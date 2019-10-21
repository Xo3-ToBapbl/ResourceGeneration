# ResourceGeneration
Small example-project for resource (IDs, Colors, Dimensions etc.) sharing between .Core, .iOS and .Droid projects.

# Initialization
1. Create .resx files.
2. Create T4 template for resource generation.
3. Add to .Core .csproj relative path varible to Droid/Resource/values/ folder:
```
<ResourceDestinationPath>..\..\ResourceGeneration.Droid\Resources\values</ResourceDestinationPath>
```
4. To allow regeneration during project build process add to .Core .csproj:
```
<PropertyGroup>
    <VisualStudioVersion Condition="'$(VisualStudioVersion)' == ''">16.0</VisualStudioVersion>
    <VSToolsPath Condition="'$(VSToolsPath)' == ''">$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v$(VisualStudioVersion)</VSToolsPath>
    <TransformOnBuild>true</TransformOnBuild>
    <OverwriteReadOnlyOutputFiles>true</OverwriteReadOnlyOutputFiles>
    <TransformOutOfDateOnly>false</TransformOutOfDateOnly>
</PropertyGroup>
```
and to the end of the file:
```
<Import Project="Sdk.targets" Sdk="Microsoft.NET.Sdk" />
<Import Project="$(VSToolsPath)\TextTemplating\Microsoft.TextTemplating.targets" />
```
5. Set up destination file settings for every T4 template:
```
<None Update="Templates\ViewIdentifiersTemplate.tt">
      <Generator>TextTemplatingFileGenerator</Generator>
      <OutputFilePath>$(ResourceDestinationPath)</OutputFilePath>
      <OutputFileName>view_identifiers.xml</OutputFileName>
      <LastGenOutput>ViewIdentifiersTemplate.xml</LastGenOutput>
</None>
```
6. For first time generation need manually include resource files into .Droid project and set up properties
```
Build Action: Android Resources
Custom Tool: MSBuild:UpdateGeneratedFiles
```
7. Enjoy sharing resources:)
