# .NET MAUI - Spec Completo e Test Suite

**Curso:** Programação Para Dispositivos Móveis - PDM  
**Professor:** Rafael Soares de Almeida  
**Período:** 1º Semestre 2026  
**Data:** 14/04/2026

---

## 1. Visão Geral do Projeto

### 1.1 Objetivo
Desenvolver um aplicativo móvel multiplataforma usando .NET MAUI que demonstre os conceitos fundamentais de desenvolvimento mobile, interfaces de usuário, navegação e integração com recursos do dispositivo.

### 1.2 Escopo
- Aplicativo com múltiplas telas e navegação
- Interfaces responsivas usando XAML
- Integração com recursos nativos (câmera, GPS, etc.)
- Design patterns (MVVM)
- Testes automatizados
- Deploy em plataformas iOS/Android

### 1.3 Tecnologias
- .NET 8+
- .NET MAUI
- XAML
- C#
- Visual Studio 2022
- xUnit/NUnit para testes

---

## 2. Apostilas e Conteúdo Programático

### Apostila 01: Desenvolvimento Mobile e Plataformas
**Conteúdo:** História, evolução, plataformas nativas vs híbridas

### Apostila 02: Introdução ao .NET MAUI
**Conteúdo:** Configuração de ambiente, estrutura de projeto

### Apostila 03: Interface do Usuário - Páginas e Layouts
**Conteúdo:** ContentPage, StackLayout, Grid, AbsoluteLayout, FlexLayout

### Apostila 04: Views e Controles
**Conteúdo:** Label, Button, Entry, Editor, CollectionView, etc.

### Apostila 05: Navegação e MVVM
**Conteúdo:** NavigationPage, TabbedPage, FlyoutPage, MVVM pattern

### Apostila 06: Recursos Avançados
**Conteúdo:** Banco de dados, APIs nativas, sensores

---

## 3. Requisitos Funcionais

### RF-001: Tela Principal
- **Descrição:** Tela inicial com menu de navegação
- **Prioridade:** Alta
- **Critérios:**
  - Exibir logo/título do app
  - Menu com 4-6 opções principais
  - Layout responsivo
  - Acessibilidade (tamanho mínimo de toque 44x44px)

### RF-002: Navegação entre Telas
- **Descrição:** Sistema de navegação hierárquico
- **Prioridade:** Alta
- **Critérios:**
  - NavigationPage com botão voltar
  - Passagem de parâmetros entre telas
  - Animação de transição

### RF-003: Tela de Perfil
- **Descrição:** Exibir e editar informações do usuário
- **Prioridade:** Média
- **Critérios:**
  - Formulário com campos validados
  - Salvar dados localmente
  - Validação de email, telefone

### RF-004: Tela de Configurações
- **Descrição:** Preferências do aplicativo
- **Prioridade:** Média
- **Critérios:**
  - Toggle switches
  - Seletores de opções
  - Persistência de configurações

### RF-005: Lista de Itens
- **Descrição:** CollectionView com listagem
- **Prioridade:** Alta
- **Critérios:**
  - Listagem scrollável
  - Pull-to-refresh
  - Busca/filtro
  - Template de itens

### RF-006: Detalhes de Item
- **Descrição:** Tela de detalhes com informações completas
- **Prioridade:** Alta
- **Critérios:**
  - Imagens
  - Texto formatado
  - Botões de ação
  - Compartilhamento

### RF-007: Captura de Imagem
- **Descrição:** Acesso à câmera/galeria
- **Prioridade:** Baixa
- **Critérios:**
  - Permissões solicitadas
  - Preview da imagem
  - Salvar no dispositivo

### RF-008: Localização
- **Descrição:** GPS e mapas
- **Prioridade:** Baixa
- **Critérios:**
  - Permissões de localização
  - Exibir coordenadas
  - Mapa com posição

### RF-009: Persistência de Dados
- **Descrição:** Banco de dados local
- **Prioridade:** Média
- **Critérios:**
  - SQLite
  - CRUD completo
  - Migrações

### RF-010: Autenticação
- **Descrição:** Login/logout
- **Prioridade:** Média
- **Critérios:**
  - Formulário de login
  - Validação
  - Sessão persistente

---

## 4. Requisitos Não-Funcionais

### RNF-001: Performance
- Tempo de resposta < 2 segundos
- 60 FPS em animações
- Inicialização < 3 segundos

### RNF-002: Usabilidade
- Interface intuitiva
- Feedback visual de ações
- Tratamento de erros amigável

### RNF-003: Compatibilidade
- iOS 14+
- Android 8.0+
- Responsividade em diferentes tamanhos de tela

### RNF-004: Acessibilidade
- Tamanho mínimo de toque: 44x44px
- Contraste adequado
- Suporte a leitores de tela
- Navegação por teclado

### RNF-005: Segurança
- Dados sensíveis criptografados
- Comunicação HTTPS
- Permissões mínimas necessárias

### RNF-006: Manutenibilidade
- Código organizado
- Comentários significativos
- Segue padrões MVVM

---

## 5. Casos de Teste

### TC-001: Abrir Aplicativo
```gherkin
Cenário: Abrir aplicativo pela primeira vez
  Dado que o aplicativo foi instalado
  Quando eu abro o aplicativo
  Então devo ver a tela principal
  E o menu deve estar visível
  E a navegação deve funcionar
```

### TC-002: Navegação entre Telas
```gherkin
Cenário: Navegar para tela de detalhes
  Dado que estou na tela principal
  Quando seleciono um item
  Então devo ver a tela de detalhes
  E o botão voltar deve estar disponível
```

### TC-003: Salvar Perfil
```gherkin
Cenário: Salvar informações de perfil válidas
  Dado que estou na tela de perfil
  Quando preencho nome, email e telefone
  E clico em salvar
  Então os dados devem ser salvos
  E devo ver mensagem de sucesso
```

### TC-004: Validação de Formulário
```gherkin
Cenário: Tentar salvar perfil com email inválido
  Dado que estou na tela de perfil
  Quando preencho nome com email inválido
  E clico em salvar
  Então devo ver mensagem de erro
  E os dados não devem ser salvos
```

### TC-005: Busca em Lista
```gherkin
Cenário: Buscar item específico
  Dado que estou na tela de lista
  Quando digito "teste" na busca
  Então devo ver apenas itens com "teste"
  E a lista deve ser atualizada em tempo real
```

### TC-006: Pull-to-Refresh
```gherkin
Cenário: Atualizar lista com pull-to-refresh
  Dado que estou na tela de lista
  Quando arrasto a lista para baixo
  E solto
  Então a lista deve ser atualizada
  E um indicador de loading deve aparecer
```

### TC-007: Capturar Foto
```gherkin
Cenário: Tirar foto com câmera
  Dado que estou na tela de perfil
  Quando clico no botão de câmera
  E seleciono "Tirar foto"
  E concedo permissão
  E tiro uma foto
  Então a foto deve ser exibida
  E deve ser salva no dispositivo
```

### TC-008: Persistência Local
```gherkin
Cenário: Dados devem persistir após fechar app
  Dado que salvei informações de perfil
  Quando fecho e abro o aplicativo
  Então as informações devem estar disponíveis
```

### TC-009: Configurações
```gherkin
Cenário: Alterar configurações do app
  Dado que estou na tela de configurações
  Quando altero uma configuração
  E volto para a tela principal
  Então a configuração deve ser aplicada
```

### TC-010: Responsividade
```gherkin
Cenário: Interface deve funcionar em diferentes telas
  Dado que estou usando um dispositivo pequeno
  Quando abro qualquer tela
  Então o conteúdo deve ser legível
  E os botões devem ser tocáveis
```

---

## 6. Test Suite Automatizado

### 6.1 Unit Tests (xUnit)
```csharp
public class MainPageViewModelTests
{
    [Fact]
    public void Title_ShouldNotBeEmpty()
    {
        // Arrange
        var viewModel = new MainPageViewModel();
        
        // Act
        var title = viewModel.Title;
        
        // Assert
        Assert.False(string.IsNullOrEmpty(title));
    }
    
    [Fact]
    public async Task NavigateToProfile_ShouldWork()
    {
        // Arrange
        var viewModel = new MainPageViewModel();
        var navigation = new MockNavigationService();
        
        // Act
        await viewModel.NavigateToProfileCommand.Execute(null);
        
        // Assert
        Assert.True(navigation.WasCalled);
    }
}
```

### 6.2 UI Tests (uitest)
```csharp
[Test]
public void VerifyMainPageElements()
{
    app.Tap(x => x.Marked("btnProfile"));
    app.WaitForElement(x => x.Marked("lblName"));
    Assert.IsTrue(app.Query(x => x.Marked("lblName")).Length > 0);
}
```

### 6.3 Integration Tests
```csharp
[Fact]
public async Task SaveProfile_ShouldPersistData()
{
    // Arrange
    var repository = new ProfileRepository();
    var profile = new Profile { Name = "Test", Email = "test@test.com" };
    
    // Act
    await repository.SaveAsync(profile);
    var result = await repository.GetAsync(profile.Id);
    
    // Assert
    Assert.Equal(profile.Name, result.Name);
}
```

---

## 7. Estrutura de Projeto

```
src/
├── App/
│   ├── App.xaml
│   ├── AppShell.xaml
│   ├── Models/
│   ├── ViewModels/
│   ├── Views/
│   │   ├── MainPage.xaml
│   │   ├── ProfilePage.xaml
│   │   ├── SettingsPage.xaml
│   │   └── ItemsPage.xaml
│   ├── Services/
│   │   ├── INavigationService.cs
│   │   ├── IDataService.cs
│   │   └── ICameraService.cs
│   └── Resources/
├── Tests/
│   ├── UnitTests/
│   ├── UITests/
│   └── IntegrationTests/
```

---

## 8. Cronograma de Implementação

### Fase 1: Estrutura Base (Semana 1)
- ✅ Criar projeto MAUI
- ✅ Configurar ambiente
- ✅ Estrutura de pastas
- ✅ Dependency Injection

### Fase 2: Telas Principais (Semanas 2-3)
- ✅ MainPage com menu
- ✅ ProfilePage com formulário
- ✅ SettingsPage com configurações
- ✅ Navegação entre telas

### Fase 3: Funcionalidades (Semanas 4-5)
- ✅ CollectionView com lista
- ✅ DetailPage
- ✅ Busca e filtros
- ✅ CRUD de dados

### Fase 4: Recursos Avançados (Semana 6)
- ✅ Câmera/Galeria
- ✅ GPS/Mapas
- ✅ Persistência local
- ✅ Autenticação

### Fase 5: Testes e Polimento (Semana 7)
- ✅ Testes unitários
- ✅ Testes de UI
- ✅ Performance
- ✅ Acessibilidade

### Fase 6: Deploy (Semana 8)
- ✅ Build para iOS
- ✅ Build para Android
- ✅ Publicação nas lojas

---

## 9. Critérios de Aceitação

### CA-001: Usabilidade
- [ ] Interface intuitiva
- [ ] Feedback visual claro
- [ ] Navegação fluida
- [ ] Sem crashes ou freezes

### CA-002: Funcionalidade
- [ ] Todos os RFs implementados
- [ ] Testes passando
- [ ] Sem bugs críticos

### CA-003: Performance
- [ ] Tempo de resposta aceitável
- [ ] 60 FPS em animações
- [ ] Uso de memória otimizado

### CA-004: Compatibilidade
- [ ] Funciona em iOS e Android
- [ ] Responsivo em diferentes telas
- [ ] Versões mínimas suportadas

### CA-005: Qualidade de Código
- [ ] Código limpo e organizado
- [ ] Segue padrões MVVM
- [ ] Comentários apropriados
- [ ] Sem code smells

---

## 10. Matriz de Riscos

| Risco | Probabilidade | Impacto | Mitigação |
|-------|---------------|---------|-----------|
| Incompatibilidade iOS | Média | Alto | Testar em dispositivo físico |
| Problemas de performance | Média | Médio | Otimizar desde o início |
| Mudança de requisitos | Alta | Médio | Arquitetura flexível |
| Dificuldade com testes | Média | Baixo | Começar testes cedo |
| Problemas de deploy | Baixa | Alto | Documentar processo |

---

## 11. Definição de Pronto

Uma funcionalidade está **pronta** quando:

1. **Código:** Implementado e seguindo padrões
2. **Testes:** Unitários e de UI passando
3. **Revisão:** Code review completada
4. **Documentação:** Atualizada
5. **Performance:** Dentro dos limites aceitáveis
6. **Compatibilidade:** Testada em iOS e Android
7. **Acessibilidade:** Verificada
8. **Integração:** Funcionando com outras features

---

**Status do Projeto:** Em andamento  
**Próxima Entrega:** Protótipo de interfaces (Aula de hoje)  
**Progresso Geral:** 12.5% (1 de 8 fases)

---

*Este spec será atualizado conforme o progresso do curso e feedback do professor.*
