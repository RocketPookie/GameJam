using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    
    public GameObject Enemy;
    public GameObject CollectableCorn;

    public List<GameObject> spawnPoints;

    private void Start()
    {
        StartCoroutine(Spawner());
    }
    public IEnumerator Spawner() 
    {
       while (true) {

            yield return new WaitForSeconds(1);

            GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Count)];

            Instantiate(Enemy, spawnPoint.transform.position, Quaternion.identity);

            Instantiate(CollectableCorn, spawnPoint.transform.position, Quaternion.identity);
        }

        
    }
}
