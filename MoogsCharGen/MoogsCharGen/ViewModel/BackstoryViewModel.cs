using Engine.Backstory;
using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MoogsCharGen.ViewModel
{
    public class BackstoryViewModel : INotifyPropertyChanged
    {
        public ICommand GenerateBackstoryCommand { get; set; }

        private Backstory backstory;

        private string ideology;
        private string meaningfulLocation;
        private string significantPerson;
        private string traits;
        private string treasuredPossession;

        public string Ideology
        {
            get { return ideology; }
            set { 
                ideology = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Ideology"));
            }
        }

        public string MeaningfulLocation
        {
            get { return meaningfulLocation; }
            set
            {
                meaningfulLocation = value;
                PropertyChanged(this, new PropertyChangedEventArgs("MeaningfulLocation"));
            }
        }

        public string SignificantPerson
        {
            get { return significantPerson; }
            set
            {
                significantPerson = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SignificantPerson"));
            }
        }

        public string Traits
        {
            get { return traits; }
            set
            {
                traits = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Traits"));
            }
        }

        public string TreasuredPossessions
        {
            get { return treasuredPossession; }
            set
            {
                treasuredPossession = value;
                PropertyChanged(this, new PropertyChangedEventArgs("TreasuredPossessions"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public BackstoryViewModel()
        {
            GenerateBackstoryCommand = new Command(() => GenerateBackstory());
            backstory = new Backstory();
            this.significantPerson = backstory.SignificantPeople;
            this.treasuredPossession = backstory.TreasuredPossession;
            this.traits = backstory.Traits;
            this.meaningfulLocation = backstory.MeaningfulLocation;
            this.ideology = backstory.Ideology;
            
        }

        public void GenerateBackstory()
        {
            backstory.GenerateBackstory();
            SignificantPerson = backstory.SignificantPeople;
            TreasuredPossessions = backstory.TreasuredPossession;
            Traits = backstory.Traits;
            MeaningfulLocation = backstory.MeaningfulLocation;
            Ideology = backstory.Ideology;
        }
    }
}
