using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] float attackTimer;
    [SerializeField] Direction direction;

    void Start()
    {
        StartCoroutine(Fire());
    }


    IEnumerator Fire()
    {
        while (gameObject)
        {
            yield return new WaitForSeconds(attackTimer);
            GameObject newProjectile = Instantiate(projectile, transform.position, Quaternion.identity);
            newProjectile.transform.localRotation = transform.rotation;
            newProjectile.transform.localScale = transform.localScale;
            //newProjectile.GetComponent<Projectile>().SetDirection(direction);
        }
    }
}
