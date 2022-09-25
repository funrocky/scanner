using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.Generic;

namespace Scanner.Helpers
{
    public class ScanAndEditingProgress : ObservableObject
    {
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // DECLARATIONS /////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private int? _Progress;
        public int? Progress
        {
            get => _Progress;
            set => SetProperty(ref _Progress, value);
        }

        private ProgressState _State;
        public ProgressState State
        {
            get => _State;
            set => SetProperty(ref _State, value);
        }
        


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // CONSTRUCTORS / FACTORIES /////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public ScanAndEditingProgress()
        {

        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // METHODS //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    }

    public enum ProgressState
    {
        Scanning = 0,
        Processing = 1,
        AutomaticRotation = 2,
        PdfGeneration = 3,
        Saving = 4,
        Finishing = 5
    }
}