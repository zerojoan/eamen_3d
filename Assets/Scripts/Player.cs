using System.Collections;
using System.Collections.Generic;
using UnityEngine;




private CharacterController _controller;

private float _horizontal;

private float _vertical;



{

    void Awake()
    {
        _controller = GetComponent<CharacterController>();

        _animator = GetComponentInChildren<Animator>();

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


 void Update()
    {
       _horizontal = Input.GetAxisRaw("Horizontal");
       _vertical = Input.GetAxisRaw("Vertical"); 
        Movement();  

    }


void Movement()
    {
        {
        
            _controller.Move(moveDirection.normalized * _playerSpeed * Time.deltaTime);
        }
    }



}




