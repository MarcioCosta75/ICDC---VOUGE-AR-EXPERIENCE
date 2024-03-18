using UnityEngine;
using UnityEngine.SceneManagement;  // Importante para carregar cenas

public class SceneLoadManager : MonoBehaviour
{
    // Método para carregar a cena pelo nome
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Método para carregar a cena pelo índice
    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}