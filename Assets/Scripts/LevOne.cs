using UnityEngine;
using UnityEngine.SceneManagement;

public class LevOne : MonoBehaviour
{

    public void LoadScene(int level)
    {
        SceneManager.LoadScene("Level1");
    }
    public void LoadScene2(int level)
    {
        SceneManager.LoadScene("Level2");
    }
    public void LoadScene3(int level)
    {
        SceneManager.LoadScene("Level3");
    }
}