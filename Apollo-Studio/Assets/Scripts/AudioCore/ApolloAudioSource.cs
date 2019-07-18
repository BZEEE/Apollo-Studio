using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApolloAudioSource {
    private AudioSource audioSource;

    public ApolloAudioSource() {
        audioSource = new AudioSource();
    }

    public AudioSource GetAudioSource() {
        return audioSource;
    }

    // public void SetAudioClip(AudioClip audioClip) {
    //     audioSource.audioClip = AudioClip;
    // }

    // public void SetAudioListenerAsAudioSourceOutput(AudioListener output) {
    //     audioSource.Output = output;
    // }

    // public void SetAudioMixerAsAudioSourceOutput(AudioMixer output) {
    //     audioSource.Output = output;
    // }

    // public void MuteAudioSource() {
    //     audioSource.Mute = true;
    // }

    // public void UnMuteAudioSource() {
    //     audioSource.Mute = false;
    // }

    // public void EnableFilterEffectsForAudioSource() {
    //     audioSource.BypassEffects = true;
    // }

    // public void DisableFilterEffectsForAudioSource() {
    //     audioSource.BypassEffects = false;
    // }

    // public void PlayAudioSource() {
    //     audioSource.Play();
    // }

    // public void EnableLoopAudioSource() {
    //     audioSource.Loop = true;
    // }

    // public void DisableLoopAudioSource() {
    //     audioSource.Loop = false;
    // }

    // public void ChangeVolumeOfAudioSource(float volume) {
    //     audioSource.Volume = volume;
    // }

    // public void ChangePitchOfAudioSource(float pitch) {
    //     audioSource.Pitch = pitch;
    // }

    // public void SetAudioMinDistance(float min) {
    //     // dont know what the units are for the world
    //     // Within the MinDistance, the sound will stay at 
    //     // loudest possible. Outside MinDistance it will begin to 
    //     // attenuate. Increase the MinDistance of a sound to make it 
    //     // ‘louder’ in a 3d world, and decrease it to make it ‘quieter’ in a 3d world.
    //     audioSource.MinDistance = min;
    // }

    // public void SetAudioMaxDistance(float max) {
    //     // dont know what the units are for the world
    //     // The distance where the sound stops attenuating at. 
    //     // Beyond this point it will stay at the volume it would 
    //     // be at MaxDistance units from the listener and will not attenuate any more.
    //     audioSource.MaxDistance = max;
    // }

    // public void SetRollOffModeForAudioSource(string mode) {
    //     audioSource.RolloffMode = mode;
    // } 
}
