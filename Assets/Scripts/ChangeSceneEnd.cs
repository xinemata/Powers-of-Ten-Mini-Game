using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneEnd : MonoBehaviour
{
    void Update()
    {
        // Press the space key to start coroutine
    }

    private void OnTriggerEnter(Collider other) {
    if (other.transform.CompareTag("EndGame")) {
        
        // load scene 3 upong collision
        SceneManager.LoadScene("Scene3", LoadSceneMode.Single);

        // Print to Console, works like println () in Processing or print() in p5
        Debug.Log("Game Over Cube is triggered");
    }
  }
}