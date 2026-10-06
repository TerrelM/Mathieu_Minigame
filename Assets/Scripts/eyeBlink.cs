using UnityEngine;

public class eyeBlink : MonoBehaviour
{
    private gameState gameState;
    public bool Open;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        gameState = GameObject.Find("GameState").GetComponent<gameState>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameState.eyesOpen)
        {
            GetComponent<Renderer>().enabled = (Open == true);
        }
        else
        {
            GetComponent<Renderer>().enabled = (Open == false);
        }
    }
}
