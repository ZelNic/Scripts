using UnityEngine;

public class KeyBoardInput : MonoBehaviour
{
    [SerializeField] private PhysicsMovement _movement;

    public void Awake()
    {
        _movement = GetComponent<PhysicsMovement>();
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        _movement.Move(new Vector2 (horizontal, vertical));
    }
}

