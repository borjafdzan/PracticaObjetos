using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aldeano : Civil
{
    internal Aldeano(int vida_total, Vector2 escala, float rangoVision, float coste, List<Superficie> superficiePosible, Vector3 velocidadMovimiento, string nombre)
    : base(vida_total, escala, rangoVision, coste, superficiePosible, velocidadMovimiento, nombre)
    {
        this.vida_total = 100;
        this.vida_actual = this.vida_total;
        this.velocidadMovimiento = new Vector3(50, 0, 0);
    }
    public string Trabajar()
    {
        if (viva)
        {
            Debug.Log("El aldeano " + this.nombre + " esta trabajando");
            return "El aldeano trabaja";
        }
        else
        {
            Debug.Log("El aldeano " + this.nombre + " no puede trabajar");
            return "El aldeano esta muerto";
        }
    }

}
