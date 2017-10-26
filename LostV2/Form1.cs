/// created by : 
/// date       : 
/// description: A basic text adventure game engine

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

namespace LostV2
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;

        // random number generator
        Random successChance = new Random();
        int chance;

        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "You are lost in a forest.";
            redLabel.Text = "North";
            blueLabel.Text = "South";
            //display initial message and options
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)      //red button press
            {
                
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                
                if (scene == 0)
                {
                    //70% chance of success
                    chance = successChance.Next(1, 11);

                    if (chance <= 7)
                    {
                        scene = 7;
                    }
                   else
                    {
                        scene = 2;
                    }
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 4)
                {
                    scene = 6;
                }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0: //empty
                    break;
                case 1:
                    //labels
                    outputLabel.Text = "You come to a lake. Do you drink the water?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 2:
                    //output
                    outputLabel.Text = "You fall in a pit and die.";
                    outputLabel.Refresh();

                    //hiding
                    redLabel.Visible = false;
                    redImage.Visible = false;
                    blueLabel.Visible = false;
                    blueImage.Visible = false;

                    Thread.Sleep(3000);
                    Close();
                    break;
                case 3:
                    //output
                    outputLabel.Text = "The water is stagnant, You die.";
                    outputLabel.Refresh();

                    //hiding
                    redLabel.Visible = false;
                    redImage.Visible = false;
                    blueLabel.Visible = false;
                    blueImage.Visible = false;

                    Thread.Sleep(3000);
                    Close();
                    break;
                case 4:
                    //output
                    outputLabel.Text = "A horse walks by. Do you try to ride it?";

                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 5:
                    //output
                    outputLabel.Text = "You tame the horse and ride to safety.\nYOU WIN!";
                    outputLabel.Refresh();

                    //hiding
                    redLabel.Visible = false;
                    redImage.Visible = false;
                    blueLabel.Visible = false;
                    blueImage.Visible = false;

                    Thread.Sleep(3000);
                    Close();
                    break;
                case 6:
                    //output
                    outputLabel.Text = "The horse walks past.\nYou die of lonliness...";
                    outputLabel.Refresh();

                    //hiding
                    redLabel.Visible = false;
                    redImage.Visible = false;
                    blueLabel.Visible = false;
                    blueImage.Visible = false;

                    Thread.Sleep(3000);
                    Close();
                    break;
                case 7:
                    //output
                    outputLabel.Text = "You jump to freedom.\nYOU WIN!";
                    outputLabel.Refresh();

                    //hiding
                    redLabel.Visible = false;
                    redImage.Visible = false;
                    blueLabel.Visible = false;
                    blueImage.Visible = false;

                    Thread.Sleep(3000);
                    Close();
                    break;
                default:
                    break;
            }
        }

    }

}
