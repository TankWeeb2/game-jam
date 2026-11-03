using Unity.VisualScripting;
using UnityEngine;


public class object_spawning_script : MonoBehaviour
{
    new public GameObject tree;
    new public GameObject player;
    double timer = 0;
    float ySpeed = 1;
    float playerY;
    float oldPlayerY;
    [SerializeField] public Rigidbody2D targetRigidbody;
    void Start()
    {
        oldPlayerY = player.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        playerY = player.transform.position.y;

        ySpeed = (oldPlayerY - playerY) * 6;
        print(ySpeed);

        //ySpeed = 0 - targetRigidbody.linearVelocity.y / 6;

        timer += 0.01666666666f * ySpeed;

        if (timer > 0.5)
        {
            timer = 0;
            print("spawn");
            Instantiate(tree, new Vector3(Random.Range(-10, 10), transform.position.y, transform.position.z), tree.transform.rotation);
        }

        oldPlayerY = player.transform.position.y;
    }
}
