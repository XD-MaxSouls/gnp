using System;
using System.Text;

namespace SKILL
{
	public class GSkill780Stub : GSkillStub
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
		public GSkill780Stub()
			: base(780)
		{
			occupation = 17;
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
			SetAction(0,"合欢派_惜春");
			SetAction(1,"合欢派_惜春");
			SetAction(2,"合欢派_惜春");
			SetAction(3,"合欢派_惜春");
			SetAction(4,"合欢派_惜春");
			SetAction(5,"合欢派_惜春");
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
			SetAction(18,"合欢派_骑乘_惜春");
			SetAction(19,"合欢派_骑乘_惜春");
			SetAction(20,"合欢派_骑乘_惜春");
			SetAction(21,"合欢派_骑乘_惜春");
			SetAction(22,"合欢派_骑乘_惜春");
			SetAction(23,"合欢派_骑乘_惜春");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "惜春";
			nativename = "惜春";
			icon = "惜春.dds";
			SetTalent(0,734);
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

			return 60000 - 4800 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,136,136,138,139};return array[level-1];
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

			return (17 * skill_level + 490);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetTime(((skill_t2 * 0.1f + 1.0f) * 12000.0f + 100.0f));
			victim.SetValue(((2 * (skill_t0 + skill_level))));
			victim.SetBlessed(true);
			victim.SetProbability(100.0f);
			victim.SetBuffid(2);
			victim.SetAmount(99.0f);
			victim.SetValue(99.0f);
			victim.SetExorcism(true);
			victim.SetProbability(((30 * skill_t0)));
			victim.SetClearslow(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetTime(((3000 * norm(skill_t0 / 1.5f))));
			victim.SetInvincible(true);
			victim.SetProbability(120.0f);
			victim.SetRatio(293.0f);
			victim.SetBuffid(0);
			victim.SetAmount(0.0f);
			victim.SetValue(2000.0f);
			victim.SetReduceskillcd(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={779};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill780 : GSkill
	{
		public GSkill780()
			: base(780)
		{
			
		}
	}
	public class GSkill781Stub : GSkillStub
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

				skill.SetCrit((skill_t0 * 0.02f));
				skill.SetRatio((skill_t1 * 0.1f + 0.75f));
				skill.SetPlus(((5 * skill_level * skill_level + (60 * skill_level) + 55)));
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

				skill.SetCrit((skill_t0 * 0.02f));
				skill.SetRatio((skill_t1 * 0.1f + 0.75f));
				skill.SetPlus(((5 * skill_level * skill_level + (60 * skill_level) + 55)));
				player.SetPerform(0);
			}
		}
		public GSkill781Stub()
			: base(781)
		{
			occupation = 17;
			maxlevel = 5;
			maxlearn = 4;
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
			SetAction(0,"合欢派_怜影");
			SetAction(1,"合欢派_怜影");
			SetAction(2,"合欢派_怜影");
			SetAction(3,"合欢派_怜影");
			SetAction(4,"合欢派_怜影");
			SetAction(5,"合欢派_怜影");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"32");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"合欢派_骑乘_怜影");
			SetAction(19,"合欢派_骑乘_怜影");
			SetAction(20,"合欢派_骑乘_怜影");
			SetAction(21,"合欢派_骑乘_怜影");
			SetAction(22,"合欢派_骑乘_怜影");
			SetAction(23,"合欢派_骑乘_怜影");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "怜影";
			nativename = "怜影";
			icon = "怜影.dds";
			SetTalent(0,731);
			SetTalent(1,735);
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 6000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,135,136,138};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((12 * skill_level) + (skill_level * (skill_level * 1.2f)) + 780.0f);
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
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 33.0f));
			victim.SetTime(4000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((120 * skill_level)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((skill_t2 * 0.3f + 1.0f) * 8000.0f + 100.0f));
			victim.SetRatio((skill_t3 * 0.03f + 0.1f));
			victim.SetInchurt2(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetRatio(293.0f);
			victim.SetBuffid(0);
			victim.SetAmount(0.0f);
			victim.SetValue(2000.0f);
			victim.SetReduceskillcd(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={780};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill781 : GSkill
	{
		public GSkill781()
			: base(781)
		{
			
		}
	}
	public class GSkill782Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();
				int				skill_t6 = skill.GetT6();

				player.SetVar1(1);
				skill.SetCrit((skill_t2 * 0.01f));
				skill.SetCrithurt((skill_t2 * 0.1f));
				float f = skill_t0 * 0.05f + ((0.04f * skill_level) + 1.0f);
				float ratio = 0.0f;
				if (skill_t4 < skill_t5)
				{
					ratio = (skill_t5 < skill_t6)?(skill_t6 * 0.03f + f):(skill_t5 * 0.03f + f);
				}
				else
				{
					ratio = (skill_t4 < skill_t6)?(skill_t6 * 0.03f + f):(skill_t4 * 0.03f + f);
				}
				skill.SetRatio(ratio);
				skill.SetPlus(((4 * skill_level * skill_level + (29 * skill_level) + 850)));
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();
				int				skill_t6 = skill.GetT6();

				player.SetVar1(0);
				skill.SetCrit((skill_t2 * 0.01f));
				skill.SetCrithurt((skill_t2 * 0.1f));
				float f = skill_t0 * 0.05f + ((0.04f * skill_level) + 1.0f);
				float ratio = 0.0f;
				if ( skill_t4 < skill_t5 )
				{
					ratio = (skill_t5 < skill_t6)?(skill_t6 * 0.03f + f):(skill_t5 * 0.03f + f);
				}
				else
				{
					ratio = (skill_t4 < skill_t6)?(skill_t6 * 0.03f + f):(skill_t4 * 0.03f + f);
				}
				skill.SetRatio(ratio);
				skill.SetPlus(((4 * skill_level * skill_level + (29 * skill_level) + 850)));
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();
				int				skill_t6 = skill.GetT6();

				player.SetVar1(0);
				skill.SetCrit((skill_t2 * 0.01f));
				skill.SetCrithurt((skill_t2 * 0.1f));
				float f = skill_t0 * 0.05f + ((0.04f * skill_level) + 1.0f);
				float ratio = 0.0f;
				if ( skill_t4 < skill_t5 )
				{
					ratio = (skill_t5 < skill_t6)?(skill_t6 * 0.03f + f):(skill_t5 * 0.03f + f);
				}
				else
				{
					ratio = (skill_t4 < skill_t6)?(skill_t6 * 0.03f + f):(skill_t4 * 0.03f + f);
				}
				skill.SetRatio(ratio);
				skill.SetPlus(((4 * skill_level * skill_level + (29 * skill_level) + 850)));
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();
				int				skill_t6 = skill.GetT6();

				player.SetVar1(0);
				skill.SetCrit((skill_t2 * 0.01f));
				skill.SetCrithurt((skill_t2 * 0.1f));
				float f = skill_t0 * 0.05f + ((0.04f * skill_level) + 1.0f);
				float ratio = 0.0f;
				if ( skill_t4 < skill_t5 )
				{
					ratio = (skill_t5 < skill_t6)?(skill_t6 * 0.03f + f):(skill_t5 * 0.03f + f);
				}
				else
				{
					ratio = (skill_t4 < skill_t6)?(skill_t6 * 0.03f + f):(skill_t4 * 0.03f + f);
				}
				skill.SetRatio(ratio);
				skill.SetPlus(((4 * skill_level * skill_level + (29 * skill_level) + 850)));
				player.SetPerform(0);
			}
		}
		public GSkill782Stub()
			: base(782)
		{
			occupation = 17;
			maxlevel = 3;
			maxlearn = 2;
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
			SetAction(0,"合欢_风花雪月");
			SetAction(1,"合欢_风花雪月");
			SetAction(2,"合欢_风花雪月");
			SetAction(3,"合欢_风花雪月");
			SetAction(4,"合欢_风花雪月");
			SetAction(5,"合欢_风花雪月");
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
			SetAction(18,"合欢_骑乘_风花雪月");
			SetAction(19,"合欢_骑乘_风花雪月");
			SetAction(20,"合欢_骑乘_风花雪月");
			SetAction(21,"合欢_骑乘_风花雪月");
			SetAction(22,"合欢_骑乘_风花雪月");
			SetAction(23,"合欢_骑乘_风花雪月");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "风花雪月";
			nativename = "风花雪月";
			icon = "风花雪月.dds";
			SetTalent(0,742);
			SetTalent(1,749);
			SetTalent(2,753);
			SetTalent(3,768);
			SetTalent(4,2947);
			SetTalent(5,4112);
			SetTalent(6,4530);
			SetTalent(7,0);
			talent_size = 7;
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 9000 - 1800 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={139,141};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return (2 * (skill_level * skill_level + (5 * skill_level)) + 475);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

			float z = zrand(100) + 0.01f;
			float x = 0.0f;
			if (skill_t4 < player.GetSkilllevel(4112))
			{
				x = (player.GetSkilllevel(4112) < player.GetSkilllevel(4530))?(player.GetSkilllevel(4530) / z):(player.GetSkilllevel(4112) / z);
			}
			else
			{
				x = (skill_t4 < player.GetSkilllevel(4530))?(player.GetSkilllevel(4530) / z):(skill_t4 / z);
			}
			victim.SetProbability((((4 * (skill_level * skill_t3 + (4 * skill_level)) + 220) * (norm(x) + 1))));
			victim.SetTime(9100.0f);
			victim.SetSilent(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(120000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((skill_level * (player_maxmp * 0.01f * 60.0f)));
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
			int				player_var1 = player.GetVar1();

			victim.SetProbability(25.0f);
			victim.SetRatio(0.0f);
			victim.SetValue((player_mp * 0.05f));
			victim.SetHeal(true);
			victim.SetProbability(((120 * player_var1)));
			victim.SetRatio(293.0f);
			victim.SetBuffid(0);
			victim.SetAmount(0.0f);
			victim.SetValue(2000.0f);
			victim.SetReduceskillcd(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={779};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill782 : GSkill
	{
		public GSkill782()
			: base(782)
		{
			
		}
	}
	public class GSkill783Stub : GSkillStub
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

				skill.SetRatio(skill_t3 * 0.05f + 1.1f);
				skill.SetPlus(((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((skill_level * (skill_level * 7.2f)) - skill_level * 6.4f + 694.0f));
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

				skill.SetRatio(skill_t3 * 0.05f + 1.1f);
				skill.SetPlus(((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((skill_level * (skill_level * 7.2f)) - skill_level * 6.4f + 694.0f));
				player.SetPerform(0);
			}
		}
		public GSkill783Stub()
			: base(783)
		{
			occupation = 20;
			maxlevel = 7;
			maxlearn = 6;
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
			SetAction(0,"青云门_雷光遁龙决");
			SetAction(1,"青云门_雷光遁龙决");
			SetAction(2,"青云门_雷光遁龙决");
			SetAction(3,"青云门_雷光遁龙决");
			SetAction(4,"青云门_雷光遁龙决");
			SetAction(5,"青云门_雷光遁龙决");
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
			SetAction(18,"青云门_骑乘_雷光遁龙决");
			SetAction(19,"青云门_骑乘_雷光遁龙决");
			SetAction(20,"青云门_骑乘_雷光遁龙决");
			SetAction(21,"青云门_骑乘_雷光遁龙决");
			SetAction(22,"青云门_骑乘_雷光遁龙决");
			SetAction(23,"青云门_骑乘_雷光遁龙决");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "雷光遁龙诀";
			nativename = "雷光遁龙诀";
			icon = "雷光遁龙诀.dds";
			SetTalent(0,582);
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 3000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,135,135,135,136,137};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return ((skill_level * (skill_level * 11.5f)) - skill_level * 2.8f + 1630.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(5 * skill_level + 3);
			victim.SetTime(8000 * skill_t0 + 8100);
			victim.SetBuffid(1);
			victim.SetValue(25 * (skill_t0 + 1) * skill_level);
			victim.SetSubattack(true);
			victim.SetProbability(5 * skill_t2);
			victim.SetTime(3050 * skill_t2);
			victim.SetRatio(skill_t2 * 0.05f);
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
	public class GSkill783 : GSkill
	{
		public GSkill783()
			: base(783)
		{
			
		}
	}
	public class GSkill784Stub : GSkillStub
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
		public GSkill784Stub()
			: base(784)
		{
			occupation = 20;
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
			SetAction(0,"青云门_天尊法身");
			SetAction(1,"青云门_天尊法身");
			SetAction(2,"青云门_天尊法身");
			SetAction(3,"青云门_天尊法身");
			SetAction(4,"青云门_天尊法身");
			SetAction(5,"青云门_天尊法身");
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
			SetAction(18,"青云门_骑乘_天尊法身");
			SetAction(19,"青云门_骑乘_天尊法身");
			SetAction(20,"青云门_骑乘_天尊法身");
			SetAction(21,"青云门_骑乘_天尊法身");
			SetAction(22,"青云门_骑乘_天尊法身");
			SetAction(23,"青云门_骑乘_天尊法身");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "天尊法身";
			nativename = "天尊法身";
			icon = "天尊法身.dds";
			SetTalent(0,578);
			SetTalent(1,592);
			SetTalent(2,594);
			SetTalent(3,596);
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
			int				skill_t3 = skill.GetT3();

			return 120000 - 10000 * skill_t3;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,136,136,138,139};return array[level-1];
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

			return (30 * skill_level + 560);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(100.0f);
			victim.SetTime(20100.0f);
			victim.SetRatio(((D2INT((zrand(5 * skill_t2 + 99)) / 100) + 1) * (skill_t2 * 0.01f + (skill_level * 0.01f + 0.011f))));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t0 * 0.3f + 1.0f) * (((75 * skill_level * (skill_level * skill_level) + (500 * skill_level)) - 1500 * D2INT(skill_level / 6.5f)))));
			victim.SetFashen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((4000 * norm(skill_t1))));
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue((player_maxhp * (skill_t1 * 0.02f)));
			victim.SetHpgen(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={783};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill784 : GSkill
	{
		public GSkill784()
			: base(784)
		{
			
		}
	}
	public class GSkill785Stub : GSkillStub
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
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((D2INT((player_mp / (0.95f - skill_t2 * 0.1f)) / player_maxmp) * 0.08f + (skill_t3 * ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f))) + (skill_level * 0.03f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * ((8 * skill_level * skill_level + (22 * skill_level) + 750))));
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
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((D2INT((player_mp / (0.95f - skill_t2 * 0.1f)) / player_maxmp) * 0.08f + (skill_t3 * ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f))) + (skill_level * 0.03f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * ((8 * skill_level * skill_level + (22 * skill_level) + 750))));
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
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((D2INT((player_mp / (0.95f - skill_t2 * 0.1f)) / player_maxmp) * 0.08f + (skill_t3 * ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f))) + (skill_level * 0.03f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * ((8 * skill_level * skill_level + (22 * skill_level) + 750))));
				player.SetPerform(0);
			}
		}
		public GSkill785Stub()
			: base(785)
		{
			occupation = 20;
			maxlevel = 5;
			maxlearn = 4;
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
			SetAction(0,"青云门_太极玄天真诀");
			SetAction(1,"青云门_太极玄天真诀");
			SetAction(2,"青云门_太极玄天真诀");
			SetAction(3,"青云门_太极玄天真诀");
			SetAction(4,"青云门_太极玄天真诀");
			SetAction(5,"青云门_太极玄天真诀");
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
			SetAction(18,"青云门_骑乘_太极玄天真诀");
			SetAction(19,"青云门_骑乘_太极玄天真诀");
			SetAction(20,"青云门_骑乘_太极玄天真诀");
			SetAction(21,"青云门_骑乘_太极玄天真诀");
			SetAction(22,"青云门_骑乘_太极玄天真诀");
			SetAction(23,"青云门_骑乘_太极玄天真诀");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "太极玄天真诀";
			nativename = "太极玄天真诀";
			icon = "太极玄天真诀.dds";
			SetTalent(0,607);
			SetTalent(1,611);
			SetTalent(2,612);
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
			AddState(new GState3());
			AddState(new GState4());
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
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,135,136,138};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 23.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((4 * skill_level * skill_level) - 5 * skill_level + 2230);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((3 * skill_t1 + (5 * skill_level))));
			victim.SetTime(3100.0f);
			victim.SetRatio(0.2f);
			victim.SetValue(0.2f);
			victim.SetRandcurse(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();
			int				skill_t2 = skill.GetT2();

			victim.SetBuffid((D2INT((player_mp / (0.95f - skill_t2 * 0.1f)) / player_maxmp)));
			victim.SetUniqprompt(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={784};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill785 : GSkill
	{
		public GSkill785()
			: base(785)
		{
			
		}
	}
	public class GSkill786Stub : GSkillStub
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();
				int				skill_t6 = skill.GetT6();

				player.SetVar1(1);
				float f = skill_t3 * ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))) + ((0.04f * skill_level) + 1.0f);
				float ratio = 0.0f;
				if ( skill_t4 < skill_t5 )
				{
					ratio = (skill_t5 < skill_t6)?(skill_t6 * 0.02f + f):(skill_t5 * 0.02f + f);
				}
				else
				{
					ratio = (skill_t4 < skill_t6)?(skill_t6 * 0.02f + f):(skill_t4 * 0.02f + f);
				}
				skill.SetRatio(ratio);
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((15 * skill_level * skill_level + (50 * skill_level) + 800))));
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();
				int				skill_t6 = skill.GetT6();

				player.SetVar1(2);
				float f = skill_t3 * ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))) + ((0.04f * skill_level) + 1.0f);
				float ratio = 0.0f;
				if ( skill_t4 < skill_t5 )
				{
					ratio = (skill_t5 < skill_t6)?(skill_t6 * 0.02f + f):(skill_t5 * 0.02f + f);
				}
				else
				{
					ratio = (skill_t4 < skill_t6)?(skill_t6 * 0.02f + f):(skill_t4 * 0.02f + f);
				}
				skill.SetRatio(ratio);
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((15 * skill_level * skill_level + (50 * skill_level) + 800))));
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();
				int				skill_t6 = skill.GetT6();

				player.SetVar1(2);
				float f = skill_t3 * ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))) + ((0.04f * skill_level) + 1.0f);
				float ratio = 0.0f;
				if ( skill_t4 < skill_t5 )
				{
					ratio = (skill_t5 < skill_t6)?(skill_t6 * 0.02f + f):(skill_t5 * 0.02f + f);
				}
				else
				{
					ratio = (skill_t4 < skill_t6)?(skill_t6 * 0.02f + f):(skill_t4 * 0.02f + f);
				}
				skill.SetRatio(ratio);
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((15 * skill_level * skill_level + (50 * skill_level) + 800))));
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();
				int				skill_t6 = skill.GetT6();

				player.SetVar1(2);
				float f = skill_t3 * ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))) + ((0.04f * skill_level) + 1.0f);
				float ratio = 0.0f;
				if ( skill_t4 < skill_t5 )
				{
					ratio = (skill_t5 < skill_t6)?(skill_t6 * 0.02f + f):(skill_t5 * 0.02f + f);
				}
				else
				{
					ratio = (skill_t4 < skill_t6)?(skill_t6 * 0.02f + f):(skill_t4 * 0.02f + f);
				}
				skill.SetRatio(ratio);
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((15 * skill_level * skill_level + (50 * skill_level) + 800))));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState6 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();
				int				skill_t6 = skill.GetT6();

				player.SetVar1(2);
				float f = skill_t3 * ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))) + ((0.04f * skill_level) + 1.0f);
				float ratio = 0.0f;
				if ( skill_t4 < skill_t5 )
				{
					ratio = (skill_t5 < skill_t6)?(skill_t6 * 0.02f + f):(skill_t5 * 0.02f + f);
				}
				else
				{
					ratio = (skill_t4 < skill_t6)?(skill_t6 * 0.02f + f):(skill_t4 * 0.02f + f);
				}
				skill.SetRatio(ratio);
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((15 * skill_level * skill_level + (50 * skill_level) + 800))));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState7 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();
				int				skill_t6 = skill.GetT6();

				player.SetVar1(3);
				float f = skill_t3 * ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))) + ((0.04f * skill_level) + 1.0f);
				float ratio = 0.0f;
				if ( skill_t4 < skill_t5 )
				{
					ratio = (skill_t5 < skill_t6)?(skill_t6 * 0.02f + f):(skill_t5 * 0.02f + f);
				}
				else
				{
					ratio = (skill_t4 < skill_t6)?(skill_t6 * 0.02f + f):(skill_t4 * 0.02f + f);
				}
				skill.SetRatio(ratio);
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * (((D2INT((zrand(5 * skill_level + 99)) / 100) + 1) * (15 * skill_level * skill_level + (50 * skill_level) + 800)))));
				player.SetPerform(0);
			}
		}
		public GSkill786Stub()
			: base(786)
		{
			occupation = 20;
			maxlevel = 3;
			maxlearn = 2;
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
			SetAction(0,"青云门_神剑御雷真诀");
			SetAction(1,"青云门_神剑御雷真诀");
			SetAction(2,"青云门_神剑御雷真诀");
			SetAction(3,"青云门_神剑御雷真诀");
			SetAction(4,"青云门_神剑御雷真诀");
			SetAction(5,"青云门_神剑御雷真诀");
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
			SetAction(18,"青云门_骑乘_神剑御雷真诀");
			SetAction(19,"青云门_骑乘_神剑御雷真诀");
			SetAction(20,"青云门_骑乘_神剑御雷真诀");
			SetAction(21,"青云门_骑乘_神剑御雷真诀");
			SetAction(22,"青云门_骑乘_神剑御雷真诀");
			SetAction(23,"青云门_骑乘_神剑御雷真诀");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "神剑御雷真诀";
			nativename = "神剑御雷真诀";
			icon = "神剑御雷真诀.dds";
			SetTalent(0,593);
			SetTalent(1,607);
			SetTalent(2,611);
			SetTalent(3,617);
			SetTalent(4,2947);
			SetTalent(5,4112);
			SetTalent(6,4530);
			SetTalent(7,0);
			talent_size = 7;
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
			AddState(new GState3());
			AddState(new GState4());
			AddState(new GState5());
			AddState(new GState6());
			AddState(new GState7());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 6000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 16000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={139,141};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 26.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (30 * skill_level * skill_level + 2560);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((600 * D2INT(zrand(100) / (100 - 5 * skill_level)))));
			victim.SetTime(6100.0f);
			victim.SetSilent(true);
			victim.SetProbability(((6 * skill_level * skill_t0 + (17 * skill_level) + 180)));
			victim.SetTime(((500 * skill_t0 + 6100)));
			victim.SetWrap(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();
			int				skill_t4 = skill.GetT4();
			int				skill_t5 = skill.GetT5();

			/*
			victim.SetRatio(((566 * D2INT((zrand(5 * (skill_t2 + skill_level) + 99)) / 100) + 220)));
			victim.SetAmount(220.0f);
			victim.SetValue(220.0f);
			victim.SetClearcooldown(true);
			v49 = norm(skill_level / 3);
			if ( player_var1 == 1
			|| (v12 = player, GNET::PlayerWrapper::GetVar1(v12) == 3) )
			v50 = 1000 * v49;
			else
			v50 = 0;
			v47 = zrand(100) + 0.01f;
			if ( skill_t4 < skill_t5 )
			{
			if ( skill_t5 < player.GetSkilllevel(4530) )
			{
			v45 = (8 * player.GetSkilllevel(4530)) / v47;
			}
			else
			{
			v45 = (8 * skill_t5) / v47;
			}
			v20 = norm(v45);
			}
			else
			{
			if ( skill_t4 < player.GetSkilllevel(4530) )
			{
			v46 = (8 * player.GetSkilllevel(4530)) / v47;
			}
			else
			{
			v46 = (8 * skill_t4) / v47;
			}
			v20 = norm(v46);
			}
			v48 = v20;
			if ( skill_t4 < skill_t5 )
			{
			if ( skill_t5 < player.GetSkilllevel(4530) )
			{
			v42 = (v48 * v50 * player.GetSkilllevel(4530));
			}
			else
			{
			v42 = (v48 * v50 * skill_t5);
			}
			t = v42;
			}
			else
			{
			if ( skill_t4 < player.GetSkilllevel(4530) )
			{
			v43 = (v48 * v50 * player.GetSkilllevel(4530));
			}
			else
			{
			v43 = (v48 * v50 * skill_t4);
			}
			t = v43;
			}
			victim.SetTime(t);
			if ( skill_t4 < skill_t5 )
			{
			if ( skill_t5 < player.GetSkilllevel(4530) )
			{
			v39 = (player.GetSkilllevel(4530) + 5);
			}
			else
			{
			v39 = (skill_t5 + 5);
			}
			d = v39;
			}
			else
			{
			if ( skill_t4 < player.GetSkilllevel(4530) )
			{
			v40 = (player.GetSkilllevel(4530) + 5);
			}
			else
			{
			v40 = (skill_t4 + 5);
			}
			d = v40;
			}
			victim.SetValue(d);
			victim.SetBlessed(true);
			*/
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={783};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill786 : GSkill
	{
		public GSkill786()
			: base(786)
		{
			
		}
	}
	public class GSkill787Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t2 * 0.07000000000000001f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus((((skill_level * skill_level + (22 * skill_level) + 835) * (D2INT((zrand(7 * skill_t3 + 99)) / 100) + 1))));
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
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t2 * 0.07000000000000001f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus((((skill_level * skill_level + (22 * skill_level) + 835) * (D2INT((zrand(7 * skill_t3 + 99)) / 100) + 1))));
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
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t2 * 0.07000000000000001f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus((((skill_level * skill_level + (22 * skill_level) + 835) * (D2INT((zrand(7 * skill_t3 + 99)) / 100) + 1))));
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
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t2 * 0.07000000000000001f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus((((skill_level * skill_level + (22 * skill_level) + 835) * (D2INT((zrand(7 * skill_t3 + 99)) / 100) + 1))));
				player.SetPerform(0);
			}
		}
		public GSkill787Stub()
			: base(787)
		{
			occupation = 23;
			maxlevel = 7;
			maxlearn = 6;
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
			SetAction(0,"天音寺_雷音法谕");
			SetAction(1,"天音寺_雷音法谕");
			SetAction(2,"天音寺_雷音法谕");
			SetAction(3,"天音寺_雷音法谕");
			SetAction(4,"天音寺_雷音法谕");
			SetAction(5,"天音寺_雷音法谕");
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
			SetAction(18,"天音寺_骑乘_雷音法谕");
			SetAction(19,"天音寺_骑乘_雷音法谕");
			SetAction(20,"天音寺_骑乘_雷音法谕");
			SetAction(21,"天音寺_骑乘_雷音法谕");
			SetAction(22,"天音寺_骑乘_雷音法谕");
			SetAction(23,"天音寺_骑乘_雷音法谕");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "雷音法谕";
			nativename = "雷音法谕";
			icon = "雷音法谕.dds";
			SetTalent(0,684);
			SetTalent(1,698);
			SetTalent(2,702);
			SetTalent(3,708);
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
			skill_class = 3;
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
			int				skill_t0 = skill.GetT0();

			return 16000 - 3200 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,135,135,135,136,137};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return ((skill_level * (skill_level * 2.6f)) - skill_level * 3.3f + 910.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(((4000 * skill_level)));
			victim.SetBuffid(1);
			victim.SetAmount((skill_level * (skill_level * (skill_level * 1.5f) + ((11 * skill_level + 500)))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((6 * skill_t1)));
			victim.SetTime(((4050 * skill_t1)));
			victim.SetRatio((skill_t1 * 0.03f));
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t3 = skill.GetT3();

			victim.SetValue(((32 * skill_level * (skill_t3 + 1))));
			victim.SetJuqi(true);
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill787 : GSkill
	{
		public GSkill787()
			: base(787)
		{
			
		}
	}
	public class GSkill788Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();

                player.SetVar2((int)player.GetSaint());
				player.SetVar1(1);
				float f = skill_t1 * 0.05f + (skill_level * 0.1f + ((0.06f * skill_t0) + 1.0f));
				float ratio = 0.0f;
				if (skill_t3 < skill_t4)
				{
					ratio = (skill_t4 < skill_t5)?(skill_t5 * 0.04f + f):(skill_t4 * 0.04f + f);
				}
				else
				{
					ratio = (skill_t3 < skill_t5)?(skill_t5 * 0.04f + f):(skill_t3 * 0.04f + f);
				}
				skill.SetRatio(ratio);
				skill.SetPlus(((5 * skill_level * skill_level) + ((30 * skill_level) + (skill_t0 * (skill_level * (player_level * 0.15f)) + 720.0f))));
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();

                player.SetVar2((int)player.GetSaint());
				player.SetVar1(0);
				float f = skill_t1 * 0.05f + (skill_level * 0.1f + ((0.06f * skill_t0) + 1.0f));
				float ratio = 0.0f;
				if (skill_t3 < skill_t4)
				{
					ratio = (skill_t4 < skill_t5)?(skill_t5 * 0.04f + f):(skill_t4 * 0.04f + f);
				}
				else
				{
					ratio = (skill_t3 < skill_t5)?(skill_t5 * 0.04f + f):(skill_t3 * 0.04f + f);
				}
				skill.SetRatio(ratio);
				skill.SetPlus(((5 * skill_level * skill_level) + ((30 * skill_level) + (skill_t0 * (skill_level * (player_level * 0.15f)) + 720.0f))));
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();

				player.SetVar2((int)player.GetSaint());
				player.SetVar1(0);
				skill.SetCrit(0.1f);
				float f = skill_t1 * 0.05f + (skill_level * 0.1f + ((0.06f * skill_t0) + 1.0f));
				float ratio = 0.0f;
				if (skill_t3 < skill_t4)
				{
					ratio = (skill_t4 < skill_t5)?(skill_t5 * 0.04f + f):(skill_t4 * 0.04f + f);
				}
				else
				{
					ratio = (skill_t3 < skill_t5)?(skill_t5 * 0.04f + f):(skill_t3 * 0.04f + f);
				}
				skill.SetRatio(ratio);
				skill.SetPlus(((5 * skill_level * skill_level) + ((30 * skill_level) + (skill_t0 * (skill_level * (player_level * 0.15f)) + 720.0f))));
				player.SetPerform(0);
			}
		}
		public GSkill788Stub()
			: base(788)
		{
			occupation = 23;
			maxlevel = 3;
			maxlearn = 2;
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
			SetAction(0,"天音寺_无量真言");
			SetAction(1,"天音寺_无量真言");
			SetAction(2,"天音寺_无量真言");
			SetAction(3,"天音寺_无量真言");
			SetAction(4,"天音寺_无量真言");
			SetAction(5,"天音寺_无量真言");
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
			SetAction(18,"天音寺_骑乘_无量真言");
			SetAction(19,"天音寺_骑乘_无量真言");
			SetAction(20,"天音寺_骑乘_无量真言");
			SetAction(21,"天音寺_骑乘_无量真言");
			SetAction(22,"天音寺_骑乘_无量真言");
			SetAction(23,"天音寺_骑乘_无量真言");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "无量真言";
			nativename = "无量真言";
			icon = "无量真言.dds";
			SetTalent(0,675);
			SetTalent(1,681);
			SetTalent(2,701);
			SetTalent(3,2947);
			SetTalent(4,4112);
			SetTalent(5,4530);
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
			skill_class = 3;
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
			int				skill_t0 = skill.GetT0();

			return 15000 - 2250 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={139,141};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((60 * skill_level) + (skill_level * (skill_level * 1.2f)) + 500.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 35;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();
			int				skill_t5 = skill.GetT5();

			float t = 0.0f;
			if ( skill_t3 < skill_t4 )
			{
				t = (skill_t4 < skill_t5)?(600 * skill_t5 + 3100):(600 * skill_t4 + 3100);
			}
			else
			{
				t = (skill_t3 < skill_t5)?(600 * skill_t5 + 3100):(600 * skill_t3 + 3100);
			}
			victim.SetTime(t);
			float d = 0.0f;
			while (true)
			{
				float s = (0.1f * skill_level) + 0.42f;
				if ((player.GetSaint() * 0.002f) - player_var2 * 0.0015f <= 0.0f)
				{
					if ( s - 0.0f <= 0.35f )
					{
						d = 0.34999999f;
						break;
					}
				}
				else
				{
					if ( s - ((player.GetSaint() * 0.002f) - player_var2 * 0.0015f) <= 0.35f )
					{
						d = 0.34999999f;
						break;
					}
				}
				if ( (player.GetSaint() * 0.002f) - player_var2 * 0.0015f <= 0.0f )
				{
					d = s - 0.0f;
				}
				else
				{
					d = s - ((player.GetSaint() * 0.002f) - player_var2 * 0.0015f);
				}
				break;
			}
			victim.SetRatio(d);
			victim.SetBuffid(1);
			victim.SetDecanti(true);
			victim.SetProbability(((5 * skill_level * skill_t2 + (skill_level * skill_level + (15 * skill_level)) + 180)));
			victim.SetTime(15100.0f);
			victim.SetValue(0.1f);
			victim.SetDsleep(true);
			victim.SetProbability(-1.0f);
			victim.SetRatio((skill_t2 * 0.1f));
			victim.SetDrainmagic(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();
			int				skill_t5 = skill.GetT5();

			/*
			if ( skill_t3 < skill_t4 )
			{
			if ( skill_t4 < skill_t5 )
			v27 = (1200 * skill_t5 + 9100);
			else
			t = ((1200 * skill_t4 + 9100));
			}
			else
			{
			if ( skill_t3 < skill_t5 )
			v28 = (1200 * skill_t5 + 9100);
			else
			t = ((1200 * skill_t3 + 9100));
			}
			victim.SetTime(t);
			v26 = 0.03f * skill_level;
			if ( skill_t3 < skill_t4 )
			{
			if ( skill_t4 < skill_t5 )
			v23 = skill_t5 * 0.02f + v26;
			else
			v25 = (skill_t4 * 0.02f + v26);
			}
			else
			{
			if ( skill_t3 < skill_t5 )
			v24 = skill_t5 * 0.02f + v26;
			else
			v25 = (skill_t3 * 0.02f + v26);
			}
			victim.SetRatio(v25);
			victim.SetBuffid(1);
			victim.SetIncanti(true);
			if ( player_var1 == 1 )
			v22 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((14800 - 2250 * skill_t0)));
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
		public override int GetPreSkillID(int index)
		{
			int[] array={787};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill788 : GSkill
	{
		public GSkill788()
			: base(788)
		{
			
		}
	}
	public class GSkill789Stub : GSkillStub
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
		public GSkill789Stub()
			: base(789)
		{
			occupation = 23;
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
			SetAction(0,"天音寺_大凡般若");
			SetAction(1,"天音寺_大凡般若");
			SetAction(2,"天音寺_大凡般若");
			SetAction(3,"天音寺_大凡般若");
			SetAction(4,"天音寺_大凡般若");
			SetAction(5,"天音寺_大凡般若");
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
			SetAction(18,"天音寺_骑乘_大凡般若");
			SetAction(19,"天音寺_骑乘_大凡般若");
			SetAction(20,"天音寺_骑乘_大凡般若");
			SetAction(21,"天音寺_骑乘_大凡般若");
			SetAction(22,"天音寺_骑乘_大凡般若");
			SetAction(23,"天音寺_骑乘_大凡般若");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "大梵般若";
			nativename = "大梵般若";
			icon = "大凡般若.dds";
			SetTalent(0,693);
			SetTalent(1,700);
			SetTalent(2,716);
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
			skill_class = 3;
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

			return 180000 - 18000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,136,136,138,139};return array[level-1];
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

			return (skill_level * skill_level + (15 * skill_level) + 810);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_t2 + 20100)));
			victim.SetRatio((skill_t0 * 0.02f + (skill_level * 0.03f)));
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(((skill_t2 * 0.1f + 1.0f) * ((skill_t1 * 0.2f + 1.0f) * (player_maxhp * (skill_level * 0.03f) * 10.0f))));
			victim.SetBanruo(true);
			victim.SetTime(((2000 * skill_t2 + 2100)));
			victim.SetInvincible(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={787};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill789 : GSkill
	{
		public GSkill789()
			: base(789)
		{
			
		}
	}
}
