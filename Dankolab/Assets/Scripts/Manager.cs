using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [Header("Main")]
    public Transform m_CanvasTransform = null;

    [Space(10)]

    [Header("Play")]
    public GameObject m_PlayWindow = null;

    [Space(10)]

    [Header("Settings")]
    public GameObject m_SettingsWindow = null;

    public void Buttons(string value)
    {
        if (value == "PlayWindow")
        {
            m_PlayWindow.SetActive(true);
        }
        else if (value == "ClosePlayWindow")
        {
            m_PlayWindow.SetActive(false);
        }
        else if (value == "SettingsWindow")
        {
            m_SettingsWindow.SetActive(true);
        }
        else if (value == "CloseSettingsWindow")
        {
            m_SettingsWindow.SetActive(false);
        }
    }
}
