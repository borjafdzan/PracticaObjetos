using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main4 : MonoBehaviour
{
    enum Color
    {
        rojo,
        azul
    }
    List<Superficie> listaSuperficies = new List<Superficie>(){
            Superficie.Tierra,
            Superficie.Bosque
    };
    List<string> nombres = new List<string>(){
        "Bumersindo",
        "Ramiro",
        "Eustaquio",
        "Jose miguel",
        "Bryan",
        "Jesus",
        "Moises",
        "Abraham",
        "Jeremias"
    };

    void Start()
    {
        List<Unidades> equipoRojo = RellenarLista(Color.rojo);
        List<Unidades> equipoAzul = RellenarLista(Color.azul);

        Color colorAtacante = Color.rojo;
        //Si uno de los equipos no esta vivo se termina el juego
        while (IsEquipoVivo(equipoRojo, Color.rojo) && IsEquipoVivo(equipoAzul, Color.azul))
        {
            Atacar(equipoRojo, equipoAzul, colorAtacante);
            colorAtacante = Random.Range(0, 2) == 0 ? Color.azul : Color.rojo;
        }
    }
    //Crea una lista de unidades con los militares en los indices 0 y 1
    private List<Unidades> RellenarLista(Color colorEquipo)
    {
        List<Unidades> equipo = new List<Unidades>();
        //Crear guerrero poder artaque 10 y arquero 5
        Guerrero guerrero = new Guerrero(100, new Vector2(1, 2), 20, 50, listaSuperficies, new Vector3(1, 1, 2), CogerNombre(colorEquipo), 10, 1);
        Debug.Log(guerrero.GetViva());
        Arquero arquero = new Arquero(100, new Vector2(1, 2), 20, 50, listaSuperficies, new Vector3(1, 1, 2), CogerNombre(colorEquipo), 10, 1);
        equipo.Add(guerrero);
        equipo.Add(arquero);
        //Crear dos aldeanos
        for (int i = 0; i < 2; i++)
        {
            Aldeano aldeanoRojo = new Aldeano(100, new Vector2(1, 2), 20, 30, listaSuperficies, new Vector3(50, 1, 1), CogerNombre(colorEquipo));
            equipo.Add(aldeanoRojo);
        }
        //Crear 1 Edificio 
        Edificio edificio = new Edificio(100, new Vector2(1, 2), 20, 5, listaSuperficies, "Edificion " + colorEquipo.ToString());
        equipo.Add(edificio);
        return equipo;
    }
    //Coge un nombre aleatorio y lo saca de la lista
    private string CogerNombre(Color equipo)
    {
        string nombreElegido = nombres[Random.Range(0, nombres.Count)];
        nombres.Remove(nombreElegido);
        return nombreElegido + " " + equipo.ToString();
    }
    //Se elige una unidad militar al azar y en caso de que este viva ataca ,si no pasa turno
    private void Atacar(List<Unidades> equipoRojo, List<Unidades> equipoAzul, Color atacante)
    {
        List<Unidades> listaAtacados;
        listaAtacados = atacante == Color.rojo ? equipoAzul : equipoRojo;
        List<Unidades> listaAtacantes;
        listaAtacantes = atacante != Color.rojo ? equipoAzul : equipoRojo;
        //Elegir una unidad ataque aletoriamente
        int indiceAtacanteAleatorio = Random.Range(0, 2);
        Militar unidadAtacante = (Militar)listaAtacantes[DevolverIndiceAtacanteVivo(listaAtacantes)];
        Debug.Log(unidadAtacante.Atacar(DevolverEnemigoVivo(listaAtacados)));
    }
    //Esta funcion genera un indice aleatorio hasta que encuentra a un enemigo vivo y luego lo devuelve
    private Unidades DevolverEnemigoVivo(List<Unidades> unidadesAtacadas){
        Unidades unidadElegida;
        int numeroAleatorio;
        do {
            numeroAleatorio = Random.Range(0, unidadesAtacadas.Count);
            unidadElegida = unidadesAtacadas[numeroAleatorio];
        } while(!unidadElegida.GetViva());
        return unidadElegida;
    }
    //Esta funcion genera indice aleatorio dentro de los atacantes si no esta vivo devuelve
    //el otro este esta vivo debido a que si no no entraria por el while
    private int DevolverIndiceAtacanteVivo(List<Unidades> unidadesAtacantes){
        int indiceAtacanteAleatorio = Random.Range(0, 2);
        if (unidadesAtacantes[indiceAtacanteAleatorio].GetViva()){
            return indiceAtacanteAleatorio;
        } else {
            return indiceAtacanteAleatorio==1?0:1;
        }
    }
    //Si el guerrero y el arquero estan vivos devolvemos True
    private bool IsEquipoVivo(List<Unidades> equipo, Color color)
    {
        if (equipo[0].GetViva() || equipo[1].GetViva())
        {
            return true;
        }
        Debug.Log("El equipo ganador es " + (color == Color.rojo ? "equipo azul" : "equipo rojo"));
        return false;
    }
}
