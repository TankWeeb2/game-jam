using UnityEngine;

public class playerCode : MonoBehaviour
{
    int speed = 4; //the speed of the snowball
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
        
    }
    private void FixedUpdate()
    {
        rigidbody.linearVelocityX = 0;
        rigidbody.linearVelocityY = 0;
        //
        if (Input.GetKey(down))
        {
            rigidbody.linearVelocityY = -1;
        }//lovely code made by theo by the way
        if (Input.GetKey(up))
        {
            rigidbody.linearVelocityY = 1;
        }//lovely code made by theo by the way
        if (Input.GetKey(left))
        {
            rigidbody.linearVelocityX = 1;
        }
        if (Input.GetKey(right))
        {
            rigidbody.linearVelocityX = -1;
        }

    }
}
