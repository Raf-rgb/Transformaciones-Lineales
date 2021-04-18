using System;
using System.Collections;

namespace Vector
{
    class Polygon
    {
        // Coordenadas de los vertices del
        // poligono
        ArrayList vertex;

        // Metodo constructor que inicializa
        // los vertices del poligono
        public Polygon() 
        {
            vertex = new ArrayList();
        }

        // Agrega un nuevo Vector a la lista 
        // de vertices
        public void Add(float x, float y) { vertex.Add(new Vector(x, y)); }

        // Elimina el ultimo Vector de la 
        // lista de vertices
        public void Remove() { vertex.RemoveAt(vertex.Count - 1); }

        // Metodo que imprime en consola los
        // valores de los vertices
        public void Print() {
            foreach(Vector v in vertex) Console.WriteLine($"[ {v.x}, {v.y} ]");
        }
    }
}