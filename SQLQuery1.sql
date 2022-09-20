create database ASTN
go
use ASTN
go
create table Voyage  (
code_voyage int primary key ,
dh_depart_voyage date ,
dh_arrivee_voyage date ,
places int ,
compteur_depart int ,
compteur_arrivee int ,
matricule int foreign key references Personnel (Matricule),
code_car int foreign key references Autocar (code_car) ,
code_calendrier int foreign key references Calendrier (code_calendrier)

)
create table Personnel  (
Matricule int primary key ,
Nom varchar(30) ,
Prenom varchar(30) ,
Telephone int ,
Passe varchar(30) 


)
create table Autocar  (
code_car int primary key ,
capacite int ,
date_achat date ,
consomation float ,
nom_marque varchar(30) foreign key references Marque(nom_marque)


)
create table Calendrier  (
code_calendrier int primary key ,
jour_voyage int ,
heure_depart date ,
heure_arrivee date ,
code_ligne int foreign key references Ligne (code_ligne)


)
create table Ligne  (
code_ligne int primary key ,
distance int, 
code_ville_depart int foreign key references Ville (code_ville) ,
code_ville_arrivee int  foreign key references Ville (code_ville)

)
create table Ville  (
code_ville int primary key ,
nom_ville varchar(30) 
 

)
create table Marque  (
nom_marque varchar(30) primary key  ,
)