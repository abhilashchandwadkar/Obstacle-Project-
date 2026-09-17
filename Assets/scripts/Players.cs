using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
 [SerializeField] float speed = 0.1f;
 
  Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        float xvalue = Input.GetAxis("Horizontal");
        float zvalue = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(xvalue,0,zvalue);
        

        rb.MovePosition(rb.position + (movement*speed*(Time.fixedDeltaTime)));
        
    }
}
