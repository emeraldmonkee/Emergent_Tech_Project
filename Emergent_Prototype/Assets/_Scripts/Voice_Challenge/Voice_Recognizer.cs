using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;
using System;

public class Voice_Recognizer : MonoBehaviour
{
    KeywordRecognizer keyWordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    public Voice_Challenge_Manager VCM;

    void Start ()
    {
        keywords.Add("Red", () =>
        {
            VCM.RedRecognized();
        });
        keywords.Add("Yellow", () =>
        {
            VCM.YellowRecognized();
        });
        keywords.Add("Green", () =>
        {
            VCM.GreenRecognized();
        });
        keywords.Add("Black", () =>
        {
            VCM.BlackRecognized();
        });
        keywords.Add("Pink", () =>
        {
            VCM.PinkRecognized();
        });
        keywords.Add("Orange", () =>
        {
            VCM.OrangeRecognized();
        });
        keyWordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());
        keyWordRecognizer.OnPhraseRecognized += KeywordRecognizerOnPhraseRecognized;
        keyWordRecognizer.Start();
    }
    void KeywordRecognizerOnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;

        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }
    private void Update()
    {
        
    }
}
