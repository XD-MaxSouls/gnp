---//�����漰��������--------------------------------------------------------------
---//���ݲ�����ض���
---//ZLuaTalisman_CombineAppendix() Ѫ������ý����
---//ZLuaTalismanEnchantEx()				���˺�һ���Թ�ħ��ý����
---//ZLuaTalismanEnchantSkillCid()	���ܹ�ħ��ý����
---//ZLuaTalismanEnchantSkillEx()		���ܹ�ħ�м�����ģ����Ϣ����
---//ZLuaTalismanSkillsExInfo(skillid,nowaddtimes) ���ܵĿɵ��Ӹ��ʲ���

---//����Ѫ����غ���
---//ZLuaTalisman_Combine(id1,id2,talisman1,talisman2,cid,output)	����Ѫ��������
---//*����1��id,����2��id,����1����,����2����,������ý,�������*
---//ZLuaTalisman_CombineRechooseSkill(id1,id2,talisman1,talisman2,output) ����Ѫ���н��������������＼��
---//*����1��id,����2��id,����1����,����2����,�������*
---//ZLuaTalisman_BurnMatrix(a_id,b_id,aqlevel,bqlevel,atime,btime,atime_ex,btime_ex,cid) ȷ��Ѫ����ʽ�Ĳ���ԭ��
---//*����1��id,����2��id,����1���󼶱�,����2���󼶱�,����1������ʱ��,����2������ʱ��,����1���ɴ�ʱ��,����2���ɴ�ʱ��,������ý*
---//ZLuaTalisman_GrowMatrix(ischangespeciality,thetypewesee,mothertalisman,fathertalisman,baseid,foodid,combineindex,cid) Ѫ����ɵĵ�λ�ɳ���
---//*�Ƿ񽻻����ɳ�����,�ɼ��ĳɳ�����,ĸ������(��),��������(����),��Ϊʳ��ķ���id,Ѫ��ֵ��λ����,������ý*
---//ZLuaSpecialTalismanOut(output,origin) ����Ѫ�����������ﺯ��
---//*Ѫ������,������Դͷ��־(��������Ϊ����ʱ)*
---//ZLuaTalisman_GrowChanceDeal(thetype,mothertalisman,PriceBase,PriceAdd,combineindex)
---//*�ɳ�����,ĸ������(��),ĸ��������ֵ,����������ֵ(ʳ���ֵ),Ѫ��ֵ��λ����*
---//ZLuaTalisman_CombineValueGrow(alevel,blevel,aqlevel,bqlevel,combineindex,multi)Ѫ����������ֵ����
---//*����1����,����2����,����1���󼶱�,����2���󼶱�,Ѫ��ֵ��λ����,�ӳ�ϵ��*
---//ZLuaTalisman_IsIgnoreChange(combineindex) Ѫ��ֵ�Ƿ��Ʒ���½�
---//*Ѫ��ֵ��λ����*
---//ZLuaTalAttributeValue(talisman,growDir18) ���������ļ�ֵ
---//*��������,��������(�ɳ�����)*
---//ZLuaTalisman_FoodAttributeValue(foodtalisman,foodid,nowmothertalismanlimit) ��������ʳ��ļ�ֵ
---//*��������,��������id,��ǰ�������ĵ�λ*
---//ZLuaTalisman_TimeMatrix(atime,btime,atime_ex,btime_ex,cid)����Ѫ��ʱ����������Ĺ�ϵ������
---//*����1������ʱ��,����2������ʱ��,����1���ɴ�ʱ��,����2���ɴ�ʱ��,������ý*


---//������ħ��غ���
---//EnchantTalismans(id,talisman1,cid,output)	������ħ������
---//*����1��id,����1����,������ý,�������*
---//ZLuaTalisman_EnchantBotEx(id,talisman1,cid,output,exid,bufftype) ���˺�һ��ħ������
---//*����1��id,����1����,������ý,�������,���˺�һ��������id,���˺�һ��������type*
---//ZLuaTalChangeExt(talisman) �������������˺�һ���͹�ħ�Ĵ���
---//*��������*-
---//ZLuaExistInTalismanEnchantEx(cid,level) �����뵱ǰ����ƥ������˺�һ��ý
---//*������ý,��������*
---//ZLuaExistInTalismanEnchantSkillCid(cid) ���Ҽ��ܹ�ħ��ý��Ӧ��Ϣ
---//*������ý*
---//ZLuaTalisman_EnchantSkill(id, talisman1,cid,output,prof,enchantskilltype,enchantskillid,maxsameskillcol) ���Ӽ��ܹ�ħ
---//*����1��id,����1����,������ý,�������,������ְҵ������Ϣ,���ܹ�ħ����,���ܹ�ħ����id,��������ͬ�ּ�������*
---//ZLuaTalisman_ChooseEnchantSkill(prof,num,maxsamecol)	������������＼��(���������ض�ѡȡ)
---//*��������ְҵ,ѡȡ��������,��������ͬ�ּ�������*
---//*ZLuaTalisman_ChooseTalismanSkill(TalismanSkillID) �������Я���ķ�������
---//*��������ID*

---//������ø�������
---//ZLuaTalisman_CombineValueDeal(combinevalue) �������Ѫ��ֵ��λ����
---//*��ǰѪ��ֵ*
---//ZLuaTalisman_GetProfInfo(id,SkillNoSeq)	��ȡ����ְҵ������Ϣ
---//*����id,�����ĸ������＼������*

---//�㷨��������
---//ZLuaCheckOutNums(ilist,vlist,klist,num,maxsamecol)
---//*��ilist(����)�а���vlist(����)�涨��Ȩ��ѡȡnum������,��һһ��Ӧklist�е�����,ÿ������������maxsamcol��*
---//ZLuaTalisman_InsertSkillSeq(insertid,ilist,vlist,talismanskillprof)
---//*��insertid����ilist��,vlistΪilistһһ��Ӧ����,talismanskillprof����ְҵ

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
---//������������̬������
function ZLuaTalisman_CombineAppendix()
	local Temp_TalismanIDs=ZLuaTalAvailableTalismans()
	local cidmatrix={}
	---//cidusetype: 	1:��ͨ������;2:�������������;3:���������;4:���˺�һ��ħ��;5:�����������＼���л���ý
	---//cidmulti: 		�������������ר�����ԣ�ȷ�ϷŴ���
	---//cidwithlvl:	���������ר�����ԣ���������������Ч(0:ͨ��/1:1��/2:15��/3:45��/4:75��)
	---//cidcombo:		���������ר�����ԣ������������ϵĿ�����
	
	cidmatrix[6338]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["QY_15_LiuHeJing"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[6336]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["GW_15_ZhuQueYin"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[6339]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["TY_15_LunHuiZhu"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[6337]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["HH_15_SheXinLing"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[17855]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["GD_15_XueYuGuPian"].tmplID,cidmulti=1,cidcombo=0}	
	cidmatrix[6342]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["QY_75_QiXingJian"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[6340]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["GW_75_SiLingFan"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[6343]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["TY_75_JinGangChu"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[6341]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["HH_75_DuoQingHuan"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[17856]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["GD_75_PoSha"].tmplID,cidmulti=1,cidcombo=0}	
	cidmatrix[6470]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_75_YuJingPing"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[6471]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_45_ShenMuShai"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[6472]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_75_WanDuDing"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[6344]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_75_ShanHeShan"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[13359]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_75_LingLongTa"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[7920]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=0}
	
	cidmatrix[10914]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["QY_105_HuPoZhuLing"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[10917]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_105_JinHuLu"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[10918]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["HH_105_QianMeiLian"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[10919]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["GW_105_QianKunQingGuangJie"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[10921]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_105_JiuLongShenHuoZhao"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[10922]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["TY_105_RuYiQianKunDai"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[17858]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["GD_105_QianDuGu"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[10915]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_105_YinYangJing"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[15867]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_105_LuoHunDeng"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[17833]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_105_ZhenShanHeShan"].tmplID,cidmulti=1,cidcombo=0}
	
	cidmatrix[10916]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_135_PanLongFan"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[10920]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_135_WuLongLun"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[20094]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_135_FanTianYin"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[20501]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_135_ChangMingDeng"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[10923]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_135_SheHun"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[10924]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_145_ShiXueZhu"].tmplID,cidmulti=1,cidcombo=0}	
	cidmatrix[10925]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_145_ShiHun"].tmplID,cidmulti=1,cidcombo=0}		

	cidmatrix[13798]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["GW_135_TianMoZhi"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[13797]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["QY_135_RuoXue"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[13795]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["HH_135_BaJiYouLong"].tmplID,cidmulti=1,cidcombo=0}	
	cidmatrix[13796]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["TY_135_LiuDaoShengMie"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[17859]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["GD_135_GuiQing"].tmplID,cidmulti=1,cidcombo=0}				

	cidmatrix[6345]={cidwithlvl=0,cidusetype=2,cidloveid=Temp_TalismanIDs["US_75_ShanHeShan"].tmplID,cidmulti=20,cidcombo=0}
	cidmatrix[6346]={cidwithlvl=0,cidusetype=2,cidloveid=Temp_TalismanIDs["US_75_ShanHeShan"].tmplID,cidmulti=100,cidcombo=0}
		
	cidmatrix[7921]={cidwithlvl=1,cidusetype=3,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=0.1}
	cidmatrix[7922]={cidwithlvl=15,cidusetype=3,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=0.1}
	cidmatrix[7923]={cidwithlvl=45,cidusetype=3,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=0.1}
	cidmatrix[7924]={cidwithlvl=75,cidusetype=3,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=0.1}
	
	cidmatrix[7926]={cidwithlvl=1,cidusetype=3,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=0.55}
	cidmatrix[7929]={cidwithlvl=15,cidusetype=3,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=0.55}
	cidmatrix[7933]={cidwithlvl=45,cidusetype=3,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=0.55}
	cidmatrix[7936]={cidwithlvl=75,cidusetype=3,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=0.55}
	
	cidmatrix[7927]={cidwithlvl=1,cidusetype=3,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=3.33}
	cidmatrix[7930]={cidwithlvl=15,cidusetype=3,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=3.33}
	cidmatrix[7934]={cidwithlvl=45,cidusetype=3,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=3.33}
	cidmatrix[7938]={cidwithlvl=75,cidusetype=3,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=3.33}
	
	cidmatrix[7928]={cidwithlvl=1,cidusetype=3,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=999}
	cidmatrix[7932]={cidwithlvl=15,cidusetype=3,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=999}
	cidmatrix[7935]={cidwithlvl=45,cidusetype=3,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=999}
	cidmatrix[7939]={cidwithlvl=75,cidusetype=3,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=999}	

	cidmatrix[11385]={cidwithlvl=1,cidusetype=4,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=999}
	cidmatrix[11386]={cidwithlvl=1,cidusetype=4,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=999}
	cidmatrix[11387]={cidwithlvl=1,cidusetype=4,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=999}
	cidmatrix[11388]={cidwithlvl=1,cidusetype=4,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=999}	
	cidmatrix[11389]={cidwithlvl=1,cidusetype=4,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=999}
	cidmatrix[11390]={cidwithlvl=1,cidusetype=4,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=999}	
	
	cidmatrix[11735]={cidwithlvl=1,cidusetype=5,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=999}
	
	cidmatrix[0]={cidwithlvl=-1,cidusetype=-1,cidloveid=0,cidmulti=1,cidcombo=0}
	return cidmatrix
end

---//����Ѫ������������Ĵ�����
function ZLuaSpecialTalismanOut(output,origin)
	local SpecialOut={}
	
	SpecialOut[4712]=50---//ɽ����
	SpecialOut[4006]=100---//�����
	SpecialOut[5527]=200---//�λ��ؽ�
	SpecialOut[5528]=100---//����֮�� 
	SpecialOut[5529]=100---//������ϻ�
	SpecialOut[5525]=100---//����֮�� 
	SpecialOut[5526]=100---//��â֮�� 
	SpecialOut[5536]=10
	SpecialOut[5537]=10
	SpecialOut[5538]=10
	SpecialOut[5539]=10---//�������ҳA/B/C/D
	SpecialOut[5540]=100---//���벻����
	SpecialOut[5541]=100---//Ʈ����Ͳ��
	SpecialOut[7792]=100---//����˫��
	SpecialOut[6428]=150---//��Ȼ��ף��
	SpecialOut[6451]=160---//����һ��
	SpecialOut[6452]=100---//��������
	SpecialOut[6453]=100---//����ָ��
	SpecialOut[6455]=100---//��ˮָ��
	SpecialOut[6456]=100---//��ħָ��
	SpecialOut[6454]=100---//����ָ��
	SpecialOut[6449]=100---//�þþ�ָ��
	SpecialOut[6450]=100---//�Ҿ��ǰ�ָ��
	local allspecialout={}
	local allspecialchance={}
	for i,v in pairs(SpecialOut) do 
		table.insert(allspecialout,i)
		table.insert(allspecialchance,v)
	end 
	local outid
	outid=allspecialout[ZLuaTal_Get_RanPoint(allspecialchance)]
	if ZLuaTalExistInTmplIDs(outid) then
		output:CreateItem(outid)			
		ZLuaTalInit(outid,output,origin)	
	else 
		output:CreateItem(outid)
	end 

end 
---//����Ѫ��ʱ����������Ĺ�ϵ������
function ZLuaTalisman_TimeMatrix(atime,btime,atime_ex,btime_ex,cid)
	if atime==btime and atime_ex==btime_ex then 
		return 1
	else 
		return 1
	end 		
end 
---//��������ֵ�븽�Ӹ��ʵĹ�ϵ������[Ѫ��]
function ZLuaTalisman_CombineValueDeal(combinevalue)
	if type(combinevalue)~="number" then return end 
	local combineindex
	if combinevalue>=0 and combinevalue<=10 then 
			combineindex=1  
	elseif combinevalue>10 and combinevalue<=60 then 
			combineindex=2 
	elseif combinevalue>60 and combinevalue<=180 then 
			combineindex=3
	elseif combinevalue>180 and combinevalue<=720 then 
			combineindex=4
	elseif combinevalue>720 and combinevalue<=1800 then 
			combineindex=5
	elseif combinevalue>1800 and combinevalue<=3200 then 
			combineindex=6
	elseif combinevalue>3200 and combinevalue<=5600 then 
			combineindex=7
	elseif combinevalue>5600 and combinevalue<=9999 then 
			combineindex=8
	elseif combinevalue>9999 and combinevalue<=23456 then 
			combineindex=9
	elseif combinevalue>23456 then 
			combineindex=10	
	else
			combineindex=1	
	end 	
	return combineindex
end 
---//���������в�������������ֵ�Ĺ�ϵ[Ѫ��]---------------------------------------------------------------
function ZLuaTalisman_CombineValueGrow(alevel,blevel,aqlevel,bqlevel,combineindex,multi)
	if type(alevel)~="number" or type(blevel)~="number" then return end
	if type(aqlevel)~="number" or type(bqlevel)~="number" then return end
	
	local c1,c2,c3,CombineValueGrowth
		c1=2
		c2=(aqlevel+bqlevel)/16+0.004*aqlevel*bqlevel
		c3=0
		CombineValueGrowth=math.floor(multi*(c1+c2+c3)/combineindex)
		if CombineValueGrowth>=25 then CombineValueGrowth=25 end
		if CombineValueGrowth<=0 then CombineValueGrowth=0 end 
		return CombineValueGrowth
end 
---//ȡ�� ��������ļ�ֵ[Ѫ��] 
function ZLuaTalAttributeValue(talisman,growDir18)
	local grade = ZLuaTalGetGradeFromValue(growDir18,talisman) or 1
	local price = 1
	if grade <= 5 then 
		price = 0.1
	elseif grade <= 10 then
		price = 0.5
	elseif grade <= 15 then
		price = 0.8
	elseif grade <= 17 then
		price = 1
	elseif grade>17 and grade<=50 then
		price = math.max(1, 0.019592*grade^3 - 1.0611*grade^2 + 19.79*grade - 125 )
	elseif grade>50 and grade<80 then
		price = math.max(1, 40*grade-1200)
	else
			price=1
	end
	return price
end
---//���� ����ʳ��ļ�ֵ[Ѫ��]-------------------------------------------------------------------------------
function ZLuaTalisman_FoodAttributeValue(foodtalisman,foodid,nowmothertalismanlimit)
	local TalismanQlevelPrice
	local reqlvl=ZLuaTalExistInTmplIDs(foodid)
	---//���ݱ��巨����λ����ʳ���ֵ
	if nowmothertalismanlimit>50 then 
		if reqlvl==1 then 
				TalismanQlevelPrice={1,2,8}
		elseif reqlvl==15 then 
				TalismanQlevelPrice={1,3,12}
		else
				TalismanQlevelPrice={1,4,20}
		end 
	else
		if reqlvl==1 then 
				TalismanQlevelPrice={1,20,80}
		elseif reqlvl==15 then 
				TalismanQlevelPrice={1,30,120}
		else
				TalismanQlevelPrice={1,40,200}
		end 
	end 
	
	local RmbVsGold=1/10
	local A=ZLuaTalAvailableTalismans()
	local BuyPrice			
	---//�����
	for i,v in pairs(A) do 
		if v.tmplID==foodid then 
			BuyPrice=v.price
		end 
	end 
	
	local dataIndex=ZLuaTalDataIndex()
	local QlevelPrice=TalismanQlevelPrice[foodtalisman:QueryData(dataIndex["quality"])+1]		
	---//Ʒ�ʼ�
	local zorigin=ZLuaTalClientOrigins()
	if foodtalisman:QueryData(dataIndex["origin"])==zorigin["quest"] then 
		QlevelPrice=1
	end 
	
	local UpLevelPrice=ZLuaTalFeedCost(foodtalisman:QueryLevel())
	---//������
	local TalismanFoodPrice=BuyPrice*QlevelPrice*RmbVsGold+UpLevelPrice
	local TalismanFeedLevelPrice=UpLevelPrice
	
	return TalismanFoodPrice,TalismanFeedLevelPrice
end 
---//��������˭�Լ��ɳ����������[Ѫ��]
function ZLuaTalisman_BurnMatrix(a_id,b_id,aqlevel,bqlevel,atime,btime,atime_ex,btime_ex,cid)
---//A����ID,B����ID,A�����󼶱�,B�����󼶱�,A������ʱ��1,B������ʱ��1,A������ʱ��2,B������ʱ��2,������
	local tempcid=ZLuaTalisman_CombineAppendix()	
	local timemulti,amulti,bmulti,cmulti,dmulti,outtype
	---//ʱ��Ӱ�����ӣ���A.B.C.D���ֲ����ӳɣ�
	---//�����outtype(1,2,3,4,5�ֱ����
	---//1:����ΪA���� A�ɳ���
	---//2:����ΪB���� B�ɳ���
	---//3:����Ϊ���ⷨ�� ��������Ʒ	
	---//4:����ΪA���� B�ɳ���
	---//5:����ΪB���� A�ɳ���
	local outtypelist={}
	timemulti=ZLuaTalisman_TimeMatrix(atime,btime,atime_ex,btime_ex,cid)
	
	if cid==0 then			---//��cid��� 
		if aqlevel>bqlevel then 
			---//ʱ����Ӱ�� Ŀǰδ�趨
			amulti=timemulti
			if bqlevel==1 then amulti=aqlevel end 
			bmulti=1
		elseif aqlevel==bqlevel then 
			amulti=1
			bmulti=1
		else 
			amulti=1
			bmulti=timemulti
		end 			
			outtypelist[1]={600,400,(aqlevel+bqlevel)/150}
			outtype=ZLuaTal_Get_RanPoint(outtypelist[1])
	else 										---//��cid���
		if tempcid[cid].cidusetype==1  then
			if tempcid[cid].cidloveid==a_id then outtype=1	end 		
			if outtype<=0 or outtype>2 then outtype=1 end
		elseif tempcid[cid].cidusetype==2 then  
			outtypelist[2]={600,400,(aqlevel+bqlevel)*tempcid[cid].cidmulti/150}
			outtype=ZLuaTal_Get_RanPoint(outtypelist[2])
			if outtype<=0 or outtype>3 then outtype=1 end 
		elseif tempcid[cid].cidusetype==3 then 
			outtypelist[3]={10,0,0,tempcid[cid].cidcombo,0}
			outtype=ZLuaTal_Get_RanPoint(outtypelist[3])
			if tempcid[cid].cidcombo>=900 then outtype=4 end 
			if outtype==2 or outtype==3 or outtype>4 or outtype<=0 then outtype=1 end  
		end 
	end 
	return outtype
end 
---//��������ֵ�����Ƿ�ֵ��˽���[Ѫ��]
function ZLuaTalisman_IsIgnoreChange(combineindex)
	if type(combineindex)~="number" or combineindex<0 or combineindex>10 then combineindex=0 end 
	local ingorechance={2*combineindex,100-2*combineindex}
	local c=0
	if ZLuaTal_Get_RanPoint(ingorechance)==1 then
		c=1
	end 	 
		return c
end 
---//���ݼ۸�Ⱦ�����λ�ɳ�[Ѫ��]
function ZLuaTalisman_GrowChanceDeal(thetype,mothertalisman,PriceBase,PriceAdd,combineindex)
		local GrowDirection={-2,-1,0,1,2,3,4}
		local HowManyGrow
		local GrowChance1={}
			GrowChance1[1]={0.01,0.1,0.84,0.05,0,0,0}
			GrowChance1[2]={0,0.01,0.85,0.14,0,0,0}
			GrowChance1[3]={0,0,0.819,0.18,0.001,0,0}
			GrowChance1[4]={0,0,0.78,0.22,0,0,0}
			GrowChance1[5]={0,0,0.74,0.26,0,0,0}
			GrowChance1[6]={0,0,0.7,0.3,0,0,0}
			GrowChance1[7]={0,0,0.51,0.49,0,0,0}
			GrowChance1[8]={0,0,0.46,0.54,0,0,0}
			GrowChance1[9]={0,0,0.41,0.59,0,0,0}
			GrowChance1[10]={0,0,0.33,0.66,0.01,0,0}
			GrowChance1[11]={0,0,0.325,0.66,0.015,0,0}
			GrowChance1[12]={0,0,0.32,0.66,0.02,0,0}
			GrowChance1[13]={0,0,0.315,0.66,0.025,0,0}
			GrowChance1[14]={0,0,0.31,0.66,0.03,0,0}
			GrowChance1[15]={0,0,0.304,0.66,0.035,0.001,0}
			GrowChance1[16]={0,0,0.296,0.66,0.04,0.004,0}
			GrowChance1[17]={0,0,0.288,0.66,0.045,0.007,0}
			GrowChance1[18]={0,0,0.28,0.66,0.05,0.01,0}
			GrowChance1[19]={0,0,0.272,0.66,0.055,0.013,0}
			GrowChance1[20]={0,0,0.173,0.75,0.06,0.016,0.001}
			GrowChance1[21]={0,0,0.162,0.75,0.065,0.019,0.004}
			GrowChance1[22]={0,0,0.151,0.75,0.07,0.022,0.007}
			GrowChance1[23]={0,0,0.14,0.75,0.075,0.025,0.01}
			GrowChance1[24]={0,0,0.129,0.75,0.08,0.028,0.013}
			GrowChance1[25]={0,0,0.118,0.75,0.085,0.031,0.016}
			GrowChance1[26]={0,0,0.107,0.75,0.09,0.034,0.019}
			GrowChance1[27]={0,0,0.096,0.75,0.095,0.037,0.022}
			GrowChance1[28]={0,0,0.085,0.75,0.1,0.04,0.025}
			GrowChance1[29]={0,0,0.074,0.75,0.105,0.043,0.028}
			GrowChance1[30]={0,0,0,0.813,0.11,0.046,0.031}
			GrowChance1[31]={0,0,0,0.802,0.115,0.049,0.034}
			GrowChance1[32]={0,0,0,0.791,0.12,0.052,0.037}
			GrowChance1[33]={0,0,0,0.78,0.125,0.055,0.04}
			GrowChance1[34]={0,0,0,0.769,0.13,0.058,0.043}
			GrowChance1[35]={0,0,0,0.758,0.135,0.061,0.046}
			GrowChance1[36]={0,0,0,0.747,0.14,0.064,0.049}
			GrowChance1[37]={0,0,0,0.736,0.145,0.067,0.052}
			GrowChance1[38]={0,0,0,0.725,0.15,0.07,0.055}
			GrowChance1[39]={0,0,0,0.714,0.155,0.073,0.058}
			GrowChance1[40]={0,0,0,0.703,0.16,0.076,0.061}
		local GrowChance2={}
			GrowChance2[1]={0,0,0.5,0.499,0.001,0,0}
			GrowChance2[2]={0,0.01,0.45,0.538,0.002,0,0}
			GrowChance2[3]={0,0,0.4,0.597,0.003,0,0}
			GrowChance2[4]={0,0,0.35,0.646,0.004,0,0}
			GrowChance2[5]={0,0,0.3,0.695,0.005,0,0}
			GrowChance2[6]={0,0,0.25,0.744,0.006,0,0}
			GrowChance2[7]={0,0,0.2,0.793,0.007,0,0}
			GrowChance2[8]={0,0,0.15,0.842,0.008,0,0}
			GrowChance2[9]={0,0,0.1,0.891,0.009,0,0}
			GrowChance2[10]={0,0,0.05,0.939,0.01,0.001,0}
			GrowChance2[11]={0,0,0.05,0.937,0.011,0.002,0}
			GrowChance2[12]={0,0,0.05,0.935,0.012,0.003,0}
			GrowChance2[13]={0,0,0.05,0.933,0.013,0.004,0}
			GrowChance2[14]={0,0,0.05,0.931,0.014,0.005,0}
			GrowChance2[15]={0,0,0.05,0.929,0.015,0.006,0}
			GrowChance2[16]={0,0,0.05,0.927,0.016,0.007,0}
			GrowChance2[17]={0,0,0.05,0.925,0.017,0.008,0}
			GrowChance2[18]={0,0,0.05,0.923,0.018,0.009,0}
			GrowChance2[19]={0,0,0.05,0.921,0.019,0.01,0}
			GrowChance2[20]={0,0,0.05,0.918,0.02,0.011,0.001}
			GrowChance2[21]={0,0,0,0.965,0.021,0.012,0.002}
			GrowChance2[22]={0,0,0,0.962,0.022,0.013,0.003}
			GrowChance2[23]={0,0,0,0.959,0.023,0.014,0.004}
			GrowChance2[24]={0,0,0,0.956,0.024,0.015,0.005}
			GrowChance2[25]={0,0,0,0.953,0.025,0.016,0.006}
			GrowChance2[26]={0,0,0,0.95,0.026,0.017,0.007}
			GrowChance2[27]={0,0,0,0.947,0.027,0.018,0.008}
			GrowChance2[28]={0,0,0,0.944,0.028,0.019,0.009}
			GrowChance2[29]={0,0,0,0.941,0.029,0.02,0.01}
			GrowChance2[30]={0,0,0,0.938,0.03,0.021,0.011}
			GrowChance2[31]={0,0,0,0.935,0.031,0.022,0.012}
			GrowChance2[32]={0,0,0,0.932,0.032,0.023,0.013}
			GrowChance2[33]={0,0,0,0.929,0.033,0.024,0.014}
			GrowChance2[34]={0,0,0,0.926,0.034,0.025,0.015}
			GrowChance2[35]={0,0,0,0.923,0.035,0.026,0.016}
			GrowChance2[36]={0,0,0,0.92,0.036,0.027,0.017}
			GrowChance2[37]={0,0,0,0.917,0.037,0.028,0.018}
			GrowChance2[38]={0,0,0,0.914,0.038,0.029,0.019}
			GrowChance2[39]={0,0,0,0.911,0.039,0.03,0.02}
			GrowChance2[40]={0,0,0,0.908,0.04,0.031,0.021}
		local GrowChance3={}
			GrowChance3[1]={0.05,0.12,0.75,0.03,0,0,0}
			GrowChance3[2]={0,0.1,0.7,0.2,0,0,0}
			GrowChance3[3]={0,0.09,0.7,0.21,0,0,0}
			GrowChance3[4]={0,0.08,0.68,0.24,0,0,0}
			GrowChance3[5]={0,0.07,0.66,0.27,0,0,0}
			GrowChance3[6]={0,0.06,0.64,0.3,0,0,0}
			GrowChance3[7]={0,0.05,0.62,0.33,0,0,0}
			GrowChance3[8]={0,0.04,0.6,0.36,0,0,0}
			GrowChance3[9]={0,0.03,0.58,0.39,0,0,0}
			GrowChance3[10]={0,0.02,0.56,0.42,0.001,0,0}
			GrowChance3[11]={0,0.01,0.540,0.448,0.002,0,0}
			GrowChance3[12]={0,0,0.52,0.477,0.003,0,0}
			GrowChance3[13]={0,0,0.50,0.496,0.004,0,0}
			GrowChance3[14]={0,0,0.48,0.515,0.005,0,0}
			GrowChance3[15]={0,0,0.46,0.533,0.006,0.001,0}
			GrowChance3[16]={0,0,0.44,0.551,0.007,0.002,0}
			GrowChance3[17]={0,0,0.42,0.569,0.008,0.003,0}
			GrowChance3[18]={0,0,0.40,0.587,0.009,0.004,0}
			GrowChance3[19]={0,0,0.38,0.605,0.01,0.005,0}
			GrowChance3[20]={0,0,0.36,0.623,0.011,0.006,0}
			GrowChance3[21]={0,0,0.34,0.641,0.012,0.007,0}
			GrowChance3[22]={0,0,0.32,0.659,0.013,0.008,0}
			GrowChance3[23]={0,0,0.30,0.677,0.014,0.009,0}
			GrowChance3[24]={0,0,0.28,0.6958,0.015,0.01,0}
			GrowChance3[25]={0,0,0.26,0.713,0.016,0.011,0}
			GrowChance3[26]={0,0,0.24,0.731,0.017,0.012,0}
			GrowChance3[27]={0,0,0.22,0.749,0.018,0.013,0}
			GrowChance3[28]={0,0,0.20,0.766,0.019,0.014,0.001}
			GrowChance3[29]={0,0,0.18,0.783,0.02,0.015,0.002}
			GrowChance3[30]={0,0,0.16,0.80,0.021,0.016,0.003}
			GrowChance3[31]={0,0,0.14,0.817,0.022,0.017,0.004}
			GrowChance3[32]={0,0,0.12,0.834,0.023,0.018,0.005}
			GrowChance3[33]={0,0,0.10,0.851,0.024,0.019,0.006}
			GrowChance3[34]={0,0,0.08,0.868,0.025,0.02,0.007}
			GrowChance3[35]={0,0,0.06,0.885,0.026,0.021,0.008}
			GrowChance3[36]={0,0,0.04,0.902,0.027,0.022,0.009}
			GrowChance3[37]={0,0,0.02,0.919,0.028,0.023,0.01}
			GrowChance3[38]={0,0,0,0.936,0.029,0.024,0.011}
			GrowChance3[39]={0,0,0,0.933,0.03,0.025,0.012}
			GrowChance3[40]={0,0,0,0.93,0.031,0.026,0.013}
			
		local GrowChanceIndex=math.floor(10*PriceAdd/PriceBase)
		if GrowChanceIndex<=0 then GrowChanceIndex=1 end 
		if GrowChanceIndex>40 then GrowChanceIndex=40 end 
		if PriceBase<800 then 
			if PriceAdd>=33.33 then 
				HowManyGrow=GrowDirection[ZLuaTal_Get_RanPoint(GrowChance2[GrowChanceIndex])]
			else 
				HowManyGrow=GrowDirection[ZLuaTal_Get_RanPoint(GrowChance1[GrowChanceIndex])]
			end 
		else 
				GrowChanceIndex=math.floor(80*PriceAdd/PriceBase)
				if GrowChanceIndex<=0 then GrowChanceIndex=1 end 
				if GrowChanceIndex>40 then GrowChanceIndex=40 end 
				HowManyGrow=GrowDirection[ZLuaTal_Get_RanPoint(GrowChance3[GrowChanceIndex])]
		end 	
		if ZLuaTalGetGradeFromValue(thetype,mothertalisman)<=24 and HowManyGrow<1 then 
			HowManyGrow=1
		end 
		if ZLuaTalGetGradeFromValue(thetype,mothertalisman)<=17 then 
			HowManyGrow=2
		end 

		if HowManyGrow<0 then 
			if ZLuaTalisman_IsIgnoreChange(combineindex)==1 then HowManyGrow=0 end 
			---//����ֵ���½�
		end 
		return HowManyGrow
end 

---//���ݳɳ���������ɳ����ٵ�����[Ѫ��]
function ZLuaTalisman_GrowMatrix(ischangespeciality,thetypewesee,mothertalisman,fathertalisman,baseid,foodid,combineindex,cid)
---//�Ƿ��ǽ�������,���ǿ����ĳɳ�����,ĸ������,��������,��Ϊʳ�﷨����id,��ǰ����ֵ����,������
	local T_dataindex=ZLuaTalDataIndex()
	local WhatTypeWeGrow,HowManyGrow
	local RandomDirectionID={T_dataindex["grow_hp"],T_dataindex["grow_mp"],T_dataindex["grow_damage_low"],
														T_dataindex["grow_damage_high"],T_dataindex["grow_resis_stun"],T_dataindex["grow_resis_sleep"],
															T_dataindex["grow_resis_silence"],T_dataindex["grow_resis_weakness"],T_dataindex["grow_resis_enlace"]}
	local RandomDirectionChance={100,200,150,100,100,150,100,100,150}
	
	if thetypewesee==0 or type(thetypewesee)~="number" then
		---//�޳ɳ����������ѡȡ�ɳ�����
		WhatTypeWeGrow=RandomDirectionID[ZLuaTal_Get_RanPoint(RandomDirectionChance)]
	else 
		---//����ͬ�ɳ�������ͬ
 		WhatTypeWeGrow=thetypewesee
	end 		
	
	local temp_cid=ZLuaTalisman_CombineAppendix()
	if ischangespeciality==1 or temp_cid[cid].cidusetype==3 then
	---//����"��������"ʱ�����
		HowManyGrow=0
	else 
		local TalismanBasePrice,TalismanFoodPrice
	 	---//��������۸��Լ�ʳ�﷨���۸�
		TalismanBasePrice=ZLuaTalAttributeValue(mothertalisman,WhatTypeWeGrow)
		
		---ȡ�ñ��巨���ĵ�λ��Ϣ
		local GradeLimitsList=ZLuaTalGradesUpperLimit(baseid)
		local growdirection=ZluaTransRiseIndex(WhatTypeWeGrow)
		local mothertalismanlimit
		if mothertalisman:QueryData(growdirection)~=nil then
			mothertalismanlimit=GradeLimitsList[ZLuaTalTransIndex(WhatTypeWeGrow)]+mothertalisman:QueryData(growdirection)
		else mothertalismanlimit=GradeLimitsList[ZLuaTalTransIndex(WhatTypeWeGrow)]
		end
		local nowmothertalismanlimit=ZLuaTalGetGradeFromValue(WhatTypeWeGrow,mothertalisman)
		if nowmothertalismanlimit>mothertalismanlimit then nowmothertalismanlimit=mothertalismanlimit end 
				
		TalismanFoodPrice,_=ZLuaTalisman_FoodAttributeValue(fathertalisman,foodid,nowmothertalismanlimit)
		HowManyGrow=ZLuaTalisman_GrowChanceDeal(WhatTypeWeGrow,mothertalisman,TalismanBasePrice,TalismanFoodPrice,combineindex)
	end 	
		return thetypewesee,WhatTypeWeGrow,HowManyGrow
		---//�����ĳɳ����ͣ��ɳ����ͣ��ɳ�����
end

---//��������(Ѫ��)������
function ZLuaTalisman_Combine(id1,id2,talisman1,talisman2,cid,output)
local dataIndex=ZLuaTalDataIndex()
---�������IDΪ�ɱ�����Ѫ��ʧ��
  if talisman1:QueryData(dataIndex["is_fly"]) == 1 or talisman2:QueryData(dataIndex["is_fly"]) == 1 then 
  output:CreateItem(-1)
	
	else
	local iswronginput,isspecialoutput
	local iswronginput=0		---���������־
	local isspecialoutput=0	---���������־
	
	---//ȡ�÷���A�ͷ���B�ľ����ȼ�
	local NowAlevel=talisman1:QueryLevel()
	local NowBlevel=talisman2:QueryLevel()

	---//ȡ�÷���A�ͷ���B�ĵ�ǰ������ʱ��
	local NowATime=talisman1:QueryData(dataIndex["birth_hour12"])		
	local NowBTime=talisman2:QueryData(dataIndex["birth_hour12"])	
	local NowATimeEx=talisman1:QueryData(dataIndex["birth_min3"])		
	local NowBTimeEx=talisman2:QueryData(dataIndex["birth_min3"])	

	---//ȡ�÷���A�ͷ���B��Qlevel(���󼶱�	
	local NowAReqLvl=ZLuaTalExistInTmplIDs(id1)
	local NowBReqLvl=ZLuaTalExistInTmplIDs(id2)
	
	---//ȡ�÷���A�ͷ���B�ĳɳ�ȡ��
	local NowAGrowType=talisman1:QueryData(dataIndex["speciality"]) or 0 	
	local NowBGrowType=talisman2:QueryData(dataIndex["speciality"]) or 0	

	---//����cid����������ķ��ش���
	local temp_cid=ZLuaTalisman_CombineAppendix()
	
	-- ����ý����ֹѪ��
	if type(cid) ~= "number" or cid == 0 then
		iswronginput = 1
		output:CreateItem(-1)
	end

	-- ��ͨѪ������ý����������ƥ�䣬��ֹѪ��	
	if temp_cid[cid].cidusetype == 1 and temp_cid[cid].cidloveid ~= id1 then
		iswronginput=1
		output:CreateItem(-1)
	end 

	-- ����Ѫ������ý����������ƥ�䣬��ֹѪ��	
	if temp_cid[cid].cidusetype == 3 and temp_cid[cid].cidwithlvl ~= NowAReqLvl then
		if temp_cid[cid].cidwithlvl ~= 75 or NowAReqLvl < 75 then
			iswronginput=1
			output:CreateItem(-1)
		end
	end 
	
	---//��������ħ���������
	if temp_cid[cid].cidusetype==4 then
		iswronginput=1
		output:CreateItem(-1)
	elseif temp_cid[cid].cidusetype==5 then
		iswronginput=1
		ZLuaTalisman_CombineRechooseSkill(id1,id2,talisman1,talisman2,output)
	end 

	---//��ǰ�����������������
	local NowOrigin=ZLuaTalServerOrigins()
		
	---//��ǰ����ֵ���ڸ���Ӱ��	
	local CombineIndex,CombineValueGrow	
	CombineIndex=ZLuaTalisman_CombineValueDeal(output:GetCombineValue())	
	
	if iswronginput~=1 then 	
				local WhatObjectTypeWeGet,WhatIDWeGet,WhatGrowTypeWeSee,mothertalisman,fathertalisman,ischangespeciality,foodid
				WhatObjectTypeWeGet=ZLuaTalisman_BurnMatrix(id1,id2,NowAReqLvl,NowBReqLvl,NowATime,NowBTime,NowATimeEx,NowBTimeEx,cid)
				if WhatObjectTypeWeGet==1 then 
					 WhatIDWeGet=id1
					 WhatGrowTypeWeSee=NowAGrowType
					 mothertalisman=talisman1
					 fathertalisman=talisman2
					 foodid=id2					 		
					 ischangespeciality=0
					
				elseif WhatObjectTypeWeGet==2 then 
					 WhatIDWeGet=id2
					 WhatGrowTypeWeSee=NowBGrowType 
					 mothertalisman=talisman2
					 fathertalisman=talisman1
					 foodid=id1
					 ischangespeciality=0	 
				elseif WhatObjectTypeWeGet==3 then 
					---//�������
					 WhatIDWeGet=ZLuaSpecialTalismanOut(output,NowOrigin["combine"])
					 ischangespeciality=0	 
					 isspecialoutput=1
				elseif WhatObjectTypeWeGet==4 then 
					 WhatIDWeGet=id1
					 WhatGrowTypeWeSee=NowBGrowType
					 mothertalisman=talisman1
					 fathertalisman=talisman2
					 foodid=id2
					 ischangespeciality=1
				elseif WhatObjectTypeWeGet==5 then 
					 WhatIDWeGet=id2
					 WhatGrowTypeWeSee=NowAGrowType
					 mothertalisman=talisman2
					 fathertalisman=talisman1
					 foodid=id1
					 ischangespeciality=1
				end 
			
			---���������������������趨��ر仯
			if isspecialoutput~=1 then 
						
				local WhatTypeWeGrow,HowManyGrow
				WhatGrowTypeWeSee,WhatTypeWeGrow,HowManyGrow=ZLuaTalisman_GrowMatrix(ischangespeciality,WhatGrowTypeWeSee,mothertalisman,fathertalisman,WhatIDWeGet,foodid,CombineIndex,cid)
				---��۳ɳ�����,ʵ�ʳɳ�����,ʵ�ʳɳ�����
				
				output:CreateItem(WhatIDWeGet)	
				
				---������������� ��������
				---if WhatIDWeGet==id1 then 
					---output:InheritCombineLevel(true)		
				---end  
								
				---���ݵ�ǰ�������͵���Ӧ��λ�ĳɳ�������Ϣ
				local GradeLimitsList=ZLuaTalGradesUpperLimit(WhatIDWeGet)
				local growdirection=ZluaTransRiseIndex(WhatTypeWeGrow)
				local Limit
				if mothertalisman:QueryData(growdirection)~=nil then
					Limit=GradeLimitsList[ZLuaTalTransIndex(WhatTypeWeGrow)]+mothertalisman:QueryData(growdirection)
				else limit=GradeLimitsList[ZLuaTalTransIndex(WhatTypeWeGrow)]
				end
					
								
				---����������ʹ��ݳɳ���Ϣ
				local nowLimit=ZLuaTalGetGradeFromValue(WhatTypeWeGrow,mothertalisman)
				if nowLimit>=Limit and ischangespeciality~=1 then 	
						output:CreateItem(-1)
				else 
			  		ZLuaTalCombineInit(WhatIDWeGet,WhatGrowTypeWeSee,WhatTypeWeGrow,HowManyGrow,mothertalisman,output)
				---//ID,��۳ɳ�����,ʵ�ʳɳ�����,ʵ�ʳɳ�����,ĸ������,output				
				
				---�趨Ѫ����ؼ�¼
			 		if ischangespeciality==0 then ---(�ɳ����͸���������Ѫ����ؼ�¼)
			 				output:UpdateData(dataIndex["combine_times"],output:QueryData(dataIndex["combine_times"])+1)
			 				local feedcosta,feedcostb=ZLuaTalisman_FoodAttributeValue(fathertalisman,foodid,nowLimit)
			 				output:UpdateData(dataIndex["feed_cost"],output:QueryData(dataIndex["feed_cost"])+feedcosta)
			 				output:UpdateData(dataIndex["feed_level_cost"],output:QueryData(dataIndex["feed_level_cost"])+feedcostb)
			 			if fathertalisman:QueryData(dataIndex["quality"])==0 then 
			 				output:UpdateData(dataIndex["feed_baoqi"],output:QueryData(dataIndex["feed_baoqi"])+1)
			 			elseif fathertalisman:QueryData(dataIndex["quality"])==1 then 
			 				output:UpdateData(dataIndex["feed_xianpin"],output:QueryData(dataIndex["feed_xianpin"])+1)
			 			elseif fathertalisman:QueryData(dataIndex["quality"])==2 then 
			 				output:UpdateData(dataIndex["feed_shenpin"],output:QueryData(dataIndex["feed_shenpin"])+1)
			 			else 
			 			
			 			end 
			 		end 
				end 
	 	 	end 
				----����֮������ֵ�仯,�κ����������Ѫ��ֵ
				if ischangespeciality==0 then 
					CombineValueGrow=ZLuaTalisman_CombineValueGrow(NowAlevel,NowBlevel,NowAReqLvl,NowBReqLvl,CombineIndex,1)
					output:SetCombineValue(output:GetCombineValue()+CombineValueGrow)
				end 
		 end
	end 
end 

----------------���������ļ����л���������------------------------------------------------------------
function ZLuaTalisman_CombineRechooseSkill(id1,id2,talisman1,talisman2,output)
	local SkillNoSeqA={}				
	local SkillReqLvlSeqA={}
	
	local SkillNoSeqB={}				
	local SkillReqLvlSeqB={}
	
	local SkillNoSeqResult={}
	local SkillReqLvlSeqResult={}
	local SkillBurnChance={}
	
	local TrueSkillNumA=0
	local TrueSkillNumB=0
	local maxsamecol=1
	
	---//��÷���Ŀǰ�ļ�����Ϣ(����ID,�������󼶱�,ʵ�ʼ�����Ŀ)
	local dataIndex=ZLuaTalDataIndex()
		SkillNoSeqA[1]=talisman1:QueryData(dataIndex["addon_1_id"])
		SkillReqLvlSeqA[1]=talisman1:QueryData(dataIndex["addon_1_learn_level"])
		SkillNoSeqA[2]=talisman1:QueryData(dataIndex["addon_2_id"])
		SkillReqLvlSeqA[2]=talisman1:QueryData(dataIndex["addon_2_learn_level"])
		SkillNoSeqA[3]=talisman1:QueryData(dataIndex["addon_3_id"])
		SkillReqLvlSeqA[3]=talisman1:QueryData(dataIndex["addon_3_learn_level"])
		SkillNoSeqA[4]=talisman1:QueryData(dataIndex["addon_4_id"])
		SkillReqLvlSeqA[4]=talisman1:QueryData(dataIndex["addon_4_learn_level"])
		SkillNoSeqA[5]=talisman1:QueryData(dataIndex["addon_5_id"])
		SkillReqLvlSeqA[5]=talisman1:QueryData(dataIndex["addon_5_learn_level"])
		SkillNoSeqA[6]=talisman1:QueryData(dataIndex["addon_6_id"])
		SkillReqLvlSeqA[6]=talisman1:QueryData(dataIndex["addon_6_learn_level"])
		
		SkillNoSeqB[1]=talisman2:QueryData(dataIndex["addon_1_id"])
		SkillReqLvlSeqB[1]=talisman2:QueryData(dataIndex["addon_1_learn_level"])
		SkillNoSeqB[2]=talisman2:QueryData(dataIndex["addon_2_id"])
		SkillReqLvlSeqB[2]=talisman2:QueryData(dataIndex["addon_2_learn_level"])
		SkillNoSeqB[3]=talisman2:QueryData(dataIndex["addon_3_id"])
		SkillReqLvlSeqB[3]=talisman2:QueryData(dataIndex["addon_3_learn_level"])
		SkillNoSeqB[4]=talisman2:QueryData(dataIndex["addon_4_id"])
		SkillReqLvlSeqB[4]=talisman2:QueryData(dataIndex["addon_4_learn_level"])
		SkillNoSeqB[5]=talisman2:QueryData(dataIndex["addon_5_id"])
		SkillReqLvlSeqB[5]=talisman2:QueryData(dataIndex["addon_5_learn_level"])
		SkillNoSeqB[6]=talisman2:QueryData(dataIndex["addon_6_id"])
		SkillReqLvlSeqB[6]=talisman2:QueryData(dataIndex["addon_6_learn_level"])

	local talismanprofA,talismanskillprofA=ZLuaTalisman_GetProfInfo(id1,SkillNoSeqA)
	local talismanprofB,talismanskillprofB=ZLuaTalisman_GetProfInfo(id2,SkillNoSeqB)
	---//���ݷ�����id�ͷ������Ѿ����ڵļ��ܾ�����������������
	
	for i=1,6 do
		if SkillNoSeqB[i]~=0 and SkillReqLvlSeqB[i]~=0 and type(SkillReqLvlSeqB[i])=="number" then 
			TrueSkillNumB=TrueSkillNumB+1
		end 
	end	
	
	if talismanskillprofA==talismanskillprofB then 
			---//ȥ��A��ͬB��ͬ�ļ���			
			for j=1,6 do
				for k=1,6 do
					if SkillNoSeqA[j]==SkillNoSeqB[k] and SkillNoSeqA[j]~=0 then
						SkillNoSeqA[j]=0
						SkillReqLvlSeqA[j]=0
					end 
				end 
			end 		
			---//��A��B�ϲ�
			for m=1,6 do
				SkillNoSeqB[6+m]=SkillNoSeqA[m]
				SkillReqLvlSeqB[6+m]=SkillReqLvlSeqA[m]
				SkillNoSeqA[m]=0
				SkillReqLvlSeqA[m]=0
			end 

			for n=1,12 do
				if SkillNoSeqB[n]~=0 then 
					SkillBurnChance[n]=100
				else
					SkillBurnChance[n]=0
				end 		
			end 	
			 
			SkillNoSeqA,SkillReqLvlSeqA=ZLuaCheckOutNums(SkillNoSeqB,SkillBurnChance,SkillReqLvlSeqB,TrueSkillNumB,maxsamecol)	
			
			output:CreateItem(id1)
			for _,index in pairs(dataIndex) do
				output:UpdateData(index,talisman1:QueryData(index))
			end
			output:UpdateData(dataIndex["addon_1_id"],SkillNoSeqA[1]or 0)		
			output:UpdateData(dataIndex["addon_1_learn_level"],SkillReqLvlSeqA[1]or 0)
			output:UpdateData(dataIndex["addon_2_id"],SkillNoSeqA[2]or 0)		
			output:UpdateData(dataIndex["addon_2_learn_level"],SkillReqLvlSeqA[2]or 0)
			output:UpdateData(dataIndex["addon_3_id"],SkillNoSeqA[3]or 0)		
			output:UpdateData(dataIndex["addon_3_learn_level"],SkillReqLvlSeqA[3]or 0)
			output:UpdateData(dataIndex["addon_4_id"],SkillNoSeqA[4]or 0)		
			output:UpdateData(dataIndex["addon_4_learn_level"],SkillReqLvlSeqA[4]or 0)
			output:UpdateData(dataIndex["addon_5_id"],SkillNoSeqA[5]or 0)		
			output:UpdateData(dataIndex["addon_5_learn_level"],SkillReqLvlSeqA[5]or 0)
			output:UpdateData(dataIndex["addon_6_id"],SkillNoSeqA[6]or 0)		
			output:UpdateData(dataIndex["addon_6_learn_level"],SkillReqLvlSeqA[6]or 0)
			output:InheritCombineExp(true)
			ZLuaTalRebuild(output,id1)

	else 
		output:CreateItem(-1)
	end 
	
end 
-------------------------------------------------------------------------------------------------------------------
---//���˺�һ���Թ�ħ��ý�ķָ���
--------------------------------------------------
function ZLuaTalismanEnchantEx()
	local TalismanEnchantEx={}
		---��������ID,��ýID,buff����,��Ӧ��������
		TalismanEnchantEx[909]={cidid=11385,bufftype=1,exlevel=1}
		TalismanEnchantEx[910]={cidid=11385,bufftype=1,exlevel=2}
		TalismanEnchantEx[911]={cidid=11385,bufftype=1,exlevel=3}
		TalismanEnchantEx[912]={cidid=11385,bufftype=1,exlevel=4}
		TalismanEnchantEx[913]={cidid=11385,bufftype=1,exlevel=5}
		TalismanEnchantEx[914]={cidid=11385,bufftype=1,exlevel=6}
		TalismanEnchantEx[915]={cidid=11385,bufftype=1,exlevel=7}
		TalismanEnchantEx[916]={cidid=11385,bufftype=1,exlevel=8}
		TalismanEnchantEx[917]={cidid=11385,bufftype=1,exlevel=9}
		TalismanEnchantEx[918]={cidid=11385,bufftype=1,exlevel=10}
		TalismanEnchantEx[919]={cidid=11385,bufftype=1,exlevel=11}
		TalismanEnchantEx[920]={cidid=11385,bufftype=1,exlevel=12}
		TalismanEnchantEx[921]={cidid=11385,bufftype=1,exlevel=13}
		TalismanEnchantEx[922]={cidid=11385,bufftype=1,exlevel=14}
		TalismanEnchantEx[923]={cidid=11385,bufftype=1,exlevel=15}
		TalismanEnchantEx[924]={cidid=11385,bufftype=1,exlevel=16}
		TalismanEnchantEx[925]={cidid=11385,bufftype=1,exlevel=17}
		TalismanEnchantEx[926]={cidid=11385,bufftype=1,exlevel=18}
		TalismanEnchantEx[927]={cidid=11385,bufftype=1,exlevel=19}
		TalismanEnchantEx[928]={cidid=11385,bufftype=1,exlevel=20}
		TalismanEnchantEx[929]={cidid=11385,bufftype=1,exlevel=21}
		TalismanEnchantEx[930]={cidid=11385,bufftype=1,exlevel=22}
		TalismanEnchantEx[931]={cidid=11385,bufftype=1,exlevel=23}
		TalismanEnchantEx[932]={cidid=11385,bufftype=1,exlevel=24}
		TalismanEnchantEx[933]={cidid=11385,bufftype=1,exlevel=25}
		TalismanEnchantEx[934]={cidid=11385,bufftype=1,exlevel=26}
		TalismanEnchantEx[935]={cidid=11385,bufftype=1,exlevel=27}
		TalismanEnchantEx[936]={cidid=11385,bufftype=1,exlevel=28}
		TalismanEnchantEx[937]={cidid=11385,bufftype=1,exlevel=29}
		TalismanEnchantEx[938]={cidid=11385,bufftype=1,exlevel=30}
		TalismanEnchantEx[939]={cidid=11386,bufftype=2,exlevel=1}
		TalismanEnchantEx[940]={cidid=11386,bufftype=2,exlevel=2}
		TalismanEnchantEx[941]={cidid=11386,bufftype=2,exlevel=3}
		TalismanEnchantEx[942]={cidid=11386,bufftype=2,exlevel=4}
		TalismanEnchantEx[943]={cidid=11386,bufftype=2,exlevel=5}
		TalismanEnchantEx[944]={cidid=11386,bufftype=2,exlevel=6}
		TalismanEnchantEx[945]={cidid=11386,bufftype=2,exlevel=7}
		TalismanEnchantEx[946]={cidid=11386,bufftype=2,exlevel=8}
		TalismanEnchantEx[947]={cidid=11386,bufftype=2,exlevel=9}
		TalismanEnchantEx[948]={cidid=11386,bufftype=2,exlevel=10}
		TalismanEnchantEx[949]={cidid=11386,bufftype=2,exlevel=11}
		TalismanEnchantEx[950]={cidid=11386,bufftype=2,exlevel=12}
		TalismanEnchantEx[951]={cidid=11386,bufftype=2,exlevel=13}
		TalismanEnchantEx[952]={cidid=11386,bufftype=2,exlevel=14}
		TalismanEnchantEx[953]={cidid=11386,bufftype=2,exlevel=15}
		TalismanEnchantEx[954]={cidid=11386,bufftype=2,exlevel=16}
		TalismanEnchantEx[955]={cidid=11386,bufftype=2,exlevel=17}
		TalismanEnchantEx[956]={cidid=11386,bufftype=2,exlevel=18}
		TalismanEnchantEx[957]={cidid=11386,bufftype=2,exlevel=19}
		TalismanEnchantEx[958]={cidid=11386,bufftype=2,exlevel=20}
		TalismanEnchantEx[959]={cidid=11386,bufftype=2,exlevel=21}
		TalismanEnchantEx[960]={cidid=11386,bufftype=2,exlevel=22}
		TalismanEnchantEx[961]={cidid=11386,bufftype=2,exlevel=23}
		TalismanEnchantEx[962]={cidid=11386,bufftype=2,exlevel=24}
		TalismanEnchantEx[963]={cidid=11386,bufftype=2,exlevel=25}
		TalismanEnchantEx[964]={cidid=11386,bufftype=2,exlevel=26}
		TalismanEnchantEx[965]={cidid=11386,bufftype=2,exlevel=27}
		TalismanEnchantEx[966]={cidid=11386,bufftype=2,exlevel=28}
		TalismanEnchantEx[967]={cidid=11386,bufftype=2,exlevel=29}
		TalismanEnchantEx[968]={cidid=11386,bufftype=2,exlevel=30}
		TalismanEnchantEx[969]={cidid=11387,bufftype=3,exlevel=1}
		TalismanEnchantEx[970]={cidid=11387,bufftype=3,exlevel=2}
		TalismanEnchantEx[971]={cidid=11387,bufftype=3,exlevel=3}
		TalismanEnchantEx[972]={cidid=11387,bufftype=3,exlevel=4}
		TalismanEnchantEx[973]={cidid=11387,bufftype=3,exlevel=5}
		TalismanEnchantEx[974]={cidid=11387,bufftype=3,exlevel=6}
		TalismanEnchantEx[975]={cidid=11387,bufftype=3,exlevel=7}
		TalismanEnchantEx[976]={cidid=11387,bufftype=3,exlevel=8}
		TalismanEnchantEx[977]={cidid=11387,bufftype=3,exlevel=9}
		TalismanEnchantEx[978]={cidid=11387,bufftype=3,exlevel=10}
		TalismanEnchantEx[979]={cidid=11387,bufftype=3,exlevel=11}
		TalismanEnchantEx[980]={cidid=11387,bufftype=3,exlevel=12}
		TalismanEnchantEx[981]={cidid=11387,bufftype=3,exlevel=13}
		TalismanEnchantEx[982]={cidid=11387,bufftype=3,exlevel=14}
		TalismanEnchantEx[983]={cidid=11387,bufftype=3,exlevel=15}
		TalismanEnchantEx[984]={cidid=11387,bufftype=3,exlevel=16}
		TalismanEnchantEx[985]={cidid=11387,bufftype=3,exlevel=17}
		TalismanEnchantEx[986]={cidid=11387,bufftype=3,exlevel=18}
		TalismanEnchantEx[987]={cidid=11387,bufftype=3,exlevel=19}
		TalismanEnchantEx[988]={cidid=11387,bufftype=3,exlevel=20}
		TalismanEnchantEx[989]={cidid=11387,bufftype=3,exlevel=21}
		TalismanEnchantEx[990]={cidid=11387,bufftype=3,exlevel=22}
		TalismanEnchantEx[991]={cidid=11387,bufftype=3,exlevel=23}
		TalismanEnchantEx[992]={cidid=11387,bufftype=3,exlevel=24}
		TalismanEnchantEx[993]={cidid=11387,bufftype=3,exlevel=25}
		TalismanEnchantEx[994]={cidid=11387,bufftype=3,exlevel=26}
		TalismanEnchantEx[995]={cidid=11387,bufftype=3,exlevel=27}
		TalismanEnchantEx[996]={cidid=11387,bufftype=3,exlevel=28}
		TalismanEnchantEx[997]={cidid=11387,bufftype=3,exlevel=29}
		TalismanEnchantEx[998]={cidid=11387,bufftype=3,exlevel=30}
		TalismanEnchantEx[999]={cidid=11388,bufftype=4,exlevel=1}
		TalismanEnchantEx[1000]={cidid=11388,bufftype=4,exlevel=2}
		TalismanEnchantEx[1001]={cidid=11388,bufftype=4,exlevel=3}
		TalismanEnchantEx[1002]={cidid=11388,bufftype=4,exlevel=4}
		TalismanEnchantEx[1003]={cidid=11388,bufftype=4,exlevel=5}
		TalismanEnchantEx[1004]={cidid=11388,bufftype=4,exlevel=6}
		TalismanEnchantEx[1005]={cidid=11388,bufftype=4,exlevel=7}
		TalismanEnchantEx[1006]={cidid=11388,bufftype=4,exlevel=8}
		TalismanEnchantEx[1007]={cidid=11388,bufftype=4,exlevel=9}
		TalismanEnchantEx[1008]={cidid=11388,bufftype=4,exlevel=10}
		TalismanEnchantEx[1009]={cidid=11388,bufftype=4,exlevel=11}
		TalismanEnchantEx[1010]={cidid=11388,bufftype=4,exlevel=12}
		TalismanEnchantEx[1011]={cidid=11388,bufftype=4,exlevel=13}
		TalismanEnchantEx[1012]={cidid=11388,bufftype=4,exlevel=14}
		TalismanEnchantEx[1013]={cidid=11388,bufftype=4,exlevel=15}
		TalismanEnchantEx[1014]={cidid=11388,bufftype=4,exlevel=16}
		TalismanEnchantEx[1015]={cidid=11388,bufftype=4,exlevel=17}
		TalismanEnchantEx[1016]={cidid=11388,bufftype=4,exlevel=18}
		TalismanEnchantEx[1017]={cidid=11388,bufftype=4,exlevel=19}
		TalismanEnchantEx[1018]={cidid=11388,bufftype=4,exlevel=20}
		TalismanEnchantEx[1019]={cidid=11388,bufftype=4,exlevel=21}
		TalismanEnchantEx[1020]={cidid=11388,bufftype=4,exlevel=22}
		TalismanEnchantEx[1021]={cidid=11388,bufftype=4,exlevel=23}
		TalismanEnchantEx[1022]={cidid=11388,bufftype=4,exlevel=24}
		TalismanEnchantEx[1023]={cidid=11388,bufftype=4,exlevel=25}
		TalismanEnchantEx[1024]={cidid=11388,bufftype=4,exlevel=26}
		TalismanEnchantEx[1025]={cidid=11388,bufftype=4,exlevel=27}
		TalismanEnchantEx[1026]={cidid=11388,bufftype=4,exlevel=28}
		TalismanEnchantEx[1027]={cidid=11388,bufftype=4,exlevel=29}
		TalismanEnchantEx[1028]={cidid=11388,bufftype=4,exlevel=30}
		TalismanEnchantEx[1029]={cidid=11389,bufftype=5,exlevel=1}
		TalismanEnchantEx[1030]={cidid=11389,bufftype=5,exlevel=2}
		TalismanEnchantEx[1031]={cidid=11389,bufftype=5,exlevel=3}
		TalismanEnchantEx[1032]={cidid=11389,bufftype=5,exlevel=4}
		TalismanEnchantEx[1033]={cidid=11389,bufftype=5,exlevel=5}
		TalismanEnchantEx[1034]={cidid=11389,bufftype=5,exlevel=6}
		TalismanEnchantEx[1035]={cidid=11389,bufftype=5,exlevel=7}
		TalismanEnchantEx[1036]={cidid=11389,bufftype=5,exlevel=8}
		TalismanEnchantEx[1037]={cidid=11389,bufftype=5,exlevel=9}
		TalismanEnchantEx[1038]={cidid=11389,bufftype=5,exlevel=10}
		TalismanEnchantEx[1039]={cidid=11389,bufftype=5,exlevel=11}
		TalismanEnchantEx[1040]={cidid=11389,bufftype=5,exlevel=12}
		TalismanEnchantEx[1041]={cidid=11389,bufftype=5,exlevel=13}
		TalismanEnchantEx[1042]={cidid=11389,bufftype=5,exlevel=14}
		TalismanEnchantEx[1043]={cidid=11389,bufftype=5,exlevel=15}
		TalismanEnchantEx[1044]={cidid=11389,bufftype=5,exlevel=16}
		TalismanEnchantEx[1045]={cidid=11389,bufftype=5,exlevel=17}
		TalismanEnchantEx[1046]={cidid=11389,bufftype=5,exlevel=18}
		TalismanEnchantEx[1047]={cidid=11389,bufftype=5,exlevel=19}
		TalismanEnchantEx[1048]={cidid=11389,bufftype=5,exlevel=20}
		TalismanEnchantEx[1049]={cidid=11389,bufftype=5,exlevel=21}
		TalismanEnchantEx[1050]={cidid=11389,bufftype=5,exlevel=22}
		TalismanEnchantEx[1051]={cidid=11389,bufftype=5,exlevel=23}
		TalismanEnchantEx[1052]={cidid=11389,bufftype=5,exlevel=24}
		TalismanEnchantEx[1053]={cidid=11389,bufftype=5,exlevel=25}
		TalismanEnchantEx[1054]={cidid=11389,bufftype=5,exlevel=26}
		TalismanEnchantEx[1055]={cidid=11389,bufftype=5,exlevel=27}
		TalismanEnchantEx[1056]={cidid=11389,bufftype=5,exlevel=28}
		TalismanEnchantEx[1057]={cidid=11389,bufftype=5,exlevel=29}
		TalismanEnchantEx[1058]={cidid=11389,bufftype=5,exlevel=30}
		TalismanEnchantEx[1059]={cidid=11390,bufftype=6,exlevel=1}
		TalismanEnchantEx[1060]={cidid=11390,bufftype=6,exlevel=2}
		TalismanEnchantEx[1061]={cidid=11390,bufftype=6,exlevel=3}
		TalismanEnchantEx[1062]={cidid=11390,bufftype=6,exlevel=4}
		TalismanEnchantEx[1063]={cidid=11390,bufftype=6,exlevel=5}
		TalismanEnchantEx[1064]={cidid=11390,bufftype=6,exlevel=6}
		TalismanEnchantEx[1065]={cidid=11390,bufftype=6,exlevel=7}
		TalismanEnchantEx[1066]={cidid=11390,bufftype=6,exlevel=8}
		TalismanEnchantEx[1067]={cidid=11390,bufftype=6,exlevel=9}
		TalismanEnchantEx[1068]={cidid=11390,bufftype=6,exlevel=10}
		TalismanEnchantEx[1069]={cidid=11390,bufftype=6,exlevel=11}
		TalismanEnchantEx[1070]={cidid=11390,bufftype=6,exlevel=12}
		TalismanEnchantEx[1071]={cidid=11390,bufftype=6,exlevel=13}
		TalismanEnchantEx[1072]={cidid=11390,bufftype=6,exlevel=14}
		TalismanEnchantEx[1073]={cidid=11390,bufftype=6,exlevel=15}
		TalismanEnchantEx[1074]={cidid=11390,bufftype=6,exlevel=16}
		TalismanEnchantEx[1075]={cidid=11390,bufftype=6,exlevel=17}
		TalismanEnchantEx[1076]={cidid=11390,bufftype=6,exlevel=18}
		TalismanEnchantEx[1077]={cidid=11390,bufftype=6,exlevel=19}
		TalismanEnchantEx[1078]={cidid=11390,bufftype=6,exlevel=20}
		TalismanEnchantEx[1079]={cidid=11390,bufftype=6,exlevel=21}
		TalismanEnchantEx[1080]={cidid=11390,bufftype=6,exlevel=22}
		TalismanEnchantEx[1081]={cidid=11390,bufftype=6,exlevel=23}
		TalismanEnchantEx[1082]={cidid=11390,bufftype=6,exlevel=24}
		TalismanEnchantEx[1083]={cidid=11390,bufftype=6,exlevel=25}
		TalismanEnchantEx[1084]={cidid=11390,bufftype=6,exlevel=26}
		TalismanEnchantEx[1085]={cidid=11390,bufftype=6,exlevel=27}
		TalismanEnchantEx[1086]={cidid=11390,bufftype=6,exlevel=28}
		TalismanEnchantEx[1087]={cidid=11390,bufftype=6,exlevel=29}
		TalismanEnchantEx[1088]={cidid=11390,bufftype=6,exlevel=30}
	return TalismanEnchantEx
end 
-------���Ӽ��ܵ�������Ϣ����(���ܹ�ħ)---------------------------------------------------------
function ZLuaTalismanEnchantSkillEx()
	local SkillsExList={}
			---[��������(��Ӧ����)ID]
			---prof:����ְҵ(0,1,2,3,4,5,6,9=����,����,����,�ϻ�,����,���,����,ͨ��)
			---bornchance:�������󼶱�--��Ӧ�ķ�������
			---replacechance:��������ʲ���
			SkillsExList[337]={prof=9,reqlevel=1,bornchance=720,replacechance=100}---//����:�ػ�
			SkillsExList[338]={prof=9,reqlevel=2,bornchance=720,replacechance=100}---//����:����
			SkillsExList[339]={prof=1,reqlevel=4,bornchance=640,replacechance=120}---//����:׷����
			SkillsExList[340]={prof=1,reqlevel=3,bornchance=640,replacechance=120}---//����:��ħն
			SkillsExList[341]={prof=1,reqlevel=5,bornchance=640,replacechance=120}---//����:���浶
			SkillsExList[342]={prof=1,reqlevel=8,bornchance=640,replacechance=120}---//����:������
			SkillsExList[343]={prof=1,reqlevel=6,bornchance=640,replacechance=120}---//����:��ˮ��
			SkillsExList[344]={prof=1,reqlevel=14,bornchance=560,replacechance=180}---//����:ʧ��ն
			SkillsExList[345]={prof=1,reqlevel=9,bornchance=560,replacechance=180}---//����:Ѹ��ն
			SkillsExList[346]={prof=1,reqlevel=12,bornchance=560,replacechance=180}---//����:����ն
			SkillsExList[347]={prof=1,reqlevel=11,bornchance=560,replacechance=180}---//����:����ն
			SkillsExList[348]={prof=1,reqlevel=10,bornchance=560,replacechance=180}---//����:�ͻ���
			SkillsExList[349]={prof=1,reqlevel=17,bornchance=240,replacechance=240}---//����:��Ѫն
			SkillsExList[350]={prof=1,reqlevel=18,bornchance=240,replacechance=240}---//����:��ħ��
			SkillsExList[351]={prof=1,reqlevel=15,bornchance=240,replacechance=240}---//����:����ն
			SkillsExList[352]={prof=1,reqlevel=20,bornchance=240,replacechance=240}---//����:����ն
			SkillsExList[353]={prof=1,reqlevel=16,bornchance=240,replacechance=240}---//����:������
			SkillsExList[354]={prof=2,reqlevel=3,bornchance=640,replacechance=120}---//����:��ˮ
			SkillsExList[355]={prof=2,reqlevel=6,bornchance=640,replacechance=120}---//����:����
			SkillsExList[356]={prof=2,reqlevel=5,bornchance=640,replacechance=120}---//����:����
			SkillsExList[357]={prof=2,reqlevel=7,bornchance=640,replacechance=120}---//����:��Ѫ
			SkillsExList[358]={prof=2,reqlevel=8,bornchance=640,replacechance=120}---//����:����
			SkillsExList[359]={prof=2,reqlevel=11,bornchance=560,replacechance=180}---//����:�ɻ�
			SkillsExList[360]={prof=2,reqlevel=9,bornchance=560,replacechance=180}---//����:����
			SkillsExList[361]={prof=2,reqlevel=10,bornchance=560,replacechance=180}---//����:����
			SkillsExList[362]={prof=2,reqlevel=12,bornchance=560,replacechance=180}---//����:����
			SkillsExList[363]={prof=2,reqlevel=11,bornchance=560,replacechance=180}---//����:��˼
			SkillsExList[364]={prof=2,reqlevel=16,bornchance=240,replacechance=240}---//����:����
			SkillsExList[365]={prof=2,reqlevel=17,bornchance=240,replacechance=240}---//����:����
			SkillsExList[366]={prof=2,reqlevel=16,bornchance=240,replacechance=240}---//����:���
			SkillsExList[367]={prof=2,reqlevel=15,bornchance=240,replacechance=240}---//����:����
			SkillsExList[368]={prof=2,reqlevel=18,bornchance=240,replacechance=240}---//����:ɽ��
			SkillsExList[369]={prof=3,reqlevel=5,bornchance=640,replacechance=120}---//����:������
			SkillsExList[370]={prof=3,reqlevel=3,bornchance=640,replacechance=120}---//����:������
			SkillsExList[371]={prof=3,reqlevel=6,bornchance=640,replacechance=120}---//����:Ԧ����
			SkillsExList[372]={prof=3,reqlevel=4,bornchance=640,replacechance=120}---//����:��˪����
			SkillsExList[373]={prof=3,reqlevel=8,bornchance=640,replacechance=120}---//����:��Ԫ����
			SkillsExList[374]={prof=3,reqlevel=14,bornchance=560,replacechance=180}---//����:��ħ����
			SkillsExList[375]={prof=3,reqlevel=9,bornchance=560,replacechance=180}---//����:������
			SkillsExList[376]={prof=3,reqlevel=12,bornchance=560,replacechance=180}---//����:���Ʒ籩
			SkillsExList[377]={prof=3,reqlevel=11,bornchance=560,replacechance=180}---//����:��������
			SkillsExList[378]={prof=3,reqlevel=10,bornchance=560,replacechance=180}---//����:��������
			SkillsExList[379]={prof=3,reqlevel=17,bornchance=240,replacechance=240}---//����:ŭ����
			SkillsExList[380]={prof=3,reqlevel=15,bornchance=240,replacechance=240}---//����:���׺䶥
			SkillsExList[381]={prof=3,reqlevel=20,bornchance=240,replacechance=240}---//����:�������
			SkillsExList[382]={prof=3,reqlevel=18,bornchance=240,replacechance=240}---//����:����֮׶
			SkillsExList[383]={prof=3,reqlevel=16,bornchance=240,replacechance=240}---//����:������ŭ
			SkillsExList[384]={prof=4,reqlevel=4,bornchance=640,replacechance=120}---//����:����
			SkillsExList[385]={prof=4,reqlevel=3,bornchance=640,replacechance=120}---//����:��ħ��
			SkillsExList[386]={prof=4,reqlevel=8,bornchance=640,replacechance=120}---//����:ʨ�Ӻ�
			SkillsExList[387]={prof=4,reqlevel=6,bornchance=640,replacechance=120}---//����:�о�
			SkillsExList[388]={prof=4,reqlevel=4,bornchance=640,replacechance=120}---//����:�׽
			SkillsExList[389]={prof=4,reqlevel=10,bornchance=560,replacechance=180}---//����:��Ը
			SkillsExList[390]={prof=4,reqlevel=9,bornchance=560,replacechance=180}---//����:������
			SkillsExList[391]={prof=4,reqlevel=12,bornchance=560,replacechance=180}---//����:��վ�
			SkillsExList[392]={prof=4,reqlevel=14,bornchance=560,replacechance=180}---//����:�ຣ�ޱ�
			SkillsExList[393]={prof=4,reqlevel=11,bornchance=560,replacechance=180}---//����:�Ĵ�Կ�:��
			SkillsExList[394]={prof=4,reqlevel=13,bornchance=240,replacechance=240}---//����:�Ĵ�Կ�:��
			SkillsExList[395]={prof=4,reqlevel=18,bornchance=240,replacechance=240}---//����:ͬ�鼫��
			SkillsExList[396]={prof=4,reqlevel=16,bornchance=240,replacechance=240}---//����:�������
			SkillsExList[397]={prof=4,reqlevel=15,bornchance=240,replacechance=240}---//����:��ħ��
			SkillsExList[398]={prof=4,reqlevel=20,bornchance=240,replacechance=240}---//����:���ͬ��
			SkillsExList[872]={prof=1,reqlevel=21,bornchance=40,replacechance=360}---//����:����¾ɱ
			SkillsExList[873]={prof=1,reqlevel=22,bornchance=40,replacechance=360}---//����:������
			SkillsExList[874]={prof=1,reqlevel=23,bornchance=40,replacechance=360}---//����:������
			SkillsExList[875]={prof=1,reqlevel=24,bornchance=40,replacechance=360}---//����:������ɱ
			SkillsExList[876]={prof=1,reqlevel=26,bornchance=40,replacechance=360}---//����:�Խ���
			SkillsExList[877]={prof=1,reqlevel=27,bornchance=20,replacechance=480}---//����:ħ������
			SkillsExList[878]={prof=1,reqlevel=28,bornchance=20,replacechance=480}---//����:���鷴��
			SkillsExList[879]={prof=2,reqlevel=21,bornchance=40,replacechance=360}---//����:��Ӱ
			SkillsExList[880]={prof=2,reqlevel=22,bornchance=40,replacechance=360}---//����:��ϼ
			SkillsExList[881]={prof=2,reqlevel=23,bornchance=40,replacechance=360}---//����:����
			SkillsExList[882]={prof=2,reqlevel=24,bornchance=40,replacechance=360}---//����:����
			SkillsExList[883]={prof=2,reqlevel=25,bornchance=40,replacechance=360}---//����:����
			SkillsExList[884]={prof=2,reqlevel=27,bornchance=20,replacechance=480}---//����:����
			SkillsExList[885]={prof=2,reqlevel=28,bornchance=20,replacechance=480}---//����:ϧ��
			SkillsExList[886]={prof=3,reqlevel=21,bornchance=40,replacechance=360}---//����:˪��ѩ��
			SkillsExList[887]={prof=3,reqlevel=22,bornchance=40,replacechance=360}---//����:������
			SkillsExList[888]={prof=3,reqlevel=23,bornchance=40,replacechance=360}---//����:���｣��
			SkillsExList[889]={prof=3,reqlevel=24,bornchance=40,replacechance=360}---//����:��ز���
			SkillsExList[890]={prof=3,reqlevel=25,bornchance=40,replacechance=360}---//����:���ӡ
			SkillsExList[891]={prof=3,reqlevel=27,bornchance=20,replacechance=480}---//����:�׹������
			SkillsExList[892]={prof=3,reqlevel=28,bornchance=20,replacechance=480}---//����:������
			SkillsExList[893]={prof=4,reqlevel=21,bornchance=40,replacechance=360}---//����:�黨����
			SkillsExList[894]={prof=4,reqlevel=22,bornchance=40,replacechance=360}---//����:��������
			SkillsExList[895]={prof=4,reqlevel=23,bornchance=40,replacechance=360}---//����:���ѭ��
			SkillsExList[896]={prof=4,reqlevel=24,bornchance=40,replacechance=360}---//����:�����ֻ�
			SkillsExList[897]={prof=4,reqlevel=25,bornchance=40,replacechance=360}---//����:�Ⱥ���Ը
			SkillsExList[898]={prof=4,reqlevel=27,bornchance=20,replacechance=480}---//����:��������
			SkillsExList[899]={prof=4,reqlevel=28,bornchance=20,replacechance=480}---//����:��������
			SkillsExList[900]={prof=1,reqlevel=29,bornchance=20,replacechance=480}---//����:�������
			SkillsExList[901]={prof=1,reqlevel=30,bornchance=20,replacechance=480}---//����:δ��ն
			SkillsExList[902]={prof=2,reqlevel=29,bornchance=20,replacechance=480}---//����:��Ӱ
			SkillsExList[903]={prof=2,reqlevel=30,bornchance=20,replacechance=480}---//����:�绨ѩ��
			SkillsExList[904]={prof=3,reqlevel=29,bornchance=20,replacechance=480}---//����:̫���������
			SkillsExList[905]={prof=3,reqlevel=30,bornchance=20,replacechance=480}---//����:���������
			SkillsExList[906]={prof=4,reqlevel=29,bornchance=20,replacechance=480}---//����:�󷲰���
			SkillsExList[907]={prof=4,reqlevel=30,bornchance=20,replacechance=480}---//����:��������
			SkillsExList[1758]={prof=5,reqlevel=3,bornchance=640,replacechance=120}---//����:�޹�����
			SkillsExList[1759]={prof=5,reqlevel=4,bornchance=640,replacechance=120}---//����:���Ƕ�ɰ
			SkillsExList[1760]={prof=5,reqlevel=5,bornchance=640,replacechance=120}---//����:�Ļ���צ
			SkillsExList[1761]={prof=5,reqlevel=6,bornchance=640,replacechance=120}---//����:���ض�â
			SkillsExList[1762]={prof=5,reqlevel=7,bornchance=640,replacechance=120}---//����:�ɻ�Ѫ��
			SkillsExList[1763]={prof=5,reqlevel=9,bornchance=560,replacechance=180}---//����:��������
			SkillsExList[1764]={prof=5,reqlevel=11,bornchance=560,replacechance=180}---//����:ʴ�Ķ���
			SkillsExList[1765]={prof=5,reqlevel=12,bornchance=560,replacechance=180}---//����:��ɳ��Ӱ
			SkillsExList[1766]={prof=5,reqlevel=14,bornchance=560,replacechance=180}---//����:��Ѫ����
			SkillsExList[1767]={prof=5,reqlevel=13,bornchance=560,replacechance=180}---//����:����а��
			SkillsExList[1768]={prof=5,reqlevel=15,bornchance=240,replacechance=240}---//����:��ɳ����
			SkillsExList[1769]={prof=5,reqlevel=15,bornchance=240,replacechance=240}---//����:Թ����ħ
			SkillsExList[1770]={prof=5,reqlevel=17,bornchance=240,replacechance=240}---//����:�����߹�
			SkillsExList[1771]={prof=5,reqlevel=18,bornchance=240,replacechance=240}---//����:���ǵش�
			SkillsExList[1772]={prof=5,reqlevel=19,bornchance=240,replacechance=240}---//����:�����Ϯ
			SkillsExList[1773]={prof=5,reqlevel=21,bornchance=40,replacechance=360}---//����:Ļ���ɳ
			SkillsExList[1774]={prof=5,reqlevel=23,bornchance=40,replacechance=360}---//����:�ٹ�ࢻ�
			SkillsExList[1775]={prof=5,reqlevel=23,bornchance=40,replacechance=360}---//����:ȼ��ٻ�
			SkillsExList[1776]={prof=5,reqlevel=24,bornchance=40,replacechance=360}---//����:����ʴ��
			SkillsExList[1777]={prof=5,reqlevel=25,bornchance=40,replacechance=360}---//����:ɭ����Ц
			SkillsExList[1778]={prof=5,reqlevel=27,bornchance=20,replacechance=480}---//����:�����
			SkillsExList[1779]={prof=5,reqlevel=28,bornchance=20,replacechance=480}---//����:а�����
			SkillsExList[1780]={prof=5,reqlevel=29,bornchance=20,replacechance=480}---//����:�������
			SkillsExList[1781]={prof=5,reqlevel=30,bornchance=20,replacechance=480}---//����:��ѡ��Թ
	return SkillsExList
end 
-------------------------------------------------------------------------------------------------
----------�������ܹ�ħ��ý������-----------------------------------------------------------------
function ZLuaTalismanEnchantSkillCid()
	local TalismanEnchantSkillCid={}
		---[��ýID]
		---prof:����ְҵ(0,1,2,3,4,5,6,9=����,����,�ϻ�,����,����,���,����,ͨ��)
		---enchantskilltype:��Ӧ���ܹ�ħ����(0=��������;1=�������(ͨ�÷��������ɲ���);2=����������ܹ�ħ;3=�������ܹ�ħ;
		---4=�������＼�ܿɼ�)
		---enchantskillid���Ϊ�������ܹ�ħ,ָ��ļ��ܺ�(�������Ժ�)
		---maxsameskillcol:�����Ϊ�������ܹ�ħ,��������ͬ�ּ��ܳ��ִ���
		TalismanEnchantSkillCid[11681]={prof=9,enchantskilltype=0,enchantskillid=337,maxsameskillcol=1} ---//��������
		
		---//TalismanEnchantSkillCid[11680]={prof=9,enchantskilltype=1,enchantskillid=337,maxsameskillcol=1} ---//ͨ������		
				---//������enchantskilltype=2�ϲ�
			
		TalismanEnchantSkillCid[11676]={prof=1,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->����
		TalismanEnchantSkillCid[11677]={prof=2,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->�ϻ�
		TalismanEnchantSkillCid[11678]={prof=3,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->����
		TalismanEnchantSkillCid[11679]={prof=4,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->����
		TalismanEnchantSkillCid[17832]={prof=5,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->���
				
		TalismanEnchantSkillCid[11572]={prof=9,enchantskilltype=3,enchantskillid=337,maxsameskillcol=1} ---//�ػ�->��ý
		TalismanEnchantSkillCid[11571]={prof=9,enchantskilltype=3,enchantskillid=338,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11577]={prof=1,enchantskilltype=3,enchantskillid=339,maxsameskillcol=1} ---//׷����->��ý
		TalismanEnchantSkillCid[11573]={prof=1,enchantskilltype=3,enchantskillid=340,maxsameskillcol=1} ---//��ħն->��ý
		TalismanEnchantSkillCid[11575]={prof=1,enchantskilltype=3,enchantskillid=341,maxsameskillcol=1} ---//���浶->��ý
		TalismanEnchantSkillCid[11574]={prof=1,enchantskilltype=3,enchantskillid=342,maxsameskillcol=1} ---//������->��ý
		TalismanEnchantSkillCid[11576]={prof=1,enchantskilltype=3,enchantskillid=343,maxsameskillcol=1} ---//��ˮ��->��ý
		TalismanEnchantSkillCid[11580]={prof=1,enchantskilltype=3,enchantskillid=344,maxsameskillcol=1} ---//ʧ��ն->��ý
		TalismanEnchantSkillCid[11582]={prof=1,enchantskilltype=3,enchantskillid=345,maxsameskillcol=1} ---//Ѹ��ն->��ý
		TalismanEnchantSkillCid[11578]={prof=1,enchantskilltype=3,enchantskillid=346,maxsameskillcol=1} ---//����ն->��ý
		TalismanEnchantSkillCid[11581]={prof=1,enchantskilltype=3,enchantskillid=347,maxsameskillcol=1} ---//����ն->��ý
		TalismanEnchantSkillCid[11579]={prof=1,enchantskilltype=3,enchantskillid=348,maxsameskillcol=1} ---//�ͻ���->��ý
		TalismanEnchantSkillCid[11585]={prof=1,enchantskilltype=3,enchantskillid=349,maxsameskillcol=1} ---//��Ѫն->��ý
		TalismanEnchantSkillCid[11586]={prof=1,enchantskilltype=3,enchantskillid=350,maxsameskillcol=1} ---//��ħ��->��ý
		TalismanEnchantSkillCid[11584]={prof=1,enchantskilltype=3,enchantskillid=351,maxsameskillcol=1} ---//����ն->��ý
		TalismanEnchantSkillCid[11587]={prof=1,enchantskilltype=3,enchantskillid=352,maxsameskillcol=1} ---//����ն->��ý
		TalismanEnchantSkillCid[11583]={prof=1,enchantskilltype=3,enchantskillid=353,maxsameskillcol=1} ---//������->��ý
		TalismanEnchantSkillCid[11599]={prof=2,enchantskilltype=3,enchantskillid=354,maxsameskillcol=1} ---//��ˮ->��ý
		TalismanEnchantSkillCid[11601]={prof=2,enchantskilltype=3,enchantskillid=355,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11603]={prof=2,enchantskilltype=3,enchantskillid=356,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11602]={prof=2,enchantskilltype=3,enchantskillid=357,maxsameskillcol=1} ---//��Ѫ->��ý
		TalismanEnchantSkillCid[11600]={prof=2,enchantskilltype=3,enchantskillid=358,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11605]={prof=2,enchantskilltype=3,enchantskillid=359,maxsameskillcol=1} ---//�ɻ�->��ý
		TalismanEnchantSkillCid[11604]={prof=2,enchantskilltype=3,enchantskillid=360,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11606]={prof=2,enchantskilltype=3,enchantskillid=361,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11608]={prof=2,enchantskilltype=3,enchantskillid=362,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11607]={prof=2,enchantskilltype=3,enchantskillid=363,maxsameskillcol=1} ---//��˼->��ý
		TalismanEnchantSkillCid[11613]={prof=2,enchantskilltype=3,enchantskillid=364,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11609]={prof=2,enchantskilltype=3,enchantskillid=365,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11611]={prof=2,enchantskilltype=3,enchantskillid=366,maxsameskillcol=1} ---//���->��ý
		TalismanEnchantSkillCid[11610]={prof=2,enchantskilltype=3,enchantskillid=367,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11612]={prof=2,enchantskilltype=3,enchantskillid=368,maxsameskillcol=1} ---//ɽ��->��ý
		TalismanEnchantSkillCid[11627]={prof=3,enchantskilltype=3,enchantskillid=369,maxsameskillcol=1} ---//������->��ý
		TalismanEnchantSkillCid[11624]={prof=3,enchantskilltype=3,enchantskillid=370,maxsameskillcol=1} ---//������->��ý
		TalismanEnchantSkillCid[11626]={prof=3,enchantskilltype=3,enchantskillid=371,maxsameskillcol=1} ---//Ԧ����->��ý
		TalismanEnchantSkillCid[11625]={prof=3,enchantskilltype=3,enchantskillid=372,maxsameskillcol=1} ---//��˪����->��ý
		TalismanEnchantSkillCid[11623]={prof=3,enchantskilltype=3,enchantskillid=373,maxsameskillcol=1} ---//��Ԫ����->��ý
		TalismanEnchantSkillCid[11630]={prof=3,enchantskilltype=3,enchantskillid=374,maxsameskillcol=1} ---//��ħ����->��ý
		TalismanEnchantSkillCid[11632]={prof=3,enchantskilltype=3,enchantskillid=375,maxsameskillcol=1} ---//������->��ý
		TalismanEnchantSkillCid[11628]={prof=3,enchantskilltype=3,enchantskillid=376,maxsameskillcol=1} ---//���Ʒ籩->��ý
		TalismanEnchantSkillCid[11631]={prof=3,enchantskilltype=3,enchantskillid=377,maxsameskillcol=1} ---//��������->��ý
		TalismanEnchantSkillCid[11629]={prof=3,enchantskilltype=3,enchantskillid=378,maxsameskillcol=1} ---//��������->��ý
		TalismanEnchantSkillCid[11635]={prof=3,enchantskilltype=3,enchantskillid=379,maxsameskillcol=1} ---//ŭ����->��ý
		TalismanEnchantSkillCid[11637]={prof=3,enchantskilltype=3,enchantskillid=380,maxsameskillcol=1} ---//���׺䶥->��ý
		TalismanEnchantSkillCid[11636]={prof=3,enchantskilltype=3,enchantskillid=381,maxsameskillcol=1} ---//�������->��ý
		TalismanEnchantSkillCid[11633]={prof=3,enchantskilltype=3,enchantskillid=382,maxsameskillcol=1} ---//����֮׶->��ý
		TalismanEnchantSkillCid[11634]={prof=3,enchantskilltype=3,enchantskillid=383,maxsameskillcol=1} ---//������ŭ->��ý
		TalismanEnchantSkillCid[11647]={prof=4,enchantskilltype=3,enchantskillid=384,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11648]={prof=4,enchantskilltype=3,enchantskillid=385,maxsameskillcol=1} ---//��ħ��->��ý
		TalismanEnchantSkillCid[11649]={prof=4,enchantskilltype=3,enchantskillid=386,maxsameskillcol=1} ---//ʨ�Ӻ�->��ý
		TalismanEnchantSkillCid[11650]={prof=4,enchantskilltype=3,enchantskillid=387,maxsameskillcol=1} ---//�о�->��ý
		TalismanEnchantSkillCid[11651]={prof=4,enchantskilltype=3,enchantskillid=388,maxsameskillcol=1} ---//�׽->��ý
		TalismanEnchantSkillCid[11653]={prof=4,enchantskilltype=3,enchantskillid=389,maxsameskillcol=1} ---//��Ը->��ý
		TalismanEnchantSkillCid[11652]={prof=4,enchantskilltype=3,enchantskillid=390,maxsameskillcol=1} ---//������->��ý
		TalismanEnchantSkillCid[11654]={prof=4,enchantskilltype=3,enchantskillid=391,maxsameskillcol=1} ---//��վ�->��ý
		TalismanEnchantSkillCid[11655]={prof=4,enchantskilltype=3,enchantskillid=392,maxsameskillcol=1} ---//�ຣ�ޱ�->��ý
		TalismanEnchantSkillCid[11658]={prof=4,enchantskilltype=3,enchantskillid=393,maxsameskillcol=1} ---//�Ĵ�Կ�:��->��ý
		TalismanEnchantSkillCid[11663]={prof=4,enchantskilltype=3,enchantskillid=394,maxsameskillcol=1} ---//�Ĵ�Կ�:��->��ý
		TalismanEnchantSkillCid[11665]={prof=4,enchantskilltype=3,enchantskillid=395,maxsameskillcol=1} ---//ͬ�鼫��->��ý
		TalismanEnchantSkillCid[11659]={prof=4,enchantskilltype=3,enchantskillid=396,maxsameskillcol=1} ---//�������->��ý
		TalismanEnchantSkillCid[11662]={prof=4,enchantskilltype=3,enchantskillid=397,maxsameskillcol=1} ---//��ħ��->��ý
		TalismanEnchantSkillCid[11664]={prof=4,enchantskilltype=3,enchantskillid=398,maxsameskillcol=1} ---//���ͬ��->��ý
		TalismanEnchantSkillCid[11590]={prof=1,enchantskilltype=3,enchantskillid=872,maxsameskillcol=1} ---//����¾ɱ->��ý
		TalismanEnchantSkillCid[11592]={prof=1,enchantskilltype=3,enchantskillid=873,maxsameskillcol=1} ---//������->��ý
		TalismanEnchantSkillCid[11594]={prof=1,enchantskilltype=3,enchantskillid=874,maxsameskillcol=1} ---//������->��ý
		TalismanEnchantSkillCid[11593]={prof=1,enchantskilltype=3,enchantskillid=875,maxsameskillcol=1} ---//������ɱ->��ý
		TalismanEnchantSkillCid[11591]={prof=1,enchantskilltype=3,enchantskillid=876,maxsameskillcol=1} ---//�Խ���->��ý
		TalismanEnchantSkillCid[11597]={prof=1,enchantskilltype=3,enchantskillid=877,maxsameskillcol=1} ---//ħ������->��ý
		TalismanEnchantSkillCid[11596]={prof=1,enchantskilltype=3,enchantskillid=878,maxsameskillcol=1} ---//���鷴��->��ý
		TalismanEnchantSkillCid[11614]={prof=2,enchantskilltype=3,enchantskillid=879,maxsameskillcol=1} ---//��Ӱ->��ý
		TalismanEnchantSkillCid[11616]={prof=2,enchantskilltype=3,enchantskillid=880,maxsameskillcol=1} ---//��ϼ->��ý
		TalismanEnchantSkillCid[11618]={prof=2,enchantskilltype=3,enchantskillid=881,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11615]={prof=2,enchantskilltype=3,enchantskillid=882,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11617]={prof=2,enchantskilltype=3,enchantskillid=883,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11620]={prof=2,enchantskilltype=3,enchantskillid=884,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11622]={prof=2,enchantskilltype=3,enchantskillid=885,maxsameskillcol=1} ---//ϧ��->��ý
		TalismanEnchantSkillCid[11638]={prof=3,enchantskilltype=3,enchantskillid=886,maxsameskillcol=1} ---//˪��ѩ��->��ý
		TalismanEnchantSkillCid[11641]={prof=3,enchantskilltype=3,enchantskillid=887,maxsameskillcol=1} ---//������->��ý
		TalismanEnchantSkillCid[11642]={prof=3,enchantskilltype=3,enchantskillid=888,maxsameskillcol=1} ---//���｣��->��ý
		TalismanEnchantSkillCid[11639]={prof=3,enchantskilltype=3,enchantskillid=889,maxsameskillcol=1} ---//��ز���->��ý
		TalismanEnchantSkillCid[11640]={prof=3,enchantskilltype=3,enchantskillid=890,maxsameskillcol=1} ---//���ӡ->��ý
		TalismanEnchantSkillCid[11643]={prof=3,enchantskilltype=3,enchantskillid=891,maxsameskillcol=1} ---//�׹������->��ý
		TalismanEnchantSkillCid[11646]={prof=3,enchantskilltype=3,enchantskillid=892,maxsameskillcol=1} ---//������->��ý
		TalismanEnchantSkillCid[11669]={prof=4,enchantskilltype=3,enchantskillid=893,maxsameskillcol=1} ---//�黨����->��ý
		TalismanEnchantSkillCid[11667]={prof=4,enchantskilltype=3,enchantskillid=894,maxsameskillcol=1} ---//��������->��ý
		TalismanEnchantSkillCid[11670]={prof=4,enchantskilltype=3,enchantskillid=895,maxsameskillcol=1} ---//���ѭ��->��ý
		TalismanEnchantSkillCid[11668]={prof=4,enchantskilltype=3,enchantskillid=896,maxsameskillcol=1} ---//�����ֻ�->��ý
		TalismanEnchantSkillCid[11666]={prof=4,enchantskilltype=3,enchantskillid=897,maxsameskillcol=1} ---//�Ⱥ���Ը->��ý
		TalismanEnchantSkillCid[11672]={prof=4,enchantskilltype=3,enchantskillid=898,maxsameskillcol=1} ---//��������->��ý
		TalismanEnchantSkillCid[11674]={prof=4,enchantskilltype=3,enchantskillid=899,maxsameskillcol=1} ---//��������->��ý
		TalismanEnchantSkillCid[11595]={prof=1,enchantskilltype=3,enchantskillid=900,maxsameskillcol=1} ---//�������->��ý
		TalismanEnchantSkillCid[11598]={prof=1,enchantskilltype=3,enchantskillid=901,maxsameskillcol=1} ---//δ��ն->��ý
		TalismanEnchantSkillCid[11621]={prof=2,enchantskilltype=3,enchantskillid=902,maxsameskillcol=1} ---//��Ӱ->��ý
		TalismanEnchantSkillCid[11619]={prof=2,enchantskilltype=3,enchantskillid=903,maxsameskillcol=1} ---//�绨ѩ��->��ý
		TalismanEnchantSkillCid[11645]={prof=3,enchantskilltype=3,enchantskillid=904,maxsameskillcol=1} ---//̫���������->��ý
		TalismanEnchantSkillCid[11644]={prof=3,enchantskilltype=3,enchantskillid=905,maxsameskillcol=1} ---//���������->��ý
		TalismanEnchantSkillCid[11671]={prof=4,enchantskilltype=3,enchantskillid=906,maxsameskillcol=1} ---//�󷲰���->��ý
		TalismanEnchantSkillCid[11673]={prof=4,enchantskilltype=3,enchantskillid=907,maxsameskillcol=1} ---//��������->��ý
		TalismanEnchantSkillCid[17862]={prof=5,enchantskilltype=3,enchantskillid=1758,maxsameskillcol=1}---//�޹�����->��ý"
		TalismanEnchantSkillCid[17864]={prof=5,enchantskilltype=3,enchantskillid=1759,maxsameskillcol=1}---//���Ƕ�ɰ->��ý"
		TalismanEnchantSkillCid[17866]={prof=5,enchantskilltype=3,enchantskillid=1760,maxsameskillcol=1}---//�Ļ���צ->��ý"
		TalismanEnchantSkillCid[17867]={prof=5,enchantskilltype=3,enchantskillid=1761,maxsameskillcol=1}---//���ض�â->��ý"
		TalismanEnchantSkillCid[17868]={prof=5,enchantskilltype=3,enchantskillid=1762,maxsameskillcol=1}---//�ɻ�Ѫ��->��ý"
		TalismanEnchantSkillCid[17869]={prof=5,enchantskilltype=3,enchantskillid=1763,maxsameskillcol=1}---//��������->��ý"
		TalismanEnchantSkillCid[17870]={prof=5,enchantskilltype=3,enchantskillid=1764,maxsameskillcol=1}---//ʴ�Ķ���->��ý"
		TalismanEnchantSkillCid[17871]={prof=5,enchantskilltype=3,enchantskillid=1765,maxsameskillcol=1}---//��ɳ��Ӱ->��ý"
		TalismanEnchantSkillCid[17872]={prof=5,enchantskilltype=3,enchantskillid=1766,maxsameskillcol=1}---//��Ѫ����->��ý"
		TalismanEnchantSkillCid[17873]={prof=5,enchantskilltype=3,enchantskillid=1767,maxsameskillcol=1}---//����а��->��ý"
		TalismanEnchantSkillCid[17874]={prof=5,enchantskilltype=3,enchantskillid=1768,maxsameskillcol=1}---//��ɳ����->��ý"
		TalismanEnchantSkillCid[17875]={prof=5,enchantskilltype=3,enchantskillid=1769,maxsameskillcol=1}---//Թ����ħ->��ý"
		TalismanEnchantSkillCid[17876]={prof=5,enchantskilltype=3,enchantskillid=1770,maxsameskillcol=1}---//�����߹�->��ý"
		TalismanEnchantSkillCid[17877]={prof=5,enchantskilltype=3,enchantskillid=1771,maxsameskillcol=1}---//���ǵش�->��ý"
		TalismanEnchantSkillCid[17878]={prof=5,enchantskilltype=3,enchantskillid=1772,maxsameskillcol=1}---//�����Ϯ->��ý"
		TalismanEnchantSkillCid[17879]={prof=5,enchantskilltype=3,enchantskillid=1773,maxsameskillcol=1}---//Ļ���ɳ->��ý"
		TalismanEnchantSkillCid[17880]={prof=5,enchantskilltype=3,enchantskillid=1774,maxsameskillcol=1}---//�ٹ�ࢻ�->��ý"
		TalismanEnchantSkillCid[17881]={prof=5,enchantskilltype=3,enchantskillid=1775,maxsameskillcol=1}---//ȼ��ٻ�->��ý"
		TalismanEnchantSkillCid[17882]={prof=5,enchantskilltype=3,enchantskillid=1776,maxsameskillcol=1}---//����ʴ��->��ý"
		TalismanEnchantSkillCid[17883]={prof=5,enchantskilltype=3,enchantskillid=1777,maxsameskillcol=1}---//ɭ����Ц->��ý"
		TalismanEnchantSkillCid[17884]={prof=5,enchantskilltype=3,enchantskillid=1778,maxsameskillcol=1}---//�����->��ý"
		TalismanEnchantSkillCid[17885]={prof=5,enchantskilltype=3,enchantskillid=1779,maxsameskillcol=1}---//а�����->��ý"
		TalismanEnchantSkillCid[17886]={prof=5,enchantskilltype=3,enchantskillid=1780,maxsameskillcol=1}---//�������->��ý"
		TalismanEnchantSkillCid[17887]={prof=5,enchantskilltype=3,enchantskillid=1781,maxsameskillcol=1}---//��ѡ��Թ->��ý"


		TalismanEnchantSkillCid[11767]={prof=9,enchantskilltype=4,enchantskillid=337,maxsameskillcol=1} ---//���Կɼ�
	return TalismanEnchantSkillCid
end 	
-------------------------------------------------------------------------------------------------
---����(���˺�һ������ý)��ID�ͷ������𡺲��ҡ�ĳ��ý��Ӧ�����˺�һ��������id�͸�����������
function ZLuaExistInTalismanEnchantEx(cid,level)
	if type(cid)~="number" or type(level)~="number"  then 
		if level<1 then level=1 end
		if level>30 then level=30 end 
		return 0,0
	end 
	local TalismanEnchantEx=ZLuaTalismanEnchantEx()
	for i,v in pairs(TalismanEnchantEx) do
		if v.cidid==cid and v.exlevel==level then 
			return i,v.bufftype  ---���ظ�������id�͸��������������� 
		end 
	end 
	return 0,0
end 
---����(���ܹ�ħ������ý)��ID�����ҡ�ĳ��ý��Ӧ��ְҵ�����ܹ�ħ���ͺ�ָ���ܵ���Ϣ
function ZLuaExistInTalismanEnchantSkillCid(cid)
	if type(cid)~="number" then return -1 end 
	local TalismanEnchantSkillCid=ZLuaTalismanEnchantSkillCid()
	for i,v in pairs(TalismanEnchantSkillCid) do
		if i==cid then 
			return v.prof,v.enchantskilltype,v.enchantskillid,v.maxsameskillcol
		end 
	end 
	return -1
end 
------------������ħ������--------------------------------------------------------------------------
function EnchantTalismans(id, talisman1, cid, output)
---�������IDΪ�ɱ�ID�����ħʧ��
local dataIndex=ZLuaTalDataIndex()
if talisman1:QueryData(dataIndex["is_fly"])==1 then
		output:CreateItem(-1)
else
	if cid~=0 then 
		local Alevel=talisman1:QueryLevel()
		local exid,bufftype=ZLuaExistInTalismanEnchantEx(cid,Alevel)
		if exid~=0 then
			---//���˺�һ��ħ
			ZLuaTalisman_EnchantBotEx(id, talisman1, cid, output,exid,bufftype)
		else
			if cid == 19512 or cid == 19513 or cid == 19514 or cid == 19515 or cid == 19516 or cid == 19517 or cid == 19518 or cid == 19519 or cid == 19520 then
				ZLuaTalisman_Rise(id, talisman1, cid, output)
			else
				local tempprof,tempenchantskilltype,tempenchantskillid,tempmaxsameskillcol=ZLuaExistInTalismanEnchantSkillCid(cid)
				if tempprof~=-1 then
				---//���Ӽ��ܹ�ħ
				ZLuaTalisman_EnchantSkill(id, talisman1, cid, output,tempprof,tempenchantskilltype,tempenchantskillid,tempmaxsameskillcol)
				else 
				output:CreateItem(-1)
				end 
			end
		end 	
	else 
		output:CreateItem(-1)
	end
end
end

------------�������˺�һ��ħ������---------------------------------------------------------------------
function ZLuaTalisman_EnchantBotEx(id, talisman1, cid, output,exid, bufftype)
		if exid~=0 and bufftype~=0 then 			---//���˺�һ��ħ
			output:CreateItem(id)
			local dataIndex=ZLuaTalDataIndex()
			local nowbufftype
			nowbufftype=talisman1:QueryData(dataIndex["buff_type"])
			if nowbufftype==bufftype then 
					output:CreateItem(-1)
			else 
				for _,index in pairs(dataIndex) do
					output:UpdateData(index,talisman1:QueryData(index))
				end
				output:UpdateData(dataIndex["buff_type"],bufftype)
				output:UpdateData(dataIndex["ext_id"],exid)
				output:InheritCombineExp(true)
				ZLuaTalRebuild(output,id)
			end 
		else
				output:CreateItem(-1)
		end 
end 
------------�������Ӽ��ܹ�ħ������---------------------------------------------------------------------
function ZLuaTalisman_EnchantSkill(id, talisman1, cid, output, prof, enchantskilltype, enchantskillid, maxsameskillcol)
		
	local SkillNoSeq={}				
	local SkillReqLvlSeq={}
	local TalismanSkillID
	local TrueSkillNum=0
	---//��÷���Ŀǰ�ļ�����Ϣ(����ID,�������󼶱�,��������ID,ʵ�ʼ�����Ŀ)
	local dataIndex=ZLuaTalDataIndex()
		SkillNoSeq[1]=talisman1:QueryData(dataIndex["addon_1_id"])
		SkillReqLvlSeq[1]=talisman1:QueryData(dataIndex["addon_1_learn_level"])
		SkillNoSeq[2]=talisman1:QueryData(dataIndex["addon_2_id"])
		SkillReqLvlSeq[2]=talisman1:QueryData(dataIndex["addon_2_learn_level"])
		SkillNoSeq[3]=talisman1:QueryData(dataIndex["addon_3_id"])
		SkillReqLvlSeq[3]=talisman1:QueryData(dataIndex["addon_3_learn_level"])
		SkillNoSeq[4]=talisman1:QueryData(dataIndex["addon_4_id"])
		SkillReqLvlSeq[4]=talisman1:QueryData(dataIndex["addon_4_learn_level"])
		SkillNoSeq[5]=talisman1:QueryData(dataIndex["addon_5_id"])
		SkillReqLvlSeq[5]=talisman1:QueryData(dataIndex["addon_5_learn_level"])
		SkillNoSeq[6]=talisman1:QueryData(dataIndex["addon_6_id"])
		SkillReqLvlSeq[6]=talisman1:QueryData(dataIndex["addon_6_learn_level"])
		
		TalismanSkillID=talisman1:QueryData(dataIndex["skill_addon_id"])
	---//���ʵ�ʵ���Ч��������
	for j=1,6 do
		if SkillNoSeq[j]~=0 and SkillReqLvlSeq[j]~=0 and type(SkillReqLvlSeq[j])=="number" then 
			TrueSkillNum=TrueSkillNum+1
		end 
	end 
	
	local talismanprof,talismanskillprof ----���������ְҵ����,������Я������ְҵ����
	local talismanprof,talismanskillprof=ZLuaTalisman_GetProfInfo(id,SkillNoSeq)
	---//���ݷ�����id�ͷ������Ѿ����ڵļ��ܾ�����������������
	local FailtoCreatTalisman=0
	local SkillHighLvlVisible=talisman1:QueryData(dataIndex["skill_visible"])
	---�������＼����δ�ﵽ����ʱ�Ƿ�ɼ�
			
	if enchantskilltype==0 then
		local skillnumchanceseq={0,200,900,1200,600,100}
		---//1-6�����ܵĳ��ָ���
		local HowManySkills
		HowManySkills=ZLuaTal_Get_RanPoint(skillnumchanceseq)
		---//ѡȡ����Щ���Ӽ���
		SkillNoSeq,SkillReqLvlSeq=ZLuaTalisman_ChooseEnchantSkill(talismanskillprof,HowManySkills,maxsameskillcol)	
		---//ѡȡ���ĸ�����ķ�������
		TalismanSkillID=ZLuaTalisman_ChooseTalismanSkill(TalismanSkillID)
	---//elseif enchantskilltype==1 then 
	---//		SkillNoSeq,SkillReqLvlSeq=ZLuaTalisman_ChooseEnchantSkill(talismanprof,TrueSkillNum,maxsameskillcol)	
	---//������enchantskilltype==2�ϲ�
	elseif enchantskilltype==2 then 
		if talismanskillprof==prof or (talismanskillprof~=prof and talismanprof==9) then 
			SkillNoSeq,SkillReqLvlSeq=ZLuaTalisman_ChooseEnchantSkill(prof,TrueSkillNum,maxsameskillcol)
		else 
			FailtoCreatTalisman=1
			output:CreateItem(-1)
		end 
	elseif (enchantskilltype==3 and prof==talismanskillprof) or 
					(enchantskilltype==3 and prof==9) or 
					(enchantskilltype==3 and talismanprof==9 and talismanskillprof==9) then 
			SkillNoSeq,SkillReqLvlSeq=ZLuaTalisman_InsertSkillSeq(enchantskillid,SkillNoSeq,SkillReqLvlSeq,talismanskillprof)
		---������Ҫ����ķ������ܺͷ���Ŀǰ�ļ������о�������������µ�SkillNoSeq,SkillReqLvlSeq
	elseif enchantskilltype==4 and SkillHighLvlVisible~=1 then
			SkillHighLvlVisible=1
	else
			FailtoCreatTalisman=1
			output:CreateItem(-1)
	end 
	
	---��Ϊͬ�༼����Ŀ�ﵽ���޵��µĹ�ħʧ��
	if type(SkillNoSeq)==nil or type(SkillReqLvlSeq)==nil then 
			FailtoCreatTalisman=1
			output:CreateItem(-1)
	end 
		
	---//�����µĸ������＼��������Ϣ	
		if 	FailtoCreatTalisman==0 then 
			output:CreateItem(id)
			for _,index in pairs(dataIndex) do
				output:UpdateData(index,talisman1:QueryData(index))
			end
			output:UpdateData(dataIndex["addon_1_id"],SkillNoSeq[1]or 0)		
			output:UpdateData(dataIndex["addon_1_learn_level"],SkillReqLvlSeq[1]or 0)
			output:UpdateData(dataIndex["addon_2_id"],SkillNoSeq[2]or 0)		
			output:UpdateData(dataIndex["addon_2_learn_level"],SkillReqLvlSeq[2]or 0)
			output:UpdateData(dataIndex["addon_3_id"],SkillNoSeq[3]or 0)		
			output:UpdateData(dataIndex["addon_3_learn_level"],SkillReqLvlSeq[3]or 0)
			output:UpdateData(dataIndex["addon_4_id"],SkillNoSeq[4]or 0)		
			output:UpdateData(dataIndex["addon_4_learn_level"],SkillReqLvlSeq[4]or 0)
			output:UpdateData(dataIndex["addon_5_id"],SkillNoSeq[5]or 0)		
			output:UpdateData(dataIndex["addon_5_learn_level"],SkillReqLvlSeq[5]or 0)
			output:UpdateData(dataIndex["addon_6_id"],SkillNoSeq[6]or 0)		
			output:UpdateData(dataIndex["addon_6_learn_level"],SkillReqLvlSeq[6]or 0)
		---//�����µķ�������������Ϣ		
			output:UpdateData(dataIndex["skill_addon_id"],TalismanSkillID)
		---//�趨���������и������＼�ܿɼ�
			if SkillHighLvlVisible==1 then 
				output:UpdateData(dataIndex["skill_visible"],SkillHighLvlVisible)
			end 
		---//�趨��ħϵ�в���	 
			if enchantskilltype==0 then 
				output:UpdateData(dataIndex["change_skillnum"],output:QueryData(dataIndex["change_skillnum"])+1)			
			elseif enchantskilltype==2 or enchantskilltype==3 then 
				output:UpdateData(dataIndex["enchant_times"],output:QueryData(dataIndex["enchant_times"])+1)		
			end 
			output:InheritCombineExp(true)
			ZLuaTalRebuild(output,id)
	end 
	
end 
-------���ڷ���levelupʱ�������˺�һ���͹�ħ�ĺ���-------------------------------------------------------------
function ZLuaTalChangeExt(talisman)
	local Alevel=talisman:QueryLevel()
	local dataIndex=ZLuaTalDataIndex()
	local ABuffType=talisman:QueryData(dataIndex["buff_type"])
	
	local TalismanEnchantEx=ZLuaTalismanEnchantEx()
	local exid
	for i,v in pairs(TalismanEnchantEx) do
		if v.bufftype==ABuffType and v.exlevel==Alevel then 
			 exid=i  ---���ظ�������id 
			 talisman:UpdateData(dataIndex["ext_id"],exid)
		else 
		end 
	end 
end 
------------------------------------------------------------------------------------------------------------
-----------�������ܶ�ε���/����/����ĸ��ʲ���(���ܹ�ħ)---------------------------------------------------
function ZLuaTalismanSkillsExInfo(skillid,nowaddtimes)
	local SkillsExInfo={}
		---//[��������ID]
		---//prof
		---//����1�θ��ʲ�����6�θ��ʲ���
		SkillsExInfo[337]={9,100,0,0,100,100,100,100,100,100}---//����:�ػ�
		SkillsExInfo[338]={9,100,0,0,100,100,100,100,100,100}---//����:����
		SkillsExInfo[339]={1,100,0,0,100,100,100,100,100,100}---//����:׷����
		SkillsExInfo[340]={1,100,0,0,100,100,100,100,100,100}---//����:��ħն
		SkillsExInfo[341]={1,100,0,0,100,100,100,100,100,100}---//����:���浶
		SkillsExInfo[342]={1,100,0,0,100,100,100,100,100,100}---//����:������
		SkillsExInfo[343]={1,100,0,0,100,100,100,100,100,100}---//����:��ˮ��
		SkillsExInfo[344]={1,100,0,0,100,100,100,100,100,100}---//����:ʧ��ն
		SkillsExInfo[345]={1,100,0,0,100,100,100,100,100,100}---//����:Ѹ��ն
		SkillsExInfo[346]={1,100,0,0,100,100,100,100,100,100}---//����:����ն
		SkillsExInfo[347]={1,100,0,0,100,100,100,100,100,100}---//����:����ն
		SkillsExInfo[348]={1,100,0,0,100,100,100,100,100,100}---//����:�ͻ���
		SkillsExInfo[349]={1,100,20,12,100,100,100,100,100,100}---//����:��Ѫն
		SkillsExInfo[350]={1,100,20,12,100,100,100,100,100,100}---//����:��ħ��
		SkillsExInfo[351]={1,100,20,12,100,100,100,100,100,100}---//����:����ն
		SkillsExInfo[352]={1,100,20,12,100,100,100,100,100,100}---//����:����ն
		SkillsExInfo[353]={1,100,20,12,100,100,100,100,100,100}---//����:������
		SkillsExInfo[354]={2,100,0,0,100,100,100,100,100,100}---//����:��ˮ
		SkillsExInfo[355]={2,100,0,0,100,100,100,100,100,100}---//����:����
		SkillsExInfo[356]={2,100,0,0,100,100,100,100,100,100}---//����:����
		SkillsExInfo[357]={2,100,0,0,100,100,100,100,100,100}---//����:��Ѫ
		SkillsExInfo[358]={2,100,0,0,100,100,100,100,100,100}---//����:����
		SkillsExInfo[359]={2,100,0,0,100,100,100,100,100,100}---//����:�ɻ�
		SkillsExInfo[360]={2,100,0,0,100,100,100,100,100,100}---//����:����
		SkillsExInfo[361]={2,100,0,0,100,100,100,100,100,100}---//����:����
		SkillsExInfo[362]={2,100,0,0,100,100,100,100,100,100}---//����:����
		SkillsExInfo[363]={2,100,0,0,100,100,100,100,100,100}---//����:��˼
		SkillsExInfo[364]={2,100,20,12,100,100,100,100,100,100}---//����:����
		SkillsExInfo[365]={2,100,20,12,100,100,100,100,100,100}---//����:����
		SkillsExInfo[366]={2,100,20,12,100,100,100,100,100,100}---//����:���
		SkillsExInfo[367]={2,100,20,12,100,100,100,100,100,100}---//����:����
		SkillsExInfo[368]={2,100,20,12,100,100,100,100,100,100}---//����:ɽ��
		SkillsExInfo[369]={3,100,0,0,100,100,100,100,100,100}---//����:������
		SkillsExInfo[370]={3,100,0,0,100,100,100,100,100,100}---//����:������
		SkillsExInfo[371]={3,100,0,0,100,100,100,100,100,100}---//����:Ԧ����
		SkillsExInfo[372]={3,100,0,0,100,100,100,100,100,100}---//����:��˪����
		SkillsExInfo[373]={3,100,0,0,100,100,100,100,100,100}---//����:��Ԫ����
		SkillsExInfo[374]={3,100,0,0,100,100,100,100,100,100}---//����:��ħ����
		SkillsExInfo[375]={3,100,0,0,100,100,100,100,100,100}---//����:������
		SkillsExInfo[376]={3,100,0,0,100,100,100,100,100,100}---//����:���Ʒ籩
		SkillsExInfo[377]={3,100,0,0,100,100,100,100,100,100}---//����:��������
		SkillsExInfo[378]={3,100,0,0,100,100,100,100,100,100}---//����:��������
		SkillsExInfo[379]={3,100,20,12,100,100,100,100,100,100}---//����:ŭ����
		SkillsExInfo[380]={3,100,20,12,100,100,100,100,100,100}---//����:���׺䶥
		SkillsExInfo[381]={3,100,20,12,100,100,100,100,100,100}---//����:�������
		SkillsExInfo[382]={3,100,20,12,100,100,100,100,100,100}---//����:����֮׶
		SkillsExInfo[383]={3,100,20,12,100,100,100,100,100,100}---//����:������ŭ
		SkillsExInfo[384]={4,100,0,0,100,100,100,100,100,100}---//����:����
		SkillsExInfo[385]={4,100,0,0,100,100,100,100,100,100}---//����:��ħ��
		SkillsExInfo[386]={4,100,0,0,100,100,100,100,100,100}---//����:ʨ�Ӻ�
		SkillsExInfo[387]={4,100,0,0,100,100,100,100,100,100}---//����:�о�
		SkillsExInfo[388]={4,100,0,0,100,100,100,100,100,100}---//����:�׽
		SkillsExInfo[389]={4,100,0,0,100,100,100,100,100,100}---//����:��Ը
		SkillsExInfo[390]={4,100,0,0,100,100,100,100,100,100}---//����:������
		SkillsExInfo[391]={4,100,0,0,100,100,100,100,100,100}---//����:��վ�
		SkillsExInfo[392]={4,100,0,0,100,100,100,100,100,100}---//����:�ຣ�ޱ�
		SkillsExInfo[393]={4,100,0,0,100,100,100,100,100,100}---//����:�Ĵ�Կ�:��
		SkillsExInfo[394]={4,100,20,12,100,100,100,100,100,100}---//����:�Ĵ�Կ�:��
		SkillsExInfo[395]={4,100,20,12,100,100,100,100,100,100}---//����:ͬ�鼫��
		SkillsExInfo[396]={4,100,20,12,100,100,100,100,100,100}---//����:�������
		SkillsExInfo[397]={4,100,20,12,100,100,100,100,100,100}---//����:��ħ��
		SkillsExInfo[398]={4,100,20,12,100,100,100,100,100,100}---//����:���ͬ��
		SkillsExInfo[872]={1,100,100,43,800,800,800,800,800,800}---//����:����¾ɱ
		SkillsExInfo[873]={1,100,100,43,800,800,800,800,800,800}---//����:������
		SkillsExInfo[874]={1,100,100,43,800,800,800,800,800,800}---//����:������
		SkillsExInfo[875]={1,100,100,43,800,800,800,800,800,800}---//����:������ɱ
		SkillsExInfo[876]={1,100,100,43,800,800,800,800,800,800}---//����:�Խ���
		SkillsExInfo[877]={1,100,400,100,1500,1500,1500,1500,1500,1500}---//����:ħ������
		SkillsExInfo[878]={1,100,400,100,1500,1500,1500,1500,1500,1500}---//����:���鷴��
		SkillsExInfo[879]={2,100,100,43,800,800,800,800,800,800}---//����:��Ӱ
		SkillsExInfo[880]={2,100,100,43,800,800,800,800,800,800}---//����:��ϼ
		SkillsExInfo[881]={2,100,100,43,800,800,800,800,800,800}---//����:����
		SkillsExInfo[882]={2,100,100,43,800,800,800,800,800,800}---//����:����
		SkillsExInfo[883]={2,100,100,43,800,800,800,800,800,800}---//����:����
		SkillsExInfo[884]={2,100,400,100,1500,1500,1500,1500,1500,1500}---//����:����
		SkillsExInfo[885]={2,100,400,100,1500,1500,1500,1500,1500,1500}---//����:ϧ��
		SkillsExInfo[886]={3,100,100,43,800,800,800,800,800,800}---//����:˪��ѩ��
		SkillsExInfo[887]={3,100,100,43,800,800,800,800,800,800}---//����:������
		SkillsExInfo[888]={3,100,100,43,800,800,800,800,800,800}---//����:���｣��
		SkillsExInfo[889]={3,100,100,43,800,800,800,800,800,800}---//����:��ز���
		SkillsExInfo[890]={3,100,100,43,800,800,800,800,800,800}---//����:���ӡ
		SkillsExInfo[891]={3,100,400,100,1500,1500,1500,1500,1500,1500}---//����:�׹������
		SkillsExInfo[892]={3,100,400,100,1500,1500,1500,1500,1500,1500}---//����:������
		SkillsExInfo[893]={4,100,100,43,800,800,800,800,800,800}---//����:�黨����
		SkillsExInfo[894]={4,100,100,43,800,800,800,800,800,800}---//����:��������
		SkillsExInfo[895]={4,100,100,43,800,800,800,800,800,800}---//����:���ѭ��
		SkillsExInfo[896]={4,100,100,43,800,800,800,800,800,800}---//����:�����ֻ�
		SkillsExInfo[897]={4,100,100,43,800,800,800,800,800,800}---//����:�Ⱥ���Ը
		SkillsExInfo[898]={4,100,400,100,1500,1500,1500,1500,1500,1500}---//����:��������
		SkillsExInfo[899]={4,100,400,100,1500,1500,1500,1500,1500,1500}---//����:��������
		SkillsExInfo[900]={1,100,400,100,1500,1500,1500,1500,1500,1500}---//����:�������
		SkillsExInfo[901]={1,100,400,100,1500,1500,1500,1500,1500,1500}---//����:δ��ն
		SkillsExInfo[902]={2,100,400,100,1500,1500,1500,1500,1500,1500}---//����:��Ӱ
		SkillsExInfo[903]={2,100,400,100,1500,1500,1500,1500,1500,1500}---//����:�绨ѩ��
		SkillsExInfo[904]={3,100,400,100,1500,1500,1500,1500,1500,1500}---//����:̫���������
		SkillsExInfo[905]={3,100,400,100,1500,1500,1500,1500,1500,1500}---//����:���������
		SkillsExInfo[906]={4,100,400,100,1500,1500,1500,1500,1500,1500}---//����:�󷲰���
		SkillsExInfo[907]={4,100,400,100,1500,1500,1500,1500,1500,1500}---//����:��������
		SkillsExInfo[1758]={5,100,0,0,100,100,100,100,100,100}---//����:�޹�����
		SkillsExInfo[1759]={5,100,0,0,100,100,100,100,100,100}---//����:���Ƕ�ɰ
		SkillsExInfo[1760]={5,100,0,0,100,100,100,100,100,100}---//����:�Ļ���צ
		SkillsExInfo[1761]={5,100,0,0,100,100,100,100,100,100}---//����:���ض�â
		SkillsExInfo[1762]={5,100,0,0,100,100,100,100,100,100}---//����:�ɻ�Ѫ��
		SkillsExInfo[1763]={5,100,0,0,100,100,100,100,100,100}---//����:��������
		SkillsExInfo[1764]={5,100,0,0,100,100,100,100,100,100}---//����:ʴ�Ķ���
		SkillsExInfo[1765]={5,100,0,0,100,100,100,100,100,100}---//����:��ɳ��Ӱ
		SkillsExInfo[1766]={5,100,0,0,100,100,100,100,100,100}---//����:��Ѫ����
		SkillsExInfo[1767]={5,100,0,0,100,100,100,100,100,100}---//����:����а��
		SkillsExInfo[1768]={5,100,20,12,100,100,100,100,100,100}---//����:��ɳ����
		SkillsExInfo[1769]={5,100,20,12,100,100,100,100,100,100}---//����:Թ����ħ
		SkillsExInfo[1770]={5,100,20,12,100,100,100,100,100,100}---//����:�����߹�
		SkillsExInfo[1771]={5,100,20,12,100,100,100,100,100,100}---//����:���ǵش�
		SkillsExInfo[1772]={5,100,20,12,100,100,100,100,100,100}---//����:�����Ϯ
		SkillsExInfo[1773]={5,100,100,43,800,800,800,800,800,800}---//����:Ļ���ɳ
		SkillsExInfo[1774]={5,100,100,43,800,800,800,800,800,800}---//����:�ٹ�ࢻ�
		SkillsExInfo[1775]={5,100,100,43,800,800,800,800,800,800}---//����:ȼ��ٻ�
		SkillsExInfo[1776]={5,100,100,43,800,800,800,800,800,800}---//����:����ʴ��
		SkillsExInfo[1777]={5,100,100,43,800,800,800,800,800,800}---//����:ɭ����Ц
		SkillsExInfo[1778]={5,100,400,100,1500,1500,1500,1500,1500,1500}---//����:�����
		SkillsExInfo[1779]={5,100,400,100,1500,1500,1500,1500,1500,1500}---//����:а�����
		SkillsExInfo[1780]={5,100,400,100,1500,1500,1500,1500,1500,1500}---//����:�������
		SkillsExInfo[1781]={5,100,400,100,1500,1500,1500,1500,1500,1500}---//����:��ѡ��Թ


			---//{prof,addchancebase,failchancebase,add[1]--add[5]}
	local addchance=0
	local addchancecalc={}
	local addchancebase=0
	local failchancebase=0

	if nowaddtimes>=1 then 
		return 4
	else	 
		for i,v in pairs(SkillsExInfo) do
			if i==skillid then 
				---addchance=v[nowaddtimes+4]
				addchance=v[nowaddtimes+4]+v[3]
				addchancebase=v[2]
				---failchancebase=v[3]
				failchancebase=v[3]-v[3]
			end 
		end	
		addchancecalc={addchancebase,addchance,failchancebase}
		return ZLuaTal_Get_RanPoint(addchancecalc)
	end 
	---return 1������ӳɹ� 2����ʧ�ܵ��������� 3����ʧ�����滻һ������(��Ĭ�ϼ���ѡȡ)
end 
-----------------����ְҵѡȡһ������(�޶��ظ�)�ļ���(���ܹ�ħ)---------------------------------------------
function ZLuaTalisman_ChooseEnchantSkill(prof,num,maxsamecol)
	---prof,num,maxsamecol  ְҵ,��������,�������ͬ���ܳ��ִ���
	
	local SkillsExLists=ZLuaTalismanEnchantSkillEx()
	local CheckedSkills={}
	local CheckedSkillsBornChance={}
	local CheckedSkillsReqLvl={}
	
	if prof==9 then prof=math.ceil(math.random(4)) end ---ͨ��ְҵ���ѡ��
	for i,v in pairs(SkillsExLists) do
		if v.prof==prof or v.prof==0 then 
			table.insert(CheckedSkills,i)
			table.insert(CheckedSkillsBornChance,v.bornchance)
			table.insert(CheckedSkillsReqLvl,v.reqlevel)
		end 
	end 
	return ZLuaCheckOutNums(CheckedSkills,CheckedSkillsBornChance,CheckedSkillsReqLvl,num,maxsamecol)
end 	
----------------------���ݷ�������id���ѡȡ�������ܵļ���仯(��ͬID)---------------------------------------
function ZLuaTalisman_ChooseTalismanSkill(TalismanSkillID)
	local TalismanSkillIDs={}
	TalismanSkillIDs[399]={399,1278,1279}---//_����ʯ.ext
	TalismanSkillIDs[400]={400,1292,1293}---//_���Ͼ�.ext
	TalismanSkillIDs[401]={401,1326,1327}---//_��ȸӡ.ext
	TalismanSkillIDs[402]={402,1294,1295}---//_�ֻ���.ext
	TalismanSkillIDs[403]={403,1308,1309}---//_������.ext
	TalismanSkillIDs[404]={404,1298,1299}---//_���ǽ�.ext
	TalismanSkillIDs[405]={405,1318,1319}---//_�����.ext
	TalismanSkillIDs[406]={406,1284,1285}---//_�����.ext
	TalismanSkillIDs[407]={407,1280,1281}---//_���黷.ext
	TalismanSkillIDs[408]={408,1306,1307}---//_ɽ����.ext
	TalismanSkillIDs[409]={409,1312,1313}---//_��ľ��.ext
	TalismanSkillIDs[410]={410,1320,1321}---//_�򶾴�(�򶾶�).ext
	TalismanSkillIDs[411]={411,1300,1301}---//_ǧ��̳(��ƿ).ext
	TalismanSkillIDs[860]={860,1282,1283}---//_�������.ext
	TalismanSkillIDs[861]={861,1324,1325}---//_������.ext
	TalismanSkillIDs[862]={862,1296,1297}---//_����.ext
	TalismanSkillIDs[863]={863,1286,1287}---//_���«.ext
	TalismanSkillIDs[864]={864,1290,1291}---//_����.ext
	TalismanSkillIDs[865]={865,1302,1303}---//_Ǭ������.ext
	TalismanSkillIDs[866]={866,1322,1323}---//_������.ext
	TalismanSkillIDs[867]={867,1288,1289}---//_���������.ext
	TalismanSkillIDs[868]={868,1304,1305}---//_����Ǭ����.ext
	TalismanSkillIDs[869]={869,1310,1311}---//_���.ext
	TalismanSkillIDs[870]={870,1316,1317}---//_��Ѫ��.ext
	TalismanSkillIDs[871]={871,1314,1315}---//_�ɻ�.ext
	TalismanSkillIDs[1653]={1653,1654,1655}---//_������.ext
	TalismanSkillIDs[1697]={1697,1698,1699}---//����.ext
	TalismanSkillIDs[1700]={1700,1701,1702}---//_�ֻ���.ext
	TalismanSkillIDs[1703]={1703,1704,1705}---//_Ǭ����.ext
	TalismanSkillIDs[1706]={1706,1707,1708}---//��ڤ����_.ext
	TalismanSkillIDs[1738]={1738,1739,1740}---//����ӡ.ext
	TalismanSkillIDs[1753]={1753,1754,1755}---//��ɽ����.ext
	TalismanSkillIDs[1806]={1806,1807,1808}---//Ѫ���Ƭ.ext
	TalismanSkillIDs[1809]={1809,1810,1811}---//��ɲ.ext
	TalismanSkillIDs[1812]={1812,1813,1814}---//ǧ����.ext
	TalismanSkillIDs[1815]={1815,1816,1817}---//����.ext
	TalismanSkillIDs[2037]={2037,2038,2039}---//_����ӡ.ext
	TalismanSkillIDs[2153]={2153,2154,2155}---//_������.ext
	
	local skilllvlchanceseq={275,24,1}
		---//1-3�����ܵĳ��ָ���
	for i,v in pairs(TalismanSkillIDs) do
		if TalismanSkillID==i or TalismanSkillID==v[1] or TalismanSkillID==v[2] or TalismanSkillID==v[3] then 
			return TalismanSkillIDs[i][ZLuaTal_Get_RanPoint(skilllvlchanceseq)]or TalismanSkillID
		end 
	end
	
end 
----------------------���ݷ���id�ͷ���Я�����ܵ�id�жϹ���ְҵ-----------------------------------------------
function ZLuaTalisman_GetProfInfo(id,SkillNoSeq)
	local prof_fromid=9
	local prof_fromskill=9
	
	local talismans=ZLuaTalAvailableTalismans()
	for i,v in pairs(talismans) do
		if id==v.tmplID then 
			prof_fromid=v.school
		end 
			if prof_fromid==0 then prof_fromid=9 end 
	end 
 
	local SkillsExLists=ZLuaTalismanEnchantSkillEx()
	for i,v in pairs(SkillsExLists) do
		for j=1,table.getn(SkillNoSeq) do 
			if i==SkillNoSeq[j] and (v.prof==1 or v.prof==2 or v.prof==3 or v.prof==4 or v.prof==5) then 
				prof_fromskill=v.prof
			end 
		end 
	end 
	if prof_fromid==1 or prof_fromid==2 or prof_fromid==3 or prof_fromid==4 or prof_fromid==5 then 
		prof_fromskill=prof_fromid
	end 
	return  prof_fromid,prof_fromskill
	
end 
------------------�����ѡȡ���ֺ���-------------------------------------------------------------------------
---��ilist�а���vlist�涨�ĸ���ѡȡ���֣���һһ��Ӧklist�е����֣�ÿ������������maxsamcol��
function ZLuaCheckOutNums(ilist,vlist,klist,num,maxsamecol)
	if table.getn(ilist)~=table.getn(vlist) then return end
	if table.getn(ilist)<num then return end 
	
	local TheDesk={}	---�Ѿ���ѡȡ�������
	local TheHand={}	---���ص���������
	local TheExInfo={}	---���صĶ����Ӧ����
	for i=1,num do
		TheDesk[i]=0
		TheHand[i]=0
	end 
	local findsamenum
	
	for j=1,num do 
			TheDesk[j]=ZLuaTal_Get_RanPoint(vlist)
			findsamenum=0
			for k=1,j do
					if TheDesk[k]==TheDesk[j] then 
						findsamenum=findsamenum+1
							if findsamenum>=maxsamecol then 
							vlist[TheDesk[j]]=0 
						end
					end
			end
			TheHand[j]=ilist[TheDesk[j]]
			TheExInfo[j]=klist[TheDesk[j]]
	end 
	return TheHand,TheExInfo
end 
---------����Ĳ������ֺ���------------------------------------------------------------------------------------
---��insertid����ilist��,vlistΪilistһһ��Ӧ����
function ZLuaTalisman_InsertSkillSeq(insertid,ilist,vlist,talismanskillprof)
	local insertid_num=0  ---//ilist��ͬinsertid��ͬ����������
	for i=1,table.getn(ilist) do
		if insertid==ilist[i] then
			insertid_num=insertid_num+1
		end 
	end 	
	
	local insertcase=ZLuaTalismanSkillsExInfo(insertid,insertid_num)
	---//��ò��뼼�ܵĽ������
	local SkillsExLists=ZLuaTalismanEnchantSkillEx()
	
	local differentskillreplacechance={} 	---�������＼���в�ͬ������Ӽ��ܹ��ɵ�����
	local differentskillposition={}				---�������＼���в�ͬ������Ӽ������󼶱𹹳ɵ�����
	local IsFindDifferentIDs=0						
	
	for i,v in pairs(SkillsExLists) do
		for j=1,table.getn(ilist) do 
			if ilist[j]==i and ilist[j]~=0 and ilist[j]~=insertid then 
				table.insert(differentskillreplacechance,v.replacechance)
				table.insert(differentskillposition,j)
				IsFindDifferentIDs=1
			end 
		end 
	end 
	
	if insertcase==1 and IsFindDifferentIDs==1 then 			---//�ɹ�����������
		local c=ZLuaTal_Get_RanPoint(differentskillreplacechance)
		ilist[differentskillposition[c]]=insertid
		vlist[differentskillposition[c]]=SkillsExLists[insertid].reqlevel
	elseif insertcase==2  then		---//ʧ�ܵ�ά������,do nothing
																		
	elseif insertcase==3 and IsFindDifferentIDs==1 then 	---//ʧ�����������
		local k=math.ceil(math.random(table.getn(ilist)))
		local FailSkillList={}
			FailSkillList[1]={337,338,339,340,341,342,343}	---//����
			FailSkillList[2]={337,338,354,355,356,357,358}	---//�ϻ�
			FailSkillList[3]={337,338,369,370,371,372,373}	---//����
			FailSkillList[4]={337,338,384,385,386,387,388}	---//����
			FailSkillList[5]={337,338,1758,1759,1760,1761,1762}	---//���
			FailSkillList[9]={337,338,337,338,337,338,337}	---//ͨ��
		local replaceskill=FailSkillList[talismanskillprof][math.ceil(math.random(7))]
					
			if ilist[k]~=0 then 
				ilist[k]=replaceskill or 337
				vlist[k]=SkillsExLists[replaceskill].reqlevel or 1
			end 		
		---///337Ϊ�ػ�����Ҫ�滻�ļ���
	elseif insertcase==4 then																---//ʧ��(��Ϊ�Ѿ��ﵽ���ͬ�༼����)
		ilist=nil
		vlist=nil
	else 
		return ilist,vlist
	end 
	return ilist,vlist
end 
---------------------------------------------------------------------------------------
function ZLuaTalisman_Rise(id,talisman1,cid,output)
local dataIndex = ZLuaTalDataIndex()
local maxlevel=10
local whattorise=ZLuaTalisman_chooserise(cid)
local currenlevel=talisman1:QueryData(whattorise) or 0
local totalgrade=talisman1:QueryData(dataIndex["all_rise"]) or 0


if currenlevel<maxlevel then 
	output:CreateItem(id)
	for _,index in pairs(dataIndex) do
	output:UpdateData(index,talisman1:QueryData(index))
	end
	output:UpdateData(whattorise,currenlevel+1)
	output:UpdateData(dataIndex["all_rise"],totalgrade+1)
	output:InheritCombineExp(true)
	ZLuaTalRebuild(output,id)
else
	output:CreateItem(-1)
end
end

----------------------������ý����ѡ��������-----------------------------------------
function ZLuaTalisman_chooserise(cid)
local dataIndex = ZLuaTalDataIndex()
if cid==19512 then return 83 end
if cid==19513 then return 84 end
if cid==19514 then return 85 end
if cid==19515 then return 86 end
if cid==19516 then return 87 end
if cid==19517 then return 88 end
if cid==19518 then return 89 end
if cid==19519 then return 90 end
if cid==19520 then return 91 end
return 0
end