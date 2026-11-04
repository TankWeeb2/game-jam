using System.Threading;
using UnityEngine;

public class we_the_people : MonoBehaviour
{
    Rigidbody2D rigidbody;
    float Timer; 
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

    }
    private void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > 0.5)
        {
            Timer = 0;
            rigidbody.linearVelocityX = Random.Range(-6, 6);
            rigidbody.linearVelocityY = -4.5f;
        }
    }
}
