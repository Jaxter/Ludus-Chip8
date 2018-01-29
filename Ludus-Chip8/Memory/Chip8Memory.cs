﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludus_Chip8.Memory
{
    public class Chip8Memory
    {
        private Chip8 _chip8Device;
        private byte[] memory;

        public Chip8Memory(Chip8 chip8Device)
        {
            this._chip8Device = chip8Device;
            this.memory = new byte[Chip8Constants.MEMORY_SIZE];

            this.InitialiseFontset();
        }

        public byte Get(ushort address)
        {
            return this.memory[address];
        }

        public void LoadRom(byte[] romBuffer)
        {
            romBuffer.CopyTo(memory, Chip8Constants.MEMORY_START_ADDRESS);
        }

        private void InitialiseFontset()
        {
            Chip8Constants.FONTSET.CopyTo(this.memory, 0);
        }
    }
}
