using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerHeron : MonoBehaviour
{
    public InputAction move;
    public Vector2 movement;
    private Rigidbody rb;
    public float speed;
    private int layerIndex;
    public float push;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        move.Enable();
        rb = GetComponent<Rigidbody>();
        layerIndex = LayerMask.NameToLayer("Box");
        push = 0;
    }

    // Update is called once per frame
    void Update()
    {
        movement = move.ReadValue<Vector2>();
        rb.linearVelocity = new Vector3(movement.x * speed, 0, 0);
    }
    private void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.layer == layerIndex) && (movement.x > 0))
        {
            push = 1;
        }
        else
        {
            push = 0;
        }
    }
}
