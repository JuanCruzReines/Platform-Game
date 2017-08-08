﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
           SceneManager.LoadScene(SceneManager.GetActiveScene().name);
           //Application.LoadLevel(Application.loadedLevel);
    }
}
