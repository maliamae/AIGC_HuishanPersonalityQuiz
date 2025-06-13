using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CharacterChanges : ButtonControls
{
    //ButtonControls buttonController;

    public Image bodyImage;
    public Image hairShortImage;
    public Image hairLongImage;
    public Image hairLongPieceImage;
    public Image eyeImage;
    public Image eye2Image;
    public Image fanImage;
    public Image fanWideImage;
    public Image textImage;

    public Sprite eye1Sprite;
    public Sprite eye2Sprite;

    public Sprite fan1GreenSprite;
    public Sprite fan1YellowSprite;
    public Sprite fan1PinkSprite;
    public Sprite fan1PurpleSprite;

    public Sprite fan2GreenSprite;
    public Sprite fan2YellowSprite;
    public Sprite fan2PinkSprite;
    public Sprite fan2PurpleSprite;

    public Sprite hair1GreenSprite;
    public Sprite hair1YellowSprite;
    public Sprite hair1PinkSprite;
    public Sprite hair1PurpleSprite;

    public Sprite hair2GreenSprite;
    public Sprite hair2YellowSprite;
    public Sprite hair2PinkSprite;
    public Sprite hair2PurpleSprite;

    public Sprite hair2PieceGreenSprite;
    public Sprite hair2PieceYellowSprite;
    public Sprite hair2PiecePinkSprite;
    public Sprite hair2PiecePurpleSprite;

    public Sprite bodyGreenSprite;
    public Sprite bodyYellowSprite;
    public Sprite bodyPinkSprite;
    public Sprite bodyPurpleSprite;


    //public List<string> option2Texts = new List<string>() { string.Empty, "E", "N", "F", "P" };
    public List<Sprite> textResults = new List<Sprite>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        eyeImage = eyeImage.GetComponent<Image>();
        eye2Image = eye2Image.GetComponent<Image>();
        bodyImage = bodyImage.GetComponent<Image>();
        hairShortImage = hairShortImage.GetComponent<Image>();
        hairLongImage = hairLongImage.GetComponent<Image>();
        fanImage = fanImage.GetComponent<Image>();
        fanWideImage = fanWideImage.GetComponent<Image>();


        if (option1Var[3] == 1) //I
        {
            eye2Image.gameObject.SetActive(false);
            eyeImage.sprite = eye1Sprite;
        }
        else if (option2Var[3] == 1) //E
        {
            eyeImage.gameObject.SetActive(false);
            eye2Image.sprite = eye2Sprite;
        }

        if (option1Var[1] == 1) //S
        {
            if (option1Var[4] == 1) //J
            {
                //Purple
                hairShortImage.gameObject.SetActive(false);

                bodyImage.sprite = bodyPurpleSprite;

                hairLongImage.sprite = hair2PurpleSprite;
                hairLongPieceImage.sprite = hair2PiecePurpleSprite;

                if (option1Var[2] == 1) //T
                {
                    //ISTJ/ESTJ
                    fanImage.gameObject.SetActive(false);
                    fanWideImage.sprite = fan2PurpleSprite;
                    if (option1Var[3] == 1) //I/E
                    {
                        //ISTJ
                        textImage.sprite = textResults[8];
                    }
                    else
                    {
                        //ESTJ
                        textImage.sprite = textResults[10];
                    }
                }
                else if (option2Var[2] == 1) //F
                {
                    //ISFJ/ESFJ
                    fanWideImage.gameObject.SetActive(false);
                    fanImage.rectTransform.sizeDelta = new Vector2(293, 293);
                    fanImage.sprite = fan1PurpleSprite;
                    if (option1Var[3] == 1) //I/E
                    {
                        //ISFJ
                        textImage.sprite = textResults[9];
                    }
                    else
                    {
                        //ESFJ
                        textImage.sprite = textResults[11];
                    }
                }
            }
            else if (option2Var[4] == 1) //P
            {
                //Yellow
                hairLongImage.gameObject.SetActive(false);
                hairLongPieceImage.gameObject.SetActive(false);

                bodyImage.sprite = bodyYellowSprite;
                hairShortImage.sprite = hair1YellowSprite;

                if (option1Var[2] == 1) //T
                {
                    //ISTP/ESTP
                    fanImage.gameObject.SetActive(false);
                    fanWideImage.sprite = fan2YellowSprite;
                    if (option1Var[3] == 1) //I/E
                    {
                        //ISTP
                        textImage.sprite = textResults[12];
                    }
                    else
                    {
                        //ESTP
                        textImage.sprite = textResults[14];
                    }
                }
                else if (option2Var[2] == 1) //F
                {
                    //ISFP/ESFP
                    fanWideImage.gameObject.SetActive(false);
                    fanImage.rectTransform.sizeDelta = new Vector2(202, 202);
                    fanImage.sprite = fan1YellowSprite;
                    if (option1Var[3] == 1) //I/E
                    {
                        //ISFP
                        textImage.sprite = textResults[13];
                    }
                    else
                    {
                        //ESFP
                        textImage.sprite = textResults[15];
                    }
                }
            }
        }
        else if (option2Var[1] == 1) //N
        {
            if (option1Var[2] == 1) //T
            {
                //Pink
                bodyImage.sprite = bodyPinkSprite;

                fanImage.gameObject.SetActive(false);
                fanWideImage.sprite = fan2PinkSprite;

                if (option1Var[4] == 1) //J
                {
                    //INTJ/ENTJ
                    hairShortImage.gameObject.SetActive(false);
                    hairLongImage.sprite = hair2PinkSprite;
                    hairLongPieceImage.sprite = hair2PiecePinkSprite;
                    if (option1Var[3] == 1) //I/E
                    {
                        //INTJ
                        textImage.sprite = textResults[0];
                    }
                    else
                    {
                        //ENTJ
                        textImage.sprite = textResults[2];
                    }

                }
                else if (option2Var[4] == 1) //P
                {
                    //INTP/ENTP
                    hairLongImage.gameObject.SetActive(false);
                    hairLongPieceImage.gameObject.SetActive(false);
                    hairShortImage.sprite = hair1PinkSprite;
                    if (option1Var[3] == 1) //I/E
                    {
                        //INTP
                        textImage.sprite = textResults[1];
                    }
                    else
                    {
                        //ENTP
                        textImage.sprite = textResults[3];
                    }
                }

            }
            else if (option2Var[2] == 1) //F
            {
                //Green
                bodyImage.sprite = bodyGreenSprite;

                fanWideImage.gameObject.SetActive(false);
                fanImage.sprite = fan1GreenSprite;

                if (option1Var[4] == 1) //J
                {
                    //INFJ/ENFJ
                    hairShortImage.gameObject.SetActive(false);
                    hairLongPieceImage.sprite = hair2PieceGreenSprite;
                    hairLongImage.sprite = hair2GreenSprite;
                    if (option1Var[3] == 1) //I/E
                    {
                        //INFJ
                        textImage.sprite = textResults[4];
                    }
                    else
                    {
                        //ENFJ
                        textImage.sprite = textResults[6];
                    }

                }
                else if (option2Var[4] == 1) //P
                {
                    //INFP/ENFP
                    hairLongImage.gameObject.SetActive(false);
                    hairLongPieceImage.gameObject.SetActive(false);
                    hairShortImage.sprite = hair1GreenSprite;
                    if (option1Var[3] == 1) //I/E
                    {
                        //INFP
                        textImage.sprite = textResults[5];
                    }
                    else
                    {
                        //ENFP
                        textImage.sprite = textResults[7];
                    }
                }
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.Space))
        {
            eyeImage.sprite = eye2Sprite;
        }
        */
    }
}
