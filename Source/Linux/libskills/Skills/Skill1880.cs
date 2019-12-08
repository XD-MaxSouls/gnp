using System;
using System.Text;

namespace SKILL
{
	public class GSkill1880Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 350;
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

				/*
				player.SetVar1(1);
				player.SetVar2(player_level);
				skill.SetRatio((skill_t1 * 0.01f + ((skill_t0 + skill_level) * 0.02f + 1.02f)));
				  if ( skill_t1 <= 0 )
				  {
				    skill.SetPlus(0.0f);
				  }
				  else
				  {
				skill.SetPlus(((10 * skill_t1 + 133)));
				  }
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
				return 225;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();

				/*
				player.SetVar1(2);
				player.SetVar2(player_level);
				skill.SetRatio((skill_t2 * 0.01f + ((skill_t0 + skill_level) * 0.02f + 1.02f)));
				  if ( skill_t2 <= 0 )
				  {
				    skill.SetPlus(0.0f);
				  }
				  else
				  {
				skill.SetPlus(((21 * skill_t2 + 324)));
				  }
				player.SetPerform(0);
				*/
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t3 = skill.GetT3();

				/*
				player.SetVar1(3);
				player.SetVar2(player_level);
				skill.SetRatio((skill_t3 * 0.01f + ((skill_t0 + skill_level) * 0.02f + 1.02f)));
				  if ( skill_t3 <= 0 )
				  {
				    skill.SetPlus(0.0f);
				  }
				  else
				  {
				skill.SetPlus(((33 * skill_t3 + 1043)));
				  }
				player.SetPerform(0);
				*/
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
				return 525;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t4 = skill.GetT4();

				/*
				player.SetVar1(4);
				player.SetVar2(player_level);
				skill.SetRatio((skill_t4 * 0.01f + ((skill_t0 + skill_level) * 0.02f + 1.02f)));
				  if ( skill_t4 <= 0 )
				  {
				    skill.SetPlus(0.0f);
				  }
				  else
				  {
				skill.SetPlus(((32 * skill_t4 + 1543)));
				  }
				player.SetPerform(0);
				*/
			}
		}
		public GSkill1880Stub()
			: base(1880)
		{
			occupation = 37;
			maxlevel = 6;
			maxlearn = 5;
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
			weapon_limit = 7;
			SetAction(0,"ÊÞÉñ_°ËëÅ");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"ÊÞÉñ_°ËëÅ");
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
			SetAction(18,"ÊÞÉñ_Æï³Ë_°ËëÅ");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_°ËëÅ");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "°ËëÅ";
			nativename = "°ËëÅ";
			icon = "°ËëÅ.dds";
			SetTalent(0,2084);
			SetTalent(1,1847);
			SetTalent(2,1856);
			SetTalent(3,1865);
			SetTalent(4,1874);
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
			skill_class = 5;
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

			return (int)(((((-1000 * skill_t0) - 1000 * (skill_t1 / 8.99f)) - 1000 * (skill_t2 / 8.99f)) - 1000 * (skill_t3 / 8.99f)) - 1000 * (skill_t4 / 8.99f) + 9600);
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={136,137,138,139,140};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (8 * skill_level + 458);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

			/*
			if ( player_var1 == 1 )
			{
			if ( skill_t1 <= 0 )
			v42 = 0.0f;
			else
			d = 600.0f;
			}
			else
			{
			d = 0.0f;
			}
			victim.SetProbability(d);
			victim.SetTime(4000.0f);
			victim.SetRatio((skill_t1 * 0.05f + 0.15f));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			if ( player_var1 == 2 )
			{
			if ( skill_t2 <= 0 )
			{
			v40 = 0.0f;
			}
			else
			{
			v40 = (skill_t2 * player_var2 / 9 + player_var2);
			}
			v41 = v40;
			}
			else
			{
			v41 = 0.0f;
			}
			victim.SetProbability(v41);
			victim.SetTime(4000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			if ( player_var1 == 3 )
			{
			if ( skill_t3 <= 0 )
			{
			v38 = 0.0f;
			}
			else
			{
			v38 = (skill_t3 * player_var2 / 9 + player_var2);
			}
			v39 = v38;
			}
			else
			{
			v39 = 0.0f;
			}
			victim.SetProbability(v39);
			victim.SetTime(4000.0f);
			victim.SetWrap(true);
			if ( player_var1 == 4 )
			{
			if ( skill_t4 <= 0 )
			{
			v36 = 0.0f;
			}
			else
			{
			v36 = (skill_t4 * player_var2 / 9 + player_var2);
			}
			v37 = v36;
			}
			else
			{
			v37 = 0.0f;
			}
			victim.SetProbability(v37);
			victim.SetTime(4000.0f);
			victim.SetDizzy(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_t0 = skill.GetT0();

			/*
			if ( player_var1 <= 1 )
			d = 0.0f;
			else
			victim.SetProbability(((10 * skill_t0)));
			victim.SetAmount(1.0f);
			victim.SetCleardebuff(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1879};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1880 : GSkill
	{
		public GSkill1880()
			: base(1880)
		{
			
		}
	}
	public class GSkill1881Stub : GSkillStub
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
		public GSkill1881Stub()
			: base(1881)
		{
			occupation = 37;
			maxlevel = 3;
			maxlearn = 2;
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
			SetAction(0,"ÊÞÉñ_ò¿»ê");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"ÊÞÉñ_ò¿»ê");
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
			SetAction(18,"ÊÞÉñ_Æï³Ë_ò¿»ê");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ò¿»ê");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ò¿»ê";
			nativename = "ò¿»ê";
			icon = "ò¿»ê.dds";
			SetTalent(0,2101);
			SetTalent(1,2947);
			SetTalent(2,4112);
			SetTalent(3,4530);
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
			skill_class = 5;
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

			return 180000 - 20000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={140,141};return array[level-1];
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
			return 900.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((12000 * skill_level + 12000)));
			victim.SetBuffid(1);
			v25 = 0.05f * skill_level;
			if ( skill_t1 < skill_t2 )
			{
			if ( skill_t2 < skill_t3 )
			v22 = skill_t3 * 0.012f + v25;
			else
			v24 = (skill_t2 * 0.012f + v25);
			}
			else
			{
			if ( skill_t1 < skill_t3 )
			v23 = skill_t3 * 0.012f + v25;
			else
			v24 = (skill_t1 * 0.012f + v25);
			}
			victim.SetAmount(v24);
			v21 = 0.05f * skill_level;
			if ( skill_t1 < skill_t2 )
			{
			if ( skill_t2 < skill_t3 )
			v18 = skill_t3 * 0.012f + v21;
			else
			v20 = (skill_t2 * 0.012f + v21);
			}
			else
			{
			if ( skill_t1 < skill_t3 )
			v19 = skill_t3 * 0.012f + v21;
			else
			v20 = (skill_t1 * 0.012f + v21);
			}
			victim.SetValue(v20);
			victim.SetChihun(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1879};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1881 : GSkill
	{
		public GSkill1881()
			: base(1881)
		{
			
		}
	}
	public class GSkill1882Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 725;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(1);
				skill.SetRatio(0.0f);
				skill.SetPlus(0.0f);
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
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				/*
				player.SetVar1(2);
				skill.SetRatio((skill_level * 0.02f + 1.02f));
				  v8 = 10 * skill_t1;
				  if ( skill_t1 <= 0 )
				    v9 = v8;
				  else
				    v9 = v8 + 133;
				  v7 = 21 * skill_t2;
				  if ( skill_t2 <= 0 )
				  {
				skill.SetPlus(((v7 + v9)));
				  }
				  else
				  {
				skill.SetPlus(((v7 + v9 + 324)));
				  }
				player.SetPerform(0);
				*/
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
				return 875;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();

				/*
				player.SetVar1(3);
				skill.SetRatio((skill_level * 0.02f + 1.02f));
				  v8 = 33 * skill_t3;
				  if ( skill_t3 <= 0 )
				    v9 = v8;
				  else
				    v9 = v8 + 1043;
				  v7 = 32 * skill_t4;
				  if ( skill_t4 <= 0 )
				  {
				skill.SetPlus(((v7 + v9)));
				  }
				  else
				  {
				skill.SetPlus(((v7 + v9 + 1543)));
				  }
				player.SetPerform(0);
				*/
			}
		}
		public GSkill1882Stub()
			: base(1882)
		{
			occupation = 37;
			maxlevel = 6;
			maxlearn = 5;
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
			weapon_limit = 7;
			SetAction(0,"ÊÞÉñ_÷éÕ½");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"ÊÞÉñ_÷éÕ½");
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
			SetAction(18,"ÊÞÉñ_Æï³Ë_÷éÕ½");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_÷éÕ½");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "÷éÕ½";
			nativename = "÷éÕ½";
			icon = "öÇÕ½.dds";
			SetTalent(0,2118);
			SetTalent(1,1850);
			SetTalent(2,1859);
			SetTalent(3,1868);
			SetTalent(4,1877);
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
			skill_class = 5;
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
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

			return (int)(((((-1000 * skill_t0) - 1000 * (skill_t1 / 8.99f)) - 1000 * (skill_t2 / 8.99f)) - 1000 * (skill_t3 / 8.99f)) - 1000 * (skill_t4 / 8.99f) + 12000);
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={136,137,138,139,140};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 3.000000f;
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

			return (16 * skill_level + 877);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

			/*
			if ( player_var1 == 2 )
			{
			if ( skill_t1 <= 0 )
			v37 = 0.0f;
			else
			d = 600.0f;
			}
			else
			{
			d = 0.0f;
			}
			victim.SetProbability(d);
			if ( zrand(100) >= 5 * skill_t1 + 15 )
			t = 400.0f;
			else
			victim.SetTime(4000.0f);
			victim.SetSilent(true);
			if ( player_var1 == 2 )
			{
			if ( skill_t2 <= 0 )
			v34 = 0.0f;
			else
			v35 = 120.0f;
			}
			else
			{
			v35 = 0.0f;
			}
			victim.SetProbability(v35);
			victim.SetTime(8000.0f);
			victim.SetBuffid(1);
			victim.SetValue(((2 * (skill_t2 * skill_t2 + (5 * skill_t2)) + 60)));
			victim.SetSubdefence(true);
			if ( player_var1 == 3 )
			{
			if ( skill_t3 <= 0 )
			v32 = 0.0f;
			else
			v33 = 120.0f;
			}
			else
			{
			v33 = 0.0f;
			}
			victim.SetProbability(v33);
			victim.SetTime(8000.0f);
			victim.SetBuffid(1);
			if ( player_var1 == 3 )
			{
			if ( skill_t3 <= 0 )
			v30 = 0.0f;
			else
			v31 = ((5 * skill_t3 + 35));
			}
			else
			{
			v31 = 0.0f;
			}
			victim.SetValue(v31);
			victim.SetSubanti(true);
			if ( player_var1 == 3 )
			{
			if ( skill_t4 <= 0 )
			v28 = 0.0f;
			else
			v29 = ((5 * skill_t4 + 35));
			}
			else
			{
			v29 = 0.0f;
			}
			victim.SetProbability(v29);
			victim.SetTime(8000.0f);
			victim.SetBarehanded(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetTime(3000.0f);
			if ( player_var1 == 1 )
			{
			if ( zrand(100) >= 34 * skill_t0 )
			v19 = 0.0f;
			else
			d = 1.0f;
			}
			else
			{
			d = 0.0f;
			}
			victim.SetValue(d);
			victim.SetBlessed(true);
			if ( skill_t0 <= 0 )
			{
			v18 = 0.0f;
			}
			else
			{
			if ( player_var1 == 1 )
			v17 = 120.0f;
			else
			v18 = 0.0f;
			}
			victim.SetProbability(v18);
			victim.SetTime(((2000 * skill_t0 + 2000)));
			victim.SetRatio((skill_level * 0.1f));
			victim.SetAmount(0.0f);
			victim.SetValue(100.0f);
			victim.SetRetort(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1879};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1882 : GSkill
	{
		public GSkill1882()
			: base(1882)
		{
			
		}
	}
	public class GSkill1883Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 667;
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
				return 333;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_charging = skill.GetCharging();

				/*
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrit(0.0f);
				  }
				  else
				  {
				skill.SetCrit((skill_level * 0.01f * (skill_charging * 0.0005f)));
				  }
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrithurt(0.0f);
				  }
				  else
				  {
				skill.SetCrithurt((skill_level * 0.05f * (skill_charging * 0.0005f)));
				  }
				  v15 = (0.01f * skill_t0) + 1.0f;
				  if ( skill_charging <= 0xFA )
				  {
				    v14 = v15 + 0.0f;
				  }
				  else
				  {
				v14 = (skill_level * 0.05f + 0.5f) * (skill_charging * 0.0005f) + v15;
				  }
				skill.SetRatio(v14);
				skill.SetPlus((((20 * skill_level + 50) * norm(30 / player_level) + (2 * skill_level) + 12)));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill1883Stub()
			: base(1883)
		{
			occupation = 39;
			maxlevel = 20;
			maxlearn = 6;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 3;
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
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = 8;
			SetAction(0,"ºüÑý_·çÃùÊ¸");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"ºüÑý_·çÃùÊ¸");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ºüÑý_Æï³Ë_·çÃùÊ¸");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"ºüÑý_Æï³Ë_·çÃùÊ¸");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "·çÃùÊ¸";
			nativename = "·çÃùÊ¸";
			icon = "·çÃùÊ¸.dds";
			SetTalent(0,2142);
			SetTalent(1,2143);
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
			skill_class = 6;
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
			int				skill_t1 = skill.GetT1();

			return 4000 - 1000 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={1,3,5,7,9,11};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 40.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 10.000000f;
		}
	}
	public class GSkill1883 : GSkill
	{
		public GSkill1883()
			: base(1883)
		{
			
		}
	}
	public class GSkill1884Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 667;
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
				return 333;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_charging = skill.GetCharging();

				/*
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrithurt(0.0f);
				  }
				  else
				  {
				skill.SetCrithurt((skill_level * 0.05f * (skill_charging * 0.0005f)));
				  }
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrit(0.0f);
				  }
				  else
				  {
				skill.SetCrit((skill_level * 0.01f * (skill_charging * 0.0005f)));
				  }
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetRatio(1.0f);
				  }
				  else
				  {
				skill.SetRatio(((skill_level * 0.05f + 0.5f) * (skill_charging * 0.0005f) + 1.0f));
				  }
				skill.SetPlus(((8 * skill_level + 60)));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill1884Stub()
			: base(1884)
		{
			occupation = 39;
			maxlevel = 20;
			maxlearn = 8;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 3;
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
			weapon_limit = 8;
			SetAction(0,"ºüÑý_ÀÇÑÀÊ¸");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"ºüÑý_ÀÇÑÀÊ¸");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ºüÑý_Æï³Ë_ÀÇÑÀÊ¸");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"ºüÑý_Æï³Ë_ÀÇÑÀÊ¸");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÀÇÑÀÊ¸";
			nativename = "ÀÇÑÀÊ¸";
			icon = "ÀÇÑÀÊ¸.dds";
			SetTalent(0,2153);
			SetTalent(1,2154);
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
			skill_class = 6;
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
			int				skill_t0 = skill.GetT0();

			return 6000 - 1000 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={20,22,24,26,28,30,32,34};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 40.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_t1 + 6000)));
			victim.SetBuffid(1);
			victim.SetAmount((((3 * skill_level + 40) * (skill_t1 + 3))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2188};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1884 : GSkill
	{
		public GSkill1884()
			: base(1884)
		{
			
		}
	}
	public class GSkill1885Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 667;
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
				return 333;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_charging = skill.GetCharging();

				/*
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrithurt(0.0f);
				  }
				  else
				  {
				skill.SetCrithurt((skill_level * 0.05f * (skill_charging * 0.0005f)));
				  }
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrit(0.0f);
				  }
				  else
				  {
				skill.SetCrit((skill_level * 0.01f * (skill_charging * 0.0005f)));
				  }
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetRatio(1.0f);
				  }
				  else
				  {
				skill.SetRatio(((skill_level * 0.05f + 0.5f) * (skill_charging * 0.0005f) + 1.0f));
				  }
				skill.SetPlus(((5 * skill_level + 47)));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill1885Stub()
			: base(1885)
		{
			occupation = 39;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 3;
			targettype = 0;
			rangetype = 3;
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
			weapon_limit = 8;
			SetAction(0,"ºüÑý_ÐÇÃ¢»÷");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"ºüÑý_ÐÇÃ¢»÷");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ºüÑý_Æï³Ë_ÐÇÃ¢»÷");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"ºüÑý_Æï³Ë_ÐÇÃ¢»÷");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÐÇÃ¢»÷";
			nativename = "ÐÇÃ¢»÷";
			icon = "ÐÇÃ¢»÷.dds";
			SetTalent(0,2148);
			SetTalent(1,2152);
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
			skill_class = 6;
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
			int				skill_t1 = skill.GetT1();

			return 6000 - 1000 * skill_t1;
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
			int				skill_t0 = skill.GetT0();

			return (skill_t0 * 0.5f + 5.0f);
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 40.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 30.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 2/*xxxx*/;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1884};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill1885 : GSkill
	{
		public GSkill1885()
			: base(1885)
		{
			
		}
	}
	public class GSkill1886Stub : GSkillStub
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
				int				player_res3 = player.GetRes3();

				player.SetVar1(player_res3);
				player.SetPerform(1);
			}
		}
		public GSkill1886Stub()
			: base(1886)
		{
			occupation = 39;
			maxlevel = 5;
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
			SetAction(0,"ºüÑý_·çÐÐÕß");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"ºüÑý_·çÐÐÕß");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ºüÑý_Æï³Ë_·çÐÐÕß");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"ºüÑý_Æï³Ë_·çÐÐÕß");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "·çÐÐÕß";
			nativename = "·çÐÐÕß";
			icon = "·çÐÐÕß.dds";
			SetTalent(0,2131);
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
			skill_class = 6;
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

			return 60000 - 12000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={15,23,31};return array[level-1];
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
			return 75.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetTime(((6000 * skill_level + 6000)));
			victim.SetBuffid(1);
			victim.SetValue(((skill_level + 1)));
			victim.SetAddspeed(true);
			victim.SetProbability(((25 * skill_level)));
			victim.SetClearwrap(true);
			victim.SetTime(((12000 * norm(skill_t0))));
			victim.SetBuffid(1);
			victim.SetValue((skill_t0 * (player_var1 * 0.02f)));
			victim.SetAddantiwrap(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2186};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1886 : GSkill
	{
		public GSkill1886()
			: base(1886)
		{
			
		}
	}
	public class GSkill1887Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill1887Stub()
			: base(1887)
		{
			occupation = 39;
			maxlevel = 12;
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
			SetAction(0,"ºüÑý_Â¾Ðë×Ó");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"ºüÑý_Â¾Ðë×Ó");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ºüÑý_Æï³Ë_Â¾Ðë×Ó");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"ºüÑý_Æï³Ë_Â¾Ðë×Ó");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Â¾Ðë×Ó";
			nativename = "Â¾Ðë×Ó";
			icon = "Â¾Ðë×Ó.dds";
			SetTalent(0,2125);
			SetTalent(1,2130);
			SetTalent(2,2126);
			SetTalent(3,2230);
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
			skill_class = 6;
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
			int				skill_t3 = skill.GetT3();

			return 60000 - 5000 * skill_t3;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={25,27,29,31,33,35,37,39,41};return array[level-1];
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
			return 125.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetTime(((10000 * skill_t0 + 40000)));
			victim.SetRatio(2.0f);
			victim.SetBuffid(1);
			victim.SetAmount(1.0f);
			victim.SetValue(30008.0f);
			victim.SetSummon(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1886};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1887 : GSkill
	{
		public GSkill1887()
			: base(1887)
		{
			
		}
	}
	public class GSkill1888Stub : GSkillStub
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
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_maxatk);
				player.SetPerform(1);
			}
		}
		public GSkill1888Stub()
			: base(1888)
		{
			occupation = 39;
			maxlevel = 10;
			maxlearn = 5;
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
			SetAction(0,"ºüÑý_¶¾Ñ×Öä");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"ºüÑý_¶¾Ñ×Öä");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ºüÑý_Æï³Ë_¶¾Ñ×Öä");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"ºüÑý_Æï³Ë_¶¾Ñ×Öä");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¶¾Ñ×Öä";
			nativename = "¶¾Ñ×Öä";
			icon = "¶¾Ñ×Öä.dds";
			SetTalent(0,2136);
			SetTalent(1,2137);
			SetTalent(2,2141);
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
			skill_class = 6;
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

			return 12000 - 2000 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={35,40,45,50,55};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();

			return (skill_t2 + 17);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();

			return (skill_t2 + 10);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();

			return (skill_t2 + 22);
		}
		public override float GetMpcost(GSkill skill)
		{
			return 175.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			/*
			v48 = 1.0f - player_level * 0.002f;
			if ( player.GetObjectType() )
			v47 = 100.0f * v48;
			else
			victim.SetProbability((0.0f * v48));
			victim.SetTime(10000.0f);
			victim.SetBuffid(1);
			if ( player_var1 * 0.5f <= (player_hp * (skill_level * 0.01f)) )
			{
			v46 = 5.0f * (0.5f * player_var1);
			}
			else
			{
			v46 = 5.0f * (player_hp * (0.01f * skill_level));
			}
			victim.SetAmount(v46);
			if ( zrand(100) >= 10 * skill_t1 )
			{
			v45 = 0.0f;
			}
			else
			{
			v45 = player_maxhp * 0.1f;
			}
			victim.SetValue(v45);
			victim.SetHpleak(true);
			v44 = 1.0f - player_level * 0.002f;
			if ( player.GetObjectType() )
			v43 = 0.0f * v44;
			else
			victim.SetProbability((100.0f * v44));
			victim.SetTime(10000.0f);
			victim.SetBuffid(1);
			if ( player_var1 <= (player_hp * (skill_level * 0.02f)) )
			{
			v42 = 5.0f * player_var1;
			}
			else
			{
			v42 = 5.0f * (player_hp * (0.02f * skill_level));
			}
			victim.SetAmount(v42);
			if ( zrand(100) >= 10 * skill_t1 )
			{
			v41 = 0.0f;
			}
			else
			{
			v41 = player_maxhp * 0.1f;
			}
			victim.SetValue(v41);
			victim.SetHpleak(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1887};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill1888 : GSkill
	{
		public GSkill1888()
			: base(1888)
		{
			
		}
	}
	public class GSkill1889Stub : GSkillStub
	{
		public GSkill1889Stub()
			: base(1889)
		{
			occupation = 39;
			maxlevel = 5;
			maxlearn = 3;
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
			SetAction(0,"");
			SetAction(1,"");
			SetAction(2,"");
			SetAction(3,"");
			SetAction(4,"");
			SetAction(5,"");
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
			SetAction(18,"");
			SetAction(19,"");
			SetAction(20,"");
			SetAction(21,"");
			SetAction(22,"");
			SetAction(23,"");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ë¸¿Õ¾¢";
			nativename = "Ë¸¿Õ¾¢";
			icon = "Ë¸¿Õ¾¢.dds";
			SetTalent(0,2159);
			SetTalent(1,2164);
			SetTalent(2,2160);
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
			skill_class = 6;
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
			int[] array={15,23,31};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			player.SetPasaddanti(((skill_level * skill_t1)));
			player.SetPasaddattack(((5 * skill_level * skill_t0) + (player_level * (skill_level * 0.3f))));
			player.SetPasaddsmite((skill_level * (skill_t1 * 0.03f)));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2187};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1889 : GSkill
	{
		public GSkill1889()
			: base(1889)
		{
			
		}
	}
}
