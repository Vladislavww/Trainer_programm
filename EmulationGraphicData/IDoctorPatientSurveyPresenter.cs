﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace EmulationGraphicData
{
    public interface IDoctorPatientSurveyPresenter
    {
        void addDotToChart(double x, double y, int chartNum);
    }
}
