using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libTPKeyboardAvoiding.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true)]
