using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio06 : MonoBehaviour
{

    // 6. Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0
    //en una variable llamada num1 y muestre un mensaje por pantalla indicando "el número es
    //par" o "el número es impar". Deberá utilizar el operador “módulo” es el caracter %.

    public int num1;
    
    void Start()
    {
        if (num1 > 0)
        {

            if (num1 % 2 == 0)
            {
                Debug.Log("El número es par");
            }

            else
            {
                Debug.Log("El número es impar");
            }
        }

        else
        {
            Debug.Log("El número debe ser mayor que 0");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
