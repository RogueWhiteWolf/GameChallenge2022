using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <Author>
/// Lisa Werner
/// </Author>
public class PickUpItem : MonoBehaviour
{
    [SerializeField] private float grabDistance = 2f;
    public Player player;

    private void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * grabDistance);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.forward * grabDistance, out hit, grabDistance) && hit.transform.gameObject.tag == "Collectable")
            {
                var collectingItem = hit.transform.gameObject.GetComponent<Item>();
                if (collectingItem)
                {
                    player.inventory.AddItem(collectingItem.item, 1);
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }

    
}
