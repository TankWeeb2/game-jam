using UnityEngine;

public class playerCode : MonoBehaviour
{
    int health = 4;
    public int score = 0;
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
    bool downhill = true;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    new public GameObject flesh;

    // Update is called once per frame
    void Update()
    {
        print(downhill);
        //resets velocity
        if (downhill == true)
        {
            rigidbody.linearVelocityY = -6;
        }
        else
        {
            rigidbody.linearVelocityY = 0;
        }

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
        if (transform.position.y < -401)
        {
            downhill = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("something");

        if (collision.transform.name == "death")
        {
            print("ow");
            health += -1;
            for (int i = 0; i < 7; i++)
            {
                Instantiate(flesh, new Vector3(transform.position.x, transform.position.y, transform.position.z), flesh.transform.rotation);
            }
            Destroy(gameObject);
        }

    }
}
