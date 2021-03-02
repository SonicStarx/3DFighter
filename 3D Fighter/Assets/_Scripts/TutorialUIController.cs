using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialUIController : MonoBehaviour
{
    public static bool tutorialOpen = true;

    public GameObject tutorialUI;

    // Start is called before the first frame update
    void Start()
    {
        tutorialUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            tutorialUI.SetActive(false);
            tutorialOpen = false;
        }
    }
}
