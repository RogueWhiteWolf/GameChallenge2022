using UnityEngine;
using System.Collections.Generic;

public class HiddenObjects : MonoBehaviour
{
    // List of hiddenObjects.
    public List<Transform> hiddenObjects;

    private void Awake()
    {
        // Set this gameobject to inactive when it's loaded.
        gameObject.SetActive(false);

        // Get parent and all children of this gameobject and save them to a list.
        hiddenObjects = new List<Transform>(gameObject.GetComponentsInChildren<Transform>());

        // Get rid of the parent gameobject from the list
        hiddenObjects.RemoveAt(0); 
    }
}
