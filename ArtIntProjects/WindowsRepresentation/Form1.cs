using Core;
using Action = Core.Action;

namespace WindowsRepresentation
{
    public partial class Form1 : Form
    {

        private int[,] Chess = {
            { 1, 5, 3, 4, 3, 6, 7, 1, 1, 6 },
            { 4, 4, 3, 4, 2, 6, 2, 6, 2, 5 },
            { 1, 3, 9, 4, 5, 2, 4, 2, 9, 5 },
            { 5, 2, 3, 5, 5, 6, 4, 6, 2, 4 },
            { 1, 3, 3, 2, 5, 6, 5, 2, 3, 2 },
            { 2, 5, 2, 5, 5, 6, 4, 8, 6, 1 },
            { 9, 2, 3, 6, 5, 6, 2, 2, 2, 0 }
        };

        public Form1()
        {
            InitializeComponent();
            PopulateDataGridView();

         
        }

        private void PopulateDataGridView()
        {
          
            dataGridView1.RowCount = Chess.GetLength(0);
            dataGridView1.ColumnCount = Chess.GetLength(1);

            
            for (int i = 0; i < Chess.GetLength(0); i++)
            {
                for (int j = 0; j < Chess.GetLength(1); j++)
                {
                    dataGridView1[j, i].Value = Chess[i, j];
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ResetForm();
            ChessState initialState = new ChessState();
            List<(Action, int, int, int)> path = new List<(Action, int, int, int)>();

            BacktrackingSolver solver = new BacktrackingSolver();

            if (solver.Solve(initialState, path, 0))
            {
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();

                dataGridView2.Columns.Add("Path", "Path");
                dataGridView2.Columns.Add("Action", "Action");
                dataGridView2.Columns.Add("Coordinates", "Coordinates");

                dataGridView1.ClearSelection(); 

                int initialX = initialState.X;
                int initialY = initialState.Y;
                dataGridView1[initialX, initialY].Style.BackColor = System.Drawing.Color.Green;
                dataGridView1[initialX, initialY].Style.ForeColor = System.Drawing.Color.White;

                foreach (var (action, step, x, y) in path)
                {
                    initialState.ApplyOperator(action);

                    dataGridView1[initialState.X, initialState.Y].Style.BackColor = System.Drawing.Color.Green;
                    dataGridView1[initialState.X, initialState.Y].Style.ForeColor = System.Drawing.Color.White;

                    dataGridView2.Rows.Add(step, action, $"({initialState.X}, {initialState.Y})");

                   
                }

                dataGridView1.Refresh();

                MessageBox.Show("Path found.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No path found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void depthFirstButton_CheckedChanged(object sender, EventArgs e)
        {
            ResetForm(); ResetForm();
            ChessState initialState = new ChessState();
            List<(Action, int, int, int)> path = new List<(Action, int, int, int)>();

            DepthFirstSolver solver = new DepthFirstSolver();

            if (solver.Solve(initialState, path, 0))
            {
                dataGridView1.ClearSelection();
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();

                dataGridView2.Columns.Add("Path", "Path");
                dataGridView2.Columns.Add("Action", "Action");
                dataGridView2.Columns.Add("Coordinates", "Coordinates");

              

                int initialX = initialState.X;
                int initialY = initialState.Y;
                dataGridView1[initialX, initialY].Style.BackColor = System.Drawing.Color.Green;
                dataGridView1[initialX, initialY].Style.ForeColor = System.Drawing.Color.White;

                foreach (var (action, step, x, y) in path)
                {
                    initialState.ApplyOperator(action);

                    dataGridView1[initialState.X, initialState.Y].Style.BackColor = System.Drawing.Color.Green;
                    dataGridView1[initialState.X, initialState.Y].Style.ForeColor = System.Drawing.Color.White;

                    dataGridView2.Rows.Add(step, action, $"({initialState.X}, {initialState.Y})");

                   
                }
                dataGridView1.Refresh();

                MessageBox.Show("Path found.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No path found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void breathFirstButton_CheckedChanged(object sender, EventArgs e)
        {
            ResetForm();
            ChessState initialState = new ChessState();
            List<(Action, int, int, int)> path;

            BreadthFirstSolver solver = new BreadthFirstSolver();

            if (solver.Solve(initialState, out path))
            {
               
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();

                dataGridView2.Columns.Add("Path", "Path");
                dataGridView2.Columns.Add("Action", "Action");
                dataGridView2.Columns.Add("Coordinates", "Coordinates");


                dataGridView1.ClearSelection();
                int initialX = initialState.X;
                int initialY = initialState.Y;
                dataGridView1[initialX, initialY].Style.BackColor = System.Drawing.Color.Green;
                dataGridView1[initialX, initialY].Style.ForeColor = System.Drawing.Color.White;

                foreach (var (action, step, x, y) in path)
                {
                    initialState.ApplyOperator(action);

                    dataGridView1[initialState.X, initialState.Y].Style.BackColor = System.Drawing.Color.Green;
                    dataGridView1[initialState.X, initialState.Y].Style.ForeColor = System.Drawing.Color.White;

                   
                    dataGridView2.Rows.Add(step, action, $"({initialState.X}, {initialState.Y})");

                }

                dataGridView1.Refresh();

                MessageBox.Show("Path found.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No path found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void optimalButton_CheckedChanged(object sender, EventArgs e)
        {
            ResetForm();
            ChessState initialState = new ChessState();
            OptimalSearch solver = new OptimalSearch();
            List<(Action, int, int)> path;
            int steps;

            if (solver.Solve(initialState, out path, out steps))
            {
         
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();

              
                dataGridView2.Columns.Add("Action", "Action");
                dataGridView2.Columns.Add("X", "X");
                dataGridView2.Columns.Add("Y", "Y");

                
                foreach (var (action, x, y) in path)
                {
                    dataGridView2.Rows.Add(action, x, y);
                }

             
                MessageBox.Show($"Path found.\nTotal steps: {steps}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
                MessageBox.Show("No path found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ResetForm()
        {
            // Reset dataGridView1
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            PopulateDataGridView();

            // Reset dataGridView2
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}