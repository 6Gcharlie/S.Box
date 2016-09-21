using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string theCode = textBox1.Text;

            string theUsername = textBox3.Text;

            if (theCode == "S.Box_protocol_B14")
            {
                label1.Text = "Control_interface_over-ride = enter: help";

                button2.Visible = true;

                textBox2.Visible = true;

                button1.Enabled = false;

                textBox1.Enabled = false;

                label6.Visible = false;

                button2.Text = "challenge";
            }
            

if (theCode == "hello")
{
    label1.Text = "Code Valid";

    label6.Text = "Why hello there " + (theUsername) + ". pleased to meet you!";
}

if (theCode == "a7jsb5")
{
    label1.Text = "Code Valid";

    label6.Text = "S.Box is running at its full.capacity";
}
             
if (theCode == "jwn6ma")
{
    label1.Text = "Code Valid";

    label6.Text = "try typing:" + Environment.NewLine + Environment.NewLine + "S.Box_protocol_B14" + Environment.NewLine + Environment.NewLine + "into the text box...";
}

if (theCode == "okay")
{
    label1.Text = "Code Valid";

    label6.Text = "okay what?";
}

if (theCode == "what is the code")
{
    label1.Text = "Code Valid";

    label6.Text = "HAH! Did you think that it was going to be that easy to get a code!?" + Environment.NewLine + "To get a code, the Admin must first GIVE you one!" + Environment.NewLine + "...or you could find one...";
}

if (theCode == "fuck yourself")
{
    label1.Text = "Code Valid";

    label6.Text = "Would if I could " + (theUsername) + "." + Environment.NewLine + Environment.NewLine + "would if I could...";
}

if (theCode == "fuck me")
{
    label1.Text = "Code Valid";

    System.Windows.Forms.MessageBox.Show(";)"); 
}

if (theCode == "list of codes")
{
    label1.Text = "Code Valid";

    label6.Text = "Did you seriously think you'd find the list of code?" + Environment.NewLine + "Although there is a list of codes hidden somewhere, it isn't here!" + Environment.NewLine + Environment.NewLine + "...However clicking the 6G logo could be a start...";
}

if (theCode == "fuck you")
            {
                label1.Text = "Fuck you";

                label2.Text = "Fuck you";

                button1.Enabled = false;

                textBox1.Enabled = false;

                label6.Text = "No " + (theUsername) + "," + Environment.NewLine + "How about FUCK YOU";
                


            }
            if (theCode == "help")
            {
                label1.Text = "Code Valid";

                label6.Text = "Don't panic " + (theUsername) + "," + Environment.NewLine + "To open the guide again, type: guide :into the text box." + Environment.NewLine + "Or, for a more detailed guide, type in: full guide";
            }

            if (theCode == "g83hn0")
            {

                label6.Text = "Code not yet implimented";

            }
            else
            {
                
            }

        }












        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "jwn6ma";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string theCodeV2 = textBox2.Text;

            if (theCodeV2 == "help")
            {
                System.Windows.Forms.MessageBox.Show("if (theCodeV2 == 3f7yj8)" + Environment.NewLine + "{" + Environment.NewLine + "System.Windows.Forms.MessageBox.Show_protocol_t76" + Environment.NewLine + "}");
            }

            if (theCodeV2 == "3f7yj8")
            {
                System.Windows.Forms.MessageBox.Show("Wow! if you're seeing this you must be a GENIUS. As a reward, type:" + Environment.NewLine + Environment.NewLine + "winner" + Environment.NewLine + Environment.NewLine + "in to the text box!");
            }

            if (theCodeV2 == "winner")
            {

                button2.Enabled = false;

                textBox1.Enabled = true;

                button1.Text = "yuo are smart";

                button2.Text = "yuo are smart";

                label2.Text = "yuo are smart, yuo are smart, yuo are smart, yuo are smart";

                label1.Text = "yuo are smart";

                textBox1.Text = "yuo are smart";

                textBox2.Text = "yuo are smart";

                System.Windows.Forms.MessageBox.Show("yuo are smart");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string theUsername = textBox3.Text;

            System.Windows.Forms.MessageBox.Show("Welcome to the S.Box, " + (theUsername) + "!" + Environment.NewLine + "----------" + Environment.NewLine + "Hopefully using this application will provide useful and not a pain to use. Whether it is or it isn't, thats your problem now until I make a patch for your problem XD. In the mean time this short little guide will be teach you how to use the S.Box to its maximum capacity!" + Environment.NewLine + "----------" + Environment.NewLine + "How to use/enter a code" + Environment.NewLine + Environment.NewLine + "after reading this quick instruction manual all feature in the S.Box will be opened up! (if this is your second time reading this just click the exit button or the OK button at the bottem to get stuck right in). when all is unlocked you will see:" + Environment.NewLine + "*- A text box to enter your code/question" + Environment.NewLine + "*- A button to click once the code/question is written to generate an answer" + Environment.NewLine + "*- A small label under the button to tell you whether or not what you just entered triggers a response" + Environment.NewLine + "*- And a disclaimer/hint on how to enter your questions (not so much codes)" + Environment.NewLine + "----------" + Environment.NewLine + "The S.Box is not only for reading specific messages from codes, but you can also talk with the S.Box! (to a certain degree...). Or, if you look close enough/give that much of a damn. you can take on the S.Box head to head in a challenge to figure out the 10 digit, master code. That is if you can even find out how..." + Environment.NewLine + "----------" + Environment.NewLine + "How to recognise a code" + Environment.NewLine + Environment.NewLine + "there are many codes, each is 6 letter/numbers long and often a combination of both. aaaaaaaaaaand thats all you really need to know! just enter them into the box, click the button and get the intended message! enjoy! (or not XD)");

            label1.Visible = true;

            button1.Visible = true;

            textBox1.Visible = true;

            label2.Visible = true;

            button3.Visible = false;

            button4.Visible = false;

            label3.Visible = false; 

            label4.Visible = false;

            label6.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            string theUsername = textBox3.Text;

            pictureBox1.Visible = true;

            label3.Visible = true;

            label4.Visible = true;

            button3.Visible = true;

            button4.Visible = true;

            button5.Visible = false;

            textBox3.Visible = false;

            label5.Visible = false;

            label7.Visible = false;

            label3.Text = "Welcome " + (theUsername) + "!";

            label4.Text = "and welcome to V0.02 of the S.Box!";

        }

        private void button4_Click(object sender, EventArgs e)
        {


            label1.Visible = true;

            button1.Visible = true;

            textBox1.Visible = true;

            label2.Visible = true;

            button3.Visible = false;

            button4.Visible = false;

            label3.Visible = false;

            label4.Visible = false;

            label6.Visible = true;

        }
    }
}
