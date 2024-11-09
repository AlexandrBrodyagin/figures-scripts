using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;
    [SerializeField] private bool isLocal;

    private void Update()
    {
        if (isLocal == false)
        {
            transform.Translate(_movementDirection, Space.World);
        }
        else
        {
            transform.Translate(_movementDirection, Space.Self);
        }
    }
}
