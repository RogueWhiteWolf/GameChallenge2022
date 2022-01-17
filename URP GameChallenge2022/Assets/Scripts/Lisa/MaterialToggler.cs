using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <Author>
/// Lisa Werner
/// </Author>
public class MaterialToggler : MonoBehaviour
{
    private Renderer renderer;
    private Material happyMaterial;

    public Material sadMaterial;

    public OptimismGlasses optimismGlasses;

    private void Start()
    {
        happyMaterial = gameObject.GetComponent<Renderer>().material;
        renderer = gameObject.GetComponent<Renderer>();
    }

    private void Update()
    {
        if (optimismGlasses.IsActivated)
        {
            renderer.material = happyMaterial;
        }
        else
        {
            renderer.material = sadMaterial;
        }
    }
}

