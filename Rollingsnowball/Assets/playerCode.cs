using UnityEngine;

public class playerCode : MonoBehaviour
{
    int speed = 4; //the speed of the snowball
    [SerializeField]
    KeyCode down = KeyCode.S;
    [SerializeField]
    KeyCode left = KeyCode.A;
    [SerializeField]
    KeyCode right = KeyCode.D;
    [SerializeField]
    KeyCode up = KeyCode.W;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rigidbody;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(rigidbody.linearVelocityX + rigidbody.linearVelocityY + "yum.");
        if (Input.GetKey(down))
        {
            rigidbody.linearVelocityY = -10;
        }//lovely code made by theo by the way
        if (Input.GetKey(up))
        {
            rigidbody.linearVelocityY = 10;
        }//lovely code made by theo by the way
        if (Input.GetKey(left))
        {
            rigidbody.linearVelocityX = 10;
        }
        if (Input.GetKey(right))
        {
            rigidbody.linearVelocityX = -10;
        }

    }

}
