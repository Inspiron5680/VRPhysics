using UnityEngine.SceneManagement;
using UnityEngine;

public class ReturnScene : MonoBehaviour
{
    public void Return()
    {
        SceneManager.LoadScene("HomeScene");
    }

    public void Cancel()
    {
        Destroy(gameObject);
    }
}
