using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Dragon : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private UnityEvent myHumanFind;
    public int vida;
    public string nombre;
    public int tipo;
    public int confianza;
    public float velocidad;
    public float fuerza;
    public int puntosRelacion;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player")){
            myHumanFind.Invoke();
        }
        
    }
}
