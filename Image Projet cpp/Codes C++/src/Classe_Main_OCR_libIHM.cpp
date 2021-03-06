#include <iostream>
#include <fstream>
#include <sstream>
#include <string>
#include <windows.h>
#include <cmath>
#include <vector>
#include <ctime>
#include <stack>

#include "Main_OCR_libIHM.h"

ClibIHM::ClibIHM() {

	this->nbDataImg = 0;
	this->dataFromImg.clear();
	this->imgPt = NULL;
}

//nous travaillons en image ndg

ClibIHM::ClibIHM(int nbChamps, byte* data, int stride, int nbLig, int nbCol)
{
	this->nbDataImg = nbChamps;
	this->dataFromImg.resize(nbChamps);

	this->imgPt = new CImageNdg(nbLig, nbCol);
	CImageNdg out(nbLig, nbCol);

	// on remplit les pixels 

	byte* pixPtr = (byte*)data;

	for (int y = 0; y < nbLig; y++)
	{
		for (int x = 0; x < nbCol; x++)
		{
			this->imgPt->operator()(y, x) = pixPtr[3 * x ];
		}
		pixPtr += stride; // largeur une seule ligne gestion multiple 32 bits
	}

	CImageNdg seuil;
	CImageNdg BWlabel;

	int seuilBas = 128;
	int seuilHaut = 255;

	seuil = this->imgPt->seuillage("automatique",seuilBas,seuilHaut);
	seuil = this->imgPt->morphologie("erosion", "V8");

	this->dataFromImg.at(0) = seuilBas;

	for (int i = 0; i < seuil.lireNbPixels(); i++)
	{
		out(i) = (unsigned char)(255*(int)seuil(i));
	}

	pixPtr = (byte*)data;
	for (int y = 0; y < nbLig; y++)
	{
		for (int x = 0; x < nbCol; x++)
		{
			pixPtr[3 * x] = out(y, x);
		}
		pixPtr += stride; // largeur une seule ligne gestion multiple 32 bits
	}
}

ClibIHM::~ClibIHM() {
	
	if (imgPt)
		(*this->imgPt).~CImageNdg(); 
	this->dataFromImg.clear();
}