using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyOne : MonoBehaviour
{
    public NavMeshAgent agente;
    public Transform posPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetearDestiny();
        
    }
    void SetearDestiny(){
        // agente.SetDestination(posPlayer.position);

    }
}
