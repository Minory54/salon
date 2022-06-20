using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalon
{
    public partial class ClientRegister : Form
    {

        BeautySalonEntities db = new BeautySalonEntities();
        Service service;
        int IDServ;
        DateTime date;

        public ClientRegister(int service_id)
        {
            InitializeComponent();
            IDServ = service_id;
        }

        private void btnClientRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateTime())
            {
                MessageBox.Show("Введите корректное время начала услуги!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTimeStart.Text != null || txtTimeStart.Text != "")
            {

                ClientService clienService = new ClientService
                {
                    ClientID = Convert.ToInt32(cmbClient.SelectedValue),
                    ServiceID = service.ID,
                    StartTime = date,
                };
                db.ClientService.Add(clienService);
                db.SaveChanges();
                MessageBox.Show("Запись клиента на услугу успешно добалена!", "Запись клиента", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите время начала услуги!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientRegister_Load(object sender, EventArgs e)
        {
            service = db.Service.Where(p => p.ID == IDServ).FirstOrDefault();
            txtServName.Text = service.Title;
            txtServiceDuration.Text = (service.DurationInSeconds / 60).ToString() + " мин.";

            var client = db.Client.ToList();
            cmbClient.DataSource = client;
            cmbClient.DisplayMember = "LastName";
            cmbClient.ValueMember = "ID";

        }

        public bool ValidateTime()
        {
            Regex regex = new Regex(@"^(([0,1][0-9])|(2[0-1])):[0-5][0-9]$");
            if (regex.IsMatch(txtTimeStart.Text))
            {
                return true;
            }
            else return false;
        }

        private void txtTimeStart_Leave(object sender, EventArgs e)
        {

            if (!ValidateTime()) MessageBox.Show("Введите корректное время начала услуги!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        public void TimeCheanger()
        {
            try 
            {
                var ArrStr = txtTimeStart.Text.Split(':');
                date = new DateTime(TxtDate.Value.Year, TxtDate.Value.Month, TxtDate.Value.Day, Convert.ToInt32(ArrStr[0]), Convert.ToInt32(ArrStr[1]), 0);
                var d = date.AddMinutes(service.DurationInSeconds / 60);
                txtTimeEnd.Text = d.ToShortTimeString();
            } catch { }
        }

        private void txtTimeEnd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTimeStart_TextChanged(object sender, EventArgs e)
        {
            TimeCheanger();
        }
    }
}
