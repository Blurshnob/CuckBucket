﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Minesweeper
{
   public class Grid
    {
       //private fields
       private Tile[,] mGrid;
       private int mRows, mColumns;
       private int mTileSize;


       //Constructors

       public Grid(int Rows, int Columns, int TileSize)
       {
            this.mRows = Rows;
            this.mColumns = Columns;
            this.mTileSize = TileSize;

            mGrid = new Tile[this.mRows, this.mColumns];

            for (int i = 0; i < this.mRows; i++)
            {
                for (int j = 0; j < this.mColumns; j++)
                {
                    mGrid[i, j] = new Tile();
                }
            }

            int eBombs = 10;
            int iBombs = 40;
            for (int i = 0; i < mGrid.GetLength(0); i++)
            {
                for (int j = 0; j < mGrid.GetLength(1); j++)
                {
                    if (mGrid.GetLength(0) == 9)
                    {
                        if (eBombs > 0)
                        {
                            mGrid[i, j].Bomb = true;
                            eBombs--;
                            mGrid[i, j].BackgroundColour = Resource1.Bomb;

                        }
                    }
                    if (mGrid.GetLength(0) == 16)
                    {
                        if (iBombs > 0)
                        {
                            mGrid[i, j].Bomb = true;
                            iBombs--;
                            mGrid[i, j].BackgroundColour = Resource1.Bomb;
                        }
                    }
                }
            }

            Bitmap Temp;
            Random Index = new Random();
            for (int i = 0; i < mGrid.GetLength(0); i++)
            {
                for (int j = 0; j < mGrid.GetLength(1); j++)
                {
                    int Row = Index.Next(0, mGrid.GetLength(0) - 1);
                        int Column = Index.Next(0, mGrid.GetLength(1) - 1);


                        Temp = mGrid[i, j].BackgroundColour;
                        mGrid[i, j].BackgroundColour = mGrid[Row, Column].BackgroundColour;
                        mGrid[Row, Column].BackgroundColour = Temp;
                }   
            }

            for (int i = 0; i < mGrid.GetLength(0); i++)
            {
                for (int j = 0; j < mGrid.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            if (mGrid[i, j + 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i + 1, j].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i + 1, j + 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }

                        }
                        else if (j == mGrid.GetLength(1) - 1)
                        {
                            if (mGrid[i + 1, j].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i + 1, j - 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i, j - 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }

                        }
                        else
                        {
                            if (mGrid[i, j - 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i, j + 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i + 1, j - 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i + 1, j].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i + 1, j + 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                        }

                    }
                    else if (i == mGrid.GetLength(0) - 1)
                    {
                        if (j == 0)
                        {
                            if (mGrid[i - 1, j].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i - 1, j + 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i, j + 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                        }
                        if (j == mGrid.GetLength(1) - 1)
                        {
                            if (mGrid[i - 1, j - 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i - 1, j].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i, j - 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                        }
                        else
                        {
                            if (mGrid[i - 1, j].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i - 1, j].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i, j].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i - 1, j + 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i, j + 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            if (mGrid[i - 1, j].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i - 1, j + 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i, j + 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i + 1, j].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i + 1, j + 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                        }
                        else if (j == mGrid.GetLength(1) - 1)
                        {
                            if (mGrid[i - 1, j - 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i - 1, j].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i, j - 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i + 1, j - 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i + 1, j].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }

                        }
                        else
                        {
                            if (mGrid[i - 1, j - 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i - 1, j].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i - 1, j + 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i, j - 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i, j + 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i + 1, j - 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i + 1, j].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }
                            if (mGrid[i + 1, j + 1].Bomb == true)
                            {
                                mGrid[i, j].BombCount++;
                            }

                        }
                        //Fuck(i, j);mGrid[i, j].BombCount++
                        if (mGrid[i, j].BombCount == 1)
                        {
                            mGrid[i, j].BackgroundColour = Resource1._76px_Minesweeper_1_svg;
                        }
                        if (mGrid[i, j].BombCount == 2)
                        {
                            mGrid[i, j].BackgroundColour = Resource1._76px_Minesweeper_2_svg;
                        }
                        if (mGrid[i, j].BombCount == 3)
                        {
                            mGrid[i, j].BackgroundColour = Resource1._76px_Minesweeper_3_svg;
                        }
                        if (mGrid[i, j].BombCount == 4)
                        {
                            mGrid[i, j].BackgroundColour = Resource1.Minesweeper_4_svg;
                        }
                        if (mGrid[i, j].BombCount == 5)
                        {
                            mGrid[i, j].BackgroundColour = Resource1._76px_Minesweeper_5_svg;
                        }
                        if (mGrid[i, j].BombCount == 6)
                        {
                            mGrid[i, j].BackgroundColour = Resource1._76px_Minesweeper_6_svg;
                        }
                        if (mGrid[i, j].BombCount == 7)
                        {
                            mGrid[i, j].BackgroundColour = Resource1._76px_Minesweeper_7_svg;
                        }
                        if (mGrid[i, j].BombCount == 8)
                        {
                            mGrid[i, j].BackgroundColour = Resource1._76px_Minesweeper_8_svg;
                        }
                    }

                }



            }
            
       }

       //Methods

       //Gets tile location
       public Tile GetTile(int Row, int Columns)
       {
           return mGrid[Row, Columns];
       }

       public void Draw(Graphics g, int X, int Y)
       {
           int pX = X;
           int pY = Y;

           for (int i = 0; i < this.mRows; i++)
           {

               pY = Y + (i * this.mTileSize);

               for (int j = 0; j < this.mColumns; j++)
               {
                   pX = X + (j * this.mTileSize);
                   mGrid[i, j].Draw(g, pX, pY);

               }
           }
       }

       ///////////////////////////////////////////////////////////////////////////////////////
       //public void Fuck(int i, int j)
       //{

       //    //change image
       //    if (mGrid.GetTile(i, j).BombCount == 1)
       //    {
       //        mGrid.GetTile(i, j).BackgroundColour = Resource1._76px_Minesweeper_1_svg;
       //    }
       //    if (mGrid.GetTile(i, j).BombCount == 2)
       //    {
       //        mGrid.GetTile(i, j).BackgroundColour = Resource1._76px_Minesweeper_2_svg;
       //    }
       //    if (mGrid.GetTile(i, j).BombCount == 3)
       //    {
       //        mGrid.GetTile(i, j).BackgroundColour = Resource1._76px_Minesweeper_3_svg;
       //    }
       //    if (mGrid.GetTile(i, j).BombCount == 4)
       //    {
       //        mGrid.GetTile(i, j).BackgroundColour = Resource1.Minesweeper_4_svg;
       //    }
       //    if (mGrid.GetTile(i, j).BombCount == 5)
       //    {
       //        mGrid.GetTile(i, j).BackgroundColour = Resource1._76px_Minesweeper_5_svg;
       //    }
       //    if (mGrid.GetTile(i, j).BombCount == 6)
       //    {
       //        mGrid.GetTile(i, j).BackgroundColour = Resource1._76px_Minesweeper_6_svg;
       //    }
       //    if (mGrid.GetTile(i, j).BombCount == 7)
       //    {
       //        mGrid.GetTile(i, j).BackgroundColour = Resource1._76px_Minesweeper_7_svg;
       //    }
       //    if (mGrid.GetTile(i, j).BombCount == 8)
       //    {
       //        mGrid.GetTile(i, j).BackgroundColour = Resource1._76px_Minesweeper_8_svg;
       //    }


       //}

       /// ////////////////////////////////////////////////////////////////////
       //public int Change(int i, int j)
       //{
       //    if (i < 0 || j < 0 || i >= 9 || j >= 9)
       //    {
       //        return mGrid.GetTile(i, j).BombCount;
       //    }
       //    if (mGrid.GetTile(i, j).Bomb == true)
       //    {
       //        return 0;
       //    }
       //    if (mGrid.GetTile(i, j).BackgroundColour == Resource1._76px_Minesweeper_0_svg)
       //    {
       //        if (mGrid.GetTile(i + 1, j).BackgroundColour == Resource1.Bomb)
       //        {
       //            return mGrid.GetTile(i, j).BombCount++;
       //        }
       //        if (mGrid.GetTile(i + 1, j + 1).BackgroundColour == Resource1.Bomb)
       //        {
       //            return mGrid.GetTile(i, j).BombCount++;
       //        }
       //        if (mGrid.GetTile(i + 1, j - 1).BackgroundColour == Resource1.Bomb)
       //        {
       //            return mGrid.GetTile(i, j).BombCount++;
       //        }
       //        if (mGrid.GetTile(i - 1, j).BackgroundColour == Resource1.Bomb)
       //        {
       //            return mGrid.GetTile(i, j).BombCount++;
       //        }
       //        if (mGrid.GetTile(i - 1, j + 1).BackgroundColour == Resource1.Bomb)
       //        {
       //            return mGrid.GetTile(i, j).BombCount++;
       //        }
       //        if (mGrid.GetTile(i - 1, j - 1).BackgroundColour == Resource1.Bomb)
       //        {
       //            return mGrid.GetTile(i, j).BombCount++;
       //        }
       //        if (mGrid.GetTile(i, j + 1).BackgroundColour == Resource1.Bomb)
       //        {
       //            return mGrid.GetTile(i, j).BombCount++;
       //        }
       //        if (mGrid.GetTile(i, j - 1).BackgroundColour == Resource1.Bomb)
       //        {
       //            return mGrid.GetTile(i, j).BombCount++;
       //        }
       //        Fuck(i, j);
       //    }


       //    return 0;


       //}
       
    }
}
