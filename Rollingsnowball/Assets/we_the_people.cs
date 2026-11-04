using System.Threading;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class we_the_people : MonoBehaviour
{
    public ParticleSystem particleSystemRef;
    Rigidbody2D rigidbody;
    float Timer;
    new public GameObject flesh;
    void Start()
    {
        particleSystemRef.Stop();

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
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.CompareTag("snowball"))
        {
            print("you hit a texas");
            particleSystemRef.Play();
            for (int i = 0; i < 5; i++)
            {
                Instantiate(flesh, new Vector3(transform.position.x, transform.position.y, transform.position.z), flesh.transform.rotation);
            }
            Destroy(gameObject);

        }
    }

}
