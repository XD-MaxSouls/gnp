using System;
using System.Text;

namespace SKILL
{
	public class GSkill220Stub : GSkillStub
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
		public GSkill220Stub()
			: base(220)
		{
			occupation = 0;
			maxlevel = 15;
			maxlearn = 6;
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
			SetAction(0,"鬼王宗_虎啸");
			SetAction(1,"青云门_虎啸");
			SetAction(2,"鬼王宗_虎啸");
			SetAction(3,"合欢派_虎啸");
			SetAction(4,"天音寺_虎啸");
			SetAction(5,"鬼王宗_虎啸");
			SetAction(6,"青云门_虎啸");
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
			SetAction(18,"鬼王宗_骑乘_虎啸");
			SetAction(19,"青云门_骑乘_虎啸");
			SetAction(20,"鬼王宗_骑乘_虎啸");
			SetAction(21,"合欢派_骑乘_虎啸");
			SetAction(22,"天音寺_骑乘_虎啸");
			SetAction(23,"鬼王宗_骑乘_虎啸");
			SetAction(24,"青云门_骑乘_虎啸");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "勇气";
			nativename = "勇气";
			icon = "勇气.dds";
			SetTalent(0,636);
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
			skill_class = -1;
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
			return 2000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={4,7,9,11,13,15};return array[level-1];
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

			return (skill_level * 1.6f + (skill_level * (skill_level * 0.25f)) + 17.5f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetTime(1800000.0f);
			victim.SetBuffid(4);
			victim.SetValue(4 * (skill_level * skill_t0 + skill_level) + 1);
			victim.SetAddattack2(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={218};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill220 : GSkill
	{
		public GSkill220()
			: base(220)
		{
			
		}
	}
	public class GSkill221Stub : GSkillStub
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
		public GSkill221Stub()
			: base(221)
		{
			occupation = 0;
			maxlevel = 15;
			maxlearn = 6;
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
			SetAction(0,"鬼王宗_包扎");
			SetAction(1,"青云门_包扎");
			SetAction(2,"鬼王宗_包扎");
			SetAction(3,"合欢派_包扎");
			SetAction(4,"天音寺_包扎");
			SetAction(5,"鬼道_包扎");
			SetAction(6,"青云门_包扎");
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
			SetAction(18,"鬼王宗_骑乘_包扎");
			SetAction(19,"青云门_骑乘_包扎");
			SetAction(20,"鬼王宗_骑乘_包扎");
			SetAction(21,"合欢派_骑乘_包扎");
			SetAction(22,"天音寺_骑乘_包扎");
			SetAction(23,"鬼道_骑乘_包扎");
			SetAction(24,"青云门_骑乘_包扎");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "疗伤";
			nativename = "疗伤";
			icon = "疗伤.dds";
			SetTalent(0,585);
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
			skill_class = -1;
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

			return 25000 - 1000 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={6,8,10,12,14,15};return array[level-1];
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
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (10 * skill_level + 15);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetValue((skill_t0 * 0.4f + 1.0f) * (10 * skill_level + 15));
			victim.SetHeal(true);
			victim.SetProbability(120.0f);
			victim.SetTime(8000 * skill_level + 8000);
			victim.SetRatio(0.0f);
			victim.SetBuffid(3);
			victim.SetAmount(0.0f);
			victim.SetValue((skill_t0 * 0.4f + 1.0f) * ((skill_level << 6) + 64));
			victim.SetHpgen(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={219};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill221 : GSkill
	{
		public GSkill221()
			: base(221)
		{
			
		}
	}
	public class GSkill222Stub : GSkillStub
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
				int				skill_t3 = skill.GetT3();

				skill.SetCrit(skill_t2 * 0.01f + ((skill_level / 9) * (skill_t2 * 0.01f)));
				skill.SetCrithurt(INT(skill_level / 9) * (skill_t2 * 0.3f));
				int level_sum = 0;
				if (player.GetSkilllevel(237) > 8) level_sum ++;
				if (player.GetSkilllevel(222) > 8) level_sum ++;
				if (player.GetSkilllevel(232) > 8) level_sum ++;
				if (player.GetSkilllevel(228) > 8) level_sum ++;
				if (player.GetSkilllevel(312) > 8) level_sum ++;
				if (player.GetSkilllevel(240) > 8) level_sum ++;
				if (player.GetSkilllevel(541) > 8) level_sum ++;
				if (player.GetSkilllevel(545) > 8) level_sum ++;
				skill.SetRatio(((0.05f * level_sum) * skill_t2 * norm(skill_t2) + 1.0f) + (0.05f * skill_t2) + (0.04f * INT((player.GetMp() / (0.95f - skill_t3 * 0.1f)) / player.GetMaxmp())));
				skill.SetPlus((skill_t0 * 0.15f + 1.0f) * ((skill_level * 8.9f + (skill_level * (skill_level * 0.72f)) + 18.0f) * INT(skill_level * 0.05f + 0.55f) + (INT(1.42f - skill_level * 0.05f) * (8 * skill_level + 60))));
				player.SetPerform(1);
			}
		}
		public GSkill222Stub()
			: base(222)
		{
			occupation = 7;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
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
			name = "御剑诀";
			nativename = "御剑诀";
			icon = "御剑诀.dds";
			SetTalent(0,569);
			SetTalent(1,579);
			SetTalent(2,583);
			SetTalent(3,612);
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
			int				skill_t1 = skill.GetT1();

			return 6000 - 1000 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={25,27,29,31,33,35,37,39,41};return array[level-1];
		}
		public override float GetAttackdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 6.5f);
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
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 39);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 12;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t3 = skill.GetT3();

			victim.SetBuffid(INT((player.GetMp() / (0.95f - skill_t3 * 0.1f)) / player.GetMaxmp()));
			victim.SetUniqprompt(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={460};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill222 : GSkill
	{
		public GSkill222()
			: base(222)
		{
			
		}
	}
	public class GSkill223Stub : GSkillStub
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
				int				skill_t1 = skill.GetT1();

				skill.SetPlus((skill_t1 * 0.1f + 1.0f) * ((skill_level * 7.1f + (skill_level * (skill_level * 0.46f)) + 4.2f) * INT(skill_level * 0.05f + 0.55f) + (INT(1.42f - skill_level * 0.05f) * (4 * skill_level + 49) + (6 * skill_t0 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill223Stub()
			: base(223)
		{
			occupation = 7;
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
			SetAction(0,"青云门_寒冰咒");
			SetAction(1,"青云门_寒冰咒");
			SetAction(2,"青云门_寒冰咒");
			SetAction(3,"青云门_寒冰咒");
			SetAction(4,"青云门_寒冰咒");
			SetAction(5,"青云门_寒冰咒");
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
			SetAction(18,"青云门_骑乘_寒冰咒");
			SetAction(19,"青云门_骑乘_寒冰咒");
			SetAction(20,"青云门_骑乘_寒冰咒");
			SetAction(21,"青云门_骑乘_寒冰咒");
			SetAction(22,"青云门_骑乘_寒冰咒");
			SetAction(23,"青云门_骑乘_寒冰咒");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "寒冰咒";
			nativename = "寒冰咒";
			icon = "寒冰咒.dds";
			SetTalent(0,567);
			SetTalent(1,602);
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
			return 2000;
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
			return 20.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 10.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(2 * skill_level * skill_t0 + (3 * skill_level) + 45);
			victim.SetTime(1000 * skill_level + 3100);
			victim.SetRatio(((INT(zrand(6 * skill_t0 + 99) / 100) + 1) * (skill_t0 * (skill_level * 0.02f) + (skill_level * 0.03f + 0.19f))) - player_level * 0.001f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={8};return array[index];
		}
	}
	public class GSkill223 : GSkill
	{
		public GSkill223()
			: base(223)
		{
			
		}
	}
	public class GSkill224Stub : GSkillStub
	{
		public GSkill224Stub()
			: base(224)
		{
			occupation = 8;
			maxlevel = 12;
			maxlearn = 6;
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
			name = "南华真经";
			nativename = "南华真经";
			icon = "南华真经.dds";
			SetTalent(0,591);
			SetTalent(1,595);
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={55,59,63,67,71,73};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			player.SetPasaddmp((skill_t0 * 0.15f + 1.0f) * (300 * skill_level));
			player.SetPasaddhp(20 * skill_t1 * skill_level);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={235};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill224 : GSkill
	{
		public GSkill224()
			: base(224)
		{
			
		}
	}
	public class GSkill225Stub : GSkillStub
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

				skill.SetRatio(skill_t2 * 0.05f + 1.0f);
				skill.SetPlus(((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * (((17 * skill_level) + (skill_level * (skill_level * 0.6f)) + 7.7f) * INT(skill_level * 0.05f + 0.55f) + ((skill_level * 6.2f + (skill_level * (skill_level * 0.028f)) + 122.0f) * INT(1.42f - skill_level * 0.05f))));
				player.SetPerform(1);
			}
		}
		public GSkill225Stub()
			: base(225)
		{
			occupation = 7;
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
			SetAction(0,"青云门_驭雷术");
			SetAction(1,"青云门_驭雷术");
			SetAction(2,"青云门_驭雷术");
			SetAction(3,"青云门_驭雷术");
			SetAction(4,"青云门_驭雷术");
			SetAction(5,"青云门_驭雷术");
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
			SetAction(18,"青云门_骑乘_驭雷术");
			SetAction(19,"青云门_骑乘_驭雷术");
			SetAction(20,"青云门_骑乘_驭雷术");
			SetAction(21,"青云门_骑乘_驭雷术");
			SetAction(22,"青云门_骑乘_驭雷术");
			SetAction(23,"青云门_骑乘_驭雷术");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "驭雷术";
			nativename = "驭雷术";
			icon = "驭雷术.dds";
			SetTalent(0,606);
			SetTalent(1,610);
			SetTalent(2,617);
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
			return 2000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={30,32,34,36,38,40,42,44,46};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 8.000000f;
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
			int				skill_level = skill.GetLevel();

			return ((skill_level * (skill_level * 0.6f)) - skill_level * 2.9f + 80.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return skill_level + 15;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(5 * skill_t1);
			victim.SetTime(3050 * skill_t1);
			victim.SetRatio(skill_t1 * 0.05f);
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.30000001f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={226};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill225 : GSkill
	{
		public GSkill225()
			: base(225)
		{
			
		}
	}
	public class GSkill226Stub : GSkillStub
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
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				skill.SetRatio(skill_t2 * 0.05f + 1.0f);
				skill.SetPlus((skill_t0 * 0.1f + 1.0f) * (((skill_level * (skill_level * 0.78f)) - skill_level * 4.6f + 76.0f) * INT(skill_level * 0.05f + 0.55f) + ((skill_level * 2.6f + (skill_level * (skill_level * 0.32f)) + 44.0f) * INT(1.42f - skill_level * 0.05f))) + (4 * skill_level * skill_t1));
				player.SetPerform(1);
			}
		}
		public GSkill226Stub()
			: base(226)
		{
			occupation = 7;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 1;
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
			SetAction(0,"青云门_霜刃决");
			SetAction(1,"青云门_霜刃决");
			SetAction(2,"青云门_霜刃决");
			SetAction(3,"青云门_霜刃决");
			SetAction(4,"青云门_霜刃决");
			SetAction(5,"青云门_霜刃决");
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
			SetAction(18,"青云门_骑乘_霜刃决");
			SetAction(19,"青云门_骑乘_霜刃决");
			SetAction(20,"青云门_骑乘_霜刃决");
			SetAction(21,"青云门_骑乘_霜刃决");
			SetAction(22,"青云门_骑乘_霜刃决");
			SetAction(23,"青云门_骑乘_霜刃决");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "寒霜剑气";
			nativename = "寒霜剑气";
			icon = "寒霜剑气.dds";
			SetTalent(0,602);
			SetTalent(1,605);
			SetTalent(2,617);
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
			return 2000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={20,22,24,26,28,30,32,34,36};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 1.500000f;
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
			return 20.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 15;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(2 * skill_level + 35);
			victim.SetTime(3000 * skill_t1 + 3100);
			victim.SetRatio(skill_level * 0.02f + 0.08f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.3000001f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={223};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill226 : GSkill
	{
		public GSkill226()
			: base(226)
		{
			
		}
	}
	public class GSkill227Stub : GSkillStub
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
		public GSkill227Stub()
			: base(227)
		{
			occupation = 130;
			maxlevel = 10;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 1;
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
			name = "完美密探之念";
			nativename = "完美密探之念";
			icon = "大悲咒.dds";
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
		public override float GetRadius(GSkill skill)
		{
			return 40.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 40.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 200.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(3000.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(3600000.0f);
			victim.SetRatio(100 * skill_level);
			victim.SetAmount(18.0f);
			victim.SetValue(100 * skill_level);
			victim.SetEvilaura(true);
			return true;
		}
	}
	public class GSkill227 : GSkill
	{
		public GSkill227()
			: base(227)
		{
			
		}
	}
	public class GSkill228Stub : GSkillStub
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
				int				skill_t3 = skill.GetT3();

				skill.SetCrit(skill_t3 * 0.01f + (D2INT(skill_level / 9) * (skill_t3 * 0.01f)));
				skill.SetCrithurt(D2INT(skill_level / 9) * (skill_t3 * 0.3f));
				int level_sum = 0;
				if (player.GetSkilllevel(237) > 8) level_sum ++;
				if (player.GetSkilllevel(222) > 8) level_sum ++;
				if (player.GetSkilllevel(232) > 8) level_sum ++;
				if (player.GetSkilllevel(228) > 8) level_sum ++;
				if (player.GetSkilllevel(312) > 8) level_sum ++;
				if (player.GetSkilllevel(240) > 8) level_sum ++;
				if (player.GetSkilllevel(541) > 8) level_sum ++;
				if (player.GetSkilllevel(545) > 8) level_sum ++;
				skill.SetRatio(((0.05f * level_sum) * skill_t3 * norm(skill_t3)) + (skill_t3 * 0.05f + 1.0f));
				skill.SetPlus((skill_t0 * 0.2f + 1.0f) * (((24 * skill_level) + (skill_level * (skill_level * 1.2f)) + 299.0f) * D2INT(skill_level * 0.05f + 0.55f) + (D2INT(1.42f - skill_level * 0.05f) * (27 * skill_level + 325))));
				player.SetPerform(1);
			}
		}
		public GSkill228Stub()
			: base(228)
		{
			occupation = 8;
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
			SetAction(0,"青云门_破魔剑气");
			SetAction(1,"青云门_破魔剑气");
			SetAction(2,"青云门_破魔剑气");
			SetAction(3,"青云门_破魔剑气");
			SetAction(4,"青云门_破魔剑气");
			SetAction(5,"青云门_破魔剑气");
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
			SetAction(18,"青云门_骑乘_破魔剑气");
			SetAction(19,"青云门_骑乘_破魔剑气");
			SetAction(20,"青云门_骑乘_破魔剑气");
			SetAction(21,"青云门_骑乘_破魔剑气");
			SetAction(22,"青云门_骑乘_破魔剑气");
			SetAction(23,"青云门_骑乘_破魔剑气");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "破魔剑气";
			nativename = "破魔剑气";
			icon = "破魔剑气.dds";
			SetTalent(0,573);
			SetTalent(1,574);
			SetTalent(2,579);
			SetTalent(3,583);
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
			int				skill_t2 = skill.GetT2();

			return 6000 - 1000 * skill_t2;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={70,72,74,76,78,80,82,83,85};return array[level-1];
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 10.000000f;
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
			int				skill_level = skill.GetLevel();

			return (skill_level * 6.7f + (skill_level * (skill_level * 0.46f)) + 159.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 12;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability((1.0f - player_level * 0.002f) * (10 * skill_t1 + (3 * skill_level) + 12));
			victim.SetRatio((skill_t0 * 0.5f + 1.0f) * (skill_level * 0.04f + 0.16f));
			victim.SetDrainmagic(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(20 * skill_t1);
			victim.SetTime(2000.0f);
			victim.SetBuffid(2);
			victim.SetAmount(0.0f);
			victim.SetValue(skill_t1 * ((skill_level * 6.7f + (skill_level * (skill_level * 0.46f)) + 159.0f) * 0.2f));
			victim.SetMpgen(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={312};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill228 : GSkill
	{
		public GSkill228()
			: base(228)
		{
			
		}
	}
	public class GSkill229Stub : GSkillStub
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
		public GSkill229Stub()
			: base(229)
		{
			occupation = 8;
			maxlevel = 12;
			maxlearn = 6;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 5;
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
			SetAction(0,"青云门_冰心诀");
			SetAction(1,"青云门_冰心诀");
			SetAction(2,"青云门_冰心诀");
			SetAction(3,"青云门_冰心诀");
			SetAction(4,"青云门_冰心诀");
			SetAction(5,"青云门_冰心诀");
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
			SetAction(18,"青云门_骑乘_冰心诀");
			SetAction(19,"青云门_骑乘_冰心诀");
			SetAction(20,"青云门_骑乘_冰心诀");
			SetAction(21,"青云门_骑乘_冰心诀");
			SetAction(22,"青云门_骑乘_冰心诀");
			SetAction(23,"青云门_骑乘_冰心诀");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "冰心诀";
			nativename = "冰心诀";
			icon = "冰心诀.dds";
			SetTalent(0,590);
			SetTalent(1,592);
			SetTalent(2,596);
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
			int				skill_t2 = skill.GetT2();

			return 120000 - 10000 * skill_t2;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={65,70,75,77,79,81};return array[level-1];
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

			return ((18 * skill_level) + (skill_level * (skill_level * 0.62f)) + 121.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(120.0f);
			victim.SetTime(4000 * skill_level + 6100);
			victim.SetRatio(skill_level * (skill_t0 * 0.01f + 0.01f));
			victim.SetBuffid(1);
			victim.SetIncdefence(true);
			victim.SetRatio(233.0f);
			victim.SetAmount(235.0f);
			victim.SetValue(239.0f);
			victim.SetClearcooldown(true);
			victim.SetRatio(23 * norm(skill_t0 / 1.5f) + 218);
			victim.SetAmount(218.0f);
			victim.SetValue(218.0f);
			victim.SetClearcooldown(true);
			victim.SetProbability(100.0f);
			victim.SetTime(4000 * norm(skill_t1));
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(skill_t1 * (((18 * skill_level) + (skill_level * (skill_level * 0.62f)) + 121.0f) * 0.15f));
			victim.SetMpgen(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120 * norm(skill_t0 / 1.5f));
			victim.SetAmount(3.0f);
			victim.SetCleardebuff(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={224};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill229 : GSkill
	{
		public GSkill229()
			: base(229)
		{
			
		}
	}
}
