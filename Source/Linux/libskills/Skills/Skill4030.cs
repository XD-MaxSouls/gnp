using System;
using System.Text;

namespace SKILL
{
	public class GSkill4030Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill4030Stub()
			: base(4030)
		{
			occupation = 59;
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
			SetAction(0,"ÐùÔ¯_¸ß½×°µÊ¹");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_¸ß½×°µÊ¹");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_¸ß½×°µÊ¹");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¸ß½×°µÊ¹");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "°ÔÔª¡¤½é";
			nativename = "°ÔÔª¡¤½é";
			icon = "°ÔÔª¡¤½é.dds";
			SetTalent(0,4116);
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
			skill_class = 11;
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
			return 10000;
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(0.0f);
			victim.SetRatio(((1000 * (skill_t0 + player.GetSkilllevel(4012)))));
			if ( player.GetCultivation() != 2
			|| (v9 = player, GNET::PlayerWrapper::GetSkilllevel(v9, 4575) <= 0) )
			{
			d = 0;
			}
			else
			{
			d = 5 * player.GetSkilllevel(4575);
			}
			victim.SetBuffid(d);
			victim.SetAmount(((7000 - 1000 * skill_level)));
			victim.SetValue(5.0f);
			victim.SetSeniordarkform(true);
			*/
			return true;
		}
		public override bool CheckDarkLightValue(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();

			return player.GetDarklight() == -100;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4027};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill4030 : GSkill
	{
		public GSkill4030()
			: base(4030)
		{
			
		}
	}
	public class GSkill4031Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill4031Stub()
			: base(4031)
		{
			occupation = 59;
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
			SetAction(0,"ÐùÔ¯_¸ß½×¹âÊ¹");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_¸ß½×¹âÊ¹");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_¸ß½×¹âÊ¹");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¸ß½×¹âÊ¹");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÌìÔª¡¤ÓÉ";
			nativename = "ÌìÔª¡¤ÓÉ";
			icon = "ÌìÔª¡¤ÓÉ.dds";
			SetTalent(0,4133);
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
			skill_class = 11;
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
			return 10000;
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxatk = player.GetMaxatk();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(120.0f);
			if ( player.GetCultivation() != 1
			|| (v4 = player, GNET::PlayerWrapper::GetSkilllevel(v4, 4570) <= 0) )
			{
			t = 0.0f;
			}
			else
			{
			t = player.GetSkilllevel(4570) * ((1000 * player_maxatk) * 0.5f);
			}
			victim.SetTime(t);
			victim.SetRatio(((1000 * (skill_t0 + player.GetSkilllevel(4013)))));
			victim.SetBuffid(0);
			victim.SetAmount(((7000 - 1000 * skill_level)));
			victim.SetValue(5.0f);
			victim.SetSeniorlightform(true);
			*/
			return true;
		}
		public override bool CheckDarkLightValue(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();

			return player.GetDarklight() == 100;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4027};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill4031 : GSkill
	{
		public GSkill4031()
			: base(4031)
		{
			
		}
	}
	public class GSkill4032Stub : GSkillStub
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
				int				player_maxatk = player.GetMaxatk();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();

				/*
				player.SetVar5(player.GetSkilllevel(4579));
				if ( player.GetCultivation() != 2
				    || (v6 = player, GNET::PlayerWrapper::GetSkilllevel(v6, 4579) <= 0) )
				    v = 0;
				  else
				    v = 120;
				player.SetVar4(v);
				player.SetVar1(1);
				v29 = (5 * player_level);
				if ( player.GetDarklightform() != 3
				    && (v11 = player, GNET::PlayerWrapper::GetDarklightform(v11) != 5)
				    && (v12 = player, GNET::PlayerWrapper::GetDarklightform(v12) != 6) )
				    v28 = v29;
				  else
				skill.SetPlus(((skill_t2 * 0.1f + 1.0f) * v29));
				player.SetVar2(player_maxatk);
				player.SetVar3(player_res2);
				v27 = player.GetDarklight();
				v26 = skill_t0 + skill_level;
				if ( player.GetDarklightform() == 6 )
				    v25 = -v26;
				  else
				player.SetDarklight(v27 - v26);
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
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_maxatk = player.GetMaxatk();
				int				player_res2 = player.GetRes2();
				int				skill_t2 = skill.GetT2();

				/*
				player.SetVar5(player.GetSkilllevel(4579));
				if ( player.GetCultivation() != 2
				    || (v6 = player, GNET::PlayerWrapper::GetSkilllevel(v6, 4579) <= 0) )
				    v = 0;
				  else
				    v = 120;
				player.SetVar4(v);
				player.SetVar1(2);
				v22 = (5 * player_level);
				if ( player.GetDarklightform() != 3
				    && (v11 = player, GNET::PlayerWrapper::GetDarklightform(v11) != 5)
				    && (v12 = player, GNET::PlayerWrapper::GetDarklightform(v12) != 6) )
				    v21 = v22;
				  else
				skill.SetPlus(((skill_t2 * 0.1f + 1.0f) * v22));
				player.SetVar2(player_maxatk);
				player.SetVar3(player_res2);
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
				return 725;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_maxatk = player.GetMaxatk();
				int				player_res2 = player.GetRes2();
				int				skill_t2 = skill.GetT2();

				/*
				player.SetVar5(player.GetSkilllevel(4579));
				if ( player.GetCultivation() != 2
				    || (v6 = player, GNET::PlayerWrapper::GetSkilllevel(v6, 4579) <= 0) )
				    v = 0;
				  else
				    v = 120;
				player.SetVar4(v);
				player.SetVar1(3);
				v22 = (5 * player_level);
				if ( player.GetDarklightform() != 3
				    && (v11 = player, GNET::PlayerWrapper::GetDarklightform(v11) != 5)
				    && (v12 = player, GNET::PlayerWrapper::GetDarklightform(v12) != 6) )
				    v21 = v22;
				  else
				skill.SetPlus(((skill_t2 * 0.1f + 1.0f) * v22));
				player.SetVar2(player_maxatk);
				player.SetVar3(player_res2);
				player.SetPerform(0);
				*/
			}
		}
		public GSkill4032Stub()
			: base(4032)
		{
			occupation = 59;
			maxlevel = 10;
			maxlearn = 9;
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
			weapon_limit = 9;
			SetAction(0,"ÐùÔ¯_°µ·ç±©");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_°µ·ç±©");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_°µ·ç±©");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_°µ·ç±©");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ËéÄù¡¤½Ù¡¤ÓÀÒ¹";
			nativename = "ËéÄù¡¤½Ù¡¤ÓÀÒ¹";
			icon = "ËéÄù¡¤½Ù¡¤ÓÀÒ¹.dds";
			SetTalent(0,4115);
			SetTalent(1,4116);
			SetTalent(2,4117);
			SetTalent(3,4124);
			SetTalent(4,4152);
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
			skill_class = 11;
			guide = true;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 1;
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
			return 2225;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t4 = skill.GetT4();

			return 15000 - 1000 * skill_t4;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={115,117,119,121,123,125,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				player_level = player.GetLevel();

			return (5 * player_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_res2 = player.GetRes2();
			int				player_var2 = player.GetVar2();
			int				player_var3 = player.GetVar3();
			int				player_var5 = player.GetVar5();
			int				skill_level = skill.GetLevel();
			int				skill_t3 = skill.GetT3();

			/*
			if ( player_res2 > player_var3 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(10.0f);
			victim.SetBuffid(1);
			if ( (skill_level * 0.2f + 0.8f) * player_var2 <= ((player_maxhp - player_hp)) )
			{
			v35 = (skill_level * 0.2f + 0.8f) * player_var2;
			}
			else
			{
			v35 = (player_maxhp - player_hp);
			}
			if ( player.GetObjectType()
			|| (v20 = player, GNET::PlayerWrapper::GetVar4(v20) <= 0) )
			{
			v34 = v35;
			}
			else
			{
			v34 = (player_var5 * 0.1f + 1.0f) * v35;
			}
			victim.SetAmount(v34);
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			if ( skill_t3 <= 0 )
			v33 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(3000.0f);
			victim.SetRatio((skill_t3 * 0.05f));
			victim.SetBuffid(1);
			victim.SetDecskilldodge(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();

			/*
			if ( player_var1 == 3 )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(15.0f);
			victim.SetBuffid(1);
			victim.SetAmount(54003.0f);
			victim.SetValue(0.0f);
			victim.SetCreateobject(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4030};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill4032 : GSkill
	{
		public GSkill4032()
			: base(4032)
		{
			
		}
	}
	public class GSkill4033Stub : GSkillStub
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
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();

				/*
				player.SetVar4(player.GetSkilllevel(4574));
				if ( player.GetCultivation() != 1
				    || (v6 = player, GNET::PlayerWrapper::GetSkilllevel(v6, 4574) <= 0) )
				    v = 0;
				  else
				    v = 120;
				player.SetVar3(v);
				player.SetVar2(player_level);
				player.SetVar1(1);
				v29 = (skill_level * player_maxmp / 100 + (5 * player_level));
				if ( player.GetDarklightform() != 4
				    && (v17 = player, GNET::PlayerWrapper::GetDarklightform(v17) != 5)
				    && (v18 = player, GNET::PlayerWrapper::GetDarklightform(v18) != 6) )
				    v28 = v29;
				  else
				skill.SetPlus(((skill_t2 * 0.1f + 1.0f) * v29));
				v27 = player.GetDarklight();
				v26 = skill_t0 + skill_level;
				if ( player.GetDarklightform() == 5 )
				    v25 = -v26;
				  else
				player.SetDarklight(v26 + v27);
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
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();

				/*
				player.SetVar4(player.GetSkilllevel(4574));
				if ( player.GetCultivation() != 1
				    || (v6 = player, GNET::PlayerWrapper::GetSkilllevel(v6, 4574) <= 0) )
				    v = 0;
				  else
				    v = 120;
				player.SetVar3(v);
				player.SetVar2(player_level);
				player.SetVar1(2);
				v22 = (skill_level * player_maxmp / 100 + (5 * player_level));
				if ( player.GetDarklightform() != 4
				    && (v17 = player, GNET::PlayerWrapper::GetDarklightform(v17) != 5)
				    && (v18 = player, GNET::PlayerWrapper::GetDarklightform(v18) != 6) )
				    v21 = v22;
				  else
				skill.SetPlus(((skill_t2 * 0.1f + 1.0f) * v22));
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
				return 1150;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();

				/*
				player.SetVar4(player.GetSkilllevel(4574));
				if ( player.GetCultivation() != 1
				    || (v6 = player, GNET::PlayerWrapper::GetSkilllevel(v6, 4574) <= 0) )
				    v = 0;
				  else
				    v = 120;
				player.SetVar3(v);
				player.SetVar2(player_level);
				player.SetVar1(3);
				v22 = (skill_level * player_maxmp / 100 + (5 * player_level));
				if ( player.GetDarklightform() != 4
				    && (v17 = player, GNET::PlayerWrapper::GetDarklightform(v17) != 5)
				    && (v18 = player, GNET::PlayerWrapper::GetDarklightform(v18) != 6) )
				    v21 = v22;
				  else
				skill.SetPlus(((skill_t2 * 0.1f + 1.0f) * v22));
				player.SetPerform(0);
				*/
			}
		}
		public GSkill4033Stub()
			: base(4033)
		{
			occupation = 59;
			maxlevel = 10;
			maxlearn = 9;
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
			weapon_limit = 9;
			SetAction(0,"ÐùÔ¯_¹â·ç±©");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_¹â·ç±©");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_¹â·ç±©");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¹â·ç±©");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ËéÄù¡¤î¸¡¤Ê¢·ç";
			nativename = "ËéÄù¡¤î¸¡¤Ê¢·ç";
			icon = "ËéÄù¡¤î¸¡¤Ê¢·ç.dds";
			SetTalent(0,4132);
			SetTalent(1,4133);
			SetTalent(2,4134);
			SetTalent(3,4141);
			SetTalent(4,4152);
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
			skill_class = 11;
			guide = true;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 2;
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
			return 2650;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t4 = skill.GetT4();

			return 15000 - 1000 * skill_t4;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={115,117,119,121,123,125,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				player_level = player.GetLevel();

			return (5 * player_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();
			int				player_var2 = player.GetVar2();
			int				player_var3 = player.GetVar3();
			int				player_var4 = player.GetVar4();
			int				skill_t3 = skill.GetT3();

			/*
			if ( skill_t3 <= 0 )
			{
			d = 0.0f;
			}
			else
			{
			d = (20 * skill_t3 + (3 * player_var2));
			}
			victim.SetProbability(d);
			victim.SetTime(3000.0f);
			victim.SetSilent(true);
			if ( player.GetObjectType() )
			{
			v17 = 0.0f;
			}
			else
			{
			v17 = player_var3;
			}
			victim.SetProbability(v17);
			victim.SetValue((player_var4 * (player_maxmp * 0.01f)));
			victim.SetDirecthurt(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();

			/*
			if ( player_var1 == 3 )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(15.0f);
			victim.SetBuffid(2);
			victim.SetAmount(54000.0f);
			victim.SetValue(0.0f);
			victim.SetCreateobject(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4031};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill4033 : GSkill
	{
		public GSkill4033()
			: base(4033)
		{
			
		}
	}
	public class GSkill4034Stub : GSkillStub
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
				return 375;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill4034Stub()
			: base(4034)
		{
			occupation = 59;
			maxlevel = 6;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 2048;
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
			SetAction(0,"ÐùÔ¯_°µÓ°ÊÞ");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_°µÓ°ÊÞ");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_°µÓ°ÊÞ");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_°µÓ°ÊÞ");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¾»Äù¡¤½Ù¡¤ºÚÉ·";
			nativename = "¾»Äù¡¤½Ù¡¤ºÚÉ·";
			icon = "¾»Äù¡¤½Ù¡¤ºÚÉ·.dds";
			SetTalent(0,4129);
			SetTalent(1,4130);
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
			skill_class = 11;
			guide = false;
			summon_id = 54003;
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
			return 875;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 60000 - 5000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetRatio(skill_level);
			victim.SetAmount(4438.0f);
			victim.SetValue(54003.0f);
			victim.SetSummonskill(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4032};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill4034 : GSkill
	{
		public GSkill4034()
			: base(4034)
		{
			
		}
	}
	public class GSkill4035Stub : GSkillStub
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
				return 375;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill4035Stub()
			: base(4035)
		{
			occupation = 59;
			maxlevel = 6;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 2048;
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
			SetAction(0,"ÐùÔ¯_Ìì¹âÕó");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_Ìì¹âÕó");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_Ìì¹âÕó");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_Ìì¹âÕó");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¾»Äù¡¤î¸¡¤Ò«ÊÀ";
			nativename = "¾»Äù¡¤î¸¡¤Ò«ÊÀ";
			icon = "¾»Äù¡¤î¸¡¤Ò«ÊÀ.dds";
			SetTalent(0,4146);
			SetTalent(1,4147);
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
			skill_class = 11;
			guide = false;
			summon_id = 54000;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 2;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 875;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 60000 - 5000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetRatio(skill_level);
			victim.SetAmount(4439.0f);
			victim.SetValue(54000.0f);
			victim.SetSummonskill(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4033};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill4035 : GSkill
	{
		public GSkill4035()
			: base(4035)
		{
			
		}
	}
	public class GSkill4036Stub : GSkillStub
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
				return 425;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill4036Stub()
			: base(4036)
		{
			occupation = 60;
			maxlevel = 6;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 5;
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
			weapon_limit = -1;
			SetAction(0,"ÐùÔ¯_ÅÚÌ¨¹Ö");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_ÅÚÌ¨¹Ö");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_ÅÚÌ¨¹Ö");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_ÅÚÌ¨¹Ö");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "»Ê¼«¡¤Ä¿²Ôñ·";
			nativename = "»Ê¼«¡¤Ä¿²Ôñ·";
			icon = "»Ê¼«¡¤Ä¿²Ôñ·.dds";
			SetTalent(0,4153);
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
			skill_class = 11;
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
			return 1425;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 6000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,136,137,138,139};return array[level-1];
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
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 6000)));
			victim.SetRatio(5.0f);
			victim.SetBuffid(2);
			victim.SetAmount(53991.0f);
			victim.SetValue(0.0f);
			victim.SetCreateobject(true);
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill4036 : GSkill
	{
		public GSkill4036()
			: base(4036)
		{
			
		}
	}
	public class GSkill4037Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				/*
				v8 = player.GetDarklight();
				  v7 = 50 * skill_level;
				if ( player.GetDarklight() >= 0 )
				    v6 = v7;
				  else
				player.SetDarklight(-v7 + v8);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4037Stub()
			: base(4037)
		{
			occupation = 60;
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
			SetAction(0,"ÐùÔ¯_ºÏÒ»");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_ºÏÒ»");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_ºÏÒ»");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_ºÏÒ»");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ôª¡¤ÎÞ¼ä";
			nativename = "Ôª¡¤ÎÞ¼ä";
			icon = "Ôª¡¤ÎÞ¼ä.dds";
			SetTalent(0,4116);
			SetTalent(1,4133);
			SetTalent(2,2947);
			SetTalent(3,4112);
			SetTalent(4,4530);
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
			skill_class = 11;
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
			return 120000/*xxxx*/;
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxatk = player.GetMaxatk();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			/*
			if ( player.GetDarklight() >= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			if ( player.GetCultivation() != 1
			|| (v5 = player, GNET::PlayerWrapper::GetSkilllevel(v5, 4570) <= 0) )
			{
			t = 0.0f;
			}
			else
			{
			t = player.GetSkilllevel(4570) * ((1000 * player_maxatk) * 0.5f);
			}
			victim.SetTime(t);
			victim.SetRatio(((1000 * (skill_t0 + player.GetSkilllevel(4012)))));
			if ( player.GetCultivation() != 2
			|| (v15 = player, GNET::PlayerWrapper::GetSkilllevel(v15, 4575) <= 0) )
			{
			v48 = 0;
			}
			else
			{
			v48 = 5 * player.GetSkilllevel(4575);
			}
			victim.SetBuffid(v48);
			victim.SetAmount(((7000 - 1000 * player.GetSkilllevel(4030))));
			victim.SetValue(5.0f);
			victim.SetDarkuniform(true);
			if ( player.GetDarklight() < 0 )
			v47 = 0.0f;
			else
			victim.SetProbability(120.0f);
			if ( player.GetCultivation() != 1
			|| (v26 = player, GNET::PlayerWrapper::GetSkilllevel(v26, 4570) <= 0) )
			{
			v46 = 0.0f;
			}
			else
			{
			v46 = player.GetSkilllevel(4570) * ((1000 * player_maxatk) * 0.5f);
			}
			victim.SetTime(v46);
			victim.SetRatio(((1000 * (skill_t1 + player.GetSkilllevel(4013)))));
			if ( player.GetCultivation() != 2
			|| (v36 = player, GNET::PlayerWrapper::GetSkilllevel(v36, 4575) <= 0) )
			{
			v45 = 0;
			}
			else
			{
			v45 = 5 * player.GetSkilllevel(4575);
			}
			victim.SetBuffid(v45);
			victim.SetAmount(((7000 - 1000 * player.GetSkilllevel(4031))));
			victim.SetValue(5.0f);
			victim.SetLightuniform(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4036};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill4037 : GSkill
	{
		public GSkill4037()
			: base(4037)
		{
			
		}
	}
	public class GSkill4038Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 875;
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
				return 750;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();

				player.SetVar1(1);
				player.SetVar2(player_res2);
				player.SetVar3(player_res3);
				skill.SetPlus(2000.0f);
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
				return 750;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(2);
				skill.SetPlus(2000.0f);
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

				player.SetVar1(3);
				skill.SetPlus(2000.0f);
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
				int				player_maxhp = player.GetMaxhp();

				player.SetVar1(4);
				player.SetVar2(player_maxhp);
				skill.SetPlus(2000.0f);
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public GSkill4038Stub()
			: base(4038)
		{
			occupation = 60;
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
			weapon_limit = 9;
			SetAction(0,"ÐùÔ¯_³é»êÊõ");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_³é»êÊõ");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_³é»êÊõ");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_³é»êÊõ");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Äù¡¤»ÊÌì·¨»êÊõ";
			nativename = "Äù¡¤»ÊÌì·¨»êÊõ";
			icon = "Äù¡¤»ÊÌì·¨»êÊõ.dds";
			SetTalent(0,4125);
			SetTalent(1,4131);
			SetTalent(2,4003);
			SetTalent(3,4014);
			SetTalent(4,4023);
			SetTalent(5,4032);
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
			skill_class = 11;
			guide = true;
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
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();
			int				skill_t5 = skill.GetT5();

			return 60000 - 1000 * (skill_t5 + (skill_t4 + (skill_t3 + skill_t2)));
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={136,137,138,139,140};return array[level-1];
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
		public override float GetMpcost(GSkill skill)
		{
			return 2000.000000f;
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
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			/*
			if ( player_var1 == 1 )
			{
			d = (player_var2 + (10 * (skill_t0 + skill_level)));
			}
			else
			{
			d = 0.0f;
			}
			victim.SetProbability(d);
			victim.SetTime(4000.0f);
			victim.SetRatio(0.5f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			if ( player_var1 == 4 )
			v40 = 120.0f;
			else
			victim.SetProbability(0.0f);
			if ( (player_maxhp - player_hp) >= player_var2 )
			{
			v39 = player_var2;
			}
			else
			{
			v39 = (player_maxhp - player_hp);
			}
			if ( player.GetHasmultbuff(5) )
			v38 = v39;
			else
			victim.SetValue((skill_t1 * 0.2f * v39));
			victim.SetDirecthurt(true);
			if ( player_var1 == 1 )
			{
			v37 = (player_var3 + (10 * (skill_t0 + skill_level)));
			}
			else
			{
			v37 = 0.0f;
			}
			victim.SetProbability(v37);
			victim.SetTime(4000.0f);
			victim.SetWrap(true);
			victim.SetProbability(120.0f);
			victim.SetRatio(1.0f);
			victim.SetExtracthp(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4036};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill4038 : GSkill
	{
		public GSkill4038()
			: base(4038)
		{
			
		}
	}
	public class GSkill4039Stub : GSkillStub
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				skill.SetPlus(2000.0f);
				skill.SetPlus2((skill_level * (player_maxmp * 0.02f)));
				skill.SetCrithurt((skill_t1 * 0.05f));
				player.SetPerform(1);
			}
		}
		public GSkill4039Stub()
			: base(4039)
		{
			occupation = 60;
			maxlevel = 6;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 11;
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
			weapon_limit = 9;
			SetAction(0,"ÐùÔ¯_ÈÕÑ×Êõ_02");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_ÈÕÑ×Êõ_02");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_ÈÕÑ×Êõ_02");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_ÈÕÑ×Êõ_02");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "½ç¡¤ÌìÑÝÊ½¡¤ÁùµÀ";
			nativename = "½ç¡¤ÌìÑÝÊ½¡¤ÁùµÀ";
			icon = "½ç¡¤ÌìÑÝÊ½¡¤ÁùµÀ.dds";
			SetTalent(0,4142);
			SetTalent(1,4148);
			SetTalent(2,4004);
			SetTalent(3,4015);
			SetTalent(4,4024);
			SetTalent(5,4033);
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
			skill_class = 11;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 4352;
			targetcnt = 6;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 400;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();
			int				skill_t5 = skill.GetT5();

			return 60000 - 1000 * (skill_t5 + (skill_t4 + (skill_t3 + skill_t2)));
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={136,137,138,139,140};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 20.000000f;
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
		public override float GetMpcost(GSkill skill)
		{
			return 2000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			/*
			if ( skill_t0 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetRatio((skill_t0 * 0.01f));
			victim.SetBuffid(1);
			victim.SetIncfatalratio(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetAmount(skill_level);
			victim.SetValue(4352.0f);
			victim.SetTriggerskill(true);
			victim.SetProbability(120.0f);
			victim.SetTime(1000.0f);
			victim.SetPowerless(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4036};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill4039 : GSkill
	{
		public GSkill4039()
			: base(4039)
		{
			
		}
	}
}
