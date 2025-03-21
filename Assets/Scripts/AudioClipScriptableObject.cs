using UnityEngine;

// Scriptable Object, essentially an item that can be transferred between scenes.
//  - Would make it easier to apply logic to the sounds
//  - Could be updated to instead of being a scriptable object for a single audio clip, it is for the animal category

// Makes it create-able in the unity project folder as a Scriptable Object
[CreateAssetMenu(fileName = "AudioScriptableObject", menuName = "Extended Audio/Audio Clip")]
public class AudioClipScriptableObject : ScriptableObject
{
    [Tooltip("The type of audio, ie. cow.")]
    [SerializeField] string type;

    public string Type {
        get{
            return type;
        }
        set{
            type = value;
        }
    }

    [Tooltip("Specific name of the audio file for categorizing.")]
    [SerializeField] string audioName;
    public string AudioName{
        get{
            return audioName;
        }
        set{
            audioName = value;
        }
    }

    [Tooltip("The audio clip that is to be played.")]
    [SerializeField] AudioClip audioClip;
    public AudioClip AudioClip{
        get{
            return audioClip;
        }
        set{
            audioClip = value;
        }
    }
}
