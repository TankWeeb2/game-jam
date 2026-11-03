using Unity.VisualScripting;
using UnityEngine;


public class object_spawning_script : MonoBehaviour
{
    new public GameObject tree;
    double timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("yes it runs theo, why wouldnt it?");
        timer += Time.deltaTime;
        if (timer > 0.5)
        {
            timer = 0;
            print("spawn");
            Instantiate(tree, new Vector3(Random.Range(-10, 10), transform.position.y, transform.position.z), tree.transform.rotation);
        }
    }
}
