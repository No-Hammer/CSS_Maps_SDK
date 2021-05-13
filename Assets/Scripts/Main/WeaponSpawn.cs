using UnityEngine;

public enum Weapons
{
    c4 = 0,
    glock18 = 2,
    rif_ak47 = 3,
    m4a1 = 4,
    famas = 5,
    galil = 6,
    aug = 7,
    sg552 = 8,
    sg550 = 9,
    g3sg1 = 10,
    awp = 11,
    scout = 12,
    m3 = 13,
    xm1014 = 14,
    m249 = 15,
    mac10 = 16,
    smg_tmp = 17,
    mp5 = 18,
    ump45 = 19,
    p90 = 20,
    usp = 21,
    p288 = 22,
    fiveseven = 23,
    deagle = 24,
    grenade = 25,
    flash = 26,
    smoke = 27
}

public class WeaponSpawn : MonoBehaviour
{
    public Weapons Weapon;
    public int Patrons;
    public int GloabalPatrons;
    public int gNumber;
}
