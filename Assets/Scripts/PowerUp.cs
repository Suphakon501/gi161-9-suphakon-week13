using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    public abstract void ApplyPowerUp(Player player);
}
