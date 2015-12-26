using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace Bonus630.vsta.FacaCaixaAuto
{
    /// <summary>
    /// Interaction logic for UserControl1.Xaml
    /// </summary>
    public partial class FacaCaixaAutoUI : UserControl
    {

        FacaMan manager;
        Dictionary<string, bool> listaComboBox;
        Regex exp;
        
        public FacaCaixaAutoUI(Corel.Interop.VGCore.Application app)
        {
            InitializeComponent();
            if (FacaBase.app == null)
                FacaBase.app = app;
           
            manager = new FacaMan();
            listaComboBox = manager.ListaClass();
            comboBox1.ItemsSource = listaComboBox.Keys;
            exp = new Regex("^(?<num>[0-9]{0,}[,.]?[0-9]{0,})", RegexOptions.IgnoreCase | RegexOptions.Compiled);

            comboBox1.SelectedIndex = -1;
            #if DEBUG
                comboBox1.SelectedIndex = 2;
                textBox_Altura.Text = "500";
                textBox_Largura.Text = "168";
                textBox_Comprimento.Text = "334";
            #endif

            comboBox1_SelectionChanged(null, null);
            

            BitmapResources br = new BitmapResources();
            img_bonus.Source = br.Bonus630;

        }
        
        private void btn_ir_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Altura.Text) && !String.IsNullOrEmpty(textBox_Largura.Text) && !String.IsNullOrEmpty(textBox_Comprimento.Text))
                manager.inicialize(comboBox1.Text, new object[] { textBox_Altura.Text, textBox_Largura.Text, textBox_Comprimento.Text });
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // System.Windows.Forms.MessageBox.Show(comboBox1.SelectedItem.ToString());
            if (comboBox1.SelectedIndex == -1)
            {
                textBox_Altura.IsEnabled = false;
                textBox_Comprimento.IsEnabled = false;
                textBox_Largura.IsEnabled = false;
                btn_ir.IsEnabled = false;
            }
            else
            {
                textBox_Altura.IsEnabled = true;
                textBox_Comprimento.IsEnabled = true;
                if(!listaComboBox[comboBox1.SelectedItem.ToString()])
                    textBox_Largura.IsEnabled = true;
                else
                    textBox_Largura.IsEnabled = false;
                btn_ir.IsEnabled = true;
            }

            //if (listaComboBox.ContainsKey(comboBox1.Text))
            //    textBox_Largura.IsEnabled = !listaComboBox[comboBox1.Text];
        }

        private string checkField(string text)
        {
            Match m = exp.Match(text);
            return m.Result("$1");
        }

        private void textBox_Largura_KeyUp(object sender, KeyEventArgs e)
        {
            textBox_Largura.Text = checkField(textBox_Largura.Text);
            textBox_Largura.CaretIndex = textBox_Largura.Text.Length;
        }

        private void textBox_Comprimento_KeyUp(object sender, KeyEventArgs e)
        {
            textBox_Comprimento.Text = checkField(textBox_Comprimento.Text);
            textBox_Comprimento.CaretIndex = textBox_Comprimento.Text.Length;
        }

        private void textBox_Altura_KeyUp(object sender, KeyEventArgs e)
        {
            textBox_Altura.Text = checkField(textBox_Altura.Text);
            textBox_Altura.CaretIndex = textBox_Altura.Text.Length;
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bonus630.tk");
        }
              
    }
}
