[English](README.md) | [Русский](README_RU.md)

<p align="center"><h1>⭐Custom Build and Run Utility for Unity⭐</h1></p>
 <p align="center">
  <a>
    <img alt="Made With Unity" src="https://img.shields.io/badge/made%20with-Unity-57b9d3.svg?logo=Unity">
  </a>
  <a>
  <img alt="License" src="https://img.shields.io/github/license/RimuruDev/CustomProjectBuilder?logo=github">
  </a>
  <a>
    <img alt="Last Commit" src="https://img.shields.io/github/last-commit/RimuruDev/CustomProjectBuilder?logo=Mapbox&color=orange">
  </a>
  <a>
    <img alt="Repo Size" src="https://img.shields.io/github/repo-size/RimuruDev/CustomProjectBuilder?logo=VirtualBox">
  </a>
  <a>
    <img alt="Downloads" src="https://img.shields.io/github/downloads/RimuruDev/CustomProjectBuilder/total?color=brightgreen">
  </a>
  <a>
    <img alt="Last Release" src="https://img.shields.io/github/v/release/RimuruDev/CustomProjectBuilder?include_prereleases&logo=Dropbox&color=yellow">
  </a>
  <a>
    <img alt="GitHub stars" src="https://img.shields.io/github/stars/RimuruDev/CustomProjectBuilder?branch=main&label=Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="GitHub user stars" src="https://img.shields.io/github/stars/RimuruDev?affiliations=OWNER&branch=main&label=User%20Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="" src="https://img.shields.io/github/watchers/RimuruDev/CustomProjectBuilder?style=flat">
  </a>
</p>

## Обзор

Custom Build and Run — это расширение редактора Unity, предназначенное для оптимизации процесса тестирования и
разработки многопользовательских игр с использованием Unity и сервера Nakama. Одной командой оно автоматизирует сборку и
запуск отдельного экземпляра игры вместе с переходом в режим Play в редакторе Unity, что позволяет бесшовно тестировать
матчмейкинг и взаимодействие в игре.

## WЗачем использовать Custom Build and Run?

Этот инструмент решает распространенную проблему тестирования многопользовательских взаимодействий в Unity. Традиционно
такое тестирование требует ручной координации между сборкой игры, запуском нескольких экземпляров и управлением
подключениями к серверу. Custom Build and Run упрощает это до одного шага, экономя время и снижая количество ошибок.

## Особенности

- **Сборка и запуск одним кликом**: Скомпилируйте и запустите отдельный экземпляр игры с предварительно настроенными
  параметрами, используя одну команду меню или горячую клавишу.
- **Одновременный режим Play в редакторе**: Автоматический вход в режим Play в редакторе Unity после сборки, позволяющий
  немедленно тестировать многопользовательские функции.
- **Оптимизированный рабочий процесс**: Сосредоточьтесь на разработке и тестировании, а не на повторяющихся задачах
  настройки, повышая продуктивность и скорость итераций.

## Установка

1. Клонируйте этот репозиторий или загрузите последний релиз.
2. Импортируйте скрипт `CustomBuildAndRun.cs` в папку Editor вашего проекта Unity.
3. Доступ к утилите осуществляется через меню `RimuruDev Tools` или нажатием назначенной горячей клавиши (`%F1` по
   умолчанию).

## Использование

После установки утилиту можно активировать через меню редактора `RimuruDev Tools/Build and Run + Play Editor Mode` или
используя горячую клавишу `%F1`. Убедитесь, что ваши сцены правильно настроены в параметрах сборки и что сервер Nakama
запущен.

###Сборка и запуск

Используйте команду меню или горячую клавишу для инициации сборки. Утилита выполнит:

- Компиляцию игры в предопределенную папку сборок.
- Запуск скомпилированного экземпляра игры.
- Автоматический вход в режим Play в редакторе Unity.

```plaintext
RimuruDev Tools/Build and Run + Play Editor Mode %F1
```

# Горячая клавиша - ctrl + F1

![image](https://github.com/RimuruDev/CustomProjectBuilder/assets/85500556/82c0e829-66e8-482b-8bb6-6d4e56363c72)

## Зависимости

Редактор Unity: Убедитесь, что у вас установлен редактор Unity.

[//]: # (Nakama Server: A running instance of Nakama Server is required for multiplayer testing.)

## Участие

Если у вас есть предложения по улучшению утилиты или вы столкнулись с проблемами, пожалуйста, не стесняйтесь вносить
свой вклад:

- Сделайте форк репозитория.
- Создайте свою ветку для новой функции (git checkout -b feature/AmazingFeature).
- Зафиксируйте свои изменения (git commit -am 'Add some AmazingFeature').
- Отправьте изменения в ветку (git push origin feature/AmazingFeature).
- Откройте запрос на слияние (pull request).

[//]: # (## License)

[//]: # (This project is licensed under the MIT License - see the LICENSE.md file for details.)

### Разработано RimuruDev