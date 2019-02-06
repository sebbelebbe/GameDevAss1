using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsound : MonoBehaviour
{
    public void PlaySound() {
        FindObjectOfType<AudioManager>().Play("Clicksound");
    }
        
    }

