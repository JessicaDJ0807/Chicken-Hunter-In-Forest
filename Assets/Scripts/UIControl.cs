using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{
    public GameObject instruct_text, congrat_text, restart_button;
    private int defeat;

    void Start() {
        defeat = 0;
        instruct_text.SetActive(true);
        congrat_text.SetActive(false);
        restart_button.SetActive(false);
        Destroy(instruct_text, 5f); // destroy after 5s
    }

    public void Defeat() {
        // Debug.Log("Defeat!");
        defeat += 1;
        if (defeat == 4) {
            congrat_text.SetActive(true);
            restart_button.SetActive(true);
        }
    }

    public void Restart() {
        SceneManager.LoadScene(0);
    }
}
