using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public bool animationBool;
    private Animator animation;

    // Start is called before the first frame update
    void Start()
    {
        animation = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            animation.SetTrigger("lpunch");
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            animation.SetTrigger("rpunch");
        }
    }
}
