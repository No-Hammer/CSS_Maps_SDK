# Создание карт для [Counter Shot: Source](https://vk.com/cs_by_devi)

**Требуемая версия Unity:** Unity3D 5.6.7 (можно загрузить в [архиве](https://unity3d.com/ru/get-unity/download/archive) Unity)

# Начало
Чтобы создать карту вам потребуется загрузить этот репозиторий к себе на компьютер и открыть его как проект в Unity.
После загрузки проекта вы можете создать собственную карту или [импортировать](https://www.google.com/search?q=%D0%B8%D0%BC%D0%BF%D0%BE%D1%80%D1%82+%D0%BA%D0%B0%D1%80%D1%82+counter+strike+%D0%B2+unity3d&oq=%D0%B8%D0%BC%D0%BF%D0%BE%D1%80%D1%82+%D0%BA%D0%B0%D1%80%D1%82+counter+strike+%D0%B2+unity3d&aqs=chrome..69i57.15803j0j4&sourceid=chrome&ie=UTF-8) готовую. После того как вы это сделали можно приступить к настройке карты.

# Настройка карты
Первым делом нужно пометить карту и все её составляющие как статические объекты и выставить для неё слой **Level**
## Спавн игроков
Для того чтобы создать точки спавна игроков нужно перетащить префаб нужного спавна на нужное место(префабы находятся в папке !Prefabs\spawns)
**Типы спавнов**
* SpawnCT - точка спавна для контр-террориста
* SpawnT - точка спавна для террориста
* SpawnDM - точка спавна для игрока в режиме DeathMatch
* SpawnZ - точка спавна для зомби в зомби режимах
* SpawnHostage - точка спавна для заложника
