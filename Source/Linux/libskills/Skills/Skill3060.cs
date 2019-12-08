using System;
using System.Text;

namespace SKILL
{
	public class GSkill3060Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1250;
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
				return 750;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				skill.SetRatio((skill_level * 0.1f + 1.0f));
				skill.SetSaint((int)((norm(skill_level / 19.9f) << 6) + (skill_level * (player.GetSaint() * 0.2f))));
				player.SetPerform(1);
			}
		}
		public GSkill3060Stub()
			: base(3060)
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
			weapon_limit = -1;
			SetAction(0,"ħ_��ʥ��ȼ");
			SetAction(1,"ħ_��ʥ��ȼ");
			SetAction(2,"ħ_��ʥ��ȼ");
			SetAction(3,"ħ_��ʥ��ȼ");
			SetAction(4,"ħ_��ʥ��ȼ");
			SetAction(5,"ħ_��ʥ��ȼ");
			SetAction(6,"ħ_��ʥ��ȼ");
			SetAction(7,"ħ_��ʥ��ȼ");
			SetAction(8,"ħ_��ʥ��ȼ");
			SetAction(9,"ħ_��ʥ��ȼ");
			SetAction(10,"ħ_��ʥ��ȼ");
			SetAction(11,"ħ_��ʥ��ȼ");
			SetAction(12,"ħ_��ʥ��ȼ");
			SetAction(13,"ħ_��ʥ��ȼ");
			SetAction(14,"ħ_��ʥ��ȼ");
			SetAction(15,"ħ_��ʥ��ȼ");
			SetAction(16,"ħ_��ʥ��ȼ");
			SetAction(17,"ħ_��ʥ��ȼ");
			SetAction(18,"���_ħ_��ʥ��ȼ");
			SetAction(19,"���_ħ_��ʥ��ȼ");
			SetAction(20,"���_ħ_��ʥ��ȼ");
			SetAction(21,"���_ħ_��ʥ��ȼ");
			SetAction(22,"���_ħ_��ʥ��ȼ");
			SetAction(23,"���_ħ_��ʥ��ȼ");
			SetAction(24,"���_ħ_��ʥ��ȼ");
			SetAction(25,"���_ħ_��ʥ��ȼ");
			SetAction(26,"���_ħ_��ʥ��ȼ");
			SetAction(27,"���_ħ_��ʥ��ȼ");
			SetAction(28,"���_ħ_��ʥ��ȼ");
			SetAction(29,"���_ħ_��ʥ��ȼ");
			SetAction(30,"���_ħ_��ʥ��ȼ");
			name = "����";
			nativename = "����";
			icon = "а�񹥻�.dds";
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

			return 60000 - 2000 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
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
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 4.0f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetIsignite() )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(3050.0f);
			victim.SetDarkness(true);
			*/
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
	public class GSkill3060 : GSkill
	{
		public GSkill3060()
			: base(3060)
		{
			
		}
	}
	public class GSkill3061Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				player_res1 = player.GetRes1();
				int				skill_level = skill.GetLevel();

				player.SetVar1(player_res1);
				player.SetHp(((player_hp - 100 * skill_level - 1050)));
				player.SetPerform(1);
			}
		}
		public GSkill3061Stub()
			: base(3061)
		{
			occupation = 168;
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
			SetAction(16,"������ʦ_����");
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
			name = "����<ɷ>";
			nativename = "����<ɷ>";
			icon = "ħ������.dds";
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

			return 720000 - 20000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 17.000000f;
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
			return 13.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (400 * skill_level + 2100);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 30;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((4 * skill_level + 20)));
			victim.SetTime(100.0f);
			victim.SetBuffid(1);
			victim.SetValue(((10 * player_var1 * (norm(skill_level / 19.9f)) + (player_var1 * skill_level))));
			victim.SetBleeding(true);
			if ( zrand(100) >= 5 * norm(skill_level / 19.9f) + skill_level + 15 )
			v37 = 0.0f;
			else
			victim.SetProbability(800.0f);
			victim.SetTime(((500 * skill_level + 2100)));
			victim.SetDizzy(true);
			victim.SetProbability(((2 * skill_level)));
			victim.SetTime(200000.0f);
			victim.SetRatio(3015.0f);
			victim.SetAmount(3013.0f);
			victim.SetValue(3013.0f);
			victim.SetSetcooldown(true);
			victim.SetProbability(((2 * skill_level)));
			victim.SetTime(200000.0f);
			victim.SetRatio(3010.0f);
			victim.SetAmount(3010.0f);
			victim.SetValue(3010.0f);
			victim.SetSetcooldown(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1546};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
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
	public class GSkill3061 : GSkill
	{
		public GSkill3061()
			: base(3061)
		{
			
		}
	}
	public class GSkill3062Stub : GSkillStub
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
		public GSkill3062Stub()
			: base(3062)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 3;
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
			SetAction(16,"������ʦ_����");
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
			name = "����<ɷ>";
			nativename = "����<ɷ>";
			icon = "ħ������.dds";
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
			return 30.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (25 * skill_level + 1525);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return D2INT(skill_level / 4.9f) + 4;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			if ( zrand(100) >= 3 * skill_level + 20 )
			d = 0.0f;
			else
			victim.SetProbability(900.0f);
			victim.SetTime(((500 * skill_level + 2100)));
			victim.SetRatio((skill_level * 0.04f + 0.15f));
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetTime(((500 * skill_level + 2100)));
			victim.SetRatio(1.0f);
			victim.SetDisperseanti(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1546};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
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

			return 4 * skill_level * skill_level + (50 * skill_level) + 190;
		}
	}
	public class GSkill3062 : GSkill
	{
		public GSkill3062()
			: base(3062)
		{
			
		}
	}
	public class GSkill3063Stub : GSkillStub
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
		public GSkill3063Stub()
			: base(3063)
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
			rangetype = 5;
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
			SetAction(16,"������ʦ_����");
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
			name = "����<ɷ>";
			nativename = "����<ɷ>";
			icon = "ħ������.dds";
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

			return 720000 - 30000 * skill_level;
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

			return (25 * skill_level + 325);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * skill_level + 10100)));
			victim.SetRatio(1.0f);
			victim.SetAmount(((skill_level + 10)));
			victim.SetValue(((12 * ((norm(skill_level / 19.9f)) * skill_level + skill_level))));
			victim.SetFrenzied(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * skill_level + 10100)));
			victim.SetRatio((skill_level * 0.0101f));
			victim.SetBuffid(2);
			victim.SetIncskilldodge(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1549};return array[index];
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

			return 3 * skill_level * skill_level + (30 * skill_level) + 180;
		}
	}
	public class GSkill3063 : GSkill
	{
		public GSkill3063()
			: base(3063)
		{
			
		}
	}
	public class GSkill3064Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill3064Stub()
			: base(3064)
		{
			occupation = 168;
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
			SetAction(0,"ħ_ħ����");
			SetAction(1,"ħ_ħ����");
			SetAction(2,"ħ_ħ����");
			SetAction(3,"ħ_ħ����");
			SetAction(4,"ħ_ħ����");
			SetAction(5,"ħ_ħ����");
			SetAction(6,"ħ_ħ����");
			SetAction(7,"ħ_ħ����");
			SetAction(8,"ħ_ħ����");
			SetAction(9,"ħ_ħ����");
			SetAction(10,"ħ_ħ����");
			SetAction(11,"ħ_ħ����");
			SetAction(12,"ħ_ħ����");
			SetAction(13,"ħ_ħ����");
			SetAction(14,"ħ_ħ����");
			SetAction(15,"ħ_ħ����");
			SetAction(16,"ħ_ħ����");
			SetAction(17,"ħ_ħ����");
			SetAction(18,"���_ħ_ħ����");
			SetAction(19,"���_ħ_ħ����");
			SetAction(20,"���_ħ_ħ����");
			SetAction(21,"���_ħ_ħ����");
			SetAction(22,"���_ħ_ħ����");
			SetAction(23,"���_ħ_ħ����");
			SetAction(24,"���_ħ_ħ����");
			SetAction(25,"���_ħ_ħ����");
			SetAction(26,"���_ħ_ħ����");
			SetAction(27,"���_ħ_ħ����");
			SetAction(28,"���_ħ_ħ����");
			SetAction(29,"���_ħ_ħ����");
			SetAction(30,"���_ħ_ħ����");
			name = "����";
			nativename = "����";
			icon = "а����.dds";
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

			return 720000 - 20000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,150};return array[level-1];
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
			victim.SetTime(((10000 * norm(skill_level / 19.9f) + (1000 * skill_level) + 10000)));
			victim.SetRatio(1.0f);
			victim.SetBuffid(0);
			victim.SetAmount(1.0f);
			victim.SetValue(41930.0f);
			victim.SetSummon(true);
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

			return 4 * skill_level * skill_level + (50 * skill_level) + 190;
		}
	}
	public class GSkill3064 : GSkill
	{
		public GSkill3064()
			: base(3064)
		{
			
		}
	}
	public class GSkill3065Stub : GSkillStub
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + (skill_t3 * 0.05f + 1.1f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((skill_level * (skill_level * 7.2f)) - skill_level * 6.4f + 694.0f)));
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + (skill_t3 * 0.05f + 1.1f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((skill_level * (skill_level * 7.2f)) - skill_level * 6.4f + 694.0f)));
				player.SetPerform(0);
			}
		}
		public GSkill3065Stub()
			: base(3065)
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
			SetAction(0,"������_�׹������");
			SetAction(1,"������_�׹������");
			SetAction(2,"������_�׹������");
			SetAction(3,"������_�׹������");
			SetAction(4,"������_�׹������");
			SetAction(5,"������_�׹������");
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
			SetAction(18,"������_���_�׹������");
			SetAction(19,"������_���_�׹������");
			SetAction(20,"������_���_�׹������");
			SetAction(21,"������_���_�׹������");
			SetAction(22,"������_���_�׹������");
			SetAction(23,"������_���_�׹������");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "�׹������<ɷ>";
			nativename = "�׹������<ɷ>";
			icon = "ħ���׹������.dds";
			SetTalent(0,582);
			SetTalent(1,606);
			SetTalent(2,610);
			SetTalent(3,617);
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 3000;
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
			return 21.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 21.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 24.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((skill_level * (skill_level * 11.5f)) - skill_level * 2.8f + 1630.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return skill_level + 10;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(((skill_level + 12)));
			victim.SetTime(((8000 * skill_t0 + 8100)));
			victim.SetBuffid(1);
			victim.SetValue(((225 * (skill_t0 + 1) * skill_level)));
			victim.SetSubattack(true);
			victim.SetProbability(((2 * skill_level + 5)));
			if ( skill_level <= 19 )
			t = 3050.0f;
			else
			victim.SetTime(4050.0f);
			victim.SetDiet(true);
			*/
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={783};return array[index];
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

			return 4 * skill_level * skill_level + (34 * skill_level) + 200;
		}
	}
	public class GSkill3065 : GSkill
	{
		public GSkill3065()
			: base(3065)
		{
			
		}
	}
	public class GSkill3066Stub : GSkillStub
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
		public GSkill3066Stub()
			: base(3066)
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
			rangetype = 5;
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
			SetAction(0,"������_������");
			SetAction(1,"������_������");
			SetAction(2,"������_������");
			SetAction(3,"������_������");
			SetAction(4,"������_������");
			SetAction(5,"������_������");
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
			SetAction(18,"������_���_������");
			SetAction(19,"������_���_������");
			SetAction(20,"������_���_������");
			SetAction(21,"������_���_������");
			SetAction(22,"������_���_������");
			SetAction(23,"������_���_������");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "������<ɷ>";
			nativename = "������<ɷ>";
			icon = "ħ��������.dds";
			SetTalent(0,578);
			SetTalent(1,592);
			SetTalent(2,594);
			SetTalent(3,596);
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
			int				skill_t3 = skill.GetT3();

			return 120000 - 10000 * skill_t3;
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

			return (30 * skill_level + 560);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(100.0f);
			victim.SetTime(20100.0f);
			victim.SetRatio(((D2INT((zrand(5 * skill_t2 + 99)) / 100) + 1) * (skill_t2 * 0.01f + (skill_level * 0.01f + 0.011f))));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t0 * 0.3f + 1.0f) * (skill_level * (player_maxhp * 0.01f))));
			victim.SetFashen(true);
			victim.SetProbability(((4 * skill_level + 15)));
			victim.SetTime(((1000 * skill_level + 4100)));
			victim.SetRatio((skill_level * 0.02f + 0.0001f));
			victim.SetBuffid(1);
			victim.SetIncskilldodge(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={784};return array[index];
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

			return 3 * skill_level * skill_level + (26 * skill_level) + 180;
		}
	}
	public class GSkill3066 : GSkill
	{
		public GSkill3066()
			: base(3066)
		{
			
		}
	}
	public class GSkill3067Stub : GSkillStub
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
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((D2INT((player_mp / (0.95f - skill_t2 * 0.1f)) / player_maxmp) * 0.08f + (skill_t3 * ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f)))));
				skill.SetPlus((((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * ((2 * (skill_level * skill_level + (11 * skill_level)) + 750))));
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
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((D2INT((player_mp / (0.95f - skill_t2 * 0.1f)) / player_maxmp) * 0.08f + (skill_t3 * ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f)))));
				skill.SetPlus((((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * ((2 * (skill_level * skill_level + (11 * skill_level)) + 750))));
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
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((D2INT((player_mp / (0.95f - skill_t2 * 0.1f)) / player_maxmp) * (skill_level * 0.02f + 0.06f) + (skill_t3 * ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f)))));
				skill.SetPlus((((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * ((2 * (skill_level * skill_level + (11 * skill_level)) + 750))));
				player.SetPerform(0);
			}
		}
		public GSkill3067Stub()
			: base(3067)
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
			SetAction(0,"������_̫���������");
			SetAction(1,"������_̫���������");
			SetAction(2,"������_̫���������");
			SetAction(3,"������_̫���������");
			SetAction(4,"������_̫���������");
			SetAction(5,"������_̫���������");
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
			SetAction(18,"������_���_̫���������");
			SetAction(19,"������_���_̫���������");
			SetAction(20,"������_���_̫���������");
			SetAction(21,"������_���_̫���������");
			SetAction(22,"������_���_̫���������");
			SetAction(23,"������_���_̫���������");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "̫���������<ɷ>";
			nativename = "̫���������<ɷ>";
			icon = "ħ��̫���������.dds";
			SetTalent(0,607);
			SetTalent(1,611);
			SetTalent(2,612);
			SetTalent(3,617);
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
			AddState(new GState3());
			AddState(new GState4());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 4000;
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
			return 23.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((4 * skill_level * skill_level) - 5 * skill_level + 2230);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return skill_level + 10;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((3 * skill_t1) + (skill_level * 0.5f + 2.0f)));
			victim.SetTime(3100.0f);
			victim.SetRatio(0.2f);
			victim.SetValue(0.2f);
			victim.SetRandcurse(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			victim.SetBuffid((D2INT((player_mp / (0.95f - skill_t2 * 0.1f)) / player_maxmp)));
			victim.SetUniqprompt(true);
			victim.SetProbability(((4 * skill_level + 15)));
			victim.SetClearweak(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={785};return array[index];
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

			return 4 * skill_level * skill_level + (34 * skill_level) + 200;
		}
	}
	public class GSkill3067 : GSkill
	{
		public GSkill3067()
			: base(3067)
		{
			
		}
	}
	public class GSkill3068Stub : GSkillStub
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3067) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((3 * skill_level * skill_level + (12 * skill_level) + 800))));
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3067) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((3 * skill_level * skill_level + (12 * skill_level) + 800))));
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3067) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((3 * skill_level * skill_level + (12 * skill_level) + 800))));
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3067) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((3 * skill_level * skill_level + (12 * skill_level) + 800))));
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3067) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((3 * skill_level * skill_level + (12 * skill_level) + 800))));
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3067) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * (((D2INT((zrand(5 * skill_level + 99)) / 100) + 1) * (3 * skill_level * skill_level + (12 * skill_level) + 800)))));
				player.SetPerform(0);
			}
		}
		public GSkill3068Stub()
			: base(3068)
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
			SetAction(0,"������_���������");
			SetAction(1,"������_���������");
			SetAction(2,"������_���������");
			SetAction(3,"������_���������");
			SetAction(4,"������_���������");
			SetAction(5,"������_���������");
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
			SetAction(18,"������_���_���������");
			SetAction(19,"������_���_���������");
			SetAction(20,"������_���_���������");
			SetAction(21,"������_���_���������");
			SetAction(22,"������_���_���������");
			SetAction(23,"������_���_���������");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "���������<ɷ>";
			nativename = "���������<ɷ>";
			icon = "ħ�����������.dds";
			SetTalent(0,593);
			SetTalent(1,607);
			SetTalent(2,617);
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
			AddState(new GState3());
			AddState(new GState4());
			AddState(new GState5());
			AddState(new GState6());
			AddState(new GState7());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 6000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 16000;
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
			return 26.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (30 * skill_level * skill_level + 2560);
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

			/*
			if ( zrand(100) >= 2 * skill_level )
			d = 0.0f;
			else
			victim.SetProbability(((10 * skill_level + 550)));
			victim.SetTime(6100.0f);
			victim.SetSilent(true);
			victim.SetProbability(((skill_level + player_var1)));
			victim.SetTime(((500 * skill_t0 + 6100)));
			victim.SetWrap(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetRatio(((2848 * D2INT((zrand(2 * skill_level + 100)) / 100) + 220)));
			victim.SetAmount(220.0f);
			victim.SetValue(220.0f);
			victim.SetClearcooldown(true);
			victim.SetTime(6100.0f);
			victim.SetImmunedizzy(true);
			victim.SetProbability(((4 * skill_level + 12)));
			victim.SetRatio((skill_level * 0.005f));
			victim.SetValue(0.0f);
			victim.SetScopedamage(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={786};return array[index];
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

			return 4 * skill_level * skill_level + (34 * skill_level) + 200;
		}
	}
	public class GSkill3068 : GSkill
	{
		public GSkill3068()
			: base(3068)
		{
			
		}
	}
	public class GSkill3069Stub : GSkillStub
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * 0.01f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.1f))));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * ((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f)));
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
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * 0.02f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.1f))));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * ((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f)));
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
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * 0.03f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.1f))));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * ((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f)));
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
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * 0.04f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.1f))));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * ((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f)));
				player.SetPerform(0);
			}
		}
		public GSkill3069Stub()
			: base(3069)
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
			autoattack = true;
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
			SetAction(0,"������_ħ������");
			SetAction(1,"������_ħ������");
			SetAction(2,"������_ħ������");
			SetAction(3,"������_ħ������");
			SetAction(4,"������_ħ������");
			SetAction(5,"������_ħ������");
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
			SetAction(18,"������_���_ħ������");
			SetAction(19,"������_���_ħ������");
			SetAction(20,"������_���_ħ������");
			SetAction(21,"������_���_ħ������");
			SetAction(22,"������_���_ħ������");
			SetAction(23,"������_���_ħ������");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ħ������<ɷ>";
			nativename = "ħ������<ɷ>";
			icon = "ħ��ħ������.dds";
			SetTalent(0,640);
			SetTalent(1,644);
			SetTalent(2,661);
			SetTalent(3,663);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			return (-1350 * skill_t3) - 1350 * skill_t2 + 9000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 1.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (10 * skill_level + 850);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			/*
			victim.SetProbability(((6 * skill_t0 + 30)));
			victim.SetTime(((3000 * skill_t0 + 11100)));
			victim.SetRatio(((D2INT(zrand(100) / (100 - 6 * skill_t1)) + 1) * (skill_t1 * 0.03f + 0.11f)));
			victim.SetBuffid(3);
			victim.SetTiansha(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((40 * skill_level + 160)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			if ( player.GetObjectType()
			|| (v21 = player,
			v22 = GNET::PlayerWrapper::GetHp(v21),
			v22 <= player,_maxhp * 0.5f) )
			v31 = 0.0f;
			else
			victim.SetProbability(((5 * skill_level)));
			victim.SetValue((skill_level * (player_maxhp * 0.005f)));
			victim.SetDirecthurt(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={775};return array[index];
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

			return 3 * skill_level * skill_level + (42 * skill_level) + 170;
		}
	}
	public class GSkill3069 : GSkill
	{
		public GSkill3069()
			: base(3069)
		{
			
		}
	}
}
