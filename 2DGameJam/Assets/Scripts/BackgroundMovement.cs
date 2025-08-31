using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public float moveSpeed;
    public Transform spawnPoint;
    public GameObject tierra;
    public float tiempoParaInvocar;

    
    void Update()
    {
        gameObject.transform.Translate(- moveSpeed * Time.deltaTime, 0, 0);
    }
    private void Start()
    {
        StartCoroutine(Spawner());
    }
    public IEnumerator Spawner()
    {
        while (true)
        {

            yield return new WaitForSeconds(tiempoParaInvocar);


            Instantiate(tierra, spawnPoint.transform.position, Quaternion.identity);

        }


    }
}
