using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpToEvent : MonoBehaviour
{
    private bool reachedEventArea;
    public int nextSceneIndex;

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
                SceneManager.LoadScene(nextSceneIndex, LoadSceneMode.Single);
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
