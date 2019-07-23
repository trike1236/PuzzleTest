using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class UIManager : MonoBehaviour
{

    public char[,] puzzleWordsForDisplay;
    public List<string> puzzleWords = new List<string>();

    private Subject<List<string>> timeSubject = new Subject<List<string>>();

    public IObservable<List<string>> OnTimeChanged
    {
        get { return timeSubject; }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimeCoroutine());
        puzzleWordsForDisplay = new char[6,6];
        puzzleWordsForDisplay[1, 2] = 't';
        puzzleWordsForDisplay[1, 3] = 'a';
        puzzleWordsForDisplay[1, 4] = 'k';
        puzzleWordsForDisplay[1, 5] = 'o';
        Debug.Log(puzzleWordsForDisplay);
    }

    IEnumerator TimeCoroutine()
    {
        var time = 30;
        while (time > 0)
        {
            puzzleWords.Add(time.ToString());
            timeSubject.OnNext(puzzleWords);
            yield return new WaitForSeconds(1);
            time--;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
