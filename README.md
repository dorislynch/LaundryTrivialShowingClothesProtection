
# react-native-laundry-trivial-showing-clothes-protection

## Getting started

`$ npm install react-native-laundry-trivial-showing-clothes-protection --save`

### Mostly automatic installation

`$ react-native link react-native-laundry-trivial-showing-clothes-protection`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-laundry-trivial-showing-clothes-protection` and add `RNLaundryTrivialShowingClothesProtection.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNLaundryTrivialShowingClothesProtection.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNLaundryTrivialShowingClothesProtectionPackage;` to the imports at the top of the file
  - Add `new RNLaundryTrivialShowingClothesProtectionPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-laundry-trivial-showing-clothes-protection'
  	project(':react-native-laundry-trivial-showing-clothes-protection').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-laundry-trivial-showing-clothes-protection/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-laundry-trivial-showing-clothes-protection')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNLaundryTrivialShowingClothesProtection.sln` in `node_modules/react-native-laundry-trivial-showing-clothes-protection/windows/RNLaundryTrivialShowingClothesProtection.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Laundry.Trivial.Showing.Clothes.Protection.RNLaundryTrivialShowingClothesProtection;` to the usings at the top of the file
  - Add `new RNLaundryTrivialShowingClothesProtectionPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNLaundryTrivialShowingClothesProtection from 'react-native-laundry-trivial-showing-clothes-protection';

// TODO: What to do with the module?
RNLaundryTrivialShowingClothesProtection;
```
  