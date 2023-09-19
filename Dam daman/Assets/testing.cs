using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Fire")) Destroy(gameObject);
        if(other.CompareTag("Water")) Debug.Log("air");
    }
}
