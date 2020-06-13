using SampleCollectionView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCollectionView.Services
{
    public class EmployeesMockData : IDataStore<Employee>
    {
        readonly List<Employee> items;
        public EmployeesMockData()
        {
            items = new List<Employee>()
            {
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Miro",
                    LastName="Badev",
                    Email="mirobadev@gmail.com",
                    Phone="+1 800 444 4444",
                    ProfileImage="https://s3-us-west-2.amazonaws.com/s.cdpn.io/245657/1_copy.jpg",
                    Designation="Software Developer"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Martin",
                    LastName="Joseph",
                    Email="marjoseph@gmail.com",
                    Phone="+1 202 762 1401",
                    ProfileImage="https://s3-us-west-2.amazonaws.com/s.cdpn.io/245657/2_copy.jpg",
                    Designation="QA Analyst"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Tomas",
                    LastName="Kennedy",
                    Email="tomaskennedy@gmail.com",
                    Phone="+1 213 621 0002",
                    ProfileImage="https://s3-us-west-2.amazonaws.com/s.cdpn.io/245657/3_copy.jpg",
                    Designation="Technical Arhitect"
                },
                new Employee()
                {
                    UserId= Guid.NewGuid().ToString(),
                    FirstName="Enrique",
                    LastName="Sutton",
                    Email="enriquesutton@gmail.com",
                    Phone="+1 914 232 9901",
                    ProfileImage="https://s3-us-west-2.amazonaws.com/s.cdpn.io/245657/4_copy.jpg",
                    Designation="Devops Engineer"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Darnell",
                    LastName="Strickland",
                    Email="darnellstrickland@gmail.com",
                    Phone="+44 20 8759 9036",
                    ProfileImage="https://s3-us-west-2.amazonaws.com/s.cdpn.io/245657/5_copy.jpg",
                    Designation="Senior Software Engineer"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="John",
                    LastName="Martin",
                    Email="johnmartin@gmail.com",
                    Phone="+1 541 754 3010",
                    ProfileImage="https://smallthoughtsinasportsworld.files.wordpress.com/2012/07/raymond_felton_013.jpg",
                    Designation="Project Manager"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Brayden",
                    LastName="Soul",
                    Email="braydensoul@gmail.com",
                    Phone="+1 541 754 3010",
                    ProfileImage="https://s3.amazonaws.com/uifaces/faces/twitter/adhamdannaway/128.jpg",
                    Designation="Scrum Master"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Emma",
                    LastName="Swan",
                    Email="emmaswan@gmail.com",
                    Phone="+1-202-555-0183",
                    ProfileImage="https://a.wattpad.com/cover/4106257-368-k161010.jpg",
                    Designation="Project Lead"
                },

                //Repeat
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Miro",
                    LastName="Badev",
                    Email="mirobadev@gmail.com",
                    Phone="+1 800 444 4444",
                    ProfileImage="https://s3-us-west-2.amazonaws.com/s.cdpn.io/245657/1_copy.jpg",
                    Designation="Software Developer"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Martin",
                    LastName="Joseph",
                    Email="marjoseph@gmail.com",
                    Phone="+1 202 762 1401",
                    ProfileImage="https://s3-us-west-2.amazonaws.com/s.cdpn.io/245657/2_copy.jpg",
                    Designation="QA Analyst"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Tomas",
                    LastName="Kennedy",
                    Email="tomaskennedy@gmail.com",
                    Phone="+1 213 621 0002",
                    ProfileImage="https://s3-us-west-2.amazonaws.com/s.cdpn.io/245657/3_copy.jpg",
                    Designation="Technical Arhitect"
                },
                new Employee()
                {
                    UserId= Guid.NewGuid().ToString(),
                    FirstName="Enrique",
                    LastName="Sutton",
                    Email="enriquesutton@gmail.com",
                    Phone="+1 914 232 9901",
                    ProfileImage="https://s3-us-west-2.amazonaws.com/s.cdpn.io/245657/4_copy.jpg",
                    Designation="Devops Engineer"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Darnell",
                    LastName="Strickland",
                    Email="darnellstrickland@gmail.com",
                    Phone="+44 20 8759 9036",
                    ProfileImage="https://s3-us-west-2.amazonaws.com/s.cdpn.io/245657/5_copy.jpg",
                    Designation="Senior Software Engineer"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="John",
                    LastName="Martin",
                    Email="johnmartin@gmail.com",
                    Phone="+1 541 754 3010",
                    ProfileImage="https://smallthoughtsinasportsworld.files.wordpress.com/2012/07/raymond_felton_013.jpg",
                    Designation="Project Manager"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Brayden",
                    LastName="Soul",
                    Email="braydensoul@gmail.com",
                    Phone="+1 541 754 3010",
                    ProfileImage="https://s3.amazonaws.com/uifaces/faces/twitter/adhamdannaway/128.jpg",
                    Designation="Scrum Master"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Emma",
                    LastName="Swan",
                    Email="emmaswan@gmail.com",
                    Phone="+1-202-555-0183",
                    ProfileImage="https://a.wattpad.com/cover/4106257-368-k161010.jpg",
                    Designation="Project Lead"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Miro",
                    LastName="Badev",
                    Email="mirobadev@gmail.com",
                    Phone="+1 800 444 4444",
                    ProfileImage="https://s3-us-west-2.amazonaws.com/s.cdpn.io/245657/1_copy.jpg",
                    Designation="Software Developer"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Martin",
                    LastName="Joseph",
                    Email="marjoseph@gmail.com",
                    Phone="+1 202 762 1401",
                    ProfileImage="https://s3-us-west-2.amazonaws.com/s.cdpn.io/245657/2_copy.jpg",
                    Designation="QA Analyst"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Tomas",
                    LastName="Kennedy",
                    Email="tomaskennedy@gmail.com",
                    Phone="+1 213 621 0002",
                    ProfileImage="https://s3-us-west-2.amazonaws.com/s.cdpn.io/245657/3_copy.jpg",
                    Designation="Technical Arhitect"
                },
                new Employee()
                {
                    UserId= Guid.NewGuid().ToString(),
                    FirstName="Enrique",
                    LastName="Sutton",
                    Email="enriquesutton@gmail.com",
                    Phone="+1 914 232 9901",
                    ProfileImage="https://s3-us-west-2.amazonaws.com/s.cdpn.io/245657/4_copy.jpg",
                    Designation="Devops Engineer"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Darnell",
                    LastName="Strickland",
                    Email="darnellstrickland@gmail.com",
                    Phone="+44 20 8759 9036",
                    ProfileImage="https://s3-us-west-2.amazonaws.com/s.cdpn.io/245657/5_copy.jpg",
                    Designation="Senior Software Engineer"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="John",
                    LastName="Martin",
                    Email="johnmartin@gmail.com",
                    Phone="+1 541 754 3010",
                    ProfileImage="https://smallthoughtsinasportsworld.files.wordpress.com/2012/07/raymond_felton_013.jpg",
                    Designation="Project Manager"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Brayden",
                    LastName="Soul",
                    Email="braydensoul@gmail.com",
                    Phone="+1 541 754 3010",
                    ProfileImage="https://s3.amazonaws.com/uifaces/faces/twitter/adhamdannaway/128.jpg",
                    Designation="Scrum Master"
                },
                new Employee()
                {
                    UserId=Guid.NewGuid().ToString(),
                    FirstName="Emma",
                    LastName="Swan",
                    Email="emmaswan@gmail.com",
                    Phone="+1-202-555-0183",
                    ProfileImage="https://a.wattpad.com/cover/4106257-368-k161010.jpg",
                    Designation="Project Lead"
                },
            };
        }

        public async Task<Employee> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.UserId == id));
        }

        public async Task<IEnumerable<Employee>> GetItemsAsync(bool forceRefresh = false, int lastIndex = 0)
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            int numberOfItemsPerPage = 8;
            return await Task.FromResult(items.Skip(lastIndex).Take(numberOfItemsPerPage));
        }
    }
}
