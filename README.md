# PrevFácil Benefícios - Portal do Associado

O **PrevFácil Benefícios** é um laboratório prático de um portal focado no ecossistema de previdência complementar e seguros. O objetivo principal do projeto é aplicar conceitos de arquitetura limpa e desacoplamento de regras de negócio em sistemas web tradicionais utilizando a plataforma .NET.

A aplicação simula o painel principal de um associado, permitindo a visualização de dados contratuais e a realização de projeções financeiras por meio de um simulador de previdência.

---

## 🚀 Funcionalidades

- **Painel do Associado:** Exibição dinâmica de dados de planos de pecúlio, histórico de cotas e saldo total acumulado.
- **Simulador de Previdência:** Mecanismo de projeção financeira baseado em tempo de contribuição e aportes mensais, utilizando cálculos de juros compostos capitalizados.
- **Master Pages & Layout Responsivo:** Interface estruturada com uma identidade visual limpa e adaptável a dispositivos móveis através do Bootstrap.

---

## 📐 Arquitetura e Boas Práticas

O projeto foi desenhado seguindo princípios de **Separação de Responsabilidades (SoC)**. Mesmo utilizando o modelo tradicional do ASP.NET Web Forms, o núcleo de processamento financeiro foi completamente isolado da camada de apresentação.

- **Camada de Apresentação (`Web Forms`):** Responsável estritamente pela captura de inputs do usuário, gerenciamento do ciclo de vida da página web (`IsPostBack`), controle de estado HTTP e renderização dos componentes de servidor.
- **Camada de Negócio (`Business`):** Classes C# puras (POCO) isoladas de qualquer dependência web ou de infraestrutura, encapsulando as regras de cálculo e modelos de domínio do sistema. Isso garante maior testabilidade e facilidade de manutenção.

---

## 🛠️ Tecnologias Utilizadas

- **Backend:** .NET Framework 4.8 / C#
- **Frontend:** ASP.NET Web Forms (Server Controls)
- **Estilização:** Bootstrap 5 & CSS3
- **Gerenciamento de Scripts:** ScriptManager / Bundling and Minification

---

## 💻 Como Executar o Projeto

### Pré-requisitos
- Visual Studio 2022 (ou superior) com a carga de trabalho de **Desenvolvimento Web e ASP.NET** instalada.
- .NET Framework 4.8 SDK.

### Passo a Passo
1. Clone este repositório para a sua máquina local:
   ```bash
   git clone [https://github.com/SEU_USUARIO/prevfacil-webforms.git](https://github.com/SEU_USUARIO/prevfacil-webforms.git)