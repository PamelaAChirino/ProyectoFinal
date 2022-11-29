using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObstaculosMundo : MonoBehaviour
{
    [SerializeField] private UnityEvent myTrigger;
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player")){
            myTrigger.Invoke();
        }
        
    }
}
