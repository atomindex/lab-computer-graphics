using System.Drawing;

namespace kglab {
    class Point3D {
        public float x;
        public float y;
        public float z;

        //Возвращает координаты, пригодные для отрисовки на picturebox
        public static PointF[] PrepareDrawCoords(PointF[] points, int x0, int y0) {
            PointF[] preparedPoints = new PointF[points.Length];
            for (int i = 0; i < points.Length; i++)
                preparedPoints[i] = new PointF(points[i].X + x0, -points[i].Y + y0);
            return preparedPoints;
        }

        //Конструктор
        public Point3D(float x, float y, float z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //Возвращает координаты точек 
        public PointF[] GetComprehensivePoints() {
            return new PointF[] {
                new PointF(-x, -y),
                new PointF(-x, z),
                new PointF(y, z)
            };
        }

        //Возвращает координаты комлексного чертежа
        public PointF[] GetAllComprehensivePoints() {
            //Получем координаты проекций
            PointF[] p = GetComprehensivePoints();

            //Получем координаты линий связи
            PointF px = new PointF(-x, 0);
            PointF py1 = new PointF(0, -y);
            PointF py2 = new PointF(y, 0);
            PointF pz = new PointF(0, z);

            return new PointF[] {
                px, p[0], py1, py2, p[2], pz, p[1], px
            };
        }

    }
}
