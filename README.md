# GameFramework
*A collection of **C# interfaces only**, to uniformize games structure. Inspired by Unreal Game Framework (Pawn, Actors, Controllers).*

Designed for building scalable and maintainable Unity games, it provides a robust architecture for defining actors, controllers, game flow, and interaction systems, making it easier to manage complexity in both single-player and multiplayer environments.

## Core Architecture

The framework differentiates logical control (`IController`), physical presence (`IPawn`), and game rules (`IGameMode`).

### Actors & Possession
- **`IActor`**: A significant world object with ownership hierarchy. Should not be considered as a GameObject. For example, a pressure plate will have an `IActor` on the root gameobject but not on the children gameobjects used for rendering and collision.
- **`IPawn`**: Physical avatar possessed by a controller. Generally movable.
- **`ICharacter`**: Specialized `IPawn` with movement capabilities.
- **`IController`**: "Brain" that possesses a Pawn (AI or Player).
- **`ISpectateController`**: Controller dedicated to viewing `ISpectate` targets for game views.
- **`IMachine`**: The physical application instance (Client/Server).
- **`IGameInstance`**: Persistent cross-scene data and lifecycle management. Only singleton you should need, because it has `IComponentsContainer` to add global services and `IEventBus` for global events.

### Game Flow
- **`IGameMode`**: Match rules, scoring, and spawning logic. Generally one per scene.
- **`IGameState`**: Replicated global game state (teams, scores).
- **`ISpawnPoint`**: Validated location and rotation for spawning actors. Can have physics checks to ensure validity.

## Systems

- **Dependencies**: `IComponentsContainer` acts as a highly optimized service locator for `IActorComponent` to build modular actors.
- **Identity**: `IHaveUUID` provides unique, persistent, network-synced identity. `IIDRegistry` allows O(1) lookups.
- **Reactive**: `IValueObservable<T>` exposes reactive data streams. `IEventBus` handles decoupled local/global pub/sub events.
- **Health**: `IHealth` manages vitality and death; `IDamageable` handles damage/healing logic; `IBattery` for energy mechanics.
- **Interaction**: `IInteractable` (target) and `IInteractor` (source) standard interactions. `IRaycastable` for pointer/cursor detection.
- **Inventory**: `IInventory` manages `IItemActor` and `IItemStack` collections. Supports `ISelectableInventory`/`IInventoryOrderableList`.
- **Spectating**: `ISpectate` defines view targets; `ICamera` and `ICameraController` handle view rendering logic.
- **Traits**: `IDroppable`, `IThrowable`.
- **Persistence**: `ISerializedObject` for saving/loading state.


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