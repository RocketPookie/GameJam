using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public void kaboom()
    {
        Destroy(gameObject);
    }
}
