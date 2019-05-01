create database OPTICA
use OPTICA

create table T_pacientes(
	nombre varchar(50) not null,
	cedula varchar(10) primary key not null,
	sexo varchar(15) not null,
	telefono varchar(8) not null,
	fecha_nacimiento datetime not null,
	ocupacion varchar(40) not null,
	edad int 
)

create table T_doctores(
	id_doctor int IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(50) not null,
	sexo varchar(15) not null,
	telefono varchar(8) not null,
	direccion varchar(100) not null,
	edad int 
)


create table T_diagnosticos(
	nombre_paciente varchar(50) not null,
	numero_consulta int IDENTITY(1,1) PRIMARY KEY,
	telefono_paciente varchar(8),
	doctor_encargado varchar(50) not null,
	tipo_lente varchar(50) not null,
	fecha_examen datetime,
	fecha_proximo_examen datetime,
	estado_receta varchar(20),

	oi_SPH float,
    oi_CYL float,
    oi_EJE float,
    oi_DP float,
    oi_ADD float,
    oi_PRISMA float,
    oi_BASE float,

	od_SPH float,
    od_CYL float,
    od_EJE float,
    od_DP float,
    od_ADD float,
    od_PRISMA float,
    od_BASE float,

	altura_od float,
    altura_oi float,
	diagnostico varchar(200)
)

-- Insertar datos en T_pacientes
	create or alter proc RegistrarPacientes
                    @nombre varchar(50),
					@cedula varchar(10),
					@sexo varchar(15),
					@telefono varchar(8),
					@fecha_nacimiento datetime,
					@ocupacion varchar(40),
					@edad int

	as
	  if (select count(*) from T_pacientes
		  where cedula= @cedula) = 0
		  begin
	   Insert into T_pacientes
	   (nombre, cedula, sexo, telefono, fecha_nacimiento, ocupacion, edad)
	   values (@nombre, @cedula, @sexo, @telefono, @fecha_nacimiento, @ocupacion, @edad);
	   end
	 
	go

	--Consultar datos de tabla T_pacientes
	create proc ConsultarPacientes
		@cedula varchar(10), 
		@nombre varchar(50) output
 
	 as 
		select @nombre = nombre from T_pacientes
		where cedula =@cedula
	 go 

	-- Insertar datos en T_doctores
	create or alter proc RegistrarDoctores
					@id_doctor int,
                    @nombre varchar(50),
					@sexo varchar(15),
					@telefono varchar(8),
					@direccion varchar(100),
					@edad int

	as
	  if (select count(*) from T_doctores
		  where id_doctor= @id_doctor) = 0
		  begin
	   Insert into T_doctores
	   (nombre, sexo, telefono, direccion, edad)
	   values (@nombre, @sexo, @telefono, @direccion, @edad);
	   end
	go


	-- Insertar datos en T_diagnosticos
	create or alter proc RegistrarDiagnostico
                    @nombre_paciente varchar(50),
					@numero_consulta int,
					@telefono_paciente varchar(8),
					@doctor_encargado varchar(50),
					@tipo_lente varchar(50),
					@fecha_examen datetime,
					@fecha_proximo_examen datetime,
					@estado_receta varchar(20),

					@oi_SPH float,
					@oi_CYL float,
					@oi_EJE float,
					@oi_DP float,
					@oi_ADD float,
					@oi_PRISMA float,
					@oi_BASE float,

					@od_SPH float,
					@od_CYL float,
					@od_EJE float,
					@od_DP float,
					@od_ADD float,
					@od_PRISMA float,
					@od_BASE float,

					@altura_od float,
					@altura_oi float,
					@diagnostico varchar(200)

	as
	  if (select count(*) from T_diagnosticos
		  where numero_consulta= @numero_consulta) = 0
		  begin
	   Insert into T_diagnosticos
	   (nombre_paciente, telefono_paciente, doctor_encargado, tipo_lente,
	   fecha_examen, fecha_proximo_examen, estado_receta, oi_SPH, oi_CYL, oi_EJE,
	   oi_DP, oi_ADD, oi_PRISMA, oi_BASE, od_SPH, od_CYL, od_EJE, od_DP, od_ADD,
	   od_PRISMA, od_BASE, altura_oi, altura_od, diagnostico)
	   values (@nombre_paciente, @telefono_paciente, @doctor_encargado, @tipo_lente, @fecha_examen,
	   @fecha_proximo_examen, @estado_receta, @oi_SPH, @oi_CYL, @oi_EJE, @oi_DP, @oi_ADD, @oi_PRISMA,
	   @oi_BASE, @od_SPH, @od_CYL, @od_EJE, @od_DP, @od_ADD, @od_PRISMA, @od_BASE, @altura_oi, @altura_od,
	   @diagnostico);
	   end
	go

	--Consultar datos de tabla T_diagnosticos
	create or alter proc ConsultarDiagnosticos
	 as 
		select * from T_diagnosticos 
	 go


	
	exec ConsultarDiagnosticos

	 select * from T_pacientes;
	 select * from T_doctores;
	 select * from T_diagnosticos;

	DELETE FROM T_pacientes WHERE cedula=2;
