using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <Author>
/// Lisa Werner
/// </Author>
public class Player : MonoBehaviour
{
    public InventoryObject inventory;

    private OptimismGlasses optimismGlasses;

    private void Awake()
    {
        optimismGlasses = gameObject.GetComponent<OptimismGlasses>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && optimismGlasses.IsActivated == false)
        {
            optimismGlasses.UseGlasses();
        }
    }

    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }
}
