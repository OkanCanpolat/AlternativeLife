using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform target;
    public float SpawnTime;
    public float SpawnMinTime;
    public float SpawnMaxTime;
    private float elapsedTime;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {
        while(SpawnTime > elapsedTime)
        {
            float time = Random.Range(SpawnMinTime, SpawnMaxTime);
            yield return new WaitForSeconds(time);
            Instantiate(projectile, transform.position, projectile.transform.rotation);
            elapsedTime++;
        }
        Destroy(gameObject);
        SceneManager.LoadScene("Scene1");
    }
}
