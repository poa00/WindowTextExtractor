﻿using System.Runtime.InteropServices;

namespace WindowTextExtractor.Native.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    struct SmallRect
    {
        public short Left;
        public short Top;
        public short Right;
        public short Bottom;
    }
}
