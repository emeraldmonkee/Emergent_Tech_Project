using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;

public class Recognition_Manager : MonoBehaviour
{
    KeywordRecognizer keyWordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("Red", () =>
        {
            RedRecognized();
        });
        keywords.Add("Yellow", () =>
        {
            YellowRecognized();
        });
        keywords.Add("Green", () =>
        {
            GreenRecognized();
        });
        keywords.Add("Black", () =>
        {
            BlackRecognized();
        });
        keywords.Add("Pink", () =>
        {
            PinkRecognized();
        });
        keywords.Add("Orange", () =>
        {
            OrangeRecognized();
        });
        keyWordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());
        keyWordRecognizer.OnPhraseRecognized += KeywordRecognizerOnPhraseRecognized;
        keyWordRecognizer.Start();
    }
    void KeywordRecognizerOnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;

        if(keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }

    void PinkRecognized()
    {
        Debug.Log("You said Pink");
    }
    void RedRecognized()
    {
        Debug.Log("You said Red");
    }
    void GreenRecognized()
    {
        Debug.Log("You said Green");
    }
    void BlackRecognized()
    {
        Debug.Log("You said Black");
    }
    void OrangeRecognized()
    {
        Debug.Log("You said Orange");
    }
    void YellowRecognized()
    {
        Debug.Log("You said Yellow");
    }
}
