using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoDestroy : MonoBehaviour
{
    public int tiempoParaDestruirse = 5;
    private void Start()
    {
        StartCoroutine(DestroyTime());
    }
    public void kaboom()
    {
        Destroy(gameObject);
    }

    public IEnumerator DestroyTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(tiempoParaDestruirse);
            Destroy(gameObject);
        }
    }
}
