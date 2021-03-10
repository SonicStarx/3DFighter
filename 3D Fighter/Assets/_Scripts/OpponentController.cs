using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentController : MonoBehaviour
{

   private bool marker;
   private int health;
   private AudioSource noise;

    void Awake()
    {
        marker = false;
        health = 30;
        noise = GetComponent<AudioSource>();
    }

   public void OnTriggerEnter(Collider C)
    {
        Debug.Log(C);
        if (C.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            marker = true;
            noise.Play();
        }
        
    }

    void Update()
    {
        if(marker == true)
        {
            health -= 5;
        }

        if(health<=0)
        {
           // Destroy(gameObject);
        }
    }

    public void OnTriggerExit(Collider C)
    {

        if (C.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            marker = false;
        }
    }
}
