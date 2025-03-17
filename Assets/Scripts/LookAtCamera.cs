using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public Transform player;
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - player.position);
    }
}
