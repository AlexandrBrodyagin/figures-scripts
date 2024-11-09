using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        var scale = transform.localScale;
        transform.localScale += scale * _speed;
    }
}
