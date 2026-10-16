# allSpontaneous

Mod para Pathfinder: Wrath of the Righteous (UMM) que converte classes prepared em spontaneous.

## Status

Setup do toolchain pronto. Implementação da conversão ainda não começou.

## Ambiente local

- Jogo: `D:\SteamLibrary\steamapps\common\Pathfinder Second Adventure`
- Unity Mod Manager: `Wrath_Data\Managed\UnityModManager`
- Pasta de mods: `Mods\allSpontaneous` (o build copia o DLL e o `Info.json` para cá)

## Ferramentas

- .NET SDK 8 (`dotnet build`)
- Pacote `Microsoft.NETFramework.ReferenceAssemblies.net48` (não precisa do Visual Studio)
- Extensão C# do Cursor (`anysphere.csharp`)
- ILSpy, para inspecionar `Assembly-CSharp.dll` quando for implementar a lógica

## Build

```powershell
dotnet build
```

O output vai para `bin\` e, se o jogo estiver no caminho acima, também para:

`D:\SteamLibrary\steamapps\common\Pathfinder Second Adventure\Mods\allSpontaneous`

## Próximos passos (implementação)

- Scanner dinâmico de classes spellcaster
- Conversão de blueprints (`IsSpontaneous` + tabelas)
- Persistência de configuração no save (JSON)
- Menu UMM por classe
