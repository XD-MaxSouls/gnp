using System;
using System.Text;

namespace SKILL
{
	public class GSkill3000Stub : GSkillStub
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
		public GSkill3000Stub()
			: base(3000)
		{
			occupation = 128;
			maxlevel = 500;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
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
			name = "������30��������";
			nativename = "������30��������";
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
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 4.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 1.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 7.0f;
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
			victim.SetTime(120000.0f);
			victim.SetBuffid(2);
			victim.SetValue(zrand(100));
			victim.SetAddattack(true);
			victim.SetProbability(((16 * skill_level)));
			victim.SetTime(120000.0f);
			victim.SetBuffid(5);
			victim.SetValue(zrand(100));
			victim.SetAdddefence(true);
			victim.SetProbability(((16 * skill_level)));
			victim.SetTime(120000.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(5);
			victim.SetInccrithurt(true);
			victim.SetProbability(((14 * skill_level)));
			victim.SetTime(120000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(5);
			victim.SetIncdrugeffect(true);
			return true;
		}
	}
	public class GSkill3000 : GSkill
	{
		public GSkill3000()
			: base(3000)
		{
			
		}
	}
	public class GSkill3001Stub : GSkillStub
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

				skill.SetRatio(0.94999999f);
				player.SetPerform(1);
			}
		}
		public GSkill3001Stub()
			: base(3001)
		{
			occupation = 128;
			maxlevel = 500;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			name = "������5��������";
			nativename = "������5��������";
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 4.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 1.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 7.0f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( zrand(100) > 20 )
			d = 0.0f;
			else
			victim.SetProbability(800.0f);
			victim.SetTime(300000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(6);
			victim.SetWeak(true);
			if ( zrand(100) > 20 )
			v23 = 0.0f;
			else
			victim.SetProbability(800.0f);
			victim.SetTime(300000.0f);
			victim.SetSilent(true);
			if ( zrand(100) > 20 )
			v22 = 0.0f;
			else
			victim.SetProbability(200.0f);
			victim.SetTime(300000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetBuffid(6);
			victim.SetSlow(true);
			if ( zrand(100) > 20 )
			v21 = 0.0f;
			else
			victim.SetProbability(100.0f);
			victim.SetTime(300000.0f);
			victim.SetRatio(0.5f);
			victim.SetBuffid(6);
			victim.SetDecdrugeffect(true);
			*/
			return true;
		}
	}
	public class GSkill3001 : GSkill
	{
		public GSkill3001()
			: base(3001)
		{
			
		}
	}
	public class GSkill3002Stub : GSkillStub
	{
		public GSkill3002Stub()
			: base(3002)
		{
			occupation = 129;
			maxlevel = 99;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 13;
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
			name = "�ٻ�����";
			nativename = "�ٻ�����";
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(300000.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(0);
			victim.SetAmount(1.0f);
			victim.SetValue(41279.0f);
			victim.SetSummon(true);
			return true;
		}
	}
	public class GSkill3002 : GSkill
	{
		public GSkill3002()
			: base(3002)
		{
			
		}
	}
	public class GSkill3003Stub : GSkillStub
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
		public GSkill3003Stub()
			: base(3003)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"������_��ľ��");
			SetAction(1,"������_��������");
			SetAction(2,"������_��ľ��");
			SetAction(3,"�ϻ���_����");
			SetAction(4,"������_�׽");
			SetAction(5,"����Ѫ��");
			SetAction(6,"0");
			SetAction(7,"����_����");
			SetAction(8,"����_��Ԫ��");
			SetAction(9,"0");
			SetAction(10,"����_͵Ϯ");
			SetAction(11,"0");
			SetAction(12,"�컪_����");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"������_���_��ľ��");
			SetAction(19,"������_���_��������");
			SetAction(20,"������_���_��ľ��");
			SetAction(21,"�ϻ���_���_����");
			SetAction(22,"������_���_�׽");
			SetAction(23,"����Ѫ��");
			SetAction(24,"0");
			SetAction(25,"����_���_����");
			SetAction(26,"����_���_��Ԫ��");
			SetAction(27,"0");
			SetAction(28,"����_���_͵Ϯ");
			SetAction(29,"0");
			SetAction(30,"�컪_���_����");
			name = "���˾�";
			nativename = "���˾�";
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
			return 15000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 35.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(30000.0f);
			victim.SetInvincible(true);
			return true;
		}
	}
	public class GSkill3003 : GSkill
	{
		public GSkill3003()
			: base(3003)
		{
			
		}
	}
	public class GSkill3004Stub : GSkillStub
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

				skill.SetRatio(0.0f);
				player.SetPerform(1);
			}
		}
		public GSkill3004Stub()
			: base(3004)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"������_Ǭ��ն");
			SetAction(1,"������_Ǭ��ն");
			SetAction(2,"������_Ǭ��ն");
			SetAction(3,"�ϻ���_Ǭ��ն");
			SetAction(4,"������_Ǭ��ն");
			SetAction(5,"���_Ǭ��ն");
			SetAction(6,"0");
			SetAction(7,"����_һ��");
			SetAction(8,"����_����ʸ");
			SetAction(9,"0");
			SetAction(10,"����_ǳϮ");
			SetAction(11,"0");
			SetAction(12,"�컪_��Ԫ����");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"������_���_Ǭ��ն");
			SetAction(19,"������_���_Ǭ��ն");
			SetAction(20,"������_���_Ǭ��ն");
			SetAction(21,"�ϻ���_���_Ǭ��ն");
			SetAction(22,"������_���_Ǭ��ն");
			SetAction(23,"���_���_Ǭ��ն");
			SetAction(24,"0");
			SetAction(25,"����_���_һ��");
			SetAction(26,"����_���_����ʸ");
			SetAction(27,"0");
			SetAction(28,"����_���_ǳϮ");
			SetAction(29,"0");
			SetAction(30,"�컪_���_��Ԫ����");
			name = "����ǧ��";
			nativename = "����ǧ��";
			icon = "ʧ����.dds";
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetTmplid() == 41014 )
			d = 800.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(6000.0f);
			victim.SetDizzy(true);
			if ( player.GetTmplid() == 41007 )
			v12 = 100.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetValue(((zrand(500) + 250)));
			victim.SetDirecthurt(true);
			*/
			return true;
		}
	}
	public class GSkill3004 : GSkill
	{
		public GSkill3004()
			: base(3004)
		{
			
		}
	}
	public class GSkill3005Stub : GSkillStub
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
		public GSkill3005Stub()
			: base(3005)
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
			SetAction(0,"��_�ǳ�����");
			SetAction(1,"��_�ǳ�����");
			SetAction(2,"��_�ǳ�����");
			SetAction(3,"��_�ǳ�����");
			SetAction(4,"��_�ǳ�����");
			SetAction(5,"��_�ǳ�����");
			SetAction(6,"��_�ǳ�����");
			SetAction(7,"��_�ǳ�����");
			SetAction(8,"��_�ǳ�����");
			SetAction(9,"��_�ǳ�����");
			SetAction(10,"��_�ǳ�����");
			SetAction(11,"��_�ǳ�����");
			SetAction(12,"��_�ǳ�����");
			SetAction(13,"��_�ǳ�����");
			SetAction(14,"��_�ǳ�����");
			SetAction(15,"��_�ǳ�����");
			SetAction(16,"��_�ǳ�����");
			SetAction(17,"��_�ǳ�����");
			SetAction(18,"���_��_�ǳ�����");
			SetAction(19,"���_��_�ǳ�����");
			SetAction(20,"���_��_�ǳ�����");
			SetAction(21,"���_��_�ǳ�����");
			SetAction(22,"���_��_�ǳ�����");
			SetAction(23,"���_��_�ǳ�����");
			SetAction(24,"���_��_�ǳ�����");
			SetAction(25,"���_��_�ǳ�����");
			SetAction(26,"���_��_�ǳ�����");
			SetAction(27,"���_��_�ǳ�����");
			SetAction(28,"���_��_�ǳ�����");
			SetAction(29,"���_��_�ǳ�����");
			SetAction(30,"���_��_�ǳ�����");
			name = "��������";
			nativename = "��������";
			icon = "Ԫ������.dds";
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
			victim.SetMiracleburstxian(true);
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
	public class GSkill3005 : GSkill
	{
		public GSkill3005()
			: base(3005)
		{
			
		}
	}
	public class GSkill3006Stub : GSkillStub
	{
		public GSkill3006Stub()
			: base(3006)
		{
			occupation = 167;
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
	public class GSkill3006 : GSkill
	{
		public GSkill3006()
			: base(3006)
		{
			
		}
	}
	public class GSkill3007Stub : GSkillStub
	{
		public GSkill3007Stub()
			: base(3007)
		{
			occupation = 167;
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
			icon = "�˷���.dds";
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
	public class GSkill3007 : GSkill
	{
		public GSkill3007()
			: base(3007)
		{
			
		}
	}
	public class GSkill3008Stub : GSkillStub
	{
		public GSkill3008Stub()
			: base(3008)
		{
			occupation = 167;
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
			icon = "���ɡ���.dds";
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
	public class GSkill3008 : GSkill
	{
		public GSkill3008()
			: base(3008)
		{
			
		}
	}
	public class GSkill3009Stub : GSkillStub
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
		public GSkill3009Stub()
			: base(3009)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 20;
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
			SetAction(0,"��_�����Ǳ�");
			SetAction(1,"��_�����Ǳ�");
			SetAction(2,"��_�����Ǳ�");
			SetAction(3,"��_�����Ǳ�");
			SetAction(4,"��_�����Ǳ�");
			SetAction(5,"��_�����Ǳ�");
			SetAction(6,"��_�����Ǳ�");
			SetAction(7,"��_�����Ǳ�");
			SetAction(8,"��_�����Ǳ�");
			SetAction(9,"��_�����Ǳ�");
			SetAction(10,"��_�����Ǳ�");
			SetAction(11,"��_�����Ǳ�");
			SetAction(12,"��_�����Ǳ�");
			SetAction(13,"��_�����Ǳ�");
			SetAction(14,"��_�����Ǳ�");
			SetAction(15,"��_�����Ǳ�");
			SetAction(16,"��_�����Ǳ�");
			SetAction(17,"��_�����Ǳ�");
			SetAction(18,"���_��_�����Ǳ�");
			SetAction(19,"���_��_�����Ǳ�");
			SetAction(20,"���_��_�����Ǳ�");
			SetAction(21,"���_��_�����Ǳ�");
			SetAction(22,"���_��_�����Ǳ�");
			SetAction(23,"���_��_�����Ǳ�");
			SetAction(24,"���_��_�����Ǳ�");
			SetAction(25,"���_��_�����Ǳ�");
			SetAction(26,"���_��_�����Ǳ�");
			SetAction(27,"���_��_�����Ǳ�");
			SetAction(28,"���_��_�����Ǳ�");
			SetAction(29,"���_��_�����Ǳ�");
			SetAction(30,"���_��_�����Ǳ�");
			name = "��ˮ��";
			nativename = "��ˮ��";
			icon = "���Ⱥ���.dds";
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

			return 120000 - 4000 * skill_level;
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
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 14.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((4000 * norm(skill_level / 19.9f) + (500 * skill_level) + 2050)));
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(1);
			victim.SetColdinjure(true);
			victim.SetProbability(900.0f);
			victim.SetTime(((500 * skill_level + 2050)));
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((500 * skill_level + 2050)));
			victim.SetRatio((skill_level * 0.02f));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetProbability(((70 * norm(skill_level / 19.9f))));
			victim.SetTime(3050.0f);
			victim.SetDiet(true);
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
	public class GSkill3009 : GSkill
	{
		public GSkill3009()
			: base(3009)
		{
			
		}
	}
}
