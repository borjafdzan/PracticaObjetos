using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edificio : PC
{

    internal Edificio(int vida_total, Vector2 escala, float rangoVision, float coste, List<Superficie> superficiePosible ,string nombre):
    base(vida_total, escala, rangoVision, coste, superficiePosible, nombre){

    }
}
