using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log($"OnTriggerEnter2D called. other's tag was {collision.tag}.");
        if(collision.CompareTag("Enemy") || collision.CompareTag("Player")) {
            Destroy(collision.gameObject);
            Debug.Log("Destroy");
        }

    }
}
