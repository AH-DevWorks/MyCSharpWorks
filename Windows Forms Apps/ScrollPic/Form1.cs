using System.Windows.Forms;

namespace ScrollPic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Width = 600; Height = 520;
            CenterToScreen();
        }

        // 最初PictureBox呈現為：圖片原始尺寸的20％
        // Scroll拉到最大時，PictureBox變成原先的5倍 → 來到圖片的原始尺寸
        // 記憶各張圖每次選中時調整的尺寸及Scroll位置

        // 4 Small Pictures

        // 以readonly的Size陣列記錄各圖原始尺寸
        // 原先欲搭配比例調整作法(未採用)
        /*readonly Size[] picOriSizes = new Size[]
        {
            new Size(525, 295),
            new Size(525, 295),
            new Size(525, 295),
            new Size(525, 295)
        };
        const int maxWidth = 525;
        const int maxHeight = 295;
        Size[] currentSizes = new Size[4];*/

        //以二維陣列儲存各圖寬高 --- 搭配線性插值法（Linear Interpolation）
        readonly double[,] picOriginalSizes = new double[,]
        {
            { 525, 295 }, { 525, 295 }, { 525, 295 }, { 525, 295 }
        };
        double[,] picSize;
        int minWidth = 105;
        int maxWidth = 525;
        int minHeight = 59;
        int maxHeight = 295;
        double scaleDownRate = 0.2;

        private void Form1_Load(object sender, EventArgs e)
        {
            picSize = new double[picOriginalSizes.GetLength(0), picOriginalSizes.GetLength(1)];
            for(int i = 0; i < picOriginalSizes.GetLength(0); i++)
            {
                for(int j = 0; j < picOriginalSizes.GetLength(1); j++)
                {
                    picSize[i , j] = picOriginalSizes[i , j] * scaleDownRate;
                }
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ClientSize = new Size((int)picSize[0, 0], (int)picSize[0, 1]);
            pictureBox1.Image = Image.FromFile("../../../Resources\\001.jpg");

            pictureBox2.Image = Image.FromFile("../../../Resources\\001.jpg");
            pictureBox3.Image = Image.FromFile("../../../Resources\\002.jpg");
            pictureBox4.Image = Image.FromFile("../../../Resources\\003.jpg");
            pictureBox5.Image = Image.FromFile("../../../Resources\\004.jpg");

            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = 109;
            hScrollBar1.Value = 0;
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = 109;
            vScrollBar1.Value = 0;

            toolTip1.SetToolTip(trackBar1, "1");
            toolTip1.SetToolTip(hScrollBar1, $"{minWidth} pix");
            toolTip1.SetToolTip(vScrollBar1, $"{minHeight} pix");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBar1, $"{trackBar1.Value + 1}");
            LoadSelectedPic();
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            PicWidthChange();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            PicHeightChange();
        }

        private void PicWidthChange()
        {
            // 基於圖片實際尺寸(max)＆初始尺寸(min)的Linear Interpolation
            double wScale = (double)hScrollBar1.Value / 100;
            int newWidth = (int)(minWidth + (maxWidth - minWidth) * wScale);
            pictureBox1.Width = newWidth;
            picSize[trackBar1.Value, 0] = newWidth;

            toolTip1.SetToolTip(hScrollBar1, $"{newWidth} pix");

            // 其他：用比例計算(原始尺寸1，初始尺寸20%)的方法 --- 未採用
            // 須以每次修改後該圖的縱橫捲軸位置反推並記錄當下Value
            // 換算較複雜且在切換chosenPicNum時容易出錯
            /*double refScale = minScale + (maxScale - minScale) * hScrollBar1.Value / 100.0;
            int newWidth = Convert.ToInt32( maxWidth * refScale);
            currentSizes[chosenPicNum - 1].Width = newWidth;
            pictureBox1.Width = newWidth;
            toolTip1.SetToolTip(hScrollBar1, $"{newWidth} pix");*/
        }
        private void PicHeightChange()
        {
            double hScale = (double)vScrollBar1.Value / 100;
            int newHeight = (int)(minHeight + (maxHeight - minHeight) * hScale);
            pictureBox1.Height = newHeight;
            picSize[trackBar1.Value, 1] = newHeight;

            toolTip1.SetToolTip(vScrollBar1, $"{newHeight} pix");

            // 未採用: double refScale = minScale + (maxScale - minScale) * hScrollBar1.Value / 100.0;
        }
        private void LoadSelectedPic()
        {
            pictureBox1.ClientSize = new Size((int)picSize[trackBar1.Value, 0], (int)picSize[trackBar1.Value, 1]);
            pictureBox1.Image = Image.FromFile($"../../../Resources\\00{trackBar1.Value + 1}.jpg");
            hScrollBar1.Value = (int)((picSize[trackBar1.Value, 0] - minWidth) *100 / (maxWidth - minWidth));
            vScrollBar1.Value = (int)((picSize[trackBar1.Value, 1] - minHeight) *100 / (maxHeight - minHeight));
        }
    }
}
