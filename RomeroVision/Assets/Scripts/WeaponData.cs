using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class WeaponData : ScriptableObject {
    new public string name;
    public WeaponType type;
    public float damage;
    private float attackSpeed;

    public Sprite sprite;

    public float attackTime { get => 1/attackSpeed;}
}
