using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction { right,left,up,down}
public class Projectile : MonoBehaviour
{
    Direction myDirection;

    [SerializeField] float speed;
    [SerializeField] float lifespan;
    Vector3 dir;
    void Start()
    {
        Destroy(gameObject, lifespan);
    }

  
    void Update()
    {
        Vector3 lookTarget = transform.position - Player.instance.transform.position;
        Vector3 targetDir = new Vector3(lookTarget.x, lookTarget.y, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, Player.instance.transform.rotation, Time.deltaTime);
        transform.position = Vector2.MoveTowards(transform.position,Player.instance.transform.position,1*speed*Time.deltaTime) ;
        //transform.position += dir * speed * Time.deltaTime ;
    }

    public void SetDirection(Direction direction)
    {
        myDirection = direction;
        switch (myDirection)
        {
            case Direction.right:
                dir = Vector3.right; 
                break;
            case Direction.left:
                dir = Vector3.left;
                break;
            case Direction.up:
                dir = Vector3.up;
                break;
            case Direction.down:
                dir = Vector3.down;
                break;
            default:
                break;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player took damage");
            Destroy(gameObject);
        }
    }

}
