using System;
using System.Collections.Generic;
using System.Drawing;

namespace oop_final_game
{
    internal static class LevelGenerator
    {
        private static Random ran = new Random();

        public static List<Brick> GenerateRandomLayout(int startY)
        {
            List<Brick> generatedBricks = new List<Brick>();

            int totalRows = 7;
            int totalColumns = 13;
            int padding = 7;
            int startX = 140;

            // 0 = Rectangle, 1 = Pyramid, 2 = Diamond, 3 = Inverted Pyramid, 4 = Hourglass, 5 = Hollow Frame, 6 = Checkered Mesh
            int shapeType = ran.Next(0, 7);

            int midRow = totalRows / 2;
            int midCol = totalColumns / 2;

            for (int r = 0; r < totalRows; r++)
            {
                int brickType = ran.Next(1, 7);

                for (int c = 0; c < totalColumns; c++)
                {
                    bool shouldSpawn = false;

                    switch (shapeType)
                    {
                        case 0: // Standard Rectangle Layout
                            shouldSpawn = true;
                            break;

                        case 1: // Pyramid Layout (Pointing Up)
                            int inverseR = totalRows - 1 - r;
                            if (c >= inverseR && c < totalColumns - inverseR)
                            {
                                shouldSpawn = true;
                            }
                            break;

                        case 2: // Diamond Layout
                            if (Math.Abs(c - midCol) + Math.Abs(r - midRow) <= midRow)
                            {
                                shouldSpawn = true;
                            }
                            break;

                        case 3: // Inverted Pyramid Layout (Pointing Down)
                            if (c >= r && c < totalColumns - r)
                            {
                                shouldSpawn = true;
                            }
                            break;

                        case 4: // Hourglass Layout
                            int distFromMidRow = Math.Abs(r - midRow);
                            if (c >= (midRow - distFromMidRow) && c < totalColumns - (midRow - distFromMidRow))
                            {
                                shouldSpawn = true;
                            }
                            break;

                        case 5: // Hollow Frame Layout (The Picture Frame)
                            if (r == 0 || r == totalRows - 1 || c == 0 || c == totalColumns - 1)
                            {
                                shouldSpawn = true;
                            }
                            break;

                        case 6: // Checkered Mesh Layout (Mosaic)
                            if ((r + c) % 2 == 0)
                            {
                                shouldSpawn = true;
                            }
                            break;
                    }

                    if (shouldSpawn)
                    {
                        float xPos = startX + (c * (Brick.WIDTH + padding));
                        float yPos = startY + (r * (Brick.HEIGHT + padding));
                        generatedBricks.Add(CreateBrickInstance(xPos, yPos, brickType));
                    }
                }
            }

            return generatedBricks;
        }

        private static Brick CreateBrickInstance(float xPos, float yPos, int brickType)
        {
            bool isItSpecial = ran.Next(1, 6) == 5;

            switch (brickType)
            {
                case 1: return new RedBrick(xPos, yPos, isItSpecial);
                case 2: return new YellowBrick(xPos, yPos, isItSpecial);
                case 3: return new PlumBrick(xPos, yPos, isItSpecial);
                case 4: return new GreenBrick(xPos, yPos, isItSpecial);
                case 5: return new TurquoiseBrick(xPos, yPos, isItSpecial);
                case 6: return new BrownBrick(xPos, yPos, isItSpecial);
                default: return new TurquoiseBrick(xPos, yPos, isItSpecial);
            }
        }
    }
}