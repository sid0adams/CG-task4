using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lib3D
{
    public class Matrix4
    {
        private float[,] data = new float[4, 4];
        public float this[int row, int column]
        {
            get => data[row, column];
            set => data[row, column] = value;
        }

        public Matrix4(float[,] Data)
        {
            for (int row = 0; row < 4; row++)
                for (int column = 0; column < 4; column++)
                {
                    data[row, column] = Data[row, column];
                }
        }
        public static Matrix4 Zero()
        {
            float[,] data = new float[4, 4] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            return new Matrix4(data);
        }
        public static Matrix4 One()
        {
            float[,] data = new float[4, 4] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            return new Matrix4(data);
        }
        public static Matrix4 RotationMatrix(int axis, float angle) => RotationMatrix(axis, (float)Sin(angle), (float)Cos(angle));
        public static Matrix4 RotationMatrix(int axis, float sin, float cos)
        {
            Matrix4 newMatrix = One();
            int a1 = (axis + 1) % 3;
            int a2 = (axis + 2) % 3;

            newMatrix[a1, a1] = cos;
            newMatrix[a1, a2] = -sin;
            newMatrix[a2, a1] = sin;
            newMatrix[a2, a2] = cos;

            return newMatrix;
        }
        public static Matrix4 RotationMatrix(Vector3 vector)
        {
            if (vector.X == 0 && vector.Y == 0)
            {
                if (vector.Z > 0)
                    return One();
                else
                    return RotationMatrix(0, (float)PI);
            }

            float l;
            if(vector.X != 0)
            {
                l = (float)Sqrt(Pow(vector.Z, 2) + Pow(vector.X, 2));
                var RotY = RotationMatrix(1, Abs(vector.X) / l, vector.Z / l);
                //return RotY;
                l = (float)Sqrt(Pow(vector.X, 2) + Pow(vector.Y, 2));
                var RotZ = RotationMatrix(2, vector.Y / l, vector.X / l);
                return RotZ*RotY;
            }
            else
            {
                l = (float)Sqrt(Pow(vector.Z, 2) + Pow(vector.Y, 2));
                var RotX = RotationMatrix(0, -vector.Y / l, vector.Z / l);
                return RotX;
            }
            /*
            Matrix4 RotZ = One();
            float l =(float) Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
            if (l == 0)
                return RotZ;

            if(vector.Y!=0)
            {
                Matrix4 RotX = One();
                l = (float)Math.Sqrt(vector.Y * vector.Y + vector.Z * vector.Z);
                RotX[1, 1] = vector.Z / l;
                RotX[1, 2] = -vector.Y / l;
                RotX[2, 1] = vector.Y / l;
                RotX[2, 2] = vector.Z / l;

                l = (float)Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
                RotZ[0, 0] = vector.X / l;
                RotZ[0, 1] = -vector.Y / l;
                RotZ[1, 0] = vector.Y / l;
                RotZ[1, 1] = vector.X / l;
                return RotX * RotZ;
            }
            else
            {
                l = (float)Math.Sqrt(vector.X * vector.X + vector.Z * vector.Z);
                Matrix4 RotY = One();
                RotY[2, 2] = vector.Z / l;
                RotY[2, 0] = -vector.X / l;
                RotY[0, 2] = vector.X / l;
                RotY[0, 0] = vector.Z / l;


                l = (float)Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
                RotZ[0, 0] = vector.Y / l;
                RotZ[0, 1] = vector.X / l;
                RotZ[1, 0] = -vector.X / l;
                RotZ[1, 1] = vector.Y / l;
                return RotY * RotZ;
            }
            */
        }
        public static Matrix4 MoveMatrix(Vector3 vector)
        {
            Matrix4 newMatrix = One();
            newMatrix[0, 3] = vector.X;
            newMatrix[1, 3] = vector.Y;
            newMatrix[2, 3] = vector.Z;
            return newMatrix;
        }
        public static Matrix4 FrustumMatrix(float l, float r, float b, float t, float n, float f)
        {
            var Matrix = Zero();
            Matrix[0, 0] = 2 * n / (r - l);
            Matrix[1, 1] = 2 * n / (t - b);
            Matrix[2, 2] = -(f + n) / (f - n);
            Matrix[0, 2] = (r + l) / (r - l);
            Matrix[1, 2] = (t + b) / (t - b);
            Matrix[2, 3] = -2 * f * n / (f - n);
            Matrix[3, 2] = -1;
            return Matrix;
        }
        public static Matrix4 operator *(Matrix4 matrix, float number)
        {
            Matrix4 newMatrix = Zero();
            for (int row = 0; row < 4; row++)
                for (int column = 0; column < 4; column++)
                    newMatrix[row, column] = matrix[row, column] * number;
            return newMatrix;
        }
        public static Matrix4 operator *(float number, Matrix4 matrix) => matrix * number;
        public static Matrix4 operator *(Matrix4 first, Matrix4 second)
        {
            Matrix4 newMatrix = Zero();
            for (int row = 0; row < 4; row++)
                for (int column = 0; column < 4; column++)
                    for (int index = 0; index < 4; index++)
                        newMatrix[row, column] += first[row, index] * second[index, column];
            return newMatrix;
        }
    }
}
