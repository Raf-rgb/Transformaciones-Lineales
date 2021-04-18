using System;
using System.Collections.Generic;
using System.Text;

namespace Draw
{
    class Vector
    {
        // Coordenadas de un vector en R2
        public float x, y;

        // Metodo constructor que recibe 
        // las coordenadas del vector
        public Vector(float x_, float y_)
        {
            x = x_;
            y = y_;
        }

        // Metodo que imprime en consola las
        // coordenadas del vector
        public void Print()
        {
            Console.WriteLine($"[{x}, {y}]");
        }
    }
}
