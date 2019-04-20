# General preparation for development in .NET

* set env variable [DOTNET_CLI_UI_LANGUAGE=en](https://github.com/dotnet/cli/issues/7585) to avoid polish commands in dotnet cli
* create [global.json](https://docs.microsoft.com/en-us/dotnet/core/tools/global-json) with version of required dotnet sdk to avoid using your beta sdks
* create project and test project
* dotnet add package coverlet.msbuild to test projects
* downgrade coverlet to [2.5.1](https://github.com/tonerdo/coverlet/issues/359)
* dotnet test /p:CollectCoverage=true /p:Exclude="[xunit*]*"
* either remove global.json or set [manualy](https://docs.microsoft.com/pl-pl/azure/devops/pipelines/languages/dotnet-core?view=azure-devops) dotnet version 
* include sonar in build:
  * https://docs.sonarqube.org/display/SCAN/Install+the+SonarScanner+for+MSBuild
