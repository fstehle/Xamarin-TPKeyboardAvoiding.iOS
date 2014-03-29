BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs
MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild
XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild

PROJECT=TPKeyboardAvoiding
CSPROJ=$(PROJECT).csproj
LIB_NAME=lib$(PROJECT).a
LIB_NAME_I386=lib$(PROJECT)-i386.a
LIB_NAME_ARMV7=lib$(PROJECT)-armv7.a
DLL_NAME=$(PROJECT).dll

POD_NAME=$(PROJECT)
PODS_PROJECT_ROOT=Pods
PODS_PROJECT=$(PODS_PROJECT_ROOT)/Pods.xcodeproj
PODS_TARGET=Pods-$(POD_NAME)

all: $(PROJECT).dll
	
package:
	nuget pack Package.nuspec

$(PODS_PROJECT):
	pod install --no-integrate

$(LIB_NAME_I386): $(PODS_PROJECT)
	$(XBUILD) -project $(PODS_PROJECT) -target $(PODS_TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PODS_PROJECT_ROOT)/build/Release-iphonesimulator/lib$(PODS_TARGET).a $@

$(LIB_NAME_ARMV7): $(PODS_PROJECT)
	$(XBUILD) -project $(PODS_PROJECT) -target $(PODS_TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PODS_PROJECT_ROOT)/build/Release-iphoneos/lib$(PODS_TARGET).a $@

$(LIB_NAME): $(LIB_NAME_I386) $(LIB_NAME_ARMV7)
	lipo -create -output $@ $^

$(DLL_NAME): $(LIB_NAME)
	$(MONOXBUILD) /p:Configuration=Release $(CSPROJ)
	cp bin/Release/$(DLL_NAME) $(DLL_NAME)

clean:
	-rm -rf bin obj *.a *.dll
	rm -rf Pods