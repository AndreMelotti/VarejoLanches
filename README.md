# VarejoLanches
Projeto ASP.NET MVC

Utiliza o Entity Framework Core, uma ferramenta ORM(Object Relational Mapping) que permite trabalhar ocm dados de forma de objetos 
do dominio.
Elimina a necessidade da maior parte do codigo de acesso a dados que precisamos escrever manualmente
Ele é dividido em duas classes principais: DbContext e DbSet<T> 

DbContext: Ela representa uma seção com um banco de dados e ela fornece uma API para a comunicação
com o banco, oferendo os recursos abaixo:
- Conexão com o Database;
- Operações com dados;
- Consulta e Persistência;
- Mapeamento de dados;
- Gestão de transações.

DbSet<T>: Representam as tabelas do banco de dados, representam uma coleção para um entidade dentro do
modelo, ele é a porta de entrada para as operações de bancos de dados na entidade:
- Coleção para entidade do modelo;
- Coleções na memoria;
- Para persistir usar SaveChanges().