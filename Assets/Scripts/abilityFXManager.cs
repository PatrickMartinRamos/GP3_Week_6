using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilityFXManager : MonoBehaviour
{

    public static abilityFXManager instance { get; private set; }
    public List<ParticleSystem> AttackFX = new();
    public List<ParticleSystem> SkillFX = new();
    public List<ParticleSystem> UltimateFX = new();

    public void Awake()
    {
        instance = this;
    }
}
