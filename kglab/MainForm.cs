using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace kglab {
    public partial class MainForm : Form {
        private Pen axisPen;
        private Pen netPen;
        private int pxPerCm;

        private double angle;

        Point3D[] cube;

        public MainForm() {
            InitializeComponent();

            axisPen = new Pen(Color.FromArgb(255, 155, 155, 155), 2);
            netPen = new Pen(Color.FromArgb(255,230,230,230), 1);
            pxPerCm = 10;

            updateCube();
        }

        //Обновление куба
        private void updateCube() {
            int xn = (int)nudTX.Value;
            int yn = (int)nudTY.Value;
            int zn = (int)nudTZ.Value;

            //Создаем точки куба
            cube = new Point3D[] {
                new Point3D(0, 0, 0),
                new Point3D(xn, 0, 0),
                new Point3D(xn, yn, 0),
                new Point3D(0, yn, 0),
                new Point3D(0, 0, zn),
                new Point3D(xn, 0, zn),
                new Point3D(xn, yn, zn),
                new Point3D(0, yn, zn)
            };
        }


        //Поворот куба
        private Point3D[] rotate(Point3D[] points, double angleX, double angleY, double angleZ) {
            return Perspective.RotateX(Perspective.RotateZ(Perspective.RotateY(points, angleY), angleZ), angleX);
        }



        //Отрисовка комплексного чертежа точки
        private void pb1_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int centerX = pb1.Width / 2;
            int centerY = pb1.Height / 2;


            //Рисуем сетку
            for (int x = pxPerCm; x < centerX; x += pxPerCm) {
                g.DrawLine(netPen, new Point(centerX - x, 5), new Point(centerX - x, pb1.Height - 5));
                g.DrawLine(netPen, new Point(centerX + x, 5), new Point(centerX + x, pb1.Height - 5));
            }

            for (int y = pxPerCm; y < centerY; y += pxPerCm) {
                g.DrawLine(netPen, new Point(5, centerY - y), new Point(pb1.Width - 5, centerY - y));
                g.DrawLine(netPen, new Point(5, centerY + y), new Point(pb1.Width - 5, centerY + y));
            }

            g.DrawLine(axisPen, new Point(centerX, 5), new Point(centerX, pb1.Height - 5));
            g.DrawLine(axisPen, new Point(5, centerY), new Point(pb1.Width - 5, centerY));



            //Создаем и рисуем комплексный чертеж точки
            Point3D t = new Point3D((int)nudTX.Value, (int)nudTY.Value, (int)nudTZ.Value);

            g.DrawLines(Pens.BlueViolet, Point3D.PrepareDrawCoords(t.GetAllComprehensivePoints(), centerX, centerY));

            PointF[] points = Point3D.PrepareDrawCoords(t.GetComprehensivePoints(), centerX, centerY);

            for (int i = 0; i < points.Length; i++) {
                g.FillEllipse(Brushes.BlueViolet, points[i].X - 3, points[i].Y - 3, 7, 7);

                string name = "T" + (i + 1).ToString();
                SizeF nameSize = g.MeasureString(name, Font);
                g.DrawString(name, Font, Brushes.BlueViolet, new PointF(
                    points[i].X - centerX < 0 ? points[i].X - 3 - (int)nameSize.Width : points[i].X + 3,
                    points[i].Y - centerY < 0 ? points[i].Y - 3 - (int)nameSize.Height : points[i].Y + 3
                ));
            }

        }



        //Отрисовка аксонометрического чертежа 
        private void pb2_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int centerX = pb1.Width / 2;
            int centerY = pb1.Height / 2;
            float zoom = (float)Math.Sqrt( Math.Pow((double)nudCX.Value,2) + Math.Pow((double)nudCY.Value,2) + Math.Pow((double)nudCZ.Value,2) ) / pxPerCm;

            //Высчитываем угол
            double angleX, angleY, angleZ;
            if (!tmrDemoRatate.Enabled) {
                angleX = -Math.PI / 2 + Math.Atan2((double)nudCZ.Value, (double)nudCY.Value);
                angleY = 0; // Math.Atan2((double)nudCZ.Value, (double)nudCX.Value);
                angleZ = Math.Atan2((double)-nudCY.Value, (double)-nudCX.Value);
            } else {
                angleX = angle;
                angleY = angle;
                angleZ = angle;
            }


            //Готовимся рисовать сетку
            int xNetLinesCount = centerX / pxPerCm;
            int yNetLinesCount = centerY / pxPerCm;

            Point3D[] xNet = new Point3D[xNetLinesCount * 4];
            Point3D[] yNet = new Point3D[yNetLinesCount * 4];

            for (int i = 0, j = pxPerCm; i < xNet.Length; i += 4, j += pxPerCm) {
                //Формируем сетку по X
                xNet[i] = new Point3D(j, -centerY, 0);
                xNet[i + 1] = new Point3D(j, centerY, 0);

                xNet[i + 2] = new Point3D(-j, -centerY, 0);
                xNet[i + 3] = new Point3D(-j, centerY, 0);
            }

            for (int i = 0, j = pxPerCm; i < yNet.Length; i += 4, j += pxPerCm) {
                //Формируем сетку по Y
                yNet[i] = new Point3D(-centerX, j, 0);
                yNet[i + 1] = new Point3D(centerY, j, 0);

                yNet[i + 2] = new Point3D(-centerY, -j, 0);
                yNet[i + 3] = new Point3D(centerY, -j, 0);
            }

            //Поворачиваем линии сетки
            xNet = rotate(xNet, angleX, angleY, angleZ);
            yNet = rotate(yNet, angleX, angleY, angleZ);

            //Формируем точки для отрисовки
            PointF[] xNetPoints = Perspective.PrepareDrawCoords(xNet, centerX, centerY, zoom);
            PointF[] yNetPoints = Perspective.PrepareDrawCoords(yNet, centerX, centerY, zoom);

            //Отрисовываем сетку
            for (int i = 0; i < xNetPoints.Length; i += 2)
                g.DrawLine(netPen, xNetPoints[i], xNetPoints[i + 1]);

            for (int i = 0; i < yNetPoints.Length; i += 2)
                g.DrawLine(netPen, yNetPoints[i], yNetPoints[i + 1]);

            //Формируем точки осей
            PointF[] axiesPoints = Perspective.PrepareDrawCoords(
                rotate(new Point3D[] {
                    new Point3D(-centerX, 0, 0),
                    new Point3D(centerX, 0, 0),
                    new Point3D(0, -centerY, 0),
                    new Point3D(0, centerY, 0),
                    new Point3D(0, 0, 0),
                    new Point3D(0, 0, centerY)
                }, angleX, angleY, angleZ),
                centerX, 
                centerY,
                zoom
            );

            //Отрисовываем оси
            for (int i = 0; i < axiesPoints.Length; i += 2)
                g.DrawLine(axisPen, axiesPoints[i], axiesPoints[i+1]);
            

            //Поворачиваем точки куба
            Point3D[] rotatedCube = rotate(cube, angleX, angleY, angleZ);

            //Формируем отдельные части из точек, для отрисовки
            Point3D[][] sides = new Point3D[][] {
                new Point3D[] { rotatedCube[0], rotatedCube[1], rotatedCube[2], rotatedCube[3] },
                new Point3D[] { rotatedCube[1], rotatedCube[5], rotatedCube[6], rotatedCube[2] },
                new Point3D[] { rotatedCube[5], rotatedCube[4], rotatedCube[7], rotatedCube[6] },
                new Point3D[] { rotatedCube[4], rotatedCube[0], rotatedCube[3], rotatedCube[7] }
            };

            //Рисуем куб
            foreach (Point3D[] side in sides)
                g.DrawLines(Pens.BlueViolet, Perspective.PrepareDrawCoords(side, centerX, centerY, zoom));

        }



        //Перерисовка при изменении размера
        private void pb1_Resize(object sender, EventArgs e) {
            pb1.Refresh();
        }

        //Перерисовка при изменении размера
        private void pb2_Resize(object sender, EventArgs e) {
            pb2.Refresh();
        }

        //Обновление таймером
        private void timer1_Tick(object sender, EventArgs e) {
            angle += 0.015;
            pb2.Refresh();
        }

        //Обновление при изменении координат точки T
        private void nudT_ValueChanged(object sender, EventArgs e) {
            updateCube();
            pb1.Refresh();
            pb2.Refresh();
        }

        //Обновление при изменении координат точки C
        private void nudC_ValueChanged(object sender, EventArgs e) {
            if (tmrDemoRatate.Enabled) tmrDemoRatate.Enabled = false;
            pb2.Refresh();
        }

    }
}
