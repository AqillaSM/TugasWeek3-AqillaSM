using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace TugasWeek3_AqillaSM
{
    public partial class FormWarna : System.Windows.Forms.Form
    {
        public FormWarna()
        {
            InitializeComponent();
        }

        private void FormWarna_Load(object sender, EventArgs e)
        {

        }

        string Kata = "";
        string CekKataIsi = "";
        string LuarKataIsi = "";
        string CekWarna = "";
        string LuarCekWarna = "";
        

        public void TBoxInput_TextChanged(object sender, EventArgs e)
        {
            Kata = TBoxInput.Text;
            Kata = Kata.ToUpper();
        }
        
        private void LabelOutput_Click(object sender, EventArgs e)
        {
           
        }
        static public Font ChangeFontSize(Font font, float fontSize)
        {
            if (font != null)
            {
                float currentSize = font.Size;
                if (currentSize != fontSize)
                {
                    font = new Font(font.Name, fontSize,
                        font.Style, font.Unit,
                        font.GdiCharSet, font.GdiVerticalFont);
                }
            }
            return font;
        }

        String Input = "";
        String Kosong = "[EMPTY]";
        String Baru = "";

        public void ButtonProses_Click(object sender, EventArgs e)
        {
            Baru = TBoxInput.Text;
            Input = TBoxInput.Text;
            Input = Input.ToUpper();
            if (Input == "RESTART")
            {
                LabelOutput.Font = ChangeFontSize(LabelOutput.Font, 12);
                LabelOutput.ForeColor = Color.Black;
                LabelOutput.Text = Kosong;
                
            }
            else if (Input == "HIDE")
            {
                LabelOutput.Hide();
            }
            else if (Input == "SHOWN")
            {
                LabelOutput.Show();
            }
            else if (Input == "BESARKAN")
            {
                LabelOutput.Font = ChangeFontSize(LabelOutput.Font, LabelOutput.Font.Size + 2);
            }
            else if (Input == "KECILKAN")
            {
                LabelOutput.Font = ChangeFontSize(LabelOutput.Font, LabelOutput.Font.Size - 2);
            }
            else if (Kata.Length > 3)
            {
                CekKataIsi = Kata.Substring(0, 4);
                LuarKataIsi = Baru.Substring(4);
                if (CekKataIsi == "ISI:")
                {
                    LabelOutput.Text = LuarKataIsi;
                }
                else if (Kata.Length > 5)
                {
                    CekWarna = Kata.Substring(0, 6);
                    LuarCekWarna = Kata.Substring(6);
                    if (CekWarna == "WARNA:")
                    {
                        if (LuarCekWarna == "DEFAULT")
                        {
                            LabelOutput.ForeColor = Color.Black;
                        }
                        else if (LuarCekWarna == "MERAH")
                        {
                            LabelOutput.ForeColor = Color.Red;
                        }
                        else if (LuarCekWarna == "HIJAU")
                        {
                            LabelOutput.ForeColor = Color.Green;
                        }
                        else if(LuarCekWarna == "BIRU")
                        {
                            LabelOutput.ForeColor = Color.Blue;
                        }
                        else
                        {
                            MessageBox.Show("WARNA TIDAK TERDAFTAR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("SYNTAX TIDAK TERDAFTAR!");
                    }
                }
                else
                {
                    MessageBox.Show("SYNTAX TIDAK TERDAFTAR!");
                }

            }    
            else
            {
                MessageBox.Show("SYNTAX TIDAK TERDAFTAR!");
            }    
        }
    }
}
