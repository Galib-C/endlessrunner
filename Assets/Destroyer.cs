using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("snf");
        if (collision.gameObject.tag == "CleanUp")
        {
            Destroy(collision.gameObject);
        }
    }

}
