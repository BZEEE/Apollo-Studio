using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ApolloAudioListenerNS {
    public class ApolloAudioListener {
        private ApolloAudioListener audioListener;

        public ApolloAudioSource() {
            audioSource = new AudioListener();
        }

        public AudioSource GetAudioListener() {
            return audioListener;
        }
    }
}

