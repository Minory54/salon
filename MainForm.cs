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
    public partial class MainForm : Form
    {

        BeautySalonEntities db = new BeautySalonEntities();
        public MainForm()
        {
            InitializeComponent();
            BtnState.mainForm = this;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataBank.btnState = false;
            UpdateBtn();
            UpdateTable();
        }

        public void UpdateTable()
        {
            if (cmbSort.SelectedIndex == -1)
                cmbSort.SelectedIndex = 0;
            if (cmbFilter.SelectedIndex == -1)
                cmbFilter.SelectedIndex = 0;
            List<Service> services = new List<Service>();

            foreach (Service service in db.Service.ToList())
            {
                services.Add(service);
            }
            services = SortTable(services);
            tableService.DataSource = services;
            tableService.Columns[0].Visible = false;
            tableService.Columns[1].HeaderText = "Наименование";
            tableService.Columns[2].HeaderText = "Стоимость";
            tableService.Columns[3].HeaderText = "Длительность (сек.)";
            tableService.Columns[4].Visible = false;
            tableService.Columns[5].HeaderText = "Размер скидки";
            tableService.Columns[6].HeaderText = "Изображение";          
            tableService.Columns[7].Visible = false;
            tableService.Columns[8].Visible = false;
            txtTotalCount.Text = Convert.ToString(tableService.RowCount) + " записей";
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            CodeForm codeForm = new CodeForm();
            codeForm.ShowDialog();

        }

        public void UpdateBtn() 
        {
            btnAddService.Visible = DataBank.btnState;
            btnEditService.Visible = DataBank.btnState;
            btnDelService.Visible = DataBank.btnState;
            btnServRegistr.Visible = DataBank.btnState;
            btnClientOnService.Visible = DataBank.btnState;
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        public List<Service> SortTable(List<Service> list)
        {
            List<Service> new_list = new List<Service>();

            if (cmbSort.SelectedIndex == 0) return list;
            if (cmbSort.SelectedIndex == 1)
                new_list = list.OrderByDescending(x => x.Cost).ToList();
            if (cmbSort.SelectedIndex == 2)
                new_list = list.OrderBy(x => x.Cost).ToList();
            return new_list;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            ServiceAddForm serviceAddForm = new ServiceAddForm();
            serviceAddForm.ShowDialog();
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            if (tableService.SelectedRows.Count > 0)
            { 
                new ServiceEditForm(Convert.ToInt32(tableService.SelectedRows[0].Cells[0].Value)).ShowDialog();
            }
            else MessageBox.Show("Выберите услугу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         
        }

        private void RemoveService() 
        {
            if (tableService.SelectedRows.Count > 0)
            {
                int service_id = Convert.ToInt32(tableService.SelectedRows[0].Cells[0].Value);
                if (!db.ClientService.Any(p => p.ServiceID == service_id))
                {
                    string message = "Вы уверены, что хотите удалить услугу?";
                    string caption = "";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        Service service = db.Service.Where(p => p.ID == service_id).FirstOrDefault();
                        db.Service.Remove(service);
                        db.SaveChanges();
                        MessageBox.Show("Услуга успешно удалена!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateTable();
                    }
                }
                else MessageBox.Show("Вы не можете удалить этого клиента, так как он связан с таблицей ClientService!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Выберите услугу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelService_Click(object sender, EventArgs e)
        {
            RemoveService();
        }

        private void btnClientOnService_Click(object sender, EventArgs e)
        {
            if (tableService.SelectedRows.Count > 0)
            {
                new ClientRegister(Convert.ToInt32(tableService.SelectedRows[0].Cells[0].Value)).ShowDialog();
            }
            else MessageBox.Show("Выберите услугу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnServRegistr_Click(object sender, EventArgs e)
        {
            ClientServiceForm clientServiceForm = new ClientServiceForm();
            clientServiceForm.Show();
        }
    }
}
