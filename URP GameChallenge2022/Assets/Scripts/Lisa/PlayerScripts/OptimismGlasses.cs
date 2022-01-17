using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OptimismGlasses : MonoBehaviour
{
    public GameObject hiddenObjects;

    [SerializeField] private float optimismCooldown = 3f; //Connect this with stamina
    [SerializeField] public bool IsActivated { get; private set; }

    public float maxHealth = 100;
    public float currentHealth;

    public hpbar hpbar;

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
    void TakeDamage(float damage)
    {
        currentHealth -= damage;

        hpbar.SetHealth(currentHealth);
    }
    IEnumerator OptimismCooldown()
    {
        yield return new WaitForSeconds(optimismCooldown);
        IsActivated = false;
        hiddenObjects.SetActive(IsActivated);
        TakeDamage(optimismCooldown);
    }

    //private void Update()
    //{
    //    if (IsActivated)
    //    {
    //        currentHealth -= Time.deltaTime;
    //    }
    //    hpbar.SetHealth(currentHealth);
    //}

}
