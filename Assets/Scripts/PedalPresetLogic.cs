using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Text.RegularExpressions;
using TMPro;

public class PedalPresetLogic : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown pedalPresetDropdown;

    [SerializeField] private List<PedalSettings> pedals;

    static readonly Regex PresetValidator = new Regex(@"^[NSF]{7}$");

    public PedalPresetDictionary pedalPresetDictionary;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //sets the pedals to a given preset value
    //input: preset (string) - a string of seven characters 'N', 'S,' or 'F': 'N'="Natural" 'S'="Sharp" 'F'="Flat"
    //preset string should be arranged in this order of pedals: D, C, B, E, F, G, A
    //e.g. "NNNNNNN" will set all seven pedals to the "natural" position (C major)
    //e.g. "NNFFNNF" will set B, E, and A to the "flat" position and all others to the "natural" position (Eb major)
    public void setPedals()
    {
        string newSetting = "";
        
        if (pedalPresetDictionary.dictionary.TryGetValue(pedalPresetDropdown.options[pedalPresetDropdown.value].text, out newSetting))
        {
            if (PresetValidator.IsMatch(newSetting))
            {
                for (int i = 0; i < newSetting.Length; i++)
                {
                    switch (newSetting[i])
                    {
                        case 'N':
                            //change appropriate toggle setting to "true"
                            pedals[i].transform.Find("Toggle - Nat").GetComponent<Toggle>().isOn = true;
                            //fire toggle group's "Submit" function
                            pedals[i].Submit();
                            break;
                        case 'S':
                            //change appropriate toggle setting to "true"
                            pedals[i].transform.Find("Toggle - Sharp").GetComponent<Toggle>().isOn = true;
                            //fire toggle group's "Submit" function
                            pedals[i].Submit();
                            break;
                        case 'F':
                            //change appropriate toggle setting to "true"
                            pedals[i].transform.Find("Toggle - Flat").GetComponent<Toggle>().isOn = true;
                            //fire toggle group's "Submit" function
                            pedals[i].Submit();
                            break;
                    }
                }
            }
        }
        
    }
    


}
