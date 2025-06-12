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


        if (option1Var[1] == 1)
        {
            eye2Image.gameObject.SetActive(false);
            eyeImage.sprite = eye1Sprite;
        }
        else if (option2Var[1] == 1)
        {
            eyeImage.gameObject.SetActive(false);
            eye2Image.sprite = eye2Sprite;
        }

        if (option1Var[2] == 1)
        {
            if (option1Var[4] == 1)
            {
                //Purple
                hairShortImage.gameObject.SetActive(false);

                bodyImage.sprite = bodyPurpleSprite;

                hairLongImage.sprite = hair2PurpleSprite;
                hairLongPieceImage.sprite = hair2PiecePurpleSprite;

                if (option1Var[3] == 1)
                {
                    fanImage.gameObject.SetActive(false);
                    fanWideImage.sprite = fan2PurpleSprite;
                }
                else if (option2Var[3] == 1)
                {
                    fanWideImage.gameObject.SetActive(false);
                    fanImage.rectTransform.sizeDelta = new Vector2(293, 293);
                    fanImage.sprite = fan1PurpleSprite;
                }
            }
            else if (option2Var[4] == 1)
            {
                //Yellow
                hairLongImage.gameObject.SetActive(false);
                hairLongPieceImage.gameObject.SetActive(false);

                bodyImage.sprite = bodyYellowSprite;
                hairShortImage.sprite = hair1YellowSprite;

                if (option1Var[3] == 1)
                {
                    fanImage.gameObject.SetActive(false);
                    fanWideImage.sprite = fan2YellowSprite;
                }
                else if (option2Var[3] == 1)
                {
                    fanWideImage.gameObject.SetActive(false);
                    fanImage.rectTransform.sizeDelta = new Vector2(202, 202);
                    fanImage.sprite = fan1YellowSprite;
                }
            }
        }
        else if (option2Var[2] == 1)
        {
            if (option1Var[3] == 1)
            {
                //Pink
                bodyImage.sprite = bodyPinkSprite;

                fanImage.gameObject.SetActive(false);
                fanWideImage.sprite = fan2PinkSprite;

                if (option1Var[4] == 1)
                {
                    hairShortImage.gameObject.SetActive(false);
                    hairLongImage.sprite = hair2PinkSprite;
                    hairLongPieceImage.sprite = hair2PiecePinkSprite;

                }
                else if (option2Var[4] == 1)
                {
                    hairLongImage.gameObject.SetActive(false);
                    hairLongPieceImage.gameObject.SetActive(false);
                    hairShortImage.sprite = hair1PinkSprite;
                }

            }
            else if (option2Var[3] == 1)
            {
                //Green
                bodyImage.sprite = bodyGreenSprite;

                fanWideImage.gameObject.SetActive(false);
                fanImage.sprite = fan1GreenSprite;

                if (option1Var[4] == 1)
                {
                    hairShortImage.gameObject.SetActive(false);
                    hairLongPieceImage.sprite = hair2PieceGreenSprite;
                    hairLongImage.sprite = hair2GreenSprite;

                }
                else if (option2Var[4] == 1)
                {
                    hairLongImage.gameObject.SetActive(false);
                    hairLongPieceImage.gameObject.SetActive(false);
                    hairShortImage.sprite = hair1GreenSprite;
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
