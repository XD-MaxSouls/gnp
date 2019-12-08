--[[
***���ű���Ҫ�Է����������＼�ܣ��Ƿ������ܣ����д���***
����ͨ������
ZLuaTal_SkillSetInit()    ---����ѡȡ�������Ӽ��ܵĲ���ԭ��

������������
ZLuaTal_Talisman_Trans_ID(Temp_TalismanID)  ---���ݴ���ķ���IDȡ��ְҵ�ͷ���Ʒ����Ϣ
ZLuaTal_Talisman_Skill_Info(Player_Prof,Talisman_Lvl,origin)  	---���ݷ���ְҵ����ͷ���Ʒ�׾������Ӽ��ܺ͸��Ӽ��ܳ��ֵķ�������

������
ZLuaTal_CheckIsNumberTable(ANumTable,Numr_Min)     	 	---����һ��Table�Ƿ�ΪNumber��ɵ�table������СΪNumr_Min
ZLuaTal_Chance_Norm(n1)                             	---��һ��table���������У��е������и��ʹ�һ��
ZLuaTal_Get_RanPoint(s1)                            	---�����һ����������s1��ѡȡһ����������λ����Ϣ
ZLuaTal_Make_AllChoise(t,prof,Temp_TalismanID,origin)                           	---����ZLuaTal_SkillSetInit()�е��趨��t������ѡ��������ѡ�����
ZLuaTal_FindSkillReqInfo(t,ts)                          ---��ts������Ѱ��t��������t��Ӧ��λ��
--]]
-------------------------------------------------------------------------------- 
function ZLuaTal_SkillSetInit()
	local MaxSameSkillColu=1 	-----ͬһ�ֿ��ܵ������ִ���
	local MaxSkillChoise=6  	-----��Ҫ��������ѡȡ��Ŀ�����,<=30 
	local SameNum=1           	-----ͬһ�ֿ��ܵĵ�ǰ���ִ�����ֵ
	local SkillLearnDelay=3 	-----���ܳ��ֿ����ӳٵķ������� 0ʱû���ӳ٣�N����0,...N-1
	local MaxPosLvl=30				-----�������ܵ���󼶱�
	return MaxSameSkillColu,MaxSkillChoise,SameNum,SkillLearnDelay,MaxPosLvl 
end 
-------------------------------------------------------------------------------- 
---���ܵ���ķ���ID��Ϣ��ת��Ϊְҵ�ͷ���������Ӧ���Ｖ��λ��
function ZLuaTal_Talisman_Trans_ID(Temp_TalismanID,origin)
    if type(Temp_TalismanID)~="number" or type(origin)~="number" then return false,false end
    ----�������Ĳ���number�򷵻�false false
  local Temp_Player_Prof,Temp_Talisman_Lvl
	local Temp_TalismanSign=ZLuaTalAvailableTalismans()	----��־����ID����
	
	if Temp_TalismanID==Temp_TalismanSign["NW_1_BaGuaShi"].tmplID then
	   Temp_Player_Prof=0
		 Temp_Talisman_Lvl=0
	elseif 	Temp_TalismanID==Temp_TalismanSign["QY_15_LiuHeJing"].tmplID then
	   Temp_Player_Prof=1
		 Temp_Talisman_Lvl=1
	elseif 	Temp_TalismanID==Temp_TalismanSign["GW_15_ZhuQueYin"].tmplID then
	   Temp_Player_Prof=2
		 Temp_Talisman_Lvl=1
	elseif 	Temp_TalismanID==Temp_TalismanSign["TY_15_LunHuiZhu"].tmplID then
	   Temp_Player_Prof=3
		 Temp_Talisman_Lvl=1
	elseif 	Temp_TalismanID==Temp_TalismanSign["HH_15_SheXinLing"].tmplID then
		 Temp_Player_Prof=4
		 Temp_Talisman_Lvl=1
	elseif 	Temp_TalismanID==Temp_TalismanSign["GD_15_XueYuGuPian"].tmplID then
		 Temp_Player_Prof=5
		 Temp_Talisman_Lvl=1
	elseif 	Temp_TalismanID==Temp_TalismanSign["QY_75_QiXingJian"].tmplID then
     Temp_Player_Prof=1
		 Temp_Talisman_Lvl=2
	elseif 	Temp_TalismanID==Temp_TalismanSign["GW_75_SiLingFan"].tmplID then
	   Temp_Player_Prof=2
		 Temp_Talisman_Lvl=2
	elseif 	Temp_TalismanID==Temp_TalismanSign["TY_75_JinGangChu"].tmplID then
	   Temp_Player_Prof=3
		 Temp_Talisman_Lvl=2
	elseif 	Temp_TalismanID==Temp_TalismanSign["HH_75_DuoQingHuan"].tmplID then
		 Temp_Player_Prof=4
		 Temp_Talisman_Lvl=2
	elseif 	Temp_TalismanID==Temp_TalismanSign["GD_75_PoSha"].tmplID then
		 Temp_Player_Prof=5
		 Temp_Talisman_Lvl=2
  elseif 	Temp_TalismanID==Temp_TalismanSign["QY_105_HuPoZhuLing"].tmplID then
		 Temp_Player_Prof=1
		 Temp_Talisman_Lvl=3
  elseif 	Temp_TalismanID==Temp_TalismanSign["GW_105_QianKunQingGuangJie"].tmplID then
		 Temp_Player_Prof=2
		 Temp_Talisman_Lvl=3 
  elseif 	Temp_TalismanID==Temp_TalismanSign["TY_105_RuYiQianKunDai"].tmplID then
		 Temp_Player_Prof=3
		 Temp_Talisman_Lvl=3 
  elseif 	Temp_TalismanID==Temp_TalismanSign["HH_105_QianMeiLian"].tmplID then
		 Temp_Player_Prof=4
		 Temp_Talisman_Lvl=3
	elseif 	Temp_TalismanID==Temp_TalismanSign["GD_105_QianDuGu"].tmplID then
		 Temp_Player_Prof=5
		 Temp_Talisman_Lvl=3
  elseif 	Temp_TalismanID==Temp_TalismanSign["GW_135_TianMoZhi"].tmplID then
		 Temp_Player_Prof=2
		 Temp_Talisman_Lvl=4
  elseif 	Temp_TalismanID==Temp_TalismanSign["QY_135_RuoXue"].tmplID then
		 Temp_Player_Prof=1
		 Temp_Talisman_Lvl=4 
  elseif 	Temp_TalismanID==Temp_TalismanSign["HH_135_BaJiYouLong"].tmplID then
		 Temp_Player_Prof=4
		 Temp_Talisman_Lvl=4 
  elseif 	Temp_TalismanID==Temp_TalismanSign["TY_135_LiuDaoShengMie"].tmplID then
		 Temp_Player_Prof=3
		 Temp_Talisman_Lvl=4
	elseif 	Temp_TalismanID==Temp_TalismanSign["GD_135_GuiQing"].tmplID then
		 Temp_Player_Prof=5
		 Temp_Talisman_Lvl=4
  elseif 	Temp_TalismanID==Temp_TalismanSign["US_75_ShanHeShan"].tmplID or
  			 	Temp_TalismanID==Temp_TalismanSign["US_45_ShenMuShai"].tmplID or 
  			 	Temp_TalismanID==Temp_TalismanSign["US_75_WanDuDing"].tmplID or
  			 	Temp_TalismanID==Temp_TalismanSign["US_75_LingLongTa"].tmplID or
  			 	Temp_TalismanID==Temp_TalismanSign["US_75_YuJingPing"].tmplID then
     Temp_Player_Prof=6
		 Temp_Talisman_Lvl=2
	elseif  Temp_TalismanID==Temp_TalismanSign["US_105_JinHuLu"].tmplID or
  		  	Temp_TalismanID==Temp_TalismanSign["US_105_JiuLongShenHuoZhao"].tmplID or
  		  	Temp_TalismanID==Temp_TalismanSign["US_105_YinYangJing"].tmplID or
  		  	Temp_TalismanID==Temp_TalismanSign["US_105_ZhenShanHeShan"].tmplID or
  		  	Temp_TalismanID==Temp_TalismanSign["US_105_LuoHunDeng"].tmplID then
     Temp_Player_Prof=6
		 Temp_Talisman_Lvl=3
	elseif 	Temp_TalismanID==Temp_TalismanSign["US_135_SheHun"].tmplID or
					Temp_TalismanID==Temp_TalismanSign["US_135_PanLongFan"].tmplID or 
					Temp_TalismanID==Temp_TalismanSign["US_135_WuLongLun"].tmplID or 	
					Temp_TalismanID==Temp_TalismanSign["US_135_FanTianYin"].tmplID or 	
					Temp_TalismanID==Temp_TalismanSign["US_135_ChangMingDeng"].tmplID or 	
  				Temp_TalismanID==Temp_TalismanSign["US_145_ShiXueZhu"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["US_145_ShiHun"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["foodtalisman"].tmplID then
     Temp_Player_Prof=6
		 Temp_Talisman_Lvl=4
  elseif  Temp_TalismanID==Temp_TalismanSign["ceshifeibao"].tmplID or
          Temp_TalismanID==Temp_TalismanSign["ceshixingxiang"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["feiafei"].tmplID then
  	 Temp_Player_Prof=7
		 Temp_Talisman_Lvl=1
	------����ģʽ����Ĳ�Ʊ�ɽ�
  elseif  Temp_TalismanID==Temp_TalismanSign["longxiang"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["yunsuo"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["yuruyi"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["biluo"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["hongfei"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["zimang"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["huiji"].tmplID then
  	 Temp_Player_Prof=7
		 Temp_Talisman_Lvl=1
	------�������ķǲ�Ʊ�����ķɽ�
	elseif  Temp_TalismanID==Temp_TalismanSign["shuoguang"].tmplID or
	        Temp_TalismanID==Temp_TalismanSign["jueying"].tmplID or
	        Temp_TalismanID==Temp_TalismanSign["liudaolunhui"].tmplID or
	        Temp_TalismanID==Temp_TalismanSign["qingshuang"].tmplID or
	        Temp_TalismanID==Temp_TalismanSign["jueying2"].tmplID or
	        Temp_TalismanID==Temp_TalismanSign["shuoguang2"].tmplID then
  	 Temp_Player_Prof=7
		 Temp_Talisman_Lvl=0
	else
     return false,false
	end
	
	local a1Temptable={}    ----���صļ�������1
	local a2Temptable={}    ----���صļ�������2
	a1Temptable,a2Temptable= ZLuaTal_Talisman_Skill_Info(Temp_Player_Prof,Temp_Talisman_Lvl,origin)

	if ZLuaTal_CheckIsNumberTable(a1Temptable,0) and ZLuaTal_CheckIsNumberTable(a2Temptable,0) then
		return a1Temptable,a2Temptable
	else
	    return false,true
		----������ص�ֵ����table����table����С��0�������򷵻�false false
	end

end
--------------------------------------------------------------------------------
------���ݷ�����ͬ��ְҵ����λ�������Ӽ��ܡ����Ӽ��ܳ��ַ�������----------------
function ZLuaTal_Talisman_Skill_Info(Player_Prof,Talisman_Lvl,origin)
	---Player_Prof
	---shaoxia(0),qingyun(1),guiwang(2),tianyin(3),hehuan(4),guidao(5),suiji(6),feijian(7)
	---Talisman_Lvl
	---0(lvl=1),1(lvl=15),2(lvl=75),3(lvl=105),4(lvl=135),5(lvl=145)
	----����Player_Prof=0ʱ��Talisman_Lvl<=2 
	---math.randomseed(os.time())
	---math.random()
	---math.random()
	
	if type(Player_Prof)~="number" or type(Talisman_Lvl)~="number" or type(origin)~="number" then return end

	local MaxSameSkillColu 	-----ͬһ�ֿ��ܵ������ִ���
	local MaxSkillChoise  	-----��Ҫ��������ѡȡ��Ŀ�����
	local SameNum           -----ͬһ�ֿ��ܵĵ�ǰ���ִ�����ֵ
	local SkillLearnDelay 	-----��ϰ���ܿ����ӳٵķ�������  0ʱû���ӳ�
	local MaxPosLvl					-----�������ܳ��ֵ���󼶱�
	MaxSameSkillColu,MaxSkillChoise,SameNum,SkillLearnDelay,MaxPosLvl = ZLuaTal_SkillSetInit()


	local SkillExInfo={}  ----���ܱ����Ϣ��ģ��ţ�

	---//���ַ������Ӽ���ģ�����Ϣ
	SkillExInfo[1]={337,338,340,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[2]={337,338,354,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[3]={337,338,370,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[4]={337,338,385,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[5]={337,338,340,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[6]={337,338,354,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[7]={337,338,370,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[8]={337,338,385,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[9]={337,338,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[10]={337,338,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	---//�����ŷ������Ӽ���ģ�����Ϣ
	SkillExInfo[11]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[12]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[13]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[14]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[15]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[16]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[17]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[18]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[19]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[20]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	---//�����ڷ������Ӽ���ģ�����Ϣ
	SkillExInfo[21]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[22]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[23]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[24]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[25]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[26]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[27]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[28]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[29]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[30]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	---//�����·������Ӽ���ģ�����Ϣ
	SkillExInfo[31]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[32]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[33]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[34]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[35]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[36]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[37]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[38]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[39]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[40]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
    ---//�ϻ������ɷ������Ӽ���ģ�����Ϣ
	SkillExInfo[41]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[42]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[43]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[44]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[45]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[46]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[47]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[48]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[49]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[50]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	---//�����������Ӽ���ģ�����Ϣ
	SkillExInfo[51]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[52]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[53]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[54]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[55]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[56]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[57]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[58]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[59]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[60]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
---//�ɽ����Ӽ���ģ�����Ϣ������������
	SkillExInfo[61]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[62]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[63]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[64]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[65]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[66]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[67]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[68]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[69]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[70]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	---//�ɽ����Ӽ���ģ�����Ϣ
	SkillExInfo[71]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[72]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[73]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[74]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[75]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[76]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[77]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[78]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[79]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[80]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	local SkillRanChance={}
	---//���ַ������Ӽ��ܳ��ָ�����Ϣ
	SkillRanChance[1]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[2]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[3]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[4]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[5]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[6]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[7]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[8]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[8]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[10]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
    ---//�����ŷ������Ӽ��ܳ��ָ�����Ϣ��15-20��ʱ��������Ӧλ��ͬ��
	SkillRanChance[11]={512,448,384,320,256,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[12]={256,320,384,448,512,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[13]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[14]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[15]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[16]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[17]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[18]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[19]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	SkillRanChance[20]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	---//�����ڷ������Ӽ��ܳ��ָ�����Ϣ
	SkillRanChance[21]={512,448,384,320,256,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[22]={256,320,384,448,512,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[23]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[24]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[25]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[26]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[27]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[28]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[29]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	SkillRanChance[30]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	---//�����·������Ӽ��ܳ��ָ�����Ϣ
	SkillRanChance[31]={512,448,384,320,256,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[32]={256,320,384,448,512,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[33]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[34]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[35]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[36]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[37]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[38]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[39]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	SkillRanChance[40]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	---//�ϻ��ɷ������Ӽ��ܳ��ָ�����Ϣ
	SkillRanChance[41]={512,448,384,320,256,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[42]={256,320,384,448,512,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[43]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[44]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[45]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[46]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[47]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[48]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[49]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	SkillRanChance[50]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	---//�����������Ӽ��ܳ��ָ�����Ϣ
	SkillRanChance[51]={512,448,384,320,256,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[52]={256,320,384,448,512,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[53]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[54]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[55]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[56]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[57]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[58]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[59]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	SkillRanChance[60]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	---//�ɽ����Ӽ��ܳ��ָ�����Ϣ��������
	SkillRanChance[61]={512,448,384,320,256,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[62]={256,320,384,448,512,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[63]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[64]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[65]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[66]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[67]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[68]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[69]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	SkillRanChance[70]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	---//�ɽ����Ӽ��ܳ��ָ�����Ϣ
	SkillRanChance[71]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}---quest
	SkillRanChance[72]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}---shop
	SkillRanChance[73]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}---npc
	SkillRanChance[74]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}---lottery
	SkillRanChance[75]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[76]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}---combine
	SkillRanChance[77]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[78]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[79]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[80]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	
	local SkillRanChanceWhenOrigin={}
	SkillRanChanceWhenOrigin[1]={100,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	
	local Skill_AddonInfo={}
    ---�������ܸ������м���ģ���
	Skill_AddonInfo={337,338,0,
	339,340,341,342,343,344,345,346,347,348,349,350,351,352,353,
	354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,
	369,370,371,372,373,374,375,376,377,378,379,380,381,382,383,
	384,385,386,387,388,389,390,391,392,393,394,395,396,397,398,
	872,873,874,875,876,877,878,879,880,881,882,883,884,885,886,
	887,888,889,890,891,892,893,894,895,896,897,898,899,900,901,
	902,903,904,905,906,907,1758,1759,1760,1761,1762,1763,1764,1765,1766,
	1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,
	1922,1923,1924,1925,1926,1927}
	
	
  local Skill_ReqLvlInfo={}
	---�������Ӽ��ܶ�Ӧ�ķ�����������(Skill_AddonInfoһһ��Ӧ��
	Skill_ReqLvlInfo={1,2,0,
  4,3,5,8,6,14,9,12,11,10,17,18,15,20,16,
	3,6,5,7,8,11,9,10,12,11,16,17,16,15,18,
	5,3,6,4,8,14,9,12,11,10,17,15,20,18,16,
	4,3,8,6,4,10,9,12,14,11,13,18,16,15,20,
	21,22,23,24,26,27,28,21,22,23,24,25,27,28,21,
	22,23,24,25,27,28,21,22,23,24,25,27,28,29,30,
	29,30,29,30,29,30,3,4,5,6,7,9,11,12,14,
	13,15,15,17,18,19,21,23,23,24,25,27,28,29,30,
	1,10,15,20,25,30}

  local RSkillExInfo_1={}    ----��һ��ѡ���ԭʼ��������ID����
	local RSkillExInfo_2={}    ----���ڷ��صĸ�������ID����
	local CSkillRanChance={}   ----ѡ���SkillExInfo[N]�еľ��巨���������
	local RSkillReqInfo={}     ----�����������󷨱�������Ϣ
  local ID_Choosed  		   ----�����ID����

	local Temp_Ran_NumA
	
	Temp_Ran_NumA=math.random()
	
	if Temp_Ran_NumA==0 then Temp_Ran_NumA=0.01 end
	if Player_Prof~=6 then     ----���ְҵ��Ϊ���ְҵ
			if Player_Prof==0 then 
					if origin==0 then		---origin:0 quest;1 shop;2 npc;3 lottery;5 combine
						ID_Choosed=Player_Prof*10+1
					else 
						ID_Choosed=Player_Prof*10+math.ceil(Temp_Ran_NumA*Talisman_Lvl*4)
			  	end
			elseif Player_Prof==7 then
				 ID_Choosed=Player_Prof*10+1+origin
			else 
					if origin==0 then 
						ID_Choosed=Player_Prof*10+1
			  	else
			    	ID_Choosed=Player_Prof*10+math.ceil(Temp_Ran_NumA*Talisman_Lvl*2)
					end 
			end 
	else
		ID_Choosed=math.ceil(Temp_Ran_NumA*5)*10+math.ceil(Temp_Ran_NumA*Talisman_Lvl*2)
		---����������룬��Ϊ*5
	end

	if ID_Choosed>80 or ID_Choosed<1 then ID_Choosed=1 end

	RSkillExInfo_1=SkillExInfo[ID_Choosed]
	if Player_Prof~=6 and Player_Prof~=7 and Talisman_Lvl~=4 and origin==0 then 
		CSkillRanChance=ZLuaTal_Make_AllChoise(SkillRanChanceWhenOrigin[1],Player_Prof,Talisman_Lvl,origin)
    ---ZLuaTal_Special_Print(CSkillRanChance)    ---$$$$������$$$$-----
 	else
 		CSkillRanChance=ZLuaTal_Make_AllChoise(SkillRanChance[ID_Choosed],Player_Prof,Talisman_Lvl,origin)
 	end 
  
  local mm
	for mm=1,table.getn(CSkillRanChance) do

	    if CSkillRanChance[mm]==65536 then
	    		RSkillExInfo_2[mm]=0
					RSkillReqInfo[mm]=0
			else
				RSkillExInfo_2[mm]=RSkillExInfo_1[CSkillRanChance[mm]]
				if table.getn(Skill_AddonInfo)~=table.getn(Skill_ReqLvlInfo) then return end
				if SkillLearnDelay==0 or RSkillExInfo_2[mm]==0 or (Player_Prof~=6 and origin==0) or Player_Prof==7 then
					RSkillReqInfo[mm]= Skill_ReqLvlInfo[ZLuaTal_FindSkillReqInfo(RSkillExInfo_2[mm],Skill_AddonInfo)]
			  else
			    RSkillReqInfo[mm]= Skill_ReqLvlInfo[ZLuaTal_FindSkillReqInfo(RSkillExInfo_2[mm],Skill_AddonInfo)]+math.floor(math.random()*SkillLearnDelay)
				end
			end
			if RSkillReqInfo[mm]>MaxPosLvl then RSkillReqInfo[mm]=MaxPosLvl end
	end
	---ZLuaTal_Special_Print(RSkillExInfo_2)   	---$$$$������$$$$-----
	---ZLuaTal_Special_Print(RSkillReqInfo)		---$$$$������$$$$-----
	return ZLuaTal_SkillMakeSeq(RSkillExInfo_2, RSkillReqInfo)
end
--------------------------------------------------------------------------------

------------����Ƿ�Ϊһ������ɵ�table,table��,����С��С��Numr_Min------------
function ZLuaTal_CheckIsNumberTable(ANumTable,Numr_Min)
	local tm
	if type(ANumTable)~="table" then return false end  
	if type(ANumTable)=="table" then
		for tm=1,table.getn(ANumTable) do 
			if type(ANumTable[tm])~="number" or ANumTable[tm]<Numr_Min then
				return false 
            end 
		end  
	end  
	return true
end 

----���ּ�����̬��--------------------------------------------------------------
function ZLuaTal_Chance_Norm(n1)
  if not ZLuaTal_CheckIsNumberTable(n1,0) then return end 
	local n1_size=table.getn(n1)
	local Total_Chance=0
	local i,m,k
	---�����
	for i=1,n1_size do
   		Total_Chance=n1[i]+Total_Chance          
	end
 	---���ɸ���������
	local nx={}
	for k=1,n1_size do
		if k==1 then 
			nx[1]=n1[k]
		else
	   	nx[k]=n1[k]+nx[k-1]              
	  end
	end

	---��������׼���ĸ���������
	local n2={}
     for m=1,n1_size do
     		if Total_Chance==0 then                 ---����ȫ0���еĴ���������{1,0,0...}
			 		n2[m]=0
					n2[1]=1
				else
					n2[m]=nx[m]/ Total_Chance
				end
	 	 end
	---����һ���������� 
    ---ZLuaTal_Special_Print(n2)   				---$$$$������$$$$-----
	return n2
end
-------------------------------------------------------------------------------- 

----���ճ��ָ������Ӧ��ѡȡ��λ��----------------------------------------------
function ZLuaTal_Get_RanPoint(s1)
	if not ZLuaTal_CheckIsNumberTable(s1,0) then return end 
	local js,ron1
	ron1= math.random()                
	---print("---------------------------")     ---$$$$������$$$$-----
	---print("Now the random Num is:",ron1) 	---$$$$������$$$$-----
  local p1=ZLuaTal_Chance_Norm(s1)
	for js=1,table.getn(p1) do
          if ron1<=p1[js] then 
		    ---print("So We Choose:",js) 		---$$$$������$$$$-----
    	  		return js
		  		end
	end
	return 1
end

----��������ԭ��ѡ��------------------------------------------------------------
function ZLuaTal_Make_AllChoise(t,prof,Talisman_Lvl,origin)
  if not ZLuaTal_CheckIsNumberTable(t,0) then return end 
	
	local MaxSameSkillColu 	-----ͬһ�ֿ��ܵ������ִ��� 
	local MaxSkillChoise  	-----��Ҫ��������ѡȡ��Ŀ����� 
	local SameNum           -----ͬһ�ֿ��ܵĵ�ǰ���ִ�����ֵ 
	local SkillLearnDelay 	-----��ϰ���ܿ����ӳٵķ�������  0ʱû���ӳ� 
	local MaxPosLvl					-----�������ܵ���󼶱�
	MaxSameSkillColu,MaxSkillChoise,SameNum,SkillLearnDelay,MaxPosLvl = ZLuaTal_SkillSetInit()

	local kk,pp,qq
	local TrueSkillChoise		---ʵ��ѡȡ�ļ����������
	local SkillNumChanceList={} ---ʵ��ѡȡ������Ŀ�ĸ�������
	local Mchoise={}
	
  if prof==7 then
  	local r = math.random()
    if origin==0 then
    	if Talisman_Lvl==0 then
     			Mchoise={2,4,6}
     	elseif Talisman_Lvl==1 then
     			if r < 0.4 then
     			    Mchoise={2,3,4,5,6}
    	    else
     			    Mchoise={2,3,4,6}
     	    end
     	end
    elseif origin==1 then
    	if r < 0.1 then
     			Mchoise={2,3,4,5,6}
    	elseif r < 0.5 then
     			Mchoise={2,3,4,6}
    	else
     	Mchoise={2,4,6}
     	end
    elseif origin==2 then
    	if r < 0.01 then
     			Mchoise={2,3,4,5,6}
    	elseif r < 0.1 then
     			Mchoise={2,3,4,6}
    	else
     	Mchoise={2,4,6}
     	end
    elseif origin==3 then
    	if r < 0.4 then
     			Mchoise={2,3,4,5,6}
    	else
     			Mchoise={2,3,4,6}
     	end
    else
    	Mchoise={2,4,6}
    end
  else
  	for kk=1,MaxSkillChoise do
   		SkillNumChanceList[kk]=2*kk*kk-42*kk+184
  	end
  	TrueSkillChoise=ZLuaTal_Get_RanPoint(SkillNumChanceList) 
  	for pp=1,TrueSkillChoise do
			Mchoise[pp]=ZLuaTal_Get_RanPoint(t)	
			if pp~=1 then 
				for qq=1,pp-1 do
					if Mchoise[pp]==Mchoise[qq] then 
						SameNum=SameNum+1
						if SameNum>MaxSameSkillColu then 
							Mchoise[pp]=65536 
							SameNum=1
						else 
						end 
					else 
					end 
				end
	  	end 
		end
	end
	---ZLuaTal_Special_Print(Mchoise)
	return Mchoise
end

----��table��ts����Ѱ�ҵ�һ��t��λ�ú�------------------------------------------
function ZLuaTal_FindSkillReqInfo(t,ts)
	if type(t)~="number" or type(ts)~="table" then return end
 	local jt
 	for jt=1,table.getn(ts) do
   		if ts[jt]==t then return jt end
  end
	return
end
----��a,b������aΪ0�����ú�------------------------------------------------------
function ZLuaTal_SkillMakeSeq(a,b)
	if type(a)~="table" or type(b)~="table" then return a,b end 
	if table.getn(a)~=table.getn(b) then return a,b end 
	local xnum,ynum
	local c={}
	local d={}
	for xnum=1,table.getn(a) do
			c[xnum]=0
			d[xnum]=0	
	end 
	ynum=1
	for xnum=1,table.getn(a) do
		if a[xnum]~=0 then
			c[ynum]=a[xnum]
			d[ynum]=b[xnum]
			ynum=ynum+1
		end 
	end 	 	
	return c,d
end 