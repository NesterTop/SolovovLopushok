namespace SolovovLopushok
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_min_cost_for_ag = new System.Windows.Forms.TextBox();
            this.textBox_artic_num = new System.Windows.Forms.TextBox();
            this.textBox_image_path = new System.Windows.Forms.TextBox();
            this.textBox_prod_per_count = new System.Windows.Forms.TextBox();
            this.textBox_prod_workshop_num = new System.Windows.Forms.TextBox();
            this.comboBox_product_type = new System.Windows.Forms.ComboBox();
            this.button_insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(138, 67);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(182, 20);
            this.textBox_title.TabIndex = 0;
            // 
            // textBox_min_cost_for_ag
            // 
            this.textBox_min_cost_for_ag.Location = new System.Drawing.Point(138, 119);
            this.textBox_min_cost_for_ag.Name = "textBox_min_cost_for_ag";
            this.textBox_min_cost_for_ag.Size = new System.Drawing.Size(182, 20);
            this.textBox_min_cost_for_ag.TabIndex = 1;
            // 
            // textBox_artic_num
            // 
            this.textBox_artic_num.Location = new System.Drawing.Point(138, 93);
            this.textBox_artic_num.Name = "textBox_artic_num";
            this.textBox_artic_num.Size = new System.Drawing.Size(182, 20);
            this.textBox_artic_num.TabIndex = 2;
            // 
            // textBox_image_path
            // 
            this.textBox_image_path.Location = new System.Drawing.Point(138, 145);
            this.textBox_image_path.Name = "textBox_image_path";
            this.textBox_image_path.Size = new System.Drawing.Size(182, 20);
            this.textBox_image_path.TabIndex = 3;
            // 
            // textBox_prod_per_count
            // 
            this.textBox_prod_per_count.Location = new System.Drawing.Point(138, 171);
            this.textBox_prod_per_count.Name = "textBox_prod_per_count";
            this.textBox_prod_per_count.Size = new System.Drawing.Size(182, 20);
            this.textBox_prod_per_count.TabIndex = 4;
            // 
            // textBox_prod_workshop_num
            // 
            this.textBox_prod_workshop_num.Location = new System.Drawing.Point(138, 197);
            this.textBox_prod_workshop_num.Name = "textBox_prod_workshop_num";
            this.textBox_prod_workshop_num.Size = new System.Drawing.Size(182, 20);
            this.textBox_prod_workshop_num.TabIndex = 5;
            // 
            // comboBox_product_type
            // 
            this.comboBox_product_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_product_type.FormattingEnabled = true;
            this.comboBox_product_type.Location = new System.Drawing.Point(138, 15);
            this.comboBox_product_type.Name = "comboBox_product_type";
            this.comboBox_product_type.Size = new System.Drawing.Size(183, 21);
            this.comboBox_product_type.TabIndex = 6;
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(187, 238);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(92, 39);
            this.button_insert.TabIndex = 7;
            this.button_insert.Text = "Добавить";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Тип продукта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Заголовок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Мин. цена:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Название картинки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Артикул:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Кол-во тел:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Номер цеха:";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 350);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.comboBox_product_type);
            this.Controls.Add(this.textBox_prod_workshop_num);
            this.Controls.Add(this.textBox_prod_per_count);
            this.Controls.Add(this.textBox_image_path);
            this.Controls.Add(this.textBox_artic_num);
            this.Controls.Add(this.textBox_min_cost_for_ag);
            this.Controls.Add(this.textBox_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdd";
            this.Text = "Добавления продукта";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_min_cost_for_ag;
        private System.Windows.Forms.TextBox textBox_artic_num;
        private System.Windows.Forms.TextBox textBox_image_path;
        private System.Windows.Forms.TextBox textBox_prod_per_count;
        private System.Windows.Forms.TextBox textBox_prod_workshop_num;
        private System.Windows.Forms.ComboBox comboBox_product_type;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}