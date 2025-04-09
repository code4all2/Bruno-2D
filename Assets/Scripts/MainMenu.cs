using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }

    public void Sair()
    {
        Debug.Log("Saiu do jogo");
        //Application.Quit();
    }
}
