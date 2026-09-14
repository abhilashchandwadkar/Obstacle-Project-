using UnityEngine;

public class Triforenemy : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Player")
        {
            enemy.SetActive(true);
        }

        Destroy(gameObject);
    }
    
}
