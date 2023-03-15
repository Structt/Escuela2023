
use Escuela2023;
go

create table Profesor(
codProfesor varchar(25) not null Primary key,
nombreProfesor varchar(20),
edadProfesor int,
);
go
create table Cursos(
idCurso int identity(1,1) not null primary key,
descripcionCurso varchar(25),
codProfesor varchar(25),
codAula varchar(20),
CONSTRAINT fk_codPro foreign key(codProfesor) references Profesor(codProfesor)
);
go
create table Cursos_Alumnos(
idCurso int not null,
legajoAlumno varchar(25) not null,
Constraint pk_idcLega Primary key(idCurso,legajoAlumno),
Constraint fk_idc foreign key(idCurso)references Cursos(idCurso),
Constraint fk_legAl foreign key(legajoAlumno)references Alumno(legajo)
);

insert into Alumno(legajo,nombre,edad,sexo)
select '01','Oscar',74,1 union
select 'l02','Mati',52,1 union
select 'l03','Sodi',14,2 
go

insert into Profesor(codProfesor,nombreProfesor,edadProfesor)
select 'pro01','Fabian',52 union
select 'pro02','Esmilda',50 union
select 'pro03','Jose',30
go

insert into Cursos(descripcionCurso,codProfesor,codAula)
select 'Fisica 1','pro02','a01' union
select 'Programacion 1','pro03','a08'

insert into Cursos_Alumnos(idCurso,legajoAlumno)
select 1,'01' union
select 1,'l02' union
select 1,'l03' union
select 1,'l02' 




select * from Alumno;

select * from Profesor

select * from Cursos

select * from Cursos_Alumnos

--Lista de los profesores

select codProfesor,nombreProfesor,edadProfesor from Profesor;

-- Mostrar solo el legajo y nombre de los alumnos
select legajo,nombre from Alumno;

--Infromacion de un determinado profesor
go

select p.codProfesor,nombreProfesor,edadProfesor,c.descripcionCurso from Profesor as p inner join Cursos as c
on p.codProfesor=c.codProfesor
where p.codProfesor='pro02';
