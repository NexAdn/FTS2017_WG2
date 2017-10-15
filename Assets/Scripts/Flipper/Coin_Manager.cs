using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin_Manager : MonoBehaviour {

    public Animator Animator;
    public GameObject Coin;
    public int coinsNeeded = 3;
    public float coinAnimationDuration = 1f;
    public Transform Ball;
    public Transform ballOrigin;
    public Text flipperDisplay;
    private int coinsInserted = 0;
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

        if (Input.GetKeyDown(KeyCode.R))
        {
            startFlipper();
        }
    }

    void OnTriggerEnter(Collider maybeCoin)
    {
        if (maybeCoin.tag == "Coin")
        {
            Coin.SetActive(true);
            Animator.SetTrigger("Coin_insert");
            animationStarted = true;

            coinsInserted += 1;

            if (coinsInserted == 1)
            {
                flipperDisplay.text = "1$ of 3$";
            }

            if (coinsInserted == 2)
            {
                flipperDisplay.text = "2$ of 3$";
            }

            if (coinsInserted >= coinsNeeded)
            {
                startFlipper();
            }
        }
    }

    void startFlipper()
    {
        Ball.transform.position = new Vector3(ballOrigin.transform.position.x, ballOrigin.transform.position.y, ballOrigin.transform.position.z);

        flipperDisplay.text = "GAME STARTED";
    }
}
