using UnityEngine;
using UnityEngine.InputSystem;

public class textScript : MonoBehaviour
{
    private gameState gameState;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        gameState = GameObject.Find("GameState").GetComponent<gameState>();
        GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameState.lose)
        {
            GetComponent<Canvas>().enabled = true;
        }
    }
}
