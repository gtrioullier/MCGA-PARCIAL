using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Entities
{
    public enum Years
    {
        [Display(Name="2010")]
        a,
        [Display(Name = "2011")]
        b,
        [Display(Name = "2012")]
        c,
        [Display(Name = "2013")]
        d,
        [Display(Name = "2014")]
        e,
        [Display(Name = "2015")]
        f,
        [Display(Name = "2016")]
        g,
        [Display(Name = "2017")]
        h
    };

}
