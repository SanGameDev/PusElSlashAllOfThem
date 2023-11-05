using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables privadas
    private CharacterController controller;
    private Vector3 moveP = Vector3.zero;
    private Vector3 direction;

    //Variables publicas
    public float forwardSpeed = 5;

    public GameObject playcol;
    public float playvel;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();

        playcol = GameObject.Find("Colicion");

    }

    private void Update()
    {
        playvel = playcol.gameObject.GetComponent<SlowForHit>().playerVel;

        // direction.z = forwardSpeed;

        direction.z = playvel;

        Vector3 pos = gameObject.transform.position;

        controller.Move(moveP * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        controller.Move(direction * Time.fixedDeltaTime);
    }
}