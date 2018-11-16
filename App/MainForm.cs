using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib3D;
using System.IO;
namespace App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Camera camera = new Camera();
        Scene scene = new Scene();
        Point start;
        private void Output_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left) && start != null)
            {

                Point dp = new Point(e.X - start.X, e.Y - start.Y);
                float alpha = dp.X * (float)System.Math.PI / 180f;
                float betta = dp.Y * (float)System.Math.PI / 180f;
                camera.View = Matrix4.RotationMatrix(0, -betta) * Matrix4.RotationMatrix(2, -alpha) * camera.View;
                Upd();
            }
            start = e.Location;
        }
        void Upd()
        {
            Bitmap t = scene.Draw(camera, new Lib3D.Screen(Output.Size, new RectangleF(-1, 1, 2, 2)));
            Output.Image = t;
            //t.Dispose();
        }
        public void Clear()
        {
            scene = new Scene();
            int L = 60;
            scene.Models.Add(Model.GetTruncatedCone(new Vector3(0, 0, 0), new Vector3(L, 0, 0), 0, 0, 1));
            scene.Models.Add(Model.GetTruncatedCone(new Vector3(0, 0, 0), new Vector3(0, L, 0), 0, 0, 1));
            scene.Models.Add(Model.GetTruncatedCone(new Vector3(0, 0, 0), new Vector3(0, 0, L), 0,0, 1));
            Upd();
        }

        private void MainForm_Load(object sender, EventArgs e) => Clear();

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Scene Temp = new Scene();
                for (int i = 3; i < scene.Models.Count; i++)
                {
                    Temp.Models.Add(scene.Models[i]);
                }
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, Temp.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("File error", "error");
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e) => Clear();

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var A = new Vector3((float)X0Input.Value, (float)Y0Input.Value, (float)Z0Input.Value);
            var B = new Vector3((float)X1Input.Value, (float)Y1Input.Value, (float)Z1Input.Value);
            scene.Models.Add(Model.GetTruncatedCone(A, B, (float)R0Input.Value, (float)R1Input.Value, (int)NInput.Value));
            Upd();
        }
    }
}
