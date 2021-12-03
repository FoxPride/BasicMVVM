# Basic MVVM
> Using Microsoft.MVVM.Toolkit, Serilog, Squirrel.Windows

### **Core**:
- Base project where all logic happens

### **Resources**:
- Project for sharing resources (languages, ui stuff, etc.) 

### **Windows**:
- Project for implementing Windows OS specific stuff  

### **UI** (WPF): 
- Example project with simple navigation, dependency injection, localization and auto publish on release build

### **Test projects**:
- **ConsoleTest** - console playground
- **WpfTest** - WPF playground   
- **Core.Tests** - example unit tests project 

### **Core** project structure:
- **Data** - classes wich gathers data somehow (database, rest api, etc. )
- **Helpers** - helper classes 
- **Infrastructure** - classes for extending the functionality of the application 
- **Models** - models of the app (**M**VVM)
- **Services** - business logic 
- **Stores** - stores for holding application states
- **ViewModels** - view models for views (MV**VM**)

### **UI** project structure:
- Same logic as in Core project
- **Views** - представления (M**V**VM)
- **ReleaseSpec.nuspec** file - needed for creating Nuget package (part of Squirrel.Windows flow)
