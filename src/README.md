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



* to read [example](https://dev.to/deinsoftware/net-core-unit-test-and-code-coverage-with-visual-studio-code-37bp)

to measure cc from command line:
* dotnet test /p:CollectCoverage=true /p:Exclude="[xunit.*]"*

to send project stats to sonar manually
* pre requisite: dotnet tool install --global dotnet-sonarscanner --version 4.3.1
* dotnet sonarscanner begin /k:"giolegal_web-bot" /o:"giolegal" /d:sonar.host.url=https://sonarcloud.io /d:sonar.login=SONAR_TOKEN /d:sonar.cs.opencover.reportsPaths="coverage.opencover.xml"
* dotnet test /p:CollectCoverage=true /p:Exclude="[xunit.*]"* /p:CoverletOutputFormat=opencover /p:CoverletOutput=../
* dotnet sonarscanner end /d:sonar.login=SONAR_TOKEN