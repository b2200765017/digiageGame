using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] public TMP_Text character1Health;
    [SerializeField] public TMP_Text character2Health;
    [SerializeField] public PauseMenu pauseUI;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseUI.Pause();
        }
    }
}
