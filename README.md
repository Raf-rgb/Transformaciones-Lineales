# Transformaciones-Lineales
Una aplicación sencilla para Transformaciones Lineales

# Clase Vector
La clase vector permite crear vectores en 2D. Ejemplo: creando un vector en (2, 5)

```c#
  Vector v = new Vector(2, 5);
```

Con la función Print() podemos visualizar los valores (x, y) del vector en consola

```c#
  // Creamos el vector en (2, 5)
  Vector v = new Vector(2, 5);
  
  // Mostramos en consola los valores (x, y)
  v.Print();
  
  // Resultado en consola
  // [ 2, 5 ]
```

Con la función GetValues() podemos obtener los valores (x, y) como un arreglo de tipo Float

```c#
  // Creamos el vector en (2, 5)
  Vector v = new Vector(2, 5);
  
  // Obteniendo los valores (x, y) como un arreglo
  float[] valores = v.GetValues();
```

Con la función SetValues() podemos actualizar los valores (x, y) del vector con
un arreglo

```c#
  // Valores (x, y) a asignar
  float[] valores = new float[]{ 1, 2 };
  
  // Creando el vector en (2, 5)
  Vector v = new Vector(2, 5);
  
  // Actualizando los valores (x, y) del vector
  v.SetValues(valores);
  
  // Mostrando los valores (x, y) del vector
  v.Print();
  
  // Resultado en consola
  // [ 1, 2 ]
```

# Clase Polygon
Con esta clase podemos crear polygonos y visualizarlos en pantalla. Ejemplo:  creando un poligono de 3 vertices

```c#
  // Creamos el poligono
  Polygon p = new Polygon();
  
  // Añadimos sus vertices
  p.Add(20, 20);
  p.Add(60, 70);
  p.Add(100, 20);
```

Podemos visualizar los valores (x, y) de cada vertice del poligono con la funcion Print()

```c#
  // Creamos el poligono
  Polygon p = new Polygon();
  
  // Añadimos sus vertices
  p.Add(20, 20);
  p.Add(60, 80);
  p.Add(100, 20);
  
  // Mostramos sus vertices en consola
  p.Print();
  
  // Resultado en consola
  // [ 20, 20 ]
  // [ 60, 80 ]
  // [ 100, 20 ]
```

Podemos eliminar el ultimo vertice del poligono con la funcion Remove()

```c#
  // Creamos el poligono
  Polygon p = new Polygon();
  
  // Añadimos sus vertices
  p.Add(20, 20);
  p.Add(60, 80);
  p.Add(100, 20);
  
  // Eliminamos el ultimo vertice del poligono
  p.Remove();
  
  // Mostramos sus vertices en consola
  p.Print();
  
  // Resultado en consola
  // [ 20, 20 ]
  // [ 60, 80 ]
```
Para dibujar el poligono creado, se necesita de un PictureBox y se pasa como parametro a la función Draw()

```c#
  // Creamos el poligono
  Polygon p = new Polygon();
  
  // Añadimos sus vertices
  p.Add(20, 20);
  p.Add(60, 80);
  p.Add(100, 20);
  
  // Dibujamos el poligono en el picture box de nuestro WindowsForm
  p.Draw(picturebox);
```
