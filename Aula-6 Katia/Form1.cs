using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_6_Katia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string numero = "";
        Candidato Alguem;
        Candidato[] lista = new Candidato[4];
        int branco = 0, nulo = 0;

        private void InsereCandidato()
        {
            Alguem = new Candidato();
            Alguem.Numero = 22;
            Alguem.Nome = "Bolsonaro";
            Alguem.Turma = "1-ADS";
            Alguem.Foto = "bolsonaro.jfif";
            lista[0] = Alguem;
            Alguem = new Candidato();
            Alguem.Numero = 13;
            Alguem.Nome = "Lula";
            Alguem.Turma = "1-ADS";
            Alguem.Foto = "lula.jfif";
            lista[1] = Alguem;
            Alguem = new Candidato();
            Alguem.Numero = 12;
            Alguem.Nome = "Ciro Games";
            Alguem.Turma = "1-ADS";
            Alguem.Foto = "ciro.jpg";
            lista[2] = Alguem;
            Alguem = new Candidato();
            Alguem.Numero = 30;
            Alguem.Nome = "Aspas";
            Alguem.Turma = "1-ADS";
            Alguem.Foto = "aspas.jfif";
            lista[3] = Alguem;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TxtNum1.Enabled = false;  // desbailita campo de texto
            TxtNum2.Enabled = false;
            BtnConfirma.Enabled = false; // desabilita botão confirma
            LblMensagem.Visible = false; // Panel ocultada
            InsereCandidato();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Preenche("1");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Preenche("9");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Preenche("8");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Preenche("6");
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            Preenche("0");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Preenche("4");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Preenche("3");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Preenche("2");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Preenche("5");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Preenche("7");
        }

        private void Preenche(string n)
        {
            if (numero.Length == 0)
            {
                TxtNum1.Text = n;
                numero += n;
            }
            else
            {
                if (numero.Length == 1)
                {
                    TxtNum2.Text = n;
                    numero += n; //numero = numero + n
                    for (int i = 0; i < 4; i++)
                    {
                        if (Convert.ToInt32(numero) == lista[i].Numero)
                        {
                            LblCandidato.Text = lista[i].Nome;
                            LblTurma.Text = lista[i].Turma;
                            PxFoto.Image = Image.FromFile(@"C:\Users\Aluno\Downloads\Candidatos\" + lista[i].Foto);
                                lista[i].Voto += 1;
                            LblMensagem.Visible = true;
                            BtnConfirma.Enabled=true;
                            i = 3;
                        }
                        else
                        {
                            LblCandidato.Text = "VOTO NULO";
                        }
                        LblMensagem.Visible = true;
                        BtnConfirma.Enabled = true;
                    }
                }
            }

        }
    }
}
