using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform player;
    Rigidbody rb;
    [SerializeField] float speed = 0.1f;
    Vector3 pos;
   

   
    void Update()
    {
        pos = player.transform.position;
        transform.position = Vector3.MoveTowards(transform.position,pos,speed*(Time.deltaTime));
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
