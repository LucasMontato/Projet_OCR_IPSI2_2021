using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Runtime.InteropServices;
using System.Drawing;

namespace seuilAuto
{
    class CImageCouleur
    {
        // on crée une classe C# avec pointeur sur l'objet C++
        // puis des static extern exportées de chaque méthode utile de la classe C++
        public IntPtr ClPtr;

        public CImageCouleur()
        {
            ClPtr = IntPtr.Zero;
        }

        ~CImageCouleur()
        {
            if (ClPtr != IntPtr.Zero)
                ClPtr = IntPtr.Zero;
        }

        // va-et-vient avec constructeur C#/C++
        // obligatoire dans toute nouvelle classe propre à l'application

        [DllImport("libImage.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CImageNdg(string name); //Classe ImageNdg

        public IntPtr ClImageNdg(string name)
        {
            return CImageNdg(name);
        }

        [DllImport("libImage.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr seuillage(string methode, int seuilBas, int seuilHaut); //Classe ImageNdg

        public IntPtr Seuillage(string methode, int seuilBas, int seuilHaut)
        {
            return seuillage(methode, seuilBas, seuilHaut);
        }
    }
}
