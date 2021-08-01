using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction { right, left, up, down }
public class Projectile : MonoBehaviour
{
    Direction myDirection;

    [SerializeField] float speed;
    Vector3 dir;
    void Start()
    {
        Destroy(gameObject, 3);
    }


    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
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
            other.GetComponent<Health>().DoDamage();
            Destroy(gameObject);
        }
    }

}