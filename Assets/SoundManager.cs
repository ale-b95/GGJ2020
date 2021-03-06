﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static SoundManager _instance;
    public static SoundManager Instance { get { return _instance; } }

    public List<AudioSource> cilindri;


    public AudioSource secondaryAudioFromScreen;
    public List<AudioClip> beep;

    public AudioClip victory;
    public AudioClip defeat;


    public List<AudioClip> burn;
    public List<AudioClip> plugPlastic;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }


    }

    public void PlayRullo(bool play)
    {
        if (!play)
        {
            foreach (AudioSource a in cilindri)
            {
                a.Stop();
            }
        }
        else
        {
            foreach (AudioSource a in cilindri)
            {
                if (a.isPlaying) return;
                a.Play();
            }
        }
    }

    private bool even;
    public AudioClip getTimeBeat(bool urgent)
    {
        if (!urgent)
        {
            even = !even;
            return even?beep[0]:beep[1];
        }
        else
        {
            even = !even;
            return even ? beep[2] : beep[3];
        }
    }
    public AudioClip gimmeBurn()
    {
        return burn[(int)Random.Range(0,burn.Count-1)];
    }
    public AudioClip gimmePlug()
    {
        return plugPlastic[(int)Random.Range(0, plugPlastic.Count - 1)];
    }
}
