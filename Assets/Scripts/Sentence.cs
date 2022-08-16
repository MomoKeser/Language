using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Sentence")]
public class Sentence : ScriptableObject
{
    public string chineseSentence;
    public List<Word> englishWords;
}
