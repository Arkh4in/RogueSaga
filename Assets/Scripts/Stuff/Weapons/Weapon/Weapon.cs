using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour, IEquipable
{
    [SerializeField]
    List<ActiveAbility> WeaponAbilities;

    [SerializeField]
    DamageType Type;
}
