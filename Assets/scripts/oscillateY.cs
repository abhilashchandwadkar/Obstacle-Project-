using UnityEngine;

public class oscillateY : MonoBehaviour
{
   [SerializeField] float speed = 0.1f;
   [SerializeField] int unit = 5;
   float starty;
   int direction = 1;

    void Start()
    {
        starty = transform.position.y;
    }


    void Update()
    {
        float y = speed*Time.deltaTime*direction;
        float ypos = transform.position.y;
        if( ypos >= starty + unit )
        {
            direction = -1;
        }
        else if( ypos <= starty )
        {
            direction = 1;
        }

        transform.Translate(0,y,0);
    }
}
