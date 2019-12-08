using System;
using System.Text;

namespace SKILL
{
	public class GSkill3580Stub : GSkillStub
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
				int				player_maxhp = player.GetMaxhp();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_level * 0.05f + 1.2f));
				skill.SetPlus((skill_t0 * ((norm(skill_t0) * player_maxhp) * 0.02f) + (skill_level * ((player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) * 0.2f))));
				player.SetPerform(1);
			}
		}
		public GSkill3580Stub()
			: base(3580)
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
			SetAction(0,"·ÙÏã¹È_ÍòÏó¾ãËð");
			SetAction(1,"·ÙÏã¹È_ÍòÏó¾ãËð");
			SetAction(2,"·ÙÏã¹È_ÍòÏó¾ãËð");
			SetAction(3,"·ÙÏã¹È_ÍòÏó¾ãËð");
			SetAction(4,"·ÙÏã¹È_ÍòÏó¾ãËð");
			SetAction(5,"·ÙÏã¹È_ÍòÏó¾ãËð");
			SetAction(6,"·ÙÏã¹È_ÍòÏó¾ãËð");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËð");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËð");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËð");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËð");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËð");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËð");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËð");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ì«Ô¨Òµº£<ìø>";
			nativename = "Ì«Ô¨Òµº£<ìø>";
			icon = "·ð¡¤Ì«Ô¨Òµº£.dds";
			SetTalent(0,3406);
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
			return 30000;
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
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (6 * (skill_level + (skill_level * skill_level)) + 1660);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 10;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res3 = player.GetRes3();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			if ( player_var1 - player_res3 <= 0 )
			{
			d = 0.0f;
			}
			else
			{
			d = (player_var1 - player_res3);
			}
			victim.SetProbability(d);
			victim.SetTime(6000.0f);
			victim.SetRatio(((skill_level + 300)));
			victim.SetBuffid(4);
			victim.SetValue(3863.0f);
			victim.SetDelaycast(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3452};return array[index];
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

			return 4 * skill_level * skill_level + (34 * skill_level) + 200;
		}
	}
	public class GSkill3580 : GSkill
	{
		public GSkill3580()
			: base(3580)
		{
			
		}
	}
	public class GSkill3581Stub : GSkillStub
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
		public GSkill3581Stub()
			: base(3581)
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
			rangetype = 0;
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
			SetAction(0,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(1,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(2,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(3,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(4,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(5,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(6,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾ÓñÑô¡¿");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "·ÙÏãÓñ²á<ìø>";
			nativename = "·ÙÏãÓñ²á<ìø>";
			icon = "·ð¡¤·ÙÏãÓñ²á.dds";
			SetTalent(0,3404);
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
			int				skill_t0 = skill.GetT0();

			return 120000 - 20000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (10 * skill_level * skill_level + 1500);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			v12 = 3 * (skill_level / 5) + 5;
			if ( skill_level / 4 + 2 <= player.GetDebuffcnt() )
			{
			t = (1000 * (2 * (skill_level / 4) + v12) + 4000);
			}
			else
			{
			t = (1000 * (2 * player.GetDebuffcnt() + v12));
			}
			victim.SetTime(t);
			victim.SetBuffid(1);
			victim.SetAmount(((skill_level / 4 + 2)));
			victim.SetTurndebuff(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(100.0f);
			victim.SetTime(((120000 - 20000 * skill_t0)));
			victim.SetRatio(3453.0f);
			victim.SetAmount(3453.0f);
			victim.SetValue(3453.0f);
			victim.SetSetcooldown(true);
			victim.SetProbability(100.0f);
			v27 = 3 * (skill_level / 5) + 5;
			if ( skill_level / 4 + 2 <= player.GetDebuffcnt() )
			{
			t = (1000 * (2 * (skill_level / 4) + v27) + 4000);
			}
			else
			{
			t = (1000 * (2 * player.GetDebuffcnt() + v27));
			}
			victim.SetTime(t);
			v25 = skill_level;
			v24 = skill_level / 5 + 6;
			if ( skill_level / 4 + 2 <= player.GetDebuffcnt() )
			{
			v23 = v24 * (skill_level / 4 + 2);
			}
			else
			{
			v23 = v24 * player.GetDebuffcnt();
			}
			victim.SetRatio(((v23 + v25 + 20) * 0.01f));
			victim.SetAmount(0.0f);
			victim.SetValue(100.0f);
			victim.SetRetort(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3453};return array[index];
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

			return 3 * skill_level * skill_level + (32 * skill_level) + 200;
		}
	}
	public class GSkill3581 : GSkill
	{
		public GSkill3581()
			: base(3581)
		{
			
		}
	}
	public class GSkill3582Stub : GSkillStub
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
		public GSkill3582Stub()
			: base(3582)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
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
			SetAction(0,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾°ËÐ×¡¿");
			SetAction(1,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾°ËÐ×¡¿");
			SetAction(2,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾°ËÐ×¡¿");
			SetAction(3,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾°ËÐ×¡¿");
			SetAction(4,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾°ËÐ×¡¿");
			SetAction(5,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾°ËÐ×¡¿");
			SetAction(6,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾°ËÐ×¡¿");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾°ËÐ×¡¿");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾°ËÐ×¡¿");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾°ËÐ×¡¿");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾°ËÐ×¡¿");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾°ËÐ×¡¿");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾°ËÐ×¡¿");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾°ËÐ×¡¿");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "°ËÐ×Ðþ»ð<ìø>";
			nativename = "°ËÐ×Ðþ»ð<ìø>";
			icon = "·ð¡¤°ËÐ×Ðþ»ð.dds";
			SetTalent(0,3421);
			SetTalent(1,3422);
			SetTalent(2,326);
			SetTalent(3,3408);
			SetTalent(4,327);
			SetTalent(5,3758);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 6;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = true;
			cyclemode = 1;
			cyclegfx = "·¨Õó°ËÐ×";
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
			int				skill_t5 = skill.GetT5();

            return (int)(((180000 - 15000 * skill_t1)) - skill_t5 * 3600.0f);
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return (10 * skill_level * skill_level + 3500);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(((20 * skill_t3)));
			victim.SetBreakcasting(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_charging = skill.GetCharging();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(0.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(0);
			victim.SetAmount(3373.0f);
			victim.SetValue(2.0f);
			victim.SetCycle(true);
			if ( zrand(100) >= 2 * player.GetSkilllevel(3759) )
			d = 218.0f;
			else
			victim.SetRatio(3449.0f);
			victim.SetAmount(218.0f);
			victim.SetValue(218.0f);
			victim.SetClearcooldown(true);
			victim.SetProbability(120.0f);
			victim.SetTime(50.0f);
			v38 = skill_charging > 0x1194;
			v36 = skill_charging > 0x9C4;
			if ( player.GetCyclemembercnt() > 3 )
			v37 = 100 * v36;
			else
			v37 = 0;
			skill_charging;
			if ( player.GetCyclemembercnt() > 0 )
			v35 = 100;
			else
			v35 = 0;
			v34 = skill_level;
			v33 = skill_t0 * player.GetCyclemembercnt();
			if ( player.GetCyclemembercnt() == 6 )
			v39 = v33 + v34 + v35 + 100 * v38 + v37 + 10;
			else
			v39 = v33 + v34 + v35 + v37 + 10;
			if ( skill_charging <= 0x12C0 )
			v32 = v39;
			else
			victim.SetRatio(((v39 + 10)));
			victim.SetBuffid(1);
			victim.SetValue(3862.0f);
			victim.SetDelaycast(true);
			victim.SetTime(500.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetEvilaura(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3454};return array[index];
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

			return 3 * skill_level * skill_level + (22 * skill_level) + 300;
		}
	}
	public class GSkill3582 : GSkill
	{
		public GSkill3582()
			: base(3582)
		{
			
		}
	}
	public class GSkill3583Stub : GSkillStub
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();

				player.SetVar1(player_res3);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.35f)));
				skill.SetPlus(((5 * skill_level * skill_level + 180)));
				player.SetPerform(1);
			}
		}
		public GSkill3583Stub()
			: base(3583)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
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
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_Ñ¸À×´¸");
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
			SetAction(11,"Ì«ê»_Ñ¸À×´¸");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_Ñ¸À×´¸");
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
			SetAction(29,"Ì«ê»_Æï³Ë_Ñ¸À×´¸");
			SetAction(30,"0");
			name = "ÈýÉúÅÐ<ìø>";
			nativename = "ÈýÉúÅÐ<ìø>";
			icon = "·ð¡¤ÈýÉúÅÐ.dds";
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
			skill_class = 10;
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
			return 15000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.500000f;
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

			return (3 * skill_level * skill_level + (10 * skill_level) + 570);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res3 = player.GetRes3();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetTime(((1000 * skill_level)));
			victim.SetRatio(((skill_level + 5) * 0.01f));
			victim.SetBuffid(0);
			victim.SetDecskilldamage(true);
			if ( player.GetHasmultbuff(11) == 1 )
			{
			if ( player_var1 - player_res3 <= 0 )
			{
			v29 = 0.0f;
			}
			else
			{
			v29 = (player_var1 - player_res3);
			}
			v30 = v29;
			}
			else
			{
			v30 = 0.0f;
			}
			victim.SetProbability(v30);
			victim.SetTime(100.0f);
			victim.SetRatio(skill_level);
			victim.SetBuffid(1);
			victim.SetValue(3593.0f);
			victim.SetDelaycast(true);
			victim.SetProbability(((3 * skill_level)));
			victim.SetAmount(((D2INT(skill_level / 5) + 1)));
			victim.SetClearbuff(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3498};return array[index];
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
	public class GSkill3583 : GSkill
	{
		public GSkill3583()
			: base(3583)
		{
			
		}
	}
	public class GSkill3584Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1200;
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3584Stub()
			: base(3584)
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
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_×£¸£");
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
			SetAction(11,"Ì«ê»_×£¸£");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_×£¸£");
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
			SetAction(29,"Ì«ê»_Æï³Ë_×£¸£");
			SetAction(30,"0");
			name = "·üôË»ê<Ðþ>";
			nativename = "·üôË»ê<Ðþ>";
			icon = "ÏÉ¡¤·üôË»ê.dds";
			SetTalent(0,3549);
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
			skill_class = 10;
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

			return 120000 - 10000 * skill_t0;
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

			return (4 * skill_level * skill_level + (10 * skill_level) + 500);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetTime(((3000 * skill_t0 + (1000 * skill_level) + 10000)));
			victim.SetRatio((skill_level * 0.05f));
			victim.SetBuffid(2);
			victim.SetInccrithurt(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((3000 * skill_t0 + (1000 * skill_level) + 10000)));
			victim.SetRatio((skill_level * 0.04f));
			victim.SetValue((skill_level * 0.04f));
			victim.SetSwift(true);
			victim.SetProbability(0.0f);
			victim.SetTime(((3000 * skill_t0 + (1000 * skill_level) + 10000)));
			victim.SetRatio(4099.0f);
			victim.SetBuffid(0);
			victim.SetAmount(skill_level);
			victim.SetValue(3586.0f);
			victim.SetActiveonfilteradd(true);
			victim.SetProbability(1.0f);
			victim.SetTime(((3000 * skill_t0 + (1000 * skill_level) + 10000)));
			victim.SetRatio(4098.0f);
			victim.SetBuffid(1);
			victim.SetAmount(skill_level);
			victim.SetValue(3639.0f);
			victim.SetActiveonfilteradd(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(0.0f);
			victim.SetTime(((3000 * skill_t0 + (1000 * skill_level) + 10000)));
			victim.SetRatio(4350.0f);
			victim.SetBuffid(2);
			victim.SetAmount(skill_level);
			victim.SetValue(3640.0f);
			victim.SetActiveonfilteradd(true);
			victim.SetProbability(1.0f);
			victim.SetTime(((3000 * skill_t0 + (1000 * skill_level) + 10000)));
			victim.SetRatio(4097.0f);
			victim.SetBuffid(3);
			victim.SetAmount(skill_level);
			victim.SetValue(3641.0f);
			victim.SetActiveonfilteradd(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3502};return array[index];
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
	public class GSkill3584 : GSkill
	{
		public GSkill3584()
			: base(3584)
		{
			
		}
	}
	public class GSkill3585Stub : GSkillStub
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

				player.SetVar1(player_res4);
				player.SetPerform(1);
			}
		}
		public GSkill3585Stub()
			: base(3585)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
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
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_×çÖä");
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
			SetAction(11,"Ì«ê»_×çÖä");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_×çÖä");
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
			SetAction(29,"Ì«ê»_Æï³Ë_×çÖä");
			SetAction(30,"0");
			name = "¹íÉñÆø<Ðþ>";
			nativename = "¹íÉñÆø<Ðþ>";
			icon = "ÏÉ¡¤¹íÉñÆø.dds";
			SetTalent(0,3527);
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
			skill_class = 10;
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

			return 90000 - 10000 * skill_t0;
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
			return 7.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (4 * skill_level * skill_level + 1050);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res4 = player.GetRes4();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			if ( player_var1 - player_res4 <= 0 )
			{
			v36 = (20 * norm(skill_level / 19.99f));
			}
			else
			{
			v36 = (20 * norm(skill_level / 19.99f) + (player_var1 - player_res4));
			}
			victim.SetProbability(v36);
			victim.SetTime(((1000 * skill_level + 5000)));
			victim.SetRatio(1.0f);
			victim.SetBuffid(0);
			victim.SetAmount(0.0f);
			victim.SetValue((skill_level * 0.05f));
			victim.SetGuishen2(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((1000 * skill_level + 5000)));
			victim.SetValue(((skill_level + 5)));
			victim.SetCrippleddebuff(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((1000 * skill_level + 5000)));
			victim.SetRatio((D2INT(skill_level / 2) * 0.01f + 0.01f));
			victim.SetBuffid(1);
			victim.SetIncfatalratio(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3501};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
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
	public class GSkill3585 : GSkill
	{
		public GSkill3585()
			: base(3585)
		{
			
		}
	}
	public class GSkill3586Stub : GSkillStub
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
		public GSkill3586Stub()
			: base(3586)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 20;
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
			name = "·âÉñ·üôË»ê-¶¨Éí¼¤»îÐ§¹û";
			nativename = "·âÉñ·üôË»ê-¶¨Éí¼¤»îÐ§¹û";
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

			AddState(new GState1());
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

			victim.SetTime(8000.0f);
			victim.SetImmunewrap(true);
			victim.SetProbability(120.0f);
			victim.SetTime(8000.0f);
			victim.SetRatio((skill_level * 0.01f + 0.05f));
			victim.SetBuffid(1);
			victim.SetIncskillaccu(true);
			return true;
		}
	}
	public class GSkill3586 : GSkill
	{
		public GSkill3586()
			: base(3586)
		{
			
		}
	}
	public class GSkill3587Stub : GSkillStub
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
				int				player_res1 = player.GetRes1();
				int				skill_level = skill.GetLevel();

				player.SetVar1(player_res1);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.35f)));
				skill.SetPlus(((5 * skill_level * skill_level + 180)));
				player.SetPerform(1);
			}
		}
		public GSkill3587Stub()
			: base(3587)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 20;
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
			clearmask = 2;
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
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_Ñ¸À×´¸");
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
			SetAction(11,"Ì«ê»_Ñ¸À×´¸");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_Ñ¸À×´¸");
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
			SetAction(29,"Ì«ê»_Æï³Ë_Ñ¸À×´¸");
			SetAction(30,"0");
			name = "ÈýÉúÅÐ<É·>";
			nativename = "ÈýÉúÅÐ<É·>";
			icon = "Ä§¡¤ÈýÉúÅÐ.dds";
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
			skill_class = 10;
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
			return 15000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.500000f;
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

			return (3 * skill_level * skill_level + (10 * skill_level) + 570);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res1 = player.GetRes1();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetTime(((1000 * skill_level)));
			victim.SetRatio(((skill_level + 5) * 0.01f));
			victim.SetBuffid(0);
			victim.SetDecskilldamage(true);
			victim.SetProbability(((3 * skill_level)));
			victim.SetAmount(((D2INT(skill_level / 5) + 1)));
			victim.SetClearbuff(true);
			if ( player_var1 - player_res1 <= 0 )
			{
			v36 = (20 * norm(skill_level / 19.99f));
			}
			else
			{
			v36 = (20 * norm(skill_level / 19.99f) + (player_var1 - player_res1));
			}
			victim.SetProbability(v36);
			victim.SetTime(((5000 * norm(skill_level / 19.99f) + (1000 * D2INT(skill_level / 5)) + 2000)));
			victim.SetRatio((skill_level * 0.03f + 0.2f));
			victim.SetValue((skill_level * 0.03f + 0.2f));
			victim.SetParalysis(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3498};return array[index];
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
	public class GSkill3587 : GSkill
	{
		public GSkill3587()
			: base(3587)
		{
			
		}
	}
	public class GSkill3588Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				player.SetVar1(1);
				skill.SetCrit((skill_level * 0.01f));
				skill.SetCrithurt((skill_level * 0.03f));
				skill.SetRatio((skill_level * 0.02f + 1.0f));
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				player.SetVar1(0);
				skill.SetCrit((skill_level * 0.01f));
				skill.SetCrithurt((skill_level * 0.03f));
				skill.SetRatio((skill_level * 0.02f + 1.0f));
				skill.SetPlus(((5 * skill_level * skill_level + (60 * skill_level) + 55)));
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

				player.SetVar1(0);
				skill.SetCrit((skill_level * 0.01f));
				skill.SetCrithurt((skill_level * 0.03f));
				skill.SetRatio((skill_level * 0.02f + 1.0f));
				skill.SetPlus(((5 * skill_level * skill_level + (60 * skill_level) + 55)));
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

				player.SetVar1(0);
				skill.SetCrit((skill_level * 0.01f));
				skill.SetCrithurt((skill_level * 0.03f));
				skill.SetRatio((skill_level * 0.02f + 1.0f));
				skill.SetPlus(((5 * skill_level * skill_level + (60 * skill_level) + 55)));
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				player.SetVar1(0);
				skill.SetCrit((skill_level * 0.01f));
				skill.SetCrithurt((skill_level * 0.03f));
				skill.SetRatio((skill_level * 0.02f + 1.0f));
				skill.SetPlus(((5 * skill_level * skill_level + (60 * skill_level) + 55)));
				player.SetPerform(0);
			}
		}
		public GSkill3588Stub()
			: base(3588)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 20;
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
			clearmask = 2;
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
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_À×öªÕðÅ­");
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
			SetAction(11,"Ì«ê»_À×öªÕðÅ­");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_À×öªÕðÅ­");
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
			SetAction(29,"Ì«ê»_Æï³Ë_À×öªÕðÅ­");
			SetAction(30,"0");
			name = "Ç¬À¤µ´<É·>";
			nativename = "Ç¬À¤µ´<É·>";
			icon = "Ä§¡¤Ç¬À¤µ´.dds";
			SetTalent(0,3587);
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
			skill_class = 10;
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 4000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.500000f;
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

			return (5 * skill_level * skill_level + (10 * skill_level) + 700);
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			if ( player_var1 == 1 )
			{
			d = (skill_t0 + (2 * skill_level) + 20);
			}
			else
			{
			d = 0.0f;
			}
			victim.SetProbability(d);
			victim.SetTime(15000.0f);
			victim.SetAmount(skill_level);
			victim.SetValue(3858.0f);
			victim.SetTriggerskill(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(10.0f);
			victim.SetRatio(3858.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetSetcooldown(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3499};return array[index];
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

			return 4 * skill_level * skill_level + (34 * skill_level) + 200;
		}
	}
	public class GSkill3588 : GSkill
	{
		public GSkill3588()
			: base(3588)
		{
			
		}
	}
	public class GSkill3589Stub : GSkillStub
	{
		public GSkill3589Stub()
			: base(3589)
		{
			occupation = 168;
			maxlevel = 25;
			maxlearn = 20;
			eventflag = 1;
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
			name = "ÌìµØ¾øìø-Çå³ý×ÔÉí¼¼ÄÜÐ§¹û";
			nativename = "ÌìµØ¾øìø-Çå³ý×ÔÉí¼¼ÄÜÐ§¹û";
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

			victim.SetRatio(3859.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetClearcooldown(true);
			return true;
		}
	}
	public class GSkill3589 : GSkill
	{
		public GSkill3589()
			: base(3589)
		{
			
		}
	}
}
