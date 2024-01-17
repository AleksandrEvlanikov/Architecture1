using Architecture10PatternRepository.Services;
using Architecture10PatternRepository.Services.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Architecture11ClinicDesctopWinForms
{
    public partial class DeleteAllClientsConfirmation : Form
    {
        private IClientRepository _clientRepository;

        public DeleteAllClientsConfirmation()
        {
            _clientRepository = new ClientRepository();
            InitializeComponent();
        }

        private void buttonDeleteYes_Click(object sender, EventArgs e)
        {
            _clientRepository.DeleteAll();
            Close();
            timer10sec.Start();
            FormSixYouReFired form6 = new FormSixYouReFired();
            form6.Size = new System.Drawing.Size(895, 505);
            form6.StartPosition = FormStartPosition.CenterScreen;

            form6.Show();
        }

        private void buttonDeleteNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer10sec_Tick(object sender, EventArgs e)
        {
            timer10sec.Stop();

            Application.Exit();
        }
    }
}
