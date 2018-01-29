using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
            set {
                        if(value < 1)
                    {
                        _statusAmount = 1;
                    }
                    else if(value > 9)
                    {
                        _statusAmount = 9;
                    }
                    else
                    {
                        _statusAmount = value;
                    }
                        UpdateStatusBar();
                }
        }
        private int _statusAmount = 9;



        /// <summary>
        /// Label property of StatusBar. Max string length is 9. Default = "Status". 
        /// </summary>
        public string Label { get; set; } = "Status";

        /// <summary>
        /// Enum to specify position for the inner border char.
        /// </summary>
        private enum CornerType { TopLeft = 0, TopRight = 10, BottomLeft = 13, BottomRight = 23, LeftSide = 11, RightSide = 12 }

        /// <summary>
        /// Enum to specify status indication.
        /// </summary>
        private enum StatusIndicator { Good, Low, Critical}

        /// <summary>
        /// Outer border side line char.
        /// </summary>
        private char OuterBorderSideChar = '█';

        /// <summary>
        /// Outer border bottom line char.
        /// </summary>
        private char outerBorderBottomLineChar = '▀';

        /// <summary>
        /// Outer border top line char.
        /// </summary>
        private char outerBorderTopLineChar = '▄';

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

        /// <summary>
        /// Sets inner border side bars.
        /// </summary>
        private char innerBorderSide = '║';

        /// <summary>
        /// Sets status bar 
        /// </summary>
        private char statusBarChar = '█';

        /// <summary>
        /// Starting x,y coordinate to position Hud Element on console. Hud is printed starting from top left.
        /// </summary>
        public Point HudPosCoordinate { get; set; }
        
        /// <summary>
        /// Change the color of the StatusBar label. Default = Green.
        /// </summary>
        public ConsoleColor LabelForegroundColor { get; set; } = ConsoleColor.Green;

        public ConsoleColor LabelBackgroundColor { get; set; } = ConsoleColor.Black;

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
        public ConsoleColor OuterBorderColor { get; set; } = ConsoleColor.DarkGray;

        /// <summary>
        /// Change the color of the inner border of the StatusBar element. Default = White.
        /// </summary>
        public ConsoleColor InnerBorderColor { get; set; } = ConsoleColor.White;

        /// <summary>
        /// Maps the outer border relative to the HudPos origin point.
        /// </summary>
        private int[,] outerBorderMap = new int[32, 2]
        {
            {0,0},{0,1},{0,2},{0,3},{0,4},{0,5},{0,6},{0,7},{0,8},{0,9},{0,10},{0,11},{0,12},
            {1,0},{1,12},
            {2,0},{2,12},
            {3,0},{3,12},
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
        private int[,] labelMappedToOrigin = new int[9, 2];

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


        /// <summary>
        /// Updates the status bar if the StatusAmount is changed.
        /// </summary>
        private void UpdateStatusBar()
        {
            DrawStatusBar();
        }

        /// <summary>
        /// Initialize the status bar.
        /// </summary>
        public void Show()
        {
            Console.CursorVisible = false;
            DrawStatusBar();
            DrawInnerBorder();
            DrawOuterBorder();
            DrawLabel();
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
                Console.BackgroundColor = LabelBackgroundColor;
                Console.ForegroundColor = LabelForegroundColor;
                char[] labelSplit = Label.ToCharArray();
                for (int i = 0; i < labelSplit.Length; i++)
                {
                    Console.SetCursorPosition(labelMappedToOrigin[i, 1], labelMappedToOrigin[i, 0]);
                    Console.Write(labelSplit[i]);
                }
                Console.BackgroundColor = ConsoleColor.Black;
                
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
                //Console.Write(i);
                if (i < 13)
                {
                    Console.Write(outerBorderTopLineChar);
                }
                else if (i >= 19)
                {
                    Console.Write(outerBorderBottomLineChar);
                }
                else
                {
                    Console.Write(OuterBorderSideChar);
                }
                
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
                    default:
                        Console.Write(InnerBorderStraightChar);
                        break;
                    
                }
                
            }


        }

        /// <summary>
        /// Prints status bar.
        /// </summary>
        private void DrawStatusBar()
        {
            
            Console.ForegroundColor = SetStatusBarConsoleColor();
          
            
            CreateMapToOrigin(statusBarMap, ref statusBarMappedToOrigin);
            for (int i = 0; i < StatusAmount; i++)
            {
                Console.SetCursorPosition(statusBarMappedToOrigin[i, 1], statusBarMappedToOrigin[i, 0]);
                Console.Write(statusBarChar);
            }
            for (int i = 8; i > StatusAmount; i--)
            {
                Console.SetCursorPosition(statusBarMappedToOrigin[i, 1], statusBarMappedToOrigin[i, 0]);
                Console.Write(" ");
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

        /// <summary>
        /// Gets the status bar color.
        /// </summary>
        /// <returns>Returns console color for status bar. </returns>
        private ConsoleColor SetStatusBarConsoleColor()
        {
            StatusIndicator status = GetStatusIndicator();
            ConsoleColor barColor = ConsoleColor.Gray;
            switch (status)
            {
                case StatusIndicator.Good:
                    barColor = StatusGoodColor;
                    break;
                case StatusIndicator.Low:
                    barColor = StatusLowColor;
                    break;
                case StatusIndicator.Critical:
                    barColor = StatusCriticalColor;
                    break;
            }
            return barColor;
        }
        
        /// <summary>
        /// Show preview to console.  Mocks a health, stammina, and ability bar.
        /// </summary>
        public static void Preview()
        {
            Random random = new Random();
            HudModule.HudStatusBar healthBar = new HudModule.HudStatusBar()
            {
                HudPosCoordinate = new Point(5, 5),
                Label = "Health",
                
            };

            HudModule.HudStatusBar stamminaBar = new HudModule.HudStatusBar()
            {
                HudPosCoordinate = new Point(10, 5),
                Label = "Stammina",
                LabelForegroundColor = ConsoleColor.Magenta,
                StatusGoodColor = ConsoleColor.DarkBlue,
                StatusLowColor = ConsoleColor.Blue,
                StatusCriticalColor = ConsoleColor.Magenta,

            };

            HudModule.HudStatusBar abilityBar = new HudModule.HudStatusBar()
            {
                HudPosCoordinate = new Point(15, 5),
                Label = "Ability",
                LabelForegroundColor = ConsoleColor.DarkCyan,
                StatusGoodColor = ConsoleColor.Cyan,
                StatusLowColor = ConsoleColor.DarkCyan,
                StatusCriticalColor = ConsoleColor.Gray
            };

            healthBar.Show();
            stamminaBar.Show();
            abilityBar.Show();
            int x = 0;
            while (x < 1000)
            {
                healthBar.StatusAmount = random.Next(1, 9);
                stamminaBar.StatusAmount = random.Next(1, 9);
                abilityBar.StatusAmount = random.Next(1, 9);
                Thread.Sleep(250);
                x++;
            }

            Console.ReadLine();
        }

    }
}
