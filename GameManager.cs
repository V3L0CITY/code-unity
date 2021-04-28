using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Assertions;

public class GameManager : MonoBehaviour
{
   

    public System.Random r = new System.Random();
    public GameObject InstructionScreen;
    public GameObject SymbolScreen;
    public GameObject LevelOneScreen;
    public GameObject EndScreen;

    public string A_to_Z="ABCDEFGHIJKLMNOPQRSTUVWXYZ";
   

    public Sprite[] LevelOneSymbols;
    public Sprite[] LevelOneLetters;
    public Sprite[] LevelOneQuestionSymbols;

    public Image SymbolImage;
    public Image QuestionSymbols;
    public Image LetterImage;

    public InputField Answer;

    public string LevelOneAnswer = "";
    int []ran=new int[4];
    int []cp=new int[4];
    

    public Text Result;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ShowInstructions");
    }
    private IEnumerator ShowInstructions()
    {
        InstructionScreen.SetActive(true);
        yield return new WaitForSeconds(3f);
        InstructionScreen.SetActive(false);
        StartCoroutine("ShowSymbolScreen");
    }

  public IEnumerator ShowSymbolScreen()
    {
        SymbolScreen.SetActive(true);
    
        
        for (int i =0 ; i<ran.Length ; i++){
        
       
           ran[i]=r.Next(1,15);
            
          Array.Copy(ran, cp, 4);

          Assert.AreEqual(ran,cp);
          

           

           
        
           
           Debug.Log(i);
           Debug.Log(ran);
           Debug.Log(cp);

           


       SymbolImage.sprite = LevelOneSymbols[ran[i]];
        
        LetterImage.sprite = LevelOneLetters[ran[i]];
    yield return new WaitForSeconds(3f);
        }
        
     SymbolScreen.SetActive(false);
  
     LevelOneScreen.SetActive(true);
     displ();
        
        
    }
public void displ()
    {
        string finalAnswer = "";
        for (int i = 0; i < 4; i++)
        {
           //LevelOneQuestionSymbols[i].sprite = QuestionSymbols[cp];
            //finalAnswer = finalAnswer + A_to_Z[cp];

        }
    }

    public void CheckAnswer()
    {
        LevelOneScreen.SetActive(false);
        Answer.text = Answer.text.ToUpper();
        if(Answer.text.Equals(LevelOneAnswer))
        {
            Result.text = "Correct Answer";
        }
        else
        {
            Result.text = "Wrong Answer";
        }
        EndScreen.SetActive(true);
    }

}
