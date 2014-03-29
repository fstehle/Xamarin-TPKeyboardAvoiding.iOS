# MonoTouch (Xamarin.iOS) bindings for TPKeyboardAvoiding

These are MonoTouch (Xamarin.iOS) bindings for [TPKeyboardAvoiding](https://github.com/michaeltyson/TPKeyboardAvoiding)

## Requirements

* iOS SDK
* [Xamarin Studio](https://xamarin.com/studio)
* Cocoapods
* Make

## Building the bindings

Just run

	make

This downloads source via CocoaPods, creates the static objectice-c library and finally links all into a .dll-file. 