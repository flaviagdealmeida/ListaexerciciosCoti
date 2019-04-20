create table Funcionario(
	IdFuncionario integer identity (1,1),
	Nome nvarchar(100) not null,
	Salario decimal(18,2) not null,
	DataAdmisssao date not null,
	primary key(IdFuncionario)
)