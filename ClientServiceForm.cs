using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalon
{
    public partial class ClientServiceForm : Form
    {
        BeautySalonEntities db = new BeautySalonEntities();

        public ClientServiceForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateTable()
        {
            DateTime dateTimeToday = DateTime.Today;
            DateTime dateTimeTomorrow = dateTimeToday.AddDays(2);           

            try
            {
                var clientServices = from clserv in db.ClientService 
                                     where clserv.StartTime >= DateTime.Today && clserv.StartTime <= dateTimeTomorrow
                                     join cl in db.Client on clserv.ClientID equals cl.ID
                                     join serv in db.Service on clserv.ServiceID equals serv.ID
                                     orderby clserv.StartTime
                                     select new
                                     {
                                         Service = serv.Title,
                                         Client = cl.LastName + " " + cl.FirstName + " " + cl.Patronymic,
                                         Email = cl.Email,
                                         Phone = cl.Phone,
                                         StartTime = clserv.StartTime,        
                                     };
               
                tableClientService.DataSource = clientServices.ToList();
                tableClientService.Columns[0].HeaderText = "Наименование";
                tableClientService.Columns[1].HeaderText = "ФИО клиента";
                tableClientService.Columns[2].HeaderText = "Email";
                tableClientService.Columns[3].HeaderText = "Номер телефона";
                tableClientService.Columns[4].HeaderText = "Дата и время записи";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void ClientServiceForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
