using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace hw3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = txtBox.Text; //введённый текст
            int N1 = Regex.Matches(text, @"[\.!\?]\s([A-Z]|[А-Я])", RegexOptions.IgnoreCase).Count;
            //ищем в указанной строке заданные символы
            //options - побитовая комбинация значений перечисления, задающая параметры для сопоставления
            //ignoreCase - не учитывать регистр
            txtResult.Text = N1.ToString();
        }
    }
}
