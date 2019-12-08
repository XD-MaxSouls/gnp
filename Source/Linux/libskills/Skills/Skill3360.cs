using System;
using System.Text;

namespace SKILL
{
	public class GSkill3360Stub : GSkillStub
	{
		public GSkill3360Stub()
			: base(3360)
		{
			occupation = 129;
			maxlevel = 99;
			maxlearn = 99;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 13;
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
			SetAction(0,"");
			SetAction(1,"");
			SetAction(2,"");
			SetAction(3,"");
			SetAction(4,"");
			SetAction(5,"");
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
			SetAction(18,"");
			SetAction(19,"");
			SetAction(20,"");
			SetAction(21,"");
			SetAction(22,"");
			SetAction(23,"");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÖĞÇïÔÂ±ı¼ÓÀ¶ÉÏÏŞ";
			nativename = "ÖĞÇïÔÂ±ı¼ÓÀ¶ÉÏÏŞ";
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
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(900000.0f);
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(4);
			victim.SetIncmp(true);
			return true;
		}
	}
	public class GSkill3360 : GSkill
	{
		public GSkill3360()
			: base(3360)
		{
			
		}
	}
	public class GSkill3361Stub : GSkillStub
	{
		public GSkill3361Stub()
			: base(3361)
		{
			occupation = 129;
			maxlevel = 999;
			maxlearn = 999;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 13;
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
			SetAction(0,"");
			SetAction(1,"");
			SetAction(2,"");
			SetAction(3,"");
			SetAction(4,"");
			SetAction(5,"");
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
			SetAction(18,"");
			SetAction(19,"");
			SetAction(20,"");
			SetAction(21,"");
			SetAction(22,"");
			SetAction(23,"");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÖĞÇïÔÂ±ı¼Ó±©ÉË";
			nativename = "ÖĞÇïÔÂ±ı¼Ó±©ÉË";
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
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(900000.0f);
			victim.SetRatio((skill_level * 0.01001f));
			victim.SetBuffid(4);
			victim.SetInccrithurt(true);
			return true;
		}
	}
	public class GSkill3361 : GSkill
	{
		public GSkill3361()
			: base(3361)
		{
			
		}
	}
	public class GSkill3362Stub : GSkillStub
	{
		public GSkill3362Stub()
			: base(3362)
		{
			occupation = 129;
			maxlevel = 10;
			maxlearn = 10;
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
			SetAction(0,"");
			SetAction(1,"");
			SetAction(2,"");
			SetAction(3,"");
			SetAction(4,"");
			SetAction(5,"");
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
			SetAction(18,"");
			SetAction(19,"");
			SetAction(20,"");
			SetAction(21,"");
			SetAction(22,"");
			SetAction(23,"");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "»î¶¯ÓÃÔ¤Áô04";
			nativename = "»î¶¯ÓÃÔ¤Áô04";
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
		}
	}
	public class GSkill3362 : GSkill
	{
		public GSkill3362()
			: base(3362)
		{
			
		}
	}
	public class GSkill3363Stub : GSkillStub
	{
		public GSkill3363Stub()
			: base(3363)
		{
			occupation = 129;
			maxlevel = 10;
			maxlearn = 10;
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
			SetAction(0,"");
			SetAction(1,"");
			SetAction(2,"");
			SetAction(3,"");
			SetAction(4,"");
			SetAction(5,"");
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
			SetAction(18,"");
			SetAction(19,"");
			SetAction(20,"");
			SetAction(21,"");
			SetAction(22,"");
			SetAction(23,"");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "»î¶¯ÓÃÔ¤Áô05";
			nativename = "»î¶¯ÓÃÔ¤Áô05";
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
		}
	}
	public class GSkill3363 : GSkill
	{
		public GSkill3363()
			: base(3363)
		{
			
		}
	}
	public class GSkill3364Stub : GSkillStub
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
				int				player_maxatk = player.GetMaxatk();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_level * 0.005f + 1.03f));
				skill.SetPlus(((((10 * skill_level + 100) * norm(skill_t0)) * D2INT(player_occupation == 64) + (2 * (skill_level * skill_t0 + (3 * skill_level))))));
				player.SetPerform(1);
			}
		}
		public GSkill3364Stub()
			: base(3364)
		{
			occupation = 64;
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
			SetAction(0,"·ÙÏã¹È_³õ¼¶»ğ¹¥");
			SetAction(1,"·ÙÏã¹È_³õ¼¶»ğ¹¥");
			SetAction(2,"·ÙÏã¹È_³õ¼¶»ğ¹¥");
			SetAction(3,"·ÙÏã¹È_³õ¼¶»ğ¹¥");
			SetAction(4,"·ÙÏã¹È_³õ¼¶»ğ¹¥");
			SetAction(5,"·ÙÏã¹È_³õ¼¶»ğ¹¥");
			SetAction(6,"·ÙÏã¹È_³õ¼¶»ğ¹¥");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"0");
			SetAction(10,"");
			SetAction(11,"0");
			SetAction(12,"");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"·ÙÏã¹È_Æï³Ë_³õ¼¶»ğ¹¥");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_³õ¼¶»ğ¹¥");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_³õ¼¶»ğ¹¥");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_³õ¼¶»ğ¹¥");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_³õ¼¶»ğ¹¥");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_³õ¼¶»ğ¹¥");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_³õ¼¶»ğ¹¥");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"0");
			SetAction(28,"");
			SetAction(29,"0");
			SetAction(30,"");
			name = "ĞÇ»ğ";
			nativename = "ĞÇ»ğ";
			icon = "ĞÇ»ğ.dds";
			SetTalent(0,3373);
			SetTalent(1,3376);
			SetTalent(2,3751);
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
			return 4000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={15,17,19,21,23,25,27,29,31};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.300000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 4.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 10.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((skill_t2 + (5 * skill_t1) + 5)));
			victim.SetTime(6100.0f);
			victim.SetRatio(4.0f);
			victim.SetBuffid(1);
			victim.SetAmount(4.0f);
			victim.SetValue(((skill_t2 * 0.1f + 1.0f) * (player_var1 * 0.1f)));
			victim.SetFiring(true);
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={8};return array[index];
		}
	}
	public class GSkill3364 : GSkill
	{
		public GSkill3364()
			: base(3364)
		{
			
		}
	}
	public class GSkill3365Stub : GSkillStub
	{
		public GSkill3365Stub()
			: base(3365)
		{
			occupation = 64;
			maxlevel = 20;
			maxlearn = 8;
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
			name = "·áÂö";
			nativename = "·áÂö";
			icon = "·áÂö.dds";
			SetTalent(0,3391);
			SetTalent(1,3374);
			SetTalent(2,3407);
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={20,22,24,26,28,30,33,36};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			player.SetPasaddhp(((2 * (player_level * skill_level + (50 * skill_t0 * skill_level)))));
			player.SetPasinchp(((skill_level / 2) * (skill_t1 * 0.01f)));
			player.SetPasadddefence(((skill_level * skill_t2)));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3364};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3365 : GSkill
	{
		public GSkill3365()
			: base(3365)
		{
			
		}
	}
	public class GSkill3366Stub : GSkillStub
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
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_level * 0.01f + 1.02f));
				skill.SetPlus(((4 * skill_level * skill_t0 + (3 * skill_level) + 32)));
				player.SetPerform(1);
			}
		}
		public GSkill3366Stub()
			: base(3366)
		{
			occupation = 64;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 3;
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
			SetAction(0,"·ÙÏã¹È_Á½Ìå¹¥»÷");
			SetAction(1,"·ÙÏã¹È_Á½Ìå¹¥»÷");
			SetAction(2,"·ÙÏã¹È_Á½Ìå¹¥»÷");
			SetAction(3,"·ÙÏã¹È_Á½Ìå¹¥»÷");
			SetAction(4,"·ÙÏã¹È_Á½Ìå¹¥»÷");
			SetAction(5,"·ÙÏã¹È_Á½Ìå¹¥»÷");
			SetAction(6,"·ÙÏã¹È_Á½Ìå¹¥»÷");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_Á½Ìå¹¥»÷");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_Á½Ìå¹¥»÷");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_Á½Ìå¹¥»÷");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_Á½Ìå¹¥»÷");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_Á½Ìå¹¥»÷");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_Á½Ìå¹¥»÷");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_Á½Ìå¹¥»÷");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÂÏĞÇ";
			nativename = "ÂÏĞÇ";
			icon = "ÂÏĞÇ.dds";
			SetTalent(0,3375);
			SetTalent(1,3377);
			SetTalent(2,3751);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 6000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={30,32,34,36,38,40,42,44,47};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.300000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 4.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 20.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 2;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((skill_t2 + (5 * skill_t1) + 5)));
			victim.SetTime(6100.0f);
			victim.SetRatio(4.0f);
			victim.SetBuffid(1);
			victim.SetAmount(4.0f);
			victim.SetValue(((skill_t2 * 0.1f + 1.0f) * (player_var1 * 0.15f)));
			victim.SetFiring(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3365};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill3366 : GSkill
	{
		public GSkill3366()
			: base(3366)
		{
			
		}
	}
	public class GSkill3367Stub : GSkillStub
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
		public GSkill3367Stub()
			: base(3367)
		{
			occupation = 64;
			maxlevel = 20;
			maxlearn = 6;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 1;
			targettype = 0;
			rangetype = 5;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 1536;
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
			name = "Ô­Áé";
			nativename = "Ô­Áé";
			icon = "Ô­Áé.dds";
			SetTalent(0,3390);
			SetTalent(1,3394);
			SetTalent(2,3403);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return 40000 - 10000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={16,18,21,24,28,32};return array[level-1];
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
			return 45.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			/*
			victim.SetProbability(120.0f);
			victim.SetValue((skill_level * 0.2f + 0.8f));
			victim.SetYuanling(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((35050 - 5000 * skill_level)));
			victim.SetRatio(((100 * skill_t2 + (10 * skill_t1) + 1)));
			victim.SetBuffid(7);
			victim.SetValue(3596.0f);
			victim.SetDelaycast(true);
			if ( player.GetHasbuff(4221) == 1 )
			v24 = 0.0f;
			else
			victim.SetProbability(100.0f);
			victim.SetRatio(5447.0f);
			victim.SetAmount(4411.0f);
			victim.SetValue(5447.0f);
			victim.SetDispel(true);
			victim.SetProbability(120.0f);
			victim.SetClearwrap(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetClearslow(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3364};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill3367 : GSkill
	{
		public GSkill3367()
			: base(3367)
		{
			
		}
	}
	public class GSkill3368Stub : GSkillStub
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
				int				player_res2 = player.GetRes2();

				/*
				if ( player_res2 / 10 > 999 )
				  {
				    v = 999;
				  }
				  else
				  {
				v = player_res2 / 10;
				  }
				player.SetVar1(v);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill3368Stub()
			: base(3368)
		{
			occupation = 64;
			maxlevel = 20;
			maxlearn = 8;
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
			SetAction(0,"·ÙÏã¹È_ÁéÁ¦¾«ÑĞ");
			SetAction(1,"·ÙÏã¹È_ÁéÁ¦¾«ÑĞ");
			SetAction(2,"·ÙÏã¹È_ÁéÁ¦¾«ÑĞ");
			SetAction(3,"·ÙÏã¹È_ÁéÁ¦¾«ÑĞ");
			SetAction(4,"·ÙÏã¹È_ÁéÁ¦¾«ÑĞ");
			SetAction(5,"·ÙÏã¹È_ÁéÁ¦¾«ÑĞ");
			SetAction(6,"·ÙÏã¹È_ÁéÁ¦¾«ÑĞ");
			SetAction(7,"");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦¾«ÑĞ");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦¾«ÑĞ");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦¾«ÑĞ");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦¾«ÑĞ");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦¾«ÑĞ");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦¾«ÑĞ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦¾«ÑĞ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ã÷¾õ";
			nativename = "Ã÷¾õ";
			icon = "Ã÷¾õ.dds";
			SetTalent(0,3392);
			SetTalent(1,3395);
			SetTalent(2,3399);
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
			int				skill_t0 = skill.GetT0();

			return 30000 - 8000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={25,27,29,31,33,35,37,40};return array[level-1];
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
			return 120.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability((skill_t2 + (skill_level * 0.5f + 2.0f)));
			victim.SetRatio(((skill_t1 * 0.25f + 1.0f) * ((4 * skill_level))));
			victim.SetAmount(((skill_level + (10 * player_var1))));
			victim.SetValue(3599.0f);
			victim.SetAddweak(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3367};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill3368 : GSkill
	{
		public GSkill3368()
			: base(3368)
		{
			
		}
	}
	public class GSkill3369Stub : GSkillStub
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
				int				player_res3 = player.GetRes3();

				/*
				if ( player_res3 / 10 > 999 )
				  {
				    v = 999;
				  }
				  else
				  {
				v = player_res3 / 10;
				  }
				player.SetVar1(v);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill3369Stub()
			: base(3369)
		{
			occupation = 64;
			maxlevel = 20;
			maxlearn = 8;
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
			SetAction(0,"·ÙÏã¹È_ÁéÁ¦¾«ÑĞ");
			SetAction(1,"·ÙÏã¹È_ÁéÁ¦¾«ÑĞ");
			SetAction(2,"·ÙÏã¹È_ÁéÁ¦¾«ÑĞ");
			SetAction(3,"·ÙÏã¹È_ÁéÁ¦¾«ÑĞ");
			SetAction(4,"·ÙÏã¹È_ÁéÁ¦¾«ÑĞ");
			SetAction(5,"·ÙÏã¹È_ÁéÁ¦¾«ÑĞ");
			SetAction(6,"·ÙÏã¹È_ÁéÁ¦¾«ÑĞ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦¾«ÑĞ");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦¾«ÑĞ");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦¾«ÑĞ");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦¾«ÑĞ");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦¾«ÑĞ");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦¾«ÑĞ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦¾«ÑĞ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÉñŞÈ";
			nativename = "ÉñŞÈ";
			icon = "ÉñŞÈ.dds";
			SetTalent(0,3392);
			SetTalent(1,3395);
			SetTalent(2,3399);
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
			int				skill_t0 = skill.GetT0();

			return 30000 - 8000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={35,37,39,42,45,48,51,55};return array[level-1];
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
			return 120.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability((skill_t2 + (skill_level * 0.5f + 2.0f)));
			victim.SetRatio(((skill_t1 * 0.25f + 1.0f) * ((4 * skill_level))));
			victim.SetAmount(((skill_level + (10 * player_var1))));
			victim.SetValue(3600.0f);
			victim.SetAddwrap(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3368};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3369 : GSkill
	{
		public GSkill3369()
			: base(3369)
		{
			
		}
	}
}
