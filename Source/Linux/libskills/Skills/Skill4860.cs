using System;
using System.Text;

namespace SKILL
{
	public class GSkill4860Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill4860Stub()
			: base(4860)
		{
			occupation = 110;
			maxlevel = 4;
			maxlearn = 3;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			SetAction(0,"”¢’–_∑¿”˘’Ω∏Ë");
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
			SetAction(13,"0");
			SetAction(14,"”¢’–_∑¿”˘’Ω∏Ë");
			SetAction(15,"0");
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
			name = "’Û°§∆Ê√≈∂›º◊";
			nativename = "’Û°§∆Ê√≈∂›º◊";
			icon = "’Û∑®£∫∆Ê√≈∂›º◊.dds";
			SetTalent(0,5188);
			SetTalent(1,5189);
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
			skill_class = 13;
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
		public override int GetRequiredLevel(int level)
		{
			int[] array={76,84,92};return array[level-1];
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
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_dodge = player.GetDodge();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			if ( skill_t0 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(10000.0f);
			victim.SetRatio((skill_level * (skill_t0 * 0.01f) + 0.00001f));
			victim.SetBuffid(0);
			victim.SetIncskilldodge(true);
			victim.SetProbability(120.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(0);
			victim.SetValue(((player_dodge * skill_level) * 0.02f));
			victim.SetAdddodge(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(3600000.0f);
			victim.SetAmount(21.0f);
			victim.SetHolyaura(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4859};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
		public override int GetHpcost(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

            return (int)((1.0f - skill_t1 * 0.25f) * 50.0f);
		}
	}
	public class GSkill4860 : GSkill
	{
		public GSkill4860()
			: base(4860)
		{
			
		}
	}
	public class GSkill4861Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill4861Stub()
			: base(4861)
		{
			occupation = 110;
			maxlevel = 4;
			maxlearn = 3;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			SetAction(0,"”¢’–_π•ª˜’Ω∏Ë");
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
			SetAction(13,"0");
			SetAction(14,"”¢’–_π•ª˜’Ω∏Ë");
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
			name = "’Û°§ Æ√Ê¬Ò∑¸";
			nativename = "’Û°§ Æ√Ê¬Ò∑¸";
			icon = "’Û∑®£∫ Æ√Ê¬Ò∑¸.dds";
			SetTalent(0,5222);
			SetTalent(1,5223);
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
			skill_class = 13;
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
		public override int GetRequiredLevel(int level)
		{
			int[] array={76,84,92};return array[level-1];
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
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			if ( skill_t0 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(10000.0f);
			victim.SetRatio((skill_level * (skill_t0 * 0.01f) + 0.00001f));
			victim.SetBuffid(0);
			victim.SetDecskilldodge(true);
			victim.SetProbability(120.0f);
			victim.SetTime(10000.0f);
			victim.SetRatio((skill_level * 0.02f));
			victim.SetBuffid(0);
			victim.SetDecdodge(true);
			*/
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
		public override int GetPreSkillID(int index)
		{
			int[] array={4859};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
		public override int GetHpcost(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

            return (int)((1.0f - skill_t1 * 0.25f) * 50.0f);
		}
	}
	public class GSkill4861 : GSkill
	{
		public GSkill4861()
			: base(4861)
		{
			
		}
	}
	public class GSkill4862Stub : GSkillStub
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
		public GSkill4862Stub()
			: base(4862)
		{
			occupation = 110;
			maxlevel = 7;
			maxlearn = 6;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 6;
			timetype = 1;
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
			charge = 1;
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
			SetAction(0,"”¢’–_≥Â∑Ê");
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
			SetAction(13,"0");
			SetAction(14,"”¢’–_≥Â∑Ê");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"0");
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
			name = "¡Ó°§≥Â∑Ê";
			nativename = "¡Ó°§≥Â∑Ê";
			icon = "¡Ó£∫≥Â∑Ê.dds";
			SetTalent(0,5195);
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
			skill_class = 13;
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
			return 30000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={80,84,88,92,96,100};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((10 * skill_level + (3 * player_var1))));
			victim.SetTime(((500 * skill_level + 2500)));
			victim.SetWrap(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			/*
			if ( skill_t0 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(6000.0f);
			victim.SetRatio((skill_t0 * 0.1f));
			victim.SetNingjin(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4859};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
		public override int GetHpcost(GSkill skill)
		{
			return 300;
		}
	}
	public class GSkill4862 : GSkill
	{
		public GSkill4862()
			: base(4862)
		{
			
		}
	}
	public class GSkill4863Stub : GSkillStub
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
				int				player_maxhp = player.GetMaxhp();
				int				player_rage = player.GetRage();
				int				skill_level = skill.GetLevel();
				float			skill_plus = skill.GetPlus();
				float			skill_plus2 = skill.GetPlus2();

				/*
				if ( player.GetCultivation() == 1 )
				  {
				v25 = player.GetSkilllevel(5251) * 0.1f;
				  }
				  else
				  {
				    v25 = 0.0f;
				  }
				if ( player.GetHasbuff(4273) )
				  {
				v24 = (player.GetSkilllevel(4851) * (player_rage * 0.01f));
				  }
				  else
				  {
				    v24 = 0;
				  }
				skill.SetPlus(((40 * skill_level + 240) + v24 * v25));
				skill.SetPlus2((v24 * (1.0f - v25)));
				if ( player.GetCultivation() == 1 )
				  {
				skill.SetRatio((player.GetSkilllevel(5254) * 0.05f + 1.0f));
				  }
				  else
				  {
				    skill.SetRatio(1.0f);
				  }
				if ( player.GetHasbuff(4273) )
				  {
				skill.SetSkillaccu((((player_rage * 10.0f * 100.0f) / player_maxhp) / (30 - 5 * player.GetSkilllevel(4851))));
				  }
				  else
				  {
				    skill.SetSkillaccu(0);
				  }
				player.SetVar1((int)(skill_plus2 + skill_plus));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4863Stub()
			: base(4863)
		{
			occupation = 110;
			maxlevel = 10;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 14;
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
			SetAction(0,"”¢’–_π««Ω");
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
			SetAction(13,"0");
			SetAction(14,"”¢’–_π««Ω");
			SetAction(15,"0");
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
			name = "ÃÏ¿Œ";
			nativename = "ÃÏ¿Œ";
			icon = "ÃÏ¿Œ.dds";
			SetTalent(0,5184);
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
			skill_class = 13;
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
			return 12000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={85,87,89,91,93,95,97,99,101};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_t0 = skill.GetT0();

			/*
			if ( skill_t0 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_t0)));
			victim.SetBuffid(0);
			victim.SetAmount(((player_var1 * skill_t0)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			/*
			victim.SetProbability(120.0f);
			victim.SetRatio(4102.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetDispel(true);
			if ( player.GetSkilllevel(5179) <= 0 )
			{
			d = 0.0f;
			}
			else
			{
			d = (33 * player.GetSkilllevel(5179) + 1);
			}
			victim.SetProbability(d);
			victim.SetAmount(1.0f);
			victim.SetCleardebuff(true);
			victim.SetProbability(120.0f);
			victim.SetTime(10.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(3);
			victim.SetValue(5115.0f);
			victim.SetDelaycast(true);
			if ( player.GetSkilllevel(4845) <= 0 )
			{
			t = 0.0f;
			}
			else
			{
			t = (1000 * player.GetSkilllevel(5181) + 10000);
			}
			victim.SetTime(t);
			victim.SetRatio(1.0f);
			victim.SetAmount((player.GetSkilllevel(4845) * (player_maxhp * 0.02f)));
			victim.SetDechurt(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4860};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
		public override int GetHpcost(GSkill skill)
		{
			return 300;
		}
	}
	public class GSkill4863 : GSkill
	{
		public GSkill4863()
			: base(4863)
		{
			
		}
	}
	public class GSkill4864Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 700;
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
				return 700;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxhp = player.GetMaxhp();
				int				player_rage = player.GetRage();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();

				/*
				if ( player.GetCultivation() == 2 )
				  {
				v25 = player.GetSkilllevel(5256) * 0.1f;
				  }
				  else
				  {
				    v25 = 0.0f;
				  }
				if ( player.GetHasbuff(4274) )
				  {
				v24 = (player.GetSkilllevel(4852) * (player_rage * 0.01f));
				  }
				  else
				  {
				    v24 = 0;
				  }
				skill.SetPlus(((40 * skill_level + 320) + v24 * v25));
				skill.SetPlus2((v24 * (1.0f - v25)));
				if ( player.GetCultivation() == 2 )
				  {
				skill.SetRatio((player.GetSkilllevel(5259) * 0.05f + 1.0f));
				  }
				  else
				  {
				    skill.SetRatio(1.0f);
				  }
				if ( player.GetHasbuff(4274) )
				  {
				skill.SetCrit(((player_rage / player_maxhp) / (30 - 5 * player.GetSkilllevel(4852))));
				  }
				  else
				  {
				    skill.SetCrit(0.0f);
				  }
				player.SetVar1(player_maxatk);
				player.SetPerform(1);
				*/
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxhp = player.GetMaxhp();
				int				player_rage = player.GetRage();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();

				/*
				if ( player.GetCultivation() == 2 )
				  {
				v25 = player.GetSkilllevel(5256) * 0.1f;
				  }
				  else
				  {
				    v25 = 0.0f;
				  }
				if ( player.GetHasbuff(4274) )
				  {
				v24 = (player.GetSkilllevel(4852) * (player_rage * 0.01f));
				  }
				  else
				  {
				    v24 = 0;
				  }
				skill.SetPlus(((40 * skill_level + 320) + v24 * v25));
				skill.SetPlus2((v24 * (1.0f - v25)));
				if ( player.GetCultivation() == 2 )
				  {
				skill.SetRatio((player.GetSkilllevel(5259) * 0.05f + 1.0f));
				  }
				  else
				  {
				    skill.SetRatio(1.0f);
				  }
				if ( player.GetHasbuff(4274) )
				  {
				skill.SetCrit(((player_rage / player_maxhp) / (30 - 5 * player.GetSkilllevel(4852))));
				  }
				  else
				  {
				    skill.SetCrit(0.0f);
				  }
				player.SetVar1(player_maxatk);
				player.SetPerform(0);
				*/
			}
		}
		public GSkill4864Stub()
			: base(4864)
		{
			occupation = 110;
			maxlevel = 10;
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
			weapon_limit = 14;
			SetAction(0,"”¢’–_“˚—™");
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
			SetAction(13,"0");
			SetAction(14,"”¢’–_“˚—™");
			SetAction(15,"0");
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
			name = "—™»–";
			nativename = "—™»–";
			icon = "’∂…±.dds";
			SetTalent(0,5218);
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
			skill_class = 13;
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
			return 1600;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 6000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={85,87,89,91,93,95,97,99,101};return array[level-1];
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(120.0f);
			if ( player_var1 <= (skill_level * ((player_maxhp - player_hp) * 0.01f)) )
			{
			v33 = player_var1;
			}
			else
			{
			v33 = skill_level * (0.01f * (player_maxhp - player_hp));
			}
			if ( skill_t0 <= 0 )
			{
			v32 = v33;
			}
			else
			{
			v32 = (player.GetDebuffcnt() * 0.01f + 1.0f) * v33;
			}
			victim.SetValue(v32);
			victim.SetDirecthurt(true);
			if ( player.GetCultivation() == 2 )
			{
			v31 = (10 * player.GetSkilllevel(5259));
			}
			else
			{
			v31 = 0.0f;
			}
			victim.SetProbability(v31);
			victim.SetRatio(7.0f);
			victim.SetAmount(9.0f);
			victim.SetValue(0.0f);
			victim.SetDispel(true);
			victim.SetProbability(-1.0f);
			victim.SetRatio(65.0f);
			victim.SetAmount(67.0f);
			victim.SetValue(0.0f);
			victim.SetDispel(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetSkilllevel(4846) <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * player.GetSkilllevel(5215) + 10000)));
			victim.SetRatio((player.GetSkilllevel(4846) * 0.02f));
			victim.SetBuffid(0);
			victim.SetIncattack(true);
			victim.SetProbability(120.0f);
			victim.SetRatio(4275.0f);
			victim.SetAmount(4276.0f);
			victim.SetValue(4278.0f);
			victim.SetDispel(true);
			if ( player.GetSkilllevel(5213) <= 0 )
			v28 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * player.GetSkilllevel(5215) + 10000)));
			victim.SetBuffid(1);
			victim.SetValue((player.GetSkilllevel(5213) * 0.5f));
			victim.SetAddspeed(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4861};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
		public override int GetHpcost(GSkill skill)
		{
			return 300;
		}
	}
	public class GSkill4864 : GSkill
	{
		public GSkill4864()
			: base(4864)
		{
			
		}
	}
	public class GSkill4865Stub : GSkillStub
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
				return 250;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_res4 = player.GetRes4();
				int				skill_t0 = skill.GetT0();

				/*
				if ( player.GetCultivation() == 4 )
				  {
				v = player.GetSkilllevel(5264);
				  }
				  else
				  {
				    v = 0;
				  }
				player.SetVar2(v);
				if ( player.GetCultivation() != 4
				    || (v6 = player, GNET::PlayerWrapper::GetSkilllevel(v6, 5264) <= 0) )
				  {
				v18 = (3 * player_level) + 10 * skill_t0;
				  }
				  else
				  {
				if ( 8 * player.GetSkilllevel(5264) + player_res4 <= 600 )
				    {
				      v17 = 600;
				    }
				    else
				    {
				v17 = player_res4 + 8 * player.GetSkilllevel(5264);
				    }
				    v18 = v17;
				  }
				player.SetVar1(v18);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4865Stub()
			: base(4865)
		{
			occupation = 110;
			maxlevel = 7;
			maxlearn = 6;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 14;
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
			SetAction(0,"”¢’–_»∫ÃÂ≥∞∑Ì");
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
			SetAction(13,"0");
			SetAction(14,"”¢’–_»∫ÃÂ≥∞∑Ì");
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
			name = "º∆°§ŒßŒ∫æ»’‘";
			nativename = "º∆°§ŒßŒ∫æ»’‘";
			icon = "º∆£∫ŒßŒ∫æ»’‘.dds";
			SetTalent(0,5197);
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
			skill_class = 13;
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
			return 60000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,94,98,102,106,110};return array[level-1];
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
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_minatk = player.GetMinatk();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			if ( player.GetObjectType() || skill_t0 <= 0 )
			{
			d = 0.0f;
			}
			else
			{
			d = player_var1;
			}
			victim.SetProbability(d);
			victim.SetTime(10.0f);
			victim.SetSilent(true);
			if ( player.GetObjectType() )
			v31 = 120.0f;
			else
			victim.SetProbability(-1.0f);
			victim.SetTime(((500 * skill_level + 2500)));
			victim.SetAssault2(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((500 * skill_level + 2500)));
			victim.SetBuffid(0);
			victim.SetValue((player_minatk * (skill_level * 0.01f)));
			victim.SetSubattack(true);
			if ( player_var2 <= 0 )
			v30 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(10000.0f);
			victim.SetRatio((player_var2 * 0.01f));
			victim.SetBuffid(0);
			victim.SetDecskilldodge(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4862};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
		public override int GetHpcost(GSkill skill)
		{
			return 300;
		}
	}
	public class GSkill4865 : GSkill
	{
		public GSkill4865()
			: base(4865)
		{
			
		}
	}
	public class GSkill4866Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill4866Stub()
			: base(4866)
		{
			occupation = 110;
			maxlevel = 6;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 5;
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
			SetAction(0,"”¢’–_ºı…À");
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
			SetAction(13,"0");
			SetAction(14,"”¢’–_ºı…À");
			SetAction(15,"0");
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
			name = "πÃ»ÙΩÃ¿";
			nativename = "πÃ»ÙΩÃ¿";
			icon = "πÃ»ÙΩÃ¿.dds";
			SetTalent(0,5180);
			SetTalent(1,5181);
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
			skill_class = 13;
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
			return 60000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={95,100,105,110,115};return array[level-1];
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
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_t1 + 6000)));
			victim.SetRatio((skill_level * 0.1f));
			victim.SetDecdamage(true);
			victim.SetProbability(120.0f);
			if ( skill_t0 <= 0 )
			t = 0.0f;
			else
			victim.SetTime(((1000 * skill_t1 + 6000)));
			victim.SetBuffid(0);
			victim.SetAmount(((2 * skill_t0)));
			victim.SetValue(5228.0f);
			victim.SetActivebecrit(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4863};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill4866 : GSkill
	{
		public GSkill4866()
			: base(4866)
		{
			
		}
	}
	public class GSkill4867Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill4867Stub()
			: base(4867)
		{
			occupation = 110;
			maxlevel = 6;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 5;
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
			SetAction(0,"”¢’–_∫ˆ ”");
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
			SetAction(13,"0");
			SetAction(14,"”¢’–_∫ˆ ”");
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
			name = "÷±µ∑ª∆¡˙";
			nativename = "÷±µ∑ª∆¡˙";
			icon = "÷±µ∑ª∆¡˙.dds";
			SetTalent(0,5214);
			SetTalent(1,5215);
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
			skill_class = 13;
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
			return 60000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={95,100,105,110,115};return array[level-1];
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
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			/*
			victim.SetTime(((1000 * skill_t1 + 6000)));
			victim.SetRatio((skill_level * 0.1f));
			victim.SetBuffid(0);
			victim.SetIncskilldamage(true);
			victim.SetProbability(120.0f);
			if ( skill_t0 <= 0 )
			t = 0.0f;
			else
			victim.SetTime(((1000 * skill_t1 + 6000)));
			victim.SetBuffid(0);
			victim.SetAmount(((2 * skill_t0)));
			victim.SetValue(5228.0f);
			victim.SetActivecrit(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4864};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill4867 : GSkill
	{
		public GSkill4867()
			: base(4867)
		{
			
		}
	}
	public class GSkill4868Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 900;
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				player.SetVar1(1);
				skill.SetPlus(((40 * skill_level + 320)));
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				player.SetVar1(2);
				skill.SetPlus(((40 * skill_level + 320)));
				player.SetPerform(0);
			}
		}
		public GSkill4868Stub()
			: base(4868)
		{
			occupation = 111;
			maxlevel = 10;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 14;
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
			weapon_limit = 14;
			SetAction(0,"”¢’–_¡Ω∂Œ»∫");
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
			SetAction(13,"0");
			SetAction(14,"”¢’–_¡Ω∂Œ»∫");
			SetAction(15,"0");
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
			name = "∫·…®«ßæ¸";
			nativename = "∫·…®«ßæ¸";
			icon = "∫·…®«ßæ¸01.dds";
			SetTalent(0,5202);
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
			skill_class = 13;
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
			return 8000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={105,107,109,111,113,115,117,119,121};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_t0 = skill.GetT0();

			/*
			if ( player_var1 != 2 || skill_t0 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetValue(skill_t0);
			victim.SetRepel2(true);
			*/
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
		public override int GetHpcost(GSkill skill)
		{
			return 200;
		}
	}
	public class GSkill4868 : GSkill
	{
		public GSkill4868()
			: base(4868)
		{
			
		}
	}
	public class GSkill4869Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_rage = player.GetRage();
				int				player_var1 = player.GetVar1();
				int				player_var2 = player.GetVar2();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				/*
				if ( (1.0f - skill_t1 * 0.25f) * (player_maxhp * 0.05f) <= player_hp )
				  {
				v = ((1.0f - skill_t1 * 0.25f) * (player_maxhp * 0.05f));
				  }
				  else
				  {
				v = player_hp;
				  }
				player.SetVar1(v);
				if ( player_maxhp * 0.05f <= player_hp )
				  {
				v28 = (player_maxhp * 0.05f);
				  }
				  else
				  {
				v28 = player_hp;
				  }
				player.SetVar2(v28);
				player.SetHp(((player_hp - player_var1 + 1)));
				player.SetRage((skill_t0 * (player_var2 * 0.5f) + player_rage));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4869Stub()
			: base(4869)
		{
			occupation = 111;
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
			SetAction(0,"”¢’–_∑¿”˘ Ω«øªØ");
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
			SetAction(13,"0");
			SetAction(14,"”¢’–_∑¿”˘ Ω«øªØ");
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
			name = "Œﬁ∂®’Ω∑®";
			nativename = "Œﬁ∂®’Ω∑®";
			icon = "Œﬁ∂®’Ω∑®.dds";
			SetTalent(0,5177);
			SetTalent(1,5178);
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
			skill_class = 13;
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetRatio((skill_level * 0.2f + 0.4f));
			victim.SetAddrage1(true);
			victim.SetProbability(120.0f);
			victim.SetRatio(4274.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetDispel(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4868};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill4869 : GSkill
	{
		public GSkill4869()
			: base(4869)
		{
			
		}
	}
}
