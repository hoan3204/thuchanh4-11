namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxCustomerName = new TextBox();
            textBoxCustomerPhone = new TextBox();
            textBoxCustomerAddress = new TextBox();
            dataGridViewCustomers = new DataGridView();
            dataGridViewServices = new DataGridView();
            buttonAddCustomer = new Button();
            buttonEditCustomer = new Button();
            buttonDeleteCustomer = new Button();
            listBoxInvoiceItems = new ListBox();
            textBoxTotal = new TextBox();
            buttonCreateInvoice = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 15);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 55);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 95);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(142, 15);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(125, 27);
            textBoxCustomerName.TabIndex = 3;
            // 
            // textBoxCustomerPhone
            // 
            textBoxCustomerPhone.Location = new Point(141, 52);
            textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            textBoxCustomerPhone.Size = new Size(125, 27);
            textBoxCustomerPhone.TabIndex = 4;
            // 
            // textBoxCustomerAddress
            // 
            textBoxCustomerAddress.Location = new Point(141, 92);
            textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            textBoxCustomerAddress.Size = new Size(125, 27);
            textBoxCustomerAddress.TabIndex = 5;
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(29, 165);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCustomers.Size = new Size(632, 188);
            dataGridViewCustomers.TabIndex = 6;
            // 
            // dataGridViewServices
            // 
            dataGridViewServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServices.Location = new Point(29, 394);
            dataGridViewServices.Name = "dataGridViewServices";
            dataGridViewServices.RowHeadersWidth = 51;
            dataGridViewServices.Size = new Size(632, 188);
            dataGridViewServices.TabIndex = 7;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Location = new Point(317, 3);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(94, 29);
            buttonAddCustomer.TabIndex = 8;
            buttonAddCustomer.Text = "Thêm";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            buttonAddCustomer.Click += buttonAddCustomer_Click;
            // 
            // buttonEditCustomer
            // 
            buttonEditCustomer.Location = new Point(317, 50);
            buttonEditCustomer.Name = "buttonEditCustomer";
            buttonEditCustomer.Size = new Size(94, 29);
            buttonEditCustomer.TabIndex = 9;
            buttonEditCustomer.Text = "Sửa";
            buttonEditCustomer.UseVisualStyleBackColor = true;
            buttonEditCustomer.Click += buttonEditCustomer_Click;
            // 
            // buttonDeleteCustomer
            // 
            buttonDeleteCustomer.Location = new Point(317, 95);
            buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            buttonDeleteCustomer.Size = new Size(94, 29);
            buttonDeleteCustomer.TabIndex = 10;
            buttonDeleteCustomer.Text = "Xóa";
            buttonDeleteCustomer.UseVisualStyleBackColor = true;
            buttonDeleteCustomer.Click += buttonDeleteCustomer_Click;
            // 
            // listBoxInvoiceItems
            // 
            listBoxInvoiceItems.FormattingEnabled = true;
            listBoxInvoiceItems.Location = new Point(817, 165);
            listBoxInvoiceItems.Name = "listBoxInvoiceItems";
            listBoxInvoiceItems.Size = new Size(150, 104);
            listBoxInvoiceItems.TabIndex = 11;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(817, 316);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(125, 27);
            textBoxTotal.TabIndex = 12;
            // 
            // buttonCreateInvoice
            // 
            buttonCreateInvoice.Location = new Point(817, 405);
            buttonCreateInvoice.Name = "buttonCreateInvoice";
            buttonCreateInvoice.Size = new Size(121, 29);
            buttonCreateInvoice.TabIndex = 13;
            buttonCreateInvoice.Text = "Tạo Hóa Đơn";
            buttonCreateInvoice.UseVisualStyleBackColor = true;
            buttonCreateInvoice.Click += buttonCreateInvoice_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 364);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 14;
            label4.Text = "Dịch vụ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 131);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 15;
            label5.Text = "Danh sách Khách Hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(821, 287);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 16;
            label6.Text = "Tổng tiền";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 594);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(buttonCreateInvoice);
            Controls.Add(textBoxTotal);
            Controls.Add(listBoxInvoiceItems);
            Controls.Add(buttonDeleteCustomer);
            Controls.Add(buttonEditCustomer);
            Controls.Add(buttonAddCustomer);
            Controls.Add(dataGridViewServices);
            Controls.Add(dataGridViewCustomers);
            Controls.Add(textBoxCustomerAddress);
            Controls.Add(textBoxCustomerPhone);
            Controls.Add(textBoxCustomerName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxCustomerName;
        private TextBox textBoxCustomerPhone;
        private TextBox textBoxCustomerAddress;
        private DataGridView dataGridViewCustomers;
        private DataGridView dataGridViewServices;
        private Button buttonAddCustomer;
        private Button buttonEditCustomer;
        private Button buttonDeleteCustomer;
        private ListBox listBoxInvoiceItems;
        private TextBox textBoxTotal;
        private Button buttonCreateInvoice;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
