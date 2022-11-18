using My_isekai_lib.Models.Emojis;
using My_isekai_lib.Utilities;

namespace Pathfinding_test
{
    public partial class PathNodes : Form
    {

        // I used this to help with the algorithm
        // most of this code came from an old of my unity test project
        // https://en.wikipedia.org/wiki/Dijkstra%27s_algorithm

        // for the most, my names convention should be claer enough i think

        GridNode[,] grid;
        Point gridSize = new Point();
        Bitmap image;
        Graphics graphic;
        Pen pen, penPath;
        SolidBrush brushNormal, brushObstacle, brushStart, brushEnd;

        int x = 50;
        int y = 50;

        bool goLeft, goRight, goUp, goDown;
        int speed = 10;

        public PathNodes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pathfinderTimer_Tick(object sender, EventArgs e)
        {
            labelInfo.Text = "...";

            List<GridNode> unvisited = SetUnvisited();
            GridNode current, destination;
            AssignTentativeDistance(unvisited, out current, out destination);

            while (true)
            {
                List<GridNode> unvisitedNeighbors = GetUnvisitedNeighbours(current);

                foreach (GridNode node in unvisitedNeighbors)
                {
                    int tentativeDistance = current.TentativeDistance + 1;
                    if (tentativeDistance < node.TentativeDistance)
                    {
                        node.TentativeDistance = tentativeDistance;
                        node.Previous = current;
                    }
                }

                current.Visited = true;
                unvisited.Remove(current);

                if (destination.Visited)
                {
                    labelInfo.Text = "A path was found!";
                    DrawGrid(gridSize.X, gridSize.Y, destination);
                    break;
                }

                // sort by tentative distance
                unvisited.Sort();
                if (unvisited[0].TentativeDistance == int.MaxValue)
                {
                    labelInfo.Text = "No path was found!";
                    break;
                }

                current = unvisited[0];
            }
        }

        /// <summary>
        /// I am setting the start and end node here. You can modify their coordinate from here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PathNodes_Load(object sender, EventArgs e)
        {
            grid = new GridNode[x, y];
            gridSize.X = x;
            gridSize.Y = y;

            for (int xPos = 0; xPos < x; xPos++)
            {
                for (int yPos = 0; yPos < y; yPos++)
                {
                    GridNode square = new GridNode(xPos, yPos);
                    grid[xPos, yPos] = square;
                }
            }

            grid[9, 17].Type = NodeType.StartNode;
            grid[1, 3].Type = NodeType.EndNode;

            DrawGrid(x, y);
        }

        /// <summary>
        /// creating the grid for the pathfinding
        /// </summary>
        /// <param name="xSize"></param>
        /// <param name="ySize"></param>
        /// <param name="destination"></param>
        public void DrawGrid(int xSize, int ySize, GridNode destination = null)
        {
            DrawingToolsInit(out image, out graphic, out pen, out penPath, out brushNormal, out brushObstacle, out brushStart, out brushEnd);

            int width = panelGameView.Width / xSize;
            int height = panelGameView.Height / ySize;

            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    GridNode square = grid[x, y];
                    SolidBrush brush = brushNormal;

                    // draw in red for an obstacle
                    if (square.Type == NodeType.Obstacle)
                    {
                        brush = brushObstacle;
                    }

                    // change colour for the start
                    if (square.Type == NodeType.StartNode)
                    {
                        brush = brushStart;
                    }

                    // change colour for the end
                    if (square.Type == NodeType.EndNode)
                    {
                        brush = brushEnd;
                    }

                    graphic.FillRectangle(brush, x * width, y * height, width, height);
                    graphic.DrawRectangle(pen, x * width, y * height, width, height);
                }
            }

            while (destination != null)
            {
                if (destination.Previous != null)
                {
                    graphic.DrawLine(penPath, destination.X * width + width / 2, destination.Y * height + height / 2, destination.Previous.X * width + width / 2, destination.Previous.Y * height + height / 2);
                }

                destination = destination.Previous;
            }

            panelGameView.BackgroundImage = image;
        }

        /// <summary>
        /// creating drawing tools
        /// </summary>
        /// <param name="image"></param>
        /// <param name="graphic"></param>
        /// <param name="pen"></param>
        /// <param name="penPath"></param>
        /// <param name="brushNormal"></param>
        /// <param name="brushObstacle"></param>
        /// <param name="brushStart"></param>
        /// <param name="brushEnd"></param>
        private void DrawingToolsInit(out Bitmap image, out Graphics graphic, out Pen pen, out Pen penPath, out SolidBrush brushNormal, out SolidBrush brushObstacle, out SolidBrush brushStart, out SolidBrush brushEnd)
        {
            image = new Bitmap(panelGameView.Width, panelGameView.Height);
            graphic = Graphics.FromImage(image);
            pen = new Pen(Color.Black);
            penPath = new Pen(Color.Blue, 2);
            brushNormal = new SolidBrush(Color.White);
            brushObstacle = new SolidBrush(Color.Black);
            brushStart = new SolidBrush(Color.Green);
            brushEnd = new SolidBrush(Color.Red);
        }

        /// <summary>
        /// convert screen space to grid space
        /// </summary>
        /// <param name="screenX"></param>
        /// <param name="screenY"></param>
        /// <returns></returns>
        public Point ScreenToGrid(int screenX, int screenY)
        {

            Point gridSpace = new Point();
            gridSpace.X = screenX * gridSize.X / panelGameView.Width;
            gridSpace.Y = screenY * gridSize.Y / panelGameView.Height;
            return gridSpace;
        }

        /// <summary>
        /// for character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PathNodes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                case Keys.Right:
                    goRight = true;
                    break;
                case Keys.A:
                case Keys.Left:
                    goLeft = true;
                    break;
                case Keys.W:
                case Keys.Up:
                    goUp = true;
                    break;
                case Keys.S:
                case Keys.Down:
                    goDown = true;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// for character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PathNodes_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                case Keys.Right:
                    goRight = false;
                    break;
                case Keys.A:
                case Keys.Left:
                    goLeft = false;
                    break;
                case Keys.W:
                case Keys.Up:
                    goUp = false;
                    break;
                case Keys.S:
                case Keys.Down:
                    goDown = false;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// current is 0 and others are infinity (or int max)
        /// </summary>
        /// <param name="unvisited"></param>
        /// <param name="current"></param>
        /// <param name="destination"></param>
        private static void AssignTentativeDistance(List<GridNode> unvisited, out GridNode current, out GridNode destination)
        {
            current = null;
            destination = null;
            foreach (GridNode node in unvisited)
            {
                if (node.Type == NodeType.StartNode)
                {
                    node.TentativeDistance = 0;
                    current = node;
                }
                else
                {
                    node.TentativeDistance = int.MaxValue;
                }
                if (node.Type == NodeType.EndNode)
                {
                    destination = node;
                }
            }
        }

        /// <summary>
        ///  for character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxEvilRed_Paint(object sender, PaintEventArgs e)
        {
            Emoji emoji;
            emoji = new EvilRed(new Point(pictureBoxEvilRed.Width / 2, pictureBoxEvilRed.Height / 2 - 15), 35);
            emoji.Draw(e);
        }

        /// <summary>
        /// for character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void controllerTimer_Tick(object sender, EventArgs e)
        {
            if (goLeft == true && pictureBoxEvilRed.Left > 0)
            {
                pictureBoxEvilRed.Left -= speed;
            }

            if (goRight == true && pictureBoxEvilRed.Left + pictureBoxEvilRed.Width < this.ClientSize.Width)
            {
                pictureBoxEvilRed.Left += speed;
            }

            if (goUp == true && pictureBoxEvilRed.Top > 50)
            {
                pictureBoxEvilRed.Top -= speed;
            }

            if (goDown == true && pictureBoxEvilRed.Top + pictureBoxEvilRed.Height < this.ClientSize.Height)
            {
                pictureBoxEvilRed.Top += speed;
            }
        }

        private List<GridNode> SetUnvisited()
        {
            List<GridNode> unvisited = new List<GridNode>();
            foreach (GridNode node in grid)
            {
                node.Visited = false;
                if (node.Type != NodeType.Obstacle)
                {
                    unvisited.Add(node);
                }
            }

            return unvisited;
        }

        /// <summary>
        /// the wiki helped a lot with the logic here...
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private List<GridNode> GetUnvisitedNeighbours(GridNode node)
        {
            List<GridNode> neighbours = new List<GridNode>();

            if (node.X > 0 && !grid[node.X - 1, node.Y].Visited && grid[node.X - 1, node.Y].Type != NodeType.Obstacle)
            {
                neighbours.Add(grid[node.X - 1, node.Y]);
            }

            if (node.X < gridSize.X - 1 && !grid[node.X + 1, node.Y].Visited && grid[node.X + 1, node.Y].Type != NodeType.Obstacle)
            {
                neighbours.Add(grid[node.X + 1, node.Y]);
            }

            if (node.Y > 0 && !grid[node.X, node.Y - 1].Visited && grid[node.X, node.Y - 1].Type != NodeType.Obstacle)
            {
                neighbours.Add(grid[node.X, node.Y - 1]);
            }
            if (node.Y < gridSize.Y - 1 && !grid[node.X, node.Y + 1].Visited && grid[node.X, node.Y + 1].Type != NodeType.Obstacle)
            {
                neighbours.Add(grid[node.X, node.Y + 1]);
            }

            return neighbours;
        }

        /// <summary>
        /// switch between normal and obstacle by mouse clicking
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelGameView_MouseDown(object sender, MouseEventArgs e)
        {
            Point gridSpace = ScreenToGrid(e.X, e.Y);

            switch (grid[gridSpace.X, gridSpace.Y].Type)
            {
                case NodeType.Normal:
                    grid[gridSpace.X, gridSpace.Y].Type = NodeType.Obstacle;
                    break;
                case NodeType.Obstacle:
                    grid[gridSpace.X, gridSpace.Y].Type = NodeType.Normal;
                    break;
            }

            DrawGrid(gridSize.X, gridSize.Y);
        }

        /// <summary>
        /// space coord conversion (similar to how you do it in unity as needed)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelGameView_MouseMove(object sender, MouseEventArgs e)
        {
            Point gridSpace = ScreenToGrid(e.X, e.Y);
            labelCoord.Text = $"Screen coordinates: ({e.X}, {e.Y}) - Grid coordinates: ({gridSpace.X},{gridSpace.Y})";
        }
    }
}