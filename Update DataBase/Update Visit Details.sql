update ClinicDays set movedb.dbo.clinicdays.VisitType = Clinic.dbo.VisitsTypes.Num
from movedb.dbo.ClinicDays inner join Clinic.dbo.VisitsTypes
on movedb.dbo.ClinicDays.visitname=clinic.dbo.VisitsTypes.VisitKind

