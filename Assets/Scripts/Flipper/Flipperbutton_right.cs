using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipperbutton_right : MonoBehaviour
{

    public Flipper_Manager FlipperManager;


    private void OnTriggerEnter(Collider other)
    {
        FlipperManager.rightButtonClick();
    }

    private void OnTriggerExit(Collider other)
    {
        FlipperManager.rightButtonRelease();
    }
}