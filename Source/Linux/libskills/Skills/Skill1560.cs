using System;
using System.Text;

namespace SKILL
{
	public class GSkill1560Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill1560Stub()
			: base(1560)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
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
			credittype = 10;
			clearmask = 130;
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
			SetAction(0,"ºÏ»¶ÅÉ_¾ö¾ø");
			SetAction(1,"ºÏ»¶ÅÉ_¾ö¾ø");
			SetAction(2,"ºÏ»¶ÅÉ_¾ö¾ø");
			SetAction(3,"ºÏ»¶ÅÉ_¾ö¾ø");
			SetAction(4,"ºÏ»¶ÅÉ_¾ö¾ø");
			SetAction(5,"ºÏ»¶ÅÉ_¾ö¾ø");
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
			SetAction(18,"ºÏ»¶ÅÉ_Æï³Ë_¾ö¾ø");
			SetAction(19,"ºÏ»¶ÅÉ_Æï³Ë_¾ö¾ø");
			SetAction(20,"ºÏ»¶ÅÉ_Æï³Ë_¾ö¾ø");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¾ö¾ø");
			SetAction(22,"ºÏ»¶ÅÉ_Æï³Ë_¾ö¾ø");
			SetAction(23,"ºÏ»¶ÅÉ_Æï³Ë_¾ö¾ø");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "¾ö¾øII";
			nativename = "¾ö¾øII";
			icon = "¾ö¾øII.dds";
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
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 1;
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
			int				skill_level = skill.GetLevel();

			return 380000 - 20000 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return (15 * skill_level + 700);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(30100.0f);
			victim.SetRatio((skill_level * 0.06f));
			victim.SetBuffid(1);
			victim.SetIncanti(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30100.0f);
			victim.SetRatio((skill_level * 0.0601f));
			victim.SetBuffid(1);
			victim.SetIncskillaccu(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={292};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={8};return array[index];
		}
	}
	public class GSkill1560 : GSkill
	{
		public GSkill1560()
			: base(1560)
		{
			
		}
	}
	public class GSkill1561Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio((skill_level * 0.03f + 1.0f));
				player.SetPerform(1);
			}
		}
		public GSkill1561Stub()
			: base(1561)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = true;
			allowform = 0;
			credittype = 10;
			clearmask = 130;
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
			SetAction(0,"ºÏ»¶ÅÉ_É½ÃË");
			SetAction(1,"ºÏ»¶ÅÉ_É½ÃË");
			SetAction(2,"ºÏ»¶ÅÉ_É½ÃË");
			SetAction(3,"ºÏ»¶ÅÉ_É½ÃË");
			SetAction(4,"ºÏ»¶ÅÉ_É½ÃË");
			SetAction(5,"ºÏ»¶ÅÉ_É½ÃË");
			SetAction(6,"0");
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
			SetAction(18,"ºÏ»¶ÅÉ_Æï³Ë_É½ÃË");
			SetAction(19,"ºÏ»¶ÅÉ_Æï³Ë_É½ÃË");
			SetAction(20,"ºÏ»¶ÅÉ_Æï³Ë_É½ÃË");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_É½ÃË");
			SetAction(22,"ºÏ»¶ÅÉ_Æï³Ë_É½ÃË");
			SetAction(23,"ºÏ»¶ÅÉ_Æï³Ë_É½ÃË");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "É½ÃËII";
			nativename = "É½ÃËII";
			icon = "É½ÃËII.dds";
			SetTalent(0,324);
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
			skill_class = 1;
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
			return 16000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
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
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (30 * skill_level + 950);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_def = player.GetDef();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(100.0f);
			victim.SetTime(100.0f);
			victim.SetBuffid(1);
			victim.SetValue((player_def + (player_maxhp * (skill_level * 0.02f))));
			victim.SetBleeding(true);
			victim.SetProbability(((skill_level * (skill_t0 / 2.99f) + (5 * skill_level))));
			victim.SetTime(((1000 * (skill_t0 / 2.99f) + 4100)));
			victim.SetDiet(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={324};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill1561 : GSkill
	{
		public GSkill1561()
			: base(1561)
		{
			
		}
	}
	public class GSkill1562Stub : GSkillStub
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

				skill.SetRatio((skill_level * 0.02f + 1.0f));
				skill.SetPlus((skill_level * ((player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) * 0.5f)));
				player.SetPerform(1);
			}
		}
		public GSkill1562Stub()
			: base(1562)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = true;
			allowform = 0;
			credittype = 10;
			clearmask = 130;
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
			SetAction(0,"ºÏ»¶ÅÉ_ÏÐÓê");
			SetAction(1,"ºÏ»¶ÅÉ_ÏÐÓê");
			SetAction(2,"ºÏ»¶ÅÉ_ÏÐÓê");
			SetAction(3,"ºÏ»¶ÅÉ_ÏÐÓê");
			SetAction(4,"ºÏ»¶ÅÉ_ÏÐÓê");
			SetAction(5,"ºÏ»¶ÅÉ_ÏÐÓê");
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
			SetAction(18,"ºÏ»¶ÅÉ_Æï³Ë_ÏÐÓê");
			SetAction(19,"ºÏ»¶ÅÉ_Æï³Ë_ÏÐÓê");
			SetAction(20,"ºÏ»¶ÅÉ_Æï³Ë_ÏÐÓê");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_ÏÐÓê");
			SetAction(22,"ºÏ»¶ÅÉ_Æï³Ë_ÏÐÓê");
			SetAction(23,"ºÏ»¶ÅÉ_Æï³Ë_ÏÐÓê");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÔÆÓêII";
			nativename = "ÔÆÓêII";
			icon = "ÔÆÓêII.dds";
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
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 1;
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
			return 16000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return (35 * skill_level + 950);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(8100.0f);
			victim.SetBuffid(1);
			victim.SetValue(((60 * (3 - (2 * player_mp + 2) / (player_maxmp + 1)) * skill_level)));
			victim.SetSubdefence(true);
			victim.SetProbability(100.0f);
			victim.SetTime(8100.0f);
			victim.SetRatio(((3 - (2 * player_mp + 2) / (player_maxmp + 1)) * (skill_level * 0.01f)));
			victim.SetBuffid(1);
			victim.SetDecskillaccu(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={532};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill1562 : GSkill
	{
		public GSkill1562()
			: base(1562)
		{
			
		}
	}
	public class GSkill1563Stub : GSkillStub
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
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1((int)(player_res4 + 80));
				skill.SetRatio(((skill_t2 + (skill_t1 + skill_t0)) * 0.04f + (skill_level * 0.02f + 1.0f)));
				player.SetPerform(1);
			}
		}
		public GSkill1563Stub()
			: base(1563)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 1;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 10;
			clearmask = 130;
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
			SetAction(0,"ÇàÔÆÃÅ_ËªÈÐ¾ö");
			SetAction(1,"ÇàÔÆÃÅ_ËªÈÐ¾ö");
			SetAction(2,"ÇàÔÆÃÅ_ËªÈÐ¾ö");
			SetAction(3,"ÇàÔÆÃÅ_ËªÈÐ¾ö");
			SetAction(4,"ÇàÔÆÃÅ_ËªÈÐ¾ö");
			SetAction(5,"ÇàÔÆÃÅ_ËªÈÐ¾ö");
			SetAction(6,"0");
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
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_ËªÈÐ¾ö");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ËªÈÐ¾ö");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_ËªÈÐ¾ö");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_ËªÈÐ¾ö");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_ËªÈÐ¾ö");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_ËªÈÐ¾ö");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "º®Ëª½£ÆøII";
			nativename = "º®Ëª½£ÆøII";
			icon = "º®Ëª½£ÆøII.dds";
			SetTalent(0,1564);
			SetTalent(1,2054);
			SetTalent(2,2055);
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
			skill_class = 2;
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
			return 16000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.700000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (10 * skill_level + 1500);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(600.0f);
			victim.SetTime(16100.0f);
			victim.SetRatio((skill_level * 0.05f + 0.15f));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetProbability((player_var1 <= 600)?(600 * norm(zrand(100) / (100 - 2 * skill_level))):(player_var1 * norm(zrand(100) / (100 - 2 * skill_level))));
			victim.SetTime(6100.0f);
			victim.SetSilent(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={226};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill1563 : GSkill
	{
		public GSkill1563()
			: base(1563)
		{
			
		}
	}
	public class GSkill1564Stub : GSkillStub
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
				int				player_res1 = player.GetRes1();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1((int)(2 * skill_level + player_res1));
				skill.SetRatio(((skill_t2 + (skill_t1 + skill_t0)) * 0.04f + (skill_level * 0.04f + 1.0f)));
				player.SetPerform(1);
			}
		}
		public GSkill1564Stub()
			: base(1564)
		{
			occupation = 149;
			maxlevel = 12;
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
			autoattack = true;
			allowform = 0;
			credittype = 10;
			clearmask = 130;
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
			SetAction(0,"ÇàÔÆÃÅ_ÌìÍâ·ÉÏÉ");
			SetAction(1,"ÇàÔÆÃÅ_ÌìÍâ·ÉÏÉ");
			SetAction(2,"ÇàÔÆÃÅ_ÌìÍâ·ÉÏÉ");
			SetAction(3,"ÇàÔÆÃÅ_ÌìÍâ·ÉÏÉ");
			SetAction(4,"ÇàÔÆÃÅ_ÌìÍâ·ÉÏÉ");
			SetAction(5,"ÇàÔÆÃÅ_ÌìÍâ·ÉÏÉ");
			SetAction(6,"0");
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
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_ÌìÍâ·ÉÏÉ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ÌìÍâ·ÉÏÉ");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_ÌìÍâ·ÉÏÉ");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_ÌìÍâ·ÉÏÉ");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_ÌìÍâ·ÉÏÉ");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_ÌìÍâ·ÉÏÉ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÌìÍâ·ÉÏÉII";
			nativename = "ÌìÍâ·ÉÏÉII";
			icon = "ÌìÍâ·ÉÏÉII.dds";
			SetTalent(0,1563);
			SetTalent(1,2054);
			SetTalent(2,2055);
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
			skill_class = 2;
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
			return 16000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (25 * skill_level + 2200);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((3 * skill_level + 7)));
			victim.SetTime(6100.0f);
			victim.SetBuffid(3);
			victim.SetAmount(2000.0f);
			victim.SetValue(player_maxmp);
			victim.SetSubmp(true);
			victim.SetProbability((player_var1 <= 600)?(600 * norm(zrand(100) / (100 - 5 * skill_level))):(player_var1 * norm(zrand(100) / (100 - 5 * skill_level))));
			victim.SetTime(3100.0f);
			victim.SetDizzy(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={240};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill1564 : GSkill
	{
		public GSkill1564()
			: base(1564)
		{
			
		}
	}
	public class GSkill1565Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				skill.SetCrithurt((skill_t0 * 0.15f));
				skill.SetRatio((skill_t0 * (skill_level * 0.04f) + (skill_level * 0.14f + 1.0f)));
				player.SetPerform(1);
			}
		}
		public GSkill1565Stub()
			: base(1565)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = true;
			allowform = 0;
			credittype = 10;
			clearmask = 130;
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
			SetAction(0,"ÇàÔÆÃÅ_ÕæÔª»ªÉÁ");
			SetAction(1,"ÇàÔÆÃÅ_ÕæÔª»ªÉÁ");
			SetAction(2,"ÇàÔÆÃÅ_ÕæÔª»ªÉÁ");
			SetAction(3,"ÇàÔÆÃÅ_ÕæÔª»ªÉÁ");
			SetAction(4,"ÇàÔÆÃÅ_ÕæÔª»ªÉÁ");
			SetAction(5,"ÇàÔÆÃÅ_ÕæÔª»ªÉÁ");
			SetAction(6,"0");
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
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_ÕæÔª»ªÉÁ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ÕæÔª»ªÉÁ");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_ÕæÔª»ªÉÁ");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_ÕæÔª»ªÉÁ");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_ÕæÔª»ªÉÁ");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_ÕæÔª»ªÉÁ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÕæÔª»ªÉÁII";
			nativename = "ÕæÔª»ªÉÁII";
			icon = "ÕæÔª»ªÉÁII.dds";
			SetTalent(0,598);
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
			skill_class = 2;
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
			int				skill_level = skill.GetLevel();

			return 380000 - 20000 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 17);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 11);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 22);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (25 * skill_level + 1950);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				skill_t0 = skill.GetT0();

			victim.SetRatio(((skill_t0 * (player.GetBuffcnt() * 0.02f) + 1.0f) * (((player_maxhp + 5000) * 0.2f) / (player_hp + 5000) + 1.0f)));
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetSecondattack(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={542};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={7};return array[index];
		}
	}
	public class GSkill1565 : GSkill
	{
		public GSkill1565()
			: base(1565)
		{
			
		}
	}
	public class GSkill1566Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio((skill_level * 0.02f + 1.0f));
				player.SetPerform(1);
			}
		}
		public GSkill1566Stub()
			: base(1566)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 10;
			clearmask = 130;
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
			SetAction(0,"ÌìÒôËÂ_´ó±¯Öä");
			SetAction(1,"ÌìÒôËÂ_´ó±¯Öä");
			SetAction(2,"ÌìÒôËÂ_´ó±¯Öä");
			SetAction(3,"ÌìÒôËÂ_´ó±¯Öä");
			SetAction(4,"ÌìÒôËÂ_´ó±¯Öä");
			SetAction(5,"ÌìÒôËÂ_´ó±¯Öä");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_´ó±¯Öä");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_´ó±¯Öä");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_´ó±¯Öä");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_´ó±¯Öä");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_´ó±¯Öä");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_´ó±¯Öä");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "´ó±¯ÖäII";
			nativename = "´ó±¯ÖäII";
			icon = "´ó±¯ÖäII.dds";
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
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 3;
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
			return 60000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (350 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_minatk = player.GetMinatk();
			int				player_maxatk = player.GetMaxatk();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_level)));
			victim.SetBuffid(0);
			victim.SetValue(((player_minatk + player_maxatk) * (skill_level * 0.05f + 0.45f) / 2.0f));
			victim.SetBleeding(true);
			victim.SetProbability(((120 * norm(skill_level / 4.9f))));
			victim.SetAmount(((skill_level / 4.9f)));
			victim.SetClearbuff(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={266};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={12};return array[index];
		}
	}
	public class GSkill1566 : GSkill
	{
		public GSkill1566()
			: base(1566)
		{
			
		}
	}
	public class GSkill1567Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill1567Stub()
			: base(1567)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 10;
			clearmask = 130;
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
			SetAction(0,"ÌìÒôËÂ_·ð¹âÆÕÕÕ");
			SetAction(1,"ÌìÒôËÂ_·ð¹âÆÕÕÕ");
			SetAction(2,"ÌìÒôËÂ_·ð¹âÆÕÕÕ");
			SetAction(3,"ÌìÒôËÂ_·ð¹âÆÕÕÕ");
			SetAction(4,"ÌìÒôËÂ_·ð¹âÆÕÕÕ");
			SetAction(5,"ÌìÒôËÂ_·ð¹âÆÕÕÕ");
			SetAction(6,"0");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_·ð¹âÆÕÕÕ");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_·ð¹âÆÕÕÕ");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_·ð¹âÆÕÕÕ");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_·ð¹âÆÕÕÕ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·ð¹âÆÕÕÕ");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_·ð¹âÆÕÕÕ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "·ð¹âÆÕÕÕII";
			nativename = "·ð¹âÆÕÕÕII";
			icon = "·ð¹âÆÕÕÕII.dds";
			SetTalent(0,277);
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
			skill_class = 3;
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
			return 16000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (400 * skill_level);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetTime(60100.0f);
			victim.SetRatio(((8 * skill_level * skill_level + (50 * skill_level)) * (skill_t0 * 0.2f + 1.0f)));
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetCrazy(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={277};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={12};return array[index];
		}
	}
	public class GSkill1567 : GSkill
	{
		public GSkill1567()
			: base(1567)
		{
			
		}
	}
	public class GSkill1568Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio((skill_level * 0.01f + 1.0f));
				player.SetPerform(1);
			}
		}
		public GSkill1568Stub()
			: base(1568)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 10;
			clearmask = 130;
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
			SetAction(0,"ÌìÒôËÂ_°ãÈô²¨ÂÞÃÛ");
			SetAction(1,"ÌìÒôËÂ_°ãÈô²¨ÂÞÃÛ");
			SetAction(2,"ÌìÒôËÂ_°ãÈô²¨ÂÞÃÛ");
			SetAction(3,"ÌìÒôËÂ_°ãÈô²¨ÂÞÃÛ");
			SetAction(4,"ÌìÒôËÂ_°ãÈô²¨ÂÞÃÛ");
			SetAction(5,"ÌìÒôËÂ_°ãÈô²¨ÂÞÃÛ");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_°ãÈô²¨ÂÞÃÛ");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_°ãÈô²¨ÂÞÃÛ");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_°ãÈô²¨ÂÞÃÛ");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_°ãÈô²¨ÂÞÃÛ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_°ãÈô²¨ÂÞÃÛ");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_°ãÈô²¨ÂÞÃÛ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "¾»ÍÁÕæÑÔII";
			nativename = "¾»ÍÁÕæÑÔII";
			icon = "¾»ÍÁÕæÑÔII.dds";
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
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 3;
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
			int				skill_level = skill.GetLevel();

			return 31000 - 1000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (150 * skill_level + 1560);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				player_mp = player.GetMp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(60000.0f);
			victim.SetBuffid(4);
			victim.SetAmount(((zrand(player_hp * skill_level) + 30)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(60000.0f);
			victim.SetBuffid(4);
			victim.SetAmount(((zrand(player_mp * skill_level) + 30)));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={548};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={12};return array[index];
		}
	}
	public class GSkill1568 : GSkill
	{
		public GSkill1568()
			: base(1568)
		{
			
		}
	}
	public class GSkill1569Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 0;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill1569Stub()
			: base(1569)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 1;
			targettype = 0;
			rangetype = 5;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 10;
			clearmask = 130;
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
			SetAction(0,"±äÉí");
			SetAction(1,"±äÉí");
			SetAction(2,"±äÉí");
			SetAction(3,"±äÉí");
			SetAction(4,"±äÉí");
			SetAction(5,"±äÉí");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"±äÉí");
			SetAction(19,"±äÉí");
			SetAction(20,"±äÉí");
			SetAction(21,"±äÉí");
			SetAction(22,"±äÉí");
			SetAction(23,"±äÉí");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¹ÆÍõ×ËÌ¬II";
			nativename = "¹ÆÍõ×ËÌ¬II";
			icon = "¹ÆÍõ×ËÌ¬II.dds";
			SetTalent(0,1140);
			SetTalent(1,1181);
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
			skill_class = 4;
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 10;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return 12500 - 3000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(0.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(((60 * skill_t1 * (skill_level * skill_level) + (100 * skill_t1 * skill_level)) + 240 * skill_level * skill_level + (400 * skill_level)));
			victim.SetAmount(((5 * skill_level + 25)));
			victim.SetValue(((5 * skill_level * skill_level + (65 * skill_level))));
			victim.SetInsanityform(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((4000 * norm(skill_t1))));
			victim.SetRatio((skill_t1 * 0.25f));
			victim.SetAmount(0.0f);
			victim.SetValue(100.0f);
			victim.SetRetort(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1106};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={8};return array[index];
		}
	}
	public class GSkill1569 : GSkill
	{
		public GSkill1569()
			: base(1569)
		{
			
		}
	}
}
