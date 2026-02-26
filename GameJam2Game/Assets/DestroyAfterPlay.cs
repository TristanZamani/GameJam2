using UnityEngine;

public class DestroyAfterPlay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float lifetime = 6f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
