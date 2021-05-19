#pragma once

#include "ImageClasse.h"
#include "ImageNdg.h"
#include "ImageCouleur.h"
#include "ImageDouble.h"

#include <windows.h>
#include <vector>

class ClibIHM {

	///////////////////////////////////////
private:
	///////////////////////////////////////

	// data nécessaires à l'IHM donc fonction de l'application ciblée
	int						nbDataImg; // nb champs Texte de l'IHM
	std::vector<double>		dataFromImg; // champs Texte de l'IHM
	CImageNdg*				imgPt;       //nous n'avons que des img ndg
	//int						res_alpha;	 //Resultat dans l'alphabet assamese --> use dataFromImage

	///////////////////////////////////////
public:
	///////////////////////////////////////

	// constructeurs
	_declspec(dllexport) ClibIHM(); // par défaut

	_declspec(dllexport) ClibIHM(int nbChamps, byte* data, int stride, int nbLig, int nbCol); // par image format bmp C# --> permet wrapper

	_declspec(dllexport) ~ClibIHM();

	// get et set 

	//fnct interne dll --> repris avec extern C

	_declspec(dllexport) int lireNbChamps() const {
		return nbDataImg;
	}

	_declspec(dllexport) double lireChamp(int i) const {
		return dataFromImg.at(i);
	}

	_declspec(dllexport) CImageNdg* imgData() const {
		return imgPt;
	}

};

extern "C" _declspec(dllexport) ClibIHM* objetLib()
{
	ClibIHM* pImg = new ClibIHM();
	return pImg;
}

//utile à la récupération des données : pointeur qui fait intéraction Cs avec Cpp

extern "C" _declspec(dllexport) ClibIHM* objetLibDataImg(int nbChamps, byte* data, int stride, int nbLig, int nbCol)
{
	ClibIHM* pImg = new ClibIHM(nbChamps,data,stride,nbLig,nbCol);
	return pImg;
}

extern "C" _declspec(dllexport) double valeurChamp(ClibIHM* pImg, int i)
{
	return pImg->lireChamp(i);
}

/*extern "C" _declspec(dllexport) int NbChamps(ClibIHM* pImg)
{
	return pImg->lireNbChamps();
}*/
