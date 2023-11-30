

using EventLib;
using EventLib.Extension;
using EventWindow.Properties;

namespace EventWindow
{
    public partial class Homepage : Form
    {
        private List<Event> events = new List<Event>();
        string? searchUsername;
        DateTime? dateTime;
        Category category = Category.None;
        public Homepage()
        {
            InitializeComponent();

            pbProfile.ImageLocation = Program.CurrentUser?.ProfilePicture ?? AppDomain.CurrentDomain.BaseDirectory + "../../../Resources/profile_holder.png";
            lbName.Text = Program.CurrentUser?.Name ?? "Unknown";
            lbPhone.Text = Program.CurrentUser?.PhoneNumber ?? "-";

            tbUsername.TextChanged += OnUsernameChanged;
            dtpDate.ValueChanged += OnDateTimeChanged;
            cbCategory.SelectedValueChanged += OnCategoryChanged;
            btClear.Click += OnClear;
            btRefresh.Click += OnRefresh;

            GetEvent();
        }
        private async void GetEvent()
        {
            string endPoint;
            if (searchUsername != null)
            {
                endPoint = $"/api/event_name?eventName={searchUsername}";
            }else if(dateTime != null)
            {
                endPoint = $"/api/event_date?dateTime={dateTime.ToString()}";
            }else if (category != Category.None)
            {
                endPoint = $"/api/event_category?category={category}";
            }
            else
            {
                endPoint = $"/api/event";
                
            }
            events = await Program.RestClient.GetAsync<List<Event>>(endPoint) ?? new List<Event>();
            flpListEvent.Controls.Clear();
            foreach (Event e in events)
            {
                HomepageEventCard card = new HomepageEventCard();
                card.InitEvent = e;
                flpListEvent.Controls.Add(card);
            }
        }
        private void OnUsernameChanged(object sender, EventArgs e)
        {
            searchUsername = tbUsername.Text;

            dtpDate.ValueChanged -= OnDateTimeChanged;
            cbCategory.SelectedValueChanged -= OnCategoryChanged;

            dtpDate.Value = DateTime.Now;
            dateTime = null;
            cbCategory.SelectedIndex = -1;
            category = Category.None;

            dtpDate.ValueChanged += OnDateTimeChanged;
            cbCategory.SelectedValueChanged += OnCategoryChanged;
        }
        private void OnDateTimeChanged(object sender, EventArgs e)
        {
            dateTime = dtpDate.Value;

            tbUsername.TextChanged -= OnUsernameChanged;
            cbCategory.SelectedValueChanged -= OnCategoryChanged;

            tbUsername.Clear();
            searchUsername = null;
            cbCategory.SelectedIndex = -1;
            category = Category.None;

            tbUsername.TextChanged += OnUsernameChanged;
            cbCategory.SelectedValueChanged += OnCategoryChanged;
        }
        private void OnCategoryChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex > 0)
            {
                category = EventExtension.intToCategory[cbCategory.SelectedIndex];
            }

            tbUsername.TextChanged -= OnUsernameChanged;
            dtpDate.ValueChanged -= OnDateTimeChanged;

            dtpDate.Value = DateTime.Now;
            dateTime = null;
            tbUsername.Clear();
            searchUsername = null;

            tbUsername.TextChanged += OnUsernameChanged;
            dtpDate.ValueChanged += OnDateTimeChanged;
        }
        private void OnClear(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            dateTime = null;
            tbUsername.Clear();
            searchUsername = null;
            cbCategory.SelectedIndex = -1;
            category = Category.None;
        }
        private void OnRefresh(object sender, EventArgs e)
        {
            GetEvent();
        }
    }
}
