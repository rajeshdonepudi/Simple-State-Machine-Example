# 📦 Order State Machine – C# Console Application

This project demonstrates a **simple enum-based state machine in C#** using a console application.  
It models a **real-world order delivery lifecycle** with controlled state transitions and activity logging.

---

## 📖 Overview

A **state machine** ensures that an object moves through a predefined set of states in a valid order.

In this example, an `Order` progresses through the following lifecycle:

Created → Shipped → InTransit → OutForDelivery → Delivered

Each transition:
- Occurs only from a valid previous state
- Updates the order status
- Records a timestamped activity log

---

## 🔁 Order Lifecycle

| State | Description |
|------|------------|
| Created | Order is created |
| Shipped | Order handed to courier |
| InTransit | Order moving between hubs |
| OutForDelivery | Order on the way to customer |
| Delivered | Order successfully delivered |

---

## 🏗️ Project Structure

This project is implemented as a **single console application** with the following logical components:

- `OrderStateEnum` – Defines valid order states
- `Order` – Manages state transitions and activity logs
- `Program` – Simulates the order lifecycle

---

## 💻 Technologies Used

- C#
- .NET Console Application
- Enum-based state machine
- In-memory logging

---

## ⚙️ Prerequisites

- .NET SDK 6.0 or later
- Any C# IDE (Visual Studio / VS Code / Rider)

Verify installation:
```bash
dotnet --version
