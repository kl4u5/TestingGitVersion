Nuget exe and config were added here to be used by the build steps in jenkins http://wspjen91:8080/job/EpiAbsojc_ny/
To test nuget restore localy run:
...\.nuget\nuget.exe restore AlmBrand.sln

All this cound become irelavant if we get MSBuild 15.1+ on jenkins.
For NuGet 4.0+ and MSBuild 15.1+, you can also use MSBuild /t:restore
See: https://docs.microsoft.com/en-us/nuget/schema/msbuild-targets