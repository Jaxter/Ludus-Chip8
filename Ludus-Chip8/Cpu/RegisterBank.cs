﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludus_Chip8.Cpu
{
    public class RegisterBank
    {
        private byte[] _v;
        private Chip8 _chip8Device;

        public ushort PC;
        public ushort I;

        public byte[] V { get { return this.V; } }

        public RegisterBank(Chip8 chip8Device)
        {
            this._v = new byte[15];
            this._chip8Device = chip8Device;
        }

        public void Reset()
        {
            for(int i = 0; i < this._v.Length; i++)
            {
                this._v[i] = 0;
            }
        }


    }
}