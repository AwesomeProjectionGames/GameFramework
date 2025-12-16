# GameFramework
*A collection of **C# interfaces only**, to uniformize games structure. Inspired by Unreal Game Framework (Pawn, Actors, Controllers).*

Designed for building scalable and maintainable Unity games, it provides a robust architecture for defining actors, controllers, game flow, and interaction systems, making it easier to manage complexity in both single-player and multiplayer environments.

## Core Architecture

The framework is built around a system of possession and ownership, separating logic (Controllers) from physical representation (Pawns).

### Actors & Possession
- **`IActor`**: The base interface for any object with a significant presence in the game world. Supports ownership hierarchy (`Owner`).
- **`IPawn`**: An `IActor` that can be possessed by a controller. It represents the physical avatar in the world.
- **`IController`**: A non-physical entity that acts as the "brain". It possesses an `IPawn` to direct its actions. This separation allows for easy swapping of control logic (e.g., Player vs AI) or switching bodies (e.g., entering a vehicle).
- **`IMachine`**: Represents a physical instance of the game application (client or server), identified by a unique definition. *This should be the only thing allowed to be a singleton.*
- **`ISpectateController`**: A controller that can spectate a `ISpectate`, generally implemented in pawns. It represent a game view. Generally, there will be only one instance for full screen game, but they can be many for split-screen. This is why there is a strong link with `IController`.

### Game Flow
- **`IGameMode`**: Defines the rules of the match, including default pawns, controllers, and spawn logic.
- **`IGameState`**: Tracks the global state of the game, such as the list of active actors, players, and scores.

## Systems

The framework includes essential systems to handle common game mechanics:
- **Health & Damage**: Manages health states, healing, death, and various types of damage (point, radial).
- **Interaction**: A unified system for actors to interact with world objects.
- **Inventory**: Flexible management for items and collections.
- **Persistence**: Interfaces for saving, loading, and serializing object states.


## Installation
To install this package, you can use the Unity Package Manager. To do so, open the Unity Package Manager and click on the `+` button in the top left corner. Then select `Add package from git URL...` and enter the following URL:

```
https://github.com/AwesomeProjectionGames/GameFramework.git
```

Or you can manually to add the following line to your `manifest.json` file located in your project's `Packages` directory.

```json
{
  "dependencies": {
    ...
    "com.awesomeprojection.gameframework": "https://github.com/AwesomeProjectionGames/GameFramework.git"
    ...
   }
}