// Dylan McFarlin
// Date 9-27-21
// Challenge#4 Trivia
// Unity project of the game Trivia. 3 difficulty modes, 20 random questions per game, total of 150 questions in store though. Built for Mac and Windos.
// Peer Reviewed by: John Dimaano
// Comments: Flowchart was easy to follow and game ran smooth. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class questionsClass 
{
    public string question;
    public string answer1;
    public string answer2;
    public string answer3;
    public string answer4;
    public string correctAnswer;
}
