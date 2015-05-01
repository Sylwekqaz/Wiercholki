namespace GraphPanel
{
    partial class GraphPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnGenerateMatrix = new System.Windows.Forms.Button();
            this.btnAddVertex = new System.Windows.Forms.Button();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.Workspace = new System.Windows.Forms.Panel();
            this.BottomMenu = new System.Windows.Forms.TabControl();
            this.SelectTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.AddVertexTab = new System.Windows.Forms.TabPage();
            this.cbAutoCompleteGraph = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddEdgeTab = new System.Windows.Forms.TabPage();
            this.cbDirected = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EditVertexTab = new System.Windows.Forms.TabPage();
            this.tbVertexY = new System.Windows.Forms.NumericUpDown();
            this.tbVertexX = new System.Windows.Forms.NumericUpDown();
            this.btnRemoveVertex = new System.Windows.Forms.Button();
            this.tbVertexLabel = new System.Windows.Forms.TextBox();
            this.lblVertexDegree = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditEdgeTab = new System.Windows.Forms.TabPage();
            this.btnRemoveEdge = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.BottomMenu.SuspendLayout();
            this.SelectTab.SuspendLayout();
            this.AddVertexTab.SuspendLayout();
            this.AddEdgeTab.SuspendLayout();
            this.EditVertexTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVertexY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVertexX)).BeginInit();
            this.EditEdgeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Workspace, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BottomMenu, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(679, 298);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.btnSelect);
            this.flowLayoutPanel1.Controls.Add(this.btnAddVertex);
            this.flowLayoutPanel1.Controls.Add(this.btnAddEdge);
            this.flowLayoutPanel1.Controls.Add(this.btnGenerateMatrix);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(673, 44);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(3, 3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Zaznacz";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelectClick);
            // 
            // btnGenerateMatrix
            // 
            this.btnGenerateMatrix.Location = new System.Drawing.Point(302, 3);
            this.btnGenerateMatrix.Name = "btnGenerateMatrix";
            this.btnGenerateMatrix.Size = new System.Drawing.Size(187, 23);
            this.btnGenerateMatrix.TabIndex = 0;
            this.btnGenerateMatrix.Text = "Generuj Macierz Sąsiedztwa";
            this.btnGenerateMatrix.UseVisualStyleBackColor = true;
            this.btnGenerateMatrix.Click += new System.EventHandler(this.btnGenerateMatrix_Click);
            // 
            // btnAddVertex
            // 
            this.btnAddVertex.Location = new System.Drawing.Point(84, 3);
            this.btnAddVertex.Name = "btnAddVertex";
            this.btnAddVertex.Size = new System.Drawing.Size(113, 23);
            this.btnAddVertex.TabIndex = 1;
            this.btnAddVertex.Text = "Dodaj Wierzchołek";
            this.btnAddVertex.UseVisualStyleBackColor = true;
            this.btnAddVertex.Click += new System.EventHandler(this.BtnAddVertexClick);
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.Location = new System.Drawing.Point(203, 3);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(93, 23);
            this.btnAddEdge.TabIndex = 2;
            this.btnAddEdge.Text = "Dodaj krawędź";
            this.btnAddEdge.UseVisualStyleBackColor = true;
            this.btnAddEdge.Click += new System.EventHandler(this.BtnAddEdgeClick);
            // 
            // Workspace
            // 
            this.Workspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Workspace.Location = new System.Drawing.Point(3, 53);
            this.Workspace.Name = "Workspace";
            this.Workspace.Size = new System.Drawing.Size(673, 142);
            this.Workspace.TabIndex = 1;
            this.Workspace.Paint += new System.Windows.Forms.PaintEventHandler(this.Workspace_Paint);
            this.Workspace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GrapchMouseDown);
            this.Workspace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GrapchMouseMove);
            this.Workspace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GrapchMouseUp);
            this.Workspace.Resize += new System.EventHandler(this.Workspace_Resize);
            // 
            // BottomMenu
            // 
            this.BottomMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.BottomMenu.Controls.Add(this.SelectTab);
            this.BottomMenu.Controls.Add(this.AddVertexTab);
            this.BottomMenu.Controls.Add(this.AddEdgeTab);
            this.BottomMenu.Controls.Add(this.EditVertexTab);
            this.BottomMenu.Controls.Add(this.EditEdgeTab);
            this.BottomMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomMenu.ItemSize = new System.Drawing.Size(0, 1);
            this.BottomMenu.Location = new System.Drawing.Point(3, 201);
            this.BottomMenu.Name = "BottomMenu";
            this.BottomMenu.SelectedIndex = 0;
            this.BottomMenu.Size = new System.Drawing.Size(673, 94);
            this.BottomMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.BottomMenu.TabIndex = 2;
            this.BottomMenu.SelectedIndexChanged += new System.EventHandler(this.BottomMenu_SelectedIndexChanged);
            // 
            // SelectTab
            // 
            this.SelectTab.Controls.Add(this.label1);
            this.SelectTab.Location = new System.Drawing.Point(4, 5);
            this.SelectTab.Name = "SelectTab";
            this.SelectTab.Size = new System.Drawing.Size(665, 85);
            this.SelectTab.TabIndex = 3;
            this.SelectTab.Text = "Select";
            this.SelectTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kliknij na krawędź lub wierzchołek aby zaznaczyć ";
            // 
            // AddVertexTab
            // 
            this.AddVertexTab.Controls.Add(this.cbAutoCompleteGraph);
            this.AddVertexTab.Controls.Add(this.label2);
            this.AddVertexTab.Location = new System.Drawing.Point(4, 5);
            this.AddVertexTab.Name = "AddVertexTab";
            this.AddVertexTab.Size = new System.Drawing.Size(665, 85);
            this.AddVertexTab.TabIndex = 4;
            this.AddVertexTab.Text = "Add vertex";
            this.AddVertexTab.UseVisualStyleBackColor = true;
            // 
            // cbAutoCompleteGraph
            // 
            this.cbAutoCompleteGraph.AutoSize = true;
            this.cbAutoCompleteGraph.Location = new System.Drawing.Point(6, 16);
            this.cbAutoCompleteGraph.Name = "cbAutoCompleteGraph";
            this.cbAutoCompleteGraph.Size = new System.Drawing.Size(224, 17);
            this.cbAutoCompleteGraph.TabIndex = 1;
            this.cbAutoCompleteGraph.Text = "Dodaj automatycznie wszystkie krawędzie";
            this.cbAutoCompleteGraph.UseVisualStyleBackColor = true;
            this.cbAutoCompleteGraph.CheckedChanged += new System.EventHandler(this.cbAutoCompleteGraph_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kliknij na białym polu aby dodać wieszchołek";
            // 
            // AddEdgeTab
            // 
            this.AddEdgeTab.Controls.Add(this.cbDirected);
            this.AddEdgeTab.Controls.Add(this.label3);
            this.AddEdgeTab.Location = new System.Drawing.Point(4, 5);
            this.AddEdgeTab.Name = "AddEdgeTab";
            this.AddEdgeTab.Size = new System.Drawing.Size(665, 85);
            this.AddEdgeTab.TabIndex = 5;
            this.AddEdgeTab.Text = "Add edge";
            this.AddEdgeTab.UseVisualStyleBackColor = true;
            // 
            // cbDirected
            // 
            this.cbDirected.AutoSize = true;
            this.cbDirected.Location = new System.Drawing.Point(3, 16);
            this.cbDirected.Name = "cbDirected";
            this.cbDirected.Size = new System.Drawing.Size(124, 17);
            this.cbDirected.TabIndex = 1;
            this.cbDirected.Text = "Krawędź skierowana";
            this.cbDirected.UseVisualStyleBackColor = true;
            this.cbDirected.CheckedChanged += new System.EventHandler(this.cbDirected_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(570, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kliknij na wierzchołek aby zaznaczyć pierwszy wierzchołek, a póżniej kliknij kole" +
    "jny wierzchołek aby dodać połączenie";
            // 
            // EditVertexTab
            // 
            this.EditVertexTab.Controls.Add(this.tbVertexY);
            this.EditVertexTab.Controls.Add(this.tbVertexX);
            this.EditVertexTab.Controls.Add(this.btnRemoveVertex);
            this.EditVertexTab.Controls.Add(this.tbVertexLabel);
            this.EditVertexTab.Controls.Add(this.lblVertexDegree);
            this.EditVertexTab.Controls.Add(this.X);
            this.EditVertexTab.Controls.Add(this.label6);
            this.EditVertexTab.Controls.Add(this.label5);
            this.EditVertexTab.Controls.Add(this.label4);
            this.EditVertexTab.Location = new System.Drawing.Point(4, 5);
            this.EditVertexTab.Name = "EditVertexTab";
            this.EditVertexTab.Size = new System.Drawing.Size(665, 85);
            this.EditVertexTab.TabIndex = 6;
            this.EditVertexTab.Text = "Edit vertex";
            this.EditVertexTab.UseVisualStyleBackColor = true;
            // 
            // tbVertexY
            // 
            this.tbVertexY.Location = new System.Drawing.Point(141, 37);
            this.tbVertexY.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.tbVertexY.Name = "tbVertexY";
            this.tbVertexY.Size = new System.Drawing.Size(52, 20);
            this.tbVertexY.TabIndex = 10;
            this.tbVertexY.ValueChanged += new System.EventHandler(this.tbVertexY_ValueChanged);
            // 
            // tbVertexX
            // 
            this.tbVertexX.Location = new System.Drawing.Point(141, 4);
            this.tbVertexX.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.tbVertexX.Name = "tbVertexX";
            this.tbVertexX.Size = new System.Drawing.Size(52, 20);
            this.tbVertexX.TabIndex = 9;
            this.tbVertexX.ValueChanged += new System.EventHandler(this.tbVertexX_ValueChanged);
            // 
            // btnRemoveVertex
            // 
            this.btnRemoveVertex.Location = new System.Drawing.Point(217, 32);
            this.btnRemoveVertex.Name = "btnRemoveVertex";
            this.btnRemoveVertex.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveVertex.TabIndex = 8;
            this.btnRemoveVertex.Text = "Usuń";
            this.btnRemoveVertex.UseVisualStyleBackColor = true;
            this.btnRemoveVertex.Click += new System.EventHandler(this.btnRemoveVertex_Click);
            // 
            // tbVertexLabel
            // 
            this.tbVertexLabel.Location = new System.Drawing.Point(54, 3);
            this.tbVertexLabel.Name = "tbVertexLabel";
            this.tbVertexLabel.Size = new System.Drawing.Size(58, 20);
            this.tbVertexLabel.TabIndex = 5;
            this.tbVertexLabel.TextChanged += new System.EventHandler(this.tbVertexLabel_TextChanged);
            // 
            // lblVertexDegree
            // 
            this.lblVertexDegree.AutoSize = true;
            this.lblVertexDegree.Location = new System.Drawing.Point(52, 37);
            this.lblVertexDegree.Name = "lblVertexDegree";
            this.lblVertexDegree.Size = new System.Drawing.Size(35, 13);
            this.lblVertexDegree.TabIndex = 4;
            this.lblVertexDegree.Text = "label8";
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(118, 6);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(17, 13);
            this.X.TabIndex = 3;
            this.X.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Stopień:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Etykieta: ";
            // 
            // EditEdgeTab
            // 
            this.EditEdgeTab.Controls.Add(this.btnRemoveEdge);
            this.EditEdgeTab.Location = new System.Drawing.Point(4, 5);
            this.EditEdgeTab.Name = "EditEdgeTab";
            this.EditEdgeTab.Size = new System.Drawing.Size(665, 85);
            this.EditEdgeTab.TabIndex = 7;
            this.EditEdgeTab.Text = "Edit edge";
            this.EditEdgeTab.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEdge
            // 
            this.btnRemoveEdge.Location = new System.Drawing.Point(3, 3);
            this.btnRemoveEdge.Name = "btnRemoveEdge";
            this.btnRemoveEdge.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveEdge.TabIndex = 0;
            this.btnRemoveEdge.Text = "Usuń";
            this.btnRemoveEdge.UseVisualStyleBackColor = true;
            this.btnRemoveEdge.Click += new System.EventHandler(this.btnRemoveEdge_Click);
            // 
            // GraphPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GraphPanel";
            this.Size = new System.Drawing.Size(679, 298);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.BottomMenu.ResumeLayout(false);
            this.SelectTab.ResumeLayout(false);
            this.SelectTab.PerformLayout();
            this.AddVertexTab.ResumeLayout(false);
            this.AddVertexTab.PerformLayout();
            this.AddEdgeTab.ResumeLayout(false);
            this.AddEdgeTab.PerformLayout();
            this.EditVertexTab.ResumeLayout(false);
            this.EditVertexTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVertexY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVertexX)).EndInit();
            this.EditEdgeTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAddVertex;
        private System.Windows.Forms.Button btnGenerateMatrix;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.Panel Workspace;
        private System.Windows.Forms.TabControl BottomMenu;
        private System.Windows.Forms.TabPage SelectTab;
        private System.Windows.Forms.TabPage AddVertexTab;
        private System.Windows.Forms.TabPage AddEdgeTab;
        private System.Windows.Forms.TabPage EditVertexTab;
        private System.Windows.Forms.TabPage EditEdgeTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbAutoCompleteGraph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbDirected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVertexLabel;
        private System.Windows.Forms.Label lblVertexDegree;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveVertex;
        private System.Windows.Forms.Button btnRemoveEdge;
        private System.Windows.Forms.NumericUpDown tbVertexY;
        private System.Windows.Forms.NumericUpDown tbVertexX;
    }
}
