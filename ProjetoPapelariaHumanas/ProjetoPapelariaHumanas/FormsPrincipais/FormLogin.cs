using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoPapelariaHumanas
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void bt_entrar_Click(object sender, EventArgs e)
        {
            ProgressBar1.Value = 0;
            

            if (box_usuario.Text == "humanas" && box_senha.Text == "adm")
            {
                //CARREGAR PREGRESSBAR
                ProgressBar1.Value = 100;
                Thread.Sleep(900);

                //MOSTRAR FORMULARIO PRINCIPAL
                Form1 f1 = new Form1();
                f1.Show();

                //ESVAZIAR PROGRESSBAR
                ProgressBar1.Value = 0;

                //ESVAZIAR AS TEXTBOX
                box_usuario.Clear();
                box_senha.Clear();

                
            }
            else
            {
                    MessageBox.Show("Usuario ou Senha Incorreto", "Sistema Papelaria humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            


        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_data.Text = DateTime.Now.ToLongDateString();
            lb_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void check_mostrar_senha_CheckedChanged(object sender, EventArgs e)
        {
            if (check_mostrar_senha.Checked == true)
            {
                box_senha.UseSystemPasswordChar = false;


            }
            else
            {
                box_senha.UseSystemPasswordChar = true;

            }



        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é a tela de login, a tela onde o usuario tera o primeiro contato com o sistema. para acessar o sistema digite um usuario e uma senha valida", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
        }
    }
}
