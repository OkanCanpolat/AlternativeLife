using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerInstantiate : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject tower;
    private bool empty = true;

    private void OnMouseDown()
    {
        if(empty /*&& yeterli para*/)
        {
            Instantiate(tower, spawnPoint.position, tower.transform.rotation);
            
            empty = false;
        }
    }
}
