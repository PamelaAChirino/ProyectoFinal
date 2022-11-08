using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10f;

    public float rotateSpeed = 100f;

    public float tiempo;

    public float tiempoPortal = 0;

    public GameObject baseChallengeOne;

    private Vector3 scaleI;

    private Vector3 posInitial;

    int rndX;

    int rndZ;

    int rndRotY;

    // Start is called before the first frame update
    void Start()
    {
        posInitial = transform.position;
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
        }
        if (col.transform.gameObject.name == "PortalDoorEndChallengeOne")
        {
            Respawn();
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
}
