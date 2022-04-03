using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ejercicio09 : MonoBehaviour
{
    // 9. Realizá un programa que resuelva el siguiente problema:
    // Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del
    // total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
    // por las tres.
    // Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
    // mostrar lo pedido en el siguiente formato:
    // Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….

    public string nom1, nom2, nom3;
    public float cap1;
    public float cap2;
    public float cap3;
    private float porcentaje1;
    private float porcentaje2;
    private float porcentaje3;
    private float total;
    
    void Start()
    {
        total = cap1 + cap2 +cap3;
        porcentaje1 = (cap1 / total) * 100;
        porcentaje2 = (cap2/total) * 100;
        porcentaje3 = (cap3/total) * 100;

        Debug.Log("Nombre: "+nom1+", capital aportado: $"+cap1+", Porcentaje del capital: "+porcentaje1+"%");
        Debug.Log("Nombre: "+nom2+", capital aportado: $"+cap2+", Porcentaje del capital: "+porcentaje2+"%");
        Debug.Log("Nombre: "+nom3+", capital aportado: $"+cap3+", Porcentaje del capital: "+porcentaje3+"%");
        Debug.Log("Monto total aportado: $"+total);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
