using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public void Newgame()
    {
        SceneManager.LoadScene("GAME");
    }
}