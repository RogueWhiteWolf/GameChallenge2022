using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MaterialToggler : MonoBehaviour
{
    [SerializeField] private Renderer renderer;
    [SerializeField] private Material happyMaterial;

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

