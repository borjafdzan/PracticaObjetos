using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Persona : PC
{
    protected Vector3 velocidadMovimiento;

    internal Persona(int vida_total, Vector2 escala, float rangoVision, float coste,  List<Superficie> superficiePosible, Vector3 velocidadMovimiento ,string nombre) : 
    base(vida_total, escala, rangoVision, coste, superficiePosible, nombre)
    {
        this.velocidadMovimiento = velocidadMovimiento;
    }

    public string Mover()
    {
        Debug.Log("La persona " + nombre + " se esta moviendo ");
        return "La persona se mueve a una velocidad de movimiento de " + this.velocidadMovimiento;
    }



    public override string ToString(){
        return "Nombre: "  + this.nombre + " vida " + this.vida_actual + " escala " + this.escala + " coste " + this.coste + " escala " + this.escala + " Rango vision " + this.rangoVision; 
    }
}
