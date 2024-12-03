
# react-native-downtown-christmas-gift-exchanging

## Getting started

`$ npm install react-native-downtown-christmas-gift-exchanging --save`

### Mostly automatic installation

`$ react-native link react-native-downtown-christmas-gift-exchanging`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-downtown-christmas-gift-exchanging` and add `RNDowntownChristmasGiftExchanging.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNDowntownChristmasGiftExchanging.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNDowntownChristmasGiftExchangingPackage;` to the imports at the top of the file
  - Add `new RNDowntownChristmasGiftExchangingPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-downtown-christmas-gift-exchanging'
  	project(':react-native-downtown-christmas-gift-exchanging').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-downtown-christmas-gift-exchanging/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-downtown-christmas-gift-exchanging')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNDowntownChristmasGiftExchanging.sln` in `node_modules/react-native-downtown-christmas-gift-exchanging/windows/RNDowntownChristmasGiftExchanging.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Downtown.Christmas.Gift.Exchanging.RNDowntownChristmasGiftExchanging;` to the usings at the top of the file
  - Add `new RNDowntownChristmasGiftExchangingPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNDowntownChristmasGiftExchanging from 'react-native-downtown-christmas-gift-exchanging';

// TODO: What to do with the module?
RNDowntownChristmasGiftExchanging;
```
  