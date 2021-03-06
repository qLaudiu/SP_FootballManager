﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    class TacticBuilder
    {
        public Tactic tactic { get; set; }
    

        public TacticBuilder()
        {
            tactic = new Tactic();
            tactic.formation = EFormation.None;
        }


        public void setFormation(EFormation formation)
        {
            tactic.formation = formation;
         
        }

        public void unsetRoster()
        {
            tactic.Atk = new List<Player>();
            tactic.Def = new List<Player>();
            tactic.Gk = new Player();
            tactic.Mid = new List<Player>();
            tactic.Substitutes = new List<Player>();
            tactic.Substitutes = null;
        }

        public void setRoster(List<Player> allPlayers)
        {
            const int MinimumRequiredPlayers = 14;
            if (allPlayers.Count == 0)
                throw new Exception("Error. The Roster cannot be initialize with no players");
            else if (allPlayers.Count < MinimumRequiredPlayers)
            {
                throw new Exception("Error. There are too few players to do a formation with. ");
            }
            else
            {
                tactic.Substitutes = allPlayers;
            }
        }
       private void SwitchFormation(EFormation eFormation)
        {

                switch (eFormation)
                {
                    case EFormation.Formation2_3_5:
                        DistributePlayersSimpleFormation(2, 3, 5);
                        break;
                    case EFormation.Formation3_2_5:
                        DistributePlayersSimpleFormation(3, 2, 5);
                        break;
                    case EFormation.Formation3_5_2:
                        DistributePlayersSimpleFormation(3, 5, 2);
                        break;
                    case EFormation.Formation4_2_3_1:
                        DistributePlayersSimpleFormation(4, 2, 4);
                        break;
                    case EFormation.Formation4_2_4:
                        DistributePlayersSimpleFormation(4, 2, 4);
                        break;
                    case EFormation.Formation4_3_3:
                        DistributePlayersSimpleFormation(4, 3, 3);
                        break;
                    case EFormation.Formation4_4_2:
                        DistributePlayersSimpleFormation(4, 4, 2);
                        break;
                    case EFormation.Formation5_4_1:
                        DistributePlayersSimpleFormation(5, 4, 1);
                        break;
                    case EFormation.Formation2_3_2_3:
                        DistributePlayersSimpleFormation(2, 5, 3);
                        break;

                    default:
                    throw new Exception("Error. There is no such formation.");
                }
            
        }

        private void DistributePlayersSimpleFormation(int def,int mid,int atk)
        {
            //Presupunem ca primesc o lista valida de 11 playeri dintre care am cel putini 2 GK si lista este sortata in functie de scorul jucatorilor
            //Pun toti jucatorii in lista de subtitutes astfel ca atunci cand mut jucatorii in formatie cei nemutati raman direct in substitutes 

            List<Player> defPlayers = new List<Player>();
            defPlayers.AddRange(tactic.Substitutes);

            bool RedFlagGk = true;
            foreach (Player player in defPlayers)
            {
                if (player.Position.Player_role == Role.CB || player.Position.Player_role == Role.LB || player.Position.Player_role==Role.RB)
                {
                    tactic.Def.Add(player);
                    tactic.Substitutes.Remove(player);
                    def--;
                    if(def==0)
                    {
                        break;
                    }
                    
                }
            }

            List<Player> midPlayers = new List<Player>();
            midPlayers.AddRange(tactic.Substitutes);

            foreach (Player player in midPlayers)
            {
                if (player.Position.Player_role == Role.CDM || player.Position.Player_role == Role.LM || player.Position.Player_role == Role.RM ||player.Position.Player_role== Role.CDM)// veriric prin positon 
                {
                    tactic.Mid.Add(player);
                    tactic.Substitutes.Remove(player);
                    mid--;
                    if (mid == 0)
                    {
                        break;
                    }

                }
            }

            List<Player> atkPlayers = new List<Player>();
            atkPlayers.AddRange(tactic.Substitutes);

            foreach (Player player in atkPlayers)
            {
                if (player.Position.Player_role == Role.SS || player.Position.Player_role == Role.CF)
                {
                    tactic.Atk.Add(player);
                    tactic.Substitutes.Remove(player);
                    atk--;
                    if (atk == 0)
                    {
                        break;
                    }

                }
            }

            List<Player> gkPlayers = new List<Player>();
            gkPlayers.AddRange(tactic.Substitutes);

            foreach (Player player in gkPlayers)
            {
                if (player.Position.Player_role == Role.GK)
                {
                    tactic.Gk = player;
                    RedFlagGk = false;
                    break;

                }
            }

            if (def!=0)
            {
                throw new Exception("Error. There are not enough defensive players for this formation.");
            }
            else if (mid !=0)
            {
                throw new Exception("Error. There are not enough midfiled players for this formation.");
            }
            else if(atk!=0)
            {
                throw new Exception("Error. There are not enough attackfield players for this formation.");
            }
            else if(RedFlagGk==true)
            {
                throw new Exception("Error. There is no goalkeeper for this formation.");
            }
        }

        

        public void setUpTeam()
        {
            if(tactic.formation==EFormation.None)
            {
                throw new Exception("Error. Formation is not initalized.");
            }
            else if (tactic.Substitutes==null)
            {
                throw new Exception("Error. There are no players to set up the team with.");
            }
            else
            {
                SwitchFormation(tactic.formation);
            }

        }
    }
}
