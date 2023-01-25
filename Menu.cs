﻿using System;
namespace studia_programowanie_obietkowe_zaliczenie
{
	public class Menu
	{
        public List<Danie> Dania { get; set; }

        public List<Danie> WyszukajPoNazwie(string nazwa)
        {
            // Kod do wyszukania dań po nazwie
        }

        public List<Kategoria> Kategorie { get; set; }
        public void DodajKategorie(Kategoria kategoria)
        {
            Kategorie.Add(kategoria);
        }
        public void UsunKategorie(Kategoria kategoria)
        {
            Kategoria.Remove(kategoria);
        }
        public List<Kategoria>
            WyswietlKategorie()
        {
            return Kategorie;
        }
}

