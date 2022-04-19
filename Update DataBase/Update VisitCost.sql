update ClinicDays set movedb.dbo.clinicdays.VisitCost = Clinic.dbo.VisitsTypes.Amount
from movedb.dbo.ClinicDays inner join Clinic.dbo.VisitsTypes
on movedb.dbo.ClinicDays.VisitType=clinic.dbo.VisitsTypes.num