using System;
using System.Text;

namespace SKILL
{
	public class GSkill6650Stub : GSkillStub
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
		public GSkill6650Stub()
			: base(6650)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 3;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 4;
			skill_limit = 22;
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
			weapon_limit = 17;
			SetAction(0,"¹éÔÆ_É¡Á¬½Ó");
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
			SetAction(16,"0");
			SetAction(17,"¹éÔÆ_É¡Á¬½Ó");
			SetAction(18,"¹éÔÆ_Æï³Ë_É¡Á¬½Ó");
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
			name = "ÌìÂÞ·÷ÔÂ<ìø>";
			nativename = "ÌìÂÞ·÷ÔÂ<ìø>";
			icon = "ÌìÂÞ·÷ÔÂìø.dds";
			SetTalent(0,6510);
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
			skill_class = 16;
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
			return 1500;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 89000;
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
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 771.000000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={6539};return array[index];
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
	}
	public class GSkill6650 : GSkill
	{
		public GSkill6650()
			: base(6650)
		{
			
		}
	}
	public class GSkill6651Stub : GSkillStub
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
		public GSkill6651Stub()
			: base(6651)
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
			rangetype = 5;
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
			weapon_limit = 17;
			SetAction(0,"¹éÔÆ_¸ß½×±¬·¢");
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
			SetAction(16,"0");
			SetAction(17,"¹éÔÆ_¸ß½×±¬·¢");
			SetAction(18,"¹éÔÆ_Æï³Ë_¸ß½×±¬·¢");
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
			name = "³Å»¨ÕÕÓ°<ìø>";
			nativename = "³Å»¨ÕÕÓ°<ìø>";
			icon = "³Å»¨ÕÕÓ°ìø.dds";
			SetTalent(0,6492);
			SetTalent(1,6509);
			SetTalent(2,6475);
			SetTalent(3,6466);
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
			skill_class = 16;
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
			return 99000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetMpcost(GSkill skill)
		{
			return 452.000000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={6540};return array[index];
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
	}
	public class GSkill6651 : GSkill
	{
		public GSkill6651()
			: base(6651)
		{
			
		}
	}
	public class GSkill6652Stub : GSkillStub
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
		public GSkill6652Stub()
			: base(6652)
		{
			occupation = 169;
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
			weapon_limit = 17;
			SetAction(0,"¹éÔÆ_É¡°ÂÒå");
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
			SetAction(16,"0");
			SetAction(17,"¹éÔÆ_É¡°ÂÒå");
			SetAction(18,"¹éÔÆ_Æï³Ë_É¡°ÂÒå");
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
			name = "ÑÌÓêÆ½Éú<ìø>";
			nativename = "ÑÌÓêÆ½Éú<ìø>";
			icon = "ÑÌÓêÆ½Éúìø.dds";
			SetTalent(0,6493);
			SetTalent(1,6466);
			SetTalent(2,6508);
			SetTalent(3,2947);
			SetTalent(4,4112);
			SetTalent(5,4530);
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
			skill_class = 16;
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
			return 118000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 8.500000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 531.000000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={6541};return array[index];
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
	}
	public class GSkill6652 : GSkill
	{
		public GSkill6652()
			: base(6652)
		{
			
		}
	}
	public class GSkill6653Stub : GSkillStub
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
		public GSkill6653Stub()
			: base(6653)
		{
			occupation = 128;
			maxlevel = 7;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
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
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"0");
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
			name = "¹éÔÆ-Ï·µûÍØÖ¦-1";
			nativename = "¹éÔÆ-Ï·µûÍØÖ¦-1";
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
			return 1700;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={1};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetAngle(GSkill skill)
		{
			return 0.333334f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 8.000000f;
		}
	}
	public class GSkill6653 : GSkill
	{
		public GSkill6653()
			: base(6653)
		{
			
		}
	}
	public class GSkill6654Stub : GSkillStub
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
		public GSkill6654Stub()
			: base(6654)
		{
			occupation = 130;
			maxlevel = 5;
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
			SetAction(0,"¹éÔÆ_É¡»÷ÍË");
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
			SetAction(16,"0");
			SetAction(17,"¹éÔÆ_É¡»÷ÍË");
			SetAction(18,"¹éÔÆ_Æï³Ë_É¡»÷ÍË");
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
			name = "Ñ©ö«»ªÃ÷";
			nativename = "Ñ©ö«»ªÃ÷";
			icon = "Ñ©ö«»ªÃ÷.dds";
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
			return 6000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.050000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 0.050000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 10.050000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 60.000000f;
		}
	}
	public class GSkill6654 : GSkill
	{
		public GSkill6654()
			: base(6654)
		{
			
		}
	}
	public class GSkill6655Stub : GSkillStub
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
		public GSkill6655Stub()
			: base(6655)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
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
			SetAction(0,"¹éÔÆ_É¡»÷ÍË");
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
			SetAction(16,"0");
			SetAction(17,"¹éÔÆ_É¡»÷ÍË");
			SetAction(18,"¹éÔÆ_Æï³Ë_É¡»÷ÍË");
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
			name = "Õæ¡¤Ñ©ö«»ªÃ÷";
			nativename = "Õæ¡¤Ñ©ö«»ªÃ÷";
			icon = "Ñ©ö«»ªÃ÷·ÉÉý.dds";
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
			return 6000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.050000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 0.050000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 10.050000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 409.000000f;
		}
	}
	public class GSkill6655 : GSkill
	{
		public GSkill6655()
			: base(6655)
		{
			
		}
	}
	public class GSkill6656Stub : GSkillStub
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
		public GSkill6656Stub()
			: base(6656)
		{
			occupation = 130;
			maxlevel = 5;
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
			SetAction(0,"¹éÔÆ_É¡»÷ÍË");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
			SetAction(2,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
			SetAction(3,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
			SetAction(4,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
			SetAction(5,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
			SetAction(6,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
			SetAction(7,"ÊÞÉñ_·¨±¦_Å­ÊÞá¦");
			SetAction(8,"ºüÑý_·¨±¦_µ¤Öì");
			SetAction(9,"ÐùÔ¯_·¨±¦_ÂÊ¶µÆì");
			SetAction(10,"»³¹â_·¨±¦_ÆßÉ±");
			SetAction(11,"Ì«ê»_·¨±¦_À×¹«Ä«");
			SetAction(12,"Ìì»ª_·¨±¦_¾ÅÒôÂÝ");
			SetAction(13,"Ì«ê»_·¨±¦_À×¹«Ä«");
			SetAction(14,"Ì«ê»_·¨±¦_À×¹«Ä«");
			SetAction(15,"Ì«ê»_·¨±¦_À×¹«Ä«");
			SetAction(16,"Ì«ê»_·¨±¦_À×¹«Ä«");
			SetAction(17,"¹éÔÆ_É¡»÷ÍË");
			SetAction(18,"¹éÔÆ_Æï³Ë_É¡»÷ÍË");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(24,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_Å­ÊÞá¦");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_µ¤Öì");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_ÂÊ¶µÆì");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÆßÉ±");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_À×¹«Ä«");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_¾ÅÒôÂÝ");
			name = "³Ð¡¤Ñ©ö«»ªÃ÷";
			nativename = "³Ð¡¤Ñ©ö«»ªÃ÷";
			icon = "Ñ©ö«»ªÃ÷.dds";
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
			return 6000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.050000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 0.050000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 10.050000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 60.000000f;
		}
	}
	public class GSkill6656 : GSkill
	{
		public GSkill6656()
			: base(6656)
		{
			
		}
	}
	public class GSkill6657Stub : GSkillStub
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
		public GSkill6657Stub()
			: base(6657)
		{
			occupation = 130;
			maxlevel = 5;
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
			SetAction(0,"¹éÔÆ_É¡Ñ¸»÷");
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
			SetAction(16,"0");
			SetAction(17,"¹éÔÆ_É¡Ñ¸»÷");
			SetAction(18,"¹éÔÆ_Æï³Ë_É¡Ñ¸»÷");
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
			name = "Ñþ¹âÍûÇç";
			nativename = "Ñþ¹âÍûÇç";
			icon = "Ñþ¹âÍûÇç.dds";
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
			return 6000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.050000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 0.050000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 10.050000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 179.000000f;
		}
	}
	public class GSkill6657 : GSkill
	{
		public GSkill6657()
			: base(6657)
		{
			
		}
	}
	public class GSkill6658Stub : GSkillStub
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
		public GSkill6658Stub()
			: base(6658)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
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
			SetAction(0,"¹éÔÆ_É¡Ñ¸»÷");
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
			SetAction(16,"0");
			SetAction(17,"¹éÔÆ_É¡Ñ¸»÷");
			SetAction(18,"¹éÔÆ_Æï³Ë_É¡Ñ¸»÷");
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
			name = "Õæ¡¤Ñþ¹âÍûÇç";
			nativename = "Õæ¡¤Ñþ¹âÍûÇç";
			icon = "Ñþ¹âÍûÇç·ÉÉý.dds";
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
			return 6000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.050000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 0.050000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 10.050000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 409.000000f;
		}
	}
	public class GSkill6658 : GSkill
	{
		public GSkill6658()
			: base(6658)
		{
			
		}
	}
	public class GSkill6659Stub : GSkillStub
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
		public GSkill6659Stub()
			: base(6659)
		{
			occupation = 130;
			maxlevel = 5;
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
			SetAction(0,"¹éÔÆ_É¡Ñ¸»÷");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ÆßÐÇ½£");
			SetAction(2,"ÇàÔÆÃÅ_·¨±¦_ÆßÐÇ½£");
			SetAction(3,"ÇàÔÆÃÅ_·¨±¦_ÆßÐÇ½£");
			SetAction(4,"ÇàÔÆÃÅ_·¨±¦_ÆßÐÇ½£");
			SetAction(5,"ÇàÔÆÃÅ_·¨±¦_ÆßÐÇ½£");
			SetAction(6,"ÇàÔÆÃÅ_·¨±¦_ÆßÐÇ½£");
			SetAction(7,"ÊÞÉñ_·¨±¦_Ñª·ãÇ¹");
			SetAction(8,"ºüÑý_·¨±¦_·µ»êÏã");
			SetAction(9,"ÐùÔ¯_·¨±¦_ÄõÁú¹Ä");
			SetAction(10,"»³¹â_·¨±¦_ÆÆ¾ü");
			SetAction(11,"Ì«ê»_·¨±¦_´ºÇïËø");
			SetAction(12,"Ìì»ª_·¨±¦_ÑÇ·ç");
			SetAction(13,"ÊÞÉñ_·¨±¦_Ñª·ãÇ¹");
			SetAction(14,"ÊÞÉñ_·¨±¦_Ñª·ãÇ¹");
			SetAction(15,"ÊÞÉñ_·¨±¦_Ñª·ãÇ¹");
			SetAction(16,"ÊÞÉñ_·¨±¦_Ñª·ãÇ¹");
			SetAction(17,"¹éÔÆ_É¡Ñ¸»÷");
			SetAction(18,"¹éÔÆ_Æï³Ë_É¡Ñ¸»÷");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÆßÐÇ½£");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÆßÐÇ½£");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÆßÐÇ½£");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÆßÐÇ½£");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÆßÐÇ½£");
			SetAction(24,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÆßÐÇ½£");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_Ñª·ãÇ¹");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_·µ»êÏã");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_ÄõÁú¹Ä");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÆÆ¾ü");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_´ºÇïËø");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÑÇ·ç");
			name = "³Ð¡¤Ñþ¹âÍûÇç";
			nativename = "³Ð¡¤Ñþ¹âÍûÇç";
			icon = "Ñþ¹âÍûÇç.dds";
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
			return 6000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.050000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 0.050000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 10.050000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 179.000000f;
		}
	}
	public class GSkill6659 : GSkill
	{
		public GSkill6659()
			: base(6659)
		{
			
		}
	}
}
