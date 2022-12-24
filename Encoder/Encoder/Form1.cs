using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Encoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int Number_of_letters;
        string[] Code_of_littere = {"0000000","0000001","0000010","0000011","0000100","0000101",
              "0000110","0000111","0001000","0001001","0001010","0001011","0001100","0001101","0001110",
              "0001111","0010000","0010001","0010010","0010011","0010100","0010101","0010110","0010111",
              "0011000","0011001","0011010","0011100","0011110","0011111","0100000","0100001","0100010",
              "0100011","0100100","0100101","0100110","0100111","0101000","0101001","0101010","0101011",
              "0101100","0101101","0101110","0101111","0110000","0110001","0110010","0110011","0110100",
              "0110101","0110110","0110111","0111000","0111001","0111010","0111011","0111100","0111101",
              "0111110","0111111","1000000","1000001","1000010","1000011","1000100","1000101","1000110"};
        string[] Number_of_lettere_array = {"А","Б","В","Г","Д","Е","Ж","З","И","Й","К","Л","М",
              "Н","О","П","Р","С","Т","У","Ф","Х","Ц","Ч","Ш","Щ","Ь","Ы","Ъ","Э","Ю","Я"," ",",",".","!","?",
              "а","б","в","г","д","е","ё","з","и","й","к","л","м",
              "н","о","п","р","с","т","у","ф","х","ц","ч","ш","щ","ь","ы","ъ","э","ю","я"};
        

        private void Creat_key_Click(object sender, EventArgs e)
        {
            if (Number_of_letters == 0)
            {
                MessageBox.Show("Сначало введите текст для шифрования");
            }
            else
            {
                foreach (char n in Text_input.Text)
                {
                    string Bukva = n.ToString();
                    for (int i = 0; i < Number_of_lettere_array.Length ; i++)
                    {
                        if (Bukva == Number_of_lettere_array[i])
                        {
                            Binar_code_text.Text += Code_of_littere[i];
                        }
                    }
                }
                Random rnd = new Random();int rndi;
                for (int i = 0; i < Binar_code_text.TextLength; i++)
                {
                    rndi = rnd.Next() & 1;
                    
                    Box_key.Text += Convert.ToString(rndi);

                }
               
            }
            
        }
        private void Text_for_code_Click(object sender, EventArgs e)
        {
            if (Box_key.TextLength != 0)
            {
                for (int i = 0; i<Binar_code_text.TextLength; i++)
                {
                    int a = Binar_code_text.Text[i];
                    int b = Box_key.Text[i];
                    if ((a == 48) && (b == 48))
                    {
                        Text_out.Text += 0;
                    }
                    else if ((a == 48) && (b == 49))
                    {
                        Text_out.Text += 1;
                    }
                    else if ((a == 49) && (b == 48))
                    {
                        Text_out.Text += 1;
                    }
                    else
                    {
                        Text_out.Text += 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("Сначало создайте ключ шифрования");
            }
        }
        private void Code_for_text_Click(object sender, EventArgs e)
        {
            if ((Box_key.TextLength & Text_input.TextLength) != 0)
            {
                for (int i = 0; i < Text_input.TextLength; i++)
                {
                    int a = Text_input.Text[i];
                    int b = Box_key.Text[i];
                    if ((a == 48) && (b == 48))
                    {
                        Binar_code_text.Text += 0;
                    }
                    else if ((a == 48) && (b == 49))
                    {
                        Binar_code_text.Text += 1;
                    }
                    else if ((a == 49) && (b == 48))
                    {
                        Binar_code_text.Text += 1;
                    }
                    else
                    {
                        Binar_code_text.Text += 0;
                    }
                }
                int Quantity_char = Binar_code_text.TextLength / 7;
                int Counter_char_index = 0, char_index_leght = 7, n_index = 0;
                for (int i = 0; i < Quantity_char; i++)
                {
                    n_index = 0;
                    foreach (string n in Code_of_littere)
                    {
                        if (n == Binar_code_text.Text.Substring(Counter_char_index, char_index_leght))
                        {

                            Text_out.Text += Number_of_lettere_array[n_index];
                        }
                        n_index += 1;
                    }
                    Counter_char_index += 7;
                }
            }
            else
            {
                MessageBox.Show("Сначало введите ключ шифрования и шифр");
            }
        }

        private void Del_text_original_Click(object sender, EventArgs e)
        {
            Text_input.Text = "";
            Number_of_letters = 0;
        }

        private void Del_text_code_Click(object sender, EventArgs e)
        {
            Text_out.Text = "";
            Binar_code_text.Text = "";
        }

        private void Save_code_Click(object sender, EventArgs e)
        {
            //Text_out.Text = 
        }

        private void Sistem_button_Click(object sender, EventArgs e)
        {
            this.Size= new Size(1100,500);
        }

        private void Text_input_KeyDown(object sender, KeyEventArgs e)
        {
            Number_of_letters = 1;
        }

        private void Del_key_Click(object sender, EventArgs e)
        {
            Box_key.Text = "";
            //Box_key.Text = Code_of_littere.Length.ToString();
            //Box_key.Text += Number_of_lettere_array.Length.ToString();
        }
    }
}
