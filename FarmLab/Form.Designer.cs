
namespace FarmLab
{
    partial class Form
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.ageField = new System.Windows.Forms.TextBox();
            this.weightField = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.wingspanLabel = new System.Windows.Forms.Label();
            this.wingspanField = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.foodLabel = new System.Windows.Forms.Label();
            this.foodField = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.food = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wingspan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(17, 68);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(17, 103);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(75, 13);
            this.ageLabel.TabIndex = 1;
            this.ageLabel.Text = "Возраст (лет)";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(17, 173);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(46, 13);
            this.weightLabel.TabIndex = 1;
            this.weightLabel.Text = "Вес (кг)";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(129, 65);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(228, 20);
            this.nameField.TabIndex = 2;
            // 
            // ageField
            // 
            this.ageField.Location = new System.Drawing.Point(129, 100);
            this.ageField.Name = "ageField";
            this.ageField.Size = new System.Drawing.Size(228, 20);
            this.ageField.TabIndex = 2;
            // 
            // weightField
            // 
            this.weightField.Location = new System.Drawing.Point(129, 170);
            this.weightField.Name = "weightField";
            this.weightField.Size = new System.Drawing.Size(228, 20);
            this.weightField.TabIndex = 2;
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Млекопитающее",
            "Птица"});
            this.comboBox.Location = new System.Drawing.Point(129, 26);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(140, 21);
            this.comboBox.TabIndex = 3;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(129, 255);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(140, 35);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // wingspanLabel
            // 
            this.wingspanLabel.AutoSize = true;
            this.wingspanLabel.Enabled = false;
            this.wingspanLabel.Location = new System.Drawing.Point(17, 208);
            this.wingspanLabel.Name = "wingspanLabel";
            this.wingspanLabel.Size = new System.Drawing.Size(109, 13);
            this.wingspanLabel.TabIndex = 1;
            this.wingspanLabel.Text = "Размах крыльев (м)";
            // 
            // wingspanField
            // 
            this.wingspanField.Enabled = false;
            this.wingspanField.Location = new System.Drawing.Point(129, 205);
            this.wingspanField.Name = "wingspanField";
            this.wingspanField.Size = new System.Drawing.Size(228, 20);
            this.wingspanField.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wingspanField);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Controls.Add(this.nameField);
            this.groupBox1.Controls.Add(this.weightField);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.wingspanLabel);
            this.groupBox1.Controls.Add(this.foodLabel);
            this.groupBox1.Controls.Add(this.ageLabel);
            this.groupBox1.Controls.Add(this.foodField);
            this.groupBox1.Controls.Add(this.ageField);
            this.groupBox1.Controls.Add(this.weightLabel);
            this.groupBox1.Location = new System.Drawing.Point(30, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 305);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить животное";
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Location = new System.Drawing.Point(17, 138);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(96, 13);
            this.foodLabel.TabIndex = 1;
            this.foodLabel.Text = "Кол-во корма (кг)";
            // 
            // foodField
            // 
            this.foodField.Location = new System.Drawing.Point(129, 135);
            this.foodField.Name = "foodField";
            this.foodField.Size = new System.Drawing.Size(228, 20);
            this.foodField.TabIndex = 2;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.age,
            this.food,
            this.weight,
            this.wingspan,
            this.ration});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(443, 20);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(455, 305);
            this.listView.TabIndex = 9;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // name
            // 
            this.name.Text = "Имя";
            this.name.Width = 75;
            // 
            // age
            // 
            this.age.Text = "Возраст (лет)";
            this.age.Width = 75;
            // 
            // food
            // 
            this.food.Text = "Кол-во корма (кг)";
            this.food.Width = 75;
            // 
            // weight
            // 
            this.weight.Text = "Вес (кг)";
            this.weight.Width = 75;
            // 
            // wingspan
            // 
            this.wingspan.Text = "Размах крыльев (м)";
            this.wingspan.Width = 75;
            // 
            // ration
            // 
            this.ration.Text = "Питание (кг/день)";
            this.ration.Width = 75;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 348);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Ферма";
            this.Load += new System.EventHandler(this.AddAnimal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox ageField;
        private System.Windows.Forms.TextBox weightField;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label wingspanLabel;
        private System.Windows.Forms.TextBox wingspanField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader food;
        private System.Windows.Forms.ColumnHeader weight;
        private System.Windows.Forms.ColumnHeader wingspan;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.TextBox foodField;
        private System.Windows.Forms.ColumnHeader ration;
    }
}