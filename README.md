# Projeto Consultar CEP App 📱

![Badge](https://img.shields.io/badge/React_Native-20232A?style=for-the-badge&logo=react&logoColor=61DAFB)
![Badge](https://img.shields.io/badge/Expo-000000?style=for-the-badge&logo=expo&logoColor=white)
![Badge](https://img.shields.io/badge/Status-Conclu%C3%ADdo-green?style=for-the-badge)

Aplicativo mobile desenvolvido em **React Native / Expo** para busca e consulta detalhada de endereços no Brasil em tempo real.

---

## 🛠️ Tecnologias Utilizadas

* **Framework:** [React Native](https://reactnative.dev/) / [Expo](https://expo.dev/)
* **Linguagem:** JavaScript / TypeScript
* **Consumo de API:** [ViaCEP](https://viacep.com.br/) via Axios/Fetch API
* **Armazenamento Local:** `@react-native-async-storage/async-storage`

---

## 🏗️ Funcionalidades do App

* **Busca Rápida:** Digitação e validação de CEP em tempo real.
* **Detalhamento de Endereço:** Exibição de rua, bairro, cidade, UF e DDD.
* **Histórico:** Salvamento das últimas consultas diretamente no dispositivo.

---

## 🚀 Como Executar

### Pré-requisitos
* [Node.js](https://nodejs.org/) instalado.
* Aplicativo **Expo Go** instalado no seu celular (Android ou iOS).

### Passo a Passo

```bash
# Clone o repositório
git clone [https://github.com/KaickFlauzin08/ConsultarCepApp-MOBILE.git](https://github.com/KaickFlauzin08/ConsultarCepApp-MOBILE.git)

# Acesse a pasta do projeto
cd ConsultarCepApp-MOBILE

# Instale as dependências
npm install

# Inicie o servidor do Expo
npx expo start
