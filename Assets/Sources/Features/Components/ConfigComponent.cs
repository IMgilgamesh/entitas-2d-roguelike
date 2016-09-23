﻿using Entitas;
using Entitas.CodeGenerator;

[SingleEntity]
public class ConfigComponent : IComponent
{
    public int columns;
    public int rows;
    public int foodCountMin;
    public int foodCountMax;
    public int wallCountMin;
    public int wallCountMax;
    public int foodPoints;
    public int sodaPoints;
    public int enemy1Dmg;
    public int enemy2Dmg;
}