using System;
using System.Text;

namespace SKILL
{
	public class GSkill3420Stub : GSkillStub
	{
		public GSkill3420Stub()
			: base(3420)
		{
			occupation = 64;
			maxlevel = 3;
			maxlearn = 2;
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
			name = "���";
			nativename = "���";
			icon = "���.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 1;
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
			int[] array={115,115};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3416};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill3420 : GSkill
	{
		public GSkill3420()
			: base(3420)
		{
			
		}
	}
	public class GSkill3421Stub : GSkillStub
	{
		public GSkill3421Stub()
			: base(3421)
		{
			occupation = 64;
			maxlevel = 4;
			maxlearn = 3;
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
			name = "����";
			nativename = "����";
			icon = "����.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 1;
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
			int[] array={120,120,120};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3420};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill3421 : GSkill
	{
		public GSkill3421()
			: base(3421)
		{
			
		}
	}
	public class GSkill3422Stub : GSkillStub
	{
		public GSkill3422Stub()
			: base(3422)
		{
			occupation = 64;
			maxlevel = 4;
			maxlearn = 3;
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
			name = "¾��";
			nativename = "¾��";
			icon = "¾��.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 1;
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
			int[] array={120,120,120};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3421};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill3422 : GSkill
	{
		public GSkill3422()
			: base(3422)
		{
			
		}
	}
	public class GSkill3423Stub : GSkillStub
	{
		public GSkill3423Stub()
			: base(3423)
		{
			occupation = 64;
			maxlevel = 4;
			maxlearn = 3;
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
			name = "�޵�";
			nativename = "�޵�";
			icon = "�޵�.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 1;
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
			int[] array={135,135,135};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3422};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3423 : GSkill
	{
		public GSkill3423()
			: base(3423)
		{
			
		}
	}
	public class GSkill3424Stub : GSkillStub
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(1);
				player.SetVar2(player_maxatk);
				skill.SetRatio((skill_t0 * 0.02f + (skill_level * 0.01f + 1.0f)));
				skill.SetPlus(((25 * skill_t0 + (skill_level * skill_level) + 124)));
				player.SetPerform(1);
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
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(2);
				player.SetVar2(player_maxatk);
				skill.SetRatio((skill_t0 * 0.02f + (skill_level * 0.01f + 1.0f)));
				skill.SetPlus(((25 * skill_t0 + (skill_level * skill_level) + 124)));
				player.SetPerform(0);
			}
		}
		public GSkill3424Stub()
			: base(3424)
		{
			occupation = 65;
			maxlevel = 20;
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
			weapon_limit = -1;
			SetAction(0,"�����_�м���");
			SetAction(1,"�����_�м���");
			SetAction(2,"�����_�м���");
			SetAction(3,"�����_�м���");
			SetAction(4,"�����_�м���");
			SetAction(5,"�����_�м���");
			SetAction(6,"�����_�м���");
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
			SetAction(18,"�����_���_�м���");
			SetAction(19,"�����_���_�м���");
			SetAction(20,"�����_���_�м���");
			SetAction(21,"�����_���_�м���");
			SetAction(22,"�����_���_�м���");
			SetAction(23,"�����_���_�м���");
			SetAction(24,"�����_���_�м���");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "����Ϯ";
			nativename = "����Ϯ";
			icon = "����Ϯ.dds";
			SetTalent(0,3378);
			SetTalent(1,3380);
			SetTalent(2,3751);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 4000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={45,47,49,51,53,55,57,59,61};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 11.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			/*
			v18 = skill_t1;
			v17 = skill_t2;
			if ( player_var1 == 2 )
			d = (v17 + 45 * v18 + 10);
			else
			victim.SetProbability(((v17 + 10)));
			victim.SetTime(((1000 * skill_t1 + 8100)));
			victim.SetRatio(5.0f);
			victim.SetBuffid(2);
			victim.SetAmount(5.0f);
			victim.SetValue(((skill_t2 * 0.1f + 1.0f) * ((100 * skill_t1) + (player_var2 * 0.15f))));
			victim.SetFiring(true);
			*/
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill3424 : GSkill
	{
		public GSkill3424()
			: base(3424)
		{
			
		}
	}
	public class GSkill3425Stub : GSkillStub
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
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();

				player.SetVar1(player_maxatk);
				skill.SetPlus(((3 * skill_level * skill_level + 300)));
				player.SetPerform(1);
			}
		}
		public GSkill3425Stub()
			: base(3425)
		{
			occupation = 65;
			maxlevel = 20;
			maxlearn = 8;
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
			SetAction(0,"�����_а�����");
			SetAction(1,"�����_а�����");
			SetAction(2,"�����_а�����");
			SetAction(3,"�����_а�����");
			SetAction(4,"�����_а�����");
			SetAction(5,"�����_а�����");
			SetAction(6,"�����_а�����");
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
			SetAction(18,"�����_���_а�����");
			SetAction(19,"�����_���_а�����");
			SetAction(20,"�����_���_а�����");
			SetAction(21,"�����_���_а�����");
			SetAction(22,"�����_���_а�����");
			SetAction(23,"�����_���_а�����");
			SetAction(24,"�����_���_а�����");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "������";
			nativename = "������";
			icon = "������.dds";
			SetTalent(0,3379);
			SetTalent(1,3382);
			SetTalent(2,3403);
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
			int				skill_t1 = skill.GetT1();

			return 30000 - 3000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={50,54,58,62,64,68,74,80};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 11.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * skill_level + 378);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((5 * skill_t2 + (3 * skill_level) + 15)));
			victim.SetTime(((skill_t1 + (skill_level * 0.5f)) * 1000.0f));
			victim.SetRatio(0.2f);
			victim.SetValue(0.2f);
			victim.SetRandcurse(true);
			victim.SetProbability(((10 * skill_t0)));
			victim.SetTime(6100.0f);
			victim.SetRatio(5.0f);
			victim.SetBuffid(2);
			victim.SetAmount(5.0f);
			victim.SetValue((player_var1 * 0.15f));
			victim.SetFiring(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3424};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3425 : GSkill
	{
		public GSkill3425()
			: base(3425)
		{
			
		}
	}
	public class GSkill3426Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_maxatk);
				skill.SetRatio((skill_t1 * 0.02f + 1.05f));
				skill.SetPlus(((3 * skill_level + 88)));
				player.SetPerform(1);
			}
		}
		public GSkill3426Stub()
			: base(3426)
		{
			occupation = 65;
			maxlevel = 20;
			maxlearn = 9;
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
			weapon_limit = -1;
			SetAction(0,"�����_������ն");
			SetAction(1,"�����_������ն");
			SetAction(2,"�����_������ն");
			SetAction(3,"�����_������ն");
			SetAction(4,"�����_������ն");
			SetAction(5,"�����_������ն");
			SetAction(6,"�����_������ն");
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
			SetAction(18,"�����_���_������ն");
			SetAction(19,"�����_���_������ն");
			SetAction(20,"�����_���_������ն");
			SetAction(21,"�����_���_������ն");
			SetAction(22,"�����_���_������ն");
			SetAction(23,"�����_���_������ն");
			SetAction(24,"�����_���_������ն");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "һ����";
			nativename = "һ����";
			icon = "һ����.dds";
			SetTalent(0,3397);
			SetTalent(1,3381);
			SetTalent(2,3751);
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
			return 8000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={60,62,64,66,68,70,72,74,76};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 11.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (6 * skill_level + 270);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return skill_level + 10;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(300.0f);
			victim.SetTime(((skill_level * 0.5f + 2.0f) * 1000.0f));
			victim.SetRatio((skill_t0 * 0.1f + (skill_level * 0.05f)));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetProbability(((skill_t2 + (20 * skill_t1))));
			victim.SetTime(8100.0f);
			victim.SetRatio(5.0f);
			victim.SetBuffid(2);
			victim.SetAmount(5.0f);
			victim.SetValue(((skill_t2 * 0.1f + 1.0f) * (player_var1 * 0.15f)));
			victim.SetFiring(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3425};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3426 : GSkill
	{
		public GSkill3426()
			: base(3426)
		{
			
		}
	}
	public class GSkill3427Stub : GSkillStub
	{
		public GSkill3427Stub()
			: base(3427)
		{
			occupation = 65;
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
			name = "�����";
			nativename = "�����";
			icon = "�����.dds";
			SetTalent(0,3393);
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
			int[] array={46,48,51,54,58,62,67,73};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			player.SetPasaddmp(((2 * (player_level * skill_level + (50 * skill_t0 * skill_level)))));
			player.SetPasadddefence(((skill_level * skill_t1)));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3424};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill3427 : GSkill
	{
		public GSkill3427()
			: base(3427)
		{
			
		}
	}
	public class GSkill3428Stub : GSkillStub
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
				int				player_res1 = player.GetRes1();

				/*
				if ( player_res1 / 10 > 999 )
				  {
				    v = 999;
				  }
				  else
				  {
				v = player_res1 / 10;
				  }
				player.SetVar1(v);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill3428Stub()
			: base(3428)
		{
			occupation = 65;
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
			SetAction(0,"�����_��������");
			SetAction(1,"�����_��������");
			SetAction(2,"�����_��������");
			SetAction(3,"�����_��������");
			SetAction(4,"�����_��������");
			SetAction(5,"�����_��������");
			SetAction(6,"�����_��������");
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
			SetAction(18,"�����_���_��������");
			SetAction(19,"�����_���_��������");
			SetAction(20,"�����_���_��������");
			SetAction(21,"�����_���_��������");
			SetAction(22,"�����_���_��������");
			SetAction(23,"�����_���_��������");
			SetAction(24,"�����_���_��������");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "������";
			nativename = "������";
			icon = "������.dds";
			SetTalent(0,3392);
			SetTalent(1,3395);
			SetTalent(2,3399);
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
			int				skill_t0 = skill.GetT0();

			return 30000 - 8000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={55,58,61,65,69,74,80,86};return array[level-1];
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
			return 350.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability((skill_t2 + (skill_level * 0.5f + 2.0f)));
			victim.SetRatio(((skill_t1 * 0.25f + 1.0f) * ((4 * skill_level))));
			victim.SetAmount(((skill_level + (10 * player_var1))));
			victim.SetValue(3601.0f);
			victim.SetAddslow(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3427};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill3428 : GSkill
	{
		public GSkill3428()
			: base(3428)
		{
			
		}
	}
	public class GSkill3429Stub : GSkillStub
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
				int				player_res4 = player.GetRes4();

				/*
				if ( player_res4 / 10 > 999 )
				  {
				    v = 999;
				  }
				  else
				  {
				v = player_res4 / 10;
				  }
				player.SetVar1(v);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill3429Stub()
			: base(3429)
		{
			occupation = 65;
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
			SetAction(0,"�����_��������");
			SetAction(1,"�����_��������");
			SetAction(2,"�����_��������");
			SetAction(3,"�����_��������");
			SetAction(4,"�����_��������");
			SetAction(5,"�����_��������");
			SetAction(6,"�����_��������");
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
			SetAction(18,"�����_���_��������");
			SetAction(19,"�����_���_��������");
			SetAction(20,"�����_���_��������");
			SetAction(21,"�����_���_��������");
			SetAction(22,"�����_���_��������");
			SetAction(23,"�����_���_��������");
			SetAction(24,"�����_���_��������");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "��ħ��";
			nativename = "��ħ��";
			icon = "��ħ��.dds";
			SetTalent(0,3392);
			SetTalent(1,3395);
			SetTalent(2,3399);
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
			int				skill_t0 = skill.GetT0();

			return 30000 - 8000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={65,68,71,74,78,83,89,95};return array[level-1];
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
			return 350.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability((skill_t2 + (skill_level * 0.5f + 2.0f)));
			victim.SetRatio(((skill_t1 * 0.25f + 1.0f) * ((4 * skill_level))));
			victim.SetAmount(((skill_level + (10 * player_var1))));
			victim.SetValue(3602.0f);
			victim.SetAddcharm(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3428};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3429 : GSkill
	{
		public GSkill3429()
			: base(3429)
		{
			
		}
	}
}
