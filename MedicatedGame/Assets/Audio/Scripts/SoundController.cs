using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    void PlayPopSound()
	{
		GetComponent<AudioSource>().Play();
	}
}

