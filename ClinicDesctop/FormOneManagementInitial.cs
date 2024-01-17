using Architecture11ClinicDesctopWinForms;
using ClinicService.Data;

namespace ClinicDesctop
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonLoadCl_Click(object sender, EventArgs e)
        {
            ClinicServiceClient clinicClient = new ClinicServiceClient("http://localhost:5294/", new HttpClient());
            List<Client> clients = clinicClient.ClientGetAllAsync().Result.ToList();

            listView1.Items.Clear();

            foreach (Client client in clients)
            {

                ListViewItem item = new ListViewItem();
                item.Text = client.ClientId.ToString();

                ListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem();
                subItem1.Text = client.SurName;
                item.SubItems.Add(subItem1);

                ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem();
                subItem2.Text = client.FirstName;
                item.SubItems.Add(subItem2);

                ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem();
                subItem3.Text = client.Patronymic;
                item.SubItems.Add(subItem3);

                ListViewItem.ListViewSubItem subItem4 = new ListViewItem.ListViewSubItem();
                subItem4.Text = client.Document;
                item.SubItems.Add(subItem4);

                ListViewItem.ListViewSubItem subItem5 = new ListViewItem.ListViewSubItem();
                DateTimeOffset birthday = client.Birthday;
                subItem5.Text = birthday.ToString();
                item.SubItems.Add(subItem5);

                listView1.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DataClients form2 = new DataClients();
            form2.Size = new System.Drawing.Size(650, 300);
            form2.StartPosition = FormStartPosition.CenterScreen;

            form2.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteOneClients form3 = new DeleteOneClients();
            form3.Size = new System.Drawing.Size(350, 240);
            form3.StartPosition = FormStartPosition.CenterScreen;

            form3.Show();
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            DeleteAllClients form3 = new DeleteAllClients();
            form3.Size = new System.Drawing.Size(350, 240);
            form3.StartPosition = FormStartPosition.CenterScreen;

            form3.Show();
        }
    }
}
