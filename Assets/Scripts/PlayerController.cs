using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static Transform player;
    
    public float speed = 0;

    private CharacterController _characterController;
    private Vector3 _moveVector;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        MovementUpdate();
    }

    private void MovementUpdate()
    {
        _moveVector = Vector3.zero;
        


        if (Input.GetKey(KeyCode.W))
        {
            _moveVector += transform.forward;
            ;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _moveVector -= transform.forward;
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            _moveVector += transform.right;



        }
        if (Input.GetKey(KeyCode.A))
        {
            _moveVector -= transform.right;
 

        }
    }

    void FixedUpdate()
    {
        _characterController.Move(_moveVector * speed * Time.deltaTime);
    }

}
