/*
 * Copyright (c) 2015 Allan Pichardo
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *  http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using UnityEngine;
using System;
using System.Collections;

public class Beat : MonoBehaviour {
    private AudioProcessor processor;
    private ArrayList beats = new ArrayList();

    void Start()
    {
        //Select the instance of AudioProcessor and pass a reference
        //to this object
        processor = FindObjectOfType<AudioProcessor>();
        processor.onBeat.AddListener(OnbeatDetected);
        processor.onSpectrum.AddListener(onSpectrum);
    }

    //this event will be called every time a beat is detected.
    //Change the threshold parameter in the inspector
    //to adjust the sensitivity
    void OnbeatDetected()
    {
        traverse(beats);
     //   Debug.Log("Beat!!!");
    }

    private void traverse(ArrayList beats)
    {
        foreach(BeatListener b in beats)
        {
            b.OnNextBeat();

        }
     }

    //This event will be called every frame while music is playing
    void onSpectrum(float[] spectrum)
    {
        //The spectrum is logarithmically averaged
        //to 12 bands

        for (int i = 0; i < spectrum.Length; ++i)
        {
            Vector3 start = new Vector3(i, 0, 0);
            Vector3 end = new Vector3(i, spectrum[i], 0);
            Debug.DrawLine(start, end);
        }
    }


    public void AddListener(BeatListener listener)
    {
        beats.Add(listener);
    }



}

public interface BeatListener
{
    void OnNextBeat();

}