using System;
using System.Text;

namespace SKILL
{
	public class GSkill3440Stub : GSkillStub
	{
		public GSkill3440Stub()
			: base(3440)
		{
			occupation = 66;
			maxlevel = 20;
			maxlearn = 8;
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
			name = "Ìì×ÚÐÄ·¨";
			nativename = "Ìì×ÚÐÄ·¨";
			icon = "Ìì×ÚÐÄ·¨.dds";
			SetTalent(0,3417);
			SetTalent(1,3407);
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
			int[] array={85,87,89,91,93,95,97,99};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				player_reborncount = player.GetReborncount();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			player.SetPasadddodge(6 * skill_level);
			player.SetPasaddaccuracy(8 * skill_level);
			player.SetPasincskilldodge((player_reborncount * (skill_level / 4) * skill_t0) * 10.001f);
			player.SetPasadddefence(skill_level * skill_t1);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3439};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill3440 : GSkill
	{
		public GSkill3440()
			: base(3440)
		{
			
		}
	}
	public class GSkill3441Stub : GSkillStub
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
		public GSkill3441Stub()
			: base(3441)
		{
			occupation = 66;
			maxlevel = 20;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
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
			SetAction(0,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾Á¬Êý¡¿");
			SetAction(1,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾Á¬Êý¡¿");
			SetAction(2,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾Á¬Êý¡¿");
			SetAction(3,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾Á¬Êý¡¿");
			SetAction(4,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾Á¬Êý¡¿");
			SetAction(5,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾Á¬Êý¡¿");
			SetAction(6,"·ÙÏã¹È_Õó·¨¾«ÑÐ¡¾Á¬Êý¡¿");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾Á¬Êý¡¿");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾Á¬Êý¡¿");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾Á¬Êý¡¿");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾Á¬Êý¡¿");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾Á¬Êý¡¿");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾Á¬Êý¡¿");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_Õó·¨¾«ÑÐ¡¾Á¬Êý¡¿");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "½Ù»ðÃ÷×ð";
			nativename = "½Ù»ðÃ÷×ð";
			icon = "½Ù»ðÃ÷×ð¡¤Õó·¨.dds";
			SetTalent(0,3418);
			SetTalent(1,3421);
			SetTalent(2,3422);
			SetTalent(3,3408);
			SetTalent(4,3758);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 5;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = true;
			cyclemode = 1;
			cyclegfx = "·¨ÕóÁ¬Êý";
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
			return 5000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();
			int				skill_t4 = skill.GetT4();

            return (int)(((120000 - 15000 * skill_t2)) - skill_t4 * 2400.0f);
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={100,105,110,115,120};return array[level-1];
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
			return 1500.000000f;
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
			int				skill_t1 = skill.GetT1();
			int				skill_t4 = skill.GetT4();
			int				skill_charging = skill.GetCharging();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_t4 + (10000 * (skill_charging / 0x12C0) + (1000 * (player.GetCyclemembercnt() * skill_t1 + (5 * (player.GetCyclemembercnt() + skill_level))))))));
			victim.SetRatio(skill_level);
			victim.SetBuffid(0);
			victim.SetAmount(3606.0f);
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
			v46 = 5 * skill_level;
			v45 = 5 * player.GetCyclemembercnt();
			v44 = skill_t1 * player.GetCyclemembercnt();
			v43 = 10 * (skill_charging / 0x12C0);
			if ( player.GetCyclemembercnt() == 6 )
			{
			v42 = (v43 + v44 + v45 + v46 + 300);
			}
			else
			{
			if ( player.GetCyclemembercnt() > 3 )
			v41 = (v43 + v44 + v45 + v46 + 200);
			else
			v42 = ((v43 + v44 + v45 + v46 + 100));
			}
			victim.SetRatio(v42);
			victim.SetBuffid(1);
			victim.SetValue(3645.0f);
			victim.SetDelaycast(true);
			victim.SetTime(900.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetEvilaura(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3440};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill3441 : GSkill
	{
		public GSkill3441()
			: base(3441)
		{
			
		}
	}
	public class GSkill3442Stub : GSkillStub
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
				int				player_maxatk = player.GetMaxatk();
				int				player_dodge = player.GetDodge();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				player.SetVar2(player_dodge);
				skill.SetRatio((skill_t0 * 0.1f + 1.0f));
				skill.SetPlus(((127 * skill_level + 1432)));
				player.SetPerform(1);
			}
		}
		public GSkill3442Stub()
			: base(3442)
		{
			occupation = 67;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
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
			weapon_limit = -1;
			SetAction(0,"·ÙÏã¹È_×ÆÉÕ³Í½ä");
			SetAction(1,"·ÙÏã¹È_×ÆÉÕ³Í½ä");
			SetAction(2,"·ÙÏã¹È_×ÆÉÕ³Í½ä");
			SetAction(3,"·ÙÏã¹È_×ÆÉÕ³Í½ä");
			SetAction(4,"·ÙÏã¹È_×ÆÉÕ³Í½ä");
			SetAction(5,"·ÙÏã¹È_×ÆÉÕ³Í½ä");
			SetAction(6,"·ÙÏã¹È_×ÆÉÕ³Í½ä");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"·ÙÏã¹È_Æï³Ë_×ÆÉÕ³Í½ä");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_×ÆÉÕ³Í½ä");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_×ÆÉÕ³Í½ä");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_×ÆÉÕ³Í½ä");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_×ÆÉÕ³Í½ä");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_×ÆÉÕ³Í½ä");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_×ÆÉÕ³Í½ä");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¾ø³¾ÁùºÏ";
			nativename = "¾ø³¾ÁùºÏ";
			icon = "¾ø³¾ÁùºÏ.dds";
			SetTalent(0,3386);
			SetTalent(1,3751);
			SetTalent(2,3752);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();

            return (int)((1.0f - skill_t2 * 0.03f) * 6000.0f);
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={105,107,109,111,113,115,117,119,122};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 14.0f);
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

			return (11 * skill_level + 624);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			/*
			victim.SetProbability(((2 * skill_level + 8)));
			victim.SetTime(6000.0f);
			victim.SetRatio(((2 * skill_level + 10) * 0.01f));
			victim.SetBuffid(1);
			victim.SetDecaccuracy(true);
			if ( skill_t0 <= 0 )
			v27 = 0.0f;
			else
			victim.SetProbability(-1.0f);
			victim.SetValue(((3 * player_var2 * skill_t0)));
			victim.SetDirecthurt(true);
			victim.SetProbability(((skill_t1 + 20)));
			victim.SetTime(14100.0f);
			victim.SetRatio(6.0f);
			victim.SetBuffid(4);
			victim.SetAmount(6.0f);
			victim.SetValue(((skill_t1 * 0.1f + 1.0f) * (player_var1 * 0.25f)));
			victim.SetFiring(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_dodge = player.GetDodge();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((2 * skill_level + 8)));
			victim.SetTime(6000.0f);
			victim.SetBuffid(1);
			victim.SetValue(((player_dodge * (2 * skill_level + 10)) * 0.01f));
			victim.SetAdddodge(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill3442 : GSkill
	{
		public GSkill3442()
			: base(3442)
		{
			
		}
	}
	public class GSkill3443Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 700;
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

				player.SetPerform(1);
			}
		}
		public GSkill3443Stub()
			: base(3443)
		{
			occupation = 67;
			maxlevel = 20;
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
			SetAction(0,"·ÙÏã¹È_»ðÑæÎÆÕÂ");
			SetAction(1,"·ÙÏã¹È_»ðÑæÎÆÕÂ");
			SetAction(2,"·ÙÏã¹È_»ðÑæÎÆÕÂ");
			SetAction(3,"·ÙÏã¹È_»ðÑæÎÆÕÂ");
			SetAction(4,"·ÙÏã¹È_»ðÑæÎÆÕÂ");
			SetAction(5,"·ÙÏã¹È_»ðÑæÎÆÕÂ");
			SetAction(6,"·ÙÏã¹È_»ðÑæÎÆÕÂ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_»ðÑæÎÆÕÂ");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_»ðÑæÎÆÕÂ");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_»ðÑæÎÆÕÂ");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_»ðÑæÎÆÕÂ");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_»ðÑæÎÆÕÂ");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_»ðÑæÎÆÕÂ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_»ðÑæÎÆÕÂ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "»ðÑæÎÆÕÂ";
			nativename = "»ðÑæÎÆÕÂ";
			icon = "»ðÑæÎÆÕÂ.dds";
			SetTalent(0,3386);
			SetTalent(1,3388);
			SetTalent(2,3748);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();

            return (int)(150000.0f - skill_t2 * 6000.0f);
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={110,115,120};return array[level-1];
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
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (10 * skill_level + 720);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();
			int				player_crit = player.GetCrit();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((5000 * skill_t0 + (6000 * skill_level))));
			victim.SetRatio(((20 * (skill_t0 + skill_level) + 40) * 0.01f));
			victim.SetNingjin(true);
			v43 = 6000 * skill_level;
			if ( player_mp <= player_maxmp * 0.95f )
			t = 0.0f;
			else
			victim.SetTime(v43);
			victim.SetRatio(((5 * (skill_t1 + skill_level)) * (player_crit * 0.001f) * 0.01f));
			victim.SetInccritrate(true);
			if ( skill_t2 <= 0 )
			v41 = 0.0f;
			else
			victim.SetProbability(((2 * (skill_level / 2) + 5)));
			v40 = 6000 * skill_level;
			if ( player_mp <= player_maxmp * 0.95f )
			v39 = 0.0f;
			else
			victim.SetTime(v40);
			victim.SetRatio((skill_t2 * ((player_mp / 10000) * 0.005001f)));
			victim.SetBuffid(5);
			victim.SetInccrithurt(true);
			if ( player.GetHasbuff(4141) == 1 )
			v38 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetRatio(4141.0f);
			victim.SetAmount(4141.0f);
			victim.SetValue(4141.0f);
			victim.SetDispel(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3442};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3443 : GSkill
	{
		public GSkill3443()
			: base(3443)
		{
			
		}
	}
	public class GSkill3444Stub : GSkillStub
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
				int				player_maxhp = player.GetMaxhp();
				int				player_var2 = player.GetVar2();
				int				player_reborncount = player.GetReborncount();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				/*
				if ( player_reborncount )
				    skill.SetCrit(COERCE_FLOAT(2147483648));
				  else
				    skill.SetCrit(-0.02f);
				player.SetVar2((int)(player.GetHasbuff(4141) == 1));
				v21 = ((skill_level * 0.1f + 0.1f) * player_var2 + 1.0f) * ((135 * skill_level + 1913));
				v20 = player_var2;
				v19 = player_maxhp;
				  v18 = skill_t1;
				if ( zrand(100) < 30 * skill_t1 )
				    v17 = (3.0f * (0.01f * (v19 * v20))) * v18;
				  else
				skill.SetPlus(((330 * skill_t1) + v21 + (0.0f * v18)));
				skill.SetRatio(((skill_level * 0.1f + 0.1f) * player_var2 + 1.0f));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill3444Stub()
			: base(3444)
		{
			occupation = 67;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
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
			SetAction(0,"·ÙÏã¹È_»ðÑæÂûÑÓ");
			SetAction(1,"·ÙÏã¹È_»ðÑæÂûÑÓ");
			SetAction(2,"·ÙÏã¹È_»ðÑæÂûÑÓ");
			SetAction(3,"·ÙÏã¹È_»ðÑæÂûÑÓ");
			SetAction(4,"·ÙÏã¹È_»ðÑæÂûÑÓ");
			SetAction(5,"·ÙÏã¹È_»ðÑæÂûÑÓ");
			SetAction(6,"·ÙÏã¹È_»ðÑæÂûÑÓ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_»ðÑæÂûÑÓ");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_»ðÑæÂûÑÓ");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_»ðÑæÂûÑÓ");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_»ðÑæÂûÑÓ");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_»ðÑæÂûÑÓ");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_»ðÑæÂûÑÓ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_»ðÑæÂûÑÓ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "³ãÑ×Ç§Àï";
			nativename = "³ãÑ×Ç§Àï";
			icon = "³ãÑ×Ç§Àï.dds";
			SetTalent(0,3387);
			SetTalent(1,3389);
			SetTalent(2,3752);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

            return (int)(((120000 - 10000 * skill_t0)) - skill_t2 * 3600.0f);
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,125,125,125,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			return (2 * skill_t0 + skill_level + 15);
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

			return (21 * skill_level + 660);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetHasbuff(4141) == 1 )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetRatio(4141.0f);
			victim.SetAmount(4141.0f);
			victim.SetValue(4141.0f);
			victim.SetDispel(true);
			*/
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3443};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3444 : GSkill
	{
		public GSkill3444()
			: base(3444)
		{
			
		}
	}
	public class GSkill3445Stub : GSkillStub
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
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_var2 = player.GetVar2();

				/*
				player.SetVar2((int)((player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) / 5));
				player.SetVar3((int)(player_var2 / 10));
				v23 = player.GetHasbuff(4199) == 1;
				if ( player.GetHasbuff(4200) == 1 )
				    v24 = v23 + 2;
				  else
				    v24 = v23;
				if ( player.GetHasbuff(4201) == 1 )
				    v25 = v24 + 3;
				  else
				    v25 = v24;
				if ( player.GetHasbuff(4202) == 1 )
				    v = v25 + 4;
				  else
				    v = v25;
				player.SetVar1(v);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill3445Stub()
			: base(3445)
		{
			occupation = 67;
			maxlevel = 20;
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
			SetAction(0,"·ÙÏã¹È_»ðá÷»¤Ö÷");
			SetAction(1,"·ÙÏã¹È_»ðá÷»¤Ö÷");
			SetAction(2,"·ÙÏã¹È_»ðá÷»¤Ö÷");
			SetAction(3,"·ÙÏã¹È_»ðá÷»¤Ö÷");
			SetAction(4,"·ÙÏã¹È_»ðá÷»¤Ö÷");
			SetAction(5,"·ÙÏã¹È_»ðá÷»¤Ö÷");
			SetAction(6,"·ÙÏã¹È_»ðá÷»¤Ö÷");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_»ðá÷»¤Ö÷");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_»ðá÷»¤Ö÷");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_»ðá÷»¤Ö÷");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_»ðá÷»¤Ö÷");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_»ðá÷»¤Ö÷");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_»ðá÷»¤Ö÷");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_»ðá÷»¤Ö÷");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "·¨Ôª½â·Å";
			nativename = "·¨Ôª½â·Å";
			icon = "ÁéÁ¦Àí½â.dds";
			SetTalent(0,3404);
			SetTalent(1,3368);
			SetTalent(2,3369);
			SetTalent(3,3428);
			SetTalent(4,3429);
			SetTalent(5,3747);
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
			int				skill_t5 = skill.GetT5();

            return (int)(((90000 - 5000 * skill_t0)) - skill_t5 * 2700.0f);
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={106,109,113,117,121,125,125,125};return array[level-1];
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
			int				player_var3 = player.GetVar3();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

			/*
			if ( player.GetHasbuff(4199) != 1
			&& (v3 = player, GNET::PlayerWrapper::GetHasbuff(v3, 4200) != 1)
			&& (v4 = player, GNET::PlayerWrapper::GetHasbuff(v4, 4201) != 1)
			&& (v5 = player, GNET::PlayerWrapper::GetHasbuff(v5, 4202) != 1) )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetRatio(4199.0f);
			victim.SetAmount(4200.0f);
			victim.SetValue(4201.0f);
			victim.SetDispel(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((3000 * (skill_t0 + skill_level) + 10000)));
			victim.SetRatio(((skill_t4 + (skill_t3 + (skill_t2 + (skill_t1 + skill_level))) + 2)));
			victim.SetBuffid(9);
			victim.SetAmount(((player_var1 + (10 * (skill_level + player_var3)))));
			victim.SetValue(3611.0f);
			victim.SetAddcommon(true);
			if ( player.GetHasbuff(4199) != 1
			&& (v31 = player, GNET::PlayerWrapper::GetHasbuff(v31, 4200) != 1)
			&& (v32 = player, GNET::PlayerWrapper::GetHasbuff(v32, 4201) != 1)
			&& (v33 = player, GNET::PlayerWrapper::GetHasbuff(v33, 4202) != 1) )
			v59 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetRatio(4202.0f);
			victim.SetAmount(4202.0f);
			victim.SetValue(4202.0f);
			victim.SetDispel(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((3000 * (skill_t0 + skill_level) + 10000)));
			victim.SetRatio(((skill_t4 + (skill_t3 + (skill_t2 + (skill_t1 + skill_level))) + 2)));
			victim.SetBuffid(9);
			victim.SetAmount(((player_var1 + (10 * (skill_level + player_var3)))));
			victim.SetValue(3611.0f);
			victim.SetAddcommon(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3442};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill3445 : GSkill
	{
		public GSkill3445()
			: base(3445)
		{
			
		}
	}
	public class GSkill3446Stub : GSkillStub
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
				int				player_skillrate = player.GetSkillrate();

				player.SetVar1((int)(player_skillrate / 59.99f));
				player.SetPerform(1);
			}
		}
		public GSkill3446Stub()
			: base(3446)
		{
			occupation = 67;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
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
			clearmask = 0;
			skill_limit = 1025;
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
			SetAction(0,"·ÙÏã¹È_ÁéÁ¦Ç£ÖÆ");
			SetAction(1,"·ÙÏã¹È_ÁéÁ¦Ç£ÖÆ");
			SetAction(2,"·ÙÏã¹È_ÁéÁ¦Ç£ÖÆ");
			SetAction(3,"·ÙÏã¹È_ÁéÁ¦Ç£ÖÆ");
			SetAction(4,"·ÙÏã¹È_ÁéÁ¦Ç£ÖÆ");
			SetAction(5,"·ÙÏã¹È_ÁéÁ¦Ç£ÖÆ");
			SetAction(6,"·ÙÏã¹È_ÁéÁ¦Ç£ÖÆ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦Ç£ÖÆ");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦Ç£ÖÆ");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦Ç£ÖÆ");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦Ç£ÖÆ");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦Ç£ÖÆ");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦Ç£ÖÆ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÁéÁ¦Ç£ÖÆ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¸¿×ãËø»ê";
			nativename = "¸¿×ãËø»ê";
			icon = "¸¿×ãËø»ê.dds";
			SetTalent(0,3403);
			SetTalent(1,3404);
			SetTalent(2,3747);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

            return (int)((1.0f - skill_t2 * 0.03f) * (((-5000 * skill_level) - 15000 * skill_t1 + 135000)));
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={115,117,119,121,123,125,125,125,125};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 24.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return (3 * skill_t0 + 12);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 880.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_t1 = skill.GetT1();

			/*
			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * (2 * skill_t1 + player_var1) + 3000)));
			if ( player.GetSpeed() <= 2.0f )
			{
			d = 1.0f;
			}
			else
			{
			d = player.GetSpeed() - 2.0f;
			}
			victim.SetRatio(d);
			victim.SetValue(32.0f);
			victim.SetSpiritdrag(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3445};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3446 : GSkill
	{
		public GSkill3446()
			: base(3446)
		{
			
		}
	}
	public class GSkill3447Stub : GSkillStub
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
				int				player_skillrate = player.GetSkillrate();

				player.SetVar1((int)(player_skillrate / 49.99f));
				skill.SetRatio(1.2f);
				player.SetPerform(1);
			}
		}
		public GSkill3447Stub()
			: base(3447)
		{
			occupation = 67;
			maxlevel = 20;
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
			name = "ÐþÑô»ðµä";
			nativename = "ÐþÑô»ðµä";
			icon = "ÐþÑô»ðµä.dds";
			SetTalent(0,3405);
			SetTalent(1,3406);
			SetTalent(2,3747);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();

            return (int)(120000.0f - skill_t2 * 3600.0f);
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
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
			if ( player.GetBuffcnt() )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(50.0f);
			victim.SetRatio(((2 * (skill_t1 + skill_level))));
			victim.SetBuffid(6);
			if ( (2 * (skill_t1 * norm(skill_t1)) * (skill_level / 2) + skill_level + 2) <= player.GetBuffcnt() )
			{
			if ( 2 * (skill_t1 * norm(skill_t1)) * (skill_level / 2) + skill_level + 2 <= 2 )
			{
			LABEL_21:
			v57 = 3615.0f;
			goto LABEL_22;
			}
			}
			else
			{
			if ( player.GetBuffcnt() <= 2 )
			goto LABEL_21;
			}
			if ( (2 * (skill_t1 * norm(skill_t1)) * (skill_level / 2) + skill_level + 2) <= player.GetBuffcnt() )
			{
			if ( 2 * (skill_t1 * norm(skill_t1)) * (skill_level / 2) + skill_level + 2 <= 4 )
			{
			LABEL_19:
			v56 = 3617.0f;
			goto LABEL_20;
			}
			}
			else
			{
			if ( player.GetBuffcnt() <= 4 )
			goto LABEL_19;
			}
			if ( (2 * (skill_t1 * norm(skill_t1)) * (skill_level / 2) + skill_level + 2) <= player.GetBuffcnt() )
			{
			if ( 2 * (skill_t1 * norm(skill_t1)) * (skill_level / 2) + skill_level + 2 <= 6 )
			{
			LABEL_17:
			v55 = 3633.0f;
			goto LABEL_18;
			}
			}
			else
			{
			if ( player.GetBuffcnt() <= 6 )
			goto LABEL_17;
			}
			v55 = 3634.0f;
			LABEL_18:
			v56 = v55;
			LABEL_20:
			v57 = v56;
			LABEL_22:
			victim.SetValue(v57);
			victim.SetDelaycast(true);
			victim.SetTime(((1000 * (2 * skill_t0 + player_var1) + 2000)));
			victim.SetBuffid(1);
			victim.SetAmount(((skill_t1 * (skill_level / 2) + skill_level + 2)));
			victim.SetTurnbuff(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3446};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill3447 : GSkill
	{
		public GSkill3447()
			: base(3447)
		{
			
		}
	}
	public class GSkill3448Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1300;
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.03f + 1.0f));
				skill.SetPlus(((20 * skill_t0 + (14 * skill_level) + 247)));
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.03f + 1.0f));
				skill.SetPlus(((20 * skill_t0 + (14 * skill_level) + 247)));
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t0 * 0.03f + 1.0f));
				skill.SetPlus(((20 * skill_t0 + (14 * skill_level) + 247)));
				player.SetPerform(0);
			}
		}
		public GSkill3448Stub()
			: base(3448)
		{
			occupation = 67;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
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
			SetAction(0,"·ÙÏã¹È_ÕÙ»½Ìì»ð");
			SetAction(1,"·ÙÏã¹È_ÕÙ»½Ìì»ð");
			SetAction(2,"·ÙÏã¹È_ÕÙ»½Ìì»ð");
			SetAction(3,"·ÙÏã¹È_ÕÙ»½Ìì»ð");
			SetAction(4,"·ÙÏã¹È_ÕÙ»½Ìì»ð");
			SetAction(5,"·ÙÏã¹È_ÕÙ»½Ìì»ð");
			SetAction(6,"·ÙÏã¹È_ÕÙ»½Ìì»ð");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ÕÙ»½Ìì»ð");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ÕÙ»½Ìì»ð");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ÕÙ»½Ìì»ð");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ÕÙ»½Ìì»ð");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ÕÙ»½Ìì»ð");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ÕÙ»½Ìì»ð");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÕÙ»½Ìì»ð");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Á¶Óü½Ù²¨";
			nativename = "Á¶Óü½Ù²¨";
			icon = "Á¶Óü½Ù²¨.dds";
			SetTalent(0,3418);
			SetTalent(1,3420);
			SetTalent(2,3751);
			SetTalent(3,3752);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 4000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t3 = skill.GetT3();

			return (int)(12000.0f - skill_t3 * 360.0f);
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={106,108,110,112,114,116,118,120,122};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 12.0f);
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.700000f;
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

			return (20 * skill_level + 1150);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 2 * skill_level + 20;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((skill_t2 + (2 * skill_level) + 6)));
			victim.SetTime(((2000 * skill_t1 + 12100)));
			victim.SetRatio(6.0f);
			victim.SetBuffid(4);
			victim.SetAmount(8.0f);
			victim.SetValue(((skill_t2 * 0.1f + 1.0f) * ((skill_t1 * 0.5f + 1.0f) * (player_var1 * 0.25f))));
			victim.SetFiring(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3442};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill3448 : GSkill
	{
		public GSkill3448()
			: base(3448)
		{
			
		}
	}
	public class GSkill3449Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
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
				return 1600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3449Stub()
			: base(3449)
		{
			occupation = 67;
			maxlevel = 20;
			maxlearn = 6;
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
			SetAction(0,"·ÙÏã¹È_ÄùÅÌ»ØÌì");
			SetAction(1,"·ÙÏã¹È_ÄùÅÌ»ØÌì");
			SetAction(2,"·ÙÏã¹È_ÄùÅÌ»ØÌì");
			SetAction(3,"·ÙÏã¹È_ÄùÅÌ»ØÌì");
			SetAction(4,"·ÙÏã¹È_ÄùÅÌ»ØÌì");
			SetAction(5,"·ÙÏã¹È_ÄùÅÌ»ØÌì");
			SetAction(6,"·ÙÏã¹È_ÄùÅÌ»ØÌì");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ÄùÅÌ»ØÌì");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ÄùÅÌ»ØÌì");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ÄùÅÌ»ØÌì");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ÄùÅÌ»ØÌì");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ÄùÅÌ»ØÌì");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ÄùÅÌ»ØÌì");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÄùÅÌ»ØÌì");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÄùÅÌÖØÉú";
			nativename = "ÄùÅÌÖØÉú";
			icon = "ÄùÅÌÖØÉú.dds";
			SetTalent(0,3420);
			SetTalent(1,3423);
			SetTalent(2,3759);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return 100000 - 20000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={115,117,119,121,122,122};return array[level-1];
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
			return 1600.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(120.0f);
			victim.SetAmount(((2 * skill_level)));
			victim.SetCleardebuff(true);
			victim.SetProbability(9999.0f);
			victim.SetTime(6000.0f);
			victim.SetWrap(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(3000.0f);
			victim.SetAloof(true);
			victim.SetTime(((3000 * skill_t1 + 6000)));
			victim.SetValue(((5 * skill_level)));
			victim.SetBlessed(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(120.0f);
			victim.SetTime(6000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(player_maxhp);
			victim.SetHpgen(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3448};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill3449 : GSkill
	{
		public GSkill3449()
			: base(3449)
		{
			
		}
	}
}
