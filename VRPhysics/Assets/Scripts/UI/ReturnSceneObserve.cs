using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class ReturnSceneObserve : MonoBehaviour
{
    [SerializeField] GameObject returnSceneUI;

    // Start is called before the first frame update
    void Start()
    {
        this.UpdateAsObservable()
            .Where(_ => OVRInput.GetDown(OVRInput.RawButton.Start))
            .Subscribe(_ =>
            {
                if (returnSceneUI.activeInHierarchy)
                {
                    returnSceneUI.SetActive(false);
                }
                else
                {
                    returnSceneUI.SetActive(true);
                }
            });
    }
}
