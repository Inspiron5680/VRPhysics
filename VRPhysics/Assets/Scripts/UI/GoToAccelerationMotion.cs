using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToAccelerationMotion : MonoBehaviour, VRUI
{
    public void Receiver()
    {
        SceneManager.LoadScene("AccelerationMotion");
    }
}
