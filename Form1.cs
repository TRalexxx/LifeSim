namespace LifeSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics _graphics;
        private bool[,] _field;
        private int _rows;
        private int _columns;
        private Random _random = new Random();
        private int _currGen = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeGeneration();
        }



        private void startBtn_Click(object sender, EventArgs e)
        {
            CreateField();
            timer1.Interval = (int)intervalNud.Value;
            timer1.Start();
        }

        private void CreateField()
        {
            if (timer1.Enabled) return;

            _currGen = 0;
            generationLable.Text = $"Gen: {_currGen}";

            _rows = gamePicBox.Height / 3;
            _columns = gamePicBox.Width / 3;

            _field = new bool[_columns, _rows];

            for (int i = 0; i < _columns; i++)
            {
                for (int j = 0; j < _rows; j++)
                {
                    _field[i, j] = _random.Next(5) == 0;
                }
            }


            gamePicBox.Image = new Bitmap(gamePicBox.Width, gamePicBox.Height);

            _graphics = Graphics.FromImage(gamePicBox.Image);
        }

        private void ChangeGeneration()
        {
            _graphics.Clear(Color.Black);

            var newField = new bool[_columns, _rows];

            for (int i = 0; i < _columns; i++)
            {
                for (int j = 0; j < _rows; j++)
                {
                    var neighCount = CountNeighbours(i, j);
                    var isLive = _field[i, j];

                    if (!isLive && neighCount == 3)
                        newField[i, j] = true;
                    else if (isLive && (neighCount < 2 || neighCount > 3))
                        newField[i, j] = false;
                    else
                        newField[i, j] = _field[i, j];

                    if (isLive)
                        _graphics.FillRectangle(Brushes.Lime, i * 3, j * 3, 3, 3);

                }
            }
            _field = newField;
            gamePicBox.Refresh();
            generationLable.Text = $"Gen: {++_currGen}";
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            fieldPanel.Size = new Size(this.Width - 40, this.Height - 126);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled) return;

            timer1.Stop();
        }

        private int CountNeighbours(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    int col = (x + i + _columns) % _columns;
                    int row = (y + j + _rows) % _rows;



                    bool isSelf = col == x && row == y;

                    var hasLife = _field[col, row];

                    if (hasLife && !isSelf)
                        count++;
                }
            }

            return count;
        }

        private void gamePicBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / 3;
                var y = e.Location.Y / 3;
                if(IsInField(x, y))
                _field[x, y] = true;
            }

            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / 3;
                var y = e.Location.Y / 3;
                if(IsInField(x, y))
                _field[x, y] = false;
            }
        }

        private bool IsInField(int x, int y)
        {
            return x>=0 && y>=0 && x<_columns && y<_rows;
        }
    }
}