using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManagement : MonoBehaviour
{

    public MusicNoteCodes player;

    private static string[] notes = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

    public void ChangeSounds(Dropdown dropdown)
    {
        Debug.Log("Selected new value " + dropdown.value);
        switch (dropdown.value)
        {
            case 0:
                AssignSynth();
                break;
            case 1:
                AssignKicks();
                break;
        }
        
    }

    private void AssignSynth()
    {
        string prefix = "Synth_";
        player.C_Note = GameObject.Find(prefix + "C").GetComponent<AudioSource>();
        player.Cs_Note = GameObject.Find(prefix + "C#").GetComponent<AudioSource>();
        player.D_Note = GameObject.Find(prefix + "D").GetComponent<AudioSource>();
        player.Ds_Note = GameObject.Find(prefix + "D#").GetComponent<AudioSource>();
        player.E_Note = GameObject.Find(prefix + "E").GetComponent<AudioSource>();
        player.F_Note = GameObject.Find(prefix + "F").GetComponent<AudioSource>();
        player.Fs_Note = GameObject.Find(prefix + "F#").GetComponent<AudioSource>();
        player.G_Note = GameObject.Find(prefix + "G").GetComponent<AudioSource>();
        player.Gs_Note = GameObject.Find(prefix + "G#").GetComponent<AudioSource>();
        player.A_Note = GameObject.Find(prefix + "A").GetComponent<AudioSource>();
        player.As_Note = GameObject.Find(prefix + "A#").GetComponent<AudioSource>();
        player.B_Note = GameObject.Find(prefix + "B").GetComponent<AudioSource>();
    }

    private void AssignKicks()
    {
        string prefix = "Kick_";
        player.C_Note = GameObject.Find(prefix + "C").GetComponent<AudioSource>();
        player.Cs_Note = GameObject.Find(prefix + "C#").GetComponent<AudioSource>();
        player.D_Note = GameObject.Find(prefix + "D").GetComponent<AudioSource>();
        player.Ds_Note = GameObject.Find(prefix + "D#").GetComponent<AudioSource>();
        player.E_Note = GameObject.Find(prefix + "E").GetComponent<AudioSource>();
        player.F_Note = GameObject.Find(prefix + "F").GetComponent<AudioSource>();
        player.Fs_Note = GameObject.Find(prefix + "F#").GetComponent<AudioSource>();
        player.G_Note = GameObject.Find(prefix + "G").GetComponent<AudioSource>();
        player.Gs_Note = GameObject.Find(prefix + "G#").GetComponent<AudioSource>();
        player.A_Note = GameObject.Find(prefix + "A").GetComponent<AudioSource>();
        player.As_Note = GameObject.Find(prefix + "A#").GetComponent<AudioSource>();
        player.B_Note = GameObject.Find(prefix + "B").GetComponent<AudioSource>();
    }

}
