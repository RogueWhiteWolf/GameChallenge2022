using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OptimismGlasses : MonoBehaviour
{
    public GameObject hiddenObjects;

    [SerializeField] private float optimismCooldown = 3f;
    [SerializeField] private Player player;
    [SerializeField] public bool IsActivated { get; private set; }

    private void Awake()
    {
        player = gameObject.GetComponent<Player>();
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
