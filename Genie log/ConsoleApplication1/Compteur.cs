﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil
//     Les modifications apportées à ce fichier seront perdues si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Compteur
{
    double _vitesse;
	public virtual double Vitesse
	{
		get
        {
            return _vitesse;
        }

		set
        {
            if (value <= 130) _vitesse = value;
            else if (value < 0) _vitesse = 0;
            else _vitesse = 130;
        }
	}

	public virtual double Kilometrage
	{
		get;
		set;
	}

	public Compteur()
	{
        Kilometrage = 0;
        Vitesse = 0;
	}

	public virtual double GetVitesse()
	{
        return Vitesse;
	}

	public virtual void SetVitesse(double vitesse)
	{
        Vitesse = vitesse;
	}

	public virtual void SetKmParcourus(int km)
	{
        Kilometrage = km;
    }

}

