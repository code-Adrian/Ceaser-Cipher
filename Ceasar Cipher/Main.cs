using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceasar_Cipher
{
    public partial class Main : Form
    {
        List<string> alph = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        List<string> enc = new List<string> { };
        //Sets default shift value to 3. Sorts arrays to correct values. Updates labels.
        public Main()
        {
            InitializeComponent();
            shift.Text = "3";
            sort();
            setCipherText();
        }

        private void Encrypton_Click(object sender, EventArgs e)
        {

            sort();
            setCipherText();
            encrypt();

        }
        //Executes decrypt method to start decrypting cipher.
        private void Decrypton_Click(object sender, EventArgs e)
        {
            decrypt();
        }

        //Copies to clipboard
        private void Copy_Click(object sender, EventArgs e)
        {
            Output.Copy();
        }
        //Sets arrays to correct values.
        private void sort() {
            try
            {
                int k = int.Parse(shift.Text);
                enc.Clear();

                for (int i = k; i >= 0; i--)
                {
                    enc.Add(alph[25 - i]);


                }
                enc.RemoveAt(0);
                for (int i = 0; i < alph.Count - k; i++)
                {
                    enc.Add(alph[i]);

                }
            }
            catch (Exception e) {
                MessageBox.Show("Please enter a valid number","Out of bounds",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //Encrypts text using the ceaser cipher. Finds the corresponding character.
        private void encrypt() {
           
                string text = EncBox.Text.ToUpper();
                string output = "";
                for (int i = 0; i < text.Length; i++)
                {

                if (text[i].ToString().Equals(" "))
                {
                    output += " ";
                }
                for (int ii = 0; ii < enc.Count; ii++)
                    {
                   
                    if (text[i].ToString().Equals(enc[ii]))
                        {
                        
                            output += alph[ii];
                       
                    }
                    }
                }

                Output.Text = output;
            DecBox.Text = output;
            Console.WriteLine(output);
            }
        //Decrypts text using the ceaser cipher. Finds the corresponding character.
        private void decrypt() {
            string text = DecBox.Text.ToUpper();
            string output = "";

            for (int i = 0; i < text.Length; i++)
            {

                if (text[i].ToString().Equals(" "))
                {
                    output += " ";
                }
                for (int ii = 0; ii < alph.Count; ii++)
                {

                    if (text[i].ToString().Equals(alph[ii]))
                    {

                        output += enc[ii];

                    }
                }
            }

            Output.Text = output;
        }


        
        

        private void setCipherText() {

            try
            {
                A.Text = enc[0];
                B.Text = enc[1];
                C.Text = enc[2];
                D.Text = enc[3];
                E.Text = enc[4];
                F.Text = enc[5];
                G.Text = enc[6];
                H.Text = enc[7];
                I.Text = enc[8];
                J.Text = enc[9];
                K.Text = enc[10];
                L.Text = enc[11];
                M.Text = enc[12];
                N.Text = enc[13];
                O.Text = enc[14];
                P.Text = enc[15];
                Q.Text = enc[16];
                R.Text = enc[17];
                S.Text = enc[18];
                T.Text = enc[19];
                U.Text = enc[20];
                V.Text = enc[21];
                W.Text = enc[22];
                X.Text = enc[23];
                Y.Text = enc[24];
                Z.Text = enc[25];
            }
            catch (Exception e) { 
            //Ignore
            }
        }


 
    }
}
