namespace Lab05
{
    public partial class Form1 : Form
    {
        private int rowIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void addItem(String item)
        {
            Boolean check = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value == null)
                {
                    check = true;

                    break;
                }
                else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == item)
                {
                    int a = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString());

                    a++;

                    dataGridView1.Rows[i].Cells[1].Value = a;
                    break;
                }

                if (dataGridView1.Rows[i].Cells[0].Value.ToString() != item)
                {
                    check = false;
                }
            }

            if (check)
            {
                dataGridView1.Rows.Add(item, 1);
            }
        }

        private void removeItem(String item)
        {
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "1")
                {
                    dataGridView1.Rows.RemoveAt(i);

                    break;
                } else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == item)
                {
                    int a = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString());

                    a--;

                    dataGridView1.Rows[i].Cells[1].Value = a;

                    break;
                } 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String item = button1.Text;

            addItem(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String item = button2.Text;

            addItem(item);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String item = button8.Text;

            addItem(item);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String item = button6.Text;

            addItem(item);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String item = button12.Text;

            addItem(item);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String item = button18.Text;

            addItem(item);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            String item = button16.Text;

            addItem(item);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            String item = button14.Text;

            addItem(item);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String item = button3.Text;

            addItem(item);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String item = button4.Text;

            addItem(item);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String item = button7.Text;

            addItem(item);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String item = button5.Text;

            addItem(item);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String item = button11.Text;

            addItem(item);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String item = button9.Text;

            addItem(item);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            String item = button13.Text;

            addItem(item);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            List<Object> list = new List<object>();

            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                list.Add(dataGridView1.Rows[i].Cells[0].Value);
            }


            MessageBox.Show("AA", "NOTIFICATION", MessageBoxButtons.OK);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            String item = null;

            try
            {
                item = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

                removeItem(item);

            } catch (Exception er)
            {
                er.ToString();
            }

            if (item == null)
            {
                MessageBox.Show("You have nothing to delete", "WARNING", MessageBoxButtons.OK);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = Convert.ToInt32(e.RowIndex.ToString());
        }
    }
}