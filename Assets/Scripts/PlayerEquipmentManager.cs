using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipmentManager : MonoBehaviour
{
    EquipmentManager EM;
    public string WeaponOnhandName;
    public GameObject WeaponModel;
    public Transform handOffest;
    public int WeaponOnHandID;

    bool isCreated;
    bool destroyPrev;
    int previousID;

    public Animator animator;

    public weaponAbilites currentWeapon;
    // Start is called before the first frame update
    void Start()
    {
        isCreated = true;
        destroyPrev = false;
        EM = EquipmentManager.Instance;
        previousID = WeaponOnHandID;
    }

    // Update is called once per frame
    void Update()
    {
        WeaponsChecker();
        OnHandWeaponModelUpdate();
        if (previousID != WeaponOnHandID)
        {
            isCreated = true;
            destroyPrev = true;
        }
        equipWeapon(WeaponModel.GetComponent<weaponAbilites>());
        CastUltimate();
    }

    public void equipWeapon(weaponAbilites weaponFX)
    {
        currentWeapon = weaponFX;
    }
    public void CastUltimate()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            currentWeapon.ultimate();
            animator.SetTrigger("Ult");
        }
    }

    public void WeaponsChecker()
    {
        WeaponOnhandName = EM.HandWeapons[WeaponOnHandID].Name;
        WeaponModel = EM.HandWeapons[WeaponOnHandID].Model;
    }
    
    public void OnHandWeaponModelUpdate()
    {
        if (isCreated)
        {
            GameObject _onHandWeaponModel = Instantiate(WeaponModel, handOffest);
            _onHandWeaponModel.transform.SetParent(handOffest);
            isCreated = false;
            if (destroyPrev)
            {
                var prevWeapon = handOffest.GetChild(0);
                Destroy(prevWeapon.gameObject);
                destroyPrev = false;
            }
        }
    }
}
