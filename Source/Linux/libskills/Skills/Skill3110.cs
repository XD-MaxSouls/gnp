using System;
using System.Text;

namespace SKILL
{
	public class GSkill3110Stub : GSkillStub
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
		public GSkill3110Stub()
			: base(3110)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 4;
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
			SetAction(0,"青云门_明净灵台");
			SetAction(1,"青云门_明净灵台");
			SetAction(2,"鬼王宗_明净灵台");
			SetAction(3,"合欢派_明净灵台");
			SetAction(4,"天音寺_明净灵台");
			SetAction(5,"鬼道_明净灵台");
			SetAction(6,"焚香谷_明净灵台");
			SetAction(7,"兽神_明净灵台");
			SetAction(8,"狐妖_明净灵台");
			SetAction(9,"轩辕_明净灵台");
			SetAction(10,"怀光_明净灵台");
			SetAction(11,"太昊_明净灵台");
			SetAction(12,"天华_明净灵台");
			SetAction(13,"灵夙_明净灵台");
			SetAction(14,"英招_明净灵台");
			SetAction(15,"武器大师_明净灵台");
			SetAction(16,"0");
			SetAction(17,"天音寺_明净灵台");
			SetAction(18,"青云门_骑乘_明净灵台");
			SetAction(19,"青云门_骑乘_明净灵台");
			SetAction(20,"鬼王宗_骑乘_明净灵台");
			SetAction(21,"合欢派_骑乘_明净灵台");
			SetAction(22,"天音寺_骑乘_明净灵台");
			SetAction(23,"鬼道_骑乘_明净灵台");
			SetAction(24,"焚香谷_骑乘_明净灵台");
			SetAction(25,"兽神_骑乘_明净灵台");
			SetAction(26,"狐妖_骑乘_明净灵台");
			SetAction(27,"轩辕_骑乘_明净灵台");
			SetAction(28,"怀光_骑乘_明净灵台");
			SetAction(29,"太昊_骑乘_明净灵台");
			SetAction(30,"天华_骑乘_明净灵台");
			name = "明镜灵台<禅>";
			nativename = "明镜灵台<禅>";
			icon = "佛·明镜灵台.dds";
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

			return 600000 - 24000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
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
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 4.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (35 * skill_level + 1335);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 10;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(((1000 * skill_level + 10100)));
			victim.SetBuffid(2);
			victim.SetValue(((20 * norm(skill_level / 19.9f) + (3 * skill_level))));
			victim.SetAddanti(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={400,500,500,700,1500,2400,3500,5600,8500,8600,19000,26500,49100,57600,85800,140300,241000,410600,614500,1344300};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={2,4,6,8,10,12,15,18,21,24,28,33,38,43,48,54,60,66,72,78};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 4 * skill_level * skill_level + (50 * skill_level) + 190;
		}
	}
	public class GSkill3110 : GSkill
	{
		public GSkill3110()
			: base(3110)
		{
			
		}
	}
	public class GSkill3111Stub : GSkillStub
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
		public GSkill3111Stub()
			: base(3111)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
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
			clearmask = 4;
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
			SetAction(0,"青云门_雷音天怒");
			SetAction(1,"青云门_雷音天怒");
			SetAction(2,"鬼王宗_雷音天怒");
			SetAction(3,"合欢派_雷音天怒");
			SetAction(4,"天音寺_雷音天怒");
			SetAction(5,"鬼道_雷音天怒");
			SetAction(6,"焚香谷_雷音天怒");
			SetAction(7,"兽神_雷音天怒");
			SetAction(8,"狐妖_雷音天怒");
			SetAction(9,"轩辕_雷音天怒");
			SetAction(10,"怀光_雷音天怒");
			SetAction(11,"太昊_雷音天怒");
			SetAction(12,"天华_雷音天怒");
			SetAction(13,"灵夙_雷音天怒");
			SetAction(14,"英招_雷音天怒");
			SetAction(15,"武器大师_雷音天怒");
			SetAction(16,"0");
			SetAction(17,"天音寺_雷音天怒");
			SetAction(18,"青云门_骑乘_雷音天怒");
			SetAction(19,"青云门_骑乘_雷音天怒");
			SetAction(20,"鬼王宗_骑乘_雷音天怒");
			SetAction(21,"合欢派_骑乘_雷音天怒");
			SetAction(22,"天音寺_骑乘_雷音天怒");
			SetAction(23,"鬼道_骑乘_雷音天怒");
			SetAction(24,"焚香谷_骑乘_雷音天怒");
			SetAction(25,"兽神_骑乘_雷音天怒");
			SetAction(26,"狐妖_骑乘_雷音天怒");
			SetAction(27,"轩辕_骑乘_雷音天怒");
			SetAction(28,"怀光_骑乘_雷音天怒");
			SetAction(29,"太昊_骑乘_雷音天怒");
			SetAction(30,"天华_骑乘_雷音天怒");
			name = "雷音天怒<禅>";
			nativename = "雷音天怒<禅>";
			icon = "佛·雷音天怒.dds";
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

			return 600000 - 20000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
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

			return (45 * skill_level + 1325);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(30000.0f);
			victim.SetBuffid(9);
			victim.SetAmount(((3000 * skill_level + 3000)));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetBuffid(9);
			victim.SetAmount(((300 * skill_level + 150)));
			victim.SetCycsubdefence(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetBuffid(9);
			victim.SetAmount(((300 * skill_level + 150)));
			victim.SetCycsubattack(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={200,500,500,600,900,1900,3200,4500,8600,10800,20700,32200,51000,65200,84800,159900,260100,427500,743600,1450600};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={1,3,5,7,9,11,14,17,21,25,29,34,39,44,49,55,61,67,73,79};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 3 * skill_level * skill_level + (30 * skill_level) + 180;
		}
	}
	public class GSkill3111 : GSkill
	{
		public GSkill3111()
			: base(3111)
		{
			
		}
	}
	public class GSkill3112Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1400;
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
				return 4000;
			}
			public override void Calculate(GSkill skill)
			{
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 100;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_charging = skill.GetCharging();

				player.SetVar2(1);
				player.SetVar1(skill_charging);
				skill.SetRatio(0.0f);
				skill.SetPlus(0.0f);
				player.SetPerform(1);
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_charging = skill.GetCharging();

				/*
				player.SetVar2(2);
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetRatio(1.0f);
				  }
				  else
				  {
				skill.SetRatio((skill_level * (skill_charging * 0.0005999999999999999f * 0.1f) + 1.0f));
				  }
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetSaint(0);
				  }
				  else
				  {
				skill.SetSaint((skill_level * ((skill_t1 + skill_t0) * (skill_charging * 0.0005f * 0.2f))));
				  }
				player.SetPerform(0);
				*/
			}
		}
		public GSkill3112Stub()
			: base(3112)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 3;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 4;
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
			SetAction(0,"佛_极乐一指");
			SetAction(1,"佛_极乐一指");
			SetAction(2,"佛_极乐一指");
			SetAction(3,"佛_极乐一指");
			SetAction(4,"佛_极乐一指");
			SetAction(5,"佛_极乐一指");
			SetAction(6,"佛_极乐一指");
			SetAction(7,"佛_极乐一指");
			SetAction(8,"佛_极乐一指");
			SetAction(9,"佛_极乐一指");
			SetAction(10,"佛_极乐一指");
			SetAction(11,"佛_极乐一指");
			SetAction(12,"佛_极乐一指");
			SetAction(13,"佛_极乐一指");
			SetAction(14,"佛_极乐一指");
			SetAction(15,"佛_极乐一指");
			SetAction(16,"佛_极乐一指");
			SetAction(17,"佛_极乐一指");
			SetAction(18,"骑乘_佛_极乐一指");
			SetAction(19,"骑乘_佛_极乐一指");
			SetAction(20,"骑乘_佛_极乐一指");
			SetAction(21,"骑乘_佛_极乐一指");
			SetAction(22,"骑乘_佛_极乐一指");
			SetAction(23,"骑乘_佛_极乐一指");
			SetAction(24,"骑乘_佛_极乐一指");
			SetAction(25,"骑乘_佛_极乐一指");
			SetAction(26,"骑乘_佛_极乐一指");
			SetAction(27,"骑乘_佛_极乐一指");
			SetAction(28,"骑乘_佛_极乐一指");
			SetAction(29,"骑乘_佛_极乐一指");
			SetAction(30,"骑乘_佛_极乐一指");
			name = "六字真言";
			nativename = "六字真言";
			icon = "极乐一指.dds";
			SetTalent(0,3105);
			SetTalent(1,3106);
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
			return 6000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 180000 - 4000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,150};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 45.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 21.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 50.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();

			/*
			if ( player_var1 <= 0
			|| (v3 = player, GNET::PlayerWrapper::GetVar1(v3) > 4099) )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			if ( player_var1 <= 3800
			|| (v6 = player, GNET::PlayerWrapper::GetVar2(v6) != 1) )
			{
			v30 = (D2INT(player_var1 * 0.001f) + 1);
			}
			else
			{
			v30 = (D2INT(player_var1 * 0.001f) + 2);
			}
			victim.SetAmount(v30);
			victim.SetClearbuff(true);
			if ( player_var2 == 2 )
			v29 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((6000 * norm(skill_level / 19.9f) + 6000)));
			victim.SetBuffid(2);
			victim.SetAmount((player_maxhp * 0.6f));
			victim.SetValue(((player_maxhp - player_hp)));
			victim.SetSubhp(true);
			*/
			return true;
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={400,500,500,700,1500,3100,3900,6500,10300,16900,21800,43300,49900,81300,84500,197600,340200,435500,998600,1897100};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={2,4,6,8,10,13,16,19,23,27,31,36,41,46,51,57,63,69,75,81};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 4 * skill_level * skill_level + (50 * skill_level) + 190;
		}
	}
	public class GSkill3112 : GSkill
	{
		public GSkill3112()
			: base(3112)
		{
			
		}
	}
	public class GSkill3113Stub : GSkillStub
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

				skill.SetRatio((skill_t3 * 0.05f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.1f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((skill_level * (skill_level * 7.2f)) - skill_level * 6.4f + 694.0f)));
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

				skill.SetRatio((skill_t3 * 0.05f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.1f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((skill_level * (skill_level * 7.2f)) - skill_level * 6.4f + 694.0f)));
				player.SetPerform(0);
			}
		}
		public GSkill3113Stub()
			: base(3113)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
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
			clearmask = 4;
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
			SetAction(16,"0");
			SetAction(17,"0");
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
			name = "雷光遁龙诀<禅>";
			nativename = "雷光遁龙诀<禅>";
			icon = "佛·雷光遁龙诀.dds";
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
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return skill_level + 10;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_iscrit = skill.GetIscrit();

			/*
			victim.SetProbability(((skill_level + 12)));
			victim.SetTime(((8000 * skill_t0 + 8100)));
			victim.SetBuffid(1);
			victim.SetValue(((225 * skill_level)));
			victim.SetSubattack(true);
			if ( skill_iscrit <= 0 )
			v18 = 0.0f;
			else
			victim.SetProbability(100.0f);
			victim.SetTime(((500 * skill_level + 2000)));
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(1);
			victim.SetIncfatalratio(true);
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
			int[] array={6};return array[index];
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={400,500,500,700,1500,3100,3900,6500,9100,10800,20700,26500,39600,52900,84300,119800,229700,389600,525000,1237600};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={2,4,6,8,10,13,16,19,22,25,29,33,37,42,47,53,59,65,71,77};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 4 * skill_level * skill_level + (34 * skill_level) + 200;
		}
	}
	public class GSkill3113 : GSkill
	{
		public GSkill3113()
			: base(3113)
		{
			
		}
	}
	public class GSkill3114Stub : GSkillStub
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
		public GSkill3114Stub()
			: base(3114)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
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
			credittype = 0;
			clearmask = 4;
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
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
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
			name = "天尊法身<禅>";
			nativename = "天尊法身<禅>";
			icon = "佛·天尊法身.dds";
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
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
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
			int				player_res1 = player.GetRes1();
			int				player_res2 = player.GetRes2();
			int				player_res3 = player.GetRes3();
			int				player_res4 = player.GetRes4();
			int				player_res5 = player.GetRes5();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(100.0f);
			victim.SetTime(20100.0f);
			victim.SetRatio(((D2INT((zrand(5 * skill_t2 + 99)) / 100) + 1) * (skill_t2 * 0.01f + (skill_level * 0.01f + 0.011f))));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t0 * 0.3f + 1.0f) * (skill_level * (player_maxhp * 0.01f))));
			victim.SetFashen(true);
			victim.SetTime(((1000 * skill_level + 4100)));
			victim.SetBuffid(2);
			victim.SetValue((skill_level * ((player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) * 0.002f)));
			victim.SetAddanti(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={784};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={400,500,500,700,1500,2400,3500,5600,8500,8600,19000,26500,49100,57600,85800,140300,241000,410600,614500,1344300};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={2,4,6,8,10,12,15,18,21,24,28,33,38,43,48,54,60,66,72,78};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 3 * skill_level * skill_level + (26 * skill_level) + 180;
		}
	}
	public class GSkill3114 : GSkill
	{
		public GSkill3114()
			: base(3114)
		{
			
		}
	}
	public class GSkill3115Stub : GSkillStub
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

				skill.SetRatio((D2INT((player_mp / (0.95f - skill_t2 * 0.1f)) / player_maxmp) * (skill_level * 0.03f + 0.05f) + (skill_t3 * ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f)))));
				skill.SetPlus((((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * ((2 * (skill_level * skill_level + (11 * skill_level)) + 750))));
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

				skill.SetRatio((D2INT((player_mp / (0.95f - skill_t2 * 0.1f)) / player_maxmp) * (skill_level * 0.03f + 0.05f) + (skill_t3 * ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f)))));
				skill.SetPlus((((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * ((2 * (skill_level * skill_level + (11 * skill_level)) + 750))));
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

				skill.SetRatio((D2INT((player_mp / (0.95f - skill_t2 * 0.1f)) / player_maxmp) * (skill_level * 0.03f + 0.05f) + (skill_t3 * ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f)))));
				skill.SetPlus((((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * ((2 * (skill_level * skill_level + (11 * skill_level)) + 750))));
				player.SetPerform(0);
			}
		}
		public GSkill3115Stub()
			: base(3115)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
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
			clearmask = 4;
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
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
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
			name = "太极玄天真诀<禅>";
			nativename = "太极玄天真诀<禅>";
			icon = "佛·太极玄天真诀.dds";
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
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return skill_level + 10;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((3 * skill_t1) + (skill_level * 0.5f + 2.0f)));
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
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			victim.SetBuffid((D2INT((player_mp / (0.95f - skill_t2 * 0.1f)) / player_maxmp)));
			victim.SetUniqprompt(true);
			victim.SetProbability(((4 * skill_level + 15)));
			victim.SetClearslow(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={785};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={200,500,500,600,900,1900,3200,4500,8600,10800,20700,32200,51000,65200,84800,159900,260100,427500,743600,1450600};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={1,3,5,7,9,11,14,17,21,25,29,34,39,44,49,55,61,67,73,79};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 4 * skill_level * skill_level + (34 * skill_level) + 200;
		}
	}
	public class GSkill3115 : GSkill
	{
		public GSkill3115()
			: base(3115)
		{
			
		}
	}
	public class GSkill3116Stub : GSkillStub
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3115) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((3 * skill_level * skill_level + (12 * skill_level) + 800))));
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3115) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((3 * skill_level * skill_level + (12 * skill_level) + 800))));
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3115) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((3 * skill_level * skill_level + (12 * skill_level) + 800))));
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3115) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((3 * skill_level * skill_level + (12 * skill_level) + 800))));
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3115) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((3 * skill_level * skill_level + (12 * skill_level) + 800))));
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3115) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * (((D2INT((zrand(5 * skill_level + 99)) / 100) + 1) * (3 * skill_level * skill_level + (12 * skill_level) + 800)))));
				player.SetPerform(0);
			}
		}
		public GSkill3116Stub()
			: base(3116)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
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
			clearmask = 4;
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
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
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
			name = "神剑御雷真诀<禅>";
			nativename = "神剑御雷真诀<禅>";
			icon = "佛·神剑御雷真诀.dds";
			SetTalent(0,593);
			SetTalent(1,607);
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
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return skill_level + 10;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			if ( zrand(100) >= 2 * skill_level )
			d = 0.0f;
			else
			victim.SetProbability(((10 * skill_level + 550)));
			victim.SetTime(6100.0f);
			victim.SetSilent(true);
			victim.SetProbability(((2 * skill_level + player_var1)));
			victim.SetTime(((500 * skill_t0 + 6100)));
			victim.SetWrap(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetRatio(((2896 * D2INT((zrand(2 * skill_level + 100)) / 100) + 220)));
			victim.SetAmount(220.0f);
			victim.SetValue(220.0f);
			victim.SetClearcooldown(true);
			victim.SetTime(6100.0f);
			victim.SetImmuneweak(true);
			victim.SetProbability(((4 * skill_level + 15)));
			victim.SetRatio((skill_level * 0.002f));
			victim.SetValue(((40 * skill_level)));
			victim.SetScopedamage(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={786};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={200,500,500,600,900,2400,3500,5600,8000,9100,21700,36400,51500,77500,79800,179300,290600,437200,872700,1620700};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={1,3,5,7,9,12,15,18,22,26,30,35,40,45,50,56,62,68,74,80};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 4 * skill_level * skill_level + (34 * skill_level) + 200;
		}
	}
	public class GSkill3116 : GSkill
	{
		public GSkill3116()
			: base(3116)
		{
			
		}
	}
	public class GSkill3117Stub : GSkillStub
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

				skill.SetRatio((skill_t3 * 0.01f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.1f))));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * ((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f)));
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

				skill.SetRatio((skill_t3 * 0.02f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.1f))));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * ((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f)));
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

				skill.SetRatio((skill_t3 * 0.03f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.1f))));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * ((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f)));
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

				skill.SetRatio((skill_t3 * 0.04f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.1f))));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * ((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f)));
				player.SetPerform(0);
			}
		}
		public GSkill3117Stub()
			: base(3117)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 3;
			doenchant = true;
			dobless = false;
			autoattack = true;
			allowform = 0;
			credittype = 0;
			clearmask = 4;
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
			SetAction(0,"鬼王宗_魔魂天咒");
			SetAction(1,"鬼王宗_魔魂天咒");
			SetAction(2,"鬼王宗_魔魂天咒");
			SetAction(3,"鬼王宗_魔魂天咒");
			SetAction(4,"鬼王宗_魔魂天咒");
			SetAction(5,"鬼王宗_魔魂天咒");
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
			SetAction(18,"鬼王宗_骑乘_魔魂天咒");
			SetAction(19,"鬼王宗_骑乘_魔魂天咒");
			SetAction(20,"鬼王宗_骑乘_魔魂天咒");
			SetAction(21,"鬼王宗_骑乘_魔魂天咒");
			SetAction(22,"鬼王宗_骑乘_魔魂天咒");
			SetAction(23,"鬼王宗_骑乘_魔魂天咒");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "魔魂天咒<禅>";
			nativename = "魔魂天咒<禅>";
			icon = "佛·魔魂天咒.dds";
			SetTalent(0,640);
			SetTalent(1,644);
			SetTalent(2,661);
			SetTalent(3,663);
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
			skill_class = 0;
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
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			return (-1350 * skill_t3) - 1350 * skill_t2 + 9000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 4.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (10 * skill_level + 850);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((6 * skill_t0 + 30)));
			victim.SetTime(((3000 * skill_t0 + 11100)));
			victim.SetRatio(((D2INT(zrand(100) / (100 - 6 * skill_t1)) + 1) * (skill_t1 * 0.03f + 0.11f)));
			victim.SetBuffid(3);
			victim.SetTiansha(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((40 * skill_level + 160)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetTime(((500 * skill_level + 3050)));
			victim.SetAmount(((skill_level + 2)));
			victim.SetValue(((56 * skill_level)));
			victim.SetCursed(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={775};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={400,500,500,700,1500,3100,3900,6500,9100,10800,20700,26500,39600,52900,84300,119800,229700,389600,525000,1237600};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={2,4,6,8,10,13,16,19,22,25,29,33,37,42,47,53,59,65,71,77};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 3 * skill_level * skill_level + (42 * skill_level) + 170;
		}
	}
	public class GSkill3117 : GSkill
	{
		public GSkill3117()
			: base(3117)
		{
			
		}
	}
	public class GSkill3118Stub : GSkillStub
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
				int				player_res1 = player.GetRes1();

				player.SetVar2((int)((1000 * player_hp) / player_maxhp));
				player.SetVar1(player_res1);
				player.SetPerform(1);
			}
		}
		public GSkill3118Stub()
			: base(3118)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
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
			clearmask = 4;
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
			SetAction(0,"鬼王宗_狂灵反噬");
			SetAction(1,"鬼王宗_狂灵反噬");
			SetAction(2,"鬼王宗_狂灵反噬");
			SetAction(3,"鬼王宗_狂灵反噬");
			SetAction(4,"鬼王宗_狂灵反噬");
			SetAction(5,"鬼王宗_狂灵反噬");
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
			SetAction(18,"鬼王宗_骑乘_狂灵反噬");
			SetAction(19,"鬼王宗_骑乘_狂灵反噬");
			SetAction(20,"鬼王宗_骑乘_狂灵反噬");
			SetAction(21,"鬼王宗_骑乘_狂灵反噬");
			SetAction(22,"鬼王宗_骑乘_狂灵反噬");
			SetAction(23,"鬼王宗_骑乘_狂灵反噬");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "狂灵反噬<禅>";
			nativename = "狂灵反噬<禅>";
			icon = "佛·狂灵反噬.dds";
			SetTalent(0,647);
			SetTalent(1,662);
			SetTalent(2,666);
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
			skill_class = 0;
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
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
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

			return (20 * skill_level + 660);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			/*
			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_t0 + 20100)));
			victim.SetRatio((norm(skill_level / 19.9f) * 0.3f + (skill_level * 0.05f)));
			victim.SetAmount(0.0f);
			victim.SetValue(((5 * skill_level)));
			victim.SetRetort(true);
			victim.SetTime(((3000 * skill_t2 + 10100)));
			victim.SetImmunesleep(true);
			if ( skill_t0 <= 0 )
			v33 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((60000 * skill_t0)));
			victim.SetBuffid(1);
			victim.SetAmount((skill_t0 * 0.1f + 0.00001f));
			victim.SetValue((player_maxmp * (skill_t0 * 0.06f)));
			victim.SetAddhp2(true);
			victim.SetTime((((3000 * skill_t2 + 10100) * norm(skill_t2))));
			victim.SetImmunedizzy(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(100.0f);
			victim.SetTime(((500 * skill_level + 2000)));
			victim.SetRatio(1.0f);
			victim.SetAmount(skill_level);
			victim.SetValue((player_var1 * 0.5f));
			victim.SetBloodshield(true);
			if ( player_var2 <= 950 )
			{
			v21 = 0.0f;
			}
			else
			{
			v21 = (120 * norm(skill_t0 / 3.9f));
			}
			victim.SetProbability(v21);
			victim.SetRatio(0.0f);
			victim.SetValue(player_maxhp);
			victim.SetHeal(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={776};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={400,500,500,700,1500,2400,3500,5600,8500,8600,19000,26500,49100,57600,85800,140300,241000,410600,614500,1344300};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={2,4,6,8,10,12,15,18,21,24,28,33,38,43,48,54,60,66,72,78};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 3 * skill_level * skill_level + (26 * skill_level) + 180;
		}
	}
	public class GSkill3118 : GSkill
	{
		public GSkill3118()
			: base(3118)
		{
			
		}
	}
	public class GSkill3119Stub : GSkillStub
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
				return 1200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetCrit((skill_t0 * 0.02f));
				skill.SetRatio((skill_t1 * 0.07000000000000001f + 1.0f));
				skill.SetCrithurt((skill_t3 * 0.5f));
				skill.SetPlus(((skill_t3 * 0.3f + 1.0f) * ((100 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill3119Stub()
			: base(3119)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
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
			clearmask = 4;
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
			SetAction(0,"鬼王宗_毁天灭地");
			SetAction(1,"鬼王宗_毁天灭地");
			SetAction(2,"鬼王宗_毁天灭地");
			SetAction(3,"鬼王宗_毁天灭地");
			SetAction(4,"鬼王宗_毁天灭地");
			SetAction(5,"鬼王宗_毁天灭地");
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
			SetAction(18,"鬼王宗_骑乘_毁天灭地");
			SetAction(19,"鬼王宗_骑乘_毁天灭地");
			SetAction(20,"鬼王宗_骑乘_毁天灭地");
			SetAction(21,"鬼王宗_骑乘_毁天灭地");
			SetAction(22,"鬼王宗_骑乘_毁天灭地");
			SetAction(23,"鬼王宗_骑乘_毁天灭地");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "毁天灭地<禅>";
			nativename = "毁天灭地<禅>";
			icon = "佛·毁天灭地.dds";
			SetTalent(0,628);
			SetTalent(1,633);
			SetTalent(2,645);
			SetTalent(3,668);
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
			skill_class = 0;
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
			int				skill_t1 = skill.GetT1();

			return 20000 - 2000 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
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
			return 11.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (15 * skill_level + 950);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 2 * D2INT(skill_level / 4.9f) + 6;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((15 * skill_t0 + 33)));
			victim.SetTime(20100.0f);
			victim.SetAssault(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((D2INT(zrand(100) / (100 - 6 * skill_t2)) + 1) * ((skill_t2 * 0.8f + 1.0f) * ((120 * skill_level)))));
			victim.SetValue(0.0f);
			victim.SetHpleak5(true);
			victim.SetProbability(((5 * skill_level)));
			victim.SetTime(((500 * skill_level + 2050)));
			victim.SetRatio((skill_level * 0.03f));
			victim.SetBuffid(1);
			victim.SetDecdrugeffect(true);
			victim.SetProbability(((3 * skill_level + 10)));
			victim.SetPullback(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={777};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={200,500,500,600,900,1900,3200,4500,8600,10800,20700,32200,51000,65200,84800,159900,260100,427500,743600,1450600};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={1,3,5,7,9,11,14,17,21,25,29,34,39,44,49,55,61,67,73,79};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 4 * skill_level * skill_level + (34 * skill_level) + 200;
		}
	}
	public class GSkill3119 : GSkill
	{
		public GSkill3119()
			: base(3119)
		{
			
		}
	}
}
