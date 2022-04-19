using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{

    public string gusto;
    public float grms;


    // Start is called before the first frame update
    void Start()
    {
        float valor = grms * 0.5f;
        float fru = valor * 0.9f;

        if (gusto != "FRU" && gusto != "CHO" && gusto != "DDL")
        {
            Debug.Log("Error, ingresar unicamente FRU, CHO o DDL");
        }

        else if (grms < 250)
        {
            Debug.Log("Error, solamente se puede entre 250 y 3000 grms");
        }

        else if (grms > 3000)
        {
            Debug.Log("Error, solamente se puede entre 250 y 3000 grms");
        }

        else if (gusto == "FRU")
        {
            Debug.Log("El valor es de " + fru + " pesos");
        }

        else if (gusto == "CHO" & gusto == "DDL")
        {
            Debug.Log("Su precio es de " + valor + " pesos");
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
