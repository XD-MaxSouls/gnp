using System;
using System.Text;

namespace SKILL
{
	public class GSkill5020Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill5020Stub()
			: base(5020)
		{
			occupation = 145;
			maxlevel = 100;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 5;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"");
			SetAction(10,"");
			SetAction(11,"");
			SetAction(12,"");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÃÖÀÕ<½ðê×>";
			nativename = "ÃÖÀÕ<½ðê×>";
			icon = "ÃÖÀÕ.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 75000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (5 * skill_level + 10);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 12;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(16000.0f);
			victim.SetRatio(((60 * (norm(skill_level / 100) + (norm(skill_level / 90) + (norm(skill_level / 60) + (norm(skill_level / 30))))) + 60) * 0.01f));
			victim.SetBuffid(1);
			victim.SetIncdefence(true);
			victim.SetProbability(100.0f);
			victim.SetTime(16000.0f);
			victim.SetRatio(((10 * (norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30))))) + 40) * 0.01f));
			victim.SetDecdamage(true);
			victim.SetProbability(100.0f);
			victim.SetTime(16000.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(((3 * player_maxhp)));
			victim.SetValue((player_maxhp * 0.03f));
			victim.SetHpregain(true);
			return true;
		}
	}
	public class GSkill5020 : GSkill
	{
		public GSkill5020()
			: base(5020)
		{
			
		}
	}
	public class GSkill5021Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();

				player.SetVar1((int)(player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))));
				player.SetVar2(player_res4);
				player.SetVar3(player_res3);
				player.SetPerform(1);
			}
		}
		public GSkill5021Stub()
			: base(5021)
		{
			occupation = 145;
			maxlevel = 100;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"");
			SetAction(10,"");
			SetAction(11,"");
			SetAction(12,"");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Íò»¨<Ä¾ê×>";
			nativename = "Íò»¨<Ä¾ê×>";
			icon = "Íò»¨.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 275000 - 50000 * (norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30)))));
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (5 * skill_level + 10);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var2 = player.GetVar2();
			int				player_var3 = player.GetVar3();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(9999.0f);
			victim.SetPullback(true);
			victim.SetProbability(((player_var2 + 10)));
			victim.SetTime(((1000 * (norm(skill_level / 100) + (norm(skill_level / 90) + (norm(skill_level / 60) + (norm(skill_level / 30))))) + 1000)));
			victim.SetSilent(true);
			victim.SetProbability(((player_var3 + 10)));
			victim.SetTime(((1000 * (norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30))))) + 1000)));
			victim.SetWrap(true);
			return true;
		}
	}
	public class GSkill5021 : GSkill
	{
		public GSkill5021()
			: base(5021)
		{
			
		}
	}
	public class GSkill5022Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();

				player.SetVar1((int)(player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))));
				player.SetPerform(1);
			}
		}
		public GSkill5022Stub()
			: base(5022)
		{
			occupation = 145;
			maxlevel = 100;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 7;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"");
			SetAction(10,"");
			SetAction(11,"");
			SetAction(12,"");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "²×º£<Ë®ê×>";
			nativename = "²×º£<Ë®ê×>";
			icon = "²×º£.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 275000 - 50000 * (norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30)))));
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 11.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (5 * skill_level + 10);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			victim.SetTime(16000.0f);
			victim.SetRatio(((norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30)))) + 1) * 0.01f));
			victim.SetBuffid(9);
			victim.SetInchp(true);
			victim.SetProbability(111.0f);
			victim.SetTime(16000.0f);
			victim.SetRatio(((player_var1 / 1000 + 2) * 0.01f));
			victim.SetBuffid(5);
			victim.SetAmount(1.0f);
			victim.SetValue(5121.0f);
			victim.SetAddcommon(true);
			return true;
		}
	}
	public class GSkill5022 : GSkill
	{
		public GSkill5022()
			: base(5022)
		{
			
		}
	}
	public class GSkill5023Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res2 = player.GetRes2();

				player.SetVar1(player_res2);
				player.SetPerform(1);
			}
		}
		public GSkill5023Stub()
			: base(5023)
		{
			occupation = 145;
			maxlevel = 100;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"");
			SetAction(10,"");
			SetAction(11,"");
			SetAction(12,"");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÌìÓ³<»ðê×>";
			nativename = "ÌìÓ³<»ðê×>";
			icon = "ÌìÓ³.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 75000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (5 * skill_level + 10);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res2 = player.GetRes2();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((player_var1 / 10)));
			victim.SetTime(((6000 * (norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30))))) + 6000)));
			victim.SetRatio(5.0f);
			if ( player.GetHasbuff(5431) == 1 )
			{
			if ( player.GetHasbuff(5432) == 1 )
			v47 = 3;
			else
			v48 = 2;
			}
			else
			{
			v48 = 1;
			}
			victim.SetBuffid(v48);
			victim.SetAmount(5.0f);
			if ( ((4 * (norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30))))) + 4) * (player_var2 * 0.01f) + player_var2) <= player_res2 )
			{
			v46 = 150.0f;
			}
			else
			{
			v46 = (4 * (norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30))))) + 4) * (player_var2 * 0.01f) + player_var2;
			}
			victim.SetValue(v46);
			victim.SetFiring(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res2 = player.GetRes2();
			int				skill_level = skill.GetLevel();

			victim.SetTime(16000.0f);
			victim.SetBuffid(1);
			victim.SetValue(((4 * (norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30))))) + 4) * (player_res2 * 0.01f)));
			victim.SetAddantiweak(true);
			return true;
		}
	}
	public class GSkill5023 : GSkill
	{
		public GSkill5023()
			: base(5023)
		{
			
		}
	}
	public class GSkill5024Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill5024Stub()
			: base(5024)
		{
			occupation = 145;
			maxlevel = 100;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 7;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"");
			SetAction(10,"");
			SetAction(11,"");
			SetAction(12,"");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Ì©×Ú<ÍÁê×>";
			nativename = "Ì©×Ú<ÍÁê×>";
			icon = "Ì©×Ú.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 275000 - 50000 * (norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30)))));
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (5 * skill_level + 10);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * (norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30))))) + 1000)));
			victim.SetRatio(0.99900001f);
			victim.SetAmount(((10 * player_maxhp)));
			victim.SetDeadlybless(true);
			victim.SetProbability(111.0f);
			victim.SetTime(6000.0f);
			victim.SetBuffid(3);
			victim.SetValue(2.0f);
			victim.SetAddspeed(true);
			victim.SetTime(6000.0f);
			victim.SetImmuneslow(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(111.0f);
			victim.SetTime(6000.0f);
			victim.SetBuffid(3);
			victim.SetValue(2.0f);
			victim.SetAddspeed(true);
			victim.SetTime(6000.0f);
			victim.SetImmuneslow(true);
			return true;
		}
	}
	public class GSkill5024 : GSkill
	{
		public GSkill5024()
			: base(5024)
		{
			
		}
	}
	public class GSkill5025Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				player_crit = player.GetCrit();
				int				player_res4 = player.GetRes4();

				player.SetVar1(player_maxatk);
				player.SetVar2(player_crit);
				player.SetVar3(player_res4);
				player.SetPerform(1);
			}
		}
		public GSkill5025Stub()
			: base(5025)
		{
			occupation = 145;
			maxlevel = 100;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"");
			SetAction(10,"");
			SetAction(11,"");
			SetAction(12,"");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÎÔÁú<¼Æ¶¼>";
			nativename = "ÎÔÁú<¼Æ¶¼>";
			icon = "ÎÔÁú.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 275000 - 50000 * (norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30)))));
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (5 * skill_level + 10);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxatk = player.GetMaxatk();
			int				player_crit = player.GetCrit();
			int				player_res4 = player.GetRes4();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();

			/*
			if ( player_var1 <= player_maxatk )
			d = 0.0f;
			else
			victim.SetProbability(100.0f);
			victim.SetTime(15000.0f);
			victim.SetBuffid(1);
			victim.SetValue(((10 * (norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30))))) + 10) * (player_var1 * 0.01f)));
			victim.SetSubattack(true);
			if ( player_var2 <= player_crit )
			{
			v38 = 0.0f;
			}
			else
			{
			v38 = (player_res4 + 100);
			}
			victim.SetProbability(v38);
			victim.SetTime((((1000 * player_var2) * 0.01f) / (5.9f - (norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30)))) + 1))));
			victim.SetSilent(true);
			*/
			return true;
		}
	}
	public class GSkill5025 : GSkill
	{
		public GSkill5025()
			: base(5025)
		{
			
		}
	}
	public class GSkill5026Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_skillrate = player.GetSkillrate();

				player.SetVar1((int)(player_skillrate / 10));
				player.SetPerform(1);
			}
		}
		public GSkill5026Stub()
			: base(5026)
		{
			occupation = 145;
			maxlevel = 100;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"");
			SetAction(10,"");
			SetAction(11,"");
			SetAction(12,"");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÁùµÀ<ÂÞºò>";
			nativename = "ÁùµÀ<ÂÞºò>";
			icon = "ÁùµÀ.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 275000 - 50000 * (norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30)))));
		}
		public override float GetRadius(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (5 * skill_level + 10);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 15;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(100.0f);
			victim.SetTime(10000.0f);
			victim.SetRatio((player_var1 * ((5 * (norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30))))) + 10) * 0.01f) * 0.01f));
			victim.SetBuffid(1);
			victim.SetDecskillaccu(true);
			victim.SetProbability(100.0f);
			victim.SetTime(100000.0f);
			if ( player.GetCultivation() == 1 )
			{
			v53 = (3 * zrand(2) + 1521);
			}
			else
			{
			if ( player.GetCultivation() == 2 )
			{
			v52 = (zrand(2) + 1547);
			}
			else
			{
			if ( player.GetCultivation() == 4 )
			v51 = (zrand(3) + 1573);
			else
			v52 = 0.0f;
			}
			v53 = v52;
			}
			victim.SetRatio(v53);
			victim.SetAmount(0.0f);
			if ( player.GetCultivation() == 1 )
			{
			v50 = (zrand(3) + 1525);
			}
			else
			{
			if ( player.GetCultivation() == 2 )
			{
			v49 = (zrand(2) + 1550);
			}
			else
			{
			if ( player.GetCultivation() == 4 )
			v48 = (zrand(3) + 1576);
			else
			v49 = 0.0f;
			}
			v50 = v49;
			}
			victim.SetValue(v50);
			victim.SetSetcooldown(true);
			victim.SetProbability(100.0f);
			victim.SetTime(100000.0f);
			if ( player.GetCultivation() == 1 )
			{
			v47 = (zrand(3) + 1528);
			}
			else
			{
			if ( player.GetCultivation() == 2 )
			{
			v46 = (zrand(4) + 1553);
			}
			else
			{
			if ( player.GetCultivation() == 4 )
			v45 = (zrand(3) + 1579);
			else
			v46 = 0.0f;
			}
			v47 = v46;
			}
			victim.SetRatio(v47);
			victim.SetAmount(0.0f);
			if ( player.GetCultivation() == 1 )
			{
			v44 = (zrand(2) + 2035);
			}
			else
			{
			if ( player.GetCultivation() == 2 )
			{
			v43 = (zrand(2) + 2037);
			}
			else
			{
			if ( player.GetCultivation() == 4 )
			v42 = (zrand(2) + 2039);
			else
			v43 = 0.0f;
			}
			v44 = v43;
			}
			victim.SetValue(v44);
			victim.SetSetcooldown(true);
			*/
			return true;
		}
	}
	public class GSkill5026 : GSkill
	{
		public GSkill5026()
			: base(5026)
		{
			
		}
	}
	public class GSkill5027Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				player_res2 = player.GetRes2();

				player.SetVar1(player_res2);
				player.SetVar2(player_maxatk);
				player.SetPerform(1);
			}
		}
		public GSkill5027Stub()
			: base(5027)
		{
			occupation = 145;
			maxlevel = 100;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = true;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"");
			SetAction(10,"");
			SetAction(11,"");
			SetAction(12,"");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Å­ÌÎ<Í¨ÓÃ>";
			nativename = "Å­ÌÎ<Í¨ÓÃ>";
			icon = "Å­ÌÎ.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 12000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 4.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (5 * skill_level + 10);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();

			/*
			if ( player_var1 <= 700 )
			{
			d = 700.0f;
			}
			else
			{
			d = player_var1;
			}
			victim.SetProbability(d);
			victim.SetTime(5000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			if ( player.GetObjectType()
			|| (v10 = player, GNET::PlayerWrapper::GetDef(v10) <= 9999) )
			v25 = 100.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetValue(((4 * (norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30))))) + 4) * (player_var2 * 0.01f)));
			victim.SetDirecthurt(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(500.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(((norm(skill_level / 100) + (norm(skill_level / 90) + (norm(skill_level / 60) + (norm(skill_level / 30)))) + 1) * (player_maxhp * 0.01f)));
			victim.SetHpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(500.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(((norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30)))) + 1) * (player_maxmp * 0.01f)));
			victim.SetMpgen(true);
			return true;
		}
	}
	public class GSkill5027 : GSkill
	{
		public GSkill5027()
			: base(5027)
		{
			
		}
	}
	public class GSkill5028Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill5028Stub()
			: base(5028)
		{
			occupation = 145;
			maxlevel = 100;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = true;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"");
			SetAction(10,"");
			SetAction(11,"");
			SetAction(12,"");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "¿ñÀ×<Í¨ÓÃ>";
			nativename = "¿ñÀ×<Í¨ÓÃ>";
			icon = "¿ñÀ×.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 12000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 4.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (5 * skill_level + 10);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(5100.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();

			victim.SetTime(15000.0f);
			victim.SetRatio((((norm(skill_level / 100) + (norm(skill_level / 90) + (norm(skill_level / 60) + (norm(skill_level / 30))))) + 1.01f) * 0.01f));
			victim.SetInccritrate(true);
			victim.SetProbability(120.0f);
			victim.SetTime(15000.0f);
			victim.SetRatio((((norm(skill_level / 100) + (norm(skill_level / 90) + (norm(skill_level / 60) + (norm(skill_level / 30))))) + 1.01f) * 0.1f));
			victim.SetBuffid(1);
			victim.SetInccrithurt(true);
			victim.SetProbability(100.0f);
			victim.SetTime(500.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(((norm(skill_level / 100) + (norm(skill_level / 90) + (norm(skill_level / 60) + (norm(skill_level / 30)))) + 1) * (player_maxhp * 0.01f)));
			victim.SetHpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(500.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(((norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30)))) + 1) * (player_maxmp * 0.01f)));
			victim.SetMpgen(true);
			return true;
		}
	}
	public class GSkill5028 : GSkill
	{
		public GSkill5028()
			: base(5028)
		{
			
		}
	}
	public class GSkill5029Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_skilldodge = player.GetSkilldodge();

				player.SetVar1((int)(player_skilldodge / 10));
				player.SetPerform(1);
			}
		}
		public GSkill5029Stub()
			: base(5029)
		{
			occupation = 145;
			maxlevel = 100;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 7;
			doenchant = true;
			dobless = false;
			autoattack = true;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"");
			SetAction(10,"");
			SetAction(11,"");
			SetAction(12,"");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÓÄ¹È<Í¨ÓÃ>";
			nativename = "ÓÄ¹È<Í¨ÓÃ>";
			icon = "ÓÄ¹È.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 90000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 4.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (5 * skill_level + 10);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res4 = player.GetRes4();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * (player_var1 / (40.001f - (5 * (norm(skill_level / 100) + (norm(skill_level / 90) + (norm(skill_level / 60) + (norm(skill_level / 30)))))))) + 4000)));
			victim.SetRatio(0.0f);
			victim.SetAmount(10.0f);
			victim.SetValue(0.0f);
			victim.SetShadowhide(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * (player_var1 / (40.001f - (5 * (norm(skill_level / 100) + (norm(skill_level / 90) + (norm(skill_level / 60) + (norm(skill_level / 30)))))))) + 4000)));
			victim.SetPowerless(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * (player_var1 / (40.001f - (5 * (norm(skill_level / 100) + (norm(skill_level / 90) + (norm(skill_level / 60) + (norm(skill_level / 30)))))))) + 4000)));
			victim.SetRatio((((2 * (norm(skill_level / 100) + (norm(skill_level / 90) + (norm(skill_level / 60) + (norm(skill_level / 30)))))) + 2.01f) * 0.01f));
			victim.SetBuffid(2);
			victim.SetIncskilldodge(true);
			victim.SetProbability(((player_res4 + 100)));
			victim.SetTime(((1000 * (player_var1 / (40.001f - (5 * (norm(skill_level / 100) + (norm((skill_level / 90)) + (norm(skill_level / 60) + (norm(skill_level / 30)))))))) + 4000)));
			victim.SetSilent(true);
			return true;
		}
	}
	public class GSkill5029 : GSkill
	{
		public GSkill5029()
			: base(5029)
		{
			
		}
	}
}
