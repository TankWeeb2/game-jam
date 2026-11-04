using UnityEngine;

public class we_the_people : MonoBehaviour
{
    Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.linearVelocityX = Random.Range(-6, 6);
    }
}
