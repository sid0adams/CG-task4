using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib3D;
using System.IO;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scene scene = new Scene();
            //scene.Models.Add(Model.GetTruncatedCone(new Vector3(0, 0, 0), new Vector3(0, 0, 300), 10, 10, 100));
            //scene.Models.Add(Model.GetTruncatedCone(new Vector3(0, 0, 0), new Vector3(0, 200, 0), 10, 10, 100));
            //scene.Models.Add(Model.GetTruncatedCone(new Vector3(0, 0, 0), new Vector3(100, 0, 0), 10, 10, 100));
            //Vector3 A = new Vector3(100, 0, 0);
            //Vector3 B = new Vector3(100, 200, 300);
            //Model model = Model.GetTruncatedCone(A, B, 20, 20, 3);
            //scene.Models.Add(model);
            //File.WriteAllText(@"C:\Users\sidad\Desktop\test3.obj",scene.ToString());
            List<Vector4> vectors = new List<Vector4>() { new Vector4(2,2,2),new Vector4(-2,2,2), new Vector4(-2, -2, 2), new Vector4(2, -2, 2),
                                                        new Vector4(2,2,3),new Vector4(-2,2,3), new Vector4(-2, -2, 3), new Vector4(2, -2, 3), new Vector4(2, 0, 2)};
            var matr = Matrix4.FrustumMatrix(-2, 2, -2, 2, -1, -4);
            List<Vector4> result = new List<Vector4>();
            foreach (var item in vectors)
            {
                result.Add(matr * item);
            }
            foreach (var item in result)
            {
                Console.WriteLine("{0} {1} {2} ", item.X/ item.W, item.Y / item.W, item.Z / item.W);
            }
        }
    }
}
