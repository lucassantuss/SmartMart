-- HELPER PROCEDURES

-- Procedure capaz de verificar o pr�ximo Id dispon�vel da tabela
GO
create procedure spProximoId (@tabela varchar(max))
as
begin
	exec('select isnull(max(id) +1, 1) as MAIOR from ' + @tabela)
end