using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class ReturnSceneObserve : MonoBehaviour
{
    [SerializeField] GameObject returnSceneUI;
    [SerializeField] Transform centerEye;
    GameObject instantUI;

    // Start is called before the first frame update
    void Start()
    {
        this.UpdateAsObservable()
            .Where(_ => OVRInput.GetDown(OVRInput.RawButton.Start))
            .Subscribe(_ =>
            {
                if (!instantUI)
                {
                    instantUI = Instantiate(returnSceneUI, centerEye);
                    instantUI.transform.parent = null;
                }
                else
                {
                    Destroy(instantUI);
                }
            });
    }
}
