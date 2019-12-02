using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class SelectScene : MonoBehaviour,VRUI
{
    enum SelectionDirection
    {
        Right, Left
    }

    [SerializeField] SelectionDirection selectionDirection;
    [SerializeField] GameObject monitorPillar;
    static bool isPillarTurning;

    public void Receiver()
    {
        switch (selectionDirection)
        {
            case SelectionDirection.Right:
                GoToSelectScene.SceneNamesIndex++;
                turnMonitorPillar(90);
                return;
            case SelectionDirection.Left:
                GoToSelectScene.SceneNamesIndex--;
                turnMonitorPillar(-90);
                return;
        }
    }

    void turnMonitorPillar(float rotationAngle)
    {
        if (monitorPillar == null || isPillarTurning)
        {
            return;
        }

        var targetAngle = monitorPillar.transform.eulerAngles.y + rotationAngle;
        if (targetAngle < 0)
        {
            targetAngle += 360;
        }
        if (targetAngle > 360)
        {
            targetAngle -= 360;
        }
        var speed = 0.06f;
        var disposable = new SingleAssignmentDisposable();
        disposable.Disposable = this.UpdateAsObservable()
            .Subscribe(_ =>
            {
                monitorPillar.transform.rotation = Quaternion.Slerp(monitorPillar.transform.rotation, Quaternion.Euler(new Vector3(0, targetAngle, 0)), speed);
                if (Mathf.Abs(targetAngle - monitorPillar.transform.eulerAngles.y) < 0.1)
                {
                    isPillarTurning = false;
                    disposable.Dispose();
                }
            });

        isPillarTurning = true;
    }

    public void Reaction()
    {
        return;
    }
}
