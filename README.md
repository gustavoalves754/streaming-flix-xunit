# StreamingFlix

Projeto desenvolvido para a disciplina de **Garantia da Qualidade de Software**, utilizando **.NET 10**, **C#** e **xUnit**.

O projeto tem como objetivo implementar e testar regras de negócio relacionadas a um serviço de streaming, utilizando **testes unitários parametrizados** para validar diferentes cenários.

## 📋 Visão Geral

O StreamingFlix possui regras de negócio relacionadas aos planos de streaming:

* Classificação do plano de acordo com a quantidade de telas simultâneas;
* Cálculo da mensalidade com desconto de acordo com o período contratado;
* Verificação de acesso a conteúdo adulto considerando a idade do usuário e o controle parental.

Os testes automatizados são desenvolvidos utilizando o framework **xUnit**, com `[Theory]` e `[InlineData]` para testar diferentes entradas e resultados esperados.

---

## 🛠️ Tecnologias Utilizadas

* **.NET 10**
* **C#**
* **xUnit**
* **Git**
* **GitHub**

### Requisitos

Para executar o projeto, é necessário possuir instalado:

* .NET SDK 10.0 ou superior;
* Git;
* IDE ou editor compatível com C#, como Visual Studio ou Visual Studio Code.

Para verificar a versão do .NET instalada:

```bash
dotnet --version
```

---

## 📁 Estrutura do Projeto

```text
StreamingFlix
│
├── StreamingFlix.App
│   └── Aplicação e regras de negócio
│
├── StreamingFlix.Tests
│   └── Testes unitários com xUnit
│
├── StreamingFlix.slnx
└── README.md
```

---

## 🚀 Como Clonar o Projeto

Clone o repositório utilizando o Git:

```bash
git clone https://github.com/gustavoalves754/streaming-flix-xunit.git
```

Depois, acesse a pasta do projeto:

```bash
cd streaming-flix-xunit
```

---

## 📦 Restaurando as Dependências

Para restaurar as dependências do projeto, execute:

```bash
dotnet restore
```

---

## 🔨 Compilando o Projeto

Para verificar se o projeto pode ser compilado corretamente:

```bash
dotnet build
```

---

## ▶️ Executando a Aplicação

Para executar o projeto principal:

```bash
dotnet run --project StreamingFlix.App
```

---

## 🧪 Executando os Testes

Os testes automatizados estão localizados no projeto:

```text
StreamingFlix.Tests
```

Para executar todos os testes, utilize:

```bash
dotnet test
```

O comando executará os testes automatizados e apresentará no terminal a quantidade de testes executados, aprovados ou que apresentaram falha.

---

## 📊 Cobertura dos Testes Parametrizados

Os testes utilizam **`[Theory]`** e **`[InlineData]`** do xUnit.

O uso de testes parametrizados permite testar uma mesma regra de negócio com diferentes valores de entrada, evitando a criação de vários métodos de teste para cada cenário.

### 1. Classificação por quantidade de telas

São utilizados os seguintes cenários:

| Telas simultâneas | Resultado esperado |
| ----------------: | ------------------ |
|                 1 | BÁSICO             |
|                 2 | PADRÃO             |
|                 4 | PREMIUM            |

Esses testes verificam se a classificação do plano está correta de acordo com a quantidade de telas simultâneas.

### 2. Cálculo da mensalidade com desconto

São utilizados os seguintes cenários:

| Valor base | Meses contratados | Valor esperado |
| ---------: | ----------------: | -------------: |
|      R$ 50 |                 1 |          R$ 50 |
|      R$ 50 |                 6 |          R$ 45 |
|      R$ 50 |                12 |          R$ 40 |

Esses testes verificam a aplicação dos descontos conforme o período contratado.

### 3. Acesso a conteúdo adulto

São utilizados os seguintes cenários:

| Idade | Controle parental | Resultado esperado |
| ----: | ----------------- | ------------------ |
|    20 | Desativado        | `true`             |
|    20 | Ativado           | `false`            |
|    16 | Desativado        | `false`            |

Esses testes verificam se o acesso ao conteúdo adulto é permitido de acordo com a idade do usuário e o estado do controle parental.

---

## 🔄 Versionamento

O projeto utiliza **Git** para controle de versão e **GitHub** para hospedagem do código-fonte.

### Repositório

https://github.com/gustavoalves754/streaming-flix-xunit

Para registrar alterações no projeto:

```bash
git add .
git commit -m "descrição da alteração"
git push
```

O uso de commits permite acompanhar a evolução do projeto e as alterações realizadas durante o desenvolvimento.

---

## 📄 Licença

Este projeto utiliza a **Licença MIT**.

Para consultar os termos completos da licença, veja o arquivo:

```text
LICENSE
```

---

## 🎓 Informações Acadêmicas

**Disciplina:** Garantia da Qualidade de Software

**Projeto:** StreamingFlix

**Framework de testes:** xUnit

**Framework:** .NET 10

**Linguagem:** C#
