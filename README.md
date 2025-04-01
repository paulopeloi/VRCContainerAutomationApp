
# VRCContainerAutomationApp

**VRCContainerAutomationApp** é uma aplicação desenvolvida em **C# utilizando Windows Forms**, projetada para simular e gerenciar operações industriais relacionadas ao armazenamento e movimentação de containers.  
Este projeto foi criado como parte do **desafio técnico da VRC Warehouse Technologies**.

---

## ⚙️ Funcionalidades

- ✅ **Cadastro de Containers**  
  Registra novos containers com UUID, altura, peso, tipo e localização válida, **incluindo validações** para garantir consistência. Cada cadastro é registrado automaticamente no log de movimentações. 

- ✅ **Visualização de Containers**  
  Lista todos os containers cadastrados em um `DataGridView` com detalhes como tipo, status, localização e datas de operação.

- ✅ **Despacho de Container**  
  Atualiza o status para "Despachado", **registra a operação no log** e libera a vaga ocupada na localização anterior.

- ✅ **Troca de Localização**  
  Permite alterar a posição de armazenamento do container com **validações de tipo, peso e altura**, além de registrar a movimentação nos logs.

- ✅ **Histórico de Movimentações (LOG)**  
  Exibe um histórico detalhado das operações realizadas com cada container, incluindo data, status e movimentações entre locais.

---

## 🧪 Tecnologias Utilizadas

| Tecnologia               | Descrição                                |
|--------------------------|--------------------------------------------|
| 💻 C#                   | Linguagem principal (**C# 12**)             |
| 🧱 .NET (Core)          | Framework **.NET 8.0**                      |
| 🪟 Windows Forms        | Interface gráfica WinForms                 |
| 🗄️ SQLite              | Banco de dados local                       |
| 📦 `Microsoft.Data.Sqlite` | Biblioteca ADO.NET para SQLite v9.0.3  |

---

## 📁 Estrutura do Banco de Dados

A aplicação utiliza um único arquivo SQLite com as seguintes tabelas:

- `containers` – Cadastro principal dos containers
- `containers_types` – Tipos disponíveis (Químico, Alimentício, etc.)
- `containers_status` – Status do container (Armazenado, Despachado)
- `warehouse_locations` – Locais disponíveis no armazém
- `containers_logs` – Histórico de movimentações

---

## 🖥️ Requisitos para Rodar

- ✅ **Windows 7 ou superior**
- ✅ **.NET 8.0 SDK ou Runtime instalado**
- ✅ **Visual Studio 2022 ou superior (recomendado)**

---

## 🚀 Como Rodar o Projeto

1. **Clone o repositório:**
```bash
git clone https://github.com/paulopeloi/VRCContainerAutomationApp.git
```

2. **Abra a solução no Visual Studio:**
```
VRCContainerAutomationApp.sln
```

3. **Restaure os pacotes NuGet:**
- Clique com o botão direito no projeto > Restaurar Pacotes NuGet

4. **Compile e execute:**
- Pressione `F5` ou clique em "Iniciar"

---

## 📝 Licença

Projeto licenciado sob a [MIT License](LICENSE).

---

## 📄 Documentação

Leia a [documentação](./DOCUMENTATION.md) para mais detalhes.

---

## 🧠 Autor

Desenvolvido por **Paulo Ricardo Peloi** para o desafio técnico da VRC Technologies.
