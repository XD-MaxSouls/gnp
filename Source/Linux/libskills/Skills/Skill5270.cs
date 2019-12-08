using System;
using System.Text;

namespace SKILL
{
	public class GSkill5270Stub : GSkillStub
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

				player.SetVar5(player.GetHasbuff(4270));
				player.SetVar1(player_maxatk);
				player.SetPerform(1);
			}
		}
		public GSkill5270Stub()
			: base(5270)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 1;
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
			weapon_limit = 14;
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
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
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
			name = "×ÝºáÌìÏÂ<É·>";
			nativename = "×ÝºáÌìÏÂ<É·>";
			icon = "×ÝºáÌìÏÂ_Ä§.dds";
			SetTalent(0,5216);
			SetTalent(1,4843);
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
			skill_class = 13;
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
			return 500;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_var5 = player.GetVar5();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((500 * skill_level + 4500)));
			victim.SetRatio((skill_level * 0.05f + 1.0f));
			v29 = ((player_maxhp - player_hp)) / player_maxhp;
			if ( player.GetCultivation() == 2 )
			{
			v28 = player.GetSkilllevel(5260) * 0.05f * v29;
			}
			else
			{
			v28 = 0.0f * v29;
			}
			victim.SetAmount(v28);
			victim.SetValue(((80 * skill_level + 640)));
			victim.SetCycleskill(true);
			victim.SetProbability(120.0f);
			if ( player_var5 )
			t = 10.0f;
			else
			victim.SetTime(((500 * skill_level + 4500)));
			victim.SetRatio(1.0f);
			victim.SetBuffid(5);
			victim.SetValue(5227.0f);
			victim.SetDelaycast(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4877};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
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

			return 5 * skill_level;
		}
		public override int GetHpcost(GSkill skill)
		{
			return 50;
		}
	}
	public class GSkill5270 : GSkill
	{
		public GSkill5270()
			: base(5270)
		{
			
		}
	}
	public class GSkill5271Stub : GSkillStub
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
				int				player_rage = player.GetRage();

				player.SetVar1(player_rage);
				player.SetRage(0);
				player.SetPerform(1);
			}
		}
		public GSkill5271Stub()
			: base(5271)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 20;
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
			SetAction(0,"Ó¢ÕÐ_·´ÉË");
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
			SetAction(13,"0");
			SetAction(14,"Ó¢ÕÐ_·´ÉË");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ó¢ÕÐ_·´ÉË");
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
			name = "°ÔÎÞË«<É·>";
			nativename = "°ÔÎÞË«<É·>";
			icon = "¼Æ£º½èµ¶É±ÈË_Ä§.dds";
			SetTalent(0,5186);
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
			skill_class = 13;
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
			return 60000;
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxatk = player.GetMaxatk();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(((25 * skill_t0)));
			if ( skill_t0 <= 0 )
			{
			t = 0.0f;
			}
			else
			{
			t = (1000 * player.GetSkilllevel(4878) + 5000);
			}
			victim.SetTime(t);
			victim.SetRejectdebuff(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * player.GetSkilllevel(4878) + 5000)));
			victim.SetRatio(3.0f);
			v29 = skill_level * (player_var1 * 0.01f) + (player_var1 * 0.5f + (skill_level * (player_maxatk * 0.2f) + ((5 * player_maxatk))));
			if ( player.GetDmgreduce() > 998 )
			{
			v28 = 1000.0f * v29;
			}
			else
			{
			v28 = 1000.0f * (1.0f / (1000 - player.GetDmgreduce()) * v29);
			}
			victim.SetAmount(v28);
			victim.SetValue(100.0f);
			victim.SetRetort(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4878};return array[index];
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

			return 3 * skill_level * skill_level + (42 * skill_level) + 170;
		}
	}
	public class GSkill5271 : GSkill
	{
		public GSkill5271()
			: base(5271)
		{
			
		}
	}
	public class GSkill5272Stub : GSkillStub
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
				int				player_maxhp = player.GetMaxhp();
				int				player_rage = player.GetRage();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				/*
				skill.SetCrit(((player_rage * (skill_level * 0.01f)) / player_maxhp + (skill_t0 * 0.05f)));
				skill.SetRatio(2.0f);
				if ( player.GetHasbuff(4271) )
				  {
				skill.SetPlus((player_rage * (skill_level * 0.01f + 0.5f)));
				  }
				  else
				  {
				    skill.SetPlus(0.0f);
				  }
				if ( player.GetHasbuff(4271) )
				  {
				    skill.SetPlus2(0.0f);
				  }
				  else
				  {
				skill.SetPlus2((player_rage * (skill_level * 0.01f + 0.5f)));
				  }
				player.SetRage(0);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill5272Stub()
			: base(5272)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
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
			weapon_limit = 14;
			SetAction(0,"Ó¢ÕÐ_Å­Õ¶");
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
			SetAction(13,"0");
			SetAction(14,"Ó¢ÕÐ_Å­Õ¶");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ó¢ÕÐ_Å­Õ¶");
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
			name = "ÄæÁÛ¶Ï<É·>";
			nativename = "ÄæÁÛ¶Ï<É·>";
			icon = "Å­Õ¶_Ä§.dds";
			SetTalent(0,5220);
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
			skill_class = 13;
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
			return 1400;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 90000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 5.0f;
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

			return player_range + 10.0f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4879};return array[index];
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

			return 3 * skill_level * skill_level + (42 * skill_level) + 170;
		}
		public override int GetHpcost(GSkill skill)
		{
			return 500;
		}
	}
	public class GSkill5272 : GSkill
	{
		public GSkill5272()
			: base(5272)
		{
			
		}
	}
	public class GSkill5273Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill5273Stub()
			: base(5273)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 20;
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
			SetAction(0,"Ó¢ÕÐ_²»ÐàÖ®Íõ");
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
			SetAction(13,"0");
			SetAction(14,"Ó¢ÕÐ_²»ÐàÖ®Íõ");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ó¢ÕÐ_²»ÐàÖ®Íõ");
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
			name = "ÑÖÍõµÐ<É·>";
			nativename = "ÑÖÍõµÐ<É·>";
			icon = "°ÔÍõÎÞË«_Ä§.dds";
			SetTalent(0,5209);
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
			skill_class = 13;
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_t0 + 10000)));
			victim.SetValue((player_maxhp * (player.GetSkilllevel(4880) * 0.05f)));
			victim.SetBuxiu(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_t0 + 10000)));
			victim.SetRatio((skill_level * 0.05f));
			victim.SetBuffid(0);
			victim.SetInccrithurt(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4880};return array[index];
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

			return 3 * skill_level * skill_level + (26 * skill_level) + 180;
		}
	}
	public class GSkill5273 : GSkill
	{
		public GSkill5273()
			: base(5273)
		{
			
		}
	}
	public class GSkill5274Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_res4 = player.GetRes4();

				/*
				player.SetVar3(player.GetSkilllevel(5197));
				if ( player.GetCultivation() == 4 )
				  {
				v = player.GetSkilllevel(5264);
				  }
				  else
				  {
				    v = 0;
				  }
				player.SetVar2(v);
				player.SetVar5(player.GetHasbuff(4270));
				if ( player.GetCultivation() != 4
				    || (v12 = player, GNET::PlayerWrapper::GetSkilllevel(v12, 5264) <= 0) )
				  {
				v25 = (3 * player_level) + 10 * player.GetSkilllevel(5197);
				  }
				  else
				  {
				if ( 8 * player.GetSkilllevel(5264) + player_res4 <= 600 )
				    {
				      v24 = 600;
				    }
				    else
				    {
				v24 = player_res4 + 8 * player.GetSkilllevel(5264);
				    }
				    v25 = v24;
				  }
				player.SetVar1(v25);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill5274Stub()
			: base(5274)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 1;
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
			weapon_limit = 14;
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
			SetAction(13,"0");
			SetAction(14,"0");
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
			name = "×ÝºáÌìÏÂ<ìø>";
			nativename = "×ÝºáÌìÏÂ<ìø>";
			icon = "×ÝºáÌìÏÂ_·ð.dds";
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
			skill_class = 13;
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
			return 500;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_minatk = player.GetMinatk();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();

			/*
			if ( player.GetObjectType() || (v3 = player, GNET::PlayerWrapper::GetVar3(v3) <= 0) )
			{
			d = 0.0f;
			}
			else
			{
			d = player_var1;
			}
			victim.SetProbability(d);
			victim.SetTime(10.0f);
			victim.SetSilent(true);
			if ( player.GetObjectType() )
			v30 = 120.0f;
			else
			victim.SetProbability(-1.0f);
			victim.SetTime(2500.0f);
			victim.SetAssault2(true);
			victim.SetProbability(120.0f);
			victim.SetTime(2500.0f);
			victim.SetBuffid(0);
			victim.SetValue((player_minatk * (skill_level * 0.01f)));
			victim.SetSubattack(true);
			if ( player_var2 <= 0 )
			v29 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(2500.0f);
			victim.SetRatio((player_var2 * 0.01f));
			victim.SetBuffid(0);
			victim.SetDecskilldodge(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var5 = player.GetVar5();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((500 * skill_level + 4500)));
			victim.SetRatio((skill_level * 0.05f + 1.0f));
			victim.SetAmount(0.0f);
			victim.SetValue(((80 * skill_level + 640)));
			victim.SetCycleskill(true);
			victim.SetProbability(120.0f);
			if ( player_var5 )
			t = 10.0f;
			else
			victim.SetTime(((500 * skill_level + 4500)));
			victim.SetRatio(1.0f);
			victim.SetBuffid(5);
			victim.SetValue(5227.0f);
			victim.SetDelaycast(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4877};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
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

			return 5 * skill_level;
		}
		public override int GetHpcost(GSkill skill)
		{
			return 50;
		}
	}
	public class GSkill5274 : GSkill
	{
		public GSkill5274()
			: base(5274)
		{
			
		}
	}
	public class GSkill5275Stub : GSkillStub
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
				int				player_rage = player.GetRage();

				player.SetVar1(player_rage);
				player.SetRage(0);
				player.SetPerform(1);
			}
		}
		public GSkill5275Stub()
			: base(5275)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
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
			SetAction(0,"Ó¢ÕÐ_·´ÉË");
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
			SetAction(13,"0");
			SetAction(14,"Ó¢ÕÐ_·´ÉË");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ó¢ÕÐ_·´ÉË");
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
			name = "°ÔÎÞË«<ìø>";
			nativename = "°ÔÎÞË«<ìø>";
			icon = "¼Æ£º½èµ¶É±ÈË_·ð.dds";
			SetTalent(0,5186);
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
			skill_class = 13;
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
			return 60000;
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxatk = player.GetMaxatk();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(((25 * skill_t0)));
			if ( skill_t0 <= 0 )
			{
			t = 0.0f;
			}
			else
			{
			t = (1000 * player.GetSkilllevel(4878) + 5000);
			}
			victim.SetTime(t);
			victim.SetRejectdebuff(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((skill_level * 0.05f + 1.0f) * ((1000 * player.GetSkilllevel(4878) + 5000))));
			victim.SetRatio(3.0f);
			v27 = skill_level * (player_var1 * 0.01f) + (player_var1 * 0.5f + ((5 * player_maxatk)));
			if ( player.GetDmgreduce() > 998 )
			{
			v26 = 1000.0f * v27;
			}
			else
			{
			v26 = 1000.0f * (1.0f / (1000 - player.GetDmgreduce()) * v27);
			}
			victim.SetAmount(v26);
			victim.SetValue(100.0f);
			victim.SetRetort(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4878};return array[index];
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

			return 3 * skill_level * skill_level + (42 * skill_level) + 170;
		}
	}
	public class GSkill5275 : GSkill
	{
		public GSkill5275()
			: base(5275)
		{
			
		}
	}
	public class GSkill5276Stub : GSkillStub
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
				int				player_rage = player.GetRage();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				/*
				skill.SetCrit((skill_t0 * 0.05f));
				skill.SetRatio(2.0f);
				if ( player.GetHasbuff(4271) )
				  {
				skill.SetPlus((player_rage * (skill_level * 0.01f + 0.5f)));
				  }
				  else
				  {
				    skill.SetPlus(0.0f);
				  }
				if ( player.GetHasbuff(4271) )
				  {
				    skill.SetPlus2(0.0f);
				  }
				  else
				  {
				skill.SetPlus2((player_rage * (skill_level * 0.01f + 0.5f)));
				  }
				player.SetRage(0);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill5276Stub()
			: base(5276)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 1;
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
			weapon_limit = 14;
			SetAction(0,"Ó¢ÕÐ_Å­Õ¶");
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
			SetAction(13,"0");
			SetAction(14,"Ó¢ÕÐ_Å­Õ¶");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ó¢ÕÐ_Å­Õ¶");
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
			name = "ÄæÁÛ¶Ï<ìø>";
			nativename = "ÄæÁÛ¶Ï<ìø>";
			icon = "Å­Õ¶_·ð.dds";
			SetTalent(0,5220);
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
			skill_class = 13;
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
			return 1400;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 90000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 5.0f;
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

			return player_range + 10.0f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			if ( player.GetBuffcnt() )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(50.0f);
			victim.SetRatio((((skill_level * 0.5f) + 1)));
			victim.SetBuffid(6);
			if ( (skill_level * 0.5f) + 1 <= player.GetBuffcnt() )
			{
			if ( (skill_level * 0.5f) + 1 <= 2 )
			{
			LABEL_21:
			v27 = 3615.0f;
			goto LABEL_22;
			}
			}
			else
			{
			if ( player.GetBuffcnt() <= 2 )
			goto LABEL_21;
			}
			if ( (skill_level * 0.5f) + 1 <= player.GetBuffcnt() )
			{
			if ( (skill_level * 0.5f) + 1 <= 4 )
			{
			LABEL_19:
			v26 = 3617.0f;
			goto LABEL_20;
			}
			}
			else
			{
			if ( player.GetBuffcnt() <= 4 )
			goto LABEL_19;
			}
			if ( (skill_level * 0.5f) + 1 <= player.GetBuffcnt() )
			{
			if ( (skill_level * 0.5f) + 1 <= 6 )
			{
			LABEL_17:
			v25 = 3633.0f;
			goto LABEL_18;
			}
			}
			else
			{
			if ( player.GetBuffcnt() <= 6 )
			goto LABEL_17;
			}
			v25 = 3634.0f;
			LABEL_18:
			v26 = v25;
			LABEL_20:
			v27 = v26;
			LABEL_22:
			victim.SetValue(v27);
			victim.SetDelaycast(true);
			victim.SetTime(1000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((((skill_level * 0.5f) + 1)));
			victim.SetTurnbuff(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4879};return array[index];
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

			return 3 * skill_level * skill_level + (42 * skill_level) + 170;
		}
		public override int GetHpcost(GSkill skill)
		{
			return 500;
		}
	}
	public class GSkill5276 : GSkill
	{
		public GSkill5276()
			: base(5276)
		{
			
		}
	}
	public class GSkill5277Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill5277Stub()
			: base(5277)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
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
			SetAction(0,"Ó¢ÕÐ_²»ÐàÖ®Íõ");
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
			SetAction(13,"0");
			SetAction(14,"Ó¢ÕÐ_²»ÐàÖ®Íõ");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ó¢ÕÐ_²»ÐàÖ®Íõ");
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
			name = "ÑÖÍõµÐ<ìø>";
			nativename = "ÑÖÍõµÐ<ìø>";
			icon = "°ÔÍõÎÞË«_·ð.dds";
			SetTalent(0,5209);
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
			skill_class = 13;
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetTime(((500 * skill_level + (1000 * skill_t0) + 10000)));
			victim.SetValue((player_maxhp * (player.GetSkilllevel(4880) * 0.05f)));
			victim.SetBuxiu(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={4880};return array[index];
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

			return 3 * skill_level * skill_level + (26 * skill_level) + 180;
		}
	}
	public class GSkill5277 : GSkill
	{
		public GSkill5277()
			: base(5277)
		{
			
		}
	}
	public class GSkill5278Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1750;
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
				return 250;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio(2.0f);
				skill.SetCrit(2.0f);
				skill.SetCrithurt(20.0f);
				player.SetPerform(1);
			}
		}
		public GSkill5278Stub()
			: base(5278)
		{
			occupation = 187;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = false;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 14;
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
			SetAction(0,"ÁéÙí_xp¼¼ÄÜ");
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
			SetAction(13,"ÁéÙí_xp¼¼ÄÜ");
			SetAction(14,"0");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÁéÙí_Æï³Ë_xp¼¼ÄÜ");
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
			name = "ÃØ·¨¡¤Ç§±äÐþ»ú";
			nativename = "ÃØ·¨¡¤Ç§±äÐþ»ú";
			icon = "ºÏ»¶XP¼¼ÄÜ.dds";
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
			skill_class = 12;
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
			return 600000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
	}
	public class GSkill5278 : GSkill
	{
		public GSkill5278()
			: base(5278)
		{
			
		}
	}
	public class GSkill5279Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1750;
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
				return 250;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio(2.0f);
				skill.SetCrit(2.0f);
				skill.SetCrithurt(20.0f);
				player.SetPerform(1);
			}
		}
		public GSkill5279Stub()
			: base(5279)
		{
			occupation = 187;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = false;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 14;
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
			SetAction(0,"Ó¢ÕÐ_xp¼¼ÄÜ");
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
			SetAction(13,"0");
			SetAction(14,"Ó¢ÕÐ_xp¼¼ÄÜ");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ó¢ÕÐ_xp¼¼ÄÜ");
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
			name = "ÃØ·¨¡¤ÖðÂ¹¾ÅÖÝ";
			nativename = "ÃØ·¨¡¤ÖðÂ¹¾ÅÖÝ";
			icon = "¹íÍõXP¼¼ÄÜ.dds";
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
			skill_class = 13;
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
			return 600000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
	}
	public class GSkill5279 : GSkill
	{
		public GSkill5279()
			: base(5279)
		{
			
		}
	}
}
