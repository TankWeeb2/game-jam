using Unity.VisualScripting;
using UnityEngine;


public class object_spawning_script : MonoBehaviour
{
    new public GameObject tree;
    double timer = 0;
    double yspeed = 1;
    [SerializeField] private Rigidbody targetRigidbody;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.5 * yspeed)
        {
            timer = 0;
            print("spawn");
            Instantiate(tree, new Vector3(Random.Range(-10, 10), transform.position.y, transform.position.z), tree.transform.rotation);
        }
    }
}
