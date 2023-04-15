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
    public partial class MainForm : Form
    {
        public int page = 0;
        public DataTable products;
        DataTable propuctType;
        DataTable productTypes;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        public bool UpdateData()
        {
            try
            {
                using (DataBase db = new DataBase())
                {
                    products = db.ExecuteSql("select * from Product");
                    propuctType = db.ExecuteSql($"select Title from ProductType where id = '{products.Rows[page].ItemArray[5].ToString()}'");
                    productTypes = db.ExecuteSql("select * from ProductType");
                }
                SelectPageData();

                return true;
            }

            catch
            {
                return false;
            }
        }

        public bool SelectPageData()
        {
            string path = @"C:\Users\solov\Desktop\Промежуточный контроль\Сессия 1\";
            string cpath = "";
            try
            {
                cpath = path + products.Rows[page].ItemArray[4].ToString();
                textBoxTitle.Text = products.Rows[page].ItemArray[1].ToString();
                textBoxCost.Text = products.Rows[page].ItemArray[3].ToString();
                textBoxProductType.Text = propuctType.Rows[0].ItemArray[0].ToString();
                pictureBox1.Image = Image.FromFile(cpath);

                return true;
            }
            catch
            {
                cpath = path + @"products\picture.png";
                pictureBox1.Image = Image.FromFile(cpath);

                return false;
            }
        }

        public bool GoPage()
        {
            try
            {
                if (page < products.Rows.Count)
                {
                    page += 1;
                    UpdateData();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            GoPage();
        }

        public bool BackPage()
        {
            try
            {
                if (page > 0)
                {
                    page -= 1;
                    UpdateData();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            BackPage();
        }

        public bool DeleteData()
        {
            try
            {
                using (DataBase db = new DataBase())
                {
                    db.ExecuteNonQuery($"delete from product where ArticleNumber = '{products.Rows[page].ItemArray[2]}'");
                }
                UpdateData();
                
                return true;
            }

            catch
            {
                return false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        public bool ShowUpdateForm()
        {
            try
            {
                new UpdateForm(this).Show();
                return true;
            }

            catch
            {
                return false;
            }
        }

        public bool ShowAddForm()
        {
            try
            {
                new FormAdd().Show();
                return true;
            }

            catch
            {
                return false;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ShowUpdateForm();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ShowAddForm();
        }
    }
}
