using System;
using System.Text;

namespace SKILL
{
	public class GSkill1570Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio((skill_level <= 13)?((0.07000000000000001f * skill_level) + 0.58f):((0.07000000000000001f * (skill_level - 13)) + 0.58f));
				player.SetPerform(1);
			}
		}
		public GSkill1570Stub()
			: base(1570)
		{
			occupation = 149;
			maxlevel = 30;
			maxlearn = 10;
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
			allowform = 4;
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
			SetAction(0,"¸¿×ãÉß¹Æ");
			SetAction(1,"¸¿×ãÉß¹Æ");
			SetAction(2,"¸¿×ãÉß¹Æ");
			SetAction(3,"¸¿×ãÉß¹Æ");
			SetAction(4,"¸¿×ãÉß¹Æ");
			SetAction(5,"¸¿×ãÉß¹Æ");
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
			SetAction(18,"¸¿×ãÉß¹Æ");
			SetAction(19,"¸¿×ãÉß¹Æ");
			SetAction(20,"¸¿×ãÉß¹Æ");
			SetAction(21,"¸¿×ãÉß¹Æ");
			SetAction(22,"¸¿×ãÉß¹Æ");
			SetAction(23,"¸¿×ãÉß¹Æ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¸¿×ãÉß¹ÆII";
			nativename = "¸¿×ãÉß¹ÆII";
			icon = "¸¿×ãÉß¹ÆII.dds";
			SetTalent(0,1182);
			SetTalent(1,1185);
			SetTalent(2,1189);
			SetTalent(3,2062);
			SetTalent(4,1169);
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
			skill_class = 4;
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
			return 7000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 11.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 26.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level <= 13)?(0.2f * ((skill_level * 4.42f + (skill_level * (14.08f * skill_level))) + 1888.0f)):(0.2f * (((skill_level - 13) * 4.42f + ((skill_level - 13) * (14.08f * (skill_level - 13)))) + 1888.0f))/**/;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 12;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

			victim.SetProbability(((skill_t2 * 0.1f + 1.0f) * ((skill_t3 * 0.03f + (1.0f - player_level * 0.002f)) * 100.0f)));
			victim.SetTime(((32000 - 2000 * skill_t2)));
			victim.SetBuffid(3);
			victim.SetAmount((skill_level <= 13)?(player_hp * (skill_t1 * (skill_level * 0.005f)) + ((skill_t1 * 0.1f + 1.0f) * (((skill_level << 7) + (skill_level * (6.27f * skill_level))) + 1837.0f))):((player_hp * (skill_t1 * ((skill_level - 13) * 0.005f)) + ((skill_t1 * 0.1f + 1.0f) * (((skill_level << 7) - 1664) + ((skill_level - 13) * ((skill_level - 13) * 6.27f)) + 1837.0f))) * ((0.4f * skill_t4) + 1.0f)));
			victim.SetValue((skill_level <= 13)?(skill_t0 * (0.1f * (((skill_level << 7) + (skill_level * (6.27f * skill_level))) + 1837.0f))):(skill_t0 * ((skill_t4 * 0.4f + 1.0f) * (0.1f * ((((skill_level << 7) - 1664) + ((skill_level - 13) * (6.27f * (skill_level - 13)))) + 1837.0f)))));
			victim.SetHpleak2(true);
			victim.SetProbability(120.0f);
			victim.SetTime(32000.0f);
			victim.SetBuffid(3);
			victim.SetValue((skill_level <= 13)?(5 * (skill_t0 + 1) * skill_level):((5 * skill_level - 65) * (skill_t0 + 1)));
			victim.SetSubanti(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1117};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={12};return array[index];
		}
	}
	public class GSkill1570 : GSkill
	{
		public GSkill1570()
			: base(1570)
		{
			
		}
	}
	public class GSkill1571Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio((skill_level * 0.07000000000000001f + 0.58f));
				player.SetPerform(1);
			}
		}
		public GSkill1571Stub()
			: base(1571)
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
			allowform = 4;
			credittype = 10;
			clearmask = 130;
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
			SetAction(0,"°Ù¹Æà¢»ê");
			SetAction(1,"°Ù¹Æà¢»ê");
			SetAction(2,"°Ù¹Æà¢»ê");
			SetAction(3,"°Ù¹Æà¢»ê");
			SetAction(4,"°Ù¹Æà¢»ê");
			SetAction(5,"°Ù¹Æà¢»ê");
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
			SetAction(18,"°Ù¹Æà¢»ê");
			SetAction(19,"°Ù¹Æà¢»ê");
			SetAction(20,"°Ù¹Æà¢»ê");
			SetAction(21,"°Ù¹Æà¢»ê");
			SetAction(22,"°Ù¹Æà¢»ê");
			SetAction(23,"°Ù¹Æà¢»ê");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "°Ù¹Æà¢»êII";
			nativename = "°Ù¹Æà¢»êII";
			icon = "°Ù¹Æà¢»êII.dds";
			SetTalent(0,1180);
			SetTalent(1,1185);
			SetTalent(2,1186);
			SetTalent(3,1189);
			SetTalent(4,2062);
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
			skill_class = 4;
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
			return 7000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 24.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((skill_level * 371.84f + (skill_level * (skill_level * 8.960000000000001f)) + 8320.0f) * 0.2f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

			victim.SetProbability(((skill_t3 * 0.1f + 1.0f) * ((skill_t4 * 0.03f + (1.0f - player_level * 0.002f)) * 100.0f)));
			victim.SetTime(((48000 - 2000 * skill_t3)));
			victim.SetBuffid(2);
			victim.SetAmount((player_hp * (skill_level * (skill_t1 * 0.005f)) + ((skill_t1 * 0.1f + 1.0f) * (skill_level * 371.84f + (skill_level * (skill_level * 8.960000000000001f)) + 8320.0f))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((3 * skill_t0 + (5 * skill_level))));
			victim.SetTime(((1000 * skill_t2 + 4100)));
			victim.SetDiet(true);
			victim.SetProbability(((600 * norm(zrand(100) / 67))));
			victim.SetTime(((3050 * skill_t2)));
			victim.SetWrap(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1126};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={12};return array[index];
		}
	}
	public class GSkill1571 : GSkill
	{
		public GSkill1571()
			: base(1571)
		{
			
		}
	}
	public class GSkill1572Stub : GSkillStub
	{
		public GSkill1572Stub()
			: base(1572)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
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
			credittype = 11;
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
			SetAction(0,"ÇàÔÆÃÅ_ð§ÒÀÕæ·¨");
			SetAction(1,"ÇàÔÆÃÅ_ð§ÒÀÕæ·¨");
			SetAction(2,"¹íÍõ×Ú_ð§ÒÀÕæ·¨");
			SetAction(3,"ºÏ»¶ÅÉ_ð§ÒÀÕæ·¨");
			SetAction(4,"ÌìÒôËÂ_ð§ÒÀÕæ·¨");
			SetAction(5,"¹íµÀ_ð§ÒÀÕæ·¨");
			SetAction(6,"·ÙÏã_ð§ÒÀÕæ·¨");
			SetAction(7,"ÊÞÉñ_ð§ÒÀÕæ·¨");
			SetAction(8,"ºüÑý_ð§ÒÀÕæ·¨");
			SetAction(9,"ÐùÔ¯_ð§ÒÀÕæ·¨");
			SetAction(10,"»³¹â_ð§ÒÀÕæ·¨");
			SetAction(11,"Ì«ê»_ð§ÒÀÕæ·¨");
			SetAction(12,"Ìì»ª_ð§ÒÀÕæ·¨");
			SetAction(13,"ÁéÙí_ð§ÒÀÕæ·¨");
			SetAction(14,"Ó¢ÕÐ_ð§ÒÀÕæ·¨");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_ð§ÒÀÕæ·¨");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ð§ÒÀÕæ·¨");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ð§ÒÀÕæ·¨");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_ð§ÒÀÕæ·¨");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ð§ÒÀÕæ·¨");
			SetAction(23,"¹íµÀ_Æï³Ë_ð§ÒÀÕæ·¨");
			SetAction(24,"·ÙÏã_Æï³Ë_ð§ÒÀÕæ·¨");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ð§ÒÀÕæ·¨");
			SetAction(26,"ºüÑý_Æï³Ë_ð§ÒÀÕæ·¨");
			SetAction(27,"ÐùÔ¯_Æï³Ë_ð§ÒÀÕæ·¨");
			SetAction(28,"»³¹â_Æï³Ë_ð§ÒÀÕæ·¨");
			SetAction(29,"Ì«ê»_Æï³Ë_ð§ÒÀÕæ·¨");
			SetAction(30,"Ìì»ª_Æï³Ë_ð§ÒÀÕæ·¨");
			name = "ð§ÒÀÕæ·¨";
			nativename = "ð§ÒÀÕæ·¨";
			icon = "ð§ÒÀÕæ·¨.dds";
			SetTalent(0,1574);
			SetTalent(1,1576);
			SetTalent(2,1578);
			SetTalent(3,1580);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 4;
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
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,90,90,95,100,105,110,115,120,125};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			player.SetPasdecfatalratio((((skill_level / 10) * (skill_t3 / 10 + (skill_t2 / 10 + (skill_t1 / 10 + (skill_t0 / 10))))) * 0.01f));
			player.SetPasaddhp(((15 * skill_level * skill_level + (90 * skill_level))));
			player.SetPasadddizzy(((4 * skill_level)));
			player.SetPasincskilldodge(((50 * norm(skill_level / 9.9f))));
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={10000,12000,14000,16000,18000,20000,22000,24000,26000,30000};return array[level-1];
		}
	}
	public class GSkill1572 : GSkill
	{
		public GSkill1572()
			: base(1572)
		{
			
		}
	}
	public class GSkill1573Stub : GSkillStub
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

				skill.SetRatio(1.0f);
				player.SetPerform(1);
			}
		}
		public GSkill1573Stub()
			: base(1573)
		{
			occupation = 150;
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
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 11;
			clearmask = 4;
			skill_limit = 3;
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
			SetAction(0,"ÇàÔÆÃÅ_Á¶ÓüÄ§½Ù");
			SetAction(1,"ÇàÔÆÃÅ_Á¶ÓüÄ§½Ù");
			SetAction(2,"¹íÍõ×Ú_Á¶ÓüÄ§½Ù");
			SetAction(3,"ºÏ»¶ÅÉ_Á¶ÓüÄ§½Ù");
			SetAction(4,"ÌìÒôËÂ_Á¶ÓüÄ§½Ù");
			SetAction(5,"¹íµÀ_Á¶ÓüÄ§½Ù");
			SetAction(6,"·ÙÏã¹È_Á¶ÓüÄ§½Ù");
			SetAction(7,"ÊÞÉñ_Á¶ÓüÄ§½Ù");
			SetAction(8,"ºüÑý_Á¶ÓüÄ§½Ù");
			SetAction(9,"ÐùÔ¯_Á¶ÓüÄ§½Ù");
			SetAction(10,"»³¹â_Á¶ÓüÄ§½Ù");
			SetAction(11,"Ì«ê»_Á¶ÓüÄ§½Ù");
			SetAction(12,"Ìì»ª_Á¶ÓüÄ§½Ù");
			SetAction(13,"ÁéÙí_Á¶ÓüÄ§½Ù");
			SetAction(14,"Ó¢ÕÐ_Á¶ÓüÄ§½Ù");
			SetAction(15,"ÎäÆ÷´óÊ¦_Á¶ÓüÄ§½Ù");
			SetAction(16,"ÔªËØ´óÊ¦_Á¶ÓüÄ§½Ù");
			SetAction(17,"ÌìÒôËÂ_Á¶ÓüÄ§½Ù");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_Á¶ÓüÄ§½Ù");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Á¶ÓüÄ§½Ù");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Á¶ÓüÄ§½Ù");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_Á¶ÓüÄ§½Ù");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Á¶ÓüÄ§½Ù");
			SetAction(23,"¹íµÀ_Æï³Ë_Á¶ÓüÄ§½Ù");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_Á¶ÓüÄ§½Ù");
			SetAction(25,"ÊÞÉñ_Æï³Ë_Á¶ÓüÄ§½Ù");
			SetAction(26,"ºüÑý_Æï³Ë_Á¶ÓüÄ§½Ù");
			SetAction(27,"ÐùÔ¯_Æï³Ë_Á¶ÓüÄ§½Ù");
			SetAction(28,"»³¹â_Æï³Ë_Á¶ÓüÄ§½Ù");
			SetAction(29,"Ì«ê»_Æï³Ë_Á¶ÓüÄ§½Ù");
			SetAction(30,"Ìì»ª_Æï³Ë_Á¶ÓüÄ§½Ù");
			name = "Á¶ÓüÄ§½Ù";
			nativename = "Á¶ÓüÄ§½Ù";
			icon = "Á¶ÓüÄ§½Ù.dds";
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
			return 2700000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 12);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 10);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 15);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (345 * skill_level + 6000);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability((((6 * skill_level + 34) * norm((player_level / 60)))));
			victim.SetGohome(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(0.80000001f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1573 : GSkill
	{
		public GSkill1573()
			: base(1573)
		{
			
		}
	}
	public class GSkill1574Stub : GSkillStub
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
		public GSkill1574Stub()
			: base(1574)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 11;
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
			SetAction(0,"ÇàÔÆÃÅ_ÎÞÏàÎÞÎÒ");
			SetAction(1,"ÇàÔÆÃÅ_ÎÞÏàÎÞÎÒ");
			SetAction(2,"¹íÍõ×Ú_ÎÞÏàÎÞÎÒ");
			SetAction(3,"ºÏ»¶ÅÉ_ÎÞÏàÎÞÎÒ");
			SetAction(4,"ÌìÒôËÂ_ÎÞÏàÎÞÎÒ");
			SetAction(5,"¹íµÀ_ÎÞÏàÎÞÎÒ");
			SetAction(6,"·ÙÏã¹È_ÎÞÏàÎÞÎÒ");
			SetAction(7,"ÊÞÉñ_ÎÞÏàÎÞÎÒ");
			SetAction(8,"ºüÑý_ÎÞÏàÎÞÎÒ");
			SetAction(9,"ÐùÔ¯_ÎÞÏàÎÞÎÒ");
			SetAction(10,"»³¹â_ÎÞÏàÎÞÎÒ");
			SetAction(11,"Ì«ê»_ÎÞÏàÎÞÎÒ");
			SetAction(12,"Ìì»ª_ÎÞÏàÎÞÎÒ");
			SetAction(13,"ÁéÙí_ÎÞÏàÎÞÎÒ");
			SetAction(14,"Ó¢ÕÐ_ÎÞÏàÎÞÎÒ");
			SetAction(15,"ÎäÆ÷´óÊ¦_ÎÞÏàÎÞÎÒ");
			SetAction(16,"ÔªËØ´óÊ¦_ÎÞÏàÎÞÎÒ");
			SetAction(17,"ÌìÒôËÂ_ÎÞÏàÎÞÎÒ");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_ÎÞÏàÎÞÎÒ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ÎÞÏàÎÞÎÒ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÎÞÏàÎÞÎÒ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_ÎÞÏàÎÞÎÒ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ÎÞÏàÎÞÎÒ");
			SetAction(23,"¹íµÀ_Æï³Ë_ÎÞÏàÎÞÎÒ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÎÞÏàÎÞÎÒ");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ÎÞÏàÎÞÎÒ");
			SetAction(26,"ºüÑý_Æï³Ë_ÎÞÏàÎÞÎÒ");
			SetAction(27,"ÐùÔ¯_Æï³Ë_ÎÞÏàÎÞÎÒ");
			SetAction(28,"»³¹â_Æï³Ë_ÎÞÏàÎÞÎÒ");
			SetAction(29,"Ì«ê»_Æï³Ë_ÎÞÏàÎÞÎÒ");
			SetAction(30,"Ìì»ª_Æï³Ë_ÎÞÏàÎÞÎÒ");
			name = "ÎÞÏàÎÞÎÒ";
			nativename = "ÎÞÏàÎÞÎÒ";
			icon = "ÎÞÏàÎÞÎÒ.dds";
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
			return 600000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
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

			return (45 * skill_level + 1125);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * skill_level)));
			victim.SetBuffid(8);
			victim.SetValue(((30 * skill_level)));
			victim.SetSubanti(true);
			victim.SetProbability(25.0f);
			victim.SetTime(600000.0f);
			victim.SetRatio(1547.0f);
			victim.SetAmount(1548.0f);
			victim.SetValue(1550.0f);
			victim.SetSetcooldown(true);
			victim.SetProbability(25.0f);
			victim.SetTime(600000.0f);
			victim.SetRatio(1551.0f);
			victim.SetAmount(1554.0f);
			victim.SetValue(1553.0f);
			victim.SetSetcooldown(true);
			victim.SetProbability(25.0f);
			victim.SetTime(600000.0f);
			victim.SetRatio(1555.0f);
			victim.SetAmount(1556.0f);
			victim.SetValue(1546.0f);
			victim.SetSetcooldown(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetRatio(((4 * norm(zrand(100) / (90 - 5 * skill_level)) + 1572)));
			victim.SetAmount(((5 * norm(zrand(100) / (90 - 5 * skill_level)) + 1572)));
			victim.SetValue(((6 * norm(zrand(100) / (90 - 5 * skill_level)) + 1572)));
			victim.SetClearcooldown(true);
			victim.SetRatio(((7 * norm(zrand(100) / (90 - 5 * skill_level)) + 1572)));
			victim.SetAmount(1572.0f);
			victim.SetValue(1572.0f);
			victim.SetClearcooldown(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1574 : GSkill
	{
		public GSkill1574()
			: base(1574)
		{
			
		}
	}
	public class GSkill1575Stub : GSkillStub
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
		public GSkill1575Stub()
			: base(1575)
		{
			occupation = 150;
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
			autoattack = true;
			allowform = 0;
			credittype = 11;
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
			SetAction(0,"ÇàÔÆÃÅ_À×ÒôÌìÅ­");
			SetAction(1,"ÇàÔÆÃÅ_À×ÒôÌìÅ­");
			SetAction(2,"¹íÍõ×Ú_À×ÒôÌìÅ­");
			SetAction(3,"ºÏ»¶ÅÉ_À×ÒôÌìÅ­");
			SetAction(4,"ÌìÒôËÂ_À×ÒôÌìÅ­");
			SetAction(5,"¹íµÀ_À×ÒôÌìÅ­");
			SetAction(6,"·ÙÏã¹È_À×ÒôÌìÅ­");
			SetAction(7,"ÊÞÉñ_À×ÒôÌìÅ­");
			SetAction(8,"ºüÑý_À×ÒôÌìÅ­");
			SetAction(9,"ÐùÔ¯_À×ÒôÌìÅ­");
			SetAction(10,"»³¹â_À×ÒôÌìÅ­");
			SetAction(11,"Ì«ê»_À×ÒôÌìÅ­");
			SetAction(12,"Ìì»ª_À×ÒôÌìÅ­");
			SetAction(13,"ÁéÙí_À×ÒôÌìÅ­");
			SetAction(14,"Ó¢ÕÐ_À×ÒôÌìÅ­");
			SetAction(15,"ÎäÆ÷´óÊ¦_À×ÒôÌìÅ­");
			SetAction(16,"ÔªËØ´óÊ¦_À×ÒôÌìÅ­");
			SetAction(17,"ÌìÒôËÂ_À×ÒôÌìÅ­");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_À×ÒôÌìÅ­");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_À×ÒôÌìÅ­");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_À×ÒôÌìÅ­");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_À×ÒôÌìÅ­");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_À×ÒôÌìÅ­");
			SetAction(23,"¹íµÀ_Æï³Ë_À×ÒôÌìÅ­");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_À×ÒôÌìÅ­");
			SetAction(25,"ÊÞÉñ_Æï³Ë_À×ÒôÌìÅ­");
			SetAction(26,"ºüÑý_Æï³Ë_À×ÒôÌìÅ­");
			SetAction(27,"ÐùÔ¯_Æï³Ë_À×ÒôÌìÅ­");
			SetAction(28,"»³¹â_Æï³Ë_À×ÒôÌìÅ­");
			SetAction(29,"Ì«ê»_Æï³Ë_À×ÒôÌìÅ­");
			SetAction(30,"Ìì»ª_Æï³Ë_À×ÒôÌìÅ­");
			name = "À×ÒôÌìÅ­";
			nativename = "À×ÒôÌìÅ­";
			icon = "À×ÒôÌìÅ­.dds";
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
			return 600000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
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
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1575 : GSkill
	{
		public GSkill1575()
			: base(1575)
		{
			
		}
	}
	public class GSkill1576Stub : GSkillStub
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
		public GSkill1576Stub()
			: base(1576)
		{
			occupation = 150;
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
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 11;
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
			SetAction(0,"ÇàÔÆÃÅ_·ð×ðÓÓ»¤");
			SetAction(1,"ÇàÔÆÃÅ_·ð×ðÓÓ»¤");
			SetAction(2,"¹íÍõ×Ú_·ð×ðÓÓ»¤");
			SetAction(3,"ºÏ»¶ÅÉ_·ð×ðÓÓ»¤");
			SetAction(4,"ÌìÒôËÂ_·ð×ðÓÓ»¤");
			SetAction(5,"¹íµÀ_·ð×ðÓÓ»¤");
			SetAction(6,"·ÙÏã¹È_·ð×ðÓÓ»¤");
			SetAction(7,"ÊÞÉñ_·ð×ðÓÓ»¤");
			SetAction(8,"ºüÑý_·ð×ðÓÓ»¤");
			SetAction(9,"ÐùÔ¯_·ð×ðÓÓ»¤");
			SetAction(10,"»³¹â_·ð×ðÓÓ»¤");
			SetAction(11,"Ì«ê»_·ð×ðÓÓ»¤");
			SetAction(12,"Ìì»ª_·ð×ðÓÓ»¤");
			SetAction(13,"ÁéÙí_·ð×ðÓÓ»¤");
			SetAction(14,"Ó¢ÕÐ_·ð×ðÓÓ»¤");
			SetAction(15,"ÎäÆ÷´óÊ¦_·ð×ðÓÓ»¤");
			SetAction(16,"ÔªËØ´óÊ¦_·ð×ðÓÓ»¤");
			SetAction(17,"ÌìÒôËÂ_·ð×ðÓÓ»¤");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_·ð×ðÓÓ»¤");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·ð×ðÓÓ»¤");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·ð×ðÓÓ»¤");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·ð×ðÓÓ»¤");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·ð×ðÓÓ»¤");
			SetAction(23,"¹íµÀ_Æï³Ë_·ð×ðÓÓ»¤");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·ð×ðÓÓ»¤");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·ð×ðÓÓ»¤");
			SetAction(26,"ºüÑý_Æï³Ë_·ð×ðÓÓ»¤");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·ð×ðÓÓ»¤");
			SetAction(28,"»³¹â_Æï³Ë_·ð×ðÓÓ»¤");
			SetAction(29,"Ì«ê»_Æï³Ë_·ð×ðÓÓ»¤");
			SetAction(30,"Ìì»ª_Æï³Ë_·ð×ðÓÓ»¤");
			name = "·ð×ð±ÓÓÓ";
			nativename = "·ð×ð±ÓÓÓ";
			icon = "·ð×ð±ÓÓÓII.dds";
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
			return 600000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 12.000000f;
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

			return (35 * skill_level + 1335);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * skill_level + 15100)));
			victim.SetBuffid(9);
			victim.SetValue(((norm(player_level / 90) * 0.8f + 0.2f) * ((120 * skill_level))));
			victim.SetAdddefence(true);
			victim.SetProbability(((norm(player_level / 90) * 0.8f + 0.2f) * 100.0f));
			victim.SetAmount(1.0f);
			victim.SetCleardebuff(true);
			victim.SetProbability(((skill_level / 10) * ((norm(player_level / 90) * 0.8f + 0.2f) * 100.0f)));
			victim.SetAmount(1.0f);
			victim.SetCleardebuff(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * skill_level + 15100)));
			victim.SetRatio((norm((player_level / 90)) * 0.3f + (skill_level * 0.02f)));
			victim.SetBuffid(8);
			victim.SetIncattack(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1576 : GSkill
	{
		public GSkill1576()
			: base(1576)
		{
			
		}
	}
	public class GSkill1577Stub : GSkillStub
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
		public GSkill1577Stub()
			: base(1577)
		{
			occupation = 150;
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
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 11;
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
			SetAction(0,"ÇàÔÆÃÅ_Ã÷¾»ÁéÌ¨");
			SetAction(1,"ÇàÔÆÃÅ_Ã÷¾»ÁéÌ¨");
			SetAction(2,"¹íÍõ×Ú_Ã÷¾»ÁéÌ¨");
			SetAction(3,"ºÏ»¶ÅÉ_Ã÷¾»ÁéÌ¨");
			SetAction(4,"ÌìÒôËÂ_Ã÷¾»ÁéÌ¨");
			SetAction(5,"¹íµÀ_Ã÷¾»ÁéÌ¨");
			SetAction(6,"·ÙÏã¹È_Ã÷¾»ÁéÌ¨");
			SetAction(7,"ÊÞÉñ_Ã÷¾»ÁéÌ¨");
			SetAction(8,"ºüÑý_Ã÷¾»ÁéÌ¨");
			SetAction(9,"ÐùÔ¯_Ã÷¾»ÁéÌ¨");
			SetAction(10,"»³¹â_Ã÷¾»ÁéÌ¨");
			SetAction(11,"Ì«ê»_Ã÷¾»ÁéÌ¨");
			SetAction(12,"Ìì»ª_Ã÷¾»ÁéÌ¨");
			SetAction(13,"ÁéÙí_Ã÷¾»ÁéÌ¨");
			SetAction(14,"Ó¢ÕÐ_Ã÷¾»ÁéÌ¨");
			SetAction(15,"ÎäÆ÷´óÊ¦_Ã÷¾»ÁéÌ¨");
			SetAction(16,"ÔªËØ´óÊ¦_Ã÷¾»ÁéÌ¨");
			SetAction(17,"ÌìÒôËÂ_Ã÷¾»ÁéÌ¨");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_Ã÷¾»ÁéÌ¨");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Ã÷¾»ÁéÌ¨");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Ã÷¾»ÁéÌ¨");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_Ã÷¾»ÁéÌ¨");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Ã÷¾»ÁéÌ¨");
			SetAction(23,"¹íµÀ_Æï³Ë_Ã÷¾»ÁéÌ¨");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_Ã÷¾»ÁéÌ¨");
			SetAction(25,"ÊÞÉñ_Æï³Ë_Ã÷¾»ÁéÌ¨");
			SetAction(26,"ºüÑý_Æï³Ë_Ã÷¾»ÁéÌ¨");
			SetAction(27,"ÐùÔ¯_Æï³Ë_Ã÷¾»ÁéÌ¨");
			SetAction(28,"»³¹â_Æï³Ë_Ã÷¾»ÁéÌ¨");
			SetAction(29,"Ì«ê»_Æï³Ë_Ã÷¾»ÁéÌ¨");
			SetAction(30,"Ìì»ª_Æï³Ë_Ã÷¾»ÁéÌ¨");
			name = "Ã÷¾µÁéÌ¨";
			nativename = "Ã÷¾µÁéÌ¨";
			icon = "Ã÷¾µÁéÌ¨.dds";
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
			return 600000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
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

			victim.SetTime(((5000 * skill_level + 15100)));
			victim.SetBuffid(0);
			victim.SetValue(((20 * skill_level)));
			victim.SetAddanti(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1577 : GSkill
	{
		public GSkill1577()
			: base(1577)
		{
			
		}
	}
	public class GSkill1578Stub : GSkillStub
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
		public GSkill1578Stub()
			: base(1578)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
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
			credittype = 11;
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
			SetAction(0,"ÇàÔÆÃÅ_¿ÝÈÙÖ®Äî");
			SetAction(1,"ÇàÔÆÃÅ_¿ÝÈÙÖ®Äî");
			SetAction(2,"¹íÍõ×Ú_¿ÝÈÙÖ®Äî");
			SetAction(3,"ºÏ»¶ÅÉ_¿ÝÈÙÖ®Äî");
			SetAction(4,"ÌìÒôËÂ_¿ÝÈÙÖ®Äî");
			SetAction(5,"¹íµÀ_¿ÝÈÙÖ®Äî");
			SetAction(6,"·ÙÏã¹È_¿ÝÈÙÖ®Äî");
			SetAction(7,"ÊÞÉñ_¿ÝÈÙÖ®Äî");
			SetAction(8,"ºüÑý_¿ÝÈÙÖ®Äî");
			SetAction(9,"ÐùÔ¯_¿ÝÈÙÖ®Äî");
			SetAction(10,"»³¹â_¿ÝÈÙÖ®Äî");
			SetAction(11,"Ì«ê»_¿ÝÈÙÖ®Äî");
			SetAction(12,"Ìì»ª_¿ÝÈÙÖ®Äî");
			SetAction(13,"ÁéÙí_¿ÝÈÙÖ®Äî");
			SetAction(14,"Ó¢ÕÐ_¿ÝÈÙÖ®Äî");
			SetAction(15,"ÎäÆ÷´óÊ¦_¿ÝÈÙÖ®Äî");
			SetAction(16,"ÔªËØ´óÊ¦_¿ÝÈÙÖ®Äî");
			SetAction(17,"ÌìÒôËÂ_¿ÝÈÙÖ®Äî");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_¿ÝÈÙÖ®Äî");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ÈÙÖ®Äî");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¿ÝÈÙÖ®Äî");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¿ÝÈÙÖ®Äî");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¿ÝÈÙÖ®Äî");
			SetAction(23,"¹íµÀ_Æï³Ë_¿ÝÈÙÖ®Äî");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_¿ÝÈÙÖ®Äî");
			SetAction(25,"ÊÞÉñ_Æï³Ë_¿ÝÈÙÖ®Äî");
			SetAction(26,"ºüÑý_Æï³Ë_¿ÝÈÙÖ®Äî");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¿ÝÈÙÖ®Äî");
			SetAction(28,"»³¹â_Æï³Ë_¿ÝÈÙÖ®Äî");
			SetAction(29,"Ì«ê»_Æï³Ë_¿ÝÈÙÖ®Äî");
			SetAction(30,"Ìì»ª_Æï³Ë_¿ÝÈÙÖ®Äî");
			name = "¿ÝÈÙÖ®Äî";
			nativename = "¿ÝÈÙÖ®Äî";
			icon = "¿ÝÈÙÖ®Äî.dds";
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
			return 600000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
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
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (35 * skill_level + 1335);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((skill_level + 79)));
			victim.SetTime(((6000 * skill_level + 30100)));
			victim.SetRatio((skill_level * 0.08f + 0.2f <= 1.0f)?(skill_level * 0.08f + 0.2f):1.0f);
			victim.SetAmount(((4 * skill_level + 5)));
			victim.SetDeadlybless(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1578 : GSkill
	{
		public GSkill1578()
			: base(1578)
		{
			
		}
	}
	public class GSkill1579Stub : GSkillStub
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
		public GSkill1579Stub()
			: base(1579)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
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
			credittype = 11;
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
			SetAction(0,"ÇàÔÆÃÅ_Òò¹ûÖ®Äî");
			SetAction(1,"ÇàÔÆÃÅ_Òò¹ûÖ®Äî");
			SetAction(2,"¹íÍõ×Ú_Òò¹ûÖ®Äî");
			SetAction(3,"ºÏ»¶ÅÉ_Òò¹ûÖ®Äî");
			SetAction(4,"ÌìÒôËÂ_Òò¹ûÖ®Äî");
			SetAction(5,"¹íµÀ_Òò¹ûÖ®Äî");
			SetAction(6,"·ÙÏã¹È_Òò¹ûÖ®Äî");
			SetAction(7,"ÊÞÉñ_Òò¹ûÖ®Äî");
			SetAction(8,"ºüÑý_Òò¹ûÖ®Äî");
			SetAction(9,"ÐùÔ¯_Òò¹ûÖ®Äî");
			SetAction(10,"»³¹â_Òò¹ûÖ®Äî");
			SetAction(11,"Ì«ê»_Òò¹ûÖ®Äî");
			SetAction(12,"Ìì»ª_Òò¹ûÖ®Äî");
			SetAction(13,"ÁéÙí_Òò¹ûÖ®Äî");
			SetAction(14,"Ó¢ÕÐ_Òò¹ûÖ®Äî");
			SetAction(15,"ÎäÆ÷´óÊ¦_Òò¹ûÖ®Äî");
			SetAction(16,"ÔªËØ´óÊ¦_Òò¹ûÖ®Äî");
			SetAction(17,"ÌìÒôËÂ_Òò¹ûÖ®Äî");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_Òò¹ûÖ®Äî");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Òò¹ûÖ®Äî");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Òò¹ûÖ®Äî");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_Òò¹ûÖ®Äî");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Òò¹ûÖ®Äî");
			SetAction(23,"¹íµÀ_Æï³Ë_Òò¹ûÖ®Äî");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_Òò¹ûÖ®Äî");
			SetAction(25,"ÊÞÉñ_Æï³Ë_Òò¹ûÖ®Äî");
			SetAction(26,"ºüÑý_Æï³Ë_Òò¹ûÖ®Äî");
			SetAction(27,"ÐùÔ¯_Æï³Ë_Òò¹ûÖ®Äî");
			SetAction(28,"»³¹â_Æï³Ë_Òò¹ûÖ®Äî");
			SetAction(29,"Ì«ê»_Æï³Ë_Òò¹ûÖ®Äî");
			SetAction(30,"Ìì»ª_Æï³Ë_Òò¹ûÖ®Äî");
			name = "Òò¹ûÖ®Äî";
			nativename = "Òò¹ûÖ®Äî";
			icon = "Òò¹ûÖ®Äî.dds";
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
			return 600000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
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
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (50 * skill_level + 1700);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((10 * skill_level)));
			victim.SetTime(((3000 * skill_level + 15100)));
			victim.SetRejectdebuff(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1579 : GSkill
	{
		public GSkill1579()
			: base(1579)
		{
			
		}
	}
}
