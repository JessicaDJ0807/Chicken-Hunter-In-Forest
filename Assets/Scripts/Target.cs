using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public UIControl UI;
    public Slider HP;

    private void Start() {
        HP.value = 100f;
        // control = UI.GetComponent<UIControl>();
    }

    public void TakeDamage(float amount) {
        HP.value -= amount;
        if (HP.value <= 0f) {
            Die();
        }
    }
    void Die() {
        UI.Defeat();
        Destroy(gameObject);
    }
}
