using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class TextGameScript : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI storytextMeshPro, buildingChoiceMeshPro;
    public string StoryText, buildingChoice;
    public GameObject MainMenuButtons, Level1Buttons, Level2Buttons, map, buildingButtons, Level3Buttons, 
           Level4Buttons, Level5Buttons, Level6Buttons, Level7Buttons, Level8Buttons, Level9Buttons, endMapButtons;

    void Start()
    {
        storytextMeshPro.text = StoryText;
        StoryText = "Interwoven";
        buildingChoice = "";
        Level1Buttons.SetActive(false);
        Level2Buttons.SetActive(false);
        Level3Buttons.SetActive(false);
        Level4Buttons.SetActive(false);
        Level5Buttons.SetActive(false);
        Level6Buttons.SetActive(false);
        Level7Buttons.SetActive(false);
        Level8Buttons.SetActive(false);
        Level9Buttons.SetActive(false);
        buildingButtons.SetActive(false);
        endMapButtons.SetActive(false);
        map.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        storytextMeshPro.text = StoryText;
        buildingChoiceMeshPro.text = buildingChoice;
    }

    public void startGame()
    {
        MainMenuButtons.SetActive(false);
        Level1Buttons.SetActive(true);
        Level2Buttons.SetActive(false);
        Level3Buttons.SetActive(false);
        Level4Buttons.SetActive(false);
        Level5Buttons.SetActive(false);
        Level6Buttons.SetActive(false);
        Level7Buttons.SetActive(false);
        Level8Buttons.SetActive(false);
        Level9Buttons.SetActive(false);
        buildingButtons.SetActive(false);
        endMapButtons.SetActive(false);
        map.SetActive(false);
        StoryText = "You have received three items. \nInteract with the guard.";
        buildingChoice = "";
    }

    public void exit()
    {
        Application.Quit();
    }

    public void Button1()
    {
        StoryText = "You have been sent home! \nYou lose!";
        buildingChoice = "";
    }

    public void Button2()
    {
        StoryText = "You have been sent home!\nYou lose!";
        buildingChoice = "";
    }

    public void Button3()
    {
        StoryText = "You may now enter the building!";
        buildingChoice = "";
    }

    public void Button4()
    {
        StoryText = "She gets mad at you and walks out \nYou lose!";
        buildingChoice = "";
    }

    public void Button5()
    {
        StoryText = "She thanks you and tells you which ways you can go";
        buildingChoice = "";
    }

    public void ButtonCig()
    {
        StoryText = "The bullies get in trouble and beat you up \nYou lose!";
        buildingChoice = "";
    }

    public void ButtonLostPhone()
    {
        StoryText = "The principal tells you to bring it to student services";
        buildingChoice = "";
    }

    public void ButtonComb()
    {
        StoryText = "You chat with the girl \nYou made a new friend";
        buildingChoice = "";
    }

    public void ButtonPouch()
    {
        StoryText = "You chat with the girl \nYou made a new friend";
        buildingChoice = "";
    }

    public void ButtonRuler()
    {
        StoryText = "You chat with the student \nYou made a new friend";
        buildingChoice = "";
    }

    public void ButtonPencil()
    {
        StoryText = "You chat with the student \nYou made a new friend";
        buildingChoice = "";
    }

    public void ButtonLostPouch()
    {
        StoryText = "The student services personnel asked you to return it to the owner";
        buildingChoice = "";
    }

    public void ButtonLPhone()
    {
        StoryText = "The student services thanked you";
        buildingChoice = "";
    }

    public void ButtonBLostPhone()
    {
        StoryText = "The bullies snatched the phone and ignored you";
        buildingChoice = "";
    }

    public void ButtonBRuler()
    {
        StoryText = "The bullies beat you up. \nYou lose!";
        buildingChoice = "";
    }

    public void ButtonBCigarettes()
    {
        StoryText = "The bullies let you go without hurting you";
        buildingChoice = "";
    }

    public void ButtonJLostPhone()
    {
        StoryText = "The janitor looked at you weird and ignored you after";
        buildingChoice = "";
    }

    public void ButtonMixtape()
    {
        StoryText = "The janitor handed you a note with numbers";
        buildingChoice = "";
    }

    public void ButtonKey()
    {
        StoryText = "The vending machine doesn't have a slot for the key";
        buildingChoice = "";
    }

    public void ButtonCode()
    {
        StoryText = "You hear footsteps behind you. The killer has shown themself. \nEND";
        buildingChoice = "";
    }

    ////buildingChoices

    public void Button6() //Principal's Office
    {
        MainMenuButtons.SetActive(false);
        Level1Buttons.SetActive(false);
        Level2Buttons.SetActive(false);
        Level3Buttons.SetActive(true);
        Level4Buttons.SetActive(false);
        Level5Buttons.SetActive(false); 
        Level6Buttons.SetActive(false);
        Level7Buttons.SetActive(false);
        Level8Buttons.SetActive(false);
        Level9Buttons.SetActive(false);
        buildingButtons.SetActive(false);
        endMapButtons.SetActive(false);
        map.SetActive(true);
        StoryText = "Interact with the principal";
        buildingChoice = "";
    }

    public void Button7() //Comfort Room
    {
        MainMenuButtons.SetActive(false);
        Level1Buttons.SetActive(false);
        Level2Buttons.SetActive(false);
        Level3Buttons.SetActive(false);
        Level4Buttons.SetActive(true);
        Level5Buttons.SetActive(false);
        Level6Buttons.SetActive(false);
        Level7Buttons.SetActive(false);
        Level8Buttons.SetActive(false);
        Level9Buttons.SetActive(false);
        buildingButtons.SetActive(false);
        endMapButtons.SetActive(false);
        map.SetActive(true);
        StoryText = "Interact with the girl";
        buildingChoice = "";
    }

    public void Button8() //Library
    {
        MainMenuButtons.SetActive(false);
        Level1Buttons.SetActive(false);
        Level2Buttons.SetActive(false);
        Level3Buttons.SetActive(false);
        Level4Buttons.SetActive(false);
        Level5Buttons.SetActive(true);
        Level6Buttons.SetActive(false);
        Level7Buttons.SetActive(false);
        Level8Buttons.SetActive(false);
        Level9Buttons.SetActive(false);
        buildingButtons.SetActive(false);
        endMapButtons.SetActive(false);
        map.SetActive(true);
        StoryText = "Interact with the student";
        buildingChoice = "";
    }

    public void Button9() //Student Services
    {
        MainMenuButtons.SetActive(false);
        Level1Buttons.SetActive(false);
        Level2Buttons.SetActive(false);
        Level3Buttons.SetActive(false);
        Level4Buttons.SetActive(false);
        Level5Buttons.SetActive(false);
        Level6Buttons.SetActive(true);
        Level7Buttons.SetActive(false);
        Level8Buttons.SetActive(false);
        Level9Buttons.SetActive(false);
        buildingButtons.SetActive(false);
        endMapButtons.SetActive(false);
        map.SetActive(true);
        StoryText = "Interact with the student services";
        buildingChoice = "";
    }

    public void Button10() //Hallway Unlocked
    {
        MainMenuButtons.SetActive(false);
        Level1Buttons.SetActive(false);
        Level2Buttons.SetActive(false);
        Level3Buttons.SetActive(false);
        Level4Buttons.SetActive(false);
        Level5Buttons.SetActive(false);
        Level6Buttons.SetActive(false);
        Level7Buttons.SetActive(false);
        Level8Buttons.SetActive(false);
        Level9Buttons.SetActive(false);
        buildingButtons.SetActive(false);
        endMapButtons.SetActive(true);
        StoryText = "";
        buildingChoice = "Choose where to go";
    }

    //Hallway Buttons

    public void ButtonLeft() 
    {
        MainMenuButtons.SetActive(false);
        Level1Buttons.SetActive(false);
        Level2Buttons.SetActive(false);
        Level3Buttons.SetActive(false);
        Level4Buttons.SetActive(false);
        Level5Buttons.SetActive(false);
        Level6Buttons.SetActive(false);
        Level7Buttons.SetActive(true);
        Level8Buttons.SetActive(false);
        Level9Buttons.SetActive(true); 
        buildingButtons.SetActive(false);
        endMapButtons.SetActive(false);
        StoryText = "Interact with the bullies";
        buildingChoice = "";
    }

    public void ButtonLockers()
    {
        MainMenuButtons.SetActive(false);
        Level1Buttons.SetActive(false);
        Level2Buttons.SetActive(false);
        Level3Buttons.SetActive(false);
        Level4Buttons.SetActive(false);
        Level5Buttons.SetActive(false);
        Level6Buttons.SetActive(false);
        Level7Buttons.SetActive(false);
        Level8Buttons.SetActive(true);
        Level9Buttons.SetActive(false);
        buildingButtons.SetActive(false);
        endMapButtons.SetActive(false);
        StoryText = "Interact with the janitor";
        buildingChoice = "";
    }

    public void ButtonRight()
    {
        MainMenuButtons.SetActive(false);
        Level1Buttons.SetActive(false);
        Level2Buttons.SetActive(false);
        Level3Buttons.SetActive(false);
        Level4Buttons.SetActive(false);
        Level5Buttons.SetActive(false);
        Level6Buttons.SetActive(false);
        Level7Buttons.SetActive(false);
        Level8Buttons.SetActive(false);
        Level9Buttons.SetActive(true);
        buildingButtons.SetActive(false);
        endMapButtons.SetActive(false);
        StoryText = "Interact with the vending machine";
        buildingChoice = "";
    }

    public void proceed1()
    {
        MainMenuButtons.SetActive(false);
        Level1Buttons.SetActive(false);
        Level2Buttons.SetActive(true);
        Level3Buttons.SetActive(false);
        Level4Buttons.SetActive(false);
        Level5Buttons.SetActive(false);
        Level6Buttons.SetActive(false);
        Level7Buttons.SetActive(false);
        Level8Buttons.SetActive(false);
        Level9Buttons.SetActive(false);
        buildingButtons.SetActive(false);
        endMapButtons.SetActive(false);
        map.SetActive(false);
        StoryText = "Interact with the crying student";
        buildingChoice = "";
    }

    public void proceed2()
    {
        MainMenuButtons.SetActive(false);
        Level1Buttons.SetActive(false);
        Level2Buttons.SetActive(false);
        Level3Buttons.SetActive(false);
        Level4Buttons.SetActive(false);
        Level5Buttons.SetActive(false);
        Level6Buttons.SetActive(false);
        Level7Buttons.SetActive(false);
        Level8Buttons.SetActive(false);
        Level9Buttons.SetActive(false);
        buildingButtons.SetActive(true);
        endMapButtons.SetActive(false);
        map.SetActive(true);
        buildingChoice = "Choose where to go";
        StoryText = "";
    }

    public void endMap()
    {
        MainMenuButtons.SetActive(false);
        Level1Buttons.SetActive(false);
        Level2Buttons.SetActive(false);
        Level3Buttons.SetActive(false);
        Level4Buttons.SetActive(false);
        Level5Buttons.SetActive(false);
        Level6Buttons.SetActive(false);
        Level7Buttons.SetActive(false);
        Level8Buttons.SetActive(false);
        Level9Buttons.SetActive(false);
        endMapButtons.SetActive(true);
        StoryText = "";
        buildingChoice = "Choose where to go";
    }

}


