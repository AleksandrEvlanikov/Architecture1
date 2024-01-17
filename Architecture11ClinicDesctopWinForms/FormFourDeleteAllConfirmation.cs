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
    public partial class DeleteAllClients : Form
    {

        public DeleteAllClients()
        {
            
            InitializeComponent();
        }

        private void buttonDeleteYes_Click(object sender, EventArgs e)
        {
            Close();
            DeleteAllClientsConfirmation form5 = new DeleteAllClientsConfirmation();
            form5.Size = new System.Drawing.Size(350, 200);
            form5.StartPosition = FormStartPosition.CenterScreen;

            form5.Show();
        }

        private void buttonDeleteNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
