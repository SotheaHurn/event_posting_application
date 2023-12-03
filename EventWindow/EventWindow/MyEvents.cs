using EventLib;
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
    public partial class MyEvents : Form
    {
        private List<Event> events = new List<Event>();
        public MyEvents()
        {
            InitializeComponent();
            this.Closing += Window_Closing;
            btCreate.Click += OnCreate;
            btRefresh.Click += OnRefresh;
            GetMyEvent();
        }
        public async void GetMyEvent()
        {
            string endPoint = $"/api/event_user_id?userId={Program.CurrentUser?.UserId}";

            events = await Program.RestClient.GetAsync<List<Event>>(endPoint) ?? new List<Event>();
            flpListEvent.Controls.Clear();
            foreach (Event e in events)
            {
                MyEventCard card = new MyEventCard(this);
                card.InitEvent = e;
                flpListEvent.Controls.Add(card);
            }
        }
        private void OnCreate(object sender, EventArgs e)
        {
            CreateUpdateEvent createUpdateEvent = new CreateUpdateEvent(true, null);
            createUpdateEvent.Show();
            this.Hide();
        }
        private void OnRefresh(object sender, EventArgs e)
        {
            GetMyEvent();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
        }
    }
}
