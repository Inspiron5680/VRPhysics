using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToSelectScene : MonoBehaviour,VRUI
{
    [SerializeField] string[] sceneNames;
    [SerializeField] GameObject teleportation;
    [SerializeField] Transform targetObject;
    public static int SceneNamesIndex;

    public void Receiver()
    {
        if (sceneNames.Length == 0)
        {
            return;
        }

        if (SceneNamesIndex >= sceneNames.Length)
        {
            SceneNamesIndex = 0;
        }

        if (SceneNamesIndex < 0)
        {
            SceneNamesIndex = sceneNames.Length - 1;
        }

        if (sceneNames[SceneNamesIndex] == "Null")
        {
            return;
        }

        var instanceTeleportation = Instantiate(teleportation, new Vector3(targetObject.position.x, 0, targetObject.position.z), Quaternion.identity);
        instanceTeleportation.GetComponent<HomeTeleportation>().SetNextScene(sceneNames[SceneNamesIndex]);
        Destroy(transform.parent.gameObject);
    }

    public void Reaction()
    {
        return;
    }
}
