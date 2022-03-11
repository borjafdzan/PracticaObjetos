using UnityEngine;
using System.Collections.Generic;
public abstract class PC : Unidades
{
    protected float coste;
    protected List<Superficie> superficiePosible;

    internal PC(int vida_total, Vector3 escala, float rangoVision, float coste, List<Superficie> superficiePosible, string nombre) 
    : base(vida_total, escala, rangoVision, nombre)
    {
        this.coste = coste;
        this.superficiePosible = superficiePosible;
    }

    public bool isVivo(){
        if (vida_actual <= 0){
            return false;
        } else {
            return true;
        }
    }
}
