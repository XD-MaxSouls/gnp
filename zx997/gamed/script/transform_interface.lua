----------------------------------------------------------
---����ű�
---
---transform_type 0��Ʒ 1���� 2����
---


function ZLuaAvailableTransforms()
   local transforms
   transforms = {}

   transforms["TEST1"] 						= {template_id = 124,type = "��Ʒ",transform_type = 0}
   transforms["TEST2"] 						= {template_id = 127,type = "��Ʒ",transform_type = 0}
   transforms["TEST3"] 						= {template_id = 131,type = "��Ʒ",transform_type = 0}

   transforms["wupindaoxuan"] 		= {template_id = 150,type = "��Ʒ",transform_type = 0}   ---��ֵ����������è  

   transforms["wupinguoqing01"] 	= {template_id = 151,type = "��Ʒ",transform_type = 0}   ---��������01  
   transforms["wupinguoqing02"] 	= {template_id = 152,type = "��Ʒ",transform_type = 0}   ---��������02  
   transforms["wupinguoqing03"] 	= {template_id = 153,type = "��Ʒ",transform_type = 0}   ---��������03  

   transforms["wupinchongyang"] 	= {template_id = 155,type = "��Ʒ",transform_type = 0}   ---������þջ���  

   transforms["wupinxueren01"] 		= {template_id = 156,type = "��Ʒ",transform_type = 0}   ---ѩ�˻��ѩ��01  
   transforms["wupinxueren02"] 		= {template_id = 159,type = "��Ʒ",transform_type = 0}   ---ѩ�˻��ѩ��02  
   transforms["wupinxueren03"] 		= {template_id = 160,type = "��Ʒ",transform_type = 0}   ---ѩ�˻��ѩ��03
   transforms["wupinxueren04"] 		= {template_id = 161,type = "��Ʒ",transform_type = 0}   ---ѩ�˻��ѩ��04

   transforms["wupinsanjie01"]	 	= {template_id = 165,type = "��Ʒ",transform_type = 0}   ---�����Ҷ�BOSS����01  
   transforms["wupinyueshen"]	 		= {template_id = 339,type = "��Ʒ",transform_type = 0}   ---����������  

   transforms["jinengsanjie01"]	 	= {template_id = 168,type = "����",transform_type = 1}   ---����BOSS����ʯ������  


   transforms["wupinpaisong1"] 		= {template_id = 145,type = "��Ʒ",transform_type = 0}   ---��ʱ����      
   transforms["wupinpaisong2"] 		= {template_id = 148,type = "��Ʒ",transform_type = 0}   ---��ʱ����  
   transforms["wupinpaisong3"] 		= {template_id = 149,type = "��Ʒ",transform_type = 0}   ---��ʱ����  

   transforms["wupinhuamei"] 			= {template_id = 133,type = "��Ʒ",transform_type = 0}   ---����
   transforms["wupinhanfei"] 			= {template_id = 134,type = "��Ʒ",transform_type = 0}   ---����
   transforms["wupinlinghou"] 		= {template_id = 135,type = "��Ʒ",transform_type = 0}   ---���
   transforms["wupinyingchifeng"] = {template_id = 144,type = "��Ʒ",transform_type = 0}   ---Ӳ���
   transforms["wupinhuayao"] 			= {template_id = 146,type = "��Ʒ",transform_type = 0}   ---����
   transforms["wupinguidaoshi"] 	= {template_id = 147,type = "��Ʒ",transform_type = 0}   ---���ʿ

   transforms["wupinshoushen"] 		= {template_id = 297,type = "��Ʒ",transform_type = 0}   ---���PK�����������ʯ
   transforms["wupinqingxin"] 		= {template_id = 338,type = "��Ʒ",transform_type = 0}   ---���˽����Ļ���ʯ

   transforms["jinengceshi01"] 		= {template_id = 157,type = "����",transform_type = 1}   ---���Լ��ܱ�������
   transforms["jinengceshi02"] 		= {template_id = 158,type = "����",transform_type = 1}   ---���Լ��ܱ��������滻����
   transforms["jinengceshi03"] 		= {template_id = 166,type = "����",transform_type = 1}   ---���Լ��ܱ���

   transforms["TEST_DOTA01"] 			= {template_id = 276,type = "����",transform_type = 1}   ---����DOTA���ù�����
   transforms["TEST_DOTA02"] 			= {template_id = 277,type = "����",transform_type = 1}   ---����DOTA��������̬
   transforms["TEST_DOTA03"] 			= {template_id = 278,type = "����",transform_type = 1}   ---����DOTA��������̬
 
   transforms["renwuceshi01"] 		= {template_id = 163,type = "����",transform_type = 2}   ---�����������
   transforms["renwuceshi02"] 		= {template_id = 164,type = "����",transform_type = 2}   ---������������滻����
   
   transforms["renwugaoqiao"] 		= {template_id = 169,type = "����",transform_type = 2}   ---�����ã����α���
   transforms["renwuzhuahaozi"]		= {template_id = 170,type = "����",transform_type = 2}   ---�����ã�ץ����
   transforms["jinengbianshitou"]	= {template_id = 172,type = "����",transform_type = 1}   ---�����ã���ʯͷ  
   transforms["renwudatouwawa"]		= {template_id = 173,type = "����",transform_type = 2}   ---�����ã���ͷ����
   transforms["renwuyutu"] 				= {template_id = 174,type = "����",transform_type = 2}   ---�����ã�����
   transforms["renwujinshizi"] 		= {template_id = 175,type = "����",transform_type = 2}   ---�����ã���ʨ��
   transforms["renwudingshenxueren"] = {template_id = 176,type = "����",transform_type = 2}   ---�����ã�����ѩ��

   transforms["jinengbaozha"]		 	= {template_id = 177,type = "����",transform_type = 1}   ---�����ã���ըЧ��
   transforms["jinengshuyao"]	 		= {template_id = 190,type = "����",transform_type = 1}   ---�����ã��������
   transforms["jinengleiji"]	 		= {template_id = 304,type = "����",transform_type = 1}   ---�����ã���������׻�
   transforms["jinengbiyan"]	 		= {template_id = 305,type = "����",transform_type = 1}   ---�����ã�����������
   transforms["jinenghunluan"]	 	= {template_id = 314,type = "����",transform_type = 1}   ---�����ã�����������

   transforms["wupinwufuhu01"]	 	= {template_id = 191,type = "��Ʒ",transform_type = 0}   ---��
   transforms["wupinwufuhu02"]	 	= {template_id = 192,type = "��Ʒ",transform_type = 0}   ---ľ��
   transforms["wupinwufuhu03"]	 	= {template_id = 193,type = "��Ʒ",transform_type = 0}   ---ˮ��
   transforms["wupinwufuhu04"]	 	= {template_id = 194,type = "��Ʒ",transform_type = 0}   ---��
   transforms["wupinwufuhu05"]	 	= {template_id = 195,type = "��Ʒ",transform_type = 0}   ---����

   transforms["renwuchunjietu01"]	= {template_id = 315,type = "����",transform_type = 0}   ---2011��������A
   transforms["renwuchunjietu02"]	= {template_id = 316,type = "����",transform_type = 0}   ---2011��������B
   transforms["renwuchunjietu03"]	= {template_id = 317,type = "����",transform_type = 0}   ---2011��������C
   transforms["renwuchunjietu04"]	= {template_id = 318,type = "����",transform_type = 0}   ---2011��������D

   transforms["renwuhaiwai01"]	= {template_id = 325,type = "����",transform_type = 0}   ---2011������1
   transforms["renwuhaiwai02"]	= {template_id = 326,type = "����",transform_type = 0}   ---2011������2
   transforms["renwuhaiwai03"]	= {template_id = 327,type = "����",transform_type = 0}   ---2011������3
   transforms["renwuhaiwai04"]	= {template_id = 328,type = "����",transform_type = 0}   ---2011������4

   transforms["renwuzhuogui01"]	 	= {template_id = 196,type = "����",transform_type = 2}   ---����ħ
   transforms["renwuzhuogui02"]	 	= {template_id = 197,type = "����",transform_type = 2}   ---����
   transforms["renwuzhuogui03"]	 	= {template_id = 198,type = "����",transform_type = 2}   ---ʯͷ
   transforms["renwuzhuogui04"]	 	= {template_id = 199,type = "����",transform_type = 2}   ---ѩ��
   transforms["renwuzhuogui05"]	 	= {template_id = 200,type = "����",transform_type = 2}   ---����

   transforms["jinengtiandibaoku01"]	 	= {template_id = 201,type = "����",transform_type = 1}   ---���ù�����
   transforms["jinengtiandibaoku02"]	 	= {template_id = 202,type = "����",transform_type = 1}   ---���ý���

   transforms["renwuyurenjie01"]	 	= {template_id = 227,type = "����",transform_type = 2}   ---�������˽ڻ01
   transforms["renwuyurenjie02"]	 	= {template_id = 228,type = "����",transform_type = 2}   ---�������˽ڻ02
   transforms["renwuyurenjie03"]	 	= {template_id = 229,type = "����",transform_type = 2}   ---�������˽ڻ03
   transforms["renwuyurenjie04"]	 	= {template_id = 230,type = "����",transform_type = 2}   ---�������˽ڻ04
   transforms["renwuyurenjie05"]	 	= {template_id = 231,type = "����",transform_type = 2}   ---�������˽ڻ05
   transforms["renwuyurenjie06"]	 	= {template_id = 232,type = "����",transform_type = 2}   ---�������˽ڻ06
   transforms["renwuyurenjie07"]	 	= {template_id = 233,type = "����",transform_type = 2}   ---�������˽ڻ07
   transforms["renwuyurenjie08"]	 	= {template_id = 234,type = "����",transform_type = 2}   ---�������˽ڻ08
   transforms["renwuyurenjie09"]	 	= {template_id = 235,type = "����",transform_type = 2}   ---�������˽ڻ09
   transforms["renwuyurenjie10"]	 	= {template_id = 236,type = "����",transform_type = 2}   ---�������˽ڻ10

   transforms["renwuyurenjie010"]	 	= {template_id = 237,type = "����",transform_type = 2}   ---�������˽ڻ010
   transforms["renwuyurenjie020"]	 	= {template_id = 238,type = "����",transform_type = 2}   ---�������˽ڻ020
   transforms["renwuyurenjie030"]	 	= {template_id = 239,type = "����",transform_type = 2}   ---�������˽ڻ030
   transforms["renwuyurenjie040"]	 	= {template_id = 240,type = "����",transform_type = 2}   ---�������˽ڻ040
   transforms["renwuyurenjie050"]	 	= {template_id = 241,type = "����",transform_type = 2}   ---�������˽ڻ050
   transforms["renwuyurenjie060"]	 	= {template_id = 242,type = "����",transform_type = 2}   ---�������˽ڻ060
   transforms["renwuyurenjie070"]	 	= {template_id = 243,type = "����",transform_type = 2}   ---�������˽ڻ070
   transforms["renwuyurenjie080"]	 	= {template_id = 244,type = "����",transform_type = 2}   ---�������˽ڻ080
   transforms["renwuyurenjie090"]	 	= {template_id = 245,type = "����",transform_type = 2}   ---�������˽ڻ090
   transforms["renwuyurenjie100"]	 	= {template_id = 246,type = "����",transform_type = 2}   ---�������˽ڻ100

   transforms["renwuqingmingegui"]	= {template_id = 247,type = "����",transform_type = 2}   ---���������ڶ�����
   transforms["renwujingcha"]	 			= {template_id = 249,type = "����",transform_type = 2}   ---���񾯲����
   transforms["renwupingmin"]	 			= {template_id = 250,type = "����",transform_type = 2}   ---����ƽ�����

   transforms["renwudiushoujuan01"]	= {template_id = 253,type = "����",transform_type = 2}   ---�����־����-��
   transforms["renwudiushoujuan02"]	= {template_id = 254,type = "����",transform_type = 2}   ---�����־����-С����
   transforms["renwuzhishu"]	 			= {template_id = 255,type = "����",transform_type = 2}   ---����ֲ������
   transforms["renwudiushoujuan03"]	= {template_id = 256,type = "����",transform_type = 2}   ---�����־����-С����2
   transforms["renwudiushoujuan04"]	= {template_id = 257,type = "����",transform_type = 2}   ---�����־����-������
   transforms["renwudiushoujuan05"]	= {template_id = 258,type = "����",transform_type = 2}   ---�����־����-��Ů��

   transforms["renwuchiyanyaotong"]	= {template_id = 259,type = "����",transform_type = 2}   ---������������
   transforms["renwucangsong"]			= {template_id = 260,type = "����",transform_type = 2}   ---����ɱ����Ϸ���ɱ���

   transforms["renwuLTdiji"]				= {template_id = 262,type = "����",transform_type = 2}   ---��������ս�ͼ����ǳ�
   transforms["renwuLTzhongji"]			= {template_id = 263,type = "����",transform_type = 2}   ---��������ս�м����ǳ�
   transforms["renwuLTgaoji"]				= {template_id = 264,type = "����",transform_type = 2}   ---��������ս�߼����ǳ�
   transforms["renwuLTdiji01"]			= {template_id = 271,type = "����",transform_type = 2}   ---��������ս�ͼ�����01
   transforms["renwuLTzhongji01"]		= {template_id = 272,type = "����",transform_type = 2}   ---��������ս�м�����01
   transforms["renwuLTzhongji02"]		= {template_id = 273,type = "����",transform_type = 2}   ---��������ս�м�����02
   transforms["renwuLTdiji02"]			= {template_id = 274,type = "����",transform_type = 2}   ---��������ս�ͼ��ط�
   transforms["renwuLTzhongji03"]		= {template_id = 275,type = "����",transform_type = 2}   ---��������ս�м��ط�
   transforms["renwuLTgongjianshou"]= {template_id = 283,type = "����",transform_type = 2}   ---��������ս�����ֱ���
   transforms["renwuLTgaoji2"]			= {template_id = 279,type = "����",transform_type = 2}   ---��������ս�߼��ط�����
   transforms["renwuLTgaoji01"]			= {template_id = 280,type = "����",transform_type = 2}   ---��������ս�߼�����01����
   transforms["renwuLTgaoji02"]			= {template_id = 281,type = "����",transform_type = 2}   ---��������ս�߼�����02����
   transforms["renwuLTgaoji03"]			= {template_id = 282,type = "����",transform_type = 2}   ---��������ս�߼�����03����

   transforms["renwucaiquanhuodong"]= {template_id = 265,type = "����",transform_type = 2}   ---�����ȭ�����
   transforms["renwuzhadanren"]			= {template_id = 266,type = "����",transform_type = 2}   ---����ը���˻����
   transforms["renwuLTbangzhu"]			= {template_id = 267,type = "����",transform_type = 2}   ---��������ս��������
   transforms["renwuyayunhui01"]		= {template_id = 288,type = "����",transform_type = 2}   ---�������˻�����
   transforms["renwupaopaokading"]	= {template_id = 289,type = "����",transform_type = 2}   ---�������ܻ
   transforms["renwuquanji"]				= {template_id = 291,type = "����",transform_type = 2}   ---��������ȭ��
   transforms["renwusheji"]					= {template_id = 292,type = "����",transform_type = 2}   ---�����������

   transforms["renwuzhuanzhi"]	   	= {template_id = 290,type = "����",transform_type = 2}   ---�������תְ��
   transforms["renwuleijie"]	 	  	= {template_id = 294,type = "����",transform_type = 2}   ---�����׽ٻ�Ѫ

   transforms["renwuduobao"]	 	  	= {template_id = 333,type = "����",transform_type = 2}   ---����ᱦ�

   transforms["renwuqiaokeli01"]	 	= {template_id = 334,type = "����",transform_type = 2}   ---�����ɫ���˽��ɿ�����A
   transforms["renwuqiaokeli02"]	 	= {template_id = 335,type = "����",transform_type = 2}   ---�����ɫ���˽��ɿ�����B
   transforms["renwuqiaokeli03"]	 	= {template_id = 336,type = "����",transform_type = 2}   ---�����ɫ���˽��ɿ���ŮA
   transforms["renwuqiaokeli04"]	 	= {template_id = 337,type = "����",transform_type = 2}   ---�����ɫ���˽��ɿ���ŮB

   return transforms   
end


function ZLuaTransExistInCtmplIDs(template_id)
	if type(template_id) ~= "number" then return 0 end
	local availableTransforms = ZLuaAvailableTransforms()
	local tansforms
	for _,tansforms in pairs(availableTransforms) do
		if tansforms.template_id == template_id then return 1 end
	end
	return 0
end


function ZLuaSkillsConfig(template_id)

  if ZLuaTransExistInCtmplIDs(template_id) == 0 then return 0 end

  local transforms = ZLuaAvailableTransforms()

  local addskilllearnlevel
  local addskilllearnexplevel
  local addskillid
  local addskilllevel


  if template_id == transforms["TEST1"].template_id then 
   addskilllearnlevel                  = { 1,1,3,4,5,6,7,8,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,1,1,1,1,1,1,0,0,0,0 } 
   addskillid                          = { 1741,993,1796,222,266,1093,404,1792,0,0,0,0 }
   addskilllevel                       = { 1,1,1,1,1,1,1,1,0,0,0,0 }
   
  elseif template_id == transforms["TEST2"].template_id then
   addskilllearnlevel                  = { 1,1,1,2,3,4,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,3,5,1,2,5,0,0,0,0,0,0 } 
   addskillid                          = { 1742,297,778,782,786,218,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,1,1,1,1,0,0,0,0,0,0 }

  elseif template_id == transforms["TEST3"].template_id then
   addskilllearnlevel                  = { 1,1,1,2,3,4,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,5,1,2,5,0,0,0,0,0,0 } 
   addskillid                          = { 1741,1515,1798,782,786,218,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,1,2,2,1,0,0,0,0,0,0 }

	---������DOTA���ù�����
  elseif template_id == transforms["TEST_DOTA01"].template_id then
   addskilllearnlevel                  = { 1,1,1,1,1,1,1,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,1,1,1,1,1,0,0,0,0,0 } 
   addskillid                          = { 2988,2977,2934,2935,2936,2964,2988,0,0,0,0,0 }
   addskilllevel                       = { 1,1,1,1,1,1,1,0,0,0,0,0 }    

  elseif template_id == transforms["TEST_DOTA02"].template_id then
   addskilllearnlevel                  = { 1,1,1,1,1,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,1,1,1,0,0,0,0,0,0,0 } 
   addskillid                          = { 3224,3232,3233,3234,2940,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,1,1,1,0,0,0,0,0,0,0 }    

  elseif template_id == transforms["TEST_DOTA03"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2763,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 }    

  ---��ֵ������è
  elseif template_id == transforms["wupindaoxuan"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 }    

  ---����������������
  elseif template_id == transforms["wupinguoqing01"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 }    

  elseif template_id == transforms["wupinguoqing02"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 }    

  elseif template_id == transforms["wupinguoqing03"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 }    

  ---���������ʱ
  elseif template_id == transforms["wupinchongyang"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 }    

  ---ѩ�˻����ʱ
  elseif template_id == transforms["wupinxueren01"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2362,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 }    

  elseif template_id == transforms["wupinxueren02"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2362,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 2,0,0,0,0,0,0,0,0,0,0,0 }    

  elseif template_id == transforms["wupinxueren03"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2376,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 }    

  elseif template_id == transforms["wupinxueren04"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2376,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 2,0,0,0,0,0,0,0,0,0,0,0 }    

  ---�����Ҷ��BOSS����
  elseif template_id == transforms["wupinsanjie01"].template_id then
   addskilllearnlevel                  = { 16,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 5,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2380,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 }    

  ---����û����������
  elseif template_id == transforms["jinengsanjie01"].template_id or 
  			 template_id == transforms["jinengleiji"].template_id or
  			 template_id == transforms["jinenghunluan"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 }    

	---����������
  elseif template_id == transforms["wupinyueshen"].template_id then
   addskilllearnlevel                  = { 16,16,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 5,5,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 3249,3250,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,0,0,0,0,0,0,0,0,0,0 }    

	---��������ֹ�ڰ�����
  elseif template_id == transforms["jinengbiyan"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 3205,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 }    

  ---��������ʱ��ֻ���˵�һ��
  elseif template_id == transforms["wupinpaisong1"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 }    

  elseif template_id == transforms["wupinpaisong2"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 }    

  elseif template_id == transforms["wupinpaisong3"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 }    

  ---�̵���6��
  elseif template_id == transforms["wupinhuamei"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 }    

  elseif template_id == transforms["wupinhanfei"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 }    

  elseif template_id == transforms["wupinlinghou"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 }    

  elseif template_id == transforms["wupinyingchifeng"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 }    

  elseif template_id == transforms["wupinhuayao"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 }    

  elseif template_id == transforms["wupinguidaoshi"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 } 

  ---�����ü��ܱ���01
  elseif template_id == transforms["jinengceshi01"].template_id then
   addskilllearnlevel                  = { 1,1,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 1746,1747,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,0,0,0,0,0,0,0,0,0,0 } 

  ---�����ü��ܱ���02
  elseif template_id == transforms["jinengceshi02"].template_id then
   addskilllearnlevel                  = { 1,1,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 1924,2763,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,0,0,0,0,0,0,0,0,0,0 } 

  ---�����ü��ܱ���03
  elseif template_id == transforms["jinengceshi03"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 1924,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

  ---�������������01
  elseif template_id == transforms["renwuceshi01"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 } 

  ---�������������02
  elseif template_id == transforms["renwuceshi02"].template_id then
   addskilllearnlevel                  = { 1,1,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 1924,2579,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,0,0,0,0,0,0,0,0,0,0 } 

  ---�����ã����α���
  elseif template_id == transforms["renwugaoqiao"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2381,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

  ---�����ã�ץ����
  elseif template_id == transforms["renwuzhuahaozi"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2384,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

  ---�����ã���ʯͷ
  elseif template_id == transforms["jinengbianshitou"].template_id 
  		or template_id == transforms["renwudatouwawa"].template_id 
  		or template_id == transforms["renwuyutu"].template_id
  		or template_id == transforms["renwujinshizi"].template_id
  		or template_id == transforms["renwudingshenxueren"].template_id
  		or template_id == transforms["jinengbaozha"].template_id
  		or template_id == transforms["jinengshuyao"].template_id
  then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 } 

  ---�����帣������ʯ
  elseif template_id == transforms["wupinwufuhu01"].template_id 
  		or template_id == transforms["wupinwufuhu02"].template_id
  		or template_id == transforms["wupinwufuhu03"].template_id
  		or template_id == transforms["wupinwufuhu04"].template_id
  		or template_id == transforms["wupinwufuhu05"].template_id
  then 
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 } 

  ---2011�������ӱ���
  elseif template_id == transforms["renwuchunjietu01"].template_id 
  		or template_id == transforms["renwuchunjietu02"].template_id
  		or template_id == transforms["renwuchunjietu03"].template_id
  		or template_id == transforms["renwuchunjietu04"].template_id
  		or template_id == transforms["renwuhaiwai01"].template_id
  		or template_id == transforms["renwuhaiwai02"].template_id
  		or template_id == transforms["renwuhaiwai03"].template_id
  		or template_id == transforms["renwuhaiwai04"].template_id
  then 
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2763,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

  ---�����ã�׽�����
  elseif template_id == transforms["renwuzhuogui01"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2577,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

  elseif template_id == transforms["renwuzhuogui02"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2578,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

  elseif template_id == transforms["renwuzhuogui03"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2579,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

  elseif template_id == transforms["renwuzhuogui04"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2580,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

  elseif template_id == transforms["renwuzhuogui05"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2581,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

  ---�����ã���ر������
  elseif template_id == transforms["jinengtiandibaoku01"].template_id then
   addskilllearnlevel                  = { 1,1,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2607,2621,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,0,0,0,0,0,0,0,0,0,0 } 
  
  elseif template_id == transforms["jinengtiandibaoku02"].template_id then
   addskilllearnlevel                  = { 1,1,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2601,2602,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,0,0,0,0,0,0,0,0,0,0 } 

	---�������˽ڻ1-10�ű���
	elseif template_id == transforms["renwuyurenjie01"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2721,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuyurenjie02"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2721,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 2,0,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuyurenjie03"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2721,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 3,0,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuyurenjie04"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2721,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 4,0,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuyurenjie05"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2721,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 5,0,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuyurenjie06"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2721,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 6,0,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuyurenjie07"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2721,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 7,0,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuyurenjie08"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2721,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 8,0,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuyurenjie09"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2721,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 9,0,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuyurenjie10"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2721,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 10,0,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuyurenjie010"].template_id
			or template_id == transforms["renwuyurenjie020"].template_id 
			or template_id == transforms["renwuyurenjie030"].template_id
			or template_id == transforms["renwuyurenjie040"].template_id
			or template_id == transforms["renwuyurenjie050"].template_id
			or template_id == transforms["renwuyurenjie060"].template_id
			or template_id == transforms["renwuyurenjie070"].template_id
			or template_id == transforms["renwuyurenjie080"].template_id
			or template_id == transforms["renwuyurenjie090"].template_id
			or template_id == transforms["renwuyurenjie100"].template_id	then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuqingmingegui"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 } 

	---ɱ����Ϸ����
	elseif template_id == transforms["renwujingcha"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2743,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwupingmin"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 } 

	---���־���Ϸ����
	elseif template_id == transforms["renwudiushoujuan01"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2749,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwudiushoujuan02"].template_id or
				 template_id == transforms["renwudiushoujuan03"].template_id or
				 template_id == transforms["renwudiushoujuan04"].template_id or
				 template_id == transforms["renwudiushoujuan05"].template_id or
				 template_id == transforms["renwuqiaokeli01"].template_id or
				 template_id == transforms["renwuqiaokeli02"].template_id or
				 template_id == transforms["renwuqiaokeli03"].template_id or
				 template_id == transforms["renwuqiaokeli04"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuchiyanyaotong"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwucangsong"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2763,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

  ---����ս���ǳ�����
	elseif template_id == transforms["renwuLTdiji"].template_id then
   addskilllearnlevel                  = { 1,1,1,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,1,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2922,2923,2930,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,1,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuLTzhongji"].template_id then
   addskilllearnlevel                  = { 1,1,1,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,1,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2924,2925,2931,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,1,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuLTgaoji"].template_id 
	or template_id == transforms["renwuLTgaoji2"].template_id then
   addskilllearnlevel                  = { 1,1,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2962,2963,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuLTgaoji03"].template_id then
   addskilllearnlevel                  = { 1,1,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2965,2966,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuLTdiji01"].template_id 
	or template_id == transforms["renwuLTgaoji01"].template_id then
   addskilllearnlevel                  = { 1,1,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2926,2927,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuLTzhongji01"].template_id then
   addskilllearnlevel                  = { 1,1,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2926,2927,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuLTzhongji02"].template_id 
	or template_id == transforms["renwuLTgaoji02"].template_id then
   addskilllearnlevel                  = { 1,1,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2928,2929,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,0,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuLTdiji02"].template_id then
   addskilllearnlevel                  = { 1,1,1,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,1,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2922,2923,2930,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,1,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuLTzhongji03"].template_id then
   addskilllearnlevel                  = { 1,1,1,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,1,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2924,2925,2931,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,1,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwuLTgongjianshou"].template_id then
   addskilllearnlevel                  = { 1,1,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2968,2969,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,0,0,0,0,0,0,0,0,0,0 } 

	---��ȭ
	elseif template_id == transforms["renwucaiquanhuodong"].template_id then
   addskilllearnlevel                  = { 1,1,1,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,1,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2799,2800,2801,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,1,0,0,0,0,0,0,0,0,0 } 

	---ը���˻
	elseif template_id == transforms["renwuzhadanren"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2817,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

	---LT��������
	elseif template_id == transforms["renwuLTbangzhu"].template_id then
		local i,j
		i = math.random()
		if i >= 0 and i <= 0.30 then j = 2891
		elseif i > 0.30 and i <= 0.45 then j = 2892
		elseif i > 0.45 and i <= 0.55 then j = 2893
		elseif i > 0.55 and i <= 0.65 then j = 2894
		elseif i > 0.65 and i <= 0.80 then j = 2895
		elseif i > 0.80 and i <= 0.90 then j = 2896
		elseif i > 0.90 and i <= 1.00 then j = 2897	 end
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { j,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

	---���˻�����
	elseif template_id == transforms["renwuyayunhui01"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 } 

	---���˻�ȭ�����
	elseif template_id == transforms["renwuquanji"].template_id then
   addskilllearnlevel                  = { 1,1,1,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,1,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 3159,3160,3161,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,1,0,0,0,0,0,0,0,0,0 } 

	elseif template_id == transforms["renwusheji"].template_id then
   addskilllearnlevel                  = { 1,1,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 3162,3163,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,0,0,0,0,0,0,0,0,0,0 } 

	---���ܿ�����
	elseif template_id == transforms["renwupaopaokading"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 327,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 500,0,0,0,0,0,0,0,0,0,0,0 } 

	---����תְ��
	elseif template_id == transforms["renwuzhuanzhi"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 3158,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

	---�����׽ٱ���
	elseif template_id == transforms["renwuleijie"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 3164,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 3,0,0,0,0,0,0,0,0,0,0,0 } 

	---���PK�����������ʯ
	elseif template_id == transforms["wupinshoushen"].template_id or 
	template_id == transforms["wupinqingxin"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 } 

	---2011�����öᱦ�
	elseif template_id == transforms["renwuduobao"].template_id then
   addskilllearnlevel                  = { 1,1,1,1,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,1,1,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 3231,3232,3233,3234,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,1,1,0,0,0,0,0,0,0,0 } 
  else return 0 
  end
  
  return addskilllearnlevel,addskilllearnexplevel,addskillid,addskilllevel  
  
end


function InitTransformSkill(template_id, transform_type, level, exp_level, player)
  if ZLuaTransExistInCtmplIDs(template_id) == 0 then return 0 end
  if level == nil or level <= 0 or level > 20 or exp_level == nil or exp_level <= 0 or exp_level > 5 then return 0 end
  if transform_type ~= 0 and transform_type ~= 1 and transform_type ~= 2 then return 0 end
    
  local addskillLearnLevel = {}
  local addskillLearnExpLevel = {}
  local addskillID = {}
  local addskillLevel = {}

  local magicAddskillLearnLevel, magicAddskillLearnExpLevel,magicAddskillID,magicAddskillLevel = ZLuaSkillsConfig(template_id)  

  for l=1,12 do
  addskillLearnLevel[l] = magicAddskillLearnLevel[l]
  addskillLearnExpLevel[l] = magicAddskillLearnExpLevel[l]
  addskillID[l] = magicAddskillID[l]
  addskillLevel[l] = magicAddskillLevel[l]
  end
	
  for i=1,12 do
	if addskillLearnLevel[i] ~= nil and addskillLearnLevel[i] > 0  and addskillLearnExpLevel[i] ~=nil and addskillLearnExpLevel[i] >0 and addskillID[i] ~= nil and addskillLevel[i] ~= 0 and addskillLevel[i] > 0 then
		local unknown = true
		for j=1,level do
		  if addskillLearnLevel[i] == j then
			for k=1,exp_level do
 			   if addskillLearnExpLevel[i] == k then
 				  player:AddTransformSkill( addskillID[i],addskillLevel[i] )
				  unknown = false
			   end
			end
		  end
		end
	end
  end
  
  return 1  
end


---���Ըı�ģ��
function InitNormalTransformProp(template_id, transform_type, level, exp_level, player)
  if ZLuaTransExistInCtmplIDs(template_id) == 0 then return 0 end
  if level == nil or level <= 0 or level > 20 or exp_level == nil or exp_level <= 0 or exp_level > 5 then return 0 end
  if transform_type ~= 0 and transform_type ~= 1 and transform_type ~= 2 then return 0 end

  local transforms = ZLuaAvailableTransforms()

  local curHP = player:GetHP()
  local curMP = player:GetMP()
  local curDamageHigh,curDamageLow = player:GetDamage()
  local curDefense = player:GetDefense()
  local curAttack = player:GetAttack()
  local curArmor = player:GetArmor()
  local curCritRate,curCritDamage = player:GetCrit()
  local curSkillAttackRate,curSkillArmorRate = player:GetSkillRate()
  local curAntiCritRate,curAntiCritDamage = player:GetAntiCrit()
  local curResistance0,curResistance1,curResistance2,curResistance3,curResistance4,curResistance5 = player:GetResistance()
  local curSpeed = player:GetSpeed()
  local curAttackRange = player:GetAttackRange()


	---transform_type�ɷ��������壬����ʯ--0������--1������--2  
  if transform_type == 0 then return 0
  end

  if transform_type == 1 then
  	if template_id == transforms["jinengceshi01"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddHP(0.5*curHP)	
  		else return 0 end	

  	elseif template_id == transforms["jinengsanjie01"].template_id then
  		if level == 1 and exp_level == 1 then
  		else return 0 end

  	elseif template_id == transforms["jinengtiandibaoku01"].template_id then
  		if level == 1 and exp_level == 1 then
  		  player:AddAttackRange(-curAttackRange+20)
  		  player:AddDamage(5000)
  		else return 0 end

  	elseif template_id == transforms["jinengtiandibaoku02"].template_id then
  		if level == 1 and exp_level == 1 then
  		  player:AddDefense(5000)
  		else return 0 end

  	elseif template_id == transforms["renwuceshi02"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddHP( -curHP + 99999)
  			player:AddMP( -curMP + 99999 )
  			player:AddSpeed(4.5)
  			player:AddCrit( -curCritRate + 777 , -curCritDamage +7.77)
  	  	player:AddDamage( -curDamageHigh + 99999)
  			player:AddAttack( -curAttack + 9999)
  			player:AddDefense( -curDefense + 9999)
  			player:AddArmor( -curArmor + 9999)
  			player:AddResistance( -curResistance0 + 777 , -curResistance1 + 777 , -curResistance2 + 777,- curResistance3 + 777,- curResistance4 + 777,- curResistance5 + 777)
  			player:AddAntiCrit( -curAntiCritRate + 777 , -curAntiCritDamage + 7.77)
  			player:AddSkillRate(-curSkillAttackRate + 999 , -curSkillArmorRate + 999)
  		  player:AddAttackRange(-curAttackRange+20)
  		else return 0  	end

  	elseif template_id == transforms["renwudiushoujuan01"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddSpeed( -curSpeed + 2 )
  		else return 0  end	

  	elseif template_id == transforms["renwudiushoujuan02"].template_id 
  			or template_id == transforms["renwudiushoujuan03"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddSpeed( -curSpeed + 3 )
  		else return 0  end	

		---������������
  	elseif template_id == transforms["renwuLTbangzhu"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddHP( curHP*0.25 )
  		else return 0  end	

  	elseif template_id == transforms["TEST_DOTA01"].template_id then
  		if level == 1 and exp_level == 1 then
  		  player:AddAttackRange(-curAttackRange+20)
   			player:AddHP( curHP*0.25 )
  		else return 0  end	

  	elseif template_id == transforms["TEST_DOTA02"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddHP( 30000 )
  			player:AddDefense( 2000 )
  			player:AddSpeed( -curSpeed + 2 )
  		  player:AddAttackRange(-curAttackRange+2)
  		else return 0  end	

  	elseif template_id == transforms["jinengleiji"].template_id then
  		if level == 1 and exp_level == 1 then
  		  player:AddSpeed(-curSpeed+4)
  		else return 0  end	

  	end
  end
  
  if transform_type == 2 then
  	if template_id == transforms["renwuceshi01"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddHP(-curHP+7777)	
  		else return 0  end	

  	elseif template_id == transforms["wupinsanjie01"].template_id then
  		if level == 16 and exp_level == 1 then
  			player:AddHP(0.5*curHP)	
  			player:AddMP(0.5*curMP)	
  			player:AddDefense(500)	
  			player:AddDamage(500)	
  			player:AddCrit(0.10 , 0.50)	
  			player:AddSkillRate(0.2 , 0.1)	
  		else return 0  end 
 
  	elseif template_id == transforms["renwugaoqiao"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddSpeed(-curSpeed + 3.5)
  		else return 0  end	

  	elseif template_id == transforms["wupinwufuhu01"].template_id 
  	or template_id == transforms["renwuchunjietu01"].template_id 
  	or template_id == transforms["renwuhaiwai01"].template_id 
  	then
  		if level == 1 and exp_level == 1 then
  			player:AddHP( 2000 )
  			player:AddCrit( 10 , 0 )
  		else return 0  end 

  	elseif template_id == transforms["wupinwufuhu02"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddAttack( 60 )
  			player:AddArmor( 30 )
  		else return 0  end 

  	elseif template_id == transforms["wupinwufuhu03"].template_id 
  	or template_id == transforms["renwuchunjietu02"].template_id 
  	or template_id == transforms["renwuhaiwai02"].template_id 
  	then
  		if level == 1 and exp_level == 1 then
  			player:AddMP( 2000 )
  			player:AddCrit( 0 , 0.1 )
  		else return 0  end 

  	elseif template_id == transforms["wupinwufuhu04"].template_id 
  	or template_id == transforms["renwuchunjietu03"].template_id 
  	or template_id == transforms["renwuhaiwai03"].template_id 
  	then
  		if level == 1 and exp_level == 1 then
  	  	player:AddDamage( curDamageHigh*0.02+60 )
  		else return 0  end 

  	elseif template_id == transforms["wupinwufuhu05"].template_id 
  	or template_id == transforms["renwuchunjietu04"].template_id 
  	or template_id == transforms["renwuhaiwai04"].template_id 
  	then
  		if level == 1 and exp_level == 1 then
  			player:AddDefense( curDefense*0.02+30 )
  		else return 0  end 

		---���˽ڱ���
  	elseif template_id == transforms["renwuyurenjie010"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddMP( curMP*0.05 )
  			player:AddDefense( -30 )
  		else return 0  end	

  	elseif template_id == transforms["renwuyurenjie020"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddMP( -curMP*0.1 )
  			player:AddCrit( 10 , 0)
  		else return 0  end	

  	elseif template_id == transforms["renwuyurenjie030"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddDefense( curDefense*0.03 )
  			player:AddCrit( -10 , 0)
  		else return 0  end	

  	elseif template_id == transforms["renwuyurenjie040"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddHP( curHP*0.05 )
  			player:AddSkillRate(-10 , 0)
  		else return 0  end	

  	elseif template_id == transforms["renwuyurenjie050"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddDefense( curDefense*0.03 )
  			player:AddArmor( -30 )
  		else return 0  end	

  	elseif template_id == transforms["renwuyurenjie060"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddHP( -curHP*0.1 )
  			player:AddSkillRate(0 , 20)
  		else return 0  end	

  	elseif template_id == transforms["renwuyurenjie070"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddCrit( 0 , 0.2)
  			player:AddSkillRate(-10 , 0)
  		else return 0  end	

  	elseif template_id == transforms["renwuyurenjie080"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddAntiCrit( 0 , 0.2)
  			player:AddAttack( -30 )
  		else return 0  end	

  	elseif template_id == transforms["renwuyurenjie090"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddMP( curMP*0.05 )
  			player:AddDamage(curDamageHigh*0.01)	
  		else return 0  end	

  	elseif template_id == transforms["renwuyurenjie100"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddHP( curHP*0.05 )
  			player:AddDefense( curDefense*0.01 )
  		else return 0  end	

  	elseif template_id == transforms["renwujingcha"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddSpeed( -curSpeed + 5 )
  			player:AddSkillRate( 0,-curSkillArmorRate + 1999 )
  		else return 0  end	

  	elseif template_id == transforms["renwupingmin"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddSpeed( -curSpeed + 2 )
  		else return 0  end	

  	elseif template_id == transforms["renwudiushoujuan01"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddSpeed( -curSpeed + 2 )
  		else return 0  end	

  	elseif template_id == transforms["renwudiushoujuan02"].template_id 
  			or template_id == transforms["renwudiushoujuan03"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddSpeed( -curSpeed + 3 )
  		else return 0  end	

		---��������
  	elseif template_id == transforms["renwuLTbangzhu"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddHP( curHP*0.25 )
  		else return 0  end	

		---����ս���ǳ�
  	elseif template_id == transforms["renwuLTdiji"].template_id 
  			or template_id == transforms["renwuLTdiji02"].template_id	then
  		if level == 1 and exp_level == 1 then
  			player:AddHP( 30000 )
  			player:AddDefense( 2000 )
  			player:AddSpeed( -2.5 )
  		  player:AddAttackRange(-curAttackRange+2)
  		else return 0  end	

  	elseif template_id == transforms["renwuLTzhongji"].template_id  
  	or template_id == transforms["renwuLTzhongji03"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddHP( 50000 )
  			player:AddDefense( 5000 )
  			player:AddSpeed( -3.3 )
  		  player:AddAttackRange(-curAttackRange+22)
  		else return 0  end	

  	elseif template_id == transforms["renwuLTgaoji03"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddHP( 100000 )
  			player:AddDefense( 5000 )
  			player:AddSpeed( -1.5 )
  		  player:AddAttackRange(6)
  		else return 0  end	

  	elseif template_id == transforms["renwuLTdiji01"].template_id 
  	or template_id == transforms["renwuLTzhongji01"].template_id
  	or template_id == transforms["renwuLTgaoji01"].template_id  then
  		if level == 1 and exp_level == 1 then
  			player:AddHP( 10000 )
  			player:AddSpeed( -1.5 )
  		  player:AddAttackRange(-curAttackRange+4)
  		else return 0  end	

  	elseif template_id == transforms["renwuLTzhongji02"].template_id  
  	or template_id == transforms["renwuLTgaoji02"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddHP( 80000 )
  			player:AddDefense( 2000 )
  			player:AddSpeed( -2.5 )
  		  player:AddAttackRange(-curAttackRange+4)
  		else return 0  end	

  	elseif template_id == transforms["renwuLTgaoji"].template_id  
  	or template_id == transforms["renwuLTgaoji2"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddHP( 100000 )
  			player:AddSpeed( -2.5 )
  		  player:AddAttackRange(20)
  		else return 0  end	

  	elseif template_id == transforms["renwuLTgongjianshou"].template_id then
  		if level == 1 and exp_level == 1 then
  		  player:AddAttackRange(20)
  		else return 0  end	

  	elseif template_id == transforms["renwuyayunhui01"].template_id then
  		if level == 1 and exp_level == 1 then
  		  player:AddSpeed( -curSpeed+8 )
  		else return 0  end	

  	elseif template_id == transforms["renwupaopaokading"].template_id then
  		if level == 1 and exp_level == 1 then
  		  player:AddSpeed( -curSpeed+3.5 )
  			player:AddSkillRate(-curSkillAttackRate + 999 , 0)
  		else return 0  end	

  	elseif template_id == transforms["renwuqiaokeli01"].template_id 
  	or template_id == transforms["renwuqiaokeli03"].template_id
  	then
  		if level == 1 and exp_level == 1 then
  			player:AddDamage(curDamageHigh*0.05)	
  		else return 0  end	

  	elseif template_id == transforms["renwuqiaokeli02"].template_id 
  	or template_id == transforms["renwuqiaokeli04"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddCrit( 20 , 0)
  		else return 0  end	

  	end

  end

  return 1
end


