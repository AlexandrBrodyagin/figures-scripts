using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;

    void Update()
    {
        transform.Translate(_movementDirection, Space.Self);
    }
}
