namespace Laba4
{
    partial class MainWindow
    {
        private System.ComponentModel.IContainer components = null;
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.numberOfVerticesLabel = new System.Windows.Forms.Label();
            this.numberOfVertices = new System.Windows.Forms.TextBox();
            this.createAdjacencyMatrixBtn = new System.Windows.Forms.Button();
            this.clearAdjacencyMatrixBtn = new System.Windows.Forms.Button();
            this.adjacencyMatrix = new System.Windows.Forms.DataGridView();
            this.adjacencyMatrixLabel = new System.Windows.Forms.Label();
            this.BuildAlgoritmBtn = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.AlgoritmLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adjacencyMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfVerticesLabel
            // 
            this.numberOfVerticesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numberOfVerticesLabel.AutoSize = true;
            this.numberOfVerticesLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.numberOfVerticesLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.numberOfVerticesLabel.Location = new System.Drawing.Point(8, 16);
            this.numberOfVerticesLabel.Name = "numberOfVerticesLabel";
            this.numberOfVerticesLabel.Size = new System.Drawing.Size(357, 22);
            this.numberOfVerticesLabel.TabIndex = 0;
            this.numberOfVerticesLabel.Text = "Введите количество вершин графа:";
            // 
            // numberOfVertices
            // 
            this.numberOfVertices.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numberOfVertices.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numberOfVertices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberOfVertices.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.numberOfVertices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.numberOfVertices.Location = new System.Drawing.Point(371, 12);
            this.numberOfVertices.MinimumSize = new System.Drawing.Size(0, 25);
            this.numberOfVertices.Name = "numberOfVertices";
            this.numberOfVertices.Size = new System.Drawing.Size(50, 31);
            this.numberOfVertices.TabIndex = 1;
            this.numberOfVertices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberOfVertices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfVertices_KeyPress);
            // 
            // createAdjacencyMatrixBtn
            // 
            this.createAdjacencyMatrixBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createAdjacencyMatrixBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.createAdjacencyMatrixBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAdjacencyMatrixBtn.FlatAppearance.BorderSize = 0;
            this.createAdjacencyMatrixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAdjacencyMatrixBtn.Location = new System.Drawing.Point(442, 12);
            this.createAdjacencyMatrixBtn.Name = "createAdjacencyMatrixBtn";
            this.createAdjacencyMatrixBtn.Size = new System.Drawing.Size(229, 31);
            this.createAdjacencyMatrixBtn.TabIndex = 2;
            this.createAdjacencyMatrixBtn.Text = "Создать матрицу смежности";
            this.createAdjacencyMatrixBtn.UseVisualStyleBackColor = false;
            this.createAdjacencyMatrixBtn.Click += new System.EventHandler(this.createAdjacencyMatrixBtn_Click);
            // 
            // clearAdjacencyMatrixBtn
            // 
            this.clearAdjacencyMatrixBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearAdjacencyMatrixBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.clearAdjacencyMatrixBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearAdjacencyMatrixBtn.FlatAppearance.BorderSize = 0;
            this.clearAdjacencyMatrixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAdjacencyMatrixBtn.Location = new System.Drawing.Point(687, 12);
            this.clearAdjacencyMatrixBtn.Name = "clearAdjacencyMatrixBtn";
            this.clearAdjacencyMatrixBtn.Size = new System.Drawing.Size(156, 31);
            this.clearAdjacencyMatrixBtn.TabIndex = 3;
            this.clearAdjacencyMatrixBtn.Text = "Очистить";
            this.clearAdjacencyMatrixBtn.UseVisualStyleBackColor = false;
            this.clearAdjacencyMatrixBtn.Click += new System.EventHandler(this.clearAdjacencyMatrixBtn_Click);
            // 
            // adjacencyMatrix
            // 
            this.adjacencyMatrix.AllowUserToAddRows = false;
            this.adjacencyMatrix.AllowUserToDeleteRows = false;
            this.adjacencyMatrix.AllowUserToResizeColumns = false;
            this.adjacencyMatrix.AllowUserToResizeRows = false;
            this.adjacencyMatrix.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adjacencyMatrix.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.adjacencyMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adjacencyMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.adjacencyMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.adjacencyMatrix.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adjacencyMatrix.DefaultCellStyle = dataGridViewCellStyle2;
            this.adjacencyMatrix.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.adjacencyMatrix.Location = new System.Drawing.Point(249, 91);
            this.adjacencyMatrix.Name = "adjacencyMatrix";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adjacencyMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.adjacencyMatrix.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.adjacencyMatrix.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.adjacencyMatrix.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.adjacencyMatrix.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.adjacencyMatrix.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.adjacencyMatrix.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.adjacencyMatrix.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.adjacencyMatrix.Size = new System.Drawing.Size(594, 422);
            this.adjacencyMatrix.TabIndex = 4;
            // 
            // adjacencyMatrixLabel
            // 
            this.adjacencyMatrixLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adjacencyMatrixLabel.AutoSize = true;
            this.adjacencyMatrixLabel.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.adjacencyMatrixLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.adjacencyMatrixLabel.Location = new System.Drawing.Point(279, 57);
            this.adjacencyMatrixLabel.Name = "adjacencyMatrixLabel";
            this.adjacencyMatrixLabel.Size = new System.Drawing.Size(259, 18);
            this.adjacencyMatrixLabel.TabIndex = 5;
            this.adjacencyMatrixLabel.Text = "Введите матрицу смежности:";
            // 
            // BuildAlgoritmBtn
            // 
            this.BuildAlgoritmBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BuildAlgoritmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.BuildAlgoritmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuildAlgoritmBtn.FlatAppearance.BorderSize = 0;
            this.BuildAlgoritmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuildAlgoritmBtn.Location = new System.Drawing.Point(328, 569);
            this.BuildAlgoritmBtn.Name = "BuildAlgoritmBtn";
            this.BuildAlgoritmBtn.Size = new System.Drawing.Size(229, 35);
            this.BuildAlgoritmBtn.TabIndex = 6;
            this.BuildAlgoritmBtn.Text = "Построить алгоритм Эйлера";
            this.BuildAlgoritmBtn.UseVisualStyleBackColor = false;
            this.BuildAlgoritmBtn.Click += new System.EventHandler(this.BuildAlgoritmBtn_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Arial", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(297, 535);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(312, 21);
            this.ErrorLabel.TabIndex = 7;
            this.ErrorLabel.Text = "Эйлерова цикла не существует!";
            this.ErrorLabel.Visible = false;
            // 
            // AlgoritmLabel
            // 
            this.AlgoritmLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AlgoritmLabel.AutoSize = true;
            this.AlgoritmLabel.Font = new System.Drawing.Font("Arial", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.AlgoritmLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AlgoritmLabel.Location = new System.Drawing.Point(324, 535);
            this.AlgoritmLabel.Name = "AlgoritmLabel";
            this.AlgoritmLabel.Size = new System.Drawing.Size(131, 21);
            this.AlgoritmLabel.TabIndex = 8;
            this.AlgoritmLabel.Text = "Цикл Эйлера:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(872, 625);
            this.Controls.Add(this.AlgoritmLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.BuildAlgoritmBtn);
            this.Controls.Add(this.adjacencyMatrixLabel);
            this.Controls.Add(this.adjacencyMatrix);
            this.Controls.Add(this.clearAdjacencyMatrixBtn);
            this.Controls.Add(this.createAdjacencyMatrixBtn);
            this.Controls.Add(this.numberOfVertices);
            this.Controls.Add(this.numberOfVerticesLabel);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №4";
            ((System.ComponentModel.ISupportInitialize)(this.adjacencyMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberOfVerticesLabel;
        private System.Windows.Forms.TextBox numberOfVertices;
        private System.Windows.Forms.Button createAdjacencyMatrixBtn;
        private System.Windows.Forms.Button clearAdjacencyMatrixBtn;
        private System.Windows.Forms.DataGridView adjacencyMatrix;
        private System.Windows.Forms.Label adjacencyMatrixLabel;
        private System.Windows.Forms.Button BuildAlgoritmBtn;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label AlgoritmLabel;
    }
}

