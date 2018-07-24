using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace micromouse_map
{
    public class MouseMapDraw
    {
        /// <summary>
        /// 圖形顏色
        /// </summary>
        private Color backColor = Color.Red;
        /// <summary>
        /// 寬度
        /// </summary>
        private int width = 1;
        /// <summary>
        /// 長度
        /// </summary>
        private int height = 1;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="draw_color">圖形顏色</param>
        public MouseMapDraw(Color draw_color)
        {
            this.BackColor = draw_color;
        }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="draw_width">寬度</param>
        /// <param name="draw_height">長度</param>
        public MouseMapDraw(int draw_width, int draw_height)
        {
            this.Width = draw_width;
            this.Height = draw_height;
        }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="draw_color">圖形顏色</param>
        /// <param name="draw_width">寬度</param>
        /// <param name="draw_height">長度</param>
        public MouseMapDraw(Color draw_color, int draw_width, int draw_height)
        {
            this.BackColor = draw_color;
            this.Width = draw_width;
            this.Height = draw_height;
        }

        /// <summary>
        /// 建構子
        /// </summary>
        public MouseMapDraw()
        {
            
        }

        /// <summary>
        /// 圖形顏色
        /// </summary>
        public Color BackColor
        {
            get
            {
                return this.backColor;
            }
            set
            {
                this.backColor = value;
            }
        }

        /// <summary>
        /// 圖形寬度
        /// </summary>
        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        /// <summary>
        /// 圖形長度
        /// </summary>
        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        /// <summary>
        /// 建立電腦鼠地圖中的柱子
        /// </summary>
        /// <param name="location_x">柱子座標x</param>
        /// <param name="location_y">柱子座標y</param>
        public PictureBox CreatePiller(int location_x, int location_y, string Name)
        {
            // 繪圖
            PictureBox pbox = new PictureBox();
            pbox.BackColor = this.backColor;
            pbox.Location = new Point(location_x, location_y);
            pbox.Size = new Size(this.width, this.width);
            pbox.Name = Name;
            return pbox;
        }

        /// <summary>
        /// 建立電腦鼠地圖中的柱子
        /// </summary>
        /// <param name="location_x">柱子座標x</param>
        /// <param name="location_y">柱子座標Y</param>
        /// <param name="piller_size">柱子大小</param>
        public PictureBox CreatePiller(int location_x, int location_y, int piller_size, string Name)
        {
            this.Width = piller_size;
            return this.CreatePiller(location_x, location_y, Name);
        }

        /// <summary>
        /// 建立電腦鼠地圖中的柱子
        /// </summary>
        /// <param name="location_x">柱子座標x</param>
        /// <param name="location_y">柱子座標Y</param>
        /// <param name="piller_color">柱子顏色</param>
        public PictureBox CreatePiller(int location_x, int location_y, Color piller_color, string Name)
        {
            this.BackColor = piller_color;
            return this.CreatePiller(location_x, location_y, Name);
        }

        /// <summary>
        /// 建立電腦鼠地圖中的柱子
        /// </summary>
        /// <param name="location_x">柱子座標X</param>
        /// <param name="location_y">柱子座標Y</param>
        /// <param name="size_width">柱子寬度</param>
        /// <param name="piller_color">柱子顏色</param>
        public PictureBox CreatePiller(int location_x, int location_y, int size_width, Color piller_color, string Name)
        {
            this.Width = size_width;
            this.backColor = piller_color;
            return this.CreatePiller(location_x, location_y, Name);
        }

        /// <summary>
        /// 建立電腦鼠地圖中的牆面
        /// </summary>
        /// <param name="location_x">座標X</param>
        /// <param name="location_y">座標Y</param>
        /// <param name="direction">方位</param>
        public PictureBox CreateWall(int location_x, int location_y, int direction, string Name)
        {
            // 繪圖
            PictureBox pbox = new PictureBox();
            pbox.BackColor = this.backColor;
            pbox.Location = new Point(location_x, location_y);
            pbox.Size = (direction % 2) == 0
                ? new Size(this.height, this.width)
                : new Size(this.width, this.height);
            pbox.Name = Name;
            return pbox;
        }

        

        
    }
}
