﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ludus_Chip8.Cpu.Opcodes;

namespace Ludus_Chip8.Cpu.Instructions.Implementation
{
    /// <summary>
    /// Ex9E - SKP Vx
    /// Skip next instruction if key with the value of Vx is pressed.
    /// </summary>
    public class SkpInstruction : ICpuInstruction
    {
        public void Execute(Chip8 chip8Device, Opcode opcode)
        {
            byte registerX = (byte)((opcode.Value & 0x0F00) >> 8);
            byte valueX = chip8Device.RegisterBank.V[registerX];

            if (chip8Device.InputManager.GetKeyState(valueX))
                chip8Device.RegisterBank.PC += 2;
        }
    }
}
