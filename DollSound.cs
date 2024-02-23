using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollSound : MonoBehaviour
{
    [SerializeField] private GameObject doll;
    [SerializeField] private GameObject triggerZone;
    [SerializeField] private AudioSource dollSound;

    private void OnTriggerEnter(Collider p)
    {
        if (p.tag == "Player")
        {
            dollSound.Play();
            StartCoroutine("waitForSound");

        }
    }

    private IEnumerator waitForSound()
    {
        yield return new WaitForSeconds(2);
        doll.SetActive(false);
        triggerZone.SetActive(false);
    }
}
