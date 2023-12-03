using EventLib;
using RestClientLib;
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
    public partial class MyEventCard : UserControl
    {
        MyEvents _myEvents;
        public MyEventCard(MyEvents myEvents)
        {
            InitializeComponent();
            btUpdate.Click += OnUpdate;
            btDelete.Click += OnDelete;
            _myEvents = myEvents;
        }
        private void OnUpdate(object sender, EventArgs e)
        {
            CreateUpdateEvent createUpdateEvent = new CreateUpdateEvent(false, _event);
            createUpdateEvent.Show();
            _myEvents.Hide();
        }
        private async void OnDelete(object sender, EventArgs e)
        {
            string endPoint = "/api/delete_event?eventId=" + _event.EventId;
            bool response = await Program.RestClient.DeleteAsync<bool>(endPoint);
            if (response)
            {
                MessageBox.Show("Successed! An event had been deleted...");
            }
            else
            {
                MessageBox.Show("Failed! You could not delete this event...");
            }
        }
        private Event _event = default!;
        public Event InitEvent
        {
            get { return _event; }
            set
            {
                _event = value;
                pbLogo.ImageLocation = value.EventLogo == null || value.EventLogo == "" ? null : Program.AppDirectory + "EventImage/" + value.EventLogo;
                lbTitle.Text = value.EventName;
                lbDate.Text = value.StartDate.ToShortDateString() == value.EndDate.ToShortDateString() ? "Date : " + value.StartDate.ToString("dddd, dd MMMM yyyy") + " \nTime : " + value.StartDate.ToString("HH:mm tt") + " - " + value.EndDate.ToString("HH:mm tt") : "Start Date : " + value.StartDate.ToString("dddd, dd MMMM yyyy HH:mm tt") + "\n" + "End Date : " + value.EndDate.ToString("dddd, dd MMMM yyyy HH:mm tt");
                lbLocation.Text = value.Location;
            }
        }
    }
}
