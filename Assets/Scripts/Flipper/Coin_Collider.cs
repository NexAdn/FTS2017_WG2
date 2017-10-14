using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Collider : MonoBehaviour {

    public Animator Animator;
    private int coinsInserted;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider maybeCoin)
    {
        if (maybeCoin.tag == "Coin")
        {
            Animator.SetTrigger("Coin_insert");
        }
    }
}
