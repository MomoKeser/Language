using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateUI : MonoBehaviour
{
    [SerializeField] private Sentence sentence;
    [SerializeField] private TMP_Text sentenceText;
    [SerializeField] private List<TMP_Text> englishWordTexts;

    #region DEBUG_TEST
    [SerializeField] private List<Sentence> debugSentences;
    [SerializeField] private List<Word> debugWords;

    private void Awake()
    {
        SetSentence(debugSentences[Random.Range(0, debugSentences.Count)]);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(IsUserInputCorrect(debugWords, sentence))
            {
                Debug.Log("Correct!");
                SetSentence(debugSentences[Random.Range(0, debugSentences.Count)]);
            }
            else
            {
                Debug.Log("Incorrect!");
            }
        }
    }
    #endregion

    public void SetSentence(Sentence sentence)
    {
        this.sentence = sentence;
        sentenceText.text = sentence.chineseSentence;
        for(int i = 0; i < sentence.englishWords.Count; ++i)
        {
            englishWordTexts[i].gameObject.SetActive(true);
            englishWordTexts[i].text = sentence.englishWords[i].englishText;
        }
        for(int i = sentence.englishWords.Count; i < englishWordTexts.Count; ++i)
        {
            englishWordTexts[i].gameObject.SetActive(false);
        }
    }



    public bool IsUserInputCorrect(List<Word> userWords, Sentence sentence)
    {
        if(userWords.Count != sentence.englishWords.Count) return false;
        for(int i = 0; i < sentence.englishWords.Count; ++i)
        {
            if(userWords[i].englishText != sentence.englishWords[i].englishText)
            {
                return false;
            }
        }
        return true;
    }



}
