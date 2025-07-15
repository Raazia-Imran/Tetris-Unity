# Tetris-Unity
A Unity recreation of the classic Tetris game featuring rotation, soft/hard drops, line-clearing, increasing difficulty, and a responsive UI.

# 🧱 Nostalgic Games Project: Tetris (Unity)

> A fully functional, retro-style **Tetris** remake built using Unity’s 2D Tilemap system and C#, featuring wall kicks, ghost pieces, smooth controls, and core line-clearing mechanics — all designed to recreate the nostalgic puzzle experience with modern tools.


---

## 🎮 Project Overview

This Unity project reimagines the **classic Tetris** experience using the latest 2D game development techniques. The gameplay includes all traditional Tetrominoes, smooth movement, wall kicks, and ghost piece previews. The architecture focuses on modularity and efficiency using **Unity Tilemaps**, **C# scripts**, and a **data-driven design** for flexibility and scalability.

---

## 🧩 Game Design and Features

- ✅ **Seven Tetromino Shapes**: I, O, T, J, L, S, Z  
- 🔲 **Tilemap-Based Grid**: Efficient rendering using Unity’s Tilemap system  
- 🔁 **Super Rotation System (SRS)**: Smooth rotation with wall kicks  
- 👻 **Ghost Piece**: Shows drop location for better planning  
- 🎮 **User Controls**: Move, rotate, soft/hard drop with responsive keys  
- ⏳ **Automatic Piece Falling**: Controlled by time step and user input  
- 🧹 **Line Clearing**: Detects and clears full rows, scores can be added  
- 🔒 **Piece Locking**: Lock delay before spawning next piece  

---

## ⚙️ Technical Architecture

- 🎮 **Unity 2022.3 LTS**
- 🧱 **Tilemap Component** for board and rendering logic  
- 📁 **Modular Scripts**: Separation of data and behavior  
- 🧮 **Matrix Math**: Used for rotation and wall kick application  
- 🧠 **Board Validation**: Ensures legal moves  
- 🖱 **Input Handling** directly within the `Piece` script  
- 🪞 **Ghost Piece Rendering** with a separate transparent tilemap layer  

---

## 📦 Core Components and Scripts

### `Tetromino` & `TetrominoData`
- Enum for all 7 tetromino types  
- Holds sprite tile, shape cell positions, and SRS wall kick data  

### `Piece.cs`
- Controls active falling piece  
- Handles movement (A/D), rotation (Q/E), drop (S/Space)  
- Applies rotation with matrix multiplication and wall kick tests  
- Communicates with `Board.cs` to validate moves  

### `Ghost.cs`
- Renders transparent piece below current piece  
- Updates every frame based on board and current position  

### `Data.cs`
- Stores all rotation matrices, Tetromino cells, and wall kick offsets  

---

## ⌨️ User Input Handling

| Key     | Action            |
|--------|-------------------|
| `A/D`  | Move Left/Right   |
| `Q/E`  | Rotate Left/Right |
| `S`    | Soft Drop         |
| `Space`| Hard Drop         |

Timers control piece descent and lock delay for smooth gameplay.

---

## 🧠 Game Mechanics

- ✅ Grid-based validation for all piece movements  
- 🔒 Locking mechanism with delay to allow last-moment shifts  
- 🧼 Full rows are auto-cleared and next piece spawns instantly  
- 🧠 Ghost piece helps plan hard drops  
- 🧮 Future scoring logic easily attachable via modular design  

---


