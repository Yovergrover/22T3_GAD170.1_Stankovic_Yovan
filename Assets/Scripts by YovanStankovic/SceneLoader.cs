using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YovanStankovic
{
    /// <summary>
    /// This class holds functionality for scene transition and reloading this scene to restart the game.
    /// </summary>
    public class SceneLoader : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            SceneManager.LoadScene(1);
        }
    }
}
