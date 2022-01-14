using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickUpItem : MonoBehaviour
{
    [SerializeField] private float grabDistance = 2f;

    private void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * grabDistance);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.forward * grabDistance, out hit, grabDistance) && hit.transform.gameObject.layer == 8) // Layer 8 is the collectable layer
            {
                // Todo: Add object to inventory
                print("Found an object: " + hit.transform.gameObject.name);
                Destroy(hit.transform.gameObject);
            }
        }
    }

    
}
