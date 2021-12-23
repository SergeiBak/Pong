# Pong
<img width="276.48" height="155.52" src="https://github.com/SergeiBak/PersonalWebsite/blob/master/images/pong.png?raw=true">

## Table of Contents
* [Overview](#Overview)
* [Test The Project!](#test-the-project)
* [Code](#Code)
* [Technologies](#Technologies)
* [Resources](#Resources)
* [Donations](#Donations)

## Overview
This project is a recreation of the classic arcade game known as Pong, one of the first ever computer games released in 1972! This solo project was developed in Unity using C# as part of my minigames series where I utilize various resources to remake simple games in order to further my learning as well as to have fun!   

Pong consists of two paddles on either sides of the screen & a ball. The goal is to deflect the ball from going into the goal on your side of the board. Get the ball into your opponents goal to score! I have setup a single player mode in which you have control over one paddle against the computer, and a two player mode where you have control over both paddles.

## Test The Project!
In order to play this version of Pong, follow the [link](https://sergeibak.github.io/PersonalWebsite/pong.html) to a in-browser WebGL build (No download required!).

## Code
A brief description of all of the classes is as follows:
- The `Ball` class handles the resetting of the ball position as well as giving it an initial velocity.
- The `BloomColorChange` class handles the glow/bloom post processing effect in the scene that cycles through a gradient of colors.
- The `BouncySurface` class increases the speed of the ball whenever it collides with a paddle or wall.
- The `ComputerPaddle` class inherits from the `Paddle` class, and handles the control of the computer paddle based on the position & direction of the ball.
- The `GameManager` class is a singleton class that handles scoring, resetting, and updating UI.
- The `MenuManager` class is a signleton class that handles scene loading.
- The `Paddle` class is a base class that all paddle classes inherit from, it contains a reference to the rigidbody & paddle speed.
- The `PlayerPaddle` class inherits from the `Paddle` class, and handles input & movement of the player paddle.
- The `ScoringZone` class handles increasing the score whenever the ball collides.
- The `TwoPlayerPaddle` class inherits from the `Paddle` class, and is used in two player mode for each player paddle to take different inputs.

## Technologies
- Unity
- Visual Studio
- GitHub
- GitHub Desktop

## Resources
- Credit goes to [Zigurous](https://www.youtube.com/channel/UCyaKsKqYTghxgAqywfefAzg) for the helpful base game tutorial!
- I made use of [Unity Post Processing](https://docs.unity3d.com/Manual/PostProcessingOverview.html) for the glowing color effect!
- [Pong SFX](https://opengameart.org/content/3-ping-pong-sounds-8-bit-style)

## Donations
This game, like many of the others I have worked on, is completely free and made for fun and learning! If you would like to support what I do, you can donate at my metamask wallet address: ```0x32d04487a141277Bb100F4b6AdAfbFED38810F40```. Thank you very much!
