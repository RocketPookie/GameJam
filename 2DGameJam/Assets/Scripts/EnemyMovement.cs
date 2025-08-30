using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float EnemySpeed;
    void Update()
    {
        if (GetComponent<SpriteRenderer>())
        {
                transform.Translate ( - EnemySpeed * Time.deltaTime, 0 ,0);
        }
    }
}
