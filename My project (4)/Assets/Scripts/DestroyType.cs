using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyType : MonoBehaviour
{

    Random random;
    void Start()
    {
        random = FindObjectOfType<Random>();
    }

    public void OnClickDestroy()
    {

        random.DestroyObject(gameObject);
    }
}
