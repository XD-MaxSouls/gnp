---版本
---2008.5.4下午17:00 准备对外

---	talisman对象接口分成三部分，分别如下：
---	A:获取基本数据
---	QueryLevel()		得到法宝级别
---	QueryExp()		得到法宝0当前经验

---	B:获取和设置参数 
---	  所谓参数，就是脚本定义的数据， 参数都是float类型，以index/value形式保存和定义
---        法宝的初始数值成长率等都以参数的方式存在。 参数区占用的空间和GetDataCount(0)的返回值
---	  成正比。所以不要随意给很大的index索引，这样会占用大量的内存和数据库空间。
---	QueryData(0,index)	获取制定索引的参数 如果该索引无对应参数，则返回0.0
---	GetDataCount(0)		返回当前所有的参数数目 这个值就是最大的有效index+1
---	UpdateData(0,index, value)更新一个参数，如果index不存在，则增加一个条目 value必须是一个数值
---	ClearData(0)		清除所有存在的参数



---	C:设置法宝属性
---	  法宝属性是法宝真正的效果作用， 法宝属性应该从参数计算得到,法宝属性都是整数,不能使用浮点数.
---	  注意每次设置前,法宝所有的属性包括附加属性都会被清空,所以每次设置都应设置全部属性
---	SetStamina(value)	设置法宝最大的精力值
---	SetQuality(value)	设置法宝的品阶, 供客户端显示使用
---	SetHP(value)		设置法宝增加的血量
---	SetMP(value)		设置法宝增加的真气
---	SetAttackEnhance(value)	设置法宝的攻击二次强化值
---	SetDamage(low,high)	设置法宝增加的攻击力
---	SetMPEnhance(value)	设置法宝的真气二次强化值
---	SetHPEnhance(value)	设置法宝的气血二次强化值
---	SetResistance(index,value) 设置法宝增加的抗性
---	SetAddon(addon)		设置法宝的附加属性, 每次设置都会增加一个附加属性 addon是模板中的附加属性模板ID

-------------------------------------------------------------------------------------------------------------------------------------------------
---	法宝融合函数说明
---	CombineTalismans(id1,id2, talisman1,talisman2,cid,output)
---	id1 id2 为需要融合的两件法宝的 id
---	talisman1 talisman2 为需要融合的两件法宝的对象 这两个对象同init reset levelup三个调用传入的talisman
---	cid 为融合调整道具的id
---	output 为产出控制对象， 此对象可以调用CreateItem接口

---	output产出控制对象接口如下
---	CreateItem(id)		表明要创建一个新物品，如果不调用此接口， 则无产出物品;
---				创建使用此接口创建一个法宝物品之后，则可以开始使用
---				talisman对象的所有其他接口， 如QueryData UpdateData Set...系列接?

---				如果没有创建物品或者创建了非法宝物品，则也不应调用output对象的其他接口。
--- InheritCombineLevel(true);
---				可以设置“出产法宝output是否继承主位置法宝的级别”。
---				如果“继承”，那么output的级别变为主位置法宝的级别；如果“不继承”，那么output的级别仍然为1。

---AddTalismanItem(tmplID, ZLuaTalInit,ZLuaTalLevelup,ZluaTalReset);  添加函数


---用到的函数，命名规则 前缀 ZLuaTal
-------数据----------------------------------------------------------------------------------------------------------
---ZLuaTalAvailableTalismans()	存储已有的法宝模板ID
---ZLuaTalStaminaGrowth()				法宝每级精力值成长值
---ZLuaTalGrades()							法宝档位。返回法宝属性档位数、各档数值
---ZLuaTalGradesUpperLimit(tmplID)	每个法宝的 总档位上限 以及 每个属性的档位上限
---ZLuaTalRandomWeight(tmplID, origin)	  每个法宝的 每个属性的 每个档位的 随机权重。 传入的是法宝模板ID
---ZLuaTalFeedCost(level)				取得某个等级法宝冲天龙魔血的花费
---ZLuaTalGetUnLearnID(id)			根据附加人物技能的附加属性取得未学会该技能的附加属性id

-------索引定义与转换------------------------------------------------------------------------------------------------
---ZLuaTalDataIndex()						法宝data索引数组
---ZLuaTalGradeIndex()					gradesUpperLimit表的索引，跟随ZLuaTalGradesUpperLimit的定义中的表中顺序而改变
---ZLuaTalTransIndex(index18)		把dataindex的索引转变为gradesindex的索引
---ZLuaTalServerOrigins()				法宝来源（服务器端约定）
---ZLuaTalClientOrigins()				法宝来源（客户端约定）

-------生成属性------------------------------------------------------------------------------------------------------
---ZLuaTalGenerateConfusion()		法宝干扰因子
---ZLuaTalGenerateSpeciality(tmplID,origin,quality,allGrades)		生成特性
---ZLuaTalGenerateClientOrigin(serverOrigin)		取得法宝来源，用于客户端显示
---ZLuaTalGenerateServerOrigin(clientOrigin)		取得法宝来源，用于服务器端判断
---ZLuaTalGenerteBirthTime()		取得法宝生成时间
---ZLuaTalGenerateQuality(tmplID, origin, grades, nGrades)		取得法宝品阶
---ZLuaTalGenerateQualityFromTalisman(tmplID, talisman) 			取得法宝品阶，从具体法宝中

-------主要处理函数--------------------------------------------------------------------------------------------------
---CombineTalismans(id1,id2, talisman1,talisman2,cid,output)	法宝合成入口（被调用）
---ZLuaTalInit(id, talisman, origin)		法宝初始化（注册用）
---ZLuaTalLevelup(id, talisman) 				法宝升级（注册用）
---ZLuaTalReset(id, talisman) 					法宝洗练（注册用）
---ZLuaTalRebuild(talisman,id)					法宝本体与附加属性重新计算
---ZLuaTalRandomResult(tmplID, origin)	随机函数，返回指定法宝模板的每个属性随机后的结果
---ZLuaTalCombineInit(id, speciality, growDirInData, growIncrement, combineValuePlus, talisman, output )		熔炼结果为A或B时的初始化函数

--------功能性函数---------------------------------------------------------------------------------------------------
---ZLuaTalExistInTmplIDs(id)													检查传入的模板ID是否是法宝，如果是的话，返回该法宝的人物需求等级
---ZLuaTalGetValueWithBounds(startValue, endValue, currentStep, allStep)	a[]是等差数列，给定a[1]=startValue和a[allStep]=endValue，求a[currentStep]。
---ZLuaTalGetGradeFromValue(speciality, talisman)			从法宝某个属性具体值取得档位数
---ZLuaTalGetTalTypeFromID(tmplID)										返回一个id代表的法宝的种类，"fabao" "feijian" "yushou" "chibang"


--------调试用函数---------------------------------------------------------------------------------------------------
---ZLuaTalDebugDisplay(talisman,id,output)	用于把法宝服务器端数据显示到前台（仅debug用，切切）


-------数据----------------------------------------------------------------------------------------------------------------------------

---已有的法宝模板ID
function ZLuaTalAvailableTalismans()
	local talismans
	talismans = {}

	-- 测试用法宝
	talismans["TEST"]												= { talType = "fabao", tmplID =  4662, requireLevel =   1, price =0.1, school = 0, skillAddon =  399, name = "测试法宝" }		---测试法宝
	talismans["foodtalisman"]								= { talType = "fabao", tmplID = 19523, requireLevel = 135, price =  1, school = 0, skillAddon =  399, name = "食物法宝" }		---测试法宝  食物法宝

	-- 法宝
	-- 索引命名规则：type_requireLevel_name		
	-- type: 少侠(0) NW， 神裔(0) SY， 通用(0) US
	-- type: 鬼王(1) GW， 合欢(2) HH， 青云(3) QY， 天音( 4) TY， 鬼道( 5) GD,  焚香( 6) FX
	-- type: 九黎(7) JL， 烈山(8) LS， 怀光(9) HG， 天华(10) TH， 太昊(11) TH， 东夷(12) DY   
	-- type: 牵机(13)QJ， 英招(14)YZ
	talismans["NW_1_BaGuaShi"] 							= { talType = "fabao", tmplID =  4703, tmplID1 = 6033,tmplID2 = 6047, requireLevel =   1, price =0.1, school = 0, skillAddon =  399, name = "八卦石" }			---少侠法宝  八卦石
	talismans["SY_1_WuSeShi"] 							= { talType = "fabao", tmplID = 30076, tmplID1 = 30077,tmplID2 = 30086, requireLevel =   1, price =0.1, school = 0, skillAddon = 3610, name = "五色石" }			---神裔法宝  五色石
	talismans["LZ_1_TianLingShi"] 					= { talType = "fabao", tmplID = 58825, tmplID1 = 58826,tmplID2 = 58827, requireLevel =   1, price =0.1, school = 0, skillAddon = 34662, name = "XX石" }			---灵族法宝  XX石

	talismans["QY_15_LiuHeJing"] 						= { talType = "fabao", tmplID =  4704, tmplID1 = 6036,tmplID2 = 6050, requireLevel =  15, price =  1, school = 3, skillAddon =  400, name = "六合镜" }			---青云一重  六合镜
	talismans["GW_15_ZhuQueYin"] 						= { talType = "fabao", tmplID =  4705, tmplID1 = 6034,tmplID2 = 6048, requireLevel =  15, price =  1, school = 1, skillAddon =  401, name = "朱雀印" }			---鬼王一重  朱雀印
	talismans["TY_15_LunHuiZhu"] 						= { talType = "fabao", tmplID =  4706, tmplID1 = 6037,tmplID2 = 6051, requireLevel =  15, price =  1, school = 4, skillAddon =  402, name = "轮回珠" }			---天音一重  轮回珠
	talismans["HH_15_SheXinLing"] 					= { talType = "fabao", tmplID =  4707, tmplID1 = 6035,tmplID2 = 6049, requireLevel =  15, price =  1, school = 2, skillAddon =  403, name = "慑心铃" }			---合欢一重  慑心铃
	talismans["GD_15_XueYuGuPian"]					= { talType = "fabao", tmplID = 17583, tmplID1 = 17596,tmplID2 = 17600, requireLevel =  15, price =  1, school = 5, skillAddon = 1806, name = "血玉骨片" }		---鬼道一重  血玉骨片
	talismans["FX_15_NanMingYin"]						= { talType = "fabao", tmplID = 45525, tmplID1 = 45533,tmplID2 = 45541, requireLevel =  15, price =  1, school = 6, skillAddon = 33347, name = "南明印" }		---焚香一重  南明印
	talismans["JL_15_NuShouFan"] 						= { talType = "fabao", tmplID = 30068, tmplID1 = 30078,tmplID2 = 30087, requireLevel =  15, price =  1, school = 7, skillAddon = 3613, name = "怒兽幡" }			---九黎一重  怒兽幡
	talismans["LS_15_DanZhu"]								= { talType = "fabao", tmplID = 30072, tmplID1 = 30082,tmplID2 = 30091, requireLevel =  15, price =  1, school = 8, skillAddon = 3625, name = "丹朱" }			  ---烈山一重  丹朱
	talismans["HG_15_QiSha"] 								= { talType = "fabao", tmplID = 38883, tmplID1 = 38903,tmplID2 = 38918, requireLevel =  15, price =  1, school = 9, skillAddon = 3943, name = "七杀" }				---怀光一重  七杀
	talismans["TH_15_JiuYinLuo"]						= { talType = "fabao", tmplID = 38887, tmplID1 = 38907,tmplID2 = 38922, requireLevel =  15, price =  1, school =10, skillAddon = 3955, name = "九音螺" }			---天华一重  九音螺
	talismans["TH_15_LeiGongMo"]						= { talType = "fabao", tmplID = 45529, tmplID1 = 45537,tmplID2 = 45545, requireLevel =  15, price =  1, school =11, skillAddon = 33359, name = "雷公墨" }		---太昊一重  雷公墨
	talismans["CH_15_lvdouqi"]							= { talType = "fabao", tmplID = 53383, tmplID1 = 53389,tmplID2 = 53393, requireLevel =  15, price =  1, school =12, skillAddon = 34015, name = "率兜旗" }		---辰皇一重  率兜旗
	talismans["QJ_15_tianjimu"]							= { talType = "fabao", tmplID = 58798, tmplID1 = 58806,tmplID2 = 58814, requireLevel =  15, price =  1, school =13, skillAddon = 34667, name = "天极木" }		---牵机一重  天极木
	talismans["YZ_15_lveying"]							= { talType = "fabao", tmplID = 58802, tmplID1 = 58810,tmplID2 = 58818, requireLevel =  15, price =  1, school =14, skillAddon = 34687, name = "掠影" }		---英招一重  掠影

	talismans["US_45_ShenMuShai"] 					= { talType = "fabao", tmplID =  4713, tmplID1 = 6043,tmplID2 = 6057, requireLevel =  45, price = 20, school = 0, skillAddon =  409, name = "神木骰" }			---通用二重  神木骰
	talismans["US_45_ShenMuShai_WZGL"]			= { talType = "fabao", tmplID = 24710, tmplID1 = 24721,tmplID2 = 24722, requireLevel =  45, price = 20, school = 0, skillAddon =  409, name = "神木骰" }			---通用二重  神木骰(王者归来纪念版)

	talismans["QY_75_QiXingJian"] 					= { talType = "fabao", tmplID =  4708, tmplID1 = 6040,tmplID2 = 6054, requireLevel =  75, price = 20, school = 3, skillAddon =  404, name = "七星剑" }			---青云三重  七星剑
	talismans["GW_75_SiLingFan"] 						= { talType = "fabao", tmplID =  4709, tmplID1 = 6038,tmplID2 = 6052, requireLevel =  75, price = 20, school = 1, skillAddon =  405, name = "四灵幡" }			---鬼王三重  四灵幡
	talismans["TY_75_JinGangChu"] 					= { talType = "fabao", tmplID =  4710, tmplID1 = 6041,tmplID2 = 6055, requireLevel =  75, price = 20, school = 4, skillAddon =  406, name = "金刚杵" }			---天音三重  金刚杵
	talismans["HH_75_DuoQingHuan"]					= { talType = "fabao", tmplID =  4711, tmplID1 = 6039,tmplID2 = 6053, requireLevel =  75, price = 20, school = 2, skillAddon =  407, name = "多情环" }			---合欢三重  多情环
	talismans["GD_75_PoSha"] 								= { talType = "fabao", tmplID = 17584, tmplID1 = 17597,tmplID2 = 17601, requireLevel =  75, price = 20, school = 5, skillAddon = 1809, name = "破刹" }				---鬼道三重  破刹
	talismans["FX_75_HengTianChi"] 					= { talType = "fabao", tmplID = 45526, tmplID1 = 45534,tmplID2 = 45542, requireLevel =  75, price = 20, school = 6, skillAddon = 33350, name = "衡天尺" }		---焚香三重  破刹
	talismans["JL_75_XueFengQiang"]					= { talType = "fabao", tmplID = 30069, tmplID1 = 30079,tmplID2 = 30088, requireLevel =  75, price = 20, school = 7, skillAddon = 3616, name = "血枫枪" }			---九黎三重  血枫枪
	talismans["LS_75_FanHunXiang"] 					= { talType = "fabao", tmplID = 30073, tmplID1 = 30083,tmplID2 = 30092, requireLevel =  75, price = 20, school = 8, skillAddon = 3628, name = "返魂香" }			---烈山三重  返魂香
	talismans["HG_75_PoJun"]								= { talType = "fabao", tmplID = 38884, tmplID1 = 38904,tmplID2 = 38919, requireLevel =  75, price = 20, school = 9, skillAddon = 3946, name = "破军" }				---怀光三重  破军
	talismans["TH_75_YaFeng"] 							= { talType = "fabao", tmplID = 38888, tmplID1 = 38908,tmplID2 = 38923, requireLevel =  75, price = 20, school =10, skillAddon = 3958, name = "亚风" }				---天华三重  亚风
	talismans["TH_75_ChunQiuSuo"] 					= { talType = "fabao", tmplID = 45530, tmplID1 = 45538,tmplID2 = 45546, requireLevel =  75, price = 20, school =11, skillAddon = 33362, name = "春秋锁" }		---太昊三重  春秋锁
	talismans["CH_75_tuogu"]								= { talType = "fabao", tmplID = 53384, tmplID1 = 53390,tmplID2 = 53394, requireLevel =  75, price = 20, school =12, skillAddon = 34018, name = "鼍鼓" }			---辰皇三重  鼍鼓
	talismans["QJ_75_luohouyu"] 						= { talType = "fabao", tmplID = 58799, tmplID1 = 58807,tmplID2 = 58815, requireLevel =  75, price = 20, school =13, skillAddon = 34672, name = "罗睺玉" }		---牵机三重  罗睺玉
	talismans["YZ_75_poming"]								= { talType = "fabao", tmplID = 58803, tmplID1 = 58811,tmplID2 = 58819, requireLevel =  75, price = 20, school =14, skillAddon = 34692, name = "破命" }			---英招三重  破命

	talismans["US_75_ShanHeShan"] 					= { talType = "fabao", tmplID =  4712, tmplID1 = 6042,tmplID2 = 6056, requireLevel =  75, price = 20, school = 0, skillAddon =  408, name = "山河扇" }			---通用三重  山河扇	
	talismans["US_75_WanDuDing"]						= { talType = "fabao", tmplID =  4714, tmplID1 = 6044,tmplID2 = 6058, requireLevel =  75, price = 20, school = 0, skillAddon =  410, name = "万毒鼎" }			---通用三重  万毒鼎
	talismans["US_75_YuJingPing"] 					= { talType = "fabao", tmplID =  4715, tmplID1 = 6045,tmplID2 = 6059, requireLevel =  75, price = 20, school = 0, skillAddon =  411, name = "玉净瓶" }			---通用三重  玉净瓶
	talismans["US_75_LingLongTa"] 					= { talType = "fabao", tmplID = 13316, tmplID1 = 13356,tmplID2 = 13357, requireLevel =  75, price = 20, school = 0, skillAddon = 1653, name = "玲珑塔" }			---通用三重  玲珑塔

	talismans["QY_105_HuPoZhuLing"] 				= { talType = "fabao", tmplID = 10866, tmplID1 = 10878,tmplID2 = 10890, requireLevel = 105, price = 50, school = 3, skillAddon =  860, name = "琥珀朱绫" }		---青云四重  琥珀朱绫
	talismans["GW_105_QianKunQingGuangJie"] = { talType = "fabao", tmplID = 10871, tmplID1 = 10883,tmplID2 = 10895, requireLevel = 105, price = 50, school = 1, skillAddon =  865, name = "乾坤青光戒" }	---鬼王四重  乾坤青光戒
	talismans["TY_105_RuYiQianKunDai"] 			= { talType = "fabao", tmplID = 10874, tmplID1 = 10886,tmplID2 = 10898, requireLevel = 105, price = 50, school = 4, skillAddon =  868, name = "如意乾坤袋" }	---天音四重  如意乾坤袋
	talismans["HH_105_QianMeiLian"] 				= { talType = "fabao", tmplID = 10870, tmplID1 = 10882,tmplID2 = 10894, requireLevel = 105, price = 50, school = 2, skillAddon =  864, name = "千媚莲" }			---合欢四重  千媚莲
	talismans["GD_105_QianDuGu"] 						= { talType = "fabao", tmplID = 17585, tmplID1 = 17598,tmplID2 = 17602, requireLevel = 105, price = 50, school = 5, skillAddon = 1812, name = "千毒蛊" }			---鬼道四重  千毒蛊
	talismans["FX_105_HuoLingLong"]					= { talType = "fabao", tmplID = 45527, tmplID1 = 45535,tmplID2 = 45543, requireLevel = 105, price = 50, school = 6, skillAddon = 33353, name = "火玲珑" }		---焚香四重  火玲珑
	talismans["JL_105_GangLan"] 						= { talType = "fabao", tmplID = 30070, tmplID1 = 30080,tmplID2 = 30089, requireLevel = 105, price = 50, school = 7, skillAddon = 3619, name = "罡岚" }				---九黎四重  罡岚
	talismans["LS_105_FuYingGuJing"] 				= { talType = "fabao", tmplID = 30074, tmplID1 = 30084,tmplID2 = 30093, requireLevel = 105, price = 50, school = 8, skillAddon = 3631, name = "浮影古镜" }		---烈山四重  浮影古镜
	talismans["HG_105_TanLang"] 						= { talType = "fabao", tmplID = 38885, tmplID1 = 38905,tmplID2 = 38920, requireLevel = 105, price = 50, school = 9, skillAddon = 3949, name = "贪狼" }				---怀光四重  贪狼
	talismans["TH_105_LiuLiZhan"] 					= { talType = "fabao", tmplID = 38889, tmplID1 = 38909,tmplID2 = 38924, requireLevel = 105, price = 50, school =10, skillAddon = 3961, name = "琉璃盏" }			---天华四重  琉璃盏
	talismans["TH_105_ZiMuYinYangKou"]			= { talType = "fabao", tmplID = 45531, tmplID1 = 45539,tmplID2 = 45547, requireLevel = 105, price = 50, school =11, skillAddon = 33365, name = "子母阴阳扣" }---太昊四重  子母阴阳扣
	talismans["CH_105_luobaojinqian"]				= { talType = "fabao", tmplID = 53385, tmplID1 = 53391,tmplID2 = 53395, requireLevel = 105, price = 50, school =12, skillAddon = 34021, name = "落宝金钱" }	---辰皇四重  落宝金钱
	talismans["QJ_105_jinyubian"]						= { talType = "fabao", tmplID = 58800, tmplID1 = 58808,tmplID2 = 58816, requireLevel = 105, price = 50, school =13, skillAddon = 34677, name = "金羽变" }---牵机四重  金羽变
	talismans["YZ_105_shuolei"]							= { talType = "fabao", tmplID = 58804, tmplID1 = 58812,tmplID2 = 58820, requireLevel = 105, price = 50, school =14, skillAddon = 34697, name = "烁雷" }	---英招四重  烁雷

	talismans["US_105_JiuLongShenHuoZhao"]	= { talType = "fabao", tmplID = 10873, tmplID1 = 10885,tmplID2 = 10897, requireLevel = 105, price = 50, school = 0, skillAddon =  867, name = "九龙神火罩" }	---通用四重  九龙神火罩	
	talismans["US_105_JinHuLu"] 						= { talType = "fabao", tmplID = 10869, tmplID1 = 10881,tmplID2 = 10893, requireLevel = 105, price = 50, school = 0, skillAddon =  863, name = "金葫芦" }			---通用四重  金葫芦（商城卖RMB）
	talismans["US_105_YinYangJing"] 				= { talType = "fabao", tmplID = 10867, tmplID1 = 10879,tmplID2 = 10891, requireLevel = 105, price = 50, school = 0, skillAddon =  861, name = "阴阳镜" }			---通用四重  阴阳镜（2007-11-27彩票出）
	talismans["US_105_YinYangJing_WZGL"]		= { talType = "fabao", tmplID = 24711, tmplID1 = 24723,tmplID2 = 24724, requireLevel = 105, price = 50, school = 0, skillAddon =  861, name = "阴阳镜" }			---通用四重  阴阳镜(王者归来纪念版)
	talismans["US_105_LuoHunDeng"] 					= { talType = "fabao", tmplID = 15868, tmplID1 = 15869,tmplID2 = 15870, requireLevel = 105, price = 50, school = 0, skillAddon = 1738, name = "落魂灯" }			---通用四重  落魂灯（2008-03-18彩票出）
	talismans["US_105_ZhenShanHeShan"] 			= { talType = "fabao", tmplID = 17829, tmplID1 = 17830,tmplID2 = 17831, requireLevel = 105, price = 50, school = 0, skillAddon = 1753, name = "真山河扇" }		---通用四重  逍遥扇

	talismans["GW_135_TianMoZhi"] 					= { talType = "fabao", tmplID = 13774, tmplID1 = 13790,tmplID2 = 13794, requireLevel = 135, price = 50, school = 1, skillAddon = 1706, name = "天魔指" }			---鬼王五重  天魔指
	talismans["QY_135_RuoXue"] 							= { talType = "fabao", tmplID = 13773, tmplID1 = 13789,tmplID2 = 13793, requireLevel = 135, price = 50, school = 3, skillAddon = 1703, name = "若雪" }				---青云五重  若雪
	talismans["HH_135_BaJiYouLong"]					= { talType = "fabao", tmplID = 13771, tmplID1 = 13787,tmplID2 = 13791, requireLevel = 135, price = 50, school = 2, skillAddon = 1697, name = "八极游龙" }		---合欢五重  八极游龙
	talismans["TY_135_LiuDaoShengMie"]			= { talType = "fabao", tmplID = 13772, tmplID1 = 13788,tmplID2 = 13792, requireLevel = 135, price = 50, school = 4, skillAddon = 1700, name = "六道生灭" }		---天音五重  六道生灭
	talismans["GD_135_GuiQing"] 						= { talType = "fabao", tmplID = 17586, tmplID1 = 17599,tmplID2 = 17603, requireLevel = 135, price = 50, school = 5, skillAddon = 1815, name = "鬼罄" }				---鬼道五重  鬼罄
	talismans["FX_135_JiuHanNingBingCi"] 		= { talType = "fabao", tmplID = 45528, tmplID1 = 45536,tmplID2 = 45544, requireLevel = 135, price = 50, school = 6, skillAddon = 33356, name = "九寒凝冰刺" }---焚香五重  九寒凝冰刺
	talismans["JL_135_SangMenJian"] 				= { talType = "fabao", tmplID = 30071, tmplID1 = 30081,tmplID2 = 30090, requireLevel = 135, price = 50, school = 7, skillAddon = 3622, name = "丧门剑" }			---九黎五重  丧门剑
	talismans["LS_135_LuoShu"] 							= { talType = "fabao", tmplID = 30075, tmplID1 = 30085,tmplID2 = 30094, requireLevel = 135, price = 50, school = 8, skillAddon = 3634, name = "洛书" }				---烈山五重  洛书
	talismans["HG_135_JueYing"] 						= { talType = "fabao", tmplID = 38886, tmplID1 = 38906,tmplID2 = 38921, requireLevel = 135, price = 50, school = 9, skillAddon = 3952, name = "绝影" }				---怀光五重  绝影
	talismans["TH_135_BiLuoFeiHong"] 				= { talType = "fabao", tmplID = 38890, tmplID1 = 38910,tmplID2 = 38925, requireLevel = 135, price = 50, school =10, skillAddon = 3964, name = "碧落飞鸿" }		---天华五重  碧落飞鸿
	talismans["TH_135_XiHuangZhong"] 				= { talType = "fabao", tmplID = 45532, tmplID1 = 45540,tmplID2 = 45548, requireLevel = 135, price = 50, school =11, skillAddon = 33368, name = "羲皇钟" }		---太昊五重  羲皇钟
	talismans["CH_135_huangji"]							= { talType = "fabao", tmplID = 53386, tmplID1 = 53392,tmplID2 = 53396, requireLevel = 135, price = 50, school =12, skillAddon = 34024, name = "皇极" }		  ---辰皇五重  皇极
	talismans["QJ_135_chixinglongyan"] 			= { talType = "fabao", tmplID = 58801, tmplID1 = 58809,tmplID2 = 58817, requireLevel = 135, price = 50, school =13, skillAddon = 34682, name = "赤星龙炎" }		---牵机五重  赤星龙炎
	talismans["YZ_135_zhuihun"]							= { talType = "fabao", tmplID = 58805, tmplID1 = 58813,tmplID2 = 58821, requireLevel = 135, price = 50, school =14, skillAddon = 34702, name = "追魂" }		  ---英招五重  追魂

	talismans["US_135_PanLongFan"] 					= { talType = "fabao", tmplID = 10868, tmplID1 = 10880,tmplID2 = 10892, requireLevel = 135, price = 50, school = 0, skillAddon =  862, name = "蟠龙幡" }			---通用五重  蟠龙幡	
	talismans["US_135_WuLongLun"] 					= { talType = "fabao", tmplID = 10872, tmplID1 = 10884,tmplID2 = 10896, requireLevel = 135, price = 50, school = 0, skillAddon =  866, name = "五龙轮" }			---通用五重  五龙轮（商城卖RMB）
	talismans["US_135_FanTianYin"] 					= { talType = "fabao", tmplID = 20090, tmplID1 = 20091,tmplID2 = 20092, requireLevel = 135, price = 50, school = 0, skillAddon = 2037, name = "混元金斗" }		---通用五重  混元金斗（2008-09-23彩票出）
	talismans["US_135_ChangMingDeng"]				= { talType = "fabao", tmplID = 20491, tmplID1 = 20492,tmplID2 = 20493, requireLevel = 135, price = 50, school = 0, skillAddon = 2153, name = "錾光龙挂" }		---通用五重  錾光龙挂（2008-10-23彩票出）
	talismans["US_135_BaoKuZhiHun"]					= { talType = "fabao", tmplID = 34820, tmplID1 = 34934,tmplID2 = 34935, requireLevel = 135, price = 50, school = 0, skillAddon = 3825, name = "宝库之魂" }		---通用五重  宝库之魂

	talismans["US_135_SheHun"] 							= { talType = "fabao", tmplID = 10875, tmplID1 = 10887,tmplID2 = 10899, requireLevel = 135, price = 100, school = 0, skillAddon = 869, name = "摄魂" }				---通用五重  摄魂
	talismans["US_145_ShiXueZhu"] 					= { talType = "fabao", tmplID = 10876, tmplID1 = 10888,tmplID2 = 10900, requireLevel = 135, price = 100, school = 0, skillAddon = 870, name = "噬血珠" }			---通用五重  噬血珠
	talismans["US_145_ShiHun"] 							= { talType = "fabao", tmplID = 10877, tmplID1 = 10889,tmplID2 = 10901, requireLevel = 135, price = 100, school = 0, skillAddon = 871, name = "噬魂" }				---通用五重  噬魂
	talismans["US_145_TianYa"] 							= { talType = "fabao", tmplID = 43475, tmplID1 = 43476,tmplID2 = 43478, requireLevel = 135, price = 100, school = 0, skillAddon = 32954, name = "天琊" }				---通用五重  天琊（20110406）

	talismans["US_75_RiYueBaoJian"] 				= { talType = "fabao", tmplID = 22121, tmplID1 = 22122,tmplID2 = 22123, requireLevel = 135, price =  20, school = 0, skillAddon =2598, name = "日月宝鉴" }		---通用三重  日月宝鉴
	talismans["US_45_YuanXiaoDeng"] 				= { talType = "fabao", tmplID = 22906, tmplID1 = 6033,tmplID2 = 6047, requireLevel =  45, price =  20, school = 0, skillAddon =3088, name = "元宵灯" }			---通用一重  元宵灯
	talismans["US_105_FuTu"] 								= { talType = "fabao", tmplID = 23353, tmplID1 = 23354,tmplID2 = 23355, requireLevel = 135, price =  50, school = 0, skillAddon =3162, name = "浮屠" }				---通用四重  浮屠
	talismans["US_135_YinHunFan"] 					= { talType = "fabao", tmplID = 25732, tmplID1 = 25737,tmplID2 = 25738, requireLevel = 135, price =  50, school = 0, skillAddon =3391, name = "引魂幡" }			---通用五重  引魂幡

	-- 测试用飞剑
--	talismans["ceshifeibao"]			= { talType = "feijian", tmplID = 18373, requireLevel = 1, price = 0.1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = false, name = "测试飞宝" }		---测试飞剑  神行百变
	talismans["feiafei"]					= { talType = "feijian", tmplID =  4685, requireLevel = 1, price = 0.1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = false, name = "飞剑" }				---测试飞剑  飞额飞
	talismans["ceshixingxiang"]		= { talType = "feijian", tmplID = 18883, requireLevel = 1, price = 0.1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = false, name = "测试ecm" }			---测试飞剑
	talismans["ceshichibang"]			= { talType = "chibang", tmplID = 34010, requireLevel = 1, price = 0.1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = false, name = "测试翅膀" }		---测试翅膀

	-- 在脚本里：飞剑和御兽的唯一区别是品质描述用词不同
	-- 飞剑  HL:鸿利商城  WZGL:标有王者归来纪念版  PM:唯一最低价PM  LB:礼包  XS:新手  RYZL:荣耀之路纪念版
	talismans["longxiang"]				= { talType = "feijian", tmplID = 18904, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "龙骧" }				---彩票飞剑  龙骧
	talismans["longxiang_HL"]			= { talType = "feijian", tmplID = 31815, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = false, name = "龙骧" }				---鸿利商城  龙骧（2009-09-08）
	talismans["shuoguang"]				= { talType = "feijian", tmplID = 18905, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = false, name = "烁光" }				---商城飞剑  烁光
	talismans["shuoguang2"]				= { talType = "feijian", tmplID = 21176, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "烁光" }				---老玩家回归飞剑  大礼包烁光（2008-11-12）
	talismans["shuoguang_HL"]			= { talType = "feijian", tmplID = 25119, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = false, name = "烁光" }				---鸿利商城  烁光（2009-05-19）
	talismans["shuoguang_XS"]			= { talType = "feijian", tmplID = 41795, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "烁光" }				---新手卡  烁光（2010-10-22）
	talismans["jueying"]					= { talType = "feijian", tmplID = 18906, requireLevel = 60, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "绝影" }				---任务奖励时限飞剑  绝影
	talismans["jueying2"]					= { talType = "feijian", tmplID = 18915, requireLevel = 60, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "绝影" }				---周任务时限飞剑    绝影
	talismans["liudaolunhui"]			= { talType = "feijian", tmplID = 18907, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = false, name = "六道轮回" }		---新手奖励飞剑  六道轮回
	talismans["qingshuang"]				= { talType = "feijian", tmplID = 18914, requireLevel = 60, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "青霜" }				---虚拟币飞剑    青霜
	talismans["yunsuo"]						= { talType = "feijian", tmplID = 19264, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "云梭" }				---彩票飞剑  云梭
	talismans["yuruyi"]						= { talType = "feijian", tmplID = 19526, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "玉如意" }			---彩票飞剑  玉如意
	talismans["biluo"]						= { talType = "feijian", tmplID = 19676, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "碧落" }				---彩票飞剑  碧落（2008-09-25）
	talismans["biluo_WZGL"]				= { talType = "feijian", tmplID = 24712, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "碧落" }				---王者归来纪念版  碧落（2008-05-13）
	talismans["biluo2"]						= { talType = "feijian", tmplID = 24948, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "碧落" }				---大礼包    碧落（2008-05-13）
	talismans["biluo_HL"]					= { talType = "feijian", tmplID = 31817, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = false, name = "碧落" }				---鸿利商城  碧落（2009-09-08）
	talismans["hongfei"]					= { talType = "feijian", tmplID = 20282, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "鸿飞" }				---彩票飞剑  鸿飞（2008-10-09）
	talismans["hongfei_HL"]				= { talType = "feijian", tmplID = 31816, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = false, name = "鸿飞" }				---鸿利商城  鸿飞（2009-09-08）
	talismans["zimang"]						= { talType = "feijian", tmplID = 20490, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "紫芒" }				---彩票飞剑  紫芒（2008-10-23）
	talismans["huiji"]						= { talType = "feijian", tmplID = 21209, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "罡拓" }				---彩票飞剑  罡拓（2008-11-14）
	talismans["huiji_HL"]					= { talType = "feijian", tmplID = 31818, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = false, name = "罡拓" }				---鸿利商城  罡拓（2009-09-08）
	talismans["dizi"]							= { talType = "feijian", tmplID = 23352, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "笛子" }				---彩票飞剑  空瑞（2008-11-14）
	talismans["dizi_WZGL"]				= { talType = "feijian", tmplID = 24713, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "笛子" }				---王者归来纪念版  空瑞（2008-05-13）
	talismans["hunyuanhulu"]			= { talType = "feijian", tmplID = 25741, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "混元葫芦" }		---彩票飞剑  混元葫芦（2009-07-21）
	talismans["hunyuanhulu_LB"]		= { talType = "feijian", tmplID = 42550, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "混元葫芦" }		---礼包飞剑  混元葫芦（2010-12-21）
	talismans["zhanlong"]					= { talType = "feijian", tmplID = 32170, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = false, name = "斩龙" }				---商城飞剑  斩龙（2009-10-13）
	talismans["zhanlong_RYZL"]		= { talType = "feijian", tmplID = 44640, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = false, name = "斩龙" }				---荣耀之路  斩龙（2011-06-03）
	talismans["vip201001"]				= { talType = "feijian", tmplID = 33293, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = false, name = "VIP201001" }	---VIP飞剑  （2009-12-29）
	talismans["vipfeiyu"]					= { talType = "feijian", tmplID = 34286, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "VIP飞鱼" }		---VIP飞鱼（2010-03-22） fromLottery=true 保证高品质
	talismans["feiling"]					= { talType = "feijian", tmplID = 35327, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "飞绫" }			  ---彩票飞剑  飞绫（2010-05-04）
	talismans["yuruyi_PM"]				= { talType = "feijian", tmplID = 35458, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "玉如意" }			---拍卖飞剑  玉如意(拍卖品)
	talismans["longxiang_PM"]			= { talType = "feijian", tmplID = 35460, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "龙骧" }				---拍卖飞剑  龙骧(拍卖品)
	talismans["zimang_PM"]				= { talType = "feijian", tmplID = 35462, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "紫芒" }				---拍卖飞剑  紫芒(拍卖品)
--talismans["hongfei_XS"]				= { talType = "feijian", tmplID = 40100, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "鸿飞" }				---新手在线  鸿飞（2010-06-11）
--talismans["dizi_XS"]					= { talType = "feijian", tmplID = 40101, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "笛子" }				---新手在线  空瑞（2010-06-11）
	talismans["hongfei_XS_new"]		= { talType = "feijian", tmplID = 40466, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "鸿飞" }				---新手在线  鸿飞（2010-06-11）
	talismans["dizi_XS_new"]			= { talType = "feijian", tmplID = 40465, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "笛子" }				---新手在线  空瑞（2010-06-11）
	talismans["pizza"]						= { talType = "feijian", tmplID = 41115, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "比萨" }				---海外飞剑  比萨（2010-8-25）
	talismans["fuyun"]						= { talType = "feijian", tmplID = 41947, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "浮云" }				---彩票飞剑  浮云（2010-10-24）
	talismans["yuruyi_XS"]				= { talType = "feijian", tmplID = 44158, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "玉如意" }				---新手在线  玉如意（2011-04-27）
	talismans["huiji_XS"]					= { talType = "feijian", tmplID = 44160, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "罡拓" }				---新手在线  罡拓（2011-04-27）
	talismans["longxiang_XS"]			= { talType = "feijian", tmplID = 44161, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "龙骧" }				---新手在线  龙骧（2011-04-27）
	talismans["suoying"]					= { talType = "feijian", tmplID = 52344, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "梭影" }				---彩票飞剑  梭影（2012-04-26）
	talismans["dizi_LB"]					= { talType = "feijian", tmplID = 52381, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "笛子" }				---5周年礼包  空瑞（2012-05-04）
	talismans["dacheng"]					= { talType = "feijian", tmplID = 53709, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "大乘" }				---2012年9月	大乘（2012-08-30）
	talismans["lianhua"]					= { talType = "feijian", tmplID = 53711, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "莲花" }				---2012年9月	莲花（2012-08-30）
	talismans["qingshuang_LB"]		= { talType = "feijian", tmplID = 54057, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "青霜" }				---2012年9月	技嘉青霜（2012-09-3）
	talismans["liangyuanhuoyun"]	= { talType = "feijian", tmplID = 55184, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "莲花" }				---2012年12月	良缘火云（2012-11-20）
	talismans["vipfeijian"]				= { talType = "feijian", tmplID = 55440, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "vip飞剑" }				---2013年1月	vip飞剑（2012-12-25）
	talismans["caiyuan"]					= { talType = "feijian", tmplID = 58364, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "彩鸢" }				---2013年6月	彩鸢（2013-06-26）
	talismans["feiling2"]					= { talType = "feijian", tmplID = 61060, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "飞翎" }				---2013年9月	彩鸢（2013-06-26）
	talismans["caiyi2"]						= { talType = "feijian", tmplID = 61062, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "罗衣" }		---彩票御兽  罗衣2013-09

--	talismans["shihunfeijian"]					= { talType = "feijian", tmplID = 58559, requireLevel = 45, price = 1, school = 0, skillAddon = 34636, fromLottery = true,  timeLimit = false, name = "噬魂" }				---2013年9月	
	talismans["shihunfeijian"]					= { talType = "feijian", tmplID = 58559, requireLevel = 45, price = 1, school = 0, skillAddon = 34636, fromLottery = true,  timeLimit = false, name = "噬魂" }				---2013年9月	
	talismans["tianyafeijian"]					= { talType = "feijian", tmplID = 58558, requireLevel = 45, price = 1, school = 0, skillAddon = 34636, fromLottery = true,  timeLimit = false, name = "天琊" }				---2013年9月	
	talismans["shehunfeijian"]					= { talType = "feijian", tmplID = 58561, requireLevel = 45, price = 1, school = 0, skillAddon = 34636, fromLottery = true,  timeLimit = false, name = "摄魂" }				---2013年9月	
	talismans["sihxuefeijian"]					= { talType = "feijian", tmplID = 58562, requireLevel = 45, price = 1, school = 0, skillAddon = 34636, fromLottery = true,  timeLimit = false, name = "噬血" }				---2013年9月	
	talismans["shenmufeijian"]					= { talType = "feijian", tmplID = 58563, requireLevel = 45, price = 1, school = 0, skillAddon = 34636, fromLottery = true,  timeLimit = false, name = "神木" }				---2013年9月	

	-- 御兽
	talismans["baidiao"]					= { talType = "yushou", tmplID = 22120, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "白雕" }				---彩票御兽  战隼（2008-12-17）
	talismans["tiane"]						= { talType = "yushou", tmplID = 23124, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "天鹅" }				---彩票御兽  鸿鹄（2009-01-19）
	talismans["fenghuang"]				= { talType = "yushou", tmplID = 23217, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "凤凰" }				---彩票御兽  火凤（2009-03-13）
	talismans["fenghuang_HL"]			= { talType = "yushou", tmplID = 25120, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = false, name = "凤凰" }				---鸿利商城  火凤（2009-05-19）
	talismans["maotouying"]				= { talType = "yushou", tmplID = 25337, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "猫头鹰" }			---彩票御兽  猫头鹰（2009-07-21）
	talismans["qingyifuwang"]			= { talType = "yushou", tmplID = 32014, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "青翼蝠王" }		---彩票御兽  青翼蝠王（2009-09-20）
	talismans["jinpeng"]					= { talType = "yushou", tmplID = 32711, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "金鹏" }				---彩票御兽  金鹏（2009-11-19）
	talismans["meiying"]					= { talType = "yushou", tmplID = 34285, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "魅影" }				---彩票御兽  魅影（2010-03-22）
	talismans["jinpeng_PM"]				= { talType = "yushou", tmplID = 35459, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "金鹏" }				---拍卖御兽  金鹏(拍卖品)
	talismans["fenghuang_PM"]			= { talType = "yushou", tmplID = 35461, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "凤凰" }				---拍卖御兽  火凤(拍卖品)
--talismans["qingyifuwang_LB"]	= { talType = "yushou", tmplID = 39922, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "青翼蝠王" }		---新手礼包  青翼蝠王（2010-06-11）
--talismans["fenghuang_LB"]			= { talType = "yushou", tmplID = 39923, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "凤凰" }				---新手礼包  火凤（2010-06-11）
--talismans["tiane_XS"]					= { talType = "yushou", tmplID = 34070, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "天鹅" }				---新手在线  鸿鹄（2010-06-11）
--talismans["baidiao_XS"]				= { talType = "yushou", tmplID = 34071, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "白雕" }				---新手在线  战隼（2010-06-11）
	talismans["qingyifuwang_LB_new"]= { talType = "yushou", tmplID = 40467, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "青翼蝠王" }		---新手礼包  青翼蝠王（2010-06-11）
	talismans["fenghuang_LB_new"]	= { talType = "yushou", tmplID = 40468, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "凤凰" }				---新手礼包  火凤（2010-06-11）
	talismans["tiane_XS_new"]			= { talType = "yushou", tmplID = 40469, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "天鹅" }				---新手在线  鸿鹄（2010-06-11）
	talismans["baidiao_XS_new"]		= { talType = "yushou", tmplID = 40470, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "白雕" }				---新手在线  战隼（2010-06-11）
	talismans["qingyifuwang_XS"]	= { talType = "yushou", tmplID = 41791, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "青翼蝠王" }		---新手卡  青翼蝠王（2010-10-22）
	talismans["fenghuang_XS"]			= { talType = "yushou", tmplID = 41792, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "凤凰" }				---新手卡  凤凰（2010-10-22）
	talismans["zhanxiao_XS"]			= { talType = "yushou", tmplID = 41793, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "白雕" }				---新手卡  白雕（2010-10-22）
	talismans["tiane1_XS"]				= { talType = "yushou", tmplID = 41794, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true, name = "天鹅" }				---新手卡  天鹅（2010-10-22）
	talismans["feimuji"]					= { talType = "yushou", tmplID = 42600, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "肥母鸡" }				---彩票御兽  肥母鸡（2010-12-23）
	talismans["feimuji_BS"]				= { talType = "yushou", tmplID = 42663, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "肥母鸡" }				---宝石御兽  肥母鸡（2010-12-28）
	talismans["meiying2"]					= { talType = "yushou", tmplID = 44787, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "魅影2" }				---彩票御兽  魅影2（2011-06-30）
	talismans["dujiaoxian"]				= { talType = "yushou", tmplID = 49311, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "独角仙" }				---跨服奖励御兽  独角仙（2011-08-07）
	talismans["yunjing"]					= { talType = "yushou", tmplID = 52455, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "云鲸" }					---彩票御兽  云鲸（2012-06-13）
	talismans["dieying"]					= { talType = "yushou", tmplID = 52678, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "蝶影" }					---彩票御兽  蝶影（2012-08-02）
	talismans["heisha"]						= { talType = "yushou", tmplID = 54056, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "黑煞" }					---彩票御兽  黑煞（2012-09-3）
	talismans["dachong"]					= { talType = "yushou", tmplID = 54865, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "鬼面大兜虫" }		---彩票御兽  鬼面大兜虫2012-10-10
	talismans["haima"]						= { talType = "yushou", tmplID = 57431, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "海马" }		---彩票御兽  海马2013-04-19
	talismans["luoyi"]						= { talType = "yushou", tmplID = 60297, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "罗衣" }		---彩票御兽  罗衣2013-08-26
	talismans["huiji2"]						= { talType = "yushou", tmplID = 61064, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "罗衣" }		---彩票御兽  罗衣2013-09
	talismans["dieying2"]					= { talType = "yushou", tmplID = 61067, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "罗衣" }		---彩票御兽  罗衣2013-09

	-- 羽翼
	talismans["yuhuang"]					= { talType = "chibang",tmplID = 34041, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "羽皇" }				---彩票羽翼  羽皇(2010-03-03)
	talismans["yuhuang_PM"]				= { talType = "chibang",tmplID = 40505, requireLevel =  1, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "羽皇" }				---拍卖羽翼  羽皇(拍卖品)(2010-06-21)
	talismans["yuhuang_SD"]				= { talType = "chibang",tmplID = 42647, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "羽皇" }				---圣诞特供  羽皇(2010-12-27)
	talismans["yuhuang_XS"]				= { talType = "chibang",tmplID = 51509, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "羽皇" }				---新手特供  羽皇(2012-04-20)
	talismans["caiyi"]						= { talType = "chibang",tmplID = 35164, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "彩翼" }				---彩票羽翼  彩翼(2010-04-22)
	talismans["caiyi_SD"]					= { talType = "chibang",tmplID = 42648, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "彩翼" }				---圣诞特供  彩翼(2010-12-27)
	talismans["tianshi"]					= { talType = "chibang",tmplID = 40962, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "天使" }				---彩票羽翼  天使(2010-08-11)
	talismans["tianshi_SD"]				= { talType = "chibang",tmplID = 42649, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "天使" }				---圣诞特供  天使(2010-12-27)
	talismans["fenghuangchibang"]	= { talType = "chibang",tmplID = 42150, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "凤凰" }				---彩票羽翼  凤凰(2010-11-03)
	talismans["emochibang"]				= { talType = "chibang",tmplID = 43591, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "恶魔" }				---彩票羽翼  恶魔(2011-04-14)
	talismans["emochibang_XS"]		= { talType = "chibang",tmplID = 50848, requireLevel = 1 , price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = false, name = "恶魔" }				---活动羽翼  恶魔(2011-10-18)
	talismans["caiyi_XS"]					= { talType = "chibang",tmplID = 44159, requireLevel = 1 , price = 1, school = 0, skillAddon = 0, fromLottery = false, timeLimit = true , name = "彩翼" }				---彩票羽翼  彩翼(2011-04-27)
	talismans["heiyi"]						= { talType = "chibang",tmplID = 44759, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "恶魔" }				---彩票羽翼  黑翼(2011-06-27)
	talismans["heiyi_HD"]					= { talType = "chibang",tmplID = 58390, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "恶魔" }				---彩票羽翼  墨舞(2013-07-03)
	talismans["mingwang"]					= { talType = "chibang",tmplID = 51198, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "冥王" }				---彩票羽翼  冥王(2012-02-02)
	talismans["shengling"]				= { talType = "chibang",tmplID = 51264, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "圣灵" }				---彩票羽翼  圣灵(2012-02-20)
	talismans["zhiyuan"]					= { talType = "chibang",tmplID = 54006, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "纸鸢" }				---彩票羽翼  纸鸢(2012-09-3)
	talismans["guangming"]				= { talType = "chibang",tmplID = 55358, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "光明" }				---彩票羽翼  光明(2012-12-17)
	talismans["shengling_XS"]			= { talType = "chibang",tmplID = 55665, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "圣灵" }				---彩票羽翼  圣灵(活动)(2013-03-01)	
	talismans["mingyin"]					= { talType = "chibang",tmplID = 55825, requireLevel = 45, price = 1, school = 0, skillAddon = 0, fromLottery = true,  timeLimit = false, name = "冥引" }				---彩票羽翼  冥引(2013-03-06)	

	talismans["6v6chibang01"]					= { talType = "chibang", tmplID = 60480, requireLevel = 45, price = 1, school = 0, skillAddon = 34636, fromLottery = true,  timeLimit = false, name = "翅膀" }				---2013年6v6	
	talismans["6v6chibang02"]					= { talType = "chibang", tmplID = 60481, requireLevel = 45, price = 1, school = 0, skillAddon = 34636, fromLottery = true,  timeLimit = false, name = "翅膀" }				---2013年6v6	
	talismans["6v6chibang03"]					= { talType = "chibang", tmplID = 60482, requireLevel = 45, price = 1, school = 0, skillAddon = 34636, fromLottery = true,  timeLimit = false, name = "翅膀" }				---2013年6v6	

	return talismans
end

---法宝每级精力值成长值
function ZLuaTalStaminaGrowth()
	---staminaGroth[5] = 82的含义是，法宝升到第5级时，其新的精力值上限为 defaultStamina + 82 * quo
	---拟合公式：0.0884 * Lv * Lv + 20.026 * Lv - 20.233
	---数据修改区 开始
	local staminaGrowth = {
		  0,  20,  41,  61,  82, 103, 124, 146, 167, 189,
		211, 233, 255, 277, 300, 323, 346, 369, 392, 416,
		439, 463, 487, 511, 536, 560, 585, 610, 635, 660,
		686, 711, 737, 763, 789, 815, 842, 868, 895, 922,
		949, 977,1004,1032,1060,1088,1116,1145,1173,1202}
	---数据修改区 结束
	return staminaGrowth
end

---法宝档位函数。返回法宝属性档位数、各档数值
function ZLuaTalGrades()

	---取得一些常量
	local dataIndex,resisIndex = ZLuaTalDataIndex()

	---数据修改区 开始
	
	---每个属性分几档，这仅仅是初始化时，在这个范围内随机，而血炼后可能会突破这个档位数
	local nGrades
	nGrades = 50  ---must >= 3，Weights[]的长度必须 ＝ nGrades

	---各类属性的上下限
	local valueBounds = {}
	valueBounds[dataIndex["default_stamina"]]				=	{ 220, 260 }
	valueBounds[dataIndex["quo_stamina"]] 					=	{ 0.75, 1.2 }

	valueBounds[dataIndex["default_hp"]] 						= { 0, 50 }
	valueBounds[dataIndex["default_mp"]]            = { 0, 50 }
	valueBounds[dataIndex["default_attack_rate"]]   = { 0, 0 }
	valueBounds[dataIndex["default_damage_low"]]    = { 0, 10 }
	valueBounds[dataIndex["default_damage_high"]]   = { 0, 30 }
	valueBounds[dataIndex["default_dodge"]]         = { 0, 0 }
	valueBounds[dataIndex["default_defense"]]       = { 0, 0 }  ---必须是0
	valueBounds[dataIndex["default_resis_stun"]]     = { 0, 10 }
	valueBounds[dataIndex["default_resis_sleep"]]    = { 0, 10 }
	valueBounds[dataIndex["default_resis_silence"]]  = { 0, 10 }
	valueBounds[dataIndex["default_resis_weakness"]] = { 0, 10 }
	valueBounds[dataIndex["default_resis_enlace"]]   = { 0, 10 }

	valueBounds[dataIndex["grow_hp"]]               = { 1, 100.18 }
	valueBounds[dataIndex["grow_mp"]]               = { 1, 69.44 }
	valueBounds[dataIndex["grow_attack_rate"]]      = { 0, 0 }
	valueBounds[dataIndex["grow_damage_low"]]       = { 0.5, 15.51 / 2 }
	valueBounds[dataIndex["grow_damage_high"]]      = { 1, 15.51 * 1.5 }
	valueBounds[dataIndex["grow_dodge"]]            = { 0, 0 }
	valueBounds[dataIndex["grow_defense"]]          = { 0, 0 } ---必须是0
	valueBounds[dataIndex["grow_resis_stun"]]        = { 0.5, 4.76 }
	valueBounds[dataIndex["grow_resis_sleep"]]       = { 0.5, 4.76 }
	valueBounds[dataIndex["grow_resis_silence"]]     = { 0.5, 4.76 }
	valueBounds[dataIndex["grow_resis_weakness"]]    = { 0.5, 4.76 }
	valueBounds[dataIndex["grow_resis_enlace"]]      = { 0.5, 4.76 }

	---数据修改区 结束

	---各类属性的档位
	local valueGrades = {}
	valueGrades[dataIndex["default_stamina"]] = {}
	valueGrades[dataIndex["quo_stamina"]] = {}
	
	valueGrades[dataIndex["default_hp"]] = {}
	valueGrades[dataIndex["default_mp"]] = {}
	valueGrades[dataIndex["default_attack_rate"]] = {}
	valueGrades[dataIndex["default_damage_low"]] = {}
	valueGrades[dataIndex["default_damage_high"]] = {}
	valueGrades[dataIndex["default_dodge"]] = {}
	valueGrades[dataIndex["default_defense"]] = {}
	valueGrades[dataIndex["default_resis_stun"]] = {}
	valueGrades[dataIndex["default_resis_sleep"]] = {}
	valueGrades[dataIndex["default_resis_silence"]] = {}
	valueGrades[dataIndex["default_resis_weakness"]] = {}
	valueGrades[dataIndex["default_resis_enlace"]] = {}
	
	
	valueGrades[dataIndex["grow_hp"]] = {}
	valueGrades[dataIndex["grow_mp"]] = {}
	valueGrades[dataIndex["grow_attack_rate"]] = {}
	valueGrades[dataIndex["grow_damage_low"]] = {}
	valueGrades[dataIndex["grow_damage_high"]] = {}
	valueGrades[dataIndex["grow_dodge"]] = {}
	valueGrades[dataIndex["grow_defense"]] = {}
	valueGrades[dataIndex["grow_resis_stun"]] = {}
	valueGrades[dataIndex["grow_resis_sleep"]] = {}
	valueGrades[dataIndex["grow_resis_silence"]] = {}
	valueGrades[dataIndex["grow_resis_weakness"]] = {}
	valueGrades[dataIndex["grow_resis_enlace"]] = {}
		
	local i
	for i = 1, nGrades do
		valueGrades[dataIndex["default_stamina"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["default_stamina"]][1], valueBounds[dataIndex["default_stamina"]][2], i, nGrades )
		valueGrades[dataIndex["quo_stamina"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["quo_stamina"]][1], valueBounds[dataIndex["quo_stamina"]][2], i, nGrades )
		
		valueGrades[dataIndex["default_hp"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["default_hp"]][1], valueBounds[dataIndex["default_hp"]][2], i, nGrades )
		valueGrades[dataIndex["default_mp"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["default_mp"]][1], valueBounds[dataIndex["default_mp"]][2], i, nGrades )
		valueGrades[dataIndex["default_attack_rate"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["default_attack_rate"]][1], valueBounds[dataIndex["default_attack_rate"]][2], i, nGrades )
		valueGrades[dataIndex["default_damage_low"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["default_damage_low"]][1], valueBounds[dataIndex["default_damage_low"]][2], i, nGrades )
		valueGrades[dataIndex["default_damage_high"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["default_damage_high"]][1], valueBounds[dataIndex["default_damage_high"]][2], i, nGrades )
		valueGrades[dataIndex["default_dodge"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["default_dodge"]][1], valueBounds[dataIndex["default_dodge"]][2], i, nGrades )
		valueGrades[dataIndex["default_defense"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["default_defense"]][1], valueBounds[dataIndex["default_defense"]][2], i, nGrades )
		valueGrades[dataIndex["default_resis_stun"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["default_resis_stun"]][1], valueBounds[dataIndex["default_resis_stun"]][2], i, nGrades )
		valueGrades[dataIndex["default_resis_sleep"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["default_resis_sleep"]][1], valueBounds[dataIndex["default_resis_sleep"]][2], i, nGrades )
		valueGrades[dataIndex["default_resis_silence"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["default_resis_silence"]][1], valueBounds[dataIndex["default_resis_silence"]][2], i, nGrades )
		valueGrades[dataIndex["default_resis_weakness"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["default_resis_weakness"]][1], valueBounds[dataIndex["default_resis_weakness"]][2], i, nGrades )
		valueGrades[dataIndex["default_resis_enlace"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["default_resis_enlace"]][1], valueBounds[dataIndex["default_resis_enlace"]][2], i, nGrades )
		
		valueGrades[dataIndex["grow_hp"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["grow_hp"]][1], valueBounds[dataIndex["grow_hp"]][2], i, nGrades )
		valueGrades[dataIndex["grow_mp"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["grow_mp"]][1], valueBounds[dataIndex["grow_mp"]][2], i, nGrades )
		valueGrades[dataIndex["grow_attack_rate"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["grow_attack_rate"]][1], valueBounds[dataIndex["grow_attack_rate"]][2], i, nGrades )
		valueGrades[dataIndex["grow_damage_low"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["grow_damage_low"]][1], valueBounds[dataIndex["grow_damage_low"]][2], i, nGrades )
		valueGrades[dataIndex["grow_damage_high"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["grow_damage_high"]][1], valueBounds[dataIndex["grow_damage_high"]][2], i, nGrades )
		valueGrades[dataIndex["grow_dodge"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["grow_dodge"]][1], valueBounds[dataIndex["grow_dodge"]][2], i, nGrades )
		valueGrades[dataIndex["grow_defense"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["grow_defense"]][1], valueBounds[dataIndex["grow_defense"]][2], i, nGrades )
		valueGrades[dataIndex["grow_resis_stun"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["grow_resis_stun"]][1], valueBounds[dataIndex["grow_resis_stun"]][2], i, nGrades )
		valueGrades[dataIndex["grow_resis_sleep"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["grow_resis_sleep"]][1], valueBounds[dataIndex["grow_resis_sleep"]][2], i, nGrades )
		valueGrades[dataIndex["grow_resis_silence"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["grow_resis_silence"]][1], valueBounds[dataIndex["grow_resis_silence"]][2], i, nGrades )
		valueGrades[dataIndex["grow_resis_weakness"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["grow_resis_weakness"]][1], valueBounds[dataIndex["grow_resis_weakness"]][2], i, nGrades )
		valueGrades[dataIndex["grow_resis_enlace"]][i] = ZLuaTalGetValueWithBounds( valueBounds[dataIndex["grow_resis_enlace"]][1], valueBounds[dataIndex["grow_resis_enlace"]][2], i, nGrades )
	end
	
	return nGrades, valueGrades
end

---每个法宝的 总档位上限 以及 每个属性的档位上限
function ZLuaTalGradesUpperLimit(tmplID)
	if ZLuaTalExistInTmplIDs(tmplID) == 0 then return nil end
	local dataIndex,resisIndex = ZLuaTalDataIndex()
	local talismans = ZLuaTalAvailableTalismans()
	
	---格式{总档位，最小攻击，最大攻击，HP，MP，命中，躲闪，眩晕，虚弱，定身，魅惑，昏睡，冰冻?}
	local gradesUpperLimit

	---八卦石 五色石
	if tmplID == talismans["NW_1_BaGuaShi"].tmplID or tmplID == talismans["SY_1_WuSeShi"].tmplID or tmplID == talismans["LZ_1_TianLingShi"].tmplID then
		gradesUpperLimit = { 82, 40, 40,	40,	40,	1,	1,	40,	40,	40,	40,	40,	1 }
	---朱雀印	怒兽幡
	elseif tmplID == talismans["GW_15_ZhuQueYin"].tmplID or tmplID == talismans["JL_15_NuShouFan"].tmplID or tmplID == talismans["QJ_15_tianjimu"].tmplID then
		gradesUpperLimit = { 148, 50, 50,	50,	50,	1,	1,	45,	45,	45,	45,	45,	1 }
	---慑心铃 七杀
	elseif tmplID == talismans["HH_15_SheXinLing"].tmplID or tmplID == talismans["HG_15_QiSha"].tmplID or tmplID == talismans["YZ_15_lveying"].tmplID then
		gradesUpperLimit = { 150, 50, 50,	50,	50,	1,	1,	45,	45,	45,	45,	45,	1 }
	---六合镜 九音螺
	elseif tmplID == talismans["QY_15_LiuHeJing"].tmplID or tmplID == talismans["TH_15_JiuYinLuo"].tmplID then
		gradesUpperLimit = { 150, 50, 50,	50,	50,	1,	1,	45,	45,	45,	45,	45,	1 }
	---轮回珠	丹朱 率兜旗
	elseif tmplID == talismans["TY_15_LunHuiZhu"].tmplID or tmplID == talismans["LS_15_DanZhu"].tmplID or tmplID == talismans["CH_15_lvdouqi"].tmplID then
		gradesUpperLimit = { 146, 50, 50,	50,	50,	1,	1,	45,	45,	45,	45,	45,	1 }
	---血玉骨片 南明印 雷公墨
	elseif tmplID == talismans["GD_15_XueYuGuPian"].tmplID or tmplID == talismans["FX_15_NanMingYin"].tmplID or tmplID == talismans["TH_15_LeiGongMo"].tmplID then
		gradesUpperLimit = { 150, 50, 50,	50,	50,	1,	1,	45,	45,	45,	45,	45,	1 }
	---四灵幡 血枫枪
	elseif tmplID == talismans["GW_75_SiLingFan"].tmplID or tmplID == talismans["JL_75_XueFengQiang"].tmplID or tmplID == talismans["QJ_75_luohouyu"].tmplID then
		gradesUpperLimit = { 219, 55, 55,	55,	55,	1,	1,	50,	50,	50,	50,	50,	1 }
	---多情环 破军
	elseif tmplID == talismans["HH_75_DuoQingHuan"].tmplID or tmplID == talismans["HG_75_PoJun"].tmplID or tmplID == talismans["YZ_75_poming"].tmplID then
		gradesUpperLimit = { 225, 55, 55,	55,	55,	1,	1,	50,	50,	50,	50,	50,	1 }
	---七星剑 亚风
	elseif tmplID == talismans["QY_75_QiXingJian"].tmplID or tmplID == talismans["TH_75_YaFeng"].tmplID then
		gradesUpperLimit = { 224, 55, 55,	55,	55,	1,	1,	50,	50,	50,	50,	50,	1 }
	---金刚杵 返魂香 鼍鼓
	elseif tmplID == talismans["TY_75_JinGangChu"].tmplID or tmplID == talismans["LS_75_FanHunXiang"].tmplID or tmplID == talismans["CH_75_tuogu"].tmplID then
		gradesUpperLimit = { 219, 55, 55,	55,	55,	1,	1,	50,	50,	50,	50,	50,	1 }
	---破刹 衡天尺 春秋锁
	elseif tmplID == talismans["GD_75_PoSha"].tmplID or tmplID == talismans["FX_75_HengTianChi"].tmplID or tmplID == talismans["TH_75_ChunQiuSuo"].tmplID then
		gradesUpperLimit = { 225, 55, 55,	55,	55,	1,	1,	50,	50,	50,	50,	50,	1 }

	---45级通用法宝(神木骰 元宵灯)
	elseif tmplID == talismans["US_45_ShenMuShai"].tmplID
			or tmplID == talismans["US_45_ShenMuShai_WZGL"].tmplID
			or tmplID == talismans["US_45_YuanXiaoDeng"].tmplID then
		gradesUpperLimit = { 225, 55, 55,	55,	55,	1,	1,	50,	50,	50,	50,	50,	1 }

	---75级通用法宝(山河扇 万毒鼎 玉净瓶 玲珑塔)
	elseif tmplID == talismans["US_75_ShanHeShan"].tmplID 
			or tmplID == talismans["US_75_WanDuDing"].tmplID
			or tmplID == talismans["US_75_YuJingPing"].tmplID
			or tmplID == talismans["US_75_LingLongTa"].tmplID then
		gradesUpperLimit = { 250, 55, 55,	55,	55,	1,	1,	50,	50,	50,	50,	50,	1 }

	---105级门派法宝
	elseif tmplID == talismans["GW_105_QianKunQingGuangJie"].tmplID
			or tmplID == talismans["HH_105_QianMeiLian"].tmplID
			or tmplID == talismans["QY_105_HuPoZhuLing"].tmplID
			or tmplID == talismans["TY_105_RuYiQianKunDai"].tmplID 
			or tmplID == talismans["GD_105_QianDuGu"].tmplID
			or tmplID == talismans["FX_105_HuoLingLong"].tmplID
			or tmplID == talismans["JL_105_GangLan"].tmplID
			or tmplID == talismans["LS_105_FuYingGuJing"].tmplID
			or tmplID == talismans["HG_105_TanLang"].tmplID
			or tmplID == talismans["TH_105_LiuLiZhan"].tmplID
			or tmplID == talismans["TH_105_ZiMuYinYangKou"].tmplID
			or tmplID == talismans["CH_105_luobaojinqian"].tmplID
			or tmplID == talismans["QJ_105_jinyubian"].tmplID
			or tmplID == talismans["YZ_105_shuolei"].tmplID
		then
		gradesUpperLimit = { 270, 55, 55,	55,	55,	1,	1,	50,	50,	50,	50,	50,	1 }

	---105级通用法宝 和 蟠龙幡
	elseif tmplID == talismans["US_105_YinYangJing"].tmplID 
			or tmplID == talismans["US_105_YinYangJing_WZGL"].tmplID
			or tmplID == talismans["US_135_PanLongFan"].tmplID
			or tmplID == talismans["US_105_JinHuLu"].tmplID
			or tmplID == talismans["US_105_JiuLongShenHuoZhao"].tmplID then
		gradesUpperLimit = { 300, 150, 55,	55,	55,		1,	1,	50,	50,	50,	50,	50,	1 }

	---真山河扇 通用
	elseif tmplID == talismans["US_105_ZhenShanHeShan"].tmplID then
		gradesUpperLimit = { 300, 50, 55,	55,	55,		1,	1,	50,	50,	50,	50,	50,	1 }
	
	---落魂灯 通用
	elseif tmplID == talismans["US_105_LuoHunDeng"].tmplID then
		gradesUpperLimit = { 300, 60, 60,	60,	60,		1,	1,	50,	50,	50,	50,	50,	1 }
		
	---135级门派法宝 和 135级通用法宝（除了蟠龙幡）
	elseif tmplID == talismans["GW_135_TianMoZhi"].tmplID
			or tmplID == talismans["QY_135_RuoXue"].tmplID
			or tmplID == talismans["HH_135_BaJiYouLong"].tmplID
			or tmplID == talismans["TY_135_LiuDaoShengMie"].tmplID 
			or tmplID == talismans["GD_135_GuiQing"].tmplID
			or tmplID == talismans["FX_135_JiuHanNingBingCi"].tmplID
			or tmplID == talismans["JL_135_SangMenJian"].tmplID
			or tmplID == talismans["LS_135_LuoShu"].tmplID
			or tmplID == talismans["HG_135_JueYing"].tmplID
			or tmplID == talismans["TH_135_BiLuoFeiHong"].tmplID
			or tmplID == talismans["TH_135_XiHuangZhong"].tmplID
			or tmplID == talismans["CH_135_huangji"].tmplID
			or tmplID == talismans["QJ_135_chixinglongyan"].tmplID
			or tmplID == talismans["YZ_135_zhuihun"].tmplID
			or tmplID == talismans["US_135_WuLongLun"].tmplID
			or tmplID == talismans["US_135_FanTianYin"].tmplID
			or tmplID == talismans["US_135_ChangMingDeng"].tmplID
			or tmplID == talismans["US_135_BaoKuZhiHun"].tmplID
			or tmplID == talismans["US_75_RiYueBaoJian"].tmplID
			or tmplID == talismans["US_105_FuTu"].tmplID
			or tmplID == talismans["US_135_YinHunFan"].tmplID
			then
		gradesUpperLimit = { 300, 60, 60,	60,	60,		1,	1,	50,	50,	50,	50,	50,	1 }
	
	---摄魂	噬血珠 食物法宝
	elseif tmplID == talismans["US_135_SheHun"].tmplID
			or tmplID == talismans["US_145_ShiXueZhu"].tmplID
			or tmplID == talismans["foodtalisman"].tmplID then
		gradesUpperLimit = { 320, 60, 60,	60,	60,	1,	1,	50,	50,	50,	50,	50,	1 }

	-- 噬魂 天琊
	elseif tmplID == talismans["US_145_ShiHun"].tmplID 
			or tmplID == talismans["US_145_TianYa"].tmplID then
		gradesUpperLimit = { 360, 65, 65,	65,	65,	1,	1,	55,	55,	55,	55,	55,	1 }
		
	---飞宝 通用
	elseif ZLuaTalGetTalTypeFromID(tmplID) == "feijian"
			or ZLuaTalGetTalTypeFromID(tmplID) == "yushou"
			or ZLuaTalGetTalTypeFromID(tmplID) == "chibang"
			then
		gradesUpperLimit = { 300, 1, 1,	1,	1,	1,	1,	1,	1,	1,	1,	1,	1 }
	end

	return gradesUpperLimit
end

---每个法宝的 每个属性的 每个档位的 随机权重
function ZLuaTalRandomWeight(tmplID, origin)
	if ZLuaTalExistInTmplIDs(tmplID) == 0 then return nil end
	---取得一些常量
	local dataIndex,resisIndex = ZLuaTalDataIndex()
	local talismanOrigin = ZLuaTalServerOrigins()
	local talismans = ZLuaTalAvailableTalismans()

	---数据修改区 开始

	---开始设置每个法宝的每个属性的每个档位的权重
	local valueWeights = {}
	
	---任务给的八卦石 五色石
	if (tmplID == talismans["NW_1_BaGuaShi"].tmplID or tmplID == talismans["SY_1_WuSeShi"].tmplID or tmplID == talismans["LZ_1_TianLingShi"].tmplID) and origin == talismanOrigin["quest"] then

		valueWeights[dataIndex["default_hp"]] ={0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_mp"]] ={0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_attack_rate"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_low"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_high"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_dodge"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_sleep"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_silence"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_weakness"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_enlace"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		
		valueWeights[dataIndex["grow_hp"]] ={0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_mp"]] ={0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_attack_rate"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_low"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_high"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_dodge"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_silence"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}

	---任务给的朱雀印 怒兽幡
	elseif (tmplID == talismans["GW_15_ZhuQueYin"].tmplID or tmplID == talismans["JL_15_NuShouFan"].tmplID or tmplID == talismans["QJ_15_tianjimu"].tmplID) and origin == talismanOrigin["quest"] then

		valueWeights[dataIndex["default_hp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_mp"]] ={0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_attack_rate"]] ={0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_dodge"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		
		valueWeights[dataIndex["grow_hp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_mp"]] ={0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_attack_rate"]] ={0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_dodge"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}

	---任务给的慑心铃 七杀
	elseif (tmplID == talismans["HH_15_SheXinLing"].tmplID or tmplID == talismans["HG_15_QiSha"].tmplID or tmplID == talismans["YZ_15_lveying"].tmplID) and origin == talismanOrigin["quest"] then
	
		valueWeights[dataIndex["default_hp"]] ={0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_mp"]] ={0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_attack_rate"]] ={0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_dodge"]] ={0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		
		valueWeights[dataIndex["grow_hp"]] ={0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_mp"]] ={0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_attack_rate"]] ={0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_dodge"]] ={0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}

	---任务给的六合镜 九音螺
	elseif (tmplID == talismans["QY_15_LiuHeJing"].tmplID or tmplID == talismans["TH_15_JiuYinLuo"].tmplID) and origin == talismanOrigin["quest"] then

		valueWeights[dataIndex["default_hp"]] ={0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_mp"]] ={0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_attack_rate"]] ={0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_dodge"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		
		valueWeights[dataIndex["grow_hp"]] ={0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_mp"]] ={0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_attack_rate"]] ={0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_dodge"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}

	---任务给的轮回珠 丹朱 率兜旗
	elseif (tmplID == talismans["TY_15_LunHuiZhu"].tmplID or tmplID == talismans["LS_15_DanZhu"].tmplID or tmplID == talismans["CH_15_lvdouqi"].tmplID) and origin == talismanOrigin["quest"] then
	
		valueWeights[dataIndex["default_hp"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_mp"]] ={0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_attack_rate"]] ={0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_dodge"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		
		valueWeights[dataIndex["grow_hp"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_mp"]] ={0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_attack_rate"]] ={0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_dodge"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		
	---任务给的血玉骨片 南明印 雷公墨
	elseif (tmplID == talismans["GD_15_XueYuGuPian"].tmplID or tmplID == talismans["FX_15_NanMingYin"].tmplID or tmplID == talismans["TH_15_LeiGongMo"].tmplID) and origin == talismanOrigin["quest"] then
	
		valueWeights[dataIndex["default_hp"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_mp"]] ={0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_attack_rate"]] ={0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_dodge"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		
		valueWeights[dataIndex["grow_hp"]] ={0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_mp"]] ={0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_attack_rate"]] ={0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_dodge"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}

	---八卦石 五色石
	elseif tmplID == talismans["NW_1_BaGuaShi"].tmplID or tmplID == talismans["SY_1_WuSeShi"].tmplID or tmplID == talismans["LZ_1_TianLingShi"].tmplID then
	
		valueWeights[dataIndex["default_hp"]] ={5,15,12.5,25,37.5,2.5,1.66666666666667,.833333333333333,4.65116279069767E-03,4.54042081949059E-03,4.4296788482835E-03,4.31893687707641E-03,4.20819490586932E-03,4.09745293466224E-03,3.98671096345515E-03,3.87596899224806E-03,3.76522702104097E-03,3.65448504983389E-03,3.5437430786268E-03,3.43300110741971E-03,3.32225913621262E-03,3.21151716500554E-03,3.10077519379845E-03,2.99003322259136E-03,2.87929125138427E-03,2.76854928017719E-03,2.6578073089701E-03,2.54706533776301E-03,2.43632336655592E-03,2.32558139534884E-03,2.21483942414175E-03,2.10409745293466E-03,1.99335548172757E-03,1.88261351052049E-03,1.7718715393134E-03,1.66112956810631E-03,1.55038759689922E-03,1.43964562569214E-03,1.32890365448505E-03,1.21816168327796E-03,1.10741971207087E-03,9.96677740863787E-04,8.859357696567E-04,7.75193798449612E-04,6.64451827242524E-04,5.53709856035437E-04,4.42967884828349E-04,3.32225913621262E-04,2.21483942414174E-04,1.10741971207087E-04,}
		valueWeights[dataIndex["default_mp"]] ={5,15,12.5,25,37.5,2.5,1.66666666666667,.833333333333333,4.65116279069767E-03,4.54042081949059E-03,4.4296788482835E-03,4.31893687707641E-03,4.20819490586932E-03,4.09745293466224E-03,3.98671096345515E-03,3.87596899224806E-03,3.76522702104097E-03,3.65448504983389E-03,3.5437430786268E-03,3.43300110741971E-03,3.32225913621262E-03,3.21151716500554E-03,3.10077519379845E-03,2.99003322259136E-03,2.87929125138427E-03,2.76854928017719E-03,2.6578073089701E-03,2.54706533776301E-03,2.43632336655592E-03,2.32558139534884E-03,2.21483942414175E-03,2.10409745293466E-03,1.99335548172757E-03,1.88261351052049E-03,1.7718715393134E-03,1.66112956810631E-03,1.55038759689922E-03,1.43964562569214E-03,1.32890365448505E-03,1.21816168327796E-03,1.10741971207087E-03,9.96677740863787E-04,8.859357696567E-04,7.75193798449612E-04,6.64451827242524E-04,5.53709856035437E-04,4.42967884828349E-04,3.32225913621262E-04,2.21483942414174E-04,1.10741971207087E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={75,.004,3.91836734693878E-03,3.83673469387755E-03,3.75510204081633E-03,3.6734693877551E-03,3.59183673469388E-03,3.51020408163265E-03,3.42857142857143E-03,3.3469387755102E-03,3.26530612244898E-03,3.18367346938775E-03,3.10204081632653E-03,3.02040816326531E-03,2.93877551020408E-03,2.85714285714286E-03,2.77551020408163E-03,2.69387755102041E-03,2.61224489795918E-03,2.53061224489796E-03,2.44897959183673E-03,2.36734693877551E-03,2.28571428571429E-03,2.20408163265306E-03,2.12244897959184E-03,2.04081632653061E-03,1.95918367346939E-03,1.87755102040816E-03,1.79591836734694E-03,1.71428571428571E-03,1.63265306122449E-03,1.55102040816327E-03,1.46938775510204E-03,1.38775510204082E-03,1.30612244897959E-03,1.22448979591837E-03,1.14285714285714E-03,1.06122448979592E-03,9.79591836734694E-04,8.97959183673469E-04,8.16326530612245E-04,7.3469387755102E-04,6.53061224489796E-04,5.71428571428572E-04,4.89795918367347E-04,4.08163265306123E-04,3.26530612244898E-04,2.44897959183673E-04,1.63265306122449E-04,8.16326530612248E-05,}
		valueWeights[dataIndex["default_damage_low"]] ={2.5,2.5,7.5,7.5,7.5,15,22.5,30,2.5,1.66666666666667,.833333333333333,.005,4.87179487179487E-03,4.74358974358974E-03,4.61538461538462E-03,4.48717948717949E-03,4.35897435897436E-03,4.23076923076923E-03,4.1025641025641E-03,3.97435897435897E-03,3.84615384615385E-03,3.71794871794872E-03,3.58974358974359E-03,3.46153846153846E-03,3.33333333333333E-03,3.20512820512821E-03,3.07692307692308E-03,2.94871794871795E-03,2.82051282051282E-03,2.69230769230769E-03,2.56410256410256E-03,2.43589743589744E-03,2.30769230769231E-03,2.17948717948718E-03,2.05128205128205E-03,1.92307692307692E-03,1.7948717948718E-03,1.66666666666667E-03,1.53846153846154E-03,1.41025641025641E-03,1.28205128205128E-03,1.15384615384615E-03,1.02564102564103E-03,8.97435897435898E-04,7.69230769230769E-04,6.41025641025641E-04,5.12820512820513E-04,3.84615384615385E-04,2.56410256410256E-04,1.28205128205128E-04,}
		valueWeights[dataIndex["default_damage_high"]] ={2.5,2.5,7.5,7.5,7.5,15,22.5,30,2.5,1.66666666666667,.833333333333333,.005,4.87179487179487E-03,4.74358974358974E-03,4.61538461538462E-03,4.48717948717949E-03,4.35897435897436E-03,4.23076923076923E-03,4.1025641025641E-03,3.97435897435897E-03,3.84615384615385E-03,3.71794871794872E-03,3.58974358974359E-03,3.46153846153846E-03,3.33333333333333E-03,3.20512820512821E-03,3.07692307692308E-03,2.94871794871795E-03,2.82051282051282E-03,2.69230769230769E-03,2.56410256410256E-03,2.43589743589744E-03,2.30769230769231E-03,2.17948717948718E-03,2.05128205128205E-03,1.92307692307692E-03,1.7948717948718E-03,1.66666666666667E-03,1.53846153846154E-03,1.41025641025641E-03,1.28205128205128E-03,1.15384615384615E-03,1.02564102564103E-03,8.97435897435898E-04,7.69230769230769E-04,6.41025641025641E-04,5.12820512820513E-04,3.84615384615385E-04,2.56410256410256E-04,1.28205128205128E-04,}
		valueWeights[dataIndex["default_dodge"]] ={75,.004,3.91836734693878E-03,3.83673469387755E-03,3.75510204081633E-03,3.6734693877551E-03,3.59183673469388E-03,3.51020408163265E-03,3.42857142857143E-03,3.3469387755102E-03,3.26530612244898E-03,3.18367346938775E-03,3.10204081632653E-03,3.02040816326531E-03,2.93877551020408E-03,2.85714285714286E-03,2.77551020408163E-03,2.69387755102041E-03,2.61224489795918E-03,2.53061224489796E-03,2.44897959183673E-03,2.36734693877551E-03,2.28571428571429E-03,2.20408163265306E-03,2.12244897959184E-03,2.04081632653061E-03,1.95918367346939E-03,1.87755102040816E-03,1.79591836734694E-03,1.71428571428571E-03,1.63265306122449E-03,1.55102040816327E-03,1.46938775510204E-03,1.38775510204082E-03,1.30612244897959E-03,1.22448979591837E-03,1.14285714285714E-03,1.06122448979592E-03,9.79591836734694E-04,8.97959183673469E-04,8.16326530612245E-04,7.3469387755102E-04,6.53061224489796E-04,5.71428571428572E-04,4.89795918367347E-04,4.08163265306123E-04,3.26530612244898E-04,2.44897959183673E-04,1.63265306122449E-04,8.16326530612248E-05,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={2.5,2.5,5,5,5,5,10,15,20,25,2.5,1.66666666666667,.833333333333333,5.26315789473684E-03,5.12091038406828E-03,4.97866287339972E-03,4.83641536273115E-03,4.69416785206259E-03,4.55192034139403E-03,4.40967283072546E-03,4.2674253200569E-03,4.12517780938834E-03,3.98293029871977E-03,3.84068278805121E-03,3.69843527738265E-03,3.55618776671408E-03,3.41394025604552E-03,3.27169274537696E-03,3.12944523470839E-03,2.98719772403983E-03,2.84495021337127E-03,2.7027027027027E-03,2.56045519203414E-03,2.41820768136558E-03,2.27596017069701E-03,2.13371266002845E-03,1.99146514935989E-03,1.84921763869132E-03,1.70697012802276E-03,1.5647226173542E-03,1.42247510668563E-03,1.28022759601707E-03,1.13798008534851E-03,9.95732574679943E-04,8.53485064011381E-04,7.11237553342817E-04,5.68990042674253E-04,4.2674253200569E-04,2.84495021337127E-04,1.42247510668564E-04,}
		valueWeights[dataIndex["default_resis_sleep"]] ={2.5,2.5,5,5,5,5,10,15,20,25,2.5,1.66666666666667,.833333333333333,5.26315789473684E-03,5.12091038406828E-03,4.97866287339972E-03,4.83641536273115E-03,4.69416785206259E-03,4.55192034139403E-03,4.40967283072546E-03,4.2674253200569E-03,4.12517780938834E-03,3.98293029871977E-03,3.84068278805121E-03,3.69843527738265E-03,3.55618776671408E-03,3.41394025604552E-03,3.27169274537696E-03,3.12944523470839E-03,2.98719772403983E-03,2.84495021337127E-03,2.7027027027027E-03,2.56045519203414E-03,2.41820768136558E-03,2.27596017069701E-03,2.13371266002845E-03,1.99146514935989E-03,1.84921763869132E-03,1.70697012802276E-03,1.5647226173542E-03,1.42247510668563E-03,1.28022759601707E-03,1.13798008534851E-03,9.95732574679943E-04,8.53485064011381E-04,7.11237553342817E-04,5.68990042674253E-04,4.2674253200569E-04,2.84495021337127E-04,1.42247510668564E-04,}
		valueWeights[dataIndex["default_resis_silence"]] ={2.5,2.5,5,5,5,5,10,15,20,25,2.5,1.66666666666667,.833333333333333,5.26315789473684E-03,5.12091038406828E-03,4.97866287339972E-03,4.83641536273115E-03,4.69416785206259E-03,4.55192034139403E-03,4.40967283072546E-03,4.2674253200569E-03,4.12517780938834E-03,3.98293029871977E-03,3.84068278805121E-03,3.69843527738265E-03,3.55618776671408E-03,3.41394025604552E-03,3.27169274537696E-03,3.12944523470839E-03,2.98719772403983E-03,2.84495021337127E-03,2.7027027027027E-03,2.56045519203414E-03,2.41820768136558E-03,2.27596017069701E-03,2.13371266002845E-03,1.99146514935989E-03,1.84921763869132E-03,1.70697012802276E-03,1.5647226173542E-03,1.42247510668563E-03,1.28022759601707E-03,1.13798008534851E-03,9.95732574679943E-04,8.53485064011381E-04,7.11237553342817E-04,5.68990042674253E-04,4.2674253200569E-04,2.84495021337127E-04,1.42247510668564E-04,}
		valueWeights[dataIndex["default_resis_weakness"]] ={2.5,2.5,5,5,5,5,10,15,20,25,2.5,1.66666666666667,.833333333333333,5.26315789473684E-03,5.12091038406828E-03,4.97866287339972E-03,4.83641536273115E-03,4.69416785206259E-03,4.55192034139403E-03,4.40967283072546E-03,4.2674253200569E-03,4.12517780938834E-03,3.98293029871977E-03,3.84068278805121E-03,3.69843527738265E-03,3.55618776671408E-03,3.41394025604552E-03,3.27169274537696E-03,3.12944523470839E-03,2.98719772403983E-03,2.84495021337127E-03,2.7027027027027E-03,2.56045519203414E-03,2.41820768136558E-03,2.27596017069701E-03,2.13371266002845E-03,1.99146514935989E-03,1.84921763869132E-03,1.70697012802276E-03,1.5647226173542E-03,1.42247510668563E-03,1.28022759601707E-03,1.13798008534851E-03,9.95732574679943E-04,8.53485064011381E-04,7.11237553342817E-04,5.68990042674253E-04,4.2674253200569E-04,2.84495021337127E-04,1.42247510668564E-04,}
		valueWeights[dataIndex["default_resis_enlace"]] ={2.5,2.5,5,5,5,5,10,15,20,25,2.5,1.66666666666667,.833333333333333,5.26315789473684E-03,5.12091038406828E-03,4.97866287339972E-03,4.83641536273115E-03,4.69416785206259E-03,4.55192034139403E-03,4.40967283072546E-03,4.2674253200569E-03,4.12517780938834E-03,3.98293029871977E-03,3.84068278805121E-03,3.69843527738265E-03,3.55618776671408E-03,3.41394025604552E-03,3.27169274537696E-03,3.12944523470839E-03,2.98719772403983E-03,2.84495021337127E-03,2.7027027027027E-03,2.56045519203414E-03,2.41820768136558E-03,2.27596017069701E-03,2.13371266002845E-03,1.99146514935989E-03,1.84921763869132E-03,1.70697012802276E-03,1.5647226173542E-03,1.42247510668563E-03,1.28022759601707E-03,1.13798008534851E-03,9.95732574679943E-04,8.53485064011381E-04,7.11237553342817E-04,5.68990042674253E-04,4.2674253200569E-04,2.84495021337127E-04,1.42247510668564E-04,}
		
		valueWeights[dataIndex["grow_hp"]] ={5,15,7.5,15,22.5,30,2.5,1.66666666666667,.833333333333333,4.76190476190476E-03,4.64576074332172E-03,4.52961672473868E-03,4.41347270615563E-03,4.29732868757259E-03,4.18118466898955E-03,4.0650406504065E-03,3.94889663182346E-03,3.83275261324042E-03,3.71660859465738E-03,3.60046457607433E-03,3.48432055749129E-03,3.36817653890825E-03,3.2520325203252E-03,3.13588850174216E-03,3.01974448315912E-03,2.90360046457607E-03,2.78745644599303E-03,2.67131242740999E-03,2.55516840882695E-03,2.4390243902439E-03,2.32288037166086E-03,2.20673635307782E-03,2.09059233449477E-03,1.97444831591173E-03,1.85830429732869E-03,1.74216027874565E-03,1.6260162601626E-03,1.50987224157956E-03,1.39372822299652E-03,1.27758420441347E-03,1.16144018583043E-03,1.04529616724739E-03,9.29152148664344E-04,8.13008130081301E-04,6.96864111498259E-04,5.80720092915215E-04,4.64576074332172E-04,3.48432055749129E-04,2.32288037166087E-04,1.16144018583043E-04,}
		valueWeights[dataIndex["grow_mp"]] ={5,15,7.5,15,22.5,30,2.5,1.66666666666667,.833333333333333,4.76190476190476E-03,4.64576074332172E-03,4.52961672473868E-03,4.41347270615563E-03,4.29732868757259E-03,4.18118466898955E-03,4.0650406504065E-03,3.94889663182346E-03,3.83275261324042E-03,3.71660859465738E-03,3.60046457607433E-03,3.48432055749129E-03,3.36817653890825E-03,3.2520325203252E-03,3.13588850174216E-03,3.01974448315912E-03,2.90360046457607E-03,2.78745644599303E-03,2.67131242740999E-03,2.55516840882695E-03,2.4390243902439E-03,2.32288037166086E-03,2.20673635307782E-03,2.09059233449477E-03,1.97444831591173E-03,1.85830429732869E-03,1.74216027874565E-03,1.6260162601626E-03,1.50987224157956E-03,1.39372822299652E-03,1.27758420441347E-03,1.16144018583043E-03,1.04529616724739E-03,9.29152148664344E-04,8.13008130081301E-04,6.96864111498259E-04,5.80720092915215E-04,4.64576074332172E-04,3.48432055749129E-04,2.32288037166087E-04,1.16144018583043E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={75,.004,3.91836734693878E-03,3.83673469387755E-03,3.75510204081633E-03,3.6734693877551E-03,3.59183673469388E-03,3.51020408163265E-03,3.42857142857143E-03,3.3469387755102E-03,3.26530612244898E-03,3.18367346938775E-03,3.10204081632653E-03,3.02040816326531E-03,2.93877551020408E-03,2.85714285714286E-03,2.77551020408163E-03,2.69387755102041E-03,2.61224489795918E-03,2.53061224489796E-03,2.44897959183673E-03,2.36734693877551E-03,2.28571428571429E-03,2.20408163265306E-03,2.12244897959184E-03,2.04081632653061E-03,1.95918367346939E-03,1.87755102040816E-03,1.79591836734694E-03,1.71428571428571E-03,1.63265306122449E-03,1.55102040816327E-03,1.46938775510204E-03,1.38775510204082E-03,1.30612244897959E-03,1.22448979591837E-03,1.14285714285714E-03,1.06122448979592E-03,9.79591836734694E-04,8.97959183673469E-04,8.16326530612245E-04,7.3469387755102E-04,6.53061224489796E-04,5.71428571428572E-04,4.89795918367347E-04,4.08163265306123E-04,3.26530612244898E-04,2.44897959183673E-04,1.63265306122449E-04,8.16326530612248E-05,}
		valueWeights[dataIndex["grow_damage_low"]] ={2.5,2.5,7.5,7.5,5,10,15,20,25,2.5,1.66666666666667,.833333333333333,5.12820512820513E-03,4.99325236167341E-03,4.8582995951417E-03,4.72334682860999E-03,4.58839406207827E-03,4.45344129554656E-03,4.31848852901484E-03,4.18353576248313E-03,4.04858299595142E-03,3.9136302294197E-03,3.77867746288799E-03,3.64372469635628E-03,3.50877192982456E-03,3.37381916329285E-03,3.23886639676113E-03,3.10391363022942E-03,2.96896086369771E-03,2.83400809716599E-03,2.69905533063428E-03,2.56410256410256E-03,2.42914979757085E-03,2.29419703103914E-03,2.15924426450742E-03,2.02429149797571E-03,1.88933873144399E-03,1.75438596491228E-03,1.61943319838057E-03,1.48448043184885E-03,1.34952766531714E-03,1.21457489878542E-03,1.07962213225371E-03,9.44669365721997E-04,8.09716599190284E-04,6.7476383265857E-04,5.39811066126856E-04,4.04858299595142E-04,2.69905533063428E-04,1.34952766531714E-04,}
		valueWeights[dataIndex["grow_damage_high"]] ={2.5,2.5,7.5,7.5,5,10,15,20,25,2.5,1.66666666666667,.833333333333333,5.12820512820513E-03,4.99325236167341E-03,4.8582995951417E-03,4.72334682860999E-03,4.58839406207827E-03,4.45344129554656E-03,4.31848852901484E-03,4.18353576248313E-03,4.04858299595142E-03,3.9136302294197E-03,3.77867746288799E-03,3.64372469635628E-03,3.50877192982456E-03,3.37381916329285E-03,3.23886639676113E-03,3.10391363022942E-03,2.96896086369771E-03,2.83400809716599E-03,2.69905533063428E-03,2.56410256410256E-03,2.42914979757085E-03,2.29419703103914E-03,2.15924426450742E-03,2.02429149797571E-03,1.88933873144399E-03,1.75438596491228E-03,1.61943319838057E-03,1.48448043184885E-03,1.34952766531714E-03,1.21457489878542E-03,1.07962213225371E-03,9.44669365721997E-04,8.09716599190284E-04,6.7476383265857E-04,5.39811066126856E-04,4.04858299595142E-04,2.69905533063428E-04,1.34952766531714E-04,}
		valueWeights[dataIndex["grow_dodge"]] ={75,.004,3.91836734693878E-03,3.83673469387755E-03,3.75510204081633E-03,3.6734693877551E-03,3.59183673469388E-03,3.51020408163265E-03,3.42857142857143E-03,3.3469387755102E-03,3.26530612244898E-03,3.18367346938775E-03,3.10204081632653E-03,3.02040816326531E-03,2.93877551020408E-03,2.85714285714286E-03,2.77551020408163E-03,2.69387755102041E-03,2.61224489795918E-03,2.53061224489796E-03,2.44897959183673E-03,2.36734693877551E-03,2.28571428571429E-03,2.20408163265306E-03,2.12244897959184E-03,2.04081632653061E-03,1.95918367346939E-03,1.87755102040816E-03,1.79591836734694E-03,1.71428571428571E-03,1.63265306122449E-03,1.55102040816327E-03,1.46938775510204E-03,1.38775510204082E-03,1.30612244897959E-03,1.22448979591837E-03,1.14285714285714E-03,1.06122448979592E-03,9.79591836734694E-04,8.97959183673469E-04,8.16326530612245E-04,7.3469387755102E-04,6.53061224489796E-04,5.71428571428572E-04,4.89795918367347E-04,4.08163265306123E-04,3.26530612244898E-04,2.44897959183673E-04,1.63265306122449E-04,8.16326530612248E-05,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={2.5,2.5,5,5,5,5.83333333333333,11.6666666666667,17.5,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,5.26315789473684E-03,5.12091038406828E-03,4.97866287339972E-03,4.83641536273115E-03,4.69416785206259E-03,4.55192034139403E-03,4.40967283072546E-03,4.2674253200569E-03,4.12517780938834E-03,3.98293029871977E-03,3.84068278805121E-03,3.69843527738265E-03,3.55618776671408E-03,3.41394025604552E-03,3.27169274537696E-03,3.12944523470839E-03,2.98719772403983E-03,2.84495021337127E-03,2.7027027027027E-03,2.56045519203414E-03,2.41820768136558E-03,2.27596017069701E-03,2.13371266002845E-03,1.99146514935989E-03,1.84921763869132E-03,1.70697012802276E-03,1.5647226173542E-03,1.42247510668563E-03,1.28022759601707E-03,1.13798008534851E-03,9.95732574679943E-04,8.53485064011381E-04,7.11237553342817E-04,5.68990042674253E-04,4.2674253200569E-04,2.84495021337127E-04,1.42247510668564E-04,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={2.5,2.5,5,5,5,5.83333333333333,11.6666666666667,17.5,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,5.26315789473684E-03,5.12091038406828E-03,4.97866287339972E-03,4.83641536273115E-03,4.69416785206259E-03,4.55192034139403E-03,4.40967283072546E-03,4.2674253200569E-03,4.12517780938834E-03,3.98293029871977E-03,3.84068278805121E-03,3.69843527738265E-03,3.55618776671408E-03,3.41394025604552E-03,3.27169274537696E-03,3.12944523470839E-03,2.98719772403983E-03,2.84495021337127E-03,2.7027027027027E-03,2.56045519203414E-03,2.41820768136558E-03,2.27596017069701E-03,2.13371266002845E-03,1.99146514935989E-03,1.84921763869132E-03,1.70697012802276E-03,1.5647226173542E-03,1.42247510668563E-03,1.28022759601707E-03,1.13798008534851E-03,9.95732574679943E-04,8.53485064011381E-04,7.11237553342817E-04,5.68990042674253E-04,4.2674253200569E-04,2.84495021337127E-04,1.42247510668564E-04,}
		valueWeights[dataIndex["grow_resis_silence"]] ={2.5,2.5,5,5,5,5.83333333333333,11.6666666666667,17.5,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,5.26315789473684E-03,5.12091038406828E-03,4.97866287339972E-03,4.83641536273115E-03,4.69416785206259E-03,4.55192034139403E-03,4.40967283072546E-03,4.2674253200569E-03,4.12517780938834E-03,3.98293029871977E-03,3.84068278805121E-03,3.69843527738265E-03,3.55618776671408E-03,3.41394025604552E-03,3.27169274537696E-03,3.12944523470839E-03,2.98719772403983E-03,2.84495021337127E-03,2.7027027027027E-03,2.56045519203414E-03,2.41820768136558E-03,2.27596017069701E-03,2.13371266002845E-03,1.99146514935989E-03,1.84921763869132E-03,1.70697012802276E-03,1.5647226173542E-03,1.42247510668563E-03,1.28022759601707E-03,1.13798008534851E-03,9.95732574679943E-04,8.53485064011381E-04,7.11237553342817E-04,5.68990042674253E-04,4.2674253200569E-04,2.84495021337127E-04,1.42247510668564E-04,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={2.5,2.5,5,5,5,5.83333333333333,11.6666666666667,17.5,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,5.26315789473684E-03,5.12091038406828E-03,4.97866287339972E-03,4.83641536273115E-03,4.69416785206259E-03,4.55192034139403E-03,4.40967283072546E-03,4.2674253200569E-03,4.12517780938834E-03,3.98293029871977E-03,3.84068278805121E-03,3.69843527738265E-03,3.55618776671408E-03,3.41394025604552E-03,3.27169274537696E-03,3.12944523470839E-03,2.98719772403983E-03,2.84495021337127E-03,2.7027027027027E-03,2.56045519203414E-03,2.41820768136558E-03,2.27596017069701E-03,2.13371266002845E-03,1.99146514935989E-03,1.84921763869132E-03,1.70697012802276E-03,1.5647226173542E-03,1.42247510668563E-03,1.28022759601707E-03,1.13798008534851E-03,9.95732574679943E-04,8.53485064011381E-04,7.11237553342817E-04,5.68990042674253E-04,4.2674253200569E-04,2.84495021337127E-04,1.42247510668564E-04,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={2.5,2.5,5,5,5,5.83333333333333,11.6666666666667,17.5,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,5.26315789473684E-03,5.12091038406828E-03,4.97866287339972E-03,4.83641536273115E-03,4.69416785206259E-03,4.55192034139403E-03,4.40967283072546E-03,4.2674253200569E-03,4.12517780938834E-03,3.98293029871977E-03,3.84068278805121E-03,3.69843527738265E-03,3.55618776671408E-03,3.41394025604552E-03,3.27169274537696E-03,3.12944523470839E-03,2.98719772403983E-03,2.84495021337127E-03,2.7027027027027E-03,2.56045519203414E-03,2.41820768136558E-03,2.27596017069701E-03,2.13371266002845E-03,1.99146514935989E-03,1.84921763869132E-03,1.70697012802276E-03,1.5647226173542E-03,1.42247510668563E-03,1.28022759601707E-03,1.13798008534851E-03,9.95732574679943E-04,8.53485064011381E-04,7.11237553342817E-04,5.68990042674253E-04,4.2674253200569E-04,2.84495021337127E-04,1.42247510668564E-04,}

	---朱雀印 怒兽幡
	elseif tmplID == talismans["GW_15_ZhuQueYin"].tmplID or tmplID == talismans["JL_15_NuShouFan"].tmplID or tmplID == talismans["QJ_15_tianjimu"].tmplID then

		valueWeights[dataIndex["default_hp"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3.75,3.75,3.75,3.75,1.36363636363636,2.72727272727273,4.09090909090909,5.45454545454545,6.81818181818182,8.18181818181818,9.54545454545455,10.9090909090909,12.2727272727273,13.6363636363636,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,6.89655172413793E-03,6.65024630541872E-03,6.40394088669951E-03,6.1576354679803E-03,5.91133004926108E-03,5.66502463054187E-03,5.41871921182266E-03,5.17241379310345E-03,4.92610837438424E-03,4.67980295566502E-03,4.43349753694581E-03,4.1871921182266E-03,3.94088669950739E-03,3.69458128078818E-03,3.44827586206897E-03,3.20197044334975E-03,2.95566502463054E-03,2.70935960591133E-03,2.46305418719212E-03,2.21674876847291E-03,1.97044334975369E-03,1.72413793103448E-03,1.47783251231527E-03,1.23152709359606E-03,9.85221674876848E-04,7.38916256157635E-04,4.92610837438423E-04,2.46305418719212E-04,}
		valueWeights[dataIndex["default_mp"]] ={5,7.5,7.5,7.5,15,22.5,30,3.33333333333333,1.66666666666667,4.76190476190476E-03,4.64576074332172E-03,4.52961672473868E-03,4.41347270615563E-03,4.29732868757259E-03,4.18118466898955E-03,4.0650406504065E-03,3.94889663182346E-03,3.83275261324042E-03,3.71660859465738E-03,3.60046457607433E-03,3.48432055749129E-03,3.36817653890825E-03,3.2520325203252E-03,3.13588850174216E-03,3.01974448315912E-03,2.90360046457607E-03,2.78745644599303E-03,2.67131242740999E-03,2.55516840882695E-03,2.4390243902439E-03,2.32288037166086E-03,2.20673635307782E-03,2.09059233449477E-03,1.97444831591173E-03,1.85830429732869E-03,1.74216027874565E-03,1.6260162601626E-03,1.50987224157956E-03,1.39372822299652E-03,1.27758420441347E-03,1.16144018583043E-03,1.04529616724739E-03,9.29152148664344E-04,8.13008130081301E-04,6.96864111498259E-04,5.80720092915215E-04,4.64576074332172E-04,3.48432055749129E-04,2.32288037166087E-04,1.16144018583043E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={15,25,50,3.33333333333333,1.66666666666667,4.34782608695652E-03,4.2512077294686E-03,4.15458937198068E-03,4.05797101449275E-03,3.96135265700483E-03,3.86473429951691E-03,3.76811594202899E-03,3.67149758454106E-03,3.57487922705314E-03,3.47826086956522E-03,3.3816425120773E-03,3.28502415458937E-03,3.18840579710145E-03,3.09178743961353E-03,2.9951690821256E-03,2.89855072463768E-03,2.80193236714976E-03,2.70531400966184E-03,2.60869565217391E-03,2.51207729468599E-03,2.41545893719807E-03,2.31884057971015E-03,2.22222222222222E-03,2.1256038647343E-03,2.02898550724638E-03,1.93236714975845E-03,1.83574879227053E-03,1.73913043478261E-03,1.64251207729469E-03,1.54589371980676E-03,1.44927536231884E-03,1.35265700483092E-03,.001256038647343,1.15942028985507E-03,1.06280193236715E-03,9.66183574879228E-04,8.69565217391305E-04,7.72946859903382E-04,6.76328502415459E-04,5.79710144927537E-04,4.83091787439614E-04,3.86473429951691E-04,2.89855072463769E-04,1.93236714975846E-04,9.66183574879235E-05,}
		valueWeights[dataIndex["default_damage_low"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["default_damage_high"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["default_dodge"]] ={15,75,3.33333333333333,1.66666666666667,4.25531914893617E-03,4.16281221091582E-03,4.07030527289547E-03,3.97779833487512E-03,3.88529139685476E-03,3.79278445883441E-03,3.70027752081406E-03,3.60777058279371E-03,3.51526364477336E-03,3.42275670675301E-03,3.33024976873266E-03,3.2377428307123E-03,3.14523589269195E-03,3.0527289546716E-03,2.96022201665125E-03,2.8677150786309E-03,2.77520814061055E-03,2.68270120259019E-03,2.59019426456984E-03,2.49768732654949E-03,2.40518038852914E-03,2.31267345050879E-03,2.22016651248844E-03,2.12765957446809E-03,2.03515263644773E-03,1.94264569842738E-03,1.85013876040703E-03,1.75763182238668E-03,1.66512488436633E-03,1.57261794634598E-03,1.48011100832562E-03,1.38760407030527E-03,1.29509713228492E-03,1.20259019426457E-03,1.11008325624422E-03,1.01757631822387E-03,9.25069380203515E-04,8.32562442183164E-04,7.40055504162812E-04,6.47548566142461E-04,5.55041628122109E-04,4.62534690101757E-04,3.70027752081406E-04,2.77520814061055E-04,1.85013876040703E-04,9.25069380203515E-05,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		valueWeights[dataIndex["default_resis_sleep"]] ={1.25,1.25,1.25,1.25,2.5,2.5,2.5,2.5,2.5,2.5,1.36363636363636,2.72727272727273,4.09090909090909,5.45454545454545,6.81818181818182,8.18181818181818,9.54545454545455,10.9090909090909,12.2727272727273,13.6363636363636,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["default_resis_silence"]] ={2.5,2.5,3.75,3.75,3.75,3.75,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,2.5,1.66666666666667,.833333333333333,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["default_resis_weakness"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["default_resis_enlace"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		
		valueWeights[dataIndex["grow_hp"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3.75,3.75,3.75,3.75,1.36363636363636,2.72727272727273,4.09090909090909,5.45454545454545,6.81818181818182,8.18181818181818,9.54545454545455,10.9090909090909,12.2727272727273,13.6363636363636,2,1.5,1,.5,6.66666666666667E-03,6.4367816091954E-03,6.20689655172414E-03,5.97701149425287E-03,5.74712643678161E-03,5.51724137931035E-03,5.28735632183908E-03,5.05747126436782E-03,4.82758620689655E-03,4.59770114942529E-03,4.36781609195402E-03,4.13793103448276E-03,3.90804597701149E-03,3.67816091954023E-03,3.44827586206897E-03,3.2183908045977E-03,2.98850574712644E-03,2.75862068965517E-03,2.52873563218391E-03,2.29885057471264E-03,2.06896551724138E-03,1.83908045977012E-03,1.60919540229885E-03,1.37931034482759E-03,1.14942528735632E-03,9.19540229885057E-04,6.89655172413793E-04,4.59770114942529E-04,2.29885057471264E-04,}
		valueWeights[dataIndex["grow_mp"]] ={5,7.5,7.5,7.5,15,22.5,30,3.33333333333333,1.66666666666667,4.76190476190476E-03,4.64576074332172E-03,4.52961672473868E-03,4.41347270615563E-03,4.29732868757259E-03,4.18118466898955E-03,4.0650406504065E-03,3.94889663182346E-03,3.83275261324042E-03,3.71660859465738E-03,3.60046457607433E-03,3.48432055749129E-03,3.36817653890825E-03,3.2520325203252E-03,3.13588850174216E-03,3.01974448315912E-03,2.90360046457607E-03,2.78745644599303E-03,2.67131242740999E-03,2.55516840882695E-03,2.4390243902439E-03,2.32288037166086E-03,2.20673635307782E-03,2.09059233449477E-03,1.97444831591173E-03,1.85830429732869E-03,1.74216027874565E-03,1.6260162601626E-03,1.50987224157956E-03,1.39372822299652E-03,1.27758420441347E-03,1.16144018583043E-03,1.04529616724739E-03,9.29152148664344E-04,8.13008130081301E-04,6.96864111498259E-04,5.80720092915215E-04,4.64576074332172E-04,3.48432055749129E-04,2.32288037166087E-04,1.16144018583043E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={15,25,50,3.33333333333333,1.66666666666667,4.34782608695652E-03,4.2512077294686E-03,4.15458937198068E-03,4.05797101449275E-03,3.96135265700483E-03,3.86473429951691E-03,3.76811594202899E-03,3.67149758454106E-03,3.57487922705314E-03,3.47826086956522E-03,3.3816425120773E-03,3.28502415458937E-03,3.18840579710145E-03,3.09178743961353E-03,2.9951690821256E-03,2.89855072463768E-03,2.80193236714976E-03,2.70531400966184E-03,2.60869565217391E-03,2.51207729468599E-03,2.41545893719807E-03,2.31884057971015E-03,2.22222222222222E-03,2.1256038647343E-03,2.02898550724638E-03,1.93236714975845E-03,1.83574879227053E-03,1.73913043478261E-03,1.64251207729469E-03,1.54589371980676E-03,1.44927536231884E-03,1.35265700483092E-03,.001256038647343,1.15942028985507E-03,1.06280193236715E-03,9.66183574879228E-04,8.69565217391305E-04,7.72946859903382E-04,6.76328502415459E-04,5.79710144927537E-04,4.83091787439614E-04,3.86473429951691E-04,2.89855072463769E-04,1.93236714975846E-04,9.66183574879235E-05,}
		valueWeights[dataIndex["grow_damage_low"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,6.66666666666667E-03,6.4367816091954E-03,6.20689655172414E-03,5.97701149425287E-03,5.74712643678161E-03,5.51724137931035E-03,5.28735632183908E-03,5.05747126436782E-03,4.82758620689655E-03,4.59770114942529E-03,4.36781609195402E-03,4.13793103448276E-03,3.90804597701149E-03,3.67816091954023E-03,3.44827586206897E-03,3.2183908045977E-03,2.98850574712644E-03,2.75862068965517E-03,2.52873563218391E-03,2.29885057471264E-03,2.06896551724138E-03,1.83908045977012E-03,1.60919540229885E-03,1.37931034482759E-03,1.14942528735632E-03,9.19540229885057E-04,6.89655172413793E-04,4.59770114942529E-04,2.29885057471264E-04,}
		valueWeights[dataIndex["grow_damage_high"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,6.66666666666667E-03,6.4367816091954E-03,6.20689655172414E-03,5.97701149425287E-03,5.74712643678161E-03,5.51724137931035E-03,5.28735632183908E-03,5.05747126436782E-03,4.82758620689655E-03,4.59770114942529E-03,4.36781609195402E-03,4.13793103448276E-03,3.90804597701149E-03,3.67816091954023E-03,3.44827586206897E-03,3.2183908045977E-03,2.98850574712644E-03,2.75862068965517E-03,2.52873563218391E-03,2.29885057471264E-03,2.06896551724138E-03,1.83908045977012E-03,1.60919540229885E-03,1.37931034482759E-03,1.14942528735632E-03,9.19540229885057E-04,6.89655172413793E-04,4.59770114942529E-04,2.29885057471264E-04,}
		valueWeights[dataIndex["grow_dodge"]] ={15,75,3.33333333333333,1.66666666666667,4.25531914893617E-03,4.16281221091582E-03,4.07030527289547E-03,3.97779833487512E-03,3.88529139685476E-03,3.79278445883441E-03,3.70027752081406E-03,3.60777058279371E-03,3.51526364477336E-03,3.42275670675301E-03,3.33024976873266E-03,3.2377428307123E-03,3.14523589269195E-03,3.0527289546716E-03,2.96022201665125E-03,2.8677150786309E-03,2.77520814061055E-03,2.68270120259019E-03,2.59019426456984E-03,2.49768732654949E-03,2.40518038852914E-03,2.31267345050879E-03,2.22016651248844E-03,2.12765957446809E-03,2.03515263644773E-03,1.94264569842738E-03,1.85013876040703E-03,1.75763182238668E-03,1.66512488436633E-03,1.57261794634598E-03,1.48011100832562E-03,1.38760407030527E-03,1.29509713228492E-03,1.20259019426457E-03,1.11008325624422E-03,1.01757631822387E-03,9.25069380203515E-04,8.32562442183164E-04,7.40055504162812E-04,6.47548566142461E-04,5.55041628122109E-04,4.62534690101757E-04,3.70027752081406E-04,2.77520814061055E-04,1.85013876040703E-04,9.25069380203515E-05,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={3.33333333333333,3.33333333333333,3.33333333333333,7,7,7,7,7,1.38888888888889,2.77777777777778,4.16666666666667,5.55555555555556,6.94444444444444,8.33333333333333,9.72222222222222,11.1111111111111,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={2.5,2.5,2.5,2.5,5.83333333333333,5.83333333333333,5.83333333333333,5.83333333333333,5.83333333333333,5.83333333333333,.909090909090909,1.81818181818182,2.72727272727273,3.63636363636364,4.54545454545455,5.45454545454545,6.36363636363636,7.27272727272727,8.18181818181818,9.09090909090909,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["grow_resis_silence"]] ={5,5,8.75,8.75,8.75,8.75,2.38095238095238,4.76190476190476,7.14285714285714,9.52380952380952,11.9047619047619,14.2857142857143,2.5,1.66666666666667,.833333333333333,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={3.33333333333333,3.33333333333333,3.33333333333333,7,7,7,7,7,1.38888888888889,2.77777777777778,4.16666666666667,5.55555555555556,6.94444444444444,8.33333333333333,9.72222222222222,11.1111111111111,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={3.33333333333333,3.33333333333333,3.33333333333333,7,7,7,7,7,1.38888888888889,2.77777777777778,4.16666666666667,5.55555555555556,6.94444444444444,8.33333333333333,9.72222222222222,11.1111111111111,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}

	---慑心铃 七杀
	elseif tmplID == talismans["HH_15_SheXinLing"].tmplID or tmplID == talismans["HG_15_QiSha"].tmplID or tmplID == talismans["YZ_15_lveying"].tmplID then
		
		valueWeights[dataIndex["default_hp"]] ={1.66666666666667,1.66666666666667,1.66666666666667,5,5,5,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,6.06060606060606E-03,5.87121212121212E-03,5.68181818181818E-03,5.49242424242424E-03,5.3030303030303E-03,5.11363636363636E-03,4.92424242424242E-03,4.73484848484849E-03,4.54545454545455E-03,4.35606060606061E-03,4.16666666666667E-03,3.97727272727273E-03,3.78787878787879E-03,3.59848484848485E-03,3.40909090909091E-03,3.21969696969697E-03,3.03030303030303E-03,2.84090909090909E-03,2.65151515151515E-03,2.46212121212121E-03,2.27272727272727E-03,2.08333333333333E-03,1.89393939393939E-03,1.70454545454545E-03,1.51515151515152E-03,1.32575757575758E-03,1.13636363636364E-03,9.46969696969697E-04,7.57575757575757E-04,5.68181818181818E-04,3.78787878787879E-04,1.8939393939394E-04,}
		valueWeights[dataIndex["default_mp"]] ={5,7.5,7.5,7.5,15,22.5,30,3.33333333333333,1.66666666666667,4.76190476190476E-03,4.64576074332172E-03,4.52961672473868E-03,4.41347270615563E-03,4.29732868757259E-03,4.18118466898955E-03,4.0650406504065E-03,3.94889663182346E-03,3.83275261324042E-03,3.71660859465738E-03,3.60046457607433E-03,3.48432055749129E-03,3.36817653890825E-03,3.2520325203252E-03,3.13588850174216E-03,3.01974448315912E-03,2.90360046457607E-03,2.78745644599303E-03,2.67131242740999E-03,2.55516840882695E-03,2.4390243902439E-03,2.32288037166086E-03,2.20673635307782E-03,2.09059233449477E-03,1.97444831591173E-03,1.85830429732869E-03,1.74216027874565E-03,1.6260162601626E-03,1.50987224157956E-03,1.39372822299652E-03,1.27758420441347E-03,1.16144018583043E-03,1.04529616724739E-03,9.29152148664344E-04,8.13008130081301E-04,6.96864111498259E-04,5.80720092915215E-04,4.64576074332172E-04,3.48432055749129E-04,2.32288037166087E-04,1.16144018583043E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={2.5,2.5,5,5,5,5,10,15,20,25,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["default_damage_low"]] ={1.25,1.25,1.25,1.25,3,3,3,3,3,1.66666666666667,3.33333333333333,5,6.66666666666667,8.33333333333333,10,11.6666666666667,13.3333333333333,15,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		valueWeights[dataIndex["default_damage_high"]] ={1.25,1.25,1.25,1.25,3,3,3,3,3,1.66666666666667,3.33333333333333,5,6.66666666666667,8.33333333333333,10,11.6666666666667,13.3333333333333,15,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		valueWeights[dataIndex["default_dodge"]] ={2.5,2.5,5,5,5,5,10,15,20,25,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["default_resis_sleep"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["default_resis_silence"]] ={2.5,2.5,3.75,3.75,3.75,3.75,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,2.5,1.66666666666667,.833333333333333,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["default_resis_weakness"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		valueWeights[dataIndex["default_resis_enlace"]] ={1.25,1.25,1.25,1.25,2.5,2.5,2.5,2.5,2.5,2.5,1.36363636363636,2.72727272727273,4.09090909090909,5.45454545454545,6.81818181818182,8.18181818181818,9.54545454545455,10.9090909090909,12.2727272727273,13.6363636363636,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		
		valueWeights[dataIndex["grow_hp"]] ={1.66666666666667,1.66666666666667,1.66666666666667,5,5,5,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,6.06060606060606E-03,5.87121212121212E-03,5.68181818181818E-03,5.49242424242424E-03,5.3030303030303E-03,5.11363636363636E-03,4.92424242424242E-03,4.73484848484849E-03,4.54545454545455E-03,4.35606060606061E-03,4.16666666666667E-03,3.97727272727273E-03,3.78787878787879E-03,3.59848484848485E-03,3.40909090909091E-03,3.21969696969697E-03,3.03030303030303E-03,2.84090909090909E-03,2.65151515151515E-03,2.46212121212121E-03,2.27272727272727E-03,2.08333333333333E-03,1.89393939393939E-03,1.70454545454545E-03,1.51515151515152E-03,1.32575757575758E-03,1.13636363636364E-03,9.46969696969697E-04,7.57575757575757E-04,5.68181818181818E-04,3.78787878787879E-04,1.8939393939394E-04,}
		valueWeights[dataIndex["grow_mp"]] ={5,7.5,7.5,7.5,15,22.5,30,3.33333333333333,1.66666666666667,4.76190476190476E-03,4.64576074332172E-03,4.52961672473868E-03,4.41347270615563E-03,4.29732868757259E-03,4.18118466898955E-03,4.0650406504065E-03,3.94889663182346E-03,3.83275261324042E-03,3.71660859465738E-03,3.60046457607433E-03,3.48432055749129E-03,3.36817653890825E-03,3.2520325203252E-03,3.13588850174216E-03,3.01974448315912E-03,2.90360046457607E-03,2.78745644599303E-03,2.67131242740999E-03,2.55516840882695E-03,2.4390243902439E-03,2.32288037166086E-03,2.20673635307782E-03,2.09059233449477E-03,1.97444831591173E-03,1.85830429732869E-03,1.74216027874565E-03,1.6260162601626E-03,1.50987224157956E-03,1.39372822299652E-03,1.27758420441347E-03,1.16144018583043E-03,1.04529616724739E-03,9.29152148664344E-04,8.13008130081301E-04,6.96864111498259E-04,5.80720092915215E-04,4.64576074332172E-04,3.48432055749129E-04,2.32288037166087E-04,1.16144018583043E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={2.5,2.5,5,5,5,5,10,15,20,25,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["grow_damage_low"]] ={.75,.75,.75,.75,3,3,3,3,3,1.36363636363636,2.72727272727273,4.09090909090909,5.45454545454545,6.81818181818182,8.18181818181818,9.54545454545455,10.9090909090909,12.2727272727273,13.6363636363636,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.40740740740741E-03,7.12250712250712E-03,6.83760683760684E-03,6.55270655270655E-03,6.26780626780627E-03,5.98290598290598E-03,5.6980056980057E-03,5.41310541310541E-03,5.12820512820513E-03,4.84330484330484E-03,4.55840455840456E-03,4.27350427350427E-03,3.98860398860399E-03,3.7037037037037E-03,3.41880341880342E-03,3.13390313390313E-03,2.84900284900285E-03,2.56410256410256E-03,2.27920227920228E-03,1.99430199430199E-03,1.70940170940171E-03,1.42450142450143E-03,1.13960113960114E-03,8.54700854700855E-04,5.6980056980057E-04,2.84900284900285E-04,}
		valueWeights[dataIndex["grow_damage_high"]] ={.75,.75,.75,.75,3,3,3,3,3,1.36363636363636,2.72727272727273,4.09090909090909,5.45454545454545,6.81818181818182,8.18181818181818,9.54545454545455,10.9090909090909,12.2727272727273,13.6363636363636,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.40740740740741E-03,7.12250712250712E-03,6.83760683760684E-03,6.55270655270655E-03,6.26780626780627E-03,5.98290598290598E-03,5.6980056980057E-03,5.41310541310541E-03,5.12820512820513E-03,4.84330484330484E-03,4.55840455840456E-03,4.27350427350427E-03,3.98860398860399E-03,3.7037037037037E-03,3.41880341880342E-03,3.13390313390313E-03,2.84900284900285E-03,2.56410256410256E-03,2.27920227920228E-03,1.99430199430199E-03,1.70940170940171E-03,1.42450142450143E-03,1.13960113960114E-03,8.54700854700855E-04,5.6980056980057E-04,2.84900284900285E-04,}
		valueWeights[dataIndex["grow_dodge"]] ={2.5,2.5,5,5,5,5,10,15,20,25,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={3.33333333333333,3.33333333333333,3.33333333333333,7,7,7,7,7,1.38888888888889,2.77777777777778,4.16666666666667,5.55555555555556,6.94444444444444,8.33333333333333,9.72222222222222,11.1111111111111,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={3.33333333333333,3.33333333333333,3.33333333333333,7,7,7,7,7,1.38888888888889,2.77777777777778,4.16666666666667,5.55555555555556,6.94444444444444,8.33333333333333,9.72222222222222,11.1111111111111,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["grow_resis_silence"]] ={5,5,8.75,8.75,8.75,8.75,2.38095238095238,4.76190476190476,7.14285714285714,9.52380952380952,11.9047619047619,14.2857142857143,2.5,1.66666666666667,.833333333333333,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={3.33333333333333,3.33333333333333,3.33333333333333,7,7,7,7,7,1.38888888888889,2.77777777777778,4.16666666666667,5.55555555555556,6.94444444444444,8.33333333333333,9.72222222222222,11.1111111111111,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={2.5,2.5,2.5,2.5,5.83333333333333,5.83333333333333,5.83333333333333,5.83333333333333,5.83333333333333,5.83333333333333,.909090909090909,1.81818181818182,2.72727272727273,3.63636363636364,4.54545454545455,5.45454545454545,6.36363636363636,7.27272727272727,8.18181818181818,9.09090909090909,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}

	---六合镜 九音螺
	elseif tmplID == talismans["QY_15_LiuHeJing"].tmplID or tmplID == talismans["TH_15_JiuYinLuo"].tmplID then

		valueWeights[dataIndex["default_hp"]] ={5,7.5,7.5,7.5,15,22.5,30,3.33333333333333,1.66666666666667,4.76190476190476E-03,4.64576074332172E-03,4.52961672473868E-03,4.41347270615563E-03,4.29732868757259E-03,4.18118466898955E-03,4.0650406504065E-03,3.94889663182346E-03,3.83275261324042E-03,3.71660859465738E-03,3.60046457607433E-03,3.48432055749129E-03,3.36817653890825E-03,3.2520325203252E-03,3.13588850174216E-03,3.01974448315912E-03,2.90360046457607E-03,2.78745644599303E-03,2.67131242740999E-03,2.55516840882695E-03,2.4390243902439E-03,2.32288037166086E-03,2.20673635307782E-03,2.09059233449477E-03,1.97444831591173E-03,1.85830429732869E-03,1.74216027874565E-03,1.6260162601626E-03,1.50987224157956E-03,1.39372822299652E-03,1.27758420441347E-03,1.16144018583043E-03,1.04529616724739E-03,9.29152148664344E-04,8.13008130081301E-04,6.96864111498259E-04,5.80720092915215E-04,4.64576074332172E-04,3.48432055749129E-04,2.32288037166087E-04,1.16144018583043E-04,}
		valueWeights[dataIndex["default_mp"]] ={2.5,2.5,5,5,5,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,2.5,1.66666666666667,.833333333333333,5.40540540540541E-03,5.25525525525526E-03,5.10510510510511E-03,4.95495495495496E-03,4.80480480480481E-03,4.65465465465465E-03,4.5045045045045E-03,4.35435435435435E-03,4.2042042042042E-03,4.05405405405405E-03,3.9039039039039E-03,3.75375375375375E-03,3.6036036036036E-03,3.45345345345345E-03,3.3033033033033E-03,3.15315315315315E-03,.003003003003003,2.85285285285285E-03,2.7027027027027E-03,2.55255255255255E-03,2.4024024024024E-03,2.25225225225225E-03,2.1021021021021E-03,1.95195195195195E-03,1.8018018018018E-03,1.65165165165165E-03,1.5015015015015E-03,1.35135135135135E-03,1.2012012012012E-03,1.05105105105105E-03,9.009009009009E-04,7.5075075075075E-04,6.006006006006E-04,4.5045045045045E-04,3.003003003003E-04,1.5015015015015E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={15,25,50,3.33333333333333,1.66666666666667,4.34782608695652E-03,4.2512077294686E-03,4.15458937198068E-03,4.05797101449275E-03,3.96135265700483E-03,3.86473429951691E-03,3.76811594202899E-03,3.67149758454106E-03,3.57487922705314E-03,3.47826086956522E-03,3.3816425120773E-03,3.28502415458937E-03,3.18840579710145E-03,3.09178743961353E-03,2.9951690821256E-03,2.89855072463768E-03,2.80193236714976E-03,2.70531400966184E-03,2.60869565217391E-03,2.51207729468599E-03,2.41545893719807E-03,2.31884057971015E-03,2.22222222222222E-03,2.1256038647343E-03,2.02898550724638E-03,1.93236714975845E-03,1.83574879227053E-03,1.73913043478261E-03,1.64251207729469E-03,1.54589371980676E-03,1.44927536231884E-03,1.35265700483092E-03,.001256038647343,1.15942028985507E-03,1.06280193236715E-03,9.66183574879228E-04,8.69565217391305E-04,7.72946859903382E-04,6.76328502415459E-04,5.79710144927537E-04,4.83091787439614E-04,3.86473429951691E-04,2.89855072463769E-04,1.93236714975846E-04,9.66183574879235E-05,}
		valueWeights[dataIndex["default_damage_low"]] ={1.25,1.25,1.25,1.25,2.5,2.5,2.5,2.5,2.5,2.5,1.66666666666667,3.33333333333333,5,6.66666666666667,8.33333333333333,10,11.6666666666667,13.3333333333333,15,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["default_damage_high"]] ={1.25,1.25,1.25,1.25,2.5,2.5,2.5,2.5,2.5,2.5,1.66666666666667,3.33333333333333,5,6.66666666666667,8.33333333333333,10,11.6666666666667,13.3333333333333,15,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["default_dodge"]] ={15,75,3.33333333333333,1.66666666666667,4.25531914893617E-03,4.16281221091582E-03,4.07030527289547E-03,3.97779833487512E-03,3.88529139685476E-03,3.79278445883441E-03,3.70027752081406E-03,3.60777058279371E-03,3.51526364477336E-03,3.42275670675301E-03,3.33024976873266E-03,3.2377428307123E-03,3.14523589269195E-03,3.0527289546716E-03,2.96022201665125E-03,2.8677150786309E-03,2.77520814061055E-03,2.68270120259019E-03,2.59019426456984E-03,2.49768732654949E-03,2.40518038852914E-03,2.31267345050879E-03,2.22016651248844E-03,2.12765957446809E-03,2.03515263644773E-03,1.94264569842738E-03,1.85013876040703E-03,1.75763182238668E-03,1.66512488436633E-03,1.57261794634598E-03,1.48011100832562E-03,1.38760407030527E-03,1.29509713228492E-03,1.20259019426457E-03,1.11008325624422E-03,1.01757631822387E-03,9.25069380203515E-04,8.32562442183164E-04,7.40055504162812E-04,6.47548566142461E-04,5.55041628122109E-04,4.62534690101757E-04,3.70027752081406E-04,2.77520814061055E-04,1.85013876040703E-04,9.25069380203515E-05,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={1.25,1.25,1.25,1.25,2.5,2.5,2.5,2.5,2.5,2.5,1.36363636363636,2.72727272727273,4.09090909090909,5.45454545454545,6.81818181818182,8.18181818181818,9.54545454545455,10.9090909090909,12.2727272727273,13.6363636363636,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["default_resis_sleep"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["default_resis_silence"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,5,5.88235294117647E-03,5.70409982174688E-03,5.52584670231729E-03,5.3475935828877E-03,5.16934046345811E-03,4.99108734402852E-03,4.81283422459893E-03,4.63458110516934E-03,4.45632798573975E-03,4.27807486631016E-03,4.09982174688057E-03,3.92156862745098E-03,3.74331550802139E-03,3.5650623885918E-03,3.38680926916221E-03,3.20855614973262E-03,3.03030303030303E-03,2.85204991087344E-03,2.67379679144385E-03,2.49554367201426E-03,2.31729055258467E-03,2.13903743315508E-03,1.96078431372549E-03,1.7825311942959E-03,1.60427807486631E-03,1.42602495543672E-03,1.24777183600713E-03,1.06951871657754E-03,8.9126559714795E-04,7.1301247771836E-04,5.3475935828877E-04,3.5650623885918E-04,1.7825311942959E-04,}
		valueWeights[dataIndex["default_resis_weakness"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		valueWeights[dataIndex["default_resis_enlace"]] ={2.5,2.5,3.75,3.75,3.75,3.75,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,6.06060606060606E-03,5.87121212121212E-03,5.68181818181818E-03,5.49242424242424E-03,5.3030303030303E-03,5.11363636363636E-03,4.92424242424242E-03,4.73484848484849E-03,4.54545454545455E-03,4.35606060606061E-03,4.16666666666667E-03,3.97727272727273E-03,3.78787878787879E-03,3.59848484848485E-03,3.40909090909091E-03,3.21969696969697E-03,3.03030303030303E-03,2.84090909090909E-03,2.65151515151515E-03,2.46212121212121E-03,2.27272727272727E-03,2.08333333333333E-03,1.89393939393939E-03,1.70454545454545E-03,1.51515151515152E-03,1.32575757575758E-03,1.13636363636364E-03,9.46969696969697E-04,7.57575757575757E-04,5.68181818181818E-04,3.78787878787879E-04,1.8939393939394E-04,}
		
		valueWeights[dataIndex["grow_hp"]] ={5,7.5,7.5,7.5,15,22.5,30,3.33333333333333,1.66666666666667,4.76190476190476E-03,4.64576074332172E-03,4.52961672473868E-03,4.41347270615563E-03,4.29732868757259E-03,4.18118466898955E-03,4.0650406504065E-03,3.94889663182346E-03,3.83275261324042E-03,3.71660859465738E-03,3.60046457607433E-03,3.48432055749129E-03,3.36817653890825E-03,3.2520325203252E-03,3.13588850174216E-03,3.01974448315912E-03,2.90360046457607E-03,2.78745644599303E-03,2.67131242740999E-03,2.55516840882695E-03,2.4390243902439E-03,2.32288037166086E-03,2.20673635307782E-03,2.09059233449477E-03,1.97444831591173E-03,1.85830429732869E-03,1.74216027874565E-03,1.6260162601626E-03,1.50987224157956E-03,1.39372822299652E-03,1.27758420441347E-03,1.16144018583043E-03,1.04529616724739E-03,9.29152148664344E-04,8.13008130081301E-04,6.96864111498259E-04,5.80720092915215E-04,4.64576074332172E-04,3.48432055749129E-04,2.32288037166087E-04,1.16144018583043E-04,}
		valueWeights[dataIndex["grow_mp"]] ={2.5,2.5,5,5,5,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,2.5,1.66666666666667,.833333333333333,5.40540540540541E-03,5.25525525525526E-03,5.10510510510511E-03,4.95495495495496E-03,4.80480480480481E-03,4.65465465465465E-03,4.5045045045045E-03,4.35435435435435E-03,4.2042042042042E-03,4.05405405405405E-03,3.9039039039039E-03,3.75375375375375E-03,3.6036036036036E-03,3.45345345345345E-03,3.3033033033033E-03,3.15315315315315E-03,.003003003003003,2.85285285285285E-03,2.7027027027027E-03,2.55255255255255E-03,2.4024024024024E-03,2.25225225225225E-03,2.1021021021021E-03,1.95195195195195E-03,1.8018018018018E-03,1.65165165165165E-03,1.5015015015015E-03,1.35135135135135E-03,1.2012012012012E-03,1.05105105105105E-03,9.009009009009E-04,7.5075075075075E-04,6.006006006006E-04,4.5045045045045E-04,3.003003003003E-04,1.5015015015015E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={15,25,50,3.33333333333333,1.66666666666667,4.34782608695652E-03,4.2512077294686E-03,4.15458937198068E-03,4.05797101449275E-03,3.96135265700483E-03,3.86473429951691E-03,3.76811594202899E-03,3.67149758454106E-03,3.57487922705314E-03,3.47826086956522E-03,3.3816425120773E-03,3.28502415458937E-03,3.18840579710145E-03,3.09178743961353E-03,2.9951690821256E-03,2.89855072463768E-03,2.80193236714976E-03,2.70531400966184E-03,2.60869565217391E-03,2.51207729468599E-03,2.41545893719807E-03,2.31884057971015E-03,2.22222222222222E-03,2.1256038647343E-03,2.02898550724638E-03,1.93236714975845E-03,1.83574879227053E-03,1.73913043478261E-03,1.64251207729469E-03,1.54589371980676E-03,1.44927536231884E-03,1.35265700483092E-03,.001256038647343,1.15942028985507E-03,1.06280193236715E-03,9.66183574879228E-04,8.69565217391305E-04,7.72946859903382E-04,6.76328502415459E-04,5.79710144927537E-04,4.83091787439614E-04,3.86473429951691E-04,2.89855072463769E-04,1.93236714975846E-04,9.66183574879235E-05,}
		valueWeights[dataIndex["grow_damage_low"]] ={.75,.75,.75,.75,2.5,2.5,2.5,2.5,2.5,2.5,1.36363636363636,2.72727272727273,4.09090909090909,5.45454545454545,6.81818181818182,8.18181818181818,9.54545454545455,10.9090909090909,12.2727272727273,13.6363636363636,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["grow_damage_high"]] ={.75,.75,.75,.75,2.5,2.5,2.5,2.5,2.5,2.5,1.36363636363636,2.72727272727273,4.09090909090909,5.45454545454545,6.81818181818182,8.18181818181818,9.54545454545455,10.9090909090909,12.2727272727273,13.6363636363636,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["grow_dodge"]] ={15,75,3.33333333333333,1.66666666666667,4.25531914893617E-03,4.16281221091582E-03,4.07030527289547E-03,3.97779833487512E-03,3.88529139685476E-03,3.79278445883441E-03,3.70027752081406E-03,3.60777058279371E-03,3.51526364477336E-03,3.42275670675301E-03,3.33024976873266E-03,3.2377428307123E-03,3.14523589269195E-03,3.0527289546716E-03,2.96022201665125E-03,2.8677150786309E-03,2.77520814061055E-03,2.68270120259019E-03,2.59019426456984E-03,2.49768732654949E-03,2.40518038852914E-03,2.31267345050879E-03,2.22016651248844E-03,2.12765957446809E-03,2.03515263644773E-03,1.94264569842738E-03,1.85013876040703E-03,1.75763182238668E-03,1.66512488436633E-03,1.57261794634598E-03,1.48011100832562E-03,1.38760407030527E-03,1.29509713228492E-03,1.20259019426457E-03,1.11008325624422E-03,1.01757631822387E-03,9.25069380203515E-04,8.32562442183164E-04,7.40055504162812E-04,6.47548566142461E-04,5.55041628122109E-04,4.62534690101757E-04,3.70027752081406E-04,2.77520814061055E-04,1.85013876040703E-04,9.25069380203515E-05,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={2.5,2.5,2.5,2.5,5.83333333333333,5.83333333333333,5.83333333333333,5.83333333333333,5.83333333333333,5.83333333333333,.909090909090909,1.81818181818182,2.72727272727273,3.63636363636364,4.54545454545455,5.45454545454545,6.36363636363636,7.27272727272727,8.18181818181818,9.09090909090909,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={3.33333333333333,3.33333333333333,3.33333333333333,7,7,7,7,7,1.38888888888889,2.77777777777778,4.16666666666667,5.55555555555556,6.94444444444444,8.33333333333333,9.72222222222222,11.1111111111111,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["grow_resis_silence"]] ={3.33333333333333,3.33333333333333,3.33333333333333,7,7,7,7,7,1.38888888888889,2.77777777777778,4.16666666666667,5.55555555555556,6.94444444444444,8.33333333333333,9.72222222222222,11.1111111111111,5,5.88235294117647E-03,5.70409982174688E-03,5.52584670231729E-03,5.3475935828877E-03,5.16934046345811E-03,4.99108734402852E-03,4.81283422459893E-03,4.63458110516934E-03,4.45632798573975E-03,4.27807486631016E-03,4.09982174688057E-03,3.92156862745098E-03,3.74331550802139E-03,3.5650623885918E-03,3.38680926916221E-03,3.20855614973262E-03,3.03030303030303E-03,2.85204991087344E-03,2.67379679144385E-03,2.49554367201426E-03,2.31729055258467E-03,2.13903743315508E-03,1.96078431372549E-03,1.7825311942959E-03,1.60427807486631E-03,1.42602495543672E-03,1.24777183600713E-03,1.06951871657754E-03,8.9126559714795E-04,7.1301247771836E-04,5.3475935828877E-04,3.5650623885918E-04,1.7825311942959E-04,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={3.33333333333333,3.33333333333333,3.33333333333333,7,7,7,7,7,1.38888888888889,2.77777777777778,4.16666666666667,5.55555555555556,6.94444444444444,8.33333333333333,9.72222222222222,11.1111111111111,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={5,5,8.75,8.75,8.75,8.75,2.38095238095238,4.76190476190476,7.14285714285714,9.52380952380952,11.9047619047619,14.2857142857143,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,6.06060606060606E-03,5.87121212121212E-03,5.68181818181818E-03,5.49242424242424E-03,5.3030303030303E-03,5.11363636363636E-03,4.92424242424242E-03,4.73484848484849E-03,4.54545454545455E-03,4.35606060606061E-03,4.16666666666667E-03,3.97727272727273E-03,3.78787878787879E-03,3.59848484848485E-03,3.40909090909091E-03,3.21969696969697E-03,3.03030303030303E-03,2.84090909090909E-03,2.65151515151515E-03,2.46212121212121E-03,2.27272727272727E-03,2.08333333333333E-03,1.89393939393939E-03,1.70454545454545E-03,1.51515151515152E-03,1.32575757575758E-03,1.13636363636364E-03,9.46969696969697E-04,7.57575757575757E-04,5.68181818181818E-04,3.78787878787879E-04,1.8939393939394E-04,}

	---轮回珠 丹朱 率兜旗
	elseif tmplID == talismans["TY_15_LunHuiZhu"].tmplID or tmplID == talismans["LS_15_DanZhu"].tmplID or tmplID == talismans["CH_15_lvdouqi"].tmplID then
			
		valueWeights[dataIndex["default_hp"]] ={5,5,5,5,7.5,15,22.5,30,3.33333333333333,1.66666666666667,4.87804878048781E-03,4.75609756097561E-03,4.63414634146342E-03,4.51219512195122E-03,4.39024390243902E-03,4.26829268292683E-03,4.14634146341464E-03,4.02439024390244E-03,3.90243902439024E-03,3.78048780487805E-03,3.65853658536585E-03,3.53658536585366E-03,3.41463414634146E-03,3.29268292682927E-03,3.17073170731707E-03,3.04878048780488E-03,2.92682926829268E-03,2.80487804878049E-03,2.68292682926829E-03,2.5609756097561E-03,2.4390243902439E-03,2.31707317073171E-03,2.19512195121951E-03,2.07317073170732E-03,1.95121951219512E-03,1.82926829268293E-03,1.70731707317073E-03,1.58536585365854E-03,1.46341463414634E-03,1.34146341463415E-03,1.21951219512195E-03,1.09756097560976E-03,9.75609756097561E-04,8.53658536585367E-04,7.31707317073171E-04,6.09756097560976E-04,4.87804878048781E-04,3.65853658536586E-04,2.4390243902439E-04,1.21951219512195E-04,}
		valueWeights[dataIndex["default_mp"]] ={2.5,2.5,5,5,5,5,10,15,20,25,2,1.5,1,.5,5.40540540540541E-03,5.25525525525526E-03,5.10510510510511E-03,4.95495495495496E-03,4.80480480480481E-03,4.65465465465465E-03,4.5045045045045E-03,4.35435435435435E-03,4.2042042042042E-03,4.05405405405405E-03,3.9039039039039E-03,3.75375375375375E-03,3.6036036036036E-03,3.45345345345345E-03,3.3033033033033E-03,3.15315315315315E-03,.003003003003003,2.85285285285285E-03,2.7027027027027E-03,2.55255255255255E-03,2.4024024024024E-03,2.25225225225225E-03,2.1021021021021E-03,1.95195195195195E-03,1.8018018018018E-03,1.65165165165165E-03,1.5015015015015E-03,1.35135135135135E-03,1.2012012012012E-03,1.05105105105105E-03,9.009009009009E-04,7.5075075075075E-04,6.006006006006E-04,4.5045045045045E-04,3.003003003003E-04,1.5015015015015E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={15,25,50,3.33333333333333,1.66666666666667,4.34782608695652E-03,4.2512077294686E-03,4.15458937198068E-03,4.05797101449275E-03,3.96135265700483E-03,3.86473429951691E-03,3.76811594202899E-03,3.67149758454106E-03,3.57487922705314E-03,3.47826086956522E-03,3.3816425120773E-03,3.28502415458937E-03,3.18840579710145E-03,3.09178743961353E-03,2.9951690821256E-03,2.89855072463768E-03,2.80193236714976E-03,2.70531400966184E-03,2.60869565217391E-03,2.51207729468599E-03,2.41545893719807E-03,2.31884057971015E-03,2.22222222222222E-03,2.1256038647343E-03,2.02898550724638E-03,1.93236714975845E-03,1.83574879227053E-03,1.73913043478261E-03,1.64251207729469E-03,1.54589371980676E-03,1.44927536231884E-03,1.35265700483092E-03,.001256038647343,1.15942028985507E-03,1.06280193236715E-03,9.66183574879228E-04,8.69565217391305E-04,7.72946859903382E-04,6.76328502415459E-04,5.79710144927537E-04,4.83091787439614E-04,3.86473429951691E-04,2.89855072463769E-04,1.93236714975846E-04,9.66183574879235E-05,}
		valueWeights[dataIndex["default_damage_low"]] ={1.66666666666667,1.66666666666667,1.66666666666667,2.5,2.5,2.5,2.5,2.5,2.5,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,6.89655172413793E-03,6.65024630541872E-03,6.40394088669951E-03,6.1576354679803E-03,5.91133004926108E-03,5.66502463054187E-03,5.41871921182266E-03,5.17241379310345E-03,4.92610837438424E-03,4.67980295566502E-03,4.43349753694581E-03,4.1871921182266E-03,3.94088669950739E-03,3.69458128078818E-03,3.44827586206897E-03,3.20197044334975E-03,2.95566502463054E-03,2.70935960591133E-03,2.46305418719212E-03,2.21674876847291E-03,1.97044334975369E-03,1.72413793103448E-03,1.47783251231527E-03,1.23152709359606E-03,9.85221674876848E-04,7.38916256157635E-04,4.92610837438423E-04,2.46305418719212E-04,}
		valueWeights[dataIndex["default_damage_high"]] ={1.66666666666667,1.66666666666667,1.66666666666667,2.5,2.5,2.5,2.5,2.5,2.5,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,6.89655172413793E-03,6.65024630541872E-03,6.40394088669951E-03,6.1576354679803E-03,5.91133004926108E-03,5.66502463054187E-03,5.41871921182266E-03,5.17241379310345E-03,4.92610837438424E-03,4.67980295566502E-03,4.43349753694581E-03,4.1871921182266E-03,3.94088669950739E-03,3.69458128078818E-03,3.44827586206897E-03,3.20197044334975E-03,2.95566502463054E-03,2.70935960591133E-03,2.46305418719212E-03,2.21674876847291E-03,1.97044334975369E-03,1.72413793103448E-03,1.47783251231527E-03,1.23152709359606E-03,9.85221674876848E-04,7.38916256157635E-04,4.92610837438423E-04,2.46305418719212E-04,}
		valueWeights[dataIndex["default_dodge"]] ={15,75,3.33333333333333,1.66666666666667,4.25531914893617E-03,4.16281221091582E-03,4.07030527289547E-03,3.97779833487512E-03,3.88529139685476E-03,3.79278445883441E-03,3.70027752081406E-03,3.60777058279371E-03,3.51526364477336E-03,3.42275670675301E-03,3.33024976873266E-03,3.2377428307123E-03,3.14523589269195E-03,3.0527289546716E-03,2.96022201665125E-03,2.8677150786309E-03,2.77520814061055E-03,2.68270120259019E-03,2.59019426456984E-03,2.49768732654949E-03,2.40518038852914E-03,2.31267345050879E-03,2.22016651248844E-03,2.12765957446809E-03,2.03515263644773E-03,1.94264569842738E-03,1.85013876040703E-03,1.75763182238668E-03,1.66512488436633E-03,1.57261794634598E-03,1.48011100832562E-03,1.38760407030527E-03,1.29509713228492E-03,1.20259019426457E-03,1.11008325624422E-03,1.01757631822387E-03,9.25069380203515E-04,8.32562442183164E-04,7.40055504162812E-04,6.47548566142461E-04,5.55041628122109E-04,4.62534690101757E-04,3.70027752081406E-04,2.77520814061055E-04,1.85013876040703E-04,9.25069380203515E-05,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["default_resis_sleep"]] ={2.5,2.5,3.75,3.75,3.75,3.75,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,2.5,1.66666666666667,.833333333333333,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["default_resis_silence"]] ={1.25,1.25,1.25,1.25,2.5,2.5,2.5,2.5,2.5,2.5,1.36363636363636,2.72727272727273,4.09090909090909,5.45454545454545,6.81818181818182,8.18181818181818,9.54545454545455,10.9090909090909,12.2727272727273,13.6363636363636,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["default_resis_weakness"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["default_resis_enlace"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		
		valueWeights[dataIndex["grow_hp"]] ={5,5,5,5,7.5,15,22.5,30,3.33333333333333,1.66666666666667,4.87804878048781E-03,4.75609756097561E-03,4.63414634146342E-03,4.51219512195122E-03,4.39024390243902E-03,4.26829268292683E-03,4.14634146341464E-03,4.02439024390244E-03,3.90243902439024E-03,3.78048780487805E-03,3.65853658536585E-03,3.53658536585366E-03,3.41463414634146E-03,3.29268292682927E-03,3.17073170731707E-03,3.04878048780488E-03,2.92682926829268E-03,2.80487804878049E-03,2.68292682926829E-03,2.5609756097561E-03,2.4390243902439E-03,2.31707317073171E-03,2.19512195121951E-03,2.07317073170732E-03,1.95121951219512E-03,1.82926829268293E-03,1.70731707317073E-03,1.58536585365854E-03,1.46341463414634E-03,1.34146341463415E-03,1.21951219512195E-03,1.09756097560976E-03,9.75609756097561E-04,8.53658536585367E-04,7.31707317073171E-04,6.09756097560976E-04,4.87804878048781E-04,3.65853658536586E-04,2.4390243902439E-04,1.21951219512195E-04,}
		valueWeights[dataIndex["grow_mp"]] ={2.5,2.5,5,5,5,5,10,15,20,25,2,1.5,1,.5,5.40540540540541E-03,5.25525525525526E-03,5.10510510510511E-03,4.95495495495496E-03,4.80480480480481E-03,4.65465465465465E-03,4.5045045045045E-03,4.35435435435435E-03,4.2042042042042E-03,4.05405405405405E-03,3.9039039039039E-03,3.75375375375375E-03,3.6036036036036E-03,3.45345345345345E-03,3.3033033033033E-03,3.15315315315315E-03,.003003003003003,2.85285285285285E-03,2.7027027027027E-03,2.55255255255255E-03,2.4024024024024E-03,2.25225225225225E-03,2.1021021021021E-03,1.95195195195195E-03,1.8018018018018E-03,1.65165165165165E-03,1.5015015015015E-03,1.35135135135135E-03,1.2012012012012E-03,1.05105105105105E-03,9.009009009009E-04,7.5075075075075E-04,6.006006006006E-04,4.5045045045045E-04,3.003003003003E-04,1.5015015015015E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={15,25,50,3.33333333333333,1.66666666666667,4.34782608695652E-03,4.2512077294686E-03,4.15458937198068E-03,4.05797101449275E-03,3.96135265700483E-03,3.86473429951691E-03,3.76811594202899E-03,3.67149758454106E-03,3.57487922705314E-03,3.47826086956522E-03,3.3816425120773E-03,3.28502415458937E-03,3.18840579710145E-03,3.09178743961353E-03,2.9951690821256E-03,2.89855072463768E-03,2.80193236714976E-03,2.70531400966184E-03,2.60869565217391E-03,2.51207729468599E-03,2.41545893719807E-03,2.31884057971015E-03,2.22222222222222E-03,2.1256038647343E-03,2.02898550724638E-03,1.93236714975845E-03,1.83574879227053E-03,1.73913043478261E-03,1.64251207729469E-03,1.54589371980676E-03,1.44927536231884E-03,1.35265700483092E-03,.001256038647343,1.15942028985507E-03,1.06280193236715E-03,9.66183574879228E-04,8.69565217391305E-04,7.72946859903382E-04,6.76328502415459E-04,5.79710144927537E-04,4.83091787439614E-04,3.86473429951691E-04,2.89855072463769E-04,1.93236714975846E-04,9.66183574879235E-05,}
		valueWeights[dataIndex["grow_damage_low"]] ={1.66666666666667,1.66666666666667,1.66666666666667,2.5,2.5,2.5,2.5,2.5,2.5,1.66666666666667,3.33333333333333,5,6.66666666666667,8.33333333333333,10,11.6666666666667,13.3333333333333,15,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		valueWeights[dataIndex["grow_damage_high"]] ={1.66666666666667,1.66666666666667,1.66666666666667,2.5,2.5,2.5,2.5,2.5,2.5,1.66666666666667,3.33333333333333,5,6.66666666666667,8.33333333333333,10,11.6666666666667,13.3333333333333,15,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		valueWeights[dataIndex["grow_dodge"]] ={15,75,3.33333333333333,1.66666666666667,4.25531914893617E-03,4.16281221091582E-03,4.07030527289547E-03,3.97779833487512E-03,3.88529139685476E-03,3.79278445883441E-03,3.70027752081406E-03,3.60777058279371E-03,3.51526364477336E-03,3.42275670675301E-03,3.33024976873266E-03,3.2377428307123E-03,3.14523589269195E-03,3.0527289546716E-03,2.96022201665125E-03,2.8677150786309E-03,2.77520814061055E-03,2.68270120259019E-03,2.59019426456984E-03,2.49768732654949E-03,2.40518038852914E-03,2.31267345050879E-03,2.22016651248844E-03,2.12765957446809E-03,2.03515263644773E-03,1.94264569842738E-03,1.85013876040703E-03,1.75763182238668E-03,1.66512488436633E-03,1.57261794634598E-03,1.48011100832562E-03,1.38760407030527E-03,1.29509713228492E-03,1.20259019426457E-03,1.11008325624422E-03,1.01757631822387E-03,9.25069380203515E-04,8.32562442183164E-04,7.40055504162812E-04,6.47548566142461E-04,5.55041628122109E-04,4.62534690101757E-04,3.70027752081406E-04,2.77520814061055E-04,1.85013876040703E-04,9.25069380203515E-05,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={3.33333333333333,3.33333333333333,3.33333333333333,7,7,7,7,7,1.38888888888889,2.77777777777778,4.16666666666667,5.55555555555556,6.94444444444444,8.33333333333333,9.72222222222222,11.1111111111111,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={5,5,8.75,8.75,8.75,8.75,2.38095238095238,4.76190476190476,7.14285714285714,9.52380952380952,11.9047619047619,14.2857142857143,2.5,1.66666666666667,.833333333333333,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["grow_resis_silence"]] ={2.5,2.5,2.5,2.5,5.83333333333333,5.83333333333333,5.83333333333333,5.83333333333333,5.83333333333333,5.83333333333333,.909090909090909,1.81818181818182,2.72727272727273,3.63636363636364,4.54545454545455,5.45454545454545,6.36363636363636,7.27272727272727,8.18181818181818,9.09090909090909,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={3.33333333333333,3.33333333333333,3.33333333333333,7,7,7,7,7,1.38888888888889,2.77777777777778,4.16666666666667,5.55555555555556,6.94444444444444,8.33333333333333,9.72222222222222,11.1111111111111,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={3.33333333333333,3.33333333333333,3.33333333333333,7,7,7,7,7,1.38888888888889,2.77777777777778,4.16666666666667,5.55555555555556,6.94444444444444,8.33333333333333,9.72222222222222,11.1111111111111,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		
	---血玉骨片 南明印 雷公墨
	elseif tmplID == talismans["GD_15_XueYuGuPian"].tmplID or tmplID == talismans["FX_15_NanMingYin"].tmplID or tmplID == talismans["TH_15_LeiGongMo"].tmplID then
			
		valueWeights[dataIndex["default_hp"]] ={5,5,5,5,7.5,15,22.5,30,3.33333333333333,1.66666666666667,4.87804878048781E-03,4.75609756097561E-03,4.63414634146342E-03,4.51219512195122E-03,4.39024390243902E-03,4.26829268292683E-03,4.14634146341464E-03,4.02439024390244E-03,3.90243902439024E-03,3.78048780487805E-03,3.65853658536585E-03,3.53658536585366E-03,3.41463414634146E-03,3.29268292682927E-03,3.17073170731707E-03,3.04878048780488E-03,2.92682926829268E-03,2.80487804878049E-03,2.68292682926829E-03,2.5609756097561E-03,2.4390243902439E-03,2.31707317073171E-03,2.19512195121951E-03,2.07317073170732E-03,1.95121951219512E-03,1.82926829268293E-03,1.70731707317073E-03,1.58536585365854E-03,1.46341463414634E-03,1.34146341463415E-03,1.21951219512195E-03,1.09756097560976E-03,9.75609756097561E-04,8.53658536585367E-04,7.31707317073171E-04,6.09756097560976E-04,4.87804878048781E-04,3.65853658536586E-04,2.4390243902439E-04,1.21951219512195E-04,}
		valueWeights[dataIndex["default_mp"]] ={2.5,2.5,5,5,5,5,10,15,20,25,2,1.5,1,.5,5.40540540540541E-03,5.25525525525526E-03,5.10510510510511E-03,4.95495495495496E-03,4.80480480480481E-03,4.65465465465465E-03,4.5045045045045E-03,4.35435435435435E-03,4.2042042042042E-03,4.05405405405405E-03,3.9039039039039E-03,3.75375375375375E-03,3.6036036036036E-03,3.45345345345345E-03,3.3033033033033E-03,3.15315315315315E-03,.003003003003003,2.85285285285285E-03,2.7027027027027E-03,2.55255255255255E-03,2.4024024024024E-03,2.25225225225225E-03,2.1021021021021E-03,1.95195195195195E-03,1.8018018018018E-03,1.65165165165165E-03,1.5015015015015E-03,1.35135135135135E-03,1.2012012012012E-03,1.05105105105105E-03,9.009009009009E-04,7.5075075075075E-04,6.006006006006E-04,4.5045045045045E-04,3.003003003003E-04,1.5015015015015E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={15,25,50,3.33333333333333,1.66666666666667,4.34782608695652E-03,4.2512077294686E-03,4.15458937198068E-03,4.05797101449275E-03,3.96135265700483E-03,3.86473429951691E-03,3.76811594202899E-03,3.67149758454106E-03,3.57487922705314E-03,3.47826086956522E-03,3.3816425120773E-03,3.28502415458937E-03,3.18840579710145E-03,3.09178743961353E-03,2.9951690821256E-03,2.89855072463768E-03,2.80193236714976E-03,2.70531400966184E-03,2.60869565217391E-03,2.51207729468599E-03,2.41545893719807E-03,2.31884057971015E-03,2.22222222222222E-03,2.1256038647343E-03,2.02898550724638E-03,1.93236714975845E-03,1.83574879227053E-03,1.73913043478261E-03,1.64251207729469E-03,1.54589371980676E-03,1.44927536231884E-03,1.35265700483092E-03,.001256038647343,1.15942028985507E-03,1.06280193236715E-03,9.66183574879228E-04,8.69565217391305E-04,7.72946859903382E-04,6.76328502415459E-04,5.79710144927537E-04,4.83091787439614E-04,3.86473429951691E-04,2.89855072463769E-04,1.93236714975846E-04,9.66183574879235E-05,}
		valueWeights[dataIndex["default_damage_low"]] ={1.66666666666667,1.66666666666667,1.66666666666667,2.5,2.5,2.5,2.5,2.5,2.5,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,6.89655172413793E-03,6.65024630541872E-03,6.40394088669951E-03,6.1576354679803E-03,5.91133004926108E-03,5.66502463054187E-03,5.41871921182266E-03,5.17241379310345E-03,4.92610837438424E-03,4.67980295566502E-03,4.43349753694581E-03,4.1871921182266E-03,3.94088669950739E-03,3.69458128078818E-03,3.44827586206897E-03,3.20197044334975E-03,2.95566502463054E-03,2.70935960591133E-03,2.46305418719212E-03,2.21674876847291E-03,1.97044334975369E-03,1.72413793103448E-03,1.47783251231527E-03,1.23152709359606E-03,9.85221674876848E-04,7.38916256157635E-04,4.92610837438423E-04,2.46305418719212E-04,}
		valueWeights[dataIndex["default_damage_high"]] ={1.66666666666667,1.66666666666667,1.66666666666667,2.5,2.5,2.5,2.5,2.5,2.5,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,6.89655172413793E-03,6.65024630541872E-03,6.40394088669951E-03,6.1576354679803E-03,5.91133004926108E-03,5.66502463054187E-03,5.41871921182266E-03,5.17241379310345E-03,4.92610837438424E-03,4.67980295566502E-03,4.43349753694581E-03,4.1871921182266E-03,3.94088669950739E-03,3.69458128078818E-03,3.44827586206897E-03,3.20197044334975E-03,2.95566502463054E-03,2.70935960591133E-03,2.46305418719212E-03,2.21674876847291E-03,1.97044334975369E-03,1.72413793103448E-03,1.47783251231527E-03,1.23152709359606E-03,9.85221674876848E-04,7.38916256157635E-04,4.92610837438423E-04,2.46305418719212E-04,}
		valueWeights[dataIndex["default_dodge"]] ={15,75,3.33333333333333,1.66666666666667,4.25531914893617E-03,4.16281221091582E-03,4.07030527289547E-03,3.97779833487512E-03,3.88529139685476E-03,3.79278445883441E-03,3.70027752081406E-03,3.60777058279371E-03,3.51526364477336E-03,3.42275670675301E-03,3.33024976873266E-03,3.2377428307123E-03,3.14523589269195E-03,3.0527289546716E-03,2.96022201665125E-03,2.8677150786309E-03,2.77520814061055E-03,2.68270120259019E-03,2.59019426456984E-03,2.49768732654949E-03,2.40518038852914E-03,2.31267345050879E-03,2.22016651248844E-03,2.12765957446809E-03,2.03515263644773E-03,1.94264569842738E-03,1.85013876040703E-03,1.75763182238668E-03,1.66512488436633E-03,1.57261794634598E-03,1.48011100832562E-03,1.38760407030527E-03,1.29509713228492E-03,1.20259019426457E-03,1.11008325624422E-03,1.01757631822387E-03,9.25069380203515E-04,8.32562442183164E-04,7.40055504162812E-04,6.47548566142461E-04,5.55041628122109E-04,4.62534690101757E-04,3.70027752081406E-04,2.77520814061055E-04,1.85013876040703E-04,9.25069380203515E-05,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["default_resis_sleep"]] ={2.5,2.5,3.75,3.75,3.75,3.75,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,2.5,1.66666666666667,.833333333333333,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["default_resis_silence"]] ={1.25,1.25,1.25,1.25,2.5,2.5,2.5,2.5,2.5,2.5,1.36363636363636,2.72727272727273,4.09090909090909,5.45454545454545,6.81818181818182,8.18181818181818,9.54545454545455,10.9090909090909,12.2727272727273,13.6363636363636,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["default_resis_weakness"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["default_resis_enlace"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		
		valueWeights[dataIndex["grow_hp"]] ={5,5,5,5,7.5,15,22.5,30,3.33333333333333,1.66666666666667,4.87804878048781E-03,4.75609756097561E-03,4.63414634146342E-03,4.51219512195122E-03,4.39024390243902E-03,4.26829268292683E-03,4.14634146341464E-03,4.02439024390244E-03,3.90243902439024E-03,3.78048780487805E-03,3.65853658536585E-03,3.53658536585366E-03,3.41463414634146E-03,3.29268292682927E-03,3.17073170731707E-03,3.04878048780488E-03,2.92682926829268E-03,2.80487804878049E-03,2.68292682926829E-03,2.5609756097561E-03,2.4390243902439E-03,2.31707317073171E-03,2.19512195121951E-03,2.07317073170732E-03,1.95121951219512E-03,1.82926829268293E-03,1.70731707317073E-03,1.58536585365854E-03,1.46341463414634E-03,1.34146341463415E-03,1.21951219512195E-03,1.09756097560976E-03,9.75609756097561E-04,8.53658536585367E-04,7.31707317073171E-04,6.09756097560976E-04,4.87804878048781E-04,3.65853658536586E-04,2.4390243902439E-04,1.21951219512195E-04,}
		valueWeights[dataIndex["grow_mp"]] ={2.5,2.5,5,5,5,5,10,15,20,25,2,1.5,1,.5,5.40540540540541E-03,5.25525525525526E-03,5.10510510510511E-03,4.95495495495496E-03,4.80480480480481E-03,4.65465465465465E-03,4.5045045045045E-03,4.35435435435435E-03,4.2042042042042E-03,4.05405405405405E-03,3.9039039039039E-03,3.75375375375375E-03,3.6036036036036E-03,3.45345345345345E-03,3.3033033033033E-03,3.15315315315315E-03,.003003003003003,2.85285285285285E-03,2.7027027027027E-03,2.55255255255255E-03,2.4024024024024E-03,2.25225225225225E-03,2.1021021021021E-03,1.95195195195195E-03,1.8018018018018E-03,1.65165165165165E-03,1.5015015015015E-03,1.35135135135135E-03,1.2012012012012E-03,1.05105105105105E-03,9.009009009009E-04,7.5075075075075E-04,6.006006006006E-04,4.5045045045045E-04,3.003003003003E-04,1.5015015015015E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={15,25,50,3.33333333333333,1.66666666666667,4.34782608695652E-03,4.2512077294686E-03,4.15458937198068E-03,4.05797101449275E-03,3.96135265700483E-03,3.86473429951691E-03,3.76811594202899E-03,3.67149758454106E-03,3.57487922705314E-03,3.47826086956522E-03,3.3816425120773E-03,3.28502415458937E-03,3.18840579710145E-03,3.09178743961353E-03,2.9951690821256E-03,2.89855072463768E-03,2.80193236714976E-03,2.70531400966184E-03,2.60869565217391E-03,2.51207729468599E-03,2.41545893719807E-03,2.31884057971015E-03,2.22222222222222E-03,2.1256038647343E-03,2.02898550724638E-03,1.93236714975845E-03,1.83574879227053E-03,1.73913043478261E-03,1.64251207729469E-03,1.54589371980676E-03,1.44927536231884E-03,1.35265700483092E-03,.001256038647343,1.15942028985507E-03,1.06280193236715E-03,9.66183574879228E-04,8.69565217391305E-04,7.72946859903382E-04,6.76328502415459E-04,5.79710144927537E-04,4.83091787439614E-04,3.86473429951691E-04,2.89855072463769E-04,1.93236714975846E-04,9.66183574879235E-05,}
		valueWeights[dataIndex["grow_damage_low"]] ={1.66666666666667,1.66666666666667,1.66666666666667,2.5,2.5,2.5,2.5,2.5,2.5,1.66666666666667,3.33333333333333,5,6.66666666666667,8.33333333333333,10,11.6666666666667,13.3333333333333,15,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		valueWeights[dataIndex["grow_damage_high"]] ={1.66666666666667,1.66666666666667,1.66666666666667,2.5,2.5,2.5,2.5,2.5,2.5,1.66666666666667,3.33333333333333,5,6.66666666666667,8.33333333333333,10,11.6666666666667,13.3333333333333,15,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		valueWeights[dataIndex["grow_dodge"]] ={15,75,3.33333333333333,1.66666666666667,4.25531914893617E-03,4.16281221091582E-03,4.07030527289547E-03,3.97779833487512E-03,3.88529139685476E-03,3.79278445883441E-03,3.70027752081406E-03,3.60777058279371E-03,3.51526364477336E-03,3.42275670675301E-03,3.33024976873266E-03,3.2377428307123E-03,3.14523589269195E-03,3.0527289546716E-03,2.96022201665125E-03,2.8677150786309E-03,2.77520814061055E-03,2.68270120259019E-03,2.59019426456984E-03,2.49768732654949E-03,2.40518038852914E-03,2.31267345050879E-03,2.22016651248844E-03,2.12765957446809E-03,2.03515263644773E-03,1.94264569842738E-03,1.85013876040703E-03,1.75763182238668E-03,1.66512488436633E-03,1.57261794634598E-03,1.48011100832562E-03,1.38760407030527E-03,1.29509713228492E-03,1.20259019426457E-03,1.11008325624422E-03,1.01757631822387E-03,9.25069380203515E-04,8.32562442183164E-04,7.40055504162812E-04,6.47548566142461E-04,5.55041628122109E-04,4.62534690101757E-04,3.70027752081406E-04,2.77520814061055E-04,1.85013876040703E-04,9.25069380203515E-05,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={3.33333333333333,3.33333333333333,3.33333333333333,7,7,7,7,7,1.38888888888889,2.77777777777778,4.16666666666667,5.55555555555556,6.94444444444444,8.33333333333333,9.72222222222222,11.1111111111111,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={5,5,8.75,8.75,8.75,8.75,2.38095238095238,4.76190476190476,7.14285714285714,9.52380952380952,11.9047619047619,14.2857142857143,2.5,1.66666666666667,.833333333333333,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["grow_resis_silence"]] ={2.5,2.5,2.5,2.5,5.83333333333333,5.83333333333333,5.83333333333333,5.83333333333333,5.83333333333333,5.83333333333333,.909090909090909,1.81818181818182,2.72727272727273,3.63636363636364,4.54545454545455,5.45454545454545,6.36363636363636,7.27272727272727,8.18181818181818,9.09090909090909,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={3.33333333333333,3.33333333333333,3.33333333333333,7,7,7,7,7,1.38888888888889,2.77777777777778,4.16666666666667,5.55555555555556,6.94444444444444,8.33333333333333,9.72222222222222,11.1111111111111,2,1.5,1,.5,6.45161290322581E-03,6.23655913978495E-03,6.02150537634409E-03,5.80645161290323E-03,5.59139784946237E-03,5.37634408602151E-03,5.16129032258065E-03,4.94623655913978E-03,4.73118279569892E-03,4.51612903225806E-03,4.3010752688172E-03,4.08602150537634E-03,3.87096774193548E-03,3.65591397849462E-03,3.44086021505376E-03,3.2258064516129E-03,3.01075268817204E-03,2.79569892473118E-03,2.58064516129032E-03,2.36559139784946E-03,2.1505376344086E-03,1.93548387096774E-03,1.72043010752688E-03,1.50537634408602E-03,1.29032258064516E-03,1.0752688172043E-03,8.60215053763441E-04,6.45161290322581E-04,4.3010752688172E-04,2.1505376344086E-04,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={3.33333333333333,3.33333333333333,3.33333333333333,7,7,7,7,7,1.38888888888889,2.77777777777778,4.16666666666667,5.55555555555556,6.94444444444444,8.33333333333333,9.72222222222222,11.1111111111111,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}

	---四灵幡 血枫枪
	elseif tmplID == talismans["GW_75_SiLingFan"].tmplID or tmplID == talismans["JL_75_XueFengQiang"].tmplID or tmplID == talismans["QJ_75_luohouyu"].tmplID then
		
		valueWeights[dataIndex["default_hp"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,25,50,.909090909090909,.818181818181818,.727272727272727,.636363636363636,.545454545454546,.454545454545455,.363636363636364,.272727272727273,.181818181818182,9.09090909090909E-02,8.69565217391304E-03,.008300395256917,7.90513833992095E-03,7.5098814229249E-03,7.11462450592885E-03,6.71936758893281E-03,6.32411067193676E-03,5.92885375494071E-03,5.53359683794466E-03,5.13833992094862E-03,4.74308300395257E-03,4.34782608695652E-03,3.95256916996047E-03,3.55731225296443E-03,3.16205533596838E-03,2.76679841897233E-03,2.37154150197628E-03,1.97628458498024E-03,1.58102766798419E-03,1.18577075098814E-03,7.90513833992096E-04,3.95256916996047E-04,}
		valueWeights[dataIndex["default_mp"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3.75,3.75,3.75,3.75,75,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,5.26315789473684E-03,5.12091038406828E-03,4.97866287339972E-03,4.83641536273115E-03,4.69416785206259E-03,4.55192034139403E-03,4.40967283072546E-03,4.2674253200569E-03,4.12517780938834E-03,3.98293029871977E-03,3.84068278805121E-03,3.69843527738265E-03,3.55618776671408E-03,3.41394025604552E-03,3.27169274537696E-03,3.12944523470839E-03,2.98719772403983E-03,2.84495021337127E-03,2.7027027027027E-03,2.56045519203414E-03,2.41820768136558E-03,2.27596017069701E-03,2.13371266002845E-03,1.99146514935989E-03,1.84921763869132E-03,1.70697012802276E-03,1.5647226173542E-03,1.42247510668563E-03,1.28022759601707E-03,1.13798008534851E-03,9.95732574679943E-04,8.53485064011381E-04,7.11237553342817E-04,5.68990042674253E-04,4.2674253200569E-04,2.84495021337127E-04,1.42247510668564E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={5,5,5,5,25,50,3.33333333333333,1.66666666666667,4.65116279069767E-03,4.54042081949059E-03,4.4296788482835E-03,4.31893687707641E-03,4.20819490586932E-03,4.09745293466224E-03,3.98671096345515E-03,3.87596899224806E-03,3.76522702104097E-03,3.65448504983389E-03,3.5437430786268E-03,3.43300110741971E-03,3.32225913621262E-03,3.21151716500554E-03,3.10077519379845E-03,2.99003322259136E-03,2.87929125138427E-03,2.76854928017719E-03,2.6578073089701E-03,2.54706533776301E-03,2.43632336655592E-03,2.32558139534884E-03,2.21483942414175E-03,2.10409745293466E-03,1.99335548172757E-03,1.88261351052049E-03,1.7718715393134E-03,1.66112956810631E-03,1.55038759689922E-03,1.43964562569214E-03,1.32890365448505E-03,1.21816168327796E-03,1.10741971207087E-03,9.96677740863787E-04,8.859357696567E-04,7.75193798449612E-04,6.64451827242524E-04,5.53709856035437E-04,4.42967884828349E-04,3.32225913621262E-04,2.21483942414174E-04,1.10741971207087E-04,}
		valueWeights[dataIndex["default_damage_low"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,1.875,1.875,1.875,1.875,1.875,1.875,1.875,1.875,25,50,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["default_damage_high"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,1.875,1.875,1.875,1.875,1.875,1.875,1.875,1.875,25,50,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["default_dodge"]] ={5,7.5,7.5,25,50,3.33333333333333,1.66666666666667,4.54545454545455E-03,4.43974630021142E-03,4.33403805496829E-03,4.22832980972516E-03,4.12262156448203E-03,4.0169133192389E-03,3.91120507399577E-03,3.80549682875264E-03,3.69978858350951E-03,3.59408033826639E-03,3.48837209302326E-03,3.38266384778013E-03,.003276955602537,3.17124735729387E-03,3.06553911205074E-03,2.95983086680761E-03,2.85412262156448E-03,2.74841437632135E-03,2.64270613107822E-03,2.5369978858351E-03,2.43128964059197E-03,2.32558139534884E-03,2.21987315010571E-03,2.11416490486258E-03,2.00845665961945E-03,1.90274841437632E-03,1.79704016913319E-03,1.69133192389006E-03,1.58562367864694E-03,1.47991543340381E-03,1.37420718816068E-03,1.26849894291755E-03,1.16279069767442E-03,1.05708245243129E-03,9.51374207188161E-04,8.45665961945032E-04,7.39957716701903E-04,6.34249471458774E-04,5.28541226215646E-04,4.22832980972516E-04,3.17124735729387E-04,2.11416490486258E-04,1.05708245243129E-04,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["default_resis_sleep"]] ={.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["default_resis_silence"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,7.5,15,22.5,30,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["default_resis_weakness"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["default_resis_enlace"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		
		valueWeights[dataIndex["grow_hp"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,25,50,.909090909090909,.818181818181818,.727272727272727,.636363636363636,.545454545454546,.454545454545455,.363636363636364,.272727272727273,.181818181818182,9.09090909090909E-02,8.69565217391304E-03,.008300395256917,7.90513833992095E-03,7.5098814229249E-03,7.11462450592885E-03,6.71936758893281E-03,6.32411067193676E-03,5.92885375494071E-03,5.53359683794466E-03,5.13833992094862E-03,4.74308300395257E-03,4.34782608695652E-03,3.95256916996047E-03,3.55731225296443E-03,3.16205533596838E-03,2.76679841897233E-03,2.37154150197628E-03,1.97628458498024E-03,1.58102766798419E-03,1.18577075098814E-03,7.90513833992096E-04,3.95256916996047E-04,}
		valueWeights[dataIndex["grow_mp"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3.75,3.75,3.75,3.75,75,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,5.26315789473684E-03,5.12091038406828E-03,4.97866287339972E-03,4.83641536273115E-03,4.69416785206259E-03,4.55192034139403E-03,4.40967283072546E-03,4.2674253200569E-03,4.12517780938834E-03,3.98293029871977E-03,3.84068278805121E-03,3.69843527738265E-03,3.55618776671408E-03,3.41394025604552E-03,3.27169274537696E-03,3.12944523470839E-03,2.98719772403983E-03,2.84495021337127E-03,2.7027027027027E-03,2.56045519203414E-03,2.41820768136558E-03,2.27596017069701E-03,2.13371266002845E-03,1.99146514935989E-03,1.84921763869132E-03,1.70697012802276E-03,1.5647226173542E-03,1.42247510668563E-03,1.28022759601707E-03,1.13798008534851E-03,9.95732574679943E-04,8.53485064011381E-04,7.11237553342817E-04,5.68990042674253E-04,4.2674253200569E-04,2.84495021337127E-04,1.42247510668564E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={5,5,5,5,25,50,3.33333333333333,1.66666666666667,4.65116279069767E-03,4.54042081949059E-03,4.4296788482835E-03,4.31893687707641E-03,4.20819490586932E-03,4.09745293466224E-03,3.98671096345515E-03,3.87596899224806E-03,3.76522702104097E-03,3.65448504983389E-03,3.5437430786268E-03,3.43300110741971E-03,3.32225913621262E-03,3.21151716500554E-03,3.10077519379845E-03,2.99003322259136E-03,2.87929125138427E-03,2.76854928017719E-03,2.6578073089701E-03,2.54706533776301E-03,2.43632336655592E-03,2.32558139534884E-03,2.21483942414175E-03,2.10409745293466E-03,1.99335548172757E-03,1.88261351052049E-03,1.7718715393134E-03,1.66112956810631E-03,1.55038759689922E-03,1.43964562569214E-03,1.32890365448505E-03,1.21816168327796E-03,1.10741971207087E-03,9.96677740863787E-04,8.859357696567E-04,7.75193798449612E-04,6.64451827242524E-04,5.53709856035437E-04,4.42967884828349E-04,3.32225913621262E-04,2.21483942414174E-04,1.10741971207087E-04,}
		valueWeights[dataIndex["grow_damage_low"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,1.875,1.875,1.875,1.875,1.875,1.875,1.875,1.875,25,50,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["grow_damage_high"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,1.875,1.875,1.875,1.875,1.875,1.875,1.875,1.875,25,50,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["grow_dodge"]] ={5,7.5,7.5,25,50,3.33333333333333,1.66666666666667,4.54545454545455E-03,4.43974630021142E-03,4.33403805496829E-03,4.22832980972516E-03,4.12262156448203E-03,4.0169133192389E-03,3.91120507399577E-03,3.80549682875264E-03,3.69978858350951E-03,3.59408033826639E-03,3.48837209302326E-03,3.38266384778013E-03,.003276955602537,3.17124735729387E-03,3.06553911205074E-03,2.95983086680761E-03,2.85412262156448E-03,2.74841437632135E-03,2.64270613107822E-03,2.5369978858351E-03,2.43128964059197E-03,2.32558139534884E-03,2.21987315010571E-03,2.11416490486258E-03,2.00845665961945E-03,1.90274841437632E-03,1.79704016913319E-03,1.69133192389006E-03,1.58562367864694E-03,1.47991543340381E-03,1.37420718816068E-03,1.26849894291755E-03,1.16279069767442E-03,1.05708245243129E-03,9.51374207188161E-04,8.45665961945032E-04,7.39957716701903E-04,6.34249471458774E-04,5.28541226215646E-04,4.22832980972516E-04,3.17124735729387E-04,2.11416490486258E-04,1.05708245243129E-04,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["grow_resis_silence"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,7.5,15,22.5,30,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}

	---多情环 破军
	elseif tmplID == talismans["HH_75_DuoQingHuan"].tmplID or tmplID == talismans["HG_75_PoJun"].tmplID or tmplID == talismans["YZ_75_poming"].tmplID then

		valueWeights[dataIndex["default_hp"]] ={.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,1.875,1.875,1.875,1.875,1.875,1.875,1.875,1.875,25,50,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["default_mp"]] ={1.66666666666667,1.66666666666667,1.66666666666667,5,5,5,25,50,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,5.40540540540541E-03,5.25525525525526E-03,5.10510510510511E-03,4.95495495495496E-03,4.80480480480481E-03,4.65465465465465E-03,4.5045045045045E-03,4.35435435435435E-03,4.2042042042042E-03,4.05405405405405E-03,3.9039039039039E-03,3.75375375375375E-03,3.6036036036036E-03,3.45345345345345E-03,3.3033033033033E-03,3.15315315315315E-03,.003003003003003,2.85285285285285E-03,2.7027027027027E-03,2.55255255255255E-03,2.4024024024024E-03,2.25225225225225E-03,2.1021021021021E-03,1.95195195195195E-03,1.8018018018018E-03,1.65165165165165E-03,1.5015015015015E-03,1.35135135135135E-03,1.2012012012012E-03,1.05105105105105E-03,9.009009009009E-04,7.5075075075075E-04,6.006006006006E-04,4.5045045045045E-04,3.003003003003E-04,1.5015015015015E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["default_damage_low"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,12.5,25,37.5,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,9.09090909090909E-03,8.65800865800866E-03,8.22510822510823E-03,7.79220779220779E-03,7.35930735930736E-03,6.92640692640693E-03,6.49350649350649E-03,6.06060606060606E-03,5.62770562770563E-03,5.19480519480519E-03,4.76190476190476E-03,4.32900432900433E-03,3.8961038961039E-03,3.46320346320346E-03,3.03030303030303E-03,2.5974025974026E-03,2.16450216450216E-03,1.73160173160173E-03,1.2987012987013E-03,8.65800865800865E-04,4.32900432900432E-04,}
		valueWeights[dataIndex["default_damage_high"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,12.5,25,37.5,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,9.09090909090909E-03,8.65800865800866E-03,8.22510822510823E-03,7.79220779220779E-03,7.35930735930736E-03,6.92640692640693E-03,6.49350649350649E-03,6.06060606060606E-03,5.62770562770563E-03,5.19480519480519E-03,4.76190476190476E-03,4.32900432900433E-03,3.8961038961039E-03,3.46320346320346E-03,3.03030303030303E-03,2.5974025974026E-03,2.16450216450216E-03,1.73160173160173E-03,1.2987012987013E-03,8.65800865800865E-04,4.32900432900432E-04,}
		valueWeights[dataIndex["default_dodge"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["default_resis_sleep"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["default_resis_silence"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,7.5,15,22.5,30,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["default_resis_weakness"]] ={.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["default_resis_enlace"]] ={.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		
		valueWeights[dataIndex["grow_hp"]] ={.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,1.875,1.875,1.875,1.875,1.875,1.875,1.875,1.875,25,50,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["grow_mp"]] ={1.66666666666667,1.66666666666667,1.66666666666667,5,5,5,25,50,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,5.40540540540541E-03,5.25525525525526E-03,5.10510510510511E-03,4.95495495495496E-03,4.80480480480481E-03,4.65465465465465E-03,4.5045045045045E-03,4.35435435435435E-03,4.2042042042042E-03,4.05405405405405E-03,3.9039039039039E-03,3.75375375375375E-03,3.6036036036036E-03,3.45345345345345E-03,3.3033033033033E-03,3.15315315315315E-03,.003003003003003,2.85285285285285E-03,2.7027027027027E-03,2.55255255255255E-03,2.4024024024024E-03,2.25225225225225E-03,2.1021021021021E-03,1.95195195195195E-03,1.8018018018018E-03,1.65165165165165E-03,1.5015015015015E-03,1.35135135135135E-03,1.2012012012012E-03,1.05105105105105E-03,9.009009009009E-04,7.5075075075075E-04,6.006006006006E-04,4.5045045045045E-04,3.003003003003E-04,1.5015015015015E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["grow_damage_low"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,12.5,25,37.5,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,9.09090909090909E-03,8.65800865800866E-03,8.22510822510823E-03,7.79220779220779E-03,7.35930735930736E-03,6.92640692640693E-03,6.49350649350649E-03,6.06060606060606E-03,5.62770562770563E-03,5.19480519480519E-03,4.76190476190476E-03,4.32900432900433E-03,3.8961038961039E-03,3.46320346320346E-03,3.03030303030303E-03,2.5974025974026E-03,2.16450216450216E-03,1.73160173160173E-03,1.2987012987013E-03,8.65800865800865E-04,4.32900432900432E-04,}
		valueWeights[dataIndex["grow_damage_high"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,12.5,25,37.5,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,9.09090909090909E-03,8.65800865800866E-03,8.22510822510823E-03,7.79220779220779E-03,7.35930735930736E-03,6.92640692640693E-03,6.49350649350649E-03,6.06060606060606E-03,5.62770562770563E-03,5.19480519480519E-03,4.76190476190476E-03,4.32900432900433E-03,3.8961038961039E-03,3.46320346320346E-03,3.03030303030303E-03,2.5974025974026E-03,2.16450216450216E-03,1.73160173160173E-03,1.2987012987013E-03,8.65800865800865E-04,4.32900432900432E-04,}
		valueWeights[dataIndex["grow_dodge"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["grow_resis_silence"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,7.5,15,22.5,30,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}

	---七星剑 亚风
	elseif tmplID == talismans["QY_75_QiXingJian"].tmplID or tmplID == talismans["TH_75_YaFeng"].tmplID then
		
		valueWeights[dataIndex["default_hp"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3.75,3.75,3.75,3.75,75,2,1.5,1,.5,5.12820512820513E-03,4.99325236167341E-03,4.8582995951417E-03,4.72334682860999E-03,4.58839406207827E-03,4.45344129554656E-03,4.31848852901484E-03,4.18353576248313E-03,4.04858299595142E-03,3.9136302294197E-03,3.77867746288799E-03,3.64372469635628E-03,3.50877192982456E-03,3.37381916329285E-03,3.23886639676113E-03,3.10391363022942E-03,2.96896086369771E-03,2.83400809716599E-03,2.69905533063428E-03,2.56410256410256E-03,2.42914979757085E-03,2.29419703103914E-03,2.15924426450742E-03,2.02429149797571E-03,1.88933873144399E-03,1.75438596491228E-03,1.61943319838057E-03,1.48448043184885E-03,1.34952766531714E-03,1.21457489878542E-03,1.07962213225371E-03,9.44669365721997E-04,8.09716599190284E-04,6.7476383265857E-04,5.39811066126856E-04,4.04858299595142E-04,2.69905533063428E-04,1.34952766531714E-04,}
		valueWeights[dataIndex["default_mp"]] ={1.25,1.25,1.25,1.25,2.5,2.5,2.5,2.5,2.5,2.5,25,50,.833333333333333,.757575757575758,.681818181818182,.606060606060606,.53030303030303,.454545454545455,.378787878787879,.303030303030303,.227272727272727,.151515151515151,7.57575757575758E-02,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={5,5,5,5,25,50,3.33333333333333,1.66666666666667,4.65116279069767E-03,4.54042081949059E-03,4.4296788482835E-03,4.31893687707641E-03,4.20819490586932E-03,4.09745293466224E-03,3.98671096345515E-03,3.87596899224806E-03,3.76522702104097E-03,3.65448504983389E-03,3.5437430786268E-03,3.43300110741971E-03,3.32225913621262E-03,3.21151716500554E-03,3.10077519379845E-03,2.99003322259136E-03,2.87929125138427E-03,2.76854928017719E-03,2.6578073089701E-03,2.54706533776301E-03,2.43632336655592E-03,2.32558139534884E-03,2.21483942414175E-03,2.10409745293466E-03,1.99335548172757E-03,1.88261351052049E-03,1.7718715393134E-03,1.66112956810631E-03,1.55038759689922E-03,1.43964562569214E-03,1.32890365448505E-03,1.21816168327796E-03,1.10741971207087E-03,9.96677740863787E-04,8.859357696567E-04,7.75193798449612E-04,6.64451827242524E-04,5.53709856035437E-04,4.42967884828349E-04,3.32225913621262E-04,2.21483942414174E-04,1.10741971207087E-04,}
		valueWeights[dataIndex["default_damage_low"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,12.5,25,37.5,.909090909090909,.818181818181818,.727272727272727,.636363636363636,.545454545454546,.454545454545455,.363636363636364,.272727272727273,.181818181818182,9.09090909090909E-02,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["default_damage_high"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,12.5,25,37.5,.909090909090909,.818181818181818,.727272727272727,.636363636363636,.545454545454546,.454545454545455,.363636363636364,.272727272727273,.181818181818182,9.09090909090909E-02,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["default_dodge"]] ={5,7.5,7.5,25,50,3.33333333333333,1.66666666666667,4.54545454545455E-03,4.43974630021142E-03,4.33403805496829E-03,4.22832980972516E-03,4.12262156448203E-03,4.0169133192389E-03,3.91120507399577E-03,3.80549682875264E-03,3.69978858350951E-03,3.59408033826639E-03,3.48837209302326E-03,3.38266384778013E-03,.003276955602537,3.17124735729387E-03,3.06553911205074E-03,2.95983086680761E-03,2.85412262156448E-03,2.74841437632135E-03,2.64270613107822E-03,2.5369978858351E-03,2.43128964059197E-03,2.32558139534884E-03,2.21987315010571E-03,2.11416490486258E-03,2.00845665961945E-03,1.90274841437632E-03,1.79704016913319E-03,1.69133192389006E-03,1.58562367864694E-03,1.47991543340381E-03,1.37420718816068E-03,1.26849894291755E-03,1.16279069767442E-03,1.05708245243129E-03,9.51374207188161E-04,8.45665961945032E-04,7.39957716701903E-04,6.34249471458774E-04,5.28541226215646E-04,4.22832980972516E-04,3.17124735729387E-04,2.11416490486258E-04,1.05708245243129E-04,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["default_resis_sleep"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["default_resis_silence"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.875,1.875,1.875,1.875,1.875,1.875,1.875,1.875,25,50,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["default_resis_weakness"]] ={.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["default_resis_enlace"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		
		valueWeights[dataIndex["grow_hp"]] ={1.66666666666667,1.66666666666667,1.66666666666667,3.75,3.75,3.75,3.75,75,2,1.5,1,.5,5.12820512820513E-03,4.99325236167341E-03,4.8582995951417E-03,4.72334682860999E-03,4.58839406207827E-03,4.45344129554656E-03,4.31848852901484E-03,4.18353576248313E-03,4.04858299595142E-03,3.9136302294197E-03,3.77867746288799E-03,3.64372469635628E-03,3.50877192982456E-03,3.37381916329285E-03,3.23886639676113E-03,3.10391363022942E-03,2.96896086369771E-03,2.83400809716599E-03,2.69905533063428E-03,2.56410256410256E-03,2.42914979757085E-03,2.29419703103914E-03,2.15924426450742E-03,2.02429149797571E-03,1.88933873144399E-03,1.75438596491228E-03,1.61943319838057E-03,1.48448043184885E-03,1.34952766531714E-03,1.21457489878542E-03,1.07962213225371E-03,9.44669365721997E-04,8.09716599190284E-04,6.7476383265857E-04,5.39811066126856E-04,4.04858299595142E-04,2.69905533063428E-04,1.34952766531714E-04,}
		valueWeights[dataIndex["grow_mp"]] ={1.25,1.25,1.25,1.25,2.5,2.5,2.5,2.5,2.5,2.5,25,50,.833333333333333,.757575757575758,.681818181818182,.606060606060606,.53030303030303,.454545454545455,.378787878787879,.303030303030303,.227272727272727,.151515151515151,7.57575757575758E-02,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={5,5,5,5,25,50,3.33333333333333,1.66666666666667,4.65116279069767E-03,4.54042081949059E-03,4.4296788482835E-03,4.31893687707641E-03,4.20819490586932E-03,4.09745293466224E-03,3.98671096345515E-03,3.87596899224806E-03,3.76522702104097E-03,3.65448504983389E-03,3.5437430786268E-03,3.43300110741971E-03,3.32225913621262E-03,3.21151716500554E-03,3.10077519379845E-03,2.99003322259136E-03,2.87929125138427E-03,2.76854928017719E-03,2.6578073089701E-03,2.54706533776301E-03,2.43632336655592E-03,2.32558139534884E-03,2.21483942414175E-03,2.10409745293466E-03,1.99335548172757E-03,1.88261351052049E-03,1.7718715393134E-03,1.66112956810631E-03,1.55038759689922E-03,1.43964562569214E-03,1.32890365448505E-03,1.21816168327796E-03,1.10741971207087E-03,9.96677740863787E-04,8.859357696567E-04,7.75193798449612E-04,6.64451827242524E-04,5.53709856035437E-04,4.42967884828349E-04,3.32225913621262E-04,2.21483942414174E-04,1.10741971207087E-04,}
		valueWeights[dataIndex["grow_damage_low"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,12.5,25,37.5,.909090909090909,.818181818181818,.727272727272727,.636363636363636,.545454545454546,.454545454545455,.363636363636364,.272727272727273,.181818181818182,9.09090909090909E-02,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["grow_damage_high"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,12.5,25,37.5,.909090909090909,.818181818181818,.727272727272727,.636363636363636,.545454545454546,.454545454545455,.363636363636364,.272727272727273,.181818181818182,9.09090909090909E-02,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["grow_dodge"]] ={5,7.5,7.5,25,50,3.33333333333333,1.66666666666667,4.54545454545455E-03,4.43974630021142E-03,4.33403805496829E-03,4.22832980972516E-03,4.12262156448203E-03,4.0169133192389E-03,3.91120507399577E-03,3.80549682875264E-03,3.69978858350951E-03,3.59408033826639E-03,3.48837209302326E-03,3.38266384778013E-03,.003276955602537,3.17124735729387E-03,3.06553911205074E-03,2.95983086680761E-03,2.85412262156448E-03,2.74841437632135E-03,2.64270613107822E-03,2.5369978858351E-03,2.43128964059197E-03,2.32558139534884E-03,2.21987315010571E-03,2.11416490486258E-03,2.00845665961945E-03,1.90274841437632E-03,1.79704016913319E-03,1.69133192389006E-03,1.58562367864694E-03,1.47991543340381E-03,1.37420718816068E-03,1.26849894291755E-03,1.16279069767442E-03,1.05708245243129E-03,9.51374207188161E-04,8.45665961945032E-04,7.39957716701903E-04,6.34249471458774E-04,5.28541226215646E-04,4.22832980972516E-04,3.17124735729387E-04,2.11416490486258E-04,1.05708245243129E-04,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["grow_resis_silence"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.875,1.875,1.875,1.875,1.875,1.875,1.875,1.875,25,50,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}

	---金刚杵 返魂香 鼍鼓
	elseif tmplID == talismans["TY_75_JinGangChu"].tmplID or tmplID == talismans["LS_75_FanHunXiang"].tmplID or tmplID == talismans["CH_75_tuogu"].tmplID then
		
		valueWeights[dataIndex["default_hp"]] ={1.25,1.25,1.25,1.25,3.75,3.75,3.75,3.75,25,50,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["default_mp"]] ={1,1,1,1,1,3,3,3,3,3,25,50,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,6.66666666666667E-03,6.4367816091954E-03,6.20689655172414E-03,5.97701149425287E-03,5.74712643678161E-03,5.51724137931035E-03,5.28735632183908E-03,5.05747126436782E-03,4.82758620689655E-03,4.59770114942529E-03,4.36781609195402E-03,4.13793103448276E-03,3.90804597701149E-03,3.67816091954023E-03,3.44827586206897E-03,3.2183908045977E-03,2.98850574712644E-03,2.75862068965517E-03,2.52873563218391E-03,2.29885057471264E-03,2.06896551724138E-03,1.83908045977012E-03,1.60919540229885E-03,1.37931034482759E-03,1.14942528735632E-03,9.19540229885057E-04,6.89655172413793E-04,4.59770114942529E-04,2.29885057471264E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={5,5,5,5,25,50,3.33333333333333,1.66666666666667,4.65116279069767E-03,4.54042081949059E-03,4.4296788482835E-03,4.31893687707641E-03,4.20819490586932E-03,4.09745293466224E-03,3.98671096345515E-03,3.87596899224806E-03,3.76522702104097E-03,3.65448504983389E-03,3.5437430786268E-03,3.43300110741971E-03,3.32225913621262E-03,3.21151716500554E-03,3.10077519379845E-03,2.99003322259136E-03,2.87929125138427E-03,2.76854928017719E-03,2.6578073089701E-03,2.54706533776301E-03,2.43632336655592E-03,2.32558139534884E-03,2.21483942414175E-03,2.10409745293466E-03,1.99335548172757E-03,1.88261351052049E-03,1.7718715393134E-03,1.66112956810631E-03,1.55038759689922E-03,1.43964562569214E-03,1.32890365448505E-03,1.21816168327796E-03,1.10741971207087E-03,9.96677740863787E-04,8.859357696567E-04,7.75193798449612E-04,6.64451827242524E-04,5.53709856035437E-04,4.42967884828349E-04,3.32225913621262E-04,2.21483942414174E-04,1.10741971207087E-04,}
		valueWeights[dataIndex["default_damage_low"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,25,50,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,8.69565217391304E-03,.008300395256917,7.90513833992095E-03,7.5098814229249E-03,7.11462450592885E-03,6.71936758893281E-03,6.32411067193676E-03,5.92885375494071E-03,5.53359683794466E-03,5.13833992094862E-03,4.74308300395257E-03,4.34782608695652E-03,3.95256916996047E-03,3.55731225296443E-03,3.16205533596838E-03,2.76679841897233E-03,2.37154150197628E-03,1.97628458498024E-03,1.58102766798419E-03,1.18577075098814E-03,7.90513833992096E-04,3.95256916996047E-04,}
		valueWeights[dataIndex["default_damage_high"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,25,50,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,8.69565217391304E-03,.008300395256917,7.90513833992095E-03,7.5098814229249E-03,7.11462450592885E-03,6.71936758893281E-03,6.32411067193676E-03,5.92885375494071E-03,5.53359683794466E-03,5.13833992094862E-03,4.74308300395257E-03,4.34782608695652E-03,3.95256916996047E-03,3.55731225296443E-03,3.16205533596838E-03,2.76679841897233E-03,2.37154150197628E-03,1.97628458498024E-03,1.58102766798419E-03,1.18577075098814E-03,7.90513833992096E-04,3.95256916996047E-04,}
		valueWeights[dataIndex["default_dodge"]] ={5,7.5,7.5,25,50,3.33333333333333,1.66666666666667,4.54545454545455E-03,4.43974630021142E-03,4.33403805496829E-03,4.22832980972516E-03,4.12262156448203E-03,4.0169133192389E-03,3.91120507399577E-03,3.80549682875264E-03,3.69978858350951E-03,3.59408033826639E-03,3.48837209302326E-03,3.38266384778013E-03,.003276955602537,3.17124735729387E-03,3.06553911205074E-03,2.95983086680761E-03,2.85412262156448E-03,2.74841437632135E-03,2.64270613107822E-03,2.5369978858351E-03,2.43128964059197E-03,2.32558139534884E-03,2.21987315010571E-03,2.11416490486258E-03,2.00845665961945E-03,1.90274841437632E-03,1.79704016913319E-03,1.69133192389006E-03,1.58562367864694E-03,1.47991543340381E-03,1.37420718816068E-03,1.26849894291755E-03,1.16279069767442E-03,1.05708245243129E-03,9.51374207188161E-04,8.45665961945032E-04,7.39957716701903E-04,6.34249471458774E-04,5.28541226215646E-04,4.22832980972516E-04,3.17124735729387E-04,2.11416490486258E-04,1.05708245243129E-04,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["default_resis_sleep"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,7.5,15,22.5,30,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["default_resis_silence"]] ={.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["default_resis_weakness"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["default_resis_enlace"]] ={.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		
		valueWeights[dataIndex["grow_hp"]] ={1.25,1.25,1.25,1.25,3.75,3.75,3.75,3.75,25,50,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["grow_mp"]] ={1,1,1,1,1,3,3,3,3,3,25,50,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,6.66666666666667E-03,6.4367816091954E-03,6.20689655172414E-03,5.97701149425287E-03,5.74712643678161E-03,5.51724137931035E-03,5.28735632183908E-03,5.05747126436782E-03,4.82758620689655E-03,4.59770114942529E-03,4.36781609195402E-03,4.13793103448276E-03,3.90804597701149E-03,3.67816091954023E-03,3.44827586206897E-03,3.2183908045977E-03,2.98850574712644E-03,2.75862068965517E-03,2.52873563218391E-03,2.29885057471264E-03,2.06896551724138E-03,1.83908045977012E-03,1.60919540229885E-03,1.37931034482759E-03,1.14942528735632E-03,9.19540229885057E-04,6.89655172413793E-04,4.59770114942529E-04,2.29885057471264E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={5,5,5,5,25,50,3.33333333333333,1.66666666666667,4.65116279069767E-03,4.54042081949059E-03,4.4296788482835E-03,4.31893687707641E-03,4.20819490586932E-03,4.09745293466224E-03,3.98671096345515E-03,3.87596899224806E-03,3.76522702104097E-03,3.65448504983389E-03,3.5437430786268E-03,3.43300110741971E-03,3.32225913621262E-03,3.21151716500554E-03,3.10077519379845E-03,2.99003322259136E-03,2.87929125138427E-03,2.76854928017719E-03,2.6578073089701E-03,2.54706533776301E-03,2.43632336655592E-03,2.32558139534884E-03,2.21483942414175E-03,2.10409745293466E-03,1.99335548172757E-03,1.88261351052049E-03,1.7718715393134E-03,1.66112956810631E-03,1.55038759689922E-03,1.43964562569214E-03,1.32890365448505E-03,1.21816168327796E-03,1.10741971207087E-03,9.96677740863787E-04,8.859357696567E-04,7.75193798449612E-04,6.64451827242524E-04,5.53709856035437E-04,4.42967884828349E-04,3.32225913621262E-04,2.21483942414174E-04,1.10741971207087E-04,}
		valueWeights[dataIndex["grow_damage_low"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,25,50,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,8.69565217391304E-03,.008300395256917,7.90513833992095E-03,7.5098814229249E-03,7.11462450592885E-03,6.71936758893281E-03,6.32411067193676E-03,5.92885375494071E-03,5.53359683794466E-03,5.13833992094862E-03,4.74308300395257E-03,4.34782608695652E-03,3.95256916996047E-03,3.55731225296443E-03,3.16205533596838E-03,2.76679841897233E-03,2.37154150197628E-03,1.97628458498024E-03,1.58102766798419E-03,1.18577075098814E-03,7.90513833992096E-04,3.95256916996047E-04,}
		valueWeights[dataIndex["grow_damage_high"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,25,50,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,8.69565217391304E-03,.008300395256917,7.90513833992095E-03,7.5098814229249E-03,7.11462450592885E-03,6.71936758893281E-03,6.32411067193676E-03,5.92885375494071E-03,5.53359683794466E-03,5.13833992094862E-03,4.74308300395257E-03,4.34782608695652E-03,3.95256916996047E-03,3.55731225296443E-03,3.16205533596838E-03,2.76679841897233E-03,2.37154150197628E-03,1.97628458498024E-03,1.58102766798419E-03,1.18577075098814E-03,7.90513833992096E-04,3.95256916996047E-04,}
		valueWeights[dataIndex["grow_dodge"]] ={5,7.5,7.5,25,50,3.33333333333333,1.66666666666667,4.54545454545455E-03,4.43974630021142E-03,4.33403805496829E-03,4.22832980972516E-03,4.12262156448203E-03,4.0169133192389E-03,3.91120507399577E-03,3.80549682875264E-03,3.69978858350951E-03,3.59408033826639E-03,3.48837209302326E-03,3.38266384778013E-03,.003276955602537,3.17124735729387E-03,3.06553911205074E-03,2.95983086680761E-03,2.85412262156448E-03,2.74841437632135E-03,2.64270613107822E-03,2.5369978858351E-03,2.43128964059197E-03,2.32558139534884E-03,2.21987315010571E-03,2.11416490486258E-03,2.00845665961945E-03,1.90274841437632E-03,1.79704016913319E-03,1.69133192389006E-03,1.58562367864694E-03,1.47991543340381E-03,1.37420718816068E-03,1.26849894291755E-03,1.16279069767442E-03,1.05708245243129E-03,9.51374207188161E-04,8.45665961945032E-04,7.39957716701903E-04,6.34249471458774E-04,5.28541226215646E-04,4.22832980972516E-04,3.17124735729387E-04,2.11416490486258E-04,1.05708245243129E-04,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,7.5,15,22.5,30,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["grow_resis_silence"]] ={.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}

---破刹
	elseif tmplID == talismans["GD_75_PoSha"].tmplID or tmplID == talismans["FX_75_HengTianChi"].tmplID or tmplID == talismans["TH_75_ChunQiuSuo"].tmplID then
		
		valueWeights[dataIndex["default_hp"]] ={1.25,1.25,1.25,1.25,3.75,3.75,3.75,3.75,25,50,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["default_mp"]] ={1,1,1,1,1,3,3,3,3,3,25,50,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,6.66666666666667E-03,6.4367816091954E-03,6.20689655172414E-03,5.97701149425287E-03,5.74712643678161E-03,5.51724137931035E-03,5.28735632183908E-03,5.05747126436782E-03,4.82758620689655E-03,4.59770114942529E-03,4.36781609195402E-03,4.13793103448276E-03,3.90804597701149E-03,3.67816091954023E-03,3.44827586206897E-03,3.2183908045977E-03,2.98850574712644E-03,2.75862068965517E-03,2.52873563218391E-03,2.29885057471264E-03,2.06896551724138E-03,1.83908045977012E-03,1.60919540229885E-03,1.37931034482759E-03,1.14942528735632E-03,9.19540229885057E-04,6.89655172413793E-04,4.59770114942529E-04,2.29885057471264E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={5,5,5,5,25,50,3.33333333333333,1.66666666666667,4.65116279069767E-03,4.54042081949059E-03,4.4296788482835E-03,4.31893687707641E-03,4.20819490586932E-03,4.09745293466224E-03,3.98671096345515E-03,3.87596899224806E-03,3.76522702104097E-03,3.65448504983389E-03,3.5437430786268E-03,3.43300110741971E-03,3.32225913621262E-03,3.21151716500554E-03,3.10077519379845E-03,2.99003322259136E-03,2.87929125138427E-03,2.76854928017719E-03,2.6578073089701E-03,2.54706533776301E-03,2.43632336655592E-03,2.32558139534884E-03,2.21483942414175E-03,2.10409745293466E-03,1.99335548172757E-03,1.88261351052049E-03,1.7718715393134E-03,1.66112956810631E-03,1.55038759689922E-03,1.43964562569214E-03,1.32890365448505E-03,1.21816168327796E-03,1.10741971207087E-03,9.96677740863787E-04,8.859357696567E-04,7.75193798449612E-04,6.64451827242524E-04,5.53709856035437E-04,4.42967884828349E-04,3.32225913621262E-04,2.21483942414174E-04,1.10741971207087E-04,}
		valueWeights[dataIndex["default_damage_low"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,25,50,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,8.69565217391304E-03,.008300395256917,7.90513833992095E-03,7.5098814229249E-03,7.11462450592885E-03,6.71936758893281E-03,6.32411067193676E-03,5.92885375494071E-03,5.53359683794466E-03,5.13833992094862E-03,4.74308300395257E-03,4.34782608695652E-03,3.95256916996047E-03,3.55731225296443E-03,3.16205533596838E-03,2.76679841897233E-03,2.37154150197628E-03,1.97628458498024E-03,1.58102766798419E-03,1.18577075098814E-03,7.90513833992096E-04,3.95256916996047E-04,}
		valueWeights[dataIndex["default_damage_high"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,25,50,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,8.69565217391304E-03,.008300395256917,7.90513833992095E-03,7.5098814229249E-03,7.11462450592885E-03,6.71936758893281E-03,6.32411067193676E-03,5.92885375494071E-03,5.53359683794466E-03,5.13833992094862E-03,4.74308300395257E-03,4.34782608695652E-03,3.95256916996047E-03,3.55731225296443E-03,3.16205533596838E-03,2.76679841897233E-03,2.37154150197628E-03,1.97628458498024E-03,1.58102766798419E-03,1.18577075098814E-03,7.90513833992096E-04,3.95256916996047E-04,}
		valueWeights[dataIndex["default_dodge"]] ={5,7.5,7.5,25,50,3.33333333333333,1.66666666666667,4.54545454545455E-03,4.43974630021142E-03,4.33403805496829E-03,4.22832980972516E-03,4.12262156448203E-03,4.0169133192389E-03,3.91120507399577E-03,3.80549682875264E-03,3.69978858350951E-03,3.59408033826639E-03,3.48837209302326E-03,3.38266384778013E-03,.003276955602537,3.17124735729387E-03,3.06553911205074E-03,2.95983086680761E-03,2.85412262156448E-03,2.74841437632135E-03,2.64270613107822E-03,2.5369978858351E-03,2.43128964059197E-03,2.32558139534884E-03,2.21987315010571E-03,2.11416490486258E-03,2.00845665961945E-03,1.90274841437632E-03,1.79704016913319E-03,1.69133192389006E-03,1.58562367864694E-03,1.47991543340381E-03,1.37420718816068E-03,1.26849894291755E-03,1.16279069767442E-03,1.05708245243129E-03,9.51374207188161E-04,8.45665961945032E-04,7.39957716701903E-04,6.34249471458774E-04,5.28541226215646E-04,4.22832980972516E-04,3.17124735729387E-04,2.11416490486258E-04,1.05708245243129E-04,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["default_resis_sleep"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,7.5,15,22.5,30,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["default_resis_silence"]] ={.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["default_resis_weakness"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["default_resis_enlace"]] ={.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		
		valueWeights[dataIndex["grow_hp"]] ={1.25,1.25,1.25,1.25,3.75,3.75,3.75,3.75,25,50,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["grow_mp"]] ={1,1,1,1,1,3,3,3,3,3,25,50,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,6.66666666666667E-03,6.4367816091954E-03,6.20689655172414E-03,5.97701149425287E-03,5.74712643678161E-03,5.51724137931035E-03,5.28735632183908E-03,5.05747126436782E-03,4.82758620689655E-03,4.59770114942529E-03,4.36781609195402E-03,4.13793103448276E-03,3.90804597701149E-03,3.67816091954023E-03,3.44827586206897E-03,3.2183908045977E-03,2.98850574712644E-03,2.75862068965517E-03,2.52873563218391E-03,2.29885057471264E-03,2.06896551724138E-03,1.83908045977012E-03,1.60919540229885E-03,1.37931034482759E-03,1.14942528735632E-03,9.19540229885057E-04,6.89655172413793E-04,4.59770114942529E-04,2.29885057471264E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={5,5,5,5,25,50,3.33333333333333,1.66666666666667,4.65116279069767E-03,4.54042081949059E-03,4.4296788482835E-03,4.31893687707641E-03,4.20819490586932E-03,4.09745293466224E-03,3.98671096345515E-03,3.87596899224806E-03,3.76522702104097E-03,3.65448504983389E-03,3.5437430786268E-03,3.43300110741971E-03,3.32225913621262E-03,3.21151716500554E-03,3.10077519379845E-03,2.99003322259136E-03,2.87929125138427E-03,2.76854928017719E-03,2.6578073089701E-03,2.54706533776301E-03,2.43632336655592E-03,2.32558139534884E-03,2.21483942414175E-03,2.10409745293466E-03,1.99335548172757E-03,1.88261351052049E-03,1.7718715393134E-03,1.66112956810631E-03,1.55038759689922E-03,1.43964562569214E-03,1.32890365448505E-03,1.21816168327796E-03,1.10741971207087E-03,9.96677740863787E-04,8.859357696567E-04,7.75193798449612E-04,6.64451827242524E-04,5.53709856035437E-04,4.42967884828349E-04,3.32225913621262E-04,2.21483942414174E-04,1.10741971207087E-04,}
		valueWeights[dataIndex["grow_damage_low"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,25,50,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,8.69565217391304E-03,.008300395256917,7.90513833992095E-03,7.5098814229249E-03,7.11462450592885E-03,6.71936758893281E-03,6.32411067193676E-03,5.92885375494071E-03,5.53359683794466E-03,5.13833992094862E-03,4.74308300395257E-03,4.34782608695652E-03,3.95256916996047E-03,3.55731225296443E-03,3.16205533596838E-03,2.76679841897233E-03,2.37154150197628E-03,1.97628458498024E-03,1.58102766798419E-03,1.18577075098814E-03,7.90513833992096E-04,3.95256916996047E-04,}
		valueWeights[dataIndex["grow_damage_high"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,25,50,1,.888888888888889,.777777777777778,.666666666666667,.555555555555556,.444444444444444,.333333333333333,.222222222222222,.111111111111111,8.69565217391304E-03,.008300395256917,7.90513833992095E-03,7.5098814229249E-03,7.11462450592885E-03,6.71936758893281E-03,6.32411067193676E-03,5.92885375494071E-03,5.53359683794466E-03,5.13833992094862E-03,4.74308300395257E-03,4.34782608695652E-03,3.95256916996047E-03,3.55731225296443E-03,3.16205533596838E-03,2.76679841897233E-03,2.37154150197628E-03,1.97628458498024E-03,1.58102766798419E-03,1.18577075098814E-03,7.90513833992096E-04,3.95256916996047E-04,}
		valueWeights[dataIndex["grow_dodge"]] ={5,7.5,7.5,25,50,3.33333333333333,1.66666666666667,4.54545454545455E-03,4.43974630021142E-03,4.33403805496829E-03,4.22832980972516E-03,4.12262156448203E-03,4.0169133192389E-03,3.91120507399577E-03,3.80549682875264E-03,3.69978858350951E-03,3.59408033826639E-03,3.48837209302326E-03,3.38266384778013E-03,.003276955602537,3.17124735729387E-03,3.06553911205074E-03,2.95983086680761E-03,2.85412262156448E-03,2.74841437632135E-03,2.64270613107822E-03,2.5369978858351E-03,2.43128964059197E-03,2.32558139534884E-03,2.21987315010571E-03,2.11416490486258E-03,2.00845665961945E-03,1.90274841437632E-03,1.79704016913319E-03,1.69133192389006E-03,1.58562367864694E-03,1.47991543340381E-03,1.37420718816068E-03,1.26849894291755E-03,1.16279069767442E-03,1.05708245243129E-03,9.51374207188161E-04,8.45665961945032E-04,7.39957716701903E-04,6.34249471458774E-04,5.28541226215646E-04,4.22832980972516E-04,3.17124735729387E-04,2.11416490486258E-04,1.05708245243129E-04,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,7.5,15,22.5,30,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["grow_resis_silence"]] ={.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,.416666666666667,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,.454545454545455,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}

	---done,2007-10-06
	---山河扇	通用 07国庆充值兑奖所需，必须至少是仙品
	elseif (tmplID == talismans["US_75_ShanHeShan"].tmplID and origin == talismanOrigin["lottery"])
	---万毒鼎	通用 07国庆充值兑奖所需，必须至少是仙品
	or (tmplID == talismans["US_75_WanDuDing"].tmplID and origin == talismanOrigin["lottery"]) then
		
		valueWeights[dataIndex["default_hp"]] ={0,0,0,0,0,0,0,0,0,0,0,11,10,.1,.09,.08,.07,.06,.05,3.99999999999999E-02,2.99999999999999E-02,1.99999999999999E-02,9.99999999999991E-03,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_mp"]] ={10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_attack_rate"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,10,.1,.09,.08,.07,.06,.05,3.99999999999999E-02,2.99999999999999E-02,1.99999999999999E-02,9.99999999999991E-03,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,10,.1,.09,.08,.07,.06,.05,3.99999999999999E-02,2.99999999999999E-02,1.99999999999999E-02,9.99999999999991E-03,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_dodge"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,10,.1,.09,.08,.07,.06,.05,3.99999999999999E-02,2.99999999999999E-02,1.99999999999999E-02,9.99999999999991E-03,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,10,.1,.09,.08,.07,.06,.05,3.99999999999999E-02,2.99999999999999E-02,1.99999999999999E-02,9.99999999999991E-03,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,10,.1,.09,.08,.07,.06,.05,3.99999999999999E-02,2.99999999999999E-02,1.99999999999999E-02,9.99999999999991E-03,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,10,.1,.09,.08,.07,.06,.05,3.99999999999999E-02,2.99999999999999E-02,1.99999999999999E-02,9.99999999999991E-03,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,10,.1,.09,.08,.07,.06,.05,3.99999999999999E-02,2.99999999999999E-02,1.99999999999999E-02,9.99999999999991E-03,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		
		valueWeights[dataIndex["grow_hp"]] ={0,0,0,0,0,0,0,0,10,10,.1,.06,.02,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_mp"]] ={10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_attack_rate"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,10,10,.1,.06,.02,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,10,10,.1,.06,.02,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_dodge"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,10,.1,.08,.06,.04,.02,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,10,.1,.08,.06,.04,.02,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,10,.1,.08,.06,.04,.02,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,10,.1,.08,.06,.04,.02,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,10,.1,.08,.06,.04,.02,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}

	---玲珑塔	通用 2007年11月27日更新，22日充值兑奖所需奖品，必须至少是仙品
	elseif tmplID == talismans["US_75_LingLongTa"].tmplID then

		valueWeights[dataIndex["default_hp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,.1,.09,.08,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_mp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_attack_rate"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,.1,.09,.08,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,.1,.09,.08,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_dodge"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,10,.1,.09,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,10,.1,.09,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,10,.1,.09,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,10,.1,.09,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,10,.1,.09,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		
		valueWeights[dataIndex["grow_hp"]] ={0,0,0,0,0,0,0,0,0,0,0,10,10,.1,.06,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_mp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,10,.1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_attack_rate"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,1,10,10,.1,.06,.02,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,1,10,10,.1,.06,.02,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_dodge"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,11,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,11,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,11,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,11,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,11,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}

	---山河扇	通用
	elseif tmplID == talismans["US_75_ShanHeShan"].tmplID 
	---万毒鼎	通用
	or tmplID == talismans["US_75_WanDuDing"].tmplID
	---玉净瓶	通用
	or tmplID == talismans["US_75_YuJingPing"].tmplID then
		
		valueWeights[dataIndex["default_hp"]] ={2.5,2.5,7.5,7.5,7.5,15,22.5,30,2,1.5,1,.5,5.12820512820513E-03,4.99325236167341E-03,4.8582995951417E-03,4.72334682860999E-03,4.58839406207827E-03,4.45344129554656E-03,4.31848852901484E-03,4.18353576248313E-03,4.04858299595142E-03,3.9136302294197E-03,3.77867746288799E-03,3.64372469635628E-03,3.50877192982456E-03,3.37381916329285E-03,3.23886639676113E-03,3.10391363022942E-03,2.96896086369771E-03,2.83400809716599E-03,2.69905533063428E-03,2.56410256410256E-03,2.42914979757085E-03,2.29419703103914E-03,2.15924426450742E-03,2.02429149797571E-03,1.88933873144399E-03,1.75438596491228E-03,1.61943319838057E-03,1.48448043184885E-03,1.34952766531714E-03,1.21457489878542E-03,1.07962213225371E-03,9.44669365721997E-04,8.09716599190284E-04,6.7476383265857E-04,5.39811066126856E-04,4.04858299595142E-04,2.69905533063428E-04,1.34952766531714E-04,}
		valueWeights[dataIndex["default_mp"]] ={2.5,2.5,7.5,7.5,7.5,15,22.5,30,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,5.26315789473684E-03,5.12091038406828E-03,4.97866287339972E-03,4.83641536273115E-03,4.69416785206259E-03,4.55192034139403E-03,4.40967283072546E-03,4.2674253200569E-03,4.12517780938834E-03,3.98293029871977E-03,3.84068278805121E-03,3.69843527738265E-03,3.55618776671408E-03,3.41394025604552E-03,3.27169274537696E-03,3.12944523470839E-03,2.98719772403983E-03,2.84495021337127E-03,2.7027027027027E-03,2.56045519203414E-03,2.41820768136558E-03,2.27596017069701E-03,2.13371266002845E-03,1.99146514935989E-03,1.84921763869132E-03,1.70697012802276E-03,1.5647226173542E-03,1.42247510668563E-03,1.28022759601707E-03,1.13798008534851E-03,9.95732574679943E-04,8.53485064011381E-04,7.11237553342817E-04,5.68990042674253E-04,4.2674253200569E-04,2.84495021337127E-04,1.42247510668564E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={5,5,5,5,25,50,3.33333333333333,1.66666666666667,4.65116279069767E-03,4.54042081949059E-03,4.4296788482835E-03,4.31893687707641E-03,4.20819490586932E-03,4.09745293466224E-03,3.98671096345515E-03,3.87596899224806E-03,3.76522702104097E-03,3.65448504983389E-03,3.5437430786268E-03,3.43300110741971E-03,3.32225913621262E-03,3.21151716500554E-03,3.10077519379845E-03,2.99003322259136E-03,2.87929125138427E-03,2.76854928017719E-03,2.6578073089701E-03,2.54706533776301E-03,2.43632336655592E-03,2.32558139534884E-03,2.21483942414175E-03,2.10409745293466E-03,1.99335548172757E-03,1.88261351052049E-03,1.7718715393134E-03,1.66112956810631E-03,1.55038759689922E-03,1.43964562569214E-03,1.32890365448505E-03,1.21816168327796E-03,1.10741971207087E-03,9.96677740863787E-04,8.859357696567E-04,7.75193798449612E-04,6.64451827242524E-04,5.53709856035437E-04,4.42967884828349E-04,3.32225913621262E-04,2.21483942414174E-04,1.10741971207087E-04,}
		valueWeights[dataIndex["default_damage_low"]] ={1.25,1.25,1.25,1.25,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["default_damage_high"]] ={1.25,1.25,1.25,1.25,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["default_dodge"]] ={5,7.5,7.5,25,50,3.33333333333333,1.66666666666667,4.54545454545455E-03,4.43974630021142E-03,4.33403805496829E-03,4.22832980972516E-03,4.12262156448203E-03,4.0169133192389E-03,3.91120507399577E-03,3.80549682875264E-03,3.69978858350951E-03,3.59408033826639E-03,3.48837209302326E-03,3.38266384778013E-03,.003276955602537,3.17124735729387E-03,3.06553911205074E-03,2.95983086680761E-03,2.85412262156448E-03,2.74841437632135E-03,2.64270613107822E-03,2.5369978858351E-03,2.43128964059197E-03,2.32558139534884E-03,2.21987315010571E-03,2.11416490486258E-03,2.00845665961945E-03,1.90274841437632E-03,1.79704016913319E-03,1.69133192389006E-03,1.58562367864694E-03,1.47991543340381E-03,1.37420718816068E-03,1.26849894291755E-03,1.16279069767442E-03,1.05708245243129E-03,9.51374207188161E-04,8.45665961945032E-04,7.39957716701903E-04,6.34249471458774E-04,5.28541226215646E-04,4.22832980972516E-04,3.17124735729387E-04,2.11416490486258E-04,1.05708245243129E-04,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["default_resis_sleep"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,7.5,15,22.5,30,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["default_resis_silence"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,7.5,15,22.5,30,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["default_resis_weakness"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["default_resis_enlace"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		
		valueWeights[dataIndex["grow_hp"]] ={2.5,2.5,7.5,7.5,7.5,15,22.5,30,2,1.5,1,.5,5.12820512820513E-03,4.99325236167341E-03,4.8582995951417E-03,4.72334682860999E-03,4.58839406207827E-03,4.45344129554656E-03,4.31848852901484E-03,4.18353576248313E-03,4.04858299595142E-03,3.9136302294197E-03,3.77867746288799E-03,3.64372469635628E-03,3.50877192982456E-03,3.37381916329285E-03,3.23886639676113E-03,3.10391363022942E-03,2.96896086369771E-03,2.83400809716599E-03,2.69905533063428E-03,2.56410256410256E-03,2.42914979757085E-03,2.29419703103914E-03,2.15924426450742E-03,2.02429149797571E-03,1.88933873144399E-03,1.75438596491228E-03,1.61943319838057E-03,1.48448043184885E-03,1.34952766531714E-03,1.21457489878542E-03,1.07962213225371E-03,9.44669365721997E-04,8.09716599190284E-04,6.7476383265857E-04,5.39811066126856E-04,4.04858299595142E-04,2.69905533063428E-04,1.34952766531714E-04,}
		valueWeights[dataIndex["grow_mp"]] ={2.5,2.5,7.5,7.5,7.5,15,22.5,30,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,5.26315789473684E-03,5.12091038406828E-03,4.97866287339972E-03,4.83641536273115E-03,4.69416785206259E-03,4.55192034139403E-03,4.40967283072546E-03,4.2674253200569E-03,4.12517780938834E-03,3.98293029871977E-03,3.84068278805121E-03,3.69843527738265E-03,3.55618776671408E-03,3.41394025604552E-03,3.27169274537696E-03,3.12944523470839E-03,2.98719772403983E-03,2.84495021337127E-03,2.7027027027027E-03,2.56045519203414E-03,2.41820768136558E-03,2.27596017069701E-03,2.13371266002845E-03,1.99146514935989E-03,1.84921763869132E-03,1.70697012802276E-03,1.5647226173542E-03,1.42247510668563E-03,1.28022759601707E-03,1.13798008534851E-03,9.95732574679943E-04,8.53485064011381E-04,7.11237553342817E-04,5.68990042674253E-04,4.2674253200569E-04,2.84495021337127E-04,1.42247510668564E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={5,5,5,5,25,50,3.33333333333333,1.66666666666667,4.65116279069767E-03,4.54042081949059E-03,4.4296788482835E-03,4.31893687707641E-03,4.20819490586932E-03,4.09745293466224E-03,3.98671096345515E-03,3.87596899224806E-03,3.76522702104097E-03,3.65448504983389E-03,3.5437430786268E-03,3.43300110741971E-03,3.32225913621262E-03,3.21151716500554E-03,3.10077519379845E-03,2.99003322259136E-03,2.87929125138427E-03,2.76854928017719E-03,2.6578073089701E-03,2.54706533776301E-03,2.43632336655592E-03,2.32558139534884E-03,2.21483942414175E-03,2.10409745293466E-03,1.99335548172757E-03,1.88261351052049E-03,1.7718715393134E-03,1.66112956810631E-03,1.55038759689922E-03,1.43964562569214E-03,1.32890365448505E-03,1.21816168327796E-03,1.10741971207087E-03,9.96677740863787E-04,8.859357696567E-04,7.75193798449612E-04,6.64451827242524E-04,5.53709856035437E-04,4.42967884828349E-04,3.32225913621262E-04,2.21483942414174E-04,1.10741971207087E-04,}
		valueWeights[dataIndex["grow_damage_low"]] ={1.25,1.25,1.25,1.25,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["grow_damage_high"]] ={1.25,1.25,1.25,1.25,3,3,3,3,3,2.08333333333333,4.16666666666667,6.25,8.33333333333333,10.4166666666667,12.5,14.5833333333333,16.6666666666667,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,7.69230769230769E-03,7.38461538461539E-03,7.07692307692308E-03,6.76923076923077E-03,6.46153846153846E-03,6.15384615384615E-03,5.84615384615385E-03,5.53846153846154E-03,5.23076923076923E-03,4.92307692307692E-03,4.61538461538462E-03,4.30769230769231E-03,.004,3.69230769230769E-03,3.38461538461539E-03,3.07692307692308E-03,2.76923076923077E-03,2.46153846153846E-03,2.15384615384615E-03,1.84615384615385E-03,1.53846153846154E-03,1.23076923076923E-03,9.23076923076923E-04,6.15384615384616E-04,3.07692307692307E-04,}
		valueWeights[dataIndex["grow_dodge"]] ={5,7.5,7.5,25,50,3.33333333333333,1.66666666666667,4.54545454545455E-03,4.43974630021142E-03,4.33403805496829E-03,4.22832980972516E-03,4.12262156448203E-03,4.0169133192389E-03,3.91120507399577E-03,3.80549682875264E-03,3.69978858350951E-03,3.59408033826639E-03,3.48837209302326E-03,3.38266384778013E-03,.003276955602537,3.17124735729387E-03,3.06553911205074E-03,2.95983086680761E-03,2.85412262156448E-03,2.74841437632135E-03,2.64270613107822E-03,2.5369978858351E-03,2.43128964059197E-03,2.32558139534884E-03,2.21987315010571E-03,2.11416490486258E-03,2.00845665961945E-03,1.90274841437632E-03,1.79704016913319E-03,1.69133192389006E-03,1.58562367864694E-03,1.47991543340381E-03,1.37420718816068E-03,1.26849894291755E-03,1.16279069767442E-03,1.05708245243129E-03,9.51374207188161E-04,8.45665961945032E-04,7.39957716701903E-04,6.34249471458774E-04,5.28541226215646E-04,4.22832980972516E-04,3.17124735729387E-04,2.11416490486258E-04,1.05708245243129E-04,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,7.5,15,22.5,30,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["grow_resis_silence"]] ={.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,7.5,15,22.5,30,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,.555555555555556,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={.625,.625,.625,.625,.625,.625,.625,.625,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}

	---神木骰	通用
	elseif tmplID == talismans["US_45_ShenMuShai"].tmplID 
			or tmplID == talismans["US_45_ShenMuShai_WZGL"].tmplID then
		
		valueWeights[dataIndex["default_hp"]] ={0,0,0,0,0,0,0,0,0,5,10,15,2.5,1.66666666666667,.833333333333333,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["default_mp"]] ={0,0,0,0,0,0,0,0,5,10,15,2.5,1.66666666666667,.833333333333333,5.40540540540541E-03,5.25525525525526E-03,5.10510510510511E-03,4.95495495495496E-03,4.80480480480481E-03,4.65465465465465E-03,4.5045045045045E-03,4.35435435435435E-03,4.2042042042042E-03,4.05405405405405E-03,3.9039039039039E-03,3.75375375375375E-03,3.6036036036036E-03,3.45345345345345E-03,3.3033033033033E-03,3.15315315315315E-03,.003003003003003,2.85285285285285E-03,2.7027027027027E-03,2.55255255255255E-03,2.4024024024024E-03,2.25225225225225E-03,2.1021021021021E-03,1.95195195195195E-03,1.8018018018018E-03,1.65165165165165E-03,1.5015015015015E-03,1.35135135135135E-03,1.2012012012012E-03,1.05105105105105E-03,9.009009009009E-04,7.5075075075075E-04,6.006006006006E-04,4.5045045045045E-04,3.003003003003E-04,1.5015015015015E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={0,0,0,0,10,20,2.5,1.66666666666667,.833333333333333,4.76190476190476E-03,4.64576074332172E-03,4.52961672473868E-03,4.41347270615563E-03,4.29732868757259E-03,4.18118466898955E-03,4.0650406504065E-03,3.94889663182346E-03,3.83275261324042E-03,3.71660859465738E-03,3.60046457607433E-03,3.48432055749129E-03,3.36817653890825E-03,3.2520325203252E-03,3.13588850174216E-03,3.01974448315912E-03,2.90360046457607E-03,2.78745644599303E-03,2.67131242740999E-03,2.55516840882695E-03,2.4390243902439E-03,2.32288037166086E-03,2.20673635307782E-03,2.09059233449477E-03,1.97444831591173E-03,1.85830429732869E-03,1.74216027874565E-03,1.6260162601626E-03,1.50987224157956E-03,1.39372822299652E-03,1.27758420441347E-03,1.16144018583043E-03,1.04529616724739E-03,9.29152148664344E-04,8.13008130081301E-04,6.96864111498259E-04,5.80720092915215E-04,4.64576074332172E-04,3.48432055749129E-04,2.32288037166087E-04,1.16144018583043E-04,}
		valueWeights[dataIndex["default_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,4,6,8,10,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["default_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,4,6,8,10,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["default_dodge"]] ={0,0,0,0,10,20,3.33333333333333,1.66666666666667,4.65116279069767E-03,4.54042081949059E-03,4.4296788482835E-03,4.31893687707641E-03,4.20819490586932E-03,4.09745293466224E-03,3.98671096345515E-03,3.87596899224806E-03,3.76522702104097E-03,3.65448504983389E-03,3.5437430786268E-03,3.43300110741971E-03,3.32225913621262E-03,3.21151716500554E-03,3.10077519379845E-03,2.99003322259136E-03,2.87929125138427E-03,2.76854928017719E-03,2.6578073089701E-03,2.54706533776301E-03,2.43632336655592E-03,2.32558139534884E-03,2.21483942414175E-03,2.10409745293466E-03,1.99335548172757E-03,1.88261351052049E-03,1.7718715393134E-03,1.66112956810631E-03,1.55038759689922E-03,1.43964562569214E-03,1.32890365448505E-03,1.21816168327796E-03,1.10741971207087E-03,9.96677740863787E-04,8.859357696567E-04,7.75193798449612E-04,6.64451827242524E-04,5.53709856035437E-04,4.42967884828349E-04,3.32225913621262E-04,2.21483942414174E-04,1.10741971207087E-04,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,4,6,8,10,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,8.69565217391304E-03,.008300395256917,7.90513833992095E-03,7.5098814229249E-03,7.11462450592885E-03,6.71936758893281E-03,6.32411067193676E-03,5.92885375494071E-03,5.53359683794466E-03,5.13833992094862E-03,4.74308300395257E-03,4.34782608695652E-03,3.95256916996047E-03,3.55731225296443E-03,3.16205533596838E-03,2.76679841897233E-03,2.37154150197628E-03,1.97628458498024E-03,1.58102766798419E-03,1.18577075098814E-03,7.90513833992096E-04,3.95256916996047E-04,}
		valueWeights[dataIndex["default_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,6,9,12,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,7.40740740740741E-03,7.12250712250712E-03,6.83760683760684E-03,6.55270655270655E-03,6.26780626780627E-03,5.98290598290598E-03,5.6980056980057E-03,5.41310541310541E-03,5.12820512820513E-03,4.84330484330484E-03,4.55840455840456E-03,4.27350427350427E-03,3.98860398860399E-03,3.7037037037037E-03,3.41880341880342E-03,3.13390313390313E-03,2.84900284900285E-03,2.56410256410256E-03,2.27920227920228E-03,1.99430199430199E-03,1.70940170940171E-03,1.42450142450143E-03,1.13960113960114E-03,8.54700854700855E-04,5.6980056980057E-04,2.84900284900285E-04,}
		valueWeights[dataIndex["default_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,6,9,12,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		valueWeights[dataIndex["default_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,4,6,8,10,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,8.33333333333333E-03,7.97101449275362E-03,7.60869565217391E-03,7.2463768115942E-03,6.88405797101449E-03,6.52173913043478E-03,6.15942028985507E-03,5.79710144927536E-03,5.43478260869565E-03,5.07246376811594E-03,4.71014492753623E-03,4.34782608695652E-03,3.98550724637681E-03,3.6231884057971E-03,3.26086956521739E-03,2.89855072463768E-03,2.53623188405797E-03,2.17391304347826E-03,1.81159420289855E-03,1.44927536231884E-03,1.08695652173913E-03,7.2463768115942E-04,3.6231884057971E-04,}
		valueWeights[dataIndex["default_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,4,6,8,10,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,8.33333333333333E-03,7.97101449275362E-03,7.60869565217391E-03,7.2463768115942E-03,6.88405797101449E-03,6.52173913043478E-03,6.15942028985507E-03,5.79710144927536E-03,5.43478260869565E-03,5.07246376811594E-03,4.71014492753623E-03,4.34782608695652E-03,3.98550724637681E-03,3.6231884057971E-03,3.26086956521739E-03,2.89855072463768E-03,2.53623188405797E-03,2.17391304347826E-03,1.81159420289855E-03,1.44927536231884E-03,1.08695652173913E-03,7.2463768115942E-04,3.6231884057971E-04,}
		
		valueWeights[dataIndex["grow_hp"]] ={0,0,0,0,0,0,0,0,0,0,6.66666666666667,13.3333333333333,20,2.5,1.66666666666667,.833333333333333,5.71428571428571E-03,5.54621848739496E-03,5.3781512605042E-03,5.21008403361345E-03,5.04201680672269E-03,4.87394957983193E-03,4.70588235294118E-03,4.53781512605042E-03,4.36974789915966E-03,4.20168067226891E-03,4.03361344537815E-03,3.86554621848739E-03,3.69747899159664E-03,3.52941176470588E-03,3.36134453781513E-03,3.19327731092437E-03,3.02521008403361E-03,2.85714285714286E-03,2.6890756302521E-03,2.52100840336134E-03,2.35294117647059E-03,2.18487394957983E-03,2.01680672268908E-03,1.84873949579832E-03,1.68067226890756E-03,1.51260504201681E-03,1.34453781512605E-03,1.17647058823529E-03,1.00840336134454E-03,8.40336134453781E-04,6.72268907563025E-04,5.04201680672269E-04,3.36134453781512E-04,1.68067226890756E-04,}
		valueWeights[dataIndex["grow_mp"]] ={0,0,0,0,0,0,0,0,6.66666666666667,13.3333333333333,20,2.5,1.66666666666667,.833333333333333,5.40540540540541E-03,5.25525525525526E-03,5.10510510510511E-03,4.95495495495496E-03,4.80480480480481E-03,4.65465465465465E-03,4.5045045045045E-03,4.35435435435435E-03,4.2042042042042E-03,4.05405405405405E-03,3.9039039039039E-03,3.75375375375375E-03,3.6036036036036E-03,3.45345345345345E-03,3.3033033033033E-03,3.15315315315315E-03,.003003003003003,2.85285285285285E-03,2.7027027027027E-03,2.55255255255255E-03,2.4024024024024E-03,2.25225225225225E-03,2.1021021021021E-03,1.95195195195195E-03,1.8018018018018E-03,1.65165165165165E-03,1.5015015015015E-03,1.35135135135135E-03,1.2012012012012E-03,1.05105105105105E-03,9.009009009009E-04,7.5075075075075E-04,6.006006006006E-04,4.5045045045045E-04,3.003003003003E-04,1.5015015015015E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={0,0,0,0,13.3333333333333,26.6666666666667,2.5,1.66666666666667,.833333333333333,4.76190476190476E-03,4.64576074332172E-03,4.52961672473868E-03,4.41347270615563E-03,4.29732868757259E-03,4.18118466898955E-03,4.0650406504065E-03,3.94889663182346E-03,3.83275261324042E-03,3.71660859465738E-03,3.60046457607433E-03,3.48432055749129E-03,3.36817653890825E-03,3.2520325203252E-03,3.13588850174216E-03,3.01974448315912E-03,2.90360046457607E-03,2.78745644599303E-03,2.67131242740999E-03,2.55516840882695E-03,2.4390243902439E-03,2.32288037166086E-03,2.20673635307782E-03,2.09059233449477E-03,1.97444831591173E-03,1.85830429732869E-03,1.74216027874565E-03,1.6260162601626E-03,1.50987224157956E-03,1.39372822299652E-03,1.27758420441347E-03,1.16144018583043E-03,1.04529616724739E-03,9.29152148664344E-04,8.13008130081301E-04,6.96864111498259E-04,5.80720092915215E-04,4.64576074332172E-04,3.48432055749129E-04,2.32288037166087E-04,1.16144018583043E-04,}
		valueWeights[dataIndex["grow_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2.66666666666667,5.33333333333333,8,10.6666666666667,13.3333333333333,2,1.5,1,.5,8.33333333333333E-03,7.97101449275362E-03,7.60869565217391E-03,7.2463768115942E-03,6.88405797101449E-03,6.52173913043478E-03,6.15942028985507E-03,5.79710144927536E-03,5.43478260869565E-03,5.07246376811594E-03,4.71014492753623E-03,4.34782608695652E-03,3.98550724637681E-03,3.6231884057971E-03,3.26086956521739E-03,2.89855072463768E-03,2.53623188405797E-03,2.17391304347826E-03,1.81159420289855E-03,1.44927536231884E-03,1.08695652173913E-03,7.2463768115942E-04,3.6231884057971E-04,}
		valueWeights[dataIndex["grow_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2.66666666666667,5.33333333333333,8,10.6666666666667,13.3333333333333,2,1.5,1,.5,8.33333333333333E-03,7.97101449275362E-03,7.60869565217391E-03,7.2463768115942E-03,6.88405797101449E-03,6.52173913043478E-03,6.15942028985507E-03,5.79710144927536E-03,5.43478260869565E-03,5.07246376811594E-03,4.71014492753623E-03,4.34782608695652E-03,3.98550724637681E-03,3.6231884057971E-03,3.26086956521739E-03,2.89855072463768E-03,2.53623188405797E-03,2.17391304347826E-03,1.81159420289855E-03,1.44927536231884E-03,1.08695652173913E-03,7.2463768115942E-04,3.6231884057971E-04,}
		valueWeights[dataIndex["grow_dodge"]] ={0,0,0,0,13.3333333333333,26.6666666666667,3.33333333333333,1.66666666666667,4.65116279069767E-03,4.54042081949059E-03,4.4296788482835E-03,4.31893687707641E-03,4.20819490586932E-03,4.09745293466224E-03,3.98671096345515E-03,3.87596899224806E-03,3.76522702104097E-03,3.65448504983389E-03,3.5437430786268E-03,3.43300110741971E-03,3.32225913621262E-03,3.21151716500554E-03,3.10077519379845E-03,2.99003322259136E-03,2.87929125138427E-03,2.76854928017719E-03,2.6578073089701E-03,2.54706533776301E-03,2.43632336655592E-03,2.32558139534884E-03,2.21483942414175E-03,2.10409745293466E-03,1.99335548172757E-03,1.88261351052049E-03,1.7718715393134E-03,1.66112956810631E-03,1.55038759689922E-03,1.43964562569214E-03,1.32890365448505E-03,1.21816168327796E-03,1.10741971207087E-03,9.96677740863787E-04,8.859357696567E-04,7.75193798449612E-04,6.64451827242524E-04,5.53709856035437E-04,4.42967884828349E-04,3.32225913621262E-04,2.21483942414174E-04,1.10741971207087E-04,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1.66666666666667,3.33333333333333,5,6.66666666666667,8.33333333333333,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,8.69565217391304E-03,.008300395256917,7.90513833992095E-03,7.5098814229249E-03,7.11462450592885E-03,6.71936758893281E-03,6.32411067193676E-03,5.92885375494071E-03,5.53359683794466E-03,5.13833992094862E-03,4.74308300395257E-03,4.34782608695652E-03,3.95256916996047E-03,3.55731225296443E-03,3.16205533596838E-03,2.76679841897233E-03,2.37154150197628E-03,1.97628458498024E-03,1.58102766798419E-03,1.18577075098814E-03,7.90513833992096E-04,3.95256916996047E-04,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,2.5,5,7.5,10,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,7.40740740740741E-03,7.12250712250712E-03,6.83760683760684E-03,6.55270655270655E-03,6.26780626780627E-03,5.98290598290598E-03,5.6980056980057E-03,5.41310541310541E-03,5.12820512820513E-03,4.84330484330484E-03,4.55840455840456E-03,4.27350427350427E-03,3.98860398860399E-03,3.7037037037037E-03,3.41880341880342E-03,3.13390313390313E-03,2.84900284900285E-03,2.56410256410256E-03,2.27920227920228E-03,1.99430199430199E-03,1.70940170940171E-03,1.42450142450143E-03,1.13960113960114E-03,8.54700854700855E-04,5.6980056980057E-04,2.84900284900285E-04,}
		valueWeights[dataIndex["grow_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,2.5,5,7.5,10,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,7.14285714285714E-03,6.87830687830688E-03,6.61375661375661E-03,6.34920634920635E-03,6.08465608465609E-03,5.82010582010582E-03,5.55555555555556E-03,5.29100529100529E-03,5.02645502645503E-03,4.76190476190476E-03,4.4973544973545E-03,4.23280423280423E-03,3.96825396825397E-03,3.7037037037037E-03,3.43915343915344E-03,3.17460317460317E-03,2.91005291005291E-03,2.64550264550265E-03,2.38095238095238E-03,2.11640211640212E-03,1.85185185185185E-03,1.58730158730159E-03,1.32275132275132E-03,1.05820105820106E-03,7.93650793650794E-04,5.29100529100529E-04,2.64550264550265E-04,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1.66666666666667,3.33333333333333,5,6.66666666666667,8.33333333333333,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,8.33333333333333E-03,7.97101449275362E-03,7.60869565217391E-03,7.2463768115942E-03,6.88405797101449E-03,6.52173913043478E-03,6.15942028985507E-03,5.79710144927536E-03,5.43478260869565E-03,5.07246376811594E-03,4.71014492753623E-03,4.34782608695652E-03,3.98550724637681E-03,3.6231884057971E-03,3.26086956521739E-03,2.89855072463768E-03,2.53623188405797E-03,2.17391304347826E-03,1.81159420289855E-03,1.44927536231884E-03,1.08695652173913E-03,7.2463768115942E-04,3.6231884057971E-04,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1.66666666666667,3.33333333333333,5,6.66666666666667,8.33333333333333,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,8.33333333333333E-03,7.97101449275362E-03,7.60869565217391E-03,7.2463768115942E-03,6.88405797101449E-03,6.52173913043478E-03,6.15942028985507E-03,5.79710144927536E-03,5.43478260869565E-03,5.07246376811594E-03,4.71014492753623E-03,4.34782608695652E-03,3.98550724637681E-03,3.6231884057971E-03,3.26086956521739E-03,2.89855072463768E-03,2.53623188405797E-03,2.17391304347826E-03,1.81159420289855E-03,1.44927536231884E-03,1.08695652173913E-03,7.2463768115942E-04,3.6231884057971E-04,}


	---乾坤青光戒	罡岚
	elseif tmplID == talismans["GW_105_QianKunQingGuangJie"].tmplID or tmplID == talismans["JL_105_GangLan"].tmplID then

		valueWeights[dataIndex["default_hp"]] ={4.76190476190476E-02,4.66666666666667E-02,4.57142857142857E-02,4.47619047619048E-02,4.38095238095238E-02,4.28571428571429E-02,4.19047619047619E-02,4.09523809523809E-02,1,1,1,1,1,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,5,10,15,20,25,2,1.5,1,.5,1.33333333333333E-02,1.23809523809524E-02,1.14285714285714E-02,1.04761904761905E-02,9.52380952380952E-03,8.57142857142857E-03,7.61904761904762E-03,6.66666666666667E-03,5.71428571428571E-03,4.76190476190476E-03,3.80952380952381E-03,2.85714285714286E-03,1.9047619047619E-03,9.52380952380951E-04,}
		valueWeights[dataIndex["default_mp"]] ={1.00806451612903E-02,9.87903225806452E-03,9.67741935483871E-03,9.4758064516129E-03,2.5,2.5,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,12.5,25,37.5,2.5,1.66666666666667,.833333333333333,.00625,6.04838709677419E-03,5.84677419354839E-03,5.64516129032258E-03,5.44354838709677E-03,5.24193548387097E-03,5.04032258064516E-03,4.83870967741936E-03,4.63709677419355E-03,4.43548387096774E-03,4.23387096774194E-03,4.03225806451613E-03,3.83064516129032E-03,3.62903225806452E-03,3.42741935483871E-03,3.2258064516129E-03,3.0241935483871E-03,2.82258064516129E-03,2.62096774193548E-03,2.41935483870968E-03,2.21774193548387E-03,2.01612903225806E-03,1.81451612903226E-03,1.61290322580645E-03,1.41129032258065E-03,1.20967741935484E-03,1.00806451612903E-03,8.06451612903226E-04,6.0483870967742E-04,4.03225806451613E-04,2.01612903225807E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={6.41025641025641E-03,6.28205128205128E-03,5,3.75,3.75,3.75,3.75,25,50,3.33333333333333,1.66666666666667,.005,4.87179487179487E-03,4.74358974358974E-03,4.61538461538462E-03,4.48717948717949E-03,4.35897435897436E-03,4.23076923076923E-03,4.1025641025641E-03,3.97435897435897E-03,3.84615384615385E-03,3.71794871794872E-03,3.58974358974359E-03,3.46153846153846E-03,3.33333333333333E-03,3.20512820512821E-03,3.07692307692308E-03,2.94871794871795E-03,2.82051282051282E-03,2.69230769230769E-03,2.56410256410256E-03,2.43589743589744E-03,2.30769230769231E-03,2.17948717948718E-03,2.05128205128205E-03,1.92307692307692E-03,1.7948717948718E-03,1.66666666666667E-03,1.53846153846154E-03,1.41025641025641E-03,1.28205128205128E-03,1.15384615384615E-03,1.02564102564103E-03,8.97435897435898E-04,7.69230769230769E-04,6.41025641025641E-04,5.12820512820513E-04,3.84615384615385E-04,2.56410256410256E-04,1.28205128205128E-04,}
		valueWeights[dataIndex["default_damage_low"]] ={2.92397660818713E-02,2.86549707602339E-02,2.80701754385965E-02,2.74853801169591E-02,2.69005847953216E-02,2.63157894736842E-02,2.57309941520468E-02,2.51461988304094E-02,1.25,1.25,1.25,1.25,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,7.5,15,22.5,30,3.33333333333333,1.66666666666667,1.05263157894737E-02,9.94152046783626E-03,9.35672514619883E-03,8.7719298245614E-03,8.18713450292398E-03,7.60233918128655E-03,7.01754385964912E-03,6.4327485380117E-03,5.84795321637427E-03,5.26315789473684E-03,4.67836257309942E-03,4.09356725146199E-03,3.50877192982456E-03,2.92397660818713E-03,2.33918128654971E-03,1.75438596491228E-03,1.16959064327485E-03,5.84795321637426E-04,}
		valueWeights[dataIndex["default_damage_high"]] ={2.92397660818713E-02,2.86549707602339E-02,2.80701754385965E-02,2.74853801169591E-02,2.69005847953216E-02,2.63157894736842E-02,2.57309941520468E-02,2.51461988304094E-02,1.25,1.25,1.25,1.25,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,7.5,15,22.5,30,3.33333333333333,1.66666666666667,1.05263157894737E-02,9.94152046783626E-03,9.35672514619883E-03,8.7719298245614E-03,8.18713450292398E-03,7.60233918128655E-03,7.01754385964912E-03,6.4327485380117E-03,5.84795321637427E-03,5.26315789473684E-03,4.67836257309942E-03,4.09356725146199E-03,3.50877192982456E-03,2.92397660818713E-03,2.33918128654971E-03,1.75438596491228E-03,1.16959064327485E-03,5.84795321637426E-04,}
		valueWeights[dataIndex["default_dodge"]] ={6.09756097560976E-03,5,3.75,3.75,3.75,3.75,25,50,3.33333333333333,1.66666666666667,4.87804878048781E-03,4.75609756097561E-03,4.63414634146342E-03,4.51219512195122E-03,4.39024390243902E-03,4.26829268292683E-03,4.14634146341464E-03,4.02439024390244E-03,3.90243902439024E-03,3.78048780487805E-03,3.65853658536585E-03,3.53658536585366E-03,3.41463414634146E-03,3.29268292682927E-03,3.17073170731707E-03,3.04878048780488E-03,2.92682926829268E-03,2.80487804878049E-03,2.68292682926829E-03,2.5609756097561E-03,2.4390243902439E-03,2.31707317073171E-03,2.19512195121951E-03,2.07317073170732E-03,1.95121951219512E-03,1.82926829268293E-03,1.70731707317073E-03,1.58536585365854E-03,1.46341463414634E-03,1.34146341463415E-03,1.21951219512195E-03,1.09756097560976E-03,9.75609756097561E-04,8.53658536585367E-04,7.31707317073171E-04,6.09756097560976E-04,4.87804878048781E-04,3.65853658536586E-04,2.4390243902439E-04,1.21951219512195E-04,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={.178571428571429,.175,.171428571428571,.167857142857143,.164285714285714,.160714285714286,.157142857142857,.153571428571429,.15,.146428571428571,.142857142857143,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,2.5,1.66666666666667,.833333333333333,.025,2.14285714285714E-02,1.78571428571429E-02,1.42857142857143E-02,1.07142857142857E-02,7.14285714285714E-03,3.57142857142857E-03,}
		valueWeights[dataIndex["default_resis_sleep"]] ={.178571428571429,.175,.171428571428571,.167857142857143,.164285714285714,.160714285714286,.157142857142857,.153571428571429,.15,.146428571428571,.142857142857143,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,2.5,1.66666666666667,.833333333333333,.025,2.14285714285714E-02,1.78571428571429E-02,1.42857142857143E-02,1.07142857142857E-02,7.14285714285714E-03,3.57142857142857E-03,}
		valueWeights[dataIndex["default_resis_silence"]] ={6.41025641025641E-02,6.28205128205128E-02,6.15384615384615E-02,6.02564102564103E-02,.058974358974359,5.76923076923077E-02,5.64102564102564E-02,5.51282051282051E-02,1.25,1.25,1.25,1.25,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.66666666666667,3.33333333333333,5,6.66666666666667,8.33333333333333,10,11.6666666666667,13.3333333333333,15,2,1.5,1,.5,1.53846153846154E-02,1.41025641025641E-02,1.28205128205128E-02,1.15384615384615E-02,1.02564102564103E-02,8.97435897435898E-03,7.69230769230769E-03,6.41025641025641E-03,5.12820512820513E-03,3.84615384615385E-03,2.56410256410257E-03,1.28205128205128E-03,}
		valueWeights[dataIndex["default_resis_weakness"]] ={.111111111111111,.108888888888889,.106666666666667,.104444444444444,.102222222222222,.1,9.77777777777778E-02,9.55555555555556E-02,9.33333333333333E-02,1,1,1,1,1,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,2,1.5,1,.5,.02,1.77777777777778E-02,1.55555555555556E-02,1.33333333333333E-02,1.11111111111111E-02,8.88888888888889E-03,6.66666666666667E-03,4.44444444444445E-03,2.22222222222222E-03,}
		valueWeights[dataIndex["default_resis_enlace"]] ={.111111111111111,.108888888888889,.106666666666667,.104444444444444,.102222222222222,.1,9.77777777777778E-02,9.55555555555556E-02,9.33333333333333E-02,1,1,1,1,1,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,2,1.5,1,.5,.02,1.77777777777778E-02,1.55555555555556E-02,1.33333333333333E-02,1.11111111111111E-02,8.88888888888889E-03,6.66666666666667E-03,4.44444444444445E-03,2.22222222222222E-03,}
		
		valueWeights[dataIndex["grow_hp"]] ={3.26797385620915E-02,3.20261437908497E-02,3.13725490196078E-02,.030718954248366,3.00653594771242E-02,2.94117647058824E-02,2.87581699346405E-02,2.81045751633987E-02,1.25,1.25,1.25,1.25,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,12.5,25,37.5,2,1.5,1,.5,1.11111111111111E-02,1.04575163398693E-02,9.80392156862745E-03,9.15032679738562E-03,8.49673202614379E-03,7.84313725490196E-03,7.18954248366013E-03,6.5359477124183E-03,5.88235294117647E-03,5.22875816993464E-03,4.57516339869281E-03,3.92156862745098E-03,3.26797385620915E-03,2.61437908496732E-03,1.96078431372549E-03,1.30718954248366E-03,6.53594771241829E-04,}
		valueWeights[dataIndex["grow_mp"]] ={8.40336134453781E-03,8.23529411764706E-03,8.0672268907563E-03,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,25,50,2.5,1.66666666666667,.833333333333333,5.71428571428571E-03,5.54621848739496E-03,5.3781512605042E-03,5.21008403361345E-03,5.04201680672269E-03,4.87394957983193E-03,4.70588235294118E-03,4.53781512605042E-03,4.36974789915966E-03,4.20168067226891E-03,4.03361344537815E-03,3.86554621848739E-03,3.69747899159664E-03,3.52941176470588E-03,3.36134453781513E-03,3.19327731092437E-03,3.02521008403361E-03,2.85714285714286E-03,2.6890756302521E-03,2.52100840336134E-03,2.35294117647059E-03,2.18487394957983E-03,2.01680672268908E-03,1.84873949579832E-03,1.68067226890756E-03,1.51260504201681E-03,1.34453781512605E-03,1.17647058823529E-03,1.00840336134454E-03,8.40336134453781E-04,6.72268907563025E-04,5.04201680672269E-04,3.36134453781512E-04,1.68067226890756E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={6.41025641025641E-03,6.28205128205128E-03,5,3.75,3.75,3.75,3.75,25,50,3.33333333333333,1.66666666666667,.005,4.87179487179487E-03,4.74358974358974E-03,4.61538461538462E-03,4.48717948717949E-03,4.35897435897436E-03,4.23076923076923E-03,4.1025641025641E-03,3.97435897435897E-03,3.84615384615385E-03,3.71794871794872E-03,3.58974358974359E-03,3.46153846153846E-03,3.33333333333333E-03,3.20512820512821E-03,3.07692307692308E-03,2.94871794871795E-03,2.82051282051282E-03,2.69230769230769E-03,2.56410256410256E-03,2.43589743589744E-03,2.30769230769231E-03,2.17948717948718E-03,2.05128205128205E-03,1.92307692307692E-03,1.7948717948718E-03,1.66666666666667E-03,1.53846153846154E-03,1.41025641025641E-03,1.28205128205128E-03,1.15384615384615E-03,1.02564102564103E-03,8.97435897435898E-04,7.69230769230769E-04,6.41025641025641E-04,5.12820512820513E-04,3.84615384615385E-04,2.56410256410256E-04,1.28205128205128E-04,}
		valueWeights[dataIndex["grow_damage_low"]] ={1.97628458498024E-02,1.93675889328063E-02,1.89723320158103E-02,1.85770750988142E-02,1.81818181818182E-02,1.77865612648221E-02,1.73913043478261E-02,1.25,1.25,1.25,1.25,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,25,50,3.33333333333333,1.66666666666667,8.69565217391304E-03,.008300395256917,7.90513833992095E-03,7.5098814229249E-03,7.11462450592885E-03,6.71936758893281E-03,6.32411067193676E-03,5.92885375494071E-03,5.53359683794466E-03,5.13833992094862E-03,4.74308300395257E-03,4.34782608695652E-03,3.95256916996047E-03,3.55731225296443E-03,3.16205533596838E-03,2.76679841897233E-03,2.37154150197628E-03,1.97628458498024E-03,1.58102766798419E-03,1.18577075098814E-03,7.90513833992096E-04,3.95256916996047E-04,}
		valueWeights[dataIndex["grow_damage_high"]] ={1.97628458498024E-02,1.93675889328063E-02,1.89723320158103E-02,1.85770750988142E-02,1.81818181818182E-02,1.77865612648221E-02,1.73913043478261E-02,1.25,1.25,1.25,1.25,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,25,50,3.33333333333333,1.66666666666667,8.69565217391304E-03,.008300395256917,7.90513833992095E-03,7.5098814229249E-03,7.11462450592885E-03,6.71936758893281E-03,6.32411067193676E-03,5.92885375494071E-03,5.53359683794466E-03,5.13833992094862E-03,4.74308300395257E-03,4.34782608695652E-03,3.95256916996047E-03,3.55731225296443E-03,3.16205533596838E-03,2.76679841897233E-03,2.37154150197628E-03,1.97628458498024E-03,1.58102766798419E-03,1.18577075098814E-03,7.90513833992096E-04,3.95256916996047E-04,}
		valueWeights[dataIndex["grow_dodge"]] ={6.09756097560976E-03,5,3.75,3.75,3.75,3.75,25,50,3.33333333333333,1.66666666666667,4.87804878048781E-03,4.75609756097561E-03,4.63414634146342E-03,4.51219512195122E-03,4.39024390243902E-03,4.26829268292683E-03,4.14634146341464E-03,4.02439024390244E-03,3.90243902439024E-03,3.78048780487805E-03,3.65853658536585E-03,3.53658536585366E-03,3.41463414634146E-03,3.29268292682927E-03,3.17073170731707E-03,3.04878048780488E-03,2.92682926829268E-03,2.80487804878049E-03,2.68292682926829E-03,2.5609756097561E-03,2.4390243902439E-03,2.31707317073171E-03,2.19512195121951E-03,2.07317073170732E-03,1.95121951219512E-03,1.82926829268293E-03,1.70731707317073E-03,1.58536585365854E-03,1.46341463414634E-03,1.34146341463415E-03,1.21951219512195E-03,1.09756097560976E-03,9.75609756097561E-04,8.53658536585367E-04,7.31707317073171E-04,6.09756097560976E-04,4.87804878048781E-04,3.65853658536586E-04,2.4390243902439E-04,1.21951219512195E-04,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={5.49450549450549E-02,5.38461538461538E-02,5.27472527472527E-02,5.16483516483516E-02,5.05494505494506E-02,4.94505494505494E-02,4.83516483516483E-02,4.72527472527473E-02,4.61538461538461E-02,4.50549450549451E-02,1,1,1,1,1,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,6.66666666666667,13.3333333333333,20,3.33333333333333,1.66666666666667,1.42857142857143E-02,1.31868131868132E-02,1.20879120879121E-02,.010989010989011,9.89010989010989E-03,8.79120879120879E-03,7.69230769230769E-03,6.59340659340659E-03,5.49450549450549E-03,4.3956043956044E-03,3.2967032967033E-03,2.1978021978022E-03,1.0989010989011E-03,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={5.49450549450549E-02,5.38461538461538E-02,5.27472527472527E-02,5.16483516483516E-02,5.05494505494506E-02,4.94505494505494E-02,4.83516483516483E-02,4.72527472527473E-02,4.61538461538461E-02,4.50549450549451E-02,1,1,1,1,1,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,6.66666666666667,13.3333333333333,20,3.33333333333333,1.66666666666667,1.42857142857143E-02,1.31868131868132E-02,1.20879120879121E-02,.010989010989011,9.89010989010989E-03,8.79120879120879E-03,7.69230769230769E-03,6.59340659340659E-03,5.49450549450549E-03,4.3956043956044E-03,3.2967032967033E-03,2.1978021978022E-03,1.0989010989011E-03,}
		valueWeights[dataIndex["grow_resis_silence"]] ={2.16450216450216E-02,2.12121212121212E-02,2.07792207792208E-02,2.03463203463203E-02,1.99134199134199E-02,1.94805194805195E-02,1.25,1.25,1.25,1.25,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,2.66666666666667,5.33333333333333,8,10.6666666666667,13.3333333333333,2.5,1.66666666666667,.833333333333333,9.09090909090909E-03,8.65800865800866E-03,8.22510822510823E-03,7.79220779220779E-03,7.35930735930736E-03,6.92640692640693E-03,6.49350649350649E-03,6.06060606060606E-03,5.62770562770563E-03,5.19480519480519E-03,4.76190476190476E-03,4.32900432900433E-03,3.8961038961039E-03,3.46320346320346E-03,3.03030303030303E-03,2.5974025974026E-03,2.16450216450216E-03,1.73160173160173E-03,1.2987012987013E-03,8.65800865800865E-04,4.32900432900432E-04,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={3.67647058823529E-02,3.60294117647059E-02,3.52941176470588E-02,3.45588235294118E-02,3.38235294117647E-02,3.30882352941176E-02,3.23529411764706E-02,3.16176470588235E-02,1,1,1,1,1,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,4,8,12,16,2.5,1.66666666666667,.833333333333333,1.17647058823529E-02,1.10294117647059E-02,1.02941176470588E-02,9.55882352941177E-03,8.82352941176471E-03,8.08823529411765E-03,7.35294117647059E-03,6.61764705882353E-03,5.88235294117647E-03,5.14705882352941E-03,4.41176470588235E-03,3.67647058823529E-03,2.94117647058824E-03,2.20588235294118E-03,1.47058823529412E-03,7.3529411764706E-04,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={3.67647058823529E-02,3.60294117647059E-02,3.52941176470588E-02,3.45588235294118E-02,3.38235294117647E-02,3.30882352941176E-02,3.23529411764706E-02,3.16176470588235E-02,1,1,1,1,1,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,4,8,12,16,2.5,1.66666666666667,.833333333333333,1.17647058823529E-02,1.10294117647059E-02,1.02941176470588E-02,9.55882352941177E-03,8.82352941176471E-03,8.08823529411765E-03,7.35294117647059E-03,6.61764705882353E-03,5.88235294117647E-03,5.14705882352941E-03,4.41176470588235E-03,3.67647058823529E-03,2.94117647058824E-03,2.20588235294118E-03,1.47058823529412E-03,7.3529411764706E-04,}

	---千媚莲	贪狼
	elseif tmplID == talismans["HH_105_QianMeiLian"].tmplID or tmplID == talismans["HG_105_TanLang"].tmplID then

		valueWeights[dataIndex["default_hp"]] ={2.63157894736842E-02,2.57894736842105E-02,2.52631578947368E-02,2.47368421052632E-02,2.42105263157895E-02,2.36842105263158E-02,2.31578947368421E-02,1,1,1,1,1,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,7.5,15,22.5,30,2.5,1.66666666666667,.833333333333333,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["default_mp"]] ={1.14942528735632E-02,.011264367816092,1.10344827586207E-02,1.08045977011494E-02,2.5,2.5,1.875,1.875,1.875,1.875,1.875,1.875,1.875,1.875,7.5,15,22.5,30,2.5,1.66666666666667,.833333333333333,6.66666666666667E-03,6.4367816091954E-03,6.20689655172414E-03,5.97701149425287E-03,5.74712643678161E-03,5.51724137931035E-03,5.28735632183908E-03,5.05747126436782E-03,4.82758620689655E-03,4.59770114942529E-03,4.36781609195402E-03,4.13793103448276E-03,3.90804597701149E-03,3.67816091954023E-03,3.44827586206897E-03,3.2183908045977E-03,2.98850574712644E-03,2.75862068965517E-03,2.52873563218391E-03,2.29885057471264E-03,2.06896551724138E-03,1.83908045977012E-03,1.60919540229885E-03,1.37931034482759E-03,1.14942528735632E-03,9.19540229885057E-04,6.89655172413793E-04,4.59770114942529E-04,2.29885057471264E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={4.16666666666667E-02,4.08333333333333E-02,.04,3.91666666666667E-02,3.83333333333333E-02,.0375,3.66666666666667E-02,1,1,1,1,1,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["default_damage_low"]] ={6.41025641025641E-02,6.28205128205128E-02,6.15384615384615E-02,6.02564102564103E-02,.058974358974359,5.76923076923077E-02,5.64102564102564E-02,5.51282051282051E-02,5.38461538461538E-02,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,5,10,15,20,25,2.5,1.66666666666667,.833333333333333,1.53846153846154E-02,1.41025641025641E-02,1.28205128205128E-02,1.15384615384615E-02,1.02564102564103E-02,8.97435897435898E-03,7.69230769230769E-03,6.41025641025641E-03,5.12820512820513E-03,3.84615384615385E-03,2.56410256410257E-03,1.28205128205128E-03,}
		valueWeights[dataIndex["default_damage_high"]] ={6.41025641025641E-02,6.28205128205128E-02,6.15384615384615E-02,6.02564102564103E-02,.058974358974359,5.76923076923077E-02,5.64102564102564E-02,5.51282051282051E-02,5.38461538461538E-02,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,5,10,15,20,25,2.5,1.66666666666667,.833333333333333,1.53846153846154E-02,1.41025641025641E-02,1.28205128205128E-02,1.15384615384615E-02,1.02564102564103E-02,8.97435897435898E-03,7.69230769230769E-03,6.41025641025641E-03,5.12820512820513E-03,3.84615384615385E-03,2.56410256410257E-03,1.28205128205128E-03,}
		valueWeights[dataIndex["default_dodge"]] ={4.16666666666667E-02,4.08333333333333E-02,.04,3.91666666666667E-02,3.83333333333333E-02,.0375,3.66666666666667E-02,1,1,1,1,1,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={.111111111111111,.108888888888889,.106666666666667,.104444444444444,.102222222222222,.1,9.77777777777778E-02,9.55555555555556E-02,9.33333333333333E-02,1,1,1,1,1,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,2,1.5,1,.5,.02,1.77777777777778E-02,1.55555555555556E-02,1.33333333333333E-02,1.11111111111111E-02,8.88888888888889E-03,6.66666666666667E-03,4.44444444444445E-03,2.22222222222222E-03,}
		valueWeights[dataIndex["default_resis_sleep"]] ={.111111111111111,.108888888888889,.106666666666667,.104444444444444,.102222222222222,.1,9.77777777777778E-02,9.55555555555556E-02,9.33333333333333E-02,1,1,1,1,1,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,2,1.5,1,.5,.02,1.77777777777778E-02,1.55555555555556E-02,1.33333333333333E-02,1.11111111111111E-02,8.88888888888889E-03,6.66666666666667E-03,4.44444444444445E-03,2.22222222222222E-03,}
		valueWeights[dataIndex["default_resis_silence"]] ={6.41025641025641E-02,6.28205128205128E-02,6.15384615384615E-02,6.02564102564103E-02,.058974358974359,5.76923076923077E-02,5.64102564102564E-02,5.51282051282051E-02,1.25,1.25,1.25,1.25,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.66666666666667,3.33333333333333,5,6.66666666666667,8.33333333333333,10,11.6666666666667,13.3333333333333,15,2,1.5,1,.5,1.53846153846154E-02,1.41025641025641E-02,1.28205128205128E-02,1.15384615384615E-02,1.02564102564103E-02,8.97435897435898E-03,7.69230769230769E-03,6.41025641025641E-03,5.12820512820513E-03,3.84615384615385E-03,2.56410256410257E-03,1.28205128205128E-03,}
		valueWeights[dataIndex["default_resis_weakness"]] ={.178571428571429,.175,.171428571428571,.167857142857143,.164285714285714,.160714285714286,.157142857142857,.153571428571429,.15,.146428571428571,.142857142857143,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,2.5,1.66666666666667,.833333333333333,.025,2.14285714285714E-02,1.78571428571429E-02,1.42857142857143E-02,1.07142857142857E-02,7.14285714285714E-03,3.57142857142857E-03,}
		valueWeights[dataIndex["default_resis_enlace"]] ={.178571428571429,.175,.171428571428571,.167857142857143,.164285714285714,.160714285714286,.157142857142857,.153571428571429,.15,.146428571428571,.142857142857143,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,2.5,1.66666666666667,.833333333333333,.025,2.14285714285714E-02,1.78571428571429E-02,1.42857142857143E-02,1.07142857142857E-02,7.14285714285714E-03,3.57142857142857E-03,}
		
		valueWeights[dataIndex["grow_hp"]] ={1.97628458498024E-02,1.93675889328063E-02,1.89723320158103E-02,1.85770750988142E-02,1.81818181818182E-02,1.77865612648221E-02,1.73913043478261E-02,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,25,50,2.5,1.66666666666667,.833333333333333,8.69565217391304E-03,.008300395256917,7.90513833992095E-03,7.5098814229249E-03,7.11462450592885E-03,6.71936758893281E-03,6.32411067193676E-03,5.92885375494071E-03,5.53359683794466E-03,5.13833992094862E-03,4.74308300395257E-03,4.34782608695652E-03,3.95256916996047E-03,3.55731225296443E-03,3.16205533596838E-03,2.76679841897233E-03,2.37154150197628E-03,1.97628458498024E-03,1.58102766798419E-03,1.18577075098814E-03,7.90513833992096E-04,3.95256916996047E-04,}
		valueWeights[dataIndex["grow_mp"]] ={9.46969696969697E-03,9.28030303030303E-03,9.09090909090909E-03,1.66666666666667,1.66666666666667,1.66666666666667,2.5,2.5,2.5,2.5,2.5,2.5,12.5,25,37.5,2.5,1.66666666666667,.833333333333333,6.06060606060606E-03,5.87121212121212E-03,5.68181818181818E-03,5.49242424242424E-03,5.3030303030303E-03,5.11363636363636E-03,4.92424242424242E-03,4.73484848484849E-03,4.54545454545455E-03,4.35606060606061E-03,4.16666666666667E-03,3.97727272727273E-03,3.78787878787879E-03,3.59848484848485E-03,3.40909090909091E-03,3.21969696969697E-03,3.03030303030303E-03,2.84090909090909E-03,2.65151515151515E-03,2.46212121212121E-03,2.27272727272727E-03,2.08333333333333E-03,1.89393939393939E-03,1.70454545454545E-03,1.51515151515152E-03,1.32575757575758E-03,1.13636363636364E-03,9.46969696969697E-04,7.57575757575757E-04,5.68181818181818E-04,3.78787878787879E-04,1.8939393939394E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={4.16666666666667E-02,4.08333333333333E-02,.04,3.91666666666667E-02,3.83333333333333E-02,.0375,3.66666666666667E-02,1,1,1,1,1,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["grow_damage_low"]] ={3.67647058823529E-02,3.60294117647059E-02,3.52941176470588E-02,3.45588235294118E-02,3.38235294117647E-02,3.30882352941176E-02,3.23529411764706E-02,3.16176470588235E-02,3.08823529411765E-02,1,1,1,1,1,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,12.5,25,37.5,2.5,1.66666666666667,.833333333333333,1.17647058823529E-02,1.10294117647059E-02,1.02941176470588E-02,9.55882352941177E-03,8.82352941176471E-03,8.08823529411765E-03,7.35294117647059E-03,6.61764705882353E-03,5.88235294117647E-03,5.14705882352941E-03,4.41176470588235E-03,3.67647058823529E-03,2.94117647058824E-03,2.20588235294118E-03,1.47058823529412E-03,7.3529411764706E-04,}
		valueWeights[dataIndex["grow_damage_high"]] ={3.67647058823529E-02,3.60294117647059E-02,3.52941176470588E-02,3.45588235294118E-02,3.38235294117647E-02,3.30882352941176E-02,3.23529411764706E-02,3.16176470588235E-02,3.08823529411765E-02,1,1,1,1,1,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,12.5,25,37.5,2.5,1.66666666666667,.833333333333333,1.17647058823529E-02,1.10294117647059E-02,1.02941176470588E-02,9.55882352941177E-03,8.82352941176471E-03,8.08823529411765E-03,7.35294117647059E-03,6.61764705882353E-03,5.88235294117647E-03,5.14705882352941E-03,4.41176470588235E-03,3.67647058823529E-03,2.94117647058824E-03,2.20588235294118E-03,1.47058823529412E-03,7.3529411764706E-04,}
		valueWeights[dataIndex["grow_dodge"]] ={4.16666666666667E-02,4.08333333333333E-02,.04,3.91666666666667E-02,3.83333333333333E-02,.0375,3.66666666666667E-02,1,1,1,1,1,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.0125,1.16666666666667E-02,1.08333333333333E-02,.01,9.16666666666667E-03,8.33333333333334E-03,.0075,6.66666666666667E-03,5.83333333333333E-03,.005,4.16666666666667E-03,3.33333333333333E-03,.0025,1.66666666666667E-03,8.33333333333334E-04,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={3.67647058823529E-02,3.60294117647059E-02,3.52941176470588E-02,3.45588235294118E-02,3.38235294117647E-02,3.30882352941176E-02,3.23529411764706E-02,3.16176470588235E-02,1,1,1,1,1,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,4,8,12,16,2.5,1.66666666666667,.833333333333333,1.17647058823529E-02,1.10294117647059E-02,1.02941176470588E-02,9.55882352941177E-03,8.82352941176471E-03,8.08823529411765E-03,7.35294117647059E-03,6.61764705882353E-03,5.88235294117647E-03,5.14705882352941E-03,4.41176470588235E-03,3.67647058823529E-03,2.94117647058824E-03,2.20588235294118E-03,1.47058823529412E-03,7.3529411764706E-04,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={3.67647058823529E-02,3.60294117647059E-02,3.52941176470588E-02,3.45588235294118E-02,3.38235294117647E-02,3.30882352941176E-02,3.23529411764706E-02,3.16176470588235E-02,1,1,1,1,1,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,4,8,12,16,2.5,1.66666666666667,.833333333333333,1.17647058823529E-02,1.10294117647059E-02,1.02941176470588E-02,9.55882352941177E-03,8.82352941176471E-03,8.08823529411765E-03,7.35294117647059E-03,6.61764705882353E-03,5.88235294117647E-03,5.14705882352941E-03,4.41176470588235E-03,3.67647058823529E-03,2.94117647058824E-03,2.20588235294118E-03,1.47058823529412E-03,7.3529411764706E-04,}
		valueWeights[dataIndex["grow_resis_silence"]] ={2.16450216450216E-02,2.12121212121212E-02,2.07792207792208E-02,2.03463203463203E-02,1.99134199134199E-02,1.94805194805195E-02,1.25,1.25,1.25,1.25,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,2.66666666666667,5.33333333333333,8,10.6666666666667,13.3333333333333,2.5,1.66666666666667,.833333333333333,9.09090909090909E-03,8.65800865800866E-03,8.22510822510823E-03,7.79220779220779E-03,7.35930735930736E-03,6.92640692640693E-03,6.49350649350649E-03,6.06060606060606E-03,5.62770562770563E-03,5.19480519480519E-03,4.76190476190476E-03,4.32900432900433E-03,3.8961038961039E-03,3.46320346320346E-03,3.03030303030303E-03,2.5974025974026E-03,2.16450216450216E-03,1.73160173160173E-03,1.2987012987013E-03,8.65800865800865E-04,4.32900432900432E-04,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={5.49450549450549E-02,5.38461538461538E-02,5.27472527472527E-02,5.16483516483516E-02,5.05494505494506E-02,4.94505494505494E-02,4.83516483516483E-02,4.72527472527473E-02,4.61538461538461E-02,4.50549450549451E-02,1,1,1,1,1,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,6.66666666666667,13.3333333333333,20,3.33333333333333,1.66666666666667,1.42857142857143E-02,1.31868131868132E-02,1.20879120879121E-02,.010989010989011,9.89010989010989E-03,8.79120879120879E-03,7.69230769230769E-03,6.59340659340659E-03,5.49450549450549E-03,4.3956043956044E-03,3.2967032967033E-03,2.1978021978022E-03,1.0989010989011E-03,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={5.49450549450549E-02,5.38461538461538E-02,5.27472527472527E-02,5.16483516483516E-02,5.05494505494506E-02,4.94505494505494E-02,4.83516483516483E-02,4.72527472527473E-02,4.61538461538461E-02,4.50549450549451E-02,1,1,1,1,1,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,6.66666666666667,13.3333333333333,20,3.33333333333333,1.66666666666667,1.42857142857143E-02,1.31868131868132E-02,1.20879120879121E-02,.010989010989011,9.89010989010989E-03,8.79120879120879E-03,7.69230769230769E-03,6.59340659340659E-03,5.49450549450549E-03,4.3956043956044E-03,3.2967032967033E-03,2.1978021978022E-03,1.0989010989011E-03,}

	---琥珀朱绫	琉璃盏 落宝金钱
	elseif tmplID == talismans["QY_105_HuPoZhuLing"].tmplID or tmplID == talismans["TH_105_LiuLiZhan"].tmplID or tmplID == talismans["CH_105_luobaojinqian"].tmplID or tmplID == talismans["QJ_105_jinyubian"].tmplID or tmplID == talismans["YZ_105_shuolei"].tmplID then

		valueWeights[dataIndex["default_hp"]] ={7.93650793650794E-03,7.77777777777778E-03,7.61904761904762E-03,2.5,2.5,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,25,50,5,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["default_mp"]] ={3.67647058823529E-02,3.60294117647059E-02,3.52941176470588E-02,3.45588235294118E-02,3.38235294117647E-02,3.30882352941176E-02,3.23529411764706E-02,1.25,1.25,1.25,1.25,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,1.17647058823529E-02,1.10294117647059E-02,1.02941176470588E-02,9.55882352941177E-03,8.82352941176471E-03,8.08823529411765E-03,7.35294117647059E-03,6.61764705882353E-03,5.88235294117647E-03,5.14705882352941E-03,4.41176470588235E-03,3.67647058823529E-03,2.94117647058824E-03,2.20588235294118E-03,1.47058823529412E-03,7.3529411764706E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={6.41025641025641E-03,6.28205128205128E-03,5,3.75,3.75,3.75,3.75,25,50,3.33333333333333,1.66666666666667,.005,4.87179487179487E-03,4.74358974358974E-03,4.61538461538462E-03,4.48717948717949E-03,4.35897435897436E-03,4.23076923076923E-03,4.1025641025641E-03,3.97435897435897E-03,3.84615384615385E-03,3.71794871794872E-03,3.58974358974359E-03,3.46153846153846E-03,3.33333333333333E-03,3.20512820512821E-03,3.07692307692308E-03,2.94871794871795E-03,2.82051282051282E-03,2.69230769230769E-03,2.56410256410256E-03,2.43589743589744E-03,2.30769230769231E-03,2.17948717948718E-03,2.05128205128205E-03,1.92307692307692E-03,1.7948717948718E-03,1.66666666666667E-03,1.53846153846154E-03,1.41025641025641E-03,1.28205128205128E-03,1.15384615384615E-03,1.02564102564103E-03,8.97435897435898E-04,7.69230769230769E-04,6.41025641025641E-04,5.12820512820513E-04,3.84615384615385E-04,2.56410256410256E-04,1.28205128205128E-04,}
		valueWeights[dataIndex["default_damage_low"]] ={.111111111111111,.108888888888889,.106666666666667,.104444444444444,.102222222222222,.1,9.77777777777778E-02,9.55555555555556E-02,9.33333333333333E-02,9.11111111111111E-02,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,5,10,15,20,25,2.5,1.66666666666667,.833333333333333,.02,1.77777777777778E-02,1.55555555555556E-02,1.33333333333333E-02,1.11111111111111E-02,8.88888888888889E-03,6.66666666666667E-03,4.44444444444445E-03,2.22222222222222E-03,}
		valueWeights[dataIndex["default_damage_high"]] ={.111111111111111,.108888888888889,.106666666666667,.104444444444444,.102222222222222,.1,9.77777777777778E-02,9.55555555555556E-02,9.33333333333333E-02,9.11111111111111E-02,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,5,10,15,20,25,2.5,1.66666666666667,.833333333333333,.02,1.77777777777778E-02,1.55555555555556E-02,1.33333333333333E-02,1.11111111111111E-02,8.88888888888889E-03,6.66666666666667E-03,4.44444444444445E-03,2.22222222222222E-03,}
		valueWeights[dataIndex["default_dodge"]] ={6.09756097560976E-03,5,3.75,3.75,3.75,3.75,25,50,3.33333333333333,1.66666666666667,4.87804878048781E-03,4.75609756097561E-03,4.63414634146342E-03,4.51219512195122E-03,4.39024390243902E-03,4.26829268292683E-03,4.14634146341464E-03,4.02439024390244E-03,3.90243902439024E-03,3.78048780487805E-03,3.65853658536585E-03,3.53658536585366E-03,3.41463414634146E-03,3.29268292682927E-03,3.17073170731707E-03,3.04878048780488E-03,2.92682926829268E-03,2.80487804878049E-03,2.68292682926829E-03,2.5609756097561E-03,2.4390243902439E-03,2.31707317073171E-03,2.19512195121951E-03,2.07317073170732E-03,1.95121951219512E-03,1.82926829268293E-03,1.70731707317073E-03,1.58536585365854E-03,1.46341463414634E-03,1.34146341463415E-03,1.21951219512195E-03,1.09756097560976E-03,9.75609756097561E-04,8.53658536585367E-04,7.31707317073171E-04,6.09756097560976E-04,4.87804878048781E-04,3.65853658536586E-04,2.4390243902439E-04,1.21951219512195E-04,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={.178571428571429,.175,.171428571428571,.167857142857143,.164285714285714,.160714285714286,.157142857142857,.153571428571429,.15,.146428571428571,.142857142857143,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,2.5,1.66666666666667,.833333333333333,.025,2.14285714285714E-02,1.78571428571429E-02,1.42857142857143E-02,1.07142857142857E-02,7.14285714285714E-03,3.57142857142857E-03,}
		valueWeights[dataIndex["default_resis_sleep"]] ={.111111111111111,.108888888888889,.106666666666667,.104444444444444,.102222222222222,.1,9.77777777777778E-02,9.55555555555556E-02,9.33333333333333E-02,1,1,1,1,1,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,2,1.5,1,.5,.02,1.77777777777778E-02,1.55555555555556E-02,1.33333333333333E-02,1.11111111111111E-02,8.88888888888889E-03,6.66666666666667E-03,4.44444444444445E-03,2.22222222222222E-03,}
		valueWeights[dataIndex["default_resis_silence"]] ={6.41025641025641E-02,6.28205128205128E-02,6.15384615384615E-02,6.02564102564103E-02,.058974358974359,5.76923076923077E-02,5.64102564102564E-02,5.51282051282051E-02,1.25,1.25,1.25,1.25,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.66666666666667,3.33333333333333,5,6.66666666666667,8.33333333333333,10,11.6666666666667,13.3333333333333,15,2,1.5,1,.5,1.53846153846154E-02,1.41025641025641E-02,1.28205128205128E-02,1.15384615384615E-02,1.02564102564103E-02,8.97435897435898E-03,7.69230769230769E-03,6.41025641025641E-03,5.12820512820513E-03,3.84615384615385E-03,2.56410256410257E-03,1.28205128205128E-03,}
		valueWeights[dataIndex["default_resis_weakness"]] ={.178571428571429,.175,.171428571428571,.167857142857143,.164285714285714,.160714285714286,.157142857142857,.153571428571429,.15,.146428571428571,.142857142857143,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,2.5,1.66666666666667,.833333333333333,.025,2.14285714285714E-02,1.78571428571429E-02,1.42857142857143E-02,1.07142857142857E-02,7.14285714285714E-03,3.57142857142857E-03,}
		valueWeights[dataIndex["default_resis_enlace"]] ={.111111111111111,.108888888888889,.106666666666667,.104444444444444,.102222222222222,.1,9.77777777777778E-02,9.55555555555556E-02,9.33333333333333E-02,1,1,1,1,1,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,2,1.5,1,.5,.02,1.77777777777778E-02,1.55555555555556E-02,1.33333333333333E-02,1.11111111111111E-02,8.88888888888889E-03,6.66666666666667E-03,4.44444444444445E-03,2.22222222222222E-03,}
		
		valueWeights[dataIndex["grow_hp"]] ={7.11237553342817E-03,6.9701280227596E-03,6.82788051209104E-03,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,75,5,5.26315789473684E-03,5.12091038406828E-03,4.97866287339972E-03,4.83641536273115E-03,4.69416785206259E-03,4.55192034139403E-03,4.40967283072546E-03,4.2674253200569E-03,4.12517780938834E-03,3.98293029871977E-03,3.84068278805121E-03,3.69843527738265E-03,3.55618776671408E-03,3.41394025604552E-03,3.27169274537696E-03,3.12944523470839E-03,2.98719772403983E-03,2.84495021337127E-03,2.7027027027027E-03,2.56045519203414E-03,2.41820768136558E-03,2.27596017069701E-03,2.13371266002845E-03,1.99146514935989E-03,1.84921763869132E-03,1.70697012802276E-03,1.5647226173542E-03,1.42247510668563E-03,1.28022759601707E-03,1.13798008534851E-03,9.95732574679943E-04,8.53485064011381E-04,7.11237553342817E-04,5.68990042674253E-04,4.2674253200569E-04,2.84495021337127E-04,1.42247510668564E-04,}
		valueWeights[dataIndex["grow_mp"]] ={2.63157894736842E-02,2.57894736842105E-02,2.52631578947368E-02,2.47368421052632E-02,2.42105263157895E-02,2.36842105263158E-02,1.25,1.25,1.25,1.25,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,5,10,15,20,25,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={6.41025641025641E-03,6.28205128205128E-03,5,3.75,3.75,3.75,3.75,25,50,3.33333333333333,1.66666666666667,.005,4.87179487179487E-03,4.74358974358974E-03,4.61538461538462E-03,4.48717948717949E-03,4.35897435897436E-03,4.23076923076923E-03,4.1025641025641E-03,3.97435897435897E-03,3.84615384615385E-03,3.71794871794872E-03,3.58974358974359E-03,3.46153846153846E-03,3.33333333333333E-03,3.20512820512821E-03,3.07692307692308E-03,2.94871794871795E-03,2.82051282051282E-03,2.69230769230769E-03,2.56410256410256E-03,2.43589743589744E-03,2.30769230769231E-03,2.17948717948718E-03,2.05128205128205E-03,1.92307692307692E-03,1.7948717948718E-03,1.66666666666667E-03,1.53846153846154E-03,1.41025641025641E-03,1.28205128205128E-03,1.15384615384615E-03,1.02564102564103E-03,8.97435897435898E-04,7.69230769230769E-04,6.41025641025641E-04,5.12820512820513E-04,3.84615384615385E-04,2.56410256410256E-04,1.28205128205128E-04,}
		valueWeights[dataIndex["grow_damage_low"]] ={5.49450549450549E-02,5.38461538461538E-02,5.27472527472527E-02,5.16483516483516E-02,5.05494505494506E-02,4.94505494505494E-02,4.83516483516483E-02,4.72527472527473E-02,4.61538461538461E-02,4.50549450549451E-02,1,1,1,1,1,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,12.5,25,37.5,2.5,1.66666666666667,.833333333333333,1.42857142857143E-02,1.31868131868132E-02,1.20879120879121E-02,.010989010989011,9.89010989010989E-03,8.79120879120879E-03,7.69230769230769E-03,6.59340659340659E-03,5.49450549450549E-03,4.3956043956044E-03,3.2967032967033E-03,2.1978021978022E-03,1.0989010989011E-03,}
		valueWeights[dataIndex["grow_damage_high"]] ={5.49450549450549E-02,5.38461538461538E-02,5.27472527472527E-02,5.16483516483516E-02,5.05494505494506E-02,4.94505494505494E-02,4.83516483516483E-02,4.72527472527473E-02,4.61538461538461E-02,4.50549450549451E-02,1,1,1,1,1,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,12.5,25,37.5,2.5,1.66666666666667,.833333333333333,1.42857142857143E-02,1.31868131868132E-02,1.20879120879121E-02,.010989010989011,9.89010989010989E-03,8.79120879120879E-03,7.69230769230769E-03,6.59340659340659E-03,5.49450549450549E-03,4.3956043956044E-03,3.2967032967033E-03,2.1978021978022E-03,1.0989010989011E-03,}
		valueWeights[dataIndex["grow_dodge"]] ={6.09756097560976E-03,5,3.75,3.75,3.75,3.75,25,50,3.33333333333333,1.66666666666667,4.87804878048781E-03,4.75609756097561E-03,4.63414634146342E-03,4.51219512195122E-03,4.39024390243902E-03,4.26829268292683E-03,4.14634146341464E-03,4.02439024390244E-03,3.90243902439024E-03,3.78048780487805E-03,3.65853658536585E-03,3.53658536585366E-03,3.41463414634146E-03,3.29268292682927E-03,3.17073170731707E-03,3.04878048780488E-03,2.92682926829268E-03,2.80487804878049E-03,2.68292682926829E-03,2.5609756097561E-03,2.4390243902439E-03,2.31707317073171E-03,2.19512195121951E-03,2.07317073170732E-03,1.95121951219512E-03,1.82926829268293E-03,1.70731707317073E-03,1.58536585365854E-03,1.46341463414634E-03,1.34146341463415E-03,1.21951219512195E-03,1.09756097560976E-03,9.75609756097561E-04,8.53658536585367E-04,7.31707317073171E-04,6.09756097560976E-04,4.87804878048781E-04,3.65853658536586E-04,2.4390243902439E-04,1.21951219512195E-04,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={5.49450549450549E-02,5.38461538461538E-02,5.27472527472527E-02,5.16483516483516E-02,5.05494505494506E-02,4.94505494505494E-02,4.83516483516483E-02,4.72527472527473E-02,4.61538461538461E-02,4.50549450549451E-02,1,1,1,1,1,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,6.66666666666667,13.3333333333333,20,3.33333333333333,1.66666666666667,1.42857142857143E-02,1.31868131868132E-02,1.20879120879121E-02,.010989010989011,9.89010989010989E-03,8.79120879120879E-03,7.69230769230769E-03,6.59340659340659E-03,5.49450549450549E-03,4.3956043956044E-03,3.2967032967033E-03,2.1978021978022E-03,1.0989010989011E-03,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={3.67647058823529E-02,3.60294117647059E-02,3.52941176470588E-02,3.45588235294118E-02,3.38235294117647E-02,3.30882352941176E-02,3.23529411764706E-02,3.16176470588235E-02,1,1,1,1,1,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,4,8,12,16,2.5,1.66666666666667,.833333333333333,1.17647058823529E-02,1.10294117647059E-02,1.02941176470588E-02,9.55882352941177E-03,8.82352941176471E-03,8.08823529411765E-03,7.35294117647059E-03,6.61764705882353E-03,5.88235294117647E-03,5.14705882352941E-03,4.41176470588235E-03,3.67647058823529E-03,2.94117647058824E-03,2.20588235294118E-03,1.47058823529412E-03,7.3529411764706E-04,}
		valueWeights[dataIndex["grow_resis_silence"]] ={2.16450216450216E-02,2.12121212121212E-02,2.07792207792208E-02,2.03463203463203E-02,1.99134199134199E-02,1.94805194805195E-02,1.25,1.25,1.25,1.25,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,2.66666666666667,5.33333333333333,8,10.6666666666667,13.3333333333333,2.5,1.66666666666667,.833333333333333,9.09090909090909E-03,8.65800865800866E-03,8.22510822510823E-03,7.79220779220779E-03,7.35930735930736E-03,6.92640692640693E-03,6.49350649350649E-03,6.06060606060606E-03,5.62770562770563E-03,5.19480519480519E-03,4.76190476190476E-03,4.32900432900433E-03,3.8961038961039E-03,3.46320346320346E-03,3.03030303030303E-03,2.5974025974026E-03,2.16450216450216E-03,1.73160173160173E-03,1.2987012987013E-03,8.65800865800865E-04,4.32900432900432E-04,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={5.49450549450549E-02,5.38461538461538E-02,5.27472527472527E-02,5.16483516483516E-02,5.05494505494506E-02,4.94505494505494E-02,4.83516483516483E-02,4.72527472527473E-02,4.61538461538461E-02,4.50549450549451E-02,1,1,1,1,1,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,6.66666666666667,13.3333333333333,20,3.33333333333333,1.66666666666667,1.42857142857143E-02,1.31868131868132E-02,1.20879120879121E-02,.010989010989011,9.89010989010989E-03,8.79120879120879E-03,7.69230769230769E-03,6.59340659340659E-03,5.49450549450549E-03,4.3956043956044E-03,3.2967032967033E-03,2.1978021978022E-03,1.0989010989011E-03,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={3.67647058823529E-02,3.60294117647059E-02,3.52941176470588E-02,3.45588235294118E-02,3.38235294117647E-02,3.30882352941176E-02,3.23529411764706E-02,3.16176470588235E-02,1,1,1,1,1,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,4,8,12,16,2.5,1.66666666666667,.833333333333333,1.17647058823529E-02,1.10294117647059E-02,1.02941176470588E-02,9.55882352941177E-03,8.82352941176471E-03,8.08823529411765E-03,7.35294117647059E-03,6.61764705882353E-03,5.88235294117647E-03,5.14705882352941E-03,4.41176470588235E-03,3.67647058823529E-03,2.94117647058824E-03,2.20588235294118E-03,1.47058823529412E-03,7.3529411764706E-04,}
		
	---千毒蛊	鬼道3 火玲珑 焚香3 子母阴阳扣 太昊3
	elseif tmplID == talismans["GD_105_QianDuGu"].tmplID or tmplID == talismans["FX_105_HuoLingLong"].tmplID or tmplID == talismans["TH_105_ZiMuYinYangKou"].tmplID then

		valueWeights[dataIndex["default_hp"]] ={7.93650793650794E-03,7.77777777777778E-03,7.61904761904762E-03,2.5,2.5,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,25,50,5,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["default_mp"]] ={3.67647058823529E-02,3.60294117647059E-02,3.52941176470588E-02,3.45588235294118E-02,3.38235294117647E-02,3.30882352941176E-02,3.23529411764706E-02,1.25,1.25,1.25,1.25,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,1.17647058823529E-02,1.10294117647059E-02,1.02941176470588E-02,9.55882352941177E-03,8.82352941176471E-03,8.08823529411765E-03,7.35294117647059E-03,6.61764705882353E-03,5.88235294117647E-03,5.14705882352941E-03,4.41176470588235E-03,3.67647058823529E-03,2.94117647058824E-03,2.20588235294118E-03,1.47058823529412E-03,7.3529411764706E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={6.41025641025641E-03,6.28205128205128E-03,5,3.75,3.75,3.75,3.75,25,50,3.33333333333333,1.66666666666667,.005,4.87179487179487E-03,4.74358974358974E-03,4.61538461538462E-03,4.48717948717949E-03,4.35897435897436E-03,4.23076923076923E-03,4.1025641025641E-03,3.97435897435897E-03,3.84615384615385E-03,3.71794871794872E-03,3.58974358974359E-03,3.46153846153846E-03,3.33333333333333E-03,3.20512820512821E-03,3.07692307692308E-03,2.94871794871795E-03,2.82051282051282E-03,2.69230769230769E-03,2.56410256410256E-03,2.43589743589744E-03,2.30769230769231E-03,2.17948717948718E-03,2.05128205128205E-03,1.92307692307692E-03,1.7948717948718E-03,1.66666666666667E-03,1.53846153846154E-03,1.41025641025641E-03,1.28205128205128E-03,1.15384615384615E-03,1.02564102564103E-03,8.97435897435898E-04,7.69230769230769E-04,6.41025641025641E-04,5.12820512820513E-04,3.84615384615385E-04,2.56410256410256E-04,1.28205128205128E-04,}
		valueWeights[dataIndex["default_damage_low"]] ={.111111111111111,.108888888888889,.106666666666667,.104444444444444,.102222222222222,.1,9.77777777777778E-02,9.55555555555556E-02,9.33333333333333E-02,9.11111111111111E-02,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,5,10,15,20,25,2.5,1.66666666666667,.833333333333333,.02,1.77777777777778E-02,1.55555555555556E-02,1.33333333333333E-02,1.11111111111111E-02,8.88888888888889E-03,6.66666666666667E-03,4.44444444444445E-03,2.22222222222222E-03,}
		valueWeights[dataIndex["default_damage_high"]] ={.111111111111111,.108888888888889,.106666666666667,.104444444444444,.102222222222222,.1,9.77777777777778E-02,9.55555555555556E-02,9.33333333333333E-02,9.11111111111111E-02,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,5,10,15,20,25,2.5,1.66666666666667,.833333333333333,.02,1.77777777777778E-02,1.55555555555556E-02,1.33333333333333E-02,1.11111111111111E-02,8.88888888888889E-03,6.66666666666667E-03,4.44444444444445E-03,2.22222222222222E-03,}
		valueWeights[dataIndex["default_dodge"]] ={6.09756097560976E-03,5,3.75,3.75,3.75,3.75,25,50,3.33333333333333,1.66666666666667,4.87804878048781E-03,4.75609756097561E-03,4.63414634146342E-03,4.51219512195122E-03,4.39024390243902E-03,4.26829268292683E-03,4.14634146341464E-03,4.02439024390244E-03,3.90243902439024E-03,3.78048780487805E-03,3.65853658536585E-03,3.53658536585366E-03,3.41463414634146E-03,3.29268292682927E-03,3.17073170731707E-03,3.04878048780488E-03,2.92682926829268E-03,2.80487804878049E-03,2.68292682926829E-03,2.5609756097561E-03,2.4390243902439E-03,2.31707317073171E-03,2.19512195121951E-03,2.07317073170732E-03,1.95121951219512E-03,1.82926829268293E-03,1.70731707317073E-03,1.58536585365854E-03,1.46341463414634E-03,1.34146341463415E-03,1.21951219512195E-03,1.09756097560976E-03,9.75609756097561E-04,8.53658536585367E-04,7.31707317073171E-04,6.09756097560976E-04,4.87804878048781E-04,3.65853658536586E-04,2.4390243902439E-04,1.21951219512195E-04,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={.178571428571429,.175,.171428571428571,.167857142857143,.164285714285714,.160714285714286,.157142857142857,.153571428571429,.15,.146428571428571,.142857142857143,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,2.5,1.66666666666667,.833333333333333,.025,2.14285714285714E-02,1.78571428571429E-02,1.42857142857143E-02,1.07142857142857E-02,7.14285714285714E-03,3.57142857142857E-03,}
		valueWeights[dataIndex["default_resis_sleep"]] ={.111111111111111,.108888888888889,.106666666666667,.104444444444444,.102222222222222,.1,9.77777777777778E-02,9.55555555555556E-02,9.33333333333333E-02,1,1,1,1,1,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,2,1.5,1,.5,.02,1.77777777777778E-02,1.55555555555556E-02,1.33333333333333E-02,1.11111111111111E-02,8.88888888888889E-03,6.66666666666667E-03,4.44444444444445E-03,2.22222222222222E-03,}
		valueWeights[dataIndex["default_resis_silence"]] ={6.41025641025641E-02,6.28205128205128E-02,6.15384615384615E-02,6.02564102564103E-02,.058974358974359,5.76923076923077E-02,5.64102564102564E-02,5.51282051282051E-02,1.25,1.25,1.25,1.25,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.66666666666667,3.33333333333333,5,6.66666666666667,8.33333333333333,10,11.6666666666667,13.3333333333333,15,2,1.5,1,.5,1.53846153846154E-02,1.41025641025641E-02,1.28205128205128E-02,1.15384615384615E-02,1.02564102564103E-02,8.97435897435898E-03,7.69230769230769E-03,6.41025641025641E-03,5.12820512820513E-03,3.84615384615385E-03,2.56410256410257E-03,1.28205128205128E-03,}
		valueWeights[dataIndex["default_resis_weakness"]] ={.178571428571429,.175,.171428571428571,.167857142857143,.164285714285714,.160714285714286,.157142857142857,.153571428571429,.15,.146428571428571,.142857142857143,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,2.5,1.66666666666667,.833333333333333,.025,2.14285714285714E-02,1.78571428571429E-02,1.42857142857143E-02,1.07142857142857E-02,7.14285714285714E-03,3.57142857142857E-03,}
		valueWeights[dataIndex["default_resis_enlace"]] ={.111111111111111,.108888888888889,.106666666666667,.104444444444444,.102222222222222,.1,9.77777777777778E-02,9.55555555555556E-02,9.33333333333333E-02,1,1,1,1,1,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,2,1.5,1,.5,.02,1.77777777777778E-02,1.55555555555556E-02,1.33333333333333E-02,1.11111111111111E-02,8.88888888888889E-03,6.66666666666667E-03,4.44444444444445E-03,2.22222222222222E-03,}
		
		valueWeights[dataIndex["grow_hp"]] ={7.11237553342817E-03,6.9701280227596E-03,6.82788051209104E-03,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,75,5,5.26315789473684E-03,5.12091038406828E-03,4.97866287339972E-03,4.83641536273115E-03,4.69416785206259E-03,4.55192034139403E-03,4.40967283072546E-03,4.2674253200569E-03,4.12517780938834E-03,3.98293029871977E-03,3.84068278805121E-03,3.69843527738265E-03,3.55618776671408E-03,3.41394025604552E-03,3.27169274537696E-03,3.12944523470839E-03,2.98719772403983E-03,2.84495021337127E-03,2.7027027027027E-03,2.56045519203414E-03,2.41820768136558E-03,2.27596017069701E-03,2.13371266002845E-03,1.99146514935989E-03,1.84921763869132E-03,1.70697012802276E-03,1.5647226173542E-03,1.42247510668563E-03,1.28022759601707E-03,1.13798008534851E-03,9.95732574679943E-04,8.53485064011381E-04,7.11237553342817E-04,5.68990042674253E-04,4.2674253200569E-04,2.84495021337127E-04,1.42247510668564E-04,}
		valueWeights[dataIndex["grow_mp"]] ={2.63157894736842E-02,2.57894736842105E-02,2.52631578947368E-02,2.47368421052632E-02,2.42105263157895E-02,2.36842105263158E-02,1.25,1.25,1.25,1.25,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,5,10,15,20,25,1.66666666666667,1.33333333333333,1,.666666666666667,.333333333333333,.01,9.47368421052632E-03,8.94736842105263E-03,8.42105263157895E-03,7.89473684210526E-03,7.36842105263158E-03,6.8421052631579E-03,6.31578947368421E-03,5.78947368421053E-03,5.26315789473684E-03,4.73684210526316E-03,4.21052631578947E-03,3.68421052631579E-03,3.15789473684211E-03,2.63157894736842E-03,2.10526315789474E-03,1.57894736842105E-03,1.05263157894737E-03,5.26315789473686E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={6.41025641025641E-03,6.28205128205128E-03,5,3.75,3.75,3.75,3.75,25,50,3.33333333333333,1.66666666666667,.005,4.87179487179487E-03,4.74358974358974E-03,4.61538461538462E-03,4.48717948717949E-03,4.35897435897436E-03,4.23076923076923E-03,4.1025641025641E-03,3.97435897435897E-03,3.84615384615385E-03,3.71794871794872E-03,3.58974358974359E-03,3.46153846153846E-03,3.33333333333333E-03,3.20512820512821E-03,3.07692307692308E-03,2.94871794871795E-03,2.82051282051282E-03,2.69230769230769E-03,2.56410256410256E-03,2.43589743589744E-03,2.30769230769231E-03,2.17948717948718E-03,2.05128205128205E-03,1.92307692307692E-03,1.7948717948718E-03,1.66666666666667E-03,1.53846153846154E-03,1.41025641025641E-03,1.28205128205128E-03,1.15384615384615E-03,1.02564102564103E-03,8.97435897435898E-04,7.69230769230769E-04,6.41025641025641E-04,5.12820512820513E-04,3.84615384615385E-04,2.56410256410256E-04,1.28205128205128E-04,}
		valueWeights[dataIndex["grow_damage_low"]] ={5.49450549450549E-02,5.38461538461538E-02,5.27472527472527E-02,5.16483516483516E-02,5.05494505494506E-02,4.94505494505494E-02,4.83516483516483E-02,4.72527472527473E-02,4.61538461538461E-02,4.50549450549451E-02,1,1,1,1,1,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,12.5,25,37.5,2.5,1.66666666666667,.833333333333333,1.42857142857143E-02,1.31868131868132E-02,1.20879120879121E-02,.010989010989011,9.89010989010989E-03,8.79120879120879E-03,7.69230769230769E-03,6.59340659340659E-03,5.49450549450549E-03,4.3956043956044E-03,3.2967032967033E-03,2.1978021978022E-03,1.0989010989011E-03,}
		valueWeights[dataIndex["grow_damage_high"]] ={5.49450549450549E-02,5.38461538461538E-02,5.27472527472527E-02,5.16483516483516E-02,5.05494505494506E-02,4.94505494505494E-02,4.83516483516483E-02,4.72527472527473E-02,4.61538461538461E-02,4.50549450549451E-02,1,1,1,1,1,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,12.5,25,37.5,2.5,1.66666666666667,.833333333333333,1.42857142857143E-02,1.31868131868132E-02,1.20879120879121E-02,.010989010989011,9.89010989010989E-03,8.79120879120879E-03,7.69230769230769E-03,6.59340659340659E-03,5.49450549450549E-03,4.3956043956044E-03,3.2967032967033E-03,2.1978021978022E-03,1.0989010989011E-03,}
		valueWeights[dataIndex["grow_dodge"]] ={6.09756097560976E-03,5,3.75,3.75,3.75,3.75,25,50,3.33333333333333,1.66666666666667,4.87804878048781E-03,4.75609756097561E-03,4.63414634146342E-03,4.51219512195122E-03,4.39024390243902E-03,4.26829268292683E-03,4.14634146341464E-03,4.02439024390244E-03,3.90243902439024E-03,3.78048780487805E-03,3.65853658536585E-03,3.53658536585366E-03,3.41463414634146E-03,3.29268292682927E-03,3.17073170731707E-03,3.04878048780488E-03,2.92682926829268E-03,2.80487804878049E-03,2.68292682926829E-03,2.5609756097561E-03,2.4390243902439E-03,2.31707317073171E-03,2.19512195121951E-03,2.07317073170732E-03,1.95121951219512E-03,1.82926829268293E-03,1.70731707317073E-03,1.58536585365854E-03,1.46341463414634E-03,1.34146341463415E-03,1.21951219512195E-03,1.09756097560976E-03,9.75609756097561E-04,8.53658536585367E-04,7.31707317073171E-04,6.09756097560976E-04,4.87804878048781E-04,3.65853658536586E-04,2.4390243902439E-04,1.21951219512195E-04,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={5.49450549450549E-02,5.38461538461538E-02,5.27472527472527E-02,5.16483516483516E-02,5.05494505494506E-02,4.94505494505494E-02,4.83516483516483E-02,4.72527472527473E-02,4.61538461538461E-02,4.50549450549451E-02,1,1,1,1,1,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,6.66666666666667,13.3333333333333,20,3.33333333333333,1.66666666666667,1.42857142857143E-02,1.31868131868132E-02,1.20879120879121E-02,.010989010989011,9.89010989010989E-03,8.79120879120879E-03,7.69230769230769E-03,6.59340659340659E-03,5.49450549450549E-03,4.3956043956044E-03,3.2967032967033E-03,2.1978021978022E-03,1.0989010989011E-03,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={3.67647058823529E-02,3.60294117647059E-02,3.52941176470588E-02,3.45588235294118E-02,3.38235294117647E-02,3.30882352941176E-02,3.23529411764706E-02,3.16176470588235E-02,1,1,1,1,1,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,4,8,12,16,2.5,1.66666666666667,.833333333333333,1.17647058823529E-02,1.10294117647059E-02,1.02941176470588E-02,9.55882352941177E-03,8.82352941176471E-03,8.08823529411765E-03,7.35294117647059E-03,6.61764705882353E-03,5.88235294117647E-03,5.14705882352941E-03,4.41176470588235E-03,3.67647058823529E-03,2.94117647058824E-03,2.20588235294118E-03,1.47058823529412E-03,7.3529411764706E-04,}
		valueWeights[dataIndex["grow_resis_silence"]] ={2.16450216450216E-02,2.12121212121212E-02,2.07792207792208E-02,2.03463203463203E-02,1.99134199134199E-02,1.94805194805195E-02,1.25,1.25,1.25,1.25,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,2.66666666666667,5.33333333333333,8,10.6666666666667,13.3333333333333,2.5,1.66666666666667,.833333333333333,9.09090909090909E-03,8.65800865800866E-03,8.22510822510823E-03,7.79220779220779E-03,7.35930735930736E-03,6.92640692640693E-03,6.49350649350649E-03,6.06060606060606E-03,5.62770562770563E-03,5.19480519480519E-03,4.76190476190476E-03,4.32900432900433E-03,3.8961038961039E-03,3.46320346320346E-03,3.03030303030303E-03,2.5974025974026E-03,2.16450216450216E-03,1.73160173160173E-03,1.2987012987013E-03,8.65800865800865E-04,4.32900432900432E-04,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={5.49450549450549E-02,5.38461538461538E-02,5.27472527472527E-02,5.16483516483516E-02,5.05494505494506E-02,4.94505494505494E-02,4.83516483516483E-02,4.72527472527473E-02,4.61538461538461E-02,4.50549450549451E-02,1,1,1,1,1,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,6.66666666666667,13.3333333333333,20,3.33333333333333,1.66666666666667,1.42857142857143E-02,1.31868131868132E-02,1.20879120879121E-02,.010989010989011,9.89010989010989E-03,8.79120879120879E-03,7.69230769230769E-03,6.59340659340659E-03,5.49450549450549E-03,4.3956043956044E-03,3.2967032967033E-03,2.1978021978022E-03,1.0989010989011E-03,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={3.67647058823529E-02,3.60294117647059E-02,3.52941176470588E-02,3.45588235294118E-02,3.38235294117647E-02,3.30882352941176E-02,3.23529411764706E-02,3.16176470588235E-02,1,1,1,1,1,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,4,8,12,16,2.5,1.66666666666667,.833333333333333,1.17647058823529E-02,1.10294117647059E-02,1.02941176470588E-02,9.55882352941177E-03,8.82352941176471E-03,8.08823529411765E-03,7.35294117647059E-03,6.61764705882353E-03,5.88235294117647E-03,5.14705882352941E-03,4.41176470588235E-03,3.67647058823529E-03,2.94117647058824E-03,2.20588235294118E-03,1.47058823529412E-03,7.3529411764706E-04,}
		

	---如意乾坤袋 浮影古镜
	elseif tmplID == talismans["TY_105_RuYiQianKunDai"].tmplID or tmplID == talismans["LS_105_FuYingGuJing"].tmplID then

		valueWeights[dataIndex["default_hp"]] ={9.46969696969697E-03,9.28030303030303E-03,9.09090909090909E-03,8.90151515151515E-03,2.5,2.5,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,2.14285714285714,12.5,25,37.5,3.33333333333333,1.66666666666667,6.06060606060606E-03,5.87121212121212E-03,5.68181818181818E-03,5.49242424242424E-03,5.3030303030303E-03,5.11363636363636E-03,4.92424242424242E-03,4.73484848484849E-03,4.54545454545455E-03,4.35606060606061E-03,4.16666666666667E-03,3.97727272727273E-03,3.78787878787879E-03,3.59848484848485E-03,3.40909090909091E-03,3.21969696969697E-03,3.03030303030303E-03,2.84090909090909E-03,2.65151515151515E-03,2.46212121212121E-03,2.27272727272727E-03,2.08333333333333E-03,1.89393939393939E-03,1.70454545454545E-03,1.51515151515152E-03,1.32575757575758E-03,1.13636363636364E-03,9.46969696969697E-04,7.57575757575757E-04,5.68181818181818E-04,3.78787878787879E-04,1.8939393939394E-04,}
		valueWeights[dataIndex["default_mp"]] ={2.16450216450216E-02,2.12121212121212E-02,2.07792207792208E-02,2.03463203463203E-02,1.99134199134199E-02,1.94805194805195E-02,1.25,1.25,1.25,1.25,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,2,1.5,1,.5,9.09090909090909E-03,8.65800865800866E-03,8.22510822510823E-03,7.79220779220779E-03,7.35930735930736E-03,6.92640692640693E-03,6.49350649350649E-03,6.06060606060606E-03,5.62770562770563E-03,5.19480519480519E-03,4.76190476190476E-03,4.32900432900433E-03,3.8961038961039E-03,3.46320346320346E-03,3.03030303030303E-03,2.5974025974026E-03,2.16450216450216E-03,1.73160173160173E-03,1.2987012987013E-03,8.65800865800865E-04,4.32900432900432E-04,}
		valueWeights[dataIndex["default_attack_rate"]] ={6.41025641025641E-03,6.28205128205128E-03,5,3.75,3.75,3.75,3.75,25,50,3.33333333333333,1.66666666666667,.005,4.87179487179487E-03,4.74358974358974E-03,4.61538461538462E-03,4.48717948717949E-03,4.35897435897436E-03,4.23076923076923E-03,4.1025641025641E-03,3.97435897435897E-03,3.84615384615385E-03,3.71794871794872E-03,3.58974358974359E-03,3.46153846153846E-03,3.33333333333333E-03,3.20512820512821E-03,3.07692307692308E-03,2.94871794871795E-03,2.82051282051282E-03,2.69230769230769E-03,2.56410256410256E-03,2.43589743589744E-03,2.30769230769231E-03,2.17948717948718E-03,2.05128205128205E-03,1.92307692307692E-03,1.7948717948718E-03,1.66666666666667E-03,1.53846153846154E-03,1.41025641025641E-03,1.28205128205128E-03,1.15384615384615E-03,1.02564102564103E-03,8.97435897435898E-04,7.69230769230769E-04,6.41025641025641E-04,5.12820512820513E-04,3.84615384615385E-04,2.56410256410256E-04,1.28205128205128E-04,}
		valueWeights[dataIndex["default_damage_low"]] ={4.76190476190476E-02,4.66666666666667E-02,4.57142857142857E-02,4.47619047619048E-02,4.38095238095238E-02,4.28571428571429E-02,4.19047619047619E-02,4.09523809523809E-02,.04,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,7.5,15,22.5,30,2.5,1.66666666666667,.833333333333333,1.33333333333333E-02,1.23809523809524E-02,1.14285714285714E-02,1.04761904761905E-02,9.52380952380952E-03,8.57142857142857E-03,7.61904761904762E-03,6.66666666666667E-03,5.71428571428571E-03,4.76190476190476E-03,3.80952380952381E-03,2.85714285714286E-03,1.9047619047619E-03,9.52380952380951E-04,}
		valueWeights[dataIndex["default_damage_high"]] ={4.76190476190476E-02,4.66666666666667E-02,4.57142857142857E-02,4.47619047619048E-02,4.38095238095238E-02,4.28571428571429E-02,4.19047619047619E-02,4.09523809523809E-02,.04,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,7.5,15,22.5,30,2.5,1.66666666666667,.833333333333333,1.33333333333333E-02,1.23809523809524E-02,1.14285714285714E-02,1.04761904761905E-02,9.52380952380952E-03,8.57142857142857E-03,7.61904761904762E-03,6.66666666666667E-03,5.71428571428571E-03,4.76190476190476E-03,3.80952380952381E-03,2.85714285714286E-03,1.9047619047619E-03,9.52380952380951E-04,}
		valueWeights[dataIndex["default_dodge"]] ={6.09756097560976E-03,5,3.75,3.75,3.75,3.75,25,50,3.33333333333333,1.66666666666667,4.87804878048781E-03,4.75609756097561E-03,4.63414634146342E-03,4.51219512195122E-03,4.39024390243902E-03,4.26829268292683E-03,4.14634146341464E-03,4.02439024390244E-03,3.90243902439024E-03,3.78048780487805E-03,3.65853658536585E-03,3.53658536585366E-03,3.41463414634146E-03,3.29268292682927E-03,3.17073170731707E-03,3.04878048780488E-03,2.92682926829268E-03,2.80487804878049E-03,2.68292682926829E-03,2.5609756097561E-03,2.4390243902439E-03,2.31707317073171E-03,2.19512195121951E-03,2.07317073170732E-03,1.95121951219512E-03,1.82926829268293E-03,1.70731707317073E-03,1.58536585365854E-03,1.46341463414634E-03,1.34146341463415E-03,1.21951219512195E-03,1.09756097560976E-03,9.75609756097561E-04,8.53658536585367E-04,7.31707317073171E-04,6.09756097560976E-04,4.87804878048781E-04,3.65853658536586E-04,2.4390243902439E-04,1.21951219512195E-04,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={.111111111111111,.108888888888889,.106666666666667,.104444444444444,.102222222222222,.1,9.77777777777778E-02,9.55555555555556E-02,9.33333333333333E-02,1,1,1,1,1,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,2,1.5,1,.5,.02,1.77777777777778E-02,1.55555555555556E-02,1.33333333333333E-02,1.11111111111111E-02,8.88888888888889E-03,6.66666666666667E-03,4.44444444444445E-03,2.22222222222222E-03,}
		valueWeights[dataIndex["default_resis_sleep"]] ={6.41025641025641E-02,6.28205128205128E-02,6.15384615384615E-02,6.02564102564103E-02,.058974358974359,5.76923076923077E-02,5.64102564102564E-02,5.51282051282051E-02,1.25,1.25,1.25,1.25,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.15384615384615,1.66666666666667,3.33333333333333,5,6.66666666666667,8.33333333333333,10,11.6666666666667,13.3333333333333,15,2,1.5,1,.5,1.53846153846154E-02,1.41025641025641E-02,1.28205128205128E-02,1.15384615384615E-02,1.02564102564103E-02,8.97435897435898E-03,7.69230769230769E-03,6.41025641025641E-03,5.12820512820513E-03,3.84615384615385E-03,2.56410256410257E-03,1.28205128205128E-03,}
		valueWeights[dataIndex["default_resis_silence"]] ={.178571428571429,.175,.171428571428571,.167857142857143,.164285714285714,.160714285714286,.157142857142857,.153571428571429,.15,.146428571428571,.142857142857143,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,2.5,1.66666666666667,.833333333333333,.025,2.14285714285714E-02,1.78571428571429E-02,1.42857142857143E-02,1.07142857142857E-02,7.14285714285714E-03,3.57142857142857E-03,}
		valueWeights[dataIndex["default_resis_weakness"]] ={.111111111111111,.108888888888889,.106666666666667,.104444444444444,.102222222222222,.1,9.77777777777778E-02,9.55555555555556E-02,9.33333333333333E-02,1,1,1,1,1,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,.9375,2.67857142857143,5.35714285714286,8.03571428571428,10.7142857142857,13.3928571428571,16.0714285714286,18.75,2,1.5,1,.5,.02,1.77777777777778E-02,1.55555555555556E-02,1.33333333333333E-02,1.11111111111111E-02,8.88888888888889E-03,6.66666666666667E-03,4.44444444444445E-03,2.22222222222222E-03,}
		valueWeights[dataIndex["default_resis_enlace"]] ={.178571428571429,.175,.171428571428571,.167857142857143,.164285714285714,.160714285714286,.157142857142857,.153571428571429,.15,.146428571428571,.142857142857143,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,3.57142857142857,7.14285714285714,10.7142857142857,14.2857142857143,17.8571428571429,21.4285714285714,2.5,1.66666666666667,.833333333333333,.025,2.14285714285714E-02,1.78571428571429E-02,1.42857142857143E-02,1.07142857142857E-02,7.14285714285714E-03,3.57142857142857E-03,}
		
		valueWeights[dataIndex["grow_hp"]] ={7.93650793650794E-03,7.77777777777778E-03,7.61904761904762E-03,1.66666666666667,1.66666666666667,1.66666666666667,2.5,2.5,2.5,2.5,2.5,2.5,25,50,5,5.55555555555556E-03,5.3968253968254E-03,5.23809523809524E-03,5.07936507936508E-03,4.92063492063492E-03,4.76190476190476E-03,4.6031746031746E-03,4.44444444444444E-03,4.28571428571429E-03,4.12698412698413E-03,3.96825396825397E-03,3.80952380952381E-03,3.65079365079365E-03,3.49206349206349E-03,3.33333333333333E-03,3.17460317460317E-03,3.01587301587302E-03,2.85714285714286E-03,2.6984126984127E-03,2.53968253968254E-03,2.38095238095238E-03,2.22222222222222E-03,2.06349206349206E-03,1.9047619047619E-03,1.74603174603175E-03,1.58730158730159E-03,1.42857142857143E-03,1.26984126984127E-03,1.11111111111111E-03,9.52380952380953E-04,7.93650793650793E-04,6.34920634920635E-04,4.76190476190476E-04,3.17460317460318E-04,1.58730158730159E-04,}
		valueWeights[dataIndex["grow_mp"]] ={1.66666666666667E-02,1.63333333333333E-02,.016,1.56666666666667E-02,1.53333333333333E-02,.015,1.66666666666667,1.66666666666667,1.66666666666667,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,12.5,25,37.5,2,1.5,1,.5,.008,7.66666666666667E-03,7.33333333333333E-03,.007,6.66666666666667E-03,6.33333333333333E-03,.006,5.66666666666667E-03,5.33333333333333E-03,.005,4.66666666666667E-03,4.33333333333333E-03,.004,3.66666666666667E-03,3.33333333333333E-03,.003,2.66666666666667E-03,2.33333333333333E-03,.002,1.66666666666667E-03,1.33333333333333E-03,9.99999999999999E-04,6.66666666666666E-04,3.33333333333332E-04,}
		valueWeights[dataIndex["grow_attack_rate"]] ={6.41025641025641E-03,6.28205128205128E-03,5,3.75,3.75,3.75,3.75,25,50,3.33333333333333,1.66666666666667,.005,4.87179487179487E-03,4.74358974358974E-03,4.61538461538462E-03,4.48717948717949E-03,4.35897435897436E-03,4.23076923076923E-03,4.1025641025641E-03,3.97435897435897E-03,3.84615384615385E-03,3.71794871794872E-03,3.58974358974359E-03,3.46153846153846E-03,3.33333333333333E-03,3.20512820512821E-03,3.07692307692308E-03,2.94871794871795E-03,2.82051282051282E-03,2.69230769230769E-03,2.56410256410256E-03,2.43589743589744E-03,2.30769230769231E-03,2.17948717948718E-03,2.05128205128205E-03,1.92307692307692E-03,1.7948717948718E-03,1.66666666666667E-03,1.53846153846154E-03,1.41025641025641E-03,1.28205128205128E-03,1.15384615384615E-03,1.02564102564103E-03,8.97435897435898E-04,7.69230769230769E-04,6.41025641025641E-04,5.12820512820513E-04,3.84615384615385E-04,2.56410256410256E-04,1.28205128205128E-04,}
		valueWeights[dataIndex["grow_damage_low"]] ={2.92397660818713E-02,2.86549707602339E-02,2.80701754385965E-02,2.74853801169591E-02,2.69005847953216E-02,2.63157894736842E-02,2.57309941520468E-02,2.51461988304094E-02,1,1,1,1,1,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,25,50,2.5,1.66666666666667,.833333333333333,1.05263157894737E-02,9.94152046783626E-03,9.35672514619883E-03,8.7719298245614E-03,8.18713450292398E-03,7.60233918128655E-03,7.01754385964912E-03,6.4327485380117E-03,5.84795321637427E-03,5.26315789473684E-03,4.67836257309942E-03,4.09356725146199E-03,3.50877192982456E-03,2.92397660818713E-03,2.33918128654971E-03,1.75438596491228E-03,1.16959064327485E-03,5.84795321637426E-04,}
		valueWeights[dataIndex["grow_damage_high"]] ={2.92397660818713E-02,2.86549707602339E-02,2.80701754385965E-02,2.74853801169591E-02,2.69005847953216E-02,2.63157894736842E-02,2.57309941520468E-02,2.51461988304094E-02,1,1,1,1,1,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,1.07142857142857,25,50,2.5,1.66666666666667,.833333333333333,1.05263157894737E-02,9.94152046783626E-03,9.35672514619883E-03,8.7719298245614E-03,8.18713450292398E-03,7.60233918128655E-03,7.01754385964912E-03,6.4327485380117E-03,5.84795321637427E-03,5.26315789473684E-03,4.67836257309942E-03,4.09356725146199E-03,3.50877192982456E-03,2.92397660818713E-03,2.33918128654971E-03,1.75438596491228E-03,1.16959064327485E-03,5.84795321637426E-04,}
		valueWeights[dataIndex["grow_dodge"]] ={6.09756097560976E-03,5,3.75,3.75,3.75,3.75,25,50,3.33333333333333,1.66666666666667,4.87804878048781E-03,4.75609756097561E-03,4.63414634146342E-03,4.51219512195122E-03,4.39024390243902E-03,4.26829268292683E-03,4.14634146341464E-03,4.02439024390244E-03,3.90243902439024E-03,3.78048780487805E-03,3.65853658536585E-03,3.53658536585366E-03,3.41463414634146E-03,3.29268292682927E-03,3.17073170731707E-03,3.04878048780488E-03,2.92682926829268E-03,2.80487804878049E-03,2.68292682926829E-03,2.5609756097561E-03,2.4390243902439E-03,2.31707317073171E-03,2.19512195121951E-03,2.07317073170732E-03,1.95121951219512E-03,1.82926829268293E-03,1.70731707317073E-03,1.58536585365854E-03,1.46341463414634E-03,1.34146341463415E-03,1.21951219512195E-03,1.09756097560976E-03,9.75609756097561E-04,8.53658536585367E-04,7.31707317073171E-04,6.09756097560976E-04,4.87804878048781E-04,3.65853658536586E-04,2.4390243902439E-04,1.21951219512195E-04,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={3.67647058823529E-02,3.60294117647059E-02,3.52941176470588E-02,3.45588235294118E-02,3.38235294117647E-02,3.30882352941176E-02,3.23529411764706E-02,3.16176470588235E-02,1,1,1,1,1,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,4,8,12,16,2.5,1.66666666666667,.833333333333333,1.17647058823529E-02,1.10294117647059E-02,1.02941176470588E-02,9.55882352941177E-03,8.82352941176471E-03,8.08823529411765E-03,7.35294117647059E-03,6.61764705882353E-03,5.88235294117647E-03,5.14705882352941E-03,4.41176470588235E-03,3.67647058823529E-03,2.94117647058824E-03,2.20588235294118E-03,1.47058823529412E-03,7.3529411764706E-04,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={2.16450216450216E-02,2.12121212121212E-02,2.07792207792208E-02,2.03463203463203E-02,1.99134199134199E-02,1.94805194805195E-02,1.25,1.25,1.25,1.25,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,3.18181818181818,2.66666666666667,5.33333333333333,8,10.6666666666667,13.3333333333333,2.5,1.66666666666667,.833333333333333,9.09090909090909E-03,8.65800865800866E-03,8.22510822510823E-03,7.79220779220779E-03,7.35930735930736E-03,6.92640692640693E-03,6.49350649350649E-03,6.06060606060606E-03,5.62770562770563E-03,5.19480519480519E-03,4.76190476190476E-03,4.32900432900433E-03,3.8961038961039E-03,3.46320346320346E-03,3.03030303030303E-03,2.5974025974026E-03,2.16450216450216E-03,1.73160173160173E-03,1.2987012987013E-03,8.65800865800865E-04,4.32900432900432E-04,}
		valueWeights[dataIndex["grow_resis_silence"]] ={5.49450549450549E-02,5.38461538461538E-02,5.27472527472527E-02,5.16483516483516E-02,5.05494505494506E-02,4.94505494505494E-02,4.83516483516483E-02,4.72527472527473E-02,4.61538461538461E-02,4.50549450549451E-02,1,1,1,1,1,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,6.66666666666667,13.3333333333333,20,3.33333333333333,1.66666666666667,1.42857142857143E-02,1.31868131868132E-02,1.20879120879121E-02,.010989010989011,9.89010989010989E-03,8.79120879120879E-03,7.69230769230769E-03,6.59340659340659E-03,5.49450549450549E-03,4.3956043956044E-03,3.2967032967033E-03,2.1978021978022E-03,1.0989010989011E-03,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={3.67647058823529E-02,3.60294117647059E-02,3.52941176470588E-02,3.45588235294118E-02,3.38235294117647E-02,3.30882352941176E-02,3.23529411764706E-02,3.16176470588235E-02,1,1,1,1,1,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,2.5,4,8,12,16,2.5,1.66666666666667,.833333333333333,1.17647058823529E-02,1.10294117647059E-02,1.02941176470588E-02,9.55882352941177E-03,8.82352941176471E-03,8.08823529411765E-03,7.35294117647059E-03,6.61764705882353E-03,5.88235294117647E-03,5.14705882352941E-03,4.41176470588235E-03,3.67647058823529E-03,2.94117647058824E-03,2.20588235294118E-03,1.47058823529412E-03,7.3529411764706E-04,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={5.49450549450549E-02,5.38461538461538E-02,5.27472527472527E-02,5.16483516483516E-02,5.05494505494506E-02,4.94505494505494E-02,4.83516483516483E-02,4.72527472527473E-02,4.61538461538461E-02,4.50549450549451E-02,1,1,1,1,1,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,2.05882352941176,6.66666666666667,13.3333333333333,20,3.33333333333333,1.66666666666667,1.42857142857143E-02,1.31868131868132E-02,1.20879120879121E-02,.010989010989011,9.89010989010989E-03,8.79120879120879E-03,7.69230769230769E-03,6.59340659340659E-03,5.49450549450549E-03,4.3956043956044E-03,3.2967032967033E-03,2.1978021978022E-03,1.0989010989011E-03,}

	---九龙神火罩	通用
	elseif tmplID == talismans["US_105_JiuLongShenHuoZhao"].tmplID then
	
		valueWeights[dataIndex["default_hp"]]= {.012, .012, .012, .012, .011, 1.667, 1.667, 1.667, 1.667, 1.667, 1.667, 1.667, 1.667, 1.667, 1.667, 1.667, 1.667, 10, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["default_mp"]]= {.014, .014, .014, .013, .013, 1.667, 1.667, 1.667, 1.875, 1.875, 1.875, 1.875, 1.875, 1.875, 1.875, 1.875, 5, 10, 15, 20, 25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["default_attack_rate"]]= {.01, .01, .01, .009, 2.5, 2.5, 2.143, 2.143, 2.143, 2.143, 2.143, 2.143, 2.143, 12.5, 25, 37.5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["default_damage_low"]]= {.042, .041, .04, .039, .038, .038, .037, .036, .035, 1.25, 1.25, 1.25, 1.25, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 5, 10, 15, 20, 25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["default_damage_high"]]= {.042, .041, .04, .039, .038, .038, .037, .036, .035, 1.25, 1.25, 1.25, 1.25, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 5, 10, 15, 20, 25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["default_dodge"]]= {.01, .01, .01, 1.667, 1.667, 1.667, 2.5, 2.5, 2.5, 2.5, 2.5, 2.5, 7.5, 15, 22.5, 30, 2.5, 1.667, .833, .006, .006, .006, .006, .005, .005, .005, .005, .005, .004, .004, .004, .004, .004, .003, .003, .003, .003, .003, .002, .002, .002, .002, .002, .001, .001, .001, .001, .001, 0, 0,  }
		valueWeights[dataIndex["default_defense"]]= {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,  }
		valueWeights[dataIndex["default_resis_stun"]]= {.139, .136, .133, .131, .128, .125, .122, .119, .117, .114, 1, 1, 1, 1, 1, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, 2.679, 5.357, 8.036, 10.714, 13.393, 16.071, 18.75, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["default_resis_sleep"]]= {.091, .089, .087, .085, .084, .082, .08, .078, .076, 1, 1, 1, 1, 1, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 2.083, 4.167, 6.25, 8.333, 10.417, 12.5, 14.583, 16.667, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["default_resis_silence"]]= {.091, .089, .087, .085, .084, .082, .08, .078, .076, 1, 1, 1, 1, 1, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 2.083, 4.167, 6.25, 8.333, 10.417, 12.5, 14.583, 16.667, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["default_resis_weakness"]]= {.139, .136, .133, .131, .128, .125, .122, .119, .117, .114, 1, 1, 1, 1, 1, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, 2.679, 5.357, 8.036, 10.714, 13.393, 16.071, 18.75, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["default_resis_enlace"]]= {.139, .136, .133, .131, .128, .125, .122, .119, .117, .114, 1, 1, 1, 1, 1, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, .938, 2.679, 5.357, 8.036, 10.714, 13.393, 16.071, 18.75, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		
		valueWeights[dataIndex["grow_hp"]]= {.011, .011, .01, .01, .01, 0, 0, 1.667, 1.667, 1.667, 1.667, 1.667, 1.667, 1.667, 1.667, 1.667, 25, 50, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["grow_mp"]]= {.011, .011, .011, .011, 0, 0, 0, 1.875, 1.875, 1.875, 1.875, 1.875, 1.875, 1.875, 1.875, 12.5, 25, 37.5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["grow_attack_rate"]]= {.01, .01, .01, .009, 0, 0, 2.143, 2.143, 2.143, 2.143, 2.143, 2.143, 2.143, 12.5, 25, 37.5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["grow_damage_low"]]= {.026, .026, .025, .025, .024, .024, .023, .023, 0, 0, 0, 0, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 12.5, 25, 37.5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["grow_damage_high"]]= {.026, .026, .025, .025, .024, .024, .023, .023, 0, 0, 0, 0, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 1.071, 12.5, 25, 37.5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["grow_dodge"]]= {.01, .01, .01, 0, 0, 0, 2.5, 2.5, 2.5, 2.5, 2.5, 2.5, 7.5, 15, 22.5, 30, 2.5, 1.667, .833, .006, .006, .006, .006, .005, .005, .005, .005, .005, .004, .004, .004, .004, .004, .003, .003, .003, .003, .003, .002, .002, .002, .002, .002, .001, .001, .001, .001, .001, 0, 0,  }
		valueWeights[dataIndex["grow_defense"]]= {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,  }
		valueWeights[dataIndex["grow_resis_stun"]]= {.042, .041, .04, .039, .038, .038, .037, .036, .035, 0, 0, 0, 0, 0, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 6.667, 13.333, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["grow_resis_sleep"]]= {.029, .029, .028, .027, .027, .026, .026, 0, 0, 0, 0, 0, 2.692, 2.692, 2.692, 2.692, 2.692, 2.692, 2.692, 2.692, 2.692, 2.692, 2.692, 2.692, 2.692, 4, 8, 12, 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["grow_resis_silence"]]= {.029, .029, .028, .027, .027, .026, .026, 0, 0, 0, 0, 0, 2.692, 2.692, 2.692, 2.692, 2.692, 2.692, 2.692, 2.692, 2.692, 2.692, 2.692, 2.692, 2.692, 4, 8, 12, 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["grow_resis_weakness"]]= {.042, .041, .04, .039, .038, .038, .037, .036, .035, 0, 0, 0, 0, 0, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 6.667, 13.333, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }
		valueWeights[dataIndex["grow_resis_enlace"]]= {.042, .041, .04, .039, .038, .038, .037, .036, .035, 0, 0, 0, 0, 0, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 2.333, 6.667, 13.333, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  }

	---金葫芦	通用 2007－11－06彩票二等奖，至少是仙品
	elseif tmplID == talismans["US_105_JinHuLu"].tmplID then

		valueWeights[dataIndex["default_hp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10,10,10,10,.1,.06,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_mp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10,10,10,10,.1,.06,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_attack_rate"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,10,10,.1,.06,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,10,10,.1,.06,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_dodge"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		
		valueWeights[dataIndex["grow_hp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_mp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_attack_rate"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_dodge"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}

	---阴阳镜	通用 2007－11－27 大箱子彩票一等奖，至少是仙品
	elseif tmplID == talismans["US_105_YinYangJing"].tmplID 
			or tmplID == talismans["US_105_YinYangJing_WZGL"].tmplID then
		
		valueWeights[dataIndex["default_hp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10,10,10,10,.1,.06,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_mp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10,10,10,10,.1,.06,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_attack_rate"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,10,10,.1,.06,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,10,10,.1,.06,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_dodge"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		
		valueWeights[dataIndex["grow_hp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_mp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_attack_rate"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_dodge"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}

	---蟠龙幡	通用
	elseif tmplID == talismans["US_135_PanLongFan"].tmplID then

		valueWeights[dataIndex["default_hp"]] ={5.49450549450549E-02,5.38461538461538E-02,5.27472527472527E-02,5.16483516483516E-02,5.05494505494506E-02,4.94505494505494E-02,1.25,1.25,1.25,1.25,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,1.36363636363636,12.5,25,37.5,.714285714285714,.659340659340659,.604395604395604,.54945054945055,.494505494505495,.43956043956044,.384615384615385,.32967032967033,.274725274725275,.21978021978022,.164835164835165,.10989010989011,.054945054945055,1.42857142857143E-02,1.31868131868132E-02,1.20879120879121E-02,.010989010989011,9.89010989010989E-03,8.79120879120879E-03,7.69230769230769E-03,6.59340659340659E-03,5.49450549450549E-03,4.3956043956044E-03,3.2967032967033E-03,2.1978021978022E-03,1.0989010989011E-03,}
		valueWeights[dataIndex["default_mp"]] ={7.57575757575758E-02,7.42424242424242E-02,7.27272727272727E-02,7.12121212121212E-02,6.96969696969697E-02,6.81818181818182E-02,6.66666666666667E-02,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,1.25,7.5,15,22.5,30,.769230769230769,.705128205128205,.641025641025641,.576923076923077,.512820512820513,.448717948717949,.384615384615385,.32051282051282,.256410256410256,.192307692307692,.128205128205128,6.41025641025641E-02,1.66666666666667E-02,1.51515151515152E-02,1.36363636363636E-02,1.21212121212121E-02,1.06060606060606E-02,9.09090909090909E-03,7.57575757575758E-03,6.06060606060606E-03,4.54545454545455E-03,3.03030303030303E-03,1.51515151515151E-03,}
		valueWeights[dataIndex["default_attack_rate"]] ={4.76190476190476E-02,4.66666666666667E-02,4.57142857142857E-02,4.47619047619048E-02,4.38095238095238E-02,1.25,1.25,1.25,1.25,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,7.5,15,22.5,30,.666666666666667,.619047619047619,.571428571428571,.523809523809524,.476190476190476,.428571428571429,.380952380952381,.333333333333333,.285714285714286,.238095238095238,.19047619047619,.142857142857143,9.52380952380952E-02,4.76190476190476E-02,1.33333333333333E-02,1.23809523809524E-02,1.14285714285714E-02,1.04761904761905E-02,9.52380952380952E-03,8.57142857142857E-03,7.61904761904762E-03,6.66666666666667E-03,5.71428571428571E-03,4.76190476190476E-03,3.80952380952381E-03,2.85714285714286E-03,1.9047619047619E-03,9.52380952380951E-04,}
		valueWeights[dataIndex["default_damage_low"]] ={.238095238095238,.233333333333333,.228571428571429,.223809523809524,.219047619047619,.214285714285714,.20952380952381,.204761904761905,.2,.195238095238095,.19047619047619,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,7.5,15,22.5,30,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,2.85714285714286E-02,2.38095238095238E-02,.019047619047619,1.42857142857143E-02,9.52380952380952E-03,4.76190476190476E-03,}
		valueWeights[dataIndex["default_damage_high"]] ={.238095238095238,.233333333333333,.228571428571429,.223809523809524,.219047619047619,.214285714285714,.20952380952381,.204761904761905,.2,.195238095238095,.19047619047619,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,7.5,15,22.5,30,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,2.85714285714286E-02,2.38095238095238E-02,.019047619047619,1.42857142857143E-02,9.52380952380952E-03,4.76190476190476E-03,}
		valueWeights[dataIndex["default_dodge"]] ={4.76190476190476E-02,4.66666666666667E-02,4.57142857142857E-02,4.47619047619048E-02,4.38095238095238E-02,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,7.5,15,22.5,30,.625,.583333333333333,.541666666666667,.5,.458333333333333,.416666666666667,.375,.333333333333333,.291666666666667,.25,.208333333333333,.166666666666667,.125,8.33333333333334E-02,4.16666666666667E-02,1.33333333333333E-02,1.23809523809524E-02,1.14285714285714E-02,1.04761904761905E-02,9.52380952380952E-03,8.57142857142857E-03,7.61904761904762E-03,6.66666666666667E-03,5.71428571428571E-03,4.76190476190476E-03,3.80952380952381E-03,2.85714285714286E-03,1.9047619047619E-03,9.52380952380951E-04,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={.833333333333333,.816666666666667,.8,.783333333333333,.766666666666667,.75,.733333333333333,.716666666666667,.7,.683333333333333,.666666666666667,.65,.633333333333333,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,7.5,15,22.5,30,2.5,1.66666666666667,.833333333333333,.05,3.33333333333333E-02,1.66666666666667E-02,}
		valueWeights[dataIndex["default_resis_sleep"]] ={.833333333333333,.816666666666667,.8,.783333333333333,.766666666666667,.75,.733333333333333,.716666666666667,.7,.683333333333333,.666666666666667,.65,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,7.5,15,22.5,30,2,1.5,1,.5,.05,3.33333333333333E-02,1.66666666666667E-02,}
		valueWeights[dataIndex["default_resis_silence"]] ={.833333333333333,.816666666666667,.8,.783333333333333,.766666666666667,.75,.733333333333333,.716666666666667,.7,.683333333333333,.666666666666667,.65,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,7.5,15,22.5,30,2,1.5,1,.5,.05,3.33333333333333E-02,1.66666666666667E-02,}
		valueWeights[dataIndex["default_resis_weakness"]] ={.833333333333333,.816666666666667,.8,.783333333333333,.766666666666667,.75,.733333333333333,.716666666666667,.7,.683333333333333,.666666666666667,.65,.633333333333333,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,7.5,15,22.5,30,2.5,1.66666666666667,.833333333333333,.05,3.33333333333333E-02,1.66666666666667E-02,}
		valueWeights[dataIndex["default_resis_enlace"]] ={.833333333333333,.816666666666667,.8,.783333333333333,.766666666666667,.75,.733333333333333,.716666666666667,.7,.683333333333333,.666666666666667,.65,.633333333333333,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,7.5,15,22.5,30,2.5,1.66666666666667,.833333333333333,.05,3.33333333333333E-02,1.66666666666667E-02,}
		
		valueWeights[dataIndex["grow_hp"]] ={4.76190476190476E-02,4.66666666666667E-02,4.57142857142857E-02,4.47619047619048E-02,4.38095238095238E-02,4.28571428571429E-02,0,0,0,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,12.5,25,37.5,.666666666666667,.619047619047619,.571428571428571,.523809523809524,.476190476190476,.428571428571429,.380952380952381,.333333333333333,.285714285714286,.238095238095238,.19047619047619,.142857142857143,9.52380952380952E-02,4.76190476190476E-02,1.33333333333333E-02,1.23809523809524E-02,1.14285714285714E-02,1.04761904761905E-02,9.52380952380952E-03,8.57142857142857E-03,7.61904761904762E-03,6.66666666666667E-03,5.71428571428571E-03,4.76190476190476E-03,3.80952380952381E-03,2.85714285714286E-03,1.9047619047619E-03,9.52380952380951E-04,}
		valueWeights[dataIndex["grow_mp"]] ={5.49450549450549E-02,5.38461538461538E-02,5.27472527472527E-02,5.16483516483516E-02,5.05494505494506E-02,4.94505494505494E-02,0,0,0,0,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,.769230769230769,.705128205128205,.641025641025641,.576923076923077,.512820512820513,.448717948717949,.384615384615385,.32051282051282,.256410256410256,.192307692307692,.128205128205128,6.41025641025641E-02,1.42857142857143E-02,1.31868131868132E-02,1.20879120879121E-02,.010989010989011,9.89010989010989E-03,8.79120879120879E-03,7.69230769230769E-03,6.59340659340659E-03,5.49450549450549E-03,4.3956043956044E-03,3.2967032967033E-03,2.1978021978022E-03,1.0989010989011E-03,}
		valueWeights[dataIndex["grow_attack_rate"]] ={4.76190476190476E-02,4.66666666666667E-02,4.57142857142857E-02,4.47619047619048E-02,4.38095238095238E-02,0,0,0,0,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,7.5,15,22.5,30,.666666666666667,.619047619047619,.571428571428571,.523809523809524,.476190476190476,.428571428571429,.380952380952381,.333333333333333,.285714285714286,.238095238095238,.19047619047619,.142857142857143,9.52380952380952E-02,4.76190476190476E-02,1.33333333333333E-02,1.23809523809524E-02,1.14285714285714E-02,1.04761904761905E-02,9.52380952380952E-03,8.57142857142857E-03,7.61904761904762E-03,6.66666666666667E-03,5.71428571428571E-03,4.76190476190476E-03,3.80952380952381E-03,2.85714285714286E-03,1.9047619047619E-03,9.52380952380951E-04,}
		valueWeights[dataIndex["grow_damage_low"]] ={.138888888888889,.136111111111111,.133333333333333,.130555555555556,.127777777777778,.125,.122222222222222,.119444444444444,.116666666666667,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,7.5,15,22.5,30,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,2.22222222222222E-02,1.94444444444444E-02,1.66666666666667E-02,1.38888888888889E-02,1.11111111111111E-02,8.33333333333333E-03,5.55555555555556E-03,2.77777777777778E-03,}
		valueWeights[dataIndex["grow_damage_high"]] ={.138888888888889,.136111111111111,.133333333333333,.130555555555556,.127777777777778,.125,.122222222222222,.119444444444444,.116666666666667,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,7.5,15,22.5,30,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,2.22222222222222E-02,1.94444444444444E-02,1.66666666666667E-02,1.38888888888889E-02,1.11111111111111E-02,8.33333333333333E-03,5.55555555555556E-03,2.77777777777778E-03,}
		valueWeights[dataIndex["grow_dodge"]] ={4.76190476190476E-02,4.66666666666667E-02,4.57142857142857E-02,4.47619047619048E-02,4.38095238095238E-02,0,0,0,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,7.5,15,22.5,30,.625,.583333333333333,.541666666666667,.5,.458333333333333,.416666666666667,.375,.333333333333333,.291666666666667,.25,.208333333333333,.166666666666667,.125,8.33333333333334E-02,4.16666666666667E-02,1.33333333333333E-02,1.23809523809524E-02,1.14285714285714E-02,1.04761904761905E-02,9.52380952380952E-03,8.57142857142857E-03,7.61904761904762E-03,6.66666666666667E-03,5.71428571428571E-03,4.76190476190476E-03,3.80952380952381E-03,2.85714285714286E-03,1.9047619047619E-03,9.52380952380951E-04,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={.238095238095238,.233333333333333,.228571428571429,.223809523809524,.219047619047619,.214285714285714,.20952380952381,.204761904761905,.2,.195238095238095,.19047619047619,0,0,0,0,0,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,6.66666666666667,13.3333333333333,20,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,2.85714285714286E-02,2.38095238095238E-02,.019047619047619,1.42857142857143E-02,9.52380952380952E-03,4.76190476190476E-03,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={.138888888888889,.136111111111111,.133333333333333,.130555555555556,.127777777777778,.125,.122222222222222,.119444444444444,.116666666666667,.113888888888889,0,0,0,0,0,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,6.66666666666667,13.3333333333333,20,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,2.22222222222222E-02,1.94444444444444E-02,1.66666666666667E-02,1.38888888888889E-02,1.11111111111111E-02,8.33333333333333E-03,5.55555555555556E-03,2.77777777777778E-03,}
		valueWeights[dataIndex["grow_resis_silence"]] ={.138888888888889,.136111111111111,.133333333333333,.130555555555556,.127777777777778,.125,.122222222222222,.119444444444444,.116666666666667,.113888888888889,0,0,0,0,0,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,6.66666666666667,13.3333333333333,20,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,2.22222222222222E-02,1.94444444444444E-02,1.66666666666667E-02,1.38888888888889E-02,1.11111111111111E-02,8.33333333333333E-03,5.55555555555556E-03,2.77777777777778E-03,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={.238095238095238,.233333333333333,.228571428571429,.223809523809524,.219047619047619,.214285714285714,.20952380952381,.204761904761905,.2,.195238095238095,.19047619047619,0,0,0,0,0,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,6.66666666666667,13.3333333333333,20,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,2.85714285714286E-02,2.38095238095238E-02,.019047619047619,1.42857142857143E-02,9.52380952380952E-03,4.76190476190476E-03,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={.238095238095238,.233333333333333,.228571428571429,.223809523809524,.219047619047619,.214285714285714,.20952380952381,.204761904761905,.2,.195238095238095,.19047619047619,0,0,0,0,0,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,6.66666666666667,13.3333333333333,20,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,2.85714285714286E-02,2.38095238095238E-02,.019047619047619,1.42857142857143E-02,9.52380952380952E-03,4.76190476190476E-03,}

	---	135门派法宝
	elseif tmplID == talismans["GW_135_TianMoZhi"].tmplID
			or tmplID == talismans["QY_135_RuoXue"].tmplID
			or tmplID == talismans["HH_135_BaJiYouLong"].tmplID
			or tmplID == talismans["TY_135_LiuDaoShengMie"].tmplID 
			or tmplID == talismans["GD_135_GuiQing"].tmplID
			or tmplID == talismans["FX_135_JiuHanNingBingCi"].tmplID
			or tmplID == talismans["JL_135_SangMenJian"].tmplID
			or tmplID == talismans["LS_135_LuoShu"].tmplID
			or tmplID == talismans["HG_135_JueYing"].tmplID
			or tmplID == talismans["TH_135_BiLuoFeiHong"].tmplID
			or tmplID == talismans["TH_135_XiHuangZhong"].tmplID
			or tmplID == talismans["CH_135_huangji"].tmplID
			or tmplID == talismans["QJ_135_chixinglongyan"].tmplID
			or tmplID == talismans["YZ_135_zhuihun"].tmplID
			then
	
		valueWeights[dataIndex["default_hp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10,10,10,10,.1,.06,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_mp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10,10,10,10,.1,.06,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_attack_rate"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,10,10,.1,.06,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,10,10,.1,.06,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_dodge"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		
		valueWeights[dataIndex["grow_hp"]] ={4.76190476190476E-02,4.66666666666667E-02,4.57142857142857E-02,4.47619047619048E-02,4.38095238095238E-02,4.28571428571429E-02,0,0,0,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,12.5,25,37.5,.666666666666667,.619047619047619,.571428571428571,.523809523809524,.476190476190476,.428571428571429,.380952380952381,.333333333333333,.285714285714286,.238095238095238,.19047619047619,.142857142857143,9.52380952380952E-02,4.76190476190476E-02,1.33333333333333E-02,1.23809523809524E-02,1.14285714285714E-02,1.04761904761905E-02,9.52380952380952E-03,8.57142857142857E-03,7.61904761904762E-03,6.66666666666667E-03,5.71428571428571E-03,4.76190476190476E-03,3.80952380952381E-03,2.85714285714286E-03,1.9047619047619E-03,9.52380952380951E-04,}
		valueWeights[dataIndex["grow_mp"]] ={5.49450549450549E-02,5.38461538461538E-02,5.27472527472527E-02,5.16483516483516E-02,5.05494505494506E-02,4.94505494505494E-02,0,0,0,0,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,1.5,5,10,15,20,25,.769230769230769,.705128205128205,.641025641025641,.576923076923077,.512820512820513,.448717948717949,.384615384615385,.32051282051282,.256410256410256,.192307692307692,.128205128205128,6.41025641025641E-02,1.42857142857143E-02,1.31868131868132E-02,1.20879120879121E-02,.010989010989011,9.89010989010989E-03,8.79120879120879E-03,7.69230769230769E-03,6.59340659340659E-03,5.49450549450549E-03,4.3956043956044E-03,3.2967032967033E-03,2.1978021978022E-03,1.0989010989011E-03,}
		valueWeights[dataIndex["grow_attack_rate"]] ={4.76190476190476E-02,4.66666666666667E-02,4.57142857142857E-02,4.47619047619048E-02,4.38095238095238E-02,0,0,0,0,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,7.5,15,22.5,30,.666666666666667,.619047619047619,.571428571428571,.523809523809524,.476190476190476,.428571428571429,.380952380952381,.333333333333333,.285714285714286,.238095238095238,.19047619047619,.142857142857143,9.52380952380952E-02,4.76190476190476E-02,1.33333333333333E-02,1.23809523809524E-02,1.14285714285714E-02,1.04761904761905E-02,9.52380952380952E-03,8.57142857142857E-03,7.61904761904762E-03,6.66666666666667E-03,5.71428571428571E-03,4.76190476190476E-03,3.80952380952381E-03,2.85714285714286E-03,1.9047619047619E-03,9.52380952380951E-04,}
		valueWeights[dataIndex["grow_damage_low"]] ={.138888888888889,.136111111111111,.133333333333333,.130555555555556,.127777777777778,.125,.122222222222222,.119444444444444,.116666666666667,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,7.5,15,22.5,30,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,2.22222222222222E-02,1.94444444444444E-02,1.66666666666667E-02,1.38888888888889E-02,1.11111111111111E-02,8.33333333333333E-03,5.55555555555556E-03,2.77777777777778E-03,}
		valueWeights[dataIndex["grow_damage_high"]] ={.138888888888889,.136111111111111,.133333333333333,.130555555555556,.127777777777778,.125,.122222222222222,.119444444444444,.116666666666667,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,7.5,15,22.5,30,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,2.22222222222222E-02,1.94444444444444E-02,1.66666666666667E-02,1.38888888888889E-02,1.11111111111111E-02,8.33333333333333E-03,5.55555555555556E-03,2.77777777777778E-03,}
		valueWeights[dataIndex["grow_dodge"]] ={4.76190476190476E-02,4.66666666666667E-02,4.57142857142857E-02,4.47619047619048E-02,4.38095238095238E-02,0,0,0,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,7.5,15,22.5,30,.625,.583333333333333,.541666666666667,.5,.458333333333333,.416666666666667,.375,.333333333333333,.291666666666667,.25,.208333333333333,.166666666666667,.125,8.33333333333334E-02,4.16666666666667E-02,1.33333333333333E-02,1.23809523809524E-02,1.14285714285714E-02,1.04761904761905E-02,9.52380952380952E-03,8.57142857142857E-03,7.61904761904762E-03,6.66666666666667E-03,5.71428571428571E-03,4.76190476190476E-03,3.80952380952381E-03,2.85714285714286E-03,1.9047619047619E-03,9.52380952380951E-04,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={.238095238095238,.233333333333333,.228571428571429,.223809523809524,.219047619047619,.214285714285714,.20952380952381,.204761904761905,.2,.195238095238095,.19047619047619,0,0,0,0,0,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,6.66666666666667,13.3333333333333,20,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,2.85714285714286E-02,2.38095238095238E-02,.019047619047619,1.42857142857143E-02,9.52380952380952E-03,4.76190476190476E-03,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={.138888888888889,.136111111111111,.133333333333333,.130555555555556,.127777777777778,.125,.122222222222222,.119444444444444,.116666666666667,.113888888888889,0,0,0,0,0,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,6.66666666666667,13.3333333333333,20,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,2.22222222222222E-02,1.94444444444444E-02,1.66666666666667E-02,1.38888888888889E-02,1.11111111111111E-02,8.33333333333333E-03,5.55555555555556E-03,2.77777777777778E-03,}
		valueWeights[dataIndex["grow_resis_silence"]] ={.138888888888889,.136111111111111,.133333333333333,.130555555555556,.127777777777778,.125,.122222222222222,.119444444444444,.116666666666667,.113888888888889,0,0,0,0,0,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,2.1875,6.66666666666667,13.3333333333333,20,1.11111111111111,.972222222222222,.833333333333333,.694444444444444,.555555555555556,.416666666666667,.277777777777778,.138888888888889,2.22222222222222E-02,1.94444444444444E-02,1.66666666666667E-02,1.38888888888889E-02,1.11111111111111E-02,8.33333333333333E-03,5.55555555555556E-03,2.77777777777778E-03,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={.238095238095238,.233333333333333,.228571428571429,.223809523809524,.219047619047619,.214285714285714,.20952380952381,.204761904761905,.2,.195238095238095,.19047619047619,0,0,0,0,0,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,6.66666666666667,13.3333333333333,20,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,2.85714285714286E-02,2.38095238095238E-02,.019047619047619,1.42857142857143E-02,9.52380952380952E-03,4.76190476190476E-03,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={.238095238095238,.233333333333333,.228571428571429,.223809523809524,.219047619047619,.214285714285714,.20952380952381,.204761904761905,.2,.195238095238095,.19047619047619,0,0,0,0,0,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,1.94444444444444,6.66666666666667,13.3333333333333,20,1.25,1.07142857142857,.892857142857143,.714285714285714,.535714285714286,.357142857142857,.178571428571429,2.85714285714286E-02,2.38095238095238E-02,.019047619047619,1.42857142857143E-02,9.52380952380952E-03,4.76190476190476E-03,}

	---135通用法宝
	elseif tmplID == talismans["US_135_WuLongLun"].tmplID
			or tmplID == talismans["US_135_FanTianYin"].tmplID
			or tmplID == talismans["US_135_ChangMingDeng"].tmplID
			or tmplID == talismans["US_135_BaoKuZhiHun"].tmplID
			or tmplID == talismans["US_135_SheHun"].tmplID
			or tmplID == talismans["US_145_ShiXueZhu"].tmplID
			or tmplID == talismans["US_145_ShiHun"].tmplID
			or tmplID == talismans["US_145_TianYa"].tmplID
			or tmplID == talismans["foodtalisman"].tmplID then
	
		valueWeights[dataIndex["default_hp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0.1,0.1,0.5,1,1,1,1,1,1,1,1,1,0.5,0.1,0.1,}
		valueWeights[dataIndex["default_mp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0.1,0.1,0.5,1,1,1,1,1,1,1,1,1,0.5,0.1,0.1,}
		valueWeights[dataIndex["default_attack_rate"]] ={0,0,0,0,0,0,0,0,0,0,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,7.5,15,22.5,30,.666666666666667,.619047619047619,.571428571428571,.523809523809524,.476190476190476,.428571428571429,.380952380952381,.333333333333333,.285714285714286,.238095238095238,.19047619047619,.142857142857143,9.52380952380952E-02,4.76190476190476E-02,1.33333333333333E-02,1.23809523809524E-02,1.14285714285714E-02,1.04761904761905E-02,9.52380952380952E-03,8.57142857142857E-03,7.61904761904762E-03,6.66666666666667E-03,5.71428571428571E-03,4.76190476190476E-03,3.80952380952381E-03,2.85714285714286E-03,1.9047619047619E-03,9.52380952380951E-04,}
		valueWeights[dataIndex["default_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0.1,0.1,0.5,1,1,1,1,1,1,1,1,1,0.5,0.1,0.1,}
		valueWeights[dataIndex["default_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0.1,0.1,0.5,1,1,1,1,1,1,1,1,1,0.5,0.1,0.1,}
		valueWeights[dataIndex["default_dodge"]] ={0,0,0,0,0,0,0,0,0,0,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,7.5,15,22.5,30,.625,.583333333333333,.541666666666667,.5,.458333333333333,.416666666666667,.375,.333333333333333,.291666666666667,.25,.208333333333333,.166666666666667,.125,8.33333333333334E-02,4.16666666666667E-02,1.33333333333333E-02,1.23809523809524E-02,1.14285714285714E-02,1.04761904761905E-02,9.52380952380952E-03,8.57142857142857E-03,7.61904761904762E-03,6.66666666666667E-03,5.71428571428571E-03,4.76190476190476E-03,3.80952380952381E-03,2.85714285714286E-03,1.9047619047619E-03,9.52380952380951E-04,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,.666666666666667,.65,.633333333333333,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,7.5,15,22.5,30,2.5,1.66666666666667,.833333333333333,.05,3.33333333333333E-02,1.66666666666667E-02,}
		valueWeights[dataIndex["default_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,.666666666666667,.65,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,7.5,15,22.5,30,2,1.5,1,.5,.05,3.33333333333333E-02,1.66666666666667E-02,}
		valueWeights[dataIndex["default_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,.666666666666667,.65,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,7.5,15,22.5,30,2,1.5,1,.5,.05,3.33333333333333E-02,1.66666666666667E-02,}
		valueWeights[dataIndex["default_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,.666666666666667,.65,.633333333333333,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,7.5,15,22.5,30,2.5,1.66666666666667,.833333333333333,.05,3.33333333333333E-02,1.66666666666667E-02,}
		valueWeights[dataIndex["default_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,.666666666666667,.65,.633333333333333,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,.75,7.5,15,22.5,30,2.5,1.66666666666667,.833333333333333,.05,3.33333333333333E-02,1.66666666666667E-02,}
		
		valueWeights[dataIndex["grow_hp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0.1,0.2,0.3,0.4,0.5,0.6,0.7,0.8,1,1,1,1,1,0.8,0.7,0.6,0.5,0.4,0.3,0.2,0.1,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_mp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0.1,0.2,0.3,0.4,0.5,0.6,0.7,0.8,1,1,1,1,1,0.8,0.7,0.6,0.5,0.4,0.3,0.2,0.1,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_attack_rate"]] ={0,0,0,0,0,0,0,0,0,0,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,7.5,15,22.5,30,.666666666666667,.619047619047619,.571428571428571,.523809523809524,.476190476190476,.428571428571429,.380952380952381,.333333333333333,.285714285714286,.238095238095238,.19047619047619,.142857142857143,9.52380952380952E-02,4.76190476190476E-02,1.33333333333333E-02,1.23809523809524E-02,1.14285714285714E-02,1.04761904761905E-02,9.52380952380952E-03,8.57142857142857E-03,7.61904761904762E-03,6.66666666666667E-03,5.71428571428571E-03,4.76190476190476E-03,3.80952380952381E-03,2.85714285714286E-03,1.9047619047619E-03,9.52380952380951E-04,}
		valueWeights[dataIndex["grow_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,.19047619047619,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,7.5,15,22.5,30,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,2.85714285714286E-02,2.38095238095238E-02,.019047619047619,1.42857142857143E-02,9.52380952380952E-03,4.76190476190476E-03,}
		valueWeights[dataIndex["grow_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,.19047619047619,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.833333333333333,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,.882352941176471,7.5,15,22.5,30,1.42857142857143,1.19047619047619,.952380952380952,.714285714285714,.476190476190476,.238095238095238,2.85714285714286E-02,2.38095238095238E-02,.019047619047619,1.42857142857143E-02,9.52380952380952E-03,4.76190476190476E-03,}
		valueWeights[dataIndex["grow_dodge"]] ={0,0,0,0,0,0,0,0,0,0,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,1.66666666666667,7.5,15,22.5,30,.625,.583333333333333,.541666666666667,.5,.458333333333333,.416666666666667,.375,.333333333333333,.291666666666667,.25,.208333333333333,.166666666666667,.125,8.33333333333334E-02,4.16666666666667E-02,1.33333333333333E-02,1.23809523809524E-02,1.14285714285714E-02,1.04761904761905E-02,9.52380952380952E-03,8.57142857142857E-03,7.61904761904762E-03,6.66666666666667E-03,5.71428571428571E-03,4.76190476190476E-03,3.80952380952381E-03,2.85714285714286E-03,1.9047619047619E-03,9.52380952380951E-04,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,.666666666666667,.65,.633333333333333,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,4,8,12,16,2.5,1.66666666666667,.833333333333333,.05,3.33333333333333E-02,1.66666666666667E-02,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,.666666666666667,.65,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,4,8,12,16,2,1.5,1,.5,.05,3.33333333333333E-02,1.66666666666667E-02,}
		valueWeights[dataIndex["grow_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,.666666666666667,.65,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,4,8,12,16,2,1.5,1,.5,.05,3.33333333333333E-02,1.66666666666667E-02,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,.666666666666667,.65,.633333333333333,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,4,8,12,16,2.5,1.66666666666667,.833333333333333,.05,3.33333333333333E-02,1.66666666666667E-02,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,.666666666666667,.65,.633333333333333,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,.714285714285714,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,1.75,4,8,12,16,2.5,1.66666666666667,.833333333333333,.05,3.33333333333333E-02,1.66666666666667E-02,}

	
	---落魂灯	通用 2008－3－18 彩票二等奖，至少是仙品
	elseif tmplID == talismans["US_105_LuoHunDeng"].tmplID then
		
	  valueWeights[dataIndex["default_hp"]]={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10,10,.1,.06,0,0,0,0,0,0,0,}
	  valueWeights[dataIndex["default_mp"]] 						={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10,10,.1,.06,0,0,0,0,0,0,0,}
	  valueWeights[dataIndex["default_attack_rate"]] 		={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
	  valueWeights[dataIndex["default_damage_low"]] 		={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,10,10,.1,.06,0,0,0,0,0,0,0,}
	  valueWeights[dataIndex["default_damage_high"]] 		={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,10,10,.1,.06,0,0,0,0,0,0,0,}
	  valueWeights[dataIndex["default_dodge"]] 					={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
    valueWeights[dataIndex["default_defense"]] 				={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
    valueWeights[dataIndex["default_resis_stun"]] 		={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,}
	  valueWeights[dataIndex["default_resis_sleep"]] 		={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,}
	  valueWeights[dataIndex["default_resis_silence"]] 	={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,}
	  valueWeights[dataIndex["default_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,}
	  valueWeights[dataIndex["default_resis_enlace"]] 	={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,}

		valueWeights[dataIndex["grow_hp"]]								={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_mp"]] 								={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_attack_rate"]] 			={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
  	valueWeights[dataIndex["grow_damage_low"]] 				={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_high"]] 			={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_dodge"]] 						={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_defense"]] 					={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] 				={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_sleep"]] 			={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_silence"]] 		={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_weakness"]] 		={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_enlace"]] 			={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}

---真山河扇	通用 && 日月宝鉴 && 元宵灯
	elseif tmplID == talismans["US_105_ZhenShanHeShan"].tmplID
			or tmplID == talismans["US_75_RiYueBaoJian"].tmplID
			or tmplID == talismans["US_45_YuanXiaoDeng"].tmplID
			or tmplID == talismans["US_105_FuTu"].tmplID
			or tmplID == talismans["US_135_YinHunFan"].tmplID then
		
		valueWeights[dataIndex["default_hp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10,10,10,10,.1,.06,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_mp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10,10,10,10,.1,.06,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_attack_rate"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,10,10,.1,.06,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,10,10,.1,.06,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_dodge"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["default_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,11,11,10,.1,.08,.06,0,0,0,0,0,0,0,0,}
		
		valueWeights[dataIndex["grow_hp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_mp"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_attack_rate"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_low"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_high"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_dodge"]] ={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_defense"]] ={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_silence"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		
---飞剑	通用
	elseif ZLuaTalGetTalTypeFromID(tmplID) == "feijian"
			or ZLuaTalGetTalTypeFromID(tmplID) == "yushou"
			or ZLuaTalGetTalTypeFromID(tmplID) == "chibang"
			then
		
		valueWeights[dataIndex["default_hp"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_mp"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_attack_rate"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_low"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_high"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_dodge"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_defense"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_stun"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_sleep"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_silence"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_weakness"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_enlace"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		
		valueWeights[dataIndex["grow_hp"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_mp"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_attack_rate"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_low"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_high"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_dodge"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_defense"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_stun"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_sleep"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_silence"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_weakness"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_enlace"]] ={1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}

	---其他任何
	else
		
		valueWeights[dataIndex["default_hp"]] 						= {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_mp"]] 						= {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_attack_rate"]] 		= {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_low"]] 		= {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_damage_high"]] 		= {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_dodge"]] 					= {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_defense"]] 				= {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_stun"]] 		= {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_sleep"]] 		= {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_silence"]] 	= {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_weakness"]] = {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["default_resis_enlace"]] 	= {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		
		valueWeights[dataIndex["grow_hp"]]								={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_mp"]] 								={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_attack_rate"]] 			={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_low"]] 				={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_damage_high"]] 			={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_dodge"]] 						={5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_defense"]] 					={1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,}
		valueWeights[dataIndex["grow_resis_stun"]] 				={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_sleep"]] 			={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_silence"]] 		={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_weakness"]] 		={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
		valueWeights[dataIndex["grow_resis_enlace"]] 			={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,11,11,11,1,.1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}

	end
	
	---设置法宝精力值初始值与成长率系数
	for _,v in pairs(talismans) do
		if tmplID == v.tmplID then
			---飞宝
			if v.talType == "feijian" or v.talType == "yushou" or v.talType == "chibang" then
				valueWeights[dataIndex["default_stamina"]] 				= {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
				valueWeights[dataIndex["quo_stamina"]] 						= {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
			---任务给的新手法宝
			elseif origin == talismanOrigin["quest"] and v.requireLevel == 1 then
				valueWeights[dataIndex["default_stamina"]] 				= {0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
				valueWeights[dataIndex["quo_stamina"]] 						= {0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
			---任务给的15级门派法宝
			elseif origin == talismanOrigin["quest"] and v.requireLevel == 15 and v.school ~= 0 then
				valueWeights[dataIndex["default_stamina"]] 				= {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
				valueWeights[dataIndex["quo_stamina"]] 						= {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
			---新手法宝
			elseif v.requireLevel == 1 then
				valueWeights[dataIndex["default_stamina"]] 				= {10,10,10,10,10,10,10,10,10,10,5,5,5,5,5,5,5,5,5,5,1,1,1,1,1,1,1,1,1,1,.1,.1,.1,.1,.1,.1,.1,.1,.1,.1,.02,.02,.02,.02,.02,.02,.02,.02,.02,.02,}
				valueWeights[dataIndex["quo_stamina"]] 						= {10,10,10,10,10,10,10,10,10,10,5,5,5,5,5,5,5,5,5,5,1,1,1,1,1,1,1,1,1,1,.1,.1,.1,.1,.1,.1,.1,.1,.1,.1,.02,.02,.02,.02,.02,.02,.02,.02,.02,.02,}
			---15级门派法宝
			elseif v.requireLevel == 15 and v.school ~= 0 then
				valueWeights[dataIndex["default_stamina"]] 				= {5,5,5,5,5,5,5,5,5,5,10,10,10,10,10,10,10,10,10,10,5,5,5,5,5,5,5,5,5,5,1,1,1,1,1,1,1,1,1,1,.1,.1,.1,.1,.1,.1,.1,.1,.1,.1,}
				valueWeights[dataIndex["quo_stamina"]] 						= {5,5,5,5,5,5,5,5,5,5,10,10,10,10,10,10,10,10,10,10,5,5,5,5,5,5,5,5,5,5,1,1,1,1,1,1,1,1,1,1,.1,.1,.1,.1,.1,.1,.1,.1,.1,.1,}
			---75级门派法宝
			elseif v.requireLevel <= 75 and v.school ~= 0 then
				valueWeights[dataIndex["default_stamina"]] 				= {5,5,5,5,5,5,5,5,5,5,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,5,5,5,5,5,5,5,5,5,5,1,1,1,1,1,1,1,1,1,1,}
				valueWeights[dataIndex["quo_stamina"]] 						= {5,5,5,5,5,5,5,5,5,5,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,5,5,5,5,5,5,5,5,5,5,1,1,1,1,1,1,1,1,1,1,}
			---所有75级以上法宝  所有通用法宝
			elseif v.requireLevel > 75 or v.school == 0 then
				valueWeights[dataIndex["default_stamina"]] 				= {5,5,5,5,5,5,5,5,5,5,10,10,10,10,10,10,10,10,10,10,15,15,15,15,15,15,15,15,15,15,5,5,5,5,5,5,5,5,5,5,1,1,1,1,1,1,1,1,1,1,}
				valueWeights[dataIndex["quo_stamina"]] 						= {5,5,5,5,5,5,5,5,5,5,10,10,10,10,10,10,10,10,10,10,15,15,15,15,15,15,15,15,15,15,5,5,5,5,5,5,5,5,5,5,1,1,1,1,1,1,1,1,1,1,}
			else
				valueWeights[dataIndex["default_stamina"]] 				= {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
				valueWeights[dataIndex["quo_stamina"]] 						= {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,}
			end 
		end
	end
	---数据修改区 结束
	
	return valueWeights
end		



---取得某个等级法宝冲天龙魔血的花费 
function ZLuaTalFeedCost(level)
	if type(level) ~= "number" or level < 1 or level > 50 then return 0 end
	local currentExp = {
		   0,  350,  600,  860, 1130, 1420, 1720, 2030, 2350, 2690,
		3030, 3390, 3940, 4350, 4780, 5220, 5680, 6160, 6630, 7130,
		7660, 8190, 8750, 9330,	9920,10550,11240,11970,12840,13900,
	 17270,21740,25470,32340,50570,100000,200000,200000000,200000000,200000000,
	 200000000,200000000,200000000,200000000,200000000,200000000,200000000,200000000,200000000,200000000}

	local accumulateExp = 0
	for i = 1,math.floor(level) do
		accumulateExp = accumulateExp + currentExp[i]
	end
	---一个天龙魔血500点，1块钱
	return math.ceil(accumulateExp/500)
end

---	根据附加人物技能的附加属性取得未学会该技能的附加属性id
function ZLuaTalGetUnLearnID(id)
	if id == nil then return 0 end
	local transfer = {}
	transfer[337] = 1328
	transfer[338] = 1329
	transfer[339] = 1330
	transfer[340] = 1331
	transfer[341] = 1332
	transfer[342] = 1333
	transfer[343] = 1334
	transfer[344] = 1335
	transfer[345] = 1336
	transfer[346] = 1337
	transfer[347] = 1338
	transfer[348] = 1339
	transfer[349] = 1340
	transfer[350] = 1341
	transfer[351] = 1342
	transfer[352] = 1343
	transfer[353] = 1344
	transfer[354] = 1345
	transfer[355] = 1346
	transfer[356] = 1347
	transfer[357] = 1348
	transfer[358] = 1349
	transfer[359] = 1350
	transfer[360] = 1351
	transfer[361] = 1352
	transfer[362] = 1353
	transfer[363] = 1354
	transfer[364] = 1355
	transfer[365] = 1356
	transfer[366] = 1357
	transfer[367] = 1358
	transfer[368] = 1359
	transfer[369] = 1360
	transfer[370] = 1361
	transfer[371] = 1362
	transfer[372] = 1363
	transfer[373] = 1364
	transfer[374] = 1365
	transfer[375] = 1366
	transfer[376] = 1367
	transfer[377] = 1368
	transfer[378] = 1369
	transfer[379] = 1370
	transfer[380] = 1371
	transfer[381] = 1372
	transfer[382] = 1373
	transfer[383] = 1374
	transfer[384] = 1375
	transfer[385] = 1376
	transfer[386] = 1377
	transfer[387] = 1378
	transfer[388] = 1379
	transfer[389] = 1380
	transfer[390] = 1381
	transfer[391] = 1382
	transfer[392] = 1383
	transfer[393] = 1384
	transfer[394] = 1385
	transfer[395] = 1386
	transfer[396] = 1387
	transfer[397] = 1388
	transfer[398] = 1389
	transfer[872] = 1390
	transfer[873] = 1391
	transfer[874] = 1392
	transfer[875] = 1393
	transfer[876] = 1394
	transfer[877] = 1395
	transfer[878] = 1396
	transfer[879] = 1397
	transfer[880] = 1398
	transfer[881] = 1399
	transfer[882] = 1400
	transfer[883] = 1401
	transfer[884] = 1402
	transfer[885] = 1403
	transfer[886] = 1404
	transfer[887] = 1405
	transfer[888] = 1406
	transfer[889] = 1407
	transfer[890] = 1408
	transfer[891] = 1409
	transfer[892] = 1410
	transfer[893] = 1411
	transfer[894] = 1412
	transfer[895] = 1413
	transfer[896] = 1414
	transfer[897] = 1415
	transfer[898] = 1416
	transfer[899] = 1417
	transfer[900] = 1418
	transfer[901] = 1419
	transfer[902] = 1420
	transfer[903] = 1421
	transfer[904] = 1422
	transfer[905] = 1423
	transfer[906] = 1424
	transfer[907] = 1425
	transfer[1758] = 1782
	transfer[1759] = 1783
	transfer[1760] = 1784
	transfer[1761] = 1785
	transfer[1762] = 1786
	transfer[1763] = 1787
	transfer[1764] = 1788
	transfer[1765] = 1789
	transfer[1766] = 1790
	transfer[1767] = 1791
	transfer[1768] = 1792
	transfer[1769] = 1793
	transfer[1770] = 1794
	transfer[1771] = 1795
	transfer[1772] = 1796
	transfer[1773] = 1797
	transfer[1774] = 1798
	transfer[1775] = 1799
	transfer[1776] = 1800
	transfer[1777] = 1801
	transfer[1778] = 1802
	transfer[1779] = 1803
	transfer[1780] = 1804
	transfer[1781] = 1805
	transfer[3510] = 3558
	transfer[3511] = 3559
	transfer[3512] = 3560
	transfer[3513] = 3561
	transfer[3514] = 3562
	transfer[3515] = 3563
	transfer[3516] = 3564
	transfer[3517] = 3565
	transfer[3518] = 3566
	transfer[3519] = 3567
	transfer[3520] = 3568
	transfer[3521] = 3569
	transfer[3522] = 3570
	transfer[3523] = 3571
	transfer[3524] = 3572
	transfer[3525] = 3573
	transfer[3526] = 3574
	transfer[3527] = 3575
	transfer[3528] = 3576
	transfer[3529] = 3577
	transfer[3530] = 3578
	transfer[3531] = 3579
	transfer[3532] = 3580
	transfer[3533] = 3581
	transfer[3534] = 3582
	transfer[3535] = 3583
	transfer[3536] = 3584
	transfer[3537] = 3585
	transfer[3538] = 3586
	transfer[3539] = 3587
	transfer[3540] = 3588
	transfer[3541] = 3589
	transfer[3542] = 3590
	transfer[3543] = 3591
	transfer[3544] = 3592
	transfer[3545] = 3593
	transfer[3546] = 3594
	transfer[3547] = 3595
	transfer[3548] = 3596
	transfer[3549] = 3597
	transfer[3550] = 3598
	transfer[3551] = 3599
	transfer[3552] = 3600
	transfer[3553] = 3601
	transfer[3554] = 3602
	transfer[3555] = 3603
	transfer[3556] = 3604
	transfer[3557] = 3605
	transfer[3972] = 4020
	transfer[3973] = 4021
	transfer[3974] = 4022
	transfer[3975] = 4023
	transfer[3976] = 4024
	transfer[3977] = 4025
	transfer[3978] = 4026
	transfer[3979] = 4027
	transfer[3980] = 4028
	transfer[3981] = 4029
	transfer[3982] = 4030
	transfer[3983] = 4031
	transfer[3984] = 4032
	transfer[3985] = 4033
	transfer[3986] = 4034
	transfer[3987] = 4035
	transfer[3988] = 4036
	transfer[3989] = 4037
	transfer[3990] = 4038
	transfer[3991] = 4039
	transfer[3992] = 4040
	transfer[3993] = 4041
	transfer[3994] = 4042
	transfer[3995] = 4043
	transfer[3996] = 4044
	transfer[3997] = 4045
	transfer[3998] = 4046
	transfer[3999] = 4047
	transfer[4000] = 4048
	transfer[4001] = 4049
	transfer[4002] = 4050
	transfer[4003] = 4051
	transfer[4004] = 4052
	transfer[4005] = 4053
	transfer[4006] = 4054
	transfer[4007] = 4055
	transfer[4008] = 4056
	transfer[4009] = 4057
	transfer[4010] = 4058
	transfer[4011] = 4059
	transfer[4012] = 4060
	transfer[4013] = 4061
	transfer[4014] = 4062
	transfer[4015] = 4063
	transfer[4016] = 4064
	transfer[4017] = 4065
	transfer[4018] = 4066
	transfer[4019] = 4067	
	transfer[33387] = 33435
	transfer[33388] = 33436
	transfer[33389] = 33437
	transfer[33390] = 33438
	transfer[33391] = 33439
	transfer[33392] = 33440
	transfer[33393] = 33441
	transfer[33394] = 33442
	transfer[33395] = 33443
	transfer[33396] = 33444
	transfer[33397] = 33445
	transfer[33398] = 33446
	transfer[33399] = 33447
	transfer[33400] = 33448
	transfer[33401] = 33449
	transfer[33402] = 33450
	transfer[33403] = 33451
	transfer[33404] = 33452
	transfer[33405] = 33453
	transfer[33406] = 33454
	transfer[33407] = 33455
	transfer[33408] = 33456
	transfer[33409] = 33457
	transfer[33410] = 33458
	transfer[33411] = 33459
	transfer[33412] = 33460
	transfer[33413] = 33461
	transfer[33414] = 33462
	transfer[33415] = 33463
	transfer[33416] = 33464
	transfer[33417] = 33465
	transfer[33418] = 33466
	transfer[33419] = 33467
	transfer[33420] = 33468
	transfer[33421] = 33469
	transfer[33422] = 33470
	transfer[33423] = 33471
	transfer[33424] = 33472
	transfer[33425] = 33473
	transfer[33426] = 33474
	transfer[33427] = 33475
	transfer[33428] = 33476
	transfer[33429] = 33477
	transfer[33430] = 33478
	transfer[33431] = 33479
	transfer[33432] = 33480
	transfer[33433] = 33481
	transfer[33434] = 33482

  transfer[34035] = 34059
  transfer[34036]	= 34060
  transfer[34037]	= 34061
  transfer[34038]	= 34062
  transfer[34039]	= 34063
  transfer[34040]	= 34064
  transfer[34041]	= 34065
  transfer[34042]	= 34066
  transfer[34043]	= 34067
  transfer[34044]	= 34068
  transfer[34045]	= 34069
  transfer[34046]	= 34070
  transfer[34047]	= 34071
  transfer[34048]	= 34072
  transfer[34049]	= 34073
  transfer[34050]	= 34074
  transfer[34051]	= 34075
  transfer[34052]	= 34076
  transfer[34053]	= 34077
  transfer[34054]	= 34078
  transfer[34055]	= 34079
  transfer[34056]	= 34080
  transfer[34057]	= 34081
  transfer[34058]	= 34082

  transfer[34707] = 34755
  transfer[34708]	= 34756
  transfer[34709]	= 34757
  transfer[34710]	= 34758
  transfer[34711]	= 34759
  transfer[34712]	= 34760
  transfer[34713]	= 34761
  transfer[34714]	= 34762
  transfer[34715]	= 34763
  transfer[34716]	= 34764
  transfer[34717]	= 34765
  transfer[34718]	= 34766
  transfer[34719]	= 34767
  transfer[34720]	= 34768
  transfer[34721]	= 34769
  transfer[34722]	= 34770
  transfer[34723]	= 34771
  transfer[34724]	= 34772
  transfer[34725]	= 34773
  transfer[34726]	= 34774
  transfer[34727]	= 34775
  transfer[34728]	= 34776
  transfer[34729]	= 34777
  transfer[34730]	= 34778

  transfer[34731]	= 34779
  transfer[34732]	= 34780
  transfer[34733]	= 34781
  transfer[34734]	= 34782
  transfer[34735]	= 34783
  transfer[34736]	= 34784
  transfer[34737]	= 34785
  transfer[34738]	= 34786
  transfer[34739]	= 34787
  transfer[34740]	= 34788
  transfer[34741]	= 34789
  transfer[34742]	= 34790
  transfer[34743]	= 34791
  transfer[34744]	= 34792
  transfer[34745]	= 34793
  transfer[34746]	= 34794
  transfer[34747]	= 34795
  transfer[34748]	= 34796
  transfer[34749]	= 34797
  transfer[34750]	= 34798
  transfer[34751]	= 34799
  transfer[34752]	= 34800
  transfer[34753]	= 34801
  transfer[34754] = 34802

	return transfer[id]

end



-------索引定义与转换------------------------------------------------------------------------------------------------

---法宝data索引数组
function ZLuaTalDataIndex()
	local dataIndex = {}
	dataIndex["reserve1"]							 = 0
	dataIndex["reserve2"]							 = 1
	dataIndex["tmpl_id"] 	             = 2
	dataIndex["skill_addon_id"]        = 3
	dataIndex["default_stamina"]       = 4
	dataIndex["quo_stamina"]           = 5
	dataIndex["default_hp"]            = 6
	dataIndex["default_mp"]            = 7
	dataIndex["default_attack_rate"]   = 8
	dataIndex["default_damage_low"]    = 9
	dataIndex["default_damage_high"]   = 10
	dataIndex["default_dodge"]         = 11
	dataIndex["default_defense"]       = 12
	dataIndex["default_resis_stun"]    = 13
	dataIndex["default_resis_sleep"]   = 14
	dataIndex["default_resis_silence"] = 15
	dataIndex["default_resis_weakness"]= 16
	dataIndex["default_resis_enlace"]  = 17
	dataIndex["grow_hp"]               = 18
	dataIndex["grow_mp"]               = 19
	dataIndex["grow_attack_rate"]      = 20
	dataIndex["grow_damage_low"]       = 21
	dataIndex["grow_damage_high"]      = 22
	dataIndex["grow_dodge"]            = 23
	dataIndex["grow_defense"]          = 24
	dataIndex["grow_resis_stun"]       = 25
	dataIndex["grow_resis_sleep"]      = 26
	dataIndex["grow_resis_silence"]    = 27
	dataIndex["grow_resis_weakness"]   = 28
	dataIndex["grow_resis_enlace"]     = 29
	dataIndex["addon_1_learn_level"]   = 30
	dataIndex["addon_1_id"]            = 31
	dataIndex["addon_2_learn_level"]   = 32
	dataIndex["addon_2_id"]            = 33
	dataIndex["addon_3_learn_level"]   = 34
	dataIndex["addon_3_id"]            = 35
	dataIndex["addon_4_learn_level"]   = 36
	dataIndex["addon_4_id"]            = 37
	dataIndex["addon_5_learn_level"]   = 38
	dataIndex["addon_5_id"]            = 39 
	dataIndex["addon_6_learn_level"]   = 40
	dataIndex["addon_6_id"]            = 41
	dataIndex["addon_7_learn_level"]   = 42
	dataIndex["addon_7_id"]            = 43
	dataIndex["addon_8_learn_level"]   = 44
	dataIndex["addon_8_id"]            = 45
	dataIndex["addon_9_learn_level"]   = 46
	dataIndex["addon_9_id"]            = 47
	dataIndex["addon_10_learn_level"]  = 48
	dataIndex["addon_10_id"]           = 49
	dataIndex["addon_11_learn_level"]  = 50
	dataIndex["addon_11_id"]           = 51
	dataIndex["artpath_1_level"]       = 52
	dataIndex["artpath_2_level"]       = 53
	dataIndex["artpath_3_level"]       = 54
	dataIndex["artpath_4_level"]       = 55
	dataIndex["confusion_1_level"]		 = 56
	dataIndex["confusion_1_quo"]			 = 57
	dataIndex["confusion_2_level"]		 = 58
	dataIndex["confusion_2_quo"]			 = 59
	dataIndex["confusion_3_level"]		 = 60
	dataIndex["confusion_3_quo"]			 = 61
	dataIndex["confusion_4_level"]		 = 62
	dataIndex["confusion_4_quo"]			 = 63
	dataIndex["confusion_5_level"]		 = 64
	dataIndex["confusion_5_quo"]			 = 65
	dataIndex["origin"]								 = 66
	dataIndex["birth_hour12"]					 = 67
	dataIndex["birth_min3"]						 = 68
	dataIndex["quality"]							 = 69
	dataIndex["speciality"]						 = 70
	dataIndex["buff_type"]						 = 71
	dataIndex["ext_id"]								 = 72
	dataIndex["skill_visible"]				 = 73
	dataIndex["combine_times"]				 = 74
	dataIndex["enchant_times"]				 = 75
	dataIndex["feed_baoqi"]						 = 76
	dataIndex["feed_xianpin"]					 = 77
	dataIndex["feed_shenpin"]					 = 78
	dataIndex["feed_cost"]						 = 79
	dataIndex["change_skillnum"]			 = 80
	dataIndex["feed_level_cost"]			 = 81
	dataIndex["is_fly"]			           = 82
	dataIndex["hp_rise"]			         = 83
	dataIndex["mp_rise"]			         = 84
	dataIndex["minattack_rise"]			   = 85
	dataIndex["maxattack_rise"]			   = 86
	dataIndex["stun_rise"]			       = 87
	dataIndex["weakness_rise"]			   = 88
	dataIndex["enlace_rise"]			     = 89
	dataIndex["silence_rise"]			     = 90
	dataIndex["sleep_rise"]			       = 91
	dataIndex["all_rise"]			         = 92
	dataIndex["hp_enhance"]						 = 93
	dataIndex["mp_enhance"]						 = 94
	dataIndex["atk_enhance"]					 = 95
	dataIndex["skillrefine_level"]		 = 96
	dataIndex["skillrefine_0"]				 = 97
	dataIndex["skillrefine_1"]				 = 98
	dataIndex["skillrefine_2"]				 = 99
	dataIndex["skillrefine_3"]				 = 100
	dataIndex["skillrefine_4"]				 = 101
	dataIndex["skillrefine_5"]				 = 102
	dataIndex["skillrefine_6"]				 = 103
	dataIndex["skillrefine_7"]				 = 104
	dataIndex["skillrefine_8"]				 = 105
	dataIndex["skillrefinetmp_1"]				 = 106
	dataIndex["skillrefinetmp_2"]				 = 107
	dataIndex["skillrefinetmp_3"]				 = 108
	dataIndex["skillrefinetmp_4"]				 = 109
	dataIndex["skillrefinetmp_5"]				 = 110
	dataIndex["skillrefinetmp_6"]				 = 111
	dataIndex["skillrefinetmp_7"]				 = 112
	dataIndex["skillrefinetmp_8"]				 = 113
	dataIndex["newaddon_id_1"]				 = 114
	dataIndex["newaddon_id_2"]				 = 115
	dataIndex["newaddon_id_3"]				 = 116
	dataIndex["newaddon_id_4"]				 = 117
	dataIndex["newaddon_id_5"]				 = 118
	dataIndex["reborncont"]						 = 119
	dataIndex["skillrefinecont"]			 = 120
	
	local resisIndex = {}
	resisIndex["resis_stun"]     = 0
	resisIndex["resis_weakness"] = 1
	resisIndex["resis_enlace"]   = 2
	resisIndex["resis_silence"]  = 3
	resisIndex["resis_sleep"]    = 4

	-- data2Index中存的是dataIndex里需要客户端知道的参数(弃用!!!)
	local data2Index = {}
	data2Index["hp_enhance"]		= 0
	data2Index["mp_enhance"]		= 1
	data2Index["atk_enhance"]		= 2

	return dataIndex, resisIndex, data2Index
end


---gradesUpperLimit表的索引，跟随ZLuaTalGradesUpperLimit的定义中的表中顺序而改变
---同时与客户端悬浮界面显示的规则也应用此规则
function ZLuaTalGradeIndex()
	local gradesIndex = {}
	gradesIndex["null"] 					= 0
	gradesIndex["all"] 						= 1
	gradesIndex["damage_low"] 		= 2
	gradesIndex["damage_high"] 		= 3
	gradesIndex["hp"] 						= 4
	gradesIndex["mp"] 						= 5
	gradesIndex["attack_rate"] 		 = 6
	gradesIndex["dodge"] 					 = 7
	gradesIndex["resis_stun"] 		 = 8
	gradesIndex["resis_weakness"]  = 9
	gradesIndex["resis_enlace"] 	 = 10
	gradesIndex["resis_silence"] 	= 11
	gradesIndex["resis_sleep"] 		= 12
	gradesIndex["defense"]				= 13

	return gradesIndex
end


---把dataindex的索引转变为gradesindex的索引
function ZLuaTalTransIndex(index18)
	local dataIndex = ZLuaTalDataIndex()
	local gradesIndex = ZLuaTalGradeIndex()
	if index18 == dataIndex["grow_hp"] then return gradesIndex["hp"] end
	if index18 == dataIndex["grow_mp"] then return gradesIndex["mp"] end
	if index18 == dataIndex["grow_damage_low"] then return gradesIndex["damage_low"] end
	if index18 == dataIndex["grow_damage_high"] then return gradesIndex["damage_high"] end
	if index18 == dataIndex["grow_resis_stun"] then return gradesIndex["resis_stun"] end
	if index18 == dataIndex["grow_resis_sleep"] then return gradesIndex["resis_sleep"] end
	if index18 == dataIndex["grow_resis_silence"] then return gradesIndex["resis_silence"] end
	if index18 == dataIndex["grow_resis_weakness"] then return gradesIndex["resis_weakness"] end
	if index18 == dataIndex["grow_resis_enlace"] then return gradesIndex["resis_enlace"] end
	return 0
end


---定义法宝来源（服务器约定）。定义跟随程序约定而改变。
function ZLuaTalServerOrigins()
	local serverOrigins = {}
	serverOrigins["null"] = -1
	serverOrigins["quest"] = 0
	serverOrigins["shop"] = 1
	serverOrigins["npc"] = 2	
	serverOrigins["lottery"] = 3
	serverOrigins["combine"] = 5	---这个不是与程序约定的。用于让talisman_combine.lua告知talisman.lua该法宝是血炼的
	return serverOrigins
end

---定义法宝来源（客户端约定）
function ZLuaTalClientOrigins()
	local clientOrigins = {}
	clientOrigins["quest"] = 0
	clientOrigins["shop"] = 1
	clientOrigins["npc"] = 2
	clientOrigins["combine"] = 3
	clientOrigins["lottery"] = 4
	clientOrigins["unknown"] = 5
	return clientOrigins
end	


---取得法宝来源，用于客户端显示
function ZLuaTalGenerateClientOrigin(serverOrigin)
	---客户端显示规则
	---0 任务
	---1 宝库
	---2 交易
	---3 血炼
	---4 彩票
	---5 未知
	local serverOrigins = ZLuaTalServerOrigins()
	local clientOrigins = ZLuaTalClientOrigins()
	local clientOrigin
	if serverOrigin == serverOrigins["quest"] then
		clientOrigin = clientOrigins["quest"]
	elseif serverOrigin == serverOrigins["shop"] then
		clientOrigin = clientOrigins["shop"]
	elseif serverOrigin == serverOrigins["npc"] then
		clientOrigin = clientOrigins["npc"]
	elseif serverOrigin == serverOrigins["combine"] then
		clientOrigin = clientOrigins["combine"]
	elseif serverOrigin == serverOrigins["lottery"] then
		clientOrigin = clientOrigins["shop"]
	else
		clientOrigin = clientOrigins["unknown"]
	end	
	return clientOrigin
end

---还原法宝来源，用于服务器端判断
function ZLuaTalGenerateServerOrigin(clientOrigin)
	local serverOrigins = ZLuaTalServerOrigins()
	local clientOrigins = ZLuaTalClientOrigins()
	local serverOrigin
	if clientOrigin == clientOrigins["quest"] then
		serverOrigin = serverOrigins["quest"]
	elseif clientOrigin == clientOrigins["shop"] then
		serverOrigin = serverOrigins["shop"]
	elseif clientOrigin == clientOrigins["npc"] then
		serverOrigin = serverOrigins["npc"]
	elseif clientOrigin == clientOrigins["combine"] then
		serverOrigin = serverOrigins["combine"]
	else
		serverOrigin = serverOrigins["null"]
	end
end


-------生成属性------------------------------------------------------------------------------------------------------

---法宝干扰系数
function ZLuaTalGenerateConfusion( tmplID, origin )
	local talismans = ZLuaTalAvailableTalismans()
	local origins = ZLuaTalServerOrigins()
	local confusion = {}
	local i
	for i=1,5 do
		confusion[i] = { quo = 1, level = 1 }
	end
	---取得一些常量
	local dataIndex,resisIndex = ZLuaTalDataIndex()
	---干扰系数上下限
	local low = 0.35
	local high = 1.65
	---被干扰的等级
	local bound = {}
	bound[1] = { down = 2, up = 2 }
	bound[2] = { down = 3, up = 4 }
	bound[3] = { down = 5, up = 10 }
	bound[4] = { down = 11, up = 20 }
	bound[5] = { down = 21, up = 30 }

	---生成干扰系数
	for i=1,5 do
		---如果是任务给的法宝，就不设干扰系数
		if ( tmplID == talismans["NW_1_BaGuaShi"].tmplID
		or tmplID == talismans["GW_15_ZhuQueYin"].tmplID
		or tmplID == talismans["HH_15_SheXinLing"].tmplID
		or tmplID == talismans["QY_15_LiuHeJing"].tmplID
		or tmplID == talismans["GD_15_XueYuGuPian"].tmplID
		or tmplID == talismans["FX_15_NanMingYin"].tmplID
		or tmplID == talismans["TY_15_LunHuiZhu"].tmplID
		or tmplID == talismans["SY_1_WuSeShi"].tmplID
		or tmplID == talismans["JL_15_NuShouFan"].tmplID
		or tmplID == talismans["LS_15_DanZhu"].tmplID
		or tmplID == talismans["HG_15_QiSha"].tmplID
		or tmplID == talismans["TH_15_JiuYinLuo"].tmplID
		or tmplID == talismans["TH_15_LeiGongMo"].tmplID
		or tmplID == talismans["CH_15_lvdouqi"].tmplID 
		or tmplID == talismans["LZ_1_TianLingShi"].tmplID
		or tmplID == talismans["QJ_15_tianjimu"].tmplID		
		or tmplID == talismans["YZ_15_lveying"].tmplID
		)and origin == origins["quest"] then
			confusion[i].quo = 1
			confusion[i].level = i

		elseif ZLuaTalGetTalTypeFromID(tmplID) == "feijian"
				or ZLuaTalGetTalTypeFromID(tmplID) == "yushou"
				or ZLuaTalGetTalTypeFromID(tmplID) == "chibang"
		then
			confusion[i].quo = 1
			confusion[i].level = i

		else
			confusion[i].quo = math.random() * ( high - low ) + low
			confusion[i].level = math.floor( math.random() * ( bound[i].up + 1 - bound[i].down ) + bound[i].down )
		end
	end

	return confusion
end	
	
---生成特性
function ZLuaTalGenerateSpeciality(tmplID,origin,quality,allGrades)
	local dataIndex = ZLuaTalDataIndex()
	local gradeIndex = ZLuaTalGradeIndex()
	local origins = ZLuaTalServerOrigins()
	local talismans = ZLuaTalAvailableTalismans()
	local gradesUpperLimit = ZLuaTalGradesUpperLimit(tmplID)
	
	local generate = false
	
	---购买的八卦石五色石有概率有特性
	if (tmplID == talismans["NW_1_BaGuaShi"].tmplID or tmplID == talismans["SY_1_WuSeShi"].tmplID or tmplID == talismans["LZ_1_TianLingShi"].tmplID) and origin == origins["npc"] then
		if math.random() < 0.4 then
			generate = true
		end
	---彩票的八卦石五色石必然有特性
	elseif (tmplID == talismans["NW_1_BaGuaShi"].tmplID or tmplID == talismans["SY_1_WuSeShi"].tmplID or tmplID == talismans["LZ_1_TianLingShi"].tmplID) and origin == origins["lottery"] then
		generate = true
	end

	---如果随到了“生成”，就生成，生成的代码
	if generate then
		---从所有档位中取出有用的
		local grades = {}
		grades[dataIndex["grow_hp"]]							= allGrades[dataIndex["grow_hp"]]
		grades[dataIndex["grow_mp"]]							= allGrades[dataIndex["grow_mp"]]
		grades[dataIndex["grow_damage_low"]]			= allGrades[dataIndex["grow_damage_low"]]
		grades[dataIndex["grow_damage_high"]]			= allGrades[dataIndex["grow_damage_high"]]
		grades[dataIndex["grow_resis_stun"]]			= allGrades[dataIndex["grow_resis_stun"]]
		grades[dataIndex["grow_resis_sleep"]]			= allGrades[dataIndex["grow_resis_sleep"]]
		grades[dataIndex["grow_resis_silence"]]		= allGrades[dataIndex["grow_resis_silence"]]
		grades[dataIndex["grow_resis_weakness"]]	= allGrades[dataIndex["grow_resis_weakness"]]
		grades[dataIndex["grow_resis_enlace"]]		= allGrades[dataIndex["grow_resis_enlace"]]

		---去掉2个相对最高档位的属性，在剩下的里面随
		---取得相对最高档位的属性
		local relativeMaxGradeDIdx = dataIndex["grow_damage_high"]
		local relativeMaxGradeGIdx = ZLuaTalTransIndex(relativeMaxGradeDIdx)
		for dataIdx,grade in pairs(grades) do
			local gradeIdx = ZLuaTalTransIndex(dataIdx)
			if grade/gradesUpperLimit[gradeIdx] > grades[relativeMaxGradeDIdx]/gradesUpperLimit[relativeMaxGradeGIdx] then
				relativeMaxGradeDIdx = dataIdx
				relativeMaxGradeGIdx = ZLuaTalTransIndex(relativeMaxGradeDIdx)
			end
		end
		---取得相对次高档位的属性
		local relativeMax2GradeDIdx
		if relativeMaxGradeDIdx == dataIndex["grow_damage_high"] then 
			relativeMax2GradeDIdx = dataIndex["grow_hp"]
		else
			relativeMax2GradeDIdx = dataIndex["grow_damage_high"]
		end
		local relativeMax2GradeGIdx = ZLuaTalTransIndex(relativeMax2GradeDIdx)
		for dataIdx,grade in pairs(grades) do
			local gradeIdx = ZLuaTalTransIndex(dataIdx)
			if grade/gradesUpperLimit[gradeIdx] > grades[relativeMax2GradeDIdx]/gradesUpperLimit[relativeMax2GradeGIdx] and grade ~= maxGradeIndex then 
				relativeMax2GradeDIdx = dataIdx
				relativeMax2GradeGIdx = ZLuaTalTransIndex(relativeMax2GradeDIdx)
			end
		end
		---在剩下里面随机		
		local randomSpace = {}
		for index,grade in pairs(grades) do
			if index ~= maxGradeIndex and index ~= max2GradeIndex then 
				table.insert(randomSpace,index) 
			end
		end
		local res = math.floor(math.random()*table.getn(randomSpace)) + 1
		---把生成的data索引的成长方向翻译为grade索引的成长方向，返回
		return randomSpace[res]
	---如果没随到“生成”，就返回0，表示无特性
	else
		return 0
	end	
end


---取得法宝生成时间
function ZLuaTalGenerteBirthTime()
	local birthday = os.date("*t")
	local t = birthday.hour + birthday.min / 60 + birthday.sec / 3600	---当天真实时间的小时数（浮点），0～23.99999
	local hoursOneDayInGame = 4
	local gameTime = math.fmod(t,hoursOneDayInGame) / hoursOneDayInGame * 24	---游戏时间的小时数（浮点），0～23.9999
	local gameHour12 = math.fmod( math.floor( ( gameTime + 1 ) / 2 ), 12 )
	local gameMin3 = math.floor( math.fmod( gameTime + 1 , 2 ) / 2 * 4 )
	return gameHour12, gameMin3
end

---取得法宝品阶
function ZLuaTalGenerateQuality(tmplID, origin, grades, nGrades)
	local dataIndex = ZLuaTalDataIndex()
	local origins = ZLuaTalServerOrigins()
	local talismans = ZLuaTalAvailableTalismans()

	local sum
	sum=0
	
	sum = sum + grades[dataIndex["default_hp"]]
	sum = sum + grades[dataIndex["default_mp"]]
	sum = sum + grades[dataIndex["default_damage_low"]]
	sum = sum + grades[dataIndex["default_damage_high"]]
	sum = sum + grades[dataIndex["default_resis_stun"]]
	sum = sum + grades[dataIndex["default_resis_sleep"]]
	sum = sum + grades[dataIndex["default_resis_silence"]]
	sum = sum + grades[dataIndex["default_resis_weakness"]]
	sum = sum + grades[dataIndex["default_resis_enlace"]]

	sum = sum + grades[dataIndex["grow_hp"]] * 10
	sum = sum + grades[dataIndex["grow_mp"]] * 4
	sum = sum + grades[dataIndex["grow_damage_low"]] * 3
	sum = sum + grades[dataIndex["grow_damage_high"]] * 10
	sum = sum + grades[dataIndex["grow_resis_stun"]] * 4
	sum = sum + grades[dataIndex["grow_resis_sleep"]] * 4
	sum = sum + grades[dataIndex["grow_resis_silence"]] * 4
	sum = sum + grades[dataIndex["grow_resis_weakness"]] * 4
	sum = sum + grades[dataIndex["grow_resis_enlace"]] * 4
	
	local g = math.floor( sum / ( nGrades * 56 ) * 1000 )

	local l1,l2
	if tmplID == talismans["NW_1_BaGuaShi"].tmplID or tmplID == talismans["SY_1_WuSeShi"].tmplID or tmplID == talismans["LZ_1_TianLingShi"].tmplID then
		l1 = 140
		l2 = 160
	elseif ZLuaTalGetTalTypeFromID(tmplID) == "feijian"
			or ZLuaTalGetTalTypeFromID(tmplID) == "yushou"
			or ZLuaTalGetTalTypeFromID(tmplID) == "chibang"
			then
		l1 = 700
		l2 = 800
	elseif (tmplID == talismans["GW_15_ZhuQueYin"].tmplID or tmplID == talismans["JL_15_NuShouFan"].tmplID or tmplID == talismans["QJ_15_tianjimu"].tmplID) and origin == origins["quest"] then
		l1 = 300
		l2 = 400
	elseif (tmplID == talismans["HH_15_SheXinLing"].tmplID or tmplID == talismans["HG_15_QiSha"].tmplID or tmplID == talismans["YZ_15_lveying"].tmplID) and origin == origins["quest"] then
		l1 = 200
		l2 = 400
	elseif (tmplID == talismans["QY_15_LiuHeJing"].tmplID or tmplID == talismans["TH_15_JiuYinLuo"].tmplID) and origin == origins["quest"] then
		l1 = 300
		l2 = 400
	elseif (tmplID == talismans["TY_15_LunHuiZhu"].tmplID or tmplID == talismans["LS_15_DanZhu"].tmplID or tmplID == talismans["CH_15_lvdouqi"].tmplID) and origin == origins["quest"] then
		l1 = 300
		l2 = 400
	elseif (tmplID == talismans["GD_15_XueYuGuPian"].tmplID or tmplID == talismans["FX_15_NanMingYin"].tmplID or tmplID == talismans["TH_15_LeiGongMo"].tmplID) and origin == origins["quest"] then
		l1 = 300
		l2 = 400
	elseif tmplID == talismans["GW_15_ZhuQueYin"].tmplID or tmplID == talismans["JL_15_NuShouFan"].tmplID or tmplID == talismans["QJ_15_tianjimu"].tmplID then
		l1 = 267
		l2 = 294
	elseif tmplID == talismans["HH_15_SheXinLing"].tmplID or tmplID == talismans["HG_15_QiSha"].tmplID or tmplID == talismans["YZ_15_lveying"].tmplID then
		l1 = 264
		l2 = 283
	elseif tmplID == talismans["QY_15_LiuHeJing"].tmplID or tmplID == talismans["TH_15_JiuYinLuo"].tmplID then
		l1 = 252
		l2 = 271
	elseif tmplID == talismans["TY_15_LunHuiZhu"].tmplID or tmplID == talismans["LS_15_DanZhu"].tmplID or tmplID == talismans["CH_15_lvdouqi"].tmplID then
		l1 = 245
		l2 = 280
	elseif tmplID == talismans["GD_15_XueYuGuPian"].tmplID or tmplID == talismans["FX_15_NanMingYin"].tmplID or tmplID == talismans["TH_15_LeiGongMo"].tmplID then
		l1 = 245
		l2 = 280
	elseif tmplID == talismans["GW_75_SiLingFan"].tmplID or tmplID == talismans["JL_75_XueFengQiang"].tmplID or tmplID == talismans["QJ_75_luohouyu"].tmplID then
		l1 = 399
		l2 = 436
	elseif tmplID == talismans["HH_75_DuoQingHuan"].tmplID or tmplID == talismans["HG_75_PoJun"].tmplID or tmplID == talismans["YZ_75_poming"].tmplID then
		l1 = 407
		l2 = 435
	elseif tmplID == talismans["QY_75_QiXingJian"].tmplID or tmplID == talismans["TH_75_YaFeng"].tmplID then
		l1 = 385
		l2 = 415
	elseif tmplID == talismans["TY_75_JinGangChu"].tmplID or tmplID == talismans["LS_75_FanHunXiang"].tmplID or tmplID == talismans["CH_75_tuogu"].tmplID then
		l1 = 383
		l2 = 413
	elseif tmplID == talismans["GD_75_PoSha"].tmplID or tmplID == talismans["FX_75_HengTianChi"].tmplID or tmplID == talismans["TH_75_ChunQiuSuo"].tmplID then
		l1 = 383
		l2 = 413
	elseif tmplID == talismans["US_45_ShenMuShai"].tmplID
			or tmplID == talismans["US_45_ShenMuShai_WZGL"].tmplID
			or tmplID == talismans["US_45_YuanXiaoDeng"].tmplID then
		l1 = 300
		l2 = 374
	elseif tmplID == talismans["US_75_ShanHeShan"].tmplID
	or tmplID == talismans["US_75_WanDuDing"].tmplID
	or tmplID == talismans["US_75_YuJingPing"].tmplID then
		l1 = 317
		l2 = 348
	elseif tmplID == talismans["US_75_LingLongTa"].tmplID then
		l1 = 310
		l2 = 410
	elseif tmplID == talismans["GW_105_QianKunQingGuangJie"].tmplID or tmplID == talismans["JL_105_GangLan"].tmplID then
		l1 = 555
		l2 = 575
	elseif tmplID == talismans["HH_105_QianMeiLian"].tmplID or tmplID == talismans["HG_105_TanLang"].tmplID then
		l1 = 570
		l2 = 590
	elseif tmplID == talismans["QY_105_HuPoZhuLing"].tmplID or tmplID == talismans["TH_105_LiuLiZhan"].tmplID then
		l1 = 550
		l2 = 570
	elseif tmplID == talismans["TY_105_RuYiQianKunDai"].tmplID or tmplID == talismans["LS_105_FuYingGuJing"].tmplID or tmplID == talismans["CH_105_luobaojinqian"].tmplID or tmplID == talismans["QJ_105_jinyubian"].tmplID or tmplID == talismans["YZ_105_shuolei"].tmplID then
		l1 = 528
		l2 = 548
	elseif tmplID == talismans["GD_105_QianDuGu"].tmplID or tmplID == talismans["FX_105_HuoLingLong"].tmplID or tmplID == talismans["TH_105_ZiMuYinYangKou"].tmplID then
		l1 = 528
		l2 = 548
	elseif tmplID == talismans["US_105_JiuLongShenHuoZhao"].tmplID then
		l1 = 533
		l2 = 550
	elseif tmplID == talismans["US_105_JinHuLu"].tmplID then
		l1 = 552
		l2 = 600
	elseif tmplID == talismans["US_105_YinYangJing"].tmplID
			or tmplID == talismans["US_105_YinYangJing_WZGL"].tmplID then
		l1 = 552
		l2 = 630
	elseif tmplID == talismans["US_105_ZhenShanHeShan"].tmplID then
		l1 = 552
		l2 = 630
	elseif tmplID == talismans["US_135_PanLongFan"].tmplID then
		l1 = 638
		l2 = 660
	elseif tmplID == talismans["GW_135_TianMoZhi"].tmplID
	or tmplID == talismans["QY_135_RuoXue"].tmplID
	or tmplID == talismans["HH_135_BaJiYouLong"].tmplID
	or tmplID == talismans["TY_135_LiuDaoShengMie"].tmplID 
	or tmplID == talismans["GD_135_GuiQing"].tmplID
	or tmplID == talismans["FX_135_JiuHanNingBingCi"].tmplID
	or tmplID == talismans["JL_135_SangMenJian"].tmplID
	or tmplID == talismans["LS_135_LuoShu"].tmplID
	or tmplID == talismans["HG_135_JueYing"].tmplID
	or tmplID == talismans["TH_135_BiLuoFeiHong"].tmplID
	or tmplID == talismans["TH_135_XiHuangZhong"].tmplID
	or tmplID == talismans["CH_135_huangji"].tmplID
	or tmplID == talismans["QJ_135_chixinglongyan"].tmplID
	or tmplID == talismans["YZ_135_zhuihun"].tmplID
	then
		l1 = 725
		l2 = 775
	elseif tmplID == talismans["US_135_SheHun"].tmplID
	or tmplID == talismans["US_145_ShiXueZhu"].tmplID
	or tmplID == talismans["US_145_ShiHun"].tmplID 
	or tmplID == talismans["US_145_TianYa"].tmplID then
		l1 = 725
		l2 = 775
	elseif tmplID == talismans["US_135_WuLongLun"].tmplID
	or tmplID == talismans["US_135_FanTianYin"].tmplID
	or tmplID == talismans["US_135_ChangMingDeng"].tmplID
	or tmplID == talismans["US_135_BaoKuZhiHun"].tmplID
	or tmplID == talismans["US_75_RiYueBaoJian"].tmplID
	or tmplID == talismans["US_105_FuTu"].tmplID
	or tmplID == talismans["US_135_YinHunFan"].tmplID then
		l1 = 300
		l2 = 775
	elseif tmplID == talismans["US_105_LuoHunDeng"].tmplID then
		l1 = 590
		l2 = 650
	elseif tmplID == talismans["foodtalisman"].tmplID then
		l1 = 1
		l2 = 3
	else
		l1 = 750
		l2 = 800
	end
	local quality
	if g <= l1 then quality = 0
	elseif l1 < g and g <= l2 then quality = 1
	else quality = 2 end
	return quality
end

---取得法宝品阶，从具体法宝
function ZLuaTalGenerateQualityFromTalisman(tmplID, talisman)
	local dataIndex = ZLuaTalDataIndex()
	local nGrades, valueGrades = ZLuaTalGrades()
	local grades = {}
	grades[dataIndex["default_hp"]] 						= ZLuaTalGetGradeFromValue(dataIndex["default_hp"],talisman)
	grades[dataIndex["default_mp"]] 						= ZLuaTalGetGradeFromValue(dataIndex["default_mp"],talisman)
	grades[dataIndex["default_damage_low"]] 		= ZLuaTalGetGradeFromValue(dataIndex["default_damage_low"],talisman)
	grades[dataIndex["default_damage_high"]] 		= ZLuaTalGetGradeFromValue(dataIndex["default_damage_high"],talisman)
	grades[dataIndex["default_resis_stun"]] 		= ZLuaTalGetGradeFromValue(dataIndex["default_resis_stun"],talisman)
	grades[dataIndex["default_resis_sleep"]] 		= ZLuaTalGetGradeFromValue(dataIndex["default_resis_sleep"],talisman)
	grades[dataIndex["default_resis_silence"]] 	= ZLuaTalGetGradeFromValue(dataIndex["default_resis_silence"],talisman)
	grades[dataIndex["default_resis_weakness"]] = ZLuaTalGetGradeFromValue(dataIndex["default_resis_weakness"],talisman)
	grades[dataIndex["default_resis_enlace"]] 	= ZLuaTalGetGradeFromValue(dataIndex["default_resis_enlace"],talisman)
		
	grades[dataIndex["grow_hp"]] 								= ZLuaTalGetGradeFromValue(dataIndex["grow_hp"],talisman)
	grades[dataIndex["grow_mp"]] 								= ZLuaTalGetGradeFromValue(dataIndex["grow_mp"],talisman)
	grades[dataIndex["grow_damage_low"]] 				= ZLuaTalGetGradeFromValue(dataIndex["grow_damage_low"],talisman)
	grades[dataIndex["grow_damage_high"]] 			= ZLuaTalGetGradeFromValue(dataIndex["grow_damage_high"],talisman)
	grades[dataIndex["grow_resis_stun"]] 				= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_stun"],talisman)
	grades[dataIndex["grow_resis_sleep"]] 			= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_sleep"],talisman)
	grades[dataIndex["grow_resis_silence"]] 		= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_silence"],talisman)
	grades[dataIndex["grow_resis_weakness"]] 		= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_weakness"],talisman)
	grades[dataIndex["grow_resis_enlace"]] 			= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_enlace"],talisman)

	local clientOrigin = talisman:QueryData(0,dataIndex["origin"])
	local serverOrigin = ZLuaTalGenerateServerOrigin(clientOrigin)
	return ZLuaTalGenerateQuality(tmplID, serverOrigin, grades, nGrades)
end

-------主要处理函数--------------------------------------------------------------------------------------------------

---法宝合成
function CombineTalismans(id1,id2, talisman1,talisman2,cid,output,locked1,locked2)
	-- 没注册过的法宝飞剑，禁止血炼
	local talismans = ZLuaTalAvailableTalismans()
	local Registed1 = false
	local Registed2 = false
	-- 75级和105级门派法宝用于神品血炼标识
	local RegistedMaxQuality = 0
	for _,v in pairs(talismans) do
		if v.tmplID == id1 then Registed1 = true	end
		if v.tmplID == id2 then Registed2 = true	end
		if v.tmplID == id1 and v.requireLevel == 75 and v.school ~= 0 then  RegistedMaxQuality = 1 end
		if v.tmplID == id1 and v.requireLevel == 105 and v.school ~= 0 then RegistedMaxQuality = 2 end
	end
	if Registed1 == false or Registed2 == false then
		output:CreateItem(-1)
		return
	end

	-- 如果有锁定的法宝，不许血炼
	if locked1 == true or locked2 == true then
		output:CreateItem(-1)
	elseif cid == 11784 or cid == 12021 then
		---11784是"显影剂"，用于把法宝的后台数据搬到前台
		---12021是"成长率显示剂"，用于把法宝每项属性的成长率档位数显示到相应属性上
		ZLuaTalDebugDisplay(talisman1,id1,cid,output)
	elseif cid == 22017 and id2 == 19523 then
		--使用灵媒之王和食物法宝，将法宝的主属性一次性喂满。
		ZLuaTalDebugMaxGrade(talisman1,id1,cid,output)
	elseif (cid == 50975 and ZLuaTalGenerateQualityFromTalisman(id1, talisman1) ~= 2 and RegistedMaxQuality == 1) or (cid == 50976 and ZLuaTalGenerateQualityFromTalisman(id1, talisman1) ~= 2 and RegistedMaxQuality == 2)
	 	---使用血炼品质灵媒和任意法宝，将门派75/105法宝血炼成神品
	then
		ZLuaTalMaxQuality(talisman1,id1,cid,output)
	else
		--正常血炼
		ZLuaTalisman_Combine(id1,id2, talisman1,talisman2,cid,output,locked1,locked2)
	end
end


---随机函数，返回指定法宝模板的每个属性随机后的结果
---会调用talisman_addon.lua里面的ZLuaTal_Get_RanPoint(array)函数
function ZLuaTalRandomResult(tmplID, origin)
	if ZLuaTalExistInTmplIDs(tmplID) == 0 then return nil end
	local talismans = ZLuaTalAvailableTalismans()
	---取得一些常量
	local dataIndex,resisIndex = ZLuaTalDataIndex()
	local origins = ZLuaTalServerOrigins()
	---取得法宝属性的档位
	local nGrades, valueGrades = ZLuaTalGrades()
	---取得此法宝的随机权重
	local valueWeights = ZLuaTalRandomWeight(tmplID, origin)
	if valueWeights == nil then return nil end

	local randomResult
	randomResult = {}
	
	---取得法宝技能的附加属性ID
	randomResult[dataIndex["skill_addon_id"]] = 399
	local tal
	for _,tal in pairs( ZLuaTalAvailableTalismans() ) do
		if tmplID == tal.tmplID then
			randomResult[dataIndex["skill_addon_id"]] = tal.skillAddon
			break
		end
	end

	---取得精力值、本体属性的初始值与成长率档位
	local grades
	grades = {}
	grades[dataIndex["default_stamina"]] 				= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["default_stamina"]])
	grades[dataIndex["quo_stamina"]] 						= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["quo_stamina"]])

	grades[dataIndex["default_hp"]] 						= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["default_hp"]])
	grades[dataIndex["default_mp"]] 						= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["default_mp"]])
	grades[dataIndex["default_attack_rate"]] 		= 1
	grades[dataIndex["default_damage_low"]] 		= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["default_damage_low"]])
	grades[dataIndex["default_damage_high"]] 		= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["default_damage_high"]])
	grades[dataIndex["default_dodge"]] 					= 1
	grades[dataIndex["default_defense"]] 				= 1
	grades[dataIndex["default_resis_stun"]] 		= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["default_resis_stun"]])
	grades[dataIndex["default_resis_sleep"]] 		= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["default_resis_sleep"]])
	grades[dataIndex["default_resis_silence"]] 	= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["default_resis_silence"]])
	grades[dataIndex["default_resis_weakness"]] = ZLuaTal_Get_RanPoint(valueWeights[dataIndex["default_resis_weakness"]])
	grades[dataIndex["default_resis_enlace"]] 	= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["default_resis_enlace"]])

	grades[dataIndex["grow_hp"]] 								= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["grow_hp"]])
	grades[dataIndex["grow_mp"]] 								= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["grow_mp"]])
	grades[dataIndex["grow_attack_rate"]] 			= 1
	grades[dataIndex["grow_damage_low"]] 				= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["grow_damage_low"]])
	grades[dataIndex["grow_damage_high"]] 			= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["grow_damage_high"]])
	grades[dataIndex["grow_dodge"]] 						= 1
	grades[dataIndex["grow_defense"]] 					= 1
	grades[dataIndex["grow_resis_stun"]] 				= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["grow_resis_stun"]])
	grades[dataIndex["grow_resis_sleep"]] 			= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["grow_resis_sleep"]])
	grades[dataIndex["grow_resis_silence"]] 		= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["grow_resis_silence"]])
	grades[dataIndex["grow_resis_weakness"]] 		= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["grow_resis_weakness"]])
	grades[dataIndex["grow_resis_enlace"]] 			= ZLuaTal_Get_RanPoint(valueWeights[dataIndex["grow_resis_enlace"]])



	---求得法宝特性
	local speciality = ZLuaTalGenerateSpeciality(tmplID, origin, quality, grades)

	---取得精力值、本体属性的初始值与成长率真实值
	---如果是飞行法宝，则初始值和成长率都为0
	if ZLuaTalGetTalTypeFromID(tmplID) == "feijian"
	or ZLuaTalGetTalTypeFromID(tmplID) == "yushou"
	or ZLuaTalGetTalTypeFromID(tmplID) == "chibang"
	then

		randomResult[dataIndex["is_fly"]] = 1
		randomResult[dataIndex["default_stamina"]] = 0
		randomResult[dataIndex["quo_stamina"]] = 0
	
		randomResult[dataIndex["default_hp"]] = 0
		randomResult[dataIndex["default_mp"]] = 0
		randomResult[dataIndex["default_attack_rate"]] = 0
		randomResult[dataIndex["default_damage_low"]] = 0
		randomResult[dataIndex["default_damage_high"]] = 0
		randomResult[dataIndex["default_dodge"]] = 0
		randomResult[dataIndex["default_defense"]] = 0
		randomResult[dataIndex["default_resis_stun"]] = 0
		randomResult[dataIndex["default_resis_sleep"]] = 0
		randomResult[dataIndex["default_resis_silence"]] = 0
		randomResult[dataIndex["default_resis_weakness"]] = 0
		randomResult[dataIndex["default_resis_enlace"]] = 0
	
		randomResult[dataIndex["grow_hp"]] = 0
		randomResult[dataIndex["grow_mp"]] = 0
		randomResult[dataIndex["grow_attack_rate"]] = 0
		randomResult[dataIndex["grow_damage_low"]] = 0
		randomResult[dataIndex["grow_damage_high"]] = 0
		randomResult[dataIndex["grow_dodge"]] = 0
		randomResult[dataIndex["grow_defense"]] = 0
		randomResult[dataIndex["grow_resis_stun"]] = 0
		randomResult[dataIndex["grow_resis_sleep"]] = 0
		randomResult[dataIndex["grow_resis_silence"]] = 0
		randomResult[dataIndex["grow_resis_weakness"]] = 0
		randomResult[dataIndex["grow_resis_enlace"]] = 0

	else
	randomResult[dataIndex["is_fly"]] = 0
	randomResult[dataIndex["default_stamina"]] = valueGrades[dataIndex["default_stamina"]][grades[dataIndex["default_stamina"]]]
	randomResult[dataIndex["quo_stamina"]] = valueGrades[dataIndex["quo_stamina"]][grades[dataIndex["quo_stamina"]]]

	randomResult[dataIndex["default_hp"]] = valueGrades[dataIndex["default_hp"]][grades[dataIndex["default_hp"]]]
	randomResult[dataIndex["default_mp"]] = valueGrades[dataIndex["default_mp"]][grades[dataIndex["default_mp"]]]
	randomResult[dataIndex["default_attack_rate"]] = valueGrades[dataIndex["default_attack_rate"]][grades[dataIndex["default_attack_rate"]]]
	randomResult[dataIndex["default_damage_low"]] = valueGrades[dataIndex["default_damage_low"]][grades[dataIndex["default_damage_low"]]]
	randomResult[dataIndex["default_damage_high"]] = valueGrades[dataIndex["default_damage_high"]][grades[dataIndex["default_damage_high"]]]
	randomResult[dataIndex["default_dodge"]] = valueGrades[dataIndex["default_dodge"]][grades[dataIndex["default_dodge"]]]
	randomResult[dataIndex["default_defense"]] = valueGrades[dataIndex["default_defense"]][grades[dataIndex["default_defense"]]]
	randomResult[dataIndex["default_resis_stun"]] = valueGrades[dataIndex["default_resis_stun"]][grades[dataIndex["default_resis_stun"]]]
	randomResult[dataIndex["default_resis_sleep"]] = valueGrades[dataIndex["default_resis_sleep"]][grades[dataIndex["default_resis_sleep"]]]
	randomResult[dataIndex["default_resis_silence"]] = valueGrades[dataIndex["default_resis_silence"]][grades[dataIndex["default_resis_silence"]]]
	randomResult[dataIndex["default_resis_weakness"]] = valueGrades[dataIndex["default_resis_weakness"]][grades[dataIndex["default_resis_weakness"]]]
	randomResult[dataIndex["default_resis_enlace"]] = valueGrades[dataIndex["default_resis_enlace"]][grades[dataIndex["default_resis_enlace"]]]

	randomResult[dataIndex["grow_hp"]] = valueGrades[dataIndex["grow_hp"]][grades[dataIndex["grow_hp"]]]
	randomResult[dataIndex["grow_mp"]] = valueGrades[dataIndex["grow_mp"]][grades[dataIndex["grow_mp"]]]
	randomResult[dataIndex["grow_attack_rate"]] = valueGrades[dataIndex["grow_attack_rate"]][grades[dataIndex["grow_attack_rate"]]]
	randomResult[dataIndex["grow_damage_low"]] = valueGrades[dataIndex["grow_damage_low"]][grades[dataIndex["grow_damage_low"]]]
	randomResult[dataIndex["grow_damage_high"]] = valueGrades[dataIndex["grow_damage_high"]][grades[dataIndex["grow_damage_high"]]]
	randomResult[dataIndex["grow_dodge"]] = valueGrades[dataIndex["grow_dodge"]][grades[dataIndex["grow_dodge"]]]
	randomResult[dataIndex["grow_defense"]] = valueGrades[dataIndex["grow_defense"]][grades[dataIndex["grow_defense"]]]
	randomResult[dataIndex["grow_resis_stun"]] = valueGrades[dataIndex["grow_resis_stun"]][grades[dataIndex["grow_resis_stun"]]]
	randomResult[dataIndex["grow_resis_sleep"]] = valueGrades[dataIndex["grow_resis_sleep"]][grades[dataIndex["grow_resis_sleep"]]]
	randomResult[dataIndex["grow_resis_silence"]] = valueGrades[dataIndex["grow_resis_silence"]][grades[dataIndex["grow_resis_silence"]]]
	randomResult[dataIndex["grow_resis_weakness"]] = valueGrades[dataIndex["grow_resis_weakness"]][grades[dataIndex["grow_resis_weakness"]]]
	randomResult[dataIndex["grow_resis_enlace"]] = valueGrades[dataIndex["grow_resis_enlace"]][grades[dataIndex["grow_resis_enlace"]]]
  end
	---取得所有附加属性值对（学会等级，附加属性ID）
	local addonIDs,addonLevels
	addonIDs, addonLevels = ZLuaTal_Talisman_Trans_ID(tmplID, origin)
	
	---约定：
	---如果 ZLuaTal_Talisman_Trans_ID 返回 false,false，说明tmplID有问题
	---如果 ZLuaTal_Talisman_Trans_ID 返回 false,true， 说明ZLuaTal_Talisman_Trans_ID函数内部有其他错误
	if addonIDs ~= false then  
		randomResult[dataIndex["addon_1_learn_level"]] = addonLevels[1]
		randomResult[dataIndex["addon_2_learn_level"]] = addonLevels[2]
		randomResult[dataIndex["addon_3_learn_level"]] = addonLevels[3]
		randomResult[dataIndex["addon_4_learn_level"]] = addonLevels[4]
		randomResult[dataIndex["addon_5_learn_level"]] = addonLevels[5]
		randomResult[dataIndex["addon_6_learn_level"]] = addonLevels[6]
		randomResult[dataIndex["addon_7_learn_level"]] = addonLevels[7]
		randomResult[dataIndex["addon_8_learn_level"]] = addonLevels[8]
		randomResult[dataIndex["addon_9_learn_level"]] = addonLevels[9]
		randomResult[dataIndex["addon_10_learn_level"]] = addonLevels[10]
		randomResult[dataIndex["addon_11_learn_level"]] = addonLevels[11]
		randomResult[dataIndex["addon_1_id"]] = addonIDs[1]
		randomResult[dataIndex["addon_2_id"]] = addonIDs[2]
		randomResult[dataIndex["addon_3_id"]] = addonIDs[3]
		randomResult[dataIndex["addon_4_id"]] = addonIDs[4]
		randomResult[dataIndex["addon_5_id"]] = addonIDs[5]
		randomResult[dataIndex["addon_6_id"]] = addonIDs[6]
		randomResult[dataIndex["addon_7_id"]] = addonIDs[7]
		randomResult[dataIndex["addon_8_id"]] = addonIDs[8]
		randomResult[dataIndex["addon_9_id"]] = addonIDs[9]
		randomResult[dataIndex["addon_10_id"]] = addonIDs[10]
		randomResult[dataIndex["addon_11_id"]] = addonIDs[11]
	else
		randomResult[dataIndex["addon_1_learn_level"]] = 0
		randomResult[dataIndex["addon_2_learn_level"]] = 0
		randomResult[dataIndex["addon_3_learn_level"]] = 0
		randomResult[dataIndex["addon_4_learn_level"]] = 0
		randomResult[dataIndex["addon_5_learn_level"]] = 0
		randomResult[dataIndex["addon_6_learn_level"]] = 0
		randomResult[dataIndex["addon_7_learn_level"]] = 0
		randomResult[dataIndex["addon_8_learn_level"]] = 0
		randomResult[dataIndex["addon_9_learn_level"]] = 0
		randomResult[dataIndex["addon_10_learn_level"]] = 0
		randomResult[dataIndex["addon_11_learn_level"]] = 0
		randomResult[dataIndex["addon_1_id"]] = 0
		randomResult[dataIndex["addon_2_id"]] = 0
		randomResult[dataIndex["addon_3_id"]] = 0
		randomResult[dataIndex["addon_4_id"]] = 0
		randomResult[dataIndex["addon_5_id"]] = 0
		randomResult[dataIndex["addon_6_id"]] = 0
		randomResult[dataIndex["addon_7_id"]] = 0
		randomResult[dataIndex["addon_8_id"]] = 0
		randomResult[dataIndex["addon_9_id"]] = 0
		randomResult[dataIndex["addon_10_id"]] = 0
		randomResult[dataIndex["addon_11_id"]] = 0
	end
	
	---求得附加属性个数
	local addonnumber=0
  for i = 1,7 do
    if addonIDs[i] ~=nil then
    addonnumber=addonnumber+1
    end
  end
  ---求得法宝综合品阶
  local quality
  if randomResult[dataIndex["is_fly"]]==1 and addonnumber<4 then
  	quality = 0
  elseif randomResult[dataIndex["is_fly"]]==1 and addonnumber==4 then
  	quality = 1
  elseif randomResult[dataIndex["is_fly"]]==1 and addonnumber>4 then
  	quality = 2
  elseif randomResult[dataIndex["is_fly"]] == 0 then
  	quality = ZLuaTalGenerateQuality(tmplID, origin, grades, nGrades)
  end	
  
	
	
	---解决07年元旦雪人活动掉落九龙神火罩没属性问题，用兑换任务换成有属性的，为防刷为把技能置为固定组合 uncomplete
	if tmplID == talismans["US_105_JiuLongShenHuoZhao"].tmplID then
		randomResult[dataIndex["addon_1_learn_level"]] = 5
		randomResult[dataIndex["addon_2_learn_level"]] = 10
		randomResult[dataIndex["addon_3_learn_level"]] = 15
		randomResult[dataIndex["addon_4_learn_level"]] = 0
		randomResult[dataIndex["addon_5_learn_level"]] = 0
		randomResult[dataIndex["addon_6_learn_level"]] = 0
		randomResult[dataIndex["addon_7_learn_level"]] = 0
		randomResult[dataIndex["addon_8_learn_level"]] = 0
		randomResult[dataIndex["addon_9_learn_level"]] = 0
		randomResult[dataIndex["addon_10_learn_level"]] = 0
		randomResult[dataIndex["addon_11_learn_level"]] = 0
		randomResult[dataIndex["addon_4_id"]] = 0
		randomResult[dataIndex["addon_5_id"]] = 0
		randomResult[dataIndex["addon_6_id"]] = 0
		randomResult[dataIndex["addon_7_id"]] = 0
		randomResult[dataIndex["addon_8_id"]] = 0
		randomResult[dataIndex["addon_9_id"]] = 0
		randomResult[dataIndex["addon_10_id"]] = 0
		randomResult[dataIndex["addon_11_id"]] = 0
		
		local r = math.random()
		if r < 0.2 then
			---青云
			randomResult[dataIndex["addon_1_id"]] = 369
			randomResult[dataIndex["addon_2_id"]] = 375
			randomResult[dataIndex["addon_3_id"]] = 380
		elseif r < 0.4 then
			---鬼王
			randomResult[dataIndex["addon_1_id"]] = 340
			randomResult[dataIndex["addon_2_id"]] = 345
			randomResult[dataIndex["addon_3_id"]] = 351
		elseif r < 0.6 then
			---天音
			randomResult[dataIndex["addon_1_id"]] = 384
			randomResult[dataIndex["addon_2_id"]] = 389
			randomResult[dataIndex["addon_3_id"]] = 394
		elseif r < 0.8 then
			---鬼道
			randomResult[dataIndex["addon_1_id"]] = 1758
			randomResult[dataIndex["addon_2_id"]] = 1759
			randomResult[dataIndex["addon_3_id"]] = 1760
		else
			---合欢
			randomResult[dataIndex["addon_1_id"]] = 354
			randomResult[dataIndex["addon_2_id"]] = 361
			randomResult[dataIndex["addon_3_id"]] = 365
		end
	end
				
	

	return randomResult, quality, speciality
end

---法宝初始化
function ZLuaTalInit(tmplID, talisman, originFromServer)
	if ZLuaTalExistInTmplIDs(tmplID) == 0 then return end
	if talisman == nil then return end
	
	---取得一些常量
	local dataIndex,resisIndex,data2Index = ZLuaTalDataIndex()
	local staminaGrowth = ZLuaTalStaminaGrowth()
	local serverOrigins = ZLuaTalServerOrigins()
	
	---取得飞剑模式
	---0 御剑;3 御兽;6 翅膀,每次添加新的飞剑需要修改此处.
	local flymod
	
	if ZLuaTalGetTalTypeFromID(tmplID) == "feijian" then
		flymod=0
	elseif ZLuaTalGetTalTypeFromID(tmplID) == "yushou" then
		flymod=3
	elseif ZLuaTalGetTalTypeFromID(tmplID) == "chibang" then
		flymod=6
	else
		flymod=3
	end

	---取得法宝来源（服务器约定）
	local serverOrigin = originFromServer or serverOrigins["null"]
	

	---取得法宝随机结果
	local randomResult, quality, speciality = ZLuaTalRandomResult(tmplID, serverOrigin)
	
	---设定法宝是否飞行法宝
	talisman:UpdateData(0,dataIndex["is_fly"], randomResult[dataIndex["is_fly"]]);
	

	---生成法宝模板ID
	talisman:UpdateData(0,dataIndex["tmpl_id"], tmplID)
	
	---生成保留数据
	talisman:UpdateData(0,dataIndex["reserve1"], 0)
	talisman:UpdateData(0,dataIndex["reserve2"], 0)

	---生成法宝技能
	talisman:UpdateData(0,dataIndex["skill_addon_id"], randomResult[dataIndex["skill_addon_id"]]);

	---生成精力值初始值、成长系数
	talisman:UpdateData(0,dataIndex["default_stamina"], math.floor(randomResult[dataIndex["default_stamina"]]));
	talisman:UpdateData(0,dataIndex["quo_stamina"], math.floor(randomResult[dataIndex["quo_stamina"]]*100)/100);
	
	---生成法宝本体属性初值、增长量
	talisman:UpdateData(0,dataIndex["default_hp"], math.floor(randomResult[dataIndex["default_hp"]]));
	talisman:UpdateData(0,dataIndex["default_mp"], math.floor(randomResult[dataIndex["default_mp"]]));
	talisman:UpdateData(0,dataIndex["default_attack_rate"], 0);
	talisman:UpdateData(0,dataIndex["default_damage_low"], math.floor(math.min(randomResult[dataIndex["default_damage_low"]],randomResult[dataIndex["default_damage_high"]])));
	talisman:UpdateData(0,dataIndex["default_damage_high"], math.floor(randomResult[dataIndex["default_damage_high"]]));
	talisman:UpdateData(0,dataIndex["default_dodge"], 0);
	talisman:UpdateData(0,dataIndex["default_defense"], 0);
	talisman:UpdateData(0,dataIndex["default_resis_stun"], math.floor(randomResult[dataIndex["default_resis_stun"]]));
	talisman:UpdateData(0,dataIndex["default_resis_weakness"], math.floor(randomResult[dataIndex["default_resis_weakness"]]));
	talisman:UpdateData(0,dataIndex["default_resis_silence"], math.floor(randomResult[dataIndex["default_resis_silence"]]));
	talisman:UpdateData(0,dataIndex["default_resis_sleep"], math.floor(randomResult[dataIndex["default_resis_sleep"]]));
	talisman:UpdateData(0,dataIndex["default_resis_enlace"], math.floor(randomResult[dataIndex["default_resis_enlace"]]));

	talisman:UpdateData(0,dataIndex["grow_hp"], math.floor(randomResult[dataIndex["grow_hp"]]*100)/100);
	talisman:UpdateData(0,dataIndex["grow_mp"], math.floor(randomResult[dataIndex["grow_mp"]]*100)/100);
	talisman:UpdateData(0,dataIndex["grow_attack_rate"], 0);
	talisman:UpdateData(0,dataIndex["grow_damage_low"], math.floor(math.min(randomResult[dataIndex["grow_damage_low"]],randomResult[dataIndex["grow_damage_high"]])*100)/100);
	talisman:UpdateData(0,dataIndex["grow_damage_high"], math.floor(randomResult[dataIndex["grow_damage_high"]]*100)/100);
	talisman:UpdateData(0,dataIndex["grow_dodge"], 0);
	talisman:UpdateData(0,dataIndex["grow_defense"], 0);
	talisman:UpdateData(0,dataIndex["grow_resis_stun"], math.floor(randomResult[dataIndex["grow_resis_stun"]]*100)/100);
	talisman:UpdateData(0,dataIndex["grow_resis_weakness"], math.floor(randomResult[dataIndex["grow_resis_weakness"]]*100)/100);
	talisman:UpdateData(0,dataIndex["grow_resis_silence"], math.floor(randomResult[dataIndex["grow_resis_silence"]]*100)/100);
	talisman:UpdateData(0,dataIndex["grow_resis_sleep"], math.floor(randomResult[dataIndex["grow_resis_sleep"]]*100)/100);
	talisman:UpdateData(0,dataIndex["grow_resis_enlace"], math.floor(randomResult[dataIndex["grow_resis_enlace"]]*100)/100);
	
	---生成法宝附加属性学习等级、附加属性Id
	talisman:UpdateData(0,dataIndex["addon_1_learn_level"], (randomResult[dataIndex["addon_1_learn_level"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_2_learn_level"], (randomResult[dataIndex["addon_2_learn_level"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_3_learn_level"], (randomResult[dataIndex["addon_3_learn_level"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_4_learn_level"], (randomResult[dataIndex["addon_4_learn_level"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_5_learn_level"], (randomResult[dataIndex["addon_5_learn_level"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_6_learn_level"], (randomResult[dataIndex["addon_6_learn_level"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_7_learn_level"], (randomResult[dataIndex["addon_7_learn_level"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_8_learn_level"], (randomResult[dataIndex["addon_8_learn_level"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_9_learn_level"], (randomResult[dataIndex["addon_9_learn_level"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_10_learn_level"], (randomResult[dataIndex["addon_10_learn_level"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_11_learn_level"], (randomResult[dataIndex["addon_11_learn_level"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_1_id"], (randomResult[dataIndex["addon_1_id"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_2_id"], (randomResult[dataIndex["addon_2_id"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_3_id"], (randomResult[dataIndex["addon_3_id"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_4_id"], (randomResult[dataIndex["addon_4_id"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_5_id"], (randomResult[dataIndex["addon_5_id"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_6_id"], (randomResult[dataIndex["addon_6_id"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_7_id"], (randomResult[dataIndex["addon_7_id"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_8_id"], (randomResult[dataIndex["addon_8_id"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_9_id"], (randomResult[dataIndex["addon_9_id"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_10_id"],(randomResult[dataIndex["addon_10_id"]] or 0));
	talisman:UpdateData(0,dataIndex["addon_11_id"],(randomResult[dataIndex["addon_11_id"]] or 0));
  
  
  
	---debug，测试最大长度法宝，噬魂
	if tmplID == 999999 then
		talisman:UpdateData(0,dataIndex["addon_1_learn_level"], 1);
		talisman:UpdateData(0,dataIndex["addon_2_learn_level"], 1);
		talisman:UpdateData(0,dataIndex["addon_3_learn_level"], 1);
		talisman:UpdateData(0,dataIndex["addon_4_learn_level"], 1);
		talisman:UpdateData(0,dataIndex["addon_5_learn_level"], 1);
		talisman:UpdateData(0,dataIndex["addon_6_learn_level"], 1);
		talisman:UpdateData(0,dataIndex["addon_7_learn_level"], 1);
		talisman:UpdateData(0,dataIndex["addon_8_learn_level"], 1);
		talisman:UpdateData(0,dataIndex["addon_9_learn_level"], 1);
		talisman:UpdateData(0,dataIndex["addon_10_learn_level"], 1);
		talisman:UpdateData(0,dataIndex["addon_11_learn_level"], 1);
		talisman:UpdateData(0,dataIndex["addon_1_id"], 370);
		talisman:UpdateData(0,dataIndex["addon_2_id"], 370);
		talisman:UpdateData(0,dataIndex["addon_3_id"], 370);
		talisman:UpdateData(0,dataIndex["addon_4_id"], 370);
		talisman:UpdateData(0,dataIndex["addon_5_id"], 370);
		talisman:UpdateData(0,dataIndex["addon_6_id"], 370);
		talisman:UpdateData(0,dataIndex["addon_7_id"], 370);
		talisman:UpdateData(0,dataIndex["addon_8_id"], 370);
		talisman:UpdateData(0,dataIndex["addon_9_id"], 370);
		talisman:UpdateData(0,dataIndex["addon_10_id"], 370);
		talisman:UpdateData(0,dataIndex["addon_11_id"], 370);
	end	
	---debug

	---生成法宝美工路径

	talisman:UpdateData(0,dataIndex["artpath_1_level"], 1);
	talisman:UpdateData(0,dataIndex["artpath_2_level"], 10);
	talisman:UpdateData(0,dataIndex["artpath_3_level"], 20);
	talisman:UpdateData(0,dataIndex["artpath_4_level"], 30);

	
	---生成法宝干扰系数
	local confusions = ZLuaTalGenerateConfusion( tmplID, origin );
	talisman:UpdateData(0,dataIndex["confusion_1_level"], confusions[1].level)
	talisman:UpdateData(0,dataIndex["confusion_1_quo"], confusions[1].quo)
	talisman:UpdateData(0,dataIndex["confusion_2_level"], confusions[2].level)
	talisman:UpdateData(0,dataIndex["confusion_2_quo"], confusions[2].quo)
	talisman:UpdateData(0,dataIndex["confusion_3_level"], confusions[3].level)
	talisman:UpdateData(0,dataIndex["confusion_3_quo"], confusions[3].quo)
	talisman:UpdateData(0,dataIndex["confusion_4_level"], confusions[4].level)
	talisman:UpdateData(0,dataIndex["confusion_4_quo"], confusions[4].quo)
	talisman:UpdateData(0,dataIndex["confusion_5_level"], confusions[5].level)
	talisman:UpdateData(0,dataIndex["confusion_5_quo"], confusions[5].quo)
	
	---计算出生成时刻
	local gameHour12, gameMin3 = ZLuaTalGenerteBirthTime()
	talisman:UpdateData(0,dataIndex["birth_hour12"], gameHour12)
	talisman:UpdateData(0,dataIndex["birth_min3"], gameMin3)
	
	---计算出法宝来源
	local clientOrigin = ZLuaTalGenerateClientOrigin(serverOrigin)
	talisman:UpdateData(0,dataIndex["origin"], clientOrigin)

	---写入品质
	local realquality
		realquality=quality+flymod
	if talisman:QueryData(0,dataIndex["is_fly"]) == 1 then
		---
		talisman:UpdateData(0,dataIndex["quality"], realquality)
	else
		talisman:UpdateData(0,dataIndex["quality"], quality)
	end
	
	---写入特性
	talisman:UpdateData(0,dataIndex["speciality"], speciality)
	
	---写入法宝灌魔相关值
	talisman:UpdateData(0,dataIndex["buff_type"], 0)
	talisman:UpdateData(0,dataIndex["ext_id"], 0)
	talisman:UpdateData(0,dataIndex["skill_visible"], 0)
	
	---写入观察值
	talisman:UpdateData(0,dataIndex["combine_times"], 0)
	talisman:UpdateData(0,dataIndex["enchant_times"], 0)
	talisman:UpdateData(0,dataIndex["feed_baoqi"], 0)
	talisman:UpdateData(0,dataIndex["feed_xianpin"], 0)
	talisman:UpdateData(0,dataIndex["feed_shenpin"], 0)
	talisman:UpdateData(0,dataIndex["feed_cost"], 0)
	talisman:UpdateData(0,dataIndex["change_skillnum"], 0)
	talisman:UpdateData(0,dataIndex["feed_level_cost"], 0)
	
	---写入档位提升信息
	talisman:UpdateData(0,dataIndex["hp_rise"], 0)
	talisman:UpdateData(0,dataIndex["mp_rise"], 0)
	talisman:UpdateData(0,dataIndex["minattack_rise"], 0)
	talisman:UpdateData(0,dataIndex["maxattack_rise"], 0)
	talisman:UpdateData(0,dataIndex["stun_rise"], 0)
	talisman:UpdateData(0,dataIndex["weakness_rise"], 0)
	talisman:UpdateData(0,dataIndex["enlace_rise"], 0)
	talisman:UpdateData(0,dataIndex["silence_rise"], 0)
	talisman:UpdateData(0,dataIndex["sleep_rise"], 0)
	talisman:UpdateData(0,dataIndex["all_rise"], 0)

	-- 写入主属性强化信息
	talisman:UpdateData(0,dataIndex["hp_enhance"], 0)
	talisman:UpdateData(0,dataIndex["mp_enhance"], 0)
	talisman:UpdateData(0,dataIndex["atk_enhance"], 0)
	talisman:UpdateData(1,data2Index["hp_enhance"], 0)
	talisman:UpdateData(1,data2Index["mp_enhance"], 0)
	talisman:UpdateData(1,data2Index["atk_enhance"], 0)

	-- 写入洗炼技能信息	
	talisman:UpdateData(0,dataIndex["skillrefine_level"], 0)
	talisman:UpdateData(0,dataIndex["skillrefine_0"], 0)
	talisman:UpdateData(0,dataIndex["skillrefine_1"], 0)
	talisman:UpdateData(0,dataIndex["skillrefine_2"], 0)
	talisman:UpdateData(0,dataIndex["skillrefine_3"], 0)
	talisman:UpdateData(0,dataIndex["skillrefine_4"], 0)
	talisman:UpdateData(0,dataIndex["skillrefine_5"], 0)
	talisman:UpdateData(0,dataIndex["skillrefine_6"], 0)
	talisman:UpdateData(0,dataIndex["skillrefine_7"], 0)
	talisman:UpdateData(0,dataIndex["skillrefine_8"], 0)
	talisman:UpdateData(0,dataIndex["skillrefinetmp_0"], 0)
	talisman:UpdateData(0,dataIndex["skillrefinetmp_1"], 0)
	talisman:UpdateData(0,dataIndex["skillrefinetmp_2"], 0)
	talisman:UpdateData(0,dataIndex["skillrefinetmp_3"], 0)
	talisman:UpdateData(0,dataIndex["skillrefinetmp_4"], 0)
	talisman:UpdateData(0,dataIndex["skillrefinetmp_5"], 0)
	talisman:UpdateData(0,dataIndex["skillrefinetmp_6"], 0)
	talisman:UpdateData(0,dataIndex["skillrefinetmp_7"], 0)
	talisman:UpdateData(0,dataIndex["skillrefinetmp_8"], 0)

	-- 写入镶嵌技能信息	
	talisman:UpdateData(0,dataIndex["newaddon_id_1"], 0)
	talisman:UpdateData(0,dataIndex["newaddon_id_2"], 0)
	talisman:UpdateData(0,dataIndex["newaddon_id_3"], 0)
	talisman:UpdateData(0,dataIndex["newaddon_id_4"], 0)
	talisman:UpdateData(0,dataIndex["newaddon_id_5"], 0)

	-- 写入飞升次数信息
	talisman:UpdateData(0,dataIndex["reborncont"], 0)

	-- 写入技能洗炼次数信息
	talisman:UpdateData(0,dataIndex["skillrefinecont"], 0)

	ZLuaTalRebuild(talisman,tmplID);
end

---法宝升级
function ZLuaTalLevelup(tmplID, talisman)
	---更换法身效果
	ZLuaTalChangeExt(talisman);

	ZLuaTalRebuild(talisman,tmplID);
end

---法宝洗炼
function ZLuaTalReset(tmplID, talisman)
	local dataIndex = ZLuaTalDataIndex()
	talisman:UpdateData(0,dataIndex["buff_type"],0)
	talisman:UpdateData(0,dataIndex["ext_id"],0)
	ZLuaTalRebuild(talisman,tmplID);
end

---法宝本体属性与附加属性重新计算
function ZLuaTalRebuild(talisman,tmplID)
	---取得一些常量
	local dataIndex,resisIndex,data2Index = ZLuaTalDataIndex()
	local staminaGrowth = ZLuaTalStaminaGrowth()
	---再次重新计算法宝品阶，用于纠正20070918正式版的脚本中山河扇、玉净瓶的品阶错误
	---在debug时注释掉 uncomplete
	local correct_quality = ZLuaTalGenerateQualityFromTalisman(tmplID, talisman)
	if talisman:QueryData(0,dataIndex["is_fly"])==0 then
	talisman:UpdateData(0,dataIndex["quality"], correct_quality)
	end

	-------------如果没有新的数据项，则生成----------------------------------
	if talisman:QueryData(0,dataIndex["hp_rise"])==nil then
		talisman:UpdateData(0,dataIndex["hp_rise"],0)
	end
	if talisman:QueryData(0,dataIndex["mp_rise"])==nil then
		talisman:UpdateData(0,dataIndex["mp_rise"],0)
	end
	if talisman:QueryData(0,dataIndex["minattack_rise"])==nil then
		talisman:UpdateData(0,dataIndex["minattack_rise"],0)
	end
	if talisman:QueryData(0,dataIndex["maxattack_rise"])==nil then
		talisman:UpdateData(0,dataIndex["maxattack_rise"],0)
	end
	if talisman:QueryData(0,dataIndex["stun_rise"])==nil then
		talisman:UpdateData(0,dataIndex["stun_rise"],0)
	end
	if talisman:QueryData(0,dataIndex["weakness_rise"])==nil then
		talisman:UpdateData(0,dataIndex["weakness_rise"],0)
	end
	if talisman:QueryData(0,dataIndex["enlace_rise"])==nil then
		talisman:UpdateData(0,dataIndex["enlace_rise"],0)
	end
	if talisman:QueryData(0,dataIndex["silence_rise"])==nil then
		talisman:UpdateData(0,dataIndex["silence_rise"],0)
	end
	if talisman:QueryData(0,dataIndex["sleep_rise"])==nil then
		talisman:UpdateData(0,dataIndex["sleep_rise"],0)
	end
	if talisman:QueryData(0,dataIndex["all_rise"])==nil then
		talisman:UpdateData(0,dataIndex["all_rise"],0)
	end	

	if talisman:QueryData(0,dataIndex["hp_enhance"])==nil then
		talisman:UpdateData(0,dataIndex["hp_enhance"],0)
	end	
	if talisman:QueryData(0,dataIndex["mp_enhance"])==nil then
		talisman:UpdateData(0,dataIndex["mp_enhance"],0)
	end	
	if talisman:QueryData(0,dataIndex["atk_enhance"])==nil then
		talisman:UpdateData(0,dataIndex["atk_enhance"],0)
	end	
	if talisman:QueryData(1,data2Index["hp_enhance"])==nil then
		talisman:UpdateData(1,data2Index["hp_enhance"],0)
	end	
	if talisman:QueryData(1,data2Index["mp_enhance"])==nil then
		talisman:UpdateData(1,data2Index["mp_enhance"],0)
	end	
	if talisman:QueryData(1,data2Index["atk_enhance"])==nil then
		talisman:UpdateData(1,data2Index["atk_enhance"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefine_level"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefine_level"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefine_0"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefine_0"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefine_1"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefine_1"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefine_2"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefine_2"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefine_3"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefine_3"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefine_4"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefine_4"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefine_5"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefine_5"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefine_6"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefine_6"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefine_7"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefine_7"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefine_8"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefine_8"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefinetmp_1"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefinetmp_1"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefinetmp_2"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefinetmp_2"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefinetmp_3"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefinetmp_3"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefinetmp_4"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefinetmp_4"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefinetmp_5"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefinetmp_5"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefinetmp_6"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefinetmp_6"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefinetmp_7"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefinetmp_7"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefinetmp_8"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefinetmp_8"],0)
	end	
	if talisman:QueryData(0,dataIndex["newaddon_id_1"])==nil then
		talisman:UpdateData(0,dataIndex["newaddon_id_1"],0)
	end	
	if talisman:QueryData(0,dataIndex["newaddon_id_2"])==nil then
		talisman:UpdateData(0,dataIndex["newaddon_id_2"],0)
	end	
	if talisman:QueryData(0,dataIndex["newaddon_id_3"])==nil then
		talisman:UpdateData(0,dataIndex["newaddon_id_3"],0)
	end	
	if talisman:QueryData(0,dataIndex["newaddon_id_4"])==nil then
		talisman:UpdateData(0,dataIndex["newaddon_id_4"],0)
	end	
	if talisman:QueryData(0,dataIndex["newaddon_id_5"])==nil then
		talisman:UpdateData(0,dataIndex["newaddon_id_5"],0)
	end	
	if talisman:QueryData(0,dataIndex["reborncont"])==nil then
		talisman:UpdateData(0,dataIndex["reborncont"],0)
	end	
	if talisman:QueryData(0,dataIndex["skillrefinecont"])==nil then
		talisman:UpdateData(0,dataIndex["skillrefinecont"],0)
	end	
	
--	

	---取得法宝等级
	local level = talisman:QueryLevel();
	---取得干扰结果
	local confusionQuo = 0
	local confusions = {}
	local i
	for i=1,5 do
		confusions[i] = { quo = 1, level = 1 }
	end
	confusions[1].quo = talisman:QueryData(0,dataIndex["confusion_1_quo"])
	confusions[2].quo = talisman:QueryData(0,dataIndex["confusion_2_quo"])
	confusions[3].quo = talisman:QueryData(0,dataIndex["confusion_3_quo"])
	confusions[4].quo = talisman:QueryData(0,dataIndex["confusion_4_quo"])
	confusions[5].quo = talisman:QueryData(0,dataIndex["confusion_5_quo"])
	confusions[1].level = talisman:QueryData(0,dataIndex["confusion_1_level"])
	confusions[2].level = talisman:QueryData(0,dataIndex["confusion_2_level"])
	confusions[3].level = talisman:QueryData(0,dataIndex["confusion_3_level"])
	confusions[4].level = talisman:QueryData(0,dataIndex["confusion_4_level"])
	confusions[5].level = talisman:QueryData(0,dataIndex["confusion_5_level"])
	
	for i=1,5 do
		if level >= confusions[i].level then confusionQuo = confusionQuo + ( confusions[i].quo - 1 ) end
	end
	
	---设置法宝精练值上限
	local defaultStamina = talisman:QueryData(0,dataIndex["default_stamina"])
	local quoStamina = talisman:QueryData(0,dataIndex["quo_stamina"])
	talisman:SetStamina( math.floor( defaultStamina + quoStamina * staminaGrowth[level] ) );

	---设置飞升影响系数
	local holyLevelUpConf1 = 1
	local holyLevelUpConf2 = 1
	if talisman:QueryData(0,dataIndex["reborncont"]) ~= 0 then 
		holyLevelUpConf1 = 1.1
		holyLevelUpConf2 = 1.2
	end
	
	---设置法宝本体属性
	local defaultHP = math.max(0, talisman:QueryData(0,dataIndex["default_hp"]))
	local defaultMP = math.max(0, talisman:QueryData(0,dataIndex["default_mp"]))
	local defaultDamageLow = math.max(0, talisman:QueryData(0,dataIndex["default_damage_low"]))
	local defaultDamageHigh = math.max(0, talisman:QueryData(0,dataIndex["default_damage_high"]))
	local defaultResisStun = math.max(0, talisman:QueryData(0,dataIndex["default_resis_stun"]))
	local defaultResisSleep = math.max(0, talisman:QueryData(0,dataIndex["default_resis_sleep"]))
	local defaultResisSilence = math.max(0, talisman:QueryData(0,dataIndex["default_resis_silence"]))
	local defaultResisWeakness = math.max(0, talisman:QueryData(0,dataIndex["default_resis_weakness"]))
	local defaultResisEnlace = math.max(0, talisman:QueryData(0,dataIndex["default_resis_enlace"]))
	
	local growHP = math.max(0, talisman:QueryData(0,dataIndex["grow_hp"])*holyLevelUpConf1)
	local growMP = math.max(0, talisman:QueryData(0,dataIndex["grow_mp"])*holyLevelUpConf1)
	local growDamageLow = math.max(0, talisman:QueryData(0,dataIndex["grow_damage_low"])*holyLevelUpConf1)
	local growDamageHigh = math.max(0, talisman:QueryData(0,dataIndex["grow_damage_high"])*holyLevelUpConf1)
	local growResisStun = math.max(0, talisman:QueryData(0,dataIndex["grow_resis_stun"])*holyLevelUpConf1)
	local growResisSleep = math.max(0, talisman:QueryData(0,dataIndex["grow_resis_sleep"])*holyLevelUpConf1)
	local growResisSilence = math.max(0, talisman:QueryData(0,dataIndex["grow_resis_silence"])*holyLevelUpConf1)
	local growResisWeakness = math.max(0, talisman:QueryData(0,dataIndex["grow_resis_weakness"])*holyLevelUpConf1)
	local growResisEnlace = math.max(0, talisman:QueryData(0,dataIndex["grow_resis_enlace"])*holyLevelUpConf1)

	local hp_enhance = math.max(0, math.min(200 * level*holyLevelUpConf2, talisman:QueryData(0,dataIndex["hp_enhance"]))*holyLevelUpConf2)
	local mp_enhance = math.max(0, math.min(200 * level*holyLevelUpConf2, talisman:QueryData(0,dataIndex["mp_enhance"]))*holyLevelUpConf2)
	local atk_enhance= math.max(0, math.min( 30 * level*holyLevelUpConf2, talisman:QueryData(0,dataIndex["atk_enhance"]))*holyLevelUpConf2)

	talisman:SetHP( math.floor( defaultHP + growHP * (level-1+confusionQuo) + hp_enhance) )
	talisman:SetMP( math.floor( defaultMP + growMP * (level-1) + mp_enhance ) )
	talisman:SetDamage( math.floor( defaultDamageLow + growDamageLow * (level-1+confusionQuo) + atk_enhance ), 
											math.floor( defaultDamageHigh + growDamageHigh * (level-1+confusionQuo) + atk_enhance ) )

	talisman:SetHPEnhance( hp_enhance )
	talisman:SetMPEnhance( mp_enhance )
	talisman:SetAttackEnhance( atk_enhance )

	talisman:SetResistance( resisIndex["resis_stun"], math.floor( defaultResisStun + growResisStun * (level-1+confusionQuo) ) )
	talisman:SetResistance( resisIndex["resis_sleep"], math.floor( defaultResisSleep + growResisSleep * (level-1+confusionQuo) ) )
	talisman:SetResistance( resisIndex["resis_silence"], math.floor( defaultResisSilence + growResisSilence * (level-1+confusionQuo) ) )
	talisman:SetResistance( resisIndex["resis_weakness"], math.floor( defaultResisWeakness + growResisWeakness * (level-1+confusionQuo) ) )
	talisman:SetResistance( resisIndex["resis_enlace"], math.floor( defaultResisEnlace + growResisEnlace * (level-1+confusionQuo) ) )
	
	---设置附加属性	
	local addonLearnLevel = {}
	local addonID = {}

	addonLearnLevel[1] = 1
	addonID[1]         = talisman:QueryData(0,dataIndex["skill_addon_id"])
	addonLearnLevel[2] = talisman:QueryData(0,dataIndex["addon_1_learn_level"])
	addonID[2]         = talisman:QueryData(0,dataIndex["addon_1_id"])
	addonLearnLevel[3] = talisman:QueryData(0,dataIndex["addon_2_learn_level"])
	addonID[3]         = talisman:QueryData(0,dataIndex["addon_2_id"])
	addonLearnLevel[4] = talisman:QueryData(0,dataIndex["addon_3_learn_level"])
	addonID[4]         = talisman:QueryData(0,dataIndex["addon_3_id"])
	addonLearnLevel[5] = talisman:QueryData(0,dataIndex["addon_4_learn_level"])
	addonID[5]         = talisman:QueryData(0,dataIndex["addon_4_id"])
	addonLearnLevel[6] = talisman:QueryData(0,dataIndex["addon_5_learn_level"])
	addonID[6]         = talisman:QueryData(0,dataIndex["addon_5_id"])
	addonLearnLevel[7] = talisman:QueryData(0,dataIndex["addon_6_learn_level"])
	addonID[7]         = talisman:QueryData(0,dataIndex["addon_6_id"])
	addonLearnLevel[8] = talisman:QueryData(0,dataIndex["addon_7_learn_level"])
	addonID[8]         = talisman:QueryData(0,dataIndex["addon_7_id"])
	addonLearnLevel[9] = talisman:QueryData(0,dataIndex["addon_8_learn_level"])
	addonID[9]         = talisman:QueryData(0,dataIndex["addon_8_id"])
	addonLearnLevel[10] = talisman:QueryData(0,dataIndex["addon_9_learn_level"])
	addonID[10]         = talisman:QueryData(0,dataIndex["addon_9_id"])
	addonLearnLevel[11] = talisman:QueryData(0,dataIndex["addon_10_learn_level"])
	addonID[11]         = talisman:QueryData(0,dataIndex["addon_10_id"])
	addonLearnLevel[12] = talisman:QueryData(0,dataIndex["addon_11_learn_level"])
	addonID[12]         = talisman:QueryData(0,dataIndex["addon_11_id"])
	
	for i=1,7 do
		if addonLearnLevel[i] ~= nil and addonID[i] ~= nil and addonLearnLevel[i] > 0 then
			local unknown = true
			for j=1,level do
				if addonLearnLevel[i] == j then
					talisman:SetAddon( addonID[i] )
					unknown = false
				end
			end
			if unknown and talisman:QueryData(0,dataIndex["skill_visible"]) == 1 then
				talisman:SetAddon( ZLuaTalGetUnLearnID(addonID[i]) )
			end
		end
	end

	---如果是飞剑，在这里重新计算法宝品质
	local flymod

	if ZLuaTalGetTalTypeFromID(tmplID) == "feijian" then flymod=0
	elseif ZLuaTalGetTalTypeFromID(tmplID) == "yushou" then flymod=3
	elseif ZLuaTalGetTalTypeFromID(tmplID) == "chibang" then flymod=6
	else flymod=3
	end

	if talisman:QueryData(0,dataIndex["is_fly"])==1 then
		local addonID_number=0
		local realquality
		for q=2,8 do
			if addonID[q] > 0 then
				addonID_number=addonID_number+1
			end
		end
		if addonID_number > 4 then realquality=flymod+2
		elseif addonID_number == 4 then realquality=flymod+1
		elseif addonID_number < 4 then realquality=flymod
		end
		talisman:UpdateData(0,dataIndex["quality"], realquality)
	end

	local extID
-- 处理30+级天人合一灌魔属性不增长的bug
	local buffType = talisman:QueryData(0,dataIndex["buff_type"])
	local TalismanEnchantEx=ZLuaTalismanEnchantEx()
	for i,v in pairs(TalismanEnchantEx) do
		if v.bufftype==buffType and v.exlevel==level then 
			extID = i
		end 
	end
-- 处理30+级天人合一灌魔属性不增长的bug
	if extID ~= 0 then
		talisman:UpdateData(0,dataIndex["ext_id"],extID)
		talisman:SetAddon( extID ) 
	end

	---生成Quality属性
	---读出法宝特性、品阶、时辰、时刻、来源
	local speciality = ZLuaTalTransIndex(talisman:QueryData(0,dataIndex["speciality"]))
	local quality = talisman:QueryData(0,dataIndex["quality"])
	local hour12 = talisman:QueryData(0,dataIndex["birth_hour12"])
	local min3 = talisman:QueryData(0,dataIndex["birth_min3"])
	local origin = talisman:QueryData(0,dataIndex["origin"])

	---计算美工路径
	local artpath1Level = talisman:QueryData(0,dataIndex["artpath_1_level"])
	local artpath2Level = talisman:QueryData(0,dataIndex["artpath_2_level"])
	local artpath3Level = talisman:QueryData(0,dataIndex["artpath_3_level"])
	local artpath4Level = talisman:QueryData(0,dataIndex["artpath_4_level"])
	local artpath
	if talisman:QueryData(0,dataIndex["reborncont"]) == 3 then
		artpath = 7
	elseif talisman:QueryData(0,dataIndex["reborncont"]) == 2 then
		artpath = 6
	elseif talisman:QueryData(0,dataIndex["reborncont"]) == 1 then
		artpath = 5
	elseif artpath4Level ~= nil and level >= artpath4Level then 
		artpath = 4
	elseif artpath3Level ~= nil and level >= artpath3Level then 
		artpath = 3
	elseif artpath2Level ~= nil and level >= artpath2Level then 
		artpath = 2
	else
		artpath = 1
	end

	---生成Quality属性的高16位
	local High16 = 2^(4+2+4+16)*quality + 2^(2+4+16)*hour12 + 2^(4+16)*min3 + 2^16*origin
	
	---Quality属性的低16位
	local Low16 = 2^12*speciality + artpath
	
	---生成Quality属性
	talisman:SetQuality( High16 + Low16 )

end


---熔炼结果为A或B时的初始化函数
function ZLuaTalCombineInit(id, speciality, growDirInData, growGrades, talisman, output )		
	---处理一些意外情况
	if type(id) ~= "number" or type(speciality) ~= "number" or type(growDirInData) ~= "number" then
		return
	end

	local dataIndex = ZLuaTalDataIndex()
	local gradeIndex = ZLuaTalGradeIndex()
	local nGrades, valueGrades = ZLuaTalGrades()
	local serverOrigins = ZLuaTalServerOrigins()

	---取得当前法宝的所有属性的成长率上限，这个表是以gradeIndex为索引的
	local gradesUpperLimit = ZLuaTalGradesUpperLimit(id)
	---判断是否飞升法宝，飞升后的法宝成长率上限取新值
--[[
	local n = gradesUpperLimit
	if talisman:QueryData(0,dataIndex["reborncont"]) ~= 0 then
		gradesUpperLimit = {n[1]+90,n[2]+15,n[3]+15,n[4]+15,n[5]+15,n[6],n[7],n[8]+15,n[9]+15,n[10]+15,n[11]+15,n[12]+15,n[13]}
	end
--]]	
	---把data索引变为grades索引，以便于使用上面的gradesUpperLimit表
	local growDirInGrade = ZLuaTalTransIndex(growDirInData)
	
	---首先把talisman的所有data数据copy至output
	for str,index in pairs(dataIndex) do
		output:UpdateData(0,index, talisman:QueryData(0,index) )
	end
	
	---处理老法宝无档位提升记录的情况
	output:UpdateData(0,dataIndex["hp_rise"], ( output:QueryData(0,dataIndex["hp_rise"]) or 0 ))
	output:UpdateData(0,dataIndex["mp_rise"], ( output:QueryData(0,dataIndex["mp_rise"]) or 0 ))
	output:UpdateData(0,dataIndex["minattack_rise"], ( output:QueryData(0,dataIndex["minattack_rise"]) or 0 ))
	output:UpdateData(0,dataIndex["maxattact_rise"], ( output:QueryData(0,dataIndex["maxattact_rise"]) or 0 ))
	output:UpdateData(0,dataIndex["stun_rise"], ( output:QueryData(0,dataIndex["stun_rise"]) or 0 ))
	output:UpdateData(0,dataIndex["weakness_rise"], ( output:QueryData(0,dataIndex["weakness_rise"]) or 0 ))
	output:UpdateData(0,dataIndex["enlace_rise"], ( output:QueryData(0,dataIndex["enlace_rise"]) or 0 ))
	output:UpdateData(0,dataIndex["silence_rise"], ( output:QueryData(0,dataIndex["silence_rise"]) or 0 ))
	output:UpdateData(0,dataIndex["sleep_rise"], ( output:QueryData(0,dataIndex["sleep_rise"]) or 0 ))
	output:UpdateData(0,dataIndex["all_rise"], ( output:QueryData(0,dataIndex["all_rise"]) or 0 ))
	
	---特别处理老法宝的几个观察值
	output:UpdateData(0,dataIndex["combine_times"], ( output:QueryData(0,dataIndex["combine_times"]) or 0 ))
	output:UpdateData(0,dataIndex["enchant_times"], ( output:QueryData(0,dataIndex["enchant_times"]) or 0 ))
	output:UpdateData(0,dataIndex["feed_baoqi"], ( output:QueryData(0,dataIndex["feed_baoqi"]) or 0 ))
	output:UpdateData(0,dataIndex["feed_xianpin"], ( output:QueryData(0,dataIndex["feed_xianpin"]) or 0 ))
	output:UpdateData(0,dataIndex["feed_shenpin"], ( output:QueryData(0,dataIndex["feed_shenpin"]) or 0 ))
	output:UpdateData(0,dataIndex["feed_cost"], ( output:QueryData(0,dataIndex["feed_cost"]) or 0 ))
	output:UpdateData(0,dataIndex["change_skillnum"], ( output:QueryData(0,dataIndex["change_skillnum"]) or 0 ))
	output:UpdateData(0,dataIndex["feed_level_cost"], ( output:QueryData(0,dataIndex["feed_level_cost"]) or 0 ))
	output:UpdateData(0,dataIndex["is_fly"], ( output:QueryData(0,dataIndex["is_fly"]) or 0 ))
	
	---清空法身效果
	output:UpdateData(0,dataIndex["buff_type"], 0)
	output:UpdateData(0,dataIndex["ext_id"], 0)
	
	---如果没有增长，或者增长0档
	if growDirInData == 0 or growGrades == 0 then
		---不作任何额外事情
	
	---如果确有增长
	else
		---取得本成长方向的成长率档位数
		local grade = ZLuaTalGetGradeFromValue(growDirInData, talisman)
		---取得本成长方向的档位上限(2008.08.21修改,引入法宝档位提升值) 
		local growdirection = ZluaTransRiseIndex(growDirInData)
		local gradeUpperLimit = gradesUpperLimit[growDirInGrade]+output:QueryData(0,growdirection)
		---如果成长以后的档位超过了档位上限，那么就置为档位上限
		local newGrade = math.max(1,math.min(gradeUpperLimit, grade + growGrades))
		---成长
		local delta = ( valueGrades[growDirInData][50] - valueGrades[growDirInData][1] ) / 49
		local v0 = valueGrades[growDirInData][1] - delta
		output:UpdateData(0,growDirInData, math.floor( ( v0 + newGrade * delta ) *100)/100)
		---如果最小攻击超过了最大攻击，则强制把最小攻击变为最大攻击
		if output:QueryData(0,dataIndex["grow_damage_low"]) > output:QueryData(0,dataIndex["grow_damage_high"]) then
			output:UpdateData(0,dataIndex["grow_damage_low"],output:QueryData(0,dataIndex["grow_damage_high"]))
		end
		
		---记载下每个属性的档位，初始值和成长率用于传入品阶函数获取品阶，成长率用于本函数内判断是否超过总档位
		local grades = {}
		grades[dataIndex["default_hp"]] 						= ZLuaTalGetGradeFromValue(dataIndex["default_hp"],output)
		grades[dataIndex["default_mp"]] 						= ZLuaTalGetGradeFromValue(dataIndex["default_mp"],output)
		grades[dataIndex["default_damage_low"]] 		= ZLuaTalGetGradeFromValue(dataIndex["default_damage_low"],output)
		grades[dataIndex["default_damage_high"]] 		= ZLuaTalGetGradeFromValue(dataIndex["default_damage_high"],output)
		grades[dataIndex["default_resis_stun"]] 		= ZLuaTalGetGradeFromValue(dataIndex["default_resis_stun"],output)
		grades[dataIndex["default_resis_sleep"]] 		= ZLuaTalGetGradeFromValue(dataIndex["default_resis_sleep"],output)
		grades[dataIndex["default_resis_silence"]] 	= ZLuaTalGetGradeFromValue(dataIndex["default_resis_silence"],output)
		grades[dataIndex["default_resis_weakness"]] = ZLuaTalGetGradeFromValue(dataIndex["default_resis_weakness"],output)
		grades[dataIndex["default_resis_enlace"]] 	= ZLuaTalGetGradeFromValue(dataIndex["default_resis_enlace"],output)
		
		grades[dataIndex["grow_hp"]] 								= ZLuaTalGetGradeFromValue(dataIndex["grow_hp"],output)
		grades[dataIndex["grow_mp"]] 								= ZLuaTalGetGradeFromValue(dataIndex["grow_mp"],output)
		grades[dataIndex["grow_damage_low"]] 				= ZLuaTalGetGradeFromValue(dataIndex["grow_damage_low"],output)
		grades[dataIndex["grow_damage_high"]] 			= ZLuaTalGetGradeFromValue(dataIndex["grow_damage_high"],output)
		grades[dataIndex["grow_resis_stun"]] 				= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_stun"],output)
		grades[dataIndex["grow_resis_sleep"]] 			= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_sleep"],output)
		grades[dataIndex["grow_resis_silence"]] 		= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_silence"],output)
		grades[dataIndex["grow_resis_weakness"]] 		= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_weakness"],output)
		grades[dataIndex["grow_resis_enlace"]] 			= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_enlace"],output)
			
		---如果总体超标就另外随机找一个属性降一挡
		local sumGrades = 0
		sumGrades = sumGrades + grades[dataIndex["grow_hp"]]
		sumGrades = sumGrades + grades[dataIndex["grow_mp"]]
		sumGrades = sumGrades + grades[dataIndex["grow_damage_low"]]
		sumGrades = sumGrades + grades[dataIndex["grow_damage_high"]]
		sumGrades = sumGrades + grades[dataIndex["grow_resis_stun"]]
		sumGrades = sumGrades + grades[dataIndex["grow_resis_sleep"]]
		sumGrades = sumGrades + grades[dataIndex["grow_resis_silence"]]
		sumGrades = sumGrades + grades[dataIndex["grow_resis_weakness"]]
		sumGrades = sumGrades + grades[dataIndex["grow_resis_enlace"]]
		if sumGrades > (gradesUpperLimit[gradeIndex["all"]]+output:QueryData(0,dataIndex["all_rise"])) then
			local randomSpace = {}
			if growDirInData ~= dataIndex["grow_hp"] then table.insert(randomSpace,dataIndex["grow_hp"]) end
			if growDirInData ~= dataIndex["grow_mp"] then table.insert(randomSpace,dataIndex["grow_mp"]) end
			if growDirInData ~= dataIndex["grow_damage_low"] then table.insert(randomSpace,dataIndex["grow_damage_low"]) end
			if growDirInData ~= dataIndex["grow_damage_high"] then table.insert(randomSpace,dataIndex["grow_damage_high"]) end
			if growDirInData ~= dataIndex["grow_resis_stun"] then table.insert(randomSpace,dataIndex["grow_resis_stun"]) end
			if growDirInData ~= dataIndex["grow_resis_sleep"] then table.insert(randomSpace,dataIndex["grow_resis_sleep"]) end
			if growDirInData ~= dataIndex["grow_resis_silence"] then table.insert(randomSpace,dataIndex["grow_resis_silence"]) end
			if growDirInData ~= dataIndex["grow_resis_weakness"] then table.insert(randomSpace,dataIndex["grow_resis_weakness"]) end
			if growDirInData ~= dataIndex["grow_resis_enlace"] then table.insert(randomSpace,dataIndex["grow_resis_enlace"]) end
			local dropAttrib = randomSpace[ math.floor(math.random()*table.getn(randomSpace)+1) ]
			local valueOneGrade = valueGrades[dropAttrib][2]-valueGrades[dropAttrib][1]
			output:UpdateData(0,dropAttrib, math.floor( (output:QueryData(0,dropAttrib)-valueOneGrade) *100) /100)
		end
			
		---重新评价法宝品级
		local quality = ZLuaTalGenerateQuality(id, serverOrigins["combine"], grades, nGrades)
		output:UpdateData(0,dataIndex["quality"], quality)
	end

	---设置模板ID（以确保无tmpl_id索引的老法宝也拥有此data项）
	output:UpdateData(0,dataIndex["tmpl_id"], id)
	
	---设置特性	（老法宝无此data项）
	output:UpdateData(0,dataIndex["speciality"], speciality)
	
	---计算出法宝来源
	local clientOrigin = ZLuaTalGenerateClientOrigin(serverOrigins["combine"])
	output:UpdateData(0,dataIndex["origin"], clientOrigin)
	
	---计算出生成时刻
	local gameHour12, gameMin3 = ZLuaTalGenerteBirthTime()
	output:UpdateData(0,dataIndex["birth_hour12"], gameHour12)
	output:UpdateData(0,dataIndex["birth_min3"], gameMin3)
	
	ZLuaTalRebuild(output,id);
end


-------功能类----------------------------------------------------------------------------------------------------------------------------------

---检查是否法宝是否此法宝的模板ID
function ZLuaTalExistInTmplIDs(tmplID)
	if type(tmplID) ~= "number" then return 0 end
	local availableTalismans = ZLuaTalAvailableTalismans()
	local talisman
	for _,talisman in pairs(availableTalismans) do
		if talisman.tmplID == tmplID then return talisman.requireLevel end
	end
	return 0
end


---a[]是等差数列，给定a[1]=startValue和a[allStep]=endValue，求a[currentStep]
function ZLuaTalGetValueWithBounds(startValue, endValue, currentStep, allStep)
	if type(startValue) ~= "number" or type(endValue) ~= "number" or type(currentStep) ~= "number" or type(allStep) ~= "number" then return -1 end
	if allStep == 1 then return -1 end
	return startValue + ( endValue - startValue ) / ( allStep - 1 ) * ( currentStep - 1 )	
end


---从法宝某个属性具体值取得档位数
function ZLuaTalGetGradeFromValue(index, talisman)		 
	local nGrades, valueGrades = ZLuaTalGrades()
	local delta = ( valueGrades[index][50] - valueGrades[index][1] ) / 49
	local v0 = valueGrades[index][1] - delta
	for i = 1, 555 do
		if talisman:QueryData(0,index) < v0 + ( i * delta ) then
			return i
		end
	end
	return 1
end

-- 返回一个id代表的法宝的种类，"fabao" "feijian" "yushou" "chibang"
function ZLuaTalGetTalTypeFromID(tmplID)
	if type(tmplID) ~= "number" then return 0 end
	local availableTalismans = ZLuaTalAvailableTalismans()
	local talisman
	for _,talisman in pairs(availableTalismans) do
		if talisman.tmplID == tmplID then return talisman.talType end
	end
	return 0
end

--------调试用函数---------------------------------------------------------------------------------------------------

---用于把法宝服务器端数据显示到前台（仅debug用，切切）
function ZLuaTalDebugDisplay(talisman,id,cid,output)		
	---首先把法宝的外在属性计算一遍
	local dataIndex, resisIndex = ZLuaTalDataIndex()
	local temp_cid=ZLuaTalisman_CombineAppendix()
	--
	if talisman:QueryData(0,dataIndex["reserve2"]) ~= 0 then 
		if temp_cid[cid].cidusetype ~= 1 then return end
		output:UpdateData(0,0,talisman:QueryData(0,1)) 
--		if output:QueryData(0,0) == 9 then return end
		return			
	elseif cid ~= 11784 or cid ~= 12021 then 
		return 
	end 
	--
	output:CreateItem(id)
	for _,index in pairs(dataIndex) do
		output:UpdateData(0,index, talisman:QueryData(0,index))
	end	
	output:InheritCombineLevel(true)	
	ZLuaTalRebuild(output,id)

	if cid == 11784 then
		---赋予外部属性
		output:SetHP((output:QueryData(0,dataIndex["combine_times"]) or 0))
		output:SetMP((output:QueryData(0,dataIndex["feed_baoqi"]) or 0))
		output:SetAttackEnhance((output:QueryData(0,dataIndex["feed_xianpin"]) or 0))
		output:SetDamage(0,output:QueryData(0,dataIndex["feed_shenpin"]) )
		output:SetMPEnhance((output:QueryData(0,dataIndex["feed_cost"]) or 0))
		output:SetHPEnhance((output:QueryData(0,dataIndex["change_skillnum"]) or 0))
		output:SetResistance(resisIndex["resis_stun"], (output:QueryData(0,dataIndex["feed_level_cost"]) or 0))
		output:SetResistance(resisIndex["resis_sleep"], (output:QueryData(0,dataIndex["enchant_times"]) or 0))
	elseif cid == 12021 then
		---挨个赋予外部属性以内部成长率
		output:SetHP(ZLuaTalDebugGetGradeFromValue(dataIndex["grow_hp"],talisman))
		output:SetMP(ZLuaTalDebugGetGradeFromValue(dataIndex["grow_mp"],talisman))
		output:SetDamage(ZLuaTalDebugGetGradeFromValue(dataIndex["grow_damage_low"],talisman),ZLuaTalDebugGetGradeFromValue(dataIndex["grow_damage_high"],talisman))
		output:SetResistance(resisIndex["resis_stun"], ZLuaTalDebugGetGradeFromValue(dataIndex["grow_resis_stun"],talisman))
		output:SetResistance(resisIndex["resis_sleep"], ZLuaTalDebugGetGradeFromValue(dataIndex["grow_resis_sleep"],talisman))
		output:SetResistance(resisIndex["resis_silence"], ZLuaTalDebugGetGradeFromValue(dataIndex["grow_resis_silence"],talisman))
		output:SetResistance(resisIndex["resis_weakness"], ZLuaTalDebugGetGradeFromValue(dataIndex["grow_resis_weakness"],talisman))
		output:SetResistance(resisIndex["resis_enlace"], ZLuaTalDebugGetGradeFromValue(dataIndex["grow_resis_enlace"],talisman))
	end
end

---使用任意法宝做辅法宝，新血炼材料做灵媒来血炼门派75级和105级法宝
function ZLuaTalMaxQuality(talisman1,id1,cid,output)
	if cid == 50975 or cid == 50976 then 
	else return end
		
	local dataIndex, resisIndex = ZLuaTalDataIndex()
	local gradeIndex = ZLuaTalGradeIndex()
	local nGrades,valueGrades = ZLuaTalGrades()
	local gradesUpperLimit = ZLuaTalGradesUpperLimit(id1)
	local serverOrigins = ZLuaTalServerOrigins()

	output:CreateItem(id1)
	for _,index in pairs(dataIndex) do
		output:UpdateData(0,index,talisman1:QueryData(0,index))
	end

	output:UpdateData(0,dataIndex["hp_rise"],10)
	output:UpdateData(0,dataIndex["mp_rise"],10)
	output:UpdateData(0,dataIndex["minattack_rise"],10)
	output:UpdateData(0,dataIndex["maxattack_rise"],10)
	output:UpdateData(0,dataIndex["stun_rise"],10)
	output:UpdateData(0,dataIndex["weakness_rise"],10)
	output:UpdateData(0,dataIndex["enlace_rise"],10)
	output:UpdateData(0,dataIndex["silence_rise"],10)
	output:UpdateData(0,dataIndex["sleep_rise"],10)
	output:UpdateData(0,dataIndex["all_rise"],90)
	output:InheritCombineLevel(true)

	local grades = {}
	grades[dataIndex["default_hp"]] 						= ZLuaTalGetGradeFromValue(dataIndex["default_hp"],output)
	grades[dataIndex["default_mp"]] 						= ZLuaTalGetGradeFromValue(dataIndex["default_mp"],output)
	grades[dataIndex["default_damage_low"]] 		= ZLuaTalGetGradeFromValue(dataIndex["default_damage_low"],output)
	grades[dataIndex["default_damage_high"]] 		= ZLuaTalGetGradeFromValue(dataIndex["default_damage_high"],output)
	grades[dataIndex["default_resis_stun"]] 		= ZLuaTalGetGradeFromValue(dataIndex["default_resis_stun"],output)
	grades[dataIndex["default_resis_sleep"]] 		= ZLuaTalGetGradeFromValue(dataIndex["default_resis_sleep"],output)
	grades[dataIndex["default_resis_silence"]] 	= ZLuaTalGetGradeFromValue(dataIndex["default_resis_silence"],output)
	grades[dataIndex["default_resis_weakness"]] = ZLuaTalGetGradeFromValue(dataIndex["default_resis_weakness"],output)
	grades[dataIndex["default_resis_enlace"]] 	= ZLuaTalGetGradeFromValue(dataIndex["default_resis_enlace"],output)

	grades[dataIndex["grow_hp"]] 								= ZLuaTalGetGradeFromValue(dataIndex["grow_hp"],output)
	grades[dataIndex["grow_mp"]] 								= ZLuaTalGetGradeFromValue(dataIndex["grow_mp"],output)
	grades[dataIndex["grow_damage_low"]] 				= ZLuaTalGetGradeFromValue(dataIndex["grow_damage_low"],output)
	grades[dataIndex["grow_damage_high"]] 			= ZLuaTalGetGradeFromValue(dataIndex["grow_damage_high"],output)
	grades[dataIndex["grow_resis_stun"]] 				= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_stun"],output)
	grades[dataIndex["grow_resis_sleep"]] 			= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_sleep"],output)
	grades[dataIndex["grow_resis_silence"]] 		= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_silence"],output)
	grades[dataIndex["grow_resis_weakness"]] 		= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_weakness"],output)
	grades[dataIndex["grow_resis_enlace"]] 			= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_enlace"],output)

	local sumGrades = 0
	sumGrades = sumGrades + grades[dataIndex["grow_hp"]]
	sumGrades = sumGrades + grades[dataIndex["grow_mp"]]
	sumGrades = sumGrades + grades[dataIndex["grow_damage_low"]]
	sumGrades = sumGrades + grades[dataIndex["grow_damage_high"]]
	sumGrades = sumGrades + grades[dataIndex["grow_resis_stun"]]
	sumGrades = sumGrades + grades[dataIndex["grow_resis_sleep"]]
	sumGrades = sumGrades + grades[dataIndex["grow_resis_silence"]]
	sumGrades = sumGrades + grades[dataIndex["grow_resis_weakness"]]
	sumGrades = sumGrades + grades[dataIndex["grow_resis_enlace"]]
	
	local i
	local m = (gradesUpperLimit[gradeIndex["all"]]+output:QueryData(0,dataIndex["all_rise"])) - sumGrades
	local delta
	local v0
	
		--//尽量加满真气
	local n = (gradesUpperLimit[gradeIndex["mp"]]+output:QueryData(0,dataIndex["mp_rise"])) - grades[dataIndex["grow_mp"]]
	if m > 0 and n > 0 then
		i = math.min(m,n)
		grades[dataIndex["grow_mp"]] = grades[dataIndex["grow_mp"]] + i
		sumGrades = sumGrades + i
		m = m - i
		delta = ( valueGrades[dataIndex["grow_mp"]][50] - valueGrades[dataIndex["grow_mp"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_mp"]][1] - delta
		output:UpdateData(0,dataIndex["grow_mp"], math.floor( ( v0 + grades[dataIndex["grow_mp"]] * delta ) *100)/100)
	end
	
	
	--//尽量加满weakness
	local n = (gradesUpperLimit[gradeIndex["resis_weakness"]]+output:QueryData(0,dataIndex["weakness_rise"])) - grades[dataIndex["grow_resis_weakness"]]
	if m > 0 and n > 0 then
		i = math.min(m,n)
		grades[dataIndex["grow_resis_weakness"]] = grades[dataIndex["grow_resis_weakness"]] + i
		sumGrades = sumGrades + i
		m = m - i
		delta = ( valueGrades[dataIndex["grow_resis_weakness"]][50] - valueGrades[dataIndex["grow_resis_weakness"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_resis_weakness"]][1] - delta
		output:UpdateData(0,dataIndex["grow_resis_weakness"], math.floor( ( v0 + grades[dataIndex["grow_resis_weakness"]] * delta ) *100)/100)
	end

	--//尽量加满气血
	local n = (gradesUpperLimit[gradeIndex["hp"]]+output:QueryData(0,dataIndex["hp_rise"])) - grades[dataIndex["grow_hp"]]
	if m > 0 and n > 0 then
		i = math.min(m,n)
		grades[dataIndex["grow_hp"]] = grades[dataIndex["grow_hp"]] + i
		sumGrades = sumGrades + i
		m = m - i
		delta = ( valueGrades[dataIndex["grow_hp"]][50] - valueGrades[dataIndex["grow_hp"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_hp"]][1] - delta
		output:UpdateData(0,dataIndex["grow_hp"], math.floor( ( v0 + grades[dataIndex["grow_hp"]] * delta ) *100)/100)
	end

	--//尽量加满enlace
	local n = (gradesUpperLimit[gradeIndex["resis_enlace"]]+output:QueryData(0,dataIndex["enlace_rise"])) - grades[dataIndex["grow_resis_enlace"]]
	if m > 0 and n > 0 then
		i = math.min(m,n)
		grades[dataIndex["grow_resis_enlace"]] = grades[dataIndex["grow_resis_enlace"]] + i
		sumGrades = sumGrades + i
		m = m - i
		delta = ( valueGrades[dataIndex["grow_resis_enlace"]][50] - valueGrades[dataIndex["grow_resis_enlace"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_resis_enlace"]][1] - delta
		output:UpdateData(0,dataIndex["grow_resis_enlace"], math.floor( ( v0 + grades[dataIndex["grow_resis_enlace"]] * delta ) *100)/100)
	end

	--//尽量加满stun
	local n = (gradesUpperLimit[gradeIndex["resis_stun"]]+output:QueryData(0,dataIndex["stun_rise"])) - grades[dataIndex["grow_resis_stun"]]
	if m > 0 and n > 0 then
		i = math.min(m,n)
		grades[dataIndex["grow_resis_stun"]] = grades[dataIndex["grow_resis_stun"]] + i
		sumGrades = sumGrades + i
		m = m - i
		delta = ( valueGrades[dataIndex["grow_resis_stun"]][50] - valueGrades[dataIndex["grow_resis_stun"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_resis_stun"]][1] - delta
		output:UpdateData(0,dataIndex["grow_resis_stun"], math.floor( ( v0 + grades[dataIndex["grow_resis_stun"]] * delta ) *100)/100)
	end
	
	--//尽量加满sleep
	local n = (gradesUpperLimit[gradeIndex["resis_sleep"]]+output:QueryData(0,dataIndex["sleep_rise"])) - grades[dataIndex["grow_resis_sleep"]]
	if m > 0 and n > 0 then
		i = math.min(m,n)
		grades[dataIndex["grow_resis_sleep"]] = grades[dataIndex["grow_resis_sleep"]] + i
		sumGrades = sumGrades + i
		m = m - i
		delta = ( valueGrades[dataIndex["grow_resis_sleep"]][50] - valueGrades[dataIndex["grow_resis_sleep"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_resis_sleep"]][1] - delta
		output:UpdateData(0,dataIndex["grow_resis_sleep"], math.floor( ( v0 + grades[dataIndex["grow_resis_sleep"]] * delta ) *100)/100)
	end
	
	--//尽量加满silence
	local n = (gradesUpperLimit[gradeIndex["resis_silence"]]+output:QueryData(0,dataIndex["silence_rise"])) - grades[dataIndex["grow_resis_silence"]]
	if m > 0 and n > 0 then
		i = math.min(m,n)
		grades[dataIndex["grow_resis_silence"]] = grades[dataIndex["grow_resis_silence"]] + i
		sumGrades = sumGrades + i
		m = m - i
		delta = ( valueGrades[dataIndex["grow_resis_silence"]][50] - valueGrades[dataIndex["grow_resis_silence"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_resis_silence"]][1] - delta
		output:UpdateData(0,dataIndex["grow_resis_silence"], math.floor( ( v0 + grades[dataIndex["grow_resis_silence"]] * delta ) *100)/100)
	end
	
		
	--//尽量加满大攻
	local n = (gradesUpperLimit[gradeIndex["damage_high"]]+output:QueryData(0,dataIndex["maxattack_rise"])) - grades[dataIndex["grow_damage_high"]]
	if m > 0 and n > 0 then
		i = math.min(m,n)
		grades[dataIndex["grow_damage_high"]] = grades[dataIndex["grow_damage_high"]] + i
		sumGrades = sumGrades + i
		m = m - i
		delta = ( valueGrades[dataIndex["grow_damage_high"]][50] - valueGrades[dataIndex["grow_damage_high"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_damage_high"]][1] - delta
		output:UpdateData(0,dataIndex["grow_damage_high"], math.floor( ( v0 + grades[dataIndex["grow_damage_high"]] * delta ) *100)/100)
	end

	--//尽量加满小攻
	local n = (gradesUpperLimit[gradeIndex["damage_low"]]+output:QueryData(0,dataIndex["minattack_rise"])) - grades[dataIndex["grow_damage_low"]]
	if m > 0 and n > 0 then
		i = math.min(m,n)
		grades[dataIndex["grow_damage_low"]] = grades[dataIndex["grow_damage_low"]] + i
		sumGrades = sumGrades + i
		m = m - i
		delta = ( valueGrades[dataIndex["grow_damage_low"]][50] - valueGrades[dataIndex["grow_damage_low"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_damage_low"]][1] - delta
		output:UpdateData(0,dataIndex["grow_damage_low"], math.floor( ( v0 + grades[dataIndex["grow_damage_low"]] * delta ) *100)/100)
	end
	
	

	---重新评价法宝品级
	local quality = ZLuaTalGenerateQuality(id1, serverOrigins["combine"], grades, nGrades)
	output:UpdateData(0,dataIndex["quality"], quality)
	local clientOrigin = ZLuaTalGenerateClientOrigin(serverOrigins["combine"])
	output:UpdateData(0,dataIndex["origin"], clientOrigin)

	ZLuaTalRebuild(output,id1)
	
	
end

---使用灵媒之王和食物法宝，将法宝的主属性一次性喂满（debug使用）
function ZLuaTalDebugMaxGrade(talisman1,id1,cid,output)
	if cid ~= 22017 then return end
	local dataIndex, resisIndex = ZLuaTalDataIndex()
	local gradeIndex = ZLuaTalGradeIndex()
	local nGrades,valueGrades = ZLuaTalGrades()
	local gradesUpperLimit = ZLuaTalGradesUpperLimit(id1)
	local serverOrigins = ZLuaTalServerOrigins()

	output:CreateItem(id1)
	for _,index in pairs(dataIndex) do
		output:UpdateData(0,index,talisman1:QueryData(0,index))
	end

	output:UpdateData(0,dataIndex["hp_rise"],10)
	output:UpdateData(0,dataIndex["mp_rise"],10)
	output:UpdateData(0,dataIndex["minattack_rise"],10)
	output:UpdateData(0,dataIndex["maxattack_rise"],10)
	output:UpdateData(0,dataIndex["stun_rise"],10)
	output:UpdateData(0,dataIndex["weakness_rise"],10)
	output:UpdateData(0,dataIndex["enlace_rise"],10)
	output:UpdateData(0,dataIndex["silence_rise"],10)
	output:UpdateData(0,dataIndex["sleep_rise"],10)
	output:UpdateData(0,dataIndex["all_rise"],90)
	output:InheritCombineLevel(true)

	local grades = {}
	grades[dataIndex["default_hp"]] 						= ZLuaTalGetGradeFromValue(dataIndex["default_hp"],output)
	grades[dataIndex["default_mp"]] 						= ZLuaTalGetGradeFromValue(dataIndex["default_mp"],output)
	grades[dataIndex["default_damage_low"]] 		= ZLuaTalGetGradeFromValue(dataIndex["default_damage_low"],output)
	grades[dataIndex["default_damage_high"]] 		= ZLuaTalGetGradeFromValue(dataIndex["default_damage_high"],output)
	grades[dataIndex["default_resis_stun"]] 		= ZLuaTalGetGradeFromValue(dataIndex["default_resis_stun"],output)
	grades[dataIndex["default_resis_sleep"]] 		= ZLuaTalGetGradeFromValue(dataIndex["default_resis_sleep"],output)
	grades[dataIndex["default_resis_silence"]] 	= ZLuaTalGetGradeFromValue(dataIndex["default_resis_silence"],output)
	grades[dataIndex["default_resis_weakness"]] = ZLuaTalGetGradeFromValue(dataIndex["default_resis_weakness"],output)
	grades[dataIndex["default_resis_enlace"]] 	= ZLuaTalGetGradeFromValue(dataIndex["default_resis_enlace"],output)

	grades[dataIndex["grow_hp"]] 								= ZLuaTalGetGradeFromValue(dataIndex["grow_hp"],output)
	grades[dataIndex["grow_mp"]] 								= ZLuaTalGetGradeFromValue(dataIndex["grow_mp"],output)
	grades[dataIndex["grow_damage_low"]] 				= ZLuaTalGetGradeFromValue(dataIndex["grow_damage_low"],output)
	grades[dataIndex["grow_damage_high"]] 			= ZLuaTalGetGradeFromValue(dataIndex["grow_damage_high"],output)
	grades[dataIndex["grow_resis_stun"]] 				= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_stun"],output)
	grades[dataIndex["grow_resis_sleep"]] 			= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_sleep"],output)
	grades[dataIndex["grow_resis_silence"]] 		= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_silence"],output)
	grades[dataIndex["grow_resis_weakness"]] 		= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_weakness"],output)
	grades[dataIndex["grow_resis_enlace"]] 			= ZLuaTalGetGradeFromValue(dataIndex["grow_resis_enlace"],output)

	local sumGrades = 0
	sumGrades = sumGrades + grades[dataIndex["grow_hp"]]
	sumGrades = sumGrades + grades[dataIndex["grow_mp"]]
	sumGrades = sumGrades + grades[dataIndex["grow_damage_low"]]
	sumGrades = sumGrades + grades[dataIndex["grow_damage_high"]]
	sumGrades = sumGrades + grades[dataIndex["grow_resis_stun"]]
	sumGrades = sumGrades + grades[dataIndex["grow_resis_sleep"]]
	sumGrades = sumGrades + grades[dataIndex["grow_resis_silence"]]
	sumGrades = sumGrades + grades[dataIndex["grow_resis_weakness"]]
	sumGrades = sumGrades + grades[dataIndex["grow_resis_enlace"]]
	
	local i
	local m = (gradesUpperLimit[gradeIndex["all"]]+output:QueryData(0,dataIndex["all_rise"])) - sumGrades
	local delta
	local v0

	--//尽量加满真气
	local n = (gradesUpperLimit[gradeIndex["mp"]]+output:QueryData(0,dataIndex["mp_rise"])) - grades[dataIndex["grow_mp"]]
	if m > 0 and n > 0 then
		i = 0
		grades[dataIndex["grow_mp"]] = grades[dataIndex["grow_mp"]] + i
		sumGrades = sumGrades + i
		--//m = m - i
		delta = ( valueGrades[dataIndex["grow_mp"]][50] - valueGrades[dataIndex["grow_mp"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_mp"]][1] - delta
		output:UpdateData(0,dataIndex["grow_mp"], math.floor( 1 )/100)
	end
	--//尽量加满stun
	local n = (gradesUpperLimit[gradeIndex["resis_stun"]]+output:QueryData(0,dataIndex["stun_rise"])) - grades[dataIndex["grow_resis_stun"]]
	if m > 0 and n > 0 then
		i = math.min(m,n)
		grades[dataIndex["grow_resis_stun"]] = grades[dataIndex["grow_resis_stun"]] + i
		sumGrades = sumGrades + i
		m = m - i
		delta = ( valueGrades[dataIndex["grow_resis_stun"]][50] - valueGrades[dataIndex["grow_resis_stun"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_resis_stun"]][1] - delta
		output:UpdateData(0,dataIndex["grow_resis_stun"], math.floor( ( v0 + grades[dataIndex["grow_resis_stun"]] * delta ) *100)/100)
	end
	--//尽量加满sleep
	local n = (gradesUpperLimit[gradeIndex["resis_sleep"]]+output:QueryData(0,dataIndex["sleep_rise"])) - grades[dataIndex["grow_resis_sleep"]]
	if m > 0 and n > 0 then
		i = math.min(m,n)
		grades[dataIndex["grow_resis_sleep"]] = grades[dataIndex["grow_resis_sleep"]] + i
		sumGrades = sumGrades + i
		m = m - i
		delta = ( valueGrades[dataIndex["grow_resis_sleep"]][50] - valueGrades[dataIndex["grow_resis_sleep"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_resis_sleep"]][1] - delta
		output:UpdateData(0,dataIndex["grow_resis_sleep"], math.floor( ( v0 + grades[dataIndex["grow_resis_sleep"]] * delta ) *100)/100)
	end
	--//尽量加满silence
	local n = (gradesUpperLimit[gradeIndex["resis_silence"]]+output:QueryData(0,dataIndex["silence_rise"])) - grades[dataIndex["grow_resis_silence"]]
	if m > 0 and n > 0 then
		i = math.min(m,n)
		grades[dataIndex["grow_resis_silence"]] = grades[dataIndex["grow_resis_silence"]] + i
		sumGrades = sumGrades + i
		m = m - i
		delta = ( valueGrades[dataIndex["grow_resis_silence"]][50] - valueGrades[dataIndex["grow_resis_silence"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_resis_silence"]][1] - delta
		output:UpdateData(0,dataIndex["grow_resis_silence"], math.floor( ( v0 + grades[dataIndex["grow_resis_silence"]] * delta ) *100)/100)
	end
	--//尽量加满enlace
	local n = (gradesUpperLimit[gradeIndex["resis_enlace"]]+output:QueryData(0,dataIndex["enlace_rise"])) - grades[dataIndex["grow_resis_enlace"]]
	if m > 0 and n > 0 then
		i = math.min(m,n)
		grades[dataIndex["grow_resis_enlace"]] = grades[dataIndex["grow_resis_enlace"]] + i
		sumGrades = sumGrades + i
		m = m - i
		delta = ( valueGrades[dataIndex["grow_resis_enlace"]][50] - valueGrades[dataIndex["grow_resis_enlace"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_resis_enlace"]][1] - delta
		output:UpdateData(0,dataIndex["grow_resis_enlace"], math.floor( ( v0 + grades[dataIndex["grow_resis_enlace"]] * delta ) *100)/100)
	end
	--//尽量加满weakness
	local n = (gradesUpperLimit[gradeIndex["resis_weakness"]]+output:QueryData(0,dataIndex["weakness_rise"])) - grades[dataIndex["grow_resis_weakness"]]
	if m > 0 and n > 0 then
		i = math.min(m,n)
		grades[dataIndex["grow_resis_weakness"]] = grades[dataIndex["grow_resis_weakness"]] + i
		sumGrades = sumGrades + i
		m = m - i
		delta = ( valueGrades[dataIndex["grow_resis_weakness"]][50] - valueGrades[dataIndex["grow_resis_weakness"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_resis_weakness"]][1] - delta
		output:UpdateData(0,dataIndex["grow_resis_weakness"], math.floor( ( v0 + grades[dataIndex["grow_resis_weakness"]] * delta ) *100)/100)
	end
	--//尽量加满大攻
	local n = (gradesUpperLimit[gradeIndex["damage_high"]]+output:QueryData(0,dataIndex["maxattack_rise"])) - grades[dataIndex["grow_damage_high"]]
	if m > 0 and n > 0 then
		i = math.min(m,n)
		grades[dataIndex["grow_damage_high"]] = grades[dataIndex["grow_damage_high"]] + i
		sumGrades = sumGrades + i
		m = m - i
		delta = ( valueGrades[dataIndex["grow_damage_high"]][50] - valueGrades[dataIndex["grow_damage_high"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_damage_high"]][1] - delta
		output:UpdateData(0,dataIndex["grow_damage_high"], math.floor( ( v0 + grades[dataIndex["grow_damage_high"]] * delta ) *100)/100)
	end
	--//尽量加满气血
	local n = (gradesUpperLimit[gradeIndex["hp"]]+output:QueryData(0,dataIndex["hp_rise"])) - grades[dataIndex["grow_hp"]]
	if m > 0 and n > 0 then
		i = math.min(m,n)
		grades[dataIndex["grow_hp"]] = grades[dataIndex["grow_hp"]] + i
		sumGrades = sumGrades + i
		m = m - i
		delta = ( valueGrades[dataIndex["grow_hp"]][50] - valueGrades[dataIndex["grow_hp"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_hp"]][1] - delta
		output:UpdateData(0,dataIndex["grow_hp"], math.floor( ( v0 + grades[dataIndex["grow_hp"]] * delta ) *100)/100)
	end
	--//尽量加满小攻
	local n = (gradesUpperLimit[gradeIndex["damage_low"]]+output:QueryData(0,dataIndex["minattack_rise"])) - grades[dataIndex["grow_damage_low"]]
	if m > 0 and n > 0 then
		i = math.min(m,n)
		grades[dataIndex["grow_damage_low"]] = grades[dataIndex["grow_damage_low"]] + i
		sumGrades = sumGrades + i
		m = m - i
		delta = ( valueGrades[dataIndex["grow_damage_low"]][50] - valueGrades[dataIndex["grow_damage_low"]][1] ) / 49
		v0 = valueGrades[dataIndex["grow_damage_low"]][1] - delta
		output:UpdateData(0,dataIndex["grow_damage_low"], math.floor( ( v0 + grades[dataIndex["grow_damage_low"]] * delta ) *100)/100)
	end

	---重新评价法宝品级
	local quality = ZLuaTalGenerateQuality(id1, serverOrigins["combine"], grades, nGrades)
	output:UpdateData(0,dataIndex["quality"], quality)

	-- 新法宝测试技能用
	local debug_TalismanSkillIDs={}
	debug_TalismanSkillIDs[399]={399,1278,1279}---//_八卦石.ext
	debug_TalismanSkillIDs[400]={400,1292,1293}---//_六合镜.ext
	debug_TalismanSkillIDs[401]={401,1326,1327}---//_朱雀印.ext
	debug_TalismanSkillIDs[402]={402,1294,1295}---//_轮回珠.ext
	debug_TalismanSkillIDs[403]={403,1308,1309}---//_慑心铃.ext
	debug_TalismanSkillIDs[404]={404,1298,1299}---//_七星剑.ext
	debug_TalismanSkillIDs[405]={405,1318,1319}---//_四灵幡.ext
	debug_TalismanSkillIDs[406]={406,1284,1285}---//_金刚杵.ext
	debug_TalismanSkillIDs[407]={407,1280,1281}---//_多情环.ext
	debug_TalismanSkillIDs[408]={408,1306,1307}---//_山河扇.ext
	debug_TalismanSkillIDs[409]={409,1312,1313}---//_神木骰.ext
	debug_TalismanSkillIDs[410]={410,1320,1321}---//_万毒袋(万毒鼎).ext
	debug_TalismanSkillIDs[411]={411,1300,1301}---//_千醉坛(玉净瓶).ext
	debug_TalismanSkillIDs[860]={860,1282,1283}---//_琥珀朱绫.ext
	debug_TalismanSkillIDs[861]={861,1324,1325}---//_阴阳镜.ext
	debug_TalismanSkillIDs[862]={862,1296,1297}---//_蟠龙幡.ext
	debug_TalismanSkillIDs[863]={863,1286,1287}---//_金葫芦.ext
	debug_TalismanSkillIDs[864]={864,1290,1291}---//_莲花.ext
	debug_TalismanSkillIDs[865]={865,1302,1303}---//_乾坤青光戒.ext
	debug_TalismanSkillIDs[866]={866,1322,1323}---//_五龙轮.ext
	debug_TalismanSkillIDs[867]={867,1288,1289}---//_九龙神火罩.ext
	debug_TalismanSkillIDs[868]={868,1304,1305}---//_如意乾坤袋.ext
	debug_TalismanSkillIDs[869]={869,1310,1311}---//_摄魂.ext
	debug_TalismanSkillIDs[870]={870,1316,1317}---//_噬血珠.ext
	debug_TalismanSkillIDs[871]={871,1314,1315}---//_噬魂.ext
	debug_TalismanSkillIDs[1653]={1653,1654,1655}---//_玲珑塔.ext
	debug_TalismanSkillIDs[1697]={1697,1698,1699}---//赤金绫.ext
	debug_TalismanSkillIDs[1700]={1700,1701,1702}---//_轮回盘.ext
	debug_TalismanSkillIDs[1703]={1703,1704,1705}---//_乾坤锁.ext
	debug_TalismanSkillIDs[1706]={1706,1707,1708}---//幽冥鬼手_.ext
	debug_TalismanSkillIDs[1738]={1738,1739,1740}---//七星印.ext
	debug_TalismanSkillIDs[1753]={1753,1754,1755}---//真山河扇.ext
	debug_TalismanSkillIDs[1806]={1806,1807,1808}---//血玉骨片.ext
	debug_TalismanSkillIDs[1809]={1809,1810,1811}---//破刹.ext
	debug_TalismanSkillIDs[1812]={1812,1813,1814}---//千毒蛊.ext
	debug_TalismanSkillIDs[1815]={1815,1816,1817}---//鬼罄.ext
	debug_TalismanSkillIDs[2037]={2037,2038,2039}---//_翻天印.ext
	debug_TalismanSkillIDs[2153]={2153,2154,2155}---//长明灯
	debug_TalismanSkillIDs[2598]={2598,2599,2600}---//日月宝鉴
	debug_TalismanSkillIDs[3088]={3088,3088,3088}---//元宵灯
	debug_TalismanSkillIDs[3162]={3162,3163,3164}---//浮屠
	debug_TalismanSkillIDs[3391]={3391,3392,3393}---//引魂幡
	debug_TalismanSkillIDs[3825]={3825,3826,3827}---//宝库之魂
	debug_TalismanSkillIDs[32954]={32954,32955,32956}---//天琊.ext

	debug_TalismanSkillIDs[3610]={3610,3611,3612}---//引魂幡
	debug_TalismanSkillIDs[3613]={3613,3614,3615}---//引魂幡
	debug_TalismanSkillIDs[3616]={3616,3617,3618}---//引魂幡
	debug_TalismanSkillIDs[3619]={3619,3620,3621}---//引魂幡
	debug_TalismanSkillIDs[3622]={3622,3623,3624}---//引魂幡
	debug_TalismanSkillIDs[3625]={3625,3626,3627}---//引魂幡
	debug_TalismanSkillIDs[3628]={3628,3629,3630}---//引魂幡
	debug_TalismanSkillIDs[3631]={3631,3632,3633}---//引魂幡
	debug_TalismanSkillIDs[3634]={3634,3635,3636}---//引魂幡
	debug_TalismanSkillIDs[3943]={3943,3944,3945}---//怀光
	debug_TalismanSkillIDs[3946]={3946,3947,3948}---//怀光
	debug_TalismanSkillIDs[3949]={3949,3950,3951}---//怀光
	debug_TalismanSkillIDs[3952]={3952,3953,3954}---//怀光
	debug_TalismanSkillIDs[3955]={3955,3956,3957}---//天华
	debug_TalismanSkillIDs[3958]={3958,3959,3960}---//天华
	debug_TalismanSkillIDs[3961]={3961,3962,3963}---//天华
	debug_TalismanSkillIDs[3964]={3964,3965,3966}---//天华

	debug_TalismanSkillIDs[33347]={33347,33348,33349}---//焚香
	debug_TalismanSkillIDs[33350]={33350,33351,33352}---//焚香
	debug_TalismanSkillIDs[33353]={33353,33354,33355}---//焚香
	debug_TalismanSkillIDs[33356]={33356,33357,33358}---//焚香
	debug_TalismanSkillIDs[33359]={33359,33360,33361}---//太昊
	debug_TalismanSkillIDs[33362]={33362,33363,33364}---//太昊
	debug_TalismanSkillIDs[33365]={33365,33366,33367}---//太昊
	debug_TalismanSkillIDs[33368]={33368,33369,33370}---//太昊
	debug_TalismanSkillIDs[34015]={34015,34016,34017}---//辰皇
	debug_TalismanSkillIDs[34018]={34018,34019,34020}---//辰皇
	debug_TalismanSkillIDs[34021]={34021,34022,34023}---//辰皇
	debug_TalismanSkillIDs[34024]={34024,34025,34026}---//辰皇

	debug_TalismanSkillIDs[34662]={34662,34663,34664}---//灵族

	debug_TalismanSkillIDs[34667]={34667,34668,34669}---//牵机
	debug_TalismanSkillIDs[34672]={34672,34673,34674}---//牵机
	debug_TalismanSkillIDs[34677]={34677,34678,34679}---//牵机
	debug_TalismanSkillIDs[34682]={34682,34683,34684}---//牵机
	debug_TalismanSkillIDs[34687]={34687,34688,34689}---//英招
	debug_TalismanSkillIDs[34692]={34692,34693,34694}---//英招
	debug_TalismanSkillIDs[34697]={34697,34698,34699}---//英招
	debug_TalismanSkillIDs[34702]={34702,34703,34704}---//英招

  	debug_TalismanSkillIDs[33723]={33723,33724,33725}---//八卦神掌_八卦石.ext
  	debug_TalismanSkillIDs[33729]={33729,33730,33731}---//六合纵横_六合镜.ext
  	debug_TalismanSkillIDs[33732]={33732,33733,33734}---//烈焰血雨_朱雀印.ext
  	debug_TalismanSkillIDs[33735]={33735,33736,33737}---//法海轮回_轮回珠.ext
  	debug_TalismanSkillIDs[33738]={33738,33739,33740}---//摄魂夺魄_慑心铃.ext
  	debug_TalismanSkillIDs[33765]={33765,33766,33767}---//流星赶月_七星剑.ext
  	debug_TalismanSkillIDs[33768]={33768,33769,33770}---//四灵血咒_四灵幡.ext
  	debug_TalismanSkillIDs[33771]={33771,33772,33773}---//金刚降魔_金刚杵.ext
  	debug_TalismanSkillIDs[33774]={33774,33775,33776}---//刹那芳华_多情环.ext
  	debug_TalismanSkillIDs[33879]={33879,33880,33881}---//江山如画_山河扇.ext
  	debug_TalismanSkillIDs[33873]={33873,33874,33875}---//否极泰来_神木骰.ext
  	debug_TalismanSkillIDs[33882]={33882,33883,33884}---//万毒噬天_万毒袋(万毒鼎).ext
  	debug_TalismanSkillIDs[33885]={33885,33886,33887}---//玉净天华_千醉坛(玉净瓶).ext
  	debug_TalismanSkillIDs[33801]={33801,33802,33803}---//千绫绚舞_琥珀朱绫.ext
  	debug_TalismanSkillIDs[33900]={33900,33901,33902}---//阴阳相生_阴阳镜.ext
  	debug_TalismanSkillIDs[33912]={33912,33913,33914}---//虬龙烈炎_蟠龙幡.ext
  	debug_TalismanSkillIDs[33897]={33897,33898,33899}---//方寸乾坤_金葫芦.ext
  	debug_TalismanSkillIDs[33810]={33810,33811,33812}---//暗香无际_莲花.ext
  	debug_TalismanSkillIDs[33804]={33804,33805,33806}---//青光乍现_乾坤青光戒.ext
  	debug_TalismanSkillIDs[33915]={33915,33916,33917}---//五龙御天_五龙轮.ext
  	debug_TalismanSkillIDs[33894]={33894,33895,33896}---//炼狱神火_九龙神火罩.ext
  	debug_TalismanSkillIDs[33807]={33807,33808,33809}---//乾坤如意_如意乾坤袋.ext
  	debug_TalismanSkillIDs[33930]={33930,33931,33932}---//摄魂心驰_摄魂.ext
  	debug_TalismanSkillIDs[33933]={33933,33934,33935}---//噬血邪灵_噬血珠.ext
  	debug_TalismanSkillIDs[33936]={33936,33937,33938}---//噬魂无双_噬魂.ext
  --	TalismanSkillIDs[1653]={1653,1654,1655,33888,33889,33890}---//宝塔镇河妖_玲珑塔.ext
  	debug_TalismanSkillIDs[33846]={33846,33847,33848}---//梦令之澜_赤金绫.ext
  	debug_TalismanSkillIDs[33843]={33843,33844,33845}---//寂灭天舞_轮回盘.ext
  	debug_TalismanSkillIDs[33837]={33837,33838,33839}---//尘光叹妙_乾坤锁.ext
  	debug_TalismanSkillIDs[33840]={33840,33841,33842}---//鬼域幽歌_幽冥鬼手_.ext
  	debug_TalismanSkillIDs[33903]={33903,33904,33905}---//华彰星陨_七星印.ext
  	debug_TalismanSkillIDs[33906]={33906,33907,33908}---//逍遥如梦_真山河扇.ext
  	debug_TalismanSkillIDs[33741]={33741,33742,33743}---//碎玉幻天_血玉骨片.ext
  	debug_TalismanSkillIDs[33777]={33777,33778,33779}---//绝戾华光_破刹.ext
  	debug_TalismanSkillIDs[33813]={33813,33814,33815}---//死亡波纹_千毒蛊.ext
  	debug_TalismanSkillIDs[33849]={33849,33850,33851}---//迷踪之寂_鬼罄.ext
  	debug_TalismanSkillIDs[33918]={33918,33919,33920}---//五岳咸服_翻天印.ext
  	debug_TalismanSkillIDs[33921]={33921,33922,33923}---//寒月镇潭_长明灯
  	debug_TalismanSkillIDs[33891]={33891,33892,33893}---//大凡若简_日月宝鉴
  --	TalismanSkillIDs[3088]={3088,3088,3088}---//元宵灯祝_元宵灯
  	debug_TalismanSkillIDs[33909]={33909,33910,33911}---//圣塔降魔_浮屠
  	debug_TalismanSkillIDs[33924]={33924,33925,33926}---//白骨之咒_引魂幡
  	debug_TalismanSkillIDs[33927]={33927,33928,33929}---//碧天宇华_宝库之魂
  	debug_TalismanSkillIDs[33939]={33939,33940,33941}---//天琊绝世_天琊.ext
  
  	debug_TalismanSkillIDs[33726]={33726,33727,33728}---//万彩画一_神裔
  	debug_TalismanSkillIDs[33747]={33747,33748,33749}---//驱虎逐豹_九黎
  	debug_TalismanSkillIDs[33783]={33783,33784,33785}---//枫林煞血_九黎
  	debug_TalismanSkillIDs[33819]={33819,33820,33821}---//狂澜灭杀_九黎
  	debug_TalismanSkillIDs[33855]={33855,33856,33857}---//亡魂丧魄_九黎
  	debug_TalismanSkillIDs[33750]={33750,33751,33752}---//月影丹朱_烈山
  	debug_TalismanSkillIDs[33786]={33786,33787,33788}---//夺魄返魂_烈山
  	debug_TalismanSkillIDs[33822]={33822,33823,33824}---//浮光阑影_烈山
  	debug_TalismanSkillIDs[33858]={33858,33859,33860}---//曦皇神威_烈山
  	debug_TalismanSkillIDs[33753]={33753,33754,33755}---//血杀千里_怀光
  	debug_TalismanSkillIDs[33789]={33789,33790,33791}---//横扫千军_怀光
  	debug_TalismanSkillIDs[33825]={33825,33826,33827}---//破魂千劫_怀光
  	debug_TalismanSkillIDs[33861]={33861,33862,33863}---//婆娑影皇_怀光
  	debug_TalismanSkillIDs[33756]={33756,33757,33758}---//琼华天籁_天华
  	debug_TalismanSkillIDs[33792]={33792,33793,33794}---//苍穹凤歌_天华
  	debug_TalismanSkillIDs[33828]={33828,33829,33830}---//宇光蓬莱_天华
  	debug_TalismanSkillIDs[33864]={33864,33865,33866}---//天魔降伏_天华
  
  	debug_TalismanSkillIDs[33744]={33744,33745,33746}---//业火天阳_焚香
  	debug_TalismanSkillIDs[33780]={33780,33781,33782}---//天地玄极_焚香
  	debug_TalismanSkillIDs[33816]={33816,33817,33818}---//凌火明阳_焚香
  	debug_TalismanSkillIDs[33852]={33852,33853,33854}---//太幽玄冰_焚香
  	debug_TalismanSkillIDs[33759]={33759,33760,33761}---//刑天怒雷_太昊
  	debug_TalismanSkillIDs[33795]={33795,33796,33797}---//殇落流华_太昊
  	debug_TalismanSkillIDs[33831]={33831,33832,33833}---//子午心魂_太昊
  	debug_TalismanSkillIDs[33867]={33867,33868,33869}---//浩气云天_太昊
		debug_TalismanSkillIDs[33762]={33762,33763,33764}---//辰皇一级_辰皇
		debug_TalismanSkillIDs[33798]={33798,33799,33800}---//辰皇二级_辰皇
		debug_TalismanSkillIDs[33834]={33834,33835,33836}---//辰皇三级_辰皇
		debug_TalismanSkillIDs[33870]={33870,33871,33872}---//辰皇四级_辰皇

		debug_TalismanSkillIDs[34803]={34803,34804,34805}---//灵族新手_灵族

  	debug_TalismanSkillIDs[34807]={34807,34808,34809}---//牵机一级_牵机
  	debug_TalismanSkillIDs[34811]={34811,34812,34813}---//牵机二级_牵机
  	debug_TalismanSkillIDs[34815]={34815,34816,34817}---//牵机三级_牵机
  	debug_TalismanSkillIDs[34819]={34819,34820,34821}---//牵机四级_牵机
		debug_TalismanSkillIDs[34823]={34823,34824,34825}---//英招一级_英招
		debug_TalismanSkillIDs[34827]={34827,34828,34829}---//英招二级_英招
		debug_TalismanSkillIDs[34831]={34831,34832,34833}---//英招三级_英招
		debug_TalismanSkillIDs[34835]={34835,34836,34837}---//英招四级_英招

	local skill_addon_id = output:QueryData(0,dataIndex["skill_addon_id"])
	local skill_addon_id_new
	for _,v in pairs(debug_TalismanSkillIDs) do
		if v[1] == skill_addon_id or v[2] == skill_addon_id then
			skill_addon_id = v[3]
		end
	end
	output:UpdateData(0,dataIndex["skill_addon_id"],skill_addon_id)
	output:UpdateData(0,dataIndex["skillrefine_level"],3)

	ZLuaTalRebuild(output,id1)
end


---用于把法宝具体成长率翻译为档位数，与GetGradeFromValue所不同的是，本函数会把负的成长率翻译为负的档位数，而不是1
function ZLuaTalDebugGetGradeFromValue(index, talisman)
	local nGrades, valueGrades = ZLuaTalGrades()
	local delta = ( valueGrades[index][50] - valueGrades[index][1] ) / 49
	local v0 = valueGrades[index][1] - delta
	if talisman:QueryData(0,index) < v0 + ( -99 * delta ) then
		return -100
	end
	if talisman:QueryData(0,index) >= v0 + ( 100 * delta ) then
		return 100
	end
	for i = -100, 100 do
		if talisman:QueryData(0,index) < v0 + ( i * delta ) then
			return i
		end
	end
	return -200
end

----把向性对应的Index值转化为DataIndex值
function ZluaTransRiseIndex(growdirection)
	if growdirection==18 then return 83 end
	if growdirection==19 then return 84 end
	if growdirection==21 then return 85 end
	if growdirection==22 then return 86 end
	if growdirection==25 then return 87 end
	if growdirection==26 then return 91 end
	if growdirection==27 then return 90 end
	if growdirection==28 then return 88 end
	if growdirection==29 then return 89	end
	return 0
end

-- 注册所有法宝和飞宝(飞剑、圣灵和羽翼)
for _,tal in pairs( ZLuaTalAvailableTalismans() ) do
	AddTalismanItem(tal.tmplID, ZLuaTalInit,ZLuaTalLevelup,ZLuaTalReset)
end
