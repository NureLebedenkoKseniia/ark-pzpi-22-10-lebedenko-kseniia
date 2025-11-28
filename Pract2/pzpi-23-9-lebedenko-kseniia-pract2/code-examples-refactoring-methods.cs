namespace FLOWERshop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Visible = false;
            textBox2.Visible = false;
            comboBox1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            checkedListBox1.Visible = false;
        }
        public Form2(string table)
        {
            InitializeComponent();
            textBox1.Visible = false;
            textBox2.Visible = false;
            comboBox1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            checkedListBox1.Visible = false;
            button7.Visible = false;
            void ResetDataGridView()
            {
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
            }
            if (table == "Plants")
            {
                ResetDataGridView();
                plantTableAdapter.Fill(flowerShopDataSet.Plant);
                dataGridView1.DataSource = plantBindingSource;
                label1.Text = "Plants";
                textBox1.Visible = false;
                textBox2.Visible = false;
                comboBox1.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                checkedListBox1.Visible = false;
                button7.Visible = true;
                button7.Text = "Статистика";
            }
            else if (table == "Categories")
            {
                ResetDataGridView();
                categoryTableAdapter1.Fill(flowerShopDataSet.Category);
                dataGridView1.DataSource = categoryBindingSource;
                label1.Text = "Categories";
                textBox1.Visible = false;
                textBox2.Visible = false;
                comboBox1.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                checkedListBox1.Visible = false;
                button7.Visible = false;
                button7.Text = "Статистика";
            }
            else if (table == "Materials")
            {
                ResetDataGridView();
                materialTableAdapter1.Fill(flowerShopDataSet.Material);
                dataGridView1.DataSource = materialBindingSource;
                label1.Text = "Materials";
                textBox1.Visible = false;
                textBox2.Visible = false;
                comboBox1.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                checkedListBox1.Visible = false;
                button7.Visible = false;
                button7.Text = "Статистика";
            }
            else if (table == "Plant types")
            {
                ResetDataGridView();
                plantTypeTableAdapter1.Fill(flowerShopDataSet.PlantType);
                dataGridView1.DataSource = plantTypeBindingSource;
                label1.Text = "Plant types";
                textBox1.Visible = false;
                textBox2.Visible = false;
                comboBox1.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                checkedListBox1.Visible = false;
                button7.Visible = false;
                button7.Text = "Статистика";
            }
            else if (table == "Flower colors")
            {
                ResetDataGridView();
                flowerColorTableAdapter1.Fill(flowerShopDataSet.FlowerColor);
                dataGridView1.DataSource = flowerColorBindingSource;
                label1.Text = "Flower colors";
                textBox1.Visible = false;
                textBox2.Visible = false;
                comboBox1.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                checkedListBox1.Visible = false;
                button7.Visible = false;
                button7.Text = "Статистика";
            }
            else if (table == "Suppliers")
            {
                ResetDataGridView();
                supplierTableAdapter1.Fill(flowerShopDataSet.Supplier);
                dataGridView1.DataSource = supplierBindingSource;
                label1.Text = "Suppliers";
                textBox1.Visible = false;
                textBox2.Visible = false;
                comboBox1.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                checkedListBox1.Visible = false;
                button7.Visible = true;
                button7.Text = "Сформувати звіт";
            }
            else if (table == "Supplies")
            {
                ResetDataGridView();
                supplyTableAdapter1.Fill(flowerShopDataSet.Supply);
                dataGridView1.DataSource = supplyBindingSource;
                label1.Text = "Supplies";
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox1.Visible = true;
                button4.Visible = true;
                button7.Visible = true;
                button7.Text = "Статистика";
            }
            else if (table == "Batches")
            {
                ResetDataGridView();
                batchTableAdapter1.Fill(flowerShopDataSet.Batch);
                dataGridView1.DataSource = batchBindingSource;
                label1.Text = "Batches";
                textBox1.Visible = false;
                textBox2.Visible = false;
                comboBox1.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                checkedListBox1.Visible = false;
                button7.Visible = false;
                button7.Text = "Статистика";
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.plantTableAdapter.Fill(this.flowerShopDataSet.Plant);
            this.categoryTableAdapter1.Fill(this.flowerShopDataSet.Category);
            this.batchTableAdapter1.Fill(this.flowerShopDataSet.Batch);
            this.flowerColorTableAdapter1.Fill(this.flowerShopDataSet.FlowerColor);
            this.materialTableAdapter1.Fill(this.flowerShopDataSet.Material);
            this.plantTypeTableAdapter1.Fill(this.flowerShopDataSet.PlantType);
            this.supplyTableAdapter1.Fill(this.flowerShopDataSet.Supply);
            this.supplierTableAdapter1.Fill(this.flowerShopDataSet.Supplier);
            dataGridView1.AutoGenerateColumns = true;
        }
        private void plantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = plantBindingSource;
            label1.Text = "Plants";
            textBox1.Visible = false;
            textBox2.Visible = false;
            comboBox1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            checkedListBox1.Visible = false;
            button7.Visible = true;
            button7.Text = "Статистика";
        }
        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = supplierBindingSource;
            label1.Text = "Suppliers";
            textBox1.Visible = false;
            textBox2.Visible = false;
            comboBox1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            checkedListBox1.Visible = false;
            button7.Visible = true;
            button7.Text = "Сформувати звіт";
        }
        private void suppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = supplyBindingSource;
            label1.Text = "Supplies";
            textBox1.Visible = true;
            textBox2.Visible = true;
            comboBox1.Visible = true;
            button4.Visible = true;
            button7.Visible = true;
            button7.Text = "Статистика";
        }
        private void batchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = batchBindingSource;
            label1.Text = "Batches";
            textBox1.Visible = false;
            textBox2.Visible = false;
            comboBox1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            checkedListBox1.Visible = false;
            button7.Visible = false;
            button7.Text = "Статистика";
        }
        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = categoryBindingSource;
            label1.Text = "Categories";
            textBox1.Visible = false;
            textBox2.Visible = false;
            comboBox1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            checkedListBox1.Visible = false;
            button7.Visible = false;
            button7.Text = "Статистика";
        }
        private void flowerColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = flowerColorBindingSource;
            label1.Text = "Flower colors";
            textBox1.Visible = false;
            textBox2.Visible = false;
            comboBox1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            checkedListBox1.Visible = false;
            button7.Visible = false;
            button7.Text = "Статистика";
        }
        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = materialBindingSource;
            label1.Text = "Materials";
            textBox1.Visible = false;
            textBox2.Visible = false;
            comboBox1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            checkedListBox1.Visible = false;
            button7.Visible = false;
            button7.Text = "Статистика";
        }
        private void plantTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = plantTypeBindingSource;
            label1.Text = "Plant types";
            textBox1.Visible = false;
            textBox2.Visible = false;
            comboBox1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            checkedListBox1.Visible = false;
            button7.Visible = false;
            button7.Text = "Статистика";
        }
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var anth = new Form3("Users");
            anth.Show();
            this.Close();
        }
        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var anth = new Form3("Orders");
            anth.Show();
            this.Close();
        }
        private bool edit;
        private void button1_Click(object sender, EventArgs e)
        {

            edit = false;

            if (label1.Text == "Plants")
            {
                var edt = new PlantEditor();
                edt.ShowDialog();
                plantTableAdapter.Fill(flowerShopDataSet.Plant);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Categories")
            {
                var edt = new CategoryEditor();
                edt.ShowDialog();
                categoryTableAdapter1.Fill(flowerShopDataSet.Category);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Materials")
            {
                var edt = new MaterialEditor();
                edt.ShowDialog();
                materialTableAdapter1.Fill(flowerShopDataSet.Material);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Plant types")
            {
                var edt = new PlantTypeEditor();
                edt.ShowDialog();
                plantTypeTableAdapter1.Fill(flowerShopDataSet.PlantType);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Flower colors")
            {
                var edt = new FlowerColorEditor();
                edt.ShowDialog();
                flowerColorTableAdapter1.Fill(flowerShopDataSet.FlowerColor);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Suppliers")
            {
                var edt = new SupplierEditor();
                edt.ShowDialog();
                supplierTableAdapter1.Fill(flowerShopDataSet.Supplier);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Supplies")
            {
                var edt = new SupplyEditor();
                edt.ShowDialog();
                supplyTableAdapter1.Fill(flowerShopDataSet.Supply);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Batches")
            {
                var edt = new BatchEditor();
                edt.ShowDialog();
                batchTableAdapter1.Fill(flowerShopDataSet.Batch);
                flowerShopDataSet.AcceptChanges();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            edit = true;
            if (label1.Text == "Plants")
            {
                var st = new FlowerShopDataSet.PlantDataTable();
                plantTableAdapter.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new PlantEditor(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    Convert.ToDecimal(row[4]),
                    Convert.ToInt32(row[5]),
                    Convert.ToDecimal(row[6]),
                    Convert.ToDecimal(row[7]),
                    Convert.ToDecimal(row[8]),
                    Convert.ToInt32(row[9]),
                    Convert.ToInt32(row[10]),
                    Convert.ToInt32(row[11]),
                    Convert.ToInt32(row[12])
                );
                edt.ShowDialog();
                plantTableAdapter.Fill(flowerShopDataSet.Plant);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Categories")
            {
                var st = new FlowerShopDataSet.CategoryDataTable();
                categoryTableAdapter1.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new CategoryEditor(
                    Convert.ToInt32(row[0]),
                    row[1].ToString()
                );
                edt.ShowDialog();
                categoryTableAdapter1.Fill(flowerShopDataSet.Category);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Materials")
            {
                var st = new FlowerShopDataSet.MaterialDataTable();
                materialTableAdapter1.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new MaterialEditor(
                    Convert.ToInt32(row[0]),
                    row[1].ToString()
                );
                edt.ShowDialog();
                materialTableAdapter1.Fill(flowerShopDataSet.Material);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Plant types")
            {
                var st = new FlowerShopDataSet.PlantTypeDataTable();
                plantTypeTableAdapter1.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new PlantTypeEditor(
                    Convert.ToInt32(row[0]),
                    row[1].ToString()
                );
                edt.ShowDialog();
                plantTypeTableAdapter1.Fill(flowerShopDataSet.PlantType);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Flower colors")
            {
                var st = new FlowerShopDataSet.FlowerColorDataTable();
                flowerColorTableAdapter1.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new FlowerColorEditor(
                    Convert.ToInt32(row[0]),
                    row[1].ToString()
                );
                edt.ShowDialog();
                flowerColorTableAdapter1.Fill(flowerShopDataSet.FlowerColor);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Suppliers")
            {
                var st = new FlowerShopDataSet.SupplierDataTable();
                supplierTableAdapter1.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new SupplierEditor(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    row[4].ToString(),
                    row[5].ToString(),
                    row[6].ToString()
                );
                edt.ShowDialog();
                supplierTableAdapter1.Fill(flowerShopDataSet.Supplier);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Supplies")
            {
                var st = new FlowerShopDataSet.SupplyDataTable();
                supplyTableAdapter1.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new SupplyEditor(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    Convert.ToInt32(row[2]),
                    Convert.ToDateTime(row[3]),
                    row[4] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row[4]),
                    row[5].ToString(),
                    Convert.ToInt32(row[6])
                );
                edt.ShowDialog();
                supplyTableAdapter1.Fill(flowerShopDataSet.Supply);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Batches")
            {
                var st = new FlowerShopDataSet.BatchDataTable();
                batchTableAdapter1.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new BatchEditor(
                    Convert.ToInt32(row[0]),
                    Convert.ToInt32(row[1]),
                    Convert.ToDecimal(row[2]),
                    Convert.ToInt32(row[3]),
                    Convert.ToInt32(row[4]),
                    Convert.ToInt32(row[5]),
                    Convert.ToInt32(row[6])
                );
                edt.ShowDialog();
                batchTableAdapter1.Fill(flowerShopDataSet.Batch);
                flowerShopDataSet.AcceptChanges();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Plants")
            {
                plantTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                plantTableAdapter.Fill(flowerShopDataSet.Plant);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Categories")
            {
                categoryTableAdapter1.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                categoryTableAdapter1.Fill(flowerShopDataSet.Category);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Materials")
            {
                materialTableAdapter1.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                materialTableAdapter1.Fill(flowerShopDataSet.Material);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Plant types")
            {
                plantTypeTableAdapter1.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                plantTypeTableAdapter1.Fill(flowerShopDataSet.PlantType);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Flower colors")
            {
                flowerColorTableAdapter1.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                flowerColorTableAdapter1.Fill(flowerShopDataSet.FlowerColor);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Suppliers")
            {
                supplierTableAdapter1.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                supplierTableAdapter1.Fill(flowerShopDataSet.Supplier);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Supplies")
            {
                supplyTableAdapter1.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                supplyTableAdapter1.Fill(flowerShopDataSet.Supply);
                flowerShopDataSet.AcceptChanges();
            }
            else if (label1.Text == "Batches")
            {
                batchTableAdapter1.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                batchTableAdapter1.Fill(flowerShopDataSet.Batch);
                flowerShopDataSet.AcceptChanges();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        List<int> selectedSt = new List<int>();
        List<int> selectedSp = new List<int>();
        private void button4_Click(object sender, EventArgs e)
        {
            string baseQuery = @"
    SELECT * 
    FROM Supply 
    WHERE invoice_number LIKE '%' + @search + '%'";
            List<string> conditions = new List<string>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (selectedSt.Any())
            {
                conditions.Add("supply_status IN (" + string.Join(", ", selectedSt.Select((_, i) => "@supplyStatus" + i)) + ")");
                for (int i = 0; i < selectedSt.Count; i++)
                {
                    string statusValue = "";
                    switch (selectedSt[i])
                    {
                        case 1:
                            statusValue = "Доставлено";
                            break;
                        case 2:
                            statusValue = "Очікується";
                            break;
                        case 3:
                            statusValue = "Скасовано";
                            break;
                        default:
                            throw new Exception("Невідомий статус");
                    }
                    parameters.Add(new SqlParameter("@supplyStatus" + i, statusValue));
                }

            }
            if (selectedSp.Any())
            {
                conditions.Add("supplier_id IN (" + string.Join(", ", selectedSp.Select((_, i) => "@supplierId" + i)) + ")");
                for (int i = 0; i < selectedSp.Count; i++)
                {
                    parameters.Add(new SqlParameter("@supplierId" + i, selectedSp[i]));
                }
            }
            if (conditions.Any())
            {
                baseQuery += " AND " + string.Join(" AND ", conditions);
            }
            using (SqlConnection conn = new SqlConnection("Server=KSENIYA-PC59;Database=FlowerShop;Trusted_Connection=True;"))
            {
                SqlCommand command = new SqlCommand(baseQuery, conn);
                command.Parameters.AddWithValue("@search", textBox1.Text);
                foreach (var param in parameters)
                {
                    command.Parameters.Add(param);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            selectedSt.Clear();
            selectedSp.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (checkedListBox1.CheckedItems.Contains("Статус: Доставлена"))
            {
                selectedSt.Add(1);
            }
            if (checkedListBox1.CheckedItems.Contains("Очікується"))
            {
                selectedSt.Add(2);
            }
            if (checkedListBox1.CheckedItems.Contains("Скасована"))
            {
                selectedSt.Add(3);
            }
            if (checkedListBox1.CheckedItems.Contains("Постачальник: Квітковий Рай"))
            {
                selectedSp.Add(1);
            }
            if (checkedListBox1.CheckedItems.Contains("Садове Щастя"))
            {
                selectedSp.Add(2);
            }
            button5.Visible = false;
            button6.Visible = false;
            checkedListBox1.Visible = false;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            button6.Visible = true;
            checkedListBox1.Visible = true;
            checkedListBox1.BringToFront();
            button5.BringToFront();
            button6.BringToFront();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            button6.Visible = false;
            checkedListBox1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBox1.SelectedItem.ToString();
            if (selectedOption == "За кількістю рослин (спадання)")
            {
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
            }
            else if (selectedOption == "За кількістю рослин (зростання)")
            {
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
            }
            else if (selectedOption == "За датою поставки (від старих)")
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
            }
            else if (selectedOption == "За датою поставки (від нових)")
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
            }
            else if (selectedOption == "За очікуваним терміном (від найранішого)")
            {
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
            }
            else if (selectedOption == "За очікуваним терміном (від найпізнішого)")
            {
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Plants")
            {
                var plantsStat = new PlantsStatistic();
                plantsStat.ShowDialog();
            }
            else if (label1.Text == "Supplies")
            {
                var suplsStat = new SuppliesStatistic();
                suplsStat.ShowDialog();
            }
            else if (label1.Text == "Suppliers")
            {
                int selectedSupplierId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string selectedSupplierName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                GenerateSupplyReport(selectedSupplierId, selectedSupplierName);
            }
        }

        private void GenerateSupplyReport(int supplierId, string supplierName)
        {
            string connectionString = "Server=KSENIYA-PC59;Database=FlowerShop;Trusted_Connection=True;";
            string query = @"
    SELECT *
    FROM 
        Supply
    WHERE 
        supplier_id = @supplierId
    ORDER BY 
        supply_date;";
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@supplierId", supplierId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show($"Немає поставок від постачальника {supplierName}.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF файли (*.pdf)|*.pdf",
                FileName = $"Звіт_поставки_{supplierName}.pdf"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fontPath = @"C:\Windows\Fonts\arial.ttf"; 
                    PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H, PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);
                    using (PdfWriter writer = new PdfWriter(saveFileDialog.FileName))
                    using (PdfDocument pdf = new PdfDocument(writer))
                    using (Document document = new Document(pdf))
                    {
                        document.SetFont(font);
                        document.Add(new Paragraph($"Звіт про поставки від постачальника: {supplierName}")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(18));
                        document.Add(new Paragraph($"Дата формування: {DateTime.Now.ToString("dd.MM.yyyy HH:mm")}")
                            .SetTextAlignment(TextAlignment.RIGHT)
                            .SetFontSize(10));
                        Table table = new Table(new float[] { 1, 2, 3, 4, 5, 6, 7 })
                            .UseAllAvailableWidth();
                        table.AddHeaderCell(new Cell().Add(new Paragraph("ID поставки").SetFont(font)));
                        table.AddHeaderCell(new Cell().Add(new Paragraph("№ накладної").SetFont(font)));
                        table.AddHeaderCell(new Cell().Add(new Paragraph("Кількість товару").SetFont(font)));
                        table.AddHeaderCell(new Cell().Add(new Paragraph("Дата оформлення").SetFont(font)));
                        table.AddHeaderCell(new Cell().Add(new Paragraph("Дата доставки").SetFont(font)));
                        table.AddHeaderCell(new Cell().Add(new Paragraph("Статус поставки").SetFont(font)));
                        table.AddHeaderCell(new Cell().Add(new Paragraph("ID постачальника").SetFont(font)));
                        foreach (DataRow row in dataTable.Rows)
                        {
                            table.AddCell(new Cell().Add(new Paragraph(row[0].ToString()).SetFont(font)));
                            table.AddCell(new Cell().Add(new Paragraph(row[1].ToString()).SetFont(font)));
                            table.AddCell(new Cell().Add(new Paragraph(row[2].ToString()).SetFont(font)));
                            table.AddCell(new Cell().Add(new Paragraph(Convert.ToDateTime(row[3]).ToString("dd.MM.yyyy")).SetFont(font)));
                            table.AddCell(new Cell().Add(new Paragraph(Convert.ToDateTime(row[4]).ToString("dd.MM.yyyy")).SetFont(font)));
                            table.AddCell(new Cell().Add(new Paragraph(row[5].ToString()).SetFont(font)));
                            table.AddCell(new Cell().Add(new Paragraph(row[6].ToString()).SetFont(font)));
                        }
                    document.Add(table);
                        MessageBox.Show($"Звіт збережено за адресою: {saveFileDialog.FileName}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка під час створення звіту: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
