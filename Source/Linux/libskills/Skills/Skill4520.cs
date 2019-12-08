using System;
using System.Text;

namespace SKILL
{
	public class GSkill4520Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((210 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4520Stub()
			: base(4520)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"¹íµÀ_·¨±¦_ËÄÏñ·ğËş");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ËÄÏñ·ğËş");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ËÄÏñ·ğËş");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_ËÄÏñ·ğËş");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ËÄÏñ·ğËş");
			SetAction(5,"¹íµÀ_·¨±¦_ËÄÏñ·ğËş");
			SetAction(6,"·ÙÏã¹È_·¨±¦_ËÄÏñ·ğËş");
			SetAction(7,"ÊŞÉñ_·¨±¦_ËÄÏó·ğËş");
			SetAction(8,"ºüÑı_·¨±¦_ËÄÏó·ğËş");
			SetAction(9,"ĞùÔ¯_·¨±¦_ËÄÏó·ğËş");
			SetAction(10,"»³¹â_·¨±¦_ËÄÏó·ğËş");
			SetAction(11,"Ì«ê»_·¨±¦_ËÄÏó·ğËş");
			SetAction(12,"Ìì»ª_·¨±¦_ËÄÏó·ğËş");
			SetAction(13,"ÁéÙí_·¨±¦_ËÄÏó·ğËş");
			SetAction(14,"Ó¢ÕĞ_·¨±¦_ËÄÏó·ğËş");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_ËÄÏó·ğËş");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_ËÄÏó·ğËş");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_ËÄÏñ·ğËş");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_ËÄÏñ·ğËş");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ËÄÏñ·ğËş");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ËÄÏñ·ğËş");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ËÄÏñ·ğËş");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ËÄÏñ·ğËş");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_ËÄÏñ·ğËş");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_ËÄÏñ·ğËş");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_ËÄÏó·ğËş");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_ËÄÏó·ğËş");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ËÄÏó·ğËş");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ËÄÏó·ğËş");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ËÄÏó·ğËş");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ËÄÏó·ğËş");
			name = "³Ğ¡¤Ê¥Ëş½µÄ§";
			nativename = "³Ğ¡¤Ê¥Ëş½µÄ§";
			icon = "Ê¥Ëş½µÄ§.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-30 * skill_level) - skill_level * skill_level + 380);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((600 * norm(zrand(100) / (90 - 10 * skill_level)))));
			victim.SetTime(2200.0f);
			victim.SetDizzy(true);
			victim.SetProbability(-1.0f);
			victim.SetAmount(1.0f);
			victim.SetClearbuff(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((10 * skill_level + 10)));
			victim.SetTime(100.0f);
			victim.SetBuffid(1);
			victim.SetAmount((((-30 * skill_level) - skill_level * skill_level + 380)));
			victim.SetValue(0.0f);
			victim.SetMpgen(true);
			victim.SetProbability(((10 * skill_level + 10)));
			victim.SetAmount(1.0f);
			victim.SetCleardebuff(true);
			return true;
		}
	}
	public class GSkill4520 : GSkill
	{
		public GSkill4520()
			: base(4520)
		{
			
		}
	}
	public class GSkill4521Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.06f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4521Stub()
			: base(4521)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"¹íµÀ_·¨±¦_ó´Áúá¦");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ó´Áúá¦");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ó´Áúá¦");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_ó´Áúá¦");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ó´Áúá¦");
			SetAction(5,"¹íµÀ_·¨±¦_ó´Áúá¦");
			SetAction(6,"·ÙÏã¹È_·¨±¦_ó´Áúá¦");
			SetAction(7,"ÊŞÉñ_·¨±¦_ó´Áúá¦");
			SetAction(8,"ºüÑı_·¨±¦_ó´Áúá¦");
			SetAction(9,"ĞùÔ¯_·¨±¦_ó´Áúá¦");
			SetAction(10,"»³¹â_·¨±¦_ó´Áúá¦");
			SetAction(11,"Ì«ê»_·¨±¦_ó´Áúá¦");
			SetAction(12,"Ìì»ª_·¨±¦_ó´Áúá¦");
			SetAction(13,"ÁéÙí_·¨±¦_ó´Áúá¦");
			SetAction(14,"Ó¢ÕĞ_·¨±¦_ó´Áúá¦");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_ó´Áúá¦");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_ó´Áúá¦");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_ó´Áúá¦");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ó´Áúá¦");
			name = "³Ğ¡¤ò°ÁúÁÒÑ×";
			nativename = "³Ğ¡¤ò°ÁúÁÒÑ×";
			icon = "ò°ÁúÁÒÑ×.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(12000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((((skill_level * 0.4f + 0.8f) * (D2INT((zrand(5 * skill_level + 100)) / 100)) + 1.0f) * ((420 * skill_level))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((600 * norm(zrand(100) / (100 - 4 * skill_level)))));
			victim.SetTime(((1000 * skill_level + 2100)));
			victim.SetDizzy(true);
			return true;
		}
	}
	public class GSkill4521 : GSkill
	{
		public GSkill4521()
			: base(4521)
		{
			
		}
	}
	public class GSkill4522Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetCrit((skill_level * 0.03f));
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((3 * player_level * skill_level + (215 * skill_level)))));
				player.SetPerform(1);
			}
		}
		public GSkill4522Stub()
			: base(4522)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"¹íµÀ_·¨±¦_ÎåÁúÂÖ");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ÎåÁúÂÖ");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÎåÁúÂÖ");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_ÎåÁúÂÖ");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÎåÁúÂÖ");
			SetAction(5,"¹íµÀ_·¨±¦_ÎåÁúÂÖ");
			SetAction(6,"·ÙÏã¹È_·¨±¦_ÎåÁúÂÖ");
			SetAction(7,"ÊŞÉñ_·¨±¦_ÎåÁúÂÖ");
			SetAction(8,"ºüÑı_·¨±¦_ÎåÁúÂÖ");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÎåÁúÂÖ");
			SetAction(10,"»³¹â_·¨±¦_ÎåÁúÂÖ");
			SetAction(11,"Ì«ê»_·¨±¦_ÎåÁúÂÖ");
			SetAction(12,"Ìì»ª_·¨±¦_ÎåÁúÂÖ");
			SetAction(13,"ÁéÙí_·¨±¦_ÎåÁúÂÖ");
			SetAction(14,"Ó¢ÕĞ_·¨±¦_ÎåÁúÂÖ");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_ÎåÁúÂÖ");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_ÎåÁúÂÖ");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_ÎåÁúÂÖ");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			name = "³Ğ¡¤ÎåÁúÓùÌì";
			nativename = "³Ğ¡¤ÎåÁúÓùÌì";
			icon = "ÎåÁúÓùÌì.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((5 * skill_level)));
			victim.SetTime((((2000 * skill_level + 4000) * (D2INT((zrand(6 * skill_level + 99)) / 100) + 1) + 100)));
			victim.SetRatio((skill_level * 0.02f + 0.2f));
			victim.SetValue((skill_level * 0.02f + 0.2f));
			victim.SetRandcurse(true);
			victim.SetProbability(33.0f);
			victim.SetTime(((4000 * skill_level + 8000)));
			victim.SetBuffid(1);
			victim.SetAmount(((16 * skill_level * skill_level + (60 * skill_level))));
			victim.SetCycsubattack(true);
			return true;
		}
	}
	public class GSkill4522 : GSkill
	{
		public GSkill4522()
			: base(4522)
		{
			
		}
	}
	public class GSkill4523Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4523Stub()
			: base(4523)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"¹íµÀ_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(5,"¹íµÀ_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(6,"·ÙÏã¹È_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(7,"ÊŞÉñ_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(8,"ºüÑı_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(9,"ĞùÔ¯_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(10,"»³¹â_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(11,"Ì«ê»_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(12,"Ìì»ª_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(13,"ÁéÙí_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(14,"Ó¢ÕĞ_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_·­ÌìÉñÓ¡");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_·­ÌìÉñÓ¡");
			name = "³Ğ¡¤ÎåÔÀÏÌ·ş";
			nativename = "³Ğ¡¤ÎåÔÀÏÌ·ş";
			icon = "ÎåÔÀÏÌ·ş.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_mp = player.GetMp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((2 * (skill_t0 + (3 * skill_level)))));
			victim.SetTime((((zrand(2000 * skill_level) + 1000) * norm(player_level / 135) + 6100)));
			victim.SetBuffid(9);
			victim.SetAmount((player_maxhp * 0.4f));
			victim.SetValue(((zrand(550 * skill_level * skill_level + (50 * skill_level)) + 1)));
			victim.SetSubhp(true);
			victim.SetProbability(((2 * (skill_t0 + (3 * skill_level)))));
			victim.SetTime((((zrand(2000 * skill_level) + 1000) * norm(player_level / 135) + 6100)));
			victim.SetBuffid(9);
			victim.SetValue(((((player_mp + player_hp) * skill_level) / (101 - skill_level * skill_level))));
			victim.SetSubattack(true);
			victim.SetProbability(((skill_t0 + skill_level)));
			victim.SetTime((((zrand(2000 * skill_level) + 1000) * norm(player_level / 135) + 6100)));
			victim.SetDiet(true);
			victim.SetProbability(-1.0f);
			victim.SetTime((((zrand(2000 * skill_level) + 1000) * norm((player_level / 135)) + 6100)));
			victim.SetSilent(true);
			return true;
		}
	}
	public class GSkill4523 : GSkill
	{
		public GSkill4523()
			: base(4523)
		{
			
		}
	}
	public class GSkill4524Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				player_atkrate = player.GetAtkrate();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((skill_level * player_atkrate + (215 * skill_level)))));
				player.SetPerform(1);
			}
		}
		public GSkill4524Stub()
			: base(4524)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"¹íµÀ_·¨±¦_³¤Ã÷µÆ");
			SetAction(1,"ÇàÔÆ_·¨±¦_³¤Ã÷µÆ");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_³¤Ã÷µÆ");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_³¤Ã÷µÆ");
			SetAction(4,"ÌìÒô_·¨±¦_³¤Ã÷µÆ");
			SetAction(5,"¹íµÀ_·¨±¦_³¤Ã÷µÆ");
			SetAction(6,"·ÙÏã¹È_·¨±¦_³¤Ã÷µÆ");
			SetAction(7,"ÊŞÉñ_·¨±¦_³¤Ã÷µÆ");
			SetAction(8,"ºüÑı_·¨±¦_³¤Ã÷µÆ");
			SetAction(9,"ĞùÔ¯_·¨±¦_³¤Ã÷µÆ");
			SetAction(10,"»³¹â_·¨±¦_³¤Ã÷µÆ");
			SetAction(11,"Ì«ê»_·¨±¦_³¤Ã÷µÆ");
			SetAction(12,"Ìì»ª_·¨±¦_³¤Ã÷µÆ");
			SetAction(13,"ÁéÙí_·¨±¦_³¤Ã÷µÆ");
			SetAction(14,"Ó¢ÕĞ_·¨±¦_³¤Ã÷µÆ");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_³¤Ã÷µÆ");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_³¤Ã÷µÆ");
			SetAction(17,"ÌìÒô_·¨±¦_³¤Ã÷µÆ");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_³¤Ã÷µÆ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_³¤Ã÷µÆ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_³¤Ã÷µÆ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_³¤Ã÷µÆ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_³¤Ã÷µÆ");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_³¤Ã÷µÆ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_³¤Ã÷µÆ");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_³¤Ã÷µÆ");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_³¤Ã÷µÆ");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_³¤Ã÷µÆ");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_³¤Ã÷µÆ");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_³¤Ã÷µÆ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_³¤Ã÷µÆ");
			name = "³Ğ¡¤º®ÔÂÕòÌ¶";
			nativename = "³Ğ¡¤º®ÔÂÕòÌ¶";
			icon = "Í¨ÓÃ02.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((skill_t0 + (skill_level * skill_level + skill_level))));
			victim.SetTime(16000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((2000 * (skill_level * skill_level + skill_level))));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			victim.SetTime((((2000 * skill_level + 4000) * norm(zrand(100) / (100 - 5 * skill_level)) + 100)));
			victim.SetRatio(((100 * skill_level * skill_level + (50 * skill_level))));
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetCrazy(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability((skill_level * (skill_level * 0.5f) + skill_level));
			victim.SetTime(((2000 * skill_level + 100)));
			victim.SetBuffid(0);
			victim.SetValue(5000.0f);
			victim.SetAdddefence(true);
			return true;
		}
	}
	public class GSkill4524 : GSkill
	{
		public GSkill4524()
			: base(4524)
		{
			
		}
	}
	public class GSkill4525Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4525Stub()
			: base(4525)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"¹íµÀ_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(5,"¹íµÀ_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(6,"·ÙÏã¹È_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(7,"ÊŞÉñ_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(8,"ºüÑı_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(9,"ĞùÔ¯_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(10,"»³¹â_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(11,"Ì«ê»_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(12,"Ìì»ª_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(13,"ÁéÙí_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(14,"Ó¢ÕĞ_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_Íò¹ÇÕĞ»êá¦");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_Íò¹ÇÕĞ»êá¦");
			name = "³Ğ¡¤°Ù¹ÇÖ®Öä";
			nativename = "³Ğ¡¤°Ù¹ÇÖ®Öä";
			icon = "°Ù¹ÇÖ®Öä.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((skill_level * skill_level + 9)));
			victim.SetTime(((1000 * skill_level + 4000)));
			victim.SetRatio((skill_level * (skill_level * 0.0101f) + 0.0501f));
			victim.SetBuffid(3);
			victim.SetDecskillaccu(true);
			victim.SetProbability(((skill_level * skill_level + 9)));
			victim.SetTime(((1000 * skill_level + 4000)));
			victim.SetRatio((skill_level * (skill_level * 0.03f) + 0.1f));
			victim.SetBuffid(3);
			victim.SetDeccrithurt(true);
			victim.SetProbability(((600 * norm(zrand(100) / (91 - skill_level * skill_level)))));
			victim.SetTime(((1000 * skill_level + 4000)));
			victim.SetRatio((skill_level * 0.1f + 0.1f));
			victim.SetBuffid(3);
			victim.SetSlow(true);
			victim.SetProbability(((skill_level * skill_level + 9)));
			victim.SetTime(((1000 * skill_level + 4000)));
			victim.SetRatio((skill_level * 0.05f + 0.05f));
			victim.SetValue((skill_level * 0.05f + 0.05f));
			victim.SetRandcurse(true);
			return true;
		}
	}
	public class GSkill4525 : GSkill
	{
		public GSkill4525()
			: base(4525)
		{
			
		}
	}
	public class GSkill4526Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();

				player.SetVar1(player_res2);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + 1.0f)));
				skill.SetPlus(((225 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4526Stub()
			: base(4526)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			weapon_limit = -1;
			SetAction(0,"¹íÍõ×Ú_·¨±¦_±¦¿âÖ®»ê");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_±¦¿âÖ®»ê");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_±¦¿âÖ®»ê");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_±¦¿âÖ®»ê");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_±¦¿âÖ®»ê");
			SetAction(5,"¹íµÀ_·¨±¦_±¦¿âÖ®»ê");
			SetAction(6,"·ÙÏã¹È_·¨±¦_±¦¿âÖ®»ê");
			SetAction(7,"ÊŞÉñ_·¨±¦_±¦¿âÖ®»ê");
			SetAction(8,"ºüÑı_·¨±¦_±¦¿âÖ®»ê");
			SetAction(9,"ĞùÔ¯_·¨±¦_±¦¿âÖ®»ê");
			SetAction(10,"»³¹â_·¨±¦_±¦¿âÖ®»ê");
			SetAction(11,"Ì«ê»_·¨±¦_±¦¿âÖ®»ê");
			SetAction(12,"Ìì»ª_·¨±¦_±¦¿âÖ®»ê");
			SetAction(13,"ÁéÙí_·¨±¦_±¦¿âÖ®»ê");
			SetAction(14,"Ó¢ÕĞ_·¨±¦_±¦¿âÖ®»ê");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_±¦¿âÖ®»ê");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_±¦¿âÖ®»ê");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_±¦¿âÖ®»ê");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_·¨±¦_±¦¿âÖ®»ê");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_±¦¿âÖ®»ê");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_±¦¿âÖ®»ê");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_±¦¿âÖ®»ê");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_±¦¿âÖ®»ê");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_±¦¿âÖ®»ê");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_±¦¿âÖ®»ê");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_±¦¿âÖ®»ê");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_±¦¿âÖ®»ê");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_±¦¿âÖ®»ê");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_±¦¿âÖ®»ê");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_±¦¿âÖ®»ê");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_±¦¿âÖ®»ê");
			name = "³Ğ¡¤±ÌÌìÓî»ª";
			nativename = "³Ğ¡¤±ÌÌìÓî»ª";
			icon = "±¦¿âÖ®»ê.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 110000 - 10000 * skill_level;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			v23 = 4 * skill_level * skill_level + player_var1;
			if ( skill_level <= 3 )
			{
			if ( v23 > 199 )
			{
			LABEL_9:
			d = (4 * skill_level * skill_level + player_var1);
			goto LABEL_10;
			}
			}
			else if ( 50 * skill_level + 50 <= v23 )
			{
			goto LABEL_9;
			}
			if ( skill_level <= 3 )
			v22 = 200.0f;
			else
			d = ((50 * skill_level + 50));
			LABEL_10:
			victim.SetProbability(d);
			if ( skill_level <= 3 )
			t = 10000.0f;
			else
			victim.SetTime(((10000 * skill_level - 20000)));
			victim.SetRatio(0.5f);
			victim.SetBuffid(0);
			victim.SetWeak(true);
			victim.SetProbability(-1.0f);
			if ( skill_level <= 3 )
			v20 = 3000.0f;
			else
			victim.SetTime(((2000 * skill_level - 3000)));
			victim.SetRatio(1.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(190.0f);
			victim.SetTransform(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetBuffid(0);
			victim.SetAmount(2.0f);
			victim.SetValue(0.0f);
			victim.SetExorcism(true);
			return true;
		}
	}
	public class GSkill4526 : GSkill
	{
		public GSkill4526()
			: base(4526)
		{
			
		}
	}
	public class GSkill4527Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((skill_level * (D2INT((zrand(4 * skill_level + 99)) / 100.0f) * 0.8f) + 1.0f) * ((250 * skill_level)))));
				player.SetPerform(1);
			}
		}
		public GSkill4527Stub()
			: base(4527)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"¹íµÀ_·¨±¦_Éã»ê");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_Éã»ê");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_Éã»ê");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_Éã»ê");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_Éã»ê");
			SetAction(5,"¹íµÀ_·¨±¦_Éã»ê");
			SetAction(6,"·ÙÏã¹È_·¨±¦_Éã»ê");
			SetAction(7,"ÊŞÉñ_·¨±¦_Éã»ê");
			SetAction(8,"ºüÑı_·¨±¦_Éã»ê");
			SetAction(9,"ĞùÔ¯_·¨±¦_Éã»ê");
			SetAction(10,"»³¹â_·¨±¦_Éã»ê");
			SetAction(11,"Ì«ê»_·¨±¦_Éã»ê");
			SetAction(12,"Ìì»ª_·¨±¦_Éã»ê");
			SetAction(13,"ÁéÙí_·¨±¦_Éã»ê");
			SetAction(14,"Ó¢ÕĞ_·¨±¦_Éã»ê");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_Éã»ê");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_Éã»ê");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_Éã»ê");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_Éã»ê");
			name = "³Ğ¡¤»êÉãĞÄ³Û";
			nativename = "³Ğ¡¤»êÉãĞÄ³Û";
			icon = "»êÉãĞÄ³Û.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-35 * skill_level) - skill_level * skill_level + 555);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((600 * norm(zrand(100) / (100 - 4 * skill_level)))));
			victim.SetTime(((5000 * skill_level + 100)));
			victim.SetDizzy(true);
			victim.SetProbability(((5 * skill_level + 25)));
			victim.SetTime(((4000 * skill_level + 100)));
			victim.SetBuffid(1);
			victim.SetValue(((30 * skill_level)));
			victim.SetSubattack(true);
			victim.SetProbability(((5 * skill_t0 + 50)));
			victim.SetTime(16100.0f);
			victim.SetRatio((skill_level * 0.01001f));
			victim.SetBuffid(1);
			victim.SetDeccritrate(true);
			return true;
		}
	}
	public class GSkill4527 : GSkill
	{
		public GSkill4527()
			: base(4527)
		{
			
		}
	}
	public class GSkill4528Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((250 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4528Stub()
			: base(4528)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"¹íµÀ_·¨±¦_ÊÉÑªÖé");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ÊÉÑªÖé");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÊÉÑªÖé");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_ÊÉÑªÖé");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÊÉÑªÖé");
			SetAction(5,"¹íµÀ_·¨±¦_ÊÉÑªÖé");
			SetAction(6,"·ÙÏã¹È_·¨±¦_ÊÉÑªÖé");
			SetAction(7,"ÊŞÉñ_·¨±¦_ÊÉÑªÖé");
			SetAction(8,"ºüÑı_·¨±¦_ÊÉÑªÖé");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÊÉÑªÖé");
			SetAction(10,"»³¹â_·¨±¦_ÊÉÑªÖé");
			SetAction(11,"Ì«ê»_·¨±¦_ÊÉÑªÖé");
			SetAction(12,"Ìì»ª_·¨±¦_ÊÉÑªÖé");
			SetAction(13,"ÁéÙí_·¨±¦_ÊÉÑªÖé");
			SetAction(14,"Ó¢ÕĞ_·¨±¦_ÊÉÑªÖé");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_ÊÉÑªÖé");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_ÊÉÑªÖé");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_ÊÉÑªÖé");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÊÉÑª");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			name = "³Ğ¡¤ÊÉÑªĞ°Áé";
			nativename = "³Ğ¡¤ÊÉÑªĞ°Áé";
			icon = "ÊÉÑªĞ°Áé.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-35 * skill_level) - skill_level * skill_level + 555);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((600 * norm(zrand(100) / (100 - 8 * skill_level)))));
			victim.SetTime(((5000 * skill_level + 100)));
			victim.SetRatio((skill_level * (skill_level * 0.01f) + (skill_level * 0.05f + 0.15f)));
			victim.SetBuffid(5);
			victim.SetWeak(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * ((skill_level * skill_level + (3 * skill_level)))));
			victim.SetRatio(1.0f);
			victim.SetDrainmagic(true);
			victim.SetProbability(((3 * skill_t0 + 50)));
			victim.SetTime(16100.0f);
			victim.SetRatio((skill_level * 0.2f));
			victim.SetBuffid(1);
			victim.SetDeccrithurt(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(30000.0f);
			victim.SetBuffid(5);
			victim.SetAmount((player_maxmp * (skill_level * (skill_level * 0.02f)) * 15.0f));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((skill_level * skill_level + (5 * skill_level) + 35)));
			victim.SetRatio(0.0f);
			victim.SetValue((player_maxhp * (skill_level * 0.02f)));
			victim.SetHeal(true);
			return true;
		}
	}
	public class GSkill4528 : GSkill
	{
		public GSkill4528()
			: base(4528)
		{
			
		}
	}
	public class GSkill4529Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (8 - skill_level)) * 0.01f + (skill_level * 0.09f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((255 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4529Stub()
			: base(4529)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"¹íµÀ_·¨±¦_ÊÉ»ê");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ÊÉ»ê");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÊÉ»ê");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_ÊÉ»ê");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÊÉ»ê");
			SetAction(5,"¹íµÀ_·¨±¦_ÊÉ»ê");
			SetAction(6,"·ÙÏã¹È_·¨±¦_ÊÉ»ê");
			SetAction(7,"ÊŞÉñ_·¨±¦_ÊÉ»ê");
			SetAction(8,"ºüÑı_·¨±¦_ÊÉ»ê");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÊÉ»ê");
			SetAction(10,"»³¹â_·¨±¦_ÊÉ»ê");
			SetAction(11,"Ì«ê»_·¨±¦_ÊÉ»ê");
			SetAction(12,"Ìì»ª_·¨±¦_ÊÉ»ê");
			SetAction(13,"ÁéÙí_·¨±¦_ÊÉ»ê");
			SetAction(14,"Ó¢ÕĞ_·¨±¦_ÊÉ»ê");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_ÊÉ»ê");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_ÊÉ»ê");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_ÊÉ»ê");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÊÉ»ê");
			name = "³Ğ¡¤ÊÉ»êÎŞË«";
			nativename = "³Ğ¡¤ÊÉ»êÎŞË«";
			icon = "ÊÉ»êÎŞË«.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-55 * skill_level) - skill_level * skill_level + 705);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(30000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_maxmp * ((skill_level + 1) * ((skill_level + 1) * 0.02f)) * 15.0f));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			if ( zrand(100) >= 7 * skill_level + 7 )
			v35 = 0.0f;
			else
			victim.SetProbability(600.0f);
			victim.SetTime(((5000 * skill_level + 5000)));
			victim.SetRatio(((skill_level + 1) * ((skill_level + 1) * 0.01f) + ((skill_level + 1) * 0.05f + 0.15f)));
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(50.0f);
			victim.SetTime(16000.0f);
			victim.SetRatio((skill_level * 0.03001f));
			victim.SetBuffid(1);
			victim.SetDeccritrate(true);
			victim.SetProbability(50.0f);
			victim.SetTime(16000.0f);
			victim.SetRatio(((skill_level + 1) * 0.2f));
			victim.SetBuffid(1);
			victim.SetDeccrithurt(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability((((skill_level + 1) * (skill_level + 1) + (5 * skill_level) + 40)));
			victim.SetRatio(0.0f);
			victim.SetValue((player_maxhp * ((skill_level + 1) * 0.02f)));
			victim.SetHeal(true);
			return true;
		}
	}
	public class GSkill4529 : GSkill
	{
		public GSkill4529()
			: base(4529)
		{
			
		}
	}
}
