----------------------------------------------------------
---变身脚本
---
---transform_type 0物品 1技能 2任务
---


function ZLuaAvailableTransforms()
   local transforms
   transforms = {}

   transforms["TEST1"] 						= {template_id = 124,type = "物品",transform_type = 0}
   transforms["TEST2"] 						= {template_id = 127,type = "物品",transform_type = 0}
   transforms["TEST3"] 						= {template_id = 131,type = "物品",transform_type = 0}

   transforms["wupindaoxuan"] 		= {template_id = 150,type = "物品",transform_type = 0}   ---充值赠送永久熊猫  

   transforms["wupinguoqing01"] 	= {template_id = 151,type = "物品",transform_type = 0}   ---国庆中秋活动01  
   transforms["wupinguoqing02"] 	= {template_id = 152,type = "物品",transform_type = 0}   ---国庆中秋活动02  
   transforms["wupinguoqing03"] 	= {template_id = 153,type = "物品",transform_type = 0}   ---国庆中秋活动03  

   transforms["wupinchongyang"] 	= {template_id = 155,type = "物品",transform_type = 0}   ---重阳活动用菊花精  

   transforms["wupinxueren01"] 		= {template_id = 156,type = "物品",transform_type = 0}   ---雪人活动用雪人01  
   transforms["wupinxueren02"] 		= {template_id = 159,type = "物品",transform_type = 0}   ---雪人活动用雪人02  
   transforms["wupinxueren03"] 		= {template_id = 160,type = "物品",transform_type = 0}   ---雪人活动用雪人03
   transforms["wupinxueren04"] 		= {template_id = 161,type = "物品",transform_type = 0}   ---雪人活动用雪人04

   transforms["wupinsanjie01"]	 	= {template_id = 165,type = "物品",transform_type = 0}   ---三界乱斗BOSS形象01  
   transforms["wupinyueshen"]	 		= {template_id = 339,type = "物品",transform_type = 0}   ---天界月神变身  

   transforms["jinengsanjie01"]	 	= {template_id = 168,type = "技能",transform_type = 1}   ---三界BOSS幻灵石变羊技能  


   transforms["wupinpaisong1"] 		= {template_id = 145,type = "物品",transform_type = 0}   ---限时派送      
   transforms["wupinpaisong2"] 		= {template_id = 148,type = "物品",transform_type = 0}   ---限时派送  
   transforms["wupinpaisong3"] 		= {template_id = 149,type = "物品",transform_type = 0}   ---限时派送  

   transforms["wupinhuamei"] 			= {template_id = 133,type = "物品",transform_type = 0}   ---花魅
   transforms["wupinhanfei"] 			= {template_id = 134,type = "物品",transform_type = 0}   ---悍匪
   transforms["wupinlinghou"] 		= {template_id = 135,type = "物品",transform_type = 0}   ---灵猴
   transforms["wupinyingchifeng"] = {template_id = 144,type = "物品",transform_type = 0}   ---硬翅蜂
   transforms["wupinhuayao"] 			= {template_id = 146,type = "物品",transform_type = 0}   ---花妖
   transforms["wupinguidaoshi"] 	= {template_id = 147,type = "物品",transform_type = 0}   ---鬼道士

   transforms["wupinshoushen"] 		= {template_id = 297,type = "物品",transform_type = 0}   ---跨服PK奖励兽神幻灵石
   transforms["wupinqingxin"] 		= {template_id = 338,type = "物品",transform_type = 0}   ---情人节情心幻灵石

   transforms["jinengceshi01"] 		= {template_id = 157,type = "技能",transform_type = 1}   ---测试技能变身兔子
   transforms["jinengceshi02"] 		= {template_id = 158,type = "技能",transform_type = 1}   ---测试技能变身兔子替换属性
   transforms["jinengceshi03"] 		= {template_id = 166,type = "技能",transform_type = 1}   ---测试技能变身

   transforms["TEST_DOTA01"] 			= {template_id = 276,type = "技能",transform_type = 1}   ---测试DOTA骷髅弓箭手
   transforms["TEST_DOTA02"] 			= {template_id = 277,type = "技能",transform_type = 1}   ---测试DOTA狼人人形态
   transforms["TEST_DOTA03"] 			= {template_id = 278,type = "技能",transform_type = 1}   ---测试DOTA狼人狼形态
 
   transforms["renwuceshi01"] 		= {template_id = 163,type = "任务",transform_type = 2}   ---测试任务变身
   transforms["renwuceshi02"] 		= {template_id = 164,type = "任务",transform_type = 2}   ---测试任务变身替换属性
   
   transforms["renwugaoqiao"] 		= {template_id = 169,type = "任务",transform_type = 2}   ---任务用：高跷变身
   transforms["renwuzhuahaozi"]		= {template_id = 170,type = "任务",transform_type = 2}   ---任务用：抓耗子
   transforms["jinengbianshitou"]	= {template_id = 172,type = "技能",transform_type = 1}   ---技能用：变石头  
   transforms["renwudatouwawa"]		= {template_id = 173,type = "任务",transform_type = 2}   ---任务用：大头娃娃
   transforms["renwuyutu"] 				= {template_id = 174,type = "任务",transform_type = 2}   ---任务用：玉兔
   transforms["renwujinshizi"] 		= {template_id = 175,type = "任务",transform_type = 2}   ---任务用：金狮子
   transforms["renwudingshenxueren"] = {template_id = 176,type = "任务",transform_type = 2}   ---任务用：定身雪人

   transforms["jinengbaozha"]		 	= {template_id = 177,type = "技能",transform_type = 1}   ---技能用：爆炸效果
   transforms["jinengshuyao"]	 		= {template_id = 190,type = "技能",transform_type = 1}   ---技能用：变成树妖
   transforms["jinengleiji"]	 		= {template_id = 304,type = "技能",transform_type = 1}   ---技能用：天界雷神雷击
   transforms["jinengbiyan"]	 		= {template_id = 305,type = "技能",transform_type = 1}   ---技能用：天界泽神闭眼
   transforms["jinenghunluan"]	 	= {template_id = 314,type = "技能",transform_type = 1}   ---技能用：天界月神混乱

   transforms["wupinwufuhu01"]	 	= {template_id = 191,type = "物品",transform_type = 0}   ---金虎
   transforms["wupinwufuhu02"]	 	= {template_id = 192,type = "物品",transform_type = 0}   ---木虎
   transforms["wupinwufuhu03"]	 	= {template_id = 193,type = "物品",transform_type = 0}   ---水虎
   transforms["wupinwufuhu04"]	 	= {template_id = 194,type = "物品",transform_type = 0}   ---火虎
   transforms["wupinwufuhu05"]	 	= {template_id = 195,type = "物品",transform_type = 0}   ---土虎

   transforms["renwuchunjietu01"]	= {template_id = 315,type = "任务",transform_type = 0}   ---2011春节兔子A
   transforms["renwuchunjietu02"]	= {template_id = 316,type = "任务",transform_type = 0}   ---2011春节兔子B
   transforms["renwuchunjietu03"]	= {template_id = 317,type = "任务",transform_type = 0}   ---2011春节兔子C
   transforms["renwuchunjietu04"]	= {template_id = 318,type = "任务",transform_type = 0}   ---2011春节兔子D

   transforms["renwuhaiwai01"]	= {template_id = 325,type = "任务",transform_type = 0}   ---2011海外活动用1
   transforms["renwuhaiwai02"]	= {template_id = 326,type = "任务",transform_type = 0}   ---2011海外活动用2
   transforms["renwuhaiwai03"]	= {template_id = 327,type = "任务",transform_type = 0}   ---2011海外活动用3
   transforms["renwuhaiwai04"]	= {template_id = 328,type = "任务",transform_type = 0}   ---2011海外活动用4

   transforms["renwuzhuogui01"]	 	= {template_id = 196,type = "任务",transform_type = 2}   ---火岩魔
   transforms["renwuzhuogui02"]	 	= {template_id = 197,type = "任务",transform_type = 2}   ---老鼠
   transforms["renwuzhuogui03"]	 	= {template_id = 198,type = "任务",transform_type = 2}   ---石头
   transforms["renwuzhuogui04"]	 	= {template_id = 199,type = "任务",transform_type = 2}   ---雪人
   transforms["renwuzhuogui05"]	 	= {template_id = 200,type = "任务",transform_type = 2}   ---树妖

   transforms["jinengtiandibaoku01"]	 	= {template_id = 201,type = "技能",transform_type = 1}   ---骷髅弓箭手
   transforms["jinengtiandibaoku02"]	 	= {template_id = 202,type = "技能",transform_type = 1}   ---骷髅将军

   transforms["renwuyurenjie01"]	 	= {template_id = 227,type = "技能",transform_type = 2}   ---任务愚人节活动01
   transforms["renwuyurenjie02"]	 	= {template_id = 228,type = "技能",transform_type = 2}   ---任务愚人节活动02
   transforms["renwuyurenjie03"]	 	= {template_id = 229,type = "技能",transform_type = 2}   ---任务愚人节活动03
   transforms["renwuyurenjie04"]	 	= {template_id = 230,type = "技能",transform_type = 2}   ---任务愚人节活动04
   transforms["renwuyurenjie05"]	 	= {template_id = 231,type = "技能",transform_type = 2}   ---任务愚人节活动05
   transforms["renwuyurenjie06"]	 	= {template_id = 232,type = "技能",transform_type = 2}   ---任务愚人节活动06
   transforms["renwuyurenjie07"]	 	= {template_id = 233,type = "技能",transform_type = 2}   ---任务愚人节活动07
   transforms["renwuyurenjie08"]	 	= {template_id = 234,type = "技能",transform_type = 2}   ---任务愚人节活动08
   transforms["renwuyurenjie09"]	 	= {template_id = 235,type = "技能",transform_type = 2}   ---任务愚人节活动09
   transforms["renwuyurenjie10"]	 	= {template_id = 236,type = "技能",transform_type = 2}   ---任务愚人节活动10

   transforms["renwuyurenjie010"]	 	= {template_id = 237,type = "技能",transform_type = 2}   ---任务愚人节活动010
   transforms["renwuyurenjie020"]	 	= {template_id = 238,type = "技能",transform_type = 2}   ---任务愚人节活动020
   transforms["renwuyurenjie030"]	 	= {template_id = 239,type = "技能",transform_type = 2}   ---任务愚人节活动030
   transforms["renwuyurenjie040"]	 	= {template_id = 240,type = "技能",transform_type = 2}   ---任务愚人节活动040
   transforms["renwuyurenjie050"]	 	= {template_id = 241,type = "技能",transform_type = 2}   ---任务愚人节活动050
   transforms["renwuyurenjie060"]	 	= {template_id = 242,type = "技能",transform_type = 2}   ---任务愚人节活动060
   transforms["renwuyurenjie070"]	 	= {template_id = 243,type = "技能",transform_type = 2}   ---任务愚人节活动070
   transforms["renwuyurenjie080"]	 	= {template_id = 244,type = "技能",transform_type = 2}   ---任务愚人节活动080
   transforms["renwuyurenjie090"]	 	= {template_id = 245,type = "技能",transform_type = 2}   ---任务愚人节活动090
   transforms["renwuyurenjie100"]	 	= {template_id = 246,type = "技能",transform_type = 2}   ---任务愚人节活动100

   transforms["renwuqingmingegui"]	= {template_id = 247,type = "任务",transform_type = 2}   ---任务清明节恶鬼变身
   transforms["renwujingcha"]	 			= {template_id = 249,type = "任务",transform_type = 2}   ---任务警察变身
   transforms["renwupingmin"]	 			= {template_id = 250,type = "任务",transform_type = 2}   ---任务平民变身

   transforms["renwudiushoujuan01"]	= {template_id = 253,type = "任务",transform_type = 2}   ---任务丢手绢变身-鬼
   transforms["renwudiushoujuan02"]	= {template_id = 254,type = "任务",transform_type = 2}   ---任务丢手绢变身-小朋友
   transforms["renwuzhishu"]	 			= {template_id = 255,type = "任务",transform_type = 2}   ---任务植树变身
   transforms["renwudiushoujuan03"]	= {template_id = 256,type = "任务",transform_type = 2}   ---任务丢手绢变身-小朋友2
   transforms["renwudiushoujuan04"]	= {template_id = 257,type = "任务",transform_type = 2}   ---任务丢手绢变身-老男人
   transforms["renwudiushoujuan05"]	= {template_id = 258,type = "任务",transform_type = 2}   ---任务丢手绢变身-老女人

   transforms["renwuchiyanyaotong"]	= {template_id = 259,type = "任务",transform_type = 2}   ---任务猪妖变身
   transforms["renwucangsong"]			= {template_id = 260,type = "任务",transform_type = 2}   ---任务杀人游戏苍松变身

   transforms["renwuLTdiji"]				= {template_id = 262,type = "任务",transform_type = 2}   ---任务领土战低级攻城车
   transforms["renwuLTzhongji"]			= {template_id = 263,type = "任务",transform_type = 2}   ---任务领土战中级攻城车
   transforms["renwuLTgaoji"]				= {template_id = 264,type = "任务",transform_type = 2}   ---任务领土战高级攻城车
   transforms["renwuLTdiji01"]			= {template_id = 271,type = "任务",transform_type = 2}   ---任务领土战低级额外01
   transforms["renwuLTzhongji01"]		= {template_id = 272,type = "任务",transform_type = 2}   ---任务领土战中级额外01
   transforms["renwuLTzhongji02"]		= {template_id = 273,type = "任务",transform_type = 2}   ---任务领土战中级额外02
   transforms["renwuLTdiji02"]			= {template_id = 274,type = "任务",transform_type = 2}   ---任务领土战低级守方
   transforms["renwuLTzhongji03"]		= {template_id = 275,type = "任务",transform_type = 2}   ---任务领土战中级守方
   transforms["renwuLTgongjianshou"]= {template_id = 283,type = "任务",transform_type = 2}   ---任务领土战弓箭手变身
   transforms["renwuLTgaoji2"]			= {template_id = 279,type = "任务",transform_type = 2}   ---任务领土战高级守方变身
   transforms["renwuLTgaoji01"]			= {template_id = 280,type = "任务",transform_type = 2}   ---任务领土战高级额外01变身
   transforms["renwuLTgaoji02"]			= {template_id = 281,type = "任务",transform_type = 2}   ---任务领土战高级额外02变身
   transforms["renwuLTgaoji03"]			= {template_id = 282,type = "任务",transform_type = 2}   ---任务领土战高级额外03变身

   transforms["renwucaiquanhuodong"]= {template_id = 265,type = "任务",transform_type = 2}   ---任务猜拳活动变身
   transforms["renwuzhadanren"]			= {template_id = 266,type = "任务",transform_type = 2}   ---任务炸弹人活动变身
   transforms["renwuLTbangzhu"]			= {template_id = 267,type = "任务",transform_type = 2}   ---任务领土战帮主变身
   transforms["renwuyayunhui01"]		= {template_id = 288,type = "任务",transform_type = 2}   ---任务亚运会马术
   transforms["renwupaopaokading"]	= {template_id = 289,type = "任务",transform_type = 2}   ---任务跑跑活动
   transforms["renwuquanji"]				= {template_id = 291,type = "任务",transform_type = 2}   ---任务亚运拳击
   transforms["renwusheji"]					= {template_id = 292,type = "任务",transform_type = 2}   ---任务亚运射击

   transforms["renwuzhuanzhi"]	   	= {template_id = 290,type = "任务",transform_type = 2}   ---任务封神转职用
   transforms["renwuleijie"]	 	  	= {template_id = 294,type = "任务",transform_type = 2}   ---任务抗雷劫回血

   transforms["renwuduobao"]	 	  	= {template_id = 333,type = "任务",transform_type = 2}   ---任务夺宝活动

   transforms["renwuqiaokeli01"]	 	= {template_id = 334,type = "任务",transform_type = 2}   ---任务白色情人节巧克力男A
   transforms["renwuqiaokeli02"]	 	= {template_id = 335,type = "任务",transform_type = 2}   ---任务白色情人节巧克力男B
   transforms["renwuqiaokeli03"]	 	= {template_id = 336,type = "任务",transform_type = 2}   ---任务白色情人节巧克力女A
   transforms["renwuqiaokeli04"]	 	= {template_id = 337,type = "任务",transform_type = 2}   ---任务白色情人节巧克力女B

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

	---测试用DOTA骷髅弓箭手
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

  ---充值奖励熊猫
  elseif template_id == transforms["wupindaoxuan"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 }    

  ---国庆中秋活动奖励三种
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

  ---重阳活动用限时
  elseif template_id == transforms["wupinchongyang"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 }    

  ---雪人活动用限时
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

  ---三界乱斗活动BOSS形象
  elseif template_id == transforms["wupinsanjie01"].template_id then
   addskilllearnlevel                  = { 16,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 5,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2380,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 }    

  ---三界幻化形象变羊技能
  elseif template_id == transforms["jinengsanjie01"].template_id or 
  			 template_id == transforms["jinengleiji"].template_id or
  			 template_id == transforms["jinenghunluan"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 }    

	---天界月神变身
  elseif template_id == transforms["wupinyueshen"].template_id then
   addskilllearnlevel                  = { 16,16,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 5,5,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 3249,3250,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,0,0,0,0,0,0,0,0,0,0 }    

	---天界泽神防止黑暗攻击
  elseif template_id == transforms["jinengbiyan"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 3205,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 }    

  ---派送用限时，只用了第一个
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

  ---商店卖6种
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

  ---测试用技能变身01
  elseif template_id == transforms["jinengceshi01"].template_id then
   addskilllearnlevel                  = { 1,1,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 1746,1747,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,0,0,0,0,0,0,0,0,0,0 } 

  ---测试用技能变身02
  elseif template_id == transforms["jinengceshi02"].template_id then
   addskilllearnlevel                  = { 1,1,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 1924,2763,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,0,0,0,0,0,0,0,0,0,0 } 

  ---测试用技能变身03
  elseif template_id == transforms["jinengceshi03"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 1924,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

  ---测试用任务变身01
  elseif template_id == transforms["renwuceshi01"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 } 

  ---测试用任务变身02
  elseif template_id == transforms["renwuceshi02"].template_id then
   addskilllearnlevel                  = { 1,1,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 1924,2579,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,0,0,0,0,0,0,0,0,0,0 } 

  ---任务用：高跷变身
  elseif template_id == transforms["renwugaoqiao"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2381,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

  ---任务用：抓耗子
  elseif template_id == transforms["renwuzhuahaozi"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2384,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

  ---技能用：变石头
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

  ---春节五福虎幻灵石
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

  ---2011春节兔子变身
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

  ---任务用：捉鬼变身
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

  ---技能用：天地宝库变身
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

	---任务愚人节活动1-10号变身
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

	---杀人游戏变身
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

	---丢手绢游戏变身
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

  ---领土战攻城车变身
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

	---猜拳
	elseif template_id == transforms["renwucaiquanhuodong"].template_id then
   addskilllearnlevel                  = { 1,1,1,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,1,1,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2799,2800,2801,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,1,1,0,0,0,0,0,0,0,0,0 } 

	---炸弹人活动
	elseif template_id == transforms["renwuzhadanren"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 2817,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

	---LT御驾亲征
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

	---亚运会马术
	elseif template_id == transforms["renwuyayunhui01"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 } 

	---亚运会拳击射击
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

	---跑跑卡丁车
	elseif template_id == transforms["renwupaopaokading"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 327,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 500,0,0,0,0,0,0,0,0,0,0,0 } 

	---封神转职用
	elseif template_id == transforms["renwuzhuanzhi"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 3158,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 1,0,0,0,0,0,0,0,0,0,0,0 } 

	---封神抗雷劫变身
	elseif template_id == transforms["renwuleijie"].template_id then
   addskilllearnlevel                  = { 1,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 1,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 3164,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 3,0,0,0,0,0,0,0,0,0,0,0 } 

	---跨服PK奖励兽神幻灵石
	elseif template_id == transforms["wupinshoushen"].template_id or 
	template_id == transforms["wupinqingxin"].template_id then
   addskilllearnlevel                  = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllearnexplevel               = { 0,0,0,0,0,0,0,0,0,0,0,0 } 
   addskillid                          = { 0,0,0,0,0,0,0,0,0,0,0,0 }
   addskilllevel                       = { 0,0,0,0,0,0,0,0,0,0,0,0 } 

	---2011任务用夺宝活动
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


---属性改变模块
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


	---transform_type由服务器定义，幻灵石--0；技能--1；任务--2  
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

		---御驾亲征测试
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

		---愚人节变身
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

		---御驾亲征
  	elseif template_id == transforms["renwuLTbangzhu"].template_id then
  		if level == 1 and exp_level == 1 then
  			player:AddHP( curHP*0.25 )
  		else return 0  end	

		---领土战攻城车
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


