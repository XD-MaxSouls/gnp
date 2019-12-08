using System;
using System.Text;

namespace SKILL
{
	public class GSkill1000Stub : GSkillStub
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
		public GSkill1000Stub()
			: base(1000)
		{
			occupation = 128;
			maxlevel = 200;
			maxlearn = 10;
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
			name = "NPC¹íÀ÷2";
			nativename = "NPC¹íÀ÷2";
			icon = "";
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
			return 12.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 24.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(4000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(2000.0f);
			victim.SetValue(2000.0f);
			victim.SetHpleak(true);
			return true;
		}
	}
	public class GSkill1000 : GSkill
	{
		public GSkill1000()
			: base(1000)
		{
			
		}
	}
	public class GSkill1001Stub : GSkillStub
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
		public GSkill1001Stub()
			: base(1001)
		{
			occupation = 128;
			maxlevel = 200;
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
			name = "NPCÐ¡°×1";
			nativename = "NPCÐ¡°×1";
			icon = "";
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
			return 1000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(6000.0f);
			victim.SetBuffid(1);
			victim.SetValue(50.0f);
			victim.SetSubdefence(true);
			return true;
		}
	}
	public class GSkill1001 : GSkill
	{
		public GSkill1001()
			: base(1001)
		{
			
		}
	}
	public class GSkill1002Stub : GSkillStub
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
		public GSkill1002Stub()
			: base(1002)
		{
			occupation = 128;
			maxlevel = 200;
			maxlearn = 10;
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
			name = "NPCÐ¡°×2";
			nativename = "NPCÐ¡°×2";
			icon = "";
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
			return 12.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 24.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(220.0f);
			victim.SetTime(6000.0f);
			victim.SetSilent(true);
			victim.SetProbability(220.0f);
			victim.SetTime(6000.0f);
			victim.SetWrap(true);
			return true;
		}
	}
	public class GSkill1002 : GSkill
	{
		public GSkill1002()
			: base(1002)
		{
			
		}
	}
	public class GSkill1003Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_t0 * 0.03f + (skill_level * 0.04f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((75 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill1003Stub()
			: base(1003)
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
			SetAction(0,"¹íµÀ_·¨±¦_ÁáççËþ");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ÁáççËþ");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÁáççËþ");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_ÁáççËþ");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÁáççËþ");
			SetAction(5,"¹íµÀ_·¨±¦_ÁáççËþ");
			SetAction(6,"·ÙÏã¹È_·¨±¦_ÁáççËþ");
			SetAction(7,"ÊÞÉñ_·¨±¦_ÁáççËþ");
			SetAction(8,"ºüÑý_·¨±¦_ÁáççËþ");
			SetAction(9,"ÐùÔ¯_·¨±¦_ÁáççËþ");
			SetAction(10,"»³¹â_·¨±¦_ÁáççËþ");
			SetAction(11,"Ì«ê»_·¨±¦_ÁáççËþ");
			SetAction(12,"Ìì»ª_·¨±¦_ÁáççËþ");
			SetAction(13,"ÔªËØ´óÊ¦_·¨±¦_ÁáççËþ");
			SetAction(14,"ÔªËØ´óÊ¦_·¨±¦_ÁáççËþ");
			SetAction(15,"ÔªËØ´óÊ¦_·¨±¦_ÁáççËþ");
			SetAction(16,"ÔªËØ´óÊ¦_·¨±¦_ÁáççËþ");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_ÁáççËþ");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_ÁáççËþ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁáççËþ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÁáççËþ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ÁáççËþ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÁáççËþ");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_ÁáççËþ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÁáççËþ");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_ÁáççËþ");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_ÁáççËþ");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_ÁáççËþ");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÁáççËþ");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ÁáççËþ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÁáççËþ");
			name = "±¦ËþÕòºÓÑý";
			nativename = "±¦ËþÕòºÓÑý";
			icon = "±¦ËþÕòºÓÑý.dds";
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
		public override float GetRadius(GSkill skill)
		{
			return 5.000000f;
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

			return (90 - 10 * skill_level);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 2;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * ((5 * skill_level + 15))));
			victim.SetTime(30000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((360 * skill_level + 180)));
			victim.SetValue(((40 * (skill_level * skill_level + skill_level))));
			victim.SetHpleak(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(30000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((360 * skill_level + 180)));
			victim.SetValue(((40 * (skill_level * skill_level + skill_level))));
			victim.SetMpleak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(25.0f);
			victim.SetTime(12100.0f);
			victim.SetBuffid(1);
			victim.SetValue((D2INT(((player_hp * (2 * skill_level * skill_level + 8)) / player_maxhp))));
			victim.SetAddattack(true);
			return true;
		}
	}
	public class GSkill1003 : GSkill
	{
		public GSkill1003()
			: base(1003)
		{
			
		}
	}
	public class GSkill1004Stub : GSkillStub
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
		public GSkill1004Stub()
			: base(1004)
		{
			occupation = 130;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"¹íÍõ×Ú_ºáÐÐÎÞ¼É");
			SetAction(1,"ÇàÔÆÃÅ_±ùÐÄ¾÷");
			SetAction(2,"¹íÍõ×Ú_ºáÐÐÎÞ¼É");
			SetAction(3,"ºÏ»¶ÅÉ_Æí¸£");
			SetAction(4,"ÌìÒôËÂ_Ò»ºÈ");
			SetAction(5,"ÌìÒôËÂ_Ò»ºÈ");
			SetAction(6,"ÌìÒôËÂ_Ò»ºÈ");
			SetAction(7,"ÊÞÉñ_»¢Á¦");
			SetAction(8,"ºüÑý_¼²Èç·ç");
			SetAction(9,"ÐùÔ¯_µÍ½×°µÊ¹");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"ÊÞÉñ_»¢Á¦");
			SetAction(12,"Ìì»ª_ËÉ·çÑÅÔÏ");
			SetAction(13,"ÁéÙí_É¢¾¡");
			SetAction(14,"Ó¢ÕÐ_É¢¾¡");
			SetAction(15,"ÎäÆ÷´óÊ¦_µ¶ÉÁ");
			SetAction(16,"ÎäÆ÷´óÊ¦_µ¶ÉÁ");
			SetAction(17,"ÌìÒôËÂ_Ò»ºÈ");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ºáÐÐÎÞ¼É");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_±ùÐÄ¾÷");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ºáÐÐÎÞ¼É");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_Æí¸£");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Ò»ºÈ");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_Ò»ºÈ");
			SetAction(24,"ÌìÒôËÂ_Æï³Ë_Ò»ºÈ");
			SetAction(25,"ÊÞÉñ_Æï³Ë_»¢Á¦");
			SetAction(26,"ºüÑý_Æï³Ë_¼²Èç·ç");
			SetAction(27,"ÐùÔ¯_Æï³Ë_µÍ½×°µÊ¹");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"ÊÞÉñ_Æï³Ë_»¢Á¦");
			SetAction(30,"Ìì»ª_Æï³Ë_ËÉ·çÑÅÔÏ");
			name = "ÐþÎäÖ®×£";
			nativename = "ÐþÎäÖ®×£";
			icon = "ÐþÎäÖ®×£.dds";
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			return (-10000 * skill_t0) - 10000 * skill_level + 240000;
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
			return 365.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_occupation = player.GetOccupation();

			victim.SetRatio(220.0f);
			int amount = 0;
			if (player_occupation == 1 || player_occupation == 2 || player_occupation == 3 || player_occupation == 13 || player_occupation == 14)
			{
				amount += 258;
			}
			if (player_occupation == 4 || player_occupation == 5 || player_occupation == 6 || player_occupation == 16 || player_occupation == 17)
			{
				amount += 291;
			}
			if (player_occupation == 7 || player_occupation == 8 || player_occupation == 9 || player_occupation == 19 || player_occupation == 20)
			{
				amount += 235;
			}
			if (player_occupation == 10 || player_occupation == 11 || player_occupation == 12 || player_occupation == 22 || player_occupation == 23)
			{
				amount += 319;
			}
			if (player_occupation == 25 || player_occupation == 26 || player_occupation == 27 || player_occupation == 28 || player_occupation == 29)
			{
				amount += 1102;
			}
			if (player_occupation == 64 || player_occupation == 65 || player_occupation == 66 || player_occupation == 67 || player_occupation == 68)
			{
				amount += 3435;
			}
			victim.SetAmount(amount);
			int value = 0;
			if (player_occupation == 1 || player_occupation == 2 || player_occupation == 3 || player_occupation == 13 || player_occupation == 14)
			{
				value += 524;
			}
			if (player_occupation == 4 || player_occupation == 5 || player_occupation == 6 || player_occupation == 16 || player_occupation == 17)
			{
				value += 530;
			}
			if (player_occupation == 7 || player_occupation == 8 || player_occupation == 9 || player_occupation == 19 || player_occupation == 20)
			{
				value += 540;
			}
			if (player_occupation == 10 || player_occupation == 11 || player_occupation == 12 || player_occupation == 22 || player_occupation == 23)
			{
				value += 550;
			}
			if (player_occupation == 25 || player_occupation == 26 || player_occupation == 27 || player_occupation == 28 || player_occupation == 29)
			{
				value += 1124;
			}
			if (player_occupation == 64 || player_occupation == 65 || player_occupation == 66 || player_occupation == 67 || player_occupation == 68)
			{
				value += 3444;
			}
			victim.SetValue(value);
			victim.SetClearcooldown(true);
			victim.SetRatio(220.0f);
			int amount1 = 0;
			if (player_occupation == 33 || player_occupation == 34 || player_occupation == 35 || player_occupation == 36 || player_occupation == 37)
			{
				amount1 += 1854;
			}
			if (player_occupation == 39 || player_occupation == 40 || player_occupation == 41 || player_occupation == 42 || player_occupation == 43)
			{
				amount1 += 1908;
			}
			if (player_occupation == 45 || player_occupation == 46 || player_occupation == 47 || player_occupation == 48 || player_occupation == 49)
			{
				amount1 += 2431;
			}
			if (player_occupation == 51 || player_occupation == 52 || player_occupation == 53 || player_occupation == 54 || player_occupation == 55)
			{
				amount1 += 2496;
			}
			if (player_occupation == 96 || player_occupation == 97 || player_occupation == 98 || player_occupation == 99 || player_occupation == 100)
			{
				amount1 += 3496;
			}
			if (player_occupation == 56 || player_occupation == 57 || player_occupation == 58 || player_occupation == 59 || player_occupation == 60)
			{
				amount1 += 4010;
			}
			victim.SetAmount(amount1);
			int value1 = 0;
			if (player_occupation == 33 || player_occupation == 34 || player_occupation == 35 || player_occupation == 36 || player_occupation == 37)
			{
				value1 += 1872;
			}
			if (player_occupation == 39 || player_occupation == 40 || player_occupation == 41 || player_occupation == 42 || player_occupation == 43)
			{
				value1 += 1917;
			}
			if (player_occupation == 45 || player_occupation == 46 || player_occupation == 47 || player_occupation == 48 || player_occupation == 49)
			{
				value1 += 2449;
			}
			if (player_occupation == 51 || player_occupation == 52 || player_occupation == 53 || player_occupation == 54 || player_occupation == 55)
			{
				value1 += 2483;
			}
			if (player_occupation == 96 || player_occupation == 97 || player_occupation == 98 || player_occupation == 99 || player_occupation == 100)
			{
				value1 += 3484;
			}
			if (player_occupation == 56 || player_occupation == 57 || player_occupation == 58 || player_occupation == 59 || player_occupation == 60)
			{
				value1 += 4019;
			}
			victim.SetValue(value1);
			victim.SetClearcooldown(true);
			return true;
		}
	}
	public class GSkill1004 : GSkill
	{
		public GSkill1004()
			: base(1004)
		{
			
		}
	}
	public class GSkill1005Stub : GSkillStub
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

				skill.SetRatio(0.0f);
				player.SetPerform(1);
			}
		}
		public GSkill1005Stub()
			: base(1005)
		{
			occupation = 128;
			maxlevel = 200;
			maxlearn = 10;
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
			name = "Ê¥µ®Ñ©ÈË01";
			nativename = "Ê¥µ®Ñ©ÈË01";
			icon = "";
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
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_maxhp * (skill_level * 0.05f)));
			victim.SetValue(skill_level);
			victim.SetHpleak(true);
			return true;
		}
	}
	public class GSkill1005 : GSkill
	{
		public GSkill1005()
			: base(1005)
		{
			
		}
	}
	public class GSkill1006Stub : GSkillStub
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

				skill.SetRatio(0.0f);
				player.SetPerform(1);
			}
		}
		public GSkill1006Stub()
			: base(1006)
		{
			occupation = 128;
			maxlevel = 200;
			maxlearn = 10;
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
			name = "Ê¥µ®Ñ©ÈË02";
			nativename = "Ê¥µ®Ñ©ÈË02";
			icon = "";
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
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_maxhp * (skill_level * 0.05f)));
			victim.SetValue(((5 * skill_level)));
			victim.SetHpleak(true);
			return true;
		}
	}
	public class GSkill1006 : GSkill
	{
		public GSkill1006()
			: base(1006)
		{
			
		}
	}
	public class GSkill1007Stub : GSkillStub
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

				skill.SetRatio(0.0f);
				player.SetPerform(1);
			}
		}
		public GSkill1007Stub()
			: base(1007)
		{
			occupation = 128;
			maxlevel = 200;
			maxlearn = 10;
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
			name = "Ê¥µ®Ñ©ÈË03";
			nativename = "Ê¥µ®Ñ©ÈË03";
			icon = "";
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
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_maxhp * (skill_level * 0.05f)));
			victim.SetValue(((20 * skill_level)));
			victim.SetHpleak(true);
			return true;
		}
	}
	public class GSkill1007 : GSkill
	{
		public GSkill1007()
			: base(1007)
		{
			
		}
	}
	public class GSkill1008Stub : GSkillStub
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

				skill.SetRatio(0.0f);
				player.SetPerform(1);
			}
		}
		public GSkill1008Stub()
			: base(1008)
		{
			occupation = 128;
			maxlevel = 200;
			maxlearn = 10;
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
			name = "Ê¥µ®Ñ©ÈË04";
			nativename = "Ê¥µ®Ñ©ÈË04";
			icon = "";
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
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_maxhp * (skill_level * 0.05f)));
			victim.SetValue(((100 * skill_level)));
			victim.SetHpleak(true);
			return true;
		}
	}
	public class GSkill1008 : GSkill
	{
		public GSkill1008()
			: base(1008)
		{
			
		}
	}
	public class GSkill1009Stub : GSkillStub
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
		public GSkill1009Stub()
			: base(1009)
		{
			occupation = 128;
			maxlevel = 200;
			maxlearn = 10;
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
			name = "Ê¥µ®Ñ©ÈË05";
			nativename = "Ê¥µ®Ñ©ÈË05";
			icon = "";
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
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_maxhp * (skill_level * 0.05f)));
			victim.SetValue(((500 * skill_level)));
			victim.SetHpleak(true);
			return true;
		}
	}
	public class GSkill1009 : GSkill
	{
		public GSkill1009()
			: base(1009)
		{
			
		}
	}
}
