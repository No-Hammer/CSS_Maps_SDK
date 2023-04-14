using UnityEngine;

public enum Weapons
{
    eq_c4 = 0,
    knife = 1,
    rif_ak47 = 2,
    rif_m4a1 = 3,
    rif_famas = 4,
    rif_galil = 5,
    rif_aug = 6,
    rif_sg552 = 7,
    snip_sg550 = 8,
    snip_g3sg1 = 9,
    snip_awp = 10,
    snip_scout = 11,
    shot_m3super90 = 12,
    shot_xm1014 = 13,
    mach_m249para = 14,
    smg_mac10 = 15,
    smg_tmp = 16,
    smg_mp5 = 17,
    smg_ump45 = 18,
    smg_p90 = 19,
    pist_glock18 = 20,
    pist_usp = 21,
    pist_p228 = 22,
    pist_fiveseven = 23,
    pist_deagle = 24,
    eq_fraggrenade = 25,
    eq_flashbang = 26,
    eq_smokegrenade = 27,
    eq_decoy = 28
}

public class WeaponSpawn : MonoBehaviour
{
    public Weapons Weapon;
    public int Patrons;
    public int GloabalPatrons;
    public int gNumber;
}
