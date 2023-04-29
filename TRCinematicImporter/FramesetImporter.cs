using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using TRLevelReader;
using TRLevelReader.Model;

namespace TRCinematicImporter
{
    public class FramesetImporter
    {
        public const uint TR1 = 32u;

        public const uint TR2 = 45u;

        public const uint TR3a = 4278714424u;

        public const uint TR3b = 4279763000u;

        private readonly List<Frameset> _cinematics;
        public Frameset[] Cinematics => _cinematics.ToArray();

        public FramesetImporter()
        {
            _cinematics = JsonConvert.DeserializeObject<List<Frameset>>(File.ReadAllText("frames.json"));
        }

        public void Import(Frameset cinematic, string levelPath)
        {
            switch (GetLevelVersion(levelPath))
            {
                case TR1:
                    ImportTR1Cinematic(cinematic, levelPath);
                    break;
                case TR2:
                    ImportTR2Cinematic(cinematic, levelPath);
                    break;
                case TR3a:
                case TR3b:
                    ImportTR3Cinematic(cinematic, levelPath);
                    break;
                default:
                    throw new NotImplementedException("Only TR1, TR2 and TR3 level files are supported.");
            }
        }

        private uint GetLevelVersion(string file)
        {
            using (BinaryReader reader = new BinaryReader(File.OpenRead(file)))
            {
                return reader.ReadUInt32();
            }
        }

        private void ImportTR1Cinematic(Frameset cinematic, string levelPath)
        {
            TRLevel level = new TR1LevelReader().ReadLevel(levelPath);
            level.CinematicFrames = cinematic.Frames;
            level.NumCinematicFrames = (ushort)level.CinematicFrames.Length;
            new TR1LevelWriter().WriteLevelToFile(level, levelPath);
        }

        private void ImportTR2Cinematic(Frameset cinematic, string levelPath)
        {
            TR2Level level = new TR2LevelReader().ReadLevel(levelPath);
            level.CinematicFrames = cinematic.Frames;
            level.NumCinematicFrames = (ushort)level.CinematicFrames.Length;
            new TR2LevelWriter().WriteLevelToFile(level, levelPath);
        }

        private void ImportTR3Cinematic(Frameset cinematic, string levelPath)
        {
            TR3Level level = new TR3LevelReader().ReadLevel(levelPath);
            level.CinematicFrames = cinematic.Frames;
            level.NumCinematicFrames = (ushort)level.CinematicFrames.Length;
            new TR3LevelWriter().WriteLevelToFile(level, levelPath);
        }
    }
}
