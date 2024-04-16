# Evaluation pratique
- Cette évaluation sera à faire en deux fois
- Une fois avec vos connaissances actuelles & une fois après avoir vu quelques conseils de clean code (code propre)

## Objectifs
- Vous devez faire un script php procédural qui permet de faire jouer deux joueurs au jeu du serpent (plateau)  
- Votre objectif est de réaliser le jeu en utilisant **des fonctions**
- Aucune nécessité pour de réalisé une belle interface, des affichages dans la console suffisent.
- A minima une fonction pour :
    - Réaliser le tour d'un joueur, donc lancer le dé et modifier le score (attention, cette fonction nécessitera normalement un return)
    - Afficher dans la console la position des joueurs
    - Afficher le gagnant à la fin de la partie
    - Proposer de rejouer une partie ou terminer le programme

## Fonctionnalités premières
Voici les fonctionnalités attendues par votre jeu du serpent :
-	Lancé de dé (1-6) aléatoire (voir Random.Next())
-	Jeu au tour par tour, chaque joueur lance un dé lors de son tour, un affichage dans la console doit afficher le nombre sorti par le dé et la nouvelle position du joueur
-	Déplacement des joueurs en fonction du nombre sorti par le dé (1-6)
-	Si le joueur dépasse 50, il revient automatiquement à la case 25
-	La partie se termine lorsqu’un joueur arrive à la case 50, il gagne donc la partie ! Le vainqueur est affiché et on peut relancer une partie ou terminer l'exécution du programme.

## Fonctionnalités optionnelles
-	Ajoutez des cases pièges, par exemple la 37 fait redescendre à la 12, la 14 fait revenir à la 7 et la 46 fait revenir à la case 33 (Mettez les valeurs que vous voulez)
-	Ajoutez des cases bonus, par exemple la 20 fait monter à la case 35, la 2 fait monter à la case 17 et la 31 fait monter à la 43 (Mettez les valeurs que vous voulez)

Bon courage et bons dévs à toutes et à tous !