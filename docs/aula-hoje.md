# Aula 15-16: Desenvolvimento de Interfaces (14/04/2026)

## 🎯 Objetivos da Aula

1. **Desenvolver interfaces móveis** usando .NET MAUI
2. **Implementar telas funcionais** com XAML
3. **Aplicar design patterns** para interfaces
4. **Criar navegação** entre telas

## 📋 Conteúdo Programático

### 1. Estrutura de Interface MAUI
- **ContentPage**: Páginas de conteúdo
- **Layouts**: StackLayout, Grid, AbsoluteLayout
- **Controles**: Button, Label, Entry, etc.
- **Recursos**: Styles, Resources, DataTemplates

### 2. XAML para Interfaces
```xml
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             x:Class="MeuApp.MainPage">
    <StackLayout Padding="20">
        <Label Text="Bem-vindo!" 
               FontSize="24"
               HorizontalOptions="Center" />
        <Button Text="Clique aqui" 
                Clicked="OnButtonClicked" />
    </StackLayout>
</ContentPage>
```

### 3. Navegação entre Telas
```csharp
await Navigation.PushAsync(new DetailPage());
```

## 🎨 Design de Interfaces

### Princípios
- **Simplicidade**: Interface limpa e objetiva
- **Consistência**: Padrões visuais uniformes
- **Feedback**: Respostas às ações do usuário
- **Acessibilidade**: Tamanho adequado de textos e botões

### Layouts Comuns
- **StackLayout**: Elementos empilhados
- **Grid**: Grade com linhas e colunas
- **FlexLayout**: Flexbox responsivo
- **AbsoluteLayout**: Posicionamento absoluto

## 💻 Exemplos Práticos

### Tela de Login
```xml
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             x:Class="App.LoginPage">
    <StackLayout Padding="30" Spacing="15">
        <Label Text="Login" 
               FontSize="32"
               FontAttributes="Bold"
               HorizontalOptions="Center" />
        
        <Entry Placeholder="E-mail" 
               Keyboard="Email" />
        
        <Entry Placeholder="Senha" 
               IsPassword="True" />
        
        <Button Text="Entrar" 
                Clicked="OnLoginClicked" />
    </StackLayout>
</ContentPage>
```

### Tela com Lista
```xml
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             x:Class="App.ListPage">
    <CollectionView ItemsSource="{Binding Items}">
        <CollectionView.ItemTemplate>
            <DataTemplate>
                <StackLayout Padding="10">
                    <Label Text="{Binding Title}" 
                           FontSize="18" />
                    <Label Text="{Binding Description}" 
                           FontSize="14" 
                           TextColor="Gray" />
                </StackLayout>
            </DataTemplate>
        </CollectionView.ItemTemplate>
    </CollectionView>
</ContentPage>
```

## 🚀 Atividades da Aula

### 1. Criar Novo Projeto
```bash
dotnet new maui -n MeuPrimeiroApp
cd MeuPrimeiroApp
```

### 2. Implementar Tela Principal
- Modificar `MainPage.xaml`
- Adicionar controles básicos
- Configurar layout

### 3. Adicionar Navegação
- Criar segunda tela
- Implementar botão de navegação
- Passar dados entre telas

### 4. Aplicar Estilos
- Criar recursos visuais
- Aplicar temas
- Configurar responsividade

## 📝 Exercício

**Objetivo:** Criar um app com 3 telas

1. **Tela Principal**: Menu com opções
2. **Tela de Perfil**: Informações do usuário
3. **Tela de Configurações**: Preferências do app

**Requisitos:**
- Navegação funcional entre telas
- Design responsivo
- Botões e interações
- Pelo menos 3 tipos de layouts diferentes

## 🎯 Entrega

- [ ] Projeto MAUI criado
- [ ] 3 telas implementadas
- [ ] Navegação funcional
- [ ] Design aplicado
- [ ] Código no GitHub

## 📚 Referências

- [Documentação .NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/)
- [XAML Basics](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/layouts/)
- [Samples Gallery](https://github.com/dotnet/maui-samples)

---

**Para a próxima aula (21/04):** Feriado/Recesso  
**Próxima aula ativa (28/04):** Continuação de interfaces
