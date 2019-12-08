using System;
using System.Text;

namespace SKILL
{
	public class GSkill3300Stub : GSkillStub
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

				skill.SetCrit(0.050000001f);
				skill.SetRatio(3.1500001f);
				skill.SetPlus(1982.0f);
				player.SetPerform(1);
			}
		}
		public GSkill3300Stub()
			: base(3300)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"∫œª∂≈…_æ…√Œ");
			SetAction(1,"∫œª∂≈…_æ…√Œ");
			SetAction(2,"∫œª∂≈…_æ…√Œ");
			SetAction(3,"∫œª∂≈…_æ…√Œ");
			SetAction(4,"∫œª∂≈…_æ…√Œ");
			SetAction(5,"∫œª∂≈…_æ…√Œ");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_æ…√Œ");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_æ…√Œ");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_æ…√Œ");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_æ…√Œ");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_æ…√Œ");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_æ…√Œ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "æ…√Œ";
			nativename = "æ…√Œ";
			icon = "æ…√Œ.dds";
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
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
			return 500.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 84.0f));
			victim.SetRatio(((D2INT(zrand(100) / 88) + 1) * 0.48f));
			victim.SetDrainmagic(true);
			victim.SetProbability(43.0f);
			victim.SetAmount(2.0f);
			victim.SetClearbuff(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(24.0f);
			victim.SetRatio(0.0f);
			victim.SetValue((player_maxhp * 0.06f));
			victim.SetHeal(true);
			return true;
		}
	}
	public class GSkill3300 : GSkill
	{
		public GSkill3300()
			: base(3300)
		{
			
		}
	}
	public class GSkill3301Stub : GSkillStub
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
		public GSkill3301Stub()
			: base(3301)
		{
			occupation = 128;
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
			SetAction(0,"∫œª∂≈…_œß¥∫");
			SetAction(1,"∫œª∂≈…_œß¥∫");
			SetAction(2,"∫œª∂≈…_œß¥∫");
			SetAction(3,"∫œª∂≈…_œß¥∫");
			SetAction(4,"∫œª∂≈…_œß¥∫");
			SetAction(5,"∫œª∂≈…_œß¥∫");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "œß¥∫";
			nativename = "œß¥∫";
			icon = "œß¥∫.dds";
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
			return 136800;
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
			return 500.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(10500.0f);
			victim.SetValue(16.0f);
			victim.SetBlessed(true);
			victim.SetProbability(100.0f);
			victim.SetBuffid(2);
			victim.SetAmount(99.0f);
			victim.SetValue(99.0f);
			victim.SetExorcism(true);
			victim.SetProbability(90.0f);
			victim.SetClearslow(true);
			victim.SetProbability(120.0f);
			victim.SetTime(136800.0f);
			victim.SetRatio(3030.0f);
			victim.SetAmount(3078.0f);
			victim.SetValue(3126.0f);
			victim.SetSetcooldown(true);
			return true;
		}
	}
	public class GSkill3301 : GSkill
	{
		public GSkill3301()
			: base(3301)
		{
			
		}
	}
	public class GSkill3302Stub : GSkillStub
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

				skill.SetCrit(0.059999999f);
				skill.SetRatio(1.05f);
				skill.SetPlus(375.0f);
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

				skill.SetCrit(0.059999999f);
				skill.SetRatio(1.05f);
				skill.SetPlus(375.0f);
				player.SetPerform(0);
			}
		}
		public GSkill3302Stub()
			: base(3302)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"∫œª∂≈…_¡Ø”∞");
			SetAction(1,"∫œª∂≈…_¡Ø”∞");
			SetAction(2,"∫œª∂≈…_¡Ø”∞");
			SetAction(3,"∫œª∂≈…_¡Ø”∞");
			SetAction(4,"∫œª∂≈…_¡Ø”∞");
			SetAction(5,"∫œª∂≈…_¡Ø”∞");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_¡Ø”∞");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_¡Ø”∞");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_¡Ø”∞");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_¡Ø”∞");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_¡Ø”∞");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_¡Ø”∞");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¡Ø”∞";
			nativename = "¡Ø”∞";
			icon = "¡Ø”∞.dds";
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 4000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetRadius(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 500.000000f;
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

			victim.SetProbability(((1.0f - player_level * 0.002f) * 33.0f));
			victim.SetTime(4000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((120 * skill_level)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(15300.0f);
			victim.SetRatio(0.19f);
			victim.SetInchurt2(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
	}
	public class GSkill3302 : GSkill
	{
		public GSkill3302()
			: base(3302)
		{
			
		}
	}
	public class GSkill3303Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1225;
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
				return 225;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetCrit(0.029999999f);
				skill.SetCrithurt(0.30000001f);
				skill.SetRatio(2.3599999f);
				skill.SetPlus(973.0f);
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
				return 225;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetCrit(0.029999999f);
				skill.SetCrithurt(0.30000001f);
				skill.SetRatio(2.3599999f);
				skill.SetPlus(973.0f);
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetCrit(0.029999999f);
				skill.SetCrithurt(0.30000001f);
				skill.SetRatio(2.3599999f);
				skill.SetPlus(973.0f);
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
				return 125;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetCrit(0.029999999f);
				skill.SetCrithurt(0.30000001f);
				skill.SetRatio(2.3599999f);
				skill.SetPlus(973.0f);
				player.SetPerform(0);
			}
		}
		public GSkill3303Stub()
			: base(3303)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"∫œª∂_∑Áª®—©‘¬");
			SetAction(1,"∫œª∂_∑Áª®—©‘¬");
			SetAction(2,"∫œª∂_∑Áª®—©‘¬");
			SetAction(3,"∫œª∂_∑Áª®—©‘¬");
			SetAction(4,"∫œª∂_∑Áª®—©‘¬");
			SetAction(5,"∫œª∂_∑Áª®—©‘¬");
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
			SetAction(18,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(19,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(20,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(21,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(22,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(23,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "∑Áª®—©‘¬";
			nativename = "∑Áª®—©‘¬";
			icon = "∑Áª®—©‘¬.dds";
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
			AddState(new GState3());
			AddState(new GState4());
			AddState(new GState5());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 6400;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 9.000000f;
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
			return 500.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(((304 * norm(6.0f / (zrand(100) + 0.01f)) + 304)));
			victim.SetTime(9100.0f);
			victim.SetSilent(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(120000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_maxmp * 0.01f * 60.0f * 3.0f));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			victim.SetProbability(33.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio(0.25f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();

			victim.SetProbability(25.0f);
			victim.SetRatio(0.0f);
			victim.SetValue((player_mp * 0.05f));
			victim.SetHeal(true);
			return true;
		}
	}
	public class GSkill3303 : GSkill
	{
		public GSkill3303()
			: base(3303)
		{
			
		}
	}
	public class GSkill3304Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
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

				skill.SetRatio(1.33f);
				skill.SetPlus(((1003 * D2INT(zrand(120) / 100) + 1003)));
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio(1.33f);
				skill.SetPlus(((1003 * D2INT(zrand(120) / 100) + 1003)));
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio(1.33f);
				skill.SetPlus(((1003 * D2INT(zrand(120) / 100) + 1003)));
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio(1.33f);
				skill.SetPlus(((1003 * D2INT(zrand(120) / 100) + 1003)));
				player.SetPerform(0);
			}
		}
		public GSkill3304Stub()
			: base(3304)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
			SetAction(1,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
			SetAction(2,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
			SetAction(3,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
			SetAction(4,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
			SetAction(5,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
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
			SetAction(18,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(19,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(20,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(21,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(23,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¿◊“Ù∑®⁄Õ";
			nativename = "¿◊“Ù∑®⁄Õ";
			icon = "¿◊“Ù∑®⁄Õ.dds";
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
			AddState(new GState3());
			AddState(new GState4());
			AddState(new GState5());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 6400;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 1.5f + 16.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 1.5f + 10.7f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 1.6f + 19.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(((4000 * skill_level)));
			victim.SetBuffid(1);
			victim.SetAmount((skill_level * (skill_level * (skill_level * 1.5f) + ((11 * skill_level + 500)))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(18.0f);
			victim.SetTime(12150.0f);
			victim.SetRatio(0.090000004f);
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetValue(((skill_level << 7)));
			victim.SetJuqi(true);
			return true;
		}
	}
	public class GSkill3304 : GSkill
	{
		public GSkill3304()
			: base(3304)
		{
			
		}
	}
	public class GSkill3305Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 125;
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
				return 100;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();

				player.SetVar1(1);
				skill.SetRatio(1.5700001f);
				skill.SetPlus((player_level * 0.15f * 3.0f * 3.0f + 720.0f + 90.0f + 45.0f));
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
				return 1150;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();

				player.SetVar1(0);
				skill.SetRatio(1.5700001f);
				skill.SetPlus((player_level * 0.15f * 3.0f * 3.0f + 720.0f + 90.0f + 45.0f));
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
				return 1625;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();

				player.SetVar1(0);
				skill.SetCrit(0.1f);
				skill.SetRatio(1.5700001f);
				skill.SetPlus((player_level * 0.15f * 3.0f * 3.0f + 720.0f + 90.0f + 45.0f));
				player.SetPerform(0);
			}
		}
		public GSkill3305Stub()
			: base(3305)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 3;
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
			SetAction(0,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
			SetAction(1,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
			SetAction(2,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
			SetAction(3,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
			SetAction(4,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
			SetAction(5,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
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
			SetAction(18,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(19,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(20,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(21,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(23,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Œﬁ¡ø’Ê—‘";
			nativename = "Œﬁ¡ø’Ê—‘";
			icon = "Œﬁ¡ø’Ê—‘.dds";
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
			AddState(new GState3());
			AddState(new GState4());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 8250;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetRadius(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 15;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			victim.SetTime(4900.0f);
			if ( player.GetSaint() <= 9.0f )
			{
			d = 0.69999999f;
			}
			else
			{
			if ( 0.72f - player.GetSaint() * 0.002f <= 0.1f )
			{
			v17 = 0.1f;
			}
			else
			{
			v17 = 0.72f - player.GetSaint() * 0.002f;
			}
			d = v17;
			}
			victim.SetRatio(d);
			victim.SetBuffid(1);
			victim.SetDecanti(true);
			victim.SetProbability(279.0f);
			victim.SetTime(15100.0f);
			victim.SetValue(0.0f);
			victim.SetSleep(true);
			victim.SetProbability(-1.0f);
			victim.SetRatio(0.30000001f);
			victim.SetDrainmagic(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();

			/*
			victim.SetTime(12700.0f);
			victim.SetRatio(0.15000001f);
			victim.SetBuffid(1);
			victim.SetIncanti(true);
			if ( player_var1 == 1 )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(8050.0f);
			victim.SetRatio(3026.0f);
			victim.SetAmount(3074.0f);
			victim.SetValue(3122.0f);
			victim.SetSetcooldown(true);
			*/
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
	}
	public class GSkill3305 : GSkill
	{
		public GSkill3305()
			: base(3305)
		{
			
		}
	}
	public class GSkill3306Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 200;
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
		public GSkill3306Stub()
			: base(3306)
		{
			occupation = 128;
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
			SetAction(0,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(1,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(2,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(3,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(4,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(5,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
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
			SetAction(18,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(19,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(20,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(21,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(23,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¥ÛËÛ∞„»Ù";
			nativename = "¥ÛËÛ∞„»Ù";
			icon = "¥Û∑≤∞„»Ù.dds";
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
			return 126000;
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
			return 500.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(100.0f);
			victim.SetTime(26100.0f);
			victim.SetRatio(0.20999999f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue((player_maxhp * 0.15f * 10.0f * 1.6f * 1.3f));
			victim.SetBanruo(true);
			victim.SetTime(8100.0f);
			victim.SetInvincible(true);
			return true;
		}
	}
	public class GSkill3306 : GSkill
	{
		public GSkill3306()
			: base(3306)
		{
			
		}
	}
	public class GSkill3307Stub : GSkillStub
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
		public GSkill3307Stub()
			: base(3307)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
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
			SetAction(0,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
			SetAction(1,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
			SetAction(2,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
			SetAction(3,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
			SetAction(4,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
			SetAction(5,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
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
			SetAction(18,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(19,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(20,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(21,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(23,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÕÚœÛ…˙∑";
			nativename = "ÕÚœÛ…˙∑";
			icon = "ÕÚœÛ…˙∑.dds";
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
			return 45000;
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
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 4500.000000f;
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

			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue((player_maxhp * (norm(18000.0f / (player_maxhp * 0.7975f + 1.0f)) * 0.55f * 1.45f) + ((18000 * norm((player_maxhp * 0.55f * 1.45f + 1.0f) / 18000.0f)))));
			victim.SetHeal(true);
			victim.SetProbability(55.0f);
			victim.SetCleardizzy(true);
			victim.SetProbability(55.0f);
			victim.SetClearsilent(true);
			victim.SetProbability(55.0f);
			victim.SetClearwrap(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(((900000 * norm(3))));
			victim.SetRatio(0.0f);
			victim.SetBuffid(5);
			victim.SetValue(1200.0f);
			victim.SetTiangu(true);
			return true;
		}
	}
	public class GSkill3307 : GSkill
	{
		public GSkill3307()
			: base(3307)
		{
			
		}
	}
	public class GSkill3308Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
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
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio((norm(zrand(115) / 100) * 0.18f + 1.24f));
				skill.SetCrit(0.029999999f);
				skill.SetCrithurt(0.89999998f);
				skill.SetPlus(1122.0f);
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
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio((norm(zrand(115) / 100) * 0.18f + 1.24f));
				skill.SetCrit(0.029999999f);
				skill.SetCrithurt(0.89999998f);
				skill.SetPlus(1122.0f);
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
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();

				skill.SetRatio((norm(zrand(115) / 100) * 0.18f + ((3 * norm(zrand(108) / 100.0f)) + 1.06f + 0.18f)));
				skill.SetCrit(0.029999999f);
				skill.SetCrithurt(0.89999998f);
				skill.SetPlus(((12 * player_level + 1122)));
				player.SetPerform(0);
			}
		}
		public GSkill3308Stub()
			: base(3308)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 1;
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
			SetAction(0,"πÌµ¿_√ªÍøÒÏ≠");
			SetAction(1,"πÌµ¿_√ªÍøÒÏ≠");
			SetAction(2,"πÌµ¿_√ªÍøÒÏ≠");
			SetAction(3,"πÌµ¿_√ªÍøÒÏ≠");
			SetAction(4,"πÌµ¿_√ªÍøÒÏ≠");
			SetAction(5,"πÌµ¿_√ªÍøÒÏ≠");
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
			SetAction(18,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(19,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(20,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(21,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(22,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(23,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "√ªÍøÒÏ≠";
			nativename = "√ªÍøÒÏ≠";
			icon = "√ªÍøÒÏ≠.dds";
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
			AddState(new GState3());
			AddState(new GState4());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 5200;
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
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 35;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetRatio(0.18000001f);
			victim.SetDrainmagic(true);
			victim.SetProbability(302.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio(0.15000001f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(((600 * norm((zrand(100) / 94)))));
			victim.SetTime(6150.0f);
			victim.SetDizzy(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(6100.0f);
			victim.SetBuffid(1);
			victim.SetValue(90.0f);
			victim.SetAdddodge(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
	}
	public class GSkill3308 : GSkill
	{
		public GSkill3308()
			: base(3308)
		{
			
		}
	}
	public class GSkill3309Stub : GSkillStub
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
		public GSkill3309Stub()
			: base(3309)
		{
			occupation = 128;
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
			allowform = 2;
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
			SetAction(0,"–∞…Ò∞¡ ¿");
			SetAction(1,"–∞…Ò∞¡ ¿");
			SetAction(2,"–∞…Ò∞¡ ¿");
			SetAction(3,"–∞…Ò∞¡ ¿");
			SetAction(4,"–∞…Ò∞¡ ¿");
			SetAction(5,"–∞…Ò∞¡ ¿");
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
			SetAction(18,"–∞…Ò∞¡ ¿");
			SetAction(19,"–∞…Ò∞¡ ¿");
			SetAction(20,"–∞…Ò∞¡ ¿");
			SetAction(21,"–∞…Ò∞¡ ¿");
			SetAction(22,"–∞…Ò∞¡ ¿");
			SetAction(23,"–∞…Ò∞¡ ¿");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "–∞…Ò∞¡ ¿";
			nativename = "–∞…Ò∞¡ ¿";
			icon = "–∞…Ò∞¡ ¿.dds";
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
			return 126000;
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

			victim.SetProbability(120.0f);
			victim.SetTime(((18000 * norm((zrand(100) / 70)) + 18100)));
			victim.SetRatio(0.25999999f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetAoshi(true);
			return true;
		}
	}
	public class GSkill3309 : GSkill
	{
		public GSkill3309()
			: base(3309)
		{
			
		}
	}
}
