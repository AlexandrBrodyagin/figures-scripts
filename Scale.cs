using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speedIncrease;

    private void Update()
    {
        var scale = transform.localScale;
        transform.localScale += scale * _speedIncrease;
    }
}
