using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.inputString == "r")
        {

            print("respect");

        }
    }
    public void Clicked()
    {
        print("yuhuuuu");
    }

    public void SoundClick()
    {
        FindObjectOfType<AudioManager>().Play("Clicksound");
    }
}
