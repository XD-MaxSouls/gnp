using System;
using System.Text;

namespace SKILL
{
	public class GSkill1550Stub : GSkillStub
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
				int				player_maxhp = player.GetMaxhp();

				player.SetVar1(player_maxhp);
				player.SetPerform(1);
			}
		}
		public GSkill1550Stub()
			: base(1550)
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
			clearmask = 2;
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
			SetAction(0,"ÇàÔÆÃÅ_¿ñÉñ");
			SetAction(1,"ÇàÔÆÃÅ_¿ñÉñ");
			SetAction(2,"¹íÍõ×Ú_¿ñÉñ");
			SetAction(3,"ºÏ»¶ÅÉ_¿ñÉñ");
			SetAction(4,"ÌìÒôËÂ_¿ñÉñ");
			SetAction(5,"¹íµÀ_¿ñÉñ");
			SetAction(6,"·ÙÏã¹È_¿ñÉñ");
			SetAction(7,"ÊÞÉñ_¿ñÉñ");
			SetAction(8,"ºüÑý_¿ñÉñ");
			SetAction(9,"ÐùÔ¯_¿ñÉñ");
			SetAction(10,"»³¹â_¿ñÉñ");
			SetAction(11,"Ì«ê»_¿ñÉñ");
			SetAction(12,"Ìì»ª_¿ñÉñ");
			SetAction(13,"ÁéÙí_¿ñÉñ");
			SetAction(14,"Ó¢ÕÐ_¿ñÉñ");
			SetAction(15,"ÎäÆ÷´óÊ¦_¿ñÉñ");
			SetAction(16,"ÔªËØ´óÊ¦_¿ñÉñ");
			SetAction(17,"ÌìÒôËÂ_¿ñÉñ");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_¿ñÉñ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_¿ñÉñ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¿ñÉñ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¿ñÉñ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¿ñÉñ");
			SetAction(23,"¹íµÀ_Æï³Ë_¿ñÉñ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_¿ñÉñ");
			SetAction(25,"ÊÞÉñ_Æï³Ë_¿ñÉñ");
			SetAction(26,"ºüÑý_Æï³Ë_¿ñÉñ");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¿ñÉñ");
			SetAction(28,"»³¹â_Æï³Ë_¿ñÉñ");
			SetAction(29,"Ì«ê»_Æï³Ë_¿ñÉñ");
			SetAction(30,"Ìì»ª_Æï³Ë_¿ñÉñ");
			name = "¿ñÉñ";
			nativename = "¿ñÉñ";
			icon = "¿ñÉñ.dds";
			SetTalent(0,1549);
			SetTalent(1,1552);
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
			int				skill_t1 = skill.GetT1();

			return 720000 - 36000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
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

			return (25 * skill_level + 325);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * skill_t0 + 30100)));
			victim.SetRatio(1.0f);
			victim.SetAmount(((3 * skill_t0 + 30)));
			victim.SetValue(((15 * skill_level)));
			victim.SetFrenzied(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30100.0f);
			victim.SetRatio((skill_level * 0.0101f));
			victim.SetBuffid(2);
			victim.SetIncskillaccu(true);
			victim.SetTime(((30100 * (skill_level / 10))));
			victim.SetBuffid(2);
			victim.SetValue(((skill_level / 10) * (player_var1 * 0.1f)));
			victim.SetAddhp(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1552};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1550 : GSkill
	{
		public GSkill1550()
			: base(1550)
		{
			
		}
	}
	public class GSkill1551Stub : GSkillStub
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
		public GSkill1551Stub()
			: base(1551)
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
			clearmask = 2;
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
			SetAction(0,"ÇàÔÆÃÅ_Ñª»ê");
			SetAction(1,"ÇàÔÆÃÅ_Ñª»ê");
			SetAction(2,"¹íÍõ×Ú_Ñª»ê");
			SetAction(3,"ºÏ»¶ÅÉ_Ñª»ê");
			SetAction(4,"ÌìÒôËÂ_Ñª»ê");
			SetAction(5,"¹íµÀ_Ñª»ê");
			SetAction(6,"·ÙÏã¹È_Ñª»ê");
			SetAction(7,"ÊÞÉñ_Ñª»ê");
			SetAction(8,"ºüÑý_Ñª»ê");
			SetAction(9,"ÐùÔ¯_Ñª»ê");
			SetAction(10,"»³¹â_Ñª»ê");
			SetAction(11,"Ì«ê»_Ñª»ê");
			SetAction(12,"Ìì»ª_Ñª»ê");
			SetAction(13,"ÁéÙí_Ñª»ê");
			SetAction(14,"Ó¢ÕÐ_Ñª»ê");
			SetAction(15,"ÎäÆ÷´óÊ¦_Ñª»ê");
			SetAction(16,"ÔªËØ´óÊ¦_Ñª»ê");
			SetAction(17,"ÌìÒôËÂ_Ñª»ê");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_Ñª»ê");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Ñª»ê");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Ñª»ê");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_Ñª»ê");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Ñª»ê");
			SetAction(23,"¹íµÀ_Æï³Ë_Ñª»ê");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_Ñª»ê");
			SetAction(25,"ÊÞÉñ_Æï³Ë_Ñª»ê");
			SetAction(26,"ºüÑý_Æï³Ë_Ñª»ê");
			SetAction(27,"ÐùÔ¯_Æï³Ë_Ñª»ê");
			SetAction(28,"»³¹â_Æï³Ë_Ñª»ê");
			SetAction(29,"Ì«ê»_Æï³Ë_Ñª»ê");
			SetAction(30,"Ìì»ª_Æï³Ë_Ñª»ê");
			name = "Ñª»ê";
			nativename = "Ñª»ê";
			icon = "Ñª»ê.dds";
			SetTalent(0,1549);
			SetTalent(1,1552);
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
			int				skill_t1 = skill.GetT1();

			return 720000 - 36000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
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
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * skill_t0 + 30100)));
			victim.SetRatio(1.0f);
			victim.SetAmount(((3 * skill_t0 + 30)));
			victim.SetValue(((300 * skill_level)));
			victim.SetHpregain(true);
			victim.SetTime(30100.0f);
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(1);
			victim.SetIncanti(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1552};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1551 : GSkill
	{
		public GSkill1551()
			: base(1551)
		{
			
		}
	}
	public class GSkill1552Stub : GSkillStub
	{
		public GSkill1552Stub()
			: base(1552)
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
			clearmask = 2;
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
			name = "ÌìÆô";
			nativename = "ÌìÆô";
			icon = "ÌìÆô.dds";
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,90,95,100,105,110,115,120,125,125};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasadddefence(((30 * D2INT(skill_level / 9.5f))));
			player.SetPasincskillaccu(((30 * (skill_level / 9.9f))));
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1553};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1552 : GSkill
	{
		public GSkill1552()
			: base(1552)
		{
			
		}
	}
	public class GSkill1553Stub : GSkillStub
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
		public GSkill1553Stub()
			: base(1553)
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
			clearmask = 2;
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
			SetAction(0,"ÇàÔÆÃÅ_Í¬¹é");
			SetAction(1,"ÇàÔÆÃÅ_Í¬¹é");
			SetAction(2,"¹íÍõ×Ú_Í¬¹é");
			SetAction(3,"ºÏ»¶ÅÉ_Í¬¹é");
			SetAction(4,"ÌìÒôËÂ_Í¬¹é");
			SetAction(5,"¹íµÀ_Í¬¹é");
			SetAction(6,"·ÙÏã¹È_Í¬¹é");
			SetAction(7,"ÊÞÉñ_Í¬¹é");
			SetAction(8,"ºüÑý_Í¬¹é");
			SetAction(9,"ÐùÔ¯_Í¬¹é");
			SetAction(10,"»³¹â_Í¬¹é");
			SetAction(11,"Ì«ê»_Í¬¹é");
			SetAction(12,"Ìì»ª_Í¬¹é");
			SetAction(13,"ÁéÙí_Í¬¹é");
			SetAction(14,"Ó¢ÕÐ_Í¬¹é");
			SetAction(15,"ÎäÆ÷´óÊ¦_Í¬¹é");
			SetAction(16,"ÔªËØ´óÊ¦_Í¬¹é");
			SetAction(17,"ÌìÒôËÂ_Í¬¹é");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_Í¬¹é");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Í¬¹é");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Í¬¹é");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_Í¬¹é");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Í¬¹é");
			SetAction(23,"¹íµÀ_Æï³Ë_Í¬¹é");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_Í¬¹é");
			SetAction(25,"ÊÞÉñ_Æï³Ë_Í¬¹é");
			SetAction(26,"ºüÑý_Æï³Ë_Í¬¹é");
			SetAction(27,"ÐùÔ¯_Æï³Ë_Í¬¹é");
			SetAction(28,"»³¹â_Æï³Ë_Í¬¹é");
			SetAction(29,"Ì«ê»_Æï³Ë_Í¬¹é");
			SetAction(30,"Ìì»ª_Æï³Ë_Í¬¹é");
			name = "Í¬¹é";
			nativename = "Í¬¹é";
			icon = "Í¬¹é.dds";
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
			return 600000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
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
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 30;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(20100.0f);
			victim.SetRatio((skill_level * 0.4f + 0.55f));
			victim.SetBuffid(15);
			victim.SetAmount(0.0f);
			victim.SetValue(20.0f);
			victim.SetDeathscatter(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1546};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1553 : GSkill
	{
		public GSkill1553()
			: base(1553)
		{
			
		}
	}
	public class GSkill1554Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill1554Stub()
			: base(1554)
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
			clearmask = 2;
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
			SetAction(0,"ÇàÔÆÃÅ_¼À»ê");
			SetAction(1,"ÇàÔÆÃÅ_¼À»ê");
			SetAction(2,"¹íÍõ×Ú_¼À»ê");
			SetAction(3,"ºÏ»¶ÅÉ_¼À»ê");
			SetAction(4,"ÌìÒôËÂ_¼À»ê");
			SetAction(5,"¹íµÀ_¼À»ê");
			SetAction(6,"·ÙÏã¹È_¼À»ê");
			SetAction(7,"ÊÞÉñ_¼À»ê");
			SetAction(8,"ºüÑý_¼À»ê");
			SetAction(9,"ÐùÔ¯_¼À»ê");
			SetAction(10,"»³¹â_¼À»ê");
			SetAction(11,"Ì«ê»_¼À»ê");
			SetAction(12,"Ìì»ª_¼À»ê");
			SetAction(13,"ÁéÙí_¼À»ê");
			SetAction(14,"Ó¢ÕÐ_¼À»ê");
			SetAction(15,"ÎäÆ÷´óÊ¦_¼À»ê");
			SetAction(16,"ÔªËØ´óÊ¦_¼À»ê");
			SetAction(17,"ÌìÒôËÂ_¼À»ê");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_¼À»ê");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_¼À»ê");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¼À»ê");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¼À»ê");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¼À»ê");
			SetAction(23,"¹íµÀ_Æï³Ë_¼À»ê");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_¼À»ê");
			SetAction(25,"ÊÞÉñ_Æï³Ë_¼À»ê");
			SetAction(26,"ºüÑý_Æï³Ë_¼À»ê");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¼À»ê");
			SetAction(28,"»³¹â_Æï³Ë_¼À»ê");
			SetAction(29,"Ì«ê»_Æï³Ë_¼À»ê");
			SetAction(30,"Ìì»ª_Æï³Ë_¼À»ê");
			name = "¼À»ê";
			nativename = "¼À»ê";
			icon = "¼À»ê.dds";
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
			return 600000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 30.000000f;
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

			return (25 * skill_level + 1525);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability((player_level * (skill_level * 0.2f + 2.6f)));
			victim.SetTime(((5000 * skill_level + 10100)));
			victim.SetRatio((skill_level * 0.05f + 0.35f));
			victim.SetBuffid(1);
			victim.SetWeak(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1546};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1554 : GSkill
	{
		public GSkill1554()
			: base(1554)
		{
			
		}
	}
	public class GSkill1555Stub : GSkillStub
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
		public GSkill1555Stub()
			: base(1555)
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
			rangetype = 3;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 10;
			clearmask = 2;
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
			SetAction(0,"ÇàÔÆÃÅ_ÄæÈÐ");
			SetAction(1,"ÇàÔÆÃÅ_ÄæÈÐ");
			SetAction(2,"¹íÍõ×Ú_ÄæÈÐ");
			SetAction(3,"ºÏ»¶ÅÉ_ÄæÈÐ");
			SetAction(4,"ÌìÒôËÂ_ÄæÈÐ");
			SetAction(5,"¹íµÀ_ÄæÈÐ");
			SetAction(6,"·ÙÏã¹È_ÄæÈÐ");
			SetAction(7,"ÊÞÉñ_ÄæÈÐ");
			SetAction(8,"ºüÑý_ÄæÈÐ");
			SetAction(9,"ÐùÔ¯_ÄæÈÐ");
			SetAction(10,"»³¹â_ÄæÈÐ");
			SetAction(11,"Ì«ê»_ÄæÈÐ");
			SetAction(12,"Ìì»ª_ÄæÈÐ");
			SetAction(13,"ÁéÙí_ÄæÈÐ");
			SetAction(14,"Ó¢ÕÐ_ÄæÈÐ");
			SetAction(15,"ÎäÆ÷´óÊ¦_ÄæÈÐ");
			SetAction(16,"ÔªËØ´óÊ¦_ÄæÈÐ");
			SetAction(17,"ÌìÒôËÂ_ÄæÈÐ");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_ÄæÈÐ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ÄæÈÐ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÄæÈÐ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_ÄæÈÐ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ÄæÈÐ");
			SetAction(23,"¹íµÀ_Æï³Ë_ÄæÈÐ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÄæÈÐ");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ÄæÈÐ");
			SetAction(26,"ºüÑý_Æï³Ë_ÄæÈÐ");
			SetAction(27,"ÐùÔ¯_Æï³Ë_ÄæÈÐ");
			SetAction(28,"»³¹â_Æï³Ë_ÄæÈÐ");
			SetAction(29,"Ì«ê»_Æï³Ë_ÄæÈÐ");
			SetAction(30,"Ìì»ª_Æï³Ë_ÄæÈÐ");
			name = "ÄæÈÐ";
			nativename = "ÄæÈÐ";
			icon = "ÄæÈÐ.dds";
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
			return 600000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (35 * skill_level + 2525);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 30;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((10 * player_level)));
			victim.SetValue((player_maxhp * (skill_level * 0.02f)));
			victim.SetSubhp(true);
			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((10 * player_level)));
			victim.SetValue((player_maxmp * (skill_level * 0.02f)));
			victim.SetSubmp(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1546};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1555 : GSkill
	{
		public GSkill1555()
			: base(1555)
		{
			
		}
	}
	public class GSkill1556Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				skill_level = skill.GetLevel();

				player.SetHp(((player_hp - 100 * skill_level - 1050)));
				player.SetPerform(1);
			}
		}
		public GSkill1556Stub()
			: base(1556)
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
			clearmask = 2;
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
			SetAction(0,"ÇàÔÆÃÅ_»ÃÃð");
			SetAction(1,"ÇàÔÆÃÅ_»ÃÃð");
			SetAction(2,"¹íÍõ×Ú_»ÃÃð");
			SetAction(3,"ºÏ»¶ÅÉ_»ÃÃð");
			SetAction(4,"ÌìÒôËÂ_»ÃÃð");
			SetAction(5,"¹íµÀ_»ÃÃð");
			SetAction(6,"·ÙÏã¹È_»ÃÃð");
			SetAction(7,"ÊÞÉñ_»ÃÃð");
			SetAction(8,"ºüÑý_»ÃÃð");
			SetAction(9,"ÐùÔ¯_»ÃÃð");
			SetAction(10,"»³¹â_»ÃÃð");
			SetAction(11,"Ì«ê»_»ÃÃð");
			SetAction(12,"Ìì»ª_»ÃÃð");
			SetAction(13,"ÁéÙí_»ÃÃð");
			SetAction(14,"Ó¢ÕÐ_»ÃÃð");
			SetAction(15,"ÎäÆ÷´óÊ¦_»ÃÃð");
			SetAction(16,"ÔªËØ´óÊ¦_»ÃÃð");
			SetAction(17,"ÌìÒôËÂ_»ÃÃð");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_»ÃÃð");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_»ÃÃð");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_»ÃÃð");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_»ÃÃð");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_»ÃÃð");
			SetAction(23,"¹íµÀ_Æï³Ë_»ÃÃð");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_»ÃÃð");
			SetAction(25,"ÊÞÉñ_Æï³Ë_»ÃÃð");
			SetAction(26,"ºüÑý_Æï³Ë_»ÃÃð");
			SetAction(27,"ÐùÔ¯_Æï³Ë_»ÃÃð");
			SetAction(28,"»³¹â_Æï³Ë_»ÃÃð");
			SetAction(29,"Ì«ê»_Æï³Ë_»ÃÃð");
			SetAction(30,"Ìì»ª_Æï³Ë_»ÃÃð");
			name = "»ÃÃð";
			nativename = "»ÃÃð";
			icon = "»ÃÃð.dds";
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
			return 720000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (400 * skill_level + 2100);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 30;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((5 * skill_level + 25)));
			victim.SetTime(100.0f);
			victim.SetBuffid(1);
			victim.SetValue((((8 * skill_level + 17) * player_level)));
			victim.SetBleeding(true);
			victim.SetProbability((D2INT(player_level * (skill_level * 0.1f + 1.9f))));
			victim.SetTime(((1000 * skill_level + 1100)));
			victim.SetDizzy(true);
			victim.SetProbability(100.0f);
			victim.SetTime(300000.0f);
			victim.SetRatio(1528.0f);
			victim.SetAmount(1529.0f);
			victim.SetValue(1530.0f);
			victim.SetSetcooldown(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1546};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1556 : GSkill
	{
		public GSkill1556()
			: base(1556)
		{
			
		}
	}
	public class GSkill1557Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				player.SetVar2(zrand(100));
				player.SetVar1(player_res1);
				skill.SetRatio((skill_level * 0.05f + 1.0f));
				player.SetPerform(1);
			}
		}
		public GSkill1557Stub()
			: base(1557)
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
			SetAction(0,"¹íÍõ×Ú_»ðÑæµ¶");
			SetAction(1,"¹íÍõ×Ú_»ðÑæµ¶");
			SetAction(2,"¹íÍõ×Ú_»ðÑæµ¶");
			SetAction(3,"¹íÍõ×Ú_»ðÑæµ¶");
			SetAction(4,"¹íÍõ×Ú_»ðÑæµ¶");
			SetAction(5,"¹íÍõ×Ú_»ðÑæµ¶");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_»ðÑæµ¶");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_»ðÑæµ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_»ðÑæµ¶");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_»ðÑæµ¶");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_»ðÑæµ¶");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_»ðÑæµ¶");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "»ðÑæµ¶II";
			nativename = "»ðÑæµ¶II";
			icon = "»ðÑæµ¶II.dds";
			SetTalent(0,248);
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
			int				skill_level = skill.GetLevel();

			return (skill_level + 13);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 8);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 18);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (30 * skill_level + 770);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability((player_var2 >= 2 * skill_level + 8)?0.0f:((8 * skill_level + player_var1 <= 600)?600.0f:(8 * skill_level + player_var1)));
			victim.SetTime(((500 * skill_t0 + 2100)));
			victim.SetDizzy(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(6100.0f);
			victim.SetRatio((skill_level * 0.05f + 0.05f));
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			victim.SetProbability((player_var2 < 2 * skill_level + 8)?0.0f:600.0f);
			victim.SetTime(6100.0f);
			victim.SetRatio((skill_level * 0.05f));
			victim.SetBuffid(2);
			victim.SetSlow(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={248};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill1557 : GSkill
	{
		public GSkill1557()
			: base(1557)
		{
			
		}
	}
	public class GSkill1558Stub : GSkillStub
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
		public GSkill1558Stub()
			: base(1558)
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
			SetAction(0,"¹íÍõ×Ú_ÃÍ»ðÖä");
			SetAction(1,"¹íÍõ×Ú_ÃÍ»ðÖä");
			SetAction(2,"¹íÍõ×Ú_ÃÍ»ðÖä");
			SetAction(3,"¹íÍõ×Ú_ÃÍ»ðÖä");
			SetAction(4,"¹íÍõ×Ú_ÃÍ»ðÖä");
			SetAction(5,"¹íÍõ×Ú_ÃÍ»ðÖä");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ðÖä");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ðÖä");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ðÖä");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ðÖä");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ðÖä");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ðÖä");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÃÍ»ðÖäII";
			nativename = "ÃÍ»ðÖäII";
			icon = "ÃÍ»ðÖäII.dds";
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
			return 360000;
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

			return (100 * skill_level + 700);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(16100.0f);
			victim.SetRatio((skill_level * 0.07000000000000001f + 0.15f));
			victim.SetNingjin(true);
			victim.SetProbability(100.0f);
			victim.SetTime(10100.0f);
			victim.SetRatio((0.9f - skill_level * 0.05f));
			victim.SetBuffid(3);
			victim.SetDecaccuracy(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={258};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={7};return array[index];
		}
	}
	public class GSkill1558 : GSkill
	{
		public GSkill1558()
			: base(1558)
		{
			
		}
	}
	public class GSkill1559Stub : GSkillStub
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
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();

				skill.SetRatio(1.0f);
				skill.SetPlus((player_def * (skill_level * 0.03f)));
				player.SetPerform(1);
			}
		}
		public GSkill1559Stub()
			: base(1559)
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
			SetAction(0,"¹íÍõ×Ú_¾ÛÁéÖä");
			SetAction(1,"¹íÍõ×Ú_¾ÛÁéÖä");
			SetAction(2,"¹íÍõ×Ú_¾ÛÁéÖä");
			SetAction(3,"¹íÍõ×Ú_¾ÛÁéÖä");
			SetAction(4,"¹íÍõ×Ú_¾ÛÁéÖä");
			SetAction(5,"¹íÍõ×Ú_¾ÛÁéÖä");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¾ÛÁéÖä");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_¾ÛÁéÖä");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¾ÛÁéÖä");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_¾ÛÁéÖä");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_¾ÛÁéÖä");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_¾ÛÁéÖä");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "¾ÛÁéÖäII";
			nativename = "¾ÛÁéÖäII";
			icon = "¾ÛÁéÖäII.dds";
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
			return 360000;
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
			return 1.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_mp = player.GetMp();
			int				player_def = player.GetDef();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(200.0f);
			victim.SetBuffid(0);
			victim.SetValue((((skill_level * 0.08f + 0.22f) * player_mp) - player_def));
			victim.SetBleeding(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetRatio(1.0f);
			victim.SetDrainmagic(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={521};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={7};return array[index];
		}
	}
	public class GSkill1559 : GSkill
	{
		public GSkill1559()
			: base(1559)
		{
			
		}
	}
}
