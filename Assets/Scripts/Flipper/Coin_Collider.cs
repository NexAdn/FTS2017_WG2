using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Collider : MonoBehaviour {

    public Animator Animator;
    public GameObject Coin;
    public float coinAnimationDuration = 0f;
    private int coinsInserted;
    private bool animationStarted = false;
    private float animationTime = 0f;

	// Use this for initialization
	void Start () {
        Coin.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (animationStarted)
        {
            animationTime += Time.deltaTime;

            if (animationTime > coinAnimationDuration)
            {
                animationStarted = false;
                animationTime = 0f;
                Coin.SetActive(false);
            }
        }
	}

    void OnTriggerEnter(Collider maybeCoin)
    {
        Debug.Log("Collided with someting at the Coin insertion");
        if (maybeCoin.tag == "Coin")
        {
            Debug.Log("Collided with Coin");
            Coin.SetActive(true);
            Animator.SetTrigger("Coin_insert");
            animationStarted = true;
        }
    }
}
