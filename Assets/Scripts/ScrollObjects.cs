using UnityEngine;

public class ScrollObjects : MonoBehaviour
{
    private ScrollRoom scroll;
    private Vector3 scrollAmount;
    private float xBounds = -50;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scroll = GameObject.Find("Scroll").GetComponent<ScrollRoom>();
    }

    // Update is called once per frame
    void Update()
    {
        scrollAmount = Vector2.left * scroll.scrollAmount;
        transform.position = transform.position + scrollAmount;

        if (transform.position.x < xBounds)
        {
            Destroy(gameObject);
        }
    }
}
