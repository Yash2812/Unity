using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LetterGenertaion : MonoBehaviour {

    char letterchoice;
    int randomnchoice;
    char[] letterstore = new char[4];
    public Button b1;
    public Button b2;
    public Button b3;
    public Button b4;
    string str;
    char[] wordmaker = new char[4];
    int count = 0;
    public Text wrdtext;
    WordList Dictonary = new WordList(); 
    Sprite sprite;
    public Text scoretext;


    void Start()
    {
        for (int i = 0; i < 4; i++)
            switch(i)
            {
                case 0: LetterSelect(i, b1);
                    break;
                case 1:
                    LetterSelect(i, b2);
                    break;
                case 2:
                    LetterSelect(i, b3);
                    break;
                case 3:
                    LetterSelect(i, b4);
                    break;

            }
        scoretext.text = "Score :" + count.ToString();
    }

	void Update ()
    {
       
         
    }
   public void OnclickB1()
    {
        wordmaker[0] = letterstore[0];
        
        str = str + wordmaker[0].ToString();
        
        print();
    }
    public void OnclickB2()
    {
        wordmaker[1] = letterstore[1];
        
        str = str + wordmaker[1].ToString();
        
            print();
    }
    public void OnclickB3()
    {
        wordmaker[2] = letterstore[2];
       
        str = str + wordmaker[2].ToString();
        
            print();
    }
   public void OnclickB4()
   {
        wordmaker[3] = letterstore[3];
        
        str = str + wordmaker[3].ToString();
        print();
   }
    void print()
    {
        scoretext.text = "Score :" + count.ToString();
        wrdtext.text = ""+str;
        
            checkword();
    }

    void checkword()
    {
        for (int i = 0; i < Dictonary.dictonary.Length; i++)

        { 
                if (string.Equals(str, Dictonary.dictonary[i])&& str.Length==3)
                {
                    Debug.Log(Dictonary.dictonary[i]);
                    count++;
                    wrdtext.text = "";
                    str = string.Empty;
                    Array.Clear(wordmaker, 0, wordmaker.Length);
                if (count == 3)
                    SceneManager.LoadScene(0);
                    print();
                    break;
                }

                else if(str.Length>3)
                {

                    str = string.Empty;
                    Array.Clear(wordmaker, 0, wordmaker.Length);
                    break;
                }
        }
    }
    
    void LetterSelect(int i = 0, Button temp=null)
    {
      
            randomnchoice = UnityEngine.Random.Range(1,27);
            
            switch (randomnchoice)
            {
                case 1:
                    letterstore[i]=letterchoice = 'A';
                    sprite = Resources.Load<Sprite>("Wood/letter_A");
                    temp.image.sprite = sprite;
                    break;

                case 2:
                       letterstore[i]=letterchoice= 'B';
                    sprite = Resources.Load<Sprite>("Wood/letter_B");
                    temp.image.sprite = sprite;
                    break;

                case 3:
                        letterstore[i]=letterchoice= 'C';
                    sprite = Resources.Load<Sprite>("Wood/letter_C");
                    temp.image.sprite = sprite;
                    break;

                case 4:
letterstore[i]=letterchoice= 'D';
                    sprite = Resources.Load<Sprite>("Wood/letter_D");
                    temp.image.sprite = sprite;
                    break;
                case 5:
letterstore[i]=letterchoice= 'E';
                    sprite = Resources.Load<Sprite>("Wood/letter_E");
                    temp.image.sprite = sprite;
                    break;
                case 6:
letterstore[i]=letterchoice= 'F';
                    sprite = Resources.Load<Sprite>("Wood/letter_F");
                    temp.image.sprite = sprite;
                    break;
                case 7:
letterstore[i]=letterchoice= 'G';
                    sprite = Resources.Load<Sprite>("Wood/letter_G");
                    temp.image.sprite = sprite;
                    break;
                case 8:
letterstore[i]=letterchoice= 'H';
                    sprite = Resources.Load<Sprite>("Wood/letter_H");
                    temp.image.sprite = sprite;
                    break;
                case 9:
letterstore[i]=letterchoice= 'I';
                    sprite = Resources.Load<Sprite>("Wood/letter_I");
                    temp.image.sprite = sprite;
                    break;
                case 10:
letterstore[i]=letterchoice= 'J';
                    sprite = Resources.Load<Sprite>("Wood/letter_J");
                    temp.image.sprite = sprite;
                break;
                case 11:
letterstore[i]=letterchoice= 'K';
                    sprite = Resources.Load<Sprite>("Wood/letter_K");
                    temp.image.sprite = sprite;
                break;
                case 12:
letterstore[i]=letterchoice= 'L';
                    sprite = Resources.Load<Sprite>("Wood/letter_L");
                    temp.image.sprite = sprite;
                break;
                case 13:
letterstore[i]=letterchoice= 'M';
                sprite = Resources.Load<Sprite>("Wood/letter_M");
                temp.image.sprite = sprite;
                break;
                case 14:
letterstore[i]=letterchoice= 'N';
                sprite = Resources.Load<Sprite>("Wood/letter_N");
                temp.image.sprite = sprite;
                break;
                case 15:
letterstore[i]=letterchoice= 'O';
                sprite = Resources.Load<Sprite>("Wood/letter_O");
                temp.image.sprite = sprite;
                break;
                case 16:
letterstore[i]=letterchoice= 'P';
                sprite = Resources.Load<Sprite>("Wood/letter_P");
                temp.image.sprite = sprite;
                break;
                case 17:
letterstore[i]=letterchoice= 'Q';
                sprite = Resources.Load<Sprite>("Wood/letter_Q");
                temp.image.sprite = sprite;
                break;
                case 18:
letterstore[i]=letterchoice= 'R';
                sprite = Resources.Load<Sprite>("Wood/letter_R");
                temp.image.sprite = sprite;
                break;
                case 19:
letterstore[i]=letterchoice= 'S';
                sprite = Resources.Load<Sprite>("Wood/letter_S");
                temp.image.sprite = sprite;
                break;
                case 20:
letterstore[i]=letterchoice= 'T';
                sprite = Resources.Load<Sprite>("Wood/letter_T");
                temp.image.sprite = sprite;
                break;
                case 21:
letterstore[i]=letterchoice= 'U';
                sprite = Resources.Load<Sprite>("Wood/letter_U");
                temp.image.sprite = sprite;
                break;
                case 22:
letterstore[i]=letterchoice= 'V';
                sprite = Resources.Load<Sprite>("Wood/letter_V");
                temp.image.sprite = sprite;
                break;
                case 23:
letterstore[i]=letterchoice= 'W';
                sprite = Resources.Load<Sprite>("Wood/letter_W");
                temp.image.sprite = sprite;
                break;
                case 24:
letterstore[i]=letterchoice= 'X';
                sprite = Resources.Load<Sprite>("Wood/letter_X");
                temp.image.sprite = sprite;
                break;
                case 25:
letterstore[i]=letterchoice= 'Y';
                sprite = Resources.Load<Sprite>("Wood/letter_Y");
                temp.image.sprite = sprite;
                break;
                case 26:
letterstore[i]=letterchoice= 'Z';
                sprite = Resources.Load<Sprite>("Wood/letter_Z");
                temp.image.sprite = sprite;
                break;
            }
            Debug.Log(letterchoice);
            
        
    }
}
