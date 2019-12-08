using System;
using System.Text;

namespace SKILL
{
	public class GSkill290Stub : GSkillStub
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

				skill.SetPlus((skill_level * (skill_level * 0.5f) + ((3 * skill_level + 28))));
				player.SetPerform(1);
			}
		}
		public GSkill290Stub()
			: base(290)
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
			SetAction(0,"∫œª∂≈…_«ÈÕ¯");
			SetAction(1,"∫œª∂≈…_«ÈÕ¯");
			SetAction(2,"∫œª∂≈…_«ÈÕ¯");
			SetAction(3,"∫œª∂≈…_«ÈÕ¯");
			SetAction(4,"∫œª∂≈…_«ÈÕ¯");
			SetAction(5,"∫œª∂≈…_«ÈÕ¯");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_«ÈÕ¯");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_«ÈÕ¯");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_«ÈÕ¯");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_«ÈÕ¯");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_«ÈÕ¯");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_«ÈÕ¯");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "«ÈÕ¯";
			nativename = "«ÈÕ¯";
			icon = "«ÈÕ¯.dds";
			SetTalent(0,722);
			SetTalent(1,736);
			SetTalent(2,744);
			SetTalent(3,748);
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
			return 5000;
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
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 7.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 1.7f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 12.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(((15 * skill_t1) + ((4 * skill_level * skill_t0) + (skill_level * 3.7f + 37.0f))));
			victim.SetTime(((D2INT(zrand(100) / (100 - 8 * skill_t1)) + 1) * ((skill_t1 * 0.2f + 1.0f) * ((2000 * skill_t0 + (700 * skill_level) + 1300))) + 100.0f));
			victim.SetWrap(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((skill_t2 * 0.3f + 1.0f) * 6000.0f + 100.0f));
			victim.SetRatio(((D2INT(zrand(100) / (100 - 4 * skill_t2)) + 1) * (skill_t3 * 0.03f + 0.08f)));
			victim.SetInchurt2(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={289};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill290 : GSkill
	{
		public GSkill290()
			: base(290)
		{
			
		}
	}
	public class GSkill291Stub : GSkillStub
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
		public GSkill291Stub()
			: base(291)
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
			SetAction(0,"∫œª∂≈…_—Ã”Í");
			SetAction(1,"∫œª∂≈…_—Ã”Í");
			SetAction(2,"∫œª∂≈…_—Ã”Í");
			SetAction(3,"∫œª∂≈…_—Ã”Í");
			SetAction(4,"∫œª∂≈…_—Ã”Í");
			SetAction(5,"∫œª∂≈…_—Ã”Í");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_—Ã”Í");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_—Ã”Í");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_—Ã”Í");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_—Ã”Í");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_—Ã”Í");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_—Ã”Í");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "—Ã”Í";
			nativename = "—Ã”Í";
			icon = "—Ã”Í.dds";
			SetTalent(0,757);
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
			int[] array={25,29,33,37,41,45,50,55};return array[level-1];
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

			return (skill_level * 1.5f + (skill_level * (skill_level * 0.5600000000000001f)) + 41.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(100.0f);
			victim.SetTime(((skill_t2 * 0.1f + 1.0f) * ((2000 * skill_level + 14000)) + 100.0f));
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetValue(((D2INT(zrand(100) / (100 - 6 * skill_t0)) + 1) * ((skill_t0 * 0.2f + 1.0f) * ((2 * ((skill_level * skill_level) * skill_level + (25 * skill_level)) + 25)))));
			victim.SetYanyu(true);
			victim.SetProbability(((10 * skill_level)));
			victim.SetAmount(1.0f);
			victim.SetCleardebuff(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={297};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill291 : GSkill
	{
		public GSkill291()
			: base(291)
		{
			
		}
	}
	public class GSkill292Stub : GSkillStub
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
		public GSkill292Stub()
			: base(292)
		{
			occupation = 6;
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
			SetAction(0,"∫œª∂≈…_æˆæ¯");
			SetAction(1,"∫œª∂≈…_æˆæ¯");
			SetAction(2,"∫œª∂≈…_æˆæ¯");
			SetAction(3,"∫œª∂≈…_æˆæ¯");
			SetAction(4,"∫œª∂≈…_æˆæ¯");
			SetAction(5,"∫œª∂≈…_æˆæ¯");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_æˆæ¯");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_æˆæ¯");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_æˆæ¯");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_æˆæ¯");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_æˆæ¯");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_æˆæ¯");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "æˆæ¯";
			nativename = "æˆæ¯";
			icon = "æˆæ¯.dds";
			SetTalent(0,763);
			SetTalent(1,764);
			SetTalent(2,766);
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
			int				skill_t0 = skill.GetT0();

			return 120000 - 9600 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={85,89,93,97,101,105,109,113};return array[level-1];
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

			return (((39 * skill_level + 65)) - skill_level * (skill_level * 0.79f));
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetTime(((skill_t1 * 0.1f + 1.0f) * ((2000 * skill_level + 14000)) + 100.0f));
			victim.SetRatio((((skill_level * skill_level) * skill_level + 20)));
			victim.SetAmount(((30 * skill_level)));
			victim.SetValue(((D2INT(zrand(100) / (100 - 6 * skill_t2)) + 1) * ((skill_t2 * 0.1f + 1.0f) * ((3 * skill_level * skill_level + (50 * skill_level))))));
			victim.SetCrazy(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((120 * (skill_level / 8))));
			victim.SetTime(((skill_t1 * 0.1f + 1.0f) * ((norm(skill_t1) * (8000 * skill_t1 + 14000))) + 100.0f));
			victim.SetRatio(((skill_level / 8) * (skill_t1 * 0.2f)));
			victim.SetBuffid(6);
			victim.SetInccrithurt(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={304};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill292 : GSkill
	{
		public GSkill292()
			: base(292)
		{
			
		}
	}
	public class GSkill293Stub : GSkillStub
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
		public GSkill293Stub()
			: base(293)
		{
			occupation = 6;
			maxlevel = 14;
			maxlearn = 8;
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
			SetAction(0,"∫œª∂≈…_÷πÀÆ");
			SetAction(1,"∫œª∂≈…_÷πÀÆ");
			SetAction(2,"∫œª∂≈…_÷πÀÆ");
			SetAction(3,"∫œª∂≈…_÷πÀÆ");
			SetAction(4,"∫œª∂≈…_÷πÀÆ");
			SetAction(5,"∫œª∂≈…_÷πÀÆ");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_÷πÀÆ");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_÷πÀÆ");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_÷πÀÆ");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_÷πÀÆ");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_÷πÀÆ");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_÷πÀÆ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "÷πÀÆ";
			nativename = "÷πÀÆ";
			icon = "÷πÀÆ.dds";
			SetTalent(0,751);
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
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			return (100 - 8 * skill_t1) * (140000 - 10000 * skill_level) / 100;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={100,103,106,108,109,110,112,114};return array[level-1];
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

			return (((47 * skill_level + 117)) - skill_level * (skill_level * 1.3f));
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetRatio(289.0f);
			victim.SetAmount(291.0f);
			victim.SetValue(302.0f);
			victim.SetClearcooldown(true);
			victim.SetRatio(((79 * D2INT(skill_level / 5.9f) + 220)));
			victim.SetAmount(((20 * D2INT(skill_level / 6.9f) + 287)));
			victim.SetValue(((74 * D2INT(skill_level / 7.9f) + 218)));
			victim.SetClearcooldown(true);
			victim.SetRatio(((224 * norm(skill_t0 / 0.8f) + 306)));
			victim.SetAmount(((225 * norm(skill_t0 / 1.5f) + 306)));
			victim.SetValue(218.0f);
			victim.SetClearcooldown(true);
			victim.SetTime(((4500 * skill_t2)));
			victim.SetImmunesleep(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={303};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill293 : GSkill
	{
		public GSkill293()
			: base(293)
		{
			
		}
	}
	public class GSkill294Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetCrithurt((skill_t3 * 0.1f));
				int hpp = player_hp / player_maxhp;
				skill.SetCrit((skill_t3 * 0.01f + (skill_level * 0.01f * (1.0f - hpp))));
				skill.SetPlus(((((37 * skill_level) + (skill_level * (skill_level * 0.16f)) + 9.199999999999999f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((((31 * skill_level + 179)) - skill_level * (skill_level * 1.5f)) * (D2INT(1.42f - skill_level * 0.05f)))) * (((skill_t0 * 0.2f + 1.0f) * (skill_level * 0.12f) * (1.0f - hpp) + 1.0f) * (hpp * 1.99f * hpp - hpp * 3.79f + 2.8f)) + (7 * skill_t0 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill294Stub()
			: base(294)
		{
			occupation = 5;
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
			SetAction(0,"∫œª∂≈…_∑…ª®");
			SetAction(1,"∫œª∂≈…_∑…ª®");
			SetAction(2,"∫œª∂≈…_∑…ª®");
			SetAction(3,"∫œª∂≈…_∑…ª®");
			SetAction(4,"∫œª∂≈…_∑…ª®");
			SetAction(5,"∫œª∂≈…_∑…ª®");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_∑…ª®");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_∑…ª®");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_∑…ª®");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_∑…ª®");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_∑…ª®");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_∑…ª®");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "∑…ª®";
			nativename = "∑…ª®";
			icon = "∑…ª®.dds";
			SetTalent(0,726);
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
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			return (100 - 20 * skill_t2) * (4100 - 100 * skill_level) / 100;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={55,56,59,61,63,65,67,69,71};return array[level-1];
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

			return ((skill_level * (skill_level * 0.72f)) - skill_level * 0.55f + 30.0f);
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={394};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill294 : GSkill
	{
		public GSkill294()
			: base(294)
		{
			
		}
	}
	public class GSkill295Stub : GSkillStub
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
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t2 * 0.05f + 1.0f));
				skill.SetCrit((skill_t3 * 0.01f + (skill_level * 0.005f + 0.025f)));
				skill.SetPlus((((17 * skill_level) + (skill_level * (skill_level * 0.19f)) + 5.5f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 4.6f + (skill_level * (skill_level * 0.021f)) + 112.0f) * (D2INT(1.42f - skill_level * 0.05f)))));
				player.SetPerform(1);
			}
		}
		public GSkill295Stub()
			: base(295)
		{
			occupation = 5;
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
			SetAction(0,"∫œª∂≈…_∞µœ„");
			SetAction(1,"∫œª∂≈…_∞µœ„");
			SetAction(2,"∫œª∂≈…_∞µœ„");
			SetAction(3,"∫œª∂≈…_∞µœ„");
			SetAction(4,"∫œª∂≈…_∞µœ„");
			SetAction(5,"∫œª∂≈…_∞µœ„");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_∞µœ„");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_∞µœ„");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_∞µœ„");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_∞µœ„");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_∞µœ„");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_∞µœ„");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "∞µœ„";
			nativename = "∞µœ„";
			icon = "∞µœ„.dds";
			SetTalent(0,723);
			SetTalent(1,724);
			SetTalent(2,732);
			SetTalent(3,756);
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={45,47,49,51,53,55,57,59,61};return array[level-1];
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

			return (skill_level * 0.31f + (skill_level * (skill_level * 0.12f)) + 14.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((1.0f - player_level * 0.002f) * ((15 * skill_t0))));
			victim.SetTime(4000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((skill_t0 * ((((17 * skill_level) + (skill_level * (skill_level * 0.19f)) + 5.5f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 4.6f + (skill_level * (skill_level * 0.021f)) + 112.0f) * (D2INT(1.42f - skill_level * 0.05f)))) * 0.15f)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((8 * skill_t1)));
			victim.SetRatio(0.0f);
			victim.SetValue((player_maxhp * (skill_t1 * 0.02f)));
			victim.SetHeal(true);
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill295 : GSkill
	{
		public GSkill295()
			: base(295)
		{
			
		}
	}
	public class GSkill296Stub : GSkillStub
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
				skill.SetRatio((skill_t1 * 0.05f + 1.07f));
				skill.SetPlus((((48 * skill_level) + (skill_level * (skill_level * 0.012f)) - 59.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((9 * skill_level) + (skill_level * (skill_level * 0.024f)) + 240.0f) * (D2INT(1.42f - skill_level * 0.05f)))));
				player.SetPerform(1);
			}
		}
		public GSkill296Stub()
			: base(296)
		{
			occupation = 5;
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
			SetAction(0,"∫œª∂≈…_√‘¿Î");
			SetAction(1,"∫œª∂≈…_√‘¿Î");
			SetAction(2,"∫œª∂≈…_√‘¿Î");
			SetAction(3,"∫œª∂≈…_√‘¿Î");
			SetAction(4,"∫œª∂≈…_√‘¿Î");
			SetAction(5,"∫œª∂≈…_√‘¿Î");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_√‘¿Î");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_√‘¿Î");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_√‘¿Î");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_√‘¿Î");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_√‘¿Î");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_√‘¿Î");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "√‘¿Î";
			nativename = "√‘¿Î";
			icon = "√‘¿Î.dds";
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

			return 5000 - 1000 * skill_t2;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={46,48,49,52,53,55,57,59,61};return array[level-1];
		}
		public override float GetAngle(GSkill skill)
		{
			return -0.333332f;
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

			return (skill_level * 0.4f + (skill_level * (skill_level * 0.28f)) + 20.0f);
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

			victim.SetTime(((3000 * skill_level + 4100)));
			victim.SetBuffid(1);
			victim.SetValue((skill_level * 2.2f + 31.0f));
			victim.SetSubantiwrap(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * ((8 * skill_t0 + 30))));
			victim.SetRatio(((D2INT((zrand(4 * skill_t0 + 99)) / 100) + 1) * 0.12f));
			victim.SetXiaoxin(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={295};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill296 : GSkill
	{
		public GSkill296()
			: base(296)
		{
			
		}
	}
	public class GSkill297Stub : GSkillStub
	{
		public GSkill297Stub()
			: base(297)
		{
			occupation = 4;
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
			name = "ƒ˝…Ò";
			nativename = "ƒ˝…Ò";
			icon = "ƒ˝…Ò.dds";
			SetTalent(0,737);
			SetTalent(1,728);
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={16,18,19,22,25,29,32,36};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			player.SetPasaddaccuracy(((2 * (skill_level * skill_t0 + (10 * skill_level)))));
			player.SetPasaddslow(((5 * skill_level)));
			player.SetPasaddattack(((skill_level * skill_t0 + (3 * skill_level))));
			player.SetPasinccrit((skill_level * (skill_t1 * 0.002f) + 0.0001f));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={287};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill297 : GSkill
	{
		public GSkill297()
			: base(297)
		{
			
		}
	}
	public class GSkill298Stub : GSkillStub
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

				skill.SetPlus(((((70 * skill_level + 76)) - skill_level * (skill_level * 0.21f)) * (D2INT(skill_level * 0.05f + 0.55f)) + (((12 * skill_level) + (skill_level * (skill_level * 0.056f)) + 476.0f) * (D2INT(1.42f - skill_level * 0.05f)))));
				player.SetPerform(1);
			}
		}
		public GSkill298Stub()
			: base(298)
		{
			occupation = 5;
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
			SetAction(0,"∫œª∂≈…_œ˙ªÍ");
			SetAction(1,"∫œª∂≈…_œ˙ªÍ");
			SetAction(2,"∫œª∂≈…_œ˙ªÍ");
			SetAction(3,"∫œª∂≈…_œ˙ªÍ");
			SetAction(4,"∫œª∂≈…_œ˙ªÍ");
			SetAction(5,"∫œª∂≈…_œ˙ªÍ");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_œ˙ªÍ");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_œ˙ªÍ");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_œ˙ªÍ");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_œ˙ªÍ");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_œ˙ªÍ");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_œ˙ªÍ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "œ˙ªÍ";
			nativename = "œ˙ªÍ";
			icon = "œ˙ªÍ.dds";
			SetTalent(0,727);
			SetTalent(1,736);
			SetTalent(2,744);
			SetTalent(3,748);
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
			return 5000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={60,62,64,66,68,70,72,74,76};return array[level-1];
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

			return (skill_level * 2.8f + (skill_level * (skill_level * 1.1f)) + 121.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(((15 * skill_t1) + ((2 * skill_level * skill_t0) + (skill_level * 5.8f + 63.0f))));
			victim.SetTime(((D2INT(zrand(100) / (100 - 8 * skill_t1)) + 1) * ((skill_t1 * 0.2f + 1.0f) * ((1300 * skill_level + 2000))) + 100.0f));
			victim.SetSilent(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((skill_t2 * 0.3f + 1.0f) * 8000.0f + 100.0f));
			victim.SetRatio(((D2INT(zrand(100) / (100 - 4 * skill_t2)) + 1) * (skill_t3 * 0.03f + 0.1f)));
			victim.SetInchurt2(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={288};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill298 : GSkill
	{
		public GSkill298()
			: base(298)
		{
			
		}
	}
	public class GSkill299Stub : GSkillStub
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
		public GSkill299Stub()
			: base(299)
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
			SetAction(0,"∫œª∂≈…_º§¿¯");
			SetAction(1,"∫œª∂≈…_º§¿¯");
			SetAction(2,"∫œª∂≈…_º§¿¯");
			SetAction(3,"∫œª∂≈…_º§¿¯");
			SetAction(4,"∫œª∂≈…_º§¿¯");
			SetAction(5,"∫œª∂≈…_º§¿¯");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_º§¿¯");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_º§¿¯");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_º§¿¯");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_º§¿¯");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_º§¿¯");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_º§¿¯");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "º§¿¯";
			nativename = "º§¿¯";
			icon = "º§¿¯.dds";
			SetTalent(0,761);
			SetTalent(1,763);
			SetTalent(2,764);
			SetTalent(3,758);
			SetTalent(4,292);
			SetTalent(5,766);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 6;
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
			int[] array={65,69,73,77,81,85,89,93,98};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return (skill_level + 9);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((19 * skill_level) + (skill_level * (skill_level * 0.5600000000000001f)) + 100.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(120.0f);
			victim.SetClearwrap(true);
			victim.SetTime(((skill_t2 * 0.1f + 1.0f) * ((2000 * skill_level + 8000)) + 100.0f));
			victim.SetImmunewrap(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((skill_t2 * 0.1f + 1.0f) * 15000.0f + 100.0f));
			victim.SetRatio((skill_t0 * (skill_level * 0.03f) + (skill_level * 0.11f + 0.19f)));
			victim.SetNingjin(true);
			victim.SetProbability(120.0f);
			victim.SetTime((norm(skill_t2) * ((skill_t2 * 0.1f + 1.0f) * 15000.0f + 100.0f)));
			victim.SetRatio((skill_t2 * 0.05001f));
			victim.SetBuffid(2);
			victim.SetIncskillaccu(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();
			int				skill_t5 = skill.GetT5();
			int				skill_t6 = skill.GetT6();

			victim.SetProbability(120.0f);
			victim.SetRatio(((5216 * norm(skill_t2) * ((skill_t5 / 7.9f)))));
			victim.SetAmount(((4100 * norm(skill_t5 / 7.9f))));
			victim.SetValue(0.0f);
			victim.SetDispel(true);
			victim.SetTime((norm(skill_t5 / 7.9f) * ((skill_t2 * 0.1f + 1.0f) * ((2000 * skill_level + 14000)) + 100.0f)));
			victim.SetRatio((((skill_level * skill_level) * skill_level + 20)));
			victim.SetAmount(((30 * skill_level)));
			victim.SetValue(((D2INT(zrand(100) / (100 - 6 * skill_t6)) + 1) * ((skill_t6 * 0.1f + 1.0f) * ((3 * skill_level * skill_level + (50 * skill_level))))));
			victim.SetCrazy(true);
			victim.SetProbability(((120 * (skill_t5 / 7.9f))));
			victim.SetTime(((skill_t2 * 0.1f + 1.0f) * ((norm(skill_t2) * (8000 * skill_t2 + 14000))) + 100.0f));
			victim.SetRatio(((skill_level / 8) * (skill_t2 * 0.2f)));
			victim.SetBuffid(6);
			victim.SetInccrithurt(true);
			victim.SetProbability(((120 * norm(skill_t4 / 7.9f))));
			victim.SetTime(((skill_t2 * 0.1f + 1.0f) * ((2000 * skill_level + 14000)) + 100.0f));
			victim.SetRatio(((D2INT(zrand(100) / (100 - 6 * skill_t3)) + 1) * (skill_t3 * 0.01f + (skill_level * 0.01f + 0.04f))));
			victim.SetBuffid(1);
			victim.SetIncattack3(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={302};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill299 : GSkill
	{
		public GSkill299()
			: base(299)
		{
			
		}
	}
}
