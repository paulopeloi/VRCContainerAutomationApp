# Relatório do Projeto: VRCContainerAutomationApp

## 🌟 Objetivo do Projeto

O projeto **VRCContainerAutomationApp** foi desenvolvido como parte de um desafio técnico com o objetivo de simular um sistema de automação industrial para controle de armazenamento de containers.

A aplicação permite:

- Cadastro de novos containers
- Armazenamento em locais válidos
- Geração de UUID automática e imutável
- Troca de localização com validações
- Despacho de containers
- Consulta de histórico de movimentações (logs)

Tudo isso com uma interface amigável feita em **WinForms**, conectada a um banco de dados **SQLite**.

---

## 📈 Funcionalidades Entregues

- Cadastro de containers com validações de peso, altura e tipo
- Algoritmo para seleção automática de localização válida
- Geração de UUID automática com `Guid.NewGuid()`
- Registro de logs para toda operação executada
- Listagem dos containers com informações completas
- Função de despacho que atualiza o status e o local
- Tela dedicada para troca de localização
- Exibição de histórico completo de movimentações do container

---

## 📄 Estrutura do Projeto

```bash
/VRCContainerAutomationApp
|│
|├── src/
|   ├── Controllers/         # Regras e tratamento de entrada
|   ├── Database/            # Conexão e serviço de acesso SQLite
|   ├── Mappers/             # Conversão de dados do DB para Model
|   ├── Models/              # Models para estrutura de dados
|   ├── Pages/               # Forms (WinForms) da aplicação
|   ├── Services/            # Regras de negócio, queries, transações
|   ├── SQLs/                # Arquivos SQL reutilizáveis
|   └── Utils/               # Gerador de UUID com Guid.NewGuid()
|
└── Resources/               # Imagens e ícones usados nos forms
```

---

## 💡 Lógica Importante no Código

### 🔎 Geração de UUID

A aplicação utiliza `Guid.NewGuid().ToString()` para gerar um identificador único para cada container. Esse UUID é criado automaticamente ao clicar no botão correspondente no formulário, sendo imediatamente atribuído ao campo e desabilitando o botão para impedir modificações manuais.

Além disso, para reforçar a integridade e garantir a **unicidade absoluta** do identificador mesmo em cenários extremos, o campo `uuid` da tabela `containers` é definido como `UNIQUE` no banco de dados SQLite:

```sql
uuid TEXT UNIQUE NOT NULL
```

Essa abordagem em dupla camada (software + banco) assegura que nenhum UUID duplicado seja inserido, oferecendo confiabilidade total na identificação dos containers.

### 🚩 Definição de Localização Válida

A aplicação realiza uma busca em `warehouse_locations` considerando:

- Tipo de container
- Peso máximo permitido
- Altura máxima permitida
- Capacidade de armazenamento

Se houver local disponível, é apresentado para confirmação do usuário.

### 🌐 Logs de Operações

Cada operação (cadastro, troca de local, despacho) é registrada em `containers_logs` com:

- ID e UUID do container
- Local antigo e novo (se aplicável)
- Tipo de operação executada (status)
- Data/hora da ocorrência

### 🚀 Transações Seguras

Todas as operações que envolvem múltiplas ações são feitas via `ExecuteTransaction`, garantindo atomicidade com `BEGIN`, `COMMIT` e `ROLLBACK`.

---

## ⚖️ Tecnologias Utilizadas

- **C#** com **.NET 8.0**
- **WinForms** para interface gráfica
- **SQLite** como banco de dados local
- **Microsoft.Data.Sqlite** para acesso aos dados
- **Debug.WriteLine** para logs internos

---

## 🧱 Diagrama de Arquitetura

Abaixo está o fluxo de chamadas e responsabilidades no projeto:

![Diagrama da Arquitetura](https://github.com/paulopeloi/VRCContainerAutomationApp/blob/main/VRCContainerAutomationApp/docs/diagrama-arquitetura.png)

---

## 🏆 Considerações Finais

O projeto foi desenvolvido com foco em organização, boas práticas e manutenção fácil do código. A ideia foi simular ao máximo uma aplicação real de automação industrial com rastreabilidade total dos containers.

