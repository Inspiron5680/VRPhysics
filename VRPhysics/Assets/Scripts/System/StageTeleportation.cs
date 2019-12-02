using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageTeleportation : MonoBehaviour
{
    [SerializeField] Transform targetObject;
    [SerializeField] GameObject objectUI;

    private void Start()
    {
        if (targetObject == null)
        {
            return;
        }
        transform.position = new Vector3(targetObject.position.x, 0, targetObject.position.z);
    }

    public void CanSeeUI()
    {
        objectUI.SetActive(true);
    }
}
