using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main3 : MonoBehaviour
{
    List<Superficie> listaSuperficies = new List<Superficie>(){
            Superficie.Tierra,
            Superficie.Bosque
    };
    List<string> nombresAleatoriosAzules = new List<string>(){
        "Bumersindo - azul",
        "Ramiro- azul",
        "Eustaquio - azul",
    };
    List<string> nombresAleatoriosRojos = new List<string>(){
        "Jesus - rojo",
        "Moises - rojo",
        "Abraham - rojo",
    };

    // Start is called before the first frame update
    void Start()
    {
        Aldeano aldeanoRojo = new Aldeano(100, new Vector2(1, 2), 20, 30, listaSuperficies, new Vector3(50, 1, 1), "Rojo");
        Aldeano aldeanoAzul = new Aldeano(100, new Vector2(1, 2), 20, 30, listaSuperficies, new Vector3(50, 1, 1), "Azul");
        List<Aldeano> listaAldeanosAzules = new List<Aldeano>(){
            aldeanoAzul
        };
        List<Aldeano> listaAldeanosRojos = new List<Aldeano>(){
            aldeanoRojo
        };

        List<Militar> listaMilitarAzul = new List<Militar>();
        List<Militar> listaMilitarRoja = new List<Militar>();

        llenarListaMilitares(listaMilitarAzul, true);
        llenarListaMilitares(listaMilitarRoja, false);

        Batalla(listaAldeanosAzules, listaAldeanosRojos, listaMilitarRoja, listaMilitarAzul);
    }

    private void Batalla(List<Aldeano> listaAldeanosAzules, List<Aldeano> listaAldeanosRojos, List<Militar> listaMilitaresRojos, List<Militar> listaMilitaresAzules)
    {
        List<List<Aldeano>> listasAldeanos = new List<List<Aldeano>>(){
            listaAldeanosAzules,
            listaAldeanosRojos
        };

        List<List<Militar>> listaMilitares = new List<List<Militar>>(){
            listaMilitaresAzules,
            listaMilitaresRojos,
        };

        int atacante = Random.Range(0, 2);
        while (true)
        {
            int turno = atacante % 2 == 0 ? 0 : 1;
            if (!Atacar(listasAldeanos[turno][0], listaMilitares[turno]))
            {
                Debug.Log(turno == 0 ? "Gana el equipo Azul" : "Gana el rojo");
                break;
            }
            atacante++;
        }
        /*
        if (aleatorio == 1)
        {
            Atacar(listaAldeanosRojos[0], listaMilitaresAzules);
        }
        while (true)
        {
            if (!Atacar(listaAldeanosRojos[0], listaMilitaresAzules))
            {
                Debug.Log("Gana el equipo Azul");
                break;
            }
            if (!Atacar(listaAldeanosAzules[0], listaMilitaresRojos))
            {
                Debug.Log("Gana el equipo rojo");
                break;
            }
        }
        */
    }

    private void llenarListaMilitares(List<Militar> lista, bool azul)
    {
        float poderAtaque = 10f;
        List<string> listaNombres = azul ? nombresAleatoriosAzules : nombresAleatoriosRojos;
        for (int i = 0; i < listaNombres.Count; i++)
        {
            string nombreMilitar = listaNombres[i];
            Militar militar = new Militar(100, new Vector2(1, 2), 20, 50, listaSuperficies, new Vector3(1, 1, 2), nombreMilitar, poderAtaque, 1);
            lista.Add(militar);
            poderAtaque += 10;
        }
    }

    //Devuelve true si mata el aldeano acaba vivo devuelve false si el aldeano no esta vivo
    private bool Atacar(Aldeano aldeanoAAtacar, List<Militar> militares)
    {
        int numeroAleatorio = Random.Range(0, militares.Count);
        militares[numeroAleatorio].Atacar(aldeanoAAtacar);
        return aldeanoAAtacar.GetViva();
    }
}
