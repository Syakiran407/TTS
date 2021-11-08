using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpeechLib;

using UnityEngine.Windows.Speech;

public class Voice : MonoBehaviour
{

    private void Start()
    {
        SpVoice voice = new SpVoice();
        //ISpeechObjectTokens voices = voice.GetVoices();
        voice.Volume = 100; //value between 0-100
        voice.Rate = 2; //speed
        voice.Speak("Hello Everyone, my name is Kiran.", SpeechVoiceSpeakFlags.SVSFDefault);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            

        }
    }
}