using System;
using System.Text;

namespace SKILL
{
	public class GSkill2370Stub : GSkillStub
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
		public GSkill2370Stub()
			: base(2370)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
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
			need_item = true;
			item1_id = 33137;
			item1_num = 1;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"青云门_炼气还神");
			SetAction(1,"青云门_炼气还神");
			SetAction(2,"鬼王宗_枯木咒");
			SetAction(3,"合欢派_激励");
			SetAction(4,"天音寺_易筋经");
			SetAction(5,"凝神血咒");
			SetAction(6,"焚香_坚盾");
			SetAction(7,"兽神_横行");
			SetAction(8,"狐妖_固元术");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"灵夙_坚盾");
			SetAction(14,"英招_坚盾");
			SetAction(15,"武器大师_增益效果");
			SetAction(16,"武器大师_增益效果");
			SetAction(17,"归云_设置气血");
			SetAction(18,"青云门_骑乘_炼气还神");
			SetAction(19,"青云门_骑乘_炼气还神");
			SetAction(20,"鬼王宗_骑乘_枯木咒");
			SetAction(21,"合欢派_骑乘_激励");
			SetAction(22,"天音寺_骑乘_易筋经");
			SetAction(23,"凝神血咒");
			SetAction(24,"0");
			SetAction(25,"兽神_骑乘_横行");
			SetAction(26,"狐妖_骑乘_固元术");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "三昧真炎火";
			nativename = "三昧真炎火";
			icon = "祝融.dds";
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
			int				skill_level = skill.GetLevel();

			return 840000 - 240000 * skill_level;
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
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(20000.0f);
			victim.SetBuffid(2);
			victim.SetValue(3275.0f);
			victim.SetAddattack(true);
			return true;
		}
	}
	public class GSkill2370 : GSkill
	{
		public GSkill2370()
			: base(2370)
		{
			
		}
	}
	public class GSkill2371Stub : GSkillStub
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
		public GSkill2371Stub()
			: base(2371)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
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
			need_item = true;
			item1_id = 33138;
			item1_num = 1;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"青云门_炼气还神");
			SetAction(1,"青云门_炼气还神");
			SetAction(2,"鬼王宗_枯木咒");
			SetAction(3,"合欢派_激励");
			SetAction(4,"天音寺_易筋经");
			SetAction(5,"凝神血咒");
			SetAction(6,"");
			SetAction(7,"兽神_横行");
			SetAction(8,"狐妖_固元术");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"灵夙_坚盾");
			SetAction(14,"英招_坚盾");
			SetAction(15,"武器大师_增益效果");
			SetAction(16,"武器大师_增益效果");
			SetAction(17,"归云_设置气血");
			SetAction(18,"青云门_骑乘_炼气还神");
			SetAction(19,"青云门_骑乘_炼气还神");
			SetAction(20,"鬼王宗_骑乘_枯木咒");
			SetAction(21,"合欢派_骑乘_激励");
			SetAction(22,"天音寺_骑乘_易筋经");
			SetAction(23,"凝神血咒");
			SetAction(24,"0");
			SetAction(25,"兽神_骑乘_横行");
			SetAction(26,"狐妖_骑乘_固元术");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "六合幻星泪";
			nativename = "六合幻星泪";
			icon = "共工.dds";
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
			int				skill_level = skill.GetLevel();

			return 840000 - 240000 * skill_level;
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
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(0.40000001f);
			victim.SetBuffid(2);
			victim.SetDecfatalratio(true);
			return true;
		}
	}
	public class GSkill2371 : GSkill
	{
		public GSkill2371()
			: base(2371)
		{
			
		}
	}
	public class GSkill2372Stub : GSkillStub
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
		public GSkill2372Stub()
			: base(2372)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
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
			need_item = true;
			item1_id = 33139;
			item1_num = 1;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"青云门_炼气还神");
			SetAction(1,"青云门_炼气还神");
			SetAction(2,"鬼王宗_枯木咒");
			SetAction(3,"合欢派_激励");
			SetAction(4,"天音寺_易筋经");
			SetAction(5,"凝神血咒");
			SetAction(6,"0");
			SetAction(7,"兽神_横行");
			SetAction(8,"狐妖_固元术");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"灵夙_加速");
			SetAction(14,"英招_加速");
			SetAction(15,"武器大师_增益效果");
			SetAction(16,"武器大师_增益效果");
			SetAction(17,"归云_设置气血");
			SetAction(18,"青云门_骑乘_炼气还神");
			SetAction(19,"青云门_骑乘_炼气还神");
			SetAction(20,"鬼王宗_骑乘_枯木咒");
			SetAction(21,"合欢派_骑乘_激励");
			SetAction(22,"天音寺_骑乘_易筋经");
			SetAction(23,"凝神血咒");
			SetAction(24,"0");
			SetAction(25,"兽神_骑乘_横行");
			SetAction(26,"狐妖_骑乘_固元术");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "五龙腾空瑞";
			nativename = "五龙腾空瑞";
			icon = "风波.dds";
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
			int				skill_level = skill.GetLevel();

			return 840000 - 240000 * skill_level;
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
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(45000.0f);
			victim.SetBuffid(2);
			victim.SetValue(2.2f);
			victim.SetAddspeed(true);
			return true;
		}
	}
	public class GSkill2372 : GSkill
	{
		public GSkill2372()
			: base(2372)
		{
			
		}
	}
	public class GSkill2373Stub : GSkillStub
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
		public GSkill2373Stub()
			: base(2373)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
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
			need_item = true;
			item1_id = 33140;
			item1_num = 1;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"青云门_炼气还神");
			SetAction(1,"青云门_炼气还神");
			SetAction(2,"鬼王宗_枯木咒");
			SetAction(3,"合欢派_激励");
			SetAction(4,"天音寺_易筋经");
			SetAction(5,"凝神血咒");
			SetAction(6,"0");
			SetAction(7,"兽神_横行");
			SetAction(8,"狐妖_固元术");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"灵夙_坚盾");
			SetAction(14,"英招_坚盾");
			SetAction(15,"武器大师_增益效果");
			SetAction(16,"武器大师_增益效果");
			SetAction(17,"归云_设置气血");
			SetAction(18,"青云门_骑乘_炼气还神");
			SetAction(19,"青云门_骑乘_炼气还神");
			SetAction(20,"鬼王宗_骑乘_枯木咒");
			SetAction(21,"合欢派_骑乘_激励");
			SetAction(22,"天音寺_骑乘_易筋经");
			SetAction(23,"凝神血咒");
			SetAction(24,"0");
			SetAction(25,"兽神_骑乘_横行");
			SetAction(26,"狐妖_骑乘_固元术");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "八极煌雷闪";
			nativename = "八极煌雷闪";
			icon = "雨师.dds";
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
			int				skill_level = skill.GetLevel();

			return 840000 - 240000 * skill_level;
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
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(30000.0f);
			victim.SetBuffid(2);
			victim.SetValue(8275.0f);
			victim.SetAdddefence(true);
			return true;
		}
	}
	public class GSkill2373 : GSkill
	{
		public GSkill2373()
			: base(2373)
		{
			
		}
	}
	public class GSkill2374Stub : GSkillStub
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
		public GSkill2374Stub()
			: base(2374)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
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
			need_item = true;
			item1_id = 33141;
			item1_num = 1;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"青云门_炼气还神");
			SetAction(1,"青云门_炼气还神");
			SetAction(2,"鬼王宗_枯木咒");
			SetAction(3,"合欢派_激励");
			SetAction(4,"天音寺_易筋经");
			SetAction(5,"凝神血咒");
			SetAction(6,"0");
			SetAction(7,"兽神_横行");
			SetAction(8,"狐妖_固元术");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"灵夙_坚盾");
			SetAction(14,"英招_坚盾");
			SetAction(15,"武器大师_增益效果");
			SetAction(16,"武器大师_增益效果");
			SetAction(17,"归云_设置气血");
			SetAction(18,"青云门_骑乘_炼气还神");
			SetAction(19,"青云门_骑乘_炼气还神");
			SetAction(20,"鬼王宗_骑乘_枯木咒");
			SetAction(21,"合欢派_骑乘_激励");
			SetAction(22,"天音寺_骑乘_易筋经");
			SetAction(23,"凝神血咒");
			SetAction(24,"0");
			SetAction(25,"兽神_骑乘_横行");
			SetAction(26,"狐妖_骑乘_固元术");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "七杀斗魂罡";
			nativename = "七杀斗魂罡";
			icon = "战神.dds";
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
			int				skill_level = skill.GetLevel();

			return 840000 - 240000 * skill_level;
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
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(20000.0f);
			victim.SetRatio(0.23999999f);
			victim.SetBuffid(2);
			victim.SetIncskillaccu(true);
			return true;
		}
	}
	public class GSkill2374 : GSkill
	{
		public GSkill2374()
			: base(2374)
		{
			
		}
	}
	public class GSkill2375Stub : GSkillStub
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
		public GSkill2375Stub()
			: base(2375)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
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
			need_item = true;
			item1_id = 33142;
			item1_num = 1;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"青云门_炼气还神");
			SetAction(1,"青云门_炼气还神");
			SetAction(2,"鬼王宗_枯木咒");
			SetAction(3,"合欢派_激励");
			SetAction(4,"天音寺_易筋经");
			SetAction(5,"凝神血咒");
			SetAction(6,"0");
			SetAction(7,"兽神_横行");
			SetAction(8,"狐妖_固元术");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"灵夙_坚盾");
			SetAction(14,"英招_坚盾");
			SetAction(15,"武器大师_增益效果");
			SetAction(16,"武器大师_增益效果");
			SetAction(17,"归云_设置气血");
			SetAction(18,"青云门_骑乘_炼气还神");
			SetAction(19,"青云门_骑乘_炼气还神");
			SetAction(20,"鬼王宗_骑乘_枯木咒");
			SetAction(21,"合欢派_骑乘_激励");
			SetAction(22,"天音寺_骑乘_易筋经");
			SetAction(23,"凝神血咒");
			SetAction(24,"0");
			SetAction(25,"兽神_骑乘_横行");
			SetAction(26,"狐妖_骑乘_固元术");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "九华淀魂曲";
			nativename = "九华淀魂曲";
			icon = "帝俊.dds";
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
			int				skill_level = skill.GetLevel();

			return 840000 - 240000 * skill_level;
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
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(20000.0f);
			victim.SetRatio(1.2f);
			victim.SetBuffid(2);
			victim.SetInccrithurt(true);
			return true;
		}
	}
	public class GSkill2375 : GSkill
	{
		public GSkill2375()
			: base(2375)
		{
			
		}
	}
	public class GSkill2376Stub : GSkillStub
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
		public GSkill2376Stub()
			: base(2376)
		{
			occupation = 151;
			maxlevel = 2;
			maxlearn = 1;
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
			skill_limit = 23;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = true;
			item1_id = 32934;
			item1_num = 1;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"鬼道_百鬼夜行");
			SetAction(1,"青云门_五气朝元");
			SetAction(2,"鬼王宗_锐金咒");
			SetAction(3,"合欢派_热情");
			SetAction(4,"天音寺_慈航普度");
			SetAction(5,"鬼道_百鬼夜行");
			SetAction(6,"0");
			SetAction(7,"兽神_横行");
			SetAction(8,"狐妖_风行者");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"元素大师_照妖");
			SetAction(16,"元素大师_照妖");
			SetAction(17,"");
			SetAction(18,"鬼道_骑乘_百鬼夜行");
			SetAction(19,"青云门_骑乘_五气朝元");
			SetAction(20,"鬼王宗_骑乘_锐金咒");
			SetAction(21,"合欢派_骑乘_热情");
			SetAction(22,"天音寺_骑乘_慈航普度");
			SetAction(23,"鬼道_骑乘_百鬼夜行");
			SetAction(24,"0");
			SetAction(25,"兽神_骑乘_横行");
			SetAction(26,"狐妖_骑乘_风行者");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "雪孩子的祝福";
			nativename = "雪孩子的祝福";
			icon = "雪球.dds";
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
		public override int GetCooldowntime(GSkill skill)
		{
			return 5000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(99.0f);
			victim.SetRatio(0.0f);
			if ( skill_level == 1 )
			d = (zrand(3) + 3);
			else
			victim.SetAmount(((zrand(6) + 5)));
			victim.SetValue(32934.0f);
			victim.SetCreateitem(true);
			victim.SetProbability(120.0f);
			victim.SetTime(3600000.0f);
			victim.SetBuffid(3);
			victim.SetValue((player_level * 0.5f + 25.0f));
			victim.SetAdddefence(true);
			if ( skill_level == 1 )
			v33 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(3600000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(3);
			victim.SetAmount(0.0f);
			victim.SetValue(((player_level * 0.2f + 5.0f) * 1800.0f));
			victim.SetHpgen(true);
			if ( skill_level == 2 )
			v32 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(3600000.0f);
			victim.SetBuffid(3);
			victim.SetAmount(0.0f);
			victim.SetValue(((player_level * 0.2f + 5.0f) * 1800.0f));
			victim.SetMpgen(true);
			*/
			return true;
		}
	}
	public class GSkill2376 : GSkill
	{
		public GSkill2376()
			: base(2376)
		{
			
		}
	}
	public class GSkill2377Stub : GSkillStub
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
		public GSkill2377Stub()
			: base(2377)
		{
			occupation = 129;
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
			SetAction(0,"鬼王宗_照妖");
			SetAction(1,"青云门_照妖");
			SetAction(2,"鬼王宗_照妖");
			SetAction(3,"合欢派_照妖");
			SetAction(4,"天音寺_照妖");
			SetAction(5,"鬼道_照妖");
			SetAction(6,"0");
			SetAction(7,"兽神_照妖");
			SetAction(8,"狐妖_照妖");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"鬼王宗_骑乘_照妖");
			SetAction(19,"青云门_骑乘_照妖");
			SetAction(20,"鬼王宗_骑乘_照妖");
			SetAction(21,"合欢派_骑乘_照妖");
			SetAction(22,"天音寺_骑乘_照妖");
			SetAction(23,"合欢派_骑乘_照妖");
			SetAction(24,"0");
			SetAction(25,"兽神_骑乘_照妖");
			SetAction(26,"狐妖_骑乘_照妖");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "真视";
			nativename = "真视";
			icon = "真视.dds";
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
		public override int GetCooldowntime(GSkill skill)
		{
			return 2000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 5.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 10.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 10.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetValue(167.0f);
			victim.SetBackorigin(true);
			return true;
		}
	}
	public class GSkill2377 : GSkill
	{
		public GSkill2377()
			: base(2377)
		{
			
		}
	}
	public class GSkill2378Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill2378Stub()
			: base(2378)
		{
			occupation = 128;
			maxlevel = 5;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			name = "三界BOSS技能2";
			nativename = "三界BOSS技能2";
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
		public override int GetCooldowntime(GSkill skill)
		{
			return 6000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 21.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 21.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 24.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 400.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_mp = player.GetMp();
			int				player_res1 = player.GetRes1();
			int				skill_level = skill.GetLevel();

			/*
			if ( player_res1 > 200 )
			d = 0.0f;
			else
			victim.SetProbability(600.0f);
			victim.SetTime(((1000 * (zrand(6) + skill_level))));
			victim.SetDizzy(true);
			victim.SetProbability(120.0f);
			victim.SetTime(200.0f);
			victim.SetBuffid(1);
			if ( player_res1 <= 200 )
			{
			v28 = 0.0f;
			}
			else
			{
			v28 = (zrand(25) * 0.01f + 0.5f) * player_hp;
			}
			victim.SetAmount(v28);
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(120.0f);
			victim.SetTime(200.0f);
			victim.SetBuffid(1);
			if ( player_res1 <= 200 )
			{
			v27 = 0.0f;
			}
			else
			{
			v27 = (zrand(25) * 0.01f + 0.5f) * player_mp;
			}
			victim.SetAmount(v27);
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			*/
			return true;
		}
	}
	public class GSkill2378 : GSkill
	{
		public GSkill2378()
			: base(2378)
		{
			
		}
	}
	public class GSkill2379Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill2379Stub()
			: base(2379)
		{
			occupation = 128;
			maxlevel = 10;
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
			name = "天空之城-四大圣兽";
			nativename = "天空之城-四大圣兽";
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
		public override int GetCooldowntime(GSkill skill)
		{
			return 1000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_skilldodge = player.GetSkilldodge();
			int				skill_level = skill.GetLevel();

			/*
			if ( player_skilldodge >= 100 * ((skill_level / 3.99f) + skill_level)
			&& (v5 = player,
			v6 = GNET::PlayerWrapper::GetLevel(v5),
			v6 >= 2 * skill_level + 140) )
			d = 1.0f;
			else
			victim.SetRatio(1000.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(1.0f);
			victim.SetSecondattack(true);
			victim.SetProbability(100.0f);
			victim.SetAmount(20.0f);
			victim.SetClearbuff(true);
			*/
			return true;
		}
	}
	public class GSkill2379 : GSkill
	{
		public GSkill2379()
			: base(2379)
		{
			
		}
	}
}
