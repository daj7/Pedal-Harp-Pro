using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Data", menuName = "ScriptableObjects/pedalPresetDictionary", order = 1)]
public class PedalPresetDictionary : ScriptableObject 
{
    //Dictionary containing definitions for pedal presets
    //Each preset definition is a string of seven letters, 'F' 'S' or 'N'
    //'F' = Flat
    //'S' = Sharp
    //'N' = Natural
    //The preset string is used to set the pedals, which affect the pitches the strings play
    //The pedals are set in the following order: DCBEFGA ("Did Columbus Bring Enough Food to Go to America")
    //A preset of NNNNNNN sets all of the pedals to the "Natural" position so the strings will play all natural notes
    //A preset of NNFNNNN sets all pedals to "Natural" except B, which is set to flat. This makes all of the B strings on the harp play B-flat instead of B-natural
     public Dictionary<string, string> dictionary = new Dictionary<string, string>()
     {
        {"C Major / A Minor", "NNNNNNN" },
        {"G Major / E Minor", "NNNNSNN" },
        {"D Major / B Minor", "NSNNSNN" },
        {"A Major / F# Minor", "NSNNSSN" },
        {"E Major / C# Minor", "SSNNSSN" },
        {"B Major / G# Minor", "SSNNSSS" },
        {"F# Major / D# Minor", "SSNSSSS" },
        {"C# Major / A# Minor", "SSSSSSS" },
        {"F Major / D Minor", "NNFNNNN" },
        {"Bb Major / G Minor", "NNFFNNN" },
        {"Eb Major / C Minor", "NNFFNNF" },
        {"Ab Major / F Minor", "FNFFNNF" },
        {"Db Major / Bb Minor", "FNFFNFF" },
        {"Gb Major / Eb Minor", "FFFFNFF" },
        {"Cb Major / Ab Minor", "FFFFFFF" },
        {"CM / am Pentatonic", "NNSNFNN" },
        {"GM / em Pentatonic", "NFNNFNN" },
        {"DM / bm Pentatonic", "NFNNSFN" },
        {"AM / f#m Pentatonic", "FSNNSFN" },
        {"EM / c#m Pentatonic", "FSNNSSF" },
        {"BM / g#m Pentatonic", "SSNFSSF" },
        {"F#M / d#m Pentatonic", "SSFFSSS" },
        {"C#M / a#m Pentatonic", "SSFSNSS" },
        {"FM / dm Pentatonic", "NNSSNNN" },
        {"BbM / gm Pentatonic", "NNFSNNS" },
        {"EbM / cm Pentatonic", "SNFFNNS" },
        {"AbM / fm Pentatonic", "SNFFNSF" },
        {"DbM / bbm Pentatonic", "FSFFNSF" },
        {"GbM / ebm Pentatonic", "FSFFSFF" },
        {"CbM / abm Pentatonic", "FFNFSFF" },
        {"Whole Tone 0", "NNFNSFF" },
        {"Whole Tone 1", "SSNSNNN" },
        {"B# / C Diminished 7th", "SNSFSFN" },
        {"C# Diminished 7th", "FSFNFNS" },
        {"D Diminshed 7th", "NFNSNSF" },
        {"C Lydian-Mixolydian", "NNFNSNN" },
        {"G Lydian-Mixolydian", "NSNNNNN" },
        {"D Lydian-Mixolydian", "NNNNSSN" },
        {"A Lydian-Mixolydian", "SSNNSNN" },
        {"E Lydian-Mixolydian", "NSNNSSS" },
        {"B Lydian-Mixolydian", "SSNSSSN" },
        {"F# Lydian-Mixolydian", "SSSNSSS" },
        {"F Lydian-Mixolydian", "NNNFNNN" },
        {"Bb Lydian-Mixolydian", "NNFNNNF" },
        {"Eb Lydian-Mixolydian", "FNFFNNN" },
        {"Ab Lydian-Mixolydian", "NNFFNFF" },
        {"Db Lydian-Mixolydian", "FFFFNNF" },
        {"Gb Lydian-Mixolydian", "FNFFFFF" },
        {"E Pelog", "SFNNFSN" },
        {"B/Cb Pelog", "SFNNSFS" },
        {"F#/Gb Pelog", "FFFSSFS" },
        {"C#/Db Pelog", "FNSSSSF" },
        {"C Double Harmonic", "FNNNNNF" },
        {"G Double Harmonic", "NNNFSNF" },
        {"D Double Harmonic", "NSFFSNN" },
        {"A Double Harmonic", "NSFNNSN" },
        {"E Double Harmonic", "SNNNNSN" },
        {"B Double Harmonic", "SNNNSNS" },
        {"F# Double Harmonic", "NSNSSNS" },
        {"C# Double Harmonic", "NSSSSSN" },
        {"F Double Harmonic", "FNFNNFN" },
        {"Bb Double Harmonic", "NFFFNFN" },
        {"Eb Double Harmonic", "NFFFFNF" },
    };
}
