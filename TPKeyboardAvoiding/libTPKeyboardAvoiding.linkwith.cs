using System;
using ObjCRuntime;

[assembly: LinkWith ("libTPKeyboardAvoiding.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64, ForceLoad = true)]
