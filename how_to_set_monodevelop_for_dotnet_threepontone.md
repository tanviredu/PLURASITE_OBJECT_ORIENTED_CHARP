1) install dotnet core 3.1 sdk in ubuntu
2) and test with dotnet --info command in terminal
3) if ok then install monodevelop
4) open a project with monodevelop
5) it wil try to install 1.1 or anything while create the project for the first time
dont worry about it
6) now go to the project .csproj file
7) in this line change it from 1.1 to 3.1

<TargetFramework>netcoreapp3.1</TargetFramework>

8) restart the project

