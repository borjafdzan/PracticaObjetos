using System.Collections.Generic;
using UnityEngine;

public class Arquero : Militar 
{
    internal Arquero(int vida_total, Vector2 escala, float rangoVision, float coste, List<Superficie> superficiePosible, Vector3 velocidadMovimiento, string nombre, float poderAtaque, float rangoAtaque):
    base(vida_total, escala, rangoVision, coste, superficiePosible, velocidadMovimiento, nombre, poderAtaque, rangoAtaque){
        poderAtaque = 10;
        rangoAtaque = 100;
        Nacer();
    }
}
