using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager_sc : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider musicSlider;
    public Slider sfxSlider;

    private void Start()
    {
        audioMixer.SetFloat("MusicVolume", Mathf.Log10(0.5f) * 20);
        audioMixer.SetFloat("SFXVolume", Mathf.Log10(0.5f) * 20);

        musicSlider.value = 0.5f;
        sfxSlider.value = 0.5f;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat("MusicVolume", Mathf.Log10(volume) * 20);
    }

    public void SetSFXVolume(float volume)
    {
        audioMixer.SetFloat("SFXVolume", Mathf.Log10(volume) * 20);
    }
}
