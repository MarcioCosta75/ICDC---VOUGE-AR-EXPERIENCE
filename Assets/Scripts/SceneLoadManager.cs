using UnityEngine;
using UnityEngine.SceneManagement;  // Importante para carregar cenas

public class SceneLoadManager : MonoBehaviour
{
    // M�todo para carregar a cena pelo nome
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // M�todo para carregar a cena pelo �ndice
    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}