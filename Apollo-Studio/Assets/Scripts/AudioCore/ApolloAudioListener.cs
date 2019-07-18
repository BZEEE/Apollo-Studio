using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApolloAudioListener {
    private AudioListener audioListener;

    public ApolloAudioListener() {
        audioListener = new AudioListener();
    }

    public AudioListener GetAudioListener() {
        return audioListener;
    }
}

