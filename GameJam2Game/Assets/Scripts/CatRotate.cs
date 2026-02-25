using UnityEngine;

public class HorizontalRotate : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 60f;

    void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}