using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Opdracht6
    {
        public Opdracht6()
        {

            /*
             * Opdracht 7.6:
               The Dutch quiz association keeps the data of the affiliated quiz teams. Each team consists of 4 members. Each member has a certain specialty, for example sports, film and music, current affairs or fauna and flora ... Create a class Member. Give the class a constructor with which you can enter the name of the member and his / her specialty. Also give the class a print () method that displays the attributes of the object "member" on the screen. Create a Team class that makes 4 Member instances. Give the class a method printAlleMembers () that displays the names of the members and their specialties.
           */

            //Ad new teams
            var team1 = new Team("Team Twente");
            var team2 = new Team("Team Gelderland");

            //Ad new Members
            var lid0 = new Member();
            var lid1 = new Member("Emre Dursun", "Online Game");
            var lid2 = new Member("Murat Bilgin", "Sport", team2);
            var lid3 = new Member("Fatih Ok", "Film");
            var lid4 = new Member("Ilker Akkaya", "Actualiteit");
            var lid5 = new Member("Erkan Ciftci", "Fishing", team2);
            var lid6 = new Member("Cevdet Balci", "Playing Footbal", team2);
            var lid7 = new Member("Emrah Akgun", "Spech", team2);

            //Ad members to team "Team Twente"
            team1.AddMember(lid1);
            team1.AddMember(lid2);
            team1.AddMember(lid3);
            team1.AddMember(lid4);

            // Write reports about team1
            Console.WriteLine(team1.GetTeams());
            Console.WriteLine(team1.GetMemberID());

            // Write reports about team2
            Console.WriteLine(team2.GetTeams());
            Console.WriteLine(team2.GetMemberID());


            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }

    public class Member
    {
        #region Fields
        public string MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberSpecialty { get; set; }

        private static int memberIdStart = 10000;
        #endregion

        #region Constructors
        // Next two constructors allow to add new members, with and without member informations!
        public Member() { }
        public Member(string memberName, string memberSpecialty)
        {
            this.MemberName = memberName;
            this.MemberSpecialty = memberSpecialty;
            this.MemberID = memberIdStart.ToString();
            memberIdStart++;
        }

        // This constructors allow to add new members, with and without team name!
        public Member(string memberName, string memberSpecialty, Team team)
        {
            this.MemberName = memberName;
            this.MemberSpecialty = memberSpecialty;
            this.MemberID = memberIdStart.ToString();
            memberIdStart++;
            team.AddMember(this); // This allows to asign a member to specific team
        }
        #endregion

        #region Methods
        public string MemberInfo()
        {
            return "ID: " + this.MemberID + " Name : " + this.MemberName + " Specialty: " + this.MemberSpecialty;
        }
        #endregion
    }

    public class Team
    {
        #region Fields
        // Allows to ad members to team
        public string TeamName { get; set; }
        public string MemberName { get; set; }
        public string MemberSpecialty { get; set; }

        // This property creates a list of team members.
        private List<Member> teamMembers = new List<Member>();
        #endregion

        #region Constructors
        // This property allows to add new team without name
        public Team() { }

        // This property allows to ad new team with name
        public Team(string name)
        {
            TeamName = name;
        }
        #endregion

        #region Methods

        // This method allows to add members to team
        public void AddMember(Member member)
        {
            teamMembers.Add(member);
        }

        // This method builds report (rows - columns) of teammembers + special interests
        public string GetTeams()
        {
            var teamReport = new StringBuilder();

            teamReport.AppendLine($"Team: {TeamName}\r\nMember Name\t\tMember Specialty\n");

            foreach (var item in teamMembers)
            {
                teamReport.AppendLine($"{item.MemberName}\t\t{item.MemberSpecialty}");
            }
            return teamReport.ToString();
        }

        // This method builds report (rows - columns) of team members + member ID's
        public string GetMemberID()
        {
            var teamReport = new StringBuilder();

            teamReport.AppendLine($"\n\nTeam: {TeamName}\r\nMemberID\tMember Name\n");

            foreach (var item in teamMembers)
            {
                teamReport.AppendLine($"{item.MemberID}\t\t{item.MemberName}");
            }
            return teamReport.ToString();
        }
        #endregion

    }

}
