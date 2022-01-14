using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OptimismGlasses : MonoBehaviour
{
    public GameObject hiddenObjects;

    [SerializeField] private float optimismCooldown = 3f; //Connect this with stamina
    [SerializeField] public bool IsActivated { get; private set; }

    private void Awake()
    {
        IsActivated = false;
    }
    public void UseGlasses()
    {
        IsActivated = true;
        hiddenObjects.SetActive(IsActivated);
        StartCoroutine("OptimismCooldown");
    }

    IEnumerator OptimismCooldown()
    {
        yield return new WaitForSeconds(optimismCooldown);
        IsActivated = false;
        hiddenObjects.SetActive(IsActivated);
    }

}
