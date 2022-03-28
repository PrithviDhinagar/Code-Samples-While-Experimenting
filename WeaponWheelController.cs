/* The program displays the weapon wheel UI inside the unity when Tab is pressed and displays the sprite in the buttom right corner when a button is clicked 
 * based on the weaponID.
 */
using UnityEngine;
using UnityEngine.UI;

public class WeaponWheelController : MonoBehaviour
{
    public Animator anim;
    private bool weaponWheelSelected = false;
    public Image selectedItem;
    public Sprite noImage;
    public static int weaponID;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            weaponWheelSelected = !weaponWheelSelected;
        }
        if(weaponWheelSelected)
        {
            anim.SetBool("OpenWeaponWheel", true);
        }
        else
        {
            anim.SetBool("OpenWeaponWheel", false);
        }

        switch (weaponID)
        {
            case 0: //nothing is selected
                selectedItem.sprite = noImage; 
                break;
            case 1: //Pistol
                Debug.Log("Pistol"); //In this case, just a log statement is displayed when the button is pressed. 
                break;
        }


    }
}
