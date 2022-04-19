update ClinicDays set clinicdays.PatientID=PatientsDetail.PatientNum 
from ClinicDays inner join PatientsDetail
on ClinicDays.[PATIENT NAME]=PatientsDetail.PatientName