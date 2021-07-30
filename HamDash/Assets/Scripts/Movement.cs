using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour{

    private Rigidbody2D rb2;
    private float dashtime;
    private int direction;
    private bool dashed;

    public float dashspeed;
    public float startDashTime;
    public float movementSpeed;

    

    void Start(){

        rb2 = GetComponent<Rigidbody2D>();
        dashtime = startDashTime;
    }
    private void FixedUpdate(){

        if (!dashed){

            if (Input.GetKey(KeyCode.A)){

                rb2.velocity = Vector2.left * movementSpeed;
                direction = 1;
            }
            else if (Input.GetKey(KeyCode.D)){

                rb2.velocity = Vector2.right * movementSpeed;
                direction = 2;
            }
            else if (Input.GetKey(KeyCode.W)){

                rb2.velocity = Vector2.up * movementSpeed;
                direction = 3;
            }
            else if (Input.GetKey(KeyCode.S)){

                rb2.velocity = Vector2.down * movementSpeed;
                direction = 4;
            }
            else{

                rb2.velocity = Vector2.zero;
            }
        }
    }

    void Update()
    {
        if (dashtime <= 0){

            dashed = false;
            dashtime = startDashTime;
        }
        else if(Input.GetKeyDown(KeyCode.Space)){

            dashed = true;
            if (direction == 1){

                rb2.velocity = Vector2.left * dashspeed;
            }
            else if (direction == 2){

                rb2.velocity = Vector2.right * dashspeed;
            }
            else if (direction == 3){

                rb2.velocity = Vector2.up * dashspeed;
            }
            else if (direction == 4){

                rb2.velocity = Vector2.down * dashspeed;
            }
        }
        if (dashed){

            dashtime -= Time.deltaTime;
        }
    }
}