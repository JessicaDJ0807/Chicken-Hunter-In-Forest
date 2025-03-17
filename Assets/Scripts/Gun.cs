using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 20f;
    public float range = 100f;
    public float impactForce = 300f;

    public Camera cam;
    public ParticleSystem flash;
    public GameObject impactEffect;
    // public GameObject food;

    public void Shoot() {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range)) {
            // Debug.Log(hit.transform.name);

            flash.Play();

            Target target = hit.transform.GetComponent<Target>();
            if (target != null) {
                target.TakeDamage(damage);
            }

            GameObject impact = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impact, 2f); // destroy after 2s

            if (hit.rigidbody != null) {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
    }
}
