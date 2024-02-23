using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doortrigger : MonoBehaviour
{
    [SerializeField] private GameObject door;
    [SerializeField] private GameObject triggerZone;


    private void OnTriggerEnter(Collider p)
    {
        if (p.tag == "Player")
        {
            door.SetActive(true);
            StartCoroutine("waitForSound");
            Debug.Log("waitForSound Done");
        }
        
    }

    private IEnumerator waitForSound()
    {
        yield return new WaitForSeconds(11);
        door.SetActive(false);
        triggerZone.SetActive(false);
    }




}
