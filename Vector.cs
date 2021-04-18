using System;

namespace Vector
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

        // Metodo que devuelve las coordenadas
        // del vector en un arreglo
        public float[] GetValues() { return new float[]{x, y}; }
        
        // Metodo que asigna las coordenadas
        // al vector con un arreglo.
        public void SetValues(float[] values) 
        { 
            x = values[0];
            y = values[1];
        }

        // Metodo que imprime en consola las
        // coordenadas del vector
        public void Print() {
            Console.WriteLine($"[{x}, {y}]");
        }
    }
}