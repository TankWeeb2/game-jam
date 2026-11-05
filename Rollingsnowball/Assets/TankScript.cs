using UnityEngine;
using UnityEngine.UIElements;

public class TankScript : MonoBehaviour
{
    public playerCode playerCode;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerCode = FindFirstObjectByType<playerCode>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCode.downhill == false)
        {
            transform.position += new Vector3(0, 3 * Time.deltaTime, 0);
        }

    }
}
