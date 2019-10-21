using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToAccelerationMotion : MonoBehaviour, VRUI
{

    [SerializeField] GameObject accelerationMotionDemo;

    public void Reaction()
    {
        accelerationMotionDemo.SetActive(true);
    }

    public void Receiver()
    {
        SceneManager.LoadScene("AccelerationMotion");
    }
}
