using System;
using System.IO;
using NAudio.Wave; 

namespace oop_final_game
{
    internal static class SoundManager
    {
        private const int POOL_SIZE = 8;

        // Changing from 300ms down to 60ms for instant game-audio synchronization
        private const int AUDIO_LATENCY_MS = 60;

        private static WaveOutEvent[] brickOutputs;
        private static Mp3FileReader[] brickReaders;
        private static int brickIndex = 0;

        private static WaveOutEvent[] paddleOutputs;
        private static Mp3FileReader[] paddleReaders;
        private static int paddleIndex = 0;

        private static bool isInitialized = false;

        public static void Initialize()
        {
            if (isInitialized) return;

            try
            {
                brickOutputs = new WaveOutEvent[POOL_SIZE];
                brickReaders = new Mp3FileReader[POOL_SIZE];

                paddleOutputs = new WaveOutEvent[POOL_SIZE];
                paddleReaders = new Mp3FileReader[POOL_SIZE];

                byte[] brickBytes = ConvertStreamToBytes(Resource.brick_destroy);
                byte[] paddleBytes = ConvertStreamToBytes(Resource.brick_destroy_s);

                if (brickBytes == null)
                {
                    System.Diagnostics.Debug.WriteLine("Audio resource stream is null. Check resource names!");
                    return;
                }

                for (int i = 0; i < POOL_SIZE; i++)
                {
                    // Brick Channels configuration
                    MemoryStream brickMS = new MemoryStream(brickBytes);
                    brickReaders[i] = new Mp3FileReader(brickMS);

                    // 🔥 FIX: Explicitly configure the hardware buffer latency before initialization
                    brickOutputs[i] = new WaveOutEvent { DesiredLatency = AUDIO_LATENCY_MS };
                    brickOutputs[i].Init(brickReaders[i]);

                    // Paddle Channels configuration
                    MemoryStream paddleMS = new MemoryStream(paddleBytes);
                    paddleReaders[i] = new Mp3FileReader(paddleMS);

                    // 🔥 FIX: Set matching hardware low-latency for paddle deflections
                    paddleOutputs[i] = new WaveOutEvent { DesiredLatency = AUDIO_LATENCY_MS };
                    paddleOutputs[i].Init(paddleReaders[i]);
                }

                isInitialized = true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("NAudio Initialization critical error: " + ex.Message);
            }
        }

        public static void PlayBrickHit()
        {
            if (!isInitialized) return;

            var reader = brickReaders[brickIndex];
            var output = brickOutputs[brickIndex];

            reader.Position = 0;

            if (output.PlaybackState == PlaybackState.Playing)
            {
                output.Stop();
            }

            output.Play();
            brickIndex = (brickIndex + 1) % POOL_SIZE;
        }

        public static void PlayPaddleHit()
        {
            if (!isInitialized) return;

            var reader = paddleReaders[paddleIndex];
            var output = paddleOutputs[paddleIndex];

            reader.Position = 0;

            if (output.PlaybackState == PlaybackState.Playing)
            {
                output.Stop();
            }

            output.Play();
            paddleIndex = (paddleIndex + 1) % POOL_SIZE;
        }

        private static byte[] ConvertStreamToBytes(Stream input)
        {
            if (input == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }

        public static void Shutdown()
        {
            if (!isInitialized) return;

            for (int i = 0; i < POOL_SIZE; i++)
            {
                brickOutputs[i]?.Dispose();
                brickReaders[i]?.Dispose();
                paddleOutputs[i]?.Dispose();
                paddleReaders[i]?.Dispose();
            }
        }
    }
}