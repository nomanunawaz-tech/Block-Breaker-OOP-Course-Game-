# Block Breaker - UML Domain Model

This file contains the UML Class Diagram for the game, structured using Mermaid.js syntax. Many modern markdown viewers (including GitHub and Visual Studio Code) support rendering this diagram automatically.

```mermaid
classDiagram
    class IDrawable {
        <<interface>>
        +Draw(Graphics g)
    }
    class ICollidable {
        <<interface>>
        +GetBounds() Rectangle
    }
    
    IDrawable <|.. GameObject
    ICollidable <|.. GameObject

    class GameObject {
        +float X
        +float Y
        +int Width
        +int Height
        +Color color
        +Image sprite
        +bool isAlive
        +float speed
        +Draw(Graphics g)
        +Update()
        +GetBounds() Rectangle
    }

    GameObject <|-- Paddle
    GameObject <|-- Ball
    GameObject <|-- Brick
    GameObject <|-- PowerUp

    class Paddle {
        +bool movingLeft
        +bool movingRight
        +MoveLeft()
        +MoveRight()
    }

    class Ball {
        +float speX
        +float speY
        +bool isStuck
        +Move()
    }

    class Brick {
        +bool isItSpecial
    }

    Brick <|-- RedBrick
    Brick <|-- YellowBrick
    Brick <|-- PlumBrick
    Brick <|-- GreenBrick
    Brick <|-- TurquoiseBrick
    Brick <|-- BrownBrick

    class PowerUp {
        +PowerUpType Type
        +float SpeedY
        +Move()
    }

    class Game {
        +int scores
        +int timmer
        +bool isOver
        +bool isGameLost
        +update()
        +Draw(Graphics g)
        +checkBricksCollision()
        +checkPowerUpsCollision()
        +ApplyPowerUp(PowerUpType type)
    }

    Game "1" *-- "many" Brick : contains
    Game "1" *-- "many" Ball : contains
    Game "1" *-- "1" Paddle : contains
    Game "1" *-- "many" PowerUp : contains
```
