using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTrigger : MonoBehaviour
{

    public GameObject groundSection;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SpawnTrigger"))
        {
            //Instantiate(groundSection, new Vector3(-10,0,0), Quaternion.identity); // this code leaves gaps in the spawning of the platforms.
            //to specify the rotation Quaternion.identity (no rotation at all)
            // Use the position of the current platform instead for reference
            Instantiate(groundSection, other.transform.position + new Vector3(-10, 0, 0), Quaternion.identity);

        }

        if (other.gameObject.CompareTag("DestroyTrigger"))
        {
            Destroy(other.transform.parent.gameObject);
        }
    }
}
