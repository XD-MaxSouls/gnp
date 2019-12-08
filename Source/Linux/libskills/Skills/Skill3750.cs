using System;
using System.Text;

namespace SKILL
{
	public class GSkill3750Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio((skill_level * 0.05f + 1.0f));
				player.SetPerform(1);
			}
		}
		public GSkill3750Stub()
			: base(3750)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
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
			credittype = 9;
			clearmask = 129;
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
			SetAction(0,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾¿ªÑô¡¿");
			SetAction(1,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾¿ªÑô¡¿");
			SetAction(2,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾¿ªÑô¡¿");
			SetAction(3,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾¿ªÑô¡¿");
			SetAction(4,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾¿ªÑô¡¿");
			SetAction(5,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾¿ªÑô¡¿");
			SetAction(6,"·ÙÏã¹È_·ÙÏãÓñ²á¡¾¿ªÑô¡¿");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾¿ªÑô¡¿");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾¿ªÑô¡¿");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾¿ªÑô¡¿");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾¿ªÑô¡¿");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾¿ªÑô¡¿");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾¿ªÑô¡¿");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·ÙÏãÓñ²á¡¾¿ªÑô¡¿");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ĞşÑô»ğµäII";
			nativename = "ĞşÑô»ğµäII";
			icon = "ĞşÑô»ğµäII.dds";
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
			return 120000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 2500.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level)));
			victim.SetRatio((skill_level * 0.01f + 0.05f));
			victim.SetInchurt(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3447};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill3750 : GSkill
	{
		public GSkill3750()
			: base(3750)
		{
			
		}
	}
	public class GSkill3751Stub : GSkillStub
	{
		public GSkill3751Stub()
			: base(3751)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 11;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 10;
			clearmask = 130;
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
			name = "·áÂöII";
			nativename = "·áÂöII";
			icon = "·áÂöII.dds";
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3365};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={8};return array[index];
		}
	}
	public class GSkill3751 : GSkill
	{
		public GSkill3751()
			: base(3751)
		{
			
		}
	}
	public class GSkill3752Stub : GSkillStub
	{
		public GSkill3752Stub()
			: base(3752)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 11;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 10;
			clearmask = 130;
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
			name = "ÓÄÑ×ÖäII";
			nativename = "ÓÄÑ×ÖäII";
			icon = "ÓÄÑ×ÖäII.dds";
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3425};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={8};return array[index];
		}
	}
	public class GSkill3752 : GSkill
	{
		public GSkill3752()
			: base(3752)
		{
			
		}
	}
	public class GSkill3753Stub : GSkillStub
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

				player.SetVar1(player_maxatk);
				player.SetPerform(1);
			}
		}
		public GSkill3753Stub()
			: base(3753)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 10;
			clearmask = 130;
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
			name = "»ğÁÔ»¤Ö÷II";
			nativename = "»ğÁÔ»¤Ö÷II";
			icon = "»ğÁÔ»¤Ö÷II.dds";
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 60000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 6);
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

			return (40 * skill_level + 800);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((5 * skill_level)));
			victim.SetTime(((2000 * skill_level)));
			victim.SetRatio(6.0f);
			victim.SetBuffid(5);
			victim.SetAmount(8.0f);
			victim.SetValue((player_var1 * 0.3f));
			victim.SetFiring(true);
			if ( zrand(100) >= 5 * skill_level )
			v26 = 0.0f;
			else
			victim.SetProbability(600.0f);
			victim.SetTime(((1000 * skill_level)));
			v25 = skill_level * 0.04f;
			v24 = 0.02f * skill_level;
			if ( player.GetHasmultbuff(113) == 1 )
			v23 = v24;
			else
			victim.SetRatio((v25 + (0.0f * v24)));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(((skill_level * 1.5f + 6.0f) * 1000.0f));
			victim.SetRatio(0.0f);
			victim.SetAmount(49.0f);
			victim.SetValue(0.0f);
			victim.SetEvilaura(true);
			victim.SetProbability(99.0f);
			victim.SetRatio(4123.0f);
			victim.SetAmount(4123.0f);
			victim.SetValue(4123.0f);
			victim.SetDispel(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3435};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={8};return array[index];
		}
	}
	public class GSkill3753 : GSkill
	{
		public GSkill3753()
			: base(3753)
		{
			
		}
	}
	public class GSkill3754Stub : GSkillStub
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_hp);
				player.SetVar2(player_maxatk);
				player.SetPerform(1);
			}
		}
		public GSkill3754Stub()
			: base(3754)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
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
			credittype = 10;
			clearmask = 130;
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
			SetAction(0,"·ÙÏã¹È_»ğÑæ³Í½ä");
			SetAction(1,"·ÙÏã¹È_»ğÑæ³Í½ä");
			SetAction(2,"·ÙÏã¹È_»ğÑæ³Í½ä");
			SetAction(3,"·ÙÏã¹È_»ğÑæ³Í½ä");
			SetAction(4,"·ÙÏã¹È_»ğÑæ³Í½ä");
			SetAction(5,"·ÙÏã¹È_»ğÑæ³Í½ä");
			SetAction(6,"·ÙÏã¹È_»ğÑæ³Í½ä");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_»ğÑæ³Í½ä");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_»ğÑæ³Í½ä");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_»ğÑæ³Í½ä");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_»ğÑæ³Í½ä");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_»ğÑæ³Í½ä");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_»ğÑæ³Í½ä");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_»ğÑæ³Í½ä");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ñ×±øÖË»êII";
			nativename = "Ñ×±øÖË»êII";
			icon = "Ñ×±øÖË»êII.dds";
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
			return 90000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
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

			return (40 * skill_level + 800);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();

			/*
			if ( skill_level <= 4 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 5000)));
			victim.SetRatio(6.0f);
			victim.SetBuffid(6);
			victim.SetAmount(8.0f);
			victim.SetValue((player_var2 * 0.3f));
			victim.SetFiring(true);
			if ( skill_level <= 8 )
			v71 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 5000)));
			victim.SetRatio(6.0f);
			victim.SetBuffid(7);
			victim.SetAmount(8.0f);
			victim.SetValue((player_var2 * 0.3f));
			victim.SetFiring(true);
			victim.SetProbability(100.0f);
			v70 = player_var1 * ((0.01f * skill_level) + 0.05f);
			if ( D2INT(player.GetHasbuff(5439) + (player.GetHasbuff(5438) + (player.GetHasbuff(5437) + (player.GetHasbuff(5436) + (player.GetHasbuff(5435) + (player.GetHasbuff(5434) + (player.GetHasbuff(5433) + (player.GetHasbuff(5432) + (player.GetHasbuff(5431) + player.GetHasbuff(5430)))))))))) > 8 )
			{
			v69 = 8.0f * v70;
			}
			else
			{
			v69 = D2INT(player.GetHasbuff(5439) + (player.GetHasbuff(5438) + (player.GetHasbuff(5437) + (player.GetHasbuff(5436) + (player.GetHasbuff(5435) + (player.GetHasbuff(5434) + (player.GetHasbuff(5433) + (player.GetHasbuff(5432) + (player.GetHasbuff(5431) + player.GetHasbuff(5430)))))))))) * v70;
			}
			victim.SetValue(v69);
			victim.SetDirecthurt(true);
			*/
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3434};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill3754 : GSkill
	{
		public GSkill3754()
			: base(3754)
		{
			
		}
	}
	public class GSkill3755Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				player_maxatk = player.GetMaxatk();
				int				player_var1 = player.GetVar1();
				int				skill_level = skill.GetLevel();

				skill.SetRatio(0.0f);
				player.SetVar1(player_hp);
				player.SetVar2(player_maxatk);
				player.SetHp((player_hp - player_hp * (skill_level * 0.05f)));
				skill.SetPlus(((player_var1 - player_hp) * (skill_level * 0.02f)));
				player.SetPerform(1);
			}
		}
		public GSkill3755Stub()
			: base(3755)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
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
			credittype = 10;
			clearmask = 130;
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
			SetAction(0,"·ÙÏã¹È_»ğÑæÂûÑÓ");
			SetAction(1,"·ÙÏã¹È_»ğÑæÂûÑÓ");
			SetAction(2,"·ÙÏã¹È_»ğÑæÂûÑÓ");
			SetAction(3,"·ÙÏã¹È_»ğÑæÂûÑÓ");
			SetAction(4,"·ÙÏã¹È_»ğÑæÂûÑÓ");
			SetAction(5,"·ÙÏã¹È_»ğÑæÂûÑÓ");
			SetAction(6,"·ÙÏã¹È_»ğÑæÂûÑÓ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_»ğÑæÂûÑÓ");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_»ğÑæÂûÑÓ");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_»ğÑæÂûÑÓ");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_»ğÑæÂûÑÓ");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_»ğÑæÂûÑÓ");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_»ğÑæÂûÑÓ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_»ğÑæÂûÑÓ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "³ãÑ×Ç§ÀïII";
			nativename = "³ãÑ×Ç§ÀïII";
			icon = "³ãÑ×Ç§ÀïII.dds";
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
			return 45000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
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
		public override float GetMpcost(GSkill skill)
		{
			return 950.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();

			/*
			if ( player.GetHasmultbuff(113) == 1 )
			d = (10 * skill_level);
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((1000 * skill_level + 5000)));
			victim.SetRatio(6.0f);
			victim.SetBuffid(8);
			victim.SetAmount(8.0f);
			victim.SetValue((player_var2 * 0.3f));
			victim.SetFiring(true);
			*/
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3444};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill3755 : GSkill
	{
		public GSkill3755()
			: base(3755)
		{
			
		}
	}
	public class GSkill3756Stub : GSkillStub
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_skilldodge = player.GetSkilldodge();

				player.SetVar1((int)(player_skilldodge / 9.99f));
				player.SetVar2(1);
				player.SetPerform(1);
			}
		}
		public GSkill3756Stub()
			: base(3756)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 2;
			timetype = 3;
			targettype = 0;
			rangetype = 5;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 11;
			clearmask = 132;
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
			SetAction(0,"·ÙÏã¹È_»ğÑæ½á½ç");
			SetAction(1,"·ÙÏã¹È_»ğÑæ½á½ç");
			SetAction(2,"·ÙÏã¹È_»ğÑæ½á½ç");
			SetAction(3,"·ÙÏã¹È_»ğÑæ½á½ç");
			SetAction(4,"·ÙÏã¹È_»ğÑæ½á½ç");
			SetAction(5,"·ÙÏã¹È_»ğÑæ½á½ç");
			SetAction(6,"·ÙÏã¹È_»ğÑæ½á½ç");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_»ğÑæ½á½ç");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_»ğÑæ½á½ç");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_»ğÑæ½á½ç");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_»ğÑæ½á½ç");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_»ğÑæ½á½ç");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_»ğÑæ½á½ç");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_»ğÑæ½á½ç");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Òµ»ğÉ±II";
			nativename = "Òµ»ğÉ±II";
			icon = "Òµ»ğÉ±II.dds";
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
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 90000 - 3000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
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
			return 800.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();
			int				skill_charging = skill.GetCharging();

			/*
			if ( player_var2 == 1 )
			d = 100.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((2000 * skill_level + 5000)));
			if ( (20.0f - skill_level * ((skill_charging / 0xC8) * 0.1f)) - player_var1 * 0.1f <= 0.0f )
			{
			v52 = 0.0f;
			}
			else
			{
			v52 = (20.0f - skill_level * ((skill_charging / 0xC8) * 0.1f)) - player_var1 * 0.1f;
			}
			victim.SetRatio(v52);
			victim.SetBuffid(2);
			victim.SetAmount(50760.0f);
			victim.SetValue(0.0f);
			victim.SetCreateobject(true);
			if ( player_var2 == 1 )
			v51 = 100.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((2000 * skill_level + 5000)));
			if ( (20.0f - skill_level * ((skill_charging / 0xC8) * 0.1f)) - player_var1 * 0.1f <= 0.0f )
			{
			v50 = 0.0f;
			}
			else
			{
			v50 = (20.0f - skill_level * ((skill_charging / 0xC8) * 0.1f)) - player_var1 * 0.1f;
			}
			victim.SetRatio(v50);
			victim.SetBuffid(2);
			victim.SetAmount(50760.0f);
			victim.SetValue(60.0f);
			victim.SetCreateobject(true);
			if ( player_var2 == 1 )
			v49 = 100.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((2000 * skill_level + 5000)));
			if ( (20.0f - skill_level * ((skill_charging / 0xC8) * 0.1f)) - player_var1 * 0.1f <= 0.0f )
			{
			v48 = 0.0f;
			}
			else
			{
			v48 = (20.0f - skill_level * ((skill_charging / 0xC8) * 0.1f)) - player_var1 * 0.1f;
			}
			victim.SetRatio(v48);
			victim.SetBuffid(2);
			victim.SetAmount(50760.0f);
			victim.SetValue(120.0f);
			victim.SetCreateobject(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();
			int				skill_charging = skill.GetCharging();

			/*
			if ( player_var2 == 1 )
			d = 100.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((2000 * skill_level + 5000)));
			if ( (20.0f - skill_level * ((skill_charging / 0xC8) * 0.1f)) - player_var1 * 0.1f <= 0.0f )
			{
			v52 = 0.0f;
			}
			else
			{
			v52 = (20.0f - skill_level * ((skill_charging / 0xC8) * 0.1f)) - player_var1 * 0.1f;
			}
			victim.SetRatio(v52);
			victim.SetBuffid(2);
			victim.SetAmount(50760.0f);
			victim.SetValue(180.0f);
			victim.SetCreateobject(true);
			if ( player_var2 == 1 )
			v51 = 100.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((2000 * skill_level + 5000)));
			if ( (20.0f - skill_level * ((skill_charging / 0xC8) * 0.1f)) - player_var1 * 0.1f <= 0.0f )
			{
			v50 = 0.0f;
			}
			else
			{
			v50 = (20.0f - skill_level * ((skill_charging / 0xC8) * 0.1f)) - player_var1 * 0.1f;
			}
			victim.SetRatio(v50);
			victim.SetBuffid(2);
			victim.SetAmount(50760.0f);
			victim.SetValue(240.0f);
			victim.SetCreateobject(true);
			if ( player_var2 == 1 )
			v49 = 100.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((2000 * skill_level + 5000)));
			if ( (20.0f - skill_level * ((skill_charging / 0xC8) * 0.1f)) - player_var1 * 0.1f <= 0.0f )
			{
			v48 = 0.0f;
			}
			else
			{
			v48 = (20.0f - skill_level * ((skill_charging / 0xC8) * 0.1f)) - player_var1 * 0.1f;
			}
			victim.SetRatio(v48);
			victim.SetBuffid(2);
			victim.SetAmount(50760.0f);
			victim.SetValue(300.0f);
			victim.SetCreateobject(true);
			*/
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3431};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill3756 : GSkill
	{
		public GSkill3756()
			: base(3756)
		{
			
		}
	}
	public class GSkill3757Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 3500;
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
				return 1500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3757Stub()
			: base(3757)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
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
			credittype = 11;
			clearmask = 132;
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
			SetAction(0,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾¹ÌÕó¡¿");
			SetAction(1,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾¹ÌÕó¡¿");
			SetAction(2,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾¹ÌÕó¡¿");
			SetAction(3,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾¹ÌÕó¡¿");
			SetAction(4,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾¹ÌÕó¡¿");
			SetAction(5,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾¹ÌÕó¡¿");
			SetAction(6,"·ÙÏã¹È_Õó·¨¾«ÑĞ¡¾¹ÌÕó¡¿");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾¹ÌÕó¡¿");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾¹ÌÕó¡¿");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾¹ÌÕó¡¿");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾¹ÌÕó¡¿");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾¹ÌÕó¡¿");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾¹ÌÕó¡¿");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑĞ¡¾¹ÌÕó¡¿");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "°ÔĞ°ÕóII";
			nativename = "°ÔĞ°ÕóII";
			icon = "°ÔĞ°ÕóII.dds";
			SetTalent(0,3408);
			SetTalent(1,3758);
			SetTalent(2,3419);
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
			cycle = true;
			cyclemode = 1;
			cyclegfx = "·¨Õó¹ÌÕó";
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

            return (int)(900000.0f - skill_t1 * 18000.0f);
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
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
			return 1200.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((20 * skill_t0)));
			victim.SetBreakcasting(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_charging = skill.GetCharging();

			/*
			victim.SetProbability(101.0f);
			victim.SetTime(((1000 * skill_t1 + (10000 * (skill_charging / 0x12C0) + (10000 * player.GetCyclemembercnt() + (5000 * skill_level))) - 10000)));
			victim.SetRatio(((10 * player.GetCyclemembercnt() + (5 * skill_t2 + (3 * skill_level)) - 10)));
			victim.SetBuffid(0);
			victim.SetAmount(3604.0f);
			victim.SetValue(2.0f);
			victim.SetCycle(true);
			victim.SetTime(500.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetEvilaura(true);
			if ( zrand(100) >= 2 * player.GetSkilllevel(3759) )
			d = 218.0f;
			else
			victim.SetRatio(3449.0f);
			victim.SetAmount(218.0f);
			victim.SetValue(218.0f);
			victim.SetClearcooldown(true);
			*/
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3432};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill3757 : GSkill
	{
		public GSkill3757()
			: base(3757)
		{
			
		}
	}
	public class GSkill3758Stub : GSkillStub
	{
		public GSkill3758Stub()
			: base(3758)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 11;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 11;
			clearmask = 132;
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
			name = "Ìì×ÚĞÄ·¨II";
			nativename = "Ìì×ÚĞÄ·¨II";
			icon = "Ìì×ÚĞÄ·¨II.dds";
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3440};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={8};return array[index];
		}
	}
	public class GSkill3758 : GSkill
	{
		public GSkill3758()
			: base(3758)
		{
			
		}
	}
	public class GSkill3759Stub : GSkillStub
	{
		public GSkill3759Stub()
			: base(3759)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 11;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 11;
			clearmask = 132;
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
			name = "ÄùÅÌÖØÉúII";
			nativename = "ÄùÅÌÖØÉúII";
			icon = "ÄùÅÌÖØÉúII.dds";
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3449};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill3759 : GSkill
	{
		public GSkill3759()
			: base(3759)
		{
			
		}
	}
}
