# ClinicaDocMais 1.0 🏥

O **ClinicaDocMais** é uma API REST desenvolvida para otimizar a gestão de clínicas médicas. O sistema centraliza o cadastro de profissionais e pacientes, permitindo um fluxo fluido desde o registro inicial até o agendamento e monitoramento de consultas diárias.

## 🚀 Tecnologias e Especificações

* **Framework:** .NET / C#
* **Banco de Dados:** MySQL
* **ORM:** Entity Framework Core (com Migrations)
* **Documentação:** OpenAPI 3.0 (Swagger)
* **Porta Local Padrão:** 7209

## 📌 Documentação da API

A interface interativa do Swagger permite visualizar e testar todos os endpoints em tempo real. Com a aplicação rodando, acesse:
`https://localhost:7209/swagger/index.html`

---

## 🛠️ Organização dos Endpoints

### 📅 Agendamento
* `POST /Agendamento/agendarconsulta`: Realiza a marcação de consultas integrando os objetos de Médico e Paciente.

### 🩺 Consultas
* `GET /Consultas/atendidosHoje`: Retorna a relação de atendimentos concluídos na data vigente.

### 👨‍⚕️ Médicos
* `POST /Medico/cadastroMedico`: Registra um novo médico no sistema.
* `GET /Medico/listaMedicos`: Lista todos os médicos cadastrados.
* `PUT /Medico/editarMedico/{crm}`: Atualiza os dados de um médico utilizando o CRM como identificador na URL.

### 👤 Pacientes
* `POST /Paciente/cadastrarpaciente`: Registra um novo paciente.
* `GET /Paciente/listarpacientes`: Lista todos os pacientes da base.
* `GET /Paciente/buscaPaciente/{id}`: Localiza um paciente específico pelo ID/CPF.
* `PUT /Paciente/editarPaciente/{id}`: Atualiza dados cadastrais do paciente.
* `DELETE /Paciente/deletarPaciente/{id}`: Remove o registro do paciente do sistema.

---

## 🗄️ Configuração do Banco de Dados

Este projeto utiliza **MySQL** e **Entity Framework Core**. Para configurar o banco de dados:

1.  **String de Conexão:** Verifique o arquivo `appsettings.json` e ajuste a `DefaultConnection` com suas credenciais do MySQL:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Database=ClinicaDocMais;Uid=seu_usuario;Pwd=sua_senha;"
    }
    ```
    
2.  **Migrations:** Para criar as tabelas automaticamente no seu banco de dados, execute os seguintes comandos no Console do Gerenciador de Pacotes ou Terminal:
    ```bash
    # Se estiver usando o terminal (dotnet CLI)
    dotnet tool install --global dotnet-ef
    dotnet-ef migrations add nomeDaAlteraçãoNoMigrationsHistory
    dotnet-ef database update
    
    # Se estiver usando o Package Manager Console (Visual Studio)
    Update-Database
    ```

---

## 💻 Como Executar o Projeto

1.  **Pré-requisitos:** SDK do .NET e MySQL Server instalado.
2.  **Clonar o repositório:**
    ```bash
    git clone [https://github.com/seu-usuario/ClinicaDocMais.git](https://github.com/seu-usuario/ClinicaDocMais.git)
    cd ClinicaDocMais
    ```
3.  **Restaurar pacotes e dependências:**
    ```bash
    dotnet restore
    ```
4.  **Executar a aplicação:**
    ```bash
    dotnet run
    ```

---

## 📄 Licença

Este projeto está sob a licença **MIT**.

> O uso e a distribuição deste software são permitidos para fins acadêmicos ou comerciais, desde que mantidos os créditos aos desenvolvedores originais.
