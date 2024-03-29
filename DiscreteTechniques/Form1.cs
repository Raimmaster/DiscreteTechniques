﻿using System;
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

    public enum Techniques
    {
        PSR, PCR, VSR, VCR, CSR, CCR, PC, RM, RA
    }

    public partial class Form1 : Form
    {
        TecnicasConteo tecnMath;
        Techniques tecnActual;
        string[] ejemplos;
        private static int CANT_EJEMPLOS = 9;

        public void reset(Techniques tec)
        {
            switch (tec)
            {
                case Techniques.PSR:
                    tEntradaN.Text = "6";
                    tResultado.Text = tecnMath.permutacionSinRepeticion(6).ToString();
                    break;
                case Techniques.PCR:
                    tEntradaN.Text = "8";
                    List<double> subsets = new List<double>();
                    subsets.Add(3);
                    subsets.Add(2);
                    tResultado.Text = tecnMath.permutacionConRepeticion(8, subsets).ToString();
                    break;
                case Techniques.VSR:
                    tEntradaN.Text = "8";
                    tEntradaM.Text = "3";
                    bCalcular_Click(null, null);
                    break;
                case Techniques.VCR:
                    tEntradaN.Text = "2";
                    tEntradaM.Text = "9";
                    bCalcular_Click(null, null);
                    break;
                case Techniques.CSR:
                    tEntradaN.Text = "8";
                    tEntradaM.Text = "3";
                    bCalcular_Click(null, null);
                    break;
                case Techniques.CCR:
                    tEntradaN.Text = "3";
                    tEntradaM.Text = "20";
                    bCalcular_Click(null, null);
                    break;
                case Techniques.PC:
                    tEntradaN.Text = "5";
                    bCalcular_Click(null, null);
                    break;
                case Techniques.RM: 
                    break;
                case Techniques.RA:
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
            tecnMath = new TecnicasConteo();
            tResultado.ReadOnly = true;
            tecnActual = Techniques.PSR;
            ejemplos = new string[CANT_EJEMPLOS];

            ejemplos[0] = "E.g, ¿De cuántas se pueden formar 6 personas para abordar el autobús?";
            ejemplos[1] = "E.g, ¿Cuántas permutaciones se pueden hacer con la palabra infinito?";
            ejemplos[2] = "E.g, En un concurso nacional de programación, hay 8 finalistas. \nEncuentre el número de ordenamientos posibles al final del concurso para las primeras tres posiciones?";
            ejemplos[3] = "E.g, ¿En cuántas formas distdoubleas se puede responder una prueba de verdadero o falso que consta de 9 preguntas?";
            ejemplos[4] = "E.g, ¿Cuántas formas hay para seleccionar a 3 candidatos de 8 recien graduados \nigualmente calificados para las vacantes de una empresa?";
            ejemplos[5] = "E.g, Considere el siguiente segmento de un programa en Pascal, donde i, j, k son variables enteras. For i = 1 to 20 do \n    For j = 1 to i do \n For k = 1 to j do \n writeln(i*j + k)\n ¿Cuántas veces se repite writeln?";
            ejemplos[6] = "E.g, ¿De cuántas maneras se pueden plantar 5 árboles distdoubleos en un redondel?";
            ejemplos[7] = "E.g, Marco va armar una computadora por sí mismo. \nTiene la opción de comprar los chips entre 2 marcas, un disco duro de 4 marcas, la memoria de tres marcas, \ny un conjunto de accesorios en 5 tiendas locales. \n¿De cuántas formas diferentes puede Marco comprar las partes de la computadora?";
            ejemplos[8] = "¿De cuántas maneras se pueden seleccionar 2 libros de temas diferentes entre 5 libros de computación distdoubleos, \n3 libros de matemáticas diferentes y 2 libros de arte distdoubleos?";

            lExample.Text = ejemplos[0];
            reset(tecnActual);
        }
        
        private void rbPSR_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = false;            
            tecnActual = Techniques.PSR;
            lExample.Text = ejemplos[0];
            reset(tecnActual);
        }

        private void rbPCR_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = false;
            tecnActual = Techniques.PCR;
            lExample.Text = ejemplos[1];
            reset(tecnActual);
        }

        private void rbVSR_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = true;
            tecnActual = Techniques.VSR;
            lExample.Text = ejemplos[2];
            reset(tecnActual);
        }

        private void rbVCR_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = true;
            tecnActual = Techniques.VCR;
            lExample.Text = ejemplos[3];
            reset(tecnActual);
        }

        private void rbCSR_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = true;
            tecnActual = Techniques.CSR;
            lExample.Text = ejemplos[4];
            reset(tecnActual);
        }

        private void rbCCR_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = true;
            tecnActual = Techniques.CCR;
            lExample.Text = ejemplos[5];
            reset(tecnActual);
        }

        private void rbPC_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = false;
            tecnActual = Techniques.PC;
            lExample.Text = ejemplos[6];
            reset(tecnActual);
        }

        private void rbRM_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = false;
            tecnActual = Techniques.RM;
            lExample.Text = ejemplos[7];
            reset(tecnActual);
        }

        private void rbRA_CheckedChanged(object sender, EventArgs e)
        {
            tEntradaM.Enabled = false;
            tecnActual = Techniques.RA;
            lExample.Text = ejemplos[8];
            reset(tecnActual);
        }

        //
        // Summary:
        //     Gets a List<double> from an InputBox
        //
        // Parameters:
        //   cant_iterations:
        //     Amount of times it should fill in the sets
        //
        // Returns:
        //     A List<double> with all the subsets used for the calculations
        //
        private List<double> getSubSet(double cant_iterations)
        {
            List<double> subsets = new List<double>();
            double valor = 1;
            int iteration = 1;
            
            do
            {
                valor = Convert.ToDouble(Microsoft.VisualBasic.
                    Interaction.InputBox(
                    "Ingrese la cantidad de números en el subconjunto " + iteration++ + ": ",
                    "Subconjuntos", "1"));
                subsets.Add(valor);
                switch (tecnActual)
                {
                    case Techniques.PCR:
                        cant_iterations -= valor;
                        break;
                    default:
                        cant_iterations--;
                        break;
                }
            } while (cant_iterations > 0);

            return subsets;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            double n = Convert.ToDouble(tEntradaN.Text);
            double m = Convert.ToDouble(tEntradaM.Text);
            List<double> subsets;
            switch (tecnActual)
            {
                case Techniques.PSR:
                    resultado = tecnMath.permutacionSinRepeticion(n);
                    break;
                case Techniques.PCR:
                    subsets = getSubSet(n);
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
                    subsets = getSubSet(n);
                    resultado = tecnMath.reglaMultiplicativa(subsets);
                    break;
                case Techniques.RA:
                    subsets = getSubSet(n);
                    resultado = tecnMath.reglaAditiva(subsets);
                    break;
            }

            tResultado.Text = resultado.ToString();
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            reset(tecnActual);
        }
    }
}
