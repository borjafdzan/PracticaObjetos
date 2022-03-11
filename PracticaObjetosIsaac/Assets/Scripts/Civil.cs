using UnityEngine;
using System.Collections.Generic;
public abstract class Civil : Persona
{

    internal Civil(int vida_total, Vector2 escala, float rangoVision, float coste,  List<Superficie> superficiePosible, Vector3 velocidadMovimiento, string nombre):
    base(vida_total, escala, rangoVision, coste, superficiePosible, velocidadMovimiento, nombre){

    }
}
