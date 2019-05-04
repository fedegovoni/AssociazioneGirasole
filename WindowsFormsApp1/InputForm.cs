using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InputForm : Form
    {
        private ShowNumberForm outputForm;
        public InputForm(ShowNumberForm outputForm)
        {
            InitializeComponent();
            this.outputForm = outputForm;
            textBox.Focus();
        }



        private void okButton_Click(object sender, EventArgs e)
        {
            int value;
            try
            {
                if (textBox.Text.Trim().Equals(""))
                {
                    plusOneButton_Click(sender, e);
                }
                else
                {
                    value = int.Parse(textBox.Text);
                    currentNumber.Text = value + "";
                    outputForm.setOutputNumber(value);
                    textBox.Text = "";

                    string filePath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Media\sound.wav";
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.SoundLocation = filePath;
                    player.Play();
                }
            }
            catch (FormatException) { }
            catch (FileNotFoundException) { }
        }

        private void plusOneButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(currentNumber.Text) + 1;
            currentNumber.Text = value + "";
            outputForm.setOutputNumber(value);
            textBox.Focus();

            try
            {
                string filePath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Media\sound.wav";
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = filePath;
                player.Play();
            
            } catch (FileNotFoundException) { }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                okButton_Click(this, new EventArgs());
            }
        }
    }
}
