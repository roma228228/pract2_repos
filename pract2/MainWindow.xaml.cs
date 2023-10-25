using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lib_14;
using System.IO;
using LibMas;

namespace pract2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnfill_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            bool f = int.TryParse(tbCount.Text, out int value);
            if (f)
            {
                for (int i = 0; i < value; i++)
                {
                    listBox.Items.Add(rnd.Next(0, 20));
                }
            }
                else MessageBox.Show("Введите правильные значения");
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сделал Николаев Роман гр. ИСП-31");
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            tbResult.Clear();
            tbCount.Clear();
        }


        private void btnGetResult_Click(object sender, RoutedEventArgs e)
        {
            int[] mas = new int[listBox.Items.Count];
            int result;
            const int MaxValue = 8;

            for (int i = 0; i < listBox.Items.Count; i++)
                mas[i] = Convert.ToInt32(listBox.Items[i]);

            result = Work.SummArray(mas, MaxValue);
            tbResult.Text = result.ToString();
        }
      
    }
}

