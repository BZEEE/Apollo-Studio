using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApolloAudioClip {
// contains the audio data used by audio sources
// Audio Sources can play multiple Audio Clips
// Unity supports mono, stereo, and multichannel audio assets
// supported audio file formats are .aif .wav .mp3 .ogg
// supported tracker file formats .xm .mod .it .s3m
// ** Tracker modules are similar to midi in format (pitch, notes to play, etc)
// but tracker modules/files sound the same across different hardware devices

private AudioClip audioClip;

    public ApolloAudioClip() {
        // audioClip = new AudioClip();
    }

    public AudioClip GetAudioClip() {
        return audioClip;
    }

    // public void SetAudioClipLoadType(AudioClipLoadTypeEnum type) {
    //     // there are Enum types available for this method, so the possible inputs
    //     // are defined in the Enum (AudioClipLoadTypeEnum)
    //     switch (type) {
    //         case AudioClipLoadTypeEnum.DecompressOnLoad:
    //             audioClip.LoadType = "Decompress On Load";
    //         case AudioClipLoadTypeEnum.CompressedInMemory:
    //             audioClip.LoadType = "Compressed In Memory";
    //         case AudioClipLoadTypeEnum.Streaming:
    //             audioClip.LoadType = "Streaming";
    //         default:
    //             // Throw some Error
    //             // set default anyways
    //             audioClip.LoadType = "Decompress On Load";
    //             Print("Sample Rate is not one of the options in AudioClipLoadTypeEnum");

    //     }
    //     audioClip.LoadType = type;
    // } 

    // public void SetAudioClipCompressionFormat(AudioClipCompressionFormatEnum format) {
    //     // there are Enum types available for this method, so the possible inputs
    //     // are defined in the Enum (AudioClipCompressionFormatEnum)
    //     switch (format) {
    //         case AudioClipCompressionFormatEnum.PCM:
    //             audioClip.CompressionFormat = "PCM";
    //         case AudioClipCompressionFormatEnum.ADPCM:
    //             audioClip.CompressionFormat = "ADPCM";
    //         case AudioClipCompressionFormatEnum.Vorbis:
    //             audioClip.CompressionFormat = "Vorbis";
    //         default:
    //             // Throw some Error
    //             // set default anyways
    //             audioClip.CompressionFormat = "PCM";
    //             Print("Sample Rate is not one of the options in AudioClipCompressionFormatEnum");

    //     }
        
    // }

    // public void SetAudioClipSampleRateSetting(AudioClipSampleRateSettingEnum rate) {
    //     // there are Enum types available for this method, so the possible inputs
    //     // are defined in the Enum (AudioClipSampleRateSettingEnum)
    //     switch (rate) {
    //         case AudioClipSampleRateSettingEnum.PreserveSampleRate:
    //             audioClip.SampleRateSetting = "Preserve Sample Rate";
    //         case AudioClipSampleRateSettingEnum.OptimizeSampleRate:
    //             audioClip.SampleRateSetting = "Optimize Sample Rate";
    //         case AudioClipSampleRateSettingEnum.OverrideSampleRate:
    //             audioClip.SampleRateSetting = "Override Sample Rate";
    //         default:
    //             // Throw some Error
    //             // set default anyways
    //             audioClip.SampleRateSetting = "Preserve Sample Rate";
    //             // Print("Sample Rate is not one of the options in AudioClipSampleRateSettingEnum");

    //     }
    //     audioClip.SampleRateSetting = rate;
    // }

    // public void ForceAudioClipToMono(bool v) {
    //     audioClip.ForceToMono = v;
    // }

    // public void LoadAudioClipInBackground(bool v) {
    //     audioClip.LoadInBackground = v;
    // }

    // public void PreloadAudioClipData(bool v) {
    //     audioClip.PreloadAudioData = v;
    // }
}

