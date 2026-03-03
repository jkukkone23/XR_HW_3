using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class XRRestart : MonoBehaviour
{
    public InputActionReference restartAction; // tää on A-napin InputAction

    void Start()
    {
        // Aktivoi action
        restartAction.action.Enable();

        // Kuuntele napin painallusta
        restartAction.action.performed += (ctx) =>
        {
            // Lataa nykyinen scene uudelleen
            Time.timeScale = 1f; // varmistetaan, että fysiikka jatkuu
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        };
    }
}