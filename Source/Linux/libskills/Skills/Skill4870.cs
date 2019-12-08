using System;
using System.Text;

namespace SKILL
{
	public class GSkill4870Stub : GSkillStub
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
		public GSkill4870Stub()
			: base(4870)
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
			SetAction(0,"Ó¢ÕÐ_¹¥»÷Ê½Ç¿»¯");
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
			SetAction(14,"Ó¢ÕÐ_¹¥»÷Ê½Ç¿»¯");
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
			name = "ÉýÁúÕ½·¨";
			nativename = "ÉýÁúÕ½·¨";
			icon = "ÉýÁúÕ½·¨.dds";
			SetTalent(0,5211);
			SetTalent(1,5212);
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
			victim.SetAddrage2(true);
			victim.SetProbability(120.0f);
			victim.SetRatio(4273.0f);
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
	public class GSkill4870 : GSkill
	{
		public GSkill4870()
			: base(4870)
		{
			
		}
	}
	public class GSkill4871Stub : GSkillStub
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

				player.SetVar1((player.GetHasbuff(4268) != 0)?1:0);
				player.SetPerform(1);
			}
		}
		public GSkill4871Stub()
			: base(4871)
		{
			occupation = 111;
			maxlevel = 7;
			maxlearn = 6;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 1;
			targettype = 0;
			rangetype = 5;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
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
			SetAction(13,"0");
			SetAction(14,"0");
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
			name = "÷è÷ë»¯Éí";
			nativename = "÷è÷ë»¯Éí";
			icon = "÷è÷ë»¯Éí.dds";
			SetTalent(0,5208);
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
			return 60000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={110,112,114,116,118,120};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 15.000000f;
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
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(120.0f);
			victim.SetValue((skill_level * 0.5f));
			victim.SetQilinform(true);
			if ( skill_t0 <= 0 || (v6 = player, GNET::PlayerWrapper::GetVar1(v6)) )
			v25 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetAmount(skill_t0);
			victim.SetCleardebuff(true);
			victim.SetProbability(120.0f);
			victim.SetRatio(4127.0f);
			victim.SetAmount(4102.0f);
			victim.SetValue(0.0f);
			victim.SetDispel(true);
			if ( player_var1 )
			v24 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(200.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(1);
			victim.SetValue(5324.0f);
			victim.SetDelaycast(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(60000.0f);
			victim.SetRatio(5325.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetSetcooldown(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4868};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill4871 : GSkill
	{
		public GSkill4871()
			: base(4871)
		{
			
		}
	}
	public class GSkill4872Stub : GSkillStub
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

				/*
				if ( player.GetCultivation() == 1 )
				  {
				v29 = player.GetSkilllevel(5251) * 0.1f;
				  }
				  else
				  {
				    v29 = 0.0f;
				  }
				if ( player.GetHasbuff(4273) )
				  {
				v28 = (player.GetSkilllevel(4851) * (player_rage * 0.01f));
				  }
				  else
				  {
				    v28 = 0;
				  }
				skill.SetPlus(((80 * skill_level + 480) + v28 * v29));
				skill.SetPlus2((v28 * (1.0f - v29)));
				if ( player.GetCultivation() == 1 )
				  {
				skill.SetRatio((player.GetSkilllevel(5255) * 0.05f + 1.0f));
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
				player.SetVar1(player_maxhp);
				if ( player.GetCultivation() == 1 )
				  {
				v = player.GetSkilllevel(5255);
				  }
				  else
				  {
				    v = 0;
				  }
				player.SetVar2(v);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4872Stub()
			: base(4872)
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
			SetAction(0,"Ó¢ÕÐ_ÉîÔ¨");
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
			SetAction(14,"Ó¢ÕÐ_ÉîÔ¨");
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
			name = "½¹ÍÁ";
			nativename = "½¹ÍÁ";
			icon = "½¹ÍÁ.dds";
			SetTalent(0,5185);
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
			int[] array={115,117,119,121,123,125,125,125,125};return array[level-1];
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
			int				player_maxhp = player.GetMaxhp();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(4000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((player_maxhp * (0.01f * player_var2)) + (player_maxhp * (0.01f * player_var2)) + ((skill_level * (0.01f * player_var1)) + (skill_level * (0.01f * player_var1)))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			if ( skill_t0 <= 0 )
			v24 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(4000.0f);
			victim.SetRatio((skill_t0 * 0.1f));
			victim.SetBuffid(0);
			victim.SetIncfatalhurt(true);
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
			victim.SetProbability(120.0f);
			victim.SetTime(10.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(4);
			victim.SetValue(5116.0f);
			victim.SetDelaycast(true);
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
			int[] array={4869};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
		public override int GetHpcost(GSkill skill)
		{
			return 400;
		}
	}
	public class GSkill4872 : GSkill
	{
		public GSkill4872()
			: base(4872)
		{
			
		}
	}
	public class GSkill4873Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_rage = player.GetRage();
				int				skill_level = skill.GetLevel();

				/*
				if ( player.GetCultivation() == 2 )
				  {
				v29 = player.GetSkilllevel(5256) * 0.1f;
				  }
				  else
				  {
				    v29 = 0.0f;
				  }
				if ( player.GetHasbuff(4274) )
				  {
				v28 = (player.GetSkilllevel(4852) * (player_rage * 0.01f));
				  }
				  else
				  {
				    v28 = 0;
				  }
				skill.SetPlus(((80 * skill_level + 640) + v28 * v29));
				skill.SetPlus2((v28 * (1.0f - v29)));
				if ( player.GetCultivation() == 2 )
				  {
				skill.SetRatio((player.GetSkilllevel(5260) * 0.05f + 1.0f));
				  }
				  else
				  {
				    skill.SetRatio(1.0f);
				  }
				v27 = ((player_maxhp - player_hp)) / player_maxhp;
				if ( player.GetHasbuff(4274) )
				  {
				v26 = ((player_rage / player_maxhp) / (30 - 5 * player.GetSkilllevel(4852))) + v27;
				  }
				  else
				  {
				    v26 = v27 + 0.0f;
				  }
				skill.SetCrit(v26);
				player.SetPerform(1);
				*/
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
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_rage = player.GetRage();
				int				skill_level = skill.GetLevel();

				/*
				if ( player.GetCultivation() == 2 )
				  {
				v38 = player.GetSkilllevel(5256) * 0.1f;
				  }
				  else
				  {
				    v38 = 0.0f;
				  }
				if ( player.GetHasbuff(4274) )
				  {
				v37 = (player.GetSkilllevel(4852) * (player_rage * 0.01f));
				  }
				  else
				  {
				    v37 = 0;
				  }
				if ( player.GetIscrit() )
				  {
				p = v37 * v38 + ((80 * skill_level + 640));
				  }
				  else
				  {
				    p = 0.0f;
				  }
				skill.SetPlus(p);
				if ( player.GetIscrit() )
				  {
				skill.SetPlus2(((1.0f - v38) * v37));
				  }
				  else
				  {
				    skill.SetPlus2(0.0f);
				  }
				if ( player.GetIscrit() )
				  {
				if ( player.GetCultivation() == 2 )
				    {
				v35 = player.GetSkilllevel(5260) * 0.05f + 1.0f;
				    }
				    else
				    {
				      v35 = 1.0f;
				    }
				    skill.SetRatio(v35);
				  }
				  else
				  {
				    skill.SetRatio(0.0f);
				  }
				if ( player.GetIscrit() )
				  {
				v34 = ((player_maxhp - player_hp)) / player_maxhp;
				if ( player.GetCultivation() == 2 )
				    {
				v33 = player.GetSkilllevel(5260) * 0.05f * v34;
				    }
				    else
				    {
				      v33 = 0.0f * v34;
				    }
				if ( player.GetHasbuff(4274) )
				    {
				v32 = ((player_rage / player_maxhp) / (30 - 5 * player.GetSkilllevel(4852))) + v33;
				    }
				    else
				    {
				      v32 = v33 + 0.0f;
				    }
				skill.SetCrit(v32);
				  }
				  else
				  {
				    skill.SetCrit(-10.0f);
				  }
				player.SetPerform(0);
				*/
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
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_rage = player.GetRage();
				int				skill_level = skill.GetLevel();

				/*
				if ( player.GetCultivation() == 2 )
				  {
				v32 = player.GetSkilllevel(5256) * 0.1f;
				  }
				  else
				  {
				    v32 = 0.0f;
				  }
				if ( player.GetHasbuff(4274) )
				  {
				v31 = (player.GetSkilllevel(4852) * (player_rage * 0.01f));
				  }
				  else
				  {
				    v31 = 0;
				  }
				skill.SetPlus(((80 * skill_level + 640) + v31 * v32));
				skill.SetPlus2((v31 * (1.0f - v32)));
				if ( player.GetCultivation() == 2 )
				  {
				skill.SetRatio((player.GetSkilllevel(5260) * 0.05f + 1.0f));
				  }
				  else
				  {
				    skill.SetRatio(1.0f);
				  }
				v29 = ((player_maxhp - player_hp)) / player_maxhp;
				if ( player.GetCultivation() == 2 )
				  {
				v30 = player.GetSkilllevel(5260) * 0.05f * v29;
				  }
				  else
				  {
				    v30 = 0.0f * v29;
				  }
				if ( player.GetHasbuff(4274) )
				  {
				v28 = ((player_rage / player_maxhp) / (30 - 5 * player.GetSkilllevel(4852))) + v30;
				  }
				  else
				  {
				    v28 = v30 + 0.0f;
				  }
				skill.SetCrit(v28);
				player.SetPerform(0);
				*/
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
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_rage = player.GetRage();
				int				skill_level = skill.GetLevel();

				/*
				if ( player.GetCultivation() == 2 )
				  {
				v32 = player.GetSkilllevel(5256) * 0.1f;
				  }
				  else
				  {
				    v32 = 0.0f;
				  }
				if ( player.GetHasbuff(4274) )
				  {
				v31 = (player.GetSkilllevel(4852) * (player_rage * 0.01f));
				  }
				  else
				  {
				    v31 = 0;
				  }
				skill.SetPlus(((80 * skill_level + 640) + v31 * v32));
				skill.SetPlus2((v31 * (1.0f - v32)));
				if ( player.GetCultivation() == 2 )
				  {
				skill.SetRatio((player.GetSkilllevel(5260) * 0.05f + 1.0f));
				  }
				  else
				  {
				    skill.SetRatio(1.0f);
				  }
				v29 = ((player_maxhp - player_hp)) / player_maxhp;
				if ( player.GetCultivation() == 2 )
				  {
				v30 = player.GetSkilllevel(5260) * 0.05f * v29;
				  }
				  else
				  {
				    v30 = 0.0f * v29;
				  }
				if ( player.GetHasbuff(4274) )
				  {
				v28 = ((player_rage / player_maxhp) / (30 - 5 * player.GetSkilllevel(4852))) + v30;
				  }
				  else
				  {
				    v28 = v30 + 0.0f;
				  }
				skill.SetCrit(v28);
				player.SetPerform(0);
				*/
			}
		}
		public GSkill4873Stub()
			: base(4873)
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
			rangetype = 0;
			doenchant = false;
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
			weapon_limit = 14;
			SetAction(0,"Ó¢ÕÐ_¿ñÕ½");
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
			SetAction(14,"Ó¢ÕÐ_¿ñÕ½");
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
			name = "±³Ë®";
			nativename = "±³Ë®";
			icon = "±³Ë®.dds";
			SetTalent(0,5219);
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
			AddState(new GState4());
			AddState(new GState5());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 6000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={115,117,119,121,123,125,125,125,125};return array[level-1];
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
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();
			int				skill_iscrit = skill.GetIscrit();

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
			victim.SetValue(4277.0f);
			victim.SetDispel(true);
			if ( skill_iscrit <= 0 || skill_t0 <= 0 )
			v38 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * player.GetSkilllevel(5215) + 10000)));
			victim.SetRatio((skill_t0 * 0.1f));
			victim.SetValue((skill_t0 * 0.1f));
			victim.SetSwift(true);
			if ( player.GetSkilllevel(5213) <= 0 )
			v37 = 0.0f;
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
			int[] array={4870};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
		public override int GetHpcost(GSkill skill)
		{
			return 400;
		}
	}
	public class GSkill4873 : GSkill
	{
		public GSkill4873()
			: base(4873)
		{
			
		}
	}
	public class GSkill4874Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				/*
				skill.SetSkillaccu(50 * skill_t1);
				if ( player.GetCultivation() != 4
				    || (v4 = player, GNET::PlayerWrapper::GetSkilllevel(v4, 5265) <= 0) )
				  {
				v = (3 * player_level) + 10 * skill_level;
				  }
				  else
				  {
				if ( 8 * player.GetSkilllevel(5265) + player_res2 <= 600 )
				    {
				      v15 = 600;
				    }
				    else
				    {
				v15 = player_res2 + 8 * player.GetSkilllevel(5265);
				    }
				    v = v15;
				  }
				player.SetVar1(v);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4874Stub()
			: base(4874)
		{
			occupation = 111;
			maxlevel = 7;
			maxlearn = 6;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 14;
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
			SetAction(0,"Ó¢ÕÐ_ÈºÌå¹´»ê");
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
			SetAction(14,"Ó¢ÕÐ_ÈºÌå¹´»ê");
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
			name = "¿ñÀ½Êõ";
			nativename = "¿ñÀ½Êõ";
			icon = "Á¦Íì¿ñÀ½.dds";
			SetTalent(0,5206);
			SetTalent(1,5207);
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
			int[] array={120,121,122,123,124,125};return array[level-1];
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
			return 13.000000f;
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
			int				skill_t0 = skill.GetT0();

			/*
			if ( player.GetObjectType() )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetPullback(true);
			victim.SetProbability(player_var1);
			victim.SetTime(((500 * skill_level + 2500)));
			victim.SetRatio(0.5f);
			victim.SetBuffid(0);
			victim.SetWeak(true);
			victim.SetProbability(-1.0f);
			if ( skill_t0 <= 0 )
			t = 0.0f;
			else
			victim.SetTime(((500 * skill_t0 + 2500)));
			victim.SetRatio(0.0f);
			victim.SetBuffid(0);
			victim.SetFrozen(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetCultivation() != 4
			|| (v3 = player, GNET::PlayerWrapper::GetSkilllevel(v3, 5265) <= 0) )
			t = 0.0f;
			else
			victim.SetTime(10000.0f);
			victim.SetValue(((2 * player.GetSkilllevel(5265))));
			victim.SetBlessed(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4871};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
		public override int GetHpcost(GSkill skill)
		{
			return 400;
		}
	}
	public class GSkill4874 : GSkill
	{
		public GSkill4874()
			: base(4874)
		{
			
		}
	}
	public class GSkill4875Stub : GSkillStub
	{
		public GSkill4875Stub()
			: base(4875)
		{
			occupation = 111;
			maxlevel = 6;
			maxlearn = 5;
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
			SetAction(13,"0");
			SetAction(14,"0");
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
			name = "ÁúÁÛ¾÷";
			nativename = "ÁúÁÛ¾÷";
			icon = "ÁúÁÛ¾÷.dds";
			SetTalent(0,5191);
			SetTalent(1,5192);
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			player.SetPasdecfatalhurt((skill_level * (skill_t0 * 0.03f)));
			player.SetPasdecfatalratio((skill_level * 0.01f + 0.00001f));
			player.SetPasadddefence(((5 * skill_level * skill_t1)));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4872};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill4875 : GSkill
	{
		public GSkill4875()
			: base(4875)
		{
			
		}
	}
	public class GSkill4876Stub : GSkillStub
	{
		public GSkill4876Stub()
			: base(4876)
		{
			occupation = 111;
			maxlevel = 6;
			maxlearn = 5;
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
			SetAction(13,"0");
			SetAction(14,"0");
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
			name = "·ïÓð¾÷";
			nativename = "·ïÓð¾÷";
			icon = "·ïÓð¾÷.dds";
			SetTalent(0,5225);
			SetTalent(1,5226);
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			player.SetPasaddsmite((skill_level * (skill_t0 * 0.03f)));
			player.SetPasinccrit((skill_level * 0.01f + 0.00001f));
			player.SetPasaddattack(((10 * skill_level * skill_t1)));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4873};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill4876 : GSkill
	{
		public GSkill4876()
			: base(4876)
		{
			
		}
	}
	public class GSkill4877Stub : GSkillStub
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
				int				player_maxatk = player.GetMaxatk();

				player.SetVar5(player.GetHasbuff(4270));
				player.SetVar4(player.GetSkilllevel(4864));
				player.SetVar3(player.GetSkilllevel(4855));
				player.SetVar2(player.GetSkilllevel(4843));
				player.SetVar1(player_maxatk);
				player.SetPerform(1);
			}
		}
		public GSkill4877Stub()
			: base(4877)
		{
			occupation = 112;
			maxlevel = 6;
			maxlearn = 5;
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
			weapon_limit = 14;
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
			SetAction(13,"0");
			SetAction(14,"0");
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
			name = "×ÝºáÌìÏÂ";
			nativename = "×ÝºáÌìÏÂ";
			icon = "×ÝºáÌìÏÂ.dds";
			SetTalent(0,5203);
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
			return 500;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,136,137,138,139};return array[level-1];
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
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				player_var3 = player.GetVar3();
			int				player_var4 = player.GetVar4();
			int				skill_t0 = skill.GetT0();

			/*
			if ( skill_t0 <= 0 || (v2 = player, GNET::PlayerWrapper::GetVar2(v2) <= 0) )
			d = 0.0f;
			else
			victim.SetProbability(600.0f);
			victim.SetTime(4000.0f);
			victim.SetRatio((player_var2 * 0.05f + 0.25f));
			victim.SetBuffid(0);
			victim.SetSlow(true);
			if ( skill_t0 <= 1 || (v10 = player, GNET::PlayerWrapper::GetVar3(v10) <= 0) )
			v39 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(6000.0f);
			victim.SetRatio((player_var3 * 0.05f));
			victim.SetBuffid(0);
			victim.SetDecdefence(true);
			if ( skill_t0 <= 2 || (v18 = player, GNET::PlayerWrapper::GetVar4(v18) <= 0) )
			v38 = 0.0f;
			else
			victim.SetProbability(120.0f);
			if ( player_var1 <= (player_var4 * ((player_maxhp - player_hp) * 0.01f)) )
			{
			v37 = player_var1;
			}
			else
			{
			v37 = player_var4 * (0.01f * (player_maxhp - player_hp));
			}
			victim.SetValue(v37);
			victim.SetDirecthurt(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var5 = player.GetVar5();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(10000.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(((80 * skill_level + 640)));
			victim.SetCycleskill(true);
			victim.SetProbability(120.0f);
			if ( player_var5 )
			t = 10.0f;
			else
			victim.SetTime(10000.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(5);
			victim.SetValue(5227.0f);
			victim.SetDelaycast(true);
			*/
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
		public override int GetHpcost(GSkill skill)
		{
			return 50;
		}
	}
	public class GSkill4877 : GSkill
	{
		public GSkill4877()
			: base(4877)
		{
			
		}
	}
	public class GSkill4878Stub : GSkillStub
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
				int				player_rage = player.GetRage();

				player.SetVar1(player_rage);
				player.SetRage(0);
				player.SetPerform(1);
			}
		}
		public GSkill4878Stub()
			: base(4878)
		{
			occupation = 112;
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
			SetAction(0,"Ó¢ÕÐ_·´ÉË");
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
			SetAction(14,"Ó¢ÕÐ_·´ÉË");
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
			name = "°ÔÎÞË«";
			nativename = "°ÔÎÞË«";
			icon = "¼Æ£º½èµ¶É±ÈË.dds";
			SetTalent(0,5186);
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
		public override int GetRequiredLevel(int level)
		{
			int[] array={136,137,138,139,140};return array[level-1];
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxatk = player.GetMaxatk();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(((25 * skill_t0)));
			if ( skill_t0 <= 0 )
			t = 0.0f;
			else
			victim.SetTime(((1000 * skill_level + 5000)));
			victim.SetRejectdebuff(true);
			victim.SetProbability(120.0f);
			victim.SetTime(10000.0f);
			victim.SetRatio((skill_level * 0.5f + 0.5f));
			v23 = skill_level * (player_var1 * 0.1f) + ((player_maxatk * skill_level));
			if ( player.GetDmgreduce() > 998 )
			{
			v22 = 1000.0f * v23;
			}
			else
			{
			v22 = 1000.0f * (1.0f / (1000 - player.GetDmgreduce()) * v23);
			}
			victim.SetAmount(v22);
			victim.SetValue(100.0f);
			victim.SetRetort(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4877};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill4878 : GSkill
	{
		public GSkill4878()
			: base(4878)
		{
			
		}
	}
	public class GSkill4879Stub : GSkillStub
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_rage = player.GetRage();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				/*
				skill.SetCrit((skill_t0 * 0.05f));
				skill.SetRatio((skill_level * 0.2f + 1.0f));
				if ( player.GetHasbuff(4271) )
				  {
				skill.SetPlus((player_rage * (skill_level * 0.1f)));
				  }
				  else
				  {
				    skill.SetPlus(0.0f);
				  }
				if ( player.GetHasbuff(4271) )
				  {
				    skill.SetPlus2(0.0f);
				  }
				  else
				  {
				skill.SetPlus2((player_rage * (skill_level * 0.1f)));
				  }
				player.SetRage(0);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4879Stub()
			: base(4879)
		{
			occupation = 112;
			maxlevel = 6;
			maxlearn = 5;
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
			weapon_limit = 14;
			SetAction(0,"Ó¢ÕÐ_Å­Õ¶");
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
			SetAction(14,"Ó¢ÕÐ_Å­Õ¶");
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
			name = "ÄæÁÛ¶Ï";
			nativename = "ÄæÁÛ¶Ï";
			icon = "Å­Õ¶.dds";
			SetTalent(0,5220);
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
			return 1400;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 60000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={136,137,138,139,140};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 10.000000f;
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
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return skill_level;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4877};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill4879 : GSkill
	{
		public GSkill4879()
			: base(4879)
		{
			
		}
	}
}
