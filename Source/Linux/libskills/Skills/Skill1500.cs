using System;
using System.Text;

namespace SKILL
{
	public class GSkill1500Stub : GSkillStub
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
				int				player_level = player.GetLevel();

				skill.SetRatio(1.05f);
				skill.SetPlus((player_level * 0.5f));
				player.SetPerform(1);
			}
		}
		public GSkill1500Stub()
			: base(1500)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 1;
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
			name = "闪光之耀：迎刃";
			nativename = "闪光之耀：迎刃";
			icon = "闪光之证.dds";
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 10;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1080000;
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
			return 12.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 600.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 15;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(999.0f);
			victim.SetTime(6000.0f);
			victim.SetSilent(true);
			victim.SetTime(10000.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(1);
			victim.SetDecskilldamage(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue((player_maxhp * (norm(6000.0f / (player_maxhp * 0.25f + 1.0f)) * 0.25f) + ((6000 * norm((player_maxhp * 0.25f + 1.0f) / 6000.0f)))));
			victim.SetHeal(true);
			return true;
		}
	}
	public class GSkill1500 : GSkill
	{
		public GSkill1500()
			: base(1500)
		{
			
		}
	}
	public class GSkill1501Stub : GSkillStub
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
				int				player_level = player.GetLevel();

				skill.SetRatio(1.05f);
				skill.SetPlus((player_level * 0.5f));
				player.SetPerform(1);
			}
		}
		public GSkill1501Stub()
			: base(1501)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 1;
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
			name = "闪光之耀：你秀";
			nativename = "闪光之耀：你秀";
			icon = "闪光之证.dds";
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 10;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1080000;
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
			return 12.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 600.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 15;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(999.0f);
			victim.SetTime(6000.0f);
			victim.SetWrap(true);
			victim.SetTime(10000.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(1);
			victim.SetDecskilldamage(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue((player_maxhp * (norm(6000.0f / (player_maxhp * 0.25f + 1.0f)) * 0.25f) + ((6000 * norm((player_maxhp * 0.25f + 1.0f) / 6000.0f)))));
			victim.SetHeal(true);
			return true;
		}
	}
	public class GSkill1501 : GSkill
	{
		public GSkill1501()
			: base(1501)
		{
			
		}
	}
	public class GSkill1502Stub : GSkillStub
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

				skill.SetRatio(0.0f);
				skill.SetPlus(1.0f);
				player.SetPerform(1);
			}
		}
		public GSkill1502Stub()
			: base(1502)
		{
			occupation = 128;
			maxlevel = 1;
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
			SetAction(0,"青云门_御剑决");
			SetAction(1,"青云门_御剑决");
			SetAction(2,"青云门_御剑决");
			SetAction(3,"青云门_御剑决");
			SetAction(4,"青云门_御剑决");
			SetAction(5,"青云门_御剑决");
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
			SetAction(18,"青云门_骑乘_御剑决");
			SetAction(19,"青云门_骑乘_御剑决");
			SetAction(20,"青云门_骑乘_御剑决");
			SetAction(21,"青云门_骑乘_御剑决");
			SetAction(22,"青云门_骑乘_御剑决");
			SetAction(23,"青云门_骑乘_御剑决");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "风驰电掣";
			nativename = "风驰电掣";
			icon = "御剑诀.dds";
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
		public override int GetCooldowntime(GSkill skill)
		{
			return 1000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 100.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetRatio(((1000 * ((norm((player_level + 0.05f) / 188.0f)) - norm((player_level + 0.05f) / 189.0f)))));
			victim.SetAmount(0.0f);
			victim.SetValue((((norm((player_level + 0.05f) / 188.0f)) - norm((player_level + 0.05f) / 189.0f))));
			victim.SetSecondattack(true);
			return true;
		}
	}
	public class GSkill1502 : GSkill
	{
		public GSkill1502()
			: base(1502)
		{
			
		}
	}
	public class GSkill1503Stub : GSkillStub
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
		public GSkill1503Stub()
			: base(1503)
		{
			occupation = 128;
			maxlevel = 999;
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
			name = "单体传送术_河阳任务管理员处";
			nativename = "单体传送术_河阳任务管理员处";
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
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(1000.0f);
			victim.SetBuffid(177);
			victim.SetAmount(166.0f);
			victim.SetValue(204.0f);
			victim.SetMagicdoor(true);
			return true;
		}
	}
	public class GSkill1503 : GSkill
	{
		public GSkill1503()
			: base(1503)
		{
			
		}
	}
	public class GSkill1504Stub : GSkillStub
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
		public GSkill1504Stub()
			: base(1504)
		{
			occupation = 128;
			maxlevel = 99;
			maxlearn = 10;
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
			name = "测试给目标上光环buff";
			nativename = "测试给目标上光环buff";
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
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 10.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 1.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 20.0f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(60000.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(20.0f);
			victim.SetValue(1000.0f);
			victim.SetEvilaura(true);
			return true;
		}
	}
	public class GSkill1504 : GSkill
	{
		public GSkill1504()
			: base(1504)
		{
			
		}
	}
	public class GSkill1505Stub : GSkillStub
	{
		public GSkill1505Stub()
			: base(1505)
		{
			occupation = 147;
			maxlevel = 50;
			maxlearn = 12;
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
			credittype = 8;
			clearmask = 64;
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
			name = "天罡浩气";
			nativename = "天罡浩气";
			icon = "天罡浩气.dds";
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
			int[] array={105,105,105,110,115,120,125,125,125,125,125,125};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasdecfatalhurt((skill_level * (skill_level * 0.002f) + (skill_level * 0.02f)));
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={25,50,125,250,500,1000,1800,3600,7200,14400,14400,14400};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1506};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1505 : GSkill
	{
		public GSkill1505()
			: base(1505)
		{
			
		}
	}
	public class GSkill1506Stub : GSkillStub
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
		public GSkill1506Stub()
			: base(1506)
		{
			occupation = 147;
			maxlevel = 50;
			maxlearn = 12;
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
			credittype = 8;
			clearmask = 64;
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
			SetAction(0,"青云门_天罡丹鼎");
			SetAction(1,"青云门_天罡丹鼎");
			SetAction(2,"鬼王宗_天罡丹鼎");
			SetAction(3,"合欢派_天罡丹鼎");
			SetAction(4,"天音寺_天罡丹鼎");
			SetAction(5,"鬼道_天罡丹鼎");
			SetAction(6,"焚香谷_天罡丹鼎");
			SetAction(7,"兽神_天罡丹鼎");
			SetAction(8,"狐妖_天罡丹鼎");
			SetAction(9,"太昊_天罡丹鼎");
			SetAction(10,"怀光_天罡丹鼎");
			SetAction(11,"太昊_天罡丹鼎");
			SetAction(12,"天华_天罡丹鼎");
			SetAction(13,"灵夙_天罡丹鼎");
			SetAction(14,"英招_天罡丹鼎");
			SetAction(15,"0");
			SetAction(16,"元素大师_天罡丹鼎");
			SetAction(17,"天音寺_天罡丹鼎");
			SetAction(18,"青云门_骑乘_天罡丹鼎");
			SetAction(19,"青云门_骑乘_天罡丹鼎");
			SetAction(20,"鬼王宗_骑乘_天罡丹鼎");
			SetAction(21,"合欢派_骑乘_天罡丹鼎");
			SetAction(22,"天音寺_骑乘_天罡丹鼎");
			SetAction(23,"鬼道_骑乘_天罡丹鼎");
			SetAction(24,"焚香谷_骑乘_天罡丹鼎");
			SetAction(25,"兽神_骑乘_天罡丹鼎");
			SetAction(26,"狐妖_骑乘_天罡丹鼎");
			SetAction(27,"太昊_骑乘_天罡丹鼎");
			SetAction(28,"怀光_骑乘_天罡丹鼎");
			SetAction(29,"太昊_骑乘_天罡丹鼎");
			SetAction(30,"天华_骑乘_天罡丹鼎");
			name = "天罡丹鼎";
			nativename = "天罡丹鼎";
			icon = "天罡丹鼎.dds";
			SetTalent(0,1508);
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
			int				skill_t0 = skill.GetT0();

			return 3600000 - 180000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={105,105,105,110,115,120,125,125,125,125,125,125};return array[level-1];
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

			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(99.0f);
			victim.SetValue(((skill_level + 19276)));
			victim.SetCreateitem(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={25,50,125,250,500,1000,1800,3600,7200,14400,14400,14400};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1507};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1506 : GSkill
	{
		public GSkill1506()
			: base(1506)
		{
			
		}
	}
	public class GSkill1507Stub : GSkillStub
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
		public GSkill1507Stub()
			: base(1507)
		{
			occupation = 147;
			maxlevel = 50;
			maxlearn = 12;
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
			credittype = 8;
			clearmask = 64;
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
			SetAction(0,"青云门_天罡贮元");
			SetAction(1,"青云门_天罡贮元");
			SetAction(2,"鬼王宗_天罡贮元");
			SetAction(3,"合欢派_天罡贮元");
			SetAction(4,"天音寺_天罡贮元");
			SetAction(5,"鬼道_天罡贮元");
			SetAction(6,"焚香谷_天罡贮元");
			SetAction(7,"兽神_天罡贮元");
			SetAction(8,"狐妖_天罡贮元");
			SetAction(9,"太昊_天罡贮元");
			SetAction(10,"怀光_天罡贮元");
			SetAction(11,"太昊_天罡贮元");
			SetAction(12,"天华_天罡贮元");
			SetAction(13,"灵夙_天罡贮元");
			SetAction(14,"英招_天罡贮元");
			SetAction(15,"元素大师_还神");
			SetAction(16,"元素大师_天罡贮元");
			SetAction(17,"天音寺_天罡贮元");
			SetAction(18,"青云门_骑乘_天罡贮元");
			SetAction(19,"青云门_骑乘_天罡贮元");
			SetAction(20,"鬼王宗_骑乘_天罡贮元");
			SetAction(21,"合欢派_骑乘_天罡贮元");
			SetAction(22,"天音寺_骑乘_天罡贮元");
			SetAction(23,"鬼道_骑乘_天罡贮元");
			SetAction(24,"焚香谷_骑乘_天罡贮元");
			SetAction(25,"兽神_骑乘_天罡贮元");
			SetAction(26,"狐妖_骑乘_天罡贮元");
			SetAction(27,"太昊_骑乘_天罡贮元");
			SetAction(28,"怀光_骑乘_天罡贮元");
			SetAction(29,"太昊_骑乘_天罡贮元");
			SetAction(30,"天华_骑乘_天罡贮元");
			name = "天罡贮元";
			nativename = "天罡贮元";
			icon = "天罡贮元.dds";
			SetTalent(0,1508);
			SetTalent(1,1505);
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
			int				skill_t0 = skill.GetT0();

			return 600000 - 30000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={105,105,105,110,115,120,125,125,125,125,125,125};return array[level-1];
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(100.0f);
			victim.SetTime(36000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(9);
			victim.SetAmount(0.0f);
			victim.SetValue(((skill_t1 * 0.1f + 1.0f) * ((player_level * 0.05f / 15.0f + 1.0f) * ((4 * (skill_level * skill_level + (26 * skill_level)))))));
			victim.SetHpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(36000.0f);
			victim.SetBuffid(9);
			victim.SetAmount(0.0f);
			victim.SetValue(((skill_t1 * 0.1f + 1.0f) * ((player_level * 0.05f / 15.0f + 1.0f) * ((2 * (skill_level * skill_level + (26 * skill_level)))))));
			victim.SetMpgen(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={25,50,125,250,500,1000,1800,3600,7200,14400,14400,14400};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1508};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1507 : GSkill
	{
		public GSkill1507()
			: base(1507)
		{
			
		}
	}
	public class GSkill1508Stub : GSkillStub
	{
		public GSkill1508Stub()
			: base(1508)
		{
			occupation = 147;
			maxlevel = 50;
			maxlearn = 12;
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
			credittype = 8;
			clearmask = 64;
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
			name = "天罡道心";
			nativename = "天罡道心";
			icon = "天罡道心.dds";
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
		public override int GetRequiredLevel(int level)
		{
			int[] array={105,105,105,110,115,120,125,125,125,125,125,125};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasaddanti((skill_level * (skill_level * 0.13f) + ((2 * skill_level))));
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={25,50,125,250,500,1000,1800,3600,7200,14400,14400,14400};return array[level-1];
		}
	}
	public class GSkill1508 : GSkill
	{
		public GSkill1508()
			: base(1508)
		{
			
		}
	}
	public class GSkill1509Stub : GSkillStub
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
		public GSkill1509Stub()
			: base(1509)
		{
			occupation = 147;
			maxlevel = 50;
			maxlearn = 12;
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
			credittype = 8;
			clearmask = 64;
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
			SetAction(0,"青云门_天罡战意");
			SetAction(1,"青云门_天罡战意");
			SetAction(2,"鬼王宗_天罡战意");
			SetAction(3,"合欢派_天罡战意");
			SetAction(4,"天音寺_天罡战意");
			SetAction(5,"鬼道_天罡战意");
			SetAction(6,"焚香谷_天罡战意");
			SetAction(7,"兽神_天罡战意");
			SetAction(8,"狐妖_天罡战意");
			SetAction(9,"太昊_天罡战意");
			SetAction(10,"怀光_天罡战意");
			SetAction(11,"太昊_天罡战意");
			SetAction(12,"天华_天罡战意");
			SetAction(13,"灵夙_天罡战意");
			SetAction(14,"英招_天罡战意");
			SetAction(15,"元素大师_坚盾");
			SetAction(16,"元素大师_天罡战意");
			SetAction(17,"天音寺_天罡战意");
			SetAction(18,"青云门_骑乘_天罡战意");
			SetAction(19,"青云门_骑乘_天罡战意");
			SetAction(20,"鬼王宗_骑乘_天罡战意");
			SetAction(21,"合欢派_骑乘_天罡战意");
			SetAction(22,"天音寺_骑乘_天罡战意");
			SetAction(23,"鬼道_骑乘_天罡战意");
			SetAction(24,"焚香谷_骑乘_天罡战意");
			SetAction(25,"兽神_骑乘_天罡战意");
			SetAction(26,"狐妖_骑乘_天罡战意");
			SetAction(27,"太昊_骑乘_天罡战意");
			SetAction(28,"怀光_骑乘_天罡战意");
			SetAction(29,"太昊_骑乘_天罡战意");
			SetAction(30,"天华_骑乘_天罡战意");
			name = "天罡战意";
			nativename = "天罡战意";
			icon = "天罡战意.dds";
			SetTalent(0,1508);
			SetTalent(1,1505);
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
			int				skill_t0 = skill.GetT0();

			return 600000 - 30000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={105,105,105,110,115,120,125,125,125,125,125,125};return array[level-1];
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(100.0f);
			victim.SetTime(((skill_t1 * 0.05f + 1.0f) * 180000.0f));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t1 * 0.05f + 1.0f) * ((player_level * 0.05f / 15.0f + 1.0f) * ((2 * (skill_level * skill_level + (2 * skill_level)))))));
			victim.SetAddattack4(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={25,50,125,250,500,1000,1800,3600,7200,14400,14400,14400};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1508};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1509 : GSkill
	{
		public GSkill1509()
			: base(1509)
		{
			
		}
	}
}
