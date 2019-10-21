using UnityEngine;

public class ReturnSceneUI : MonoBehaviour,VRUI
{
    enum Choice
    {
        Done,Cancel
    }
    [SerializeField] ReturnScene returnScene;
    [SerializeField] Choice choice;

    public void Receiver()
    {
        switch (choice)
        {
            case Choice.Done:
                returnScene.Return();
                break;
            case Choice.Cancel:
                returnScene.Cancel();
                break;
        }
    }

    public void Reaction()
    {
        return;
    }
}
