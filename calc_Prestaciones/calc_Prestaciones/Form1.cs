using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_Prestaciones
{
    public partial class Form1 : Form
    {
        double sueldo = 0;
        double sueldoh = 0;
        double preaviso = 0;
        double cesantia = 0;
        double regalia = 0;
        double vacaciones = 0;
        double pagoPrestaciones  = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lista.Items.Add(txtsueldo.Text);
            button4.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtnombre.Text == "" || txtsueldo.Text == "" || txtmesestrabajados.Text == "" || txtcedula.Text == "")
            {
                MessageBox.Show("Favor completar todos los campos para proceder a calcular");
            }
            else
            {

            string mesesc = this.txtmesestrabajados.Text;
            int meses = int.Parse(mesesc);

            // Llenando la Lista con los sueldos
            for (int i = 0; i < lista.Items.Count; i++)
            {
                //suma = lista.Items.Count + suma;
                sueldo = sueldo + double.Parse(lista.Items[i].ToString());

            }
  
            //convercion sueldo total acumulado a sueldo por hora
            sueldoh = sueldo / 12 / 23.83;

            // checkBox Preaviso
            if (cbpreaviso.Checked == true)
            {
                if (meses >= 3 && meses <= 5)
                {
                    preaviso = sueldoh * 7;

                }
                else if (meses >= 6 && meses <= 11)
                {
                    preaviso = sueldoh * 14;
                }
                else if (meses >= 12 )
                {
                    preaviso = sueldoh * 28;
                }

            }else
                {
                    preaviso = 0;
                }
            // checkBox Cesantia
            if (cbcesantia.Checked == true)
            {
                if (meses >= 3 && meses <= 5)
                {
                    cesantia = sueldoh * 6;

                }
                else if (meses >= 6 && meses <= 11)
                {
                    cesantia = sueldoh * 13;
                }
                else if (meses >= 12 && meses <= 59)
                {
                    cesantia = sueldoh * 21;
                }
                else
                {
                    cesantia = sueldoh * 23;
                }

            } else
                {
                    cesantia = 0;
                }

            // checkBox Regalia 
            if (cbsalarionavidad.Checked == true)
            {
                regalia = sueldo / 12;
                //MessageBox.Show(regalia.ToString());
            } else
                {
                    regalia = 0;
                }

            if (cbvacaciones.Checked == true && meses >= 5)
                {
                    if (meses <= 5)
                    {
                        vacaciones = sueldoh * 6;

                    } else if (meses == 6)
                    {
                        vacaciones = sueldoh * 7;

                    } else if (meses == 7)
                    {
                        vacaciones = sueldoh * 8;

                    } else if (meses == 8)
                    {
                        vacaciones = sueldoh * 9;

                    } else if (meses == 9) 
                    {
                        vacaciones = sueldoh * 10;

                    } else if (meses == 10)
                    {
                        vacaciones = sueldoh * 11;

                    } else if (meses == 11)
                    {
                        vacaciones = sueldoh * 12;

                    } else if (meses >= 12 && meses <= 59)
                    {
                        vacaciones = sueldoh * 14;

                    } else
                    {
                        vacaciones = sueldoh * 18;
                    }
                } else
                {
                    vacaciones = 0;
                }

                pagoPrestaciones = preaviso + regalia + cesantia + vacaciones;

               

                
                //Creando Objeto del Formulario 2 para mostrar datos
                muestraDatos formulario2 = new muestraDatos();

                //Enviando los datos a los respectios TextBox
                formulario2.txtcesantiaf2.Text = cesantia.ToString("0,00");
                formulario2.txtpreavisof2.Text = preaviso.ToString("0,00");
                formulario2.txtregaliaf2.Text = regalia.ToString("0,00");
                formulario2.txtsueldoxhoraf2.Text = sueldoh.ToString("0,00");
                formulario2.txtvacacionesf2.Text = vacaciones.ToString("0,00");
                formulario2.txtcalculototalf2.Text = pagoPrestaciones.ToString("0,00");

                
                formulario2.Show();

                // Limpiando los Campos del Formulario

                //txtcedula.Clear();
                //txtmesestrabajados.Clear();
                //txtnombre.Clear();

                txtsueldo.Clear();
                lista.ClearSelected();
                cbcesantia.Checked = false;
                cbpreaviso.Checked = false;
                cbsalarionavidad.Checked = false;
                cbvacaciones.Checked = false;
                lista.Items.Clear();
                button4.Hide();

                 sueldo = 0;
                 sueldoh = 0;
                 preaviso = 0;
                 cesantia = 0;
                 regalia = 0;
                 vacaciones = 0;
                 pagoPrestaciones = 0;
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 12; i++)
            {
                lista.Items.Add(txtsueldo.Text);
            }
                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtcedula.Clear();
            txtmesestrabajados.Clear();
            txtnombre.Clear();
            txtsueldo.Clear();
            lista.ClearSelected();
            cbcesantia.Checked = false;
            cbpreaviso.Checked = false;
            cbsalarionavidad.Checked = false;
            cbvacaciones.Checked = false;
            lista.Items.Clear();

        }
    }
}
