using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Militar : Persona
{
    protected float poderAtaque;
    private float rangoAtaque;

    internal Militar(int vida_total, Vector2 escala, float rangoVision, float coste, List<Superficie> superficiePosible, Vector3 velocidadMovimiento, string nombre, float poderAtaque, float rangoAtaque)
    : base(vida_total, escala, rangoVision, coste, superficiePosible, velocidadMovimiento , nombre)
    {
        this.vida_total = 100;
        this.vida_actual = vida_total;
        this.poderAtaque = poderAtaque;
        this.rangoAtaque = rangoAtaque;
    }
    public string Atacar(Unidades unidad)
    {
        if (viva)
        {
            unidad.ReciBirDamage(this.poderAtaque);

            if (unidad is Persona)
            {
                Persona persona = (Persona)unidad;
            }
        }
        //Debug.Log("El militar con nombre " + this.nombre + " y fuerza de ataque de " + this.poderAtaque + " ataco a " + unidad.GetNombre());
        return "El militar con nombre " + this.nombre + "  ataca con una fuerza de " + poderAtaque + " a " + unidad.GetNombre()  ;
    }

    public override string ToString()
    {
        string stringbase = base.ToString();
        return stringbase + " poder ataque " + this.poderAtaque;
    }
}
