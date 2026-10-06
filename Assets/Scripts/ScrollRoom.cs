using UnityEngine;
using UnityEngine.InputSystem;

public class ScrollRoom : MonoBehaviour
{
    public InputAction scrollAction;

    public GameObject room;
    public GameObject spawner;
    private PlayerHeron haren;
    private float spawnLength = 60;
    private float spawnPosition;
    public float scrollLength;
    public float scrollAmount;
    public float scrollSpeed = 10;
    private float scrollPosition = 0;

    public float distance;

    public GameObject[] objects;
    private void OnEnable()
    {
        scrollAction.Enable();

        distance = 0;
        spawnLength = scrollLength;
        haren = GameObject.Find("Heron").GetComponent<PlayerHeron>();
    }

    // Update is called once per frame
    void Update()
    {

        scrollAmount = scrollSpeed * haren.push * Time.deltaTime;
        scrollPosition += scrollAmount;
        spawnPosition += scrollAmount;
        distance += scrollAmount;
        if (scrollPosition > scrollLength)
        {
            scrollPosition -= scrollLength;
        }
        if (spawnPosition > spawnLength)
        {
            spawnPosition -= spawnLength;
            Spawn();
        }

        room.transform.position = new Vector3(-scrollPosition, 0, 0);
    }

    void Spawn()
    {
        int randomInt = Random.Range(0, objects.Length);
        Instantiate(objects[randomInt], spawner.transform);
    }
}
