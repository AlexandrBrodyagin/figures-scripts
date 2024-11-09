using UnityEngine;

public class MovementLocal : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;

    void Update()
    {
        transform.Translate(_movementDirection, Space.Self);
    }
}
