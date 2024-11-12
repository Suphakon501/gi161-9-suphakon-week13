using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrengthPowerUP : PowerUp
{
    float strengthMultiplier = 2f;
    public override void ApplyPowerUp(Player player)
    {
        player.PowerUp(strengthMultiplier);
    }
}
