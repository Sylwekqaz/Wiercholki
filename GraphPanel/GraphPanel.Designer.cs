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
            this.btnAddVertex = new System.Windows.Forms.Button();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.btnSerchWay = new System.Windows.Forms.Button();
            this.Workspace = new System.Windows.Forms.Panel();
            this.BottomMenu = new System.Windows.Forms.TabControl();
            this.SelectTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.AddVertexTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.AddEdgeTab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAddEdgeValue = new System.Windows.Forms.TextBox();
            this.cbDirected = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.WayLabel = new System.Windows.Forms.Label();
            this.EndVertexLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.StartVertexLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.label8 = new System.Windows.Forms.Label();
            this.tbEditEdgeValue = new System.Windows.Forms.TextBox();
            this.btnRemoveEdge = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.BottomMenu.SuspendLayout();
            this.SelectTab.SuspendLayout();
            this.AddVertexTab.SuspendLayout();
            this.AddEdgeTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.flowLayoutPanel1.Controls.Add(this.btnSerchWay);
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
            // btnSerchWay
            // 
            this.btnSerchWay.Location = new System.Drawing.Point(302, 3);
            this.btnSerchWay.Name = "btnSerchWay";
            this.btnSerchWay.Size = new System.Drawing.Size(93, 23);
            this.btnSerchWay.TabIndex = 2;
            this.btnSerchWay.Text = "Szukaj drogi";
            this.btnSerchWay.UseVisualStyleBackColor = true;
            this.btnSerchWay.Click += new System.EventHandler(this.BtnSerchWayClick);
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
            this.BottomMenu.Controls.Add(this.tabPage1);
            this.BottomMenu.Controls.Add(this.EditVertexTab);
            this.BottomMenu.Controls.Add(this.EditEdgeTab);
            this.BottomMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomMenu.ItemSize = new System.Drawing.Size(0, 2);
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
            this.SelectTab.AutoScroll = true;
            this.SelectTab.Controls.Add(this.label1);
            this.SelectTab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SelectTab.Location = new System.Drawing.Point(4, 24);
            this.SelectTab.Name = "SelectTab";
            this.SelectTab.Size = new System.Drawing.Size(665, 66);
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
            this.AddVertexTab.Controls.Add(this.label2);
            this.AddVertexTab.Location = new System.Drawing.Point(4, 24);
            this.AddVertexTab.Name = "AddVertexTab";
            this.AddVertexTab.Size = new System.Drawing.Size(665, 66);
            this.AddVertexTab.TabIndex = 4;
            this.AddVertexTab.Text = "Add vertex";
            this.AddVertexTab.UseVisualStyleBackColor = true;
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
            this.AddEdgeTab.Controls.Add(this.label7);
            this.AddEdgeTab.Controls.Add(this.tbAddEdgeValue);
            this.AddEdgeTab.Controls.Add(this.cbDirected);
            this.AddEdgeTab.Controls.Add(this.label3);
            this.AddEdgeTab.Location = new System.Drawing.Point(4, 24);
            this.AddEdgeTab.Name = "AddEdgeTab";
            this.AddEdgeTab.Size = new System.Drawing.Size(665, 66);
            this.AddEdgeTab.TabIndex = 5;
            this.AddEdgeTab.Text = "Add edge";
            this.AddEdgeTab.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Waga";
            // 
            // tbAddEdgeValue
            // 
            this.tbAddEdgeValue.Location = new System.Drawing.Point(48, 36);
            this.tbAddEdgeValue.Name = "tbAddEdgeValue";
            this.tbAddEdgeValue.Size = new System.Drawing.Size(100, 20);
            this.tbAddEdgeValue.TabIndex = 2;
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.WayLabel);
            this.tabPage1.Controls.Add(this.EndVertexLabel);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.StartVertexLabel);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(665, 84);
            this.tabPage1.TabIndex = 8;
            this.tabPage1.Text = "SearchWay";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // WayLabel
            // 
            this.WayLabel.AutoSize = true;
            this.WayLabel.Location = new System.Drawing.Point(94, 43);
            this.WayLabel.Name = "WayLabel";
            this.WayLabel.Size = new System.Drawing.Size(65, 13);
            this.WayLabel.TabIndex = 5;
            this.WayLabel.Text = "Początkowy";
            // 
            // EndVertexLabel
            // 
            this.EndVertexLabel.AutoSize = true;
            this.EndVertexLabel.Location = new System.Drawing.Point(94, 30);
            this.EndVertexLabel.Name = "EndVertexLabel";
            this.EndVertexLabel.Size = new System.Drawing.Size(65, 13);
            this.EndVertexLabel.TabIndex = 4;
            this.EndVertexLabel.Text = "Początkowy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Długość ścieżki";
            // 
            // StartVertexLabel
            // 
            this.StartVertexLabel.AutoSize = true;
            this.StartVertexLabel.Location = new System.Drawing.Point(94, 17);
            this.StartVertexLabel.Name = "StartVertexLabel";
            this.StartVertexLabel.Size = new System.Drawing.Size(65, 13);
            this.StartVertexLabel.TabIndex = 2;
            this.StartVertexLabel.Text = "Początkowy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Początkowy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Końcowy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(413, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Zaznacz lewym przyciskiem początkowy wieszchołek i prawym końcowy wieszchołek";
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
            this.EditVertexTab.Location = new System.Drawing.Point(4, 24);
            this.EditVertexTab.Name = "EditVertexTab";
            this.EditVertexTab.Size = new System.Drawing.Size(665, 66);
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
            this.EditEdgeTab.Controls.Add(this.label8);
            this.EditEdgeTab.Controls.Add(this.tbEditEdgeValue);
            this.EditEdgeTab.Controls.Add(this.btnRemoveEdge);
            this.EditEdgeTab.Location = new System.Drawing.Point(4, 24);
            this.EditEdgeTab.Name = "EditEdgeTab";
            this.EditEdgeTab.Size = new System.Drawing.Size(665, 66);
            this.EditEdgeTab.TabIndex = 7;
            this.EditEdgeTab.Text = "Edit edge";
            this.EditEdgeTab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Waga";
            // 
            // tbEditEdgeValue
            // 
            this.tbEditEdgeValue.Location = new System.Drawing.Point(45, 3);
            this.tbEditEdgeValue.Name = "tbEditEdgeValue";
            this.tbEditEdgeValue.Size = new System.Drawing.Size(100, 20);
            this.tbEditEdgeValue.TabIndex = 4;
            this.tbEditEdgeValue.TextChanged += new System.EventHandler(this.tbEditEdgeValue_TextChanged);
            // 
            // btnRemoveEdge
            // 
            this.btnRemoveEdge.Location = new System.Drawing.Point(6, 29);
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.EditVertexTab.ResumeLayout(false);
            this.EditVertexTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVertexY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVertexX)).EndInit();
            this.EditEdgeTab.ResumeLayout(false);
            this.EditEdgeTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAddVertex;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.Panel Workspace;
        private System.Windows.Forms.TabControl BottomMenu;
        private System.Windows.Forms.TabPage SelectTab;
        private System.Windows.Forms.TabPage AddVertexTab;
        private System.Windows.Forms.TabPage AddEdgeTab;
        private System.Windows.Forms.TabPage EditVertexTab;
        private System.Windows.Forms.TabPage EditEdgeTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAddEdgeValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEditEdgeValue;
        private System.Windows.Forms.CheckBox cbDirected;
        private System.Windows.Forms.Button btnSerchWay;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label WayLabel;
        private System.Windows.Forms.Label EndVertexLabel;
        private System.Windows.Forms.Label StartVertexLabel;
    }
}
