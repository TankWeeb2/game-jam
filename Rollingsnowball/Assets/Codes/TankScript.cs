using UnityEngine;
using UnityEngine.SceneManagement;
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
        //theo: moves when downhill is false
        if (playerCode.downhill == false)
        {
            transform.position += new Vector3(0, 3.01f * Time.deltaTime, 0);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("god"))
        {

            SceneManager.LoadScene("Victory");

        }
    }
}
