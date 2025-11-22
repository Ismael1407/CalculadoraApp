## 💻 README: Calculadora WinForms 🔢

### 📝 Visão Geral do Projeto

Este projeto consiste em uma **Calculadora funcional** desenvolvida utilizando **C\#** e a *framework* **Windows Forms (WinForms)**. O objetivo principal é fornecer uma interface gráfica de usuário (GUI) intuitiva para operações matemáticas básicas, além de incluir funcionalidades avançadas como **histórico de cálculos** e **estilização moderna (Dark Mode)**.

### ✨ Funcionalidades

  * **Operações Básicas:** Soma (`+`), Subtração (`-`), Multiplicação (`*`), Divisão (`/`).
  * **Operações Avançadas:** Porcentagem (`%`) e Raiz Quadrada (`√`).
  * **Controle de Entrada:** Manipulação de novos números e concatenação correta de dígitos.
  * **Limpeza:** Limpar a entrada atual (`C`) e Limpar Tudo (`CE`, incluindo o histórico interno).
  * **Histórico (H):** Armazenamento e visualização de todas as operações realizadas em uma janela separada (`FormHistorico`).
  * **Estilo Profissional:** Interface de usuário com **Dark Mode** e efeitos *hover* nos botões.

### ⚙️ Estrutura do Projeto

O projeto é dividido em dois *namespaces* principais para garantir a separação de responsabilidades:

| Namespace | Classe(s) Principal(is) | Responsabilidade |
| :--- | :--- | :--- |
| `AppCalc` | `Form1` e `FormHistorico` | **Interface do Usuário (UI):** Gerencia a interação do usuário (cliques de botão) e a exibição de resultados. |
| `Calculadora` | `Calculator` | **Lógica de Negócio:** Contém os métodos para realizar cálculos e gerencia o histórico das operações. |

-----

### 🚀 Como Executar o Projeto

#### Requisitos

  * **Visual Studio** (Recomendado)
  * **.NET Framework** ou **.NET (Core)**, dependendo da versão do WinForms utilizada.

#### Passos para a Execução

1.  **Clone o Repositório:**
    ```bash
    git clone [https://github.com/Ismael1407/CalculadoraApp]
    ```
2.  **Abra no Visual Studio:**
      * Navegue até o diretório do projeto e abra o arquivo da solução (`.sln`).
3.  **Restaurar Pacotes:**
      * O Visual Studio deve restaurar automaticamente os pacotes NuGet. Caso contrário, execute:
        ```bash
        dotnet restore
        ```
4.  **Compilar e Iniciar:**
      * Pressione **F5** ou clique em **"Iniciar"** no Visual Studio para construir e executar a aplicação.

-----

### 🎨 Estilização da UI

A calculadora utiliza uma paleta de cores escura para uma experiência de usuário mais agradável:

  * **Fundo do Formulário:** `#1E1E1E` (RGB: 30, 30, 30)
  * **Display de Entrada:** Fundo `#323232` (RGB: 50, 50, 50), Texto **Branco**.
  * **Botões Numéricos:** Fundo `#3C3C3C` (RGB: 60, 60, 60).
  * **Botão Igual (`=`):** Destaque em `#007ACC` (Azul, padrão de UI).

-----

### 🤝 Contribuições

Contribuições são bem-vindas\! Sinta-se à vontade para abrir um *Pull Request* para melhorias ou correções.

-----

### 🧑‍💻 Autor

  * **Ismael OLiveira**

-----

### 📜 Licença

Este projeto está licenciado sob a Licença **MIT**.

-----

## 📥 Download

### 🚀 Versão Portátil
[⬇️ Baixar Calculator-Completa.zip](https://drive.google.com/file/d/1YpUdv8L9NiYSrOiDfMMyhB1UVBbucTQN/view?usp=drive_link)

**Tamanho:** ~57,9MB (app completo independente)

### 🖥️ Como Usar
1. Baixe o ZIP
2. Extraia em qualquer pasta  
3. Execute `CalculadoraWinForms.exe`
4. Pronto! 🎉

### ⚡ Requisitos
- Windows 10/11 64-bit
- 100MB espaço livre
