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

        // Metodo constructor que inicializa
        // los vertices del poligono
        public Polygon()
        {
            vertex = new List<Vector>();
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
