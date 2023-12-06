using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//Create slots and spin button DONE
// create an array/list to hold each color DONE
// when spin button is pressed a general function applies to all slots that:
// changes the colors at random for a particular number of times DONE
// Store the value of each slots current color after the spin button is stopped DONE
// if each value is the same add one to score point DONE
//GAMEPLAY : WHEN GAME STARTS PLAYER HAS 5 SPINS AND 2 HOLDS , GET A POINT GET A SPIN INNIT
// hold button for each of the slots{ stops the random function}

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //change names of resources
        Image blue = WindowsFormsApp1.Properties.Resources.Blue;
        Image red = WindowsFormsApp1.Properties.Resources.Red;
        Image purple = WindowsFormsApp1.Properties.Resources.Purple;

        //create list to contain all slot image types
        List<Image> photos = new List<Image>();
        int score = -1;
        int tries = 5;

        public Form1()
        {
            InitializeComponent();
        }

        public void slotchange() // this function changes the slot image for each slot at random
        {
            var random = new Random();
            int slot1change = random.Next(0, 3);
            int slot2change = random.Next(0, 3);
            int slot3change = random.Next(0, 3);
            slot1.Image = photos[slot1change];
            slot2.Image = photos[slot2change];
            slot3.Image = photos[slot3change];
 
        }

        public void sameslots()
        {
            if (slot1.Image == slot2.Image && slot3.Image == slot1.Image) 
            { score++; miniconsole.Text = score.ToString();}
          
        }

        private void Form1_Load(object sender, EventArgs e)
        { // adding slot images to the list
            photos.Add(blue);
            photos.Add(red);
            photos.Add(purple);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this button starts the random slot image changing function, when pressed again stops it ONLY IF YOU HAVE TRIES LEFT
            if (tries >= 0)
            {
                if (timer1.Enabled)
                {
                    timer1.Enabled = false;
                    button1.Text = "START";

                }
                else
                {
                    timer1.Enabled = true;
                    button1.Text = "STOP";
                    sameslots();
                    tries--;
                    triestextbox.Text = tries.ToString();
                }
            }
            else { triestextbox.Text = "OUT OF TRIES"; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        { // the timer for the button function
            slotchange();
        }
    }
}
