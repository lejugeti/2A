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

public class Soin
{
	public virtual object type
	{
		get;
		set;
	}

	public virtual object date
	{
		get;
		set;
	}

	public virtual IEnumerable<Personnel> Soigneur
	{
		get;
		set;
	}

}

