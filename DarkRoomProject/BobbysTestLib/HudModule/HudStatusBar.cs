using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib.HudModule
{
    class HudStatusBar
    {
        /// <summary>
        /// Default = 9. The Health bar is divided by three.   987 = GoodHealth, 654 = LowHealth, 321 = CriticalHealth 
        /// </summary>
        public int StatusAmount
        {
            get { return _statusAmount; }
            set { _statusAmount = value; UpdateStatusBar(); }
        }
        private int _statusAmount = 9;

        /// <summary>
        /// Label property of StatusBar. Max string length is 9. Default = "Status". 
        /// </summary>
        public string Label { get; set; } = "Status";

        private enum CornerType { TopLeft, TopRight, BottomLeft, BottomRight, LeftSide, RightSide }

        private enum StatusIndicator { Good, Low, Critical}

        /// <summary>
        /// Change the outer border character for a different look. Default = ▓
        /// </summary>
        public char OuterBorderChar { get; set; } = '▓';

        /// <summary>
        /// Top and bottom char for inner border.  Cannot be changed. 
        /// </summary>
        private char InnerBorderStraightChar = '═';

        /// <summary>
        /// Sets inner border top left corner character.
        /// </summary>
        private char innerBorderElboLeftTopCorner = '╔';

        /// <summary>
        /// Sets inner border bottom left corner character.
        /// </summary>
        private char innerBorderElboLeftBottomCorner = '╚';

        /// <summary>
        /// Sets inner border top right corner character.
        /// </summary>
        private char innerBorderElboRightTopCorner = '╗';

        /// <summary>
        /// Sets inner border bottom right corner character.
        /// </summary>
        private char innerBorderElboRightBottomCorner = '╝';

        private char innerBorderSide = '║';

        /// <summary>
        /// Starting x,y coordinate to position Hud Element on console. Hud is printed starting from top left.
        /// </summary>
        public Point HudPosCoordinate { get; set; }
        
        /// <summary>
        /// Change the color of the StatusBar label. Default = Green.
        /// </summary>
        public ConsoleColor LabelColor { get; set; } = ConsoleColor.Green;

        /// <summary>
        /// Change the color of the StatusBar if greater than 6. Default = Green
        /// </summary>
        public ConsoleColor StatusGoodColor { get; set; } = ConsoleColor.Green;

        /// <summary>
        /// Change the color of the StatusBar if greater than 3 and less than 7. Default = Yellow
        /// </summary>
        public ConsoleColor StatusLowColor { get; set; } = ConsoleColor.Yellow;

        /// <summary>
        /// Change the color of the StatusBar if less than 4. Default = Red.
        /// </summary>
        public ConsoleColor StatusCriticalColor { get; set; } = ConsoleColor.Red;

        /// <summary>
        /// Change the color of the outer border of the StatusBar element. Default = Gray.
        /// </summary>
        public ConsoleColor OuterBorderColor { get; set; } = ConsoleColor.Gray;

        /// <summary>
        /// Change the color of the inner border of the StatusBar element. Default = White.
        /// </summary>
        public ConsoleColor InnerBorderColor { get; set; } = ConsoleColor.White;

        /// <summary>
        /// Maps the outer border relative to the HudPos origin point.
        /// </summary>
        private int[,] outerBorderMap = new int[38, 2]
        {
            {0,0},{0,1},{0,2},{0,3},{0,4},{0,5},{0,6},{0,7},{0,8},{0,9},{0,10},{0,11},{0,12},
            {1,-1},{1,0},{1,12},{1,13},
            {2,-1},{2,0},{2,12},{2,13},
            {3,-1},{3,0},{3,12},{2,13},
            {4,0},{4,1},{4,2},{4,3},{4,4},{4,5},{4,6},{4,7},{4,8},{4,9},{4,10},{4,11},{4,12}
        };

        /// <summary>
        /// MultiDim array that takes outer border map and gets mapped to origin.
        /// </summary>
        private int[,] outerBorderMappedToOrigin = new int[32,2];

        /// <summary>
        /// Maps the inner border relative to the HudPos origin point.
        /// </summary>
        private int[,] innerBorderMap = new int[24, 2]
        {
            {1,1},{1,2},{1,3},{1,4},{1,5},{1,6},{1,7},{1,8},{1,9},{1,10},{1,11},
            {2,1},{2,11},
            {3,1},{3,2},{3,3},{3,4},{3,5},{3,6},{3,7},{3,8},{3,9},{3,10},{3,11}
        };

        /// <summary>
        /// MultiDim array that takes the inner border map and gets mapped to origin.
        /// </summary>
        private int[,] innerBorderMappedToOrigin = new int[24, 2];

        /// <summary>
        /// Maps the label relative to the HudPos origin point.
        /// </summary>
        private int[,] labelMap = new int[9, 2]
        {
            {0,2},{0,3},{0,4},{0,5},{0,6},{0,7},{0,8},{0,9},{0,10}
        };

        /// <summary>
        /// MulitDim array that takes the label map and gets mapped to origin.
        /// </summary>
        private int[,] labelMappedToOrigin = new int[6, 2];

        /// <summary>
        /// Maps the StatusBar relative to the HudPos origin point.
        /// </summary>
        private int[,] statusBarMap = new int[9, 2]
        {
            {2,2},{2,3},{2,4},{2,5},{2,6},{2,7},{2,8},{2,9},{2,10}
        };

        /// <summary>
        /// MultiDim array that takes the status bar map and gets mapped to origin.
        /// </summary>
        private int[,] statusBarMappedToOrigin = new int[9, 2];



        private void UpdateStatusBar()
        {

        }

        /// <summary>
        /// Prints label to console
        /// </summary>
        private void DrawLabel()
        {
            if(Label.Length > 9)
            {
                throw new Exception("Label is too long.  Max length is 9 characters.");                
            }
            else
            {
                CreateMapToOrigin(labelMap, ref labelMappedToOrigin);
                Console.ForegroundColor = LabelColor;
                char[] labelSplit = Label.ToCharArray();
                for (int i = 0; i < labelSplit.Length; i++)
                {
                    Console.SetCursorPosition(labelMappedToOrigin[i, 1], labelMappedToOrigin[i, 0]);
                    Console.Write(labelSplit[i]);
                }
            }
        }

        /// <summary>
        /// Prints outer border to console.
        /// </summary>
        private void DrawOuterBorder()
        {
            CreateMapToOrigin(outerBorderMap, ref outerBorderMappedToOrigin);
            Console.ForegroundColor = OuterBorderColor;
            for (int i = 0; i < outerBorderMappedToOrigin.GetLength(0); i++)
            {
                Console.SetCursorPosition(outerBorderMappedToOrigin[i, 1], outerBorderMappedToOrigin[i, 0]);
                Console.Write(OuterBorderChar);
            }            
        }

        /// <summary>
        /// Prints inner border to console.
        /// </summary>
        private void DrawInnerBorder()
        {
            CreateMapToOrigin(innerBorderMap, ref innerBorderMappedToOrigin);
            Console.ForegroundColor = InnerBorderColor;
            for (int i = 0; i < innerBorderMappedToOrigin.GetLength(0); i++)
            {
                Console.SetCursorPosition(innerBorderMappedToOrigin[i, 1], innerBorderMappedToOrigin[i, 0]);
                switch (i)
                {
                    case ((int)CornerType.TopLeft):
                        Console.Write(innerBorderElboLeftTopCorner);
                        break;
                    case ((int)CornerType.TopRight):
                        Console.Write(innerBorderElboRightTopCorner);
                        break;
                    case ((int)CornerType.BottomLeft):
                        Console.Write(innerBorderElboLeftBottomCorner);
                        break;
                    case ((int)CornerType.BottomRight):
                        Console.Write(innerBorderElboRightBottomCorner);
                        break;
                    case ((int)CornerType.LeftSide):
                        Console.Write(innerBorderSide);
                        break;
                    case ((int)CornerType.RightSide):
                        Console.Write(innerBorderSide);
                        break;
                }
                Console.Write(InnerBorderStraightChar);
            }


        }

        private void DrawStatusBar()
        {
            CreateMapToOrigin(statusBarMap, ref statusBarMappedToOrigin);
            StatusIndicator status = GetStatusIndicator();
            for (int i = 0; i < StatusAmount; i++)
            {
                switch (status)
                {
                    case StatusIndicator.Good:
                        Console.ForegroundColor = StatusGoodColor;
                        break;
                    case StatusIndicator.Low:
                        Console.ForegroundColor = StatusLowColor;
                        break;
                    case StatusIndicator.Critical:
                        Console.ForegroundColor = StatusCriticalColor;
                        break;
                }
            }

        }

        /// <summary>
        /// Takes element map and adds origin coordinates and returns mappedToOrgin MultiDim array. 
        /// </summary>
        /// <param name="map">element to be mapped</param>
        /// <param name="newMap">destination array that will hold new mapped coordinates</param>
        private void CreateMapToOrigin(int[,] map, ref int[,] newMap)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                newMap[i, 0] = map[i, 0] + HudPosCoordinate.X;
                newMap[i, 1] = map[i, 1] + HudPosCoordinate.Y;
            }
        }

        /// <summary>
        /// Gets the status indicator
        /// </summary>
        /// <returns>Returns the status indicator according to the status amount</returns>
        private StatusIndicator GetStatusIndicator()
        {
            if(StatusAmount < 4)
            {
                return StatusIndicator.Critical;
            }

            else if(StatusAmount > 3 && StatusAmount < 7)
            {
                return StatusIndicator.Low;
            }

            return StatusIndicator.Good;

        }
        

    }
}
