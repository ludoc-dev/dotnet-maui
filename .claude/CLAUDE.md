# .NET/MAUI Project Rules

## Course Context
- **Course**: Programação Para Dispositivos Móveis 2026
- **NotebookLM**: d7c17a87-6c17-4953-aa67-9cacd31e7a35
- **Platform**: .NET MAUI (cross-platform mobile)

## Session Start Protocol
**When working in this repository, always:**
1. Access NotebookLM notebook `d7c17a87-6c17-4953-aa67-9cacd31e7a35` first
2. Review current lesson materials and exercise requirements
3. Verify alignment with course project structure standards
4. Check platform-specific requirements (iOS vs Android)

## Anti-Drift (CRITICAL)
**Stop work and re-sync with NotebookLM when:**
- Implementation contradicts course materials
- Missing lesson prerequisites or dependencies
- Platform-specific conflicts arise (iOS/Android behavioral differences)
- Project structure diverges from course standards

## Tech Stack
- .NET 8+ or latest stable
- MAUI workload installed
- C# for cross-platform business logic
- XAML for UI definitions with platform-specific renderers

## Development Commands

### Build & Run
```bash
# Build entire solution
dotnet build

# Run on specific platform
dotnet build -t:Run -f net8.0-android
dotnet build -t:Run -f net8.0-ios

# Clean build artifacts
dotnet clean
```

### Testing
```bash
# Run all tests
dotnet test

# Run specific test
dotnet test --filter "FullyQualifiedName~TestMethodName"

# Run tests with detailed output
dotnet test --logger "console;verbosity=detailed"
```

### Package Management
```bash
# Add NuGet package
dotnet add package PackageName

# Restore packages
dotnet restore

# List packages
dotnet list package
```

## Architecture Patterns

### MAUI Application Structure
- **MauiProgram.cs**: Dependency injection and app configuration
- **App.xaml/AppShell.xaml**: App-level resources and navigation hierarchy
- **Pages/**: UI screens (ContentPage derivatives)
- **ViewModels/**: Data binding and business logic (MVVM pattern)
- **Models/**: Data structures and business entities
- **Services/**: Platform-specific abstractions (file I/O, networking, sensors)
- **Resources/**: Images, fonts, strings, styles (per-platform)

### Platform-Specific Considerations
- **iOS**: Requires Mac build host, Info.plist permissions, physical device for testing
- **Android**: AndroidManifest.xml permissions, minimum API level configuration
- **Windows**: WinUI 3 rendering, different touch/input handling
- **macOS**: MacCatalyst framework, different sandbox constraints

### MVVM Pattern (Preferred)
- ViewModels should inherit from `INotifyPropertyChanged` or use `ObservableObject`
- Use CommunityToolkit.Mvvm for boilerplate reduction
- Commands for user interactions, not code-behind event handlers
- Data binding over direct UI manipulation

## Platform-Specific Debugging

### iOS Quirks
- NavigationPage stack behavior differs from Android
- Tab placement requires Platform-specific logic
- Permissions require Info.plist entries at build time

### Android Quirks
- File provider URIs required for file:// access
- Activity lifecycle affects view model disposal
- Back button behavior differs from iOS navigation
