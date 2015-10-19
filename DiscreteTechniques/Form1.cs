using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecnicas;


namespace DiscreteTechniques
{

    enum Techniques
    {
        PSR, PCR, VSR, VCR, CSR, CCR, PC, RM, RA
    }

    public partial class Form1 : Form
    {
        TecnicasConteo tecnMath;
        Techniques tecnActual;

        public Form1()
        {
            InitializeComponent();
            tecnMath = new TecnicasConteo();
            tResultado.ReadOnly = true;
            tecnActual = Techniques.PSR;
        }

        private void rbPSR_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = false;            
            tecnActual = Techniques.PSR;
        }

        private void rbPCR_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = false;
            tecnActual = Techniques.PCR;
        }

        private void rbVSR_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = true;
            tecnActual = Techniques.VSR;
        }

        private void rbVCR_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = true;
            tecnActual = Techniques.VCR;
        }

        private void rbCSR_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = true;
            tecnActual = Techniques.CSR;
        }

        private void rbPC_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = false;
            tecnActual = Techniques.PC;
        }

        private void rbCCR_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = true;
            tecnActual = Techniques.CCR;
        }

        private void rbRM_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = false;
            tecnActual = Techniques.RM;
        }

        private void rbRA_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = false;
            tecnActual = Techniques.RA;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            int n = Convert.ToInt32(tEntradaN.Text);
            int m = Convert.ToInt32(tEntradaM.Text);
            switch (tecnActual)
            {
                case Techniques.PSR:
                    resultado = tecnMath.permutacionSinRepeticion(n);
                    break;
                case Techniques.PCR:
                    List<int> subsets = new List<int>();
                    int valor = 1;
                    int contador = n;
                    do
                    {
                        valor = Convert.ToInt32(Microsoft.VisualBasic.
                            Interaction.InputBox(
                            "Ingrese la cantidad de números en este subconjunto: ",
                            "Subconjuntos", "1"));
                        subsets.Add(valor);
                        contador -= valor;
                    } while (contador > 0);
                    resultado = tecnMath.permutacionConRepeticion(n, subsets);
                    break;
                case Techniques.VSR:
                    resultado = tecnMath.variacionSinRepeticion(n, m);
                    break;
                case Techniques.VCR:
                    resultado = tecnMath.variacionConRepeticion(n, m);
                    break;
                case Techniques.CSR:
                    resultado = tecnMath.combinacionSinRepeticion(n, m);
                    break;
                case Techniques.CCR:
                    resultado = tecnMath.combinacionConRepeticion(n, m);
                    break;
                case Techniques.PC:
                    resultado = tecnMath.permutacionCircular(n);
                    break;
                case Techniques.RM:
                    resultado = tecnMath.reglaMultiplicativa(n);
                    break;
                case Techniques.RA:
                    resultado = tecnMath.reglaAditiva();
                    break;
            }

            tResultado.Text = resultado.ToString();
        }
    }
}
