using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private float fireRadius;
    private GameObject[] enemies;
    private Transform closestEnemy;
   
    private void Update()
    {
        FindEnemies();
        closestEnemy = FindClosestEnemy().transform;
        CheckFire(closestEnemy);
    }
    public void FindEnemies()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        this.enemies = enemies;
    }
    public GameObject FindClosestEnemy()
    {
        float closestTarget = Mathf.Infinity;
        GameObject closest = null;

        foreach(GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(enemy.transform.position, transform.position);
            
            if(distance < closestTarget)
            {
                closestTarget = distance;
                closest = enemy;
            }

        }
        return closest;
    }
    public void CheckFire(Transform enemy)
    {
        float distance = Vector3.Distance(enemy.position, transform.position);
        if(distance <= fireRadius)
        {
            GameObject go = Instantiate(projectile);
            Projectile bullet = go.GetComponent<Projectile>();
            bullet.SetEnemy(enemy);
        }
    }

}
