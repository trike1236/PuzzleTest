using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public char[,] puzzleWordsForDisplay;
    // Start is called before the first frame update
    void Start()
    {
        puzzleWordsForDisplay = new char[6,6];
        puzzleWordsForDisplay[1, 2] = 't';
        puzzleWordsForDisplay[1, 3] = 'a';
        puzzleWordsForDisplay[1, 4] = 'k';
        puzzleWordsForDisplay[1, 5] = 'o';
        Debug.Log(puzzleWordsForDisplay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
