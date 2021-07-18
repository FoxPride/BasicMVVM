# Basic MVVM

Состоит из следующих частей: Core Project, Resources Project, UI Project (WPF), Tests

Core Project реализует MVVM подход с использованием Microsoft.MVVM.Toolkit и базовую структуру проекта:

- **Data** - сюда складируются классы для получения данных каким-либо путём (база данных, онлайн и т.д.)
- **Models** - здесь хранятся все модели приложения (**M**VVM)
- **ViewModels** - здесь хранятся все модели представлений (MV**VM**)
- **Helpers** - классы-помощники
- **Infrastructure** - расширения функционала приложения
- **Services** - бизнес логика приложения
- **Views** - представления (M**V**VM)
- **Resources** - ресурсы проекта
  
### **Core Project** реализует:
- Встраивание команд через делегаты 
- Систему навигации с примерами 
- Систему нотификаций между моделями представлений
- Интерфейсы:
  - Обновление клиента (через Squirrel)
  - Логирование (через NLog)

### **Resources Project**:
- Хранит все стили проекта

### **Папка Tests содержит**:
- Тестовые проекты
  - **ConsoleTest** - консольный проект для тестов
  - **WpfTest** - wpf проект для тестов    
- Юнит-тесты для проекта

### **UI Project** реализует: 
- Dependency Injection
- Хранит представления проекта 