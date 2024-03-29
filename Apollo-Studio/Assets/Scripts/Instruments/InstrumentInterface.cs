﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InstrumentInterfaceNS {
    public interface InstrumentInterface {
        void MoveUpAnOctave();
        void MoveDownAnOctave();
        void PlayAChord();
        void PlayBChord();
        void PlayCChord();
        void PlayDChord();
        void PlayEChord();
        void PlayFChord();
        void PlayGChord();
    }
}


