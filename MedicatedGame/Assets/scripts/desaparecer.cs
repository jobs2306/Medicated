using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desaparecer : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D other) {
        Destroy(gameObject);
    }
}
