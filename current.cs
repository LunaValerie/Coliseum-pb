for (int i = 0; i < 52; i++)
                {
                    string STR = LauncherLogs + "0x" + (HackDetected + i * 0x10).ToString("X");
                }
                m.WriteMemory("PointBlank.exe+4669D6", "bytes", "0x90 0x90 0x90 0x90 0x90");
                m.WriteMemory("PointBlank.exe+7EB367", "bytes", "0x90 0x90 0x90 0x90 0x90");
                m.WriteMemory("PointBlank.exe+7EB2A7", "bytes", "0x90 0x90");
                m.WriteMemory("PointBlank.exe+9761E0", "bytes", "0x90 0x90");
                m.WriteMemory("PointBlank.exe+976E1E", "bytes", "0x90 0x90 0x90 0x90 0x90");
                m.WriteMemory("PointBlank.exe+417D1F", "bytes", "0x90 0x90 0x90 0x90 0x90 0x90 0x90 0x90");