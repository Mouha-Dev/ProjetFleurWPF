using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using ProjetFleurWPF.Data;
using ProjetFleurWPF.Models;


namespace ProjetFleurWPF.ViewModels
{
    public partial class FleurViewModel : BaseViewModel
    {
        private readonly AppDbContext _context;

        [ObservableProperty]
        private ObservableCollection<Fleur> fleurs = new ObservableCollection<Fleur>();

        [ObservableProperty]
        private string nom;

        [ObservableProperty]
        private double prix;

        [ObservableProperty]
        private string couleur;

        [ObservableProperty]
        private string description;

       // public ObservableCollection<Fleur> Fleurs { get; private set; }
       // public string? Nom { get; private set; }
       // public int Prix { get; private set; }
       // public string Couleur { get; private set; }
       // public string Description { get; private set; }

        public FleurViewModel()
        {
            _context = new AppDbContext();
            LoadFleurs();
        }

        private async void LoadFleurs()
        {
            var fleursList = await _context.Fleurs.ToListAsync();
            Fleurs = new ObservableCollection<Fleur>(fleursList);
        }

        [RelayCommand]
        private async Task AjouterFleur()
        {
            if (string.IsNullOrWhiteSpace(Nom) || Prix <= 0)
                return;

            var fleur = new Fleur
            {
                Nom = Nom,
                Prix = Prix,
                Couleur = Couleur,
                Description = Description
            };

            _context.Fleurs.Add(fleur);
            await _context.SaveChangesAsync();

            Fleurs.Add(fleur);

            // Réinitialiser les champs
            Nom = string.Empty;
            Prix = 0;
            Couleur = string.Empty;
            Description = string.Empty;
        }
    }
}
