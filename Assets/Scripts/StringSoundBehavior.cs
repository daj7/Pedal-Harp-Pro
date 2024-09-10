using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class StringSoundBehavior : MonoBehaviour
{
    public AudioSource flat;
    public AudioSource natural;
    public AudioSource sharp;
    public UnityEvent<string, string> pedalChange;
    public string pitchClass = "Pedal-C";
    public string pitchState = "Toggle - Nat";
    public Animator animator;

    public void PlaySound()
    {
        if (pitchState == "Toggle - Flat")
        {
            flat.PlayOneShot(flat.clip, 1f);
        }
        else if (pitchState == "Toggle - Nat")
        {
            natural.PlayOneShot(natural.clip, 1f);
        }
        else if (pitchState == "Toggle - Sharp")
        {
            sharp.PlayOneShot(sharp.clip, 1f);
        }
        animator.SetTrigger("Plucked");
        
    }

    public void OnPedalChange(string pedalName, string state)
    {
        if (pedalName == pitchClass)
        {
            pitchState = state;
            //Debug.Log("Pedal " + pedalName + " has been changed to " + pitchState);
            UpdateText();
        }
    }

    private void UpdateText()
    {
        //Debug.Log(GetComponentInChildren<Text>().text);
        
        if (pitchState == "Toggle - Nat")
        {
            GetComponentInChildren<Text>().text = this.transform.name;
        }
        else if (pitchState == "Toggle - Flat")
        {
            GetComponentInChildren<Text>().text = this.transform.name.Insert(1, "b");
        }
        else if (pitchState == "Toggle - Sharp")
        {
            GetComponentInChildren<Text>().text = this.transform.name.Insert(1, "#");
        }
        
    }
}
