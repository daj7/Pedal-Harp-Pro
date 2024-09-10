using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PedalPresetDropdown : MonoBehaviour
{
    [SerializeField] private PedalPresetDictionary pedalPresetDictionary;
    [SerializeField] private TMP_Dropdown pedalPresetDropdown;

    // Start is called before the first frame update
    void Start()
    {
        pedalPresetDropdown.ClearOptions();
        List<string> newOptions = new List<string>();
        newOptions.Add("--Select pedal preset--");
        foreach (string presetName in pedalPresetDictionary.dictionary.Keys)
        {
            newOptions.Add(presetName);
        }
        pedalPresetDropdown.AddOptions(newOptions);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
