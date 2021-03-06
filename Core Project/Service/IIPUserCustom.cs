﻿using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPUserCustom
    {
        IEnumerable<IPUserCustomModel> FilterIPUserCustom();
        IPUserCustomModel FilterIPUserCustom(int id);
        void Add(IPUserCustomModel iPUserCustomModel);
    }
}
