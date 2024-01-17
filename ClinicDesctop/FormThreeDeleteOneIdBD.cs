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
    public partial class DeleteOneClients : Form
    {
        private IClientRepository _clientRepository;

        public DeleteOneClients()
        {
            _clientRepository = new ClientRepository();
            InitializeComponent();
        }

        private void buttonDeletOneIdClient_Click(object sender, EventArgs e)
        {
            var inputForma = textBoxDeleteId.Text;
            
            int idDelete = int.Parse(inputForma);

            _clientRepository.Delete(idDelete);
            Close();

        }
    }
}
