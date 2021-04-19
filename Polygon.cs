using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Draw
{
    class Polygon
    {
        // Coordenadas de los vertices del
        // poligono
        List<Vector> vertex;

        // Posicion del poligono
        Vector pos;

        // Canvas
        PictureBox canvas;

        // Metodo constructor que inicializa
        // los vertices del poligono y la
        // posicion del poligono
        public Polygon(PictureBox canvas_, float x, float y)
        {
            pos = new Vector(x, y);
            vertex = new List<Vector>();
            canvas = canvas_;
        }

        // Agrega un nuevo Vector a la lista 
        // de vertices
        public void Add(float x, float y) { vertex.Add(new Vector(x, y)); }

        // Elimina el ultimo Vector de la 
        // lista de vertices
        public void Remove() { vertex.RemoveAt(vertex.Count - 1); }

        // Metodo que imprime en consola los
        // valores de los vertices
        public void Print()
        {
            foreach (Vector v in vertex) Console.WriteLine($"[ {v.x}, {v.y} ]");
        }

       // Metodo para rotar el poligono
       public void Rotate(double angle)
       {
            // Conversion de grados a radianes
            angle = angle * Math.PI / 180;

            // Se define la matriz de rotación
            double[,] R = new double[,] {
                {  Math.Cos(angle), Math.Sin(angle), 0 },
                { -Math.Sin(angle), Math.Cos(angle), 0 },
                {  0              , 0              , 1 }
            };

            // Se aplica la transformación lineal 
            // para cada vertice del poligono
            foreach(Vector v in vertex)
            {
                // Se define el vector
                double[] p = new double[] { v.x, v.y, 1};

                // Se obtiene el resultado de la
                // multiplicacion
                double[] result = Mult(R, p);
                
                // Se actualizan los valores (x, y)
                // del vertice
                v.x = (float) result[0] - canvas.Width / 2;
                v.y = (float) result[1] - canvas.Height / 2;
            }

            // La transformacion lineal tambien 
            // se aplica al centro del poligono
            double[] posR = new double[] { pos.x, pos.y, 1 };

            pos.x = (float) Mult(R, posR)[0] - canvas.Width / 2;
            pos.y = (float) Mult(R, posR)[0] - canvas.Height / 2;
        }

        // Metodo para escalar el poligono
        public void Escalar(double sx, double sy)
        {

            // Se define la matriz de escalamiento
            double[,] E = new double[,] {
                {  sx,  0, 0 },
                {   0, sy, 0 },
                {   0,  0, 1 }
            };

            // Se aplica la transformación lineal 
            // para cada vertice del poligono
            foreach (Vector v in vertex)
            {
                // Se define el vector
                double[] p = new double[] { v.x, v.y, 1 };

                // Se obtiene el resultado de la
                // multiplicacion
                double[] result = Mult(E, p);

                // Se actualizan los valores (x, y)
                // del vertice
                v.x = (float)result[0] - canvas.Width / 2;
                v.y = (float)result[1] - canvas.Height / 2;
            }

            // La transformacion lineal tambien 
            // se aplica al centro del poligono
            double[] posE = new double[] { pos.x, pos.y, 1 };

            pos.x = (float)Mult(E, posE)[0] - canvas.Width / 2;
            pos.y = (float)Mult(E, posE)[0] - canvas.Height / 2;
        }

        // Metodo para multiplicar una matrix con un vector
        private double[] Mult(double[,] T, double[] p)
        {
            double[] result = new double[3];

            for(int i = 0; i < 3; i++)
            {
                double sum = 0;

                for(int j = 0; j < 3; j++)
                {
                    sum += T[i, j] * p[j];
                }
                result[i] = sum;
            }

            return result;
        }


        // Metodo que dibuja en un PictureBox que
        // recibe como parametro.
        public void Draw(PictureBox canvas)
        {
            if (vertex.Count > 0)
            {
                // Se crea un bitmap para obtener el contexto grafico
                Bitmap bitmap = new Bitmap(canvas.Width, canvas.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                // Se obtiene el contexto grafico
                Graphics graphics = Graphics.FromImage(bitmap);

                // Se crea un objeto Pen para definir el estilo de la linea
                Pen pen = new Pen(Color.Black, 2);

                // Se dibujan las lineas entre los vertices
                // del poligono
                for(int i = 0; i < vertex.Count; i++)
                {   
                    Vector p1 = vertex[i];
                    Vector p2 = vertex[(i + 1) % vertex.Count];

                    // Se dibuja la linea entre los vertices
                    graphics.DrawLine(pen, p1.x, p1.y, p2.x, p2.y);
                }

                // Se actualiza la imagen del PictureBox
                canvas.Image = bitmap;
            }
        }
    }
}
