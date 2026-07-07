# Adaptive Math Quiz Game 🎮🧮

An adaptive console-based math quiz game built with **C#** to practice arithmetic skills while demonstrating professional **Object-Oriented Programming (OOP)** principles.

---

## ✨ Features

- Three adaptive difficulty levels:
  - Easy
  - Medium
  - Hard
- Automatic level progression based on the player's performance.
- Randomly generated arithmetic questions.
- Supports:
  - Addition
  - Subtraction
  - Multiplication
  - Division
- Score tracking after each round.
- Robust input validation to prevent crashes caused by invalid user input.

---

## 🏗️ OOP Concepts Applied

This project was designed following clean object-oriented principles.

### Inheritance
An abstract `Level` class defines the common behavior shared by all game levels.

Derived classes:
- `EasyLevel`
- `MidLevel`
- `HardLevel`

---

### Polymorphism

The `GameEngine` interacts only with the abstract `Level` class.

Each level overrides its own question generation logic at runtime.

---

### Abstraction

The abstract `Level` class hides implementation details while exposing only the required functionality.

---

### Encapsulation

Input validation and helper methods are separated into a dedicated `Helper` class to keep responsibilities isolated.

---

## 📁 Project Structure

```
GameProj
│
├── GameEngine
├── Helper
├── Level (Abstract)
├── EasyLevel
├── MidLevel
├── HardLevel
└── Program
```

---

## 🛠 Technologies

- C#
- .NET
- Object-Oriented Programming (OOP)

---

## ▶️ Getting Started

1. Clone the repository.

```bash
git clone https://github.com/yousefAmrDev/MathGameProj.git
```

2. Open the solution in Visual Studio.

3. Build and run the project.

---

## 🚀 Future Improvements

- Add a timer for each question.
- Save high scores.
- Support additional game modes.
- Add more mathematical operations.
- Export results.

---

## 👨‍💻 Author

**Yousef Amr**

Computer Science Student | Backend .NET Developer
