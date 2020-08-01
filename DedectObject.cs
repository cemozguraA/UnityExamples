using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DedectObject
{
    public static T DedectScreenCenterObjectClass<T>() where T : MonoBehaviour
    {
        T TurnObject = null;
        int x = Screen.width / 2;
        int y = Screen.height / 2;

        Ray ray = Camera.main.ScreenPointToRay(new Vector3(x, y));

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
            TurnObject = hit.collider.GetComponent<T>();

        return TurnObject;

    }
    public static GameObject DedectScreenCenterObject()
    {
        GameObject TurnObject = null;
        int x = Screen.width / 2;
        int y = Screen.height / 2;

        Ray ray = Camera.main.ScreenPointToRay(new Vector3(x, y));

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            TurnObject = hit.collider.gameObject;
        }
            

        return TurnObject;

    }

}
