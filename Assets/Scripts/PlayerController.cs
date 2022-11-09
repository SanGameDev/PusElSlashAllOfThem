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

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    private void Update()
    {
        direction.z = forwardSpeed;

        Vector3 pos = gameObject.transform.position;

        controller.Move(moveP * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        controller.Move(direction * Time.fixedDeltaTime);
    }
}