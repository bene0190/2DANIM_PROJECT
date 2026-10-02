using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementNew : MonoBehaviour
{
    public float moveSpeed;
    private Animator anim;
    private Vector2 movement;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        if(movement != Vector2.zero)
        {
            anim.SetFloat("LookX",movement.x);
             anim.SetFloat("LookY",movement.y);
        }
        anim.SetFloat("Speed",movement.sqrMagnitude);
    }
}
