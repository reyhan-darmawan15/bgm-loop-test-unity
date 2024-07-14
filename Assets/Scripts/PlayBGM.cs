using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnityEngine;

public class PlayBGM : MonoBehaviour
{
    public AudioSource[] bgmSourceArray;
    public AudioClip[] bgmClipArray;

    double nextStartTime;
    // Start is called before the first frame update

    void Start()
    {
        bgmSourceArray[0].clip = bgmClipArray[0];
        bgmSourceArray[1].clip = bgmClipArray[1];

        double introLength = (double)bgmClipArray[0].samples / (double)bgmClipArray[0].frequency;

        // Play intro part
        bgmSourceArray[0].PlayScheduled(AudioSettings.dspTime);

        // Play loop part
        bgmSourceArray[1].PlayScheduled(AudioSettings.dspTime + introLength);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
