using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Transform enemy;
    public float Damage;

    private void Update()
    {
        FollowTarget();
    }
    public void FollowTarget()
    {
        if(enemy != null)
        {
            Vector3 targetPosition = (enemy.position - transform.position).normalized;
            transform.position = (transform.position + targetPosition)*Time.deltaTime;
        }
    }

    public void SetEnemy(Transform enemy)
    {
        this.enemy = enemy;
    }

    private void OnTriggerEnter(Collider other)
    {
        //
    }
}
