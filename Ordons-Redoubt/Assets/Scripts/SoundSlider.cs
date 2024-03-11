using TMPro;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSlider : MonoBehaviour
{
    [SerializeField]
    private AudioMixer Mixer;

   

    private void Start()
    {
        Mixer.SetFloat("Volume", Mathf.Log10(PlayerPrefs.GetFloat("Volume", 1) * 20));
    }

    public void OnChangeSlider(float Value)
    {
        

      
            
            Mixer.SetFloat("Volume", Mathf.Log10(Value) * 20);
                    
        

        

        PlayerPrefs.SetFloat("Volume", Value);
        PlayerPrefs.Save();
    }


}