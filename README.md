# Projeto Consultar CEP App 📱

![Badge](https://img.shields.io/badge/.NET_MAUI-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Badge](https://img.shields.io/badge/Visual_Studio_2022-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white)
![Badge](https://img.shields.io/badge/Status-Conclu%C3%ADdo-green?style=for-the-badge)

Aplicativo mobile desenvolvido em **.NET MAUI** no Visual Studio 2022 para busca e consulta detalhada de endereços no Brasil em tempo real.

---

## 🛠️ Tecnologias Utilizadas

* **Framework:** [.NET MAUI](https://learn.microsoft.com/dotnet/maui/)
* **Linguagem:** C# / XAML
* **IDE:** [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (com workload .NET MAUI)
* **Consumo de API:** [ViaCEP](https://viacep.com.br/) via `HttpClient` / `System.Text.Json`
* **Arquitetura:** MVVM (Model-View-ViewModel)

---

## 🏗️ Funcionalidades do App

* **Busca Rápida:** Digitação e validação de CEP em tempo real.
* **Detalhamento de Endereço:** Exibição de rua, bairro, cidade, UF e DDD.
* **Histórico:** Salvamento local das últimas consultas diretamente no dispositivo.

---

## 🚀 Como Executar

### Pré-requisitos
* [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) instalado com a carga de trabalho (workload) **Desenvolvimento com .NET MAUI**.
* Emulador Android/iOS configurado ou um dispositivo físico conectado via Depuração USB.

### Passo a Passo

```bash
# Clone o repositório
git clone [https://github.com/KaickFlauzin08/ConsultarCepApp-MOBILE.git](https://github.com/KaickFlauzin08/ConsultarCepApp-MOBILE.git)
