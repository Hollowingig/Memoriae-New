using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;


public class Option : MonoBehaviour {

public bool isOpened = false; //Открыто ли меню
public float volume = 0; //Громкость
public int quality = 0; //Качество
public bool isFullscreen = false; //Полноэкранный режим
public AudioMixer audioMixer; //Регулятор громкости
public Dropdown resolutionDropdown; //Список с разрешениями для игры
private Resolution[] resolutions; //Список доступных разрешений
private int currResolutionIndex = 0; //Текущее разрешение
}