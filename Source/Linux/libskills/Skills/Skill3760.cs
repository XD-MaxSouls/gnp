using System;
using System.Text;

namespace SKILL
{
	public class GSkill3760Stub : GSkillStub
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
				int				player_var1 = player.GetVar1();

				/*
				player_var1;
				  zrand(2);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill3760Stub()
			: base(3760)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 2;
			timetype = 3;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 11;
			clearmask = 132;
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
			SetAction(0,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾Êìïþ¡¿");
			SetAction(1,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾Êìïþ¡¿");
			SetAction(2,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾Êìïþ¡¿");
			SetAction(3,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾Êìïþ¡¿");
			SetAction(4,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾Êìïþ¡¿");
			SetAction(5,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾Êìïþ¡¿");
			SetAction(6,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾Êìïþ¡¿");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾Êìïþ¡¿");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾Êìïþ¡¿");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾Êìïþ¡¿");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾Êìïþ¡¿");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾Êìïþ¡¿");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾Êìïþ¡¿");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾Êìïþ¡¿");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "×£ÈÚÕæµäII";
			nativename = "×£ÈÚÕæµäII";
			icon = "×£ÈÚÕæµäII.dds";
			SetTalent(0,3408);
			SetTalent(1,3758);
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
			cycle = true;
			cyclemode = 1;
			cyclegfx = "·¨ÕóÊìïþ";
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
			return 10000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

            return (int)(240000.0f - skill_t1 * 4800.0f);
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
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
			return 2000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((20 * skill_t0)));
			victim.SetBreakcasting(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_charging = skill.GetCharging();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * (skill_t1 + (5 * (skill_charging / 0x12C0) + (5 * player.GetCyclemembercnt() + skill_level))))));
			victim.SetRatio(((100 * zrand(2) + skill_level + 100)));
			victim.SetBuffid(0);
			victim.SetAmount(3856.0f);
			victim.SetValue(2.0f);
			victim.SetCycle(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * (skill_t1 + (5 * (skill_charging / 0x12C0) + (5 * player.GetCyclemembercnt() + skill_level))))));
			victim.SetRatio((skill_level * 0.02f));
			victim.SetBuffid(7);
			victim.SetIncskilldodge(true);
			if ( zrand(100) >= 2 * player.GetSkilllevel(3759) )
			v39 = 218.0f;
			else
			victim.SetRatio(3449.0f);
			victim.SetAmount(218.0f);
			victim.SetValue(218.0f);
			victim.SetClearcooldown(true);
			victim.SetTime(500.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetEvilaura(true);
			*/
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3450};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill3760 : GSkill
	{
		public GSkill3760()
			: base(3760)
		{
			
		}
	}
	public class GSkill3761Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill3761Stub()
			: base(3761)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"·ÙÏã¹È_ºì³¾ºÞ£ºÐþ");
			SetAction(1,"·ÙÏã¹È_ºì³¾ºÞ£ºÐþ");
			SetAction(2,"·ÙÏã¹È_ºì³¾ºÞ£ºÐþ");
			SetAction(3,"·ÙÏã¹È_ºì³¾ºÞ£ºÐþ");
			SetAction(4,"·ÙÏã¹È_ºì³¾ºÞ£ºÐþ");
			SetAction(5,"·ÙÏã¹È_ºì³¾ºÞ£ºÐþ");
			SetAction(6,"·ÙÏã¹È_ºì³¾ºÞ£ºÐþ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ºì³¾ºÞ£ºÐþ");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ºì³¾ºÞ£ºÐþ");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ºì³¾ºÞ£ºÐþ");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ºì³¾ºÞ£ºÐþ");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ºì³¾ºÞ£ºÐþ");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ºì³¾ºÞ£ºÐþ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ºì³¾ºÞ£ºÐþ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ºì³¾ºÞ£º·Ù";
			nativename = "ºì³¾ºÞ£º·Ù";
			icon = "ºì³¾ºÞ·Ù.dds";
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
			return 360000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 19.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(30000.0f);
			victim.SetRatio(0.75f);
			victim.SetBuffid(1);
			victim.SetDecskilldamage(true);
			victim.SetProbability(120.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(0.25f);
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			victim.SetTime(15000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((zrand(3) + 1)));
			victim.SetTurnbuff(true);
			return true;
		}
	}
	public class GSkill3761 : GSkill
	{
		public GSkill3761()
			: base(3761)
		{
			
		}
	}
	public class GSkill3762Stub : GSkillStub
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(1);
				skill.SetRatio((zrand(100) * 0.01f + 1.5f));
				player.SetPerform(1);
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(2);
				skill.SetRatio((zrand(100) * 0.01f + 1.5f));
				player.SetPerform(0);
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(3);
				skill.SetRatio((zrand(100) * 0.01f + 1.5f));
				player.SetPerform(0);
			}
		}
		public GSkill3762Stub()
			: base(3762)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 0;
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
			SetAction(0,"·ÙÏã¹È_É½ºÓÄæ£ºÐþ");
			SetAction(1,"·ÙÏã¹È_É½ºÓÄæ£ºÐþ");
			SetAction(2,"·ÙÏã¹È_É½ºÓÄæ£ºÐþ");
			SetAction(3,"·ÙÏã¹È_É½ºÓÄæ£ºÐþ");
			SetAction(4,"·ÙÏã¹È_É½ºÓÄæ£ºÐþ");
			SetAction(5,"·ÙÏã¹È_É½ºÓÄæ£ºÐþ");
			SetAction(6,"·ÙÏã¹È_É½ºÓÄæ£ºÐþ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_É½ºÓÄæ£ºÐþ");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_É½ºÓÄæ£ºÐþ");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_É½ºÓÄæ£ºÐþ");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_É½ºÓÄæ£ºÐþ");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_É½ºÓÄæ£ºÐþ");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_É½ºÓÄæ£ºÐþ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_É½ºÓÄæ£ºÐþ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "É½ºÓÄæ£º·Ù";
			nativename = "É½ºÓÄæ£º·Ù";
			icon = "É½ºÓÄæ·Ù.dds";
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 360000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 2000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 36;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res2 = player.GetRes2();
			int				player_res4 = player.GetRes4();

			/*
			victim.SetProbability(15.0f);
			victim.SetBreakcasting(true);
			if ( zrand(100) > 14 )
			t = 0.0f;
			else
			victim.SetTime(16000.0f);
			victim.SetBuffid(1);
			victim.SetValue(player_res2);
			victim.SetSubantiweak(true);
			victim.SetTime(16000.0f);
			victim.SetBuffid(1);
			victim.SetValue(player_res4);
			victim.SetSubantisilent(true);
			*/
			return true;
		}
	}
	public class GSkill3762 : GSkill
	{
		public GSkill3762()
			: base(3762)
		{
			
		}
	}
	public class GSkill3763Stub : GSkillStub
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
				int				player_res2 = player.GetRes2();

				player.SetVar1(player_res2);
				player.SetVar2(player_level);
				skill.SetRatio(2.0f);
				player.SetPerform(1);
			}
		}
		public GSkill3763Stub()
			: base(3763)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
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
			weapon_limit = -1;
			SetAction(0,"·ÙÏã¹È_¾øÇééä£ºÐþ");
			SetAction(1,"·ÙÏã¹È_¾øÇééä£ºÐþ");
			SetAction(2,"·ÙÏã¹È_¾øÇééä£ºÐþ");
			SetAction(3,"·ÙÏã¹È_¾øÇééä£ºÐþ");
			SetAction(4,"·ÙÏã¹È_¾øÇééä£ºÐþ");
			SetAction(5,"·ÙÏã¹È_¾øÇééä£ºÐþ");
			SetAction(6,"·ÙÏã¹È_¾øÇééä£ºÐþ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_¾øÇééä£ºÐþ");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_¾øÇééä£ºÐþ");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_¾øÇééä£ºÐþ");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_¾øÇééä£ºÐþ");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_¾øÇééä£ºÐþ");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_¾øÇééä£ºÐþ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_¾øÇééä£ºÐþ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¾øÇééä£º·Ù";
			nativename = "¾øÇééä£º·Ù";
			icon = "¾øÇééä·Ù.dds";
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
			return 360000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 900.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();

			victim.SetProbability(player_var1);
			victim.SetTime(15000.0f);
			victim.SetRatio(0.25f);
			victim.SetBuffid(6);
			victim.SetWeak(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(15000.0f);
			victim.SetRatio(0.60000002f);
			victim.SetInchurt(true);
			victim.SetProbability(100.0f);
			victim.SetValue(((player_var2 * (zrand(51) + 50))));
			victim.SetDirecthurt(true);
			victim.SetProbability(120.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(9);
			victim.SetValue(3854.0f);
			victim.SetDelaycast(true);
			return true;
		}
	}
	public class GSkill3763 : GSkill
	{
		public GSkill3763()
			: base(3763)
		{
			
		}
	}
	public class GSkill3764Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill3764Stub()
			: base(3764)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
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
			SetAction(0,"·ÙÏã¹È_¹íÉñÍ¨£ºÐþ");
			SetAction(1,"·ÙÏã¹È_¹íÉñÍ¨£ºÐþ");
			SetAction(2,"·ÙÏã¹È_¹íÉñÍ¨£ºÐþ");
			SetAction(3,"·ÙÏã¹È_¹íÉñÍ¨£ºÐþ");
			SetAction(4,"·ÙÏã¹È_¹íÉñÍ¨£ºÐþ");
			SetAction(5,"·ÙÏã¹È_¹íÉñÍ¨£ºÐþ");
			SetAction(6,"·ÙÏã¹È_¹íÉñÍ¨£ºÐþ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_¹íÉñÍ¨£ºÐþ");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_¹íÉñÍ¨£ºÐþ");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_¹íÉñÍ¨£ºÐþ");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_¹íÉñÍ¨£ºÐþ");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_¹íÉñÍ¨£ºÐþ");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_¹íÉñÍ¨£ºÐþ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_¹íÉñÍ¨£ºÐþ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¹íÉñÍ¨£º·Ù";
			nativename = "¹íÉñÍ¨£º·Ù";
			icon = "¹íÉñÍ¨·Ù.dds";
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
			return 360000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1200.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(60000.0f);
			victim.SetRatio(10.0f);
			victim.SetBuffid(2);
			victim.SetAmount(1.0f);
			victim.SetValue(3853.0f);
			victim.SetAddcommon(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(60000.0f);
			victim.SetRatio(0.15001f);
			victim.SetBuffid(3);
			victim.SetIncskillaccu(true);
			return true;
		}
	}
	public class GSkill3764 : GSkill
	{
		public GSkill3764()
			: base(3764)
		{
			
		}
	}
	public class GSkill3765Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill3765Stub()
			: base(3765)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"·ÙÏã¹È_ºì³¾ºÞ£ºÐþ");
			SetAction(1,"·ÙÏã¹È_ºì³¾ºÞ£ºÐþ");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"·ÙÏã¹È_ºì³¾ºÞ£ºÐþ");
			SetAction(5,"0");
			SetAction(6,"·ÙÏã¹È_ºì³¾ºÞ£ºÐþ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ºì³¾ºÞ£ºÐþ");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ºì³¾ºÞ£ºÐþ");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ºì³¾ºÞ£ºÐþ");
			SetAction(23,"0");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ºì³¾ºÞ£ºÐþ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ºì³¾ºÞ£ºÐþ";
			nativename = "ºì³¾ºÞ£ºÐþ";
			icon = "ºì³¾ºÞ·Ù.dds";
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
			return 360000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 19.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(30000.0f);
			victim.SetRatio(0.75f);
			victim.SetBuffid(1);
			victim.SetDecskilldamage(true);
			victim.SetProbability(120.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(0.25f);
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			victim.SetProbability(600.0f);
			victim.SetTime(15000.0f);
			victim.SetRatio(0.5f);
			victim.SetBuffid(0);
			victim.SetSlow(true);
			victim.SetProbability(100.0f);
			victim.SetAmount(((zrand(3) + 1)));
			victim.SetClearbuff(true);
			return true;
		}
	}
	public class GSkill3765 : GSkill
	{
		public GSkill3765()
			: base(3765)
		{
			
		}
	}
	public class GSkill3766Stub : GSkillStub
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(1);
				skill.SetRatio((zrand(100) * 0.01f + 1.5f));
				player.SetPerform(1);
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(2);
				skill.SetRatio((zrand(100) * 0.01f + 1.5f));
				player.SetPerform(0);
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(3);
				skill.SetRatio((zrand(100) * 0.01f + 1.5f));
				player.SetPerform(0);
			}
		}
		public GSkill3766Stub()
			: base(3766)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 0;
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
			SetAction(0,"·ÙÏã¹È_É½ºÓÄæ£ºÐþ");
			SetAction(1,"·ÙÏã¹È_É½ºÓÄæ£ºÐþ");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"·ÙÏã¹È_É½ºÓÄæ£ºÐþ");
			SetAction(5,"0");
			SetAction(6,"·ÙÏã¹È_É½ºÓÄæ£ºÐþ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_É½ºÓÄæ£ºÐþ");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_É½ºÓÄæ£ºÐþ");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_É½ºÓÄæ£ºÐþ");
			SetAction(23,"0");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_É½ºÓÄæ£ºÐþ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "É½ºÓÄæ£ºÐþ";
			nativename = "É½ºÓÄæ£ºÐþ";
			icon = "É½ºÓÄæ·Ù.dds";
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 360000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 2000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 36;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res2 = player.GetRes2();
			int				player_res3 = player.GetRes3();

			/*
			victim.SetProbability(15.0f);
			victim.SetBreakcasting(true);
			if ( zrand(100) > 14 )
			t = 0.0f;
			else
			victim.SetTime(16000.0f);
			victim.SetBuffid(1);
			victim.SetValue(player_res2);
			victim.SetSubantiweak(true);
			victim.SetProbability(((player_res3 + 99)));
			victim.SetTime(6100.0f);
			victim.SetWrap(true);
			*/
			return true;
		}
	}
	public class GSkill3766 : GSkill
	{
		public GSkill3766()
			: base(3766)
		{
			
		}
	}
	public class GSkill3767Stub : GSkillStub
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
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_res2 = player.GetRes2();

				player.SetVar1(player_res2);
				player.SetVar2(player_level);
				skill.SetRatio((norm(player_mp / (player_maxmp * 0.75f + 1.0f)) * 0.3f + 2.0f));
				player.SetPerform(1);
			}
		}
		public GSkill3767Stub()
			: base(3767)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
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
			weapon_limit = -1;
			SetAction(0,"·ÙÏã¹È_¾øÇééä£ºÐþ");
			SetAction(1,"·ÙÏã¹È_¾øÇééä£ºÐþ");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"·ÙÏã¹È_¾øÇééä£ºÐþ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_¾øÇééä£ºÐþ");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_¾øÇééä£ºÐþ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¾øÇééä£ºÐþ";
			nativename = "¾øÇééä£ºÐþ";
			icon = "¾øÇééä·Ù.dds";
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
			return 360000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 900.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();

			victim.SetProbability(player_var1);
			victim.SetTime(15000.0f);
			victim.SetRatio(0.25f);
			victim.SetBuffid(6);
			victim.SetWeak(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(15000.0f);
			victim.SetRatio(0.60000002f);
			victim.SetInchurt(true);
			victim.SetProbability(100.0f);
			victim.SetValue(((player_var2 * (zrand(51) + 50))));
			victim.SetDirecthurt(true);
			return true;
		}
	}
	public class GSkill3767 : GSkill
	{
		public GSkill3767()
			: base(3767)
		{
			
		}
	}
	public class GSkill3768Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill3768Stub()
			: base(3768)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
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
			SetAction(0,"·ÙÏã¹È_¹íÉñÍ¨£ºÐþ");
			SetAction(1,"·ÙÏã¹È_¹íÉñÍ¨£ºÐþ");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"·ÙÏã¹È_¹íÉñÍ¨£ºÐþ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_¹íÉñÍ¨£ºÐþ");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_¹íÉñÍ¨£ºÐþ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¹íÉñÍ¨£ºÐþ";
			nativename = "¹íÉñÍ¨£ºÐþ";
			icon = "¹íÉñÍ¨·Ù.dds";
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
			return 360000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1200.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(60000.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(2);
			victim.SetAmount(1.0f);
			victim.SetValue(3853.0f);
			victim.SetAddcommon(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(16000.0f);
			victim.SetRatio(0.25001001f);
			victim.SetBuffid(3);
			victim.SetIncskilldodge(true);
			return true;
		}
	}
	public class GSkill3768 : GSkill
	{
		public GSkill3768()
			: base(3768)
		{
			
		}
	}
	public class GSkill3769Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill3769Stub()
			: base(3769)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"·ÙÏã¹È_ºì³¾ºÞ£ºÐþ");
			SetAction(1,"·ÙÏã¹È_ºì³¾ºÞ£ºÐþ");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"·ÙÏã¹È_ºì³¾ºÞ£ºÐþ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ºì³¾ºÞ£ºÐþ");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ºì³¾ºÞ£ºÐþ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ºì³¾ºÞ£º°Ô";
			nativename = "ºì³¾ºÞ£º°Ô";
			icon = "ºì³¾ºÞ·Ù.dds";
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
			return 360000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 19.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			victim.SetTime(30000.0f);
			victim.SetRatio(0.75f);
			victim.SetBuffid(1);
			victim.SetDecskilldamage(true);
			victim.SetProbability(120.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(0.25f);
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			victim.SetProbability(100.0f);
			victim.SetAmount(((zrand(3) + 1)));
			victim.SetClearbuff(true);
			victim.SetProbability(120.0f);
			victim.SetTime(15100.0f);
			victim.SetBuffid(0);
			victim.SetAmount((player_maxhp * 0.5f));
			victim.SetValue(5000.0f);
			victim.SetSubhp(true);
			return true;
		}
	}
	public class GSkill3769 : GSkill
	{
		public GSkill3769()
			: base(3769)
		{
			
		}
	}
}
