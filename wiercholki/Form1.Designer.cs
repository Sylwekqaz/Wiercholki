namespace wiercholki
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.newGraphButton = new System.Windows.Forms.Button();
            this.openGraphButton = new System.Windows.Forms.Button();
            this.saveGraphButton = new System.Windows.Forms.Button();
            this.vertexModeButton = new System.Windows.Forms.RadioButton();
            this.edgeModeButton = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.mainPanel = new wiercholki.DisplayPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainPanel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.61582F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.38418F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 354);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.edgeModeButton);
            this.panel2.Controls.Add(this.vertexModeButton);
            this.panel2.Location = new System.Drawing.Point(3, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 47);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.newGraphButton);
            this.flowLayoutPanel1.Controls.Add(this.openGraphButton);
            this.flowLayoutPanel1.Controls.Add(this.saveGraphButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(544, 28);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // newGraphButton
            // 
            this.newGraphButton.Location = new System.Drawing.Point(3, 3);
            this.newGraphButton.Name = "newGraphButton";
            this.newGraphButton.Size = new System.Drawing.Size(75, 23);
            this.newGraphButton.TabIndex = 0;
            this.newGraphButton.Text = "Nowy";
            this.newGraphButton.UseVisualStyleBackColor = true;
            this.newGraphButton.Click += new System.EventHandler(this.newGraphButton_Click);
            // 
            // openGraphButton
            // 
            this.openGraphButton.Location = new System.Drawing.Point(84, 3);
            this.openGraphButton.Name = "openGraphButton";
            this.openGraphButton.Size = new System.Drawing.Size(75, 23);
            this.openGraphButton.TabIndex = 1;
            this.openGraphButton.Text = "Otwórz";
            this.openGraphButton.UseVisualStyleBackColor = true;
            // 
            // saveGraphButton
            // 
            this.saveGraphButton.Location = new System.Drawing.Point(165, 3);
            this.saveGraphButton.Name = "saveGraphButton";
            this.saveGraphButton.Size = new System.Drawing.Size(75, 23);
            this.saveGraphButton.TabIndex = 2;
            this.saveGraphButton.Text = "Zapisz";
            this.saveGraphButton.UseVisualStyleBackColor = true;
            // 
            // vertexModeButton
            // 
            this.vertexModeButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.vertexModeButton.AutoSize = true;
            this.vertexModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vertexModeButton.Location = new System.Drawing.Point(96, 0);
            this.vertexModeButton.Name = "vertexModeButton";
            this.vertexModeButton.Size = new System.Drawing.Size(102, 25);
            this.vertexModeButton.TabIndex = 2;
            this.vertexModeButton.TabStop = true;
            this.vertexModeButton.Text = "Rysuj wierzchołki";
            this.vertexModeButton.UseVisualStyleBackColor = true;
            this.vertexModeButton.Click += new System.EventHandler(this.vertexModeButton_Click);
            // 
            // edgeModeButton
            // 
            this.edgeModeButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.edgeModeButton.AutoSize = true;
            this.edgeModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edgeModeButton.Location = new System.Drawing.Point(239, 0);
            this.edgeModeButton.Name = "edgeModeButton";
            this.edgeModeButton.Size = new System.Drawing.Size(96, 25);
            this.edgeModeButton.TabIndex = 3;
            this.edgeModeButton.TabStop = true;
            this.edgeModeButton.Text = "Rysuj krawędzie";
            this.edgeModeButton.UseVisualStyleBackColor = true;
            this.edgeModeButton.Click += new System.EventHandler(this.edgeModeButton_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.AutoSize = true;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Location = new System.Drawing.Point(384, 0);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 25);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Zaznacz";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Bitmap = null;
            this.mainPanel.Location = new System.Drawing.Point(3, 37);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(544, 261);
            this.mainPanel.TabIndex = 3;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseClick);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 378);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button openGraphButton;
        private System.Windows.Forms.Button newGraphButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button saveGraphButton;
        private DisplayPanel mainPanel;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton edgeModeButton;
        private System.Windows.Forms.RadioButton vertexModeButton;

    }
}

