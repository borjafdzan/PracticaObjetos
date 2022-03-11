using UnityEngine;
using System;

public abstract class Unidades 
{
    protected int vida_total;
    protected int vida_actual;
    protected Vector3 escala;
    protected float rangoVision;
    protected bool viva;
    protected string nombre;

    internal Unidades(int vida_total, Vector3 escala, float rangoVision, string nombre){
        this.vida_total = vida_total;
        this.vida_actual = this.vida_total;
        this.escala = escala;
        this.rangoVision = rangoVision;
        this.nombre = nombre;
        //Debug.Log(this.Nacer());

    }
    public string serAtacado(float fuerzaAtaque){
        return "La unidad ha sido atacada con una fuerza de ataca de " + fuerzaAtaque;
    }

    public string Morir(){

        Debug.Log("La unidad muere");
        this.viva = false;
        GC.SuppressFinalize(this);
        return "La unidad con nombre " + this.nombre + "  muere ";
        
    }

    public string Nacer(){
        this.viva = true;
        return "La unidad nace";
    }

    public virtual void ReciBirDamage(float puntosDamage){
        this.vida_actual-= (int)puntosDamage;
        if (vida_actual<= 0){
            this.vida_actual = 0;
            this.Morir();
        }
        
        Debug.Log("la vida de la unidad " + this.nombre + " es " + this.vida_actual);
    }

    public bool GetViva(){
      
        return viva;
    }
    public string GetNombre(){
        return nombre;
    }
    /*
    ~Unidades(){
        Debug.Log("El " + GetType().Name + " se destruye");

    }
    */
}

