﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifModule2
{
    public partial class Form1 : Form
    {
        //globals
        string color, shape;

        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            //holding values
            color = colorInput.Text;
            shape = shapeInput.Text;

            Color shapeColor = Color.White; //set white to hold value (otherwise pen/brush gets mad)

            //colour
            if (color == "R" | color == "r")
            {
                //set pen/brush colour
                shapeColor = Color.Red;
            }
            else if (color == "G" | color == "g")
            {

                //set pen/brush colour
                shapeColor = Color.Green;
            }
            else
            {
                //error! (set value to null)
                colorInput.Text = null;
            }

            //graphics
            Graphics sG = this.CreateGraphics();//graphics (AKA. Black Magic!)  (ﾉ◕ヮ◕)⊃━☆*:･ﾟ.* ･｡ﾟ✧

            //pen & brush
            Pen shapePen = new Pen(shapeColor, 10);
            SolidBrush shapeBrushCover = new SolidBrush(Color.DeepSkyBlue);

            

            //shape
            if (shape == "C" | shape == "c" | shape == "Circle" | shape == "circle")
            {
                //coving up possible past drawings
                sG.FillRectangle(shapeBrushCover, 120, 200, 220, 120);//drawing rectangle

                //drawing circle   
                sG.DrawEllipse(shapePen, 130, 210, 100, 100);//drawing circle
            }
            else if (shape == "R" | shape == "r" | shape == "Rectangle" | shape == "rectangle")
            {
                //coving up possible past drawings
                sG.FillRectangle(shapeBrushCover, 120, 200, 220, 120);//drawing rectangle

                //drawing circle   
                sG.DrawRectangle(shapePen, 130, 210, 200, 100);//drawing rectangle
            }
        }
    }
}
