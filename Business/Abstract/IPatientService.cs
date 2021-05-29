using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities;

namespace Business.Abstract
{
    public interface IPatientService
    {
        IDataResult<List<Patient>> GetAll();
        IDataResult<Patient> GetById(int patientId);
        IResult Add(Patient patient);
        IResult Delete(Patient patient);
        IResult Update(Patient patient);
    }
}
