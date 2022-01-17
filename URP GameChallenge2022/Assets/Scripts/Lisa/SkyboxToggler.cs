using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <Author>
/// Lisa Werner
/// </Author>
public class SkyboxToggler : MonoBehaviour
{
    private OptimismGlasses optimismGlasses;
    
    private Skybox skybox;
    private Material happyMaterial;

    public Material sadMaterial;


    private void Start()
    {
        skybox = gameObject.GetComponent<Skybox>();
        happyMaterial = gameObject.GetComponent<Skybox>().material;

        optimismGlasses = gameObject.GetComponentInParent<OptimismGlasses>();
    }

    private void Update()
    {
        if (optimismGlasses.IsActivated)
        {
            skybox.material = happyMaterial;
        }
        else
        {
            skybox.material = sadMaterial;
        }
    }
}
