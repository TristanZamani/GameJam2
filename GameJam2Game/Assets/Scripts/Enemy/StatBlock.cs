using UnityEngine;
using UnityEngine.SceneManagement;
public class StatBlock : MonoBehaviour
{
    [SerializeField] private int hitPoints = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void takeDamage(int damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            Object.Destroy(gameObject);
        }
    }
        
}
