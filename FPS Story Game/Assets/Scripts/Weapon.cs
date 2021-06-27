using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Weapon : MonoBehaviour {

    public abstract void Attack();
    public abstract void PickUp();

}