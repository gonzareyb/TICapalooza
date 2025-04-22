using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIC : MonoBehaviour
{
    float entradasVendidas;
    public float cantPlatea; 
    public float cantCampo;
    float valorCampo;
    float valorPlatea;
    float recaudacionPlatea;
    float recaudacionCampo;
    // Start is called before the first frame update
    void Start()
    {
        recaudacionCampo = cantCampo * valorCampo;
        recaudacionPlatea = cantPlatea * valorPlatea;
        entradasVendidas = recaudacionCampo + recaudacionPlatea;

        if (cantCampo > 20400 || cantCampo < 0)
        {
            Debug.Log("Error, Cantidad de entradas no valido");
            return;
        }

        if (cantPlatea > 16200 || cantPlatea < 0)
        {
            Debug.Log("Error, Cantidad de entradas no valido");
            return;
        }

        if (cantCampo == 20400 && cantPlatea == 16200)
        {
            Debug.Log("¡Sold Out!");
            return;
        }

        if (entradasVendidas > 18300)
        {
            Debug.Log("El festival fue un éxito!");
            return;
        }

        if (entradasVendidas < 18300)
        {
            Debug.Log("Debemos mejorar la convocatoria");
            return;
        }

        


        Debug.Log("se recaudo " + recaudacionCampo + " para el campo y " + recaudacionPlatea + " para platea, en total, se recaudo " + entradasVendidas);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
