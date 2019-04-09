using System;
namespace SP_FootballManager
{
    public class GetStaffCommand : RequestCommand<Staff_Members>
    {
        public GetStaffCommand()
        {
        }

        public override Staff_Members execute()
        {
            IStaff staff = new Staff_Members();

            IStaff director = new Staff();
            director.type = Staff_Type.Director;

            IStaff manager = new Staff_Members();
            manager.type = Staff_Type.Manager;

            IStaff medicManager = new Staff_Members();
            medicManager.type = Staff_Type.Manager;

            IStaff subordonate1 = new Staff_Subordonate();
            IStaff subordonate2 = new Staff_Subordonate();
            IStaff subordonate3 = new Staff_Subordonate();
            IStaff subordonate4 = new Staff_Subordonate();
            IStaff subordonate5 = new Staff_Subordonate();

            subordonate1.type = Staff_Type.Medic;
            subordonate2.type = Staff_Type.Medic;

            subordonate3.type = Staff_Type.FitnesTrainer;
            subordonate4.type = Staff_Type.Trainer;
            subordonate5.type = Staff_Type.FitnesTrainer;

            medicManager.Add(subordonate1);
            medicManager.Add(subordonate2);

            manager.Add(subordonate3);
            manager.Add(subordonate4);
            manager.Add(subordonate5);

            director.Add(manager);
            director.Add(medicManager);

            staff.Add(director);

            return (Staff_Members)staff;
        }
    }
}
