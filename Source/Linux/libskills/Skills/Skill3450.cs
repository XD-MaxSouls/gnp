using System;
using System.Text;

namespace SKILL
{
	public class GSkill3450Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 3000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 5000;
			}
			public override void Calculate(GSkill skill)
			{
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 2000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3450Stub()
			: base(3450)
		{
			occupation = 67;
			maxlevel = 20;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 3;
			targettype = 0;
			rangetype = 2;
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
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾Êìïş¡¿");
			SetAction(1,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾Êìïş¡¿");
			SetAction(2,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾Êìïş¡¿");
			SetAction(3,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾Êìïş¡¿");
			SetAction(4,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾Êìïş¡¿");
			SetAction(5,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾Êìïş¡¿");
			SetAction(6,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾Êìïş¡¿");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾Êìïş¡¿");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾Êìïş¡¿");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾Êìïş¡¿");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾Êìïş¡¿");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾Êìïş¡¿");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾Êìïş¡¿");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾Êìïş¡¿");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "×£ÈÚÕæµä";
			nativename = "×£ÈÚÕæµä";
			icon = "×£ÈÚÕæµä¡¤Õó·¨.dds";
			SetTalent(0,3421);
			SetTalent(1,3422);
			SetTalent(2,3423);
			SetTalent(3,3408);
			SetTalent(4,3758);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 5;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = true;
			cyclemode = 1;
			cyclegfx = "·¨ÕóÊìïş";
			skill_class = 9;
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 5000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();
			int				skill_t4 = skill.GetT4();

            return (int)(((150000 - 15000 * skill_t1)) - skill_t4 * 3000.0f);
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 28.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 2500.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(((20 * skill_t3)));
			victim.SetBreakcasting(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();
			int				skill_t4 = skill.GetT4();
			int				skill_charging = skill.GetCharging();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_t4 + (10000 * (skill_charging / 0x12C0) + (1000 * (player.GetCyclemembercnt() * skill_t0 + (5 * player.GetCyclemembercnt() + (2 * skill_level))))))));
			victim.SetRatio(((skill_t2 * player.GetCyclemembercnt() + (player.GetCyclemembercnt() + (skill_level + (100 * skill_level))) - 1)));
			victim.SetBuffid(0);
			victim.SetAmount(3607.0f);
			victim.SetValue(2.0f);
			victim.SetCycle(true);
			victim.SetTime(900.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetEvilaura(true);
			if ( zrand(100) >= 2 * player.GetSkilllevel(3759) )
			d = 218.0f;
			else
			victim.SetRatio(3449.0f);
			victim.SetAmount(218.0f);
			victim.SetValue(218.0f);
			victim.SetClearcooldown(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3449};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3450 : GSkill
	{
		public GSkill3450()
			: base(3450)
		{
			
		}
	}
	public class GSkill3451Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 300;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((21 * skill_level + 375)));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 700;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((21 * skill_level + 375)));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 700;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((21 * skill_level + 375)));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState5 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 700;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((21 * skill_level + 375)));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState6 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 300;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((21 * skill_level + 375)));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState7 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 300;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((21 * skill_level + 375)));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState8 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((21 * skill_level + 375)));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState9 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((21 * skill_level + 375)));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState10 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((21 * skill_level + 375)));
				player.SetPerform(0);
			}
		}
		public GSkill3451Stub()
			: base(3451)
		{
			occupation = 68;
			maxlevel = 7;
			maxlearn = 6;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
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
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(1,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(2,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(3,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(4,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(5,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(6,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÄÏÎ×Ìì»ğ";
			nativename = "ÄÏÎ×Ìì»ğ";
			icon = "ÄÏÎ×Ìì»ğ.dds";
			SetTalent(0,3381);
			SetTalent(1,3384);
			SetTalent(2,3389);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 3;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 9;
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
			AddState(new GState3());
			AddState(new GState4());
			AddState(new GState5());
			AddState(new GState6());
			AddState(new GState7());
			AddState(new GState8());
			AddState(new GState9());
			AddState(new GState10());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 5000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 16000 - 3000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,135,135,135,136,137};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 18);
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (3000 - 20 * skill_level * skill_level);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();

			return 4 * skill_t2 + 20;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_t0 = skill.GetT0();

			/*
			v17 = 5 * skill_t0 + 15;
			if ( player.GetHasbuff(4120) == 1 )
			v16 = (v17 - 13);
			else
			victim.SetProbability(v17);
			victim.SetTime(14100.0f);
			victim.SetRatio(8.0f);
			if ( player.GetHasbuff(4120) == 1 )
			v15 = zrand(2) + 1;
			else
			victim.SetBuffid((zrand(5) + 1));
			victim.SetAmount(9.0f);
			victim.SetValue((player_var1 * 0.05f));
			victim.SetFiring(true);
			*/
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill3451 : GSkill
	{
		public GSkill3451()
			: base(3451)
		{
			
		}
	}
	public class GSkill3452Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxhp = player.GetMaxhp();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_var1 = player.GetVar1();
				int				player_var2 = player.GetVar2();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((skill_level * 0.05f + 1.2f));
				player.SetVar1((int)((player_res2 * (D2INT(player.GetHasbuff(4199) == 1))) + (D2INT(player.GetHasbuff(4200) == 1)) * player_res3 + ((D2INT(player.GetHasbuff(4202) == 1)) * player_res1 + (player_res4 * (D2INT(player.GetHasbuff(4201) == 1))))));
				player.SetVar2((int)(D2INT(player.GetHasbuff(4202) == 1) + (D2INT(player.GetHasbuff(4201) == 1) + (D2INT(player.GetHasbuff(4200) == 1) + (D2INT(player.GetHasbuff(4199) == 1))))));
				player.SetVar3((int)(4 * D2INT(player.GetHasbuff(4202) == 1) + (D2INT(player.GetHasbuff(4199) == 1) + (3 * D2INT(player.GetHasbuff(4201) == 1) + (2 * D2INT(player.GetHasbuff(4200) == 1))))));
				skill.SetPlus((skill_t1 * ((norm(skill_t1) * player_maxhp) * 0.02f) + ((zrand(100) * (((skill_level * 0.5f) - ((skill_level - 1) / 2)) * 0.01f) + (((skill_level - 1) / 2) + 0.5f)) * ((player_var2 * player_var1)))));
				player.SetPerform(1);
			}
		}
		public GSkill3452Stub()
			: base(3452)
		{
			occupation = 68;
			maxlevel = 20;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 3;
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
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(1,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(2,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(3,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(4,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(5,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(6,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ì«Ô¨Òµº£";
			nativename = "Ì«Ô¨Òµº£";
			icon = "Ì«Ô¨Òµº£.dds";
			SetTalent(0,3405);
			SetTalent(1,3406);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 2;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 9;
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

			return 33000 - 3000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,135,136,137,139};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (6 * (skill_level + (skill_level * skill_level)) + 1660);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 10;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var2 = player.GetVar2();
			int				player_var3 = player.GetVar3();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability((((6 * skill_level + 20) * player_var2)));
			victim.SetTime(16000.0f);
			victim.SetRatio(((player_var3 + (10 * (skill_t0 + skill_level)))));
			victim.SetBuffid(3);
			victim.SetValue(3613.0f);
			victim.SetDelaycast(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3451};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill3452 : GSkill
	{
		public GSkill3452()
			: base(3452)
		{
			
		}
	}
	public class GSkill3453Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3453Stub()
			: base(3453)
		{
			occupation = 68;
			maxlevel = 20;
			maxlearn = 4;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(1,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(2,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(3,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(4,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(5,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(6,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "·ÙÏãÓñ²á";
			nativename = "·ÙÏãÓñ²á";
			icon = "·ÙÏãÓñ²á.dds";
			SetTalent(0,3405);
			SetTalent(1,3406);
			SetTalent(2,3404);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 3;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 9;
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();

			return 120000 - 20000 * skill_t2;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,135,136,137};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 13.500000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1500.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			/*
			if ( player.GetDebuffcnt() )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(50.0f);
			victim.SetRatio(((2 * (skill_t1 + skill_level))));
			victim.SetBuffid(4);
			if ( (2 * (skill_t1 * norm(skill_t1)) * (skill_level / 2) + skill_level + 2) <= player.GetDebuffcnt() )
			{
			if ( 2 * (skill_t1 * norm(skill_t1)) * (skill_level / 2) + skill_level + 2 <= 2 )
			{
			LABEL_21:
			v56 = 3635.0f;
			goto LABEL_22;
			}
			}
			else
			{
			if ( player.GetDebuffcnt() <= 2 )
			goto LABEL_21;
			}
			if ( (2 * (skill_t1 * norm(skill_t1)) * (skill_level / 2) + skill_level + 2) <= player.GetDebuffcnt() )
			{
			if ( 2 * (skill_t1 * norm(skill_t1)) * (skill_level / 2) + skill_level + 2 <= 4 )
			{
			LABEL_19:
			v55 = 3636.0f;
			goto LABEL_20;
			}
			}
			else
			{
			if ( player.GetDebuffcnt() <= 4 )
			goto LABEL_19;
			}
			if ( (2 * (skill_t1 * norm(skill_t1)) * (skill_level / 2) + skill_level + 2) <= player.GetDebuffcnt() )
			{
			if ( 2 * (skill_t1 * norm(skill_t1)) * (skill_level / 2) + skill_level + 2 <= 6 )
			{
			LABEL_17:
			v54 = 3637.0f;
			goto LABEL_18;
			}
			}
			else
			{
			if ( player.GetDebuffcnt() <= 6 )
			goto LABEL_17;
			}
			v54 = 3638.0f;
			LABEL_18:
			v55 = v54;
			LABEL_20:
			v56 = v55;
			LABEL_22:
			victim.SetValue(v56);
			victim.SetDelaycast(true);
			victim.SetTime(((3000 * skill_t0 + (4000 * skill_level))));
			victim.SetBuffid(1);
			victim.SetAmount((((skill_level / 2) * skill_t1 + skill_level + 2)));
			victim.SetTurndebuff(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3452};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill3453 : GSkill
	{
		public GSkill3453()
			: base(3453)
		{
			
		}
	}
	public class GSkill3454Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 3000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 5000;
			}
			public override void Calculate(GSkill skill)
			{
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 2000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3454Stub()
			: base(3454)
		{
			occupation = 68;
			maxlevel = 3;
			maxlearn = 2;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 3;
			targettype = 0;
			rangetype = 2;
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
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(1,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(2,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(3,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(4,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(5,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(6,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "°ËĞ×Ğş»ğ";
			nativename = "°ËĞ×Ğş»ğ";
			icon = "°ËĞ×Ğş»ğ¡¤Õó·¨.dds";
			SetTalent(0,3421);
			SetTalent(1,3422);
			SetTalent(2,3423);
			SetTalent(3,3408);
			SetTalent(4,2947);
			SetTalent(5,3758);
			SetTalent(6,4112);
			SetTalent(7,4530);
			talent_size = 8;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = true;
			cyclemode = 1;
			cyclegfx = "·¨Õó°ËĞ×";
			skill_class = 9;
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 5000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();
			int				skill_t5 = skill.GetT5();

			return (int)(((180000 - 15000 * skill_t1)) - skill_t5 * 3600.0f);
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={139,141};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 28.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 4000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(((20 * skill_t3)));
			victim.SetBreakcasting(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();
			int				skill_t4 = skill.GetT4();
			int				skill_t5 = skill.GetT5();
			int				skill_charging = skill.GetCharging();

			/*
			victim.SetProbability(120.0f);
			if ( skill_t2 == 4 )
			goto LABEL_12;
			if ( skill_t4 >= player.GetSkilllevel(4112) )
			{
			if ( skill_t4 < player.GetSkilllevel(4530) )
			{
			if ( player.GetSkilllevel(4530) <= 0 )
			goto LABEL_34;
			}
			else if ( skill_t4 <= 0 )
			{
			goto LABEL_34;
			}
			LABEL_12:
			v112 = 1000 * skill_t0 * (player.GetCyclemembercnt() * norm(skill_t0));
			v111 = 1000 * skill_t5;
			if ( skill_t4 < player.GetSkilllevel(4112) )
			{
			if ( player.GetSkilllevel(4112) < player.GetSkilllevel(4530) )
			{
			if ( player.GetSkilllevel(4530) == 5 )
			{
			LABEL_32:
			v110 = (v111 + v112 + 10000);
			LABEL_33:
			t = v110;
			goto LABEL_35;
			}
			}
			else
			{
			if ( player.GetSkilllevel(4112) == 5 )
			goto LABEL_32;
			}
			}
			else
			{
			if ( skill_t4 < player.GetSkilllevel(4530) )
			{
			if ( player.GetSkilllevel(4530) == 5 )
			goto LABEL_32;
			}
			else if ( skill_t4 == 5 )
			{
			goto LABEL_32;
			}
			}
			if ( skill_t4 < player.GetSkilllevel(4112) )
			{
			if ( player.GetSkilllevel(4112) < player.GetSkilllevel(4530) )
			{
			v107 = (v111 + v112 + 1000 * player.GetSkilllevel(4530));
			}
			else
			{
			v107 = (v111 + v112 + 1000 * player.GetSkilllevel(4112));
			}
			v109 = v107;
			}
			else
			{
			if ( skill_t4 < player.GetSkilllevel(4530) )
			{
			v108 = (v111 + v112 + 1000 * player.GetSkilllevel(4530));
			}
			else
			{
			v108 = (v111 + v112 + 1000 * skill_t4);
			}
			v109 = v108;
			}
			v110 = v109;
			goto LABEL_33;
			}
			if ( player.GetSkilllevel(4112) >= player.GetSkilllevel(4530) )
			{
			if ( player.GetSkilllevel(4112) <= 0 )
			goto LABEL_34;
			goto LABEL_12;
			}
			if ( player.GetSkilllevel(4530) > 0 )
			goto LABEL_12;
			LABEL_34:
			t = 0.0f;
			LABEL_35:
			victim.SetTime(t);
			v105 = player.GetSkilllevel(3432) > 4;
			if ( player.GetSkilllevel(3441) <= 4 )
			v106 = v105;
			else
			v106 = v105 + 10;
			if ( player.GetSkilllevel(3450) <= 4 )
			d = v106;
			else
			victim.SetRatio(((v106 + 100)));
			if ( skill_t2 != 4 )
			{
			if ( skill_t4 < player.GetSkilllevel(4112) )
			{
			if ( player.GetSkilllevel(4112) < player.GetSkilllevel(4530) )
			{
			if ( player.GetSkilllevel(4530) <= 0 )
			{
			LABEL_56:
			v103 = 0;
			goto LABEL_57;
			}
			}
			else
			{
			if ( player.GetSkilllevel(4112) <= 0 )
			goto LABEL_56;
			}
			}
			else
			{
			if ( skill_t4 < player.GetSkilllevel(4530) )
			{
			if ( player.GetSkilllevel(4530) <= 0 )
			goto LABEL_56;
			}
			else if ( skill_t4 <= 0 )
			{
			goto LABEL_56;
			}
			}
			}
			if ( player.GetSkilllevel(3450) <= 4 )
			v102 = 0;
			else
			v103 = 3984;
			LABEL_57:
			victim.SetBuffid(v103);
			if ( skill_t2 != 4 )
			{
			if ( skill_t4 < player.GetSkilllevel(4112) )
			{
			if ( player.GetSkilllevel(4112) < player.GetSkilllevel(4530) )
			{
			if ( player.GetSkilllevel(4530) <= 0 )
			{
			LABEL_72:
			v101 = 0.0f;
			goto LABEL_73;
			}
			}
			else
			{
			if ( player.GetSkilllevel(4112) <= 0 )
			goto LABEL_72;
			}
			}
			else
			{
			if ( skill_t4 < player.GetSkilllevel(4530) )
			{
			if ( player.GetSkilllevel(4530) <= 0 )
			goto LABEL_72;
			}
			else if ( skill_t4 <= 0 )
			{
			goto LABEL_72;
			}
			}
			}
			if ( player.GetSkilllevel(3450) <= 4 )
			v100 = 0.0f;
			else
			v101 = 3608.0f;
			LABEL_73:
			victim.SetAmount(v101);
			victim.SetValue(2.0f);
			victim.SetCycle(true);
			if ( zrand(100) >= 2 * player.GetSkilllevel(3759) )
			v99 = 218.0f;
			else
			victim.SetRatio(3449.0f);
			victim.SetAmount(218.0f);
			victim.SetValue(218.0f);
			victim.SetClearcooldown(true);
			victim.SetProbability(120.0f);
			victim.SetTime(50.0f);
			v97 = skill_charging > 0x1194;
			v95 = skill_charging > 0x9C4;
			if ( player.GetCyclemembercnt() > 3 )
			v96 = 100 * v95;
			else
			v96 = 0;
			skill_charging;
			if ( player.GetCyclemembercnt() > 0 )
			v94 = 100;
			else
			v94 = 0;
			v93 = 5 * skill_level;
			v92 = skill_t0 * player.GetCyclemembercnt();
			if ( player.GetCyclemembercnt() == 6 )
			v98 = v92 + v93 + v94 + 100 * v97 + v96 + 20;
			else
			v98 = v92 + v93 + v94 + v96 + 20;
			if ( skill_charging <= 0x12C0 )
			v91 = (v98 + 1000);
			else
			victim.SetRatio(((v98 + 1010)));
			victim.SetBuffid(1);
			victim.SetValue(3646.0f);
			victim.SetDelaycast(true);
			victim.SetTime(900.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetEvilaura(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3451};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3454 : GSkill
	{
		public GSkill3454()
			: base(3454)
		{
			
		}
	}
	public class GSkill3455Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				skill.SetPlus((((20 * skill_level + 50) * norm(30 / player_level) + (5 * (skill_level * skill_t0 + skill_level)) + 40)));
				player.SetPerform(1);
			}
		}
		public GSkill3455Stub()
			: base(3455)
		{
			occupation = 96;
			maxlevel = 9;
			maxlearn = 6;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
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
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_´¸»÷");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"Ì«ê»_´¸»÷");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_´¸»÷");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"Ì«ê»_Æï³Ë_´¸»÷");
			SetAction(30,"0");
			name = "³åÉ±";
			nativename = "³åÉ±";
			icon = "³åÉ±.dds";
			SetTalent(0,3503);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 1;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 10;
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={1,3,5,7,9,11};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 10.000000f;
		}
	}
	public class GSkill3455 : GSkill
	{
		public GSkill3455()
			: base(3455)
		{
			
		}
	}
	public class GSkill3456Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				skill.SetPlus(((15 * skill_level + 39)));
				player.SetPerform(1);
			}
		}
		public GSkill3456Stub()
			: base(3456)
		{
			occupation = 96;
			maxlevel = 10;
			maxlearn = 7;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
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
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_Ï¥×²");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"Ì«ê»_Ï¥×²");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_Ï¥×²");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"Ì«ê»_Æï³Ë_Ï¥×²");
			SetAction(30,"0");
			name = "ÈÕÔÂÕ¶";
			nativename = "ÈÕÔÂÕ¶";
			icon = "ÈÕÔÂÕ¶.dds";
			SetTalent(0,3508);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 1;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 10;
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 2000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={15,17,19,21,23,25,27};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 30.000000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3455};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3456 : GSkill
	{
		public GSkill3456()
			: base(3456)
		{
			
		}
	}
	public class GSkill3457Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();

				player.SetVar1(player_res2);
				skill.SetCrit((skill_level * 0.01f));
				player.SetPerform(1);
			}
		}
		public GSkill3457Stub()
			: base(3457)
		{
			occupation = 96;
			maxlevel = 11;
			maxlearn = 8;
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
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_Öâ»÷");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"Ì«ê»_Öâ»÷");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_Öâ»÷");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"Ì«ê»_Æï³Ë_Öâ»÷");
			SetAction(30,"0");
			name = "ÉñÏ¢Êõ";
			nativename = "ÉñÏ¢Êõ";
			icon = "ÉñÏ¢Êõ.dds";
			SetTalent(0,3509);
			SetTalent(1,3512);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 2;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 10;
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 2000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={20,22,24,26,28,30,32,34};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 41.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_t1 = skill.GetT1();

			victim.SetTime(((4000 * skill_t1)));
			victim.SetBuffid(1);
			victim.SetValue((skill_t1 * (player_var1 * 0.02f)));
			victim.SetSubantiweak(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3456};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3457 : GSkill
	{
		public GSkill3457()
			: base(3457)
		{
			
		}
	}
	public class GSkill3458Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();

				player.SetVar1(player_res2);
				skill.SetPlus(((10 * skill_level + 133)));
				skill.SetCrit((skill_level * 0.01f));
				player.SetPerform(1);
			}
		}
		public GSkill3458Stub()
			: base(3458)
		{
			occupation = 96;
			maxlevel = 12;
			maxlearn = 9;
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
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_ÉÙÑô»÷");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"Ì«ê»_ÉÙÑô»÷");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_ÉÙÑô»÷");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"Ì«ê»_Æï³Ë_ÉÙÑô»÷");
			SetAction(30,"0");
			name = "·çÀ×»÷";
			nativename = "·çÀ×»÷";
			icon = "·çÀ×»÷.dds";
			SetTalent(0,3516);
			SetTalent(1,3507);
			SetTalent(2,3456);
			SetTalent(3,3457);
			SetTalent(4,3508);
			SetTalent(5,3509);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 6;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 10;
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 5000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={30,32,34,36,38,40,42,44,46};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 55.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t3 = skill.GetT3();
			int				skill_t5 = skill.GetT5();

			victim.SetProbability(((2 * skill_t3 * skill_t5) + ((skill_t0 * 0.05f + (skill_level * 0.1f)) * player_var1)));
			victim.SetTime(((1000 * skill_level + 5000)));
			victim.SetRatio((skill_level * 0.02f));
			victim.SetBuffid(1);
			victim.SetWeak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

			victim.SetProbability(((5 * norm(player.GetSkilllevel(3584) / 19.99f) + (player.GetSkilllevel(3584) / 2 + (skill_t3 + (skill_t2 * skill_t4 + (5 * skill_t1)))) + 20)));
			victim.SetTime(15000.0f);
			victim.SetAmount(((player.GetSkilllevel(3852) + skill_level)));
			victim.SetValue(3703.0f);
			victim.SetTriggerskill(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(10.0f);
			victim.SetRatio(3703.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetSetcooldown(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3457};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3458 : GSkill
	{
		public GSkill3458()
			: base(3458)
		{
			
		}
	}
	public class GSkill3459Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				skill_level = skill.GetLevel();

				player.SetVar1((int)(player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))));
				skill.SetPlus(((5 * skill_level + 80)));
				skill.SetRatio((skill_level * 0.02f + 1.0f));
				player.SetPerform(1);
			}
		}
		public GSkill3459Stub()
			: base(3459)
		{
			occupation = 96;
			maxlevel = 10;
			maxlearn = 9;
			eventflag = 0;
			spcost = 0;
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
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"Ì«ê»_ÖÁÑô»÷");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"Ì«ê»_ÖÁÑô»÷");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_ÖÁÑô»÷");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"Ì«ê»_Æï³Ë_ÖÁÑô»÷");
			SetAction(30,"0");
			name = "Áú»¢¶·£¨·Ï£©";
			nativename = "Áú»¢¶·£¨·Ï£©";
			icon = "Áú»¢¶·.dds";
			SetTalent(0,3513);
			SetTalent(1,3506);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 2;
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 5000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 1.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 110.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res1 = player.GetRes1();
			int				player_res2 = player.GetRes2();
			int				player_res3 = player.GetRes3();
			int				player_res4 = player.GetRes4();
			int				player_res5 = player.GetRes5();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(0);
			victim.SetAmount(skill_level);
			victim.SetValue(3603.0f);
			victim.SetActiveonfilteradd(true);
			victim.SetProbability(((50 * skill_t0)));
			victim.SetAmount(skill_t0);
			victim.SetClearbuff(true);
			if ( player_var1 <= player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1))) )
			{
			v47 = 0.0f;
			}
			else
			{
			v47 = (10 * skill_t1 + (player_var1 - (player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1))))));
			}
			victim.SetProbability(v47);
			victim.SetTime(((5000 * skill_t1)));
			victim.SetRatio((skill_t1 * 0.3f + 1.0f));
			victim.SetValue((skill_t1 * 0.2f + 1.0f));
			victim.SetParalysis(true);
			*/
			return true;
		}
	}
	public class GSkill3459 : GSkill
	{
		public GSkill3459()
			: base(3459)
		{
			
		}
	}
}
