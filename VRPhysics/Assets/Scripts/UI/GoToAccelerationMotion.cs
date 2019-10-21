using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToAccelerationMotion : MonoBehaviour, VRUI
{

    [SerializeField] Animator animator;
    bool isRayStaying;

    public void Reaction()
    {
        if (isRayStaying)
        {
            return;
        }


    }

    public void Receiver()
    {
        SceneManager.LoadScene("AccelerationMotion");
    }
}
