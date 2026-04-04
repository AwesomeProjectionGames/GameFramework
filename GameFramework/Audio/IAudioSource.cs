using UnityEngine;
using UnityEngine.Audio;

namespace GameFramework.Audio
{
    /// <summary>
    /// Defines a common interface for both native Unity AudioSources and Virtual AudioSources.
    /// </summary>
    public interface IAudioSource
    {
        /// <summary>The primary AudioClip to play.</summary>
        AudioClip clip { get; set; }
        /// <summary>The volume level (0 to 1).</summary>
        float volume { get; set; }
        /// <summary>The playback pitch.</summary>
        float pitch { get; set; }
        /// <summary>Sets how much the 3D engine affects the source (0 = 2D, 1 = 3D).</summary>
        float spatialBlend { get; set; }
        /// <summary>Should the clip cycle back to the start when finished?</summary>
        bool loop { get; set; }
        /// <summary>Playback position in seconds.</summary>
        float time { get; set; }
        /// <summary>Target AudioMixerGroup for routing.</summary>
        AudioMixerGroup outputAudioMixerGroup { get; set; }
        
        /// <summary>Is the audio source currently playing?</summary>
        bool isPlaying { get; }
        /// <summary>The GameObject this source is attached to.</summary>
        GameObject gameObject { get; }
        /// <summary>The Transform of the source for spatial positioning.</summary>
        Transform transform { get; }

        /// <summary>Starts playing the scheduled clip.</summary>
        void Play();
        /// <summary>Stops playback immediately.</summary>
        void Stop();
        /// <summary>Pauses playback.</summary>
        void Pause();
        /// <summary>Unpauses playback.</summary>
        void UnPause();
        /// <summary>Plays a clip once without interrupting the main clip.</summary>
        /// <param name="shotClip">The clip to play.</param>
        /// <param name="volumeScale">The scale of the volume (0 to 1).</param>
        void PlayOneShot(AudioClip shotClip, float volumeScale = 1f);
    }
}