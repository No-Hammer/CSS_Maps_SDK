using UnityEngine;

public class GameSettings : MonoBehaviour
{
    [Header("Настройки игры")]
    [Space]
    [Tooltip("Использовать стандартные настройки сервера(при включении этой функции все настройки расположенные ниже применяться не будут)")]
    public bool useDefaultSettings = true;
    [Space]
    [Tooltip("Список отключенных оружий на карте")]
    public string[] disableGuns;
    [Tooltip("Отключить гравитацию")]
    public bool disableGravity = false;
    [Tooltip("Рандомный спавн")]
    public bool enableRandomSpawn = false;
    [Tooltip("Начальная сумма денег")]
    [Range(0, 16000)]
    public int startingMoney = 800;
    [Tooltip("Включить таймер покупки оружий")]
    public bool enableBuyTimer = true;
    [Tooltip("Лимит времени покупки оружий(работает только если включен таймер покупки оружий)")]
    [Range(0, 200)]
    public int buyTimeLimit = 15;
    [Tooltip("Включить прицеливание")]
    public bool enableAiming = false;
    [Tooltip("Включить бег")]
    public bool enableRun = false;
    [Tooltip("Включить баррикады")]
    public bool enableBarricades = false;
    [Tooltip("Прочность баррикад")]
    [Range(100, 1000)]
    public int barricadeDurabillity = 1000;
    [Tooltip("Наблюдение только за командой")]
    public bool observingOwnTeam = true;
    [Tooltip("Отключить курсор прицеливания")]
    public bool disableCursor = false;
    [Tooltip("Включить огонь по своим")]
    public bool enableFriendlyFire = false;
    [Tooltip("Включить 5 секунд закупки")]
    public bool enableStartTime = true;
    [Tooltip("Ограниченное число оружий на раунд")]
    public bool enableGunAmout = false;
    [Tooltip("Отключить хедшот(удвоение урона при попадании в голову)")]
    public bool disableHeadshot = false;
    [Tooltip("Отключить разный урон по частям тела")]
    public bool disableBodyParts = false;
    [Tooltip("Включить спавн килл")]
    public bool enableSpawnKill = false;
    [Tooltip("Включить выстрел в прыжке")]
    public bool enableJumpShoot = false;
    [Tooltip("Включить голосовой чат")]
    public bool enableVoiceChat = true;
    [Tooltip("Отключить мёртвую зону")]
    public bool disableDeadZone = false;
    [Tooltip("Включить бесконечные патроны")]
    public bool enableUnlimitedBullets = false;
    [Tooltip("Включить лимит жизней")]
    public bool enableLimitHealth = true;
    [Tooltip("Включить быструю перезарядку")]
    public bool enableFastReload = false;
    [Tooltip("Включить замедление при попадании")]
    public bool enableSlowDown = true;
    [Tooltip("Включить лечение(тимейтов) ударом ножа")]
    public bool enableHealing = false;
    [Tooltip("Включить вид от третьего лица")]
    public bool enableThirdPersonView = false;
    [Tooltip("Проходить сквоь игроков")]
    public bool canGoThroughPlayer = false;
    [Tooltip("Включить прострелы сквозь стены")]
    public bool shootThroughWalls = false;
    [Tooltip("Отключить баланс команд")]
    public bool disableBalance = false;
    [Tooltip("Помечать врагов на радаре")]
    public bool showEnemyOnRadar = false;
    [Tooltip("Жизни игроков")]
    [Range(10, 600)]
    public int playerHealth = 100;
    [Tooltip("Скорость игроков")]
    [Range(0.5f, 1.5f)]
    public float playerSpeed = 1f;
}