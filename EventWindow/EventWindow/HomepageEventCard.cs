using EventLib;
using Microsoft.Extensions.Logging;
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
    public partial class HomepageEventCard : UserControl
    {
        public HomepageEventCard()
        {
            InitializeComponent();

            btLike.Click += OnLike;
            btComments.Click += OnComment;
            btSend.Click += OnSend;
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
                lbLikes.Text = value.LikedCount.ToString();
                lbComments.Text = value.Comments.Count.ToString();
            }
        }
        private async void OnLike(object sender, EventArgs e)
        {
            string endPoint = "/api/event_like";
            btLike.Enabled = false;
            bool response = await Program.RestClient.PutAsync<EventLikes, bool>(endPoint, new EventLikes()
            {
                EventId = _event.EventId,
                UserId = Program.CurrentUser!.UserId,
            });
            if (response)
            {
                MessageBox.Show("Success! Refresh to see");
            }
            else
            {
                MessageBox.Show("Failed! Something went wrong...");
            }
            btLike.Enabled = true;
        }
        private void OnComment(object sender, EventArgs e)
        {
            string comments = "";
            foreach (EventComments comment in _event.Comments)
            {
                comments += ("User " + comment.UserId + " : " + comment.Text + "\n");
            }
            MessageBox.Show(comments);
        }
        private async void OnSend(object sender, EventArgs e)
        {
            string text = tbComment.Text;
            if (tbComment.Text == "")
            {
                MessageBox.Show("Please! Input text");
            }
            string endPoint = "/api/event_comment";
            btSend.Enabled = false;
            bool response = await Program.RestClient.PutAsync<EventComments, bool>(endPoint, new EventComments()
            {
                EventId = _event.EventId,
                UserId = Program.CurrentUser!.UserId,
                Text = text,
            });
            if (response)
            {
                MessageBox.Show("Success! Refresh to see");
                tbComment.Clear();
            }
            else
            {
                MessageBox.Show("Failed! Something went wrong...");
            }
            btSend.Enabled = true;
        }
    }
}
