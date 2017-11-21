using AccessInterfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VM_V_Interfaces;

namespace Repository
{
    public static class ConvertionsTypes
    {
        public static Group ConvertDALGroupToIGroup(DAL.Group dbGroup, Group group)
        {
            if (dbGroup != null)
            {
                group.Id = dbGroup.Id;
                group.Name = dbGroup.Name;
                return group;
            }
            return null;
        }

        public static DAL.Group ConvertIEmployeeToDALEmployee(Group group, DAL.Group dbGroup)
        {
            if (group != null)
            {
                dbGroup.Id = group.Id;
                dbGroup.Name = group.Name;
                return dbGroup;
            }
            return null;
        }

        public static DAL.Employee ConvertIEmployeeToDALEmployee(Employee employee, DAL.Employee dbEmployee)
        {
            if (employee != null)
            {

                dbEmployee.Name = employee.Name;
                dbEmployee.Address = employee.Address;
                dbEmployee.AdditionalInfo = employee.AdditionalInfo;
                dbEmployee.Phone = employee.Phone;
                dbEmployee.Email = employee.Email;
                dbEmployee.MobilePhone = employee.MobilePhone;
                dbEmployee.SotialSecurityNumber = employee.SotialSecurityNumber;
                dbEmployee.Position = employee.Position;
                dbEmployee.RegistrationDate = employee.RegistrationDate;
                dbEmployee.WorkingStatus = employee.WorkingStatus;
                return dbEmployee;
            }
            else return null;
        }
        public static bool ConvertDALEmployeeToIEmployee(DAL.Employee dbEmployee, Employee employee)
        {
            if (dbEmployee != null)
            {
                employee.Name = dbEmployee.Name;
                employee.Address = dbEmployee.Address;
                employee.AdditionalInfo = dbEmployee.AdditionalInfo;
                employee.Phone = dbEmployee.Phone;
                employee.Email = dbEmployee.Email;
                employee.MobilePhone = dbEmployee.MobilePhone;
                employee.SotialSecurityNumber = dbEmployee.SotialSecurityNumber;
                employee.Position = dbEmployee.Position;
                employee.RegistrationDate = dbEmployee.RegistrationDate;
                employee.WorkingStatus = dbEmployee.WorkingStatus;
                return true;
            }
            return false;
        }
        public static bool ConvertDALClientToIClient(DAL.Client dbClient, Client client)
        {
            if (dbClient != null)
            {
                client.Id = dbClient.Id;
                client.Name = dbClient.Name;
                client.Address = dbClient.Address;
                client.AdditionalInfo = dbClient.AdditionalInfo;
                client.Phone = dbClient.Phone;
                client.Email = dbClient.Email;
                client.MobilePhone = dbClient.MobilePhone;
                client.EmailStatus = dbClient.EmailStatus;
                client.RegistrationDate = dbClient.RegistrationDate;
                client.PassportIssuedBy = dbClient.PassportIssuedBy;
                client.PassportNumber = dbClient.PassportNumber;
                client.PassportSeria = dbClient.PassportSeria;
                client.PassprotDateOfIssue = dbClient.PassprotDateOfIssue;
                client.ResponsibilityStatus = dbClient.ResponsibilityStatus;
                client.SMSStatus = dbClient.SMSStatus;
                if(dbClient.Manager != null)
                {
                    ConvertDALEmployeeToIEmployee(dbClient.Manager, client.Employee);
                }
                if (dbClient.Group != null)
                {
                    ConvertDALGroupToIGroup(dbClient.Group, client.Group);
                }
                return true;
            }
            return false;
        }
        public static bool ConvertIClientToDALClient(Client client, DAL.Client dbClient)
        {
            if (client != null)
            {
                dbClient.Id = client.Id;
                dbClient.Name = client.Name;
                dbClient.Address = client.Address;
                dbClient.AdditionalInfo = client.AdditionalInfo;
                dbClient.Phone = client.Phone;
                dbClient.Email = client.Email;
                dbClient.MobilePhone = client.MobilePhone;
                dbClient.EmailStatus = client.EmailStatus;
                dbClient.RegistrationDate = client.RegistrationDate;
                dbClient.PassportIssuedBy = client.PassportIssuedBy;
                dbClient.PassportNumber = client.PassportNumber;
                dbClient.PassportSeria = client.PassportSeria;
                dbClient.PassprotDateOfIssue = client.PassprotDateOfIssue;
                dbClient.ResponsibilityStatus = client.ResponsibilityStatus;
                dbClient.SMSStatus = client.SMSStatus;
                return true;
            }
            return false;
        }
    }
}
