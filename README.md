# Midrem: Guia de Primeiros Socorros e Remédios

> **Aviso Importante:** Este projeto é um guia de referência e foi desenvolvido para fins educacionais e de portfólio. As informações contidas aqui **não substituem** o aconselhamento, diagnóstico ou tratamento médico profissional. Em caso de emergência médica, ligue para o serviço de emergência local (192 no Brasil) ou procure um médico imediatamente.

## Sobre o Projeto

O Midrem é uma aplicação desktop/mobile desenvolvida em C# como um guia rápido e de fácil acesso para procedimentos de primeiros socorros e informações sobre medicamentos comuns. O objetivo é fornecer orientação clara e concisa para situações cotidianas e de emergência leve.

## Funcionalidades Principais

### Guia de Primeiros Socorros
* **Busca Rápida:** Pesquise por situações de emergência (ex: "Queimadura", "Engasgo", "Corte").
* **Instruções Passo a Passo:** Procedimentos claros e diretos para cada situação.
* **Categorias:** Navegação por categorias como acidentes domésticos, mal-estar, etc.

### Guia de Remédios
* **Catálogo de Medicamentos:** Lista de medicamentos de venda livre com suas principais indicações.
* **Consulta por Sintoma:** Sugestões de medicamentos com base em sintomas comuns (ex: "Dor de cabeça", "Febre").
* **Informações Relevantes:** Detalhes como posologia genérica e principais contraindicações (com base em informações públicas de bulas).

## Pilha de Tecnologias

* **Linguagem:** C#

## Como Compilar e Executar

**Pré-requisitos:**
* [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
* [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/vs/) ou outra IDE compatível.

**Passos:**

1.  Clone o repositório:
    ```bash
    git clone https://github.com/Olikeira/Midrem.git
    ```
2.  Abra o arquivo da solução (`Midrem.sln`) no Visual Studio.

3.  O Visual Studio irá restaurar automaticamente os pacotes NuGet necessários. Caso não ocorra, clique com o botão direito na solução no "Gerenciador de Soluções" e selecione "Restaurar Pacotes NuGet".

4.  Compile a solução (Build > Build Solution ou `Ctrl+Shift+B`).

5.  Inicie o projeto (Debug > Start Debugging ou `F5`).

## Estrutura do Projeto (Sugestão)

Uma estrutura bem definida demonstra organização e boas práticas de desenvolvimento.

```
.
├── Midrem.Core/              # Contém os modelos de dados (ex: Remedio, Procedimento) e a lógica de negócio.
├── Midrem.DataAccess/        # Responsável pela comunicação com o banco de dados (SQLite, etc.).
├── Midrem.UI/                # O projeto principal da interface do usuário (WPF, MAUI, etc.).
└── Midrem.sln                # Arquivo da solução para o Visual Studio.
```

## Autor

**[Seu Nome Completo]**

* **LinkedIn:** `https://www.linkedin.com/in/lucas-de-oliveira-pereira-741936272/`
* **GitHub:** `https://github.com/Olikeira/`
