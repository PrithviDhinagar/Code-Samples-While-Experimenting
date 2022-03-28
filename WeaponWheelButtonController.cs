//This code was an experiment while I was learning about weapon wheel.
/* EXPLANATION: The program controls the weapon wheel UI button which was created inside unity. A separate set of animations including  
 * Selected, Deselected, HoverEnter and HoverExit animation were created to display the sprite and itemText. 
 */

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeaponWheelButtonController : MonoBehaviour
{
    public int ID;
    private Animator anim;
    public string itemName;
    public TextMeshProUGUI itemText;
    public Image selectedItem;
    private bool selected = false;
    public Sprite icon;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (selected)
        {
            selectedItem.sprite = icon;
            itemText.text = itemName;
        }
    }
    public void Selected()
    {
        selected = true;
        WeaponWheelController.weaponID = ID;
    }
    public void DeSelected()
    {
        selected = false;
        WeaponWheelController.weaponID = 0;
    }
    public void HoverEnter()
    {
        anim.SetBool("Hover", true);
        itemText.text = itemName;
    }
    public void HoverExit()
    {
        anim.SetBool("Hover", false);
        itemText.text = "";
    }
}
