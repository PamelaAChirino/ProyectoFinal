using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectosSobreJugador : MonoBehaviour
{
    // Start is called before the first frame update
    public void DistanciaRecorrida(){
        Debug.Log("El jugador ha recorrido una distacia de 1000");

    }
    public void LifeCrisis(){
        Debug.Log("¡Su vida ha disminuido demasiado! Por favor descanse");

    }
    public void LifeFull(){
        Debug.Log("Vida maxima");

    }
    public void ContactDragon(){
    Debug.Log("En jugador ha encontrado un dragon");
   }
}
