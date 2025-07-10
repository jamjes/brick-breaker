using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private string targetScene;

    public void SwitchToScene()
    {
        SceneManager.LoadScene(targetScene);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
