# Progopdrachten M5

## Les 1
In deze opdracht worden pilaren gespawned door op het scherm te klikken.

**Script:**  
[Spawner](Assets/Scripts/Spawner.cs)

**Resultaat:**  
![Pillaren](https://github.com/user-attachments/assets/da09766f-c696-4f0d-84bc-c2c7b2675c14)



Daarnaast spawnen ballen automatisch iedere seconde.

**Script:**  
[Balls](Assets/Scripts/Ballen.cs)

**Resultaat:**  
![Balls](https://github.com/user-attachments/assets/76d43bbc-c929-4bb8-8c3b-a12aac78252c)

---

## Les 2
Coin system: een speler (blok) verzamelt coins en de score wordt live bijgewerkt.

**Script:**  
[ScoreSystem](Assets/Scripts/ScoreSystem.cs)

**Resultaat:**  
![CoinCollect](https://github.com/user-attachments/assets/5cdbe098-8d1a-4b58-aae8-15fac447533d)

---

## Les 3
Debugging-opdracht. Document met uitleg en gevonden bugs:

**Document:**  
https://docs.google.com/document/d/1A9Way1L0EpJQ_nYAU97fFFEAygIEalajdR3z9GcCELA/edit?usp=sharing

Bugs gevonden in de Tower Defence game.  
De opdracht “Mythe” ontbreekt.

**Screenshot:**  
<img width="1849" height="940" alt="Screenshot 2025-10-10 091009" src="https://github.com/user-attachments/assets/1df9183e-362b-4b24-a1f9-b017a2252104" />

---

## Les 4
Alle scripts van de Space Shooter zijn herschreven volgens het Single Responsibility Principle.

**Map:**  
[Scripts](Assets/Scripts/Spaceshooter)

**Resultaat:**  
![Spaceshooter](https://github.com/user-attachments/assets/d9751b27-2152-477e-8509-4377636e682c)

---

## Les 5
Nog niet uitgevoerd.

---

## Les 6
Dependency analyse.

**Document:**  
https://docs.google.com/document/d/1bXBO7FFVSXiE5CwlVJwobjQiokGVwQ9dZ05z7R6Xghg/edit?usp=sharing


# Progopdrachten M6

## Opdracht 1 || Code Conventions

[Code](https://github.com/JosHub112/Progopdrachten/tree/main/Assets/Scripts/M6/Code%20Conventions)


## Opdracht  2 || Class diagram Towerdefense

```mermaid

classDiagram

class Bullet {
    - int damage
    - float lifeTime
    + Start()
    + OnTriggerEnter2D(collider)
}

class Enemy {
    - int health
    - int cashReward
    - spriteRenderers
    - Transform visuals
    + TakeDamage(dmg)
    + KillEnemy()
    + FlashEffect()
}

Bullet --> Enemy : interacts with


class EnemySpawner {
    - enemyTypes[]
    - baseEnemies
    - enemiesPerSecond
    - maxWaves
    - currentWave
    + SpawnEnemy()
    + EnemyDestroyed()
    + IsAllWavesDone()
}

class EnemyType {
    - GameObject prefab
    - spawnWeight
    - minSpeed
    - maxSpeed
    - weightIncreasePerWave
}

EnemySpawner --> EnemyType : spawns


class Enemymovement {
    - Rigidbody2D rb
    - float moveSpeed
    - int health
    - target
    - PathIndex
    + TakeDamage(dmg)
}

class StraightEnemy {
    - Rigidbody2D rb
    - moveSpeed
    - target
    - pathIndex
    + SetSpeed()
}

class ZigZagEnemy {
    - zigzagAmplitude
    - zigzagFrequency
    - float time
    + SetSpeed()
}

StraightEnemy --> Enemymovement
ZigZagEnemy --> Enemymovement


class Turret {
    - range
    - fireRate
    - bulletPrefab
    - firePoint
    - bulletSpeed
    - turnSpeed
    - target
    + Update()
    + Shoot()
    + EnemyLockOn()
}

Turret --> Bullet : shoots


class PlayerShoot {
    - shootingPoint
    - bulletPrefab
    - bulletSpeed
    - bulletCooldown
    - spreadAngle
    + Shoot(dir)
    + ApplySpread(dir)
    + GetMouseDirection()
}

PlayerShoot --> Bullet : spawns


class PopupSpawner {
    - popupPrefab
    - Transform player
    + SpawnPopup(msg)
}

class PopupText {
    - TMP_Text text
    + Show(msg)
}

PopupSpawner --> PopupText


class ScreenFlash {
    - Image flashImg
    + Flash()
}

class UIManager {
    - Image redPanel
    - popupPrefab
    - playerTransform
    + RedFlash()
    + ShowPopup(text)
    + Fade()
    + Slide()
}


class CashSystem {
    - int cashAmount
    - TMP cashText
    + AddCash()
    + SpendCash()
}


class TurretBuildManager {
    + PlaceTurret(prefab,pos)
}

class TurretDragUI {
    - turretPrefab
    - turretCost
    + OnBeginDrag()
    + OnDrag()
    + OnEndDrag()
}

TurretDragUI --> TurretBuildManager : uses


class SoundManager {
    - sfxSource
    - musicSource
    - clips
    + PlayShoot()
    + PlayPlaceTower()
    + PlayBackgroundMusic()
}


class LevelManager {
    - lives
    - Path[]
    - Healthbar
    - gameOverUI
    + LoseLife()
    + GameOver()
    + RestartLevel()
    + LoadMainMenu()
}


class CamShake {
    + Shake(duration,strength)
}

class CameraDrag {
    - panSpeed
    - bounds
    - useBounds
    + StartDrag()
    + ContinueDrag()
    + EndDrag()
}

class EndlessRunner {
    - vbegin
    - g
    - velocity
    - acceleration
    - State enum
    - t
    - tmax
}

class Shooting {
    - lifetime
}

class Background {
    - Renderer bgBackground
    - speed
}

class SceneSwitcher {
    - nextSceneName
    - spawner
}


	

	

```


## Opdracht 3 || Data Structures

[Code](https://github.com/JosHub112/Progopdrachten/tree/main/Assets/Scripts/M6/Data%20Structure)

## Opdracht 4 || delegates gebruiken

![ezgif-75d548983100605b](https://github.com/user-attachments/assets/94446952-1f43-45df-9127-c695027c6842)


[Delgates](Assets/Scripts/M6/Delegates)



## Abstractions


![ahfggb](https://github.com/user-attachments/assets/b15cf525-8f94-425c-a398-9a9443007e75)



[Scripts](https://github.com/JosHub112/Progopdrachten/tree/main/Assets/Scripts/M6/Abstraction)



## Polymorfisme

![ahmkx0](https://github.com/user-attachments/assets/674360de-efa7-4679-a9ff-07db39155d6c)



[Scripts](https://github.com/JosHub112/Progopdrachten/tree/main/Assets/Scripts/M6/Polymorfisme)


## Early returns

```Charp
public bool IsPlayerReadyToAttack(Player player)
{

        if (player == null) return false;
        if (!player.IsAlive) return false;
        if (player.AttackCooldown > 0) return false; 
        if (player.Target == null) return false;

        if (!player.Target.IsAlive) return false;

   
    if (Vector3.Distance(player.transform.position, player.Target.transform.position) >= 5f)
    {
        return false;
    }

    bool hasManaAndWeapon
        if (player.Mana >= 20 && player.HasEquippedWeapon("Sword"))
    hasManaAndWeapon = true;
    
    bool hasHealthAndBuff
        if (player.Health >= 50 && player.HasActiveBuff("Berserk"))
        hasHealthAndBuff = true;

        if (!hasManaAndWeapon || !hasHealthAndBuff)
        
     return true;
    



}
```

