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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(down))
        {
            transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(up))
        {
            transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;//rerelser
        }
        if (Input.GetKey(left))
        {
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(right))
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }//rörelse kods  
    }
}
