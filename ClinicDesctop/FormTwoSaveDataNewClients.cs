using Architecture10PatternRepository.Models;
using Architecture10PatternRepository.Models.Requests;
using Architecture10PatternRepository.Services;
using Architecture10PatternRepository.Services.Impl;
using Newtonsoft.Json;
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
    public partial class DataClients : Form
    {
        private IClientRepository _clientRepository;

        public DataClients()
        {
            _clientRepository = new ClientRepository();
            InitializeComponent();
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {

            string document = textBoxDocument.Text;
            string surName = textBoxSurname.Text;
            string firstName = textBoxFirstName.Text;
            string patronymic = textBoxPatronymic.Text;
            DateTime birthday = dateTimePickerBrithDay.Value;

            Client clientClinic = new Client
            {
                Document = document,
                SurName = surName,
                FirstName = firstName,
                Patronymic = patronymic,
                Birthday = birthday

            };
            _clientRepository.Create(clientClinic);
            Close();
        }
    }
}
