using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace SyncFusionChipTemplate
{
    public class ChipViewModel
    {
        public ObservableCollection<ChipModel> ChipsToShow { get; set; }

        public ChipViewModel()
        {
            ChipsToShow = new ObservableCollection<ChipModel>()
            {
                new ChipModel() {Label = "Chip1", ChipColor = Color.Red },
                new ChipModel() {Label = "Chip2", ChipColor = Color.Blue},
                new ChipModel() {Label = "Chip3", ChipColor = Color.Green },
                new ChipModel() {Label = "Chip4", ChipColor = Color.Pink }
            };
        }
    }
}
