# Générateur SQL

## Description

Le **Générateur SQL** est une application Windows Forms développée en C# permettant de générer des requêtes SQL à partir de fichiers d'entrée (texte, CSV, etc.). Elle facilite la conversion de données en format SQL pour une utilisation dans une base de données.

### Fonctionnalités principales :
- Affichage et sélection de fichiers via un **OpenFileDialog**.
- Lecture et affichage du contenu des fichiers sélectionnés dans une **ListBox**.
- Conversion du contenu en une requête SQL.
- Sauvegarde de la requête générée dans un dossier spécifique.

## Prérequis

Pour utiliser l'application, vous devez disposer de :

- **.NET Framework** (Version requise : 4.7.2 ou supérieure)
- **Visual Studio** ou un autre IDE compatible avec les projets C# Windows Forms.

## Installation

### 1. Cloner le projet

Clonez le dépôt dans un répertoire local ou téléchargez le fichier ZIP du projet.

`git clone https://github.com/CorentinLartigue/GenerateurSQL_application.git`

### 2. Ouvrir avec Visual Studio

Ouvrez Visual Studio.

Allez dans File > Open > Project/Solution et sélectionnez le fichier .sln du projet.

Une fois le projet ouvert, vous pouvez le compiler et l'exécuter directement depuis l'IDE.

### 3. Dépendances
   
Le projet est développé en C# avec Windows Forms et ne nécessite aucune dépendance externe. Le framework .NET doit être installé sur votre machine.

