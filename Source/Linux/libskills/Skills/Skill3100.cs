using System;
using System.Text;

namespace SKILL
{
	public class GSkill3100Stub : GSkillStub
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
		public GSkill3100Stub()
			: base(3100)
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
			weapon_limit = 12;
			SetAction(0,"�컪_ױ̨��˼");
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
			SetAction(12,"�컪_ױ̨��˼");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"�컪_���_ױ̨��˼");
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
			SetAction(30,"�컪_���_ױ̨��˼");
			name = "��̨����<ɷ>";
			nativename = "��̨����<ɷ>";
			icon = "ħ����̨����.dds";
			SetTalent(0,2596);
			SetTalent(1,2600);
			SetTalent(2,2718);
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
			skill_class = 8;
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

			return 60000 - 8000 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
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

			return (300 * skill_level + 3500);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 6;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetValue(((1000 * skill_level + 5000)));
			victim.SetHeal(true);
			victim.SetProbability(((5 * skill_t0 + (3 * skill_level) + 30)));
			victim.SetRatio(4099.0f);
			victim.SetAmount(15.0f);
			victim.SetValue(14.0f);
			victim.SetDispel(true);
			victim.SetProbability(-1.0f);
			victim.SetRatio(48.0f);
			victim.SetAmount(49.0f);
			victim.SetValue(50.0f);
			victim.SetDispel(true);
			victim.SetProbability(((3 * skill_level + 10)));
			victim.SetTime(((500 * skill_level + 2050)));
			victim.SetRatio((skill_level * 0.02f + 0.2f));
			victim.SetValue(3.0f);
			victim.SetSkillreflect(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res4 = player.GetRes4();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((skill_t2 + (2 * skill_level) + 14)));
			victim.SetTime(((2000 * norm(skill_t2) + 5000)));
			victim.SetRatio(1.0f);
			victim.SetSkillmirror(true);
			victim.SetTime(((1000 * skill_level + 2050)));
			victim.SetBuffid(1);
			victim.SetValue(((2 * player_res4 * skill_level)));
			victim.SetAddmp(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2501};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
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

			return 4 * skill_level * skill_level + (34 * skill_level) + 200;
		}
	}
	public class GSkill3100 : GSkill
	{
		public GSkill3100()
			: base(3100)
		{
			
		}
	}
	public class GSkill3101Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1100;
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
		public GSkill3101Stub()
			: base(3101)
		{
			occupation = 169;
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
			SetAction(0,"��_��ʥ����");
			SetAction(1,"��_��ʥ����");
			SetAction(2,"��_��ʥ����");
			SetAction(3,"��_��ʥ����");
			SetAction(4,"��_��ʥ����");
			SetAction(5,"��_��ʥ����");
			SetAction(6,"��_��ʥ����");
			SetAction(7,"��_��ʥ����");
			SetAction(8,"��_��ʥ����");
			SetAction(9,"��_��ʥ����");
			SetAction(10,"��_��ʥ����");
			SetAction(11,"��_��ʥ����");
			SetAction(12,"��_��ʥ����");
			SetAction(13,"��_��ʥ����");
			SetAction(14,"��_��ʥ����");
			SetAction(15,"��_��ʥ����");
			SetAction(16,"��_��ʥ����");
			SetAction(17,"��_��ʥ����");
			SetAction(18,"���_��_��ʥ����");
			SetAction(19,"���_��_��ʥ����");
			SetAction(20,"���_��_��ʥ����");
			SetAction(21,"���_��_��ʥ����");
			SetAction(22,"���_��_��ʥ����");
			SetAction(23,"���_��_��ʥ����");
			SetAction(24,"���_��_��ʥ����");
			SetAction(25,"���_��_��ʥ����");
			SetAction(26,"���_��_��ʥ����");
			SetAction(27,"���_��_��ʥ����");
			SetAction(28,"���_��_��ʥ����");
			SetAction(29,"���_��_��ʥ����");
			SetAction(30,"���_��_��ʥ����");
			name = "��������";
			nativename = "��������";
			icon = "Ԫ������-��.dds";
			SetTalent(0,3711);
			SetTalent(1,4449);
			SetTalent(2,4450);
			SetTalent(3,4451);
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

			return 300000 - 5000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,150};return array[level-1];
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
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			victim.SetTime(((3000 * skill_t3 + (5000 * skill_t2 + (8000 * skill_t1 + (8000 * skill_t0 + ((norm(skill_level / 15)) * (1000 * skill_level - 15000) + (2000 * skill_level))))) + 5000)));
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(1);
			victim.SetAmount(((((2 * (skill_level * skill_level + (5 * skill_level)) + 184) * ((2 * skill_level) + (norm(skill_level / 15)) * (skill_level - 15) + 5)) * 0.25f) - ((norm(skill_level / 15)) * (skill_level - 15) + (2 * skill_level) + 5) * ((2 * (skill_level * skill_level + (5 * skill_level)) + 184) * (skill_t3 * 0.05f + (skill_t2 * 0.1f + (skill_t1 * 0.25f + (skill_t0 * 0.25f)))))));
			victim.SetMiracleburstfo(true);
			return true;
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={400,500,500,700,1500,3100,3900,6500,10300,16900,21800,43300,49900,81300,84500,197600,340200,435500,998600,1897100};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={2,4,6,8,10,13,16,19,23,27,31,36,41,46,51,57,63,69,75,81};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			return (2 * (skill_level * skill_level + (5 * skill_level))) - skill_t0 * (2 * (skill_level * skill_level + (5 * skill_level)) + 184) + 184;
		}
	}
	public class GSkill3101 : GSkill
	{
		public GSkill3101()
			: base(3101)
		{
			
		}
	}
	public class GSkill3102Stub : GSkillStub
	{
		public GSkill3102Stub()
			: base(3102)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
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
			name = "��ħ";
			nativename = "��ħ";
			icon = "��ħ����.dds";
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
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasdecrestrainmo((skill_level * 0.01005f));
			player.SetPasincskillaccu(((50 * D2INT(skill_level / 19.9f))));
			return true;
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={400,500,500,700,1500,3100,3900,6500,9100,10800,20700,26500,39600,52900,84300,119800,229700,389600,525000,1237600};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={2,4,6,8,10,13,16,19,22,25,29,33,37,42,47,53,59,65,71,77};return array[level-1];
		}
	}
	public class GSkill3102 : GSkill
	{
		public GSkill3102()
			: base(3102)
		{
			
		}
	}
	public class GSkill3103Stub : GSkillStub
	{
		public GSkill3103Stub()
			: base(3103)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
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
			icon = "��ħ����.dds";
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
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasdecrestrainfo((skill_level * 0.01005f));
			player.SetPasinccrit((D2INT(skill_level / 19.9f) * 0.0501f));
			return true;
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={200,500,500,600,900,1900,3200,4500,8600,10800,20700,32200,51000,65200,84800,159900,260100,427500,743600,1450600};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={1,3,5,7,9,11,14,17,21,25,29,34,39,44,49,55,61,67,73,79};return array[level-1];
		}
	}
	public class GSkill3103 : GSkill
	{
		public GSkill3103()
			: base(3103)
		{
			
		}
	}
	public class GSkill3104Stub : GSkillStub
	{
		public GSkill3104Stub()
			: base(3104)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
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
			icon = "��ħ����.dds";
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
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasdecrestrainxian((skill_level * 0.01005f));
			player.SetPasaddsmite((D2INT(skill_level / 19.9f) * 0.5f));
			return true;
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={400,500,500,700,1500,3100,3900,6500,10300,16900,21800,43300,49900,81300,84500,197600,340200,435500,998600,1897100};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={2,4,6,8,10,13,16,19,23,27,31,36,41,46,51,57,63,69,75,81};return array[level-1];
		}
	}
	public class GSkill3104 : GSkill
	{
		public GSkill3104()
			: base(3104)
		{
			
		}
	}
	public class GSkill3105Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1500;
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

				player.SetPerform(1);
			}
		}
		public GSkill3105Stub()
			: base(3105)
		{
			occupation = 169;
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
			SetAction(0,"��_��ʥ֮ŭ");
			SetAction(1,"��_��ʥ֮ŭ");
			SetAction(2,"��_��ʥ֮ŭ");
			SetAction(3,"��_��ʥ֮ŭ");
			SetAction(4,"��_��ʥ֮ŭ");
			SetAction(5,"��_��ʥ֮ŭ");
			SetAction(6,"��_��ʥ֮ŭ");
			SetAction(7,"��_��ʥ֮ŭ");
			SetAction(8,"��_��ʥ֮ŭ");
			SetAction(9,"��_��ʥ֮ŭ");
			SetAction(10,"��_��ʥ֮ŭ");
			SetAction(11,"��_��ʥ֮ŭ");
			SetAction(12,"��_��ʥ֮ŭ");
			SetAction(13,"��_��ʥ֮ŭ");
			SetAction(14,"��_��ʥ֮ŭ");
			SetAction(15,"��_��ʥ֮ŭ");
			SetAction(16,"��_��ʥ֮ŭ");
			SetAction(17,"��_��ʥ֮ŭ");
			SetAction(18,"���_��_��ʥ֮ŭ");
			SetAction(19,"���_��_��ʥ֮ŭ");
			SetAction(20,"���_��_��ʥ֮ŭ");
			SetAction(21,"���_��_��ʥ֮ŭ");
			SetAction(22,"���_��_��ʥ֮ŭ");
			SetAction(23,"���_��_��ʥ֮ŭ");
			SetAction(24,"���_��_��ʥ֮ŭ");
			SetAction(25,"���_��_��ʥ֮ŭ");
			SetAction(26,"���_��_��ʥ֮ŭ");
			SetAction(27,"���_��_��ʥ֮ŭ");
			SetAction(28,"���_��_��ʥ֮ŭ");
			SetAction(29,"���_��_��ʥ֮ŭ");
			SetAction(30,"���_��_��ʥ֮ŭ");
			name = "�����ľ�";
			nativename = "�����ľ�";
			icon = "��ʥ֮Դ.dds";
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 200000 - 5000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 1.0f;
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

			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 20000)));
			victim.SetBuffid(1);
			victim.SetAmount(((norm(skill_level / 19.9f) * 0.2f + 1.0f) * ((24 * (skill_level + 20) * skill_level))));
			victim.SetValue(0.0f);
			victim.SetDivinityfury(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 20000)));
			victim.SetRatio(0.0f);
			victim.SetBuffid(2);
			victim.SetValue(((8 * skill_level + 20)));
			victim.SetDivinityburst(true);
			return true;
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

			return 3 * skill_level * skill_level + (30 * skill_level) + 180;
		}
	}
	public class GSkill3105 : GSkill
	{
		public GSkill3105()
			: base(3105)
		{
			
		}
	}
	public class GSkill3106Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1700;
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
		public GSkill3106Stub()
			: base(3106)
		{
			occupation = 169;
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
			SetAction(0,"��_��ʥ����");
			SetAction(1,"��_��ʥ����");
			SetAction(2,"��_��ʥ����");
			SetAction(3,"��_��ʥ����");
			SetAction(4,"��_��ʥ����");
			SetAction(5,"��_��ʥ����");
			SetAction(6,"��_��ʥ����");
			SetAction(7,"��_��ʥ����");
			SetAction(8,"��_��ʥ����");
			SetAction(9,"��_��ʥ����");
			SetAction(10,"��_��ʥ����");
			SetAction(11,"��_��ʥ����");
			SetAction(12,"��_��ʥ����");
			SetAction(13,"��_��ʥ����");
			SetAction(14,"��_��ʥ����");
			SetAction(15,"��_��ʥ����");
			SetAction(16,"��_��ʥ����");
			SetAction(17,"��_��ʥ����");
			SetAction(18,"���_��_��ʥ����");
			SetAction(19,"���_��_��ʥ����");
			SetAction(20,"���_��_��ʥ����");
			SetAction(21,"���_��_��ʥ����");
			SetAction(22,"���_��_��ʥ����");
			SetAction(23,"���_��_��ʥ����");
			SetAction(24,"���_��_��ʥ����");
			SetAction(25,"���_��_��ʥ����");
			SetAction(26,"���_��_��ʥ����");
			SetAction(27,"���_��_��ʥ����");
			SetAction(28,"���_��_��ʥ����");
			SetAction(29,"���_��_��ʥ����");
			SetAction(30,"���_��_��ʥ����");
			name = "�򷨲���";
			nativename = "�򷨲���";
			icon = "��ʥ����.dds";
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 200000 - 5000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
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

			victim.SetTime(((4000 * norm(skill_level / 19.9f) + (500 * skill_level) + 2050)));
			victim.SetImmunedizzy(true);
			victim.SetTime(((4000 * norm(skill_level / 19.9f) + (500 * skill_level) + 2050)));
			victim.SetImmunewrap(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((4000 * norm(skill_level / 19.9f) + (500 * skill_level) + 2050)));
			victim.SetRatio(((2 * norm(skill_level / 19.9f)) + (skill_level * 0.2f)));
			victim.SetBuffid(2);
			victim.SetIncdefence(true);
			return true;
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

			return 3 * skill_level * skill_level + (30 * skill_level) + 180;
		}
	}
	public class GSkill3106 : GSkill
	{
		public GSkill3106()
			: base(3106)
		{
			
		}
	}
	public class GSkill3107Stub : GSkillStub
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

				player.SetVar1(player_maxatk);
				player.SetPerform(1);
			}
		}
		public GSkill3107Stub()
			: base(3107)
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
			rangetype = 3;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 4;
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
			SetAction(0,"��_��ʥ����");
			SetAction(1,"��_��ʥ����");
			SetAction(2,"��_��ʥ����");
			SetAction(3,"��_��ʥ����");
			SetAction(4,"��_��ʥ����");
			SetAction(5,"��_��ʥ����");
			SetAction(6,"��_��ʥ����");
			SetAction(7,"��_��ʥ����");
			SetAction(8,"��_��ʥ����");
			SetAction(9,"��_��ʥ����");
			SetAction(10,"��_��ʥ����");
			SetAction(11,"��_��ʥ����");
			SetAction(12,"��_��ʥ����");
			SetAction(13,"��_��ʥ����");
			SetAction(14,"��_��ʥ����");
			SetAction(15,"��_��ʥ����");
			SetAction(16,"��_��ʥ����");
			SetAction(17,"��_��ʥ����");
			SetAction(18,"���_��_��ʥ����");
			SetAction(19,"���_��_��ʥ����");
			SetAction(20,"���_��_��ʥ����");
			SetAction(21,"���_��_��ʥ����");
			SetAction(22,"���_��_��ʥ����");
			SetAction(23,"���_��_��ʥ����");
			SetAction(24,"���_��_��ʥ����");
			SetAction(25,"���_��_��ʥ����");
			SetAction(26,"���_��_��ʥ����");
			SetAction(27,"���_��_��ʥ����");
			SetAction(28,"���_��_��ʥ����");
			SetAction(29,"���_��_��ʥ����");
			SetAction(30,"���_��_��ʥ����");
			name = "��ɽ����";
			nativename = "��ɽ����";
			icon = "λ�Ƹ���.dds";
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
			int				skill_level = skill.GetLevel();

			return 120000 - 3000 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return D2INT(skill_level / 4.9f) + 1;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((4000 * norm(skill_level / 19.9f) + (500 * skill_level) + 4050)));
			victim.SetBuffid(1);
			victim.SetValue(((norm(skill_level / 19.9f) * 0.2f + 1.0f) * ((skill_level * 0.02f + 0.2f) * player_var1)));
			victim.SetDamagemove(true);
			return true;
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={200,500,500,600,900,1900,3200,4500,8600,10800,20700,32200,51000,65200,84800,159900,360100,427500,743600,1450600};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={1,3,5,7,9,11,14,17,21,25,29,34,39,44,49,55,61,67,73,79};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 4 * skill_level * skill_level + (50 * skill_level) + 190;
		}
	}
	public class GSkill3107 : GSkill
	{
		public GSkill3107()
			: base(3107)
		{
			
		}
	}
	public class GSkill3108Stub : GSkillStub
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
		public GSkill3108Stub()
			: base(3108)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			weapon_limit = -1;
			SetAction(0,"��_���ܷ���");
			SetAction(1,"��_���ܷ���");
			SetAction(2,"��_���ܷ���");
			SetAction(3,"��_���ܷ���");
			SetAction(4,"��_���ܷ���");
			SetAction(5,"��_���ܷ���");
			SetAction(6,"��_���ܷ���");
			SetAction(7,"��_���ܷ���");
			SetAction(8,"��_���ܷ���");
			SetAction(9,"��_���ܷ���");
			SetAction(10,"��_���ܷ���");
			SetAction(11,"��_���ܷ���");
			SetAction(12,"��_���ܷ���");
			SetAction(13,"��_���ܷ���");
			SetAction(14,"��_���ܷ���");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"��_���ܷ���");
			SetAction(18,"���_��_���ܷ���");
			SetAction(19,"���_��_���ܷ���");
			SetAction(20,"���_��_���ܷ���");
			SetAction(21,"���_��_���ܷ���");
			SetAction(22,"���_��_���ܷ���");
			SetAction(23,"���_��_���ܷ���");
			SetAction(24,"���_��_���ܷ���");
			SetAction(25,"���_��_���ܷ���");
			SetAction(26,"���_��_���ܷ���");
			SetAction(27,"���_��_���ܷ���");
			SetAction(28,"���_��_���ܷ���");
			SetAction(29,"���_��_���ܷ���");
			SetAction(30,"���_��_���ܷ���");
			name = "��������";
			nativename = "��������";
			icon = "���ܷ���.dds";
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 180000 - 5000 * skill_level;
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
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((500 * skill_level + 2050)));
			victim.SetRatio(((5 * skill_level)));
			victim.SetValue(((D2INT(skill_level / 4.9f) + 1)));
			victim.SetSkillreflect(true);
			return true;
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

			return 3 * skill_level * skill_level + (30 * skill_level) + 180;
		}
	}
	public class GSkill3108 : GSkill
	{
		public GSkill3108()
			: base(3108)
		{
			
		}
	}
	public class GSkill3109Stub : GSkillStub
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
		public GSkill3109Stub()
			: base(3109)
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
			SetAction(0,"������_�����ӻ�");
			SetAction(1,"������_�����ӻ�");
			SetAction(2,"������_�����ӻ�");
			SetAction(3,"�ϻ���_�����ӻ�");
			SetAction(4,"������_�����ӻ�");
			SetAction(5,"���_�����ӻ�");
			SetAction(6,"�����_�����ӻ�");
			SetAction(7,"����_�����ӻ�");
			SetAction(8,"����_�����ӻ�");
			SetAction(9,"��ԯ_�����ӻ�");
			SetAction(10,"����_�����ӻ�");
			SetAction(11,"̫�_�����ӻ�");
			SetAction(12,"�컪_�����ӻ�");
			SetAction(13,"����_�����ӻ�");
			SetAction(14,"Ӣ��_�����ӻ�");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"������_�����ӻ�");
			SetAction(18,"������_���_�����ӻ�");
			SetAction(19,"������_���_�����ӻ�");
			SetAction(20,"������_���_�����ӻ�");
			SetAction(21,"�ϻ���_���_�����ӻ�");
			SetAction(22,"������_���_�����ӻ�");
			SetAction(23,"���_���_�����ӻ�");
			SetAction(24,"�����_���_�����ӻ�");
			SetAction(25,"����_���_�����ӻ�");
			SetAction(26,"����_���_�����ӻ�");
			SetAction(27,"��ԯ_���_�����ӻ�");
			SetAction(28,"����_���_�����ӻ�");
			SetAction(29,"̫�_���_�����ӻ�");
			SetAction(30,"�컪_���_�����ӻ�");
			name = "�������<��>";
			nativename = "�������<��>";
			icon = "�𡤷������.dds";
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
			int				skill_level = skill.GetLevel();

			return 600000 - 20000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
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
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((5 * skill_level)));
			victim.SetTime(((2000 * skill_level + 15100)));
			victim.SetBuffid(9);
			victim.SetValue(((126 * skill_level)));
			victim.SetAdddefence(true);
			victim.SetProbability(100.0f);
			victim.SetAmount(((D2INT(skill_level / 19.9f) + 1)));
			victim.SetCleardebuff(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
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

			return 4 * skill_level * skill_level + (50 * skill_level) + 190;
		}
	}
	public class GSkill3109 : GSkill
	{
		public GSkill3109()
			: base(3109)
		{
			
		}
	}
}
