# MyIsekai
My Isekai Project is a C# Windows Forms role-playing game (RPG) prototype, designed as a narrative-driven adventure with a hero selection system, combat screens, and multi-stage exploration. It simulates the gameplay flow of a classic "isekai" (alternate-world) RPG, emphasizing modular scene transitions and a menu-based interface. The second part inside the Tower gate is a sidescroller with simulated physics and a moving platform done using winform image boundary.

Features
    Hero Selection System
        Choose from a set of heroes to begin your journey.
    Turn-Based Combat Interface
        Engage in scripted combat via the CombatScreen.
    Open World Navigation
        Explore multiple regions such as towers and villages via the OpenWorldCenterScreen.
    Siscroller mechanics
        Jump, idle, walk, stand on moving platform, physics
    Multiple Game Scenes
        Modular screen transitions for each phase of gameplay:
        Title screen
        Hero selection
        Exploration hub
        Combat
        Sidescroller
        Credits
    Component-Based Design
        Each form acts as a separate game screen (similar to game scenes in Unity), improving organization and testability.

How to Run
    Open the solution file My_isekai_project_app.sln in Visual Studio.
    Set My_isekai_project as the Startup Project.
    Press F5 or click Start to build and run.
    The game begins at the TitleScreen and progresses based on user interaction.

Notes
    All navigation between scenes is handled through form transitions.
    The solution contains additional folders (like My_isekai_lib and Pathfinding_test) that includes logic for navigation algorithms (pathfinding test).
    The class diagram ClassDiagramIsekaiMain.png provides a high-level view of class relationships.

Change starting project to see the pathfinding test based on Dijkstra's algorithm

<p align="center">
  <img src="https://github.com/GestaltFactory/MyIsekai/blob/main/01.PNG" width="35%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/MyIsekai/blob/main/02.PNG" width="35%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/MyIsekai/blob/main/03.PNG" width="35%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/MyIsekai/blob/main/04.PNG" width="35%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/MyIsekai/blob/main/09.PNG" width="35%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/MyIsekai/blob/main/05.PNG" width="35%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/MyIsekai/blob/main/10.PNG" width="35%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/MyIsekai/blob/main/06.PNG" width="35%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/MyIsekai/blob/main/11.PNG" width="35%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/MyIsekai/blob/main/07.PNG" width="35%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/MyIsekai/blob/main/08.PNG" width="35%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/MyIsekai/blob/main/12.PNG" width="35%">
</p>
