using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Laba4
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            adjacencyMatrix.Visible = false;
            adjacencyMatrixLabel.Visible = false;
            AlgoritmLabel.Visible = false;
            BuildAlgoritmBtn.Enabled = false;
            ErrorLabel.Visible = false;
        }

        private int count;
        private void createAdjacencyMatrixBtn_Click(object sender, EventArgs e)
        {
            try
            {
                count = Convert.ToInt32(numberOfVertices.Text);
            } catch {
                MessageBox.Show("Введите количество вершин графа!");
            }
            

            adjacencyMatrixLabel.Visible = true;
            adjacencyMatrix.Visible = true;

            adjacencyMatrix.RowCount = count + 1;
            adjacencyMatrix.ColumnCount = count + 1;


            for (int i = 0; i < count + 1; i++)
            {
                adjacencyMatrix.Columns[i].Width = 35;
                adjacencyMatrix.Rows[i].Height = 35;
            }

            int numberCharColumns = 1;
            for (int i = 0; i < count; i++)
            {
                adjacencyMatrix[i + 1, 0].Value = numberCharColumns;
                adjacencyMatrix[i + 1, 0].ReadOnly = true;
                adjacencyMatrix[i + 1, 0].Style.BackColor = System.Drawing.Color.LightGray;
                numberCharColumns++;
            }

            int numberCharRows = 1;
            for (int j = 0; j < count; j++)
            {
                adjacencyMatrix[0, j + 1].Value = numberCharRows;
                adjacencyMatrix[0, j + 1].ReadOnly = true;
                adjacencyMatrix[0, j + 1].Style.BackColor = System.Drawing.Color.LightGray;
                numberCharRows++;
            }

            adjacencyMatrix[0, 0].ReadOnly = true;
            adjacencyMatrix[0, 0].Style.BackColor = System.Drawing.Color.LightGray;


            BuildAlgoritmBtn.Enabled = true;
        }

        private void BuildAlgoritmBtn_Click(object sender, EventArgs e)
        {
            adjacencyMatrixLabel.Visible = true;
            adjacencyMatrix.Visible = true;

            adjacencyMatrix[0, 0].Selected = true;
            int count = Convert.ToInt32(numberOfVertices.Text);

            int[,] adjMatrixArr = new int[count, count];
            for (int i = 1; i < count+1; i++)
            {
                for (int j = 1; j  < count+1; j ++)
                {
                    adjMatrixArr[i - 1, j - 1] = Convert.ToInt32(adjacencyMatrix[i, j].Value);
                }
            }

            BuildEulerCycle(adjMatrixArr);
        }

        private void BuildEulerCycle(int[,] adjMatrixArr)
        {
            int count = Convert.ToInt32(numberOfVertices.Text);
            int[] vertices = new int[count]; 
            bool correct = true;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (adjMatrixArr[i, j] == adjMatrixArr[j, i])
                    {
                        if (adjMatrixArr[i, j] == 1)
                        {
                            vertices[i] += 1;
                        }
                    }
                    else
                    {
                        correct = false;
                        break;
                    }
                }
            }

            for (int i = 0; i < count; i++)
            {
                if (vertices[i] % 2 == 1) {
                    correct = false;
                    break;
                }
            }

            if (correct && CheckingConnectivity(adjMatrixArr, count))
            {
                ErrorLabel.Visible = false;
                AlgoritmLabel.Visible = true;

                var result = new Stack<int>();
                var stack = new Stack<int>();
                stack.Push(0);
                while (stack.Count > 0)
                {
                    int lastVertices = stack.Peek();
                    if (!NumberOfAdjacentVertices(adjMatrixArr, lastVertices, count))
                    {
                        result.Push(stack.Pop()+1);
                    }
                    for (int i = 0; i < count; i++)
                    {
                        if (adjMatrixArr[lastVertices, i] == 1)
                        {
                            adjMatrixArr[lastVertices, i] = 0;
                            adjMatrixArr[i, lastVertices] = 0;
                            stack.Push(i);
                            break;
                        }
                    }
                }
                
                AlgoritmLabel.Text = "Цикл Эйлера: " + string.Join(", ", result.ToArray());
            } else
            {
                ErrorLabel.Visible = true;
                AlgoritmLabel.Visible = false;
            }
        }

        private static bool NumberOfAdjacentVertices(int[,] matrix, int vertices, int count)
        {
            int k = 0;
            for (int j = 0; j < count; j++)
            {
                if (matrix[vertices, j] == 1) k++;
            }
            if (k > 0) return true; else return false;
        }

        private static bool CheckingConnectivity(int[,] adjMatrix, int count)
        {
            var visited = new Stack<int>();
            var stack = new Stack<int>();
            stack.Push(0);
            bool[] mark = new bool[count];
            mark[0] = true;
            while (stack.Count > 0)
            {
                visited.Push(stack.Pop());
                int lastVertices = visited.Peek();

                for (int i = 0; i < count; i++)
                {
                    if ((adjMatrix[lastVertices, i] == 1) && (!mark[i]))
                    {
                        mark[i] = true;
                        stack.Push(i);
                    }
                }
            }

            if (visited.Count == count) return true;
            else return false;
        }

        private void clearAdjacencyMatrixBtn_Click(object sender, EventArgs e)
        {
            adjacencyMatrix.Visible = false;
            adjacencyMatrixLabel.Visible = false;
            AlgoritmLabel.Visible = false;
            ErrorLabel.Visible = false;
            BuildAlgoritmBtn.Enabled = false;

            int count = Convert.ToInt32(numberOfVertices.Text);
            for (int i = 1; i < count + 1; i++)
            {
                for (int j = 1; j < count + 1; j++)
                {
                    adjacencyMatrix[i, j].Value = "";
                    adjacencyMatrix[i, j].Selected = false;
                }
            }

            for (int i = 0; i < count + 1; i++)
            {
                for (int j = 0; j < count + 1; j++)
                {
                    adjacencyMatrix[i, j].Selected = false;
                }
            }
            adjacencyMatrix[0, 0].Selected = true;
            adjacencyMatrix[0, 0].ReadOnly = true;
            adjacencyMatrix[0, 0].Style.BackColor = System.Drawing.Color.LightGray;

            numberOfVertices.Text = "";
        }

        private void numberOfVertices_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
