using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "new Character", menuName = "ScriptableObjects/Character", order = 1)]
public class CharacterSO : ScriptableObject
{
    public string CharacterName;
    public float Health;
    public float MovementSpeed;
    
    
    public Sprite sprite;

}
