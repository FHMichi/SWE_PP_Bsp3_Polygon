using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace SWE_PP_Bsp3_Polygon
{
    public partial class Form1 : Form
    {
        const float minX = -1.1f;
        const float maxX = 1.1f;
        const float minY = -1.1f;
        const float maxY = 1.1f;
        public Form1()
        {
            InitializeComponent();

        }

        private void chkDiagonalen_CheckedChanged(object sender, EventArgs e)
        {
            pic.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 3; i <= 100; i++)
            {
                cbEcken.Items.Add(i);
            }
            cbEcken.SelectedIndex = 0;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            z.SmoothingMode = SmoothingMode.AntiAlias;


            float breite = maxX - minX;
            float hoehe = maxY - minY;

            Matrix myMatrix = new Matrix();
            //Koordinatensytem skalieren:
            myMatrix.Scale(pic.ClientSize.Width / breite,
                           pic.ClientSize.Height / hoehe);
            //Nullpunkt verschieben 
            myMatrix.Translate(-minX, -minY, MatrixOrder.Prepend);

            z.Transform = myMatrix;  //Matrix anwenden

            Pen p = new Pen(Color.Black, 0.01f);

            // z.DrawEllipse(p, -1f, -1f, 2f, 2f);  //Kreis zum testen
            int edges = Convert.ToInt32(cbEcken.SelectedItem);

            float w = 2f * MathF.PI / (float)edges;
            float w1 = 0f;
            float w2 = 0f;


            if (!chkDiagonalen.Checked)
            {
                for (int i = 1; i <= edges; i++)
                {
                    w1 = i * w;
                    w2 = (i - 1) * w;
                    z.DrawLine(p, MathF.Cos(w1), MathF.Sin(w1),
                                  MathF.Cos(w2), MathF.Sin(w2));
                }
            }
            else
            {
                //alle Ecken durchgehen(bis auf die letzte)
                for(int i= 1; i < edges; i++)
                {
                    //nun alle linien zu folge ecken zeichnen
                    for(int j = i+1; j <= edges; j++)
                    {
                        w1 = i * w;
                        w2 = j * w;
                        z.DrawLine(p, MathF.Cos(w1), MathF.Sin(w1),
                                      MathF.Cos(w2), MathF.Sin(w2));
                    }

                }
            }

        }

        private void cbEcken_SelectedIndexChanged(object sender, EventArgs e)
        {
            pic.Invalidate();
        }

        private void pic_Resize(object sender, EventArgs e)
        {
            pic.Invalidate();
        }
    }
}
