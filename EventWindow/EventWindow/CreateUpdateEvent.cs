using EventLib;
using EventLib.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventWindow
{
    public partial class CreateUpdateEvent : Form
    {
        private bool _isCreate = true;
        private Event? _initEvent;
        public CreateUpdateEvent(bool isCreate, Event? initEvent)
        {
            InitializeComponent();
            this.Closing += Window_Closing;
            _isCreate = isCreate;
            _initEvent = initEvent;
            if (_isCreate == false && _initEvent != null)
            {
                lbTitle.Text = "Update Event";
                SetPictureBox();
                tbName.Text = _initEvent.EventName;
                dtpStartDate.Value = _initEvent.StartDate;
                dtpStartTime.Value = _initEvent.StartDate;
                dtpEndDate.Value = _initEvent.EndDate;
                dtpEndTime.Value = _initEvent.EndDate;
                cbCategory.SelectedIndex = EventExtension.categoryToInt[_initEvent.CategoryNum];
                tbLocation.Text = _initEvent.Location;
            }
            else
            {
                lbTitle.Text = "Create Event";
            }
            btChangeLogo.Click += OnChangeProfile;
            btRemoveLogo.Click += OnRemoveProfile;
            btSave.Click += OnSave;
        }

        private void OnChangeProfile(object sender, EventArgs e)
        {
            if (ofdEventLogo.ShowDialog() == DialogResult.OK)
            {
                pbLogo.ImageLocation = ofdEventLogo.FileName;
            }
        }
        private void OnRemoveProfile(object sender, EventArgs e)
        {
            pbLogo.Image = Properties.Resources.profile_holder;
            ofdEventLogo.FileName = "";
        }
        private void SetPictureBox()
        {
            if (_initEvent?.EventLogo != null && _initEvent.EventLogo != "")
            {
                string imagePath = Program.AppDirectory + "EventImage/" + _initEvent.EventLogo;
                if (File.Exists(imagePath))
                {
                    pbLogo.ImageLocation = imagePath;
                    ofdEventLogo.FileName = imagePath;
                    return;
                }
            }
            pbLogo.Image = Properties.Resources.profile_holder;
            ofdEventLogo.FileName = "";
        }
        private async void OnSave(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("Please input event's name...!!");
                return;
            }
            string location = tbLocation.Text.Trim();
            if (location == "")
            {
                MessageBox.Show("Please input event's location...!!");
                return;
            }
            Disable();
            string endPoint = _isCreate ? "/api/create_event" : "/api/update_event";
            string? oldProfileName = _isCreate ? null : _initEvent?.EventLogo;
            string logoImageName;
            if (ofdEventLogo.FileName == "")
            {
                logoImageName = "";
            }
            else if (Path.GetFileName(ofdEventLogo.FileName) != oldProfileName)
            {
                logoImageName = Program.UploadImage(ofdEventLogo.FileName, "EventImage");
            }
            else
            {
                logoImageName = oldProfileName;
            }
            DateTime startDate = dtpStartDate.Value.Date + dtpStartTime.Value.TimeOfDay;
            DateTime endDate = dtpEndDate.Value.Date + dtpEndTime.Value.TimeOfDay;
            Category category = EventExtension.intToCategory[cbCategory.SelectedIndex];
            Event newEvent;
            if(_isCreate)
            {
                newEvent = new Event()
                {
                    UserId = Program.CurrentUser.UserId,
                    EventLogo = logoImageName,
                    EventName = name,
                    StartDate = startDate,
                    EndDate = endDate,
                    CategoryNum = category,
                    Location = location,
                    CreateOn = DateTime.Now,
                };
            }
            else
            {
                newEvent = new Event()
                {
                    EventId = _initEvent.EventId,
                    UserId = Program.CurrentUser.UserId,
                    EventLogo = logoImageName,
                    EventName = name,
                    StartDate = startDate,
                    EndDate = endDate,
                    CategoryNum = category,
                    Location = location,
                    CreateOn = DateTime.Now,
                };
            }
            bool response = await Program.RestClient.PutAsync<Event, bool>(endPoint, newEvent);
            if (response)
            {
                if (oldProfileName != null && oldProfileName != "" && oldProfileName != Program.CurrentUser.ProfilePicture)
                {
                    Program.DeleteImage(oldProfileName, "EventImage");
                }
                MessageBox.Show("Successed!!! Your profile Had been updated...");
                MyEvents myEvents = new MyEvents();
                myEvents.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failded!!! You could not update your profile...");
            }
            Enable();
        }
        void ClearData()
        {
            pbLogo.Image = Properties.Resources.image_holder;
            ofdEventLogo.FileName = "";
            tbName.Clear();
            dtpStartDate.Value = DateTime.Now;
            dtpEndTime.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            dtpEndTime.Value = DateTime.Now;
            cbCategory.SelectedIndex = 0;
        }
        void Enable()
        {
            btRemoveLogo.Enabled = true;
            btChangeLogo.Enabled = true;
            btSave.Enabled = true;
            tbName.Enabled = true;
            dtpStartDate.Enabled = true;
            dtpStartTime.Enabled = true;
            dtpEndDate.Enabled = true;
            dtpEndTime.Enabled = true;
            cbCategory.Enabled = true;
        }
        void Disable()
        {
            btRemoveLogo.Enabled = false;
            btChangeLogo.Enabled = false;
            btSave.Enabled = false;
            tbName.Enabled = false;
            dtpStartDate.Enabled = false;
            dtpStartTime.Enabled = false;
            dtpEndDate.Enabled = false;
            dtpEndTime.Enabled = false;
            cbCategory.Enabled = false;
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MyEvents myEvents = new MyEvents();
            myEvents.Show();
        }
    }
}
