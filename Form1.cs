namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        
        private List<Customer> customers = new List<Customer>();
        private List<Service> services = new List<Service>
        {
            new Service { ServiceId = 1, ServiceName = "Thay dầu", Price = 100000 },
            new Service { ServiceId = 2, ServiceName = "Rửa xe", Price = 200000 },
            new Service { ServiceId = 3, ServiceName = "Sửa xe", Price = 150000 }
        };

        private List<Service> selectedServices = new List<Service>();

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridViews();
            LoadServices();
        }

        private void InitializeDataGridViews()
        {
            // Khách hàng DataGridView
            dataGridViewCustomers.Columns.Add("CustomerId", "Mã khách hàng");
            dataGridViewCustomers.Columns.Add("CustomerName", "Tên");
            dataGridViewCustomers.Columns.Add("Phone", "Số điện thoại");
            dataGridViewCustomers.Columns.Add("Address", "Địa chỉ");

            // Dịch vụ DataGridView
            dataGridViewServices.Columns.Add("ServiceId", "Mã dịch vụ");
            dataGridViewServices.Columns.Add("ServiceName", "Tên dịch vụ");
            dataGridViewServices.Columns.Add("Price", "Giá tiền");
        }

        private void LoadServices()
        {
            foreach (var service in services)
            {
                dataGridViewServices.Rows.Add(service.ServiceId, service.ServiceName, service.Price);
            }
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                CustomerId = customers.Count + 1,
                CustomerName = textBoxCustomerName.Text,
                Phone = textBoxCustomerPhone.Text,
                Address = textBoxCustomerAddress.Text
            };

            customers.Add(customer);
            dataGridViewCustomers.Rows.Add(customer.CustomerId, customer.CustomerName, customer.Phone, customer.Address);
            ClearCustomerFields();
        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                var row = dataGridViewCustomers.SelectedRows[0];
                var customerId = (int)row.Cells["CustomerId"].Value;
                var customer = customers.First(c => c.CustomerId == customerId);

                customer.CustomerName = textBoxCustomerName.Text;
                customer.Phone = textBoxCustomerPhone.Text;
                customer.Address = textBoxCustomerAddress.Text;

                row.Cells["CustomerName"].Value = customer.CustomerName;
                row.Cells["Phone"].Value = customer.Phone;
                row.Cells["Address"].Value = customer.Address;
                ClearCustomerFields();
            }
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                var row = dataGridViewCustomers.SelectedRows[0];
                var customerId = (int)row.Cells["CustomerId"].Value;
                customers.RemoveAll(c => c.CustomerId == customerId);
                dataGridViewCustomers.Rows.Remove(row);
            }
        }

        private void buttonCreateInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridViewServices.SelectedRows.Count > 0)
            {
                var row = dataGridViewServices.SelectedRows[0];
                var serviceId = (int)row.Cells["ServiceId"].Value;
                var service = services.First(s => s.ServiceId == serviceId);

                selectedServices.Add(service);
                listBoxInvoiceItems.Items.Add(service.ServiceName + " - " + service.Price + " VNĐ");
                UpdateTotal();
            }
        }

        private void UpdateTotal()
        {
            var total = selectedServices.Sum(s => s.Price);
            textBoxTotal.Text = total.ToString("N0");
        }

        private void ClearCustomerFields()
        {
            textBoxCustomerName.Clear();
            textBoxCustomerPhone.Clear();
            textBoxCustomerAddress.Clear();
        }
    }
}
