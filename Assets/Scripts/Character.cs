using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Character : MonoBehaviour
{
    [SerializeField] protected CharacterSO characterData;
    [SerializeField] public CharacterInputController _CharacterController;

    public void Start()
    {
        Initialization();
    }

    public void Initialization()
    {
        characterData = (CharacterSO)Resources.Load("Character1");
    }
}
