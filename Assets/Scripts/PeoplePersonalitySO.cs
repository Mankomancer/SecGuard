using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="Person Personality", fileName ="Persons Personality")]
public class PeoplePersonalitySO : ScriptableObject
{
    
    [TextArea(1,5)]
    [SerializeField] string personality;    //what kind of person (or who they are)

    // I KNOW I SHOULD SEPERATE PEOPLE CATEGORIES IN MORE DETAILS (at least 3), BUT BECAUSE I HAVE TIGHT DEADLINE WILL DO THIS LAZY WAY. Not like anyone else will work on code part here

    //------------------This part if meant for people who are in concert to watch it
    [Header("Clients")]
    [SerializeField] string [] random_text_messages;    //what they could say regardless if they were jammed or not. will need to do some % experimentation
    [SerializeField] string [] text_message_after_jamming_coorect;  //how they will react after jamming - they did something bad

    [SerializeField] string [] text_message_after_jamming_mistake;  //how they will react after jamming - player jammer wrong person
    [SerializeField] string [] thank_you_good; //in case if they had real problem and player didnt jam them
    [SerializeField] string [] leaving_concert_happy;//they didnt get jammed
    [SerializeField] string [] leaving_concert_unhappy;//they got jammed without reason
    [SerializeField] string [] leaving_concert_unhappy_jammed;//they got jammed
    [SerializeField] string [] unfriending_reason;


    //--------------------This part is for people who are in concert working
    [Header("Workers")]
    [SerializeField] string [] getting_jammed;//when played jamms the NPC. It always is a mistake
    [SerializeField] string [] warning_player; //sees that someone is doing something bad
    [SerializeField] string [] thank_you; //player took care of all if not most people who broke the rules


    //---------------------This part is for close friends/relatives
    [Header("Close people")]
    [SerializeField] string [] misc_text_messages; //just stuff relatives will spawn
    
}
