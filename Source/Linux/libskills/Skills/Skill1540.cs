using System;
using System.Text;

namespace SKILL
{
	public class GSkill1540Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill1540Stub()
			: base(1540)
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
			rangetype = 5;
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
			SetAction(0,"������_��ȱ�");
			SetAction(1,"������_��ȱ�");
			SetAction(2,"������_��ȱ�");
			SetAction(3,"������_��ȱ�");
			SetAction(4,"������_��ȱ�");
			SetAction(5,"������_��ȱ�");
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
			SetAction(18,"������_���_��ȱ�");
			SetAction(19,"������_���_��ȱ�");
			SetAction(20,"������_���_��ȱ�");
			SetAction(21,"������_���_��ȱ�");
			SetAction(22,"������_���_��ȱ�");
			SetAction(23,"������_���_��ȱ�");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "��ȱ�II";
			nativename = "��ȱ�II";
			icon = "��ȱ�II.dds";
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
			skill_class = 3;
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
			return 18.000000f;
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

			return (30 * skill_level + 600);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(900000.0f);
			victim.SetRatio((skill_level * 0.0101f));
			victim.SetBuffid(2);
			victim.SetIncskillaccu(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={386};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill1540 : GSkill
	{
		public GSkill1540()
			: base(1540)
		{
			
		}
	}
	public class GSkill1541Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				skill_level = skill.GetLevel();

				skill.SetRatio(1.0f);
				skill.SetPlus((player_hp * (skill_level * 0.06f + 0.1f)));
				player.SetPerform(1);
			}
		}
		public GSkill1541Stub()
			: base(1541)
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
			SetAction(0,"������_ͬ�鼫��");
			SetAction(1,"������_ͬ�鼫��");
			SetAction(2,"������_ͬ�鼫��");
			SetAction(3,"������_ͬ�鼫��");
			SetAction(4,"������_ͬ�鼫��");
			SetAction(5,"������_ͬ�鼫��");
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
			SetAction(18,"������_���_ͬ�鼫��");
			SetAction(19,"������_���_ͬ�鼫��");
			SetAction(20,"������_���_ͬ�鼫��");
			SetAction(21,"������_���_ͬ�鼫��");
			SetAction(22,"������_���_ͬ�鼫��");
			SetAction(23,"������_���_ͬ�鼫��");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ͬ�鼫��II";
			nativename = "ͬ�鼫��II";
			icon = "ͬ�鼫��II.dds";
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
			skill_class = 3;
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
			int				skill_level = skill.GetLevel();

			return 12000 * skill_level + 24000;
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
			int				skill_level = skill.GetLevel();

			return (skill_level + 16);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 13);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 20);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (60 * skill_level + 2260);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetBreakcasting(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * skill_level + 2100)));
			victim.SetDiet(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={275};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill1541 : GSkill
	{
		public GSkill1541()
			: base(1541)
		{
			
		}
	}
	public class GSkill1542Stub : GSkillStub
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
		public GSkill1542Stub()
			: base(1542)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 2;
			timetype = 1;
			targettype = 0;
			rangetype = 2;
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
			SetAction(0,"������_�Ⱥ���Ը");
			SetAction(1,"������_�Ⱥ���Ը");
			SetAction(2,"������_�Ⱥ���Ը");
			SetAction(3,"������_�Ⱥ���Ը");
			SetAction(4,"������_�Ⱥ���Ը");
			SetAction(5,"������_�Ⱥ���Ը");
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
			SetAction(18,"������_���_�Ⱥ���Ը");
			SetAction(19,"������_���_�Ⱥ���Ը");
			SetAction(20,"������_���_�Ⱥ���Ը");
			SetAction(21,"������_���_�Ⱥ���Ը");
			SetAction(22,"������_���_�Ⱥ���Ը");
			SetAction(23,"������_���_�Ⱥ���Ը");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "�Ⱥ���ԸII";
			nativename = "�Ⱥ���ԸII";
			icon = "�������II.dds";
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
			skill_class = 3;
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
			return 12000;
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
			return 20.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (595 - 5 * skill_level);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(8100.0f);
			victim.SetRatio((skill_level * 0.0201f));
			victim.SetBuffid(0);
			victim.SetDecskillaccu(true);
			victim.SetProbability(100.0f);
			victim.SetTime(8100.0f);
			victim.SetRatio((skill_level * 0.0101f));
			victim.SetBuffid(0);
			victim.SetDecskilldodge(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(3600000.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(21.0f);
			victim.SetValue(0.0f);
			victim.SetEvilaura(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={553};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill1542 : GSkill
	{
		public GSkill1542()
			: base(1542)
		{
			
		}
	}
	public class GSkill1543Stub : GSkillStub
	{
		public GSkill1543Stub()
			: base(1543)
		{
			occupation = 148;
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
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "�ɹ�ͬӵ";
			nativename = "�ɹ�ͬӵ";
			icon = "�ɹ�ͬӵ.dds";
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
			int[] array={1093};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1543 : GSkill
	{
		public GSkill1543()
			: base(1543)
		{
			
		}
	}
	public class GSkill1544Stub : GSkillStub
	{
		public GSkill1544Stub()
			: base(1544)
		{
			occupation = 148;
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
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "��ˮ����";
			nativename = "��ˮ����";
			icon = "��ˮ����.dds";
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasinchp((skill_level * (skill_level * 0.001f) + (skill_level * 0.01f)));
			player.SetPasincmp((skill_level * (skill_level * 0.002f) + (skill_level * 0.02f)));
			player.SetPasdechurt((D2INT(skill_level / 9.9f) * 0.03f));
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1543};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1544 : GSkill
	{
		public GSkill1544()
			: base(1544)
		{
			
		}
	}
	public class GSkill1545Stub : GSkillStub
	{
		public GSkill1545Stub()
			: base(1545)
		{
			occupation = 148;
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
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "רע����";
			nativename = "רע����";
			icon = "����רע.dds";
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPassubhurt(((3 * skill_level * skill_level + (12 * skill_level))));
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1544};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1545 : GSkill
	{
		public GSkill1545()
			: base(1545)
		{
			
		}
	}
	public class GSkill1546Stub : GSkillStub
	{
		public GSkill1546Stub()
			: base(1546)
		{
			occupation = 149;
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
			credittype = 10;
			clearmask = 2;
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
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "��ħ";
			nativename = "��ħ";
			icon = "��ħ.dds";
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
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,90,90,95,100,105,110,115,120,125};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasinchp((norm(skill_level / 9.9f) * 0.04f));
			player.SetPasaddattack(((30 * skill_level)));
			player.SetPasaddsilent(((3 * skill_level)));
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={10000,12000,14000,16000,18000,20000,22000,24000,26000,30000};return array[level-1];
		}
	}
	public class GSkill1546 : GSkill
	{
		public GSkill1546()
			: base(1546)
		{
			
		}
	}
	public class GSkill1547Stub : GSkillStub
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
				int				player_maxmp = player.GetMaxmp();

				player.SetVar2(player_maxmp);
				player.SetPerform(1);
			}
		}
		public GSkill1547Stub()
			: base(1547)
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
			rangetype = 5;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 10;
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
			SetAction(0,"������_����");
			SetAction(1,"������_����");
			SetAction(2,"������_����");
			SetAction(3,"�ϻ���_����");
			SetAction(4,"������_����");
			SetAction(5,"���_����");
			SetAction(6,"�����_����");
			SetAction(7,"����_����");
			SetAction(8,"����_����");
			SetAction(9,"��ԯ_����");
			SetAction(10,"����_����");
			SetAction(11,"̫�_����");
			SetAction(12,"�컪_����");
			SetAction(13,"����_����");
			SetAction(14,"Ӣ��_����");
			SetAction(15,"������ʦ_����");
			SetAction(16,"Ԫ�ش�ʦ_����");
			SetAction(17,"������_����");
			SetAction(18,"������_���_����");
			SetAction(19,"������_���_����");
			SetAction(20,"������_���_����");
			SetAction(21,"�ϻ���_���_����");
			SetAction(22,"������_���_����");
			SetAction(23,"���_���_����");
			SetAction(24,"�����_���_����");
			SetAction(25,"����_���_����");
			SetAction(26,"����_���_����");
			SetAction(27,"��ԯ_���_����");
			SetAction(28,"����_���_����");
			SetAction(29,"̫�_���_����");
			SetAction(30,"�컪_���_����");
			name = "����";
			nativename = "����";
			icon = "����.dds";
			SetTalent(0,1549);
			SetTalent(1,1552);
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
			int				skill_t1 = skill.GetT1();

			return 720000 - 36000 * skill_t1;
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
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (25 * skill_level + 325);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * skill_t0 + 30100)));
			victim.SetRatio(1.0f);
			victim.SetAmount(((3 * skill_t0 + 30)));
			victim.SetValue(((6 * skill_level)));
			victim.SetDodgeregain(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30100.0f);
			victim.SetRatio((skill_level * 0.0101f));
			victim.SetBuffid(2);
			victim.SetIncskilldodge(true);
			victim.SetTime(((30100 * (skill_level / 10))));
			victim.SetBuffid(4);
			victim.SetValue(((skill_level / 10) * (player_var2 * 0.1f)));
			victim.SetAddmp(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1549};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1547 : GSkill
	{
		public GSkill1547()
			: base(1547)
		{
			
		}
	}
	public class GSkill1548Stub : GSkillStub
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
		public GSkill1548Stub()
			: base(1548)
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
			rangetype = 5;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 10;
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
			SetAction(0,"������_�ݼ�");
			SetAction(1,"������_�ݼ�");
			SetAction(2,"������_�ݼ�");
			SetAction(3,"�ϻ���_�ݼ�");
			SetAction(4,"������_�ݼ�");
			SetAction(5,"���_�ݼ�");
			SetAction(6,"�����_�ݼ�");
			SetAction(7,"����_�ݼ�");
			SetAction(8,"����_�ݼ�");
			SetAction(9,"��ԯ_�ݼ�");
			SetAction(10,"����_�ݼ�");
			SetAction(11,"̫�_�ݼ�");
			SetAction(12,"�컪_�ݼ�");
			SetAction(13,"����_�ݼ�");
			SetAction(14,"Ӣ��_�ݼ�");
			SetAction(15,"������ʦ_�ݼ�");
			SetAction(16,"Ԫ�ش�ʦ_�ݼ�");
			SetAction(17,"������_�ݼ�");
			SetAction(18,"������_���_�ݼ�");
			SetAction(19,"������_���_�ݼ�");
			SetAction(20,"������_���_�ݼ�");
			SetAction(21,"�ϻ���_���_�ݼ�");
			SetAction(22,"������_���_�ݼ�");
			SetAction(23,"���_���_�ݼ�");
			SetAction(24,"�����_���_�ݼ�");
			SetAction(25,"����_���_�ݼ�");
			SetAction(26,"����_���_�ݼ�");
			SetAction(27,"��ԯ_���_�ݼ�");
			SetAction(28,"����_���_�ݼ�");
			SetAction(29,"̫�_���_�ݼ�");
			SetAction(30,"�컪_���_�ݼ�");
			name = "�ݼ�";
			nativename = "�ݼ�";
			icon = "�ݼ�.dds";
			SetTalent(0,1549);
			SetTalent(1,1552);
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
			int				skill_t1 = skill.GetT1();

			return 720000 - 36000 * skill_t1;
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
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (25 * skill_level + 325);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * skill_t0 + 30100)));
			victim.SetRatio(1.0f);
			victim.SetAmount(((3 * skill_t0 + 30)));
			victim.SetValue(((15 * skill_level)));
			victim.SetBloodshield(true);
			victim.SetTime(30100.0f);
			victim.SetRatio((skill_level * 0.01f));
			victim.SetAmount(1000000.0f);
			victim.SetDechurt(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1549};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1548 : GSkill
	{
		public GSkill1548()
			: base(1548)
		{
			
		}
	}
	public class GSkill1549Stub : GSkillStub
	{
		public GSkill1549Stub()
			: base(1549)
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
			clearmask = 2;
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
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "��Ϣ";
			nativename = "��Ϣ";
			icon = "��Ϣ.dds";
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
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,90,95,100,105,110,115,120,125,125};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasaddanti(((10 * D2INT(skill_level / 9.5f))));
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1554};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1549 : GSkill
	{
		public GSkill1549()
			: base(1549)
		{
			
		}
	}
}
