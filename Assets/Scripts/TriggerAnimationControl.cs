using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimationControl : MonoBehaviour
{
    public string nameTrigger;
    public GameObject gameObjects;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            gameObjects.GetComponent<Animator>().SetTrigger(nameTrigger);
        }
    }
}
