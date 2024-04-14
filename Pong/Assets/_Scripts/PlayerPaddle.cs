using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour
{
    public bool Oyuncu_1_mi = false;
    private float speed = 10.0f;
    private Rigidbody2D rigitBody2D;
    private Vector2 _direction;// (x,y)

    private void Start(){
        rigitBody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {   
        if(Oyuncu_1_mi){//Oyuncu 1'in kontrolleri 
            if (Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up; //(0,1)
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down; //(0,-1)
        }
        else
        {
            _direction = Vector2.zero;// (0,0)
        }
        }
        
        else{//Oyuncu 2'in kontrolleri 
            if (Input.GetKey(KeyCode.W))
        {
            _direction = Vector2.up; //(0,1)
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _direction = Vector2.down; //(0,-1)
        }
        else
        {
            _direction = Vector2.zero;// (0,0)
        }
        }
        
    }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        {
            rigitBody2D.AddForce(_direction * speed);
        }
    }
}
