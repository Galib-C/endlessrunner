using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinscriipt : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("snf");
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

}

