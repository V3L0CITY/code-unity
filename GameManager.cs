using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    private Random random = new Random();
    public GameObject InstructionScreen;
    public GameObject SymbolScreen;
    public GameObject LevelOneScreen;
    public GameObject EndScreen;

    public Sprite[] LevelOneSymbols;
    public Sprite[] LevelOneLetters;

    public Image SymbolImage;
    public Image LetterImage;

    public InputField Answer;

    public string LevelOneAnswer = "";

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

    /*private IEnumerator ShowSymbolScreen()
    {
        SymbolScreen.SetActive(true);
        for(int i=0; i<LevelOneLetters.Length; i++)
        {
            SymbolImage.sprite = LevelOneSymbols[i];
            LetterImage.sprite = LevelOneLetters[i];
            yield return new WaitForSeconds(3f);
        }
        SymbolScreen.SetActive(false);
        LevelOneScreen.SetActive(true);
    }*/
   /* private IEnumerator ShowSymbolScreen()
    {
        SymbolScreen.SetActive(true);
         for(int i=0; i<LevelOneSymbols.Length; i++)
        {
         int num = UnityEngine.Random.Range(i, 4);
          
            SymbolImage.sprite = LevelOneSymbols[num - 4];
            yield return new WaitForSeconds(3f);
            }
        
         for(int i=0; i<LevelOneLetters.Length; i++)
        {
             int numm = UnityEngine.Random.Range(i ,4);
   
            LetterImage.sprite = LevelOneLetters[numm - 4];
            yield return new WaitForSeconds(3f);
            }

            
        
        SymbolScreen.SetActive(false);
        LevelOneScreen.SetActive(true);
    }*/

  private IEnumerator ShowSymbolScreen()
    {
        SymbolScreen.SetActive(true);
        for (int i = 0 ; i<LevelOneSymbols.Length;i++){
            var temp =Mathf.Ceil( UnityEngine.Random.Range()*(LevelOneSymbols.length-1));
            SymbolImage.sprite = LevelOneSymbols[i];
            yield return new WaitForSeconds(3f);

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
