using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace micromouse_map
{
    public partial class MapForm : Form
    {
        /// <summary>
        /// 繪圖類別
        /// </summary>
        private MouseMapDraw mapDrow = null;
        /// <summary>
        /// 基準座標X
        /// </summary>
        private int datum_x = 10;//335;
        /// <summary>
        /// 基準座標Y
        /// </summary>
        private int datum_y = 10;//30;
        /// <summary>
        /// 圖形物件表
        /// </summary>
        private Queue<PictureBox> drawQueue = new Queue<PictureBox>();
    
        public MapForm()
        {
            InitializeComponent();

            this.mapDrow = new MouseMapDraw();

            this.mapDrow.Width = 12;
            this.mapDrow.Height = 60;

        }

        /// <summary>
        /// 建立地圖
        /// </summary>
        private void CreateMap(int x_max, int y_max, int gap)
        {
            int x = this.datum_x, y = this.datum_y;
            int dgap = gap * 2;

            // 調整背景顏色
            this.splitContainer.Panel2.BackColor = Color.FromArgb(this.bg_red_tb.Value, this.bg_green_tb.Value, this.bg_blue_tb.Value);

            // 產生XY軸格點
            for (int lopx = 0; lopx <= x_max; lopx++)
            {
                for (int lopy = 0; lopy <= y_max; lopy++)
                {
                    this.mapDrow.BackColor = p_color_panel.BackColor;
                    PictureBox pxp = this.mapDrow.CreatePiller(x, y, lopx.ToString() + "_" + lopy.ToString());
                    this.splitContainer.Panel2.Controls.Add(pxp);   // 柱子
                    this.drawQueue.Enqueue(pxp);
                    this.mapDrow.BackColor = w_color_panel.BackColor;
                    if (lopx != x_max)
                    {
                        PictureBox px = this.mapDrow.CreateWall(x, y + this.mapDrow.Width + gap, 1, lopx.ToString() + "_" + lopy.ToString() + "_NS");
                        if (lopy != 0 && lopy != y_max)
                            px.Click += new EventHandler(this.PictureBox_Click);
                        this.splitContainer.Panel2.Controls.Add(px);   //牆面 南北向
                        this.drawQueue.Enqueue(px);
                    }
                    if (lopy != y_max)
                    {
                        PictureBox px = this.mapDrow.CreateWall(x + this.mapDrow.Width + gap, y, 0, lopx.ToString() + "_" + lopy.ToString() + "_EW");
                        if (lopx != 0 && lopx != x_max)
                            px.Click += new EventHandler(this.PictureBox_Click);
                        this.splitContainer.Panel2.Controls.Add(px);   //牆面 東西向
                        this.drawQueue.Enqueue(px);
                    }
                    x += (this.mapDrow.Height + this.mapDrow.Width + dgap);  //加上寬度
                }
                x = this.datum_x;
                y += (this.mapDrow.Height + this.mapDrow.Width + dgap);  //加上寬度
            }
        }

        /// <summary>
        /// 產生地圖
        /// </summary>
        private void GenerateMap_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            int gap = 0;
            try
            {
                x = Int16.Parse(this.x_box.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("X資料錯誤\n" + ex.Message, "警告");
            }
            try
            {
                y = Int16.Parse(this.y_box.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("X資料錯誤\n" + ex.Message, "警告");
            }
            try
            {
                gap = Int16.Parse(this.gaps.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("間隙資料錯誤\n" + ex.Message, "警告");
            }

            if (this.mapDrow == null)
                this.mapDrow = new MouseMapDraw();

            try
            {
                this.mapDrow.Height = Int16.Parse(this.height.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("寬度資料錯誤\n" + ex.Message, "警告");
            }
            try
            {
                this.mapDrow.Width = Int16.Parse(this.width.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("長度資料錯誤\n" + ex.Message, "警告");
            }
            this.CreateMap(x, y, gap);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            p.BackColor = (p.BackColor == this.splitContainer.Panel2.BackColor)
                ? this.mapDrow.BackColor
                : this.splitContainer.Panel2.BackColor;
        }

        private void clearMap_Click(object sender, EventArgs e)
        {
            // 清除原本存在的地圖
            while(this.drawQueue.Count > 0)
            {
                PictureBox pb = this.drawQueue.Dequeue();
                pb.Dispose();
            }
            this.drawQueue = new Queue<PictureBox>();
        }

        /// <summary>
        /// 柱子顏色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p_color_change(object sender, EventArgs e)
        {
            p_color_panel.BackColor = Color.FromArgb(this.p_red_tb.Value, this.p_green_tb.Value, this.p_blue_tb.Value);
            this.p_red_lab.Text = this.p_red_tb.Value.ToString();
            this.p_green_lab.Text = this.p_green_tb.Value.ToString();
            this.p_blue_lab.Text = this.p_blue_tb.Value.ToString();
        }

        /// <summary>
        /// 牆面顏色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void w_color_change(object sender, EventArgs e)
        {
            w_color_panel.BackColor = Color.FromArgb(this.w_red_tb.Value, this.w_green_tb.Value, this.w_blue_tb.Value);
            this.w_red_lab.Text = this.w_red_tb.Value.ToString();
            this.w_green_lab.Text = this.w_green_tb.Value.ToString();
            this.w_blue_lab.Text = this.w_blue_tb.Value.ToString();
        }

        /// <summary>
        /// 背景底色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bg_color_change(object sender, EventArgs e)
        {
            this.bg_color_grp.BackColor = Color.FromArgb(this.bg_red_tb.Value, this.bg_green_tb.Value, this.bg_blue_tb.Value);

            if (this.bg_green_tb.Value < 40 && this.bg_red_tb.Value < 70)
            {
                this.bg_color_grp.ForeColor = Color.White;
            }
            else if ((this.bg_red_tb.Value + this.bg_green_tb.Value) < 60)
            {
                this.bg_color_grp.ForeColor = Color.White;
            }
            else
            {
                this.bg_color_grp.ForeColor = Color.Black;
            }

            this.bg_red_lab.Text = this.bg_red_tb.Value.ToString();
            this.bg_green_lab.Text = this.bg_green_tb.Value.ToString();
            this.bg_blue_lab.Text = this.bg_blue_tb.Value.ToString();
        }

        private void test_saveimg_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(this.splitContainer.Panel2.Width, this.splitContainer.Panel2.Height);
            this.splitContainer.Panel2.DrawToBitmap(bmp, new Rectangle(0, 0, this.splitContainer.Panel2.Width, this.splitContainer.Panel2.Height));
            bmp.Save(@"D:\");
        }
    }
}
