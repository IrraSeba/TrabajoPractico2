using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practico2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog abrir = new OpenFileDialog();

        int a, e, i, o, u;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        String cadena;
        int cont = 0;
        int cont_palabras = 0;
        int cont_letras = 0;
        int cont_vocales = 0;
        int cont_consonantes = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        int cont_Eblancos = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            if (abrir.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

                abrir.Title = "Abrir archivo";

                textBox1.Text = abrir.FileName;
                StreamReader read = new StreamReader(File.OpenRead(abrir.FileName));

                textBox2.Text = read.ReadToEnd();
                abrir.Dispose();
                MessageBox.Show("Archivo cargado .... Acepta para continuar !");
                textBox2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog save = new SaveFileDialog();

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));

                write.Write(textBox2.Text);
                write.Dispose();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            //System.String[] = textBox2.Text;
            lblContPalabras.Text = " " + textBox2.Text.Length;
            cont_palabras++;

            lblContCaracteres.Text = "" + textBox2.Text.Length;// ok

            lblContEspBlanco.Text = "" + textBox2.Text.Length;

            lblContTabulador.Text = "" + textBox2.Text.Length;

            lblContLineas.Text = "" + textBox2.Text.Length;

            lblContVocales.Text = "" + textBox2.Text.Length;
            
            //cadena = textBox2.Text;

            //for (int x =0; x < cadena.Length; x++) {
            //    if (cadena[x] == 'a' || cadena[x] == 'A')
            //        a++;
            //    if (cadena[x] == 'e' || cadena[x] == 'E')
            //        a++;
            //    if (cadena[x] == 'i' || cadena[x] == 'I')
            //        a++;
            //    if (cadena[x] == 'o' || cadena[x] == 'O')
            //        a++;
            //    if (cadena[x] == 'u' || cadena[x] == 'U')
            //        a++;
            //    {
            //    }
            //    textBox2.Text = a.ToString();
            //    textBox2.Text = e.ToString();
            //    textBox2.Text = i.ToString();
            //    textBox2.Text = o.ToString();
            //    textBox2.Text = u.ToString();

            
            lblContConsonantes.Text = "" + textBox2.Text.Length;
        }


        
        }
    }
