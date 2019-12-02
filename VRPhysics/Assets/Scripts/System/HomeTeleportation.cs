using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeTeleportation : MonoBehaviour
{
    string nextSceneName;

    public void SetNextScene(string sceneName)
    {
        nextSceneName = sceneName;
    }

    public void GotoNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
