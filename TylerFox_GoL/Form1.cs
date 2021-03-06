﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace TylerFox_GoL
{
    class GraphicPanel : Panel
    {
        //default constructor
        public GraphicPanel()
        {
            //Turn on dbl buff
            this.DoubleBuffered = true;

            //repaint when resized
            this.SetStyle(ControlStyles.ResizeRedraw, true);

        }//end constructor
    }//end class
    public partial class Form1 : Form
    {
        // The universe array
        bool[,] universe = new bool[10, 10];
        //scratchpad
        bool[,] scratchPad = new bool[10, 10];

        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;

        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;

        public Form1()
        {
            InitializeComponent();

            // Setup the timer
            timer.Interval = 20; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running
        }
        /*
        //counts the neighbors
        private int ToroidalVillageCheck(int x, int y)
        {
            int count = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);

            for (int yOffset = -1; yOffset <= 1; yOffset++)
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;

                    if (xCheck < 0)
                    {
                        xCheck = xLen - 1;
                    }
                    else if (yCheck < 0)
                    {
                        yCheck = yLen - 1;
                    }
                    else if (xCheck >= xLen)
                    {
                        xCheck = 0;
                    }
                    else if (yCheck >= yLen)
                    {
                        yCheck = 0;
                    }

                    if (universe[xCheck, yCheck] == true) count++;
                }//end for xOffset
            }//end for yOffset

            return count;
        }//end  ToroidalVillageCheck
        */

        private int CountNeighbors(int x, int y)
        {
            int count = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(01);


            for (int yOffset = -1; yOffset <= 1; yOffset++)
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;

                    if (xOffset == 0 && yOffset == 0)
                    {
                        continue;
                    }//check 1
                    if (xCheck < 0)
                    {
                        continue;
                    }//check 2
                    if (yCheck < 0)
                    {
                        continue;
                    }//check 3
                    if (xCheck >= xLen)
                    {
                        continue;
                    }//check 4
                    if (yCheck >= yLen)
                    {
                        continue;
                    }//check 5
                    if (universe[xCheck, yCheck] == true) count++;
                }//end xOffset
            }//end yOffset
            
            return count;
        }//end count neighbors

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    int count = CountNeighbors(x, y);
                    
                    scratchPad[x, y] = false;
                    if (universe[x, y] && count < 2)
                        scratchPad[x, y] = false;
                    if (universe[x, y] && (count == 2 || count == 3))
                        scratchPad[x, y] = true;
                    if (universe[x, y] && count > 3)
                        scratchPad[x, y] = false;
                    if (!universe[x, y] && count == 3)
                        scratchPad[x, y] = true;


                }//end y for
            }//end x for

            // Increment generation count 
            generations++;

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();

            bool[,] temp = universe;
            universe = scratchPad;
            scratchPad = temp;

            // Tell Windows you need to repaint
            graphicsPanel1.Invalidate();

        }

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);
            
            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    Rectangle cellRect = Rectangle.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    //set font
                    Font font = new Font("Arial", 15f);

                    //set format to center
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    
                    //initialize neighbor variable
                    int neighbors = CountNeighbors(x, y);
                  

                    // Fill the cell with a brush if alive
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }
                    
                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);

                    //check to not print 0's
                    if (neighbors > 0)
                    {
                        //print neighbor count
                        e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Black, cellRect, stringFormat);
                    }
                    
                }
            }


            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {

                // Calculate the width and height of each cell in pixels
                int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
                int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = e.X / cellWidth;
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = e.Y / cellHeight;

                // Toggle the cell's state
                universe[x, y] = !universe[x, y];

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }

        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            timer.Start();//start

            NextGeneration();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Pause_Click(object sender, EventArgs e)
        {
            timer.Stop();//pause
        }

        private void Next_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                }
            }
            // Iterate through the scratchpad in the y, top to bottom
            for (int y = 0; y < scratchPad.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < scratchPad.GetLength(0); x++)
                {
                    scratchPad[x, y] = false;
                }
            }

            //reset timer
            timer.Enabled = false;

            // Tell Windows you need to repaint
            graphicsPanel1.Invalidate();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                }
            }
            // Iterate through the scratchpad in the y, top to bottom
            for (int y = 0; y < scratchPad.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < scratchPad.GetLength(0); x++)
                {
                    scratchPad[x, y] = false;
                }
            }

            //reset timer
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Enabled = false;

            // Tell Windows you need to repaint
            graphicsPanel1.Invalidate();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabelGenerations_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundStripMenuItem1_Click(object sender, EventArgs e)
        {
            //initialize dialog box
            ColorDialog cldl = new ColorDialog();

            //set default
            cldl.Color = graphicsPanel1.BackColor;

            //if OK
            if (DialogResult.OK == cldl.ShowDialog())
            {
                graphicsPanel1.BackColor = cldl.Color;
            }
        }

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //initialize dialog box
            ColorDialog cldl = new ColorDialog();

            //set default
            cldl.Color = gridColor;

            //if OK
            if (DialogResult.OK == cldl.ShowDialog())
            {
                gridColor = cldl.Color;

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //initialize dialog box
            ColorDialog cldl = new ColorDialog();

            //set default
            cldl.Color = cellColor;

            //if OK
            if (DialogResult.OK == cldl.ShowDialog())
            {
                cellColor = cldl.Color;

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //instancinating
            ModalDialog mod = new ModalDialog();
            if (DialogResult.OK == mod.ShowDialog())
            {
                int x = 0;

            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instancinating
            ModalDialog mod = new ModalDialog();
            if (DialogResult.OK == mod.ShowDialog())
            {
                int x = 0;

            }
        }
        
    }
    
}
