using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KInsurance_Repository
{
    public class Team
    {
        public string TeamName { get; set; }
        public int ID { get; set; }



         private List<Developer> _listOfTeam = new List<Developer>();
            //Create
            public void AddnewTeam(Developer Team)
             {
                _listOfTeam.Add(Team);

             }
            //Read
            public List<Developer> GetNewDeveloper()
            {
            return _listOfTeam;
            }
            //Update
            public bool UpdateExcistingDevelopers(string originalTitle, int id, string lastName, bool pluralSightAccount, string title)
             {
            // Find the Team
            Developer oldTeam = getDeveloperByTitle(originalTitle);



            // Update the Team
            if (oldTeam != null)
            {
                oldTeam.Title = title;
                oldTeam.Id = id;
                oldTeam.LastName = lastName;
                oldTeam.PluralSightAccount = pluralSightAccount;

                return true;
            }
            else
            {
                return false;
            }
            

             }
            //Delete
            public bool RemoveDeveloperFromList(string title)
            {
            Developer Team = getDeveloperByTitle(title);

                if (Team == null)
                {
                return false;
                }

            int initialCount = _listOfTeam.Count;
            _listOfTeam.Remove(Team);

            if (initialCount > _listOfTeam.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
            }
            //Helper Method
            private Developer getDeveloperByTitle(string title)
            {
            foreach (Developer Team in _listOfTeam)
            {
                if (Team.Title == title)
                {
                    return Team;
                }
                
            }
              return null;  
            }

    }
}
