using System;
using System.Text;

namespace SKILL
{
	public class GSkill3040Stub : GSkillStub
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
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.02f)));
				  v11 = 10 * skill_t1;
				  if ( skill_t1 <= 0 )
				    v12 = v11;
				  else
				    v12 = v11 + 133;
				  v10 = 21 * skill_t2;
				  if ( skill_t2 <= 0 )
				  {
				skill.SetPlus(((v10 + v12)));
				  }
				  else
				  {
				skill.SetPlus(((v10 + v12 + 324)));
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
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.02f)));
				  v11 = 33 * skill_t3;
				  if ( skill_t3 <= 0 )
				    v12 = v11;
				  else
				    v12 = v11 + 1043;
				  v10 = 32 * skill_t4;
				  if ( skill_t4 <= 0 )
				  {
				skill.SetPlus(((v10 + v12)));
				  }
				  else
				  {
				skill.SetPlus(((v10 + v12 + 1543)));
				  }
				player.SetPerform(0);
				*/
			}
		}
		public GSkill3040Stub()
			: base(3040)
		{
			occupation = 167;
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
			dobless = true;
			autoattack = true;
			allowform = 0;
			credittype = 0;
			clearmask = 1;
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
			name = "÷éÕ½<Ðþ>";
			nativename = "÷éÕ½<Ðþ>";
			icon = "ÏÉ¡¤÷éÕ½.dds";
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
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
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
			v22 = 0.0f;
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
			v21 = 0.0f;
			}
			else
			{
			if ( player_var1 == 1 )
			v20 = 120.0f;
			else
			v21 = 0.0f;
			}
			victim.SetProbability(v21);
			victim.SetTime(((2000 * skill_t0 + 2000)));
			victim.SetRatio((skill_level * 0.04f));
			victim.SetAmount(0.0f);
			victim.SetValue(100.0f);
			victim.SetRetort(true);
			victim.SetTime(((200 * skill_level + 2050)));
			victim.SetImmunedizzy(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1882};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
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

			return 3 * skill_level * skill_level + (42 * skill_level) + 170;
		}
	}
	public class GSkill3040 : GSkill
	{
		public GSkill3040()
			: base(3040)
		{
			
		}
	}
	public class GSkill3041Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1133;
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
				return 100;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_charging = skill.GetCharging();

				/*
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrithurt(0.0f);
				  }
				  else
				  {
				skill.SetCrithurt((skill_level * 0.03f * (skill_charging * 0.0005f)));
				  }
				  if ( skill_charging <= 0xFA )
				    v = 0;
				  else
				    v = skill_charging;
				player.SetVar3(v);
				player.SetVar2(player_res4);
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrit(0.0f);
				  }
				  else
				  {
				skill.SetCrit((skill_level * 0.01f * (skill_charging * 0.0005f)));
				  }
				player.SetVar1(1);
				v20 = skill_t0 * 0.01f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + ((0.05f * skill_level) + 1.02f));
				  if ( skill_charging <= 0xFA )
				  {
				    v19 = v20 + 0.0f;
				  }
				  else
				  {
				v19 = (skill_level * 0.05f + 0.5f) * (skill_charging * 0.0005f) + v20;
				  }
				skill.SetRatio(v19);
				skill.SetPlus(((9 * skill_level + 515)));
				player.SetPerform(1);
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
				return 100;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_charging = skill.GetCharging();

				/*
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrithurt(0.0f);
				  }
				  else
				  {
				skill.SetCrithurt((skill_level * 0.03f * (skill_charging * 0.0005f)));
				  }
				  if ( skill_charging <= 0xFA )
				    v = 0;
				  else
				    v = skill_charging;
				player.SetVar3(v);
				player.SetVar2(player_res4);
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrit(0.0f);
				  }
				  else
				  {
				skill.SetCrit((skill_level * 0.01f * (skill_charging * 0.0005f)));
				  }
				player.SetVar1(2);
				v20 = skill_t0 * 0.01f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + ((0.05f * skill_level) + 1.02f));
				  if ( skill_charging <= 0xFA )
				  {
				    v19 = v20 + 0.0f;
				  }
				  else
				  {
				v19 = (skill_level * 0.05f + 0.5f) * (skill_charging * 0.0005f) + v20;
				  }
				skill.SetRatio(v19);
				skill.SetPlus(((9 * skill_level + 515)));
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
				return 667;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_charging = skill.GetCharging();

				/*
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrithurt(0.0f);
				  }
				  else
				  {
				skill.SetCrithurt((skill_level * 0.03f * (skill_charging * 0.0005f)));
				  }
				player.SetVar2(player_res4);
				  if ( skill_charging <= 0xFA )
				    v = 0;
				  else
				    v = skill_charging;
				player.SetVar3(v);
				  if ( skill_charging <= 0xFA )
				  {
				    v22 = 0.0f;
				  }
				  else
				  {
				v22 = skill_level * 0.01f * (0.0005f * skill_charging);
				  }
				  if ( skill_t1 <= 2.9f )
				    v21 = v22 + 0.0f;
				  else
				skill.SetCrit((v22 + 0.1f));
				player.SetVar1(3);
				v20 = skill_t0 * 0.01f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + ((0.05f * skill_level) + 1.02f));
				  if ( skill_charging <= 0xFA )
				  {
				    v19 = v20 + 0.0f;
				  }
				  else
				  {
				v19 = (skill_level * 0.05f + 0.5f) * (skill_charging * 0.0005f) + v20;
				  }
				skill.SetRatio(v19);
				skill.SetPlus(((9 * skill_level + 515)));
				player.SetPerform(0);
				*/
			}
		}
		public GSkill3041Stub()
			: base(3041)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
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
			clearmask = 1;
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
			SetAction(0,"ºüÑý_ÈýÔÆÁú");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"ºüÑý_ÈýÔÆÁú");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ºüÑý_Æï³Ë_ÈýÔÆÁú");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"ºüÑý_Æï³Ë_ÈýÔÆÁú");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÈýÔÆÁú<Ðþ>";
			nativename = "ÈýÔÆÁú<Ðþ>";
			icon = "ÏÉ¡¤ÈýÔÆÁú.dds";
			SetTalent(0,2142);
			SetTalent(1,2147);
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
			AddState(new GState4());
			AddState(new GState5());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 4000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 12000 - 2000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((3 * norm(skill_level / 19.9f)) + (skill_level * 0.2f + 30.0f));
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((3 * norm(skill_level / 19.9f)) + (skill_level * 0.2f + 20.0f));
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((3 * norm(skill_level / 19.9f)) + (skill_level * 0.2f + 40.0f));
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (16 * skill_level + 985);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				player_var3 = player.GetVar3();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			/*
			if ( player_var1 == 1 )
			{
			if ( skill_t1 <= 0.9f )
			v26 = 0.0f;
			else
			d = 600.0f;
			}
			else
			{
			d = 0.0f;
			}
			victim.SetProbability(d);
			victim.SetTime(5000.0f);
			victim.SetRatio(0.40000001f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			if ( player_var1 == 2 )
			{
			if ( skill_t1 <= 1.9f )
			v24 = 0.0f;
			else
			v25 = 600.0f;
			}
			else
			{
			v25 = 0.0f;
			}
			victim.SetProbability(v25);
			victim.SetTime(5000.0f);
			victim.SetRatio(0.40000001f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetProbability(((2 * skill_level + player_var2)));
			victim.SetTime((player_var3 * 0.0005f * 10.0f * 500.0f + ((300 * skill_level + 2000))));
			victim.SetSilent(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1919};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
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
	public class GSkill3041 : GSkill
	{
		public GSkill3041()
			: base(3041)
		{
			
		}
	}
	public class GSkill3042Stub : GSkillStub
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
		public GSkill3042Stub()
			: base(3042)
		{
			occupation = 167;
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
			clearmask = 1;
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
			SetAction(0,"ºüÑý_´óôàÍõ");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"ºüÑý_´óôàÍõ");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ºüÑý_Æï³Ë_´óôàÍõ");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"ºüÑý_Æï³Ë_´óôàÍõ");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "´óôàÍõ<Ðþ>";
			nativename = "´óôàÍõ<Ðþ>";
			icon = "ÏÉ¡¤´óôàÍõ.dds";
			SetTalent(0,2135);
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

			return 120000 - 20000 * skill_t0;
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

			return (skill_level * skill_level + (16 * skill_level) + 1680);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res5 = player.GetRes5();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 7000)));
			victim.SetRatio((skill_level * 0.03f + 0.25f));
			victim.SetBuffid(1);
			victim.SetIncskillaccu(true);
			victim.SetTime(((1000 * skill_level + 7000)));
			victim.SetRatio((skill_level * 0.02f + 0.001f));
			victim.SetInccritrate(true);
			victim.SetTime(((1000 * skill_level + 7000)));
			victim.SetRatio((skill_level * 0.03f));
			victim.SetBuffid(1);
			victim.SetIncskilldamage(true);
			victim.SetTime(((1000 * skill_level + 7000)));
			victim.SetBuffid(1);
			victim.SetValue((skill_level * (player_res5 * 0.01f)));
			victim.SetAddantisleep(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1920};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
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
	public class GSkill3042 : GSkill
	{
		public GSkill3042()
			: base(3042)
		{
			
		}
	}
	public class GSkill3043Stub : GSkillStub
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
				skill.SetCrithurt((skill_level * 0.03f * (skill_charging * 0.0005f)));
				  }
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrit(0.0f);
				  }
				  else
				  {
				skill.SetCrit((skill_level * 0.01f * (skill_charging * 0.0005f)));
				  }
				v13 = (skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + ((0.05f * skill_level) + 1.02f);
				  if ( skill_charging <= 0xFA )
				  {
				    v12 = v13 + 0.0f;
				  }
				  else
				  {
				v12 = (skill_level * 0.1f + 0.5f) * (skill_charging * 0.0005f) + v13;
				  }
				skill.SetRatio(v12);
				skill.SetPlus(834.0f);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill3043Stub()
			: base(3043)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
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
			clearmask = 1;
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
			SetAction(0,"ºüÑý_ÂÖ»ØÉÁ");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"ºüÑý_ÂÖ»ØÉÁ");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ºüÑý_Æï³Ë_ÂÖ»ØÉÁ");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"ºüÑý_Æï³Ë_ÂÖ»ØÉÁ");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÂÖ»ØÉÁ<Ðþ>";
			nativename = "ÂÖ»ØÉÁ<Ðþ>";
			icon = "ÏÉ¡¤ÂÖ»ØÉÁ.dds";
			SetTalent(0,2153);
			SetTalent(1,2158);
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

			return 40000 - 5000 * skill_t0;
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
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 30.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 20.0f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 40.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			return 866.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();
			int				player_reborncount = player.GetReborncount();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((4 * skill_level + 20)));
			victim.SetTime(((2000 * skill_t1 + 6000)));
			victim.SetBuffid(1);
			victim.SetAmount((((50 * player_reborncount + 50) * player_level)));
			victim.SetValue(((player_maxhp - player_hp)));
			victim.SetSubhp(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((2000 * skill_t1 + 6000)));
			victim.SetBuffid(1);
			victim.SetAmount((((50 * player_reborncount + 50) * player_level)));
			victim.SetValue(((player_maxmp - player_mp)));
			victim.SetSubmp(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * skill_level + 2050)));
			victim.SetRatio((skill_level * 0.02f + 0.2f));
			victim.SetBuffid(2);
			victim.SetCycdecattack(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1921};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
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

			return 3 * skill_level * skill_level + (42 * skill_level) + 170;
		}
	}
	public class GSkill3043 : GSkill
	{
		public GSkill3043()
			: base(3043)
		{
			
		}
	}
	public class GSkill3044Stub : GSkillStub
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
		public GSkill3044Stub()
			: base(3044)
		{
			occupation = 167;
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
			clearmask = 1;
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
			SetAction(0,"ºüÑý_ÁúÐë»¢");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"ºüÑý_ÁúÐë»¢");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ºüÑý_Æï³Ë_ÁúÐë»¢");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"ºüÑý_Æï³Ë_ÁúÐë»¢");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÁúÐë»¢<Ðþ>";
			nativename = "ÁúÐë»¢<Ðþ>";
			icon = "ÏÉ¡¤ÁúÐë»¢.dds";
			SetTalent(0,2169);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 180000;
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

			return (4 * skill_level * skill_level + (14 * skill_level) + 2000);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_t0 + (4000 * skill_level) + 10000)));
			victim.SetRatio(1.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((norm((zrand(2 * skill_level + 100)) / 100) + 2)));
			victim.SetValue(30007.0f);
			victim.SetSummon(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1922};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
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
	public class GSkill3044 : GSkill
	{
		public GSkill3044()
			: base(3044)
		{
			
		}
	}
	public class GSkill3045Stub : GSkillStub
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
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				/*
				player.SetVar2(player.GetHide());
				player.SetVar1(player_res4);
				v16 = (skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + ((0.05f * skill_level) + 1.02f);
				if ( player.GetHide() <= 0 )
				    v15 = v16 + 0.0f;
				  else
				skill.SetRatio((skill_t1 * 0.1f + v16));
				skill.SetPlus(((10 * skill_level + 277)));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill3045Stub()
			: base(3045)
		{
			occupation = 167;
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
			dobless = true;
			autoattack = true;
			allowform = 0;
			credittype = 0;
			clearmask = 1;
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
			weapon_limit = 10;
			SetAction(0,"»³¹â_¹í÷ÈÒ»»÷");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"»³¹â_¹í÷ÈÒ»»÷");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"»³¹â_Æï³Ë_¹í÷ÈÒ»»÷");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_¹í÷ÈÒ»»÷");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÎÞÏë<Ðþ>";
			nativename = "ÎÞÏë<Ðþ>";
			icon = "ÏÉ¡¤ÎÞÏë.dds";
			SetTalent(0,2527);
			SetTalent(1,2528);
			SetTalent(2,2418);
			SetTalent(3,2545);
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
			skill_class = 7;
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

			return (16 * skill_level + 374);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res1 = player.GetRes1();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();

			/*
			if ( player_var2 <= 0 )
			{
			v20 = (2 * skill_level + player_var1);
			}
			else
			{
			v20 = (10 * skill_level + 600);
			}
			victim.SetProbability(v20);
			victim.SetTime(3200.0f);
			victim.SetSilent(true);
			if ( player_var2 <= 0 )
			t = 0.0f;
			else
			victim.SetTime(((1000 * skill_level + 3000)));
			victim.SetAmount(((skill_level + 2)));
			victim.SetValue((skill_level * (player_res1 * 0.05f)));
			victim.SetCursed(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			/*
			if ( skill_t0 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_t0)));
			victim.SetRatio(0.0f);
			victim.SetBuffid(0);
			victim.SetAmount(((15 * skill_t2)));
			victim.SetValue(((30 * skill_t3)));
			victim.SetDimming(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2450};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
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
	public class GSkill3045 : GSkill
	{
		public GSkill3045()
			: base(3045)
		{
			
		}
	}
	public class GSkill3046Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1000;
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
				return 1000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_c0 = skill.GetC0();

				skill.SetCrit((skill_c0 * 0.1f));
				skill.SetRatio((skill_t1 * (skill_c0 * 0.08f) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.05f))));
				skill.SetPlus(((player_res2 * (skill_level + 2)) + (skill_t0 * (player_hp * 0.05f) + ((10 * skill_level + 244)))));
				player.SetHp(((1.0f - skill_t0 * 0.05f) * player_hp));
				player.SetPerform(1);
			}
		}
		public GSkill3046Stub()
			: base(3046)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = false;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 1;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 3;
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
			weapon_limit = 10;
			SetAction(0,"»³¹â_÷Î÷È÷Í÷Ë");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"»³¹â_÷Î÷È÷Í÷Ë");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"»³¹â_Æï³Ë_÷Î÷È÷Í÷Ë");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_÷Î÷È÷Í÷Ë");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÌìÖï<Ðþ>";
			nativename = "ÌìÖï<Ðþ>";
			icon = "ÏÉ¡¤ÌìÖï.dds";
			SetTalent(0,2538);
			SetTalent(1,2539);
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
			skill_class = 7;
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
			return 30000;
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
			return 15.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (5 * skill_level * skill_level + (12 * skill_level) + 1000);
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2451};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
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

			return 4 * skill_level * skill_level + (34 * skill_level) + 200;
		}
	}
	public class GSkill3046 : GSkill
	{
		public GSkill3046()
			: base(3046)
		{
			
		}
	}
	public class GSkill3047Stub : GSkillStub
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
		public GSkill3047Stub()
			: base(3047)
		{
			occupation = 167;
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
			clearmask = 1;
			skill_limit = 1536;
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
			SetAction(0,"»³¹â_Ó°Îè");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"»³¹â_Ó°Îè");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"»³¹â_Æï³Ë_Ó°Îè");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_Ó°Îè");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ò»ÉÁ<Ðþ>";
			nativename = "Ò»ÉÁ<Ðþ>";
			icon = "ÏÉ¡¤Ò»ÉÁ.dds";
			SetTalent(0,2549);
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
			skill_class = 7;
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

			return 120000 - 2000 * skill_level;
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

			return (3 * skill_level * skill_level + 650);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 10000)));
			victim.SetRatio(0.0f);
			victim.SetAmount(skill_level);
			victim.SetValue(0.0f);
			victim.SetShadowdance(true);
			if ( skill_t0 <= 0 )
			t = 100.0f;
			else
			victim.SetTime(((1000 * skill_level + 10000)));
			victim.SetRatio((skill_t0 * 0.1f));
			victim.SetBuffid(0);
			victim.SetIncskilldamage(true);
			victim.SetProbability(120.0f);
			victim.SetTime(60000.0f);
			victim.SetRatio(2446.0f);
			victim.SetAmount(2437.0f);
			victim.SetValue(2428.0f);
			victim.SetSetcooldown(true);
			victim.SetProbability(120.0f);
			victim.SetTime(120000.0f);
			victim.SetRatio(2452.0f);
			victim.SetAmount(2452.0f);
			victim.SetValue(2452.0f);
			victim.SetSetcooldown(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res2 = player.GetRes2();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(120.0f);
			victim.SetRatio(4141.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetDispel(true);
			victim.SetTime(((1000 * skill_level + 10000)));
			victim.SetBuffid(2);
			victim.SetValue((skill_level * (player_res2 * 0.005f)));
			victim.SetAddantiweak(true);
			if ( skill_level <= 19 )
			t = 0.0f;
			else
			victim.SetTime(((1000 * skill_level + 10000)));
			victim.SetRatio(0.050000001f);
			victim.SetBuffid(2);
			victim.SetIncanti(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2452};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
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

			return 3 * skill_level * skill_level + (26 * skill_level) + 180;
		}
	}
	public class GSkill3047 : GSkill
	{
		public GSkill3047()
			: base(3047)
		{
			
		}
	}
	public class GSkill3048Stub : GSkillStub
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
		public GSkill3048Stub()
			: base(3048)
		{
			occupation = 167;
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
			clearmask = 1;
			skill_limit = 1536;
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
			SetAction(0,"»³¹â_ËÀÉñÖ®Ó°");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"»³¹â_ËÀÉñÖ®Ó°");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"»³¹â_Æï³Ë_ËÀÉñÖ®Ó°");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_ËÀÉñÖ®Ó°");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ó°Îè¡¤¼«<Ðþ>";
			nativename = "Ó°Îè¡¤¼«<Ðþ>";
			icon = "ÏÉ¡¤Ó°Îè¡¤¼«.dds";
			SetTalent(0,2566);
			SetTalent(1,2562);
			SetTalent(2,2564);
			SetTalent(3,2567);
			SetTalent(4,2568);
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
			skill_class = 7;
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
			return 180000;
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

			return (4 * skill_level * skill_level + 1500);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_def = player.GetDef();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetTime(((5000 * skill_t0 + (1000 * skill_level) + 10000)));
			victim.SetRatio(3.0f);
			victim.SetBuffid(0);
			victim.SetAmount(1.0f);
			victim.SetValue(34670.0f);
			victim.SetSummonclone(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((500 * skill_level + 5050)));
			victim.SetRatio(1.0f);
			victim.SetAmount(((skill_level + 2)));
			victim.SetValue(((player_def * skill_level) * 0.005f));
			victim.SetBloodshield(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2453};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
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
	public class GSkill3048 : GSkill
	{
		public GSkill3048()
			: base(3048)
		{
			
		}
	}
	public class GSkill3049Stub : GSkillStub
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
				int				player_res2 = player.GetRes2();
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_j0 = skill.GetJ0();
				int				skill_j1 = skill.GetJ1();
				int				skill_j2 = skill.GetJ2();

				skill.SetCrit((skill_j1 * (skill_level * 0.003f) + (skill_j1 * 0.02f + (skill_t0 * 0.02f))));
				skill.SetCrithurt((skill_level * (player_res4 * 0.00002f) + (skill_j2 * 0.1f)));
				skill.SetRatio((skill_j0 * 0.03f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.05f))));
				skill.SetPlus((skill_j0 * ((skill_level * 0.2f + 2.0f) * player_res2) + ((13 * skill_level) + (skill_level * (skill_level * 0.07099999999999999f)) + 1027.0f)));
				player.SetPerform(1);
			}
		}
		public GSkill3049Stub()
			: base(3049)
		{
			occupation = 167;
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
			clearmask = 1;
			skill_limit = 0;
			skillelemsnum = 3;
			skillelemsfactor = 1.300000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 1;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = 12;
			SetAction(0,"Ìì»ª_¹Ú¹ÅÔÏíà");
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
			SetAction(12,"Ìì»ª_¹Ú¹ÅÔÏíà");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ìì»ª_Æï³Ë_¹Ú¹ÅÔÏíà");
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
			SetAction(30,"Ìì»ª_Æï³Ë_¹Ú¹ÅÔÏíà");
			name = "ÉñÒý£ºÑô¹ØÈýµþ<Ðþ>";
			nativename = "ÉñÒý£ºÑô¹ØÈýµþ<Ðþ>";
			icon = "ÏÉ¡¤ÉñÒý£ºÑô¹ØÈýµþ.dds";
			SetTalent(0,2610);
			SetTalent(1,2605);
			SetTalent(2,2606);
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
			skill_class = 8;
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

			return 10000 - 1000 * skill_t2;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return (skill_t1 + 20);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return (skill_t1 + 15);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return (skill_t1 + 25);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((skill_level * (skill_level * 1.5f)) - skill_level * 3.8f + 897.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((2 * (skill_level + (5 * norm(skill_level / 19.9f))) + 20)));
			victim.SetRatio(7.0f);
			victim.SetAmount(67.0f);
			victim.SetValue(65.0f);
			victim.SetDispel(true);
			victim.SetProbability(-1.0f);
			victim.SetRatio(74.0f);
			victim.SetAmount(9.0f);
			victim.SetValue(67.0f);
			victim.SetDispel(true);
			return true;
		}
		public override int GetSkillElem(int index)
		{
			int[] array={2916,2917,2918};return array[index-1];
		}
		public override int GetComboSkillCapacity(int level)
		{
			int[] array={1,1,1,2,2,2,2,3,3,3,3,4,4,4,4,5,5,5,5,6};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2498};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
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
	public class GSkill3049 : GSkill
	{
		public GSkill3049()
			: base(3049)
		{
			
		}
	}
}
