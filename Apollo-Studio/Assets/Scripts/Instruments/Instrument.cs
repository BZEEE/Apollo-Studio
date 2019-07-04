using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using IntsrumentInterface;

public abstract class Instrument : IntsrumentInterface
{
    public abstract void MoveUpAnOctave() {
        // go up an octave for this instrument
    }

    public abstract void MoveDownAnOctave() {
        // go down an octave for this instrument
    }

    public abstract void PlayAChord() {
        // Play (A) chord for this instrument
    }

    public abstract void PlayBChord() {
        // Play (B) chord for this instrument
    }

    public abstract void PlayCChord() {
        // Play (C) chord for this instrument
    }

    public abstract void PlayDChord() {
        // Play (D) chord for this instrument
    }

    public abstract void PlayEChord() {
        // Play (E) chord for this instrument
    }

    public abstract void PlayFChord() {
        // Play (F) chord for this instrument
    }

    public abstract void PlayGChord() {
        // Play (G) chord for this instrument
    }
}
