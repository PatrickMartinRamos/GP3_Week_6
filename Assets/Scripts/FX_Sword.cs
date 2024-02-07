using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FX_Sword : weaponAbilites
{
    private ParticleSystem _ultimate, _skill, _attack;
    public Transform player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public override void attack()
    {
        _attack = abilityFXManager.instance.AttackFX[0];
        Instantiate(_attack, player.transform);
        _attack.Play();
    }
    public override void skill() 
    {
        _skill = abilityFXManager.instance.SkillFX[0];
        Instantiate(_skill, player.transform);
        _skill.Play();
    }
    public override void ultimate()
    {
        _ultimate  = abilityFXManager.instance.UltimateFX[0];
        Instantiate (_ultimate);
        _ultimate.Play();

    }

}
