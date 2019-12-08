using System;
using System.Text;
using System.Runtime.CompilerServices;

namespace SKILL
{
    /// <summary>
    /// 技能功能接口
    /// </summary>
    public class GPlayerWrapper
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetRes1(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetRes2(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetRes3(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetRes4(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetRes5(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetRes6(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetVar1(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetVar2(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetVar3(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetVar4(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetVar5(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetVar6(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetVar7(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetVar8(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetVar9(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetVar10(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetVar11(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetVar12(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetVar13(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetVar14(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetVar15(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetVar16(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetVar1(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetVar2(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetVar3(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetVar4(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetVar5(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetVar6(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetVar7(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetVar8(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetVar9(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetVar10(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetVar11(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetVar12(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetVar13(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetVar14(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetVar15(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetVar16(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetInk(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetRage(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetGender(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetOccupation(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetObjectType(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetRace(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetLevel(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetSglevel(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMaxatk(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMinatk(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetDef(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetHide(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetTmplid(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetAtkrate(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetDodge(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetSkillrate(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetSkilldodge(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetCrit(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetCrithurt(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetSpeed(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetDarklight(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetDarklightform(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetHp(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMp(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetDp(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMaxHp(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMaxMp(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMaxDp(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetRange(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetSaint(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetReborncount(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetCyclemembercnt(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetCultivation(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetSkilllevel(IntPtr p, int id);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetBufflevel(IntPtr p, int id);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetHasbuff(IntPtr p, int id);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetHasmultbuff(IntPtr p, int id);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetBuffcnt(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetDebuffcnt(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHp(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetMp(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPray(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPerform(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetProbability(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetRage(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetDarklight(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetTime(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBuffid(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetRatio(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetValue(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAmount(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHeal(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetResurrect(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDecmp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetInchp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetInchp2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIncmp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddhp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddhp2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddmp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHpgen(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBarhpgen(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetMpgen(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBarmpgen(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetInchpgen(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIncmpgen(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDizzy(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSleep(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetWeak(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSilent(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetWrap(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSlow(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSlow2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddantidizzy(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddantisleep(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddantiweak(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddantisilent(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddantiwrap(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddantislow(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubantidizzy(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubantisleep(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubantiweak(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubantisilent(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubantiwrap(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubantislow(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCleardizzy(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetClearsleep(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetClearweak(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetClearsilent(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetClearwrap(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetClearslow(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddattack(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddattack2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddattack3(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddattack4(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAdddefence(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIncattack(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIncattack2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIncattack3(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIncdefence(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIncdefence2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDecattack(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAdddodge(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAdddodge2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCrazy(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAssault(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetMagicshield(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDechurt(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetInvincible(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBreak(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetGohome(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddspeed(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBarehanded(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDodge(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetInccritrate(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetScaleinchp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetScaleincmp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetScaledecmp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetScaledechp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHpleak(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetMpleak(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFrenetic(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddattack(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasincattack(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasadddefence(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasincefence(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddhp(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasinchp(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddmp(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddaccuracy(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasadddodge(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddsilent(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddweak(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasadddizzy(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddsleep(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddslow(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddwrap(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddsilenttenaciy(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddweaktenaciy(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasadddizzytenaciy(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddsleeptenaciy(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddslowtenaciy(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddwraptenaciy(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddsilentproficiency(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddweakproficiency(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasadddizzyproficiency(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddsleepproficiency(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddslowproficiency(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddwrapproficiency(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasinchpgen(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasincmpgen(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetRepel(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetOverawe(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubdefence(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDecdefence(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDecdamage(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBloodshield(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetImmunedizzy(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetImmunesleep(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetImmunesilent(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetImmuneweak(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetImmunewrap(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetImmuneslow(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDrainmagic(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddsmite(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCursed(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDiet(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSalvation(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBlessed(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPowerup(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetInchurt(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetInchurt2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetRandcurse(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetClearcooldown(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSecondattack(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetShouyi(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetNingjin(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIncanti(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDecanti(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddanti(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddanti2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubanti(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIncskilldamage(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDecskilldamage(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetClearbuff(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCleardebuff(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetRetort(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetInccrithurt(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddanti(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasinccrit(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetTiansha(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetJuqi(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetXiaoxin(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetUniqprompt(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDrunk(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSpicy(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetGloss(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetExorcism(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubhp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubmp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubattack(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFamilyincattack(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFamilyinchp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFamilyincmp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasincmp(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCycsubdefence(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCycsubattack(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCycdecdefence(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCycdecattack(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDeccritrate(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDeccrithurt(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDecdodge(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFrenzied(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasincantidizzy(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasincantiweak(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasincantisilent(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasincantiwrap(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasincantisleep(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasincantislow(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasincanti(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHolyaura(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetEvilaura(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDie(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIceshield(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFocusanti(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDisperseanti(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDecaccuracy(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIncheal(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAttack2hp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAttack2mp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPowerless(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAloof(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBleeding(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDirecthurt(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDirectattack(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDizzytimer(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetWraptimer(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSilenttimer(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSleeptimer(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetMagicdoor(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHpleak1(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHpleak2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHpleak3(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHpleak4(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHpleak5(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHpleak6(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetMpdisperse(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetGhostform(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetInsanityform(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCreateitem(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetJumptospouse(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetYanyu(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDodgeregain(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHpregain(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDeadlybless(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHurtscatter(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDeathscatter(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetRejectdebuff(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIncskillaccu(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDecskillaccu(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIncskilldodge(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDecskilldodge(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIncfatalratio(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDecfatalratio(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIncfatalhurt(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDecfatalhurt(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSetcooldown(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasincskillaccu(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasdecfatalratio(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasdecfatalhurt(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasincskilldodge(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPassubhurt(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasdechurt(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasdecpethurt(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasdechurt1(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasdechurt2(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasdechurt3(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasdechurt4(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasdechurt5(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasdechurt6(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetExpboost(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBarexpboost(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCreditboost(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasincpetdamage(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAdddebuff(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetZhaoqi(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFashen(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCibei(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetTiangu(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBanruo(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetXinmo(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAoshi(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHupo(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetGuilin(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetTongxin(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetUpdatecommondata(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSetcommondata(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBaradddogeaccu(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDiscover(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCatchpet(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetViphupo(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetVipguilin(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSummon(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetExtracthp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetExtractmp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFear(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetLongxiang(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHuju(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDouhun(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetGangdan(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAswind(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAsforest(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAsfire(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAshill(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetMakecrit(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBackorigin(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFoxstate(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetChihun(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDispel(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetTransform(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCleartransform(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetImmunetransform(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasaddtransform(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasincantitransform(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddantitransform(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubantitransform(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDimming(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetShadowhide(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetShadowdance(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPosexchangewithclone(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetStateexchangewithclone(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDrawclonelife(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSharelifewithclone(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSharestatewithclone(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBackstab(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCritcurse(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIncdrugeffect(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDecdrugeffect(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSkillmirror(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAbsulotearea(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSummonclone(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetUnsummon(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetUnsummonclone(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddspot(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubSpot(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddhide(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubhide(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBreakcasting(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCrazycurse(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFogstate(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetMiracleburstxian(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetMiracleburstfo(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetMiracleburstmo(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDarkness(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIgnite(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSkillreflect(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDivinityburst(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDivinityfury(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetColdinjure(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFrozen(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetGoback(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetScopedamage(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPullback(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDamagemove(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHumanbomb(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasdecrestrainxian(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasdecrestrainmo(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasdecrestrainfo(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPasincdpgen(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSpiritdrag(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFiring(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBefired(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCreateobject(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddweak(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddwrap(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddcharm(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddslow(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddcommon(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDelaycast(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetTurnbuff(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetTurndebuff(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetParalysis(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSwift(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetTriggerskill(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetActiveonfilteradd(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetActivecrit(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetActivebecrit(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCrippled(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetGuishen1(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetTuoling1(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetGuishen2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetTuoling2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBepulled(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPulling(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBloodthirsty(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCycle(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIncskilllevel(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSetskilllevel(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIncmountspeed(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPermitcyclearea(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetLimitcyclearea(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetJail(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetJailpermitcyclearea(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetJaillimitcyclearea(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetYuanling(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetGuishen1debuff(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetTuoling1debuff(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetGuishen2debuff(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetTuoling2debuff(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCrippleddebuff(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPzmaxspeed(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPzhalfspeed(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPzhill(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPznomove(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPzchaos(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPzvoid(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetJuniordarkform(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetJuniorlightform(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSeniordarkform(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSeniorlightform(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDarkuniform(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetLightuniform(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDechurt2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetRecordpos(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetReturnpos(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFly(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetActivebeattacked(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetMirrorimage(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetInstantskill(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSummonskill(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBloodthirsty2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetTalismaneffects(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetTalismaneffectsbless(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDarklaser(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAutorescurrect(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddspirit(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDirstate(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetTeamenchant(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetGthpgen(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetGtmpgen(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetGtaddattackdefense(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetShowyb(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetRecoverhp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetEquipeffect(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSummonmachine(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSummontrap(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSummoncontroltrap(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSummonteleport1(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSummonteleport2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCurseteleport(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSpytrap(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSpeedto(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPossummon(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPuppetform(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPuppetskill(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBounceto(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDrawto(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubantidizzy2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubantisleep2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubantiweak2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubantisilent2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubantiwrap2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubantislow2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubhp2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSubmp2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSeed(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetQilinform(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetRmhumanform(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCycleskill(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBuxiu(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetRepel2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBlowoff(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAssault2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetThrowback(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddrage1(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddrage2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetRenma1(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetRenma2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetRenma3(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetRenma4(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSharelifewithsummon(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetReduceskillcd(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAccumdamage(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetBloodpool(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDsleep(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFinder(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHider(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetKillmonster(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddmonsterexp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetHumanbomb2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetTrad(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetStruggle(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetParry(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDisguise(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSign(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetMagicdance(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAtkchangetarget(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAtkchangetarget2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPojun1(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPojun2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSkilltransfer(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetGroupatkchange(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSingleatkchange(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetClearkillnum(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSmog(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetClearimmune(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetWhenkillasself(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetWhenkillastarget(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIgnoreblessed(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetImmunetaune(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetParry2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetImmunelakemp(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSupertrigger(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddseed(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDeathpact(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetScudblessing(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDeriveattribution(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDerivedef(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFenggong(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIcecurse(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFlamecurse(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetIceblessing(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFlameblessing(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetTorpescence(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSacrifice(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetQingluo1(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetQingluo2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetGuhuo(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetFear2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSuspend(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDisarrange(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetImitate(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSoullink(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSkillreplace(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSharedamage(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetClrsoullink(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAddproficiency(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDechurt3(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetPromotedps(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetActivebecrit2(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDpleak(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetRagegen(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetAbolishbloodpool(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetImmunemanaburn(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetSummonnpc(IntPtr p, bool v);
        private IntPtr nativePtr = new IntPtr();
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="p">接口对象指针</param>
        public GPlayerWrapper(IntPtr p)
        {
            this.nativePtr = p;
        }
        public int GetRes1()
        {
            return GetRes1(nativePtr);
        }
        public int GetRes2()
        {
            return GetRes2(nativePtr);
        }
        public int GetRes3()
        {
            return GetRes3(nativePtr);
        }
        public int GetRes4()
        {
            return GetRes4(nativePtr);
        }
        public int GetRes5()
        {
            return GetRes5(nativePtr);
        }
        public int GetRes6()
        {
            return GetRes6(nativePtr);
        }
        /// <summary>
        /// 取得变量值（用于技能处理临时使用）
        /// </summary>
        /// <returns>变量值</returns>
        public int GetVar1()
        {
            return GetVar1(nativePtr);
        }
        /// <summary>
        /// 取得变量值（用于技能处理临时使用）
        /// </summary>
        /// <returns>变量值</returns>
        public int GetVar2()
        {
            return GetVar2(nativePtr);
        }
        /// <summary>
        /// 取得变量值（用于技能处理临时使用）
        /// </summary>
        /// <returns>变量值</returns>
        public int GetVar3()
        {
            return GetVar3(nativePtr);
        }
        /// <summary>
        /// 取得变量值（用于技能处理临时使用）
        /// </summary>
        /// <returns>变量值</returns>
        public int GetVar4()
        {
            return GetVar4(nativePtr);
        }
        /// <summary>
        /// 取得变量值（用于技能处理临时使用）
        /// </summary>
        /// <returns>变量值</returns>
        public int GetVar5()
        {
            return GetVar5(nativePtr);
        }
        /// <summary>
        /// 取得变量值（用于技能处理临时使用）
        /// </summary>
        /// <returns>变量值</returns>
        public int GetVar6()
        {
            return GetVar6(nativePtr);
        }
        /// <summary>
        /// 取得变量值（用于技能处理临时使用）
        /// </summary>
        /// <returns>变量值</returns>
        public int GetVar7()
        {
            return GetVar7(nativePtr);
        }
        /// <summary>
        /// 取得变量值（用于技能处理临时使用）
        /// </summary>
        /// <returns>变量值</returns>
        public int GetVar8()
        {
            return GetVar8(nativePtr);
        }
        /// <summary>
        /// 取得变量值（用于技能处理临时使用）
        /// </summary>
        /// <returns>变量值</returns>
        public int GetVar9()
        {
            return GetVar9(nativePtr);
        }
        /// <summary>
        /// 取得变量值（用于技能处理临时使用）
        /// </summary>
        /// <returns>变量值</returns>
        public int GetVar10()
        {
            return GetVar10(nativePtr);
        }
        /// <summary>
        /// 取得变量值（用于技能处理临时使用）
        /// </summary>
        /// <returns>变量值</returns>
        public int GetVar11()
        {
            return GetVar11(nativePtr);
        }
        /// <summary>
        /// 取得变量值（用于技能处理临时使用）
        /// </summary>
        /// <returns>变量值</returns>
        public int GetVar12()
        {
            return GetVar12(nativePtr);
        }
        /// <summary>
        /// 取得变量值（用于技能处理临时使用）
        /// </summary>
        /// <returns>变量值</returns>
        public int GetVar13()
        {
            return GetVar13(nativePtr);
        }
        /// <summary>
        /// 取得变量值（用于技能处理临时使用）
        /// </summary>
        /// <returns>变量值</returns>
        public int GetVar14()
        {
            return GetVar14(nativePtr);
        }
        /// <summary>
        /// 取得变量值（用于技能处理临时使用）
        /// </summary>
        /// <returns>变量值</returns>
        public int GetVar15()
        {
            return GetVar15(nativePtr);
        }
        /// <summary>
        /// 取得变量值（用于技能处理临时使用）
        /// </summary>
        /// <returns>变量值</returns>
        public int GetVar16()
        {
            return GetVar16(nativePtr);
        }
        /// <summary>
        /// 设置变量值（用于技能处理临时使用）
        /// </summary>
        /// <param name="v">变量值</param>
        public void SetVar1(int v)
        {
            SetVar1(nativePtr, v);
        }
        /// <summary>
        /// 设置变量值（用于技能处理临时使用）
        /// </summary>
        /// <param name="v">变量值</param>
        public void SetVar2(int v)
        {
            SetVar2(nativePtr, v);
        }
        /// <summary>
        /// 设置变量值（用于技能处理临时使用）
        /// </summary>
        /// <param name="v">变量值</param>
        public void SetVar3(int v)
        {
            SetVar3(nativePtr, v);
        }
        /// <summary>
        /// 设置变量值（用于技能处理临时使用）
        /// </summary>
        /// <param name="v">变量值</param>
        public void SetVar4(int v)
        {
            SetVar4(nativePtr, v);
        }
        /// <summary>
        /// 设置变量值（用于技能处理临时使用）
        /// </summary>
        /// <param name="v">变量值</param>
        public void SetVar5(int v)
        {
            SetVar5(nativePtr, v);
        }
        /// <summary>
        /// 设置变量值（用于技能处理临时使用）
        /// </summary>
        /// <param name="v">变量值</param>
        public void SetVar6(int v)
        {
            SetVar6(nativePtr, v);
        }
        /// <summary>
        /// 设置变量值（用于技能处理临时使用）
        /// </summary>
        /// <param name="v">变量值</param>
        public void SetVar7(int v)
        {
            SetVar7(nativePtr, v);
        }
        /// <summary>
        /// 设置变量值（用于技能处理临时使用）
        /// </summary>
        /// <param name="v">变量值</param>
        public void SetVar8(int v)
        {
            SetVar8(nativePtr, v);
        }
        /// <summary>
        /// 设置变量值（用于技能处理临时使用）
        /// </summary>
        /// <param name="v">变量值</param>
        public void SetVar9(int v)
        {
            SetVar9(nativePtr, v);
        }
        /// <summary>
        /// 设置变量值（用于技能处理临时使用）
        /// </summary>
        /// <param name="v">变量值</param>
        public void SetVar10(int v)
        {
            SetVar10(nativePtr, v);
        }
        /// <summary>
        /// 设置变量值（用于技能处理临时使用）
        /// </summary>
        /// <param name="v">变量值</param>
        public void SetVar11(int v)
        {
            SetVar11(nativePtr, v);
        }
        /// <summary>
        /// 设置变量值（用于技能处理临时使用）
        /// </summary>
        /// <param name="v">变量值</param>
        public void SetVar12(int v)
        {
            SetVar12(nativePtr, v);
        }
        /// <summary>
        /// 设置变量值（用于技能处理临时使用）
        /// </summary>
        /// <param name="v">变量值</param>
        public void SetVar13(int v)
        {
            SetVar13(nativePtr, v);
        }
        /// <summary>
        /// 设置变量值（用于技能处理临时使用）
        /// </summary>
        /// <param name="v">变量值</param>
        public void SetVar14(int v)
        {
            SetVar14(nativePtr, v);
        }
        /// <summary>
        /// 设置变量值（用于技能处理临时使用）
        /// </summary>
        /// <param name="v">变量值</param>
        public void SetVar15(int v)
        {
            SetVar15(nativePtr, v);
        }
        /// <summary>
        /// 设置变量值（用于技能处理临时使用）
        /// </summary>
        /// <param name="v">变量值</param>
        public void SetVar16(int v)
        {
            SetVar16(nativePtr, v);
        }
        public int GetInk()
        {
            return GetInk(nativePtr);
        }
        public int GetRage()
        {
            return GetRage(nativePtr);
        }
        /// <summary>
        /// 取得性别
        /// </summary>
        /// <returns></returns>
        public int GetGender()
        {
            return GetGender(nativePtr);
        }
        /// <summary>
        /// 取得职业
        /// </summary>
        /// <returns></returns>
        public int GetOccupation()
        {
            return GetOccupation(nativePtr);
        }
        /// <summary>
        /// 取得类型
        /// </summary>
        /// <returns></returns>
        public int GetObjectType()
        {
            return GetObjectType(nativePtr);
        }
        /// <summary>
        /// 取得种族
        /// </summary>
        /// <returns></returns>
        public int GetRace()
        {
            return GetRace(nativePtr);
        }
        /// <summary>
        /// 取得等级
        /// </summary>
        /// <returns></returns>
        public int GetLevel()
        {
            return GetLevel(nativePtr);
        }
        public int GetSglevel()
        {
            return GetSglevel(nativePtr);
        }
        public int GetMaxatk()
        {
            return GetMaxatk(nativePtr);
        }
        public int GetMinatk()
        {
            return GetMinatk(nativePtr);
        }
        public int GetDef()
        {
            return GetDef(nativePtr);
        }
        public int GetHide()
        {
            return GetHide(nativePtr);
        }
        public int GetTmplid()
        {
            return GetTmplid(nativePtr);
        }
        public int GetAtkrate()
        {
            return GetAtkrate(nativePtr);
        }
        public int GetDodge()
        {
            return GetDodge(nativePtr);
        }
        public int GetSkillrate()
        {
            return GetSkillrate(nativePtr);
        }
        public int GetSkilldodge()
        {
            return GetSkilldodge(nativePtr);
        }
        public int GetCrit()
        {
            return GetCrit(nativePtr);
        }
        public float GetCrithurt()
        {
            return GetCrithurt(nativePtr);
        }
        /// <summary>
        /// 取得当前速度
        /// </summary>
        /// <returns></returns>
        public float GetSpeed()
        {
            return GetSpeed(nativePtr);
        }
        public int GetDarklight()
        {
            return GetDarklight(nativePtr);
        }
        public int GetDarklightform()
        {
            return GetDarklightform(nativePtr);
        }
		public int GetHp()
        {
            return GetHp(nativePtr);
        }
		public int GetMp()
        {
            return GetMp(nativePtr);
        }
		public int GetDp()
        {
            return GetDp(nativePtr);
        }
        public int GetMaxhp()
        {
            return GetMaxHp(nativePtr);
        }
        public int GetMaxmp()
        {
            return GetMaxMp(nativePtr);
        }
        public int GetMaxdp()
        {
            return GetMaxDp(nativePtr);
        }
        public float GetRange()
        {
            return GetRange(nativePtr);
        }
        public float GetSaint()
        {
            return GetSaint(nativePtr);
        }
        /// <summary>
        /// 取得飞升次数
        /// </summary>
        /// <returns></returns>
        public int GetReborncount()
        {
            return GetReborncount(nativePtr);
        }
        public int GetCyclemembercnt()
        {
            return GetCyclemembercnt(nativePtr);
        }
        public int GetCultivation()
        {
            return GetCultivation(nativePtr);
        }
        /// <summary>
        /// 取得技能等级
        /// </summary>
        /// <param name="id">技能标识</param>
        /// <returns></returns>
        public int GetSkilllevel(int id)
        {
            return GetSkilllevel(nativePtr, id);
        }
        public int GetBufflevel(int id)
        {
            return GetBufflevel(nativePtr, id);
        }
        public int GetHasbuff(int id)
        {
            return GetHasbuff(nativePtr, id);
        }
        public int GetHasmultbuff(int id)
        {
            return GetHasmultbuff(nativePtr, id);
        }
        public int GetBuffcnt()
        {
            return GetBuffcnt(nativePtr);
        }
        public int GetDebuffcnt()
        {
            return GetDebuffcnt(nativePtr);
        }
		public bool SetHp(float v)
        {
            return SetHp(nativePtr, v);
        }
		public bool SetMp(float v)
        {
            return SetMp(nativePtr, v);
        }
        public bool SetPray(int v)
        {
            return SetPray(nativePtr, v);
        }
        public bool SetPerform(int v)
        {
            return SetPerform(nativePtr, v);
        }
        /// <summary>
        /// 设置功能机率
        /// </summary>
        /// <param name="v"></param>
        public void SetProbability(float v)
        {
            SetProbability(nativePtr, v);
        }
        public void SetRage(int v)
        {
            SetRage(nativePtr, v);
        }
        public void SetDarklight(int v)
        {
            SetDarklight(nativePtr, v);
        }
        /// <summary>
        /// 设置功能时间
        /// </summary>
        /// <param name="v">时间</param>
        /// <returns></returns>
        public bool SetTime(float v)
        {
            return SetTime(nativePtr, v);
        }
        public bool SetBuffid(int v)
        {
            return SetBuffid(nativePtr, v);
        }
        public bool SetRatio(float v)
        {
            return SetRatio(nativePtr, v);
        }
        public bool SetValue(float v)
        {
            return SetValue(nativePtr, v);
        }
        public bool SetAmount(float v)
        {
            return SetAmount(nativePtr, v);
        }
        public bool SetHeal(bool v)
        {
            return SetHeal(nativePtr, v);
        }
        public bool SetResurrect(bool v)
        {
            return SetResurrect(nativePtr, v);
        }
        public bool SetDecmp(bool v)
        {
            return SetDecmp(nativePtr, v);
        }
        public bool SetInchp(bool v)
        {
            return SetInchp(nativePtr, v);
        }
        public bool SetInchp2(bool v)
        {
            return SetInchp2(nativePtr, v);
        }
        public bool SetIncmp(bool v)
        {
            return SetIncmp(nativePtr, v);
        }
        public bool SetAddhp(bool v)
        {
            return SetAddhp(nativePtr, v);
        }
        public bool SetAddhp2(bool v)
        {
            return SetAddhp2(nativePtr, v);
        }
        public bool SetAddmp(bool v)
        {
            return SetAddmp(nativePtr, v);
        }
        public bool SetHpgen(bool v)
        {
            return SetHpgen(nativePtr, v);
        }
        public bool SetBarhpgen(bool v)
        {
            return SetBarhpgen(nativePtr, v);
        }
        public bool SetMpgen(bool v)
        {
            return SetMpgen(nativePtr, v);
        }
        public bool SetBarmpgen(bool v)
        {
            return SetBarmpgen(nativePtr, v);
        }
        public bool SetInchpgen(bool v)
        {
            return SetInchpgen(nativePtr, v);
        }
        public bool SetIncmpgen(bool v)
        {
            return SetIncmpgen(nativePtr, v);
        }
        public bool SetDizzy(bool v)
        {
            return SetDizzy(nativePtr, v);
        }
        public bool SetSleep(bool v)
        {
            return SetSleep(nativePtr, v);
        }
        public bool SetWeak(bool v)
        {
            return SetWeak(nativePtr, v);
        }
        public bool SetSilent(bool v)
        {
            return SetSilent(nativePtr, v);
        }
        public bool SetWrap(bool v)
        {
            return SetWrap(nativePtr, v);
        }
        public bool SetSlow(bool v)
        {
            return SetSlow(nativePtr, v);
        }
        public bool SetSlow2(bool v)
        {
            return SetSlow2(nativePtr, v);
        }
        public bool SetAddantidizzy(bool v)
        {
            return SetAddantidizzy(nativePtr, v);
        }
        public bool SetAddantisleep(bool v)
        {
            return SetAddantisleep(nativePtr, v);
        }
        public bool SetAddantiweak(bool v)
        {
            return SetAddantiweak(nativePtr, v);
        }
        public bool SetAddantisilent(bool v)
        {
            return SetAddantisilent(nativePtr, v);
        }
        public bool SetAddantiwrap(bool v)
        {
            return SetAddantiwrap(nativePtr, v);
        }
        public bool SetAddantislow(bool v)
        {
            return SetAddantislow(nativePtr, v);
        }
        public bool SetSubantidizzy(bool v)
        {
            return SetSubantidizzy(nativePtr, v);
        }
        public bool SetSubantisleep(bool v)
        {
            return SetSubantisleep(nativePtr, v);
        }
        public bool SetSubantiweak(bool v)
        {
            return SetSubantiweak(nativePtr, v);
        }
        public bool SetSubantisilent(bool v)
        {
            return SetSubantisilent(nativePtr, v);
        }
        public bool SetSubantiwrap(bool v)
        {
            return SetSubantiwrap(nativePtr, v);
        }
        public bool SetSubantislow(bool v)
        {
            return SetSubantislow(nativePtr, v);
        }
        public bool SetCleardizzy(bool v)
        {
            return SetCleardizzy(nativePtr, v);
        }
        public bool SetClearsleep(bool v)
        {
            return SetClearsleep(nativePtr, v);
        }
        public bool SetClearweak(bool v)
        {
            return SetClearweak(nativePtr, v);
        }
        public bool SetClearsilent(bool v)
        {
            return SetClearsilent(nativePtr, v);
        }
        public bool SetClearwrap(bool v)
        {
            return SetClearwrap(nativePtr, v);
        }
        public bool SetClearslow(bool v)
        {
            return SetClearslow(nativePtr, v);
        }
        public bool SetAddattack(bool v)
        {
            return SetAddattack(nativePtr, v);
        }
        public bool SetAddattack2(bool v)
        {
            return SetAddattack2(nativePtr, v);
        }
        public bool SetAddattack3(bool v)
        {
            return SetAddattack3(nativePtr, v);
        }
        public bool SetAddattack4(bool v)
        {
            return SetAddattack4(nativePtr, v);
        }
        public bool SetAdddefence(bool v)
        {
            return SetAdddefence(nativePtr, v);
        }
        public bool SetIncattack(bool v)
        {
            return SetIncattack(nativePtr, v);
        }
        public bool SetIncattack2(bool v)
        {
            return SetIncattack2(nativePtr, v);
        }
        public bool SetIncattack3(bool v)
        {
            return SetIncattack3(nativePtr, v);
        }
        public bool SetIncdefence(bool v)
        {
            return SetIncdefence(nativePtr, v);
        }
        public bool SetIncdefence2(bool v)
        {
            return SetIncdefence2(nativePtr, v);
        }
        public bool SetDecattack(bool v)
        {
            return SetDecattack(nativePtr, v);
        }
        public bool SetAdddodge(bool v)
        {
            return SetAdddodge(nativePtr, v);
        }
        public bool SetAdddodge2(bool v)
        {
            return SetAdddodge2(nativePtr, v);
        }
        public bool SetCrazy(bool v)
        {
            return SetCrazy(nativePtr, v);
        }
        public bool SetAssault(bool v)
        {
            return SetAssault(nativePtr, v);
        }
        public bool SetMagicshield(bool v)
        {
            return SetMagicshield(nativePtr, v);
        }
        public bool SetDechurt(bool v)
        {
            return SetDechurt(nativePtr, v);
        }
        public bool SetInvincible(bool v)
        {
            return SetInvincible(nativePtr, v);
        }
        public bool SetBreak(bool v)
        {
            return SetBreak(nativePtr, v);
        }
        public bool SetGohome(bool v)
        {
            return SetGohome(nativePtr, v);
        }
        public bool SetAddspeed(bool v)
        {
            return SetAddspeed(nativePtr, v);
        }
        public bool SetBarehanded(bool v)
        {
            return SetBarehanded(nativePtr, v);
        }
        public bool SetDodge(bool v)
        {
            return SetDodge(nativePtr, v);
        }
        public bool SetInccritrate(bool v)
        {
            return SetInccritrate(nativePtr, v);
        }
        public bool SetScaleinchp(bool v)
        {
            return SetScaleinchp(nativePtr, v);
        }
        public bool SetScaleincmp(bool v)
        {
            return SetScaleincmp(nativePtr, v);
        }
        public bool SetScaledecmp(bool v)
        {
            return SetScaledecmp(nativePtr, v);
        }
        public bool SetScaledechp(bool v)
        {
            return SetScaledechp(nativePtr, v);
        }
        public bool SetHpleak(bool v)
        {
            return SetHpleak(nativePtr, v);
        }
        public bool SetMpleak(bool v)
        {
            return SetMpleak(nativePtr, v);
        }
        public bool SetFrenetic(bool v)
        {
            return SetFrenetic(nativePtr, v);
        }
        public bool SetPasaddattack(float v)
        {
            return SetPasaddattack(nativePtr, v);
        }
        public bool SetPasincattack(float v)
        {
            return SetPasincattack(nativePtr, v);
        }
        public bool SetPasadddefence(float v)
        {
            return SetPasadddefence(nativePtr, v);
        }
        public bool SetPasincefence(float v)
        {
            return SetPasincefence(nativePtr, v);
        }
        public bool SetPasaddhp(float v)
        {
            return SetPasaddhp(nativePtr, v);
        }
        public bool SetPasinchp(float v)
        {
            return SetPasinchp(nativePtr, v);
        }
        public bool SetPasaddmp(float v)
        {
            return SetPasaddmp(nativePtr, v);
        }
        public bool SetPasaddaccuracy(float v)
        {
            return SetPasaddaccuracy(nativePtr, v);
        }
        public bool SetPasadddodge(float v)
        {
            return SetPasadddodge(nativePtr, v);
        }
        public bool SetPasaddsilent(float v)
        {
            return SetPasaddsilent(nativePtr, v);
        }
        public bool SetPasaddweak(float v)
        {
            return SetPasaddweak(nativePtr, v);
        }
        public bool SetPasadddizzy(float v)
        {
            return SetPasadddizzy(nativePtr, v);
        }
        public bool SetPasaddsleep(float v)
        {
            return SetPasaddsleep(nativePtr, v);
        }
        public bool SetPasaddslow(float v)
        {
            return SetPasaddslow(nativePtr, v);
        }
        public bool SetPasaddwrap(float v)
        {
            return SetPasaddwrap(nativePtr, v);
        }
        public bool SetPasaddsilenttenaciy(float v)
        {
            return SetPasaddsilenttenaciy(nativePtr, v);
        }
        public bool SetPasaddweaktenaciy(float v)
        {
            return SetPasaddweaktenaciy(nativePtr, v);
        }
        public bool SetPasadddizzytenaciy(float v)
        {
            return SetPasadddizzytenaciy(nativePtr, v);
        }
        public bool SetPasaddsleeptenaciy(float v)
        {
            return SetPasaddsleeptenaciy(nativePtr, v);
        }
        public bool SetPasaddslowtenaciy(float v)
        {
            return SetPasaddslowtenaciy(nativePtr, v);
        }
        public bool SetPasaddwraptenaciy(float v)
        {
            return SetPasaddwraptenaciy(nativePtr, v);
        }
        public bool SetPasaddsilentproficiency(float v)
        {
            return SetPasaddsilentproficiency(nativePtr, v);
        }
        public bool SetPasaddweakproficiency(float v)
        {
            return SetPasaddweakproficiency(nativePtr, v);
        }
        public bool SetPasadddizzyproficiency(float v)
        {
            return SetPasadddizzyproficiency(nativePtr, v);
        }
        public bool SetPasaddsleepproficiency(float v)
        {
            return SetPasaddsleepproficiency(nativePtr, v);
        }
        public bool SetPasaddslowproficiency(float v)
        {
            return SetPasaddslowproficiency(nativePtr, v);
        }
        public bool SetPasaddwrapproficiency(float v)
        {
            return SetPasaddwrapproficiency(nativePtr, v);
        }
        public bool SetPasinchpgen(float v)
        {
            return SetPasinchpgen(nativePtr, v);
        }
        public bool SetPasincmpgen(float v)
        {
            return SetPasincmpgen(nativePtr, v);
        }
        public bool SetRepel(bool v)
        {
            return SetRepel(nativePtr, v);
        }
        public bool SetOverawe(bool v)
        {
            return SetOverawe(nativePtr, v);
        }
        public bool SetSubdefence(bool v)
        {
            return SetSubdefence(nativePtr, v);
        }
        public bool SetDecdefence(bool v)
        {
            return SetDecdefence(nativePtr, v);
        }
        public bool SetDecdamage(bool v)
        {
            return SetDecdamage(nativePtr, v);
        }
        public bool SetBloodshield(bool v)
        {
            return SetBloodshield(nativePtr, v);
        }
        public bool SetImmunedizzy(bool v)
        {
            return SetImmunedizzy(nativePtr, v);
        }
        public bool SetImmunesleep(bool v)
        {
            return SetImmunesleep(nativePtr, v);
        }
        public bool SetImmunesilent(bool v)
        {
            return SetImmunesilent(nativePtr, v);
        }
        public bool SetImmuneweak(bool v)
        {
            return SetImmuneweak(nativePtr, v);
        }
        public bool SetImmunewrap(bool v)
        {
            return SetImmunewrap(nativePtr, v);
        }
        public bool SetImmuneslow(bool v)
        {
            return SetImmuneslow(nativePtr, v);
        }
        public bool SetDrainmagic(bool v)
        {
            return SetDrainmagic(nativePtr, v);
        }
        public bool SetPasaddsmite(float v)
        {
            return SetPasaddsmite(nativePtr, v);
        }
        public bool SetCursed(bool v)
        {
            return SetCursed(nativePtr, v);
        }
        public bool SetDiet(bool v)
        {
            return SetDiet(nativePtr, v);
        }
        public bool SetSalvation(bool v)
        {
            return SetSalvation(nativePtr, v);
        }
        public bool SetBlessed(bool v)
        {
            return SetBlessed(nativePtr, v);
        }
        public bool SetPowerup(bool v)
        {
            return SetPowerup(nativePtr, v);
        }
        public bool SetInchurt(bool v)
        {
            return SetInchurt(nativePtr, v);
        }
        public bool SetInchurt2(bool v)
        {
            return SetInchurt2(nativePtr, v);
        }
        public bool SetRandcurse(bool v)
        {
            return SetRandcurse(nativePtr, v);
        }
        public bool SetClearcooldown(bool v)
        {
            return SetClearcooldown(nativePtr, v);
        }
        public bool SetSecondattack(bool v)
        {
            return SetSecondattack(nativePtr, v);
        }
        public bool SetShouyi(bool v)
        {
            return SetShouyi(nativePtr, v);
        }
        public bool SetNingjin(bool v)
        {
            return SetNingjin(nativePtr, v);
        }
        public bool SetIncanti(bool v)
        {
            return SetIncanti(nativePtr, v);
        }
        public bool SetDecanti(bool v)
        {
            return SetDecanti(nativePtr, v);
        }
        public bool SetAddanti(bool v)
        {
            return SetAddanti(nativePtr, v);
        }
        public bool SetAddanti2(bool v)
        {
            return SetAddanti2(nativePtr, v);
        }
        public bool SetSubanti(bool v)
        {
            return SetSubanti(nativePtr, v);
        }
        public bool SetIncskilldamage(bool v)
        {
            return SetIncskilldamage(nativePtr, v);
        }
        public bool SetDecskilldamage(bool v)
        {
            return SetDecskilldamage(nativePtr, v);
        }
        public bool SetClearbuff(bool v)
        {
            return SetClearbuff(nativePtr, v);
        }
        public bool SetCleardebuff(bool v)
        {
            return SetCleardebuff(nativePtr, v);
        }
        public bool SetRetort(bool v)
        {
            return SetRetort(nativePtr, v);
        }
        public bool SetInccrithurt(bool v)
        {
            return SetInccrithurt(nativePtr, v);
        }
        public bool SetPasaddanti(float v)
        {
            return SetPasaddanti(nativePtr, v);
        }
        public bool SetPasinccrit(float v)
        {
            return SetPasinccrit(nativePtr, v);
        }
        public bool SetTiansha(bool v)
        {
            return SetTiansha(nativePtr, v);
        }
        public bool SetJuqi(bool v)
        {
            return SetJuqi(nativePtr, v);
        }
        public bool SetXiaoxin(bool v)
        {
            return SetXiaoxin(nativePtr, v);
        }
        public bool SetUniqprompt(bool v)
        {
            return SetUniqprompt(nativePtr, v);
        }
        public bool SetDrunk(bool v)
        {
            return SetDrunk(nativePtr, v);
        }
        public bool SetSpicy(bool v)
        {
            return SetSpicy(nativePtr, v);
        }
        public bool SetGloss(bool v)
        {
            return SetGloss(nativePtr, v);
        }
        public bool SetExorcism(bool v)
        {
            return SetExorcism(nativePtr, v);
        }
        public bool SetSubhp(bool v)
        {
            return SetSubhp(nativePtr, v);
        }
        public bool SetSubmp(bool v)
        {
            return SetSubmp(nativePtr, v);
        }
        public bool SetSubattack(bool v)
        {
            return SetSubattack(nativePtr, v);
        }
        public bool SetFamilyincattack(bool v)
        {
            return SetFamilyincattack(nativePtr, v);
        }
        public bool SetFamilyinchp(bool v)
        {
            return SetFamilyinchp(nativePtr, v);
        }
        public bool SetFamilyincmp(bool v)
        {
            return SetFamilyincmp(nativePtr, v);
        }
        public bool SetPasincmp(float v)
        {
            return SetPasincmp(nativePtr, v);
        }
        public bool SetCycsubdefence(bool v)
        {
            return SetCycsubdefence(nativePtr, v);
        }
        public bool SetCycsubattack(bool v)
        {
            return SetCycsubattack(nativePtr, v);
        }
        public bool SetCycdecdefence(bool v)
        {
            return SetCycdecdefence(nativePtr, v);
        }
        public bool SetCycdecattack(bool v)
        {
            return SetCycdecattack(nativePtr, v);
        }
        public bool SetDeccritrate(bool v)
        {
            return SetDeccritrate(nativePtr, v);
        }
        public bool SetDeccrithurt(bool v)
        {
            return SetDeccrithurt(nativePtr, v);
        }
        public bool SetDecdodge(bool v)
        {
            return SetDecdodge(nativePtr, v);
        }
        public bool SetFrenzied(bool v)
        {
            return SetFrenzied(nativePtr, v);
        }
        public bool SetPasincantidizzy(float v)
        {
            return SetPasincantidizzy(nativePtr, v);
        }
        public bool SetPasincantiweak(float v)
        {
            return SetPasincantiweak(nativePtr, v);
        }
        public bool SetPasincantisilent(float v)
        {
            return SetPasincantisilent(nativePtr, v);
        }
        public bool SetPasincantiwrap(float v)
        {
            return SetPasincantiwrap(nativePtr, v);
        }
        public bool SetPasincantisleep(float v)
        {
            return SetPasincantisleep(nativePtr, v);
        }
        public bool SetPasincantislow(float v)
        {
            return SetPasincantislow(nativePtr, v);
        }
        public bool SetPasincanti(float v)
        {
            return SetPasincanti(nativePtr, v);
        }
        public bool SetHolyaura(bool v)
        {
            return SetHolyaura(nativePtr, v);
        }
        public bool SetEvilaura(bool v)
        {
            return SetEvilaura(nativePtr, v);
        }
        public bool SetDie(bool v)
        {
            return SetDie(nativePtr, v);
        }
        public bool SetIceshield(bool v)
        {
            return SetIceshield(nativePtr, v);
        }
        public bool SetFocusanti(bool v)
        {
            return SetFocusanti(nativePtr, v);
        }
        public bool SetDisperseanti(bool v)
        {
            return SetDisperseanti(nativePtr, v);
        }
        public bool SetDecaccuracy(bool v)
        {
            return SetDecaccuracy(nativePtr, v);
        }
        public bool SetIncheal(bool v)
        {
            return SetIncheal(nativePtr, v);
        }
        public bool SetAttack2hp(bool v)
        {
            return SetAttack2hp(nativePtr, v);
        }
        public bool SetAttack2mp(bool v)
        {
            return SetAttack2mp(nativePtr, v);
        }
        public bool SetPowerless(bool v)
        {
            return SetPowerless(nativePtr, v);
        }
        public bool SetAloof(bool v)
        {
            return SetAloof(nativePtr, v);
        }
        public bool SetBleeding(bool v)
        {
            return SetBleeding(nativePtr, v);
        }
        public bool SetDirecthurt(bool v)
        {
            return SetDirecthurt(nativePtr, v);
        }
        public bool SetDirectattack(bool v)
        {
            return SetDirectattack(nativePtr, v);
        }
        public bool SetDizzytimer(bool v)
        {
            return SetDizzytimer(nativePtr, v);
        }
        public bool SetWraptimer(bool v)
        {
            return SetWraptimer(nativePtr, v);
        }
        public bool SetSilenttimer(bool v)
        {
            return SetSilenttimer(nativePtr, v);
        }
        public bool SetSleeptimer(bool v)
        {
            return SetSleeptimer(nativePtr, v);
        }
        public bool SetMagicdoor(bool v)
        {
            return SetMagicdoor(nativePtr, v);
        }
        public bool SetHpleak1(bool v)
        {
            return SetHpleak1(nativePtr, v);
        }
        public bool SetHpleak2(bool v)
        {
            return SetHpleak2(nativePtr, v);
        }
        public bool SetHpleak3(bool v)
        {
            return SetHpleak3(nativePtr, v);
        }
        public bool SetHpleak4(bool v)
        {
            return SetHpleak4(nativePtr, v);
        }
        public bool SetHpleak5(bool v)
        {
            return SetHpleak5(nativePtr, v);
        }
        public bool SetHpleak6(bool v)
        {
            return SetHpleak6(nativePtr, v);
        }
        public bool SetMpdisperse(bool v)
        {
            return SetMpdisperse(nativePtr, v);
        }
        public bool SetGhostform(bool v)
        {
            return SetGhostform(nativePtr, v);
        }
        public bool SetInsanityform(bool v)
        {
            return SetInsanityform(nativePtr, v);
        }
        public bool SetCreateitem(bool v)
        {
            return SetCreateitem(nativePtr, v);
        }
        public bool SetJumptospouse(bool v)
        {
            return SetJumptospouse(nativePtr, v);
        }
        public bool SetYanyu(bool v)
        {
            return SetYanyu(nativePtr, v);
        }
        public bool SetDodgeregain(bool v)
        {
            return SetDodgeregain(nativePtr, v);
        }
        public bool SetHpregain(bool v)
        {
            return SetHpregain(nativePtr, v);
        }
        public bool SetDeadlybless(bool v)
        {
            return SetDeadlybless(nativePtr, v);
        }
        public bool SetHurtscatter(bool v)
        {
            return SetHurtscatter(nativePtr, v);
        }
        public bool SetDeathscatter(bool v)
        {
            return SetDeathscatter(nativePtr, v);
        }
        public bool SetRejectdebuff(bool v)
        {
            return SetRejectdebuff(nativePtr, v);
        }
        public bool SetIncskillaccu(bool v)
        {
            return SetIncskillaccu(nativePtr, v);
        }
        public bool SetDecskillaccu(bool v)
        {
            return SetDecskillaccu(nativePtr, v);
        }
        public bool SetIncskilldodge(bool v)
        {
            return SetIncskilldodge(nativePtr, v);
        }
        public bool SetDecskilldodge(bool v)
        {
            return SetDecskilldodge(nativePtr, v);
        }
        public bool SetIncfatalratio(bool v)
        {
            return SetIncfatalratio(nativePtr, v);
        }
        public bool SetDecfatalratio(bool v)
        {
            return SetDecfatalratio(nativePtr, v);
        }
        public bool SetIncfatalhurt(bool v)
        {
            return SetIncfatalhurt(nativePtr, v);
        }
        public bool SetDecfatalhurt(bool v)
        {
            return SetDecfatalhurt(nativePtr, v);
        }
        public bool SetSetcooldown(bool v)
        {
            return SetSetcooldown(nativePtr, v);
        }
        public bool SetPasincskillaccu(float v)
        {
            return SetPasincskillaccu(nativePtr, v);
        }
        public bool SetPasdecfatalratio(float v)
        {
            return SetPasdecfatalratio(nativePtr, v);
        }
        public bool SetPasdecfatalhurt(float v)
        {
            return SetPasdecfatalhurt(nativePtr, v);
        }
        public bool SetPasincskilldodge(float v)
        {
            return SetPasincskilldodge(nativePtr, v);
        }
        public bool SetPassubhurt(float v)
        {
            return SetPassubhurt(nativePtr, v);
        }
        public bool SetPasdechurt(float v)
        {
            return SetPasdechurt(nativePtr, v);
        }
        public bool SetPasdecpethurt(float v)
        {
            return SetPasdecpethurt(nativePtr, v);
        }
        public bool SetPasdechurt1(float v)
        {
            return SetPasdechurt1(nativePtr, v);
        }
        public bool SetPasdechurt2(float v)
        {
            return SetPasdechurt2(nativePtr, v);
        }
        public bool SetPasdechurt3(float v)
        {
            return SetPasdechurt3(nativePtr, v);
        }
        public bool SetPasdechurt4(float v)
        {
            return SetPasdechurt4(nativePtr, v);
        }
        public bool SetPasdechurt5(float v)
        {
            return SetPasdechurt5(nativePtr, v);
        }
        public bool SetPasdechurt6(float v)
        {
            return SetPasdechurt6(nativePtr, v);
        }
        public bool SetExpboost(bool v)
        {
            return SetExpboost(nativePtr, v);
        }
        public bool SetBarexpboost(bool v)
        {
            return SetBarexpboost(nativePtr, v);
        }
        public bool SetCreditboost(bool v)
        {
            return SetCreditboost(nativePtr, v);
        }
        public bool SetPasincpetdamage(float v)
        {
            return SetPasincpetdamage(nativePtr, v);
        }
        public bool SetAdddebuff(bool v)
        {
            return SetAdddebuff(nativePtr, v);
        }
        public bool SetZhaoqi(bool v)
        {
            return SetZhaoqi(nativePtr, v);
        }
        public bool SetFashen(bool v)
        {
            return SetFashen(nativePtr, v);
        }
        public bool SetCibei(bool v)
        {
            return SetCibei(nativePtr, v);
        }
        public bool SetTiangu(bool v)
        {
            return SetTiangu(nativePtr, v);
        }
        public bool SetBanruo(bool v)
        {
            return SetBanruo(nativePtr, v);
        }
        public bool SetXinmo(bool v)
        {
            return SetXinmo(nativePtr, v);
        }
        public bool SetAoshi(bool v)
        {
            return SetAoshi(nativePtr, v);
        }
        public bool SetHupo(bool v)
        {
            return SetHupo(nativePtr, v);
        }
        public bool SetGuilin(bool v)
        {
            return SetGuilin(nativePtr, v);
        }
        public bool SetTongxin(bool v)
        {
            return SetTongxin(nativePtr, v);
        }
        public bool SetUpdatecommondata(bool v)
        {
            return SetUpdatecommondata(nativePtr, v);
        }
        public bool SetSetcommondata(bool v)
        {
            return SetSetcommondata(nativePtr, v);
        }
        public bool SetBaradddogeaccu(bool v)
        {
            return SetBaradddogeaccu(nativePtr, v);
        }
        public bool SetDiscover(bool v)
        {
            return SetDiscover(nativePtr, v);
        }
        public bool SetCatchpet(bool v)
        {
            return SetCatchpet(nativePtr, v);
        }
        public bool SetViphupo(bool v)
        {
            return SetViphupo(nativePtr, v);
        }
        public bool SetVipguilin(bool v)
        {
            return SetVipguilin(nativePtr, v);
        }
        public bool SetSummon(bool v)
        {
            return SetSummon(nativePtr, v);
        }
        public bool SetExtracthp(bool v)
        {
            return SetExtracthp(nativePtr, v);
        }
        public bool SetExtractmp(bool v)
        {
            return SetExtractmp(nativePtr, v);
        }
        public bool SetFear(bool v)
        {
            return SetFear(nativePtr, v);
        }
        public bool SetLongxiang(bool v)
        {
            return SetLongxiang(nativePtr, v);
        }
        public bool SetHuju(bool v)
        {
            return SetHuju(nativePtr, v);
        }
        public bool SetDouhun(bool v)
        {
            return SetDouhun(nativePtr, v);
        }
        public bool SetGangdan(bool v)
        {
            return SetGangdan(nativePtr, v);
        }
        public bool SetAswind(bool v)
        {
            return SetAswind(nativePtr, v);
        }
        public bool SetAsforest(bool v)
        {
            return SetAsforest(nativePtr, v);
        }
        public bool SetAsfire(bool v)
        {
            return SetAsfire(nativePtr, v);
        }
        public bool SetAshill(bool v)
        {
            return SetAshill(nativePtr, v);
        }
        public bool SetMakecrit(bool v)
        {
            return SetMakecrit(nativePtr, v);
        }
        public bool SetBackorigin(bool v)
        {
            return SetBackorigin(nativePtr, v);
        }
        public bool SetFoxstate(bool v)
        {
            return SetFoxstate(nativePtr, v);
        }
        public bool SetChihun(bool v)
        {
            return SetChihun(nativePtr, v);
        }
        public bool SetDispel(bool v)
        {
            return SetDispel(nativePtr, v);
        }
        public bool SetTransform(bool v)
        {
            return SetTransform(nativePtr, v);
        }
        public bool SetCleartransform(bool v)
        {
            return SetCleartransform(nativePtr, v);
        }
        public bool SetImmunetransform(bool v)
        {
            return SetImmunetransform(nativePtr, v);
        }
        public bool SetPasaddtransform(float v)
        {
            return SetPasaddtransform(nativePtr, v);
        }
        public bool SetPasincantitransform(float v)
        {
            return SetPasincantitransform(nativePtr, v);
        }
        public bool SetAddantitransform(bool v)
        {
            return SetAddantitransform(nativePtr, v);
        }
        public bool SetSubantitransform(bool v)
        {
            return SetSubantitransform(nativePtr, v);
        }
        public bool SetDimming(bool v)
        {
            return SetDimming(nativePtr, v);
        }
        public bool SetShadowhide(bool v)
        {
            return SetShadowhide(nativePtr, v);
        }
        public bool SetShadowdance(bool v)
        {
            return SetShadowdance(nativePtr, v);
        }
        public bool SetPosexchangewithclone(bool v)
        {
            return SetPosexchangewithclone(nativePtr, v);
        }
        public bool SetStateexchangewithclone(bool v)
        {
            return SetStateexchangewithclone(nativePtr, v);
        }
        public bool SetDrawclonelife(bool v)
        {
            return SetDrawclonelife(nativePtr, v);
        }
        public bool SetSharelifewithclone(bool v)
        {
            return SetSharelifewithclone(nativePtr, v);
        }
        public bool SetSharestatewithclone(bool v)
        {
            return SetSharestatewithclone(nativePtr, v);
        }
        public bool SetBackstab(bool v)
        {
            return SetBackstab(nativePtr, v);
        }
        public bool SetCritcurse(bool v)
        {
            return SetCritcurse(nativePtr, v);
        }
        public bool SetIncdrugeffect(bool v)
        {
            return SetIncdrugeffect(nativePtr, v);
        }
        public bool SetDecdrugeffect(bool v)
        {
            return SetDecdrugeffect(nativePtr, v);
        }
        public bool SetSkillmirror(bool v)
        {
            return SetSkillmirror(nativePtr, v);
        }
        public bool SetAbsulotearea(bool v)
        {
            return SetAbsulotearea(nativePtr, v);
        }
        public bool SetSummonclone(bool v)
        {
            return SetSummonclone(nativePtr, v);
        }
        public bool SetUnsummon(bool v)
        {
            return SetUnsummon(nativePtr, v);
        }
        public bool SetUnsummonclone(bool v)
        {
            return SetUnsummonclone(nativePtr, v);
        }
        public bool SetAddspot(bool v)
        {
            return SetAddspot(nativePtr, v);
        }
        public bool SetSubSpot(bool v)
        {
            return SetSubSpot(nativePtr, v);
        }
        public bool SetAddhide(bool v)
        {
            return SetAddhide(nativePtr, v);
        }
        public bool SetSubhide(bool v)
        {
            return SetSubhide(nativePtr, v);
        }
        public bool SetBreakcasting(bool v)
        {
            return SetBreakcasting(nativePtr, v);
        }
        public bool SetCrazycurse(bool v)
        {
            return SetCrazycurse(nativePtr, v);
        }
        public bool SetFogstate(bool v)
        {
            return SetFogstate(nativePtr, v);
        }
        public bool SetMiracleburstxian(bool v)
        {
            return SetMiracleburstxian(nativePtr, v);
        }
        public bool SetMiracleburstfo(bool v)
        {
            return SetMiracleburstfo(nativePtr, v);
        }
        public bool SetMiracleburstmo(bool v)
        {
            return SetMiracleburstmo(nativePtr, v);
        }
        public bool SetDarkness(bool v)
        {
            return SetDarkness(nativePtr, v);
        }
        public bool SetIgnite(bool v)
        {
            return SetIgnite(nativePtr, v);
        }
        public bool SetSkillreflect(bool v)
        {
            return SetSkillreflect(nativePtr, v);
        }
        public bool SetDivinityburst(bool v)
        {
            return SetDivinityburst(nativePtr, v);
        }
        public bool SetDivinityfury(bool v)
        {
            return SetDivinityfury(nativePtr, v);
        }
        public bool SetColdinjure(bool v)
        {
            return SetColdinjure(nativePtr, v);
        }
        public bool SetFrozen(bool v)
        {
            return SetFrozen(nativePtr, v);
        }
        public bool SetGoback(bool v)
        {
            return SetGoback(nativePtr, v);
        }
        public bool SetScopedamage(bool v)
        {
            return SetScopedamage(nativePtr, v);
        }
        public bool SetPullback(bool v)
        {
            return SetPullback(nativePtr, v);
        }
        public bool SetDamagemove(bool v)
        {
            return SetDamagemove(nativePtr, v);
        }
        public bool SetHumanbomb(bool v)
        {
            return SetHumanbomb(nativePtr, v);
        }
        public bool SetPasdecrestrainxian(float v)
        {
            return SetPasdecrestrainxian(nativePtr, v);
        }
        public bool SetPasdecrestrainmo(float v)
        {
            return SetPasdecrestrainmo(nativePtr, v);
        }
        public bool SetPasdecrestrainfo(float v)
        {
            return SetPasdecrestrainfo(nativePtr, v);
        }
        public bool SetPasincdpgen(float v)
        {
            return SetPasincdpgen(nativePtr, v);
        }
        public bool SetSpiritdrag(bool v)
        {
            return SetSpiritdrag(nativePtr, v);
        }
        public bool SetFiring(bool v)
        {
            return SetFiring(nativePtr, v);
        }
        public bool SetBefired(bool v)
        {
            return SetBefired(nativePtr, v);
        }
        public bool SetCreateobject(bool v)
        {
            return SetCreateobject(nativePtr, v);
        }
        public bool SetAddweak(bool v)
        {
            return SetAddweak(nativePtr, v);
        }
        public bool SetAddwrap(bool v)
        {
            return SetAddwrap(nativePtr, v);
        }
        public bool SetAddcharm(bool v)
        {
            return SetAddcharm(nativePtr, v);
        }
        public bool SetAddslow(bool v)
        {
            return SetAddslow(nativePtr, v);
        }
        public bool SetAddcommon(bool v)
        {
            return SetAddcommon(nativePtr, v);
        }
        public bool SetDelaycast(bool v)
        {
            return SetDelaycast(nativePtr, v);
        }
        public bool SetTurnbuff(bool v)
        {
            return SetTurnbuff(nativePtr, v);
        }
        public bool SetTurndebuff(bool v)
        {
            return SetTurndebuff(nativePtr, v);
        }
        public bool SetParalysis(bool v)
        {
            return SetParalysis(nativePtr, v);
        }
        public bool SetSwift(bool v)
        {
            return SetSwift(nativePtr, v);
        }
        public bool SetTriggerskill(bool v)
        {
            return SetTriggerskill(nativePtr, v);
        }
        public bool SetActiveonfilteradd(bool v)
        {
            return SetActiveonfilteradd(nativePtr, v);
        }
        public bool SetActivecrit(bool v)
        {
            return SetActivecrit(nativePtr, v);
        }
        public bool SetActivebecrit(bool v)
        {
            return SetActivebecrit(nativePtr, v);
        }
        public bool SetCrippled(bool v)
        {
            return SetCrippled(nativePtr, v);
        }
        public bool SetGuishen1(bool v)
        {
            return SetGuishen1(nativePtr, v);
        }
        public bool SetTuoling1(bool v)
        {
            return SetTuoling1(nativePtr, v);
        }
        public bool SetGuishen2(bool v)
        {
            return SetGuishen2(nativePtr, v);
        }
        public bool SetTuoling2(bool v)
        {
            return SetTuoling2(nativePtr, v);
        }
        public bool SetBepulled(bool v)
        {
            return SetBepulled(nativePtr, v);
        }
        public bool SetPulling(bool v)
        {
            return SetPulling(nativePtr, v);
        }
        public bool SetBloodthirsty(bool v)
        {
            return SetBloodthirsty(nativePtr, v);
        }
        public bool SetCycle(bool v)
        {
            return SetCycle(nativePtr, v);
        }
        public bool SetIncskilllevel(bool v)
        {
            return SetIncskilllevel(nativePtr, v);
        }
        public bool SetSetskilllevel(bool v)
        {
            return SetSetskilllevel(nativePtr, v);
        }
        public bool SetIncmountspeed(bool v)
        {
            return SetIncmountspeed(nativePtr, v);
        }
        public bool SetPermitcyclearea(bool v)
        {
            return SetPermitcyclearea(nativePtr, v);
        }
        public bool SetLimitcyclearea(bool v)
        {
            return SetLimitcyclearea(nativePtr, v);
        }
        public bool SetJail(bool v)
        {
            return SetJail(nativePtr, v);
        }
        public bool SetJailpermitcyclearea(bool v)
        {
            return SetJailpermitcyclearea(nativePtr, v);
        }
        public bool SetJaillimitcyclearea(bool v)
        {
            return SetJaillimitcyclearea(nativePtr, v);
        }
        public bool SetYuanling(bool v)
        {
            return SetYuanling(nativePtr, v);
        }
        public bool SetGuishen1debuff(bool v)
        {
            return SetGuishen1debuff(nativePtr, v);
        }
        public bool SetTuoling1debuff(bool v)
        {
            return SetTuoling1debuff(nativePtr, v);
        }
        public bool SetGuishen2debuff(bool v)
        {
            return SetGuishen2debuff(nativePtr, v);
        }
        public bool SetTuoling2debuff(bool v)
        {
            return SetTuoling2debuff(nativePtr, v);
        }
        public bool SetCrippleddebuff(bool v)
        {
            return SetCrippleddebuff(nativePtr, v);
        }
        public bool SetPzmaxspeed(bool v)
        {
            return SetPzmaxspeed(nativePtr, v);
        }
        public bool SetPzhalfspeed(bool v)
        {
            return SetPzhalfspeed(nativePtr, v);
        }
        public bool SetPzhill(bool v)
        {
            return SetPzhill(nativePtr, v);
        }
        public bool SetPznomove(bool v)
        {
            return SetPznomove(nativePtr, v);
        }
        public bool SetPzchaos(bool v)
        {
            return SetPzchaos(nativePtr, v);
        }
        public bool SetPzvoid(bool v)
        {
            return SetPzvoid(nativePtr, v);
        }
        public bool SetJuniordarkform(bool v)
        {
            return SetJuniordarkform(nativePtr, v);
        }
        public bool SetJuniorlightform(bool v)
        {
            return SetJuniorlightform(nativePtr, v);
        }
        public bool SetSeniordarkform(bool v)
        {
            return SetSeniordarkform(nativePtr, v);
        }
        public bool SetSeniorlightform(bool v)
        {
            return SetSeniorlightform(nativePtr, v);
        }
        public bool SetDarkuniform(bool v)
        {
            return SetDarkuniform(nativePtr, v);
        }
        public bool SetLightuniform(bool v)
        {
            return SetLightuniform(nativePtr, v);
        }
        public bool SetDechurt2(bool v)
        {
            return SetDechurt2(nativePtr, v);
        }
        public bool SetRecordpos(bool v)
        {
            return SetRecordpos(nativePtr, v);
        }
        public bool SetReturnpos(bool v)
        {
            return SetReturnpos(nativePtr, v);
        }
        public bool SetFly(bool v)
        {
            return SetFly(nativePtr, v);
        }
        public bool SetActivebeattacked(bool v)
        {
            return SetActivebeattacked(nativePtr, v);
        }
        public bool SetMirrorimage(bool v)
        {
            return SetMirrorimage(nativePtr, v);
        }
        public bool SetInstantskill(bool v)
        {
            return SetInstantskill(nativePtr, v);
        }
        public bool SetSummonskill(bool v)
        {
            return SetSummonskill(nativePtr, v);
        }
        public bool SetBloodthirsty2(bool v)
        {
            return SetBloodthirsty2(nativePtr, v);
        }
        public bool SetTalismaneffects(bool v)
        {
            return SetTalismaneffects(nativePtr, v);
        }
        public bool SetTalismaneffectsbless(bool v)
        {
            return SetTalismaneffectsbless(nativePtr, v);
        }
        public bool SetDarklaser(bool v)
        {
            return SetDarklaser(nativePtr, v);
        }
        public bool SetAutorescurrect(bool v)
        {
            return SetAutorescurrect(nativePtr, v);
        }
        public bool SetAddspirit(bool v)
        {
            return SetAddspirit(nativePtr, v);
        }
        public bool SetDirstate(bool v)
        {
            return SetDirstate(nativePtr, v);
        }
        public bool SetTeamenchant(bool v)
        {
            return SetTeamenchant(nativePtr, v);
        }
        public bool SetGthpgen(bool v)
        {
            return SetGthpgen(nativePtr, v);
        }
        public bool SetGtmpgen(bool v)
        {
            return SetGtmpgen(nativePtr, v);
        }
        public bool SetGtaddattackdefense(bool v)
        {
            return SetGtaddattackdefense(nativePtr, v);
        }
        public bool SetShowyb(bool v)
        {
            return SetShowyb(nativePtr, v);
        }
        public bool SetRecoverhp(bool v)
        {
            return SetRecoverhp(nativePtr, v);
        }
        public bool SetEquipeffect(bool v)
        {
            return SetEquipeffect(nativePtr, v);
        }
        public bool SetSummonmachine(bool v)
        {
            return SetSummonmachine(nativePtr, v);
        }
        public bool SetSummontrap(bool v)
        {
            return SetSummontrap(nativePtr, v);
        }
        public bool SetSummoncontroltrap(bool v)
        {
            return SetSummoncontroltrap(nativePtr, v);
        }
        public bool SetSummonteleport1(bool v)
        {
            return SetSummonteleport1(nativePtr, v);
        }
        public bool SetSummonteleport2(bool v)
        {
            return SetSummonteleport2(nativePtr, v);
        }
        public bool SetCurseteleport(bool v)
        {
            return SetCurseteleport(nativePtr, v);
        }
        public bool SetSpytrap(bool v)
        {
            return SetSpytrap(nativePtr, v);
        }
        public bool SetSpeedto(bool v)
        {
            return SetSpeedto(nativePtr, v);
        }
        public bool SetPossummon(bool v)
        {
            return SetPossummon(nativePtr, v);
        }
        public bool SetPuppetform(bool v)
        {
            return SetPuppetform(nativePtr, v);
        }
        public bool SetPuppetskill(bool v)
        {
            return SetPuppetskill(nativePtr, v);
        }
        public bool SetBounceto(bool v)
        {
            return SetBounceto(nativePtr, v);
        }
        public bool SetDrawto(bool v)
        {
            return SetDrawto(nativePtr, v);
        }
        public bool SetSubantidizzy2(bool v)
        {
            return SetSubantidizzy2(nativePtr, v);
        }
        public bool SetSubantisleep2(bool v)
        {
            return SetSubantisleep2(nativePtr, v);
        }
        public bool SetSubantiweak2(bool v)
        {
            return SetSubantiweak2(nativePtr, v);
        }
        public bool SetSubantisilent2(bool v)
        {
            return SetSubantisilent2(nativePtr, v);
        }
        public bool SetSubantiwrap2(bool v)
        {
            return SetSubantiwrap2(nativePtr, v);
        }
        public bool SetSubantislow2(bool v)
        {
            return SetSubantislow2(nativePtr, v);
        }
        public bool SetSubhp2(bool v)
        {
            return SetSubhp2(nativePtr, v);
        }
        public bool SetSubmp2(bool v)
        {
            return SetSubmp2(nativePtr, v);
        }
        public bool SetSeed(bool v)
        {
            return SetSeed(nativePtr, v);
        }
        public bool SetQilinform(bool v)
        {
            return SetQilinform(nativePtr, v);
        }
        public bool SetRmhumanform(bool v)
        {
            return SetRmhumanform(nativePtr, v);
        }
        public bool SetCycleskill(bool v)
        {
            return SetCycleskill(nativePtr, v);
        }
        public bool SetBuxiu(bool v)
        {
            return SetBuxiu(nativePtr, v);
        }
        public bool SetRepel2(bool v)
        {
            return SetRepel2(nativePtr, v);
        }
        public bool SetBlowoff(bool v)
        {
            return SetBlowoff(nativePtr, v);
        }
        public bool SetAssault2(bool v)
        {
            return SetAssault2(nativePtr, v);
        }
        public bool SetThrowback(bool v)
        {
            return SetThrowback(nativePtr, v);
        }
        public bool SetAddrage1(bool v)
        {
            return SetAddrage1(nativePtr, v);
        }
        public bool SetAddrage2(bool v)
        {
            return SetAddrage2(nativePtr, v);
        }
        public bool SetRenma1(bool v)
        {
            return SetRenma1(nativePtr, v);
        }
        public bool SetRenma2(bool v)
        {
            return SetRenma2(nativePtr, v);
        }
        public bool SetRenma3(bool v)
        {
            return SetRenma3(nativePtr, v);
        }
        public bool SetRenma4(bool v)
        {
            return SetRenma4(nativePtr, v);
        }
        public bool SetSharelifewithsummon(bool v)
        {
            return SetSharelifewithsummon(nativePtr, v);
        }
        public bool SetReduceskillcd(bool v)
        {
            return SetReduceskillcd(nativePtr, v);
        }
        public bool SetAccumdamage(bool v)
        {
            return SetAccumdamage(nativePtr, v);
        }
        public bool SetBloodpool(bool v)
        {
            return SetBloodpool(nativePtr, v);
        }
        public bool SetDsleep(bool v)
        {
            return SetDsleep(nativePtr, v);
        }
        public bool SetFinder(bool v)
        {
            return SetFinder(nativePtr, v);
        }
        public bool SetHider(bool v)
        {
            return SetHider(nativePtr, v);
        }
        public bool SetKillmonster(bool v)
        {
            return SetKillmonster(nativePtr, v);
        }
        public bool SetAddmonsterexp(bool v)
        {
            return SetAddmonsterexp(nativePtr, v);
        }
        public bool SetHumanbomb2(bool v)
        {
            return SetHumanbomb2(nativePtr, v);
        }
        public bool SetTrad(bool v)
        {
            return SetTrad(nativePtr, v);
        }
        public bool SetStruggle(bool v)
        {
            return SetStruggle(nativePtr, v);
        }
        public bool SetParry(bool v)
        {
            return SetParry(nativePtr, v);
        }
        public bool SetDisguise(bool v)
        {
            return SetDisguise(nativePtr, v);
        }
        public bool SetSign(bool v)
        {
            return SetSign(nativePtr, v);
        }
        public bool SetMagicdance(bool v)
        {
            return SetMagicdance(nativePtr, v);
        }
        public bool SetAtkchangetarget(bool v)
        {
            return SetAtkchangetarget(nativePtr, v);
        }
        public bool SetAtkchangetarget2(bool v)
        {
            return SetAtkchangetarget2(nativePtr, v);
        }
        public bool SetPojun1(bool v)
        {
            return SetPojun1(nativePtr, v);
        }
        public bool SetPojun2(bool v)
        {
            return SetPojun2(nativePtr, v);
        }
        public bool SetSkilltransfer(bool v)
        {
            return SetSkilltransfer(nativePtr, v);
        }
        public bool SetGroupatkchange(bool v)
        {
            return SetGroupatkchange(nativePtr, v);
        }
        public bool SetSingleatkchange(bool v)
        {
            return SetSingleatkchange(nativePtr, v);
        }
        public bool SetClearkillnum(bool v)
        {
            return SetClearkillnum(nativePtr, v);
        }
        public bool SetSmog(bool v)
        {
            return SetSmog(nativePtr, v);
        }
        public bool SetClearimmune(bool v)
        {
            return SetClearimmune(nativePtr, v);
        }
        public bool SetWhenkillasself(bool v)
        {
            return SetWhenkillasself(nativePtr, v);
        }
        public bool SetWhenkillastarget(bool v)
        {
            return SetWhenkillastarget(nativePtr, v);
        }
        public bool SetIgnoreblessed(bool v)
        {
            return SetIgnoreblessed(nativePtr, v);
        }
        public bool SetImmunetaune(bool v)
        {
            return SetImmunetaune(nativePtr, v);
        }
        public bool SetParry2(bool v)
        {
            return SetParry2(nativePtr, v);
        }
        public bool SetImmunelakemp(bool v)
        {
            return SetImmunelakemp(nativePtr, v);
        }
        public bool SetSupertrigger(bool v)
        {
            return SetSupertrigger(nativePtr, v);
        }
        public bool SetAddseed(bool v)
        {
            return SetAddseed(nativePtr, v);
        }
        public bool SetDeathpact(bool v)
        {
            return SetDeathpact(nativePtr, v);
        }
        public bool SetScudblessing(bool v)
        {
            return SetScudblessing(nativePtr, v);
        }
        public bool SetDeriveattribution(bool v)
        {
            return SetDeriveattribution(nativePtr, v);
        }
        public bool SetDerivedef(bool v)
        {
            return SetDerivedef(nativePtr, v);
        }
        public bool SetFenggong(bool v)
        {
            return SetFenggong(nativePtr, v);
        }
        public bool SetIcecurse(bool v)
        {
            return SetIcecurse(nativePtr, v);
        }
        public bool SetFlamecurse(bool v)
        {
            return SetFlamecurse(nativePtr, v);
        }
        public bool SetIceblessing(bool v)
        {
            return SetIceblessing(nativePtr, v);
        }
        public bool SetFlameblessing(bool v)
        {
            return SetFlameblessing(nativePtr, v);
        }
        public bool SetTorpescence(bool v)
        {
            return SetTorpescence(nativePtr, v);
        }
        public bool SetSacrifice(bool v)
        {
            return SetSacrifice(nativePtr, v);
        }
        public bool SetQingluo1(bool v)
        {
            return SetQingluo1(nativePtr, v);
        }
        public bool SetQingluo2(bool v)
        {
            return SetQingluo2(nativePtr, v);
        }
        public bool SetGuhuo(bool v)
        {
            return SetGuhuo(nativePtr, v);
        }
        public bool SetFear2(bool v)
        {
            return SetFear2(nativePtr, v);
        }
        public bool SetSuspend(bool v)
        {
            return SetSuspend(nativePtr, v);
        }
        public bool SetDisarrange(bool v)
        {
            return SetDisarrange(nativePtr, v);
        }
        public bool SetImitate(bool v)
        {
            return SetImitate(nativePtr, v);
        }
        public bool SetSoullink(bool v)
        {
            return SetSoullink(nativePtr, v);
        }
        public bool SetSkillreplace(bool v)
        {
            return SetSkillreplace(nativePtr, v);
        }
        public bool SetSharedamage(bool v)
        {
            return SetSharedamage(nativePtr, v);
        }
        public bool SetClrsoullink(bool v)
        {
            return SetClrsoullink(nativePtr, v);
        }
        public bool SetAddproficiency(bool v)
        {
            return SetAddproficiency(nativePtr, v);
        }
        public bool SetDechurt3(bool v)
        {
            return SetDechurt3(nativePtr, v);
        }
        public bool SetPromotedps(bool v)
        {
            return SetPromotedps(nativePtr, v);
        }
        public bool SetActivebecrit2(bool v)
        {
            return SetActivebecrit2(nativePtr, v);
        }
        public bool SetDpleak(bool v)
        {
            return SetDpleak(nativePtr, v);
        }
        public bool SetRagegen(bool v)
        {
            return SetRagegen(nativePtr, v);
        }
        public bool SetAbolishbloodpool(bool v)
        {
            return SetAbolishbloodpool(nativePtr, v);
        }
        public bool SetImmunemanaburn(bool v)
        {
            return SetImmunemanaburn(nativePtr, v);
        }
        public bool SetSummonnpc(bool v)
        {
            return SetSummonnpc(nativePtr, v);
        }
    }
}
