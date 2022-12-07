using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpToEvent : MonoBehaviour
{
    private bool reachedEventArea;

    // Start is called before the first frame update
    void Start()
    {
        reachedEventArea = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (reachedEventArea) {
            if (Input.GetKeyDown(KeyCode.Return)) {
                Debug.Log("Event");
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            reachedEventArea = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            reachedEventArea = false;
        }
    }
}
