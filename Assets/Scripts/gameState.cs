using UnityEngine;

public class gameState : MonoBehaviour
{
    private float speed = 1;
    private float timer;

    private float intervals = 10;
    private float waitTime = 5;
    private float waitTimer;
    public bool eyesOpen;

    public GameObject player;
    private PlayerHeron playerHeron;
    private ScrollRoom scroll;

    public bool lose;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        timer = 0;
        lose = false;
        eyesOpen = false;
        playerHeron = player.GetComponent<PlayerHeron>();
        scroll = GameObject.Find("Scroll").GetComponent<ScrollRoom>();
    }

    // Update is called once per frame
    void Update()
    {


        timer += Time.deltaTime * speed;
        if (timer > intervals + waitTime)
        {
            timer = 0;
        }

        if (timer <= intervals)
        {
            eyesOpen = false;
        }
        else
        {
            eyesOpen = true;
            if (playerHeron.movement.x != 0)
            {
                if (lose == false)
                {
                    lose = true;
                    Debug.Log("You Lost! :(");

                    int points = Mathf.FloorToInt(scroll.distance);

                    Debug.Log("You have " + points + " points!!!");
                }
            }
        }
    }
}
