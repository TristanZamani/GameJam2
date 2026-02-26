using UnityEngine;
using UnityEngine.SceneManagement;
public class StatBlock : MonoBehaviour
{
    [SerializeField] private int hitPoints = 10;
    [SerializeField] private GameObject objectToSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    private void SpawnObject()
    {
        if(objectToSpawn != null)
    {
            // Spawn the VFX
            GameObject vfx = Instantiate(objectToSpawn, transform.position, Quaternion.identity);

            // Make it face the player
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null){
                vfx.transform.LookAt(player.transform);
            
        }
    }
}
    public void takeDamage(int damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            SpawnObject();
            Object.Destroy(gameObject);
        }
    }

}

public class BodyguardCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
