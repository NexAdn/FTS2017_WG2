using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Disable_after_Flipper_Insertion : MonoBehaviour {
    
    private void OnTriggerEnter(Collider maybeCoinInserter)
    {
        if (maybeCoinInserter.tag == "Coin_Inserter")
        {
            gameObject.SetActive(false);
        }
    }
}