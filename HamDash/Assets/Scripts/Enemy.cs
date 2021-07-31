using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] float attackTimer;
    [SerializeField] Direction direction;

    bool attacking=true;

    public IEnumerator Fire()
    {
        while (attacking)
        {
            GameObject newProjectile = Instantiate(projectile, transform.position, Quaternion.identity);
            newProjectile.transform.localRotation = transform.rotation;
            newProjectile.transform.localScale = transform.localScale;
            newProjectile.GetComponent<Projectile>().SetDirection(direction);
            yield return new WaitForSeconds(attackTimer);
        }
    }
    private void OnDisable()
    {
        attacking = false;
    }
    private void OnEnable()
    {
        attacking = true;
        StartCoroutine(Fire());
    }
}