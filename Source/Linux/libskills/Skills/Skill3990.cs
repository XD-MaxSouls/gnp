using System;
using System.Text;

namespace SKILL
{
	public class GSkill3990Stub : GSkillStub
	{
		public GSkill3990Stub()
			: base(3990)
		{
			occupation = 129;
			maxlevel = 99;
			maxlearn = 99;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 13;
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
			SetAction(0,"");
			SetAction(1,"");
			SetAction(2,"");
			SetAction(3,"");
			SetAction(4,"");
			SetAction(5,"");
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
			SetAction(18,"");
			SetAction(19,"");
			SetAction(20,"");
			SetAction(21,"");
			SetAction(22,"");
			SetAction(23,"");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÈË»Ê¶Ò»»¼Ó¹¥·À";
			nativename = "ÈË»Ê¶Ò»»¼Ó¹¥·À";
			icon = "";
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

			victim.SetProbability(100.0f);
			victim.SetTime(28800000.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(1);
			victim.SetValue(100.0f);
			victim.SetHupo(true);
			victim.SetProbability(100.0f);
			victim.SetTime(28800000.0f);
			victim.SetRatio(0.050000001f);
			victim.SetBuffid(1);
			victim.SetValue(70.0f);
			victim.SetGuilin(true);
			victim.SetProbability(100.0f);
			victim.SetTime(28800000.0f);
			victim.SetRatio(0.050000001f);
			victim.SetBuffid(9);
			victim.SetIncattack(true);
			victim.SetProbability(100.0f);
			victim.SetTime(28800000.0f);
			victim.SetRatio(0.050000001f);
			victim.SetBuffid(9);
			victim.SetIncdefence(true);
			return true;
		}
	}
	public class GSkill3990 : GSkill
	{
		public GSkill3990()
			: base(3990)
		{
			
		}
	}
	public class GSkill3997Stub : GSkillStub
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
				return 325;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();

				float pp;
				float p = 0.002f * player_maxmp;
				if ( player.GetSkilllevel(4011) >= skill_level )
				{
					pp = skill_level * p;
				}
				else
				{
					pp = player.GetSkilllevel(4011) * p;
				}
				skill.SetPlus((((20 * skill_level + 50) * norm(30 / player_level)) + (5 * skill_level + 10) + pp));
				player.SetPerform(1);
				/**/
			}
		}
		public GSkill3997Stub()
			: base(3997)
		{
			occupation = 56;
			maxlevel = 8;
			maxlearn = 6;
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
			weapon_limit = 9;
			SetAction(0,"ÐùÔ¯_·Éµ¯");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_·Éµ¯");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_·Éµ¯");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·Éµ¯");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¾»Äù¡¤Ë·ÐÇ";
			nativename = "¾»Äù¡¤Ë·ÐÇ";
			icon = "¾»Äù¡¤Ë·ÐÇ.dds";
			SetTalent(0,4149);
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
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 11;
			guide = false;
			summon_id = -1;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = -1;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1075;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 200;
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
			int				skill_t0 = skill.GetT0();

			return (2 * skill_t0 + 17);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return (2 * skill_t0 + 15);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return (2 * skill_t0 + 20);
		}
		public override float GetMpcost(GSkill skill)
		{
			return 10.000000f;
		}
	}
	public class GSkill3997 : GSkill
	{
		public GSkill3997()
			: base(3997)
		{
			
		}
	}
	public class GSkill3998Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 425;
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
				return 450;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_var1 = player.GetVar1();

				/*
				if ( player_mp >= player_maxmp / 10 )
				  {
				v = player_maxmp / 10;
				  }
				  else
				  {
				v = player_mp;
				  }
				player.SetVar1(v);
				player.SetMp(((player_mp - player_var1)));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill3998Stub()
			: base(3998)
		{
			occupation = 56;
			maxlevel = 9;
			maxlearn = 7;
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
			SetAction(0,"ÐùÔ¯_»¤¶Ü");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_»¤¶Ü");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_»¤¶Ü");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_»¤¶Ü");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Àï½ç¡¤ö«ÔÆ";
			nativename = "Àï½ç¡¤ö«ÔÆ";
			icon = "Àï½ç¡¤ö«ÔÆ.dds";
			SetTalent(0,4154);
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
			return 875;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 20000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={10,12,14,16,18,20,22};return array[level-1];
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
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(120.0f);
			victim.SetRatio(4240.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetDispel(true);
			victim.SetTime(60000.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(((player_var1 * skill_level)));
			victim.SetDechurt2(true);
			if ( skill_t0 <= 0 )
			t = 0.0f;
			else
			victim.SetTime(60000.0f);
			victim.SetBuffid(1);
			victim.SetValue(((player_var1 * skill_t0)));
			victim.SetAddmp(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3997};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3998 : GSkill
	{
		public GSkill3998()
			: base(3998)
		{
			
		}
	}
	public class GSkill3999Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 625;
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
		public GSkill3999Stub()
			: base(3999)
		{
			occupation = 56;
			maxlevel = 10;
			maxlearn = 8;
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
			SetAction(0,"ÐùÔ¯_¼ÓËÙ");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"ÐùÔ¯_¼ÓËÙ");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÐùÔ¯_Æï³Ë_¼ÓËÙ");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¼ÓËÙ");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "½ç¡¤¶Ý¹âÊ½¡¤Ç§ÐÐ";
			nativename = "½ç¡¤¶Ý¹âÊ½¡¤Ç§ÐÐ";
			icon = "½ç¡¤¶Ý¹âÊ½¡¤Ç§ÐÐ.dds";
			SetTalent(0,4155);
			SetTalent(1,4158);
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
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 875;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 60000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={20,22,24,26,28,30,32,34};return array[level-1];
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
			return 100.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 8000)));
			victim.SetBuffid(1);
			victim.SetValue(4.0f);
			victim.SetAddspeed(true);
			victim.SetProbability(((33 * skill_t1 + 1)));
			victim.SetRatio(2.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetDispel(true);
			if ( zrand(100) >= 10 * skill_t0 )
			v20 = 0.0f;
			else
			victim.SetRatio(4010.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetClearcooldown(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3998};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3999 : GSkill
	{
		public GSkill3999()
			: base(3999)
		{
			
		}
	}
}
