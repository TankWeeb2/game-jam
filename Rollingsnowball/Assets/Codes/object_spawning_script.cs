using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class object_spawning_script : MonoBehaviour
{
    //theo: holy variable declarations
    new public GameObject tree;
    new public GameObject player;
    new public GameObject sadtree;
    new public GameObject person;
    double timer = 0;
    double loseTimer = 0;
    float ySpeed = 1;
    float playerY;
    float oldPlayerY;
    [SerializeField] public Rigidbody2D targetRigidbody;
    public playerCode playerCode;
    void Start()
    {
        oldPlayerY = player.transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        //theo: if player exists
        if (player)
        {
            loseTimer = 0;
        }
        else
        {
            //theo: theres a "lose timer" to make a delay before the death screen comes so you can see your fate for 2.5 seconds.
            loseTimer += Time.deltaTime;
            if (loseTimer > 2.5f)
            {
                SceneManager.LoadScene("Död");
            }
        }
    }
    private void FixedUpdate()
    {
        playerY = player.transform.position.y;

        //theo: delta checks how fast player is moving and sets to y speed
        ySpeed = (oldPlayerY - playerY) * 6;
        //theo: ySpeed is the best variable ever

        //theo: increases timer until next layer of trees and people spawned
        timer += 0.01666666666f * ySpeed;

        if (timer > 0.5)
        {
            //theo: spawning the stuff
            timer = 0;
            Instantiate(tree, new Vector3(Random.Range(-10, 10), transform.position.y, transform.position.z), tree.transform.rotation);
            Instantiate(person, new Vector3(Random.Range(-6, 6), transform.position.y + 2, transform.position.z), tree.transform.rotation);
            if (transform.position.y < -60)
            {
                //theo: extra tree if you gotten far in level
                Instantiate(tree, new Vector3(Random.Range(-10, 10), transform.position.y, transform.position.z), tree.transform.rotation);
            }
        }

        oldPlayerY = player.transform.position.y;
    }
}
