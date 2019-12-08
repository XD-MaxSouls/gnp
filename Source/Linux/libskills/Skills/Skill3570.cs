using System;
using System.Text;

namespace SKILL
{
	public class GSkill3570Stub : GSkillStub
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

				player.SetVar1(player_res4);
				skill.SetRatio((skill_level * 0.05f + 1.2f));
				skill.SetPlus((skill_t0 * ((norm(skill_t0) * player_maxhp) * 0.02f) + (skill_level * ((player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) * 0.2f))));
				player.SetPerform(1);
			}
		}
		public GSkill3570Stub()
			: base(3570)
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
			rangetype = 3;
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
			SetAction(0,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(1,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(2,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(3,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(4,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(5,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(6,"·ÙÏã¹È_ÍòÏó¾ãËğ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ì«Ô¨Òµº£<Ğş>";
			nativename = "Ì«Ô¨Òµº£<Ğş>";
			icon = "ÏÉ¡¤Ì«Ô¨Òµº£.dds";
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
			int				player_res4 = player.GetRes4();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			if ( player_var1 - player_res4 <= 0 )
			{
			d = 0.0f;
			}
			else
			{
			d = (player_var1 - player_res4);
			}
			victim.SetProbability(d);
			victim.SetTime(6000.0f);
			victim.SetRatio(((skill_level + 100)));
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
	public class GSkill3570 : GSkill
	{
		public GSkill3570()
			: base(3570)
		{
			
		}
	}
	public class GSkill3571Stub : GSkillStub
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
		public GSkill3571Stub()
			: base(3571)
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
			rangetype = 0;
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
			name = "·ÙÏãÓñ²á<Ğş>";
			nativename = "·ÙÏãÓñ²á<Ğş>";
			icon = "ÏÉ¡¤·ÙÏãÓñ²á.dds";
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
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((120000 - 20000 * skill_t0)));
			victim.SetRatio(3453.0f);
			victim.SetAmount(3453.0f);
			victim.SetValue(3453.0f);
			victim.SetSetcooldown(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * (skill_level / 5) + 5000)));
			victim.SetRatio(1.0f);
			victim.SetAmount(40.0f);
			v24 = player_maxhp;
			v23 = skill_level / 5 + 1;
			if ( skill_level / 4 + 2 <= player.GetDebuffcnt() )
			{
			v22 = (0.01f * (v23 * (skill_level / 4 + 2))) + 0.05f;
			}
			else
			{
			v22 = (0.01f * (v23 * player.GetDebuffcnt())) + 0.05f;
			}
			victim.SetValue((v24 * v22));
			victim.SetHpregain(true);
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
	public class GSkill3571 : GSkill
	{
		public GSkill3571()
			: base(3571)
		{
			
		}
	}
	public class GSkill3572Stub : GSkillStub
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
		public GSkill3572Stub()
			: base(3572)
		{
			occupation = 167;
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
			SetAction(0,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(1,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(2,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(3,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(4,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(5,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(6,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "°ËĞ×Ğş»ğ<Ğş>";
			nativename = "°ËĞ×Ğş»ğ<Ğş>";
			icon = "ÏÉ¡¤°ËĞ×Ğş»ğ.dds";
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
			cyclegfx = "·¨Õó°ËĞ×";
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
			victim.SetValue(3860.0f);
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
	public class GSkill3572 : GSkill
	{
		public GSkill3572()
			: base(3572)
		{
			
		}
	}
	public class GSkill3573Stub : GSkillStub
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

				player.SetVar1(player_res4);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.35f)));
				skill.SetPlus(((5 * skill_level * skill_level + 180)));
				player.SetPerform(1);
			}
		}
		public GSkill3573Stub()
			: base(3573)
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
			name = "ÈıÉúÅĞ<Ğş>";
			nativename = "ÈıÉúÅĞ<Ğş>";
			icon = "ÏÉ¡¤ÈıÉúÅĞ.dds";
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
			int				player_res4 = player.GetRes4();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			victim.SetTime(((1000 * skill_level)));
			victim.SetRatio(((skill_level + 5) * 0.01f));
			victim.SetBuffid(0);
			victim.SetDecskilldamage(true);
			victim.SetProbability(((3 * skill_level)));
			victim.SetAmount(((D2INT(skill_level / 5) + 1)));
			victim.SetClearbuff(true);
			victim.SetProbability(((20 * norm(skill_level / 19.99f) + (player_var1 - player_res4))));
			victim.SetTime(((5000 * norm(skill_level / 19.99f) + (1000 * D2INT(skill_level / 5)) + 2000)));
			victim.SetValue(skill_level);
			victim.SetCrippleddebuff(true);
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
	public class GSkill3573 : GSkill
	{
		public GSkill3573()
			: base(3573)
		{
			
		}
	}
	public class GSkill3574Stub : GSkillStub
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
		public GSkill3574Stub()
			: base(3574)
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
			doenchant = false;
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
			SetAction(0,"Ì«ê»_À×öªÕğÅ­");
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
			SetAction(11,"Ì«ê»_À×öªÕğÅ­");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_À×öªÕğÅ­");
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
			SetAction(29,"Ì«ê»_Æï³Ë_À×öªÕğÅ­");
			SetAction(30,"0");
			name = "Ç¬À¤µ´<Ğş>";
			nativename = "Ç¬À¤µ´<Ğş>";
			icon = "ÏÉ¡¤Ç¬À¤µ´.dds";
			SetTalent(0,3573);
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
			d = (10 * norm(skill_level / 19.99f) + (skill_t0 + (2 * skill_level)) + 20);
			}
			else
			{
			d = 0.0f;
			}
			victim.SetProbability(d);
			victim.SetTime(15000.0f);
			victim.SetAmount(skill_level);
			victim.SetValue(3857.0f);
			victim.SetTriggerskill(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(10.0f);
			victim.SetRatio(3857.0f);
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
	public class GSkill3574 : GSkill
	{
		public GSkill3574()
			: base(3574)
		{
			
		}
	}
	public class GSkill3575Stub : GSkillStub
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
				return 300;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				/*
				player.SetVar1(player_maxatk);
				  v16 = 0.05f * (skill_level / 2);
				if ( zrand(100) < 2 * (skill_level / 2) + 1 )
				    v15 = v16 + 0.01f;
				  else
				skill.SetCrithurt(((0.0f * v16) + 0.01f));
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
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
				return 700;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
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
				return 700;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
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
				return 700;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				/*
				player.SetVar1(player_maxatk);
				  v16 = 0.05f * (skill_level / 2);
				if ( zrand(100) < 3 * (skill_level / 2) + 1 )
				    v15 = v16 + 0.01f;
				  else
				skill.SetCrithurt(((0.0f * v16) + 0.01f));
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
				player.SetPerform(0);
				*/
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
				return 300;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
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
				return 300;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState8 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				/*
				player.SetVar1(player_maxatk);
				  v16 = 0.05f * (skill_level / 2);
				if ( zrand(100) < 5 * (skill_level / 2) + 1 )
				    v15 = v16 + 0.01f;
				  else
				skill.SetCrithurt(((0.0f * v16) + 0.01f));
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
				player.SetPerform(0);
				*/
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState9 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState10 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
				player.SetPerform(0);
			}
		}
		public GSkill3575Stub()
			: base(3575)
		{
			occupation = 168;
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
			weapon_limit = -1;
			SetAction(0,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(1,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(2,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(3,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(4,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(5,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(6,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÄÏÎ×Ìì»ğ<É·>";
			nativename = "ÄÏÎ×Ìì»ğ<É·>";
			icon = "Ä§¡¤ÄÏÎ×Ìì»ğ.dds";
			SetTalent(0,3381);
			SetTalent(1,3384);
			SetTalent(2,3389);
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
			AddState(new GState4());
			AddState(new GState5());
			AddState(new GState6());
			AddState(new GState7());
			AddState(new GState8());
			AddState(new GState9());
			AddState(new GState10());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 5000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 16000 - 3000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 21.000000f/*xxxx*/;
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

			return (26 * skill_level + 2374);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			return 4 * skill_t2 + (skill_level / 2) + 20;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_t0 = skill.GetT0();

			/*
			v17 = 5 * skill_t0 + 15;
			if ( player.GetHasbuff(4120) == 1 )
			v16 = (v17 - 10);
			else
			victim.SetProbability(v17);
			victim.SetTime(16100.0f);
			victim.SetRatio(8.0f);
			if ( player.GetHasbuff(4120) == 1 )
			v15 = zrand(2) + 1;
			else
			victim.SetBuffid((zrand(5) + 1));
			victim.SetAmount(9.0f);
			victim.SetValue((player_var1 * 0.05f));
			victim.SetFiring(true);
			*/
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3451};return array[index];
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

			return 4 * skill_level * skill_level + (42 * skill_level) + 200;
		}
	}
	public class GSkill3575 : GSkill
	{
		public GSkill3575()
			: base(3575)
		{
			
		}
	}
	public class GSkill3576Stub : GSkillStub
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

				player.SetVar1(player_res1);
				skill.SetRatio((skill_level * 0.05f + 1.2f));
				skill.SetPlus((skill_t0 * ((norm(skill_t0) * player_maxhp) * 0.02f) + (skill_level * ((player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) * 0.2f))));
				player.SetPerform(1);
			}
		}
		public GSkill3576Stub()
			: base(3576)
		{
			occupation = 168;
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
			weapon_limit = -1;
			SetAction(0,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(1,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(2,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(3,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(4,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(5,"·ÙÏã¹È_ÍòÏó¾ãËğ");
			SetAction(6,"·ÙÏã¹È_ÍòÏó¾ãËğ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÍòÏó¾ãËğ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ì«Ô¨Òµº£<É·>";
			nativename = "Ì«Ô¨Òµº£<É·>";
			icon = "Ä§¡¤Ì«Ô¨Òµº£.dds";
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
			int				player_res1 = player.GetRes1();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			if ( player_var1 - player_res1 <= 0 )
			{
			d = 0.0f;
			}
			else
			{
			d = (player_var1 - player_res1);
			}
			victim.SetProbability(d);
			victim.SetTime(6000.0f);
			victim.SetRatio(((skill_level + 200)));
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
	public class GSkill3576 : GSkill
	{
		public GSkill3576()
			: base(3576)
		{
			
		}
	}
	public class GSkill3577Stub : GSkillStub
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
		public GSkill3577Stub()
			: base(3577)
		{
			occupation = 168;
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
			name = "·ÙÏãÓñ²á<É·>";
			nativename = "·ÙÏãÓñ²á<É·>";
			icon = "Ä§¡¤·ÙÏãÓñ²á.dds";
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
			int				player_maxatk = player.GetMaxatk();
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
			v33 = 3 * (skill_level / 5) + 5;
			if ( skill_level / 4 + 2 <= player.GetDebuffcnt() )
			{
			t = (1000 * (2 * (skill_level / 4) + v33) + 4000);
			}
			else
			{
			t = (1000 * (2 * player.GetDebuffcnt() + v33));
			}
			victim.SetTime(t);
			victim.SetRatio(1.0f);
			v31 = skill_level / 5 + 4;
			if ( skill_level / 4 + 2 <= player.GetDebuffcnt() )
			{
			d = (v31 + skill_level / 4 + 2);
			}
			else
			{
			d = (v31 + player.GetDebuffcnt());
			}
			victim.SetAmount(d);
			v29 = player_maxatk;
			v28 = (0.01f * (skill_level / 5)) + 0.01f;
			if ( skill_level / 4 + 2 <= player.GetDebuffcnt() )
			{
			v27 = (skill_level / 4 + 2) * 0.01f + v28;
			}
			else
			{
			v27 = player.GetDebuffcnt() * 0.01f + v28;
			}
			victim.SetValue((v29 * v27));
			victim.SetFrenzied(true);
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
	public class GSkill3577 : GSkill
	{
		public GSkill3577()
			: base(3577)
		{
			
		}
	}
	public class GSkill3578Stub : GSkillStub
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
		public GSkill3578Stub()
			: base(3578)
		{
			occupation = 168;
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
			weapon_limit = -1;
			SetAction(0,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(1,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(2,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(3,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(4,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(5,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(6,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾°ËĞ×¡¿");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "°ËĞ×Ğş»ğ<É·>";
			nativename = "°ËĞ×Ğş»ğ<É·>";
			icon = "Ä§¡¤°ËĞ×Ğş»ğ.dds";
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
			cyclegfx = "·¨Õó°ËĞ×";
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
			victim.SetValue(3861.0f);
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
	public class GSkill3578 : GSkill
	{
		public GSkill3578()
			: base(3578)
		{
			
		}
	}
	public class GSkill3579Stub : GSkillStub
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
				return 300;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				/*
				player.SetVar1(player_maxatk);
				  v16 = 0.01f * (skill_level / 5 + 1);
				if ( zrand(100) < 2 * (skill_level / 2) + 1 )
				    v15 = v16;
				  else
				skill.SetCrit((0.0f * v16));
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
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
				return 700;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
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
				return 700;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
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
				return 700;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				/*
				player.SetVar1(player_maxatk);
				  v16 = 0.01f * (skill_level / 5 + 4);
				if ( zrand(100) < 3 * (skill_level / 2) + 1 )
				    v15 = v16;
				  else
				skill.SetCrit((0.0f * v16));
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
				player.SetPerform(0);
				*/
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
				return 300;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
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
				return 300;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState8 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				/*
				player.SetVar1(player_maxatk);
				  v16 = 0.01f * (skill_level / 5 + 6);
				if ( zrand(100) < 5 * (skill_level / 2) + 1 )
				    v15 = v16;
				  else
				skill.SetCrit((0.0f * v16));
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
				player.SetPerform(0);
				*/
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState9 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState10 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.04f + ((4 * (skill_level + ((2 * skill_level - 30) * (skill_level / 15)))) * 0.01f + 1.0f)));
				skill.SetPlus(((3 * skill_level * skill_level + (21 * skill_level) + 375)));
				player.SetPerform(0);
			}
		}
		public GSkill3579Stub()
			: base(3579)
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
			SetAction(0,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(1,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(2,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(3,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(4,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(5,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(6,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÄÏÎ×Ìì»ğ<ìø>";
			nativename = "ÄÏÎ×Ìì»ğ<ìø>";
			icon = "·ğ¡¤ÄÏÎ×Ìì»ğ.dds";
			SetTalent(0,3381);
			SetTalent(1,3384);
			SetTalent(2,3389);
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
			AddState(new GState4());
			AddState(new GState5());
			AddState(new GState6());
			AddState(new GState7());
			AddState(new GState8());
			AddState(new GState9());
			AddState(new GState10());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 5000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 16000 - 3000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 21.000000f/*xxxx*/;
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

			return (26 * skill_level + 2374);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			return 4 * skill_t2 + (skill_level / 2) + 20;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_t0 = skill.GetT0();

			/*
			v17 = 5 * skill_t0 + 15;
			if ( player.GetHasbuff(4120) == 1 )
			v16 = (v17 - 10);
			else
			victim.SetProbability(v17);
			victim.SetTime(16100.0f);
			victim.SetRatio(8.0f);
			if ( player.GetHasbuff(4120) == 1 )
			v15 = zrand(2) + 1;
			else
			victim.SetBuffid((zrand(5) + 1));
			victim.SetAmount(9.0f);
			victim.SetValue((player_var1 * 0.05f));
			victim.SetFiring(true);
			*/
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3451};return array[index];
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

			return 4 * skill_level * skill_level + (42 * skill_level) + 200;
		}
	}
	public class GSkill3579 : GSkill
	{
		public GSkill3579()
			: base(3579)
		{
			
		}
	}
}
