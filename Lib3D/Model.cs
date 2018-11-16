using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib3D
{
    public class Model
    {
        public List<Vector3> Vertexes { get; private set; }
        public PolygonContainer PolygonContainer { get;private set; }

        public Model()
        {
            Vertexes = new List<Vector3>();
            PolygonContainer = new PolygonContainer();
        }
        public static Model GetTruncatedCone(Vector3 A, Vector3 B, float R1, float R2, int N)
        {
            Model model = new Model();
            Vector4 D = new Vector4(R1, 0, 0);
            Vector4 U = new Vector4(R2, 0, (float)Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2) + Math.Pow(A.Z - B.Z, 2)));
            Matrix4 Rotate = Matrix4.RotationMatrix(B - A);
            Matrix4 Move = Matrix4.MoveMatrix(A);
            //Matrix4 VectorRot = ;
            for (int index = 0; index < N; index++)
            {
                Matrix4 Rotation = Matrix4.RotationMatrix(2, (float)(index * 2 * Math.PI / N));
                model.Vertexes.Add(Move*(Rotate * (Rotation * D)));
                model.Vertexes.Add(Move*(Rotate * (Rotation * U)));
            }
            List<int> PolygonDown = new List<int>();
            List<int> PolygonUp = new List<int>();
            for (int i = 0; i < N; i++)
            {
                PolygonDown.Add(2 * i);
                PolygonUp.Add(2 * i + 1);
                model.PolygonContainer.Add(new List<int>
                {
                    2 * i,
                    2 * i + 1,
                    (2 *i + 3) % (2*N),
                    (2 * i + 2) % (2*N)
                });
            }
            model.PolygonContainer.Add(PolygonDown);
            model.PolygonContainer.Add(PolygonUp);
            return model;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Vertexes)
            {
                sb.AppendLine("v " + item.X + " " + item.Z + " " + (-item.Y) + " ");
            }
            for (int polygonIndex = 0; polygonIndex < PolygonContainer.Count; polygonIndex++)
            {
                sb.Append("f");
                int VertexesCount = PolygonContainer.VertexInPolygonCount(polygonIndex);
                for (int VertexIndex = 0; VertexIndex < VertexesCount; VertexIndex++)
                {
                    sb.Append(" " + (PolygonContainer[polygonIndex, VertexIndex]+ 1));
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
