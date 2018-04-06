﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awale.Models
{
    public class Player : IObserver
    {
        private string nom;
        private int id;
        private int nbVictoire;
        private int nbPartie;
        private string ip;
        private bool tourDeJeu;
        private int recolte;

        //INITILISER LES DONNEES DU JOUEUR
        public string Nom {
            get => nom;
            set {
                nom = value;
                RaisePropertyChanged("Nom");
            }
        }
        public int Id {
            get => id;
            set {
                id = value;
                RaisePropertyChanged("Id");
            }
        }
        public string Ip
        {
            get => ip;
            set => ip = value;
        }
        public int NbVictoire {
            get => nbVictoire;
            set {
                nbVictoire = value;
                RaisePropertyChanged("NbVictoire");
            }
        }

        public int NbPartie {
            get => nbPartie;
            set {
                nbPartie = value;
                RaisePropertyChanged("NbPartie");
            }
        }

        public bool TourDeJeu {
            get => tourDeJeu;
            set {
                tourDeJeu = value;
                RaisePropertyChanged("TourDeJeu");
            }
        }
        public int Recolte {
            get => recolte;
            set {
                recolte = value;
                RaisePropertyChanged("Recolte");
            }
        }

        public Player() {

        }

        public Player(string nom)
        {
            Nom = nom;
            NbPartie = 0;
            NbVictoire = 0;
        }

        public Player(string nom,bool tourDeJeu)
        {
            Nom = nom;
            TourDeJeu = tourDeJeu;
        }

        public override string ToString()
        {
            return Nom;
        }

    }
}
