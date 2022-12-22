using System;
using System.Windows.Forms;

namespace FarmLab
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void AddAnimal_Load(object sender, EventArgs e)
        {
            comboBox.SelectedIndex = 0;
            myUIntSorter = new MyUIntSorter(AGE_COLUMN_INDEX, MyUIntSorter.Mode.Ascend);
            listView.ListViewItemSorter = myUIntSorter;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                wingspanLabel.Enabled = false;
                wingspanField.Enabled = false;
                wingspanField.Text = "";
            }
            else
            {
                wingspanLabel.Enabled = true;
                wingspanField.Enabled = true;
            }
        }

        const int AGE_COLUMN_INDEX = 1;
        MyUIntSorter myUIntSorter;

        private void addButton_Click(object sender, EventArgs e)
        {
            Animal animal;

            string name = nameField.Text;

            bool ageParsed = uint.TryParse(ageField.Text, out uint age);
            bool foodAmountParsed = double.TryParse(foodField.Text, out double foodAmount) && foodAmount > 0;
            bool weightParsed = double.TryParse(weightField.Text, out double weight) && weight > 0;
            bool wingspanParsed = double.TryParse(wingspanField.Text, out double wingspan) && wingspan > 0;

            if (name == "")
                MessageBox.Show("Имя не должно быть пустым.");
            else if (!ageParsed)
                MessageBox.Show("Возраст должен быть неотрицательным целым числом.");
            else if (!foodAmountParsed)
                MessageBox.Show("Кол-во корма должно быть положительным числом с дробной частью, отделённой запятой.");
            else if (!weightParsed)
                MessageBox.Show("Вес должен быть положительным числом с дробной частью, отделённой запятой.");
            else if (!wingspanParsed && comboBox.SelectedIndex == 1)
                MessageBox.Show("Размах крыльев должен быть положительным числом с дробной частью, отделённой запятой.");
            else
            {
                ListViewItem item = new ListViewItem(nameField.Text);
                item.SubItems.Add(ageField.Text);
                item.SubItems.Add(foodField.Text);
                item.SubItems.Add(weightField.Text);

                if (comboBox.SelectedIndex == 0)
                {
                    animal = new Mammal(name, age, foodAmount, weight);
                    item.SubItems.Add("-");
                }
                else
                {
                    animal = new Bird(name, age, foodAmount, weight, wingspan);
                    item.SubItems.Add(wingspanField.Text);
                }

                item.SubItems.Add(Convert.ToString(animal.FoodRation()));
                listView.Items.Add(item);

                nameField.Text = "";
                ageField.Text = "";
                foodField.Text = "";
                weightField.Text = "";
                wingspanField.Text = "";
            }
        }

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int columnIndex = e.Column;
            if (columnIndex == AGE_COLUMN_INDEX)
            {
                if (myUIntSorter.SortingMode == MyUIntSorter.Mode.Ascend)
                {
                    myUIntSorter.SortingMode = MyUIntSorter.Mode.Descend;
                }
                else
                {
                    myUIntSorter.SortingMode = MyUIntSorter.Mode.Ascend;
                }
                listView.Sort();
                Console.WriteLine($"Sorting at column {columnIndex}");
            }
        }
    }
}
