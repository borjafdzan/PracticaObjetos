using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Superficie> listaSuperficies = new List<Superficie>(){
            Superficie.Tierra, 
            Superficie.Bosque
        };

        List<Aldeano> aldeanos = new List<Aldeano>();
        List<string> nombres = new List<string>(){
            "Rojelio", 
            "Eduardo",
            "David",
            "Antonio",
            "Emanuel",
            "Ruben",
            "Elcapo",
            "El zorro",
            "Linterna verde",
            "Superman"
        };

        for (int i = 0; i < 10; i++)
        {
            Aldeano p1 = new Aldeano(100, new Vector2(1, 2), 20, 30, listaSuperficies, new Vector3(50, 1, 1), nombres[i]);
            p1.Trabajar();
            aldeanos.Add(p1);
        }

        Militar militar1 = new Militar(100, new Vector2(1, 2), 20, 50, listaSuperficies, new Vector3(1, 1, 2), "Eduardo", 100f, 1);
        Militar militar2 = new Militar(100, new Vector2(1, 2), 20, 60, listaSuperficies, new Vector3(1, 1, 2),"Ruben",  4f, 1);
        Militar militar3 = new Militar(100, new Vector2(1, 2), 20, 60, listaSuperficies, new Vector3(1, 1, 2),"Rojelio",  5f, 1);
        Debug.Log(aldeanos[0].ToString());
        Debug.Log(militar1.Atacar(aldeanos[0]));
        Debug.Log(militar1.ToString());
        Debug.Log(aldeanos[0].ToString());
        aldeanos[0].GetViva();
        if (!aldeanos[0].GetViva()){
            aldeanos[0] = null;
        }

        for (int i = 0; i < 10; i++)
        {
            militar2.Atacar(aldeanos[1]);
            if (!aldeanos[1].GetViva()){
                aldeanos[1] = null;
                Debug.Log("Se sale del bucle");
                break;
            }
        }

        Debug.Log("Este es el final");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
