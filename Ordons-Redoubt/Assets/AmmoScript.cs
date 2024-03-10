using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AmmoScript : MonoBehaviour
{
    public int ammoCount = 4;
    public TextMeshProUGUI ammoText;

    [ContextMenu("DecreaseAmmo")]
    public void DecreaseAmmo(int ammoToDecrease)
    {
        ammoCount -= ammoToDecrease;
        ammoText.text = ammoCount.ToString() + " ammo";
    }

    [ContextMenu("IncreaseAmmo")]
    public void IncreaseAmmo(int ammoToIncrease)
    {
        ammoCount += ammoToIncrease;
        ammoText.text = ammoCount.ToString() + " ammo";
    }
}
