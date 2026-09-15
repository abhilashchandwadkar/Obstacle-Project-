using Unity.Collections;
using UnityEngine;

public class oscillate : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    [SerializeField] int unit = 5;
    float startx;
    int direction = 1;

    void Start()
    {
        startx = transform.position.x;
    }
    void Update()
    {
        float x = speed*direction*(Time.deltaTime);
        float xpos = transform.position.x;

        if(xpos >= startx + unit)
        {
            direction = -1;
        }
        else if(xpos <= startx - unit)
        {
            direction = 1;
        }
        

        transform.Translate(x,0,0);
    }
}
