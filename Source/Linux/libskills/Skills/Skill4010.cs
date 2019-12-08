using System;
using System.Text;

namespace SKILL
{
	public class GSkill4010Stub : GSkillStub
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
		public GSkill4010Stub()
			: base(4010)
		{
			occupation = 57;
			maxlevel = 5;
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
			name = "Á«»ª¡¤¿ÕÐÐ";
			nativename = "Á«»ª¡¤¿ÕÐÐ";
			icon = "Óù¿ÕÊõ.dds";
			SetTalent(0,4159);
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
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 70000 - 10000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={50,58,66};return array[level-1];
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
			return 150.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetTime(5000.0f);
			victim.SetValue(15.0f);
			victim.SetDodge(true);
			if ( zrand(100) >= 10 * skill_t0 )
			d = 0.0f;
			else
			victim.SetRatio(3999.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetClearcooldown(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4009};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill4010 : GSkill
	{
		public GSkill4010()
			: base(4010)
		{
			
		}
	}
	public class GSkill4011Stub : GSkillStub
	{
		public GSkill4011Stub()
			: base(4011)
		{
			occupation = 57;
			maxlevel = 10;
			maxlearn = 9;
			eventflag = 1;
			spcost = 1;
			reborncount = 0;
			type = 11;
			timetype = 0;
			targettype = 0;
			rangetype = 5;
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
			name = "ÀïÒáÒý¡¤Áú¸è";
			nativename = "ÀïÒáÒý¡¤Áú¸è";
			icon = "½ç¡¤¶Ý¹âÊ½¡¤×ß¸ê.dds";
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={60,62,64,66,68,70,72,74,76};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4010};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill4011 : GSkill
	{
		public GSkill4011()
			: base(4011)
		{
			
		}
	}
	public class GSkill4012Stub : GSkillStub
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
		public GSkill4012Stub()
			: base(4012)
		{
			occupation = 57;
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
			SetAction(0,"ÐùÔ¯_µÍ½×°µÊ¹");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_µÍ½×°µÊ¹");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_µÍ½×°µÊ¹");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_µÍ½×°µÊ¹");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "°ÔÔª¡¤Ï¦";
			nativename = "°ÔÔª¡¤Ï¦";
			icon = "°ÔÔª¡¤Ï¦.dds";
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
			int[] array={46,54,62};return array[level-1];
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

			return player_range + 10.0f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetRatio(((1000 * (skill_t0 + skill_level))));
			victim.SetValue(5.0f);
			victim.SetJuniordarkform(true);
			return true;
		}
		public override bool CheckDarkLightValue(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();

			return player.GetDarklight() == -100;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4009};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill4012 : GSkill
	{
		public GSkill4012()
			: base(4012)
		{
			
		}
	}
	public class GSkill4013Stub : GSkillStub
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
		public GSkill4013Stub()
			: base(4013)
		{
			occupation = 57;
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
			SetAction(0,"ÐùÔ¯_µÍ½×¹âÊ¹");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_µÍ½×¹âÊ¹");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_µÍ½×¹âÊ¹");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_µÍ½×¹âÊ¹");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÌìÔª¡¤êÍ";
			nativename = "ÌìÔª¡¤êÍ";
			icon = "ÌìÔª¡¤êÍ.dds";
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
			int[] array={46,54,62};return array[level-1];
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetRatio(((1000 * (skill_t0 + skill_level))));
			victim.SetValue(5.0f);
			victim.SetJuniorlightform(true);
			return true;
		}
		public override bool CheckDarkLightValue(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();

			return player.GetDarklight() == 100;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4009};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill4013 : GSkill
	{
		public GSkill4013()
			: base(4013)
		{
			
		}
	}
	public class GSkill4014Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 375;
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
				return 625;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();

				/*
				player.SetVar3(player.GetSkilllevel(4577));
				if ( player.GetCultivation() != 2
				    || (v6 = player, GNET::PlayerWrapper::GetSkilllevel(v6, 4577) <= 0) )
				    v = 0;
				  else
				    v = 120;
				player.SetVar2(v);
				v22 = (3 * player_level);
				if ( player.GetDarklightform() != 3
				    && (v10 = player, GNET::PlayerWrapper::GetDarklightform(v10) != 5)
				    && (v11 = player, GNET::PlayerWrapper::GetDarklightform(v11) != 6) )
				    v21 = v22;
				  else
				skill.SetPlus(((skill_t2 * 0.1f + 1.0f) * v22));
				v20 = player.GetDarklight();
				v19 = skill_t0 + skill_level;
				if ( player.GetDarklightform() == 6 )
				    v18 = -v19;
				  else
				player.SetDarklight(v20 - v19);
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
				return 750;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t4 = skill.GetT4();

				/*
				player.SetVar3(player.GetSkilllevel(4577));
				if ( player.GetCultivation() != 2
				    || (v6 = player, GNET::PlayerWrapper::GetSkilllevel(v6, 4577) <= 0) )
				    v = 0;
				  else
				    v = 120;
				player.SetVar2(v);
				v16 = 3.0f * (player_level * ((0.05f * skill_t4) + 1.0f));
				if ( player.GetDarklightform() != 3
				    && (v11 = player, GNET::PlayerWrapper::GetDarklightform(v11) != 5)
				    && (v12 = player, GNET::PlayerWrapper::GetDarklightform(v12) != 6) )
				    v15 = v16;
				  else
				skill.SetPlus(((skill_t2 * 0.1f + 1.0f) * v16));
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
				return 625;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t4 = skill.GetT4();

				/*
				player.SetVar3(player.GetSkilllevel(4577));
				if ( player.GetCultivation() != 2
				    || (v6 = player, GNET::PlayerWrapper::GetSkilllevel(v6, 4577) <= 0) )
				    v = 0;
				  else
				    v = 120;
				player.SetVar2(v);
				v16 = 3.0f * (player_level * ((0.1f * skill_t4) + 1.0f));
				if ( player.GetDarklightform() != 3
				    && (v11 = player, GNET::PlayerWrapper::GetDarklightform(v11) != 5)
				    && (v12 = player, GNET::PlayerWrapper::GetDarklightform(v12) != 6) )
				    v15 = v16;
				  else
				skill.SetPlus(((skill_t2 * 0.1f + 1.0f) * v16));
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
				return 625;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t4 = skill.GetT4();

				/*
				player.SetVar3(player.GetSkilllevel(4577));
				if ( player.GetCultivation() != 2
				    || (v6 = player, GNET::PlayerWrapper::GetSkilllevel(v6, 4577) <= 0) )
				    v = 0;
				  else
				    v = 120;
				player.SetVar2(v);
				v16 = 3.0f * (player_level * ((0.15f * skill_t4) + 1.0f));
				if ( player.GetDarklightform() != 3
				    && (v11 = player, GNET::PlayerWrapper::GetDarklightform(v11) != 5)
				    && (v12 = player, GNET::PlayerWrapper::GetDarklightform(v12) != 6) )
				    v15 = v16;
				  else
				skill.SetPlus(((skill_t2 * 0.1f + 1.0f) * v16));
				player.SetPerform(0);
				*/
			}
		}
		public GSkill4014Stub()
			: base(4014)
		{
			occupation = 57;
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
			weapon_limit = 9;
			SetAction(0,"ÐùÔ¯_°µÉäÏß");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_°µÉäÏß");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_°µÉäÏß");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_°µÉäÏß");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¾»Äù¡¤½Ù¡¤Ìý³ð";
			nativename = "¾»Äù¡¤½Ù¡¤Ìý³ð";
			icon = "¾»Äù¡¤½Ù¡¤Ìý³ð.dds";
			SetTalent(0,4115);
			SetTalent(1,4116);
			SetTalent(2,4117);
			SetTalent(3,4122);
			SetTalent(4,4150);
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
			AddState(new GState5());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 6000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={55,57,59,61,63,65,67,69,71};return array[level-1];
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
			GPlayerWrapper	player = skill.GetPlayer();
			int				player_level = player.GetLevel();

			return (3 * player_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var2 = player.GetVar2();
			int				player_var3 = player.GetVar3();
			int				skill_level = skill.GetLevel();
			int				skill_t3 = skill.GetT3();

			/*
			victim.SetProbability(120.0f);
			victim.SetRatio((skill_level * 0.1f));
			victim.SetExtracthp(true);
			if ( skill_t3 <= 0 )
			v22 = 0.0f;
			else
			victim.SetProbability(600.0f);
			victim.SetTime(1500.0f);
			victim.SetRatio((skill_t3 * 0.25f));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetProbability(player_var2);
			victim.SetTime(1500.0f);
			victim.SetRatio((player_var3 * 0.02f));
			victim.SetBuffid(1);
			victim.SetIncfatalratio(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4012};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill4014 : GSkill
	{
		public GSkill4014()
			: base(4014)
		{
			
		}
	}
	public class GSkill4015Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 375;
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
				return 625;
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
				player.SetVar3(player.GetSkilllevel(4572));
				if ( player.GetCultivation() != 1
				    || (v6 = player, GNET::PlayerWrapper::GetSkilllevel(v6, 4572) <= 0) )
				    v = 0;
				  else
				    v = 120;
				player.SetVar2(v);
				player.SetVar1(player_maxmp);
				v28 = (skill_level * player_maxmp / 100 + (3 * player_level));
				if ( player.GetDarklightform() != 4
				    && (v16 = player, GNET::PlayerWrapper::GetDarklightform(v16) != 5)
				    && (v17 = player, GNET::PlayerWrapper::GetDarklightform(v17) != 6) )
				    v27 = v28;
				  else
				skill.SetPlus(((skill_t2 * 0.1f + 1.0f) * v28));
				v26 = player.GetDarklight();
				v25 = skill_t0 + skill_level;
				if ( player.GetDarklightform() == 5 )
				    v24 = -v25;
				  else
				player.SetDarklight(v25 + v26);
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
				return 750;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t4 = skill.GetT4();

				/*
				player.SetVar3(player.GetSkilllevel(4572));
				if ( player.GetCultivation() != 1
				    || (v6 = player, GNET::PlayerWrapper::GetSkilllevel(v6, 4572) <= 0) )
				    v = 0;
				  else
				    v = 120;
				player.SetVar2(v);
				player.SetVar1(player_maxmp);
				v22 = (skill_level * player_maxmp / 100 + (3 * player_level)) * ((0.05f * skill_t4) + 1.0f);
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
				return 625;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t4 = skill.GetT4();

				/*
				player.SetVar3(player.GetSkilllevel(4572));
				if ( player.GetCultivation() != 1
				    || (v6 = player, GNET::PlayerWrapper::GetSkilllevel(v6, 4572) <= 0) )
				    v = 0;
				  else
				    v = 120;
				player.SetVar2(v);
				player.SetVar1(player_maxmp);
				v22 = (skill_level * player_maxmp / 100 + (3 * player_level)) * ((0.1f * skill_t4) + 1.0f);
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
		public class GState5 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 625;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t4 = skill.GetT4();

				/*
				player.SetVar3(player.GetSkilllevel(4572));
				if ( player.GetCultivation() != 1
				    || (v6 = player, GNET::PlayerWrapper::GetSkilllevel(v6, 4572) <= 0) )
				    v = 0;
				  else
				    v = 120;
				player.SetVar2(v);
				player.SetVar1(player_maxmp);
				v22 = (skill_level * player_maxmp / 100 + (3 * player_level)) * ((0.15f * skill_t4) + 1.0f);
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
		public GSkill4015Stub()
			: base(4015)
		{
			occupation = 57;
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
			weapon_limit = 9;
			SetAction(0,"ÐùÔ¯_¹âÉäÏß");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_¹âÉäÏß");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_¹âÉäÏß");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¹âÉäÏß");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¾»Äù¡¤î¸¡¤´æÕÕ";
			nativename = "¾»Äù¡¤î¸¡¤´æÕÕ";
			icon = "¾»Äù¡¤î¸¡¤´æÕÕ.dds";
			SetTalent(0,4132);
			SetTalent(1,4133);
			SetTalent(2,4134);
			SetTalent(3,4139);
			SetTalent(4,4150);
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
			AddState(new GState5());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 6000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={55,57,59,61,63,65,67,69,71};return array[level-1];
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
			GPlayerWrapper	player = skill.GetPlayer();
			int				player_level = player.GetLevel();

			return (3 * player_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var3 = player.GetVar3();
			int				skill_t3 = skill.GetT3();

			/*
			if ( skill_t3 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(1500.0f);
			victim.SetRatio((skill_t3 * 0.1f));
			victim.SetBuffid(1);
			victim.SetDecaccuracy(true);
			if ( player.GetObjectType() || (v9 = player, GNET::PlayerWrapper::GetVar2(v9) <= 0) )
			v18 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetAmount((player_var3 * (player_var1 * 0.005f)));
			victim.SetMpdisperse(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4013};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill4015 : GSkill
	{
		public GSkill4015()
			: base(4015)
		{
			
		}
	}
	public class GSkill4016Stub : GSkillStub
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
				return 125;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();

				skill.SetPlus(((3 * player_level)));
				player.SetVar1(player_level);
				player.SetPerform(1);
			}
		}
		public GSkill4016Stub()
			: base(4016)
		{
			occupation = 57;
			maxlevel = 6;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 10;
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
			SetAction(0,"ÐùÔ¯_ÏßÐÎ°µÈº");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_ÏßÐÎ°µÈº");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_ÏßÐÎ°µÈº");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_ÏßÐÎ°µÈº");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ËéÄù¡¤½Ù¡¤°µÏã¸¡¶¯";
			nativename = "ËéÄù¡¤½Ù¡¤°µÏã¸¡¶¯";
			icon = "ËéÄù¡¤½Ù¡¤°µÏã¸¡¶¯.dds";
			SetTalent(0,4127);
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
			castInPreSkill = true;
			preCastSkillId = 4014;
			darkLightType = 1;
			followskill = 0;
			targetcnt = 6;
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={65,70,75,80,85};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 19.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				player_level = player.GetLevel();

			return (3 * player_level);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 6;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((10 * skill_t0 + (10 * skill_level + (3 * player_var1)))));
			victim.SetTime(3000.0f);
			victim.SetSilent(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4014};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill4016 : GSkill
	{
		public GSkill4016()
			: base(4016)
		{
			
		}
	}
	public class GSkill4017Stub : GSkillStub
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
				return 125;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();

				skill.SetPlus(((skill_level * player_maxmp / 100 + (3 * player_level))));
				player.SetVar1(player_level);
				player.SetPerform(1);
			}
		}
		public GSkill4017Stub()
			: base(4017)
		{
			occupation = 57;
			maxlevel = 6;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 1;
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
			SetAction(0,"ÐùÔ¯_ÏßÐÎ¹âÈº");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_ÏßÐÎ¹âÈº");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_ÏßÐÎ¹âÈº");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_ÏßÐÎ¹âÈº");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ËéÄù¡¤î¸¡¤Á¬ÐÇ";
			nativename = "ËéÄù¡¤î¸¡¤Á¬ÐÇ";
			icon = "ËéÄù¡¤î¸¡¤Á¬ÐÇ.dds";
			SetTalent(0,4144);
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
			castInPreSkill = true;
			preCastSkillId = 4015;
			darkLightType = 2;
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={65,70,75,80,85};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 2.000000f;
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 19.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				player_level = player.GetLevel();

			return (3 * player_level);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 10;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((10 * skill_t0 + (10 * skill_level + (3 * player_var1)))));
			victim.SetTime(2000.0f);
			victim.SetDizzy(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4015};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill4017 : GSkill
	{
		public GSkill4017()
			: base(4017)
		{
			
		}
	}
	public class GSkill4018Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1050;
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
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();

				/*
				  v10 = (50 * skill_level + 400);
				v9 = 0.002f * player_maxmp;
				if ( player.GetSkilllevel(4011) >= skill_level )
				  {
				    v8 = skill_level * v9;
				  }
				  else
				  {
				v8 = player.GetSkilllevel(4011) * v9;
				  }
				skill.SetPlus((v10 + v8));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4018Stub()
			: base(4018)
		{
			occupation = 58;
			maxlevel = 10;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 14;
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
			weapon_limit = 9;
			SetAction(0,"ÐùÔ¯_ÄÜ»·");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_ÄÜ»·");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_ÄÜ»·");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_ÄÜ»·");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ËéÄù¡¤ÃÖÂ½";
			nativename = "ËéÄù¡¤ÃÖÂ½";
			icon = "ËéÄù¡¤ÃÖÂ½.dds";
			SetTalent(0,4151);
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
			return 1550;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 200;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={75,77,79,81,83,85,87,89,91};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 19.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 19.000000f;
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
			return 100.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return 2 * skill_t0 + 10;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill4018 : GSkill
	{
		public GSkill4018()
			: base(4018)
		{
			
		}
	}
	public class GSkill4019Stub : GSkillStub
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

				player.SetVar1(player.GetHasbuff(4241));
				player.SetPerform(1);
			}
		}
		public GSkill4019Stub()
			: base(4019)
		{
			occupation = 58;
			maxlevel = 8;
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
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 3;
			chargedist = 20.000000f;
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
			name = "Á«»ª¡¤Ë²";
			nativename = "Á«»ª¡¤Ë²";
			icon = "Á«»ª¡¤Ë².dds";
			SetTalent(0,4161);
			SetTalent(1,4160);
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
			int[] array={80,84,88,92,96,100};return array[level-1];
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
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			/*
			victim.SetProbability(((120 * skill_t0)));
			victim.SetTime(3100.0f);
			victim.SetRatio((skill_t0 * 0.1f));
			victim.SetBuffid(1);
			victim.SetIncskilldodge(true);
			if ( player_var1 || skill_t1 <= 0 )
			v28 = 0.0f;
			else
			victim.SetProbability(((10 * skill_level)));
			victim.SetAmount(skill_t1);
			victim.SetCleardebuff(true);
			if ( player_var1 )
			v27 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetRatio(3.0f);
			victim.SetUnsummonclone(true);
			victim.SetProbability(120.0f);
			if ( player_var1 )
			t = 10.0f;
			else
			victim.SetTime(6000.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(2);
			victim.SetValue(4544.0f);
			victim.SetDelaycast(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();

			/*
			if ( player_var1 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(6000.0f);
			victim.SetRatio(3.0f);
			victim.SetBuffid(1);
			victim.SetAmount(1.0f);
			victim.SetValue(54786.0f);
			victim.SetSummonclone(true);
			if ( player_var1 )
			v26 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(6200.0f);
			victim.SetRecordpos(true);
			if ( player_var1 )
			v25 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetReturnpos(true);
			if ( player_var1 )
			v24 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetRatio(4241.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetDispel(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4018};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill4019 : GSkill
	{
		public GSkill4019()
			: base(4019)
		{
			
		}
	}
}
