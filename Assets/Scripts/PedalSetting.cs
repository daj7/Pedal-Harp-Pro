using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.Events;

public class PedalSettings : MonoBehaviour
{
    private ToggleGroup toggleGroup;
    public UnityEvent<string, string> pedalChange;

    // Start is called before the first frame update
    void Start()
    {
        toggleGroup = GetComponent<ToggleGroup>();
    }

    public void Submit()
    {
        Toggle t = toggleGroup.ActiveToggles().FirstOrDefault();
        //Debug.Log(t.transform.parent.parent.name + " " + t.transform.name);
        pedalChange.Invoke(t.transform.parent.parent.name, t.transform.name);
    }

    public void TestEvent(string pedalName, string pedalState)
    {
        //Debug.Log("Pedal " + pedalName + " changed state to " + pedalState);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
