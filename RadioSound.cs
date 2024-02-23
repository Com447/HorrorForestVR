using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RadioSound : MonoBehaviour
{
    [SerializeField] private GameObject radio;
    [SerializeField] private GameObject toyScare;
    [SerializeField] private GameObject triggerZone;




    private void OnTriggerEnter(Collider p)
    {
        if (p.tag == "Player")
        {
            radio.SetActive(true);
            spawnMan();
            StartCoroutine("waitForSound");
        }

    }

    private IEnumerator waitForSound()
    {
        yield return new WaitForSeconds(39);
        radio.SetActive(false);
        toyScare.SetActive(false);
        triggerZone.SetActive(false);
    }

    void spawnMan()
    {
        StartCoroutine("waitForMan");
    }

    private IEnumerator waitForMan()
    {
        yield return new WaitForSeconds(28);
        toyScare.SetActive(true);
    }

}
