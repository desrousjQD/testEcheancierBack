# Introduction 
Doit afficher un échéancier suivant les paramètres fournis.
Il faut 
 - un montant annuel en euros
 - une date de début
Puis il faut au choix
 - une date de fin et une périodicité => pour definir que tout les x mois jusqu'a la fin j'ai une échéance.
 - un nombre d'échéance voulu et une périodicité => "je veux 3 échéances de 4 mois"
 - une date de fin et un nombre d'échéance => du 01/01/2023 au 31/12/2023 je veux 4 échéances

Arguments
	- -d : Date début format iso 8601 => obligatoire
	- -f : Date fin format iso 8601
	- -p : Periodicité en mois
	- -n : Nombre d'échéance
	- -m : Montant annuel decimal =>  obligatoire
les arguments sont toujours suivis du symbol "=" suivis de leur valeurs exemple: '-d=2023-09-18'


