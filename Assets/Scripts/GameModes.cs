using UnityEngine;
using UnityEngine.SceneManagement;

public class GameModes : MonoBehaviour
{
    public void StartGameMode (string gamemodename)
    {
        SceneManager.LoadScene(gamemodename);
    }
    public void GoBack (string back)
    {
        SceneManager.LoadScene(back);
    }
}
