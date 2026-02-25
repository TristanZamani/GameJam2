using UnityEngine;
using UnityEngine.SceneManagement;

public class Diamond : MonoBehaviour
{
     private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("YouWin");
        }
    }
}

