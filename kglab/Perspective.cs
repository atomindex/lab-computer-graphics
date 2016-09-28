using System;
using System.Drawing;

namespace kglab {
    class Perspective {

        private static float[,] GetRotateXMatrix(double angle) {
            return new float[,] {
                { 1, 0, 0 },
                { 0, (float)Math.Cos(angle), (float)-Math.Sin(angle) },
                { 0, (float)Math.Sin(angle), (float)Math.Cos(angle) }
            };
        }

        private static float[,] GetRotateYMatrix(double angle) {
            return new float[,] {
                { (float)Math.Cos(angle), 0, (float)Math.Sin(angle) },
                { 0, 1, 0 },
                { (float)-Math.Sin(angle), 0, (float)Math.Cos(angle) }
            };
        }

        private static float[,] GetRotateZMatrix(double angle) {
            return new float[,] {
                { (float)Math.Cos(angle), (float)-Math.Sin(angle), 0 },
                { (float)Math.Sin(angle), (float)Math.Cos(angle), 0 },
                { 0, 0, 1 }
            };
        }


        private static Point3D multiple(float[,] matrix, Point3D point) {
            return new Point3D(
                point.x * matrix[0, 0] +
                point.y * matrix[0, 1] +
                point.z * matrix[0, 2],

                point.x * matrix[1, 0] +
                point.y * matrix[1, 1] +
                point.z * matrix[1, 2],

                point.x * matrix[2, 0] +
                point.y * matrix[2, 1] +
                point.z * matrix[2, 2]
            );
        }

        private static Point3D[] multiple(float[,] matrix, Point3D[] points) {
            Point3D[] result = new Point3D[points.Length];
            for (int i = 0; i < points.Length; i++)
                result[i] = multiple(matrix, points[i]);
            return result;
        }

        public static Point3D[] RotateX(Point3D[] points, double angle) {
            return multiple(GetRotateXMatrix(angle), points);
        }

        public static Point3D[] RotateY(Point3D[] points, double angle) {
            return multiple(GetRotateYMatrix(angle), points);
        }

        public static Point3D[] RotateZ(Point3D[] points, double angle) {
            return multiple(GetRotateZMatrix(angle), points);
        }

        public static PointF[] PrepareDrawCoords(Point3D[] points, int x0, int y0, float camera) {
            PointF[] preparedPoints = new PointF[points.Length];
            for (int i = 0; i < points.Length; i++)
                preparedPoints[i] = new PointF(points[i].x / camera + x0, -points[i].y / camera + y0);
            return preparedPoints;
        }

    }
}
