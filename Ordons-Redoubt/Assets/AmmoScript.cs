using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AmmoScript : MonoBehaviour
{
    public int ammo = 4;
    public TextMeshProUGUI ammoText;

    [ContextMenu("DecreaseAmmo")]
    public void DecreaseAmmo(int ammoToDecrease)
    {
        ammo -= ammoToDecrease;
        ammoText.text = ammo.ToString() + " ammo";
    }
}
