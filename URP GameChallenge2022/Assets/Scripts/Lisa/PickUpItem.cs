using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickUpItem : MonoBehaviour
{
    [SerializeField] private float grabDistance = 2f;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Debug.DrawRay(transform.position, transform.forward * grabDistance);

            if (Physics.Raycast(transform.position, transform.forward * grabDistance, out hit) && hit.transform.gameObject.tag == "Collectable")
            {
                print("Found an object: " + hit.transform.gameObject.name);
                // Todo: Add object to inventory
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
