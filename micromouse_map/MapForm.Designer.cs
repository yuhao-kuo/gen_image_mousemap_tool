namespace micromouse_map
{
    partial class MapForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.x_box = new System.Windows.Forms.RichTextBox();
            this.y_box = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerateMap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Coordinate = new System.Windows.Forms.GroupBox();
            this.Output = new System.Windows.Forms.GroupBox();
            this.gaps = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.RichTextBox();
            this.width = new System.Windows.Forms.RichTextBox();
            this.clearMap = new System.Windows.Forms.Button();
            this.p_red_tb = new System.Windows.Forms.TrackBar();
            this.p_green_tb = new System.Windows.Forms.TrackBar();
            this.p_blue_tb = new System.Windows.Forms.TrackBar();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.bg_color_grp = new System.Windows.Forms.GroupBox();
            this.bg_blue_lab = new System.Windows.Forms.Label();
            this.bg_green_lab = new System.Windows.Forms.Label();
            this.bg_red_lab = new System.Windows.Forms.Label();
            this.bg_blue_tb = new System.Windows.Forms.TrackBar();
            this.bg_green_tb = new System.Windows.Forms.TrackBar();
            this.bg_red_tb = new System.Windows.Forms.TrackBar();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.p_color_panel = new System.Windows.Forms.Panel();
            this.p_blue_lab = new System.Windows.Forms.Label();
            this.p_green_lab = new System.Windows.Forms.Label();
            this.p_red_lab = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.w_color_panel = new System.Windows.Forms.Panel();
            this.w_blue_lab = new System.Windows.Forms.Label();
            this.w_green_lab = new System.Windows.Forms.Label();
            this.w_red_lab = new System.Windows.Forms.Label();
            this.w_blue_tb = new System.Windows.Forms.TrackBar();
            this.w_green_tb = new System.Windows.Forms.TrackBar();
            this.w_red_tb = new System.Windows.Forms.TrackBar();
            this.Coordinate.SuspendLayout();
            this.Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_red_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_green_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_blue_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.bg_color_grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bg_blue_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_green_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_red_tb)).BeginInit();
            this.groupbox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.w_blue_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_green_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_red_tb)).BeginInit();
            this.SuspendLayout();
            // 
            // x_box
            // 
            this.x_box.Location = new System.Drawing.Point(87, 43);
            this.x_box.Margin = new System.Windows.Forms.Padding(4);
            this.x_box.Name = "x_box";
            this.x_box.Size = new System.Drawing.Size(120, 49);
            this.x_box.TabIndex = 0;
            this.x_box.Text = "10";
            // 
            // y_box
            // 
            this.y_box.Location = new System.Drawing.Point(87, 112);
            this.y_box.Margin = new System.Windows.Forms.Padding(4);
            this.y_box.Name = "y_box";
            this.y_box.Size = new System.Drawing.Size(120, 49);
            this.y_box.TabIndex = 1;
            this.y_box.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // GenerateMap
            // 
            this.GenerateMap.Location = new System.Drawing.Point(62, 626);
            this.GenerateMap.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateMap.Name = "GenerateMap";
            this.GenerateMap.Size = new System.Drawing.Size(118, 36);
            this.GenerateMap.TabIndex = 4;
            this.GenerateMap.Text = "產生地圖";
            this.GenerateMap.UseVisualStyleBackColor = true;
            this.GenerateMap.Click += new System.EventHandler(this.GenerateMap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "長度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(21, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "寬度";
            // 
            // Coordinate
            // 
            this.Coordinate.Controls.Add(this.y_box);
            this.Coordinate.Controls.Add(this.x_box);
            this.Coordinate.Controls.Add(this.label1);
            this.Coordinate.Controls.Add(this.label2);
            this.Coordinate.Location = new System.Drawing.Point(13, 13);
            this.Coordinate.Margin = new System.Windows.Forms.Padding(4);
            this.Coordinate.Name = "Coordinate";
            this.Coordinate.Padding = new System.Windows.Forms.Padding(4);
            this.Coordinate.Size = new System.Drawing.Size(243, 183);
            this.Coordinate.TabIndex = 7;
            this.Coordinate.TabStop = false;
            this.Coordinate.Text = "地圖大小";
            // 
            // Output
            // 
            this.Output.Controls.Add(this.gaps);
            this.Output.Controls.Add(this.label5);
            this.Output.Controls.Add(this.height);
            this.Output.Controls.Add(this.width);
            this.Output.Controls.Add(this.label3);
            this.Output.Controls.Add(this.label4);
            this.Output.Location = new System.Drawing.Point(13, 203);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(243, 252);
            this.Output.TabIndex = 8;
            this.Output.TabStop = false;
            this.Output.Text = "牆面資訊";
            // 
            // gaps
            // 
            this.gaps.Location = new System.Drawing.Point(97, 177);
            this.gaps.Margin = new System.Windows.Forms.Padding(4);
            this.gaps.Name = "gaps";
            this.gaps.Size = new System.Drawing.Size(120, 49);
            this.gaps.TabIndex = 10;
            this.gaps.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(21, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "空隙";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(97, 114);
            this.height.Margin = new System.Windows.Forms.Padding(4);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(120, 49);
            this.height.TabIndex = 8;
            this.height.Text = "40";
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(97, 45);
            this.width.Margin = new System.Windows.Forms.Padding(4);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(120, 49);
            this.width.TabIndex = 7;
            this.width.Text = "12";
            // 
            // clearMap
            // 
            this.clearMap.Location = new System.Drawing.Point(62, 680);
            this.clearMap.Margin = new System.Windows.Forms.Padding(4);
            this.clearMap.Name = "clearMap";
            this.clearMap.Size = new System.Drawing.Size(118, 36);
            this.clearMap.TabIndex = 9;
            this.clearMap.Text = "清除地圖";
            this.clearMap.UseVisualStyleBackColor = true;
            this.clearMap.Click += new System.EventHandler(this.clearMap_Click);
            // 
            // p_red_tb
            // 
            this.p_red_tb.Location = new System.Drawing.Point(26, 43);
            this.p_red_tb.Maximum = 255;
            this.p_red_tb.Name = "p_red_tb";
            this.p_red_tb.Size = new System.Drawing.Size(263, 56);
            this.p_red_tb.TabIndex = 10;
            this.p_red_tb.TickFrequency = 10;
            this.p_red_tb.Scroll += new System.EventHandler(this.p_color_change);
            // 
            // p_green_tb
            // 
            this.p_green_tb.Location = new System.Drawing.Point(26, 94);
            this.p_green_tb.Maximum = 255;
            this.p_green_tb.Name = "p_green_tb";
            this.p_green_tb.Size = new System.Drawing.Size(263, 56);
            this.p_green_tb.TabIndex = 11;
            this.p_green_tb.TickFrequency = 10;
            this.p_green_tb.Scroll += new System.EventHandler(this.p_color_change);
            // 
            // p_blue_tb
            // 
            this.p_blue_tb.Location = new System.Drawing.Point(26, 147);
            this.p_blue_tb.Maximum = 255;
            this.p_blue_tb.Name = "p_blue_tb";
            this.p_blue_tb.Size = new System.Drawing.Size(263, 56);
            this.p_blue_tb.TabIndex = 12;
            this.p_blue_tb.TickFrequency = 10;
            this.p_blue_tb.Scroll += new System.EventHandler(this.p_color_change);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel1.Controls.Add(this.bg_color_grp);
            this.splitContainer.Panel1.Controls.Add(this.groupbox2);
            this.splitContainer.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer.Panel1.Controls.Add(this.Coordinate);
            this.splitContainer.Panel1.Controls.Add(this.clearMap);
            this.splitContainer.Panel1.Controls.Add(this.GenerateMap);
            this.splitContainer.Panel1.Controls.Add(this.Output);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer.Size = new System.Drawing.Size(1355, 768);
            this.splitContainer.SplitterDistance = 622;
            this.splitContainer.TabIndex = 13;
            // 
            // bg_color_grp
            // 
            this.bg_color_grp.BackColor = System.Drawing.Color.White;
            this.bg_color_grp.Controls.Add(this.bg_blue_lab);
            this.bg_color_grp.Controls.Add(this.bg_green_lab);
            this.bg_color_grp.Controls.Add(this.bg_red_lab);
            this.bg_color_grp.Controls.Add(this.bg_blue_tb);
            this.bg_color_grp.Controls.Add(this.bg_green_tb);
            this.bg_color_grp.Controls.Add(this.bg_red_tb);
            this.bg_color_grp.Location = new System.Drawing.Point(263, 523);
            this.bg_color_grp.Name = "bg_color_grp";
            this.bg_color_grp.Size = new System.Drawing.Size(350, 205);
            this.bg_color_grp.TabIndex = 15;
            this.bg_color_grp.TabStop = false;
            this.bg_color_grp.Text = "背景顏色";
            // 
            // bg_blue_lab
            // 
            this.bg_blue_lab.AutoSize = true;
            this.bg_blue_lab.Location = new System.Drawing.Point(295, 141);
            this.bg_blue_lab.Name = "bg_blue_lab";
            this.bg_blue_lab.Size = new System.Drawing.Size(36, 20);
            this.bg_blue_lab.TabIndex = 18;
            this.bg_blue_lab.Text = "255";
            // 
            // bg_green_lab
            // 
            this.bg_green_lab.AutoSize = true;
            this.bg_green_lab.Location = new System.Drawing.Point(295, 88);
            this.bg_green_lab.Name = "bg_green_lab";
            this.bg_green_lab.Size = new System.Drawing.Size(36, 20);
            this.bg_green_lab.TabIndex = 17;
            this.bg_green_lab.Text = "255";
            // 
            // bg_red_lab
            // 
            this.bg_red_lab.AutoSize = true;
            this.bg_red_lab.Location = new System.Drawing.Point(295, 40);
            this.bg_red_lab.Name = "bg_red_lab";
            this.bg_red_lab.Size = new System.Drawing.Size(36, 20);
            this.bg_red_lab.TabIndex = 16;
            this.bg_red_lab.Text = "255";
            // 
            // bg_blue_tb
            // 
            this.bg_blue_tb.Location = new System.Drawing.Point(26, 144);
            this.bg_blue_tb.Maximum = 255;
            this.bg_blue_tb.Name = "bg_blue_tb";
            this.bg_blue_tb.Size = new System.Drawing.Size(263, 56);
            this.bg_blue_tb.TabIndex = 15;
            this.bg_blue_tb.TickFrequency = 10;
            this.bg_blue_tb.Value = 255;
            this.bg_blue_tb.Scroll += new System.EventHandler(this.bg_color_change);
            // 
            // bg_green_tb
            // 
            this.bg_green_tb.Location = new System.Drawing.Point(26, 91);
            this.bg_green_tb.Maximum = 255;
            this.bg_green_tb.Name = "bg_green_tb";
            this.bg_green_tb.Size = new System.Drawing.Size(263, 56);
            this.bg_green_tb.TabIndex = 14;
            this.bg_green_tb.TickFrequency = 10;
            this.bg_green_tb.Value = 255;
            this.bg_green_tb.Scroll += new System.EventHandler(this.bg_color_change);
            // 
            // bg_red_tb
            // 
            this.bg_red_tb.Location = new System.Drawing.Point(26, 40);
            this.bg_red_tb.Maximum = 255;
            this.bg_red_tb.Name = "bg_red_tb";
            this.bg_red_tb.Size = new System.Drawing.Size(263, 56);
            this.bg_red_tb.TabIndex = 13;
            this.bg_red_tb.TickFrequency = 10;
            this.bg_red_tb.Value = 255;
            this.bg_red_tb.Scroll += new System.EventHandler(this.bg_color_change);
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.p_color_panel);
            this.groupbox2.Controls.Add(this.p_blue_lab);
            this.groupbox2.Controls.Add(this.p_green_lab);
            this.groupbox2.Controls.Add(this.p_red_lab);
            this.groupbox2.Controls.Add(this.p_red_tb);
            this.groupbox2.Controls.Add(this.p_green_tb);
            this.groupbox2.Controls.Add(this.p_blue_tb);
            this.groupbox2.Location = new System.Drawing.Point(263, 13);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(350, 249);
            this.groupbox2.TabIndex = 14;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "柱子顏色";
            // 
            // p_color_panel
            // 
            this.p_color_panel.BackColor = System.Drawing.Color.Black;
            this.p_color_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_color_panel.Location = new System.Drawing.Point(155, 198);
            this.p_color_panel.Name = "p_color_panel";
            this.p_color_panel.Size = new System.Drawing.Size(36, 36);
            this.p_color_panel.TabIndex = 16;
            // 
            // p_blue_lab
            // 
            this.p_blue_lab.AutoSize = true;
            this.p_blue_lab.Location = new System.Drawing.Point(295, 147);
            this.p_blue_lab.Name = "p_blue_lab";
            this.p_blue_lab.Size = new System.Drawing.Size(18, 20);
            this.p_blue_lab.TabIndex = 15;
            this.p_blue_lab.Text = "0";
            // 
            // p_green_lab
            // 
            this.p_green_lab.AutoSize = true;
            this.p_green_lab.Location = new System.Drawing.Point(295, 94);
            this.p_green_lab.Name = "p_green_lab";
            this.p_green_lab.Size = new System.Drawing.Size(18, 20);
            this.p_green_lab.TabIndex = 14;
            this.p_green_lab.Text = "0";
            // 
            // p_red_lab
            // 
            this.p_red_lab.AutoSize = true;
            this.p_red_lab.Location = new System.Drawing.Point(295, 46);
            this.p_red_lab.Name = "p_red_lab";
            this.p_red_lab.Size = new System.Drawing.Size(18, 20);
            this.p_red_lab.TabIndex = 13;
            this.p_red_lab.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.w_color_panel);
            this.groupBox1.Controls.Add(this.w_blue_lab);
            this.groupBox1.Controls.Add(this.w_green_lab);
            this.groupBox1.Controls.Add(this.w_red_lab);
            this.groupBox1.Controls.Add(this.w_blue_tb);
            this.groupBox1.Controls.Add(this.w_green_tb);
            this.groupBox1.Controls.Add(this.w_red_tb);
            this.groupBox1.Location = new System.Drawing.Point(263, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 249);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "牆面顏色";
            // 
            // w_color_panel
            // 
            this.w_color_panel.BackColor = System.Drawing.Color.Black;
            this.w_color_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.w_color_panel.ForeColor = System.Drawing.Color.Black;
            this.w_color_panel.Location = new System.Drawing.Point(26, 195);
            this.w_color_panel.Name = "w_color_panel";
            this.w_color_panel.Size = new System.Drawing.Size(287, 36);
            this.w_color_panel.TabIndex = 19;
            // 
            // w_blue_lab
            // 
            this.w_blue_lab.AutoSize = true;
            this.w_blue_lab.Location = new System.Drawing.Point(295, 141);
            this.w_blue_lab.Name = "w_blue_lab";
            this.w_blue_lab.Size = new System.Drawing.Size(18, 20);
            this.w_blue_lab.TabIndex = 18;
            this.w_blue_lab.Text = "0";
            // 
            // w_green_lab
            // 
            this.w_green_lab.AutoSize = true;
            this.w_green_lab.Location = new System.Drawing.Point(295, 88);
            this.w_green_lab.Name = "w_green_lab";
            this.w_green_lab.Size = new System.Drawing.Size(18, 20);
            this.w_green_lab.TabIndex = 17;
            this.w_green_lab.Text = "0";
            // 
            // w_red_lab
            // 
            this.w_red_lab.AutoSize = true;
            this.w_red_lab.Location = new System.Drawing.Point(295, 40);
            this.w_red_lab.Name = "w_red_lab";
            this.w_red_lab.Size = new System.Drawing.Size(18, 20);
            this.w_red_lab.TabIndex = 16;
            this.w_red_lab.Text = "0";
            // 
            // w_blue_tb
            // 
            this.w_blue_tb.Location = new System.Drawing.Point(26, 144);
            this.w_blue_tb.Maximum = 255;
            this.w_blue_tb.Name = "w_blue_tb";
            this.w_blue_tb.Size = new System.Drawing.Size(263, 56);
            this.w_blue_tb.TabIndex = 15;
            this.w_blue_tb.TickFrequency = 10;
            this.w_blue_tb.Scroll += new System.EventHandler(this.w_color_change);
            // 
            // w_green_tb
            // 
            this.w_green_tb.Location = new System.Drawing.Point(26, 91);
            this.w_green_tb.Maximum = 255;
            this.w_green_tb.Name = "w_green_tb";
            this.w_green_tb.Size = new System.Drawing.Size(263, 56);
            this.w_green_tb.TabIndex = 14;
            this.w_green_tb.TickFrequency = 10;
            this.w_green_tb.Scroll += new System.EventHandler(this.w_color_change);
            // 
            // w_red_tb
            // 
            this.w_red_tb.Location = new System.Drawing.Point(26, 40);
            this.w_red_tb.Maximum = 255;
            this.w_red_tb.Name = "w_red_tb";
            this.w_red_tb.Size = new System.Drawing.Size(263, 56);
            this.w_red_tb.TabIndex = 13;
            this.w_red_tb.TickFrequency = 10;
            this.w_red_tb.Scroll += new System.EventHandler(this.w_color_change);
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 768);
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MapForm";
            this.Text = "老鼠地圖產生器";
            this.Coordinate.ResumeLayout(false);
            this.Coordinate.PerformLayout();
            this.Output.ResumeLayout(false);
            this.Output.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_red_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_green_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_blue_tb)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.bg_color_grp.ResumeLayout(false);
            this.bg_color_grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bg_blue_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_green_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_red_tb)).EndInit();
            this.groupbox2.ResumeLayout(false);
            this.groupbox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.w_blue_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_green_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_red_tb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox x_box;
        private System.Windows.Forms.RichTextBox y_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenerateMap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Coordinate;
        private System.Windows.Forms.GroupBox Output;
        private System.Windows.Forms.RichTextBox height;
        private System.Windows.Forms.RichTextBox width;
        private System.Windows.Forms.Button clearMap;
        private System.Windows.Forms.TrackBar p_red_tb;
        private System.Windows.Forms.TrackBar p_green_tb;
        private System.Windows.Forms.TrackBar p_blue_tb;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar w_blue_tb;
        private System.Windows.Forms.TrackBar w_green_tb;
        private System.Windows.Forms.TrackBar w_red_tb;
        private System.Windows.Forms.Label p_red_lab;
        private System.Windows.Forms.Label p_blue_lab;
        private System.Windows.Forms.Label p_green_lab;
        private System.Windows.Forms.Label w_blue_lab;
        private System.Windows.Forms.Label w_green_lab;
        private System.Windows.Forms.Label w_red_lab;
        private System.Windows.Forms.RichTextBox gaps;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox bg_color_grp;
        private System.Windows.Forms.Label bg_blue_lab;
        private System.Windows.Forms.Label bg_green_lab;
        private System.Windows.Forms.Label bg_red_lab;
        private System.Windows.Forms.TrackBar bg_blue_tb;
        private System.Windows.Forms.TrackBar bg_green_tb;
        private System.Windows.Forms.TrackBar bg_red_tb;
        private System.Windows.Forms.Panel p_color_panel;
        private System.Windows.Forms.Panel w_color_panel;


    }
}

