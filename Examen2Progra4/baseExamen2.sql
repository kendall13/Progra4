use Examen2
go

drop table dbo.consumo
go
drop table dbo.clientes
go
drop table dbo.empresa
go

create table clientes(
cedula int primary key,
nombre varchar(200) not null,
telefono int not null,
direccion varchar(200) not null,
medidior int not null,
tipoDomi bit not null
)

create table empresa(
titulo varchar(200) primary key,
costo int not null,
baseDomiciliar int not null,
baseEmpresarial int not null,
fechaCobro int not null,
fechaCorte int not null,
multa int not null
)

create table consumo(
mes int NOT NULL,
ano int NOT NULL,
consumo int NOT NULL,
pago int null,
pagado bit null,
multa bit null,
cedula int NOT NULL,
foreign key (cedula) references clientes (cedula),
CONSTRAINT PK PRIMARY KEY CLUSTERED (mes,ano,cedula)
)
go

create or alter procedure insertCliente(
@cedulaI int,
@nombreI varchar(200),
@telefonoI int,
@direccionI varchar(200),
@medidiorI int,
@tipoDomiI bit
)as
insert into clientes (cedula,nombre,telefono,direccion,medidior,tipoDomi)
values (@cedulaI,@nombreI,@telefonoI,@direccionI,@medidiorI,@tipoDomiI);
go

create or alter procedure updateEmpresa(
@tituloI varchar(200),
@costoI int,
@baseDomiciliarI int,
@baseEmpresarialI int,
@fechaCobroI int,
@fechaCorteI int,
@multaI int
)as
update empresa set costo=@costoI, baseDomiciliar=@baseDomiciliarI,
baseEmpresarial=@baseEmpresarialI, fechaCobro=@fechaCobroI,
fechaCorte=@fechaCorteI, multa=@multaI
where titulo=@tituloI
go

create or alter procedure getClientes
as
select * from clientes
go

create or alter procedure getCliente(@cedula int)
as
select * from clientes where @cedula=cedula
go

create or alter procedure getEmpresa
as
select * from empresa
go

create or alter procedure getCosumo(
@mesI int,
@anoI int,
@cedulaI int
)as
select * from consumo where @mesI=mes and @anoI=ano and @cedulaI=cedula
go

create or alter procedure getConsumoPorPagar(@cedulaI int) as
select mes,ano,consumo,cedula,dbo.verPago(mes,ano,cedula) from consumo where pagado=0 and cedula=@cedulaI
go

create or alter procedure insertConsumo(
@mesI int,
@anoI int,
@consumoI int,
@cedulaI int
)as
insert into consumo(mes, ano, consumo, pago,pagado,multa,cedula)
values(@mesI,@anoI,@consumoI,0,0,0,@cedulaI);
go

create or alter procedure checkPago(
@mesI int,
@anoI int,
@cedulaI int
)as
select dbo.verPago(@mesI,@anoI,@cedulaI);
go

create or alter procedure pagar(
@mesI int,
@anoI int,
@cedulaI int
)as
if 0<(select dbo.verPago(@mesI,@anoI,@cedulaI))
begin
	update consumo 
	set pago=(select dbo.verPago(@mesI,@anoI,@cedulaI)),pagado=1
	where @mesI=mes and @anoI=ano and @cedulaI=cedula
	declare @fecha date
	declare @fechaMulta date
	set @fecha=DATEFROMPARTS(Convert(int,Year(CURRENT_TIMESTAMP)),Convert(int,Month(CURRENT_TIMESTAMP)),Convert(int,Day(CURRENT_TIMESTAMP)))
	set @fechaMulta=DATEFROMPARTS((select ano from consumo where mes=@mesI and ano=@anoI and cedula=@cedulaI),(select mes from consumo where mes=@mesI and ano=@anoI and cedula=@cedulaI),(select fechaCobro from empresa))
	if @fecha>@fechaMulta
		update consumo set multa=1
		where @mesI=mes and @anoI=ano and @cedulaI=cedula		 
	select 1;
end
else
	select 0;
go

create or alter function verPago(
@mesI int,
@anoI int,
@cedulaI int
)
returns int 
as
begin
declare @base int
if 1=(select tipoDomi from clientes where cedula=@cedulaI)
	set @base=(select baseDomiciliar from empresa);
else
	set @base=(select baseEmpresarial from empresa);
declare @pago int
if exists (select * from consumo where mes=@mesI and ano=@anoI and cedula=@cedulaI)
begin
	declare @ano int
	set @ano= dbo.getAno()
	declare @mes int
	set @mes= dbo.getMes()
	declare @dia int
	set @dia= dbo.getDia()
	declare @fecha date
	declare @fechaMulta date
	set @fecha=DATEFROMPARTS(Convert(int,Year(CURRENT_TIMESTAMP)),Convert(int,Month(CURRENT_TIMESTAMP)),Convert(int,Day(CURRENT_TIMESTAMP)))
	set @fechaMulta=DATEFROMPARTS((select ano from consumo where mes=@mesI and ano=@anoI and cedula=@cedulaI),(select mes from consumo where mes=@mesI and ano=@anoI and cedula=@cedulaI),(select fechaCobro from empresa))

	if @fecha<=@fechaMulta
		set @pago=(select consumo from consumo where mes=@mesI and ano=@anoI and cedula=@cedulaI)
		*(select costo from empresa)+@base
	else
		set @pago=(select consumo from consumo where mes=@mesI and ano=@anoI and cedula=@cedulaI)
		*(select costo from empresa)+(select multa from empresa)+@base
end
else
	set @pago=-1
return @pago;
end
go

create or alter function getAno()
returns int
as
begin
declare @ano int
set @ano= Convert(int,YEAR(CURRENT_TIMESTAMP))
return @ano;
end
go

create or alter function getMes()
returns int
as
begin
declare @mes int
set @mes= Convert(int,Month(CURRENT_TIMESTAMP))
return @mes;
end
go

create or alter function getDia()
returns int
as
begin
declare @dia int
set @dia= Convert(int,Day(CURRENT_TIMESTAMP))
return @dia;
end
go

insert into empresa (titulo,costo,baseDomiciliar,baseEmpresarial,fechaCobro,fechaCorte,multa)
values ('ASADA',20,2500,10000,14,16,4000)

Exec updateEmpresa @tituloI='ASADA',
@costoI=25,
@baseDomiciliarI=3000,
@baseEmpresarialI=15000,
@fechaCobroI=15,
@fechaCorteI=20,
@multaI =5000
go

select * from empresa;

exec insertCliente
@cedulaI=304750949,
@nombreI='Jorge Guzman',
@telefonoI=89379744,
@direccionI='Paraiso, Cartago',
@medidiorI=1,
@tipoDomiI=1
go

select * from clientes;

exec insertConsumo
@mesI= 5,
@anoI= 2019,
@consumoI= 400,
@cedulaI= 304750949

select * from consumo;

exec getConsumoPorPagar @cedulaI= 304750949 
go

select dbo.verPago(6,2019,304750949)