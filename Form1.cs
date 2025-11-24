using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace OpenTK_winforms_z02
{
    public partial class Form1 : Form
    {
        // Stări de control cameră.
        private int eyePosX, eyePosY, eyePosZ;
        private Point mousePos;
        private float camDepth;

        // Stări de control mouse.
        private bool statusControlMouse2D, statusControlMouse3D, statusMouseDown;
        private bool statusControlMouseLight1;

        // Stări de control axe de coordonate.
        private bool statusControlAxe;

        // Stări de control iluminare.
        private bool lightON;
        private bool lightON_0;
        private bool lightON_1;

        // Stări de control obiecte 3D.
        private string statusCube;

        // Structuri de stocare a vertexurilor și a listelor de vertexuri.
        private int[,] arrVertex = new int[50, 3];
        private int nVertex;
        private int[] arrQuadsList = new int[100];
        private int nQuadsList;
        private int[] arrTrianglesList = new int[100];
        private int nTrianglesList;

        // Fișiere de in/out pentru manipularea vertexurilor.
        private string fileVertex = "vertexList.txt";
        private string fileQList = "quadsVertexList.txt";
        private string fileTList = "trianglesVertexList.txt";
        private bool statusFiles;

        // Lumini
        private float[] valuesAmbientTemplate0 = new float[] { 0.1f, 0.1f, 0.1f, 1.0f };
        private float[] valuesDiffuseTemplate0 = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
        private float[] valuesSpecularTemplate0 = new float[] { 0.1f, 0.1f, 0.1f, 1.0f };
        private float[] valuesPositionTemplate0 = new float[] { 0.0f, 0.0f, 5.0f, 1.0f };

        private float[] valuesAmbient0 = new float[4];
        private float[] valuesDiffuse0 = new float[4];
        private float[] valuesSpecular0 = new float[4];
        private float[] valuesPosition0 = new float[4];

        // Sursa de lumină 1
        private float[] valuesAmbientTemplate1 = new float[] { 0.2f, 0.2f, 0.2f, 1.0f };
        private float[] valuesDiffuseTemplate1 = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
        private float[] valuesSpecularTemplate1 = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
        private float[] valuesPositionTemplate1 = new float[] { 0.0f, 50.0f, 0.0f, 1.0f };

        private float[] valuesAmbient1 = new float[4];
        private float[] valuesDiffuse1 = new float[4];
        private float[] valuesSpecular1 = new float[4];
        private float[] valuesPosition1 = new float[4];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupValues();
            SetupWindowGUI();
        }

        private void SetupValues()
        {
            eyePosX = 100;
            eyePosY = 100;
            eyePosZ = 50;
            camDepth = 1.04f;

            setLight0Values();
            setLight1Values();

            numericXeye.Value = eyePosX;
            numericYeye.Value = eyePosY;
            numericZeye.Value = eyePosZ;
        }

        private void SetupWindowGUI()
        {
            setControlMouse2D(false);
            setControlMouse3D(false);
            setControlMouseLight1(false);

            numericCameraDepth.Value = (int)camDepth;

            setControlAxe(true);

            setCubeStatus("OFF");
            setIlluminationStatus(false);
            setSource0Status(false);
            setSource1Status(false);

            setTrackLight0Default();
            setTrackLight1Default();
            setColorAmbientLight0Default();
            setColorDifuseLight0Default();
            setColorSpecularLight0Default();
        }

        // Încărcarea vertexurilor și listelor
        private void loadVertex()
        {
            try
            {
                StreamReader fileReader = new StreamReader((fileVertex));
                nVertex = Convert.ToInt32(fileReader.ReadLine().Trim());
                Console.WriteLine("Vertexuri citite: " + nVertex.ToString());

                string tmpStr = "";
                string[] str = new string[3];
                for (int i = 0; i < nVertex; i++)
                {
                    tmpStr = fileReader.ReadLine();
                    str = tmpStr.Trim().Split(' ');
                    arrVertex[i, 0] = Convert.ToInt32(str[0].Trim());
                    arrVertex[i, 1] = Convert.ToInt32(str[1].Trim());
                    arrVertex[i, 2] = Convert.ToInt32(str[2].Trim());
                }
                fileReader.Close();
            }
            catch (Exception)
            {
                statusFiles = false;
                Console.WriteLine("Fisierul cu informații vertex <" + fileVertex + "> nu exista!");
                MessageBox.Show("Fisierul cu informații vertex <" + fileVertex + "> nu exista!");
            }
        }

        private void loadQList()
        {
            try
            {
                StreamReader fileReader = new StreamReader(fileQList);
                int tmp;
                string line;
                nQuadsList = 0;

                while ((line = fileReader.ReadLine()) != null)
                {
                    tmp = Convert.ToInt32(line.Trim());
                    arrQuadsList[nQuadsList] = tmp;
                    nQuadsList++;
                }
                fileReader.Close();
            }
            catch (Exception)
            {
                statusFiles = false;
                MessageBox.Show("Fisierul cu informații vertex <" + fileQList + "> nu exista!");
            }
        }

        private void loadTList()
        {
            try
            {
                StreamReader fileReader = new StreamReader(fileTList);
                int tmp;
                string line;
                nTrianglesList = 0;

                while ((line = fileReader.ReadLine()) != null)
                {
                    tmp = Convert.ToInt32(line.Trim());
                    arrTrianglesList[nTrianglesList] = tmp;
                    nTrianglesList++;
                }
                fileReader.Close();
            }
            catch (Exception)
            {
                statusFiles = false;
                MessageBox.Show("Fisierul cu informații vertex <" + fileTList + "> nu exista!");
            }
        }

        // Control cameră
        private void numericXeye_ValueChanged(object sender, EventArgs e)
        {
            eyePosX = (int)numericXeye.Value;
            GlControl1.Invalidate();
        }

        private void numericYeye_ValueChanged(object sender, EventArgs e)
        {
            eyePosY = (int)numericYeye.Value;
            GlControl1.Invalidate();
        }

        private void numericZeye_ValueChanged(object sender, EventArgs e)
        {
            eyePosZ = (int)numericZeye.Value;
            GlControl1.Invalidate();
        }

        private void numericCameraDepth_ValueChanged(object sender, EventArgs e)
        {
            camDepth = 1 + ((float)numericCameraDepth.Value) * 0.1f;
            GlControl1.Invalidate();
        }

        // Control mouse
        private void setControlMouse2D(bool status)
        {
            statusControlMouse2D = status;
            btnMouseControl2D.Text = status ? "2D mouse control ON" : "2D mouse control OFF";
        }

        private void setControlMouse3D(bool status)
        {
            statusControlMouse3D = status;
            btnMouseControl3D.Text = status ? "3D mouse control ON" : "3D mouse control OFF";
        }

        private void setControlMouseLight1(bool status)
        {
            statusControlMouseLight1 = status;
            btnMouseControlLight1.Text = status ? "Mouse ON" : "Mouse OFF";
        }

        private void btnMouseControl2D_Click(object sender, EventArgs e)
        {
            setControlMouse2D(!statusControlMouse2D);
            if (statusControlMouse2D) setControlMouse3D(false);
        }

        private void btnMouseControl3D_Click(object sender, EventArgs e)
        {
            setControlMouse3D(!statusControlMouse3D);
            if (statusControlMouse3D) setControlMouse2D(false);
        }

        private void btnMouseControlLight1_Click(object sender, EventArgs e)
        {
            setControlMouseLight1(!statusControlMouseLight1);
        }

        private void GlControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (statusMouseDown)
            {
                if (statusControlMouseLight1 && lightON)
                {
                    valuesPosition1[0] += (e.X - mousePos.X) * 0.1f;
                    valuesPosition1[1] -= (e.Y - mousePos.Y) * 0.1f;
                    setTrackLight1Default();
                }
                else if (statusControlMouse2D || statusControlMouse3D)
                {
                    // Rotație normală a scenei
                }
                mousePos = new Point(e.X, e.Y);
                GlControl1.Invalidate();
            }
        }

        private void GlControl1_MouseDown(object sender, MouseEventArgs e)
        {
            statusMouseDown = true;
            mousePos = e.Location;
        }

        private void GlControl1_MouseUp(object sender, MouseEventArgs e)
        {
            statusMouseDown = false;
        }

        // Control iluminare
        private void setIlluminationStatus(bool status)
        {
            lightON = status;
            btnLights.Text = status ? "Iluminare ON" : "Iluminare OFF";
        }

        private void btnLights_Click(object sender, EventArgs e)
        {
            setIlluminationStatus(!lightON);
            GlControl1.Invalidate();
        }

        private void btnLightsNo_Click(object sender, EventArgs e)
        {
            int nr = GL.GetInteger(GetPName.MaxLights);
            MessageBox.Show("Nr. maxim de luminii pentru aceasta implementare este <" + nr.ToString() + ">.");
        }

        // Sursa 0
        private void setSource0Status(bool status)
        {
            lightON_0 = status;
            btnLight0.Text = status ? "Sursa 0 ON" : "Sursa 0 OFF";
        }

        private void btnLight0_Click(object sender, EventArgs e)
        {
            if (lightON)
            {
                setSource0Status(!lightON_0);
                GlControl1.Invalidate();
            }
        }

        private void setTrackLight0Default()
        {
            trackLight0PositionX.Value = (int)valuesPosition0[0];
            trackLight0PositionY.Value = (int)valuesPosition0[1];
            trackLight0PositionZ.Value = (int)valuesPosition0[2];
        }

        private void trackLight0PositionX_Scroll(object sender, EventArgs e)
        {
            valuesPosition0[0] = trackLight0PositionX.Value;
            GlControl1.Invalidate();
        }

        private void trackLight0PositionY_Scroll(object sender, EventArgs e)
        {
            valuesPosition0[1] = trackLight0PositionY.Value;
            GlControl1.Invalidate();
        }

        private void trackLight0PositionZ_Scroll(object sender, EventArgs e)
        {
            valuesPosition0[2] = trackLight0PositionZ.Value;
            GlControl1.Invalidate();
        }

        // Culori sursa 0 - Ambient
        private void setColorAmbientLight0Default()
        {
            numericLight0Ambient_Red.Value = (decimal)(valuesAmbient0[0] * 100);
            numericLight0Ambient_Green.Value = (decimal)(valuesAmbient0[1] * 100);
            numericLight0Ambient_Blue.Value = (decimal)(valuesAmbient0[2] * 100);
        }

        private void numericLight0Ambient_Red_ValueChanged(object sender, EventArgs e)
        {
            valuesAmbient0[0] = (float)numericLight0Ambient_Red.Value / 100;
            GlControl1.Invalidate();
        }

        private void numericLight0Ambient_Green_ValueChanged(object sender, EventArgs e)
        {
            valuesAmbient0[1] = (float)numericLight0Ambient_Green.Value / 100;
            GlControl1.Invalidate();
        }

        private void numericLight0Ambient_Blue_ValueChanged(object sender, EventArgs e)
        {
            valuesAmbient0[2] = (float)numericLight0Ambient_Blue.Value / 100;
            GlControl1.Invalidate();
        }

        // Culori sursa 0 - Difuz
        private void setColorDifuseLight0Default()
        {
            numericLight0Difuse_Red.Value = (decimal)(valuesDiffuse0[0] * 100);
            numericLight0Difuse_Green.Value = (decimal)(valuesDiffuse0[1] * 100);
            numericLight0Difuse_Blue.Value = (decimal)(valuesDiffuse0[2] * 100);
        }

        private void numericLight0Difuse_Red_ValueChanged(object sender, EventArgs e)
        {
            valuesDiffuse0[0] = (float)numericLight0Difuse_Red.Value / 100;
            GlControl1.Invalidate();
        }

        private void numericLight0Difuse_Green_ValueChanged(object sender, EventArgs e)
        {
            valuesDiffuse0[1] = (float)numericLight0Difuse_Green.Value / 100;
            GlControl1.Invalidate();
        }

        private void numericLight0Difuse_Blue_ValueChanged(object sender, EventArgs e)
        {
            valuesDiffuse0[2] = (float)numericLight0Difuse_Blue.Value / 100;
            GlControl1.Invalidate();
        }

        // Culori sursa 0 - Specular
        private void setColorSpecularLight0Default()
        {
            numericLight0Specular_Red.Value = (decimal)(valuesSpecular0[0] * 100);
            numericLight0Specular_Green.Value = (decimal)(valuesSpecular0[1] * 100);
            numericLight0Specular_Blue.Value = (decimal)(valuesSpecular0[2] * 100);
        }

        private void numericLight0Specular_Red_ValueChanged(object sender, EventArgs e)
        {
            valuesSpecular0[0] = (float)numericLight0Specular_Red.Value / 100;
            GlControl1.Invalidate();
        }

        private void numericLight0Specular_Green_ValueChanged(object sender, EventArgs e)
        {
            valuesSpecular0[1] = (float)numericLight0Specular_Green.Value / 100;
            GlControl1.Invalidate();
        }

        private void numericLight0Specular_Blue_ValueChanged(object sender, EventArgs e)
        {
            valuesSpecular0[2] = (float)numericLight0Specular_Blue.Value / 100;
            GlControl1.Invalidate();
        }

        private void setLight0Values()
        {
            Array.Copy(valuesAmbientTemplate0, valuesAmbient0, valuesAmbientTemplate0.Length);
            Array.Copy(valuesDiffuseTemplate0, valuesDiffuse0, valuesDiffuseTemplate0.Length);
            Array.Copy(valuesSpecularTemplate0, valuesSpecular0, valuesSpecularTemplate0.Length);
            Array.Copy(valuesPositionTemplate0, valuesPosition0, valuesPositionTemplate0.Length);
        }

        private void btnLight0Reset_Click(object sender, EventArgs e)
        {
            setLight0Values();
            setTrackLight0Default();
            setColorAmbientLight0Default();
            setColorDifuseLight0Default();
            setColorSpecularLight0Default();
            GlControl1.Invalidate();
        }

        // Sursa 1
        private void setSource1Status(bool status)
        {
            lightON_1 = status;
            btnLight1.Text = status ? "Sursa 1 ON" : "Sursa 1 OFF";
        }

        private void btnLight1_Click(object sender, EventArgs e)
        {
            if (lightON)
            {
                setSource1Status(!lightON_1);
                GlControl1.Invalidate();
            }
        }

        private void setTrackLight1Default()
        {
            trackLight1PositionX.Value = (int)valuesPosition1[0];
            trackLight1PositionY.Value = (int)valuesPosition1[1];
            trackLight1PositionZ.Value = (int)valuesPosition1[2];
        }

        private void trackLight1PositionX_Scroll(object sender, EventArgs e)
        {
            valuesPosition1[0] = trackLight1PositionX.Value;
            GlControl1.Invalidate();
        }

        private void trackLight1PositionY_Scroll(object sender, EventArgs e)
        {
            valuesPosition1[1] = trackLight1PositionY.Value;
            GlControl1.Invalidate();
        }

        private void trackLight1PositionZ_Scroll(object sender, EventArgs e)
        {
            valuesPosition1[2] = trackLight1PositionZ.Value;
            GlControl1.Invalidate();
        }

        private void setLight1Values()
        {
            Array.Copy(valuesAmbientTemplate1, valuesAmbient1, valuesAmbientTemplate1.Length);
            Array.Copy(valuesDiffuseTemplate1, valuesDiffuse1, valuesDiffuseTemplate1.Length);
            Array.Copy(valuesSpecularTemplate1, valuesSpecular1, valuesSpecularTemplate1.Length);
            Array.Copy(valuesPositionTemplate1, valuesPosition1, valuesPositionTemplate1.Length);
        }

        private void btnLight1Reset_Click(object sender, EventArgs e)
        {
            setLight1Values();
            setTrackLight1Default();
            GlControl1.Invalidate();
        }

        // Control cu taste
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!lightON) return;

            float step = 5.0f;
            switch (e.KeyCode)
            {
                case Keys.Left: valuesPosition1[0] -= step; break;
                case Keys.Right: valuesPosition1[0] += step; break;
                case Keys.Down: valuesPosition1[1] -= step; break;
                case Keys.Up: valuesPosition1[1] += step; break;
                case Keys.OemMinus: valuesPosition1[2] -= step; break;
                case Keys.Oemplus: valuesPosition1[2] += step; break;
                default: return;
            }
            setTrackLight1Default();
            GlControl1.Invalidate();
        }

        // Control obiecte 3D
        private void setControlAxe(bool status)
        {
            statusControlAxe = status;
            btnShowAxes.Text = status ? "Axe Oxyz ON" : "Axe Oxyz OFF";
        }

        private void btnShowAxes_Click(object sender, EventArgs e)
        {
            setControlAxe(!statusControlAxe);
            GlControl1.Invalidate();
        }

        private void setCubeStatus(string status)
        {
            statusCube = status.ToUpper();
        }

        private void btnCubeQ_Click(object sender, EventArgs e)
        {
            statusFiles = true;
            loadVertex();
            loadQList();
            setCubeStatus("QUADS");
            GlControl1.Invalidate();
        }

        private void btnCubeT_Click(object sender, EventArgs e)
        {
            statusFiles = true;
            loadVertex();
            loadTList();
            setCubeStatus("TRIANGLES");
            GlControl1.Invalidate();
        }

        private void btnResetObjects_Click(object sender, EventArgs e)
        {
            setCubeStatus("OFF");
            GlControl1.Invalidate();
        }

        // Metoda principală de desenare
        private void GlControl1_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.ClearColor(Color.Black);

            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(camDepth, 4 / 3, 1, 10000);
            Matrix4 lookat = Matrix4.LookAt(eyePosX, eyePosY, eyePosZ, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.LoadMatrix(ref perspective);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.LoadMatrix(ref lookat);
            GL.Viewport(0, 0, GlControl1.Width, GlControl1.Height);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);

            // Iluminare
            if (lightON)
            {
                GL.Enable(EnableCap.Lighting);

                // Sursa 0
                GL.Light(LightName.Light0, LightParameter.Ambient, valuesAmbient0);
                GL.Light(LightName.Light0, LightParameter.Diffuse, valuesDiffuse0);
                GL.Light(LightName.Light0, LightParameter.Specular, valuesSpecular0);
                GL.Light(LightName.Light0, LightParameter.Position, valuesPosition0);

                if (lightON_0)
                    GL.Enable(EnableCap.Light0);
                else
                    GL.Disable(EnableCap.Light0);

                // Sursa 1
                GL.Light(LightName.Light1, LightParameter.Ambient, valuesAmbient1);
                GL.Light(LightName.Light1, LightParameter.Diffuse, valuesDiffuse1);
                GL.Light(LightName.Light1, LightParameter.Specular, valuesSpecular1);
                GL.Light(LightName.Light1, LightParameter.Position, valuesPosition1);

                if (lightON_1)
                    GL.Enable(EnableCap.Light1);
                else
                    GL.Disable(EnableCap.Light1);
            }
            else
            {
                GL.Disable(EnableCap.Lighting);
            }

            // Control rotație mouse
            if (statusControlMouse2D)
            {
                GL.Rotate(mousePos.X, 0, 1, 0);
            }
            if (statusControlMouse3D)
            {
                GL.Rotate(mousePos.X, 0, 1, 1);
            }

            // Desenare obiecte
            if (statusControlAxe)
            {
                DeseneazaAxe();
            }

            if (statusCube == "QUADS")
            {
                DeseneazaCubQ();
            }
            else if (statusCube == "TRIANGLES")
            {
                DeseneazaCubT();
            }

            GlControl1.SwapBuffers();
        }

        private void DeseneazaAxe()
        {
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Red);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(75, 0, 0);
            GL.End();

            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Yellow);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 75, 0);
            GL.End();

            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Green);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 0, 75);
            GL.End();
        }

        private void DeseneazaCubQ()
        {
            GL.Begin(PrimitiveType.Quads);
            for (int i = 0; i < nQuadsList; i++)
            {
                switch (i % 4)
                {
                    case 0: GL.Color3(Color.Blue); break;
                    case 1: GL.Color3(Color.Red); break;
                    case 2: GL.Color3(Color.Green); break;
                    case 3: GL.Color3(Color.Yellow); break;
                }
                int x = arrQuadsList[i];
                GL.Vertex3(arrVertex[x, 0], arrVertex[x, 1], arrVertex[x, 2]);
            }
            GL.End();
        }

        private void DeseneazaCubT()
        {
            GL.Begin(PrimitiveType.Triangles);
            for (int i = 0; i < nTrianglesList; i++)
            {
                switch (i % 3)
                {
                    case 0: GL.Color3(Color.Blue); break;
                    case 1: GL.Color3(Color.Red); break;
                    case 2: GL.Color3(Color.Green); break;
                }
                int x = arrTrianglesList[i];
                GL.Vertex3(arrVertex[x, 0], arrVertex[x, 1], arrVertex[x, 2]);
            }
            GL.End();
        }
    }
}