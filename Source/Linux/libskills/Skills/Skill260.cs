using System;
using System.Text;

namespace SKILL
{
	public class GSkill260Stub : GSkillStub
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
		public GSkill260Stub()
			: base(260)
		{
			occupation = 1;
			maxlevel = 12;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			SetAction(0,"¹íÍõ×Ú_Èñ½ğÖä");
			SetAction(1,"¹íÍõ×Ú_Èñ½ğÖä");
			SetAction(2,"¹íÍõ×Ú_Èñ½ğÖä");
			SetAction(3,"¹íÍõ×Ú_Èñ½ğÖä");
			SetAction(4,"¹íÍõ×Ú_Èñ½ğÖä");
			SetAction(5,"¹íÍõ×Ú_Èñ½ğÖä");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_Èñ½ğÖä");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_Èñ½ğÖä");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Èñ½ğÖä");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_Èñ½ğÖä");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_Èñ½ğÖä");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_Èñ½ğÖä");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Èñ½ğÖä";
			nativename = "Èñ½ğÖä";
			icon = "Èñ½ğÖä.dds";
			SetTalent(0,637);
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
			skill_class = 0;
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
			return 2000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={35,40,45,49,51};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((52 * skill_level) + (skill_level * (skill_level * 0.24f)) + 124.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 30;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetTime(((900000 * skill_t0 + 1800000)));
			victim.SetRatio((skill_t0 * 0.01f + (skill_level * 0.01f)));
			victim.SetBuffid(2);
			victim.SetIncattack(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={245};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill260 : GSkill
	{
		public GSkill260()
			: base(260)
		{
			
		}
	}
	public class GSkill261Stub : GSkillStub
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
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetCrit((skill_t3 * 0.01f));
				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetPlus((((8 * skill_level) + (skill_level * (skill_level * 0.42f)) + 17.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 4.4f + (skill_level * (skill_level * 0.022f)) + 74.0f) * (D2INT(1.42f - skill_level * 0.05f)) + ((3 * skill_level * skill_t3)))));
				player.SetPerform(1);
			}
		}
		public GSkill261Stub()
			: base(261)
		{
			occupation = 1;
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
			SetAction(0,"¹íÍõ×Ú_ÄæË®Öä");
			SetAction(1,"¹íÍõ×Ú_ÄæË®Öä");
			SetAction(2,"¹íÍõ×Ú_ÄæË®Öä");
			SetAction(3,"¹íÍõ×Ú_ÄæË®Öä");
			SetAction(4,"¹íÍõ×Ú_ÄæË®Öä");
			SetAction(5,"¹íÍõ×Ú_ÄæË®Öä");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÄæË®Öä");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ÄæË®Öä");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÄæË®Öä");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ÄæË®Öä");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ÄæË®Öä");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_ÄæË®Öä");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÄæË®Öä";
			nativename = "ÄæË®Öä";
			icon = "ÄæË®Öä.dds";
			SetTalent(0,622);
			SetTalent(1,634);
			SetTalent(2,638);
			SetTalent(3,656);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 4;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 0;
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
			return 6000;
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
			return 1.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.57f + (skill_level * (skill_level * 0.2f)) + 46.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((3 * skill_level + 80)));
			victim.SetTime(((3000 * skill_t2 + (500 * skill_level) + 9600)));
			victim.SetRatio((skill_t2 * 0.1f + (skill_level * 0.03f + 0.35f)));
			victim.SetBuffid(3);
			victim.SetSlow(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(100.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_level * (skill_t0 * 0.9f)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((2 * skill_level)));
			victim.SetTime(100.0f);
			victim.SetBuffid(2);
			victim.SetAmount((player_hp * (skill_t1 * 0.12f)));
			victim.SetValue(0.0f);
			victim.SetHpleak1(true);
			victim.SetProbability(((10 * skill_level)));
			victim.SetRatio(11.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetDispel(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={251};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill261 : GSkill
	{
		public GSkill261()
			: base(261)
		{
			
		}
	}
	public class GSkill262Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 2400;
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill262Stub()
			: base(262)
		{
			occupation = 3;
			maxlevel = 12;
			maxlearn = 5;
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
			SetAction(0,"¹íÍõ×Ú_ÌìÄ§¸½Ìå");
			SetAction(1,"¹íÍõ×Ú_ÌìÄ§¸½Ìå");
			SetAction(2,"¹íÍõ×Ú_ÌìÄ§¸½Ìå");
			SetAction(3,"¹íÍõ×Ú_ÌìÄ§¸½Ìå");
			SetAction(4,"¹íÍõ×Ú_ÌìÄ§¸½Ìå");
			SetAction(5,"¹íÍõ×Ú_ÌìÄ§¸½Ìå");
			SetAction(6,"0");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§¸½Ìå");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§¸½Ìå");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§¸½Ìå");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§¸½Ìå");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§¸½Ìå");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§¸½Ìå");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÌìÄ§¸½Ìå";
			nativename = "ÌìÄ§¸½Ìå";
			icon = "ÌìÄ§¸½Ìå.dds";
			SetTalent(0,646);
			SetTalent(1,666);
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
			skill_class = 0;
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
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 6000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={95,99,103,105,107};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (((36 * skill_level + 59)) - skill_level * (skill_level * 0.95f));
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetTime(((900000 * skill_t1 + 1800000)));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t0 * 0.5f + 1.0f) * ((100 * skill_level))));
			victim.SetAddhp(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((900000 * skill_t1 + 1800000)));
			victim.SetRatio((skill_t0 * 0.01f + ((2 * D2INT(skill_level / 4.98f) + (D2INT(skill_level / 3.98f) + skill_level) + 7) * 0.01f)));
			victim.SetBuffid(2);
			victim.SetIncattack(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={249};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill262 : GSkill
	{
		public GSkill262()
			: base(262)
		{
			
		}
	}
	public class GSkill263Stub : GSkillStub
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

				skill.SetRatio(1.05f);
				skill.SetPlus(((skill_t0 * 0.08f + 1.0f) * (((16 * skill_level) + (skill_level * (skill_level * 0.68f)) + 179.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 6.9f + (skill_level * (skill_level * 0.21f)) + 267.0f) * (D2INT(1.42f - skill_level * 0.05f))))));
				player.SetPerform(1);
			}
		}
		public GSkill263Stub()
			: base(263)
		{
			occupation = 3;
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
			SetAction(0,"¹íÍõ×Ú_¶áÉñÕ¶");
			SetAction(1,"¹íÍõ×Ú_¶áÉñÕ¶");
			SetAction(2,"¹íÍõ×Ú_¶áÉñÕ¶");
			SetAction(3,"¹íÍõ×Ú_¶áÉñÕ¶");
			SetAction(4,"¹íÍõ×Ú_¶áÉñÕ¶");
			SetAction(5,"¹íÍõ×Ú_¶áÉñÕ¶");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¶áÉñÕ¶");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_¶áÉñÕ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¶áÉñÕ¶");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_¶áÉñÕ¶");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_¶áÉñÕ¶");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_¶áÉñÕ¶");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "¶áÉñÕ¶";
			nativename = "¶áÉñÕ¶";
			icon = "¶áÉñÕ¶.dds";
			SetTalent(0,630);
			SetTalent(1,640);
			SetTalent(2,644);
			SetTalent(3,659);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 4;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 0;
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
			return 2000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={75,77,79,81,83,85,87,89,91};return array[level-1];
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

			return (skill_level * 2.6f + (skill_level * (skill_level * 0.32f)) + 162.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			victim.SetTime(((3000 * skill_t3 + (2000 * skill_level) + 3100)));
			victim.SetBuffid(1);
			victim.SetValue(((2 * skill_level * skill_t3) + (skill_level * 3.8f + 41.0f)));
			victim.SetSubantiweak(true);
			victim.SetProbability(((6 * skill_t1 + 20)));
			victim.SetTime(((3000 * skill_t1 + 8100)));
			victim.SetRatio(((D2INT(zrand(100) / (100 - 6 * skill_t2)) + 1) * (skill_t2 * 0.03f + 0.07000000000000001f)));
			victim.SetBuffid(3);
			victim.SetTiansha(true);
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill263 : GSkill
	{
		public GSkill263()
			: base(263)
		{
			
		}
	}
	public class GSkill264Stub : GSkillStub
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
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetCrit((skill_t0 * 0.02f));
				skill.SetRatio((skill_t3 * 0.05f + 1.0f));
				skill.SetPlus(((skill_t2 * 0.08f + 1.0f) * ((28 * skill_level + 400) * (skill_level * 0.2f + 1.6f))));
				player.SetPerform(1);
			}
		}
		public GSkill264Stub()
			: base(264)
		{
			occupation = 3;
			maxlevel = 20;
			maxlearn = 9;
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
			SetAction(0,"¹íÍõ×Ú_ĞŞÂŞÕ¶");
			SetAction(1,"¹íÍõ×Ú_ĞŞÂŞÕ¶");
			SetAction(2,"¹íÍõ×Ú_ĞŞÂŞÕ¶");
			SetAction(3,"¹íÍõ×Ú_ĞŞÂŞÕ¶");
			SetAction(4,"¹íÍõ×Ú_ĞŞÂŞÕ¶");
			SetAction(5,"¹íÍõ×Ú_ĞŞÂŞÕ¶");
			SetAction(6,"0");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ĞŞÂŞÕ¶");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ĞŞÂŞÕ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ĞŞÂŞÕ¶");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ĞŞÂŞÕ¶");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ĞŞÂŞÕ¶");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_ĞŞÂŞÕ¶");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ĞŞÂŞÕ¶";
			nativename = "ĞŞÂŞÕ¶";
			icon = "ĞŞÂŞÕ¶.dds";
			SetTalent(0,620);
			SetTalent(1,629);
			SetTalent(2,630);
			SetTalent(3,634);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 4;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 0;
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
			return 60000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={100,102,104,106,108,110,112,113,115};return array[level-1];
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

			return (28 * skill_level + 400);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(((600 * D2INT(zrand(100) / (100 - 5 * skill_t1)))));
			victim.SetTime(((2050 * skill_t1)));
			victim.SetDizzy(true);
			victim.SetProbability(((2 * skill_level)));
			victim.SetTime(100.0f);
			victim.SetBuffid(2);
			victim.SetAmount((player_hp * (skill_t3 * 0.12f)));
			victim.SetValue(0.0f);
			victim.SetHpleak2(true);
			victim.SetProbability(((120 * (skill_level / 9))));
			victim.SetTime(((16000 * norm(skill_t0))));
			victim.SetRatio((skill_t0 * 0.06f));
			victim.SetBuffid(1);
			victim.SetIncfatalratio(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={255};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill264 : GSkill
	{
		public GSkill264()
			: base(264)
		{
			
		}
	}
	public class GSkill265Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 2400;
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();

				skill.SetRatio((player_level * 0.01f / 7.0f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((skill_level * player_level) + (((58 * skill_level + 285)) - skill_level * (skill_level * 0.057f))));
				player.SetPerform(1);
			}
		}
		public GSkill265Stub()
			: base(265)
		{
			occupation = 130;
			maxlevel = 8;
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
			SetAction(0,"¹íÍõ×Ú_ÁÒÑæ¾ªÓğ");
			SetAction(1,"¹íÍõ×Ú_ÁÒÑæ¾ªÓğ");
			SetAction(2,"¹íÍõ×Ú_ÁÒÑæ¾ªÓğ");
			SetAction(3,"¹íÍõ×Ú_ÁÒÑæ¾ªÓğ");
			SetAction(4,"¹íÍõ×Ú_ÁÒÑæ¾ªÓğ");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÁÒÑæ¾ªÓğ");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ÁÒÑæ¾ªÓğ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÁÒÑæ¾ªÓğ");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ÁÒÑæ¾ªÓğ");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ÁÒÑæ¾ªÓğ");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÁÒÑæ³àÓğ";
			nativename = "ÁÒÑæ³àÓğ";
			icon = "ÁÒÑæ¾ªÓğ.dds";
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
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 60000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetRadius(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 2.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 2.2f + (skill_level * (skill_level * 0.74f)) + 100.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetValue(((skill_level + 10)));
			victim.SetRepel(true);
			victim.SetProbability(15.0f);
			victim.SetTime(7000.0f);
			victim.SetRatio(0.050000001f);
			victim.SetBuffid(3);
			victim.SetTiansha(true);
			return true;
		}
	}
	public class GSkill265 : GSkill
	{
		public GSkill265()
			: base(265)
		{
			
		}
	}
	public class GSkill266Stub : GSkillStub
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
		public GSkill266Stub()
			: base(266)
		{
			occupation = 10;
			maxlevel = 20;
			maxlearn = 12;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			name = "´ó±¯Öä";
			nativename = "´ó±¯Öä";
			icon = "´ó±¯Öä.dds";
			SetTalent(0,703);
			SetTalent(1,704);
			SetTalent(2,707);
			SetTalent(3,719);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 4;
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
			int				skill_t0 = skill.GetT0();

			return 1000 - 1000 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={16,18,19,22,25,29,33,37,41,43,45,48};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.8f + 13.2f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.8f + 11.2f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.8f + 15.2f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 9.199999999999999f + (skill_level * (skill_level * 1.9f)) + 32.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetValue(((skill_t3 * 0.15f + 1.0f) * (((D2INT((skill_level * 9.199999999999999f + (skill_level * (skill_level * 1.9f)) + 32.0f) * 2.9f)) * (D2INT(zrand(100) / (100 - 9 * skill_t1)) + 1)))));
			victim.SetHeal(true);
			victim.SetTime(((90000 * skill_t2 + 90000)));
			victim.SetBuffid(3);
			victim.SetValue(((skill_t2 * 0.6f + 1.0f) * (player_level * (skill_level * 0.15f + 0.45f))));
			victim.SetAddhp(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(100.0f);
			victim.SetTime(((1800000 * norm(skill_t3))));
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetValue(((100 * skill_t3 * skill_level)));
			victim.SetTiangu(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={267};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill266 : GSkill
	{
		public GSkill266()
			: base(266)
		{
			
		}
	}
	public class GSkill267Stub : GSkillStub
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
				int				skill_t2 = skill.GetT2();

				skill.SetRatio((skill_t2 * 0.07000000000000001f + 1.0f));
				skill.SetPlus(((skill_level * 5.2f + (skill_level * (skill_level * 0.4f)) + 14.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((5 * skill_level) + (skill_level * (skill_level * 0.015f)) + 39.0f) * (D2INT(1.42f - skill_level * 0.05f)) + ((20 * skill_t0 * skill_level)))));
				player.SetPerform(1);
			}
		}
		public GSkill267Stub()
			: base(267)
		{
			occupation = 10;
			maxlevel = 20;
			maxlearn = 9;
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
			SetAction(0,"ÌìÒôËÂ_½µÄ§ÕÈ");
			SetAction(1,"ÌìÒôËÂ_½µÄ§ÕÈ");
			SetAction(2,"ÌìÒôËÂ_½µÄ§ÕÈ");
			SetAction(3,"ÌìÒôËÂ_½µÄ§ÕÈ");
			SetAction(4,"ÌìÒôËÂ_½µÄ§ÕÈ");
			SetAction(5,"ÌìÒôËÂ_½µÄ§ÕÈ");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_½µÄ§ÕÈ");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_½µÄ§ÕÈ");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_½µÄ§ÕÈ");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_½µÄ§ÕÈ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_½µÄ§ÕÈ");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_½µÄ§ÕÈ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "½µÄ§ÕÈ";
			nativename = "½µÄ§ÕÈ";
			icon = "½µÄ§ÕÈ.dds";
			SetTalent(0,686);
			SetTalent(1,698);
			SetTalent(2,702);
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
			int				skill_t0 = skill.GetT0();

			return 2000 - 1000 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={15,17,19,21,23,25,27,29,31};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 19.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 10.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((6 * skill_t1)));
			victim.SetTime(((4050 * skill_t1)));
			victim.SetRatio((skill_t1 * 0.03f));
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={8};return array[index];
		}
	}
	public class GSkill267 : GSkill
	{
		public GSkill267()
			: base(267)
		{
			
		}
	}
	public class GSkill268Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 2400;
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill268Stub()
			: base(268)
		{
			occupation = 10;
			maxlevel = 7;
			maxlearn = 6;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 3;
			targettype = 1;
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
			weapon_limit = -1;
			SetAction(0,"ÌìÒôËÂ_ÍùÉúÖä");
			SetAction(1,"ÌìÒôËÂ_ÍùÉúÖä");
			SetAction(2,"ÌìÒôËÂ_ÍùÉúÖä");
			SetAction(3,"ÌìÒôËÂ_ÍùÉúÖä");
			SetAction(4,"ÌìÒôËÂ_ÍùÉúÖä");
			SetAction(5,"ÌìÒôËÂ_ÍùÉúÖä");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_ÍùÉúÖä");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_ÍùÉúÖä");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_ÍùÉúÖä");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_ÍùÉúÖä");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ÍùÉúÖä");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_ÍùÉúÖä");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÍùÉúÖä";
			nativename = "ÍùÉúÖä";
			icon = "ÍùÉúÖä.dds";
			SetTalent(0,688);
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 8000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 360000 - 60000 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={25,28,31,34,37,40};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 14);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 12);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 16);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((29 * skill_level) + (skill_level * (skill_level * 1.3f)) + 134.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetRatio((0.02f - D2INT(skill_level / 5.5f) * 0.01f));
			victim.SetValue((skill_t0 * 0.1f + (skill_level * 0.1f + 0.05f)));
			victim.SetSalvation(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_charging = skill.GetCharging();

			victim.SetProbability(120.0f);
			victim.SetRatio(skill_level);
			victim.SetBuffid((skill_charging / 0x3E8));
			victim.SetAmount(((skill_charging / 0x3E8 + (2 * skill_level) + 12)));
			victim.SetValue(4531.0f);
			victim.SetTeamenchant(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={266};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill268 : GSkill
	{
		public GSkill268()
			: base(268)
		{
			
		}
	}
	public class GSkill269Stub : GSkillStub
	{
		public GSkill269Stub()
			: base(269)
		{
			occupation = 10;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 1;
			spcost = 1;
			reborncount = 0;
			type = 11;
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
			name = "ÆĞÌáÊ÷";
			nativename = "ÆĞÌáÊ÷";
			icon = "ÆĞÌáÊ÷.dds";
			SetTalent(0,689);
			SetTalent(1,712);
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={25,27,29,31,33,35,37,39,41};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			player.SetPasaddsmite(skill_level * (skill_t1 * 0.01001f));
			player.SetPasaddhp((skill_t0 * 0.15f + 1.0f) * (skill_level * skill_level + 30 * skill_level));
			player.SetPasaddmp((skill_t0 * 0.15f + 1.0f) * (5 * skill_level * skill_level + 100 * skill_level));
			player.SetPasaddattack(skill_level * skill_t1);
			player.SetPasadddodge(skill_level * skill_t1);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={464};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill269 : GSkill
	{
		public GSkill269()
			: base(269)
		{
			
		}
	}
}
