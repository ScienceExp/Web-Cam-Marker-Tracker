using System;
using System.Drawing;
using System.Windows.Forms;

namespace WebCam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webCapture1.Start();
            timer1.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (webCapture1 != null)
                webCapture1.Closeinterfaces();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point m1 = webCapture1.TopMarker;
            Point m2 = webCapture1.BottomMarker;
            cm1.X = (int)Lerp(cm1.X, m1.X, speed);
            cm1.Y = (int)Lerp(cm1.Y, m1.Y, speed);
            cm2.X = (int)Lerp(cm2.X, m2.X, speed);
            cm2.Y = (int)Lerp(cm2.Y, m2.Y, speed);

            lblMarker1.Text = cm1.X.ToString() + " , " + cm1.Y.ToString();
            lblMarker2.Text = cm2.X.ToString() + " , " + cm2.Y.ToString();
        }

        #region Testing Lerp for smoother transition
        float speed = 0.8f;
        Point cm1 = new Point();
        Point cm2 = new Point();

        public static float Lerp(float startValue, float endValue, float speed)
        {
            if (speed < 0f)
                speed = 0f;
            else if (speed > 1f)
                speed = 1f;

            return startValue + (endValue - startValue) * speed;
        }
        #endregion
    }
}
