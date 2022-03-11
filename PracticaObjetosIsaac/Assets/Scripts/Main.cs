using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Triangulo tri = new Triangulo(2f);
        Triangulo tri2 = new Triangulo(2.3f);
        Triangulo tri3 = new Triangulo(4.3f);

        /*
        Debug.Log(tri.CalcularArea());
        Debug.Log(tri2.CalcularArea());
        Debug.Log(Triangulo.CalcularAreaEstatico(2.8f));

        Debug.Log(Triangulo.VerCantidadTriangulos());
        float[] areas = new float[1000];
        //Crear 1000 triangulos de lado aleatorio guardando los 
        //triangulos en un arreglo
        for (int i = 0; i < areas.Length; i++)
        {
            areas[i] = Triangulo.CalcularAreaEstatico(Random.Range(0, 1000));
            //Debug.Log(areas[i]);
        }
        Debug.Log(areas[4]);
        */

        /*
                List<float> listaAreas = new List<float>();

                for (int i = 0; i < 1000; i ++){
                    listaAreas.Add(Triangulo.CalcularAreaEstatico(Random.Range(0, 1000)));
                    Debug.Log("Posicion " + i + " valor " + listaAreas[i]);
                }
                Debug.Log(listaAreas[4]);

                Debug.Log("Inice aleatorio " + listaAreas[Random.Range(0, listaAreas.Count)]);


                listaAreas.ForEach((float i)=>{
                    Debug.Log(i);
                });
                */

        List<Triangulo> listaTriangulos = new List<Triangulo>();
        for (int i = 0; i < 5; i++)
        {
            listaTriangulos.Add(new Triangulo(Random.Range(0, 20)));
        }

        Debug.Log("-----LISTA TRIANGULOS ----");
        listaTriangulos.ForEach((Triangulo i) => Debug.Log(i.CalcularArea()));

        Triangulo trianguloMenor = null;
        float areaMenor = 1000000000;
        foreach (Triangulo triangulo in listaTriangulos)
        {
            if (triangulo.CalcularArea() < areaMenor)
            {
                trianguloMenor = triangulo;
                areaMenor = triangulo.CalcularArea();
            }
        }

        listaTriangulos.Remove(trianguloMenor);
        Debug.Log("-----LISTA TRIANGULOS menor borrado ----");
        listaTriangulos.ForEach((Triangulo i) => Debug.Log(i.CalcularArea()));


    }

    // Update is called once per frame
    void Update()
    {

    }
}
