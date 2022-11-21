using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyOne : MonoBehaviour
{
    public NavMeshAgent agente;
    public Transform posPlayer;
    public Player playerInstance;
    public float timePlayerInChallenge;
    private Vector3 posInitial;
    // Start is called before the first frame update
    void Start()
    {
        posInitial = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        SetearDestiny();
        
    }
    void SetearDestiny(){
        if(playerInstance.challengeOne){
            timePlayerInChallenge +=Time.deltaTime;
            if(timePlayerInChallenge >10){
              agente.SetDestination(posPlayer.position);
            }
        }else
        {
            Respawn();
            timePlayerInChallenge=0;
            
        }
    }
    void Respawn()
    {
        transform.position = posInitial;
    }
}
