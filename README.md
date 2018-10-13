# Equations-Of-Motion-Library

[![Build status](https://ci.appveyor.com/api/projects/status/hf1msnphbt0g9oyx/branch/master?svg=true)](https://ci.appveyor.com/project/srbrettle/equations-of-motion-library/branch/master) [![Build Status](https://travis-ci.org/srbrettle/Equations-Of-Motion-Library.svg?branch=master)](https://travis-ci.org/srbrettle/Equations-Of-Motion-Library) [![codecov](https://codecov.io/gh/srbrettle/Equations-Of-Motion-Library/branch/master/graph/badge.svg)](https://codecov.io/gh/srbrettle/Equations-Of-Motion-Library)
 [![contributions welcome](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/srbrettle/Equations-Of-Motion-Library/issues)

A collection of methods for solving Displacement, Initial and Final Velocities, Constant Acceleration and Time. This project uses .NET Standard 2.0.

## See in Action

[Equations Of Motion - Android Application](https://play.google.com/store/apps/details?id=com.barwickapplications.calc.equationsofmotion)

## Getting Started - C#

### Using NuGet [![NuGet](https://img.shields.io/badge/NuGet-1.0.0-blue.svg)](https://www.nuget.org/packages/EquationsOfMotion/1.0.0)

1. Within your project, install EquationsOfMotion NuGet package (via "Manage Packages for Solution" or running the following in "Packet Manager Console".
```PowerShell
Install-Package EquationsOfMotion -Version 1.0.0
```
2. Reference the Namespace:
```c#
using srbrettle.EquationsOfMotion;
```
3. Use the static library methods:
```c#
double result = InitialVelocity.InitialVelocityFromVAT(20, 2, 5);
```

## License

This project is licensed under the MIT License - see the [LICENSE](/LICENSE) file for details.
