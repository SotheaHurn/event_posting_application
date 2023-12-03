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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EventWindow
{
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
            this.Closing += Window_Closing;
            ofdProfile.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            ofdProfile.AddExtension = true;

            SetPictureBox();
            tbName.Text = Program.CurrentUser?.Name;
            tbPhoneNumber.Text = Program.CurrentUser?.PhoneNumber;
            tbAddress.Text = Program.CurrentUser?.Address;

            btChangeProfile.Click += OnChangeProfile;
            btRemoveProfile.Click += OnRemoveProfile;
            btUpdate.Click += OnUpdate;
            btCancel.Click += OnCancel;
        }
        private void OnChangeProfile(object sender, EventArgs e)
        {
            if (ofdProfile.ShowDialog() == DialogResult.OK)
            {
                pbProfile.ImageLocation = ofdProfile.FileName;
            }
        }
        private void OnRemoveProfile(object sender, EventArgs e)
        {
            pbProfile.Image = Properties.Resources.profile_holder;
            ofdProfile.FileName = "";
        }
        private async void OnUpdate(object sender, EventArgs e)
        {
            Disable();
            string endPoint = "/api/update_profile";
            string? oldProfileName = Program.CurrentUser?.ProfilePicture;
            string profileImageName;
            if (ofdProfile.FileName == "")
            {
                profileImageName = "";
            }
            else if(Path.GetFileName(ofdProfile.FileName) != oldProfileName)
            {
                profileImageName = Program.UploadImage(ofdProfile.FileName, "ProfileImage");
            }
            else
            {
                profileImageName = oldProfileName;
            }
            string? name = tbName.Text.Trim() == "" ? null : tbName.Text.Trim();
            string? phoneNumber = tbPhoneNumber.Text.Trim() == "" ? null : tbPhoneNumber.Text.Trim();
            string? address = tbAddress.Text.Trim() == "" ? null : tbAddress.Text.Trim();
            User newUser = new User()
            {
                UserId = Program.CurrentUser!.UserId,
                Username = Program.CurrentUser.Username,
                Password = Program.CurrentUser.Password,
                Name = name,
                ProfilePicture = profileImageName==""?null: profileImageName,
                PhoneNumber = phoneNumber,
                Address = address,
            };
            User? response = await Program.RestClient.PutAsync<User, User?>(endPoint, newUser);
            if (response != null)
            {
                Program.CurrentUser = response;
                SetPictureBox();
                if (oldProfileName != null && oldProfileName != "" && oldProfileName != Program.CurrentUser.ProfilePicture)
                {
                    Program.DeleteImage(oldProfileName, "ProfileImage");
                }
                MessageBox.Show("Successed!!! Your profile Had been updated...");
                Close();
                Homepage homepage = new Homepage();
                homepage.Show();
            }
            else
            {
                MessageBox.Show("Failded!!! You could not update your profile...");
            }
            Enable();
        }
        private void OnCancel(object sender, EventArgs e)
        {
            Close(); 
            Homepage homepage = new Homepage();
            homepage.Show();
        }
        private void Enable()
        {
            btChangeProfile.Enabled = true;
            btRemoveProfile.Enabled = true;
            btUpdate.Enabled = true;
            btCancel.Enabled = true;
            tbName.Enabled = true;
            tbAddress.Enabled = true;
            tbPhoneNumber.Enabled = true;
        }
        private void Disable()
        {
            btChangeProfile.Enabled = false;
            btRemoveProfile.Enabled = false;
            btUpdate.Enabled = false;
            btCancel.Enabled = false;
            tbName.Enabled = false;
            tbAddress.Enabled = false;
            tbPhoneNumber.Enabled = false;
        }
        private void SetPictureBox()
        {
            if (Program.CurrentUser?.ProfilePicture !=null && Program.CurrentUser.ProfilePicture != "")
            {
                string imagePath = Program.AppDirectory + "ProfileImage/" + Program.CurrentUser?.ProfilePicture;
                if (File.Exists(imagePath)){
                    pbProfile.ImageLocation = imagePath;
                    ofdProfile.FileName = imagePath;
                    return;
                }
            }
            pbProfile.Image = Properties.Resources.profile_holder;
            ofdProfile.FileName = "";
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
        }
    }
}
