using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
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

}
