﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepsSound : MonoBehaviour
{
    //ссылочная переменная для звукового файла
    public AudioClip footsteps;

    //публичная функция, получим доступ к ней из аниматора
    public void FootStepsAudio()
    {
        //воспроизвести заданный звук на позиции игрока
        AudioSource.PlayClipAtPoint(footsteps, transform.position);
    }
}
