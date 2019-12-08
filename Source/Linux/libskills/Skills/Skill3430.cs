using System;
using System.Text;

namespace SKILL
{
	public class GSkill3430Stub : GSkillStub
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
		public GSkill3430Stub()
			: base(3430)
		{
			occupation = 65;
			maxlevel = 20;
			maxlearn = 3;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 4;
			timetype = 1;
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
			name = "”˘ø’ ı";
			nativename = "”˘ø’ ı";
			icon = "”˘ø’ ı.dds";
			SetTalent(0,3410);
			SetTalent(1,3419);
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
			return 25000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={46,50,76};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 2.5f + 5.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (240 - 40 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((5 * skill_t0 + (15 * skill_level))));
			victim.SetTime(6000.0f);
			victim.SetBuffid(2);
			victim.SetValue((skill_level * 0.5f));
			victim.SetAddspeed(true);
			victim.SetTime(2500.0f);
			victim.SetValue(15.0f);
			victim.SetDodge(true);
			victim.SetProbability(((10 * skill_t1)));
			victim.SetTime(200.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(9);
			victim.SetValue(3644.0f);
			victim.SetDelaycast(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3424};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill3430 : GSkill
	{
		public GSkill3430()
			: base(3430)
		{
			
		}
	}
	public class GSkill3431Stub : GSkillStub
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
				return 2000;
			}
			public override void Calculate(GSkill skill)
			{
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

				player.SetPerform(1);
			}
		}
		public GSkill3431Stub()
			: base(3431)
		{
			occupation = 65;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 3;
			targettype = 0;
			rangetype = 5;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 1024;
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
			SetAction(0,"∑Ÿœ„π»_ª—ÊΩ·ΩÁ");
			SetAction(1,"∑Ÿœ„π»_ª—ÊΩ·ΩÁ");
			SetAction(2,"∑Ÿœ„π»_ª—ÊΩ·ΩÁ");
			SetAction(3,"∑Ÿœ„π»_ª—ÊΩ·ΩÁ");
			SetAction(4,"∑Ÿœ„π»_ª—ÊΩ·ΩÁ");
			SetAction(5,"∑Ÿœ„π»_ª—ÊΩ·ΩÁ");
			SetAction(6,"∑Ÿœ„π»_ª—ÊΩ·ΩÁ");
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
			SetAction(18,"∑Ÿœ„π»_∆Ô≥À_ª—ÊΩ·ΩÁ");
			SetAction(19,"∑Ÿœ„π»_∆Ô≥À_ª—ÊΩ·ΩÁ");
			SetAction(20,"∑Ÿœ„π»_∆Ô≥À_ª—ÊΩ·ΩÁ");
			SetAction(21,"∑Ÿœ„π»_∆Ô≥À_ª—ÊΩ·ΩÁ");
			SetAction(22,"∑Ÿœ„π»_∆Ô≥À_ª—ÊΩ·ΩÁ");
			SetAction(23,"∑Ÿœ„π»_∆Ô≥À_ª—ÊΩ·ΩÁ");
			SetAction(24,"∑Ÿœ„π»_∆Ô≥À_ª—ÊΩ·ΩÁ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "“µª…±";
			nativename = "“µª…±";
			icon = "“µª…±.dds";
			SetTalent(0,3412);
			SetTalent(1,3413);
			SetTalent(2,3396);
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();

            return (int)((1.0f - skill_t2 * 0.1f) * 60000.0f);
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={55,57,59,61,63,65,67,70,73};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 30.000000f;
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

			return (6 * skill_level + 342);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 6;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_charging = skill.GetCharging();

			/*
			if ( skill_charging <= 0x79E || skill_level <= 8 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((3000 * (skill_t1 + skill_level) + 8000)));
			victim.SetRatio(20.0f);
			victim.SetBuffid(2);
			victim.SetAmount(45507.0f);
			victim.SetValue(354.0f);
			victim.SetCreateobject(true);
			if ( skill_charging <= 0x79E || skill_level <= 8 )
			v41 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((3000 * (skill_t1 + skill_level) + 8000)));
			victim.SetRatio(20.0f);
			victim.SetBuffid(2);
			victim.SetAmount(45507.0f);
			victim.SetValue(6.0f);
			victim.SetCreateobject(true);
			if ( skill_charging <= 0x79E || skill_level <= 8 )
			v40 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((3000 * (skill_t1 + skill_level) + 8000)));
			victim.SetRatio(24.0f);
			victim.SetBuffid(2);
			victim.SetAmount(45507.0f);
			victim.SetValue(0.0f);
			victim.SetCreateobject(true);
			if ( skill_charging <= 0x79E || skill_level <= 8 )
			v39 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((3000 * (skill_t1 + skill_level) + 8000)));
			victim.SetRatio(21.5f);
			victim.SetBuffid(2);
			victim.SetAmount(50297.0f);
			victim.SetValue(0.0f);
			victim.SetCreateobject(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_charging = skill.GetCharging();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((3000 * (skill_t1 + skill_level) + 8000)));
			victim.SetRatio(0.0f);
			victim.SetBuffid(2);
			victim.SetAmount(45507.0f);
			victim.SetValue(0.0f);
			victim.SetCreateobject(true);
			if ( skill_charging <= 0x1F4 || skill_level <= 2 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((3000 * (skill_t1 + skill_level) + 8000)));
			victim.SetRatio(5.0f);
			victim.SetBuffid(2);
			victim.SetAmount(45507.0f);
			victim.SetValue(0.0f);
			victim.SetCreateobject(true);
			if ( skill_charging <= 0x3E8 || skill_level <= 4 )
			v40 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((3000 * (skill_t1 + skill_level) + 8000)));
			victim.SetRatio(10.0f);
			victim.SetBuffid(2);
			victim.SetAmount(50295.0f);
			victim.SetValue(0.0f);
			victim.SetCreateobject(true);
			if ( skill_charging <= 0x5DC || skill_level <= 6 )
			v39 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((3000 * (skill_t1 + skill_level) + 8000)));
			victim.SetRatio(15.0f);
			victim.SetBuffid(2);
			victim.SetAmount(50296.0f);
			victim.SetValue(0.0f);
			victim.SetCreateobject(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3430};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill3431 : GSkill
	{
		public GSkill3431()
			: base(3431)
		{
			
		}
	}
	public class GSkill3432Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 3000;
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
				return 5000;
			}
			public override void Calculate(GSkill skill)
			{
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
				return 2000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3432Stub()
			: base(3432)
		{
			occupation = 65;
			maxlevel = 20;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 3;
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
			SetAction(0,"∑Ÿœ„π»_’Û∑®æ´—–°æπÃ’Û°ø");
			SetAction(1,"∑Ÿœ„π»_’Û∑®æ´—–°æπÃ’Û°ø");
			SetAction(2,"∑Ÿœ„π»_’Û∑®æ´—–°æπÃ’Û°ø");
			SetAction(3,"∑Ÿœ„π»_’Û∑®æ´—–°æπÃ’Û°ø");
			SetAction(4,"∑Ÿœ„π»_’Û∑®æ´—–°æπÃ’Û°ø");
			SetAction(5,"∑Ÿœ„π»_’Û∑®æ´—–°æπÃ’Û°ø");
			SetAction(6,"∑Ÿœ„π»_’Û∑®æ´—–°æπÃ’Û°ø");
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
			SetAction(18,"∑Ÿœ„π»_∆Ô≥À_’Û∑®æ´—–°æπÃ’Û°ø");
			SetAction(19,"∑Ÿœ„π»_∆Ô≥À_’Û∑®æ´—–°æπÃ’Û°ø");
			SetAction(20,"∑Ÿœ„π»_∆Ô≥À_’Û∑®æ´—–°æπÃ’Û°ø");
			SetAction(21,"∑Ÿœ„π»_∆Ô≥À_’Û∑®æ´—–°æπÃ’Û°ø");
			SetAction(22,"∑Ÿœ„π»_∆Ô≥À_’Û∑®æ´—–°æπÃ’Û°ø");
			SetAction(23,"∑Ÿœ„π»_∆Ô≥À_’Û∑®æ´—–°æπÃ’Û°ø");
			SetAction(24,"∑Ÿœ„π»_∆Ô≥À_’Û∑®æ´—–°æπÃ’Û°ø");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "∞‘–∞’œ";
			nativename = "∞‘–∞’œ";
			icon = "∞‘–∞’Û°§’Û∑®.dds";
			SetTalent(0,3414);
			SetTalent(1,3415);
			SetTalent(2,3408);
			SetTalent(3,3758);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 4;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = true;
			cyclemode = 1;
			cyclegfx = "∑®’ÛπÃ’Û";
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 10000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();
			int				skill_t3 = skill.GetT3();

            return (int)(((120000 - 15000 * skill_t1)) - skill_t3 * 2400.0f);
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={70,75,80,85,90};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 28.000000f;
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
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((20 * skill_t2)));
			victim.SetBreakcasting(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res2 = player.GetRes2();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t3 = skill.GetT3();
			int				skill_charging = skill.GetCharging();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_t3 + (10000 * player.GetCyclemembercnt() + (2000 * skill_level) + (10000 * (skill_charging / 0x12C0) + (5000 * skill_t1))))));
			v53 = player.GetCyclemembercnt() + (skill_t0 + skill_level) - 1;
			if ( skill_t0 == 4
			&& (v13 = player, GNET::PlayerWrapper::GetCyclemembercnt(v13) == 6) )
			{
			d = (v53 + 400);
			}
			else
			{
			if ( skill_t0 > 2
			&& (v14 = player, GNET::PlayerWrapper::GetCyclemembercnt(v14) > 3) )
			{
			v51 = (v53 + 300);
			}
			else
			{
			if ( skill_t0 <= 1
			|| (v15 = player, GNET::PlayerWrapper::GetCyclemembercnt(v15) <= 1) )
			v50 = (v53 + 100);
			else
			v51 = ((v53 + 200));
			}
			d = v51;
			}
			victim.SetRatio(d);
			victim.SetBuffid(0);
			victim.SetAmount(3605.0f);
			victim.SetValue(2.0f);
			victim.SetCycle(true);
			victim.SetTime(900.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetEvilaura(true);
			victim.SetTime(((1000 * skill_t3 + (10000 * player.GetCyclemembercnt() + (2000 * skill_level) + (10000 * (skill_charging / 0x12C0) + (5000 * skill_t1))))));
			victim.SetBuffid(4);
			victim.SetValue(((player.GetCyclemembercnt() + (skill_t0 + skill_level) - 1) * (player_res2 * 0.02f)));
			victim.SetAddantiweak(true);
			if ( zrand(100) >= 2 * player.GetSkilllevel(3759) )
			v49 = 218.0f;
			else
			victim.SetRatio(3449.0f);
			victim.SetAmount(218.0f);
			victim.SetValue(218.0f);
			victim.SetClearcooldown(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3431};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill3432 : GSkill
	{
		public GSkill3432()
			: base(3432)
		{
			
		}
	}
	public class GSkill3433Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 750;
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
				int				player_res1 = player.GetRes1();
				int				skill_level = skill.GetLevel();

				player.SetVar1(1);
				player.SetVar2(player_maxatk);
				player.SetVar3(player_res1);
				skill.SetRatio((skill_level * 0.01f + 1.08f));
				skill.SetPlus(((80 * skill_level + 300)));
				player.SetPerform(1);
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
				int				player_maxatk = player.GetMaxatk();
				int				player_res1 = player.GetRes1();
				int				skill_level = skill.GetLevel();

				player.SetVar1(2);
				player.SetVar2(player_maxatk);
				player.SetVar3(player_res1);
				skill.SetRatio((skill_level * 0.01f + 1.08f));
				skill.SetPlus(((80 * skill_level + 300)));
				player.SetPerform(0);
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 450;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				player_res1 = player.GetRes1();
				int				skill_level = skill.GetLevel();

				player.SetVar1(3);
				player.SetVar2(player_maxatk);
				player.SetVar3(player_res1);
				skill.SetRatio((skill_level * 0.01f + 1.08f));
				skill.SetPlus(((80 * skill_level + 300)));
				player.SetPerform(0);
			}
		}
		public GSkill3433Stub()
			: base(3433)
		{
			occupation = 66;
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
			SetAction(0,"∑Ÿœ„π»_»˝Œ∂’Êª");
			SetAction(1,"∑Ÿœ„π»_»˝Œ∂’Êª");
			SetAction(2,"∑Ÿœ„π»_»˝Œ∂’Êª");
			SetAction(3,"∑Ÿœ„π»_»˝Œ∂’Êª");
			SetAction(4,"∑Ÿœ„π»_»˝Œ∂’Êª");
			SetAction(5,"∑Ÿœ„π»_»˝Œ∂’Êª");
			SetAction(6,"∑Ÿœ„π»_»˝Œ∂’Êª");
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
			SetAction(18,"∑Ÿœ„π»_∆Ô≥À_»˝Œ∂’Êª");
			SetAction(19,"∑Ÿœ„π»_∆Ô≥À_»˝Œ∂’Êª");
			SetAction(20,"∑Ÿœ„π»_∆Ô≥À_»˝Œ∂’Êª");
			SetAction(21,"∑Ÿœ„π»_∆Ô≥À_»˝Œ∂’Êª");
			SetAction(22,"∑Ÿœ„π»_∆Ô≥À_»˝Œ∂’Êª");
			SetAction(23,"∑Ÿœ„π»_∆Ô≥À_»˝Œ∂’Êª");
			SetAction(24,"∑Ÿœ„π»_∆Ô≥À_»˝Œ∂’Êª");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "»˝√¡’Êª";
			nativename = "»˝√¡’Êª";
			icon = "»˝Œ∂’Êª.dds";
			SetTalent(0,3384);
			SetTalent(1,3383);
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
			AddState(new GState3());
			AddState(new GState4());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return 12000 - 2400 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={75,77,79,81,83,85,87,89,91};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 465.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				player_var3 = player.GetVar3();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			/*
			if ( player_var1 == 1 )
			{
			if ( zrand(100) > 5 * (skill_t0 + skill_level) )
			{
			v35 = 0.0f;
			}
			else
			{
			v35 = player_var3;
			}
			d = v35;
			}
			else
			{
			d = 0.0f;
			}
			victim.SetProbability(d);
			victim.SetTime(3000.0f);
			victim.SetDizzy(true);
			if ( player_var1 != 2 || skill_t1 <= 0 )
			v34 = 0.0f;
			else
			victim.SetProbability(((10 * skill_t1)));
			victim.SetTime(((1000 * (18 - skill_t1))));
			victim.SetBuffid(2);
			victim.SetAmount((skill_t1 * (player_maxmp * 0.333f)));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			if ( player_var1 != 3 || skill_t1 <= 1 )
			{
			v33 = 0.0f;
			}
			else
			{
			v33 = (skill_t2 + (10 * skill_t1));
			}
			victim.SetProbability(v33);
			victim.SetTime(12100.0f);
			victim.SetRatio(6.0f);
			victim.SetBuffid(3);
			victim.SetAmount(6.0f);
			victim.SetValue(((skill_t2 * 0.1f + 1.0f) * (player_var2 * 0.5f)));
			victim.SetFiring(true);
			*/
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill3433 : GSkill
	{
		public GSkill3433()
			: base(3433)
		{
			
		}
	}
	public class GSkill3434Stub : GSkillStub
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
				int				player_mp = player.GetMp();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_maxatk);
				player.SetVar2(player_mp);
				skill.SetRatio((skill_t1 * 0.1f + (skill_t0 * 0.15f + (skill_level * 0.15f + 1.0f))));
				player.SetPerform(1);
			}
		}
		public GSkill3434Stub()
			: base(3434)
		{
			occupation = 66;
			maxlevel = 20;
			maxlearn = 6;
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
			SetAction(0,"∑Ÿœ„π»_ª—Ê≥ÕΩ‰");
			SetAction(1,"∑Ÿœ„π»_ª—Ê≥ÕΩ‰");
			SetAction(2,"∑Ÿœ„π»_ª—Ê≥ÕΩ‰");
			SetAction(3,"∑Ÿœ„π»_ª—Ê≥ÕΩ‰");
			SetAction(4,"∑Ÿœ„π»_ª—Ê≥ÕΩ‰");
			SetAction(5,"∑Ÿœ„π»_ª—Ê≥ÕΩ‰");
			SetAction(6,"∑Ÿœ„π»_ª—Ê≥ÕΩ‰");
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
			SetAction(18,"∑Ÿœ„π»_∆Ô≥À_ª—Ê≥ÕΩ‰");
			SetAction(19,"∑Ÿœ„π»_∆Ô≥À_ª—Ê≥ÕΩ‰");
			SetAction(20,"∑Ÿœ„π»_∆Ô≥À_ª—Ê≥ÕΩ‰");
			SetAction(21,"∑Ÿœ„π»_∆Ô≥À_ª—Ê≥ÕΩ‰");
			SetAction(22,"∑Ÿœ„π»_∆Ô≥À_ª—Ê≥ÕΩ‰");
			SetAction(23,"∑Ÿœ„π»_∆Ô≥À_ª—Ê≥ÕΩ‰");
			SetAction(24,"∑Ÿœ„π»_∆Ô≥À_ª—Ê≥ÕΩ‰");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "—◊±¯÷ÀªÍ";
			nativename = "—◊±¯÷ÀªÍ";
			icon = "—◊±¯÷ÀªÍ.dds";
			SetTalent(0,3385);
			SetTalent(1,3754);
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
			return 26000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={80,84,88,90,96,100};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 11.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1375.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			if ( player.GetHasmultbuff(113) == 1 )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			v41 = (skill_level * 0.02f + 0.03f) * player_var2;
			v32 = player.GetHasbuff(5430) == 1;
			if ( player.GetHasbuff(5431) == 1 )
			v33 = v32 + 1;
			else
			v33 = v32;
			if ( player.GetHasbuff(5432) == 1 )
			v34 = v33 + 1;
			else
			v34 = v33;
			if ( player.GetHasbuff(5433) == 1 )
			v35 = v34 + 1;
			else
			v35 = v34;
			if ( player.GetHasbuff(5434) == 1 )
			v36 = v35 + 1;
			else
			v36 = v35;
			if ( player.GetHasbuff(5435) == 1 )
			v37 = v36 + 1;
			else
			v37 = v36;
			if ( player.GetHasbuff(5436) == 1 )
			v38 = v37 + 1;
			else
			v38 = v37;
			if ( player.GetHasbuff(5437) == 1 )
			v39 = v38 + 1;
			else
			v39 = v38;
			if ( player.GetHasbuff(5438) == 1 )
			v40 = v39 + 1;
			else
			v40 = v39;
			if ( player.GetHasbuff(5439) == 1 )
			v31 = (v40 + 1);
			else
			victim.SetValue((v41 * v40));
			victim.SetDirecthurt(true);
			if ( skill_t0 <= 0 )
			v30 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio(6.0f);
			victim.SetBuffid(3);
			victim.SetAmount(6.0f);
			victim.SetValue((player_var1 * (skill_t0 * 0.15f)));
			victim.SetFiring(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3433};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3434 : GSkill
	{
		public GSkill3434()
			: base(3434)
		{
			
		}
	}
	public class GSkill3435Stub : GSkillStub
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

				player.SetVar1(player_level);
				player.SetPerform(1);
			}
		}
		public GSkill3435Stub()
			: base(3435)
		{
			occupation = 66;
			maxlevel = 20;
			maxlearn = 8;
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
			SetAction(0,"∑Ÿœ„π»_ª·˜ª§÷˜");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"∑Ÿœ„π»_ª·˜ª§÷˜");
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
			SetAction(18,"∑Ÿœ„π»_∆Ô≥À_ª·˜ª§÷˜");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"∑Ÿœ„π»_∆Ô≥À_ª·˜ª§÷˜");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ª¡‘ª§÷˜";
			nativename = "ª¡‘ª§÷˜";
			icon = "ª¡‘ª§÷˜.dds";
			SetTalent(0,3401);
			SetTalent(1,3387);
			SetTalent(2,3388);
			SetTalent(3,3396);
			SetTalent(4,3752);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 5;
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
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

            return (int)((60000.0f - skill_t3 * 6000.0f) - skill_t4 * 1800.0f);
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,92,94,96,98,101,104,107};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 8);
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
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			/*
			if ( player.GetHasbuff(5331)
			|| (v3 = player,
			v4 = GNET::PlayerWrapper::GetLevel(v3),
			v4 > player,_var1 + 10) )
			d = 0.0f;
			else
			victim.SetProbability(600.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(1);
			victim.SetValue(((2 * skill_t2 + skill_level + 2)));
			victim.SetSubhide(true);
			if ( skill_t1 <= 0 || (v13 = zrand(100), v13 >= 33 * skill_t1) )
			v19 = 0.0f;
			else
			victim.SetProbability(-1.0f);
			victim.SetTime(((2000 * skill_t1)));
			victim.SetWrap(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			/*
			victim.SetTime(21000.0f);
			victim.SetRatio((skill_level * 0.02f + 1.0f));
			victim.SetAmount(49.0f);
			victim.SetValue(((55 * skill_t2)));
			victim.SetEvilaura(true);
			if ( zrand(100) >= 40 * skill_t0 )
			v15 = 220.0f;
			else
			victim.SetRatio(3444.0f);
			victim.SetAmount(220.0f);
			victim.SetValue(220.0f);
			victim.SetClearcooldown(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3434};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill3435 : GSkill
	{
		public GSkill3435()
			: base(3435)
		{
			
		}
	}
	public class GSkill3436Stub : GSkillStub
	{
		public GSkill3436Stub()
			: base(3436)
		{
			occupation = 66;
			maxlevel = 20;
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
			name = "¡“”–ƒæ≠";
			nativename = "¡“”–ƒæ≠";
			icon = "¡“”–ƒæ≠.dds";
			SetTalent(0,3398);
			SetTalent(1,3400);
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
			int[] array={76,80,85,91,98,106};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			player.SetPasaddsmite((skill_t1 * 0.1501f + (skill_level * 0.150001f)));
			player.SetPasinccrit((((skill_level / 2) * skill_t0) * 0.01001f));
			player.SetPasadddefence(((skill_level * skill_t2)));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3433};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill3436 : GSkill
	{
		public GSkill3436()
			: base(3436)
		{
			
		}
	}
	public class GSkill3437Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill3437Stub()
			: base(3437)
		{
			occupation = 66;
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
			SetAction(0,"∑Ÿœ„π»_ª—Ê«Ù¿Œ");
			SetAction(1,"∑Ÿœ„π»_ª—Ê«Ù¿Œ");
			SetAction(2,"∑Ÿœ„π»_ª—Ê«Ù¿Œ");
			SetAction(3,"∑Ÿœ„π»_ª—Ê«Ù¿Œ");
			SetAction(4,"∑Ÿœ„π»_ª—Ê«Ù¿Œ");
			SetAction(5,"∑Ÿœ„π»_ª—Ê«Ù¿Œ");
			SetAction(6,"∑Ÿœ„π»_ª—Ê«Ù¿Œ");
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
			SetAction(18,"∑Ÿœ„π»_∆Ô≥À_ª—Ê«Ù¿Œ");
			SetAction(19,"∑Ÿœ„π»_∆Ô≥À_ª—Ê«Ù¿Œ");
			SetAction(20,"∑Ÿœ„π»_∆Ô≥À_ª—Ê«Ù¿Œ");
			SetAction(21,"∑Ÿœ„π»_∆Ô≥À_ª—Ê«Ù¿Œ");
			SetAction(22,"∑Ÿœ„π»_∆Ô≥À_ª—Ê«Ù¿Œ");
			SetAction(23,"∑Ÿœ„π»_∆Ô≥À_ª—Ê«Ù¿Œ");
			SetAction(24,"∑Ÿœ„π»_∆Ô≥À_ª—Ê«Ù¿Œ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÃÏÀ¯«Ù‘π";
			nativename = "ÃÏÀ¯«Ù‘π";
			icon = "ÃÏÀ¯«Ù‘π.dds";
			SetTalent(0,3400);
			SetTalent(1,3402);
			SetTalent(2,3396);
			SetTalent(3,3747);
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
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

            return (int)(((1.0f - skill_t2 * 0.1f) - skill_t3 * 0.03f) * 80000.0f);
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={85,87,89,91,93,95,97,99};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (15 * skill_level + 600);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			/*
			if ( player.GetHasbuff(4197) == 1 )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetRatio(4197.0f);
			victim.SetAmount(4197.0f);
			victim.SetValue(4197.0f);
			victim.SetDispel(true);
			if ( skill_t0 <= 0 )
			v17 = 0.0f;
			else
			victim.SetProbability(300.0f);
			victim.SetTime(((2000 * (skill_t1 + skill_level) + 6000)));
			victim.SetRatio((skill_t0 * 0.15f));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * (skill_t1 + skill_level) + 6000)));
			victim.SetRatio(0.0f);
			victim.SetBuffid(2);
			victim.SetAmount(44678.0f);
			victim.SetValue(0.0f);
			victim.SetCreateobject(true);
			victim.SetProbability(100.0f);
			victim.SetTime((((1.0f - skill_t2 * 0.1f) - skill_t3 * 0.03f) * 80000.0f));
			victim.SetRatio(3749.0f);
			victim.SetAmount(3749.0f);
			victim.SetValue(3749.0f);
			victim.SetSetcooldown(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3436};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3437 : GSkill
	{
		public GSkill3437()
			: base(3437)
		{
			
		}
	}
	public class GSkill3438Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 300;
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
		public GSkill3438Stub()
			: base(3438)
		{
			occupation = 66;
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
			SetAction(0,"∑Ÿœ„π»_¡È¡¶≈≤“∆");
			SetAction(1,"∑Ÿœ„π»_¡È¡¶≈≤“∆");
			SetAction(2,"∑Ÿœ„π»_¡È¡¶≈≤“∆");
			SetAction(3,"∑Ÿœ„π»_¡È¡¶≈≤“∆");
			SetAction(4,"∑Ÿœ„π»_¡È¡¶≈≤“∆");
			SetAction(5,"∑Ÿœ„π»_¡È¡¶≈≤“∆");
			SetAction(6,"∑Ÿœ„π»_¡È¡¶≈≤“∆");
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
			SetAction(18,"∑Ÿœ„π»_∆Ô≥À_¡È¡¶≈≤“∆");
			SetAction(19,"∑Ÿœ„π»_∆Ô≥À_¡È¡¶≈≤“∆");
			SetAction(20,"∑Ÿœ„π»_∆Ô≥À_¡È¡¶≈≤“∆");
			SetAction(21,"∑Ÿœ„π»_∆Ô≥À_¡È¡¶≈≤“∆");
			SetAction(22,"∑Ÿœ„π»_∆Ô≥À_¡È¡¶≈≤“∆");
			SetAction(23,"∑Ÿœ„π»_∆Ô≥À_¡È¡¶≈≤“∆");
			SetAction(24,"∑Ÿœ„π»_∆Ô≥À_¡È¡¶≈≤“∆");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ƒ˝…Ò∞Ÿ¡∂";
			nativename = "ƒ˝…Ò∞Ÿ¡∂";
			icon = "ƒ˝…Ò∞Ÿ¡∂.dds";
			SetTalent(0,3401);
			SetTalent(1,3405);
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
			return 500;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return 25000 - 10000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={95,97,99,101,103,105,108,111,115};return array[level-1];
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
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (3 * skill_level * skill_level + 332);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			/*
			if ( D2INT(player.GetHasbuff(4202) == 1) + (D2INT(player.GetHasbuff(4201) == 1) + (D2INT(player.GetHasbuff(4200) == 1) + (D2INT(player.GetHasbuff(4199) == 1)))) == 1 )
			t = 15000.0f;
			else
			victim.SetTime(1.0f);
			victim.SetRatio((skill_t1 * 0.15f + (skill_level * 0.06f + 0.15f)));
			v25 = D2INT(player.GetHasbuff(4199) == 1) + (3 * D2INT(player.GetHasbuff(4201) == 1) + (2 * D2INT(player.GetHasbuff(4200) == 1)));
			D2INT(player.GetHasbuff(4202) == 1);
			victim.SetAmount(v25);
			victim.SetValue(0.0f);
			victim.SetFocusanti(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3437};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill3438 : GSkill
	{
		public GSkill3438()
			: base(3438)
		{
			
		}
	}
	public class GSkill3439Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1500;
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
				int				player_maxatk = player.GetMaxatk();
				int				player_dodge = player.GetDodge();
				int				player_atkrate = player.GetAtkrate();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio(0.0f);
				skill.SetPlus(((skill_level * 0.5f + 5.0f) * ((15 * skill_t0 + (3 * skill_level) + 20) * ((player_dodge + player_atkrate) * 0.01f))));
				player.SetPerform(1);
			}
		}
		public GSkill3439Stub()
			: base(3439)
		{
			occupation = 66;
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
			SetAction(0,"∑Ÿœ„π»_º¿Ω£ƒ˝‘™");
			SetAction(1,"∑Ÿœ„π»_º¿Ω£ƒ˝‘™");
			SetAction(2,"∑Ÿœ„π»_º¿Ω£ƒ˝‘™");
			SetAction(3,"∑Ÿœ„π»_º¿Ω£ƒ˝‘™");
			SetAction(4,"∑Ÿœ„π»_º¿Ω£ƒ˝‘™");
			SetAction(5,"∑Ÿœ„π»_º¿Ω£ƒ˝‘™");
			SetAction(6,"∑Ÿœ„π»_º¿Ω£ƒ˝‘™");
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
			SetAction(18,"∑Ÿœ„π»_∆Ô≥À_º¿Ω£ƒ˝‘™");
			SetAction(19,"∑Ÿœ„π»_∆Ô≥À_º¿Ω£ƒ˝‘™");
			SetAction(20,"∑Ÿœ„π»_∆Ô≥À_º¿Ω£ƒ˝‘™");
			SetAction(21,"∑Ÿœ„π»_∆Ô≥À_º¿Ω£ƒ˝‘™");
			SetAction(22,"∑Ÿœ„π»_∆Ô≥À_º¿Ω£ƒ˝‘™");
			SetAction(23,"∑Ÿœ„π»_∆Ô≥À_º¿Ω£ƒ˝‘™");
			SetAction(24,"∑Ÿœ„π»_∆Ô≥À_º¿Ω£ƒ˝‘™");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "º¿Ω£ƒ˝‘™";
			nativename = "º¿Ω£ƒ˝‘™";
			icon = "º¿Ω£ƒ˝‘™.dds";
			SetTalent(0,3416);
			SetTalent(1,3751);
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
			int				skill_t0 = skill.GetT0();

			return 60000 - 5000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={76,78,80,82,84,86,88,90,92};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 14.500000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (10 * skill_level + 564);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((skill_t1 + 15)));
			victim.SetTime(12100.0f);
			victim.SetRatio(5.0f);
			victim.SetBuffid(3);
			victim.SetAmount(5.0f);
			victim.SetValue(((skill_t1 * 0.1f + 1.0f) * (player_var1 * 0.2f)));
			victim.SetFiring(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * (30 - skill_level))));
			victim.SetRatio(1.0f);
			victim.SetBuffid(2);
			victim.SetDecaccuracy(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * (30 - skill_level))));
			victim.SetRatio(1.0f);
			victim.SetBuffid(2);
			victim.SetDecdodge(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3433};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill3439 : GSkill
	{
		public GSkill3439()
			: base(3439)
		{
			
		}
	}
}
