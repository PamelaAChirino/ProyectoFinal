using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering.PostProcessing;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent myDistance;
    [SerializeField] private UnityEvent lifePlayerEmergen;
    [SerializeField] private UnityEvent lifePlayerFull;
    [SerializeField] private UnityEvent myDragonFind;
    public float moveSpeed = 10f;

    public float rotateSpeed = 100f;

    public float tiempo;

    public float tiempoPortal = 0;
    public bool challengeOne=false;

    public GameObject baseChallengeOne;

    private Vector3 scaleI;

    private Vector3 posInitial;
    public float distaciaRecorrida=0;
    public Vector3 posAnterior;
    public static float vidaJugador=100f;

    public PostProcessVolume volumen;
    private Vignette _vignette;


    // Start is called before the first frame update
    void Start()
    {
        posInitial = transform.position;
        posAnterior = transform.position;
        volumen.profile.TryGetSettings(out _vignette);
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();
        CheckRotation();
    }

    void CheckMovement()
    {
        var xMove =
            transform.right *
            (Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime);
        var zMove =
            transform.forward *
            (Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime);
        var move = xMove + zMove;

        transform.position += move;
        if(posAnterior != transform.position){
            DistaciaRecorrida();
            posAnterior= transform.position;
            if(vidaJugador>0)
            {
              vidaJugador--;
              _vignette.intensity.value ++;
            }
            if(vidaJugador == 0 || vidaJugador<0)
            {
              lifePlayerEmergen.Invoke();
            }

            
        }else{
            if(vidaJugador<100f)
            {
              vidaJugador++;
              _vignette.intensity.value --;
            }
            if(vidaJugador == 100f || vidaJugador > 100f)
            {
              lifePlayerFull.Invoke();
            }
            
        }
    }

    void CheckRotation()
    {
        var rotation =
            Input.GetAxisRaw("Mouse X") * rotateSpeed * Time.deltaTime * 500;

        transform.Rotate(0f, rotation, 0f);
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.transform.gameObject.name);
        if (col.transform.gameObject.name == "PortalPuertaA")
        {
            PositionChallengeOne();
            challengeOne= true;
        }
        if (col.transform.gameObject.name == "PortalDoorEndChallengeOne")
        {
            Respawn();
            challengeOne= false;
        }
        if (col.transform.gameObject.name == "Enemy")
        {
            Respawn();
            challengeOne= false;
        }
        if(col.CompareTag("Dragon")){
            myDragonFind.Invoke();
        }
    }

    void PositionChallengeOne()
    {
        transform.position = baseChallengeOne.transform.position;
    }

    void Respawn()
    {
        transform.position = posInitial;
    }
    void DistaciaRecorrida()
    {
        HUDGame.distaciaRecorrida ++;
        if(HUDGame.distaciaRecorrida == 1000){
            myDistance.Invoke();
        }

    }
}