using System;
using System.Text;

namespace SKILL
{
	public class GSkill530Stub : GSkillStub
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
		public GSkill530Stub()
			: base(530)
		{
			occupation = 16;
			maxlevel = 4;
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
			SetAction(0,"∫œª∂≈…_ª√’Ê");
			SetAction(1,"∫œª∂≈…_ª√’Ê");
			SetAction(2,"∫œª∂≈…_ª√’Ê");
			SetAction(3,"∫œª∂≈…_ª√’Ê");
			SetAction(4,"∫œª∂≈…_ª√’Ê");
			SetAction(5,"∫œª∂≈…_ª√’Ê");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_ª√’Ê");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_ª√’Ê");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_ª√’Ê");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_ª√’Ê");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_ª√’Ê");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_ª√’Ê");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ª√’Ê";
			nativename = "ª√’Ê";
			icon = "ª√’Ê.dds";
			SetTalent(0,763);
			SetTalent(1,764);
			SetTalent(2,769);
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

			return 150000 - 12000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={106,114,122};return array[level-1];
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

			return (10 * skill_level + 250);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(100.0f);
			victim.SetTime(((skill_t1 * 0.1f + 1.0f) * ((5000 * skill_level + 10000)) + 100.0f));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t2 * 0.15f + 1.0f) * ((15 * skill_level))));
			victim.SetAdddodge(true);
			victim.SetProbability(33.0f);
			victim.SetTime(((skill_t1 * 0.1f + 1.0f) * ((5000 * skill_level + 10000)) + 100.0f));
			victim.SetRatio(((skill_t2 * 0.2f + 1.0f) * (skill_level * 0.01f)));
			victim.SetAttack2mp(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={528};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill530 : GSkill
	{
		public GSkill530()
			: base(530)
		{
			
		}
	}
	public class GSkill531Stub : GSkillStub
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
		public GSkill531Stub()
			: base(531)
		{
			occupation = 16;
			maxlevel = 20;
			maxlearn = 8;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"∫œª∂≈…_«Ô≤®");
			SetAction(1,"∫œª∂≈…_«Ô≤®");
			SetAction(2,"∫œª∂≈…_«Ô≤®");
			SetAction(3,"∫œª∂≈…_«Ô≤®");
			SetAction(4,"∫œª∂≈…_«Ô≤®");
			SetAction(5,"∫œª∂≈…_«Ô≤®");
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
			SetAction(16,"0");
			SetAction(17,"0");
			SetAction(18,"∫œª∂≈…_∆Ô≥À_«Ô≤®");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_«Ô≤®");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_«Ô≤®");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_«Ô≤®");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_«Ô≤®");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_«Ô≤®");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "«Ô≤®";
			nativename = "«Ô≤®";
			icon = "«Ô≤®.dds";
			SetTalent(0,734);
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
			int				skill_t2 = skill.GetT2();

			return 180000 - 14400 * skill_t2;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={110,112,114,116,118,120,122,124};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 24.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (20 * skill_level + 200);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(((15 * skill_t1) + ((skill_level * 11.7f) - skill_level * (skill_level * 0.2f) + 94.59999999999999f)));
			victim.SetTime(((D2INT(zrand(100) / (100 - 8 * skill_t1)) + 1) * ((skill_t3 * 0.1f + 1.0f) * ((skill_t1 * 0.2f + 1.0f) * ((1000 * skill_level + 4000)))) + 100.0f));
			victim.SetSilent(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((skill_t3 * 0.1f + 1.0f) * ((2000 * (skill_t0 + skill_level) + 4000)) + 100.0f));
			victim.SetRatio((skill_t0 * 0.1f + (skill_level * 0.03f + 0.22f)));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={528};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill531 : GSkill
	{
		public GSkill531()
			: base(531)
		{
			
		}
	}
	public class GSkill532Stub : GSkillStub
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
		public GSkill532Stub()
			: base(532)
		{
			occupation = 16;
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
			SetAction(0,"∫œª∂≈…_œ–”Í");
			SetAction(1,"∫œª∂≈…_œ–”Í");
			SetAction(2,"∫œª∂≈…_œ–”Í");
			SetAction(3,"∫œª∂≈…_œ–”Í");
			SetAction(4,"∫œª∂≈…_œ–”Í");
			SetAction(5,"∫œª∂≈…_œ–”Í");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_œ–”Í");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_œ–”Í");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_œ–”Í");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_œ–”Í");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_œ–”Í");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_œ–”Í");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "‘∆”Í";
			nativename = "‘∆”Í";
			icon = "‘∆”Í.dds";
			SetTalent(0,744);
			SetTalent(1,748);
			SetTalent(2,752);
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
			return 5000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={115,117,119,121,123,125,125,125,125};return array[level-1];
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

			return (((skill_level * skill_level)) - skill_level * 3.3f + 337.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((1.0f - player_level * 0.002f) * ((10 * skill_t2 + 33))));
			victim.SetTime(4000.0f);
			victim.SetBuffid(4);
			victim.SetAmount(((skill_t2 * 0.4f + 1.0f) * (3.0f / ((player_mp + player_mp) / (player_maxmp + 1) + 1.0f) * ((80 * skill_level + 320)))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((skill_t0 * 0.3f + 1.0f) * 12000.0f + 100.0f));
			victim.SetRatio(((D2INT(zrand(100) / (100 - 4 * skill_t0)) + 1) * (skill_t1 * 0.03f + 0.14f)));
			victim.SetInchurt2(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={530};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill532 : GSkill
	{
		public GSkill532()
			: base(532)
		{
			
		}
	}
	public class GSkill533Stub : GSkillStub
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();

				skill.SetCrit(0.0099999998f);
				skill.SetRatio((skill_t2 * 0.03f + 1.12f));
				skill.SetPlus(((skill_level * (skill_t0 * 0.02f) + 1.0f) * ((((94 * skill_level - 68)) - skill_level * (skill_level * 2.4f)) * (D2INT(skill_level * 0.05f + 0.55f)) + (((11 * skill_level) + (skill_level * (skill_level * 0.067f)) + 434.0f) * (D2INT(1.42f - skill_level * 0.05f))))));
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();

				skill.SetCrit(0.02f);
				skill.SetRatio((skill_t2 * 0.03f + 1.12f));
				skill.SetPlus(((skill_level * (skill_t0 * 0.02f) + 1.0f) * ((((94 * skill_level - 68)) - skill_level * (skill_level * 2.4f)) * (D2INT(skill_level * 0.05f + 0.55f)) + (((11 * skill_level) + (skill_level * (skill_level * 0.067f)) + 434.0f) * (D2INT(1.42f - skill_level * 0.05f))))));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();

				skill.SetCrit(0.029999999f);
				skill.SetRatio((skill_t2 * 0.03f + 1.12f));
				skill.SetPlus(((skill_level * (skill_t0 * 0.02f) + 1.0f) * ((((94 * skill_level - 68)) - skill_level * (skill_level * 2.4f)) * (D2INT(skill_level * 0.05f + 0.55f)) + (((11 * skill_level) + (skill_level * (skill_level * 0.067f)) + 434.0f) * (D2INT(1.42f - skill_level * 0.05f))))));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState5 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();

				skill.SetCrit(0.039999999f);
				skill.SetRatio((skill_t2 * 0.03f + 1.12f));
				skill.SetPlus(((skill_level * (skill_t0 * 0.02f) + 1.0f) * ((((94 * skill_level - 68)) - skill_level * (skill_level * 2.4f)) * (D2INT(skill_level * 0.05f + 0.55f)) + (((11 * skill_level) + (skill_level * (skill_level * 0.067f)) + 434.0f) * (D2INT(1.42f - skill_level * 0.05f))))));
				player.SetPerform(0);
			}
		}
		public GSkill533Stub()
			: base(533)
		{
			occupation = 16;
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
			SetAction(0,"∫œª∂≈…_Ω≠ƒœ");
			SetAction(1,"∫œª∂≈…_Ω≠ƒœ");
			SetAction(2,"∫œª∂≈…_Ω≠ƒœ");
			SetAction(3,"∫œª∂≈…_Ω≠ƒœ");
			SetAction(4,"∫œª∂≈…_Ω≠ƒœ");
			SetAction(5,"∫œª∂≈…_Ω≠ƒœ");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_Ω≠ƒœ");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_Ω≠ƒœ");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_Ω≠ƒœ");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_Ω≠ƒœ");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_Ω≠ƒœ");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_Ω≠ƒœ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ω≠ƒœ";
			nativename = "Ω≠ƒœ";
			icon = "Ω≠ƒœ.dds";
			SetTalent(0,735);
			SetTalent(1,750);
			SetTalent(2,761);
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
			AddState(new GState4());
			AddState(new GState5());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 4000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 8000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,125,125,125,125,125,125};return array[level-1];
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
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 2.2f + (skill_level * (skill_level * 2.4f)) + 840.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((15 * skill_t1)));
			victim.SetTime(8100.0f);
			victim.SetRatio((skill_t1 * 0.2f));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(8100.0f);
			victim.SetBuffid(1);
			victim.SetValue(((35 * skill_t1)));
			victim.SetSubattack(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((15 * skill_t0 + 25)));
			victim.SetBuffid(2);
			victim.SetAmount(99.0f);
			victim.SetValue(99.0f);
			victim.SetExorcism(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={531};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill533 : GSkill
	{
		public GSkill533()
			: base(533)
		{
			
		}
	}
	public class GSkill534Stub : GSkillStub
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
		public GSkill534Stub()
			: base(534)
		{
			occupation = 16;
			maxlevel = 20;
			maxlearn = 6;
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
			SetAction(0,"∫œª∂≈…_∑Á‘¬");
			SetAction(1,"∫œª∂≈…_∑Á‘¬");
			SetAction(2,"∫œª∂≈…_∑Á‘¬");
			SetAction(3,"∫œª∂≈…_∑Á‘¬");
			SetAction(4,"∫œª∂≈…_∑Á‘¬");
			SetAction(5,"∫œª∂≈…_∑Á‘¬");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_∑Á‘¬");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_∑Á‘¬");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_∑Á‘¬");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_∑Á‘¬");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_∑Á‘¬");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_∑Á‘¬");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Õ¸«È";
			nativename = "Õ¸«È";
			icon = "Õ¸«È.dds";
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
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 12000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 155.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(8100.0f);
			victim.SetRatio((skill_level * 0.04f));
			victim.SetBuffid(1);
			victim.SetDecanti(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(3600000.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(18.0f);
			victim.SetValue(0.0f);
			victim.SetEvilaura(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.400000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={536};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill534 : GSkill
	{
		public GSkill534()
			: base(534)
		{
			
		}
	}
	public class GSkill535Stub : GSkillStub
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
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetCrit((skill_t3 * 0.01f));
				skill.SetCrithurt((skill_t3 * 0.1f));
				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetPlus((((D2INT(skill_level * 0.05f + 0.55f)) * (21 * skill_level + 210) + ((17 * skill_level + 199) * (D2INT(1.42f - skill_level * 0.05f))))));
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
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetCrit((skill_t3 * 0.01f));
				skill.SetCrithurt((skill_t3 * 0.1f));
				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetPlus((((D2INT(skill_level * 0.05f + 0.55f)) * (21 * skill_level + 210) + ((17 * skill_level + 199) * (D2INT(1.42f - skill_level * 0.05f))))));
				player.SetPerform(0);
			}
		}
		public GSkill535Stub()
			: base(535)
		{
			occupation = 16;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 4;
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
			SetAction(0,"∫œª∂≈…_–«‘∏");
			SetAction(1,"∫œª∂≈…_–«‘∏");
			SetAction(2,"∫œª∂≈…_–«‘∏");
			SetAction(3,"∫œª∂≈…_–«‘∏");
			SetAction(4,"∫œª∂≈…_–«‘∏");
			SetAction(5,"∫œª∂≈…_–«‘∏");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_–«‘∏");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_–«‘∏");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_–«‘∏");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_–«‘∏");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_–«‘∏");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_–«‘∏");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "–«‘∏";
			nativename = "–«‘∏";
			icon = "–«‘∏.dds";
			SetTalent(0,733);
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();

			return 7000 - 1400 * skill_t2;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,125,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.1f + 5.0f);
		}
		public override float GetAngle(GSkill skill)
		{
			return -0.333332f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.1f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 1.700000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 18.2f + (skill_level * (skill_level * 1.88f)) + 604.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return D2INT(skill_level / 2) + 2;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((600 * D2INT(zrand(100) / (100 - 2 * skill_t0)))));
			victim.SetTime(((3020 * skill_t0)));
			victim.SetDizzy(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={532};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill535 : GSkill
	{
		public GSkill535()
			: base(535)
		{
			
		}
	}
	public class GSkill536Stub : GSkillStub
	{
		public GSkill536Stub()
			: base(536)
		{
			occupation = 16;
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
			name = "Õ¸”«";
			nativename = "Õ¸”«";
			icon = "Õ¸”«.dds";
			SetTalent(0,728);
			SetTalent(1,767);
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
			int[] array={115,118,121,124,125,125,125,125};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			player.SetPasinccrit((skill_t1 * 0.01f + (skill_level * (skill_t0 * 0.002f + 0.005f)) + 0.0001f));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={529};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill536 : GSkill
	{
		public GSkill536()
			: base(536)
		{
			
		}
	}
	public class GSkill537Stub : GSkillStub
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
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * 0.05f + 1.0f));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((((skill_level * (skill_level * 2.6f)) - skill_level * 2.9f + 854.0f) * (D2INT(skill_level * 0.05f + 0.55f) * 0.9f) + (((14 * skill_level) + (skill_level * (skill_level * 0.07199999999999999f)) + 791.0f) * (D2INT(1.42f - skill_level * 0.05f) * 0.9f))) * (skill_t0 * 0.1f + 1.0f))));
				player.SetPerform(1);
			}
		}
		public GSkill537Stub()
			: base(537)
		{
			occupation = 19;
			maxlevel = 18;
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
			SetAction(0,"«‡‘∆√≈_À™ÃÏ—©ŒË");
			SetAction(1,"«‡‘∆√≈_À™ÃÏ—©ŒË");
			SetAction(2,"«‡‘∆√≈_À™ÃÏ—©ŒË");
			SetAction(3,"«‡‘∆√≈_À™ÃÏ—©ŒË");
			SetAction(4,"«‡‘∆√≈_À™ÃÏ—©ŒË");
			SetAction(5,"«‡‘∆√≈_À™ÃÏ—©ŒË");
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
			SetAction(18,"«‡‘∆√≈_∆Ô≥À_À™ÃÏ—©ŒË");
			SetAction(19,"«‡‘∆√≈_∆Ô≥À_À™ÃÏ—©ŒË");
			SetAction(20,"«‡‘∆√≈_∆Ô≥À_À™ÃÏ—©ŒË");
			SetAction(21,"«‡‘∆√≈_∆Ô≥À_À™ÃÏ—©ŒË");
			SetAction(22,"«‡‘∆√≈_∆Ô≥À_À™ÃÏ—©ŒË");
			SetAction(23,"«‡‘∆√≈_∆Ô≥À_À™ÃÏ—©ŒË");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "À™ÃÏ—©ŒË";
			nativename = "À™ÃÏ—©ŒË";
			icon = "À™ÃÏ—©ŒË.dds";
			SetTalent(0,602);
			SetTalent(1,606);
			SetTalent(2,610);
			SetTalent(3,617);
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
			int[] array={105,107,109,111,113,115,117,119,122};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 21.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((skill_level * (skill_level * 1.1f)) - skill_level * 3.1f + 330.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 36;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((3 * skill_level + 42)));
			victim.SetTime(((10000 * skill_t1 + 4100)));
			victim.SetRatio(0.25f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_level * (skill_level * 0.2f)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((5 * skill_t2)));
			victim.SetTime(((3050 * skill_t2)));
			victim.SetRatio((skill_t2 * 0.05f));
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill537 : GSkill
	{
		public GSkill537()
			: base(537)
		{
			
		}
	}
	public class GSkill538Stub : GSkillStub
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
		public GSkill538Stub()
			: base(538)
		{
			occupation = 19;
			maxlevel = 4;
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
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"«‡‘∆√≈_Œﬁº´");
			SetAction(1,"«‡‘∆√≈_Œﬁº´");
			SetAction(2,"«‡‘∆√≈_Œﬁº´");
			SetAction(3,"«‡‘∆√≈_Œﬁº´");
			SetAction(4,"«‡‘∆√≈_Œﬁº´");
			SetAction(5,"«‡‘∆√≈_Œﬁº´");
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
			SetAction(18,"«‡‘∆√≈_∆Ô≥À_Œﬁº´");
			SetAction(19,"«‡‘∆√≈_∆Ô≥À_Œﬁº´");
			SetAction(20,"«‡‘∆√≈_∆Ô≥À_Œﬁº´");
			SetAction(21,"«‡‘∆√≈_∆Ô≥À_Œﬁº´");
			SetAction(22,"«‡‘∆√≈_∆Ô≥À_Œﬁº´");
			SetAction(23,"«‡‘∆√≈_∆Ô≥À_Œﬁº´");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¥Ûµ¿Œﬁ–Œ";
			nativename = "¥Ûµ¿Œﬁ–Œ";
			icon = "¥Ûµ¿Œﬁ–Œ.dds";
			SetTalent(0,578);
			SetTalent(1,582);
			SetTalent(2,597);
			SetTalent(3,1591);
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
			int				skill_t3 = skill.GetT3();

			return (-12000 * skill_t1) - 5000 * skill_t3 + 120000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={106,114,122};return array[level-1];
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

			return (10 * skill_level + 220);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((15 * skill_t0 + 50)));
			victim.SetTime(((6000 * skill_t2 + 16100)));
			victim.SetRatio((skill_t2 * 0.15f + (skill_level * 0.15f + 0.15f)));
			victim.SetDecdamage(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={537};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill538 : GSkill
	{
		public GSkill538()
			: base(538)
		{
			
		}
	}
	public class GSkill539Stub : GSkillStub
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
		public GSkill539Stub()
			: base(539)
		{
			occupation = 19;
			maxlevel = 18;
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
			SetAction(0,"«‡‘∆√≈_ÃÏ–˛±˘");
			SetAction(1,"«‡‘∆√≈_ÃÏ–˛±˘");
			SetAction(2,"«‡‘∆√≈_ÃÏ–˛±˘");
			SetAction(3,"«‡‘∆√≈_ÃÏ–˛±˘");
			SetAction(4,"«‡‘∆√≈_ÃÏ–˛±˘");
			SetAction(5,"«‡‘∆√≈_ÃÏ–˛±˘");
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
			SetAction(18,"«‡‘∆√≈_∆Ô≥À_ÃÏ–˛±˘");
			SetAction(19,"«‡‘∆√≈_∆Ô≥À_ÃÏ–˛±˘");
			SetAction(20,"«‡‘∆√≈_∆Ô≥À_ÃÏ–˛±˘");
			SetAction(21,"«‡‘∆√≈_∆Ô≥À_ÃÏ–˛±˘");
			SetAction(22,"«‡‘∆√≈_∆Ô≥À_ÃÏ–˛±˘");
			SetAction(23,"«‡‘∆√≈_∆Ô≥À_ÃÏ–˛±˘");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÃÏ–˛±˘";
			nativename = "ÃÏ–˛±˘";
			icon = "ÃÏ–˛±˘.dds";
			SetTalent(0,571);
			SetTalent(1,616);
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
			int				skill_level = skill.GetLevel();

			return 155000 - 5000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={106,109,113,117,121,125};return array[level-1];
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

			return (10 * skill_level + 560);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(120.0f);
			victim.SetTime(((skill_t0 * 0.15f + 1.0f) * 12000.0f + 200.0f));
			victim.SetAmount(((skill_t0 * 0.15f + 1.0f) * (player_maxhp * (skill_t1 * (skill_level * 0.03f) + (skill_level * 0.09f)))));
			victim.SetValue(((skill_t1 * 0.35f + 1.0f) * ((8 * (skill_level * skill_level) * skill_level + (350 * skill_level)))));
			victim.SetIceshield(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((skill_t0 * 0.15f + 1.0f) * ((2000 * skill_level)) + 200.0f));
			victim.SetBuffid(9);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetChihun(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={537};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill539 : GSkill
	{
		public GSkill539()
			: base(539)
		{
			
		}
	}
}
