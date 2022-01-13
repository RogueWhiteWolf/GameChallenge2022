using UnityEngine;

public class HiddenObjects : MonoBehaviour
{
    private void Awake()
    {
        gameObject.SetActive(false);
    }
}
