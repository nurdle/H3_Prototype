﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : Enemy {

    public GameObject boomerang;
    public string nextscene;
    public float minBoomerangTime, maxBoomerangTime;

    // Use this for initialization
    void Awake () {
        Invoke("ThrowBoomerang", Random.Range(minBoomerangTime, maxBoomerangTime));
    }
	
    void ThrowBoomerang()
    {
        if (!isDead)
        {
            anim.SetTrigger("Boomerang");
            GameObject tempBoomerang = Instantiate(boomerang, transform.position, transform.rotation);
            if (facingRight)
            {
                tempBoomerang.GetComponent<Boomerang>().direction = 1;
            }
            else
            {
                tempBoomerang.GetComponent<Boomerang>().direction = -1;
            }
            Invoke("ThrowBoomerang", Random.Range(minBoomerangTime, maxBoomerangTime));
        }

    }

    void BossDefeated()
    {
        SoundManager.instance.musicSource.Stop();
        Invoke("LoadScene", 6f);

    }
    void LoadScene()
    {
        Transition.instance.FadeToLevel(nextscene);
    }

}
