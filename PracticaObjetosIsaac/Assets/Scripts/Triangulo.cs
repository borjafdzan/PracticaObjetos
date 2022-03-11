using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangulo
{
    float lado;
    private static int cantidadeTriangulos = 0;
    public Triangulo(float lado)
    {
        cantidadeTriangulos++;
        this.lado = lado;
    }

    public float CalcularArea()
    {
        return (lado * lado) / 2;
    }
    public static float CalcularAreaEstatico(float lado)
    {
        return (lado * lado) / 2;
    }

    public static float VerCantidadTriangulos(){
        return cantidadeTriangulos;
    }
}
