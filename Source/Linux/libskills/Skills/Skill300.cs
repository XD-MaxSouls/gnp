using System;
using System.Text;

namespace SKILL
{
	public class GSkill300Stub : GSkillStub
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
		public GSkill300Stub()
			: base(300)
		{
			occupation = 4;
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
			SetAction(0,"∫œª∂≈…_«„«È");
			SetAction(1,"∫œª∂≈…_«„«È");
			SetAction(2,"∫œª∂≈…_«„«È");
			SetAction(3,"∫œª∂≈…_«„«È");
			SetAction(4,"∫œª∂≈…_«„«È");
			SetAction(5,"0");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_«„«È");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_«„«È");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_«„«È");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_«„«È");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_«„«È");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "«„«È";
			nativename = "«„«È";
			icon = "«„«È.dds";
			SetTalent(0,763);
			SetTalent(1,764);
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
			int				skill_t1 = skill.GetT1();

			return 120000 - 9600 * skill_t1;
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
			int				skill_level = skill.GetLevel();

			return (6 * skill_level + 36);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(120.0f);
			victim.SetTime(((skill_t2 * 0.1f + 1.0f) * ((2000 * skill_level + 14000)) + 100.0f));
			victim.SetRatio(((D2INT(zrand(100) / (100 - 6 * skill_t0)) + 1) * (skill_t0 * 0.01f + (skill_level * 0.01f + 0.04f))));
			victim.SetBuffid(1);
			victim.SetIncattack3(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={466};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill300 : GSkill
	{
		public GSkill300()
			: base(300)
		{
			
		}
	}
	public class GSkill301Stub : GSkillStub
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
		public GSkill301Stub()
			: base(301)
		{
			occupation = 6;
			maxlevel = 20;
			maxlearn = 8;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"∫œª∂≈…_Œ¬»·");
			SetAction(1,"∫œª∂≈…_Œ¬»·");
			SetAction(2,"∫œª∂≈…_Œ¬»·");
			SetAction(3,"∫œª∂≈…_Œ¬»·");
			SetAction(4,"∫œª∂≈…_Œ¬»·");
			SetAction(5,"∫œª∂≈…_Œ¬»·");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_Œ¬»·");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_Œ¬»·");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_Œ¬»·");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_Œ¬»·");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_Œ¬»·");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_Œ¬»·");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Œ¬»·";
			nativename = "Œ¬»·";
			icon = "Œ¬»·.dds";
			SetTalent(0,727);
			SetTalent(1,765);
			SetTalent(2,768);
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
			int				skill_t2 = skill.GetT2();

			return 12000 - 1000 * skill_t2;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={80,82,84,86,88,90,92,94};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 6.5f);
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 6.5f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 3.8f + (skill_level * (skill_level * 1.9f)) + 502.0f);
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
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((2 * skill_level * skill_t0) + (skill_level * 7.9f + 82.0f)));
			victim.SetTime(((skill_t1 * 0.1f + 1.0f) * ((1200 * skill_level + 1800)) + 100.0f));
			victim.SetSilent(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((3050 * skill_t1)));
			victim.SetBuffid(1);
			victim.SetValue(((35 * skill_t1)));
			victim.SetSubdefence(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={306};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill301 : GSkill
	{
		public GSkill301()
			: base(301)
		{
			
		}
	}
	public class GSkill302Stub : GSkillStub
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
		public GSkill302Stub()
			: base(302)
		{
			occupation = 5;
			maxlevel = 20;
			maxlearn = 9;
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
			SetAction(0,"∫œª∂≈…_œ‡Àº");
			SetAction(1,"∫œª∂≈…_œ‡Àº");
			SetAction(2,"∫œª∂≈…_œ‡Àº");
			SetAction(3,"∫œª∂≈…_œ‡Àº");
			SetAction(4,"∫œª∂≈…_œ‡Àº");
			SetAction(5,"∫œª∂≈…_œ‡Àº");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_œ‡Àº");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_œ‡Àº");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_œ‡Àº");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_œ‡Àº");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_œ‡Àº");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_œ‡Àº");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "œ‡Àº";
			nativename = "œ‡Àº";
			icon = "œ‡Àº.dds";
			SetTalent(0,762);
			SetTalent(1,763);
			SetTalent(2,764);
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
			int				skill_t1 = skill.GetT1();

			return 180000 - 14400 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={55,60,65,71,75,78,80,83,86};return array[level-1];
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

			return (skill_level * 3.4f + (skill_level * (skill_level * 2.7f)) + 238.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetValue(((skill_t0 * 0.15f + 1.0f) * ((186 * skill_level + (12 * skill_level * skill_level) + 1800))));
			victim.SetHeal(true);
			victim.SetProbability(((25 - 3 * skill_t0)));
			victim.SetTime(((2000 * skill_level + 22100)));
			victim.SetBuffid(1);
			victim.SetAmount(((1.0f - skill_t2 * 0.1f) * ((177 * skill_level) + (skill_level * (skill_level * 4.8f)) + 1130.0f)));
			victim.SetValue(0.0f);
			victim.SetHpleak6(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={296};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill302 : GSkill
	{
		public GSkill302()
			: base(302)
		{
			
		}
	}
	public class GSkill303Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetCrit((skill_t3 * 0.01f));
				skill.SetCrithurt((skill_t3 * 0.1f));
				skill.SetRatio((skill_t0 * 0.05f + (skill_level * 0.04f + 1.77f)));
				skill.SetPlus((player_level * (skill_t1 * 1.2f)));
				player.SetPerform(1);
			}
		}
		public GSkill303Stub()
			: base(303)
		{
			occupation = 6;
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
			SetAction(0,"∫œª∂≈…_≤¯√‡");
			SetAction(1,"∫œª∂≈…_≤¯√‡");
			SetAction(2,"∫œª∂≈…_≤¯√‡");
			SetAction(3,"∫œª∂≈…_≤¯√‡");
			SetAction(4,"∫œª∂≈…_≤¯√‡");
			SetAction(5,"∫œª∂≈…_≤¯√‡");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_≤¯√‡");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_≤¯√‡");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_≤¯√‡");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_≤¯√‡");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_≤¯√‡");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_≤¯√‡");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "≤¯√‡";
			nativename = "≤¯√‡";
			icon = "≤¯√‡.dds";
			SetTalent(0,742);
			SetTalent(1,746);
			SetTalent(2,749);
			SetTalent(3,753);
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
			int				skill_t2 = skill.GetT2();

			return 2000 - 400 * skill_t2;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={85,87,89,91,93,95,97,99,101};return array[level-1];
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

			return (skill_level * 3.2f + (skill_level * (skill_level * 0.82f)) + 245.0f);
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={467};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill303 : GSkill
	{
		public GSkill303()
			: base(303)
		{
			
		}
	}
	public class GSkill304Stub : GSkillStub
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
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetCrit((skill_t3 * 0.01f));
				skill.SetCrithurt((skill_t3 * 0.1f));
				skill.SetRatio((skill_t1 * 0.05f + (skill_level * 0.01f + 1.01f)));
				skill.SetPlus(((((79 * skill_level + 133)) - skill_level * (skill_level * 1.4f)) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 2.5f + (skill_level * (skill_level * 0.63f)) + 597.0f) * (D2INT(1.42f - skill_level * 0.05f)))));
				player.SetPerform(1);
			}
		}
		public GSkill304Stub()
			: base(304)
		{
			occupation = 6;
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
			SetAction(0,"∫œª∂≈…_«„≥«");
			SetAction(1,"∫œª∂≈…_«„≥«");
			SetAction(2,"∫œª∂≈…_«„≥«");
			SetAction(3,"∫œª∂≈…_«„≥«");
			SetAction(4,"∫œª∂≈…_«„≥«");
			SetAction(5,"∫œª∂≈…_«„≥«");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_«„≥«");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_«„≥«");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_«„≥«");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_«„≥«");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_«„≥«");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_«„≥«");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "«„≥«";
			nativename = "«„≥«";
			icon = "«„≥«.dds";
			SetTalent(0,743);
			SetTalent(1,742);
			SetTalent(2,749);
			SetTalent(3,753);
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
			int				skill_t2 = skill.GetT2();

			return 2000 - 400 * skill_t2;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={76,77,79,81,83,85,87,89,91};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 3.000000f;
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
			return 13.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((12 * skill_level) + (skill_level * (skill_level * 0.55f)) + 254.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 10;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetTime(((3000 * skill_level + 3100)));
			victim.SetBuffid(1);
			victim.SetValue((skill_level * 4.1f + 39.0f));
			victim.SetSubantisilent(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * ((8 * skill_t0 + 40))));
			victim.SetRatio(((D2INT(zrand(100) / (100 - 4 * skill_t0)) + 1) * 0.24f));
			victim.SetXiaoxin(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={306};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill304 : GSkill
	{
		public GSkill304()
			: base(304)
		{
			
		}
	}
	public class GSkill305Stub : GSkillStub
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
		public GSkill305Stub()
			: base(305)
		{
			occupation = 4;
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
			SetAction(0,"∫œª∂≈…_»»«È");
			SetAction(1,"∫œª∂≈…_»»«È");
			SetAction(2,"∫œª∂≈…_»»«È");
			SetAction(3,"∫œª∂≈…_»»«È");
			SetAction(4,"∫œª∂≈…_»»«È");
			SetAction(5,"∫œª∂≈…_»»«È");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_»»«È");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_»»«È");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_»»«È");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_»»«È");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_»»«È");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_»»«È");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "»»—™";
			nativename = "»»—™";
			icon = "»»—™.dds";
			SetTalent(0,740);
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 4000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={35,39,43,47,49,51,53,56};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 4.5f);
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

			return ((8 * skill_level) + (skill_level * (skill_level * 0.59f)) + 60.0f);
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
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetTime(((900000 * skill_t0 + 1800000)));
			victim.SetBuffid(4);
			victim.SetValue(((skill_t0 * 0.35f + 1.0f) * (player_maxmp * (skill_level * 0.05f) + (player_level * (skill_level * 0.2f)))));
			victim.SetAddhp(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={291};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill305 : GSkill
	{
		public GSkill305()
			: base(305)
		{
			
		}
	}
	public class GSkill306Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetCrit((skill_t0 * 0.02f + 0.05f));
				skill.SetPlus(((skill_t2 * 0.12f + 1.0f) * (((20 * skill_level) + (skill_level * (skill_level * 0.6f)) + 192.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 6.4f + (skill_level * (skill_level * 0.26f)) + 297.0f) * (D2INT(1.42f - skill_level * 0.05f))))));
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetCrit((skill_t0 * 0.02f + 0.05f));
				skill.SetPlus(((skill_t2 * 0.12f + 1.0f) * (((20 * skill_level) + (skill_level * (skill_level * 0.6f)) + 192.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 6.4f + (skill_level * (skill_level * 0.26f)) + 297.0f) * (D2INT(1.42f - skill_level * 0.05f))))));
				player.SetPerform(0);
			}
		}
		public GSkill306Stub()
			: base(306)
		{
			occupation = 6;
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
			SetAction(0,"∫œª∂≈…_µ˚ŒË");
			SetAction(1,"∫œª∂≈…_µ˚ŒË");
			SetAction(2,"∫œª∂≈…_µ˚ŒË");
			SetAction(3,"∫œª∂≈…_µ˚ŒË");
			SetAction(4,"∫œª∂≈…_µ˚ŒË");
			SetAction(5,"∫œª∂≈…_µ˚ŒË");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_µ˚ŒË");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_µ˚ŒË");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_µ˚ŒË");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_µ˚ŒË");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_µ˚ŒË");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_µ˚ŒË");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "µ˚ŒË";
			nativename = "µ˚ŒË";
			icon = "µ˚ŒË.dds";
			SetTalent(0,729);
			SetTalent(1,732);
			SetTalent(2,747);
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={75,77,78,80,83,85,87,89,91};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 1.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((14 * skill_level) + (skill_level * (skill_level * 0.82f)) + 302.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((1.0f - player_level * 0.002f) * ((20 * skill_t0))));
			victim.SetTime(((4000 * norm(skill_t0))));
			victim.SetBuffid(1);
			victim.SetAmount((skill_t0 * ((14 * skill_level) + (skill_level * (skill_level * 0.82f)) + 302.0f)));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((120 * skill_t2)));
			victim.SetTime(4000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue((skill_t2 * ((skill_t2 * 0.12f + 1.0f) * (((20 * skill_level) + (skill_level * (skill_level * 0.6f)) + 192.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 6.4f + (skill_level * (skill_level * 0.26f)) + 297.0f) * (D2INT(1.42f - skill_level * 0.05f)))) * 0.07000000000000001f)));
			victim.SetHpgen(true);
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill306 : GSkill
	{
		public GSkill306()
			: base(306)
		{
			
		}
	}
	public class GSkill307Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();

				player.SetVar1((int)((1000 * player_hp) / player_maxhp));
				player.SetPerform(1);
			}
		}
		public GSkill307Stub()
			: base(307)
		{
			occupation = 5;
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
			SetAction(0,"∫œª∂≈…_∆Ì∏£");
			SetAction(1,"∫œª∂≈…_∆Ì∏£");
			SetAction(2,"∫œª∂≈…_∆Ì∏£");
			SetAction(3,"∫œª∂≈…_∆Ì∏£");
			SetAction(4,"∫œª∂≈…_∆Ì∏£");
			SetAction(5,"∫œª∂≈…_∆Ì∏£");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "∆Ì∏£";
			nativename = "∆Ì∏£";
			icon = "∆Ì∏£.dds";
			SetTalent(0,759);
			SetTalent(1,763);
			SetTalent(2,764);
			SetTalent(3,740);
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
			int				skill_t1 = skill.GetT1();

			return 180000 - 14400 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={70,73,76,79,82,85,87,89};return array[level-1];
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

			return ((21 * skill_level) + (skill_level * (skill_level * 0.097f)) + 70.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			victim.SetTime(((skill_t2 * 0.1f + 1.0f) * ((2000 * skill_level + 14000)) + 100.0f));
			victim.SetRatio(((D2INT(zrand(100) / (100 - 6 * skill_t0)) + 1) * (skill_level * (skill_t0 * 0.06f) + (skill_level * (skill_level * 0.01f) + (skill_level * 0.15f + 0.15f)))));
			victim.SetBuffid(1);
			victim.SetInchp2(true);
			victim.SetTime((((norm(player.GetSkilllevel(305)) * (900000 * skill_t3 + 1800000)) * norm(player.GetSkilllevel(740) / 1.5f))));
			victim.SetBuffid(4);
			victim.SetValue(((skill_t3 * 0.35f + 1.0f) * (player_maxmp * (player.GetSkilllevel(305) * 0.05f) + (player_level * (player.GetSkilllevel(305) * 0.2f)))));
			victim.SetAddhp(true);
			victim.SetProbability(player_var1 <= 950?0.0f:(120 * norm(skill_t0 / 1.5f)));
			victim.SetRatio(0.0f);
			victim.SetValue(player_maxhp);
			victim.SetHeal(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={294};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill307 : GSkill
	{
		public GSkill307()
			: base(307)
		{
			
		}
	}
	public class GSkill308Stub : GSkillStub
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
				skill.SetCrithurt((skill_t3 * 0.1f));
				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetPlus(((skill_level * 4.6f + (skill_level * (skill_level * 0.38f)) + 54.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((D2INT(1.42f - skill_level * 0.05f)) * (6 * skill_level + 54)))));
				player.SetPerform(1);
			}
		}
		public GSkill308Stub()
			: base(308)
		{
			occupation = 4;
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
			SetAction(0,"∫œª∂≈…_∆∆‘∆");
			SetAction(1,"∫œª∂≈…_∆∆‘∆");
			SetAction(2,"∫œª∂≈…_∆∆‘∆");
			SetAction(3,"∫œª∂≈…_∆∆‘∆");
			SetAction(4,"∫œª∂≈…_∆∆‘∆");
			SetAction(5,"∫œª∂≈…_∆∆‘∆");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_∆∆‘∆");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_∆∆‘∆");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_∆∆‘∆");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_∆∆‘∆");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_∆∆‘∆");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_∆∆‘∆");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "∆∆‘∆";
			nativename = "∆∆‘∆";
			icon = "∆∆‘∆.dds";
			SetTalent(0,739);
			SetTalent(1,742);
			SetTalent(2,749);
			SetTalent(3,753);
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
			int				skill_t2 = skill.GetT2();

			return 4000 - 800 * skill_t2;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={40,42,44,46,48,50,52,54,56};return array[level-1];
		}
		public override float GetAttackdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 5.5f);
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

			return (skill_level * 0.013f + (skill_level * (skill_level * 0.18f)) + 30.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 8;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(8000.0f);
			victim.SetBuffid(2);
			victim.SetAmount((D2INT(zrand(100) / (100 - 6 * skill_t0)) * ((skill_t0 * 0.3f + 1.0f) * ((24 * skill_level + 120))) + ((skill_t0 * 0.3f + 1.0f) * ((48 * skill_level + 240)))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(8000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((skill_t0 * 0.3f + 1.0f) * ((96 * skill_level + 480))));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={300};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill308 : GSkill
	{
		public GSkill308()
			: base(308)
		{
			
		}
	}
	public class GSkill309Stub : GSkillStub
	{
		public GSkill309Stub()
			: base(309)
		{
			occupation = 6;
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
			name = "æ¯¡µ";
			nativename = "æ¯¡µ";
			icon = "æ¯¡µ.dds";
			SetTalent(0,728);
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={95,99,103,107,111,113,115,118};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			player.SetPasaddsmite((skill_level * 0.055f + (skill_level * (skill_level * 0.01f))));
			player.SetPasinccrit((skill_level * (skill_t0 * 0.002f) + 0.0001f));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={292};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill309 : GSkill
	{
		public GSkill309()
			: base(309)
		{
			
		}
	}
}
