using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolovovLopushok
{
    public partial class UpdateForm : Form
    {
        MainForm form;
        public UpdateForm(MainForm form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataBase db = new DataBase())
                {
                    db.ExecuteNonQuery($"update product set MinCostForAgent = {double.Parse(textBox1.Text)} where '{form.products.Rows[form.page].ItemArray[2]}'");
                }
            }
            catch
            {
                MessageBox.Show("Не удалось поменять стоимость продукции");
            }
            form.SelectPageData();
            this.Close();
        }
    }
}
