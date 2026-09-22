using UnityEngine;
using UnityEngine.InputSystem;

public class ScrollRoom : MonoBehaviour
{
    public InputAction scrollAction;

    public GameObject room;
    public float scrollLength;
    public float scrollAmount;
    public float scrollSpeed = 10;
    private float scrollPosition = 0;
    private void OnEnable()
    {
        scrollAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        scrollAmount = scrollSpeed * scrollAction.ReadValue<float>() * Time.deltaTime;
        scrollPosition += scrollAmount;
        if (scrollPosition > scrollLength)
        {
            scrollPosition -= scrollLength;
        }

        room.transform.position = new Vector3(-scrollPosition, 0, 0);
    }
}
