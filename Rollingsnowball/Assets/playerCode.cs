using UnityEngine;

public class playerCode : MonoBehaviour
{
    int health = 4;
    [SerializeField]
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
        rigidbody = GetComponent<Rigidbody2D>();
    }
    new public GameObject flesh;

    // Update is called once per frame
    void Update()
    {
        //resets velocity
        rigidbody.linearVelocityY = -6;
        rigidbody.linearVelocityX = 0;

        if (Input.GetKey(down))
        {
            rigidbody.linearVelocityY += -3;
        }//lovely code made by theo by the way
        if (Input.GetKey(up))
        {
            rigidbody.linearVelocityY += 3;
        }//lovely code made by theo by the way
        if (Input.GetKey(left))
        {
            rigidbody.linearVelocityX += -5;
        }
        if (Input.GetKey(right))
        {
            rigidbody.linearVelocityX += 5;
        }
        //nice
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("something");

        if (collision.transform.name == "death")
        {
            print("ow");
            health += -1;
            print("health: " + health);

        }
        if (health < 0.1)
        {
            for (int i = 0; i < 7; i++)
            {
                Instantiate(flesh, new Vector3(transform.position.x, transform.position.y, transform.position.z), flesh.transform.rotation);
            }
            Destroy(gameObject);
        }

    }
}
