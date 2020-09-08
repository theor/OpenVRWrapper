using System;
using Valve.VR;

namespace OpenVRWrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EVRInitError error = EVRInitError.None;
            var sys = OpenVR.Init(ref error);
            // var i = OpenVRInterop.InitInternal(ref error, EVRApplicationType.VRApplication_Utility);
            try
            {
                Console.WriteLine($"Error: {error}");
                Console.WriteLine($"PResent: {sys.IsTrackedDeviceConnected(0)}");
                Console.WriteLine($"PResent: {OpenVRInterop.IsHmdPresent()}");

            }
            finally
            {
                OpenVR.Shutdown();
                // OpenVRInterop.ShutdownInternal();
                
            }
        }
    }
}