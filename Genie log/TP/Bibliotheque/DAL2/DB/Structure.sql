drop table if exists utilisateur;
drop table if exists livre;
drop table if exists emprunt;

create table utilisateur (
    util_id integer not null primary key auto_increment,
    util_nom varchar(100) not null,
    util_prenom varchar(100) not null,
);

create table livre (
	livre_id integer not null primary key auto_increment,
	livre_auteur string not null,
	livre_titre varchar(200) not null,
	livre_isbn varchar(1000) not null,
);

create table emprunt (
	emprunt_id integer not null primary key auto_increment,
	emprunt_date date not null,
	emprunt_rendu boolean not null,
	emprunt_id_util integer not null,
	emprunt_id_livre integer not null,
	FOREIGN KEY (emprunt_id_util) REFERENCES utilisateur(util_id),
	FOREIGN KEY (emprunt_id_livre) REFERENCES livre(livre_id)
);