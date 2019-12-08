using System;
using System.Text;

namespace SKILL
{
	public class GSkill2050Stub : GSkillStub
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
		public GSkill2050Stub()
			: base(2050)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
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
			credittype = 9;
			clearmask = 129;
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
			SetAction(0,"ÌìÒôËÂ_ËÄ´ó½Ô¿Õ»ğ");
			SetAction(1,"ÌìÒôËÂ_ËÄ´ó½Ô¿Õ»ğ");
			SetAction(2,"ÌìÒôËÂ_ËÄ´ó½Ô¿Õ»ğ");
			SetAction(3,"ÌìÒôËÂ_ËÄ´ó½Ô¿Õ»ğ");
			SetAction(4,"ÌìÒôËÂ_ËÄ´ó½Ô¿Õ»ğ");
			SetAction(5,"ÌìÒôËÂ_ËÄ´ó½Ô¿Õ»ğ");
			SetAction(6,"ÌìÒôËÂ_ËÄ´ó½Ô¿Õ»ğ");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_ËÄ´ó½Ô¿Õ»ğ");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_ËÄ´ó½Ô¿Õ»ğ");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_ËÄ´ó½Ô¿Õ»ğ");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_ËÄ´ó½Ô¿Õ»ğ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ËÄ´ó½Ô¿Õ»ğ");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_ËÄ´ó½Ô¿Õ»ğ");
			SetAction(24,"ÌìÒôËÂ_Æï³Ë_ËÄ´ó½Ô¿Õ»ğ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ËÄ´ó½Ô¿ÕII";
			nativename = "ËÄ´ó½Ô¿ÕII";
			icon = "ËÄ´ó½Ô¿ÕII.dds";
			SetTalent(0,382);
			SetTalent(1,383);
			SetTalent(2,384);
			SetTalent(3,385);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 120000;
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
			return 750.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * (skill_t3 + (skill_t2 + (skill_t1 + skill_t0))) + 200)));
			victim.SetBuffid(1);
			victim.SetValue(((300 - 3 * skill_level * skill_level)));
			victim.SetSubanti(true);
			victim.SetTime(((1000 * (skill_t3 + (skill_t2 + (skill_t1 + skill_t0))) + 200)));
			victim.SetImmunesleep(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={382};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={8};return array[index];
		}
	}
	public class GSkill2050 : GSkill
	{
		public GSkill2050()
			: base(2050)
		{
			
		}
	}
	public class GSkill2051Stub : GSkillStub
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
		public GSkill2051Stub()
			: base(2051)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 9;
			clearmask = 129;
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
			SetAction(0,"ÌìÒôËÂ_Ê¨×Óºğ");
			SetAction(1,"ÌìÒôËÂ_Ê¨×Óºğ");
			SetAction(2,"ÌìÒôËÂ_Ê¨×Óºğ");
			SetAction(3,"ÌìÒôËÂ_Ê¨×Óºğ");
			SetAction(4,"ÌìÒôËÂ_Ê¨×Óºğ");
			SetAction(5,"ÌìÒôËÂ_Ê¨×Óºğ");
			SetAction(6,"ÌìÒôËÂ_Ê¨×Óºğ");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_Ê¨×Óºğ");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_Ê¨×Óºğ");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_Ê¨×Óºğ");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_Ê¨×Óºğ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Ê¨×Óºğ");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_Ê¨×Óºğ");
			SetAction(24,"ÌìÒôËÂ_Æï³Ë_Ê¨×Óºğ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ê¨×ÓºğII";
			nativename = "Ê¨×ÓºğII";
			icon = "Ê¨×ÓºğII.dds";
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

			return 380000 - 20000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 1.5f);
		}
		public override float GetAngle(GSkill skill)
		{
			return -0.333332f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.2f + 5.8f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.2f + 2.3f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (102 * skill_level + 99);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 15;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetClearsleep(true);
			victim.SetTime(((1000 * skill_level + 5000)));
			victim.SetImmunesleep(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={270};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill2051 : GSkill
	{
		public GSkill2051()
			: base(2051)
		{
			
		}
	}
	public class GSkill2052Stub : GSkillStub
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
		public GSkill2052Stub()
			: base(2052)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 5;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 1;
			credittype = 9;
			clearmask = 129;
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
			SetAction(0,"¹íµÀ_¹éÁéÃØÓ¡");
			SetAction(1,"¹íµÀ_¹éÁéÃØÓ¡");
			SetAction(2,"¹íµÀ_¹éÁéÃØÓ¡");
			SetAction(3,"¹íµÀ_¹éÁéÃØÓ¡");
			SetAction(4,"¹íµÀ_¹éÁéÃØÓ¡");
			SetAction(5,"¹íµÀ_¹éÁéÃØÓ¡");
			SetAction(6,"¹íµÀ_¹éÁéÃØÓ¡");
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
			SetAction(18,"¹íµÀ_Æï³Ë_¹éÁéÃØÓ¡");
			SetAction(19,"¹íµÀ_Æï³Ë_¹éÁéÃØÓ¡");
			SetAction(20,"¹íµÀ_Æï³Ë_¹éÁéÃØÓ¡");
			SetAction(21,"¹íµÀ_Æï³Ë_¹éÁéÃØÓ¡");
			SetAction(22,"¹íµÀ_Æï³Ë_¹éÁéÃØÓ¡");
			SetAction(23,"¹íµÀ_Æï³Ë_¹éÁéÃØÓ¡");
			SetAction(24,"¹íµÀ_Æï³Ë_¹éÁéÃØÓ¡");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¹éÁéÃØÓ¡II";
			nativename = "¹éÁéÃØÓ¡II";
			icon = "¹éÁéÃØÓ¡II.dds";
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
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 150000;
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
			return 3150.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(90000.0f);
			victim.SetRatio((skill_level * 0.0601f));
			victim.SetBuffid(2);
			victim.SetDecfatalhurt(true);
			victim.SetProbability(120.0f);
			victim.SetTime(90000.0f);
			victim.SetRatio((skill_level * 0.01f));
			victim.SetDecdamage(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1114};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill2052 : GSkill
	{
		public GSkill2052()
			: base(2052)
		{
			
		}
	}
	public class GSkill2053Stub : GSkillStub
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
		public GSkill2053Stub()
			: base(2053)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 5;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 1;
			credittype = 9;
			clearmask = 129;
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
			SetAction(0,"¹íµÀ_ÓÄÈª¹í²½");
			SetAction(1,"¹íµÀ_ÓÄÈª¹í²½");
			SetAction(2,"¹íµÀ_ÓÄÈª¹í²½");
			SetAction(3,"¹íµÀ_ÓÄÈª¹í²½");
			SetAction(4,"¹íµÀ_ÓÄÈª¹í²½");
			SetAction(5,"¹íµÀ_ÓÄÈª¹í²½");
			SetAction(6,"¹íµÀ_ÓÄÈª¹í²½");
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
			SetAction(18,"¹íµÀ_Æï³Ë_ÓÄÈª¹í²½");
			SetAction(19,"¹íµÀ_Æï³Ë_ÓÄÈª¹í²½");
			SetAction(20,"¹íµÀ_Æï³Ë_ÓÄÈª¹í²½");
			SetAction(21,"¹íµÀ_Æï³Ë_ÓÄÈª¹í²½");
			SetAction(22,"¹íµÀ_Æï³Ë_ÓÄÈª¹í²½");
			SetAction(23,"¹íµÀ_Æï³Ë_ÓÄÈª¹í²½");
			SetAction(24,"¹íµÀ_Æï³Ë_ÓÄÈª¹í²½");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÓÄÈª¹í²½II";
			nativename = "ÓÄÈª¹í²½II";
			icon = "ÓÄÈª¹í²½II.dds";
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
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 180000;
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
			return 2250.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(((2000 * skill_level + 5500)));
			victim.SetRatio((skill_level * 0.0101f));
			victim.SetInccritrate(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 5500)));
			victim.SetRatio((skill_level * 0.0601f + 0.0201f));
			victim.SetBuffid(1);
			victim.SetInccrithurt(true);
			victim.SetProbability(100.0f);
			victim.SetBuffid(0);
			victim.SetAmount(3.0f);
			victim.SetValue(0.0f);
			victim.SetExorcism(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1105};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={8};return array[index];
		}
	}
	public class GSkill2053 : GSkill
	{
		public GSkill2053()
			: base(2053)
		{
			
		}
	}
	public class GSkill2054Stub : GSkillStub
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
				int				player_mp = player.GetMp();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1((int)(player_mp * (skill_level * 0.05f + 0.5f)));
				player.SetMp((player_mp * (0.5f - skill_level * 0.05f)));
				skill.SetRatio(((skill_t2 + (skill_t1 + skill_t0)) * 0.04f + 1.0f));
				player.SetPerform(1);
			}
		}
		public GSkill2054Stub()
			: base(2054)
		{
			occupation = 149;
			maxlevel = 10;
			maxlearn = 10;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"ÇàÔÆÃÅ_ÆÆÄ§½£Æø");
			SetAction(1,"ÇàÔÆÃÅ_ÆÆÄ§½£Æø");
			SetAction(2,"ÇàÔÆÃÅ_ÆÆÄ§½£Æø");
			SetAction(3,"ÇàÔÆÃÅ_ÆÆÄ§½£Æø");
			SetAction(4,"ÇàÔÆÃÅ_ÆÆÄ§½£Æø");
			SetAction(5,"ÇàÔÆÃÅ_ÆÆÄ§½£Æø");
			SetAction(6,"ÇàÔÆÃÅ_ÆÆÄ§½£Æø");
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
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_ÆÆÄ§½£Æø");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ÆÆÄ§½£Æø");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_ÆÆÄ§½£Æø");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_ÆÆÄ§½£Æø");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_ÆÆÄ§½£Æø");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_ÆÆÄ§½£Æø");
			SetAction(24,"ÇàÔÆÃÅ_Æï³Ë_ÆÆÄ§½£Æø");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÆÆÄ§½£ÆøII";
			nativename = "ÆÆÄ§½£ÆøII";
			icon = "ÆÆÄ§½£ÆøII.dds";
			SetTalent(0,1563);
			SetTalent(1,1564);
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
			return 20.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetAmount(player_var1);
			victim.SetMpdisperse(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			victim.SetBuffid(1);
			victim.SetAmount((((player_var1 / 5) * (skill_level + 5))));
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
			int[] array={228};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill2054 : GSkill
	{
		public GSkill2054()
			: base(2054)
		{
			
		}
	}
	public class GSkill2055Stub : GSkillStub
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
				int				player_mp = player.GetMp();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				skill.SetRatio(((skill_t2 + (skill_t1 + skill_t0)) * 0.04f + (skill_level * 0.04f + 1.0f)));
				skill.SetPlus((player_mp * (skill_level * 0.02f)));
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_mp = player.GetMp();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				skill.SetRatio(((skill_t2 + (skill_t1 + skill_t0)) * 0.04f + (skill_level * 0.04f + 1.0f)));
				skill.SetCrit((skill_level * 0.01f));
				skill.SetPlus((player_mp * (skill_level * 0.02f)));
				player.SetPerform(0);
			}
		}
		public GSkill2055Stub()
			: base(2055)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
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
			SetAction(0,"ÇàÔÆÃÅ_Æß½ÙÕ¶Áú¾÷");
			SetAction(1,"ÇàÔÆÃÅ_Æß½ÙÕ¶Áú¾÷");
			SetAction(2,"ÇàÔÆÃÅ_Æß½ÙÕ¶Áú¾÷");
			SetAction(3,"ÇàÔÆÃÅ_Æß½ÙÕ¶Áú¾÷");
			SetAction(4,"ÇàÔÆÃÅ_Æß½ÙÕ¶Áú¾÷");
			SetAction(5,"ÇàÔÆÃÅ_Æß½ÙÕ¶Áú¾÷");
			SetAction(6,"ÇàÔÆÃÅ_Æß½ÙÕ¶Áú¾÷");
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
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_Æß½ÙÕ¶Áú¾÷");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Æß½ÙÕ¶Áú¾÷");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_Æß½ÙÕ¶Áú¾÷");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_Æß½ÙÕ¶Áú¾÷");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_Æß½ÙÕ¶Áú¾÷");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_Æß½ÙÕ¶Áú¾÷");
			SetAction(24,"ÇàÔÆÃÅ_Æï³Ë_Æß½ÙÕ¶Áú¾÷");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Æß½ÙÕ¶Áú¾÷II";
			nativename = "Æß½ÙÕ¶Áú¾÷II";
			icon = "Æß½ÙÕ¶Áú¾÷II.dds";
			SetTalent(0,1563);
			SetTalent(1,1564);
			SetTalent(2,2054);
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 120000;
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

			return (skill_level * 0.6f + 16.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.6f + 10.7f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.6f + 19.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (99 * skill_level + 333);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(6000.0f);
			victim.SetRatio((skill_level * 0.02f));
			victim.SetBuffid(1);
			victim.SetDecskilldodge(true);
			victim.SetProbability(120.0f);
			victim.SetTime(6000.0f);
			victim.SetRatio((skill_level * 0.1f));
			victim.SetBuffid(1);
			victim.SetIncfatalhurt(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={545};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill2055 : GSkill
	{
		public GSkill2055()
			: base(2055)
		{
			
		}
	}
	public class GSkill2056Stub : GSkillStub
	{
		public GSkill2056Stub()
			: base(2056)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 11;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
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
			SetAction(0,"0");
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
			SetAction(11,"0");
			SetAction(12,"0");
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
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÄıÉñII";
			nativename = "ÄıÉñII";
			icon = "ÄıÉñII.dds";
			SetTalent(0,297);
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasincskillaccu(((5 * skill_level)));
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={297};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={8};return array[index];
		}
	}
	public class GSkill2056 : GSkill
	{
		public GSkill2056()
			: base(2056)
		{
			
		}
	}
	public class GSkill2057Stub : GSkillStub
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
		public GSkill2057Stub()
			: base(2057)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
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
			SetAction(0,"ºÏ»¶ÅÉ_¼¤Àø");
			SetAction(1,"ºÏ»¶ÅÉ_¼¤Àø");
			SetAction(2,"ºÏ»¶ÅÉ_¼¤Àø");
			SetAction(3,"ºÏ»¶ÅÉ_¼¤Àø");
			SetAction(4,"ºÏ»¶ÅÉ_¼¤Àø");
			SetAction(5,"ºÏ»¶ÅÉ_¼¤Àø");
			SetAction(6,"ºÏ»¶ÅÉ_¼¤Àø");
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
			SetAction(18,"ºÏ»¶ÅÉ_Æï³Ë_¼¤Àø");
			SetAction(19,"ºÏ»¶ÅÉ_Æï³Ë_¼¤Àø");
			SetAction(20,"ºÏ»¶ÅÉ_Æï³Ë_¼¤Àø");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¼¤Àø");
			SetAction(22,"ºÏ»¶ÅÉ_Æï³Ë_¼¤Àø");
			SetAction(23,"ºÏ»¶ÅÉ_Æï³Ë_¼¤Àø");
			SetAction(24,"ºÏ»¶ÅÉ_Æï³Ë_¼¤Àø");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¼¤ÀøII";
			nativename = "¼¤ÀøII";
			icon = "¼¤ÀøII.dds";
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
			return 1900.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetClearwrap(true);
			victim.SetTime(((2000 * skill_level + 8100)));
			victim.SetImmunewrap(true);
			victim.SetTime(((1000 * skill_level + 5100)));
			victim.SetMakecrit(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={299};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill2057 : GSkill
	{
		public GSkill2057()
			: base(2057)
		{
			
		}
	}
	public class GSkill2058Stub : GSkillStub
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
		public GSkill2058Stub()
			: base(2058)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
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
			SetAction(0,"¹íÍõ×Ú_ÃÍ»ğÖä");
			SetAction(1,"¹íÍõ×Ú_ÃÍ»ğÖä");
			SetAction(2,"¹íÍõ×Ú_ÃÍ»ğÖä");
			SetAction(3,"¹íÍõ×Ú_ÃÍ»ğÖä");
			SetAction(4,"¹íÍõ×Ú_ÃÍ»ğÖä");
			SetAction(5,"¹íÍõ×Ú_ÃÍ»ğÖä");
			SetAction(6,"¹íÍõ×Ú_ÃÍ»ğÖä");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ğÖä");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ğÖä");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ğÖä");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ğÖä");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ğÖä");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ğÖä");
			SetAction(24,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ğÖä");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¿İÄ¾ÖäII";
			nativename = "¿İÄ¾ÖäII";
			icon = "¿İÄ¾ÖäII.dds";
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
			return 120000;
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
			return 940.000000f;
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
			int				player_res6 = player.GetRes6();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 5000)));
			victim.SetBuffid(1);
			victim.SetValue(((player_res6 + (player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1))))) * (skill_level * 0.2f)));
			victim.SetAdddefence(true);
			victim.SetTime(((1000 * skill_level + 5000)));
			victim.SetImmunedizzy(true);
			victim.SetRatio(((39 * norm(zrand(100) / 70) + 219)));
			victim.SetAmount(((1339 * norm((zrand(100) / 70)) + 219)));
			victim.SetValue(219.0f);
			victim.SetClearcooldown(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={249};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={8};return array[index];
		}
	}
	public class GSkill2058 : GSkill
	{
		public GSkill2058()
			: base(2058)
		{
			
		}
	}
	public class GSkill2059Stub : GSkillStub
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
		public GSkill2059Stub()
			: base(2059)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
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
			SetAction(0,"¹íÍõ×Ú_ĞŞÂŞÕ¶");
			SetAction(1,"¹íÍõ×Ú_ĞŞÂŞÕ¶");
			SetAction(2,"¹íÍõ×Ú_ĞŞÂŞÕ¶");
			SetAction(3,"¹íÍõ×Ú_ĞŞÂŞÕ¶");
			SetAction(4,"¹íÍõ×Ú_ĞŞÂŞÕ¶");
			SetAction(5,"¹íÍõ×Ú_ĞŞÂŞÕ¶");
			SetAction(6,"¹íÍõ×Ú_ĞŞÂŞÕ¶");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ĞŞÂŞÕ¶");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ĞŞÂŞÕ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ĞŞÂŞÕ¶");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ĞŞÂŞÕ¶");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ĞŞÂŞÕ¶");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_ĞŞÂŞÕ¶");
			SetAction(24,"¹íÍõ×Ú_Æï³Ë_ĞŞÂŞÕ¶");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ĞŞÂŞÕ¶II";
			nativename = "ĞŞÂŞÕ¶II";
			icon = "ĞŞÂŞÕ¶II.dds";
			SetTalent(0,264);
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
			return 5.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return (100 * skill_t0 + 400);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 2 * skill_level + 4;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 5000)));
			victim.SetBuffid(1);
			victim.SetValue((skill_level * ((100 * skill_t0 + 400) * 0.3f)));
			victim.SetSubattack(true);
			victim.SetProbability(((3 * skill_level)));
			victim.SetRatio(0.33000001f);
			victim.SetDrainmagic(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={264};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill2059 : GSkill
	{
		public GSkill2059()
			: base(2059)
		{
			
		}
	}
}
