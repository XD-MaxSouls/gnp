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
---//ZLuaSpecialTalismanOut(cid,output,origin) ����Ѫ�����������ﺯ��
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

---//����������غ���
---//ZLuaTalHolyLevelUp(id,talisman,cid,output)	��������������
---//*������id,��������,������ý,�������*

---//��������ϴ����غ���
---//ZLuaTalSkillRefine(id1,id2,talisman1,talisman2,cid,output)	��������ϴ��������
---//*����1��id,����2��id,����1����,����2����,ϴ����ý,�������*

---//����������Ƕ��غ���
---//ZLuaTalSkillAdd(id1,id2,talisman1,talisman2,cid1,cid2,output)	����������Ƕ������
---//*����1��id,����2��id,����1����,����2����,��ý1,��ý2,�������*

---//ZluaTalSkillRefineResult(id1, talisman1, result, ouput);

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
	cidmatrix[6471]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_45_ShenMuShai"].tmplID,cidloveid2=Temp_TalismanIDs["US_45_ShenMuShai_WZGL"].tmplID,cidmulti=1,cidcombo=0}
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
	cidmatrix[10915]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_105_YinYangJing"].tmplID,cidloveid2=Temp_TalismanIDs["US_105_YinYangJing_WZGL"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[15867]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_105_LuoHunDeng"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[17833]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_105_ZhenShanHeShan"].tmplID,cidmulti=1,cidcombo=0}
	
	cidmatrix[10916]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_135_PanLongFan"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[10920]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_135_WuLongLun"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[20094]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_135_FanTianYin"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[20501]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_135_ChangMingDeng"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[34852]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_135_BaoKuZhiHun"].tmplID,cidmulti=1,cidcombo=0}

	cidmatrix[10923]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_135_SheHun"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[10924]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_145_ShiXueZhu"].tmplID,cidmulti=1,cidcombo=0}	
	cidmatrix[10925]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_145_ShiHun"].tmplID,cidmulti=1,cidcombo=0}		
	cidmatrix[43480]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_145_TianYa"].tmplID,cidmulti=1,cidcombo=0}		

	cidmatrix[22128]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_75_RiYueBaoJian"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[23356]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_105_FuTu"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[25739]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["US_135_YinHunFan"].tmplID,cidmulti=1,cidcombo=0}

	cidmatrix[13798]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["GW_135_TianMoZhi"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[13797]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["QY_135_RuoXue"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[13795]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["HH_135_BaJiYouLong"].tmplID,cidmulti=1,cidcombo=0}	
	cidmatrix[13796]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["TY_135_LiuDaoShengMie"].tmplID,cidmulti=1,cidcombo=0}
	cidmatrix[17859]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["GD_135_GuiQing"].tmplID,cidmulti=1,cidcombo=0}				

	cidmatrix[31504]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["SY_1_WuSeShi"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[31505]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["JL_15_NuShouFan"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[31506]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["JL_75_XueFengQiang"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[31507]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["JL_105_GangLan"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[31508]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["JL_135_SangMenJian"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[31509]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["LS_15_DanZhu"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[31510]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["LS_75_FanHunXiang"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[31511]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["LS_105_FuYingGuJing"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[31512]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["LS_135_LuoShu"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[38891]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["HG_15_QiSha"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[38892]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["HG_75_PoJun"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[38893]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["HG_105_TanLang"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[38894]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["HG_135_JueYing"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[38895]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["TH_15_JiuYinLuo"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[38896]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["TH_75_YaFeng"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[38897]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["TH_105_LiuLiZhan"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[38898]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["TH_135_BiLuoFeiHong"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[49372]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["FX_15_NanMingYin"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[49373]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["FX_75_HengTianChi"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[49374]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["FX_105_HuoLingLong"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[49375]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["FX_135_JiuHanNingBingCi"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[49376]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["TH_15_LeiGongMo"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[49377]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["TH_75_ChunQiuSuo"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[49378]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["TH_105_ZiMuYinYangKou"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[49379]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["TH_135_XiHuangZhong"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[54047]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["CH_15_lvdouqi"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[54048]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["CH_75_tuogu"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[54049]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["CH_105_luobaojinqian"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[54050]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["CH_135_huangji"].tmplID,cidmulti=1,cidcombo=0}				

	cidmatrix[58841]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["LZ_1_TianLingShi"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[58842]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["QJ_15_tianjimu"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[58843]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["QJ_75_luohouyu"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[58844]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["QJ_105_jinyubian"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[58845]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["QJ_135_chixinglongyan"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[58846]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["YZ_15_lveying"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[58847]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["YZ_75_poming"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[58848]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["YZ_105_shuolei"].tmplID,cidmulti=1,cidcombo=0}				
	cidmatrix[58849]={cidwithlvl=0,cidusetype=1,cidloveid=Temp_TalismanIDs["YZ_135_zhuihun"].tmplID,cidmulti=1,cidcombo=0}				

	cidmatrix[6345]={cidwithlvl=0,cidusetype=2,cidloveid=Temp_TalismanIDs["US_75_ShanHeShan"].tmplID,cidmulti=20,cidcombo=0}
	cidmatrix[6346]={cidwithlvl=0,cidusetype=2,cidloveid=Temp_TalismanIDs["US_75_ShanHeShan"].tmplID,cidmulti=100,cidcombo=0}
	cidmatrix[27150]={cidwithlvl=0,cidusetype=2,cidloveid=Temp_TalismanIDs["US_145_ShiHun"].tmplID,cidmulti=100,cidcombo=0}
	cidmatrix[38204]={cidwithlvl=0,cidusetype=2,cidloveid=Temp_TalismanIDs["US_145_ShiHun"].tmplID,cidmulti=100,cidcombo=0}
		
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
	---������ɽ�
	cidmatrix[60820]={cidwithlvl=1,cidusetype=100,cidloveid=Temp_TalismanIDs["NW_1_BaGuaShi"].tmplID,cidmulti=1,cidcombo=999}

	cidmatrix[61205]={cidwithlvl=1,cidusetype=100,cidloveid=Temp_TalismanIDs["US_145_ShiHun"].tmplID,cidloveid2=Temp_TalismanIDs["shihunfeijian"].tmplID,cidmulti=1,cidcombo=999}
	cidmatrix[61206]={cidwithlvl=1,cidusetype=100,cidloveid=Temp_TalismanIDs["US_145_TianYa"].tmplID,cidloveid2=Temp_TalismanIDs["tianyafeijian"].tmplID,cidmulti=1,cidcombo=999}
	cidmatrix[61207]={cidwithlvl=1,cidusetype=100,cidloveid=Temp_TalismanIDs["US_135_SheHun"].tmplID,cidloveid2=Temp_TalismanIDs["shehunfeijian"].tmplID,cidmulti=1,cidcombo=999}
	cidmatrix[61208]={cidwithlvl=1,cidusetype=100,cidloveid=Temp_TalismanIDs["US_145_ShiXueZhu"].tmplID,cidloveid2=Temp_TalismanIDs["sihxuefeijian"].tmplID,cidmulti=1,cidcombo=999}
	cidmatrix[61209]={cidwithlvl=1,cidusetype=100,cidloveid=Temp_TalismanIDs["US_45_ShenMuShai"].tmplID,cidloveid2=Temp_TalismanIDs["shenmufeijian"].tmplID,cidmulti=1,cidcombo=999}
	
	cidmatrix[0]={cidwithlvl=-1,cidusetype=-1,cidloveid=0,cidmulti=1,cidcombo=0}
	return cidmatrix
end

---//����Ѫ������������Ĵ�����
function ZLuaSpecialTalismanOut(cid,output,origin)
	local temp_cid=ZLuaTalisman_CombineAppendix()
	local Temp_TalismanIDs=ZLuaTalAvailableTalismans()
	local outid
	
	-- �����ɽ���Ⱥϳ���ý
	if temp_cid[cid].cidloveid == Temp_TalismanIDs["US_75_ShanHeShan"].tmplID then
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
		outid=allspecialout[ZLuaTal_Get_RanPoint(allspecialchance)]
	-- �������Ѫ��ϳ���ý
	elseif temp_cid[cid].cidloveid == Temp_TalismanIDs["US_145_ShiHun"].tmplID then
		outid=Temp_TalismanIDs["US_145_ShiHun"].tmplID
	end

	if ZLuaTalExistInTmplIDs(outid) then
		output:CreateItem(outid)			
		ZLuaTalInit(outid,output,origin)	
	else 
		output:CreateItem(outid)
	end 
	outid=nil
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
	local QlevelPrice=TalismanQlevelPrice[foodtalisman:QueryData(0,dataIndex["quality"])+1]		
	---//Ʒ�ʼ�
	local zorigin=ZLuaTalClientOrigins()
	if foodtalisman:QueryData(0,dataIndex["origin"])==zorigin["quest"] then 
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
	local Temp_TalismanIDs=ZLuaTalAvailableTalismans()
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
	
	---//����ý
	if cid==0 then
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
	---//����ý
	else
		if tempcid[cid].cidusetype==1  then
			if tempcid[cid].cidloveid==a_id or tempcid[cid].cidloveid2==a_id then
				outtype=1
			end 		
			if outtype<=0 or outtype>2 then outtype=1 end
		elseif tempcid[cid].cidusetype==2 and tempcid[cid].cidloveid==Temp_TalismanIDs["US_75_ShanHeShan"].tmplID then
			outtypelist[2]={600,400,(aqlevel+bqlevel)*tempcid[cid].cidmulti/150}
			outtype=ZLuaTal_Get_RanPoint(outtypelist[2])
			if outtype<=0 or outtype>3 then outtype=1 end 
		elseif tempcid[cid].cidusetype==2 and tempcid[cid].cidloveid==Temp_TalismanIDs["US_145_ShiHun"].tmplID then
			outtype=3
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
--[[
		local n = GradeLimitsList
		if mothertalisman:QueryData(0,dataIndex["reborncont"]) ~= 0 then
			GradeLimitsList = {n[1]+90,n[2]+15,n[3]+15,n[4]+15,n[5]+15,n[6],n[7],n[8]+15,n[9]+15,n[10]+15,n[11]+15,n[12]+15,n[13]}
		end
--]]
		
		local growdirection=ZluaTransRiseIndex(WhatTypeWeGrow)
		local mothertalismanlimit
		if mothertalisman:QueryData(0,growdirection)~=nil then
			mothertalismanlimit=GradeLimitsList[ZLuaTalTransIndex(WhatTypeWeGrow)]+mothertalisman:QueryData(0,growdirection)
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
function ZLuaTalisman_Combine(id1,id2,talisman1,talisman2,cid,output,locked1,locked2)

	local dataIndex=ZLuaTalDataIndex()
	local talismans=ZLuaTalAvailableTalismans()
	local temp_cid=ZLuaTalisman_CombineAppendix()

	---// ������ɽ�
	
	---���������IDΪ�ɱ�����Ѫ��ʧ��
	if talisman1:QueryData(0,dataIndex["is_fly"]) == 1 or talisman2:QueryData(0,dataIndex["is_fly"]) == 1 then 
		output:CreateItem(-1)
  ---Ԫ���Ʋ�����Ѫ��
  elseif id1 == talismans["US_45_YuanXiaoDeng"].tmplID or id2 == talismans["US_45_YuanXiaoDeng"].tmplID then
		output:CreateItem(-1)
	elseif locked1 == true or locked2 == true then
		output:CreateItem(-1)
	
	else
	local iswronginput,isspecialoutput
	local iswronginput=0		---���������־
	local isspecialoutput=0	---���������־
	
	---//ȡ�÷���A�ͷ���B�ľ����ȼ�
	local NowAlevel=talisman1:QueryLevel()
	local NowBlevel=talisman2:QueryLevel()

	---//ȡ�÷���A�ͷ���B�ĵ�ǰ������ʱ��
	local NowATime=talisman1:QueryData(0,dataIndex["birth_hour12"])		
	local NowBTime=talisman2:QueryData(0,dataIndex["birth_hour12"])	
	local NowATimeEx=talisman1:QueryData(0,dataIndex["birth_min3"])		
	local NowBTimeEx=talisman2:QueryData(0,dataIndex["birth_min3"])	

	---//ȡ�÷���A�ͷ���B��Qlevel(���󼶱�	
	local NowAReqLvl=ZLuaTalExistInTmplIDs(id1)
	local NowBReqLvl=ZLuaTalExistInTmplIDs(id2)
	
	---//ȡ�÷���A�ͷ���B�ĳɳ�ȡ��
	local NowAGrowType=talisman1:QueryData(0,dataIndex["speciality"]) or 0 	
	local NowBGrowType=talisman2:QueryData(0,dataIndex["speciality"]) or 0	

	---//����cid����������ķ��ش���
	
	-- ����ý����ֹѪ��
	if type(cid) ~= "number" or cid == 0 then
		iswronginput = 1
		output:CreateItem(-1)
	end
--[[
	-- ��ͨѪ������ý����������ƥ�䣬��ֹѪ��	
	if temp_cid[cid].cidusetype == 1 
	and temp_cid[cid].cidloveid == talismans["NW_1_BaGuaShi"].tmplID 
	and temp_cid[cid].cidloveid == id2 
	and temp_cid[cid].cidloveid ~= id1 then
		talisman2:UpdateData(0,120,talisman2:QueryData(0,120)+1)
		talisman2:UpdateData(0,dataIndex["reborncont"],1)
		iswronginput=1
		output:CreateItem(-1)
	elseif temp_cid[cid].cidusetype == 1 
	and temp_cid[cid].cidloveid ~= id1 
	and temp_cid[cid].cidloveid2 ~= id1 then
		iswronginput=1
		output:CreateItem(-1)
	
	end 
--]]
	-- ��ͨѪ������ý����������ƥ�䣬��ֹѪ��	
	if temp_cid[cid].cidusetype == 1 
	and temp_cid[cid].cidloveid ~= id1 
	and temp_cid[cid].cidloveid2 ~= id1 then
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




	-- �ɻ�ϳ�Ѫ�������ϱ�������Ѫ������	
	if temp_cid[cid].cidusetype == 2 and temp_cid[cid].cidloveid == talismans["US_145_ShiHun"].tmplID then
		if id1 == talismans["US_135_SheHun"].tmplID and id2 == talismans["US_145_ShiXueZhu"].tmplID then
			iswronginput = 0
		elseif id1 == talismans["US_145_ShiXueZhu"].tmplID and id2 == talismans["US_135_SheHun"].tmplID then
			iswronginput = 0
		else
			iswronginput = 1
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
			WhatIDWeGet=ZLuaSpecialTalismanOut(cid,output,NowOrigin["combine"])
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
			if WhatIDWeGet==id1 then 
				output:InheritCombineLevel(true)		
	  --    if id1==talismans["NW_1_BaGuaShi"].tmplID and id2==temp_cid[cid].cidloveid then talisman1:UpdateData(0,1,talisman1:QueryData(0,1)+1) ZLuaTalDebugDisplay(talisman2,id1,cid,output)	end   --Debug
			end  
								
			---���ݵ�ǰ�������͵���Ӧ��λ�ĳɳ�������Ϣ
			local GradeLimitsList=ZLuaTalGradesUpperLimit(WhatIDWeGet)
--[[
			local n = GradeLimitsList
			if talisman1:QueryData(0,dataIndex["reborncont"]) ~= 0 then
				GradeLimitsList = {n[1]+90,n[2]+15,n[3]+15,n[4]+15,n[5]+15,n[6],n[7],n[8]+15,n[9]+15,n[10]+15,n[11]+15,n[12]+15,n[13]}
			end
--]]
			
			local growdirection=ZluaTransRiseIndex(WhatTypeWeGrow)
			local Limit
			if mothertalisman:QueryData(0,growdirection)~=nil then
				Limit=GradeLimitsList[ZLuaTalTransIndex(WhatTypeWeGrow)]+mothertalisman:QueryData(0,growdirection)
			else Limit=GradeLimitsList[ZLuaTalTransIndex(WhatTypeWeGrow)]
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
	 				output:UpdateData(0,dataIndex["combine_times"],output:QueryData(0,dataIndex["combine_times"])+1)
	 				local feedcosta,feedcostb=ZLuaTalisman_FoodAttributeValue(fathertalisman,foodid,nowLimit)
	 				output:UpdateData(0,dataIndex["feed_cost"],output:QueryData(0,dataIndex["feed_cost"])+feedcosta)
	 				output:UpdateData(0,dataIndex["feed_level_cost"],output:QueryData(0,dataIndex["feed_level_cost"])+feedcostb)
		 			if fathertalisman:QueryData(0,dataIndex["quality"])==0 then 
		 				output:UpdateData(0,dataIndex["feed_baoqi"],output:QueryData(0,dataIndex["feed_baoqi"])+1)
		 			elseif fathertalisman:QueryData(0,dataIndex["quality"])==1 then 
		 				output:UpdateData(0,dataIndex["feed_xianpin"],output:QueryData(0,dataIndex["feed_xianpin"])+1)
		 			elseif fathertalisman:QueryData(0,dataIndex["quality"])==2 then 
		 				output:UpdateData(0,dataIndex["feed_shenpin"],output:QueryData(0,dataIndex["feed_shenpin"])+1)
		 			else
		 			end
		 		end
			end
 	 	end  -- end of isspecialout

		----����֮������ֵ�仯,�κ����������Ѫ��ֵ
		if ischangespeciality==0 then 
			CombineValueGrow=ZLuaTalisman_CombineValueGrow(NowAlevel,NowBlevel,NowAReqLvl,NowBReqLvl,CombineIndex,1)
			output:SetCombineValue(output:GetCombineValue()+CombineValueGrow)
		end 

	end  --end of iswronginput
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
		SkillNoSeqA[1]=talisman1:QueryData(0,dataIndex["addon_1_id"])
		SkillReqLvlSeqA[1]=talisman1:QueryData(0,dataIndex["addon_1_learn_level"])
		SkillNoSeqA[2]=talisman1:QueryData(0,dataIndex["addon_2_id"])
		SkillReqLvlSeqA[2]=talisman1:QueryData(0,dataIndex["addon_2_learn_level"])
		SkillNoSeqA[3]=talisman1:QueryData(0,dataIndex["addon_3_id"])
		SkillReqLvlSeqA[3]=talisman1:QueryData(0,dataIndex["addon_3_learn_level"])
		SkillNoSeqA[4]=talisman1:QueryData(0,dataIndex["addon_4_id"])
		SkillReqLvlSeqA[4]=talisman1:QueryData(0,dataIndex["addon_4_learn_level"])
		SkillNoSeqA[5]=talisman1:QueryData(0,dataIndex["addon_5_id"])
		SkillReqLvlSeqA[5]=talisman1:QueryData(0,dataIndex["addon_5_learn_level"])
		SkillNoSeqA[6]=talisman1:QueryData(0,dataIndex["addon_6_id"])
		SkillReqLvlSeqA[6]=talisman1:QueryData(0,dataIndex["addon_6_learn_level"])
		
		SkillNoSeqB[1]=talisman2:QueryData(0,dataIndex["addon_1_id"])
		SkillReqLvlSeqB[1]=talisman2:QueryData(0,dataIndex["addon_1_learn_level"])
		SkillNoSeqB[2]=talisman2:QueryData(0,dataIndex["addon_2_id"])
		SkillReqLvlSeqB[2]=talisman2:QueryData(0,dataIndex["addon_2_learn_level"])
		SkillNoSeqB[3]=talisman2:QueryData(0,dataIndex["addon_3_id"])
		SkillReqLvlSeqB[3]=talisman2:QueryData(0,dataIndex["addon_3_learn_level"])
		SkillNoSeqB[4]=talisman2:QueryData(0,dataIndex["addon_4_id"])
		SkillReqLvlSeqB[4]=talisman2:QueryData(0,dataIndex["addon_4_learn_level"])
		SkillNoSeqB[5]=talisman2:QueryData(0,dataIndex["addon_5_id"])
		SkillReqLvlSeqB[5]=talisman2:QueryData(0,dataIndex["addon_5_learn_level"])
		SkillNoSeqB[6]=talisman2:QueryData(0,dataIndex["addon_6_id"])
		SkillReqLvlSeqB[6]=talisman2:QueryData(0,dataIndex["addon_6_learn_level"])

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
				output:UpdateData(0,index,talisman1:QueryData(0,index))
			end
			output:UpdateData(0,dataIndex["addon_1_id"],SkillNoSeqA[1]or 0)		
			output:UpdateData(0,dataIndex["addon_1_learn_level"],SkillReqLvlSeqA[1]or 0)
			output:UpdateData(0,dataIndex["addon_2_id"],SkillNoSeqA[2]or 0)		
			output:UpdateData(0,dataIndex["addon_2_learn_level"],SkillReqLvlSeqA[2]or 0)
			output:UpdateData(0,dataIndex["addon_3_id"],SkillNoSeqA[3]or 0)		
			output:UpdateData(0,dataIndex["addon_3_learn_level"],SkillReqLvlSeqA[3]or 0)
			output:UpdateData(0,dataIndex["addon_4_id"],SkillNoSeqA[4]or 0)		
			output:UpdateData(0,dataIndex["addon_4_learn_level"],SkillReqLvlSeqA[4]or 0)
			output:UpdateData(0,dataIndex["addon_5_id"],SkillNoSeqA[5]or 0)		
			output:UpdateData(0,dataIndex["addon_5_learn_level"],SkillReqLvlSeqA[5]or 0)
			output:UpdateData(0,dataIndex["addon_6_id"],SkillNoSeqA[6]or 0)		
			output:UpdateData(0,dataIndex["addon_6_learn_level"],SkillReqLvlSeqA[6]or 0)
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
		TalismanEnchantEx[3125]={cidid=11385,bufftype=1,exlevel=31}
		TalismanEnchantEx[3126]={cidid=11385,bufftype=1,exlevel=32}
		TalismanEnchantEx[3127]={cidid=11385,bufftype=1,exlevel=33}
		TalismanEnchantEx[3128]={cidid=11385,bufftype=1,exlevel=34}
		TalismanEnchantEx[3129]={cidid=11385,bufftype=1,exlevel=35}
		TalismanEnchantEx[34631]={cidid=11385,bufftype=1,exlevel=36}
		TalismanEnchantEx[34632]={cidid=11385,bufftype=1,exlevel=37}

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
		TalismanEnchantEx[3120]={cidid=11386,bufftype=2,exlevel=31}
		TalismanEnchantEx[3121]={cidid=11386,bufftype=2,exlevel=32}
		TalismanEnchantEx[3122]={cidid=11386,bufftype=2,exlevel=33}
		TalismanEnchantEx[3123]={cidid=11386,bufftype=2,exlevel=34}
		TalismanEnchantEx[3124]={cidid=11386,bufftype=2,exlevel=35}
		TalismanEnchantEx[34629]={cidid=11386,bufftype=2,exlevel=36}
		TalismanEnchantEx[34630]={cidid=11386,bufftype=2,exlevel=37}

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
		TalismanEnchantEx[3110]={cidid=11387,bufftype=3,exlevel=31}
		TalismanEnchantEx[3111]={cidid=11387,bufftype=3,exlevel=32}
		TalismanEnchantEx[3112]={cidid=11387,bufftype=3,exlevel=33}
		TalismanEnchantEx[3113]={cidid=11387,bufftype=3,exlevel=34}
		TalismanEnchantEx[3114]={cidid=11387,bufftype=3,exlevel=35}
		TalismanEnchantEx[34627]={cidid=11387,bufftype=3,exlevel=36}
		TalismanEnchantEx[34628]={cidid=11387,bufftype=3,exlevel=37}

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
		TalismanEnchantEx[3105]={cidid=11388,bufftype=4,exlevel=31}
		TalismanEnchantEx[3106]={cidid=11388,bufftype=4,exlevel=32}
		TalismanEnchantEx[3107]={cidid=11388,bufftype=4,exlevel=33}
		TalismanEnchantEx[3108]={cidid=11388,bufftype=4,exlevel=34}
		TalismanEnchantEx[3109]={cidid=11388,bufftype=4,exlevel=35}
		TalismanEnchantEx[34625]={cidid=11388,bufftype=4,exlevel=36}
		TalismanEnchantEx[34626]={cidid=11388,bufftype=4,exlevel=37}

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
		TalismanEnchantEx[3115]={cidid=11389,bufftype=5,exlevel=31}
		TalismanEnchantEx[3116]={cidid=11389,bufftype=5,exlevel=32}
		TalismanEnchantEx[3117]={cidid=11389,bufftype=5,exlevel=33}
		TalismanEnchantEx[3118]={cidid=11389,bufftype=5,exlevel=34}
		TalismanEnchantEx[3119]={cidid=11389,bufftype=5,exlevel=35}
		TalismanEnchantEx[34633]={cidid=11389,bufftype=5,exlevel=36}
		TalismanEnchantEx[34634]={cidid=11389,bufftype=5,exlevel=37}
		
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
		TalismanEnchantEx[3100]={cidid=11390,bufftype=6,exlevel=31}
		TalismanEnchantEx[3101]={cidid=11390,bufftype=6,exlevel=32}
		TalismanEnchantEx[3102]={cidid=11390,bufftype=6,exlevel=33}
		TalismanEnchantEx[3103]={cidid=11390,bufftype=6,exlevel=34}
		TalismanEnchantEx[3104]={cidid=11390,bufftype=6,exlevel=35}
		TalismanEnchantEx[34623]={cidid=11390,bufftype=6,exlevel=36}
		TalismanEnchantEx[34624]={cidid=11390,bufftype=6,exlevel=37}
	return TalismanEnchantEx
end 
-------���Ӽ��ܵ�������Ϣ����(���ܹ�ħ)---------------------------------------------------------
function ZLuaTalismanEnchantSkillEx()
	local SkillsExList={}
			---[��������(��Ӧ����)ID]
			---prof:����ְҵ(0,1,2,3,4,5,6,9=����,����,����,�ϻ�,����,���,����,ͨ��)
			---bornchance:�������󼶱�--��Ӧ�ķ�������
			---replacechance:��������ʲ���
			SkillsExList[337]={prof=21,reqlevel=1,bornchance=720,replacechance=100}---//����:�ػ�
			SkillsExList[338]={prof=21,reqlevel=2,bornchance=720,replacechance=100}---//����:����

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
			SkillsExList[872]={prof=1,reqlevel=21,bornchance=40,replacechance=360}---//����:����¾ɱ
			SkillsExList[873]={prof=1,reqlevel=22,bornchance=40,replacechance=360}---//����:������
			SkillsExList[874]={prof=1,reqlevel=23,bornchance=40,replacechance=360}---//����:������
			SkillsExList[875]={prof=1,reqlevel=24,bornchance=40,replacechance=360}---//����:������ɱ
			SkillsExList[876]={prof=1,reqlevel=26,bornchance=40,replacechance=360}---//����:�Խ���
			SkillsExList[877]={prof=1,reqlevel=27,bornchance=20,replacechance=480}---//����:ħ������
			SkillsExList[878]={prof=1,reqlevel=28,bornchance=20,replacechance=480}---//����:���鷴��
			SkillsExList[900]={prof=1,reqlevel=29,bornchance=20,replacechance=480}---//����:�������
			SkillsExList[901]={prof=1,reqlevel=30,bornchance=20,replacechance=480}---//����:δ��ն

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
			SkillsExList[879]={prof=2,reqlevel=21,bornchance=40,replacechance=360}---//����:��Ӱ
			SkillsExList[880]={prof=2,reqlevel=22,bornchance=40,replacechance=360}---//����:��ϼ
			SkillsExList[881]={prof=2,reqlevel=23,bornchance=40,replacechance=360}---//����:����
			SkillsExList[882]={prof=2,reqlevel=24,bornchance=40,replacechance=360}---//����:����
			SkillsExList[883]={prof=2,reqlevel=25,bornchance=40,replacechance=360}---//����:����
			SkillsExList[884]={prof=2,reqlevel=27,bornchance=20,replacechance=480}---//����:����
			SkillsExList[885]={prof=2,reqlevel=28,bornchance=20,replacechance=480}---//����:ϧ��
			SkillsExList[902]={prof=2,reqlevel=29,bornchance=20,replacechance=480}---//����:��Ӱ
			SkillsExList[903]={prof=2,reqlevel=30,bornchance=20,replacechance=480}---//����:�绨ѩ��

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
			SkillsExList[886]={prof=3,reqlevel=21,bornchance=40,replacechance=360}---//����:˪��ѩ��
			SkillsExList[887]={prof=3,reqlevel=22,bornchance=40,replacechance=360}---//����:������
			SkillsExList[888]={prof=3,reqlevel=23,bornchance=40,replacechance=360}---//����:���｣��
			SkillsExList[889]={prof=3,reqlevel=24,bornchance=40,replacechance=360}---//����:��ز���
			SkillsExList[890]={prof=3,reqlevel=25,bornchance=40,replacechance=360}---//����:���ӡ
			SkillsExList[891]={prof=3,reqlevel=27,bornchance=20,replacechance=480}---//����:�׹������
			SkillsExList[892]={prof=3,reqlevel=28,bornchance=20,replacechance=480}---//����:������
			SkillsExList[904]={prof=3,reqlevel=29,bornchance=20,replacechance=480}---//����:̫���������
			SkillsExList[905]={prof=3,reqlevel=30,bornchance=20,replacechance=480}---//����:���������

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
			SkillsExList[893]={prof=4,reqlevel=21,bornchance=40,replacechance=360}---//����:�黨����
			SkillsExList[894]={prof=4,reqlevel=22,bornchance=40,replacechance=360}---//����:��������
			SkillsExList[895]={prof=4,reqlevel=23,bornchance=40,replacechance=360}---//����:���ѭ��
			SkillsExList[896]={prof=4,reqlevel=24,bornchance=40,replacechance=360}---//����:�����ֻ�
			SkillsExList[897]={prof=4,reqlevel=25,bornchance=40,replacechance=360}---//����:�Ⱥ���Ը
			SkillsExList[898]={prof=4,reqlevel=27,bornchance=20,replacechance=480}---//����:��������
			SkillsExList[899]={prof=4,reqlevel=28,bornchance=20,replacechance=480}---//����:��������
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

			SkillsExList[33387]={prof=6,reqlevel=3,bornchance=640,replacechance=120}---//����:
			SkillsExList[33388]={prof=6,reqlevel=4,bornchance=640,replacechance=120}---//����:
			SkillsExList[33389]={prof=6,reqlevel=5,bornchance=640,replacechance=120}---//����:
			SkillsExList[33390]={prof=6,reqlevel=6,bornchance=640,replacechance=120}---//����:
			SkillsExList[33391]={prof=6,reqlevel=7,bornchance=640,replacechance=120}---//����:
			SkillsExList[33392]={prof=6,reqlevel=9,bornchance=560,replacechance=180}---//����:
			SkillsExList[33393]={prof=6,reqlevel=11,bornchance=560,replacechance=180}---//����:
			SkillsExList[33394]={prof=6,reqlevel=12,bornchance=560,replacechance=180}---//����:
			SkillsExList[33395]={prof=6,reqlevel=14,bornchance=560,replacechance=180}---//����:
			SkillsExList[33396]={prof=6,reqlevel=13,bornchance=560,replacechance=180}---//����:
			SkillsExList[33397]={prof=6,reqlevel=15,bornchance=240,replacechance=240}---//����:
			SkillsExList[33398]={prof=6,reqlevel=15,bornchance=240,replacechance=240}---//����:
			SkillsExList[33399]={prof=6,reqlevel=17,bornchance=240,replacechance=240}---//����:
			SkillsExList[33400]={prof=6,reqlevel=18,bornchance=240,replacechance=240}---//����:
			SkillsExList[33401]={prof=6,reqlevel=19,bornchance=240,replacechance=240}---//����:
			SkillsExList[33402]={prof=6,reqlevel=21,bornchance=40,replacechance=360}---//����:
			SkillsExList[33403]={prof=6,reqlevel=23,bornchance=40,replacechance=360}---//����:
			SkillsExList[33404]={prof=6,reqlevel=23,bornchance=40,replacechance=360}---//����:
			SkillsExList[33405]={prof=6,reqlevel=24,bornchance=40,replacechance=360}---//����:
			SkillsExList[33406]={prof=6,reqlevel=25,bornchance=40,replacechance=360}---//����:
			SkillsExList[33407]={prof=6,reqlevel=27,bornchance=20,replacechance=480}---//����:
			SkillsExList[33408]={prof=6,reqlevel=28,bornchance=20,replacechance=480}---//����:
			SkillsExList[33409]={prof=6,reqlevel=29,bornchance=20,replacechance=480}---//����:
			SkillsExList[33410]={prof=6,reqlevel=30,bornchance=20,replacechance=480}---//����:

			SkillsExList[3510]={prof=7,reqlevel=3,bornchance=640,replacechance=120}---//����:һ��
			SkillsExList[3511]={prof=7,reqlevel=4,bornchance=640,replacechance=120}---//����:ŭ��
			SkillsExList[3512]={prof=7,reqlevel=5,bornchance=640,replacechance=120}---//����:����
			SkillsExList[3513]={prof=7,reqlevel=6,bornchance=640,replacechance=120}---//����:��β
			SkillsExList[3514]={prof=7,reqlevel=7,bornchance=640,replacechance=120}---//����:����
			SkillsExList[3515]={prof=7,reqlevel=9,bornchance=560,replacechance=180}---//����:����
			SkillsExList[3516]={prof=7,reqlevel=11,bornchance=560,replacechance=180}---//����:����
			SkillsExList[3517]={prof=7,reqlevel=12,bornchance=560,replacechance=180}---//����:����
			SkillsExList[3518]={prof=7,reqlevel=14,bornchance=560,replacechance=180}---//����:��Ѫ
			SkillsExList[3519]={prof=7,reqlevel=13,bornchance=560,replacechance=180}---//����:�Ƽ�
			SkillsExList[3520]={prof=7,reqlevel=15,bornchance=240,replacechance=240}---//����:ɽ�
			SkillsExList[3521]={prof=7,reqlevel=15,bornchance=240,replacechance=240}---//����:����
			SkillsExList[3522]={prof=7,reqlevel=17,bornchance=240,replacechance=240}---//����:����
			SkillsExList[3523]={prof=7,reqlevel=18,bornchance=240,replacechance=240}---//����:����
			SkillsExList[3524]={prof=7,reqlevel=19,bornchance=240,replacechance=240}---//����:��ɷ
			SkillsExList[3525]={prof=7,reqlevel=21,bornchance=40,replacechance=360}---//����:��ɽ
			SkillsExList[3526]={prof=7,reqlevel=23,bornchance=40,replacechance=360}---//����:����
			SkillsExList[3527]={prof=7,reqlevel=23,bornchance=40,replacechance=360}---//����:�ѿ�
			SkillsExList[3528]={prof=7,reqlevel=24,bornchance=40,replacechance=360}---//����:ɱ¾
			SkillsExList[3529]={prof=7,reqlevel=25,bornchance=40,replacechance=360}---//����:����
			SkillsExList[3530]={prof=7,reqlevel=27,bornchance=20,replacechance=480}---//����:����
			SkillsExList[3531]={prof=7,reqlevel=28,bornchance=20,replacechance=480}---//����:����
			SkillsExList[3532]={prof=7,reqlevel=29,bornchance=20,replacechance=480}---//����:��
			SkillsExList[3533]={prof=7,reqlevel=30,bornchance=20,replacechance=480}---//����:��ս

			SkillsExList[3534]={prof=8,reqlevel=3,bornchance=640,replacechance=120}---//����:����ʸ
			SkillsExList[3535]={prof=8,reqlevel=4,bornchance=640,replacechance=120}---//����:����ʸ
			SkillsExList[3536]={prof=8,reqlevel=5,bornchance=640,replacechance=120}---//����:��â��
			SkillsExList[3537]={prof=8,reqlevel=6,bornchance=640,replacechance=120}---//����:������
			SkillsExList[3538]={prof=8,reqlevel=7,bornchance=640,replacechance=120}---//����:�����
			SkillsExList[3539]={prof=8,reqlevel=9,bornchance=560,replacechance=180}---//����:��Ѫʸ
			SkillsExList[3540]={prof=8,reqlevel=11,bornchance=560,replacechance=180}---//����:ѣ��ʸ
			SkillsExList[3541]={prof=8,reqlevel=12,bornchance=560,replacechance=180}---//����:������
			SkillsExList[3542]={prof=8,reqlevel=14,bornchance=560,replacechance=180}---//����:�����
			SkillsExList[3543]={prof=8,reqlevel=13,bornchance=560,replacechance=180}---//����:������
			SkillsExList[3544]={prof=8,reqlevel=15,bornchance=240,replacechance=240}---//����:���»�
			SkillsExList[3545]={prof=8,reqlevel=15,bornchance=240,replacechance=240}---//����:��ħʸ
			SkillsExList[3546]={prof=8,reqlevel=17,bornchance=240,replacechance=240}---//����:������
			SkillsExList[3547]={prof=8,reqlevel=18,bornchance=240,replacechance=240}---//����:������
			SkillsExList[3548]={prof=8,reqlevel=19,bornchance=240,replacechance=240}---//����:�����
			SkillsExList[3549]={prof=8,reqlevel=21,bornchance=40,replacechance=360}---//����:˫�ɻ�
			SkillsExList[3550]={prof=8,reqlevel=23,bornchance=40,replacechance=360}---//����:������
			SkillsExList[3551]={prof=8,reqlevel=23,bornchance=40,replacechance=360}---//����:����׹
			SkillsExList[3552]={prof=8,reqlevel=24,bornchance=40,replacechance=360}---//����:ʧ����
			SkillsExList[3553]={prof=8,reqlevel=25,bornchance=40,replacechance=360}---//����:����ɽ
			SkillsExList[3554]={prof=8,reqlevel=27,bornchance=20,replacechance=480}---//����:������
			SkillsExList[3555]={prof=8,reqlevel=28,bornchance=20,replacechance=480}---//����:������
			SkillsExList[3556]={prof=8,reqlevel=29,bornchance=20,replacechance=480}---//����:�ֻ���
			SkillsExList[3557]={prof=8,reqlevel=30,bornchance=20,replacechance=480}---//����:���뻢

			SkillsExList[3972]={prof=9,reqlevel=3,bornchance=640,replacechance=120}---//����:��Ϯ
			SkillsExList[3973]={prof=9,reqlevel=4,bornchance=640,replacechance=120}---//����:����
			SkillsExList[3974]={prof=9,reqlevel=5,bornchance=640,replacechance=120}---//����:��ɱ
			SkillsExList[3975]={prof=9,reqlevel=6,bornchance=640,replacechance=120}---//����:Ѫ��
			SkillsExList[3976]={prof=9,reqlevel=7,bornchance=640,replacechance=120}---//����:��Ӱ
			SkillsExList[3977]={prof=9,reqlevel=9,bornchance=560,replacechance=180}---//����:ǱϮ
			SkillsExList[3978]={prof=9,reqlevel=11,bornchance=560,replacechance=180}---//����:����
			SkillsExList[3979]={prof=9,reqlevel=12,bornchance=560,replacechance=180}---//����:˲ɱ
			SkillsExList[3980]={prof=9,reqlevel=14,bornchance=560,replacechance=180}---//����:�˱�
			SkillsExList[3981]={prof=9,reqlevel=13,bornchance=560,replacechance=180}---//����:����
			SkillsExList[3982]={prof=9,reqlevel=15,bornchance=240,replacechance=240}---//����:��Ϯ
			SkillsExList[3983]={prof=9,reqlevel=15,bornchance=240,replacechance=240}---//����:����
			SkillsExList[3984]={prof=9,reqlevel=17,bornchance=240,replacechance=240}---//����:ͻɱ
			SkillsExList[3985]={prof=9,reqlevel=18,bornchance=240,replacechance=240}---//����:��Ļ
			SkillsExList[3986]={prof=9,reqlevel=19,bornchance=240,replacechance=240}---//����:Ӱ��
			SkillsExList[3987]={prof=9,reqlevel=21,bornchance=40,replacechance=360}---//����:��Ϯ
			SkillsExList[3988]={prof=9,reqlevel=23,bornchance=40,replacechance=360}---//����:����
			SkillsExList[3989]={prof=9,reqlevel=23,bornchance=40,replacechance=360}---//����:��ɱ
			SkillsExList[3990]={prof=9,reqlevel=24,bornchance=40,replacechance=360}---//����:�ֽ�
			SkillsExList[3991]={prof=9,reqlevel=25,bornchance=40,replacechance=360}---//����:����
			SkillsExList[3992]={prof=9,reqlevel=27,bornchance=20,replacechance=480}---//����:����
			SkillsExList[3993]={prof=9,reqlevel=28,bornchance=20,replacechance=480}---//����:����
			SkillsExList[3994]={prof=9,reqlevel=29,bornchance=20,replacechance=480}---//����:һ��
			SkillsExList[3995]={prof=9,reqlevel=30,bornchance=20,replacechance=480}---//����:Ӱ�衤��

			SkillsExList[3996]={prof=10,reqlevel=3,bornchance=640,replacechance=120}---//����:��ɴ����
			SkillsExList[3997]={prof=10,reqlevel=4,bornchance=640,replacechance=120}---//����:�������
			SkillsExList[3998]={prof=10,reqlevel=5,bornchance=640,replacechance=120}---//����:���ﻪ��
			SkillsExList[3999]={prof=10,reqlevel=6,bornchance=640,replacechance=120}---//����:�ɷ�����
			SkillsExList[4000]={prof=10,reqlevel=7,bornchance=640,replacechance=120}---//����:��Ȫ����
			SkillsExList[4001]={prof=10,reqlevel=9,bornchance=560,replacechance=180}---//����:��������
			SkillsExList[4002]={prof=10,reqlevel=11,bornchance=560,replacechance=180}---//����:�������
			SkillsExList[4003]={prof=10,reqlevel=12,bornchance=560,replacechance=180}---//����:���һ���
			SkillsExList[4004]={prof=10,reqlevel=14,bornchance=560,replacechance=180}---//����:��ڤ����
			SkillsExList[4005]={prof=10,reqlevel=13,bornchance=560,replacechance=180}---//����:������ƽɳ����
			SkillsExList[4006]={prof=10,reqlevel=15,bornchance=240,replacechance=240}---//����:��ƽ����
			SkillsExList[4007]={prof=10,reqlevel=15,bornchance=240,replacechance=240}---//����:�������
			SkillsExList[4008]={prof=10,reqlevel=17,bornchance=240,replacechance=240}---//����:˷�»���
			SkillsExList[4009]={prof=10,reqlevel=18,bornchance=240,replacechance=240}---//����:��ˮ����
			SkillsExList[4010]={prof=10,reqlevel=19,bornchance=240,replacechance=240}---//����:���������߿���
			SkillsExList[4011]={prof=10,reqlevel=21,bornchance=40,replacechance=360}---//����:��������
			SkillsExList[4012]={prof=10,reqlevel=23,bornchance=40,replacechance=360}---//����:��������
			SkillsExList[4013]={prof=10,reqlevel=23,bornchance=40,replacechance=360}---//����:��������
			SkillsExList[4014]={prof=10,reqlevel=24,bornchance=40,replacechance=360}---//����:������������ҹ
			SkillsExList[4015]={prof=10,reqlevel=25,bornchance=40,replacechance=360}---//����:������������ѩ
			SkillsExList[4016]={prof=10,reqlevel=27,bornchance=20,replacechance=480}---//����:��������������
			SkillsExList[4017]={prof=10,reqlevel=28,bornchance=20,replacechance=480}---//����:��������
			SkillsExList[4018]={prof=10,reqlevel=29,bornchance=20,replacechance=480}---//����:������÷����Ū
			SkillsExList[4019]={prof=10,reqlevel=30,bornchance=20,replacechance=480}---//����:��̨����

			SkillsExList[33411]={prof=11,reqlevel=3,bornchance=640,replacechance=120}---//����:
			SkillsExList[33412]={prof=11,reqlevel=4,bornchance=640,replacechance=120}---//����:
			SkillsExList[33413]={prof=11,reqlevel=5,bornchance=640,replacechance=120}---//����:
			SkillsExList[33414]={prof=11,reqlevel=6,bornchance=640,replacechance=120}---//����:
			SkillsExList[33415]={prof=11,reqlevel=7,bornchance=640,replacechance=120}---//����:
			SkillsExList[33416]={prof=11,reqlevel=9,bornchance=560,replacechance=180}---//����:
			SkillsExList[33417]={prof=11,reqlevel=11,bornchance=560,replacechance=180}---//����:
			SkillsExList[33418]={prof=11,reqlevel=12,bornchance=560,replacechance=180}---//����:
			SkillsExList[33419]={prof=11,reqlevel=14,bornchance=560,replacechance=180}---//����:
			SkillsExList[33420]={prof=11,reqlevel=13,bornchance=560,replacechance=180}---//����:
			SkillsExList[33421]={prof=11,reqlevel=15,bornchance=240,replacechance=240}---//����:
			SkillsExList[33422]={prof=11,reqlevel=15,bornchance=240,replacechance=240}---//����:
			SkillsExList[33423]={prof=11,reqlevel=17,bornchance=240,replacechance=240}---//����:
			SkillsExList[33424]={prof=11,reqlevel=18,bornchance=240,replacechance=240}---//����:
			SkillsExList[33425]={prof=11,reqlevel=19,bornchance=240,replacechance=240}---//����:
			SkillsExList[33426]={prof=11,reqlevel=21,bornchance=40,replacechance=360}---//����:
			SkillsExList[33427]={prof=11,reqlevel=23,bornchance=40,replacechance=360}---//����:
			SkillsExList[33428]={prof=11,reqlevel=23,bornchance=40,replacechance=360}---//����:
			SkillsExList[33429]={prof=11,reqlevel=24,bornchance=40,replacechance=360}---//����:
			SkillsExList[33430]={prof=11,reqlevel=25,bornchance=40,replacechance=360}---//����:
			SkillsExList[33431]={prof=11,reqlevel=27,bornchance=20,replacechance=480}---//����:
			SkillsExList[33432]={prof=11,reqlevel=28,bornchance=20,replacechance=480}---//����:
			SkillsExList[33433]={prof=11,reqlevel=29,bornchance=20,replacechance=480}---//����:
			SkillsExList[33434]={prof=11,reqlevel=30,bornchance=20,replacechance=480}---//����:

			SkillsExList[34035]={prof=12,reqlevel=3,bornchance=640,replacechance=120}---//����:
			SkillsExList[34036]={prof=12,reqlevel=4,bornchance=640,replacechance=120}---//����:
			SkillsExList[34037]={prof=12,reqlevel=5,bornchance=640,replacechance=120}---//����:
			SkillsExList[34038]={prof=12,reqlevel=6,bornchance=640,replacechance=120}---//����:
			SkillsExList[34039]={prof=12,reqlevel=7,bornchance=640,replacechance=120}---//����:
			SkillsExList[34040]={prof=12,reqlevel=9,bornchance=560,replacechance=180}---//����:
			SkillsExList[34041]={prof=12,reqlevel=11,bornchance=560,replacechance=180}---//����:
			SkillsExList[34042]={prof=12,reqlevel=12,bornchance=560,replacechance=180}---//����:
			SkillsExList[34043]={prof=12,reqlevel=14,bornchance=560,replacechance=180}---//����:
			SkillsExList[34044]={prof=12,reqlevel=13,bornchance=560,replacechance=180}---//����:
			SkillsExList[34045]={prof=12,reqlevel=15,bornchance=240,replacechance=240}---//����:
			SkillsExList[34046]={prof=12,reqlevel=15,bornchance=240,replacechance=240}---//����:
			SkillsExList[34047]={prof=12,reqlevel=17,bornchance=240,replacechance=240}---//����:
			SkillsExList[34048]={prof=12,reqlevel=18,bornchance=240,replacechance=240}---//����:
			SkillsExList[34049]={prof=12,reqlevel=19,bornchance=240,replacechance=240}---//����:
			SkillsExList[34050]={prof=12,reqlevel=21,bornchance=40,replacechance=360}---//����:
			SkillsExList[34051]={prof=12,reqlevel=23,bornchance=40,replacechance=360}---//����:
			SkillsExList[34052]={prof=12,reqlevel=23,bornchance=40,replacechance=360}---//����:
			SkillsExList[34053]={prof=12,reqlevel=24,bornchance=40,replacechance=360}---//����:
			SkillsExList[34054]={prof=12,reqlevel=25,bornchance=40,replacechance=360}---//����:
			SkillsExList[34055]={prof=12,reqlevel=27,bornchance=20,replacechance=480}---//����:
			SkillsExList[34056]={prof=12,reqlevel=28,bornchance=20,replacechance=480}---//����:
			SkillsExList[34057]={prof=12,reqlevel=29,bornchance=20,replacechance=480}---//����:
			SkillsExList[34058]={prof=12,reqlevel=30,bornchance=20,replacechance=480}---//����:
			
			---ǣ��
			SkillsExList[34707]={prof=13,reqlevel=3,bornchance=640,replacechance=120}---//����:
			SkillsExList[34708]={prof=13,reqlevel=4,bornchance=640,replacechance=120}---//����:
			SkillsExList[34709]={prof=13,reqlevel=5,bornchance=640,replacechance=120}---//����:
			SkillsExList[34710]={prof=13,reqlevel=6,bornchance=640,replacechance=120}---//����:
			SkillsExList[34711]={prof=13,reqlevel=7,bornchance=640,replacechance=120}---//����:
			SkillsExList[34712]={prof=13,reqlevel=9,bornchance=560,replacechance=180}---//����:
			SkillsExList[34713]={prof=13,reqlevel=11,bornchance=560,replacechance=180}---//����:
			SkillsExList[34714]={prof=13,reqlevel=12,bornchance=560,replacechance=180}---//����:
			SkillsExList[34715]={prof=13,reqlevel=14,bornchance=560,replacechance=180}---//����:
			SkillsExList[34716]={prof=13,reqlevel=13,bornchance=560,replacechance=180}---//����:
			SkillsExList[34717]={prof=13,reqlevel=15,bornchance=240,replacechance=240}---//����:
			SkillsExList[34718]={prof=13,reqlevel=15,bornchance=240,replacechance=240}---//����:
			SkillsExList[34719]={prof=13,reqlevel=17,bornchance=240,replacechance=240}---//����:
			SkillsExList[34720]={prof=13,reqlevel=18,bornchance=240,replacechance=240}---//����:
			SkillsExList[34721]={prof=13,reqlevel=19,bornchance=240,replacechance=240}---//����:
			SkillsExList[34722]={prof=13,reqlevel=21,bornchance=40,replacechance=360}---//����:
			SkillsExList[34723]={prof=13,reqlevel=23,bornchance=40,replacechance=360}---//����:
			SkillsExList[34724]={prof=13,reqlevel=23,bornchance=40,replacechance=360}---//����:
			SkillsExList[34725]={prof=13,reqlevel=24,bornchance=40,replacechance=360}---//����:
			SkillsExList[34726]={prof=13,reqlevel=25,bornchance=40,replacechance=360}---//����:
			SkillsExList[34727]={prof=13,reqlevel=27,bornchance=20,replacechance=480}---//����:
			SkillsExList[34728]={prof=13,reqlevel=28,bornchance=20,replacechance=480}---//����:
			SkillsExList[34729]={prof=13,reqlevel=29,bornchance=20,replacechance=480}---//����:
			SkillsExList[34730]={prof=13,reqlevel=30,bornchance=20,replacechance=480}---//����:

			---Ӣ��
			SkillsExList[34731]={prof=14,reqlevel=3,bornchance=640,replacechance=120}---//����:
			SkillsExList[34732]={prof=14,reqlevel=4,bornchance=640,replacechance=120}---//����:
			SkillsExList[34733]={prof=14,reqlevel=5,bornchance=640,replacechance=120}---//����:
			SkillsExList[34734]={prof=14,reqlevel=6,bornchance=640,replacechance=120}---//����:
			SkillsExList[34735]={prof=14,reqlevel=7,bornchance=640,replacechance=120}---//����:
			SkillsExList[34736]={prof=14,reqlevel=9,bornchance=560,replacechance=180}---//����:
			SkillsExList[34737]={prof=14,reqlevel=11,bornchance=560,replacechance=180}---//����:
			SkillsExList[34738]={prof=14,reqlevel=12,bornchance=560,replacechance=180}---//����:
			SkillsExList[34739]={prof=14,reqlevel=14,bornchance=560,replacechance=180}---//����:
			SkillsExList[34740]={prof=14,reqlevel=13,bornchance=560,replacechance=180}---//����:
			SkillsExList[34741]={prof=14,reqlevel=15,bornchance=240,replacechance=240}---//����:
			SkillsExList[34742]={prof=14,reqlevel=15,bornchance=240,replacechance=240}---//����:
			SkillsExList[34743]={prof=14,reqlevel=17,bornchance=240,replacechance=240}---//����:
			SkillsExList[34744]={prof=14,reqlevel=18,bornchance=240,replacechance=240}---//����:
			SkillsExList[34745]={prof=14,reqlevel=19,bornchance=240,replacechance=240}---//����:
			SkillsExList[34746]={prof=14,reqlevel=21,bornchance=40,replacechance=360}---//����:
			SkillsExList[34747]={prof=14,reqlevel=23,bornchance=40,replacechance=360}---//����:
			SkillsExList[34748]={prof=14,reqlevel=23,bornchance=40,replacechance=360}---//����:
			SkillsExList[34749]={prof=14,reqlevel=24,bornchance=40,replacechance=360}---//����:
			SkillsExList[34750]={prof=14,reqlevel=25,bornchance=40,replacechance=360}---//����:
			SkillsExList[34751]={prof=14,reqlevel=27,bornchance=20,replacechance=480}---//����:
			SkillsExList[34752]={prof=14,reqlevel=28,bornchance=20,replacechance=480}---//����:
			SkillsExList[34753]={prof=14,reqlevel=29,bornchance=20,replacechance=480}---//����:
			SkillsExList[34754]={prof=14,reqlevel=30,bornchance=20,replacechance=480}---//����:

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
		TalismanEnchantSkillCid[11681]={prof=99,enchantskilltype=0,enchantskillid=337,maxsameskillcol=1} ---//��������
		TalismanEnchantSkillCid[23882]={prof=99,enchantskilltype=0,enchantskillid=337,maxsameskillcol=1} ---//��������
		
		---//TalismanEnchantSkillCid[11680]={prof=9,enchantskilltype=1,enchantskillid=337,maxsameskillcol=1} ---//ͨ������		
		---//������enchantskilltype=2�ϲ�
			
		TalismanEnchantSkillCid[11676]={prof=1,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->����
		TalismanEnchantSkillCid[11677]={prof=2,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->�ϻ�
		TalismanEnchantSkillCid[11678]={prof=3,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->����
		TalismanEnchantSkillCid[11679]={prof=4,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->����
		TalismanEnchantSkillCid[17832]={prof=5,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->���
		TalismanEnchantSkillCid[49380]={prof=6,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->����
		TalismanEnchantSkillCid[31623]={prof=7,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->����
		TalismanEnchantSkillCid[31624]={prof=8,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->��ɽ
		TalismanEnchantSkillCid[39925]={prof=9,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->����
		TalismanEnchantSkillCid[39926]={prof=10,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->�컪
		TalismanEnchantSkillCid[49381]={prof=11,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->̫�
		TalismanEnchantSkillCid[54051]={prof=12,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->����
		TalismanEnchantSkillCid[58850]={prof=13,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->ǣ��
		TalismanEnchantSkillCid[58851]={prof=14,enchantskilltype=2,enchantskillid=337,maxsameskillcol=1} ---//��������->Ӣ��

		TalismanEnchantSkillCid[11572]={prof=21,enchantskilltype=3,enchantskillid=337,maxsameskillcol=1} ---//�ػ�->��ý
		TalismanEnchantSkillCid[11571]={prof=21,enchantskilltype=3,enchantskillid=338,maxsameskillcol=1} ---//����->��ý

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
		TalismanEnchantSkillCid[11590]={prof=1,enchantskilltype=3,enchantskillid=872,maxsameskillcol=1} ---//����¾ɱ->��ý
		TalismanEnchantSkillCid[11592]={prof=1,enchantskilltype=3,enchantskillid=873,maxsameskillcol=1} ---//������->��ý
		TalismanEnchantSkillCid[11594]={prof=1,enchantskilltype=3,enchantskillid=874,maxsameskillcol=1} ---//������->��ý
		TalismanEnchantSkillCid[11593]={prof=1,enchantskilltype=3,enchantskillid=875,maxsameskillcol=1} ---//������ɱ->��ý
		TalismanEnchantSkillCid[11591]={prof=1,enchantskilltype=3,enchantskillid=876,maxsameskillcol=1} ---//�Խ���->��ý
		TalismanEnchantSkillCid[11597]={prof=1,enchantskilltype=3,enchantskillid=877,maxsameskillcol=1} ---//ħ������->��ý
		TalismanEnchantSkillCid[11596]={prof=1,enchantskilltype=3,enchantskillid=878,maxsameskillcol=1} ---//���鷴��->��ý
		TalismanEnchantSkillCid[11595]={prof=1,enchantskilltype=3,enchantskillid=900,maxsameskillcol=1} ---//�������->��ý
		TalismanEnchantSkillCid[11598]={prof=1,enchantskilltype=3,enchantskillid=901,maxsameskillcol=1} ---//δ��ն->��ý

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
		TalismanEnchantSkillCid[11614]={prof=2,enchantskilltype=3,enchantskillid=879,maxsameskillcol=1} ---//��Ӱ->��ý
		TalismanEnchantSkillCid[11616]={prof=2,enchantskilltype=3,enchantskillid=880,maxsameskillcol=1} ---//��ϼ->��ý
		TalismanEnchantSkillCid[11618]={prof=2,enchantskilltype=3,enchantskillid=881,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11615]={prof=2,enchantskilltype=3,enchantskillid=882,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11617]={prof=2,enchantskilltype=3,enchantskillid=883,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11620]={prof=2,enchantskilltype=3,enchantskillid=884,maxsameskillcol=1} ---//����->��ý
		TalismanEnchantSkillCid[11622]={prof=2,enchantskilltype=3,enchantskillid=885,maxsameskillcol=1} ---//ϧ��->��ý
		TalismanEnchantSkillCid[11621]={prof=2,enchantskilltype=3,enchantskillid=902,maxsameskillcol=1} ---//��Ӱ->��ý
		TalismanEnchantSkillCid[11619]={prof=2,enchantskilltype=3,enchantskillid=903,maxsameskillcol=1} ---//�绨ѩ��->��ý

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
		TalismanEnchantSkillCid[11638]={prof=3,enchantskilltype=3,enchantskillid=886,maxsameskillcol=1} ---//˪��ѩ��->��ý
		TalismanEnchantSkillCid[11641]={prof=3,enchantskilltype=3,enchantskillid=887,maxsameskillcol=1} ---//������->��ý
		TalismanEnchantSkillCid[11642]={prof=3,enchantskilltype=3,enchantskillid=888,maxsameskillcol=1} ---//���｣��->��ý
		TalismanEnchantSkillCid[11639]={prof=3,enchantskilltype=3,enchantskillid=889,maxsameskillcol=1} ---//��ز���->��ý
		TalismanEnchantSkillCid[11640]={prof=3,enchantskilltype=3,enchantskillid=890,maxsameskillcol=1} ---//���ӡ->��ý
		TalismanEnchantSkillCid[11643]={prof=3,enchantskilltype=3,enchantskillid=891,maxsameskillcol=1} ---//�׹������->��ý
		TalismanEnchantSkillCid[11646]={prof=3,enchantskilltype=3,enchantskillid=892,maxsameskillcol=1} ---//������->��ý
		TalismanEnchantSkillCid[11645]={prof=3,enchantskilltype=3,enchantskillid=904,maxsameskillcol=1} ---//̫���������->��ý
		TalismanEnchantSkillCid[11644]={prof=3,enchantskilltype=3,enchantskillid=905,maxsameskillcol=1} ---//���������->��ý

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
		TalismanEnchantSkillCid[11669]={prof=4,enchantskilltype=3,enchantskillid=893,maxsameskillcol=1} ---//�黨����->��ý
		TalismanEnchantSkillCid[11667]={prof=4,enchantskilltype=3,enchantskillid=894,maxsameskillcol=1} ---//��������->��ý
		TalismanEnchantSkillCid[11670]={prof=4,enchantskilltype=3,enchantskillid=895,maxsameskillcol=1} ---//���ѭ��->��ý
		TalismanEnchantSkillCid[11668]={prof=4,enchantskilltype=3,enchantskillid=896,maxsameskillcol=1} ---//�����ֻ�->��ý
		TalismanEnchantSkillCid[11666]={prof=4,enchantskilltype=3,enchantskillid=897,maxsameskillcol=1} ---//�Ⱥ���Ը->��ý
		TalismanEnchantSkillCid[11672]={prof=4,enchantskilltype=3,enchantskillid=898,maxsameskillcol=1} ---//��������->��ý
		TalismanEnchantSkillCid[11674]={prof=4,enchantskilltype=3,enchantskillid=899,maxsameskillcol=1} ---//��������->��ý
		TalismanEnchantSkillCid[11671]={prof=4,enchantskilltype=3,enchantskillid=906,maxsameskillcol=1} ---//�󷲰���->��ý
		TalismanEnchantSkillCid[11673]={prof=4,enchantskilltype=3,enchantskillid=907,maxsameskillcol=1} ---//��������->��ý

		TalismanEnchantSkillCid[17862]={prof=5,enchantskilltype=3,enchantskillid=1758,maxsameskillcol=1}---//�޹�����->��ý
		TalismanEnchantSkillCid[17864]={prof=5,enchantskilltype=3,enchantskillid=1759,maxsameskillcol=1}---//���Ƕ�ɰ->��ý
		TalismanEnchantSkillCid[17866]={prof=5,enchantskilltype=3,enchantskillid=1760,maxsameskillcol=1}---//�Ļ���צ->��ý
		TalismanEnchantSkillCid[17867]={prof=5,enchantskilltype=3,enchantskillid=1761,maxsameskillcol=1}---//���ض�â->��ý
		TalismanEnchantSkillCid[17868]={prof=5,enchantskilltype=3,enchantskillid=1762,maxsameskillcol=1}---//�ɻ�Ѫ��->��ý
		TalismanEnchantSkillCid[17869]={prof=5,enchantskilltype=3,enchantskillid=1763,maxsameskillcol=1}---//��������->��ý
		TalismanEnchantSkillCid[17870]={prof=5,enchantskilltype=3,enchantskillid=1764,maxsameskillcol=1}---//ʴ�Ķ���->��ý
		TalismanEnchantSkillCid[17871]={prof=5,enchantskilltype=3,enchantskillid=1765,maxsameskillcol=1}---//��ɳ��Ӱ->��ý
		TalismanEnchantSkillCid[17872]={prof=5,enchantskilltype=3,enchantskillid=1766,maxsameskillcol=1}---//��Ѫ����->��ý
		TalismanEnchantSkillCid[17873]={prof=5,enchantskilltype=3,enchantskillid=1767,maxsameskillcol=1}---//����а��->��ý
		TalismanEnchantSkillCid[17874]={prof=5,enchantskilltype=3,enchantskillid=1768,maxsameskillcol=1}---//��ɳ����->��ý
		TalismanEnchantSkillCid[17875]={prof=5,enchantskilltype=3,enchantskillid=1769,maxsameskillcol=1}---//Թ����ħ->��ý
		TalismanEnchantSkillCid[17876]={prof=5,enchantskilltype=3,enchantskillid=1770,maxsameskillcol=1}---//�����߹�->��ý
		TalismanEnchantSkillCid[17877]={prof=5,enchantskilltype=3,enchantskillid=1771,maxsameskillcol=1}---//���ǵش�->��ý
		TalismanEnchantSkillCid[17878]={prof=5,enchantskilltype=3,enchantskillid=1772,maxsameskillcol=1}---//�����Ϯ->��ý
		TalismanEnchantSkillCid[17879]={prof=5,enchantskilltype=3,enchantskillid=1773,maxsameskillcol=1}---//Ļ���ɳ->��ý
		TalismanEnchantSkillCid[17880]={prof=5,enchantskilltype=3,enchantskillid=1774,maxsameskillcol=1}---//�ٹ�ࢻ�->��ý
		TalismanEnchantSkillCid[17881]={prof=5,enchantskilltype=3,enchantskillid=1775,maxsameskillcol=1}---//ȼ��ٻ�->��ý
		TalismanEnchantSkillCid[17882]={prof=5,enchantskilltype=3,enchantskillid=1776,maxsameskillcol=1}---//����ʴ��->��ý
		TalismanEnchantSkillCid[17883]={prof=5,enchantskilltype=3,enchantskillid=1777,maxsameskillcol=1}---//ɭ����Ц->��ý
		TalismanEnchantSkillCid[17884]={prof=5,enchantskilltype=3,enchantskillid=1778,maxsameskillcol=1}---//�����->��ý
		TalismanEnchantSkillCid[17885]={prof=5,enchantskilltype=3,enchantskillid=1779,maxsameskillcol=1}---//а�����->��ý
		TalismanEnchantSkillCid[17886]={prof=5,enchantskilltype=3,enchantskillid=1780,maxsameskillcol=1}---//�������->��ý
		TalismanEnchantSkillCid[17887]={prof=5,enchantskilltype=3,enchantskillid=1781,maxsameskillcol=1}---//��ѡ��Թ->��ý

		TalismanEnchantSkillCid[49392]={prof=6,enchantskilltype=3,enchantskillid=33387,maxsameskillcol=1}---//�ǻ�->��ý
		TalismanEnchantSkillCid[49393]={prof=6,enchantskilltype=3,enchantskillid=33388,maxsameskillcol=1}---//����->��ý
		TalismanEnchantSkillCid[49394]={prof=6,enchantskilltype=3,enchantskillid=33389,maxsameskillcol=1}---//ԭ��->��ý
		TalismanEnchantSkillCid[49395]={prof=6,enchantskilltype=3,enchantskillid=33390,maxsameskillcol=1}---//����->��ý
		TalismanEnchantSkillCid[49396]={prof=6,enchantskilltype=3,enchantskillid=33391,maxsameskillcol=1}---//����->��ý
		TalismanEnchantSkillCid[49397]={prof=6,enchantskilltype=3,enchantskillid=33392,maxsameskillcol=1}---//����Ϯ->��ý
		TalismanEnchantSkillCid[49398]={prof=6,enchantskilltype=3,enchantskillid=33393,maxsameskillcol=1}---//������->��ý
		TalismanEnchantSkillCid[49399]={prof=6,enchantskilltype=3,enchantskillid=33394,maxsameskillcol=1}---//һ����->��ý
		TalismanEnchantSkillCid[49400]={prof=6,enchantskilltype=3,enchantskillid=33395,maxsameskillcol=1}---//ҵ��ɱ->��ý
		TalismanEnchantSkillCid[49401]={prof=6,enchantskilltype=3,enchantskillid=33396,maxsameskillcol=1}---//��а��->��ý
		TalismanEnchantSkillCid[49402]={prof=6,enchantskilltype=3,enchantskillid=33397,maxsameskillcol=1}---//��ζ���->��ý
		TalismanEnchantSkillCid[49403]={prof=6,enchantskilltype=3,enchantskillid=33398,maxsameskillcol=1}---//�ױ��˻�->��ý
		TalismanEnchantSkillCid[49404]={prof=6,enchantskilltype=3,enchantskillid=33399,maxsameskillcol=1}---//���Ի���->��ý
		TalismanEnchantSkillCid[49405]={prof=6,enchantskilltype=3,enchantskillid=33400,maxsameskillcol=1}---//������Թ->��ý
		TalismanEnchantSkillCid[49406]={prof=6,enchantskilltype=3,enchantskillid=33401,maxsameskillcol=1}---//�ٻ�����->��ý
		TalismanEnchantSkillCid[49407]={prof=6,enchantskilltype=3,enchantskillid=33402,maxsameskillcol=1}---//��������->��ý
		TalismanEnchantSkillCid[49408]={prof=6,enchantskilltype=3,enchantskillid=33403,maxsameskillcol=1}---//����ǧ��->��ý
		TalismanEnchantSkillCid[49409]={prof=6,enchantskilltype=3,enchantskillid=33404,maxsameskillcol=1}---//�������->��ý
		TalismanEnchantSkillCid[49410]={prof=6,enchantskilltype=3,enchantskillid=33405,maxsameskillcol=1}---//�����ٲ�->��ý
		TalismanEnchantSkillCid[49411]={prof=6,enchantskilltype=3,enchantskillid=33406,maxsameskillcol=1}---//ף�����->��ý
		TalismanEnchantSkillCid[49413]={prof=6,enchantskilltype=3,enchantskillid=33407,maxsameskillcol=1}---//�������->��ý
		TalismanEnchantSkillCid[49414]={prof=6,enchantskilltype=3,enchantskillid=33408,maxsameskillcol=1}---//̫Ԩҵ��->��ý
		TalismanEnchantSkillCid[49415]={prof=6,enchantskilltype=3,enchantskillid=33409,maxsameskillcol=1}---//�������->��ý
		TalismanEnchantSkillCid[49416]={prof=6,enchantskilltype=3,enchantskillid=33410,maxsameskillcol=1}---//��������->��ý

		TalismanEnchantSkillCid[31331]={prof=7,enchantskilltype=3,enchantskillid=3510,maxsameskillcol=1}--//һ��->��ý
		TalismanEnchantSkillCid[31332]={prof=7,enchantskilltype=3,enchantskillid=3511,maxsameskillcol=1}--//ŭ��->��ý
		TalismanEnchantSkillCid[31333]={prof=7,enchantskilltype=3,enchantskillid=3512,maxsameskillcol=1}--//����->��ý
		TalismanEnchantSkillCid[31334]={prof=7,enchantskilltype=3,enchantskillid=3513,maxsameskillcol=1}--//��β->��ý
		TalismanEnchantSkillCid[31335]={prof=7,enchantskilltype=3,enchantskillid=3514,maxsameskillcol=1}--//����->��ý
		TalismanEnchantSkillCid[31336]={prof=7,enchantskilltype=3,enchantskillid=3515,maxsameskillcol=1}--//����->��ý
		TalismanEnchantSkillCid[31337]={prof=7,enchantskilltype=3,enchantskillid=3516,maxsameskillcol=1}--//����->��ý
		TalismanEnchantSkillCid[31338]={prof=7,enchantskilltype=3,enchantskillid=3517,maxsameskillcol=1}--//����->��ý
		TalismanEnchantSkillCid[31339]={prof=7,enchantskilltype=3,enchantskillid=3518,maxsameskillcol=1}--//��Ѫ->��ý
		TalismanEnchantSkillCid[31340]={prof=7,enchantskilltype=3,enchantskillid=3519,maxsameskillcol=1}--//�Ƽ�->��ý
		TalismanEnchantSkillCid[31341]={prof=7,enchantskilltype=3,enchantskillid=3520,maxsameskillcol=1}--//ɽ�->��ý
		TalismanEnchantSkillCid[31342]={prof=7,enchantskilltype=3,enchantskillid=3521,maxsameskillcol=1}--//����->��ý
		TalismanEnchantSkillCid[31343]={prof=7,enchantskilltype=3,enchantskillid=3522,maxsameskillcol=1}--//����->��ý
		TalismanEnchantSkillCid[31344]={prof=7,enchantskilltype=3,enchantskillid=3523,maxsameskillcol=1}--//����->��ý
		TalismanEnchantSkillCid[31345]={prof=7,enchantskilltype=3,enchantskillid=3524,maxsameskillcol=1}--//��ɷ->��ý
		TalismanEnchantSkillCid[31346]={prof=7,enchantskilltype=3,enchantskillid=3525,maxsameskillcol=1}--//��ɽ->��ý
		TalismanEnchantSkillCid[31347]={prof=7,enchantskilltype=3,enchantskillid=3526,maxsameskillcol=1}--//����->��ý
		TalismanEnchantSkillCid[31348]={prof=7,enchantskilltype=3,enchantskillid=3527,maxsameskillcol=1}--//�ѿ�->��ý
		TalismanEnchantSkillCid[31349]={prof=7,enchantskilltype=3,enchantskillid=3528,maxsameskillcol=1}--//ɱ¾->��ý
		TalismanEnchantSkillCid[31350]={prof=7,enchantskilltype=3,enchantskillid=3529,maxsameskillcol=1}--//����->��ý
		TalismanEnchantSkillCid[31351]={prof=7,enchantskilltype=3,enchantskillid=3530,maxsameskillcol=1}--//����->��ý
		TalismanEnchantSkillCid[31352]={prof=7,enchantskilltype=3,enchantskillid=3531,maxsameskillcol=1}--//����->��ý
		TalismanEnchantSkillCid[31353]={prof=7,enchantskilltype=3,enchantskillid=3532,maxsameskillcol=1}--//��->��ý
		TalismanEnchantSkillCid[31354]={prof=7,enchantskilltype=3,enchantskillid=3533,maxsameskillcol=1}--//��ս->��ý

		TalismanEnchantSkillCid[31355]={prof=8,enchantskilltype=3,enchantskillid=3534,maxsameskillcol=1}--//����ʸ->��ý
		TalismanEnchantSkillCid[31356]={prof=8,enchantskilltype=3,enchantskillid=3535,maxsameskillcol=1}--//����ʸ->��ý
		TalismanEnchantSkillCid[31357]={prof=8,enchantskilltype=3,enchantskillid=3536,maxsameskillcol=1}--//��â��->��ý
		TalismanEnchantSkillCid[31358]={prof=8,enchantskilltype=3,enchantskillid=3537,maxsameskillcol=1}--//������->��ý
		TalismanEnchantSkillCid[31359]={prof=8,enchantskilltype=3,enchantskillid=3538,maxsameskillcol=1}--//�����->��ý
		TalismanEnchantSkillCid[31360]={prof=8,enchantskilltype=3,enchantskillid=3539,maxsameskillcol=1}--//��Ѫʸ->��ý
		TalismanEnchantSkillCid[31361]={prof=8,enchantskilltype=3,enchantskillid=3540,maxsameskillcol=1}--//ѣ��ʸ->��ý
		TalismanEnchantSkillCid[31362]={prof=8,enchantskilltype=3,enchantskillid=3541,maxsameskillcol=1}--//������->��ý
		TalismanEnchantSkillCid[31363]={prof=8,enchantskilltype=3,enchantskillid=3542,maxsameskillcol=1}--//�����->��ý
		TalismanEnchantSkillCid[31364]={prof=8,enchantskilltype=3,enchantskillid=3543,maxsameskillcol=1}--//������->��ý
		TalismanEnchantSkillCid[31365]={prof=8,enchantskilltype=3,enchantskillid=3544,maxsameskillcol=1}--//���»�->��ý
		TalismanEnchantSkillCid[31366]={prof=8,enchantskilltype=3,enchantskillid=3545,maxsameskillcol=1}--//��ħʸ->��ý
		TalismanEnchantSkillCid[31367]={prof=8,enchantskilltype=3,enchantskillid=3546,maxsameskillcol=1}--//������->��ý
		TalismanEnchantSkillCid[31368]={prof=8,enchantskilltype=3,enchantskillid=3547,maxsameskillcol=1}--//������->��ý
		TalismanEnchantSkillCid[31369]={prof=8,enchantskilltype=3,enchantskillid=3548,maxsameskillcol=1}--//�����->��ý
		TalismanEnchantSkillCid[31370]={prof=8,enchantskilltype=3,enchantskillid=3549,maxsameskillcol=1}--//˫�ɻ�->��ý
		TalismanEnchantSkillCid[31371]={prof=8,enchantskilltype=3,enchantskillid=3550,maxsameskillcol=1}--//������->��ý
		TalismanEnchantSkillCid[31372]={prof=8,enchantskilltype=3,enchantskillid=3551,maxsameskillcol=1}--//����׹->��ý
		TalismanEnchantSkillCid[31373]={prof=8,enchantskilltype=3,enchantskillid=3552,maxsameskillcol=1}--//ʧ����->��ý
		TalismanEnchantSkillCid[31618]={prof=8,enchantskilltype=3,enchantskillid=3553,maxsameskillcol=1}--//����ɽ->��ý
		TalismanEnchantSkillCid[31374]={prof=8,enchantskilltype=3,enchantskillid=3554,maxsameskillcol=1}--//������->��ý
		TalismanEnchantSkillCid[31375]={prof=8,enchantskilltype=3,enchantskillid=3555,maxsameskillcol=1}--//������->��ý
		TalismanEnchantSkillCid[31376]={prof=8,enchantskilltype=3,enchantskillid=3556,maxsameskillcol=1}--//�ֻ���->��ý
		TalismanEnchantSkillCid[31377]={prof=8,enchantskilltype=3,enchantskillid=3557,maxsameskillcol=1}--//���뻢->��ý

		TalismanEnchantSkillCid[39990]={prof=9,enchantskilltype=3,enchantskillid=3972,maxsameskillcol=1}
		TalismanEnchantSkillCid[39991]={prof=9,enchantskilltype=3,enchantskillid=3973,maxsameskillcol=1}
		TalismanEnchantSkillCid[39992]={prof=9,enchantskilltype=3,enchantskillid=3974,maxsameskillcol=1}
		TalismanEnchantSkillCid[39993]={prof=9,enchantskilltype=3,enchantskillid=3975,maxsameskillcol=1}
		TalismanEnchantSkillCid[39994]={prof=9,enchantskilltype=3,enchantskillid=3976,maxsameskillcol=1}
		TalismanEnchantSkillCid[39995]={prof=9,enchantskilltype=3,enchantskillid=3977,maxsameskillcol=1}
		TalismanEnchantSkillCid[39996]={prof=9,enchantskilltype=3,enchantskillid=3978,maxsameskillcol=1}
		TalismanEnchantSkillCid[39997]={prof=9,enchantskilltype=3,enchantskillid=3979,maxsameskillcol=1}
		TalismanEnchantSkillCid[39998]={prof=9,enchantskilltype=3,enchantskillid=3980,maxsameskillcol=1}
		TalismanEnchantSkillCid[39999]={prof=9,enchantskilltype=3,enchantskillid=3981,maxsameskillcol=1}
		TalismanEnchantSkillCid[40000]={prof=9,enchantskilltype=3,enchantskillid=3982,maxsameskillcol=1}
		TalismanEnchantSkillCid[40001]={prof=9,enchantskilltype=3,enchantskillid=3983,maxsameskillcol=1}
		TalismanEnchantSkillCid[40002]={prof=9,enchantskilltype=3,enchantskillid=3984,maxsameskillcol=1}
		TalismanEnchantSkillCid[40003]={prof=9,enchantskilltype=3,enchantskillid=3985,maxsameskillcol=1}
		TalismanEnchantSkillCid[40004]={prof=9,enchantskilltype=3,enchantskillid=3986,maxsameskillcol=1}
		TalismanEnchantSkillCid[40005]={prof=9,enchantskilltype=3,enchantskillid=3987,maxsameskillcol=1}
		TalismanEnchantSkillCid[40006]={prof=9,enchantskilltype=3,enchantskillid=3988,maxsameskillcol=1}
		TalismanEnchantSkillCid[40007]={prof=9,enchantskilltype=3,enchantskillid=3989,maxsameskillcol=1}
		TalismanEnchantSkillCid[40008]={prof=9,enchantskilltype=3,enchantskillid=3990,maxsameskillcol=1}
		TalismanEnchantSkillCid[40009]={prof=9,enchantskilltype=3,enchantskillid=3991,maxsameskillcol=1}
		TalismanEnchantSkillCid[40010]={prof=9,enchantskilltype=3,enchantskillid=3992,maxsameskillcol=1}
		TalismanEnchantSkillCid[40011]={prof=9,enchantskilltype=3,enchantskillid=3993,maxsameskillcol=1}
		TalismanEnchantSkillCid[40012]={prof=9,enchantskilltype=3,enchantskillid=3994,maxsameskillcol=1}
		TalismanEnchantSkillCid[40013]={prof=9,enchantskilltype=3,enchantskillid=3995,maxsameskillcol=1}

		TalismanEnchantSkillCid[40014]={prof=10,enchantskilltype=3,enchantskillid=3996,maxsameskillcol=1}
		TalismanEnchantSkillCid[40015]={prof=10,enchantskilltype=3,enchantskillid=3997,maxsameskillcol=1}
		TalismanEnchantSkillCid[40016]={prof=10,enchantskilltype=3,enchantskillid=3998,maxsameskillcol=1}
		TalismanEnchantSkillCid[40017]={prof=10,enchantskilltype=3,enchantskillid=3999,maxsameskillcol=1}
		TalismanEnchantSkillCid[40018]={prof=10,enchantskilltype=3,enchantskillid=4000,maxsameskillcol=1}
		TalismanEnchantSkillCid[40019]={prof=10,enchantskilltype=3,enchantskillid=4001,maxsameskillcol=1}
		TalismanEnchantSkillCid[40020]={prof=10,enchantskilltype=3,enchantskillid=4002,maxsameskillcol=1}
		TalismanEnchantSkillCid[40021]={prof=10,enchantskilltype=3,enchantskillid=4003,maxsameskillcol=1}
		TalismanEnchantSkillCid[40022]={prof=10,enchantskilltype=3,enchantskillid=4004,maxsameskillcol=1}
		TalismanEnchantSkillCid[40023]={prof=10,enchantskilltype=3,enchantskillid=4005,maxsameskillcol=1}
		TalismanEnchantSkillCid[40024]={prof=10,enchantskilltype=3,enchantskillid=4006,maxsameskillcol=1}
		TalismanEnchantSkillCid[40025]={prof=10,enchantskilltype=3,enchantskillid=4007,maxsameskillcol=1}
		TalismanEnchantSkillCid[40026]={prof=10,enchantskilltype=3,enchantskillid=4008,maxsameskillcol=1}
		TalismanEnchantSkillCid[40027]={prof=10,enchantskilltype=3,enchantskillid=4009,maxsameskillcol=1}
		TalismanEnchantSkillCid[40028]={prof=10,enchantskilltype=3,enchantskillid=4010,maxsameskillcol=1}
		TalismanEnchantSkillCid[40029]={prof=10,enchantskilltype=3,enchantskillid=4011,maxsameskillcol=1}
		TalismanEnchantSkillCid[40030]={prof=10,enchantskilltype=3,enchantskillid=4012,maxsameskillcol=1}
		TalismanEnchantSkillCid[40031]={prof=10,enchantskilltype=3,enchantskillid=4013,maxsameskillcol=1}
		TalismanEnchantSkillCid[40032]={prof=10,enchantskilltype=3,enchantskillid=4014,maxsameskillcol=1}
		TalismanEnchantSkillCid[40033]={prof=10,enchantskilltype=3,enchantskillid=4015,maxsameskillcol=1}
		TalismanEnchantSkillCid[40034]={prof=10,enchantskilltype=3,enchantskillid=4016,maxsameskillcol=1}
		TalismanEnchantSkillCid[40035]={prof=10,enchantskilltype=3,enchantskillid=4017,maxsameskillcol=1}
		TalismanEnchantSkillCid[40036]={prof=10,enchantskilltype=3,enchantskillid=4018,maxsameskillcol=1}
		TalismanEnchantSkillCid[40037]={prof=10,enchantskilltype=3,enchantskillid=4019,maxsameskillcol=1}

		TalismanEnchantSkillCid[49543]={prof=11,enchantskilltype=3,enchantskillid=33411,maxsameskillcol=1}
		TalismanEnchantSkillCid[49544]={prof=11,enchantskilltype=3,enchantskillid=33412,maxsameskillcol=1}
		TalismanEnchantSkillCid[49545]={prof=11,enchantskilltype=3,enchantskillid=33413,maxsameskillcol=1}
		TalismanEnchantSkillCid[49546]={prof=11,enchantskilltype=3,enchantskillid=33414,maxsameskillcol=1}
		TalismanEnchantSkillCid[49547]={prof=11,enchantskilltype=3,enchantskillid=33415,maxsameskillcol=1}
		TalismanEnchantSkillCid[49548]={prof=11,enchantskilltype=3,enchantskillid=33416,maxsameskillcol=1}
		TalismanEnchantSkillCid[49549]={prof=11,enchantskilltype=3,enchantskillid=33417,maxsameskillcol=1}
		TalismanEnchantSkillCid[49550]={prof=11,enchantskilltype=3,enchantskillid=33418,maxsameskillcol=1}
		TalismanEnchantSkillCid[49551]={prof=11,enchantskilltype=3,enchantskillid=33419,maxsameskillcol=1}
		TalismanEnchantSkillCid[49552]={prof=11,enchantskilltype=3,enchantskillid=33420,maxsameskillcol=1}
		TalismanEnchantSkillCid[49553]={prof=11,enchantskilltype=3,enchantskillid=33421,maxsameskillcol=1}
		TalismanEnchantSkillCid[49554]={prof=11,enchantskilltype=3,enchantskillid=33422,maxsameskillcol=1}
		TalismanEnchantSkillCid[49555]={prof=11,enchantskilltype=3,enchantskillid=33423,maxsameskillcol=1}
		TalismanEnchantSkillCid[49556]={prof=11,enchantskilltype=3,enchantskillid=33424,maxsameskillcol=1}
		TalismanEnchantSkillCid[49557]={prof=11,enchantskilltype=3,enchantskillid=33425,maxsameskillcol=1}
		TalismanEnchantSkillCid[49558]={prof=11,enchantskilltype=3,enchantskillid=33426,maxsameskillcol=1}
		TalismanEnchantSkillCid[49559]={prof=11,enchantskilltype=3,enchantskillid=33427,maxsameskillcol=1}
		TalismanEnchantSkillCid[49560]={prof=11,enchantskilltype=3,enchantskillid=33428,maxsameskillcol=1}
		TalismanEnchantSkillCid[49561]={prof=11,enchantskilltype=3,enchantskillid=33429,maxsameskillcol=1}
		TalismanEnchantSkillCid[49562]={prof=11,enchantskilltype=3,enchantskillid=33430,maxsameskillcol=1}
		TalismanEnchantSkillCid[49563]={prof=11,enchantskilltype=3,enchantskillid=33431,maxsameskillcol=1}
		TalismanEnchantSkillCid[49564]={prof=11,enchantskilltype=3,enchantskillid=33432,maxsameskillcol=1}
		TalismanEnchantSkillCid[49565]={prof=11,enchantskilltype=3,enchantskillid=33433,maxsameskillcol=1}
		TalismanEnchantSkillCid[49566]={prof=11,enchantskilltype=3,enchantskillid=33434,maxsameskillcol=1}
		
		TalismanEnchantSkillCid[53646]={prof=12,enchantskilltype=3,enchantskillid=34035,maxsameskillcol=1}
		TalismanEnchantSkillCid[53647]={prof=12,enchantskilltype=3,enchantskillid=34036,maxsameskillcol=1}
		TalismanEnchantSkillCid[53648]={prof=12,enchantskilltype=3,enchantskillid=34037,maxsameskillcol=1}
		TalismanEnchantSkillCid[53649]={prof=12,enchantskilltype=3,enchantskillid=34038,maxsameskillcol=1}
		TalismanEnchantSkillCid[53650]={prof=12,enchantskilltype=3,enchantskillid=34039,maxsameskillcol=1}
		TalismanEnchantSkillCid[53651]={prof=12,enchantskilltype=3,enchantskillid=34040,maxsameskillcol=1}
		TalismanEnchantSkillCid[53652]={prof=12,enchantskilltype=3,enchantskillid=34041,maxsameskillcol=1}
		TalismanEnchantSkillCid[53653]={prof=12,enchantskilltype=3,enchantskillid=34042,maxsameskillcol=1}
		TalismanEnchantSkillCid[53654]={prof=12,enchantskilltype=3,enchantskillid=34043,maxsameskillcol=1}
		TalismanEnchantSkillCid[53655]={prof=12,enchantskilltype=3,enchantskillid=34044,maxsameskillcol=1}
		TalismanEnchantSkillCid[53656]={prof=12,enchantskilltype=3,enchantskillid=34045,maxsameskillcol=1}
		TalismanEnchantSkillCid[53657]={prof=12,enchantskilltype=3,enchantskillid=34046,maxsameskillcol=1}
		TalismanEnchantSkillCid[53658]={prof=12,enchantskilltype=3,enchantskillid=34047,maxsameskillcol=1}
		TalismanEnchantSkillCid[53659]={prof=12,enchantskilltype=3,enchantskillid=34048,maxsameskillcol=1}
		TalismanEnchantSkillCid[53660]={prof=12,enchantskilltype=3,enchantskillid=34049,maxsameskillcol=1}
		TalismanEnchantSkillCid[53661]={prof=12,enchantskilltype=3,enchantskillid=34050,maxsameskillcol=1}
		TalismanEnchantSkillCid[53662]={prof=12,enchantskilltype=3,enchantskillid=34051,maxsameskillcol=1}
		TalismanEnchantSkillCid[53663]={prof=12,enchantskilltype=3,enchantskillid=34052,maxsameskillcol=1}
		TalismanEnchantSkillCid[53664]={prof=12,enchantskilltype=3,enchantskillid=34053,maxsameskillcol=1}
		TalismanEnchantSkillCid[53665]={prof=12,enchantskilltype=3,enchantskillid=34054,maxsameskillcol=1}
		TalismanEnchantSkillCid[53666]={prof=12,enchantskilltype=3,enchantskillid=34055,maxsameskillcol=1}
		TalismanEnchantSkillCid[53667]={prof=12,enchantskilltype=3,enchantskillid=34056,maxsameskillcol=1}
		TalismanEnchantSkillCid[53668]={prof=12,enchantskilltype=3,enchantskillid=34057,maxsameskillcol=1}
		TalismanEnchantSkillCid[53669]={prof=12,enchantskilltype=3,enchantskillid=34058,maxsameskillcol=1}

		TalismanEnchantSkillCid[60072]={prof=13,enchantskilltype=3,enchantskillid=34707,maxsameskillcol=1}
		TalismanEnchantSkillCid[60073]={prof=13,enchantskilltype=3,enchantskillid=34708,maxsameskillcol=1}
		TalismanEnchantSkillCid[60074]={prof=13,enchantskilltype=3,enchantskillid=34709,maxsameskillcol=1}
		TalismanEnchantSkillCid[60075]={prof=13,enchantskilltype=3,enchantskillid=34710,maxsameskillcol=1}
		TalismanEnchantSkillCid[60076]={prof=13,enchantskilltype=3,enchantskillid=34711,maxsameskillcol=1}
		TalismanEnchantSkillCid[60077]={prof=13,enchantskilltype=3,enchantskillid=34712,maxsameskillcol=1}
		TalismanEnchantSkillCid[60078]={prof=13,enchantskilltype=3,enchantskillid=34713,maxsameskillcol=1}
		TalismanEnchantSkillCid[60079]={prof=13,enchantskilltype=3,enchantskillid=34714,maxsameskillcol=1}
		TalismanEnchantSkillCid[60080]={prof=13,enchantskilltype=3,enchantskillid=34715,maxsameskillcol=1}
		TalismanEnchantSkillCid[60081]={prof=13,enchantskilltype=3,enchantskillid=34716,maxsameskillcol=1}
		TalismanEnchantSkillCid[60082]={prof=13,enchantskilltype=3,enchantskillid=34717,maxsameskillcol=1}
		TalismanEnchantSkillCid[60083]={prof=13,enchantskilltype=3,enchantskillid=34718,maxsameskillcol=1}
		TalismanEnchantSkillCid[60084]={prof=13,enchantskilltype=3,enchantskillid=34719,maxsameskillcol=1}
		TalismanEnchantSkillCid[60085]={prof=13,enchantskilltype=3,enchantskillid=34720,maxsameskillcol=1}
		TalismanEnchantSkillCid[60086]={prof=13,enchantskilltype=3,enchantskillid=34721,maxsameskillcol=1}
		TalismanEnchantSkillCid[60088]={prof=13,enchantskilltype=3,enchantskillid=34722,maxsameskillcol=1}
		TalismanEnchantSkillCid[60089]={prof=13,enchantskilltype=3,enchantskillid=34723,maxsameskillcol=1}
		TalismanEnchantSkillCid[60090]={prof=13,enchantskilltype=3,enchantskillid=34724,maxsameskillcol=1}
		TalismanEnchantSkillCid[60091]={prof=13,enchantskilltype=3,enchantskillid=34725,maxsameskillcol=1}
		TalismanEnchantSkillCid[60092]={prof=13,enchantskilltype=3,enchantskillid=34726,maxsameskillcol=1}
		TalismanEnchantSkillCid[60093]={prof=13,enchantskilltype=3,enchantskillid=34727,maxsameskillcol=1}
		TalismanEnchantSkillCid[60094]={prof=13,enchantskilltype=3,enchantskillid=34728,maxsameskillcol=1}
		TalismanEnchantSkillCid[60095]={prof=13,enchantskilltype=3,enchantskillid=34729,maxsameskillcol=1}
		TalismanEnchantSkillCid[60096]={prof=13,enchantskilltype=3,enchantskillid=34730,maxsameskillcol=1}

		TalismanEnchantSkillCid[60097]={prof=14,enchantskilltype=3,enchantskillid=34731,maxsameskillcol=1}
		TalismanEnchantSkillCid[60098]={prof=14,enchantskilltype=3,enchantskillid=34732,maxsameskillcol=1}
		TalismanEnchantSkillCid[60099]={prof=14,enchantskilltype=3,enchantskillid=34733,maxsameskillcol=1}
		TalismanEnchantSkillCid[60100]={prof=14,enchantskilltype=3,enchantskillid=34734,maxsameskillcol=1}
		TalismanEnchantSkillCid[60101]={prof=14,enchantskilltype=3,enchantskillid=34735,maxsameskillcol=1}
		TalismanEnchantSkillCid[60102]={prof=14,enchantskilltype=3,enchantskillid=34736,maxsameskillcol=1}
		TalismanEnchantSkillCid[60104]={prof=14,enchantskilltype=3,enchantskillid=34737,maxsameskillcol=1}
		TalismanEnchantSkillCid[60105]={prof=14,enchantskilltype=3,enchantskillid=34738,maxsameskillcol=1}
		TalismanEnchantSkillCid[60106]={prof=14,enchantskilltype=3,enchantskillid=34739,maxsameskillcol=1}
		TalismanEnchantSkillCid[60107]={prof=14,enchantskilltype=3,enchantskillid=34740,maxsameskillcol=1}
		TalismanEnchantSkillCid[60108]={prof=14,enchantskilltype=3,enchantskillid=34741,maxsameskillcol=1}
		TalismanEnchantSkillCid[60109]={prof=14,enchantskilltype=3,enchantskillid=34742,maxsameskillcol=1}
		TalismanEnchantSkillCid[60110]={prof=14,enchantskilltype=3,enchantskillid=34743,maxsameskillcol=1}
		TalismanEnchantSkillCid[60111]={prof=14,enchantskilltype=3,enchantskillid=34744,maxsameskillcol=1}
		TalismanEnchantSkillCid[60113]={prof=14,enchantskilltype=3,enchantskillid=34745,maxsameskillcol=1}
		TalismanEnchantSkillCid[60114]={prof=14,enchantskilltype=3,enchantskillid=34746,maxsameskillcol=1}
		TalismanEnchantSkillCid[60115]={prof=14,enchantskilltype=3,enchantskillid=34747,maxsameskillcol=1}
		TalismanEnchantSkillCid[60116]={prof=14,enchantskilltype=3,enchantskillid=34748,maxsameskillcol=1}
		TalismanEnchantSkillCid[60117]={prof=14,enchantskilltype=3,enchantskillid=34749,maxsameskillcol=1}
		TalismanEnchantSkillCid[60118]={prof=14,enchantskilltype=3,enchantskillid=34750,maxsameskillcol=1}
		TalismanEnchantSkillCid[60119]={prof=14,enchantskilltype=3,enchantskillid=34751,maxsameskillcol=1}
		TalismanEnchantSkillCid[60120]={prof=14,enchantskilltype=3,enchantskillid=34752,maxsameskillcol=1}
		TalismanEnchantSkillCid[60121]={prof=14,enchantskilltype=3,enchantskillid=34753,maxsameskillcol=1}
		TalismanEnchantSkillCid[60122]={prof=14,enchantskilltype=3,enchantskillid=34754,maxsameskillcol=1}

		TalismanEnchantSkillCid[11767]={prof=99,enchantskilltype=4,enchantskillid=337,maxsameskillcol=1} ---//���Կɼ�
		TalismanEnchantSkillCid[23883]={prof=99,enchantskilltype=4,enchantskillid=337,maxsameskillcol=1} ---//���Կɼ�
		TalismanEnchantSkillCid[40472]={prof=99,enchantskilltype=4,enchantskillid=337,maxsameskillcol=1} ---//���Կɼ�
	return TalismanEnchantSkillCid
end 	
-------------------------------------------------------------------------------------------------
---����(���˺�һ������ý)��ID�ͷ������𡺲��ҡ�ĳ��ý��Ӧ�����˺�һ��������id�͸�����������
function ZLuaExistInTalismanEnchantEx(cid,level)
	if type(cid)~="number" or type(level)~="number" then
		return 0,0
	end
	if level<1 then level=1 end
	if level>35 then level=35 end	-- 30�����Ϸ�����ʱ��30������
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
function EnchantTalismans(id, talisman1, cid, output, locked)
	local dataIndex=ZLuaTalDataIndex()
	local talismans=ZLuaTalAvailableTalismans()

	-- û����ý�������ħ
	if cid == 0 then
		output:CreateItem(-1)
		return
	end
	
	-- ûע����ķ����ɽ�����ֹ��ħ
	local Registed = false
	for _,v in pairs(talismans) do
		if v.tmplID == id then Registed = true end
	end
	if Registed == false then
		output:CreateItem(-1)
		return
	end

	-- �������IDΪ�ɱ�ID�����ħʧ��
	if talisman1:QueryData(0,dataIndex["is_fly"])==1 then
		-- ���֮�Ŀ��Ըı�ɽ�Ʒ��
		if cid == 40272 then
			if ZLuaTalisman_ImproveFlyerQuality(id, talisman1, cid, output) == false then
				output:CreateItem(-1)
			end
		else
			output:CreateItem(-1)
		end
		return
	end

	-- Ԫ���Ʋ������ħ
	if id == talismans["US_45_YuanXiaoDeng"].tmplID then
		output:CreateItem(-1)
		return
	end

	-- ���˺�һ��ħ
	local Alevel = talisman1:QueryLevel()
	local exid,bufftype = ZLuaExistInTalismanEnchantEx(cid,Alevel)
	if exid ~= 0 then
		ZLuaTalisman_EnchantBotEx(id, talisman1, cid, output, exid, bufftype)
		return
	end

	-- ������λ����������ħ
	if cid == 19512 or cid == 19513 or cid == 19514 or cid == 19515 
	or cid == 19516 or cid == 19517 or cid == 19518 or cid == 19519 or cid == 19520 then
		ZLuaTalisman_Rise(id, talisman1, cid, output)
		return
	end

	-- ���������Զ���ǿ����ħ
	if cid == 23860 or cid == 23861 or cid == 23862 or cid == 11784 or cid == 12021 or cid == 19716 then
		ZLuaTalisman_Rise2(id, talisman1, cid, output)
		return
	end

	-- ���Ӽ��ܹ�ħ
	local tempprof,tempenchantskilltype,tempenchantskillid,tempmaxsameskillcol=ZLuaExistInTalismanEnchantSkillCid(cid)
	if tempprof~=-1 and locked == false then
		ZLuaTalisman_EnchantSkill(id, talisman1, cid, output,tempprof,tempenchantskilltype,tempenchantskillid,tempmaxsameskillcol)
		return
	end

	-- ����	
	output:CreateItem(-1)
end

------------�������˺�һ��ħ������---------------------------------------------------------------------
function ZLuaTalisman_EnchantBotEx(id, talisman1, cid, output,exid, bufftype)
		if exid~=0 and bufftype~=0 then 			---//���˺�һ��ħ
			output:CreateItem(id)
			local dataIndex=ZLuaTalDataIndex()
			local nowbufftype
			nowbufftype=talisman1:QueryData(0,dataIndex["buff_type"])
			if nowbufftype==bufftype then 
					output:CreateItem(-1)
			else 
				for _,index in pairs(dataIndex) do
					output:UpdateData(0,index,talisman1:QueryData(0,index))
				end
				output:UpdateData(0,dataIndex["buff_type"],bufftype)
				output:UpdateData(0,dataIndex["ext_id"],exid)
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
		SkillNoSeq[1]=talisman1:QueryData(0,dataIndex["addon_1_id"])
		SkillReqLvlSeq[1]=talisman1:QueryData(0,dataIndex["addon_1_learn_level"])
		SkillNoSeq[2]=talisman1:QueryData(0,dataIndex["addon_2_id"])
		SkillReqLvlSeq[2]=talisman1:QueryData(0,dataIndex["addon_2_learn_level"])
		SkillNoSeq[3]=talisman1:QueryData(0,dataIndex["addon_3_id"])
		SkillReqLvlSeq[3]=talisman1:QueryData(0,dataIndex["addon_3_learn_level"])
		SkillNoSeq[4]=talisman1:QueryData(0,dataIndex["addon_4_id"])
		SkillReqLvlSeq[4]=talisman1:QueryData(0,dataIndex["addon_4_learn_level"])
		SkillNoSeq[5]=talisman1:QueryData(0,dataIndex["addon_5_id"])
		SkillReqLvlSeq[5]=talisman1:QueryData(0,dataIndex["addon_5_learn_level"])
		SkillNoSeq[6]=talisman1:QueryData(0,dataIndex["addon_6_id"])
		SkillReqLvlSeq[6]=talisman1:QueryData(0,dataIndex["addon_6_learn_level"])
		
		TalismanSkillID=talisman1:QueryData(0,dataIndex["skill_addon_id"])
	---//���ʵ�ʵ���Ч��������
	for j=1,6 do
		if SkillNoSeq[j]~=0 and SkillReqLvlSeq[j]~=0 and type(SkillReqLvlSeq[j])=="number" then 
			TrueSkillNum=TrueSkillNum+1
		end 
	end 
	
	local talismanprof,talismanskillprof -- ���������ְҵ����,������Я������ְҵ����
	talismanprof,talismanskillprof = ZLuaTalisman_GetProfInfo(id,SkillNoSeq)
	---//���ݷ�����id�ͷ������Ѿ����ڵļ��ܾ�����������������
	local FailtoCreatTalisman=0
	local SkillHighLvlVisible=talisman1:QueryData(0,dataIndex["skill_visible"])
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
		if talismanskillprof==prof 
		or talismanprof==99 
		or (talismanprof==21 and (prof==1 or prof==2 or prof==3 or prof==4 or prof==5 or prof==6))	--�����ְҵ���޸�����
		or (talismanprof==22 and (prof==7 or prof==8 or prof==9 or prof==10 or prof==11 or prof==12))						--�����ְҵ���޸�����
		or (talismanprof==33 and (prof==13 or prof==14))						--�����ְҵ���޸�����
		then 
			SkillNoSeq,SkillReqLvlSeq=ZLuaTalisman_ChooseEnchantSkill(prof,TrueSkillNum,maxsameskillcol)
		else 
			FailtoCreatTalisman=1
			output:CreateItem(-1)
		end 
	elseif (enchantskilltype==3 and prof==talismanskillprof)
			or (enchantskilltype==3 and prof==21 and talismanprof~=99 and talismanprof~=22 and talismanprof~=33 and talismanprof~=7 and talismanprof~=8 and talismanprof~=9 and talismanprof~=10 and talismanprof~=11 and talismanprof~=12 and talismanprof~=13 and talismanprof~=14)	--�����ְҵ���޸�����
			or (enchantskilltype==3 and prof==21 and talismanprof==99 and talismanskillprof~=7 and talismanskillprof~=8 and talismanskillprof~=9 and talismanskillprof~=10 and talismanskillprof~=11 and talismanskillprof~=12 and talismanskillprof~=13 and talismanskillprof~=14)		--�����ְҵ���޸�����
			or (enchantskilltype==3 and talismanprof==99 and talismanskillprof==99)
			then 
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
				output:UpdateData(0,index,talisman1:QueryData(0,index))
			end
			output:UpdateData(0,dataIndex["addon_1_id"],SkillNoSeq[1]or 0)		
			output:UpdateData(0,dataIndex["addon_1_learn_level"],SkillReqLvlSeq[1]or 0)
			output:UpdateData(0,dataIndex["addon_2_id"],SkillNoSeq[2]or 0)		
			output:UpdateData(0,dataIndex["addon_2_learn_level"],SkillReqLvlSeq[2]or 0)
			output:UpdateData(0,dataIndex["addon_3_id"],SkillNoSeq[3]or 0)		
			output:UpdateData(0,dataIndex["addon_3_learn_level"],SkillReqLvlSeq[3]or 0)
			output:UpdateData(0,dataIndex["addon_4_id"],SkillNoSeq[4]or 0)		
			output:UpdateData(0,dataIndex["addon_4_learn_level"],SkillReqLvlSeq[4]or 0)
			output:UpdateData(0,dataIndex["addon_5_id"],SkillNoSeq[5]or 0)		
			output:UpdateData(0,dataIndex["addon_5_learn_level"],SkillReqLvlSeq[5]or 0)
			output:UpdateData(0,dataIndex["addon_6_id"],SkillNoSeq[6]or 0)		
			output:UpdateData(0,dataIndex["addon_6_learn_level"],SkillReqLvlSeq[6]or 0)
		---//�����µķ�������������Ϣ		
			output:UpdateData(0,dataIndex["skill_addon_id"],TalismanSkillID)
		---//�趨���������и������＼�ܿɼ�
			if SkillHighLvlVisible==1 then 
				output:UpdateData(0,dataIndex["skill_visible"],SkillHighLvlVisible)
			end 
		---//�趨��ħϵ�в���	 
			if enchantskilltype==0 then 
				output:UpdateData(0,dataIndex["change_skillnum"],output:QueryData(0,dataIndex["change_skillnum"])+1)			
			elseif enchantskilltype==2 or enchantskilltype==3 then 
				output:UpdateData(0,dataIndex["enchant_times"],output:QueryData(0,dataIndex["enchant_times"])+1)		
			end 
			output:InheritCombineExp(true)
			ZLuaTalRebuild(output,id)
	end 
	
end 
-------���ڷ���levelupʱ�������˺�һ���͹�ħ�ĺ���-------------------------------------------------------------
function ZLuaTalChangeExt(talisman)
	local Alevel=talisman:QueryLevel()
	local dataIndex=ZLuaTalDataIndex()
	local ABuffType=talisman:QueryData(0,dataIndex["buff_type"])
	
	local TalismanEnchantEx=ZLuaTalismanEnchantEx()
	local exid
	if Alevel > 30 then Alevel = 30 end	-- 30�����Ϸ�����ʱ��30������
	for i,v in pairs(TalismanEnchantEx) do
		if v.bufftype==ABuffType and v.exlevel==Alevel then 
			 exid=i  ---���ظ�������id 
			 talisman:UpdateData(0,dataIndex["ext_id"],exid)
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
		SkillsExInfo[872]={1,100,100,43,800,800,800,800,800,800}---//����:����¾ɱ
		SkillsExInfo[873]={1,100,100,43,800,800,800,800,800,800}---//����:������
		SkillsExInfo[874]={1,100,100,43,800,800,800,800,800,800}---//����:������
		SkillsExInfo[875]={1,100,100,43,800,800,800,800,800,800}---//����:������ɱ
		SkillsExInfo[876]={1,100,100,43,800,800,800,800,800,800}---//����:�Խ���
		SkillsExInfo[877]={1,100,400,100,1500,1500,1500,1500,1500,1500}---//����:ħ������
		SkillsExInfo[878]={1,100,400,100,1500,1500,1500,1500,1500,1500}---//����:���鷴��
		SkillsExInfo[900]={1,100,400,100,1500,1500,1500,1500,1500,1500}---//����:�������
		SkillsExInfo[901]={1,100,400,100,1500,1500,1500,1500,1500,1500}---//����:δ��ն

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
		SkillsExInfo[879]={2,100,100,43,800,800,800,800,800,800}---//����:��Ӱ
		SkillsExInfo[880]={2,100,100,43,800,800,800,800,800,800}---//����:��ϼ
		SkillsExInfo[881]={2,100,100,43,800,800,800,800,800,800}---//����:����
		SkillsExInfo[882]={2,100,100,43,800,800,800,800,800,800}---//����:����
		SkillsExInfo[883]={2,100,100,43,800,800,800,800,800,800}---//����:����
		SkillsExInfo[884]={2,100,400,100,1500,1500,1500,1500,1500,1500}---//����:����
		SkillsExInfo[885]={2,100,400,100,1500,1500,1500,1500,1500,1500}---//����:ϧ��
		SkillsExInfo[902]={2,100,400,100,1500,1500,1500,1500,1500,1500}---//����:��Ӱ
		SkillsExInfo[903]={2,100,400,100,1500,1500,1500,1500,1500,1500}---//����:�绨ѩ��

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
		SkillsExInfo[886]={3,100,100,43,800,800,800,800,800,800}---//����:˪��ѩ��
		SkillsExInfo[887]={3,100,100,43,800,800,800,800,800,800}---//����:������
		SkillsExInfo[888]={3,100,100,43,800,800,800,800,800,800}---//����:���｣��
		SkillsExInfo[889]={3,100,100,43,800,800,800,800,800,800}---//����:��ز���
		SkillsExInfo[890]={3,100,100,43,800,800,800,800,800,800}---//����:���ӡ
		SkillsExInfo[891]={3,100,400,100,1500,1500,1500,1500,1500,1500}---//����:�׹������
		SkillsExInfo[892]={3,100,400,100,1500,1500,1500,1500,1500,1500}---//����:������
		SkillsExInfo[904]={3,100,400,100,1500,1500,1500,1500,1500,1500}---//����:̫���������
		SkillsExInfo[905]={3,100,400,100,1500,1500,1500,1500,1500,1500}---//����:���������

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
		SkillsExInfo[893]={4,100,100,43,800,800,800,800,800,800}---//����:�黨����
		SkillsExInfo[894]={4,100,100,43,800,800,800,800,800,800}---//����:��������
		SkillsExInfo[895]={4,100,100,43,800,800,800,800,800,800}---//����:���ѭ��
		SkillsExInfo[896]={4,100,100,43,800,800,800,800,800,800}---//����:�����ֻ�
		SkillsExInfo[897]={4,100,100,43,800,800,800,800,800,800}---//����:�Ⱥ���Ը
		SkillsExInfo[898]={4,100,400,100,1500,1500,1500,1500,1500,1500}---//����:��������
		SkillsExInfo[899]={4,100,400,100,1500,1500,1500,1500,1500,1500}---//����:��������
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

		SkillsExInfo[33387]={6,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[33388]={6,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[33389]={6,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[33390]={6,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[33391]={6,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[33392]={6,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[33393]={6,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[33394]={6,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[33395]={6,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[33396]={6,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[33397]={6,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[33398]={6,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[33399]={6,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[33400]={6,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[33401]={6,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[33402]={6,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[33403]={6,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[33404]={6,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[33405]={6,100,100,43,800,800,800,800,800,800}---//����
		SkillsExInfo[33406]={6,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[33407]={6,100,400,100,1500,1500,1500,1500,1500,1500}---//����
		SkillsExInfo[33408]={6,100,400,100,1500,1500,1500,1500,1500,1500}---//����
		SkillsExInfo[33409]={6,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[33410]={6,100,400,100,1500,1500,1500,1500,1500,1500}---//����:

		SkillsExInfo[3510]={7,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3511]={7,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3512]={7,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3513]={7,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3514]={7,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3515]={7,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3516]={7,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[3517]={7,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3518]={7,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3519]={7,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[3520]={7,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[3521]={7,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[3522]={7,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[3523]={7,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[3524]={7,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[3525]={7,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[3526]={7,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[3527]={7,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[3528]={7,100,100,43,800,800,800,800,800,800}---//����
		SkillsExInfo[3529]={7,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[3530]={7,100,400,100,1500,1500,1500,1500,1500,1500}---//����
		SkillsExInfo[3531]={7,100,400,100,1500,1500,1500,1500,1500,1500}---//����
		SkillsExInfo[3532]={7,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[3533]={7,100,400,100,1500,1500,1500,1500,1500,1500}---//����:

		SkillsExInfo[3534]={8,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[3535]={8,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3536]={8,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3537]={8,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3538]={8,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3539]={8,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3540]={8,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[3541]={8,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3542]={8,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3543]={8,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3544]={8,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[3545]={8,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[3546]={8,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[3547]={8,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[3548]={8,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[3549]={8,100,100,43,800,800,800,800,800,800}---//����
		SkillsExInfo[3550]={8,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[3551]={8,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[3552]={8,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[3553]={8,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[3554]={8,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[3555]={8,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[3556]={8,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[3557]={8,100,400,100,1500,1500,1500,1500,1500,1500}---//����:

		SkillsExInfo[3972]={9,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3973]={9,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3974]={9,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3975]={9,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3976]={9,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3977]={9,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3978]={9,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[3979]={9,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3980]={9,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3981]={9,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[3982]={9,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[3983]={9,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[3984]={9,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[3985]={9,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[3986]={9,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[3987]={9,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[3988]={9,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[3989]={9,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[3990]={9,100,100,43,800,800,800,800,800,800}---//����
		SkillsExInfo[3991]={9,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[3992]={9,100,400,100,1500,1500,1500,1500,1500,1500}---//����
		SkillsExInfo[3993]={9,100,400,100,1500,1500,1500,1500,1500,1500}---//����
		SkillsExInfo[3994]={9,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[3995]={9,100,400,100,1500,1500,1500,1500,1500,1500}---//����:

		SkillsExInfo[3996]={10,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[3997]={10,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3998]={10,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[3999]={10,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[4000]={10,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[4001]={10,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[4002]={10,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[4003]={10,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[4004]={10,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[4005]={10,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[4006]={10,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[4007]={10,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[4008]={10,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[4009]={10,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[4010]={10,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[4011]={10,100,100,43,800,800,800,800,800,800}---//����
		SkillsExInfo[4012]={10,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[4013]={10,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[4014]={10,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[4015]={10,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[4016]={10,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[4017]={10,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[4018]={10,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[4019]={10,100,400,100,1500,1500,1500,1500,1500,1500}---//����:

		SkillsExInfo[33411]={11,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[33412]={11,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[33413]={11,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[33414]={11,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[33415]={11,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[33416]={11,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[33417]={11,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[33418]={11,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[33419]={11,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[33420]={11,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[33421]={11,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[33422]={11,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[33423]={11,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[33424]={11,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[33425]={11,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[33426]={11,100,100,43,800,800,800,800,800,800}---//����
		SkillsExInfo[33427]={11,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[33428]={11,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[33429]={11,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[33430]={11,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[33431]={11,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[33432]={11,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[33433]={11,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[33434]={11,100,400,100,1500,1500,1500,1500,1500,1500}---//����:

		SkillsExInfo[34035]={12,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[34036]={12,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34037]={12,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34038]={12,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34039]={12,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34040]={12,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34041]={12,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[34042]={12,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34043]={12,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34044]={12,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34045]={12,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[34046]={12,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[34047]={12,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[34048]={12,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[34049]={12,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[34050]={12,100,100,43,800,800,800,800,800,800}---//����
		SkillsExInfo[34051]={12,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[34052]={12,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[34053]={12,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[34054]={12,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[34055]={12,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[34056]={12,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[34057]={12,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[34058]={12,100,400,100,1500,1500,1500,1500,1500,1500}---//����:

		SkillsExInfo[34707]={13,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[34708]={13,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34709]={13,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34710]={13,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34711]={13,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34712]={13,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34713]={13,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[34714]={13,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34715]={13,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34716]={13,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34717]={13,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[34718]={13,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[34719]={13,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[34720]={13,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[34721]={13,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[34722]={13,100,100,43,800,800,800,800,800,800}---//����
		SkillsExInfo[34723]={13,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[34724]={13,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[34725]={13,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[34726]={13,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[34727]={13,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[34728]={13,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[34729]={13,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[34730]={13,100,400,100,1500,1500,1500,1500,1500,1500}---//����:

		SkillsExInfo[34731]={14,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[34732]={14,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34733]={14,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34734]={14,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34735]={14,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34736]={14,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34737]={14,100,0,0,100,100,100,100,100,100}---//����
		SkillsExInfo[34738]={14,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34739]={14,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34740]={14,100,0,0,100,100,100,100,100,100}---//����:
		SkillsExInfo[34741]={14,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[34742]={14,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[34743]={14,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[34744]={14,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[34745]={14,100,20,12,100,100,100,100,100,100}---//����:
		SkillsExInfo[34746]={14,100,100,43,800,800,800,800,800,800}---//����
		SkillsExInfo[34747]={14,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[34748]={14,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[34749]={14,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[34750]={14,100,100,43,800,800,800,800,800,800}---//����:
		SkillsExInfo[34751]={14,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[34752]={14,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[34753]={14,100,400,100,1500,1500,1500,1500,1500,1500}---//����:
		SkillsExInfo[34754]={14,100,400,100,1500,1500,1500,1500,1500,1500}---//����:

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
	local zchoice = {}
	local zrand
	
	if     prof==99 then
		zchoice = {1,2,3,4,5,6,7,8,9,10,11,12,13,14}	--�����ְҵ���޸�����
		zrand = math.ceil(math.random(table.getn(zchoice)))
		prof = zchoice[zrand]
	elseif prof==21 then
		zchoice = {1,2,3,4,5,6}	--�����ְҵ���޸�����
		zrand = math.ceil(math.random(table.getn(zchoice)))
		prof = zchoice[zrand]
	elseif prof==22 then
		zchoice = {7,8,9,10,11,12}	--�����ְҵ���޸�����
		zrand = math.ceil(math.random(table.getn(zchoice)))
		prof = zchoice[zrand]
	elseif prof==33 then
		zchoice = {13,14}	--�����ְҵ���޸�����
		zrand = math.ceil(math.random(table.getn(zchoice)))
		prof = zchoice[zrand]
	end
	
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
	TalismanSkillIDs[2153]={2153,2154,2155}---//������
	TalismanSkillIDs[2598]={2598,2599,2600}---//���±���
	TalismanSkillIDs[3088]={3088,3088,3088}---//Ԫ����
	TalismanSkillIDs[3162]={3162,3163,3164}---//����
	TalismanSkillIDs[3391]={3391,3392,3393}---//�����
	TalismanSkillIDs[3825]={3825,3826,3827}---//����֮��
	TalismanSkillIDs[32954]={32954,32955,32956}---//����.ext

	TalismanSkillIDs[3610]={3610,3611,3612}---//����
	TalismanSkillIDs[3613]={3613,3614,3615}---//����
	TalismanSkillIDs[3616]={3616,3617,3618}---//����
	TalismanSkillIDs[3619]={3619,3620,3621}---//����
	TalismanSkillIDs[3622]={3622,3623,3624}---//����
	TalismanSkillIDs[3625]={3625,3626,3627}---//��ɽ
	TalismanSkillIDs[3628]={3628,3629,3630}---//��ɽ
	TalismanSkillIDs[3631]={3631,3632,3633}---//��ɽ
	TalismanSkillIDs[3634]={3634,3635,3636}---//��ɽ
	TalismanSkillIDs[3943]={3943,3944,3945}---//����
	TalismanSkillIDs[3946]={3946,3947,3948}---//����
	TalismanSkillIDs[3949]={3949,3950,3951}---//����
	TalismanSkillIDs[3952]={3952,3953,3954}---//����
	TalismanSkillIDs[3955]={3955,3956,3957}---//�컪
	TalismanSkillIDs[3958]={3958,3959,3960}---//�컪
	TalismanSkillIDs[3961]={3961,3962,3963}---//�컪
	TalismanSkillIDs[3964]={3964,3965,3966}---//�컪

	TalismanSkillIDs[33347]={33347,33348,33349}---//����
	TalismanSkillIDs[33350]={33350,33351,33352}---//����
	TalismanSkillIDs[33353]={33353,33354,33355}---//����
	TalismanSkillIDs[33356]={33356,33357,33358}---//����
	TalismanSkillIDs[33359]={33359,33360,33361}---//̫�
	TalismanSkillIDs[33362]={33362,33363,33364}---//̫�
	TalismanSkillIDs[33365]={33365,33366,33367}---//̫�
	TalismanSkillIDs[33368]={33368,33369,33370}---//̫�
	TalismanSkillIDs[34015]={34015,34016,34017}---//����
	TalismanSkillIDs[34018]={34018,34019,34020}---//����
	TalismanSkillIDs[34021]={34021,34022,34023}---//����
	TalismanSkillIDs[34024]={34024,34025,34026}---//����

	TalismanSkillIDs[34662]={34662,34663,34664}---//����

	TalismanSkillIDs[34667]={34667,34668,34669}---//ǣ��
	TalismanSkillIDs[34672]={34672,34673,34674}---//ǣ��
	TalismanSkillIDs[34677]={34677,34678,34679}---//ǣ��
	TalismanSkillIDs[34682]={34682,34683,34684}---//ǣ��
	TalismanSkillIDs[34687]={34687,34688,34689}---//Ӣ��
	TalismanSkillIDs[34692]={34692,34693,34694}---//Ӣ��
	TalismanSkillIDs[34697]={34697,34698,34699}---//Ӣ��
	TalismanSkillIDs[34702]={34702,34703,34704}---//Ӣ��


  	TalismanSkillIDs[33723]={33723,33724,33725}---//��������_����ʯ.ext
  	TalismanSkillIDs[33729]={33729,33730,33731}---//�����ݺ�_���Ͼ�.ext
  	TalismanSkillIDs[33732]={33732,33733,33734}---//����Ѫ��_��ȸӡ.ext
  	TalismanSkillIDs[33735]={33735,33736,33737}---//�����ֻ�_�ֻ���.ext
  	TalismanSkillIDs[33738]={33738,33739,33740}---//������_������.ext
  	TalismanSkillIDs[33765]={33765,33766,33767}---//���Ǹ���_���ǽ�.ext
  	TalismanSkillIDs[33768]={33768,33769,33770}---//����Ѫ��_�����.ext
  	TalismanSkillIDs[33771]={33771,33772,33773}---//��ս�ħ_�����.ext
  	TalismanSkillIDs[33774]={33774,33775,33776}---//ɲ�Ƿ���_���黷.ext
  	TalismanSkillIDs[33879]={33879,33880,33881}---//��ɽ�续_ɽ����.ext
  	TalismanSkillIDs[33873]={33873,33874,33875}---//��̩��_��ľ��.ext
  	TalismanSkillIDs[33882]={33882,33883,33884}---//������_�򶾴�(�򶾶�).ext
  	TalismanSkillIDs[33885]={33885,33886,33887}---//���컪_ǧ��̳(��ƿ).ext
  	TalismanSkillIDs[33801]={33801,33802,33803}---//ǧ�Ѥ��_�������.ext
  	TalismanSkillIDs[33900]={33900,33901,33902}---//��������_������.ext
  	TalismanSkillIDs[33912]={33912,33913,33914}---//�������_����.ext
  	TalismanSkillIDs[33897]={33897,33898,33899}---//����Ǭ��_���«.ext
  	TalismanSkillIDs[33810]={33810,33811,33812}---//�����޼�_����.ext
  	TalismanSkillIDs[33804]={33804,33805,33806}---//���է��_Ǭ������.ext
  	TalismanSkillIDs[33915]={33915,33916,33917}---//��������_������.ext
  	TalismanSkillIDs[33894]={33894,33895,33896}---//�������_���������.ext
  	TalismanSkillIDs[33807]={33807,33808,33809}---//Ǭ������_����Ǭ����.ext
  	TalismanSkillIDs[33930]={33930,33931,33932}---//����ĳ�_���.ext
  	TalismanSkillIDs[33933]={33933,33934,33935}---//��Ѫа��_��Ѫ��.ext
  	TalismanSkillIDs[33936]={33936,33937,33938}---//�ɻ���˫_�ɻ�.ext
  --	TalismanSkillIDs[1653]={1653,1654,1655,33888,33889,33890}---//���������_������.ext
  	TalismanSkillIDs[33846]={33846,33847,33848}---//����֮��_����.ext
  	TalismanSkillIDs[33843]={33843,33844,33845}---//��������_�ֻ���.ext
  	TalismanSkillIDs[33837]={33837,33838,33839}---//����̾��_Ǭ����.ext
  	TalismanSkillIDs[33840]={33840,33841,33842}---//�����ĸ�_��ڤ����_.ext
  	TalismanSkillIDs[33903]={33903,33904,33905}---//��������_����ӡ.ext
  	TalismanSkillIDs[33906]={33906,33907,33908}---//��ң����_��ɽ����.ext
  	TalismanSkillIDs[33741]={33741,33742,33743}---//�������_Ѫ���Ƭ.ext
  	TalismanSkillIDs[33777]={33777,33778,33779}---//���廪��_��ɲ.ext
  	TalismanSkillIDs[33813]={33813,33814,33815}---//��������_ǧ����.ext
  	TalismanSkillIDs[33849]={33849,33850,33851}---//����֮��_����.ext
  	TalismanSkillIDs[33918]={33918,33919,33920}---//�����̷�_����ӡ.ext
  	TalismanSkillIDs[33921]={33921,33922,33923}---//������̶_������
  	TalismanSkillIDs[33891]={33891,33892,33893}---//������_���±���
  --	TalismanSkillIDs[3088]={3088,3088,3088}---//Ԫ����ף_Ԫ����
  	TalismanSkillIDs[33909]={33909,33910,33911}---//ʥ����ħ_����
  	TalismanSkillIDs[33924]={33924,33925,33926}---//�׹�֮��_�����
  	TalismanSkillIDs[33927]={33927,33928,33929}---//�����_����֮��
  	TalismanSkillIDs[33939]={33939,33940,33941}---//�������_����.ext
  
  	TalismanSkillIDs[33726]={33726,33727,33728}---//��ʻ�һ_����
  	TalismanSkillIDs[33747]={33747,33748,33749}---//������_����
  	TalismanSkillIDs[33783]={33783,33784,33785}---//����ɷѪ_����
  	TalismanSkillIDs[33819]={33819,33820,33821}---//������ɱ_����
  	TalismanSkillIDs[33855]={33855,33856,33857}---//����ɥ��_����
  	TalismanSkillIDs[33750]={33750,33751,33752}---//��Ӱ����_��ɽ
  	TalismanSkillIDs[33786]={33786,33787,33788}---//���Ƿ���_��ɽ
  	TalismanSkillIDs[33822]={33822,33823,33824}---//������Ӱ_��ɽ
  	TalismanSkillIDs[33858]={33858,33859,33860}---//�ػ�����_��ɽ
  	TalismanSkillIDs[33753]={33753,33754,33755}---//Ѫɱǧ��_����
  	TalismanSkillIDs[33789]={33789,33790,33791}---//��ɨǧ��_����
  	TalismanSkillIDs[33825]={33825,33826,33827}---//�ƻ�ǧ��_����
  	TalismanSkillIDs[33861]={33861,33862,33863}---//���Ӱ��_����
  	TalismanSkillIDs[33756]={33756,33757,33758}---//������_�컪
  	TalismanSkillIDs[33792]={33792,33793,33794}---//�����_�컪
  	TalismanSkillIDs[33828]={33828,33829,33830}---//�������_�컪
  	TalismanSkillIDs[33864]={33864,33865,33866}---//��ħ����_�컪
  
  	TalismanSkillIDs[33744]={33744,33745,33746}---//ҵ������_����
  	TalismanSkillIDs[33780]={33780,33781,33782}---//�������_����
  	TalismanSkillIDs[33816]={33816,33817,33818}---//�������_����
  	TalismanSkillIDs[33852]={33852,33853,33854}---//̫������_����
  	TalismanSkillIDs[33759]={33759,33760,33761}---//����ŭ��_̫�
  	TalismanSkillIDs[33795]={33795,33796,33797}---//��������_̫�
  	TalismanSkillIDs[33831]={33831,33832,33833}---//�����Ļ�_̫�
  	TalismanSkillIDs[33867]={33867,33868,33869}---//��������_̫�
		TalismanSkillIDs[33762]={33762,33763,33764}---//����һ��_����
		TalismanSkillIDs[33798]={33798,33799,33800}---//���ʶ���_����
		TalismanSkillIDs[33834]={33834,33835,33836}---//��������_����
		TalismanSkillIDs[33870]={33870,33871,33872}---//�����ļ�_����

		TalismanSkillIDs[34803]={34803,34804,34805}---//��������_����

  	TalismanSkillIDs[34807]={34807,34808,34809}---//ǣ��һ��_ǣ��
  	TalismanSkillIDs[34811]={34811,34812,34813}---//ǣ������_ǣ��
  	TalismanSkillIDs[34815]={34815,34816,34817}---//ǣ������_ǣ��
  	TalismanSkillIDs[34819]={34819,34820,34821}---//ǣ���ļ�_ǣ��
		TalismanSkillIDs[34823]={34823,34824,34825}---//Ӣ��һ��_Ӣ��
		TalismanSkillIDs[34827]={34827,34828,34829}---//Ӣ�ж���_Ӣ��
		TalismanSkillIDs[34831]={34831,34832,34833}---//Ӣ������_Ӣ��
		TalismanSkillIDs[34835]={34835,34836,34837}---//Ӣ���ļ�_Ӣ��



	local skilllvlchanceseq={275,24,1}
	local newholyskilllevel
		---//1-3�����ܵĳ��ָ���
	for i,v in pairs(TalismanSkillIDs) do
		if TalismanSkillID==i or TalismanSkillID==v[1] or TalismanSkillID==v[2] or TalismanSkillID==v[3] then 
			return TalismanSkillIDs[i][ZLuaTal_Get_RanPoint(skilllvlchanceseq)]or TalismanSkillID
		end 
	end
	
end 
----------------------���ݷ���id�ͷ���Я�����ܵ�id�жϹ���ְҵ-----------------------------------------------
function ZLuaTalisman_GetProfInfo(id,SkillNoSeq)
	local prof_fromid=99
	local prof_fromskill=99
	
	local talismans=ZLuaTalAvailableTalismans()
	for i,v in pairs(talismans) do
		if id == v.tmplID then 
			prof_fromid = v.school
		end 
		if prof_fromid == 0 then 
			prof_fromid = 99
		end 
		if id == 4703 then
			prof_fromid = 21
		end
		if id == 30076 then
			prof_fromid = 22
		end
		if id == 58825 then
			prof_fromid = 33
		end
	end 

	if prof_fromid == 21 or prof_fromid == 22 or prof_fromid == 33	then
		prof_fromskill = prof_fromid
	end 

	local SkillsExLists=ZLuaTalismanEnchantSkillEx()
	for i,v in pairs(SkillsExLists) do
		for j=1,table.getn(SkillNoSeq) do 
			if i==SkillNoSeq[j] and (v.prof==1 or v.prof==2 or v.prof==3 or v.prof==4 or v.prof==5 or v.prof==6 or v.prof==7 or v.prof==8 or v.prof==9 or v.prof==10 or v.prof==11 or v.prof==12 or v.prof==13 or v.prof==14) then 		--�����ְҵ���޸�����
				prof_fromskill = v.prof
			end 
		end 
	end 

	if prof_fromid==1 or prof_fromid==2 or prof_fromid==3 or prof_fromid==4 or prof_fromid==5 or prof_fromid==6 or prof_fromid==7 or prof_fromid==8 or prof_fromid==9 or prof_fromid==10 or prof_fromid==11 or prof_fromid==12 or prof_fromid==13 or prof_fromid==14  		--�����ְҵ���޸�����
	then 
		prof_fromskill=prof_fromid
	end 

	return  prof_fromid,prof_fromskill
	
end 

------------------��������������-----------------------------------------------------------------------------

function ZLuaTalHolyLevelUp(id,talisman,cid,output)	
	local dataIndex=ZLuaTalDataIndex()
	local talismans=ZLuaTalAvailableTalismans()
	local outid
	
---	print("dataIndex["reserve1"]=",talisman:QueryData(0,dataIndex["reserve1"]))
---	print("dataIndex["reserve2"]=",talisman:QueryData(0,dataIndex["reserve2"]))
--[[
  print("reserve1=",talisman:QueryData(0,dataIndex["reserve1"]))
  print("reserve2=",talisman:QueryData(0,dataIndex["reserve2"]))
  print("tmpl_id=",talisman:QueryData(0,dataIndex["tmpl_id"]))
  print("skill_addon_id=",talisman:QueryData(0,dataIndex["skill_addon_id"]))
  print("default_stamina=",talisman:QueryData(0,dataIndex["default_stamina"]))
  print("quo_stamina=",talisman:QueryData(0,dataIndex["quo_stamina"]))
  print("default_hp=",talisman:QueryData(0,dataIndex["default_hp"]))
  print("default_mp=",talisman:QueryData(0,dataIndex["default_mp"]))
  print("default_attack_rate=",talisman:QueryData(0,dataIndex["default_attack_rate"]))
  print("default_damage_low=",talisman:QueryData(0,dataIndex["default_damage_low"]))
  print("default_damage_high=",talisman:QueryData(0,dataIndex["default_damage_high"]))
  print("default_dodge=",talisman:QueryData(0,dataIndex["default_dodge"]))
  print("default_defense=",talisman:QueryData(0,dataIndex["default_defense"]))
  print("default_resis_stun=",talisman:QueryData(0,dataIndex["default_resis_stun"]))
  print("default_resis_sleep=",talisman:QueryData(0,dataIndex["default_resis_sleep"]))
  print("default_resis_silence=",talisman:QueryData(0,dataIndex["default_resis_silence"]))
  print("default_resis_weakness=",talisman:QueryData(0,dataIndex["default_resis_weakness"]))
  print("default_resis_enlace=",talisman:QueryData(0,dataIndex["default_resis_enlace"]))
  print("grow_hp=",talisman:QueryData(0,dataIndex["grow_hp"]))
  print("grow_mp=",talisman:QueryData(0,dataIndex["grow_mp"]))
  print("grow_attack_rate=",talisman:QueryData(0,dataIndex["grow_attack_rate"]))
  print("grow_damage_low=",talisman:QueryData(0,dataIndex["grow_damage_low"]))
  print("grow_damage_high=",talisman:QueryData(0,dataIndex["grow_damage_high"]))
  print("grow_dodge=",talisman:QueryData(0,dataIndex["grow_dodge"]))
  print("grow_defense=",talisman:QueryData(0,dataIndex["grow_defense"]))
  print("grow_resis_stun=",talisman:QueryData(0,dataIndex["grow_resis_stun"]))
  print("grow_resis_sleep=",talisman:QueryData(0,dataIndex["grow_resis_sleep"]))
  print("grow_resis_silence=",talisman:QueryData(0,dataIndex["grow_resis_silence"]))
  print("grow_resis_weakness=",talisman:QueryData(0,dataIndex["grow_resis_weakness"]))
  print("grow_resis_enlace=",talisman:QueryData(0,dataIndex["grow_resis_enlace"]))
  print("addon_1_learn_level=",talisman:QueryData(0,dataIndex["addon_1_learn_level"]))
  print("addon_1_id=",talisman:QueryData(0,dataIndex["addon_1_id"]))
  print("addon_2_learn_level=",talisman:QueryData(0,dataIndex["addon_2_learn_level"]))
  print("addon_2_id=",talisman:QueryData(0,dataIndex["addon_2_id"]))
  print("addon_3_learn_level=",talisman:QueryData(0,dataIndex["addon_3_learn_level"]))
  print("addon_3_id=",talisman:QueryData(0,dataIndex["addon_3_id"]))
  print("addon_4_learn_level=",talisman:QueryData(0,dataIndex["addon_4_learn_level"]))
  print("addon_4_id=",talisman:QueryData(0,dataIndex["addon_4_id"]))
  print("addon_5_learn_level=",talisman:QueryData(0,dataIndex["addon_5_learn_level"]))
  print("addon_5_id=",talisman:QueryData(0,dataIndex["addon_5_id"]))
  print("addon_6_learn_level=",talisman:QueryData(0,dataIndex["addon_6_learn_level"]))
  print("addon_6_id=",talisman:QueryData(0,dataIndex["addon_6_id"]))
  print("addon_7_learn_level=",talisman:QueryData(0,dataIndex["addon_7_learn_level"]))
  print("addon_7_id=",talisman:QueryData(0,dataIndex["addon_7_id"]))
  print("addon_8_learn_level=",talisman:QueryData(0,dataIndex["addon_8_learn_level"]))
  print("addon_8_id=",talisman:QueryData(0,dataIndex["addon_8_id"]))
  print("addon_9_learn_level=",talisman:QueryData(0,dataIndex["addon_9_learn_level"]))
  print("addon_9_id=",talisman:QueryData(0,dataIndex["addon_9_id"]))
  print("addon_10_learn_level=",talisman:QueryData(0,dataIndex["addon_10_learn_level"]))
  print("addon_10_id=",talisman:QueryData(0,dataIndex["addon_10_id"]))
  print("addon_11_learn_level=",talisman:QueryData(0,dataIndex["addon_11_learn_level"]))
  print("addon_11_id=",talisman:QueryData(0,dataIndex["addon_11_id"]))
  print("artpath_1_level=",talisman:QueryData(0,dataIndex["artpath_1_level"]))
  print("artpath_2_level=",talisman:QueryData(0,dataIndex["artpath_2_level"]))
  print("artpath_3_level=",talisman:QueryData(0,dataIndex["artpath_3_level"]))
  print("artpath_4_level=",talisman:QueryData(0,dataIndex["artpath_4_level"]))
  print("confusion_1_level=",talisman:QueryData(0,dataIndex["confusion_1_level"]))
  print("confusion_1_quo=",talisman:QueryData(0,dataIndex["confusion_1_quo"]))
  print("confusion_2_level=",talisman:QueryData(0,dataIndex["confusion_2_level"]))
  print("confusion_2_quo=",talisman:QueryData(0,dataIndex["confusion_2_quo"]))
  print("confusion_3_level=",talisman:QueryData(0,dataIndex["confusion_3_level"]))
  print("confusion_3_quo=",talisman:QueryData(0,dataIndex["confusion_3_quo"]))
  print("confusion_4_level=",talisman:QueryData(0,dataIndex["confusion_4_level"]))
  print("confusion_4_quo=",talisman:QueryData(0,dataIndex["confusion_4_quo"]))
  print("confusion_5_level=",talisman:QueryData(0,dataIndex["confusion_5_level"]))
  print("confusion_5_quo=",talisman:QueryData(0,dataIndex["confusion_5_quo"]))
  print("origin=",talisman:QueryData(0,dataIndex["origin"]))
  print("birth_hour12=",talisman:QueryData(0,dataIndex["birth_hour12"]))
  print("birth_min3=",talisman:QueryData(0,dataIndex["birth_min3"]))
  print("quality=",talisman:QueryData(0,dataIndex["quality"]))
  print("speciality=",talisman:QueryData(0,dataIndex["speciality"]))
  print("buff_type=",talisman:QueryData(0,dataIndex["buff_type"]))
  print("ext_id=",talisman:QueryData(0,dataIndex["ext_id"]))
  print("skill_visible=",talisman:QueryData(0,dataIndex["skill_visible"]))
  print("combine_times=",talisman:QueryData(0,dataIndex["combine_times"]))
  print("enchant_times=",talisman:QueryData(0,dataIndex["enchant_times"]))
  print("feed_baoqi=",talisman:QueryData(0,dataIndex["feed_baoqi"]))
  print("feed_xianpin=",talisman:QueryData(0,dataIndex["feed_xianpin"]))
  print("feed_shenpin=",talisman:QueryData(0,dataIndex["feed_shenpin"]))
  print("feed_cost=",talisman:QueryData(0,dataIndex["feed_cost"]))
  print("change_skillnum=",talisman:QueryData(0,dataIndex["change_skillnum"]))
  print("feed_level_cost=",talisman:QueryData(0,dataIndex["feed_level_cost"]))
  print("is_fly=",talisman:QueryData(0,dataIndex["is_fly"]))
  print("hp_rise=",talisman:QueryData(0,dataIndex["hp_rise"]))
  print("mp_rise=",talisman:QueryData(0,dataIndex["mp_rise"]))
  print("minattack_rise=",talisman:QueryData(0,dataIndex["minattack_rise"]))
  print("maxattack_rise=",talisman:QueryData(0,dataIndex["maxattack_rise"]))
  print("stun_rise=",talisman:QueryData(0,dataIndex["stun_rise"]))
  print("weakness_rise=",talisman:QueryData(0,dataIndex["weakness_rise"]))
  print("enlace_rise=",talisman:QueryData(0,dataIndex["enlace_rise"]))
  print("silence_rise=",talisman:QueryData(0,dataIndex["silence_rise"]))
  print("sleep_rise=",talisman:QueryData(0,dataIndex["sleep_rise"]))
  print("all_rise=",talisman:QueryData(0,dataIndex["all_rise"]))
  print("hp_enhance=",talisman:QueryData(0,dataIndex["hp_enhance"]))
  print("mp_enhance=",talisman:QueryData(0,dataIndex["mp_enhance"]))
  print("atk_enhance=",talisman:QueryData(0,dataIndex["atk_enhance"]))
  print("skillrefine_level=",talisman:QueryData(0,dataIndex["skillrefine_level"]))
  print("skillrefine_0=",talisman:QueryData(0,dataIndex["skillrefine_0"]))
  print("skillrefine_1=",talisman:QueryData(0,dataIndex["skillrefine_1"]))
  print("skillrefine_2=",talisman:QueryData(0,dataIndex["skillrefine_2"]))
  print("skillrefine_3=",talisman:QueryData(0,dataIndex["skillrefine_3"]))
  print("skillrefine_4=",talisman:QueryData(0,dataIndex["skillrefine_4"]))
  print("skillrefine_5=",talisman:QueryData(0,dataIndex["skillrefine_5"]))
  print("skillrefine_6=",talisman:QueryData(0,dataIndex["skillrefine_6"]))
  print("skillrefine_7=",talisman:QueryData(0,dataIndex["skillrefine_7"]))
  print("skillrefine_8=",talisman:QueryData(0,dataIndex["skillrefine_8"]))
  print("skillrefinetmp_1=",talisman:QueryData(0,dataIndex["skillrefinetmp_1"]))
  print("skillrefinetmp_2=",talisman:QueryData(0,dataIndex["skillrefinetmp_2"]))
  print("skillrefinetmp_3=",talisman:QueryData(0,dataIndex["skillrefinetmp_3"]))
  print("skillrefinetmp_4=",talisman:QueryData(0,dataIndex["skillrefinetmp_4"]))
  print("skillrefinetmp_5=",talisman:QueryData(0,dataIndex["skillrefinetmp_5"]))
  print("skillrefinetmp_6=",talisman:QueryData(0,dataIndex["skillrefinetmp_6"]))
  print("skillrefinetmp_7=",talisman:QueryData(0,dataIndex["skillrefinetmp_7"]))
  print("skillrefinetmp_8=",talisman:QueryData(0,dataIndex["skillrefinetmp_8"]))
  print("newaddon_id_1=",talisman:QueryData(0,dataIndex["newaddon_id_1"]))
  print("newaddon_id_2=",talisman:QueryData(0,dataIndex["newaddon_id_2"]))
  print("newaddon_id_3=",talisman:QueryData(0,dataIndex["newaddon_id_3"]))
  print("newaddon_id_4=",talisman:QueryData(0,dataIndex["newaddon_id_4"]))
  print("newaddon_id_5=",talisman:QueryData(0,dataIndex["newaddon_id_5"]))
  print("reborncont=",talisman:QueryData(0,dataIndex["reborncont"]))
  print("skillrefinecont=",talisman:QueryData(0,dataIndex["skillrefinecont"]))
--]]
  ---û����ý�޷�����-----------------------
	if cid == 0 then
		output:CreateItem(-1)
		return
	end
  ---ûע����ķ����ɽ�����ֹ����----------------
	local Registed = false
	for _,v in pairs(talismans) do
		if v.tmplID == id then Registed = true end
	end
	if Registed == false then
		output:CreateItem(-1)
		return
	end


 ---�����ǲ߻��ڲ����⴦�������������ڷ�����������ֵ�ķ������������ɴ����Ƶ�����ķ�������Ե�������޸�BUG��------
 ---ע�⣬ÿ�����ɷ���Ҫ��ÿһ��dataIndex��ȷ���壬���򷨱����п��ܳ��ֲ���Ԥ֪������-------
	
  if cid == 12021 then
  	outid = id
 		output:CreateItem(outid)			
		for _,index in pairs(dataIndex) do
			output:UpdateData(0,index,talisman:QueryData(0,index))
		end

	 	output:UpdateData(0,dataIndex["reserve1"], 0)
	 	output:UpdateData(0,dataIndex["reserve2"], 0)
---	 	output:UpdateData(0,dataIndex["tmpl_id"], 0)
	 	output:UpdateData(0,dataIndex["skill_addon_id"], 33941)

	 	output:UpdateData(0,dataIndex["default_stamina"], 242)
	 	output:UpdateData(0,dataIndex["quo_stamina"], 0.97000002861023)

	 	output:UpdateData(0,dataIndex["default_hp"], 48)
	 	output:UpdateData(0,dataIndex["default_mp"], 46)
	 	output:UpdateData(0,dataIndex["default_attack_rate"], 0)
	 	output:UpdateData(0,dataIndex["default_damage_low"], 8)
	 	output:UpdateData(0,dataIndex["default_damage_high"], 24)
	 	output:UpdateData(0,dataIndex["default_dodge"], 0)
	 	output:UpdateData(0,dataIndex["default_defense"], 0)
	 	output:UpdateData(0,dataIndex["default_resis_stun"], 8)
	 	output:UpdateData(0,dataIndex["default_resis_sleep"], 8)
	 	output:UpdateData(0,dataIndex["default_resis_silence"], 8)
	 	output:UpdateData(0,dataIndex["default_resis_weakness"], 8)
	 	output:UpdateData(0,dataIndex["default_resis_enlace"], 8)

	 	output:UpdateData(0,dataIndex["grow_hp"], 134.59999694824)
	 	output:UpdateData(0,dataIndex["grow_mp"], 0)
	 	output:UpdateData(0,dataIndex["grow_attack_rate"], 0)
	 	output:UpdateData(0,dataIndex["grow_damage_low"], 0)
	 	output:UpdateData(0,dataIndex["grow_damage_high"], 33.410000038147)
	 	output:UpdateData(0,dataIndex["grow_dodge"], 0)
	 	output:UpdateData(0,dataIndex["grow_defense"], 0)
	 	output:UpdateData(0,dataIndex["grow_resis_stun"], 6.2099999427795)
	 	output:UpdateData(0,dataIndex["grow_resis_sleep"], 6.2099999427795)
	 	output:UpdateData(0,dataIndex["grow_resis_silence"], 6.2099999427795)
	 	output:UpdateData(0,dataIndex["grow_resis_weakness"], 6.2099999427795)
	 	output:UpdateData(0,dataIndex["grow_resis_enlace"], 6.2099999427795)

	 	output:UpdateData(0,dataIndex["addon_1_learn_level"], 11)
	 	output:UpdateData(0,dataIndex["addon_1_id"], 33389)
	 	output:UpdateData(0,dataIndex["addon_2_learn_level"], 28)
	 	output:UpdateData(0,dataIndex["addon_2_id"], 33396)
	 	output:UpdateData(0,dataIndex["addon_3_learn_level"], 20)
	 	output:UpdateData(0,dataIndex["addon_3_id"], 33400)
	 	output:UpdateData(0,dataIndex["addon_4_learn_level"], 10)
	 	output:UpdateData(0,dataIndex["addon_4_id"], 33402)
	 	output:UpdateData(0,dataIndex["addon_5_learn_level"], 18)
	 	output:UpdateData(0,dataIndex["addon_5_id"], 33405)
	 	output:UpdateData(0,dataIndex["addon_6_learn_level"], 28)
	 	output:UpdateData(0,dataIndex["addon_6_id"], 33407)
	 	output:UpdateData(0,dataIndex["addon_7_learn_level"], 0)
	 	output:UpdateData(0,dataIndex["addon_7_id"], 0)
	 	output:UpdateData(0,dataIndex["addon_8_learn_level"], 0)
	 	output:UpdateData(0,dataIndex["addon_8_id"], 0)
	 	output:UpdateData(0,dataIndex["addon_9_learn_level"], 0)
	 	output:UpdateData(0,dataIndex["addon_9_id"], 0)
	 	output:UpdateData(0,dataIndex["addon_10_learn_level"], 0)
	 	output:UpdateData(0,dataIndex["addon_10_id"], 0)
	 	output:UpdateData(0,dataIndex["addon_11_learn_level"], 0)
	 	output:UpdateData(0,dataIndex["addon_11_id"], 0)

	 	output:UpdateData(0,dataIndex["artpath_1_level"], 1)
	 	output:UpdateData(0,dataIndex["artpath_2_level"], 10)
	 	output:UpdateData(0,dataIndex["artpath_3_level"], 20)
	 	output:UpdateData(0,dataIndex["artpath_4_level"], 30)

	 	output:UpdateData(0,dataIndex["confusion_1_level"], 2)
	 	output:UpdateData(0,dataIndex["confusion_1_quo"], 1.5059777498245)
	 	output:UpdateData(0,dataIndex["confusion_2_level"], 4)
	 	output:UpdateData(0,dataIndex["confusion_2_quo"], 1.3748062849045)
	 	output:UpdateData(0,dataIndex["confusion_3_level"], 9)
	 	output:UpdateData(0,dataIndex["confusion_3_quo"], 1.1029150485992)
	 	output:UpdateData(0,dataIndex["confusion_4_level"], 13)
	 	output:UpdateData(0,dataIndex["confusion_4_quo"], 1.4053633213043)
	 	output:UpdateData(0,dataIndex["confusion_5_level"], 29)
	 	output:UpdateData(0,dataIndex["confusion_5_quo"], 1.0061609745026)

	 	output:UpdateData(0,dataIndex["origin"], 3)
	 	output:UpdateData(0,dataIndex["birth_hour12"], 3)
	 	output:UpdateData(0,dataIndex["birth_min3"], 2)
	 	output:UpdateData(0,dataIndex["quality"], 2)
	 	output:UpdateData(0,dataIndex["speciality"], 25)
	 	output:UpdateData(0,dataIndex["buff_type"], 0)
	 	output:UpdateData(0,dataIndex["ext_id"], 0)
	 	output:UpdateData(0,dataIndex["skill_visible"], 1)
	 	output:UpdateData(0,dataIndex["combine_times"], 639)
	 	output:UpdateData(0,dataIndex["enchant_times"], 33)
	 	output:UpdateData(0,dataIndex["feed_baoqi"], 1)
	 	output:UpdateData(0,dataIndex["feed_xianpin"], 0)
	 	output:UpdateData(0,dataIndex["feed_shenpin"], 638)
	 	output:UpdateData(0,dataIndex["feed_cost"], 72320.0078125)
	 	output:UpdateData(0,dataIndex["change_skillnum"], 148)
	 	output:UpdateData(0,dataIndex["feed_level_cost"], 0)
	 	output:UpdateData(0,dataIndex["is_fly"], 0)

	 	output:UpdateData(0,dataIndex["hp_rise"], 10)
	 	output:UpdateData(0,dataIndex["mp_rise"], 10)
	 	output:UpdateData(0,dataIndex["minattack_rise"], 10)
	 	output:UpdateData(0,dataIndex["maxattack_rise"], 10)
	 	output:UpdateData(0,dataIndex["stun_rise"], 10)
	 	output:UpdateData(0,dataIndex["weakness_rise"], 10)
	 	output:UpdateData(0,dataIndex["enlace_rise"], 10)
	 	output:UpdateData(0,dataIndex["silence_rise"], 10)
	 	output:UpdateData(0,dataIndex["sleep_rise"], 10)
	 	output:UpdateData(0,dataIndex["all_rise"], 90)

	 	output:UpdateData(0,dataIndex["hp_enhance"], 7000)
	 	output:UpdateData(0,dataIndex["mp_enhance"], 7000)
	 	output:UpdateData(0,dataIndex["atk_enhance"], 1050)

	 	output:UpdateData(0,dataIndex["skillrefine_level"], 3)
	 	output:UpdateData(0,dataIndex["skillrefine_0"], 4112)
	 	output:UpdateData(0,dataIndex["skillrefine_1"], 4346)
	 	output:UpdateData(0,dataIndex["skillrefine_2"], 4332)
	 	output:UpdateData(0,dataIndex["skillrefine_3"], 4342)
	 	output:UpdateData(0,dataIndex["skillrefine_4"], 4347)
	 	output:UpdateData(0,dataIndex["skillrefine_5"], 4348)
	 	output:UpdateData(0,dataIndex["skillrefine_6"], 4349)
	 	output:UpdateData(0,dataIndex["skillrefine_7"], 0)
	 	output:UpdateData(0,dataIndex["skillrefine_8"], 0)

	 	output:UpdateData(0,dataIndex["skillrefinetmp_1"], 0)
	 	output:UpdateData(0,dataIndex["skillrefinetmp_2"], 0)
	 	output:UpdateData(0,dataIndex["skillrefinetmp_3"], 0)
	 	output:UpdateData(0,dataIndex["skillrefinetmp_4"], 0)
	 	output:UpdateData(0,dataIndex["skillrefinetmp_5"], 0)
	 	output:UpdateData(0,dataIndex["skillrefinetmp_6"], 0)
	 	output:UpdateData(0,dataIndex["skillrefinetmp_7"], 0)
	 	output:UpdateData(0,dataIndex["skillrefinetmp_8"], 0)

	 	output:UpdateData(0,dataIndex["newaddon_id_1"], 34467)
	 	output:UpdateData(0,dataIndex["newaddon_id_2"], 34466)
	 	output:UpdateData(0,dataIndex["newaddon_id_3"], 0)
	 	output:UpdateData(0,dataIndex["newaddon_id_4"], 0)
	 	output:UpdateData(0,dataIndex["newaddon_id_5"], 0)

	 	output:UpdateData(0,dataIndex["reborncont"], 2)
	 	output:UpdateData(0,dataIndex["skillrefinecont"], 1)


		output:InheritCombineExp(true)

		ZLuaTalRebuild(output,outid)
		return
  end


 ---�������IDΪ�ɱ�ID�����ֹ����--------------
	if talisman:QueryData(0,dataIndex["is_fly"])==1 then
		output:CreateItem(-1)
		return
	end
 ---����Ԫ���ƺ���������ֹ����------------------
	if id == talismans["US_45_YuanXiaoDeng"].tmplID or id == talismans["US_75_LingLongTa"].tmplID then
		output:CreateItem(-1)
		return
	end

 ---�Ѿ������ķ����޷����з�������--------------
	if talisman:QueryData(0,dataIndex["reborncont"]) >= 1 or talisman:QueryData(0,dataIndex["skillrefine_0"]) > 0 then
		output:CreateItem(-1)
		return
	end

 ---�ȼ�����35���޷�����------------------------
	if talisman:QueryLevel() < 30 then
		output:CreateItem(-1)
		return
	end


	if cid ~= 53576 and cid ~= 55602 then 
		output:CreateItem(-1)
		return
	end
 ---���������ڲ����ݴ���------------------------
	if cid == 53576 or cid == 55602 then
		outid = id
		output:CreateItem(outid)			
		for _,index in pairs(dataIndex) do
			output:UpdateData(0,index,talisman:QueryData(0,index))
		end
---		ZLuaTalisman_InitHolySkillID(id,output)

  	local HolySkillLevel
  	local HolySkillAddonID
  	local HolySkillId0
  	local HolySkillId1
  	local HolySkillId2
  	local HolySkillId3
  	local HolySkillId4
  	local HolySkillId5
  	local HolySkillId6
  	local HolySkillId7
  	local HolySkillId8
  	
  	local TalismanSkillIDs={}
  ---��������addon1��addon2��addon3������addon1������addon2������addon3������addon1��Ӧ����id���������ܳ�ʼЧ��ID1,ID2,ID3,ID4,ID5,ID6,ID7,ID8
  	TalismanSkillIDs[399]={399,1278,1279,33723,33724,33725,4044,4166,4167,0,0,0,0,0,0}---//��������_����ʯ.ext
  	TalismanSkillIDs[400]={400,1292,1293,33729,33730,33731,4046,4170,4171,0,0,0,0,0,0}---//�����ݺ�_���Ͼ�.ext
  	TalismanSkillIDs[401]={401,1326,1327,33732,33733,33734,4047,4172,4173,0,0,0,0,0,0}---//����Ѫ��_��ȸӡ.ext
  	TalismanSkillIDs[402]={402,1294,1295,33735,33736,33737,4048,4174,4175,0,0,0,0,0,0}---//�����ֻ�_�ֻ���.ext
  	TalismanSkillIDs[403]={403,1308,1309,33738,33739,33740,4049,4176,4177,0,0,0,0,0,0}---//������_������.ext
  	TalismanSkillIDs[404]={404,1298,1299,33765,33766,33767,4057,4193,4194,0,0,0,0,0,0}---//���Ǹ���_���ǽ�.ext
  	TalismanSkillIDs[405]={405,1318,1319,33768,33769,33770,4058,4196,4197,0,0,0,0,0,0}---//����Ѫ��_�����.ext
  	TalismanSkillIDs[406]={406,1284,1285,33771,33772,33773,4059,4199,4200,0,0,0,0,0,0}---//��ս�ħ_�����.ext
  	TalismanSkillIDs[407]={407,1280,1281,33774,33775,33776,4060,4202,4203,0,0,0,0,0,0}---//ɲ�Ƿ���_���黷.ext
  	TalismanSkillIDs[408]={408,1306,1307,33879,33880,33881,4092,4291,0   ,0,0,0,0,0,0}---//��ɽ�续_ɽ����.ext
  	TalismanSkillIDs[409]={409,1312,1313,33873,33874,33875,4090,4290,0   ,0,0,0,0,0,0}---//��̩��_��ľ��.ext
  	TalismanSkillIDs[410]={410,1320,1321,33882,33883,33884,4093,4292,0   ,0,0,0,0,0,0}---//������_�򶾴�(�򶾶�).ext
  	TalismanSkillIDs[411]={411,1300,1301,33885,33886,33887,4094,4293,0   ,0,0,0,0,0,0}---//���컪_ǧ��̳(��ƿ).ext
  	TalismanSkillIDs[860]={860,1282,1283,33801,33802,33803,4068,4221,4222,4223,0,0,0,0,0}---//ǧ�Ѥ��_�������.ext
  	TalismanSkillIDs[861]={861,1324,1325,33900,33901,33902,4099,4303,4304,4305,0,0,0,0,0}---//��������_������.ext
  	TalismanSkillIDs[862]={862,1296,1297,33912,33913,33914,4103,4316,4317,0,0,0,0,0,0}---//�������_����.ext
  	TalismanSkillIDs[863]={863,1286,1287,33897,33898,33899,4098,4300,4301,4302,0,0,0,0,0}---//����Ǭ��_���«.ext
  	TalismanSkillIDs[864]={864,1290,1291,33810,33811,33812,4071,4230,4231,4232,0,0,0,0,0}---//�����޼�_����.ext
  	TalismanSkillIDs[865]={865,1302,1303,33804,33805,33806,4069,4224,4225,4226,0,0,0,0,0}---//���է��_Ǭ������.ext
  	TalismanSkillIDs[866]={866,1322,1323,33915,33916,33917,4104,4318,4319,4320,0,0,0,0,0}---//��������_������.ext
  	TalismanSkillIDs[867]={867,1288,1289,33894,33895,33896,4097,4297,4298,4299,0,0,0,0,0}---//�������_���������.ext
  	TalismanSkillIDs[868]={868,1304,1305,33807,33808,33809,4070,4227,4228,4229,0,0,0,0,0}---//Ǭ������_����Ǭ����.ext
  	TalismanSkillIDs[869]={869,1310,1311,33930,33931,33932,4109,4334,4335,4336,0,0,0,0,0}---//����ĳ�_���.ext
  	TalismanSkillIDs[870]={870,1316,1317,33933,33934,33935,4110,4337,4338,4339,4340,0,0,0,0}---//��Ѫа��_��Ѫ��.ext
  	TalismanSkillIDs[871]={871,1314,1315,33936,33937,33938,4111,4342,4343,4344,4345,4346,0,0,0}---//�ɻ���˫_�ɻ�.ext
  --	TalismanSkillIDs[1653]={1653,1654,1655,33888,33889,33890}---//���������_������.ext
  	TalismanSkillIDs[1697]={1697,1698,1699,33846,33847,33848,4082,4265,4266,4267,4268,0,0,0,0}---//����֮��_����.ext
  	TalismanSkillIDs[1700]={1700,1701,1702,33843,33844,33845,4081,4261,4262,4263,4264,0,0,0,0}---//��������_�ֻ���.ext
  	TalismanSkillIDs[1703]={1703,1704,1705,33837,33838,33839,4079,4253,4254,4255,4256,0,0,0,0}---//����̾��_Ǭ����.ext
  	TalismanSkillIDs[1706]={1706,1707,1708,33840,33841,33842,4080,4257,4258,4259,4260,0,0,0,0}---//�����ĸ�_��ڤ����_.ext
  	TalismanSkillIDs[1738]={1738,1739,1740,33903,33904,33905,4100,4306,4307,4308,4309,0,0,0,0}---//��������_����ӡ.ext
  	TalismanSkillIDs[1753]={1753,1754,1755,33906,33907,33908,4101,4310,4311,0,0,0,0,0,0}---//��ң����_��ɽ����.ext
  	TalismanSkillIDs[1806]={1806,1807,1808,33741,33742,33743,4050,4178,4179,0,0,0,0,0,0}---//�������_Ѫ���Ƭ.ext
  	TalismanSkillIDs[1809]={1809,1810,1811,33777,33778,33779,4061,4204,4205,0,0,0,0,0,0}---//���廪��_��ɲ.ext
  	TalismanSkillIDs[1812]={1812,1813,1814,33813,33814,33815,4072,4233,4234,4235,0,0,0,0,0}---//��������_ǧ����.ext
  	TalismanSkillIDs[1815]={1815,1816,1817,33849,33850,33851,4083,4269,4270,4271,0,0,0,0,0}---//����֮��_����.ext
  	TalismanSkillIDs[2037]={2037,2038,2039,33918,33919,33920,4105,4321,4322,4323,0,0,0,0,0}---//�����̷�_����ӡ.ext
  	TalismanSkillIDs[2153]={2153,2154,2155,33921,33922,33923,4106,4324,4325,4326,0,0,0,0,0}---//������̶_������
  	TalismanSkillIDs[2598]={2598,2599,2600,33891,33892,33893,4096,4294,4295,4296,0,0,0,0,0}---//������_���±���
  --	TalismanSkillIDs[3088]={3088,3088,3088}---//Ԫ����ף_Ԫ����
  	TalismanSkillIDs[3162]={3162,3163,3164,33909,33910,33911,4102,4312,4313,4314,4315,0,0,0,0}---//ʥ����ħ_����
  	TalismanSkillIDs[3391]={3391,3392,3393,33924,33925,33926,4107,4327,4328,4329,4330,0,0,0,0}---//�׹�֮��_�����
  	TalismanSkillIDs[3825]={3825,3826,3827,33927,33928,33929,4108,4331,4332,4333,0,0,0,0,0}---//�����_����֮��
  	TalismanSkillIDs[32954]={32954,32955,32956,33939,33940,33941,4112,4347,4348,4349,4350,0,0,0,0}---//�������_����.ext
  
  	TalismanSkillIDs[3610]={3610,3611,3612,33726,33727,33728,4045,4168,4169,0,0,0,0,0,0}---//��ʻ�һ_����
  	TalismanSkillIDs[3613]={3613,3614,3615,33747,33748,33749,4052,4182,4183,0,0,0,0,0,0}---//������_����
  	TalismanSkillIDs[3616]={3616,3617,3618,33783,33784,33785,4063,4208,4209,0,0,0,0,0,0}---//����ɷѪ_����
  	TalismanSkillIDs[3619]={3619,3620,3621,33819,33820,33821,4074,4239,4240,4241,0,0,0,0,0}---//������ɱ_����
  	TalismanSkillIDs[3622]={3622,3623,3624,33855,33856,33857,4085,4274,4275,4276,0,0,0,0,0}---//����ɥ��_����
  	TalismanSkillIDs[3625]={3625,3626,3627,33750,33751,33752,4053,4184,4185,0,0,0,0,0,0}---//��Ӱ����_��ɽ
  	TalismanSkillIDs[3628]={3628,3629,3630,33786,33787,33788,4064,4210,4211,0,0,0,0,0,0}---//���Ƿ���_��ɽ
  	TalismanSkillIDs[3631]={3631,3632,3633,33822,33823,33824,4075,4242,4243,4244,0,0,0,0,0}---//������Ӱ_��ɽ
  	TalismanSkillIDs[3634]={3634,3635,3636,33858,33859,33860,4086,4278,4279,4280,0,0,0,0,0}---//�ػ�����_��ɽ
  	TalismanSkillIDs[3943]={3943,3944,3945,33753,33754,33755,4054,4186,4187,0,0,0,0,0,0}---//Ѫɱǧ��_����
  	TalismanSkillIDs[3946]={3946,3947,3948,33789,33790,33791,4065,4213,4214,0,0,0,0,0,0}---//��ɨǧ��_����
  	TalismanSkillIDs[3949]={3949,3950,3951,33825,33826,33827,4076,4245,4246,0,0,0,0,0,0}---//�ƻ�ǧ��_����
  	TalismanSkillIDs[3952]={3952,3953,3954,33861,33862,33863,4087,4281,4282,4283,0,0,0,0,0}---//���Ӱ��_����
  	TalismanSkillIDs[3955]={3955,3956,3957,33756,33757,33758,4055,4189,4190,0,0,0,0,0,0}---//������_�컪
  	TalismanSkillIDs[3958]={3958,3959,3960,33792,33793,33794,4066,4215,4216,4217,0,0,0,0,0}---//�����_�컪
  	TalismanSkillIDs[3961]={3961,3962,3963,33828,33829,33830,4077,4247,4248,4249,0,0,0,0,0}---//�������_�컪
  	TalismanSkillIDs[3964]={3964,3965,3966,33864,33865,33866,4088,4284,4285,4286,0,0,0,0,0}---//��ħ����_�컪
  
  	TalismanSkillIDs[33347]={33347,33348,33349,33744,33745,33746,4051,4180,4181,0,0,0,0,0,0}---//ҵ������_����
  	TalismanSkillIDs[33350]={33350,33351,33352,33780,33781,33782,4062,4206,4207,0,0,0,0,0,0}---//�������_����
  	TalismanSkillIDs[33353]={33353,33354,33355,33816,33817,33818,4073,4236,4237,4238,0,0,0,0,0}---//�������_����
  	TalismanSkillIDs[33356]={33356,33357,33358,33852,33853,33854,4084,4272,4273,0,0,0,0,0,0}---//̫������_����
  	TalismanSkillIDs[33359]={33359,33360,33361,33759,33760,33761,4056,4191,4192,0,0,0,0,0,0}---//����ŭ��_̫�
  	TalismanSkillIDs[33362]={33362,33363,33364,33795,33796,33797,4067,4218,4219,0,0,0,0,0,0}---//��������_̫�
  	TalismanSkillIDs[33365]={33365,33366,33367,33831,33832,33833,4078,4250,4251,4252,0,0,0,0,0}---//�����Ļ�_̫�
  	TalismanSkillIDs[33368]={33368,33369,33370,33867,33868,33869,4089,4287,4288,4289,0,0,0,0,0}---//��������_̫�
		TalismanSkillIDs[34015]={34015,34016,34017,33762,33763,33764,4366,4370,4371,0,0,0,0,0,0}---//����һ��_����
		TalismanSkillIDs[34018]={34018,34019,34020,33798,33799,33800,4367,4372,4373,0,0,0,0,0,0}---//���ʶ���_����
		TalismanSkillIDs[34021]={34021,34022,34023,33834,33835,33836,4368,4375,4376,4377,0,0,0,0,0}---//��������_����
		TalismanSkillIDs[34024]={34024,34025,34026,33870,33871,33872,4369,4378,4379,4380,0,0,0,0,0}---//�����ļ�_����
 
		TalismanSkillIDs[34662]={34662,34663,34664,34803,34804,34805,4936,4937,4938,0,0,0,0,0,0}---//��������_����
		TalismanSkillIDs[34667]={34667,34668,34669,34807,34808,34809,4940,4941,4942,0,0,0,0,0,0}---//ǣ��һ��_ǣ��
		TalismanSkillIDs[34672]={34672,34673,34674,34811,34812,34813,4944,4945,4946,0,0,0,0,0,0}---//ǣ������_ǣ��
		TalismanSkillIDs[34677]={34677,34678,34679,34815,34816,34817,4948,4949,4950,0,0,0,0,0,0}---//ǣ������_ǣ��
		TalismanSkillIDs[34682]={34682,34683,34684,34819,34820,34821,4953,4954,4955,4956,0,0,0,0,0}---//ǣ���ļ�_ǣ��
		TalismanSkillIDs[34687]={34687,34688,34689,34823,34824,34825,4959,4960,4961,0,0,0,0,0,0}---//Ӣ��һ��_Ӣ��
		TalismanSkillIDs[34692]={34692,34693,34694,34827,34828,34829,4963,4964,4965,0,0,0,0,0,0}---//Ӣ�ж���_Ӣ��
		TalismanSkillIDs[34697]={34697,34698,34699,34831,34832,34833,4967,4968,4969,0,0,0,0,0,0}---//Ӣ������_Ӣ��
		TalismanSkillIDs[34702]={34702,34703,34704,34835,34836,34837,4972,4973,4974,4975,0,0,0,0,0}---//Ӣ���ļ�_Ӣ��

 		for i,v in pairs(TalismanSkillIDs) do
  	 for k = 1,15 do
  	 	if talisman:QueryData(0,dataIndex["skill_addon_id"]) == v[k] then
  	 		HolySkillLevel = k
  	 		HolySkillAddonID = v[k+3]
  	 		HolySkillId0 = v[7]
  	 		HolySkillId1 = v[8]
  	 		HolySkillId2 = v[9]
  	 		HolySkillId3 = v[10]
  	 		HolySkillId4 = v[11]
  	 		HolySkillId5 = v[12]
  	 		HolySkillId6 = v[13]
  	 		HolySkillId7 = v[14]
  	 		HolySkillId8 = v[15]
  	 	end
  	 end 
  	end
  
  	output:UpdateData(0,dataIndex["skill_addon_id"],HolySkillAddonID)
  	output:UpdateData(0,dataIndex["skillrefine_level"],HolySkillLevel)
  	output:UpdateData(0,dataIndex["skillrefine_0"],HolySkillId0)
  	output:UpdateData(0,dataIndex["skillrefine_1"],HolySkillId1)
  	output:UpdateData(0,dataIndex["skillrefine_2"],HolySkillId2)
  	output:UpdateData(0,dataIndex["skillrefine_3"],HolySkillId3)
  	output:UpdateData(0,dataIndex["skillrefine_4"],HolySkillId4)
  	output:UpdateData(0,dataIndex["skillrefine_5"],HolySkillId5)
  	output:UpdateData(0,dataIndex["skillrefine_6"],HolySkillId6)
  	output:UpdateData(0,dataIndex["skillrefine_7"],HolySkillId7)
  	output:UpdateData(0,dataIndex["skillrefine_8"],HolySkillId8)
		output:UpdateData(0,dataIndex["reborncont"],1)

		output:InheritCombineExp(true)
		---���÷����ȼ�---
		local newlevel = 1
		if talisman:QueryLevel() == 31 then newlevel = 11
		elseif talisman:QueryLevel() == 32 then newlevel = 16
		elseif talisman:QueryLevel() == 33 then newlevel = 20
		elseif talisman:QueryLevel() == 34 then newlevel = 23
		elseif talisman:QueryLevel() == 35 then newlevel = 28
		elseif talisman:QueryLevel() == 36 then newlevel = 29
		elseif talisman:QueryLevel() == 37 then newlevel = 30
		else
		end

		output:SetExp(1)
		output:SetLevel(newlevel)
		ZLuaTalRebuild(output,outid)
	end		

end

--------------------------------------------------------------------
------------------��������ϴ��������--------------------------------
function ZLuaTalSkillRefine(id1,id2,talisman1,talisman2,cid,output)
	local dataIndex=ZLuaTalDataIndex()
	local talismans=ZLuaTalAvailableTalismans()
	local outid

	---û����ý����ϴ������---
	if cid == 0 then
		output:CreateItem(-1)
		return
	end

	---û�����ķ���������Ϊ������---
	if talisman1:QueryData(0,dataIndex["reborncont"]) == 0 then
		output:CreateItem(-1)
		return
	end	

	---mei�����ķ���������Ϊ������---
	if talisman2:QueryData(0,dataIndex["reborncont"]) == 0 then
		output:CreateItem(-1)
		return
	end

  ---ûע����ķ����ɽ�����ֹϴ��----------------
	local Registed1 = false
	for _,v in pairs(talismans) do
		if v.tmplID == id1 then Registed1 = true end
	end
	local Registed2 = false
	for _,v in pairs(talismans) do
		if v.tmplID == id2 then Registed2 = true end
	end
	if Registed1 == false or Registed2 == false  then
		output:CreateItem(-1)
		return
	end

 ---�������IDΪ�ɱ�ID�����ֹϴ��--------------
	if talisman1:QueryData(0,dataIndex["is_fly"])==1 or talisman2:QueryData(0,dataIndex["is_fly"])==1 then
		output:CreateItem(-1)
		return
	end

 ---����Ԫ���ƺ���������ֹϴ��------------------
	if id1 == talismans["US_45_YuanXiaoDeng"].tmplID or id1 == talismans["US_75_LingLongTa"].tmplID or id2 == talismans["US_45_YuanXiaoDeng"].tmplID or id2 == talismans["US_75_LingLongTa"].tmplID then
		output:CreateItem(-1)
		return
	end
		
	---ϴ������---
	if cid == 53577 or cid == 55603 then
		ZLuaTalSkillRefineRull(id1,id2,talisman1,talisman2,output)
		return
	end

 	output:CreateItem(-1)

end

----------------------------------------------------------------
------------------ϴ������--------------------------------------
function ZLuaTalSkillRefineRull(id1,id2,talisman1,talisman2,output)

	local dataIndex=ZLuaTalDataIndex()
	local talismans=ZLuaTalAvailableTalismans()

	local inData1={}
	local Datacont1 = 0
	local Datacont2 = 0
	local inData2={}
	local OutData={0,0,0,0,0,0,0,0,}
	local AllSkillProbData={}
	local ALLSkillIDInfo={}
	local SkillSeqPro={}

--
	---���ܸ��ʿ�---
	AllSkillProbData={
	250,150,---//����1������
	150,100,---//����1������
	150,100,---//����1������

	100,100,---//����15����������
	150,100,---//����15����������
	250,250,---//����15����������
	200,100,---//����15�������ϻ�
	80,80,---//����15���������
	80,100,---//����15����������
	100,100,---//����15����������
	80,250,---//����15��������ɽ
	100,100,---//����15����������
	250,80,---//����15�������컪
	100,80,---//����15������̫�
	120,150,---//����15����������
	120,150,---//����15������ǣ��
	120,150,---//����15������Ӣ��

	100,150,---//����75����������
	150,150,---//����75����������
	100,250,---//����75����������
	80,100,---//����75�������ϻ�
	80,100,---//����75���������
	120,100,---//����75����������
	80,100,---//����75����������
	80,150,---//����75��������ɽ
	250,100,---//����75����������
	200,80,---//����75�������컪
	100,250,---//����75������̫�
	80,120,---//����75����������
	80,120,---//����75������ǣ��
	80,120,---//����75������Ӣ��

	100,150,100,---//����105����������
	150,150,100,---//����105����������
	250,100,150,---//����105����������
	100,300,150,---//����105�������ϻ�
	150,300,100,---//����105���������
	100,300,150,---//����105����������
	80,200,250,---//����105����������
	200,100,80,---//����105��������ɽ
	100,80,---//����105����������
	300,150,100,---//����105�������컪
	150,80,100,---//����105������̫�
	150,80,120,---//����105����������
	150,80,---//����105������ǣ��
	150,80,---//����105������Ӣ��
	
	100,80,300,250,---//����135����������
	150,80,80,300,---//����135����������
	300,150,100,150,---//����135����������
	150,150,150,300,---//����135�������ϻ�
	150,150,100,---//����135���������
	100,100,---//����135����������
	150,300,150,---//����135����������
	250,40,100,---//����135��������ɽ
	150,100,100,---//����135����������
	150,300,80,---//����135�������컪
	150,80,100,---//����135������̫�
	60,80,80,---//����135����������
	150,80,80,---//����135������ǣ��
	150,80,80,---//����135������Ӣ��
	
	150,---//45��ľ
	150,---//75ɽ��
	150,---//75��
	300,---//75��ƿ
	200,150,100,---//75����
	300,150,200,---//105����
	200,100,80,---//105���«
	100,100,300,---//105����
	80,120,150,150,---//105���
	100,80,---//105��ң
	150,100,80,80,---//105����
	150,100,---//135���
	60,300,80,---//135����
	100,80,150,---//135��Ԫ
	80,100,150,---//135����
	80,80,150,60,---//135����
	150,40,150,---//135�޼�
	30,150,80,---//135���
	150,50,90,150,---//135��Ѫ��
	30,80,80,150,150,---//135�ɻ�
	80,80,30,100,---//135����
	}
	
	---����ID��Ϣ�⣬����ʿ��Ӧ----
	ALLSkillIDInfo={
	4166,4167,---//����1������
	4168,4169,---//����1������
	4937,4938,---//����1������

	4170,4171,---//����15����������
	4172,4173,---//����15����������
	4174,4175,---//����15����������
	4176,4177,---//����15�������ϻ�
	4178,4179,---//����15���������
	4180,4181,---//����15����������
	4182,4183,---//����15����������
	4184,4185,---//����15��������ɽ
	4186,4187,---//����15����������
	4189,4190,---//����15�������컪
	4191,4192,---//����15������̫�
	4370,4371,---//����15����������
	4941,4942,---//����15������ǣ��
	4960,4961,---//����15������Ӣ��

	4193,4194,---//����75����������
	4196,4197,---//����75����������
	4199,4200,---//����75����������
	4202,4203,---//����75�������ϻ�
	4204,4205,---//����75���������
	4206,4207,---//����75����������
	4208,4209,---//����75����������
	4210,4211,---//����75��������ɽ
	4213,4214,---//����75����������
	4215,4216,---//����75�������컪
	4218,4219,---//����75������̫�
	4372,4373,---//����75����������
	4945,4946,---//����75������ǣ��
	4964,4965,---//����75������Ӣ��
	
	4221,4222,4223,---//����105����������
	4224,4225,4226,---//����105����������
	4227,4228,4229,---//����105����������
	4230,4231,4232,---//����105�������ϻ�
	4233,4234,4235,---//����105���������
	4236,4237,4238,---//����105����������
	4239,4240,4241,---//����105����������
	4242,4243,4244,---//����105��������ɽ
	4245,4246,---//����105����������
	4247,4248,4249,---//����105�������컪
	4250,4251,4252,---//����105������̫�
	4375,4376,4377,---//����105����������
	4949,4950,---//����105������ǣ��
	4968,4969,---//����105������Ӣ��
	
	4253,4254,4255,4256,---//����135����������
	4257,4258,4259,4260,---//����135����������
	4261,4262,4263,4264,---//����135����������
	4265,4266,4267,4268,---//����135�������ϻ�
	4269,4270,4271,---//����135���������
	4272,4273,---//����135����������
	4274,4275,4276,---//����135����������
	4278,4279,4280,---//����135��������ɽ
	4281,4282,4283,---//����135����������
	4284,4285,4286,---//����135�������컪
	4287,4288,4289,---//����135������̫�
	4378,4379,4380,---//����135����������
	4954,4955,4956,---//����135������ǣ��
	4973,4974,4975,---//����135������Ӣ��
	
	4290,---//45��ľ
	4291,---//75ɽ��
	4292,---//75��
	4293,---//75��ƿ
	4294,4295,4296,---//75����
	4297,4298,4299,---//105����
	4300,4301,4302,---//105���«
	4303,4304,4305,---//105����
	4306,4307,4308,4309,---//105���
	4310,4311,---//105��ң
	4312,4313,4314,4315,---//105����
	4316,4317,---//135���
	4318,4319,4320,---//135����
	4321,4322,4323,---//135��Ԫ
	4324,4325,4326,---//135����
	4327,4328,4329,4330,---//135����
	4331,4332,4333,---//135�޼�
	4334,4335,4336,---//135���
	4337,4338,4339,4340,---//135��Ѫ��
	4342,4343,4344,4345,4346,---//135�ɻ�
	4347,4348,4349,4350,---//135����
	}
	
	local transBUGskillID = {}
	----------------ǿID----��ID-��������-��������ID
	transBUGskillID[4349]	= {4452,80,43475}
	transBUGskillID[4342]	= {4453,80,10877}
	transBUGskillID[4338]	= {4454,80,10876}
	transBUGskillID[4334]	= {4455,80,10875}
	transBUGskillID[4332]	= {4456,80,34820}
	transBUGskillID[4330]	= {4457,80,25732}
	transBUGskillID[4322]	= {4458,80,20090}
	transBUGskillID[4318]	= {4459,80,10872}

	---��������������---
	inData1 = {
	talisman1:QueryData(0,dataIndex["skillrefine_1"]),
	talisman1:QueryData(0,dataIndex["skillrefine_2"]),
	talisman1:QueryData(0,dataIndex["skillrefine_3"]),
	talisman1:QueryData(0,dataIndex["skillrefine_4"]),
	talisman1:QueryData(0,dataIndex["skillrefine_5"]),
	talisman1:QueryData(0,dataIndex["skillrefine_6"]),
	talisman1:QueryData(0,dataIndex["skillrefine_7"]),
	talisman1:QueryData(0,dataIndex["skillrefine_8"]),
	}
	---��ת��Ч���ĵ��ض�����ת���ԭID--
	for k=1,8 do
		for i,v in pairs(transBUGskillID) do
			if inData1[k] == v[1] then
				inData1[k] = i
			end
		end
	end
	
	---������������Ч���ܸ���---
	for i=1,8 do
		if inData1[i]~=0 then Datacont1=Datacont1+1 end
	end

	---��������������---
	inData2 = {
	talisman2:QueryData(0,dataIndex["skillrefine_1"]),
	talisman2:QueryData(0,dataIndex["skillrefine_2"]),
	talisman2:QueryData(0,dataIndex["skillrefine_3"]),
	talisman2:QueryData(0,dataIndex["skillrefine_4"]),
	talisman2:QueryData(0,dataIndex["skillrefine_5"]),
	talisman2:QueryData(0,dataIndex["skillrefine_6"]),
	talisman2:QueryData(0,dataIndex["skillrefine_7"]),
	talisman2:QueryData(0,dataIndex["skillrefine_8"]),
	}

	---��ת��Ч���ĵ��ض�����ת���ԭID--
	for k=1,8 do
		for i,v in pairs(transBUGskillID) do
			if inData2[k] == v[1] then
				inData2[k] = i
			end
		end
	end

  ---ȥ���ظ���������---	
	for i=1,8 do
		for j=1,8 do
			if inData2[i]==inData1[j] and inData2[i]~=0 then
				inData2[i]=0
			end
		end
	end
	---���㸨������Ч���ܸ�����ȥ���ظ��������ݺ�---
	for i=1,8 do
		if inData2[i]~=0 then Datacont2=Datacont2+1 end
	end
	---�ں�ǰ��ʱ�������ݿ�---	
	local BaseDataIn={}
	BaseDataIn = {
	inData1[1],
	inData1[2],
	inData1[3],
	inData1[4],
	inData1[5],
	inData1[6],
	inData1[7],
	inData1[8],
	inData2[1],
	inData2[2],
	inData2[3],
	inData2[4],
	inData2[5],
	inData2[6],
	inData2[7],
	inData2[8],
	}	
	---�״��ں϶��⸽��һ��������Ч����������
	local firstrefine
	if talisman1:QueryData(0,dataIndex["skillrefinecont"])==1 then
		firstrefine = 1
	else
		firstrefine = 0
	end
	for i=1,16 do
		for j=1,table.getn(ALLSkillIDInfo) do
			if ALLSkillIDInfo[j]==BaseDataIn[i] then
				SkillSeqPro[i]=AllSkillProbData[j] + firstrefine*100
			else
				SkillSeqPro[i]=80	---�ռ��ܸ���
			end
		end
	end

	---���ϴ����������ֵ---
	local NumChance = 0
	local a = math.random(1,100)
	local b = math.random(1,100)
	if a<math.floor(100-100*Datacont1/8) then
		NumChance=1
	elseif b<math.floor(100*Datacont1/8) then
		NumChance=-1
	else
		NumChance=0
	end
	
	---ϴ����������---
	local DatacontOut = Datacont1+Datacont2 +  NumChance
	if DatacontOut >= 8 then 
		DatacontOut = 8
	elseif DatacontOut < 1 then
		DatacontOut = 1
	else
	end
	
	---�������������ѡȡ���ܣ������ظ���������---
	for i=1,DatacontOut do
		OutData[i]=BaseDataIn[ZLuaTal_Get_RanPoint(SkillSeqPro)]
		if i~=1 then
			for j=1,i-1 do
				if OutData[i] == OutData[j] and OutData[i] ~=0 then
					OutData[i]=0
				end
			end
		end
	end
	
	local OutDataRull={0,0,0,0,0,0,0,0,}
	local k = 0
	for i=1,8 do
		if OutData[i] ~= 0 then
			OutDataRull[k+1] = OutData[i]
			k = k + 1
		end
	end
	
	---��BUG����IDת�������Ч��ID
	for i=1,8 do
		for k,v in pairs(transBUGskillID) do
			if OutDataRull[i] == k and v[3] ~= id1 then
				OutDataRull[i] = v[1]
			end
		end
	end

	---������Ч��������3�������Ч����С��3��ʱ�����⴦��
	local tmpOutData={}
	local tmpOutDataPro={}
	local tmp1=1
	for i=1,table.getn(BaseDataIn) do
		if BaseDataIn[i] ~= 0 then
			tmpOutData[tmp1] = BaseDataIn[i]
			tmp1=tmp1+1
		end
	end
	
	for m=1,table.getn(tmpOutData) do
		for i=1,table.getn(ALLSkillIDInfo) do
			if ALLSkillIDInfo[i] == tmpOutData[m] then
				tmpOutDataPro[m] = AllSkillProbData[i]
			end
		end
	end
	---�����tmpOutData����ID�����趨�����ɸߵ�������
	local tmpData1
	local tmpDataPro1
	for i=1,table.getn(tmpOutData)-1 do
		for j=1,table.getn(tmpOutData)-1 do
			if tmpOutDataPro[j]<tmpOutDataPro[j+1] then
				tmpDataPro1 				= tmpOutDataPro[j]
				tmpOutDataPro[j]		= tmpOutDataPro[j+1]
				tmpOutDataPro[j+1] 	= tmpDataPro1
				tmpData1 						= tmpOutData[j]
				tmpOutData[j]				= tmpOutData[j+1]
				tmpOutData[j+1]			= tmpData1
			end
		end
	end

	---��BUG����IDת�������Ч��ID
	for i=1,8 do
		for k,v in pairs(transBUGskillID) do
			if tmpOutData[i] == k and v[3] ~= id1 then
				tmpOutData[i] = v[1]
			end
		end
	end

	local OutDataRullCont = 0
	for i=1,8 do
		if OutDataRull[i] ~= 0 then
			OutDataRullCont = OutDataRullCont+1
		end
	end
	
	---�����Ч��ֻ��2������ȫ�ں�
	if Datacont1+Datacont2 == 2 then
		OutDataRull[1] = talisman1:QueryData(0,dataIndex["skillrefine_1"])
		OutDataRull[2] = talisman2:QueryData(0,dataIndex["skillrefine_1"])
	---�����Ч������2������������С��3���������ٱ���3���߸���Ч��
	elseif OutDataRullCont < 3 and Datacont1+Datacont2 > 2 then
		OutDataRull[1] = tmpOutData[1]
		OutDataRull[2] = tmpOutData[2]
		OutDataRull[3] = tmpOutData[3]
	end
	
	---��ֵ---	
	output:CreateItem(id1)
	for _,index in pairs(dataIndex) do
		output:UpdateData(0,index,talisman1:QueryData(0,index))
	end

	output:UpdateData(0,dataIndex["skillrefinetmp_1"],OutDataRull[1])
	output:UpdateData(0,dataIndex["skillrefinetmp_2"],OutDataRull[2])
	output:UpdateData(0,dataIndex["skillrefinetmp_3"],OutDataRull[3])
	output:UpdateData(0,dataIndex["skillrefinetmp_4"],OutDataRull[4])
	output:UpdateData(0,dataIndex["skillrefinetmp_5"],OutDataRull[5])
	output:UpdateData(0,dataIndex["skillrefinetmp_6"],OutDataRull[6])
	output:UpdateData(0,dataIndex["skillrefinetmp_7"],OutDataRull[7])
	output:UpdateData(0,dataIndex["skillrefinetmp_8"],OutDataRull[8])

	output:UpdateData(0,dataIndex["skillrefinecont"],talisman1:QueryData(0,dataIndex["skillrefinecont"])+1)

	output:InheritCombineExp(true)
	ZLuaTalRebuild(output,id1)
	return
end

-----------------------------------------------------------------
------------------��������ϴ��ȷ��������-----------------------------------------------------------------------------
function ZluaTalSkillRefineResult(id1, talisman1, result, output)
	local dataIndex=ZLuaTalDataIndex()
	local talismans=ZLuaTalAvailableTalismans()
	local outid = id1

	if cid == 0 then
		output:CreateItem(-1)
		return
	end

---û�����ķ���������ϴ��-----------------------
	if talisman1:QueryData(0,dataIndex["reborncont"]) == 0 then
		output:CreateItem(-1)
		return
	end

---���������û�л��漼��Ч����Ϣ��ϴ��ʧ��-----
	if talisman1:QueryData(0,dataIndex["skillrefinetmp_1"]) == 0 then
		output:CreateItem(-1)
		return
	end

	output:CreateItem(outid)
	for _,index in pairs(dataIndex) do
		output:UpdateData(0,index,talisman1:QueryData(0,index))
	end

	if result == 0 then			
		output:UpdateData(0,dataIndex["skillrefinetmp_1"],0)
		output:UpdateData(0,dataIndex["skillrefinetmp_2"],0)
		output:UpdateData(0,dataIndex["skillrefinetmp_3"],0)
		output:UpdateData(0,dataIndex["skillrefinetmp_4"],0)
		output:UpdateData(0,dataIndex["skillrefinetmp_5"],0)
		output:UpdateData(0,dataIndex["skillrefinetmp_6"],0)
		output:UpdateData(0,dataIndex["skillrefinetmp_7"],0)
		output:UpdateData(0,dataIndex["skillrefinetmp_8"],0)
	elseif result == 1 then
		output:UpdateData(0,dataIndex["skillrefine_1"],talisman1:QueryData(0,dataIndex["skillrefinetmp_1"]))
		output:UpdateData(0,dataIndex["skillrefine_2"],talisman1:QueryData(0,dataIndex["skillrefinetmp_2"]))
		output:UpdateData(0,dataIndex["skillrefine_3"],talisman1:QueryData(0,dataIndex["skillrefinetmp_3"]))
		output:UpdateData(0,dataIndex["skillrefine_4"],talisman1:QueryData(0,dataIndex["skillrefinetmp_4"]))
		output:UpdateData(0,dataIndex["skillrefine_5"],talisman1:QueryData(0,dataIndex["skillrefinetmp_5"]))
		output:UpdateData(0,dataIndex["skillrefine_6"],talisman1:QueryData(0,dataIndex["skillrefinetmp_6"]))
		output:UpdateData(0,dataIndex["skillrefine_7"],talisman1:QueryData(0,dataIndex["skillrefinetmp_7"]))
		output:UpdateData(0,dataIndex["skillrefine_8"],talisman1:QueryData(0,dataIndex["skillrefinetmp_8"]))
		output:UpdateData(0,dataIndex["skillrefinetmp_1"],0)
		output:UpdateData(0,dataIndex["skillrefinetmp_2"],0)
		output:UpdateData(0,dataIndex["skillrefinetmp_3"],0)
		output:UpdateData(0,dataIndex["skillrefinetmp_4"],0)
		output:UpdateData(0,dataIndex["skillrefinetmp_5"],0)
		output:UpdateData(0,dataIndex["skillrefinetmp_6"],0)
		output:UpdateData(0,dataIndex["skillrefinetmp_7"],0)
		output:UpdateData(0,dataIndex["skillrefinetmp_8"],0)
	end

	local RefineCont = 0
	local DataSkillRefine={}
	DataSkillRefine={
	talisman1:QueryData(0,dataIndex["skillrefine_1"]),
	talisman1:QueryData(0,dataIndex["skillrefine_2"]),
	talisman1:QueryData(0,dataIndex["skillrefine_3"]),
	talisman1:QueryData(0,dataIndex["skillrefine_4"]),
	talisman1:QueryData(0,dataIndex["skillrefine_5"]),
	talisman1:QueryData(0,dataIndex["skillrefine_6"]),
	talisman1:QueryData(0,dataIndex["skillrefine_7"]),
	talisman1:QueryData(0,dataIndex["skillrefine_8"]),
	}
	for i=1,8 do
		if DataSkillRefine[i]~=0 then
			RefineCont=RefineCont+1
		end
	end
	local finalLevel
	if RefineCont == 8 then
		finalLevel = 3
	elseif RefineCont>=1 or RefineCont<8 then
		finalLevel = 2
	else
		finalLevel = 1
	end
	output:UpdateData(0,dataIndex["reborncont"],finalLevel)
	output:InheritCombineExp(true)
	ZLuaTalRebuild(output,outid)
	
end

------------------����������Ƕ������-----------------------------------------------------------------------------
function ZLuaTalSkillAdd(id1,id2,talisman1,talisman2,cid1,cid2,output)
	local dataIndex=ZLuaTalDataIndex()
	local talismans=ZLuaTalAvailableTalismans()
	local outid = id1

	if cid == 0 then
		output:CreateItem(-1)
		return
	end

  ---ûע����ķ����ɽ�����ֹϴ��----------------
	local Registed1 = false
	for _,v in pairs(talismans) do
		if v.tmplID == id1 then Registed1 = true end
	end
	local Registed2 = false
	for _,v in pairs(talismans) do
		if v.tmplID == id2 then Registed2 = true end
	end
	if Registed1 == false or Registed2 == false  then
		output:CreateItem(-1)
		return
	end

 ---�������IDΪ�ɱ�ID�����ֹ��Ƕ--------------
	if talisman1:QueryData(0,dataIndex["is_fly"])==1 or talisman2:QueryData(0,dataIndex["is_fly"])==1 then
		output:CreateItem(-1)
		return
	end

 ---����Ԫ���ƺ���������ֹ��Ƕ------------------
	if id1 == talismans["US_45_YuanXiaoDeng"].tmplID or id1 == talismans["US_75_LingLongTa"].tmplID or id2 == talismans["US_45_YuanXiaoDeng"].tmplID or id2 == talismans["US_75_LingLongTa"].tmplID then
		output:CreateItem(-1)
		return
	end

	---�������������-----------------------
	if talisman1:QueryData(0,dataIndex["reborncont"]) == 0 then
		output:CreateItem(-1)
		return
	end

	---����������Ϊδ����-----------------------
	if talisman2:QueryData(0,dataIndex["reborncont"]) >= 1 then
		output:CreateItem(-1)
		return
	end

	---�������ű���͸���������---
	for _,v in pairs(talismans) do
		if v.tmplID == id2 then
			if v.tmplID1 ~= cid1 or v.tmplID2 ~= cid2 then
				output:CreateItem(-1)
				return
			end
		end
	end	
	
	local NumChance={120,80,80,45,15,}	---//ÿ��λ��ѡȡ�ĸ�������
	local addSkillIn	= {}	---//��Ƕǰ�ļ�������
	local addSkillOut	= {}	---//��Ƕ��ļ�������
	local whatskilltoadd	---//�������������ļ��ܼ���Ҫ����Ƕ�ļ���
	whatskilltoadd = talisman2:QueryData(0,dataIndex["skill_addon_id"])
--------------
	local TalismanSkillIDs={}
	TalismanSkillIDs[399]={399,1278,1279,34088,34089,34259,34330,34401,}---//��������_����ʯ.ext
	TalismanSkillIDs[400]={400,1292,1293,34140,34141,34261,34332,34403,}---//�����ݺ�_���Ͼ�.ext
	TalismanSkillIDs[401]={401,1326,1327,34232,34233,34262,34333,34404,}---//����Ѫ��_��ȸӡ.ext
	TalismanSkillIDs[402]={402,1294,1295,34144,34145,34263,34334,34405,}---//�����ֻ�_�ֻ���.ext
	TalismanSkillIDs[403]={403,1308,1309,34168,34169,34264,34335,34406,}---//������_������.ext
	TalismanSkillIDs[404]={404,1298,1299,34150,34151,34273,34344,34415,}---//���Ǹ���_���ǽ�.ext
	TalismanSkillIDs[405]={405,1318,1319,34196,34197,34274,34345,34416,}---//����Ѫ��_�����.ext
	TalismanSkillIDs[406]={406,1284,1285,34130,34131,34275,34346,34417,}---//��ս�ħ_�����.ext
	TalismanSkillIDs[407]={407,1280,1281,34104,34105,34276,34347,34418,}---//ɲ�Ƿ���_���黷.ext
	TalismanSkillIDs[408]={408,1306,1307,34166,34167,34310,34381,34452,}---//��ɽ�续_ɽ����.ext
	TalismanSkillIDs[409]={409,1312,1313,34172,34173,34309,34380,34451,}---//��̩��_��ľ��.ext
	TalismanSkillIDs[410]={410,1320,1321,34216,34217,34311,34382,34453,}---//������_�򶾴�(�򶾶�).ext
	TalismanSkillIDs[411]={411,1300,1301,34156,34157,34312,34383,34454,}---//���컪_ǧ��̳(��ƿ).ext
	TalismanSkillIDs[860]={860,1282,1283,34120,34121,34285,34356,34427,}---//ǧ�Ѥ��_�������.ext
	TalismanSkillIDs[861]={861,1324,1325,34224,34225,34316,34387,34458,}---//��������_������.ext
	TalismanSkillIDs[862]={862,1296,1297,34146,34147,34320,34391,34462,}---//�������_����.ext
	TalismanSkillIDs[863]={863,1286,1287,34132,34133,34315,34386,34457,}---//����Ǭ��_���«.ext
	TalismanSkillIDs[864]={864,1290,1291,34136,34137,34288,34359,34430,}---//�����޼�_����.ext
	TalismanSkillIDs[865]={865,1302,1303,34158,34159,34286,34357,34428,}---//���է��_Ǭ������.ext
	TalismanSkillIDs[866]={866,1322,1323,34218,34219,34321,34392,34463,}---//��������_������.ext
	TalismanSkillIDs[867]={867,1288,1289,34134,34135,34314,34385,34456,}---//�������_���������.ext
	TalismanSkillIDs[868]={868,1304,1305,34164,34165,34287,34358,34429,}---//Ǭ������_����Ǭ����.ext
	TalismanSkillIDs[869]={869,1310,1311,34170,34171,34326,34397,34468,}---//����ĳ�_���.ext
	TalismanSkillIDs[870]={870,1316,1317,34194,34195,34327,34398,34469,}---//��Ѫа��_��Ѫ��.ext
	TalismanSkillIDs[871]={871,1314,1315,34192,34193,34328,34399,34470,}---//�ɻ���˫_�ɻ�.ext
--	TalismanSkillIDs[1653]={1653,1654,1655,33888,33889,33890}---//���������_������.ext
	TalismanSkillIDs[1697]={1697,1698,1699,34102,34103,34300,34371,34442,}---//����֮��_����.ext
	TalismanSkillIDs[1700]={1700,1701,1702,34142,34143,34299,34370,34441,}---//��������_�ֻ���.ext
	TalismanSkillIDs[1703]={1703,1704,1705,34160,34161,34297,34368,34439,}---//����̾��_Ǭ����.ext
	TalismanSkillIDs[1706]={1706,1707,1708,34228,34229,34298,34369,34440,}---//�����ĸ�_��ڤ����_.ext
	TalismanSkillIDs[1738]={1738,1739,1740,34152,34153,34317,34388,34459,}---//��������_����ӡ.ext
	TalismanSkillIDs[1753]={1753,1754,1755,34220,34221,34318,34389,34460,}---//��ң����_��ɽ����.ext
	TalismanSkillIDs[1806]={1806,1807,1808,34222,34223,34265,34336,34407,}---//�������_Ѫ���Ƭ.ext
	TalismanSkillIDs[1809]={1809,1810,1811,34148,34149,34277,34348,34419,}---//���廪��_��ɲ.ext
	TalismanSkillIDs[1812]={1812,1813,1814,34154,34155,34289,34360,34431,}---//��������_ǧ����.ext
	TalismanSkillIDs[1815]={1815,1816,1817,34118,34119,34301,34372,34443,}---//����֮��_����.ext
	TalismanSkillIDs[2037]={2037,2038,2039,34106,34107,34322,34393,34464,}---//�����̷�_����ӡ.ext
	TalismanSkillIDs[2153]={2153,2154,2155,34092,34093,34323,34394,34465,}---//������̶_������
	TalismanSkillIDs[2598]={2598,2599,2600,34162,34163,34313,34384,34455,}---//������_���±���
--	TalismanSkillIDs[3088]={3088,3088,3088}---//Ԫ����ף_Ԫ����
	TalismanSkillIDs[3162]={3162,3163,3164,34116,34117,34319,34390,34461,}---//ʥ����ħ_����
	TalismanSkillIDs[3391]={3391,3392,3393,34226,34227,34324,34395,34466,}---//�׹�֮��_�����
	TalismanSkillIDs[3825]={3825,3826,3827,34090,34091,34325,34396,34467,}---//�����_����֮��
	TalismanSkillIDs[32954]={32954,32955,32956,34214,34215,34329,34400,34471,}---//�������_����.ext

	TalismanSkillIDs[3610]={3610,3611,3612,34188,34189,34260,34331,34402,}---//��ʻ�һ_����
	TalismanSkillIDs[3613]={3613,3614,3615,34184,34185,34267,34338,34409,}---//������_����
	TalismanSkillIDs[3616]={3616,3617,3618,34190,34191,34279,34350,34421,}---//����ɷѪ_����
	TalismanSkillIDs[3619]={3619,3620,3621,34180,34181,34291,34362,34433,}---//������ɱ_����
	TalismanSkillIDs[3622]={3622,3623,3624,34186,34187,34303,34374,34445,}---//����ɥ��_����
	TalismanSkillIDs[3625]={3625,3626,3627,34174,34175,34268,34339,34410,}---//��Ӱ����_��ɽ
	TalismanSkillIDs[3628]={3628,3629,3630,34176,34177,34280,34351,34422,}---//���Ƿ���_��ɽ
	TalismanSkillIDs[3631]={3631,3632,3633,34178,34179,34292,34363,34434,}---//������Ӱ_��ɽ
	TalismanSkillIDs[3634]={3634,3635,3636,34182,34183,34304,34375,34446,}---//�ػ�����_��ɽ
	TalismanSkillIDs[3943]={3943,3944,3945,34126,34127,34269,34340,34411,}---//Ѫɱǧ��_����
	TalismanSkillIDs[3946]={3946,3947,3948,34124,34125,34281,34352,34423,}---//��ɨǧ��_����
	TalismanSkillIDs[3949]={3949,3950,3951,34128,34129,34293,34364,34435,}---//�ƻ�ǧ��_����
	TalismanSkillIDs[3952]={3952,3953,3954,34122,34123,34305,34376,34447,}---//���Ӱ��_����
	TalismanSkillIDs[3955]={3955,3956,3957,34208,34209,34270,34341,34412,}---//������_�컪
	TalismanSkillIDs[3958]={3958,3959,3960,34212,34213,34282,34353,34424,}---//�����_�컪
	TalismanSkillIDs[3961]={3961,3962,3963,34210,34211,34294,34365,34436,}---//�������_�컪
	TalismanSkillIDs[3964]={3964,3965,3966,34206,34207,34306,34377,34448,}---//��ħ����_�컪

	TalismanSkillIDs[33347]={33347,33348,33349,34114,34115,34266,34337,34408,}---//ҵ������_����
	TalismanSkillIDs[33350]={33350,33351,33352,34108,34109,34278,34349,34420,}---//�������_����
	TalismanSkillIDs[33353]={33353,33354,33355,34110,34111,34290,34361,34432,}---//�������_����
	TalismanSkillIDs[33356]={33356,33357,33358,34112,34113,34302,34373,34444,}---//̫������_����
	TalismanSkillIDs[33359]={33359,33360,33361,34200,34201,34271,34342,34413,}---//����ŭ��_̫�
	TalismanSkillIDs[33362]={33362,33363,33364,34198,34199,34283,34354,34425,}---//��������_̫�
	TalismanSkillIDs[33365]={33365,33366,33367,34204,34205,34295,34366,34437,}---//�����Ļ�_̫�
	TalismanSkillIDs[33368]={33368,33369,33370,34202,34203,34307,34378,34449,}---//��������_̫�
	TalismanSkillIDs[34015]={34015,34016,34017,34096,34097,34272,34343,34414,}---//����һ��_����
	TalismanSkillIDs[34018]={34018,34019,34020,34100,34101,34284,34355,34426,}---//���ʶ���_����
	TalismanSkillIDs[34021]={34021,34022,34023,34098,34099,34296,34367,34438,}---//��������_����
	TalismanSkillIDs[34024]={34024,34025,34026,34094,34095,34308,34379,34450,}---//�����ļ�_����

	TalismanSkillIDs[34662]={34662,34663,34664,34665,34666,34839,34840,34841,}---//��������_����
	TalismanSkillIDs[34667]={34667,34668,34669,34670,34671,34842,34843,34844,}---//ǣ��һ��_ǣ��
	TalismanSkillIDs[34672]={34672,34673,34674,34675,34676,34845,34846,34847,}---//ǣ������_ǣ��
	TalismanSkillIDs[34677]={34677,34678,34679,34680,34681,34848,34849,34850,}---//ǣ������_ǣ��
	TalismanSkillIDs[34682]={34682,34683,34684,34685,34686,34851,34852,34853,}---//ǣ���ļ�_ǣ��
	TalismanSkillIDs[34687]={34687,34688,34689,34690,34691,34854,34855,34856,}---//Ӣ��һ��_Ӣ��
	TalismanSkillIDs[34692]={34692,34693,34694,34695,34696,34857,34858,34859,}---//Ӣ�ж���_Ӣ��
	TalismanSkillIDs[34697]={34697,34698,34699,34700,34701,34860,34861,34862,}---//Ӣ������_Ӣ��
	TalismanSkillIDs[34702]={34702,34703,34704,34705,34706,34863,34864,34865,}---//Ӣ���ļ�_Ӣ��

--	
	local transskilladd
	for i,v in pairs(TalismanSkillIDs) do
		for j=1,3 do
			if whatskilltoadd == v[j] then
				transskilladd = v[j+5]
			end
		end
	end
--	
	
	addSkillIn={
	talisman1:QueryData(0,dataIndex["newaddon_id_1"]),
	talisman1:QueryData(0,dataIndex["newaddon_id_2"]),
	talisman1:QueryData(0,dataIndex["newaddon_id_3"]),
	talisman1:QueryData(0,dataIndex["newaddon_id_4"]),
	talisman1:QueryData(0,dataIndex["newaddon_id_5"]),
	}
	
	---���ظ����ͼ�����Ƕʧ��
	for i,v in pairs(TalismanSkillIDs) do
		for k=1,5 do
			for m=6,8 do
				if addSkillIn[k] == v[m] and ( transskilladd==v[6] or transskilladd==v[7] or transskilladd==v[8] ) then
					output:CreateItem(-1)
					return
				end
			end
		end
	end
	
	local pos = ZLuaTal_Get_RanPoint(NumChance)
	for i=1,5 do
		if i == pos then
			addSkillOut[i] = transskilladd
		else
			addSkillOut[i] = addSkillIn[i]
		end
	end

	local addSkillOutRull={0,0,0,0,0,}
	local k = 0
	for i=1,5 do
		if addSkillOut[i] ~= 0 then
			addSkillOutRull[k+1] = addSkillOut[i]
			k=k+1
		end
	end
	
	output:CreateItem(outid)
	for _,index in pairs(dataIndex) do
		output:UpdateData(0,index,talisman1:QueryData(0,index))
	end
	output:UpdateData(0,dataIndex["newaddon_id_1"],addSkillOutRull[1])
	output:UpdateData(0,dataIndex["newaddon_id_2"],addSkillOutRull[2])
	output:UpdateData(0,dataIndex["newaddon_id_3"],addSkillOutRull[3])
	output:UpdateData(0,dataIndex["newaddon_id_4"],addSkillOutRull[4])
	output:UpdateData(0,dataIndex["newaddon_id_5"],addSkillOutRull[5])
	output:InheritCombineExp(true)
	ZLuaTalRebuild(output,outid)

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
			FailSkillList[6]={337,338,33387,33388,33389,33390,33391}	---//����
			FailSkillList[7]={3510,3511,3512,3513,3514,3515,3516}	---//����
			FailSkillList[8]={3534,3535,3536,3537,3538,3539,3540}	---//��ɽ
			FailSkillList[9]={3972,3973,3974,3975,3976,3977,3978}	---//����
			FailSkillList[10]={3996,3997,3998,3999,4000,4001,4002}	---//�컪
			FailSkillList[11]={33411,33412,33413,33414,33415,33416,33417}	---//̫�
			FailSkillList[12]={34035,34036,34037,34038,34039,34040,34041}	---//����
			FailSkillList[13]={34707,34708,34709,34710,34711,34712,34713}	---//ǣ��
			FailSkillList[14]={34731,34732,34733,34734,34735,34736,34737}	---//Ӣ��
			FailSkillList[99]={337,338,337,338,337,338,337}	---//ͨ��
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
-- ������λ�������� -------------------------------------------------------------------
function ZLuaTalisman_Rise(id,talisman1,cid,output)
	local dataIndex = ZLuaTalDataIndex()
	local maxlevel=10
	local whattorise=ZLuaTalisman_chooserise(cid)
	local currenlevel=talisman1:QueryData(0,whattorise) or 0
	local totalgrade=talisman1:QueryData(0,dataIndex["all_rise"]) or 0

	if currenlevel<maxlevel then 
		output:CreateItem(id)
		for _,index in pairs(dataIndex) do
			output:UpdateData(0,index,talisman1:QueryData(0,index))
		end
		output:UpdateData(0,whattorise,currenlevel+1)
		output:UpdateData(0,dataIndex["all_rise"],totalgrade+1)
		output:InheritCombineExp(true)
		ZLuaTalRebuild(output,id)
	else
		output:CreateItem(-1)
	end
end
---------------------------------------------------------------------------------------
-- ���������Զ���ǿ�� -----------------------------------------------------------------
function ZLuaTalisman_Rise2(id,talisman1,cid,output)
	local dataIndex = ZLuaTalDataIndex()
	local whattorise, valueCap, valueAdd, chanceLowCap, chanceHigCap, chance
	local current
	local talLevel = talisman1:QueryLevel()
	
	if talLevel > 35 then talLevel = 35 end
	
	if cid == 23860 then 
		whattorise = dataIndex["hp_enhance"]
		valueCap = 200 * talLevel
		valueAdd = 10
		chanceLowCap = 0.15
	elseif cid == 23861 then 
		whattorise = dataIndex["mp_enhance"] 
		valueCap = 200 * talLevel
		valueAdd = 10
		chanceLowCap = 0.10
	elseif cid == 23862 then 
		whattorise = dataIndex["atk_enhance"]
		valueCap = 30 * talLevel
		valueAdd = 2
		chanceLowCap = 0.10
	elseif cid == 11784 then 
		whattorise = dataIndex["hp_enhance"]
		valueCap = 200 * talLevel
		valueAdd = 7000
		chanceLowCap = 0.15
	elseif cid == 12021 then 
		whattorise = dataIndex["mp_enhance"]
		valueCap = 200 * talLevel
		valueAdd = 7000
		chanceLowCap = 0.15
	elseif cid == 19716 then 
		whattorise = dataIndex["atk_enhance"]
		valueCap = 30 * talLevel
		valueAdd = 1050
		chanceLowCap = 0.10

	end
	
	current = talisman1:QueryData(0,whattorise) or 0
	if 0 <= current and current < valueCap then
		output:CreateItem(id)
		for _,index in pairs(dataIndex) do
			output:UpdateData(0,index,talisman1:QueryData(0,index))
		end
		chance = 1.0 - 0.002*current/valueAdd
		chance = math.max(chance,chanceLowCap)
		chance = math.min(chance,1.0)
		if math.random() <= chance then
			output:UpdateData(0,whattorise,math.min(current+valueAdd,valueCap))
		end
		output:InheritCombineExp(true)
		ZLuaTalRebuild(output,id)
	else
		output:CreateItem(-1)
	end
end
---------------------------------------------------------------------------------------
----------------------������ý����ѡ��������-------------------------------------------
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
-- �ɽ�Ʒ�ʸ������� -------------------------------------------------------------------
function ZLuaTalisman_ImproveFlyerQuality(id, talisman1, cid, output)
	local dataIndex=ZLuaTalDataIndex()
	local SkillNoSeq={}				
	local SkillReqLvlSeq={}
	local skills_amount=0
	local fail=0
	

	-- �������ʱ�޷ɽ����ܹ�ħ����Ʒ��
	local talismans = ZLuaTalAvailableTalismans()
	local timeLimit = true
	for i,v in pairs(talismans) do
		if v.tmplID == id and v.timeLimit == false then
			timeLimit = false
		end
	end
	if timeLimit == true then
--		return false
	end

	SkillNoSeq[1]=talisman1:QueryData(0,dataIndex["addon_1_id"])
	SkillReqLvlSeq[1]=talisman1:QueryData(0,dataIndex["addon_1_learn_level"])
	SkillNoSeq[2]=talisman1:QueryData(0,dataIndex["addon_2_id"])
	SkillReqLvlSeq[2]=talisman1:QueryData(0,dataIndex["addon_2_learn_level"])
	SkillNoSeq[3]=talisman1:QueryData(0,dataIndex["addon_3_id"])
	SkillReqLvlSeq[3]=talisman1:QueryData(0,dataIndex["addon_3_learn_level"])
	SkillNoSeq[4]=talisman1:QueryData(0,dataIndex["addon_4_id"])
	SkillReqLvlSeq[4]=talisman1:QueryData(0,dataIndex["addon_4_learn_level"])
	SkillNoSeq[5]=talisman1:QueryData(0,dataIndex["addon_5_id"])
	SkillReqLvlSeq[5]=talisman1:QueryData(0,dataIndex["addon_5_learn_level"])
	SkillNoSeq[6]=talisman1:QueryData(0,dataIndex["addon_6_id"])
	SkillReqLvlSeq[6]=talisman1:QueryData(0,dataIndex["addon_6_learn_level"])

	for i = 1,6 do
		if SkillNoSeq[i] > 0 then
			skills_amount = skills_amount + 1
		end
	end

	output:CreateItem(id)
	for _,index in pairs(dataIndex) do
		output:UpdateData(0,index,talisman1:QueryData(0,index))
	end

 	local r1 = math.random()
 	local r2 = math.random()
	local Mchoise = {}
  local RSkillExInfo_1={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	local RSkillExInfo_2={}    ----���ڷ��صĸ�������ID����
	local RSkillReqInfo={}     ----�����������󷨱�������Ϣ

	local Skill_AddonInfo={1922,1923,1924,1925,1926,1927}
	local	Skill_ReqLvlInfo={1,10,15,20,25,30}

	-- ֻ���������ͷ�ʽ
	if skills_amount < 4 then
		if r1 > 0.9 and r2 > 0.5 then
			Mchoise = {2,3,4,6}
		else
			Mchoise = {2,4,6}
		end
	elseif skills_amount == 4 then
		if r1 > 0.9 and r2 > 0.8 then
			Mchoise = {2,3,4,5,6}
		else
			Mchoise = {2,3,4,6}
		end
	elseif skills_amount > 4 then
		return false
	end

	-- ����������ɷ�ʽ
--	if r1 > 0.9 and r2 > 0.9 then
--		Mchoise = {2,3,4,5,6}
--	elseif r1 > 0.9 then
--		Mchoise = {2,3,4,6}
--	else
--		Mchoise = {2,4,6}
--	end

	for mm=1,table.getn(Mchoise) do
    if Mchoise[mm]==65536 then
   		RSkillExInfo_2[mm]=0
			RSkillReqInfo[mm]=0
		else
			RSkillExInfo_2[mm]=RSkillExInfo_1[Mchoise[mm]]
			-- if table.getn(Skill_AddonInfo)~=table.getn(Skill_ReqLvlInfo) then return end
			RSkillReqInfo[mm]= Skill_ReqLvlInfo[ZLuaTal_FindSkillReqInfo(RSkillExInfo_2[mm],Skill_AddonInfo)]
		end
		-- if RSkillReqInfo[mm]>MaxPosLvl then RSkillReqInfo[mm]=MaxPosLvl end
	end

	-- local addonIDs,addonLevels
	-- addonIDs, addonLevels = ZLuaTal_SkillMakeSeq(RSkillExInfo_2, RSkillReqInfo)

	output:UpdateData(0,dataIndex["addon_1_id"],RSkillExInfo_2[1]or 0)		
	output:UpdateData(0,dataIndex["addon_1_learn_level"],RSkillReqInfo[1]or 0)
	output:UpdateData(0,dataIndex["addon_2_id"],RSkillExInfo_2[2]or 0)		
	output:UpdateData(0,dataIndex["addon_2_learn_level"],RSkillReqInfo[2]or 0)
	output:UpdateData(0,dataIndex["addon_3_id"],RSkillExInfo_2[3]or 0)		
	output:UpdateData(0,dataIndex["addon_3_learn_level"],RSkillReqInfo[3]or 0)
	output:UpdateData(0,dataIndex["addon_4_id"],RSkillExInfo_2[4]or 0)		
	output:UpdateData(0,dataIndex["addon_4_learn_level"],RSkillReqInfo[4]or 0)
	output:UpdateData(0,dataIndex["addon_5_id"],RSkillExInfo_2[5]or 0)		
	output:UpdateData(0,dataIndex["addon_5_learn_level"],RSkillReqInfo[5]or 0)
	output:UpdateData(0,dataIndex["addon_6_id"],RSkillExInfo_2[6]or 0)		
	output:UpdateData(0,dataIndex["addon_6_learn_level"],RSkillReqInfo[6]or 0)

	--//�����µķ�������������Ϣ		
	--output:UpdateData(0,dataIndex["skill_addon_id"],TalismanSkillID)

	--//�趨���������и������＼�ܿɼ�
	--if SkillHighLvlVisible==1 then 
	--	output:UpdateData(0,dataIndex["skill_visible"],SkillHighLvlVisible)
	--end 

	output:InheritCombineExp(true)
	ZLuaTalRebuild(output,id)
end
