# Cours de C#

## Création de la structure

### Création des projets indépendants

Création de la solution vide :  
`mkdir Isen.Cs && cd Isen.Cs`  
`dotnet new sln`  
Création du projet de type console :  
`mkdir Isen.Cs.ConsoleApp && cd Isen.Cs.ConsoleApp`  
`dotnet new console`  
Création du projet de type librairie (depuis la racine) :  
`mkdir Isen.Cs.Library && cd Isen.Cs.Library`  
`dotnet new classlib`  
Création du projet de type tests unitaires (depuis la racine) :  
`mkdir Isen.Cs.Tests && cd Isen.Cs.Tests`  
`dotnet new xunit`  
### Référencement des projets
Ajouter au projet console une référence vers le projet Library.  
Depuis le dossier du projet console :  
`dotnet add reference ..\Isen.Cs.Library\Isen.Cs.Library.csproj` 

Ajouter au projet tests une référence vers le projet Library.  
Depuis le dossier du projet tests :  
`dotnet add reference ..\Isen.Cs.Library\Isen.Cs.Library.csproj` 
Pour retirer la référence, remplacer `add` par `remove`.

### Indiquer au sln la présence des 3 projets :
`dotnet sln add Isen.Cs.Library\Isen.Cs.Library.csproj`  
`dotnet sln add Isen.Cs.ConsoleApp\Isen.Cs.ConsoleApp.csproj`  
`dotnet sln add Isen.Cs.Tests\Isen.Cs.Tests.csproj`  

### Parenthèse spécifique à Visual Studio (et PAS Visual Studio CODE)
On peut créer des "dossiers de solution", qui sont des dossiers virtuels (non reflétés dasn le filesystem).
Rangement proposé :
- `src` pour les projets library et console.
- `tests` pour les projets de tests.
- `sln` pour tous les fichiers hors projet à la racine de la solution.

### Ménage 
Effacer les fichiers .cs générés automatiquement, à l'exception de celui du projet Console.

### Build pour vérifier
Il y a 3 étapes, qui s'appellent entre elles, lors d'un build :
- `dotnet restore` : restaurer les packages "NuGet" distants (mécanisme équivalent à `npm`).
- `dotnet build` : compiler les projets.
- `dotnet run` : exécuter le projet, s'il est exécutable :
    - Exécuter dans la console, pour un projet console.
    - Lancer un serveur web, pour un projet web.
    
### Initial commit
Créer un pojet sur Github