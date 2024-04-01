using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KartGame.KartSystems
{

    public class KeyboardInputAZES : BaseInput
    {
        public string TurnInputName = "Horizontal2"; // Utilisation des touches AZES pour le contrôle horizontal
        public string AccelerateButtonName = "Accelerate2"; // Utilisation de la touche A pour accélérer
        public string BrakeButtonName = "Brake2"; // Utilisation de la touche Z pour freiner

        public override InputData GenerateInput()
        {
            return new InputData
            {
                Accelerate = Input.GetButton(AccelerateButtonName),
                Brake = Input.GetButton(BrakeButtonName),
                TurnInput = Input.GetAxis(TurnInputName)
            };
        }
    }
}

