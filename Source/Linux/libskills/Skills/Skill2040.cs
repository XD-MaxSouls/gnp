using System;
using System.Text;

namespace SKILL
{
	public class GSkill2040Stub : GSkillStub
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
				int				player_occupation = player.GetOccupation();

				player.SetVar1((player_occupation == 10)?1:0);
                player.SetVar2((player_occupation == 11)?1:0);
                player.SetVar3((player_occupation == 12)?1:0);
                player.SetVar4((player_occupation == 22)?1:0);
                player.SetVar5((player_occupation == 23)?1:0);
				player.SetPerform(1);
			}
		}
		public GSkill2040Stub()
			: base(2040)
		{
			occupation = 150;
			maxlevel = 30;
			maxlearn = 20;
			eventflag = 0;
			spcost = 1;
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
			clearmask = 132;
			skill_limit = 1;
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
			SetAction(0,"¹íµÀ_ÊØ»¤");
			SetAction(1,"ÇàÔÆÃÅ_ÊØ»¤");
			SetAction(2,"¹íÍõ×Ú_ÊØ»¤");
			SetAction(3,"ºÏ»¶ÅÉ_ÊØ»¤");
			SetAction(4,"ÌìÒôËÂ_ÊØ»¤");
			SetAction(5,"¹íµÀ_ÊØ»¤");
			SetAction(6,"·ÙÏã_ÊØ»¤");
			SetAction(7,"ÊŞÉñ_ÊØ»¤");
			SetAction(8,"ºüÑı_ÊØ»¤");
			SetAction(9,"ĞùÔ¯_ÊØ»¤");
			SetAction(10,"»³¹â_ÊØ»¤");
			SetAction(11,"Ì«ê»_ÊØ»¤");
			SetAction(12,"Ìì»ª_ÊØ»¤");
			SetAction(13,"ÁéÙí_ÊØ»¤");
			SetAction(14,"Ó¢ÕĞ_ÊØ»¤");
			SetAction(15,"ÎäÆ÷´óÊ¦_ÊØ»¤");
			SetAction(16,"ÔªËØ´óÊ¦_ÊØ»¤");
			SetAction(17,"ÌìÒôËÂ_ÊØ»¤");
			SetAction(18,"¹íµÀ_Æï³Ë_ÊØ»¤");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ÊØ»¤");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÊØ»¤");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_ÊØ»¤");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ÊØ»¤");
			SetAction(23,"¹íµÀ_Æï³Ë_ÊØ»¤");
			SetAction(24,"·ÙÏã_Æï³Ë_ÊØ»¤");
			SetAction(25,"ÊŞÉñ_Æï³Ë_ÊØ»¤");
			SetAction(26,"ºüÑı_Æï³Ë_ÊØ»¤");
			SetAction(27,"ĞùÔ¯_Æï³Ë_ÊØ»¤");
			SetAction(28,"»³¹â_Æï³Ë_ÊØ»¤");
			SetAction(29,"Ì«ê»_Æï³Ë_ÊØ»¤");
			SetAction(30,"Ìì»ª_Æï³Ë_ÊØ»¤");
			name = "·ğÖ®ÊØ»¤";
			nativename = "·ğÖ®ÊØ»¤";
			icon = "·ğÖ®ÊØ»¤.dds";
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
			return 900000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125,125,125,125,125,125,125,125,130,135,140};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			if ( player_var1 != 1
			&& (v6 = player, GNET::PlayerWrapper::GetVar2(v6) != 1)
			&& (v7 = player, GNET::PlayerWrapper::GetVar3(v7) != 1)
			&& (v8 = player, GNET::PlayerWrapper::GetVar4(v8) != 1)
			&& (v9 = player, GNET::PlayerWrapper::GetVar5(v9) != 1) )
			d = 0.0f;
			else
			victim.SetRatio(1.0f);
			victim.SetBuffid(0);
			victim.SetAmount(0.0f);
			v44 = (0.005f * skill_level) + 0.05f;
			v43 = player_maxhp;
			v42 = (skill_level + 5);
			if ( player.GetCultivation() == 4 )
			v41 = (v44 + v44) * v43 * v42;
			else
			victim.SetValue((v44 * v43 * v42));
			victim.SetHpgen(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			victim.SetBuffid(0);
			victim.SetAmount(0.0f);
			v40 = (0.005f * skill_level) + 0.05f;
			v39 = player_maxmp;
			v38 = (skill_level + 5);
			if ( player.GetCultivation() == 4 )
			v37 = (v40 + v40) * v39 * v38;
			else
			victim.SetValue((v40 * v39 * v38));
			victim.SetMpgen(true);
			if ( player.GetCultivation() == 4 )
			v36 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(0);
			victim.SetValue(((100 * skill_level)));
			victim.SetAdddefence(true);
			*/
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={12000,13000,14000,15000,16000,17000,18000,19000,20000,21000,22000,24000,25500,27500,28500,30000,32000,34000,36000,40000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill2040 : GSkill
	{
		public GSkill2040()
			: base(2040)
		{
			
		}
	}
	public class GSkill2041Stub : GSkillStub
	{
		public GSkill2041Stub()
			: base(2041)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
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
			name = "Î´Öª¼¼ÄÜ";
			nativename = "Î´Öª¼¼ÄÜ";
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
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2041};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={10};return array[index];
		}
	}
	public class GSkill2041 : GSkill
	{
		public GSkill2041()
			: base(2041)
		{
			
		}
	}
	public class GSkill2042Stub : GSkillStub
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
		public GSkill2042Stub()
			: base(2042)
		{
			occupation = 128;
			maxlevel = 99;
			maxlearn = 99;
			eventflag = 0;
			spcost = 1;
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
			name = "¸ñ¶·»î¶¯-¸Ä±ä±äÁ¿1";
			nativename = "¸ñ¶·»î¶¯-¸Ä±ä±äÁ¿1";
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
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1000;
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
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetAmount(30188.0f);
			victim.SetValue(((zrand(20) + 1)));
			victim.SetSetcommondata(true);
			victim.SetProbability(120.0f);
			victim.SetAmount(30189.0f);
			victim.SetValue(((zrand(20) + 1)));
			victim.SetSetcommondata(true);
			victim.SetProbability(120.0f);
			victim.SetAmount(30190.0f);
			victim.SetValue(((zrand(20) + 1)));
			victim.SetSetcommondata(true);
			victim.SetProbability(120.0f);
			victim.SetAmount(30191.0f);
			victim.SetValue(((zrand(20) + 1)));
			victim.SetSetcommondata(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetAmount(30192.0f);
			victim.SetValue(((zrand(20) + 1)));
			victim.SetSetcommondata(true);
			victim.SetProbability(120.0f);
			victim.SetAmount(30193.0f);
			victim.SetValue(((zrand(20) + 1)));
			victim.SetSetcommondata(true);
			victim.SetProbability(120.0f);
			victim.SetAmount(30194.0f);
			victim.SetValue(((zrand(20) + 1)));
			victim.SetSetcommondata(true);
			victim.SetProbability(120.0f);
			victim.SetAmount(30195.0f);
			victim.SetValue(((zrand(20) + 1)));
			victim.SetSetcommondata(true);
			return true;
		}
	}
	public class GSkill2042 : GSkill
	{
		public GSkill2042()
			: base(2042)
		{
			
		}
	}
	public class GSkill2043Stub : GSkillStub
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
		public GSkill2043Stub()
			: base(2043)
		{
			occupation = 128;
			maxlevel = 99;
			maxlearn = 99;
			eventflag = 0;
			spcost = 1;
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
			name = "¸ñ¶·»î¶¯-¸Ä±ä±äÁ¿2";
			nativename = "¸ñ¶·»î¶¯-¸Ä±ä±äÁ¿2";
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
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1000;
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
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetAmount(30180.0f);
			victim.SetValue(((zrand(20) + 1)));
			victim.SetSetcommondata(true);
			victim.SetProbability(120.0f);
			victim.SetAmount(30181.0f);
			victim.SetValue(((zrand(20) + 1)));
			victim.SetSetcommondata(true);
			victim.SetProbability(120.0f);
			victim.SetAmount(30182.0f);
			victim.SetValue(((zrand(20) + 1)));
			victim.SetSetcommondata(true);
			victim.SetProbability(120.0f);
			victim.SetAmount(30183.0f);
			victim.SetValue(((zrand(20) + 1)));
			victim.SetSetcommondata(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetAmount(30184.0f);
			victim.SetValue(((zrand(20) + 1)));
			victim.SetSetcommondata(true);
			victim.SetProbability(120.0f);
			victim.SetAmount(30185.0f);
			victim.SetValue(((zrand(20) + 1)));
			victim.SetSetcommondata(true);
			victim.SetProbability(120.0f);
			victim.SetAmount(30186.0f);
			victim.SetValue(((zrand(20) + 1)));
			victim.SetSetcommondata(true);
			victim.SetProbability(120.0f);
			victim.SetAmount(30187.0f);
			victim.SetValue(((zrand(20) + 1)));
			victim.SetSetcommondata(true);
			return true;
		}
	}
	public class GSkill2043 : GSkill
	{
		public GSkill2043()
			: base(2043)
		{
			
		}
	}
	public class GSkill2044Stub : GSkillStub
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
		public GSkill2044Stub()
			: base(2044)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
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
			credittype = 9;
			clearmask = 129;
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
			SetAction(0,"ÇàÔÆÃÅ_åĞÒ£ÓÎ");
			SetAction(1,"ÇàÔÆÃÅ_åĞÒ£ÓÎ");
			SetAction(2,"ÇàÔÆÃÅ_åĞÒ£ÓÎ");
			SetAction(3,"ÇàÔÆÃÅ_åĞÒ£ÓÎ");
			SetAction(4,"ÇàÔÆÃÅ_åĞÒ£ÓÎ");
			SetAction(5,"ÇàÔÆÃÅ_åĞÒ£ÓÎ");
			SetAction(6,"ÇàÔÆÃÅ_åĞÒ£ÓÎ");
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
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_åĞÒ£ÓÎ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_åĞÒ£ÓÎ");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_åĞÒ£ÓÎ");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_åĞÒ£ÓÎ");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_åĞÒ£ÓÎ");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_åĞÒ£ÓÎ");
			SetAction(24,"ÇàÔÆÃÅ_Æï³Ë_åĞÒ£ÓÎ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "åĞÒ£ÓÎII";
			nativename = "åĞÒ£ÓÎII";
			icon = "åĞÒ£ÓÎII.dds";
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
			skill_class = 2;
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
			return 120000;
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
			return 999.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			victim.SetBuffid(1);
			victim.SetValue((skill_level * 0.4f + 0.2f));
			victim.SetAddspeed(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			victim.SetBuffid(1);
			victim.SetValue(((10 * skill_level + 20)));
			victim.SetAdddodge(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			victim.SetRatio((skill_level * 0.05f + 0.1f));
			victim.SetBuffid(1);
			victim.SetIncskilldodge(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={233};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill2044 : GSkill
	{
		public GSkill2044()
			: base(2044)
		{
			
		}
	}
	public class GSkill2045Stub : GSkillStub
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
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_res3);
				skill.SetRatio((D2INT((player_mp / (0.95f - skill_t1 * 0.1f)) / player_maxmp) * 0.2f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus((player_maxmp * (skill_level * 0.01f)));
				player.SetPerform(1);
			}
		}
		public GSkill2045Stub()
			: base(2045)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 3;
			doenchant = true;
			dobless = true;
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
			SetAction(0,"ÇàÔÆÃÅ_ÌìÖï½£Æø");
			SetAction(1,"ÇàÔÆÃÅ_ÌìÖï½£Æø");
			SetAction(2,"ÇàÔÆÃÅ_ÌìÖï½£Æø");
			SetAction(3,"ÇàÔÆÃÅ_ÌìÖï½£Æø");
			SetAction(4,"ÇàÔÆÃÅ_ÌìÖï½£Æø");
			SetAction(5,"ÇàÔÆÃÅ_ÌìÖï½£Æø");
			SetAction(6,"ÇàÔÆÃÅ_ÌìÖï½£Æø");
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
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_ÌìÖï½£Æø");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ÌìÖï½£Æø");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_ÌìÖï½£Æø");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_ÌìÖï½£Æø");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_ÌìÖï½£Æø");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_ÌìÖï½£Æø");
			SetAction(24,"ÇàÔÆÃÅ_Æï³Ë_ÌìÖï½£Æø");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÌìÖï½£ÆøII";
			nativename = "ÌìÖï½£ÆøII";
			icon = "ÌìÖï½£ÆøII.dds";
			SetTalent(0,541);
			SetTalent(1,612);
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
			skill_class = 2;
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
			return 60000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
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

			return (100 * skill_level + 213);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((10 * (skill_t0 / 2.99f) + (10 * skill_level + player_var1) + 30)));
			victim.SetTime(((1000 * ((skill_t0 / 2.99f) + skill_level) + 5000)));
			victim.SetWrap(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();
			int				skill_t1 = skill.GetT1();

			victim.SetBuffid((D2INT((player_mp / (0.95f - skill_t1 * 0.1f)) / player_maxmp)));
			victim.SetUniqprompt(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={541};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill2045 : GSkill
	{
		public GSkill2045()
			: base(2045)
		{
			
		}
	}
	public class GSkill2046Stub : GSkillStub
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

				skill.SetRatio((skill_level * 0.02f + 1.0f));
				skill.SetPlus(((200 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill2046Stub()
			: base(2046)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
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
			credittype = 9;
			clearmask = 129;
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
			SetAction(0,"ºÏ»¶ÅÉ_ÆÆÔÆ");
			SetAction(1,"ºÏ»¶ÅÉ_ÆÆÔÆ");
			SetAction(2,"ºÏ»¶ÅÉ_ÆÆÔÆ");
			SetAction(3,"ºÏ»¶ÅÉ_ÆÆÔÆ");
			SetAction(4,"ºÏ»¶ÅÉ_ÆÆÔÆ");
			SetAction(5,"ºÏ»¶ÅÉ_ÆÆÔÆ");
			SetAction(6,"ºÏ»¶ÅÉ_ÆÆÔÆ");
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
			SetAction(18,"ºÏ»¶ÅÉ_Æï³Ë_ÆÆÔÆ");
			SetAction(19,"ºÏ»¶ÅÉ_Æï³Ë_ÆÆÔÆ");
			SetAction(20,"ºÏ»¶ÅÉ_Æï³Ë_ÆÆÔÆ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_ÆÆÔÆ");
			SetAction(22,"ºÏ»¶ÅÉ_Æï³Ë_ÆÆÔÆ");
			SetAction(23,"ºÏ»¶ÅÉ_Æï³Ë_ÆÆÔÆ");
			SetAction(24,"ºÏ»¶ÅÉ_Æï³Ë_ÆÆÔÆ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÆÆÔÆII";
			nativename = "ÆÆÔÆII";
			icon = "ÆÆÔÆII.dds";
			SetTalent(0,308);
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
			skill_class = 1;
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
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

			return (2 * (skill_level * skill_level + (60 * skill_level)));
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetTime(200.0f);
			victim.SetBuffid(2);
			victim.SetAmount((((48 * skill_t0 + 240) * skill_level)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(120.0f);
			victim.SetTime(200.0f);
			victim.SetBuffid(1);
			victim.SetAmount((((96 * skill_t0 + 480) * skill_level)));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={308};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill2046 : GSkill
	{
		public GSkill2046()
			: base(2046)
		{
			
		}
	}
	public class GSkill2047Stub : GSkillStub
	{
		public GSkill2047Stub()
			: base(2047)
		{
			occupation = 148;
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
			credittype = 9;
			clearmask = 129;
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
			name = "çÎç¿II";
			nativename = "çÎç¿II";
			icon = "çÎç¿II.dds";
			SetTalent(0,288);
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
			skill_class = 1;
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
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasincskilldodge(((5 * skill_level)));
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={288};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={8};return array[index];
		}
	}
	public class GSkill2047 : GSkill
	{
		public GSkill2047()
			: base(2047)
		{
			
		}
	}
	public class GSkill2048Stub : GSkillStub
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

				skill.SetRatio((skill_level * 0.05f + 0.5f));
				player.SetPerform(1);
			}
		}
		public GSkill2048Stub()
			: base(2048)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 4;
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
			SetAction(0,"¹íÍõ×Ú_º®±ùÈĞ");
			SetAction(1,"¹íÍõ×Ú_º®±ùÈĞ");
			SetAction(2,"¹íÍõ×Ú_º®±ùÈĞ");
			SetAction(3,"¹íÍõ×Ú_º®±ùÈĞ");
			SetAction(4,"¹íÍõ×Ú_º®±ùÈĞ");
			SetAction(5,"¹íÍõ×Ú_º®±ùÈĞ");
			SetAction(6,"¹íÍõ×Ú_º®±ùÈĞ");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_º®±ùÈĞ");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_º®±ùÈĞ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_º®±ùÈĞ");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_º®±ùÈĞ");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_º®±ùÈĞ");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_º®±ùÈĞ");
			SetAction(24,"¹íÍõ×Ú_Æï³Ë_º®±ùÈĞ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "º®±ùÈĞII";
			nativename = "º®±ùÈĞII";
			icon = "º®±ùÈĞII.dds";
			SetTalent(0,252);
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
			skill_class = 0;
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
			return 40000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetAngle(GSkill skill)
		{
			return -0.333332f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * skill_level + (100 * skill_level) + 77);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 2 * skill_level + 8;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 5000)));
			victim.SetBuffid(1);
			victim.SetAmount(10.0f);
			victim.SetValue((player_maxhp * (skill_level * 0.02f)));
			victim.SetSubhp(true);
			if ( (2 * player_hp) >= player_maxhp )
			v26 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 5000)));
			victim.SetRatio(0.0f);
			victim.SetBuffid(9);
			victim.SetFrozen(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((500 * skill_t0 + 500)));
			victim.SetDiet(true);
			*/
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={252};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill2048 : GSkill
	{
		public GSkill2048()
			: base(2048)
		{
			
		}
	}
	public class GSkill2049Stub : GSkillStub
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res1 = player.GetRes1();
				int				player_var1 = player.GetVar1();
				int				player_var2 = player.GetVar2();
				int				skill_level = skill.GetLevel();

				player.SetVar1(1);
				player.SetVar2((int)(2 * player_var1 * skill_level + player_res1));
				skill.SetRatio((skill_level * 0.02f + 1.0f));
				skill.SetPlus(((10 * player_var2)));
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res1 = player.GetRes1();
				int				player_var1 = player.GetVar1();
				int				player_var2 = player.GetVar2();
				int				skill_level = skill.GetLevel();

				player.SetVar1(2);
				player.SetVar2((int)(2 * player_var1 * skill_level + player_res1));
				skill.SetRatio((skill_level * 0.02f + 1.0f));
				skill.SetPlus(((10 * player_var2)));
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res1 = player.GetRes1();
				int				player_var1 = player.GetVar1();
				int				player_var2 = player.GetVar2();
				int				skill_level = skill.GetLevel();

				player.SetVar1(3);
				player.SetVar2((int)(2 * player_var1 * skill_level + player_res1));
				skill.SetRatio((skill_level * 0.02f + 1.0f));
				skill.SetPlus(((10 * player_var2)));
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res1 = player.GetRes1();
				int				player_var1 = player.GetVar1();
				int				player_var2 = player.GetVar2();
				int				skill_level = skill.GetLevel();

				player.SetVar1(4);
				player.SetVar2((int)(2 * player_var1 * skill_level + player_res1));
				skill.SetRatio((skill_level * 0.02f + 1.0f));
				skill.SetPlus(((10 * player_var2)));
				player.SetPerform(0);
			}
		}
		public GSkill2049Stub()
			: base(2049)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
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
			credittype = 9;
			clearmask = 129;
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
			SetAction(0,"¹íÍõ×Ú_ĞıÁú»ÃÉ±");
			SetAction(1,"¹íÍõ×Ú_ĞıÁú»ÃÉ±");
			SetAction(2,"¹íÍõ×Ú_ĞıÁú»ÃÉ±");
			SetAction(3,"¹íÍõ×Ú_ĞıÁú»ÃÉ±");
			SetAction(4,"¹íÍõ×Ú_ĞıÁú»ÃÉ±");
			SetAction(5,"¹íÍõ×Ú_ĞıÁú»ÃÉ±");
			SetAction(6,"¹íÍõ×Ú_ĞıÁú»ÃÉ±");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ĞıÁú»ÃÉ±");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ĞıÁú»ÃÉ±");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ĞıÁú»ÃÉ±");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ĞıÁú»ÃÉ±");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ĞıÁú»ÃÉ±");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_ĞıÁú»ÃÉ±");
			SetAction(24,"¹íÍõ×Ú_Æï³Ë_ĞıÁú»ÃÉ±");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ĞıÁú»ÃÉ±II";
			nativename = "ĞıÁú»ÃÉ±II";
			icon = "ĞıÁú»ÃÉ±II.dds";
			SetTalent(0,525);
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
			skill_class = 0;
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
			return 40000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 1.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (150 * skill_level + 66);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((3 * skill_level + 3)));
			victim.SetTime(3100.0f);
			victim.SetBarehanded(true);
			victim.SetProbability(player_var2);
			victim.SetTime(((1000 * ((skill_t0 / 4.99f) + player_var1))));
			victim.SetDizzy(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((3 * skill_level + 9)));
			victim.SetTime(8000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue((player_maxhp * (skill_level * 0.01f)));
			victim.SetHpgen(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={525};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill2049 : GSkill
	{
		public GSkill2049()
			: base(2049)
		{
			
		}
	}
}
