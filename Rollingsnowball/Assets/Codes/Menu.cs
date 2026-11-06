using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void OnPlayButton()
    {
        SceneManager.LoadScene("Game");
    }
    //starts the game
    public void OnQuitButton()
    {
       
    }
    //quits the game(not)
    public void OnCreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }

    public void OnReturnButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}//loads difrent sceans on button presses-victor j