using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class ChangeImage : MonoBehaviour
{
    public Image original;
    public Sprite newSprite;
    new public GameObject player;
    new public GameObject cube;
    bool var = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void FixedUpdate()
    {
        if (var = true)
        {

        }
        
    }
    public void NewImage()
    {
        var = true;
        original.sprite = newSprite;
        print("rage");
        for (int i = 0; i < 1000; i++)
        {
            transform.position = player.transform.position + new Vector3(0, -4, -2);
            Instantiate(cube, new Vector3(transform.position.x + Random.Range(-2, 2), transform.position.y + Random.Range(-2, 2), transform.position.z -5), cube.transform.rotation);

        }
        transform.position = new Vector3(0, 0, 0);

    }
}
