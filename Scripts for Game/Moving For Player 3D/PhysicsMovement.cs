using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private SurfaceSlider _sS;

    [SerializeField] private float _speed;

    public void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sS = GetComponent<SurfaceSlider>();    
    }

    public void Move(Vector2 direction)
    {
        Vector2 directionAlongSurface = _sS.Project(direction.normalized);
        Vector2 offset = directionAlongSurface * (_speed * Time.deltaTime);
        _rb.MovePosition(_rb.position + offset);
    }
}
