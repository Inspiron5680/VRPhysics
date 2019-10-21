using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToAccelerationMotion : MonoBehaviour, VRUI
{

    [SerializeField] GameObject accelerationMotionDemo;
    bool isRayStaying;

    public void Reaction()
    {
        if (isRayStaying)
        {
            return;
        }

        accelerationMotionDemo.SetActive(true);
        isRayStaying = true;
    }

    public void Receiver()
    {
        SceneManager.LoadScene("AccelerationMotion");
    }
}
