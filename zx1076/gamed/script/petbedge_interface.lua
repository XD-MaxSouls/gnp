--[[
//����³�����Ҫ���õ�������

1.�趨�Ϸ�����
ZLuaAvailablePets()

--]]

---��ǰ�Ϸ�����ID----//�˴�������------------------------------------------------------------
function ZLuaAvailablePets()
	local AvailablePets={}
	local Race=ZLuaPetBedgeRaceDesc()
	local Element=ZLuaPetBedgeElementDesc()
	local Horoscope=ZLuaPetBedgeHoroscopeDesc()
	
	AvailablePets["TestPet"]=
	{pet_tid=15782,	race=Race["renzu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}---//����1
	---//�Ƿ���������������Ƿ��������/�������Ƿ���Է������Ƿ�������ɳ�����ʼ�ļٵ�λ
	 
	AvailablePets["TestPet2"]=
	{pet_tid=15843,race=Race["dijing"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}---//����2

	AvailablePets["conglinshanzhu"]=
	{pet_tid=16503,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=22992,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//����ɽ��(Ұ��)
	
	AvailablePets["beimingshuyao"]=
	{pet_tid=16504,race=Race["shanjing"],
	crit=0.01,critdmg=1.1,spirit_id=22993,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//��ڤ����(ɽ��)
	
	AvailablePets["bingyuanxuexiong"]=
	{pet_tid=16505,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=22994,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//��ԭѩ��(Ұ��)
	
	AvailablePets["meixindiejing"]=
	{pet_tid=16506,race=Race["meizu"],
	crit=0.01,critdmg=1.1,spirit_id=22995,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//���ĵ���(����)
	
	AvailablePets["songcaijinshu"]=
	{pet_tid=16507,race=Race["yishou"],
	crit=0.01,critdmg=1.1,spirit_id=22996,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�Ͳƽ���(����)

	AvailablePets["shouhushiling"]=
	{pet_tid=16508,race=Race["yuansu"],
	crit=0.01,critdmg=1.1,spirit_id=22997,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�ػ�ʯ��(Ԫ��)

	AvailablePets["yiyujingling"]=
	{pet_tid=18306,race=Race["huanling"],
	crit=0.01,critdmg=1.1,spirit_id=22998,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//������(����)
	
	AvailablePets["Q_conglinshanzhu"]=
	{pet_tid=18385,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=22992,
	combine_able=1,fixage_able=1,free_able=0,
	changefigure_able=1,default_potential=1,born_special=0}	---//����ɽ��(Ұ��)(����)
	
	AvailablePets["Q_beimingshuyao"]=
	{pet_tid=18386,race=Race["shanjing"],
	crit=0.01,critdmg=1.1,spirit_id=22993,
	combine_able=1,fixage_able=1,free_able=0,
	changefigure_able=1,default_potential=1,born_special=0}	---//��ڤ����(ɽ��)(����)

	AvailablePets["Q_shouhushiling"]=
	{pet_tid=18798,race=Race["yuansu"],
	crit=0.01,critdmg=1.1,spirit_id=22997,
	combine_able=1,fixage_able=1,free_able=0,
	changefigure_able=1,default_potential=1,born_special=0}	---//�ػ�ʯ��(Ԫ��)(����)	

	AvailablePets["S_luxueqi"]=
	{pet_tid=18416,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=30,born_special=15}	---//½ѩ��(����)(�ض�)	
	
	AvailablePets["S_luxueqi2"]=
	{pet_tid=21773,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=30,born_special=15}	---//½ѩ��(����2)(�ض�)	

	AvailablePets["Q_heyangqingwa"]=
	{pet_tid=18818,race=Race["shuizu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=1,free_able=1,
	changefigure_able=0,default_potential=1,born_special=0}	---//��������(ˮ��)(����/ʳ���)	
	
	AvailablePets["Q_heyangyelang"]=
	{pet_tid=18819,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=1,free_able=1,
	changefigure_able=0,default_potential=1,born_special=0}	---//����Ұ��(Ұ��)(����/ʳ���)	

	AvailablePets["sancaiyaozhu"]=
	{pet_tid=18929,race=Race["yaozu"],
	crit=0.01,critdmg=1.1,spirit_id=22999,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//��������(����)	

	AvailablePets["poliudijing"]=
	{pet_tid=19263,race=Race["xianling"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�����ؾ�(����)	
	
	AvailablePets["miaochihuangniao"]=
	{pet_tid=19510,race=Race["yuzu"],
	crit=0.01,critdmg=1.1,spirit_id=23000,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//������(����)	

	AvailablePets["caiyihuangniao"]=
	{pet_tid=20108,race=Race["yuzu"],
	crit=0.01,critdmg=1.1,spirit_id=23001,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�������(����)	

	AvailablePets["huanmoshuling"]=
	{pet_tid=19110,race=Race["huanling"],
	crit=0.01,critdmg=1.1,spirit_id=23002,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//��ħ����(����)		
	
	AvailablePets["xianjielinghou"]=
	{pet_tid=20488,race=Race["xianling"],
	crit=0.01,critdmg=1.1,spirit_id=23003,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�ɽ����(����)
	
	AvailablePets["shashouzhixie"]=
	{pet_tid=20489,race=Race["chonggu"],
	crit=0.01,critdmg=1.1,spirit_id=23004,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//ɱ��֮Ы(���)			
	
	AvailablePets["zhanshenyanmo"]=
	{pet_tid=20561,race=Race["yuansu"],
	crit=0.01,critdmg=1.1,spirit_id=23005,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=0,default_potential=1,born_special=0}	---//ս����ħ(Ԫ��)		
	
	AvailablePets["shengdanxueren"]=
	{pet_tid=22105,race=Race["xianling"],
	crit=0.01,critdmg=1.1,spirit_id=23006,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//ʥ��ѩ��(����)		
	
	AvailablePets["yuegongyutu"]=
	{pet_tid=22484,race=Race["xianling"],
	crit=0.01,critdmg=1.1,spirit_id=23007,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�¹�����(����)		
	
	AvailablePets["menghuanmaonv"]=
	{pet_tid=21247,race=Race["yaozu"],
	crit=0.01,critdmg=1.1,spirit_id=23008,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�λ�èŮ(����)		

	AvailablePets["S_biyao"]=
	{pet_tid=19124,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=30,born_special=15}	---//����(����)(�ض�)	
	
	AvailablePets["S_kuilei01"]=
	{pet_tid=22431,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=30,born_special=15}	---//���ؾ���(����)(�ض�)	
	
	AvailablePets["S_kuilei02"]=
	{pet_tid=22432,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=30,born_special=15}	---//��������(����)(�ض�)	
	
	AvailablePets["S_kuilei03"]=
	{pet_tid=22433,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=30,born_special=15}	---//����(����)(�ض�)	
	
	AvailablePets["S_kuilei04"]=
	{pet_tid=22434,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=30,born_special=15}	---//��������(����)(�ض�)	
	
	AvailablePets["S_kuilei05"]=
	{pet_tid=22435,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=30,born_special=15}	---//�������(����)(�ض�)	
	
	AvailablePets["S_kuilei06"]=
	{pet_tid=22436,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=30,born_special=15}	---//����(����)(�ض�)	

	AvailablePets["S_kuilei07"]=
	{pet_tid=22437,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=30,born_special=15}	---//������(����)(�ض�)	
	
	AvailablePets["baihu"]=
	{pet_tid=23337,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=23338,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�׻�(Ұ��)
	
	AvailablePets["N_shouhushiling"]=
	{pet_tid=24650,race=Race["yuansu"],
	crit=0.01,critdmg=1.1,spirit_id=22997,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//Ť���ػ�ʯ��(Ұ��)
	
	AvailablePets["G_conglinshanzhu"]=
	{pet_tid=24781,race=Race["shanjing"],
	crit=0.01,critdmg=1.1,spirit_id=25283,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//����ɽ��(���)
	
	AvailablePets["H_shouhushiling"]=
	{pet_tid=25117,race=Race["yuansu"],
	crit=0.01,critdmg=1.1,spirit_id=22997,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�����ػ�ʯ��(Ұ��)
	
	AvailablePets["H_songcaijinshu"]=
	{pet_tid=25118,race=Race["yishou"],
	crit=0.01,critdmg=1.1,spirit_id=22996,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�����Ͳƽ���(����)
	
	AvailablePets["sanyanlinghou"]=
	{pet_tid=25124,race=Race["xianling"],
	crit=0.01,critdmg=1.1,spirit_id=25125,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�������(����)
	
	AvailablePets["Z_baihu"]=
	{pet_tid=25234,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=23338,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//ս���׻�(Ұ��)
	
	AvailablePets["maozei"]=
	{pet_tid=25311,race=Race["yaozu"],
	crit=0.01,critdmg=1.1,spirit_id=25391,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//è��(����)	
	
	AvailablePets["cairen_1"]=
	{pet_tid=28557,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=0,default_potential=1,born_special=0}	---//����1(����)(�ض�)	
	
	AvailablePets["cairen_2"]=
	{pet_tid=28558,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=0,default_potential=1,born_special=0}	---//����2(����)(�ض�)	
	
	AvailablePets["cairen_3"]=
	{pet_tid=28559,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=0,default_potential=1,born_special=0}	---//����3(����)(�ض�)	
	
	AvailablePets["cairen_4"]=
	{pet_tid=28560,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=0,default_potential=1,born_special=0}	---//����4(����)(�ض�)	
	
	AvailablePets["cairen_5"]=
	{pet_tid=28561,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=0,default_potential=1,born_special=0}	---//����5(����)(�ض�)
	
	AvailablePets["fuwang"]=
	{pet_tid=33448,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=0,default_potential=1,born_special=0}	---//����
	
	AvailablePets["dahuilang"]=
	{pet_tid=25422,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�����(Ұ��)
	
	AvailablePets["dahuilang2"]=
	{pet_tid=34054,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�����2(Ұ��)	
	
	
	AvailablePets["xiaomianyang"]=
	{pet_tid=25421,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//С����(Ұ��)
	
	AvailablePets["zhanshenxingxing"]=
	{pet_tid=25385,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//09���PK������������(Ұ��)

	AvailablePets["huli"]=
	{pet_tid=29992,race=Race["yishou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=25,born_special=15}	---//����(�������͸��ǵ�)

--[[
	AvailablePets["huli"]=
	{pet_tid=29992,race=Race["yishou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=1,born_special=0}	---//����(�������͸��ǵ�)
--]]
	
	AvailablePets["huli2"]=
	{pet_tid=33146,race=Race["yishou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//����(����)

	AvailablePets["dahuang"]=
	{pet_tid=29993,race=Race["xianling"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//���(����)
	
	AvailablePets["songshu"]=
	{pet_tid=29994,race=Race["shanjing"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//����(ɽ��)
	
	AvailablePets["xiongmao"]=
	{pet_tid=29995,race=Race["yishou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//��è(����)
	
	AvailablePets["lu"]=
	{pet_tid=29996,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//¹(Ұ��)
	
	AvailablePets["nainiu"]=
	{pet_tid=29997,race=Race["yishou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//��ţ(����)		
	
	AvailablePets["datouwawa"]=
	{pet_tid=30988,race=Race["yaozu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//��ͷ����(����)	
	
	AvailablePets["panguan"]=
	{pet_tid=30989,race=Race["siling"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�й�(����)	
	
	AvailablePets["maotouying"]=
	{pet_tid=30990,race=Race["shanjing"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//èͷӥ(ɽ��)	
	
	AvailablePets["yanmo"]=
	{pet_tid=30991,race=Race["yuansu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//��ħ(Ԫ��)	
	
	AvailablePets["zx2libaochong"]=
	{pet_tid=31463,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=20,born_special=15}	---//����2�����(����)
	
	AvailablePets["qingtianzhanhun"]=
	{pet_tid=32118,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=40,born_special=15}	---//�������������(����)	
	
	AvailablePets["xinshoukabaihu"]=
	{pet_tid=33280,race=Race["yishou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=25,born_special=15}	---//�׻�(������������)
	
	AvailablePets["�߹�"]=
	{pet_tid=33522,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=20,born_special=15}	---//�߹�(����)
	
	AvailablePets["qingrenjielaohu"]=
	{pet_tid=34069,race=Race["yishou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=25,born_special=15}	---//���˽��ϻ�(��ɫ���˽����ֿ�����)
	
	AvailablePets["qiubite"]=
	{pet_tid=34126,race=Race["xianling"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//����أ����飩
	
	AvailablePets["yecha"]=
	{pet_tid=34214,race=Race["shuizu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//��۱������-ҹ��(ˮ��)
	
	AvailablePets["shuangmianguai"]=
	{pet_tid=34215,race=Race["yaozu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//��������������-˫���(����)
	
	AvailablePets["pangtouyu"]=
	{pet_tid=34289,race=Race["shuizu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//��ͷ��(ˮ��)
	
	AvailablePets["guangminghuo"]=
	{pet_tid=40541,race=Race["yuansu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//������(Ԫ��)
	
	AvailablePets["meiqijingling"]=
	{pet_tid=40631,race=Race["yuansu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//���澫��(Ԫ��)
	
	AvailablePets["leishe"]=
	{pet_tid=40665,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//����(Ұ��)
	
		AvailablePets["beimeixiniu"]=
	{pet_tid=40863,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//����Ϭţ(Ұ��)
	
		AvailablePets["beimeikuiniu"]=
	{pet_tid=40864,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//������ţ(Ұ��)
	
		AvailablePets["beimeizhizhu"]=
	{pet_tid=40865,race=Race["yaozu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//����֩��(����)
	
		AvailablePets["beimeisantouquan"]=
	{pet_tid=40866,race=Race["teshu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//������ͷȮ(����)
	
		AvailablePets["beimeirenshenwawa"]=
	{pet_tid=40867,race=Race["xianling"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�����˲�����(����)
	
		AvailablePets["beimeiqie"]=
	{pet_tid=40868,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�������(Ұ��)
	
		AvailablePets["beimeihuolong"]=
	{pet_tid=40869,race=Race["yishou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//��������(����)
	
		AvailablePets["beimeidaxiang"]=
	{pet_tid=40870,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//��������(Ұ��)
	
	AvailablePets["yudigege"]=
	{pet_tid=41166,race=Race["renzu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=24,born_special=15}	---//���۸��(����)
	
	AvailablePets["aifei"]=
	{pet_tid=41167,race=Race["renzu"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=24,born_special=15}	---//����(����)
	
	AvailablePets["zhenyumoxie"]=
	{pet_tid=41261,race=Race["chonggu"],
	crit=0.01,critdmg=1.1,spirit_id=23004,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//����ħЫ(���)	
	
	AvailablePets["guanghanyutu"]=
	{pet_tid=41262,race=Race["xianling"],
	crit=0.01,critdmg=1.1,spirit_id=23007,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�㺮����(����)	

	AvailablePets["2010taotie"]=
	{pet_tid=41928,race=Race["xianling"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//2010���pk����������_���ѣ����飩
	
	AvailablePets["1123linghu"]=
	{pet_tid=41782,race=Race["xianling"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=25,born_special=15}	---//���(����)	
	
	AvailablePets["1123yuty"]=
	{pet_tid=41783,race=Race["xianling"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=25,born_special=15}---//����(����)

	AvailablePets["1123feitianbaihu"]=
	{pet_tid=41784,race=Race["yishou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=25,born_special=15}---//����׻�(����)
	
	AvailablePets["1123zhandimenghu"]=
	{pet_tid=41785,race=Race["yishou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=25,born_special=15}---//ս���ͻ�(����)
	
	AvailablePets["chongwuzhangyu"]=
	{pet_tid=42683,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}---//20100118�������㣨Ұ�ޣ�
	
	AvailablePets["2011kuiniu"]=
	{pet_tid=43404,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//2011��Ը��ţ(Ұ��)
	
	AvailablePets["vipdaxiang"]=
	{pet_tid=43405,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//vip����(Ұ��)
	
	AvailablePets["20110524renshenwawa"]=
	{pet_tid=43254,race=Race["xianling"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}	---//�����˲�����(����)
	
	AvailablePets["20110524feitianbaihu"]=
	{pet_tid=44162,race=Race["xianling"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=25,born_special=15}	---//20110524����׻�(����)
	
	AvailablePets["20110524guanghanyutu"]=
	{pet_tid=44163,race=Race["xianling"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=25,born_special=15}	---//20110524�㺮����(����)
	
	AvailablePets["20110524bingyuanxuexiong"]=
	{pet_tid=44164,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=25,born_special=15}	---//20110524��ԭѩ��(Ұ��)
	
	AvailablePets["20110524kuiniu"]=
	{pet_tid=44246,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=0,fixage_able=0,free_able=0,
	changefigure_able=0,default_potential=25,born_special=15}	---//20110524VIP��ţ(Ұ��)
	
	AvailablePets["20100621qie"]=
	{pet_tid=44644,race=Race["yeshou"],
	crit=0.01,critdmg=1.1,spirit_id=0,
	combine_able=1,fixage_able=1,free_able=1,
	changefigure_able=1,default_potential=1,born_special=0}		---//20110621��죨Ұ�ޣ�
	
	return AvailablePets
end 
---����data��������----------------------------------------------------------------------------
function ZLuaPetBedgeDataIndex()
	local DataIndex={}
		DataIndex["blank"]												= 0
		DataIndex["id"]														= 1
		DataIndex["star"]													= 2
		DataIndex["maintype"]											= 3
		DataIndex["element"]											= 4
		DataIndex["identify"]											= 5
		DataIndex["race"]													= 6
		DataIndex["horoscope"]										= 7
		DataIndex["extradamage"]									= 8
		DataIndex["extradamagereduce"]						= 9
		DataIndex["maxhunger"]										= 10
		DataIndex["curhunger"]										= 11	
		DataIndex["maxhonor"]											= 12
		DataIndex["curhonor"]											= 13		
		DataIndex["critrate"]											= 14
		DataIndex["critdamage"]										= 15
		DataIndex["nativecritrate"]								= 16
		DataIndex["nativecritdamage"]							= 17			
		DataIndex["age"]													= 18
		DataIndex["life"]													= 19
		DataIndex["acuity"]												= 20
		DataIndex["stamina"]											= 21
		DataIndex["sawy"]													= 22
		DataIndex["dowry"]												= 23
		DataIndex["wisdom"]												= 24
		DataIndex["cnr"]													= 25
		DataIndex["face"]													= 26
		DataIndex["shape"]												= 27
		DataIndex["isgrowup"]											= 28
		DataIndex["isaberrant"]										= 29
		DataIndex["orign"]												= 30
		DataIndex["nativeorigin"]									= 31
		DataIndex["default_hp"]										= 32		---0
		DataIndex["default_mp"]										= 33		---1
		DataIndex["default_minatk"]								= 34		---2
		DataIndex["default_maxatk"]								= 35		---3
		DataIndex["default_def"]									= 36		---4
		DataIndex["default_attackrate"]						= 37		---5
		DataIndex["default_dodge"]								= 38		---6
		DataIndex["default_resist1"]							= 39		---7
		DataIndex["default_resist2"]							= 40		---8
		DataIndex["default_resist3"]							= 41		---9
		DataIndex["default_resist4"]							= 42		---10
		DataIndex["default_resist5"]							= 43		---11
		DataIndex["default_resist6"]							= 44		---12
		DataIndex["potential_hp"]									= 45		---0
		DataIndex["potential_mp"]									= 46		---1
		DataIndex["potential_minatk"]							= 47		---2
		DataIndex["potential_maxatk"]							= 48		---3
		DataIndex["potential_def"]								= 49		---4
		DataIndex["potential_attackrate"]					= 50		---5
		DataIndex["potential_dodge"]							= 51		---6
		DataIndex["potential_resist1"]						= 52		---7
		DataIndex["potential_resist2"]						= 53		---8
		DataIndex["potential_resist3"]						= 54		---9
		DataIndex["potential_resist4"]						= 55		---10
		DataIndex["potential_resist5"]						= 56		---11
		DataIndex["potential_resist6"]						= 57		---12
		DataIndex["skillid_0"]										= 58		
		DataIndex["skillid_1"]										= 59	
		DataIndex["skillid_2"]										= 60	
		DataIndex["skillid_3"]										= 61	
		DataIndex["skillid_4"]										= 62	
		DataIndex["skillid_5"]										= 63	
		DataIndex["skillid_6"]										= 64	
		DataIndex["skillid_7"]										= 65	
		DataIndex["skillid_8"]										= 66	
		DataIndex["skillid_9"]										= 67	
		DataIndex["skillid_10"]										= 68	
		DataIndex["skillid_11"]										= 69	
		DataIndex["skilllvl_0"]										= 70		
		DataIndex["skilllvl_1"]										= 71	
		DataIndex["skilllvl_2"]										= 72	
		DataIndex["skilllvl_3"]										= 73	
		DataIndex["skilllvl_4"]										= 74	
		DataIndex["skilllvl_5"]										= 75	
		DataIndex["skilllvl_6"]										= 76	
		DataIndex["skilllvl_7"]										= 77	
		DataIndex["skilllvl_8"]										= 78	
		DataIndex["skilllvl_9"]										= 79	
		DataIndex["skilllvl_10"]									= 80	
		DataIndex["skilllvl_11"]									= 81
		DataIndex["talent_1"]											= 82		
		DataIndex["talent_2"]											= 83	
		DataIndex["talent_3"]											= 84	
		DataIndex["talent_4"]											= 85	
		DataIndex["talent_5"]											= 86	
		DataIndex["talent_6"]											= 87	
		DataIndex["talent_7"]											= 88	
		DataIndex["talent_8"]											= 89	
		DataIndex["talent_9"]											= 90	
		DataIndex["talent_10"]										= 91	
		DataIndex["talent_11"]										= 92	
		DataIndex["talent_12"]										= 93
		DataIndex["talent_13"]										= 94
		DataIndex["isspecial"]										= 95
		DataIndex["feedtimes"]										= 96
		DataIndex["feedaids"]											= 97		
		DataIndex["fatalityinchp"]								= 98
		DataIndex["fatalityincmp"]								= 99
		DataIndex["fatalityincminatk"]						= 100
		DataIndex["fatalityincmaxatk"]						= 101
		DataIndex["fatalityincdef"]								= 102
		DataIndex["fatalityaddatkrate"]						= 103
		DataIndex["fatalityadddodge"]							= 104
		DataIndex["fatalityincres1"]							= 105
		DataIndex["fatalityincres2"]							= 106
		DataIndex["fatalityincres3"]							= 107	
		DataIndex["fatalityincres4"]							= 108
		DataIndex["fatalityincres5"]							= 109
		DataIndex["fatalityincres6"]							= 110
		DataIndex["fatalityaddcrit"]							= 111
		DataIndex["fatalityaddcritdmg"]						= 112	
		DataIndex["fatalityaddacuity"]						= 113	
		DataIndex["fatalityaddstamina"]						= 114
		DataIndex["fatalityaddsawy"]							= 115
		DataIndex["fatalityadddowry"]							= 116
		DataIndex["fatalityaddwisdom"]						= 117
		DataIndex["fatalityaddcnr"]								= 118							
		DataIndex["smallgrow"]										= 119
		DataIndex["reserve1"]											= 120
		DataIndex["reserve2"]											= 121
		DataIndex["reserve3"]											= 122
		DataIndex["reserve4"]											= 123
		DataIndex["reserve5"]											= 124
		DataIndex["reserve6"]											= 125
		DataIndex["reserve7"]											= 126
		DataIndex["reserve8"]											= 127
		DataIndex["reserve9"]											= 128	
		return DataIndex
end 

---������ԴԼ������----//�˴���δͬ����Լ��-------------------------------
function ZLuaPetBedgeOrigins()
	local ServerOrigins = {}			
	ServerOrigins["task"]  						= 0
	ServerOrigins["gshop"] 						= 1
	ServerOrigins["npc"]  						= 2
	ServerOrigins["lottery"] 	 				= 3
	ServerOrigins["drop"]			 	 			= 4
	ServerOrigins["combine"] 					= 5
	ServerOrigins["catch"] 						= 6
	return ServerOrigins
end 

---��������Լ������-------------------------------------------------------
function ZLuaPetBedgeElementDesc()
	local Element = {}			
	Element["danqie"]  							= 0			---//����
	Element["lumang"]								= 1			---//³ç
	Element["kuangye"]  						= 2			---//��Ұ
	Element["baozao"] 	 						= 3			---//����
	Element["gaoao"]			 	 				= 4			---//�߰�	
	Element["youya"]								= 5			---//����
	Element["yaomei"]  							= 6			---//����
	Element["wenrou"]								= 7			---//����
	Element["yinxian"]  						= 8			---//����
	Element["xiee"] 	 							= 9			---//а��
	Element["wanpi"]			 	 				= 10		---//��Ƥ	
	Element["weiyan"]								= 11		---//����
	Element["shensheng"]  					= 12		---//��ʥ
	Element["ruizhi"]								= 13		---//���
	Element["miantian"]  						= 14		---//����
	Element["boxue"] 	 							= 15		---//��ѧ
	Element["gupi"]			 	 					= 16		---//��Ƨ	
	Element["yiyu"]									= 17		---//����

	return Element
end 

---��������Լ������-------------------------------------------------------
function ZLuaPetBedgeRaceDesc()
	local Race = {}			
	Race["renzu"]  								= 0
	Race["yaozu"] 								= 1
	Race["guizu"]  								=	2
	Race["yuzu"]  								=	3
	Race["meizu"] 	 							= 4
	Race["tianjiang"]			 	 			= 5	
	Race["xianling"] 							= 6
	Race["shanjing"]  						= 7
	Race["yeshou"] 								= 8
	Race["yishou"]  							=	9
	Race["shuizu"] 	 							= 10
	Race["chonggu"]			 	 				= 11	
	Race["huanling"] 							= 12
	Race["siling"]  							= 13
	Race["yuansu"] 								= 14
	Race["teshu"]  								=	15
	return Race
	--[[���/����/����/����/����/�ɳ�/���/���/
			��ľ/ˮ��/����/����/����/��ħ/�Ϲ�/����--(old)
			����/����/����/����/����/�콫/����/ɽ��/
			Ұ��/����/ˮ��/���/����/����/Ԫ��/����--]]		
end 

---�����ǳ�Լ������-------------------------------------------------------
function ZLuaPetBedgeHoroscopeDesc()
	local Horoscope= {}			
	Horoscope["riyao"]  						= 0		---���ף�ʥ�
	Horoscope["yueyao"] 						= 1		---���ף�������
	Horoscope["jinyao"]  						= 2		---���ף�սʿ��
	Horoscope["muyao"] 	 						= 3		---ľ�ף�С�£�
	Horoscope["shuiyao"]			 			= 4		---ˮ�ף���ʦ��
	Horoscope["huoyao"] 						= 5		---���ף���ʦ��
	Horoscope["tuyao"] 							= 6		---���ף����ˣ�
	Horoscope["luohou"] 						= 7		---�޺���ʿ��
	Horoscope["jidu"] 							= 8		---�ƶ���������
	return Horoscope
end 
---Լ��������index����,����ս����ص�ֵ(��ʼ/�ɳ�/��ǰֵ)
function ZLuaPetBedgeSpecialIndex()
	local SpecialIndex={}
		SpecialIndex["hp"]=0
		SpecialIndex["mp"]=1
		SpecialIndex["minatk"]=2
		SpecialIndex["maxatk"]=3
		SpecialIndex["defence"]=4
		SpecialIndex["atkrate"]=5
		SpecialIndex["dodge"]=6
		SpecialIndex["res1"]=7		---//ѣ��
		SpecialIndex["res2"]=8		---//����
		SpecialIndex["res3"]=9		---//����
		SpecialIndex["res4"]=10		---//�Ȼ�
		SpecialIndex["res5"]=11		---//��˯
		SpecialIndex["res6"]=12		---//����
	return SpecialIndex
end 
---�������Ƿ�Ϊ�Ϸ�����ID------------------------------------------------
function ZLuaPetBedgeExistInTmplIDs(pet_tid)
	if type(pet_tid) ~= "number" then return 0 end
	local availablePets = ZLuaAvailablePets()
	local pet
	for _,pet in pairs(availablePets) do
		if pet.pet_tid == pet_tid then return pet.pet_tid end
	end
	return 0
end

---��ȡ��������/����/����һ����/����һ���˺���Ϣ---------------------------
function ZLuaPetBedgeStaticInfo(pet_tid)
	if type(pet_tid) ~= "number" then return 0 end
	local availablePets = ZLuaAvailablePets()
	local pet
	for _,pet in pairs(availablePets) do
		if pet.pet_tid == pet_tid then 
			return pet.race,pet.crit,pet.critdmg
		end
	end
	return 0,0,0
end
---�����ʼ��--------------------------------------------------------------
function PetBedgeInit(pet_tid,pet,origin,master_level)
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return 0 end
	if pet == nil then return 0 end
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local availablePets = ZLuaAvailablePets()
		
	---ȡ�ó�����Դ��������Լ����
	local serverorigin = origin or ServerOrigins["drop"]
	local race,crit,critdmg=ZLuaPetBedgeStaticInfo(pet_tid)
	
	---//��������(petbedge_grades�ж���)
	local horoscope=ZLuaPetBedgeHoroscopeInfo(pet_tid,origin)

	---//�����Ը���˵���й�(petbedge_free�ж���)
	local element=ZLuaPetBedgeElementInfo(pet_tid,origin)
	
	
	local GradeDirection=ZLuaPetBedgeGradeDirection()
	
	---��ȡ�����޽�/��ص�λ��Ϣ(maintype/Atk/Def/Hp/Mp/Res1-Res6)(file:petbedge_grades.lua)
	local MainType,StarLevel
	local GradesList={}
	MainType=ZLuaPetBedgeSetMaintype(pet_tid,horoscope,origin)
	GradesList,StarLevel=ZLuaPetBedgeInitGrades(pet_tid,horoscope,MainType,serverorigin)
	

	---��ȡ���＼����Ϣ(Skills/SkillsLevel)(file:petbedge_skills.lua)
	local SkillsList={}
	local SkillsLevel={}
	SkillsList,SkillsLevel=ZLuaPetBedgeSkills(pet_tid,horoscope,serverorigin)
	
	---��ȡ�����츳��Ϣ(Talents)(file:petbedge_skills.lua)
	local TalenetsList={}
	TalenetsList=ZLuaPetBedgeTalents(pet_tid,serverorigin)
	
	---��ȡ��������������Ϣ(Live)(file:petbedge_skills.lua)
	local LivesList={}
	LivesList=ZLuaPetBedgeLives(pet_tid,serverorigin)
--[[
	---���ɳ���ģ��ID
	if pet_tid==29992 then
		pet:UpdateData(DataIndex["id"], pet_tid)
	else
		pet:UpdateData(DataIndex["id"], 33146)
	end
--]]

  pet:UpdateData(DataIndex["id"], pet_tid)
  	
	---�趨���Ｖ��ͳ��ﾭ��
	pet:SetLevel(1)
	pet:SetExp(0)

	---���ɳ���������
	pet:UpdateData(DataIndex["identify"], 0)
		
	---���ɳ�����Դ��(��¼��Դ)�����塢�Ը������
	pet:UpdateData(DataIndex["orign"], serverorigin)	
	pet:UpdateData(DataIndex["nativeorigin"],serverorigin)	
	pet:UpdateData(DataIndex["race"], race)
	pet:UpdateData(DataIndex["element"], element)
	pet:UpdateData(DataIndex["horoscope"], horoscope)
			
	---������ﱻ������/���弼��/�ǳ�����------------------------------------
	local Race=ZLuaPetBedgeRaceDesc()
	local Horoscope= ZLuaPetBedgeHoroscopeDesc()		
	
	local PseudoPassiveAddDef=0
	local PseudoPassiveAddRes1=0
	local PseudoPassiveAddRes2=0
	local PseudoPassiveAddRes3=0
	local PseudoPassiveAddRes4=0
	local PseudoPassiveAddRes5=0
	local PseudoPassiveAddRes6=0
	local PseudoPassiveAddCrit=0
	local PseudoPassiveAddCritDmg=0
	local PseudoPassiveAddAtkRate=0
	local PseudoPassiveAddDodge=0
	local PseudoPassiveAddExtraDamage=0
	local PseudoPassiveAddExtraDamageReduce=0
	
	local FatalitySkillID,HoroscopeAddSkillID,RaceAddSkillID,DescriptionID=0,0,0,0
	---//�ֻؼ���/���༼��/���弼��/ְҵ����
	
	FatalitySkillID=ZLuaPetBedgeFatalitySkills(pet_tid,origin)

	if race==Race["renzu"] then 					---����
		RaceAddSkillID=1223
	elseif race==Race["yaozu"] then 			---����
		PseudoPassiveAddRes5=15
		RaceAddSkillID=1224
	elseif race==Race["guizu"] then 			---����
		RaceAddSkillID=1225
	elseif race==Race["yuzu"] then 				---����
		PseudoPassiveAddAtkRate=15
		RaceAddSkillID=1226
	elseif race==Race["meizu"] then 			---����
		PseudoPassiveAddRes4=15
		RaceAddSkillID=1240
	elseif race==Race["tianjiang"] then		---�콫	 
		PseudoPassiveAddRes3=15
		RaceAddSkillID=1241
	elseif race==Race["xianling"] then 		---����
		RaceAddSkillID=1242
	elseif race==Race["shanjing"] then 		---ɽ��
		RaceAddSkillID=1243
	elseif race==Race["yeshou"] then 			---Ұ��
		PseudoPassiveAddCritDmg=0.1
		RaceAddSkillID=1244
	elseif race==Race["yishou"] then 			---����
		PseudoPassiveAddExtraDamageReduce=10
		RaceAddSkillID=1245
	elseif race==Race["shuizu"] then 			---ˮ��
		PseudoPassiveAddRes6=15
		RaceAddSkillID=1246
	elseif race==Race["chonggu"] then 		---���
		PseudoPassiveAddExtraDamage=20
		RaceAddSkillID=1247
	elseif race==Race["huanling"] then 		---����
		RaceAddSkillID=1248
	elseif race==Race["siling"] then 			---����
		PseudoPassiveAddRes1=15
		RaceAddSkillID=1249
	elseif race==Race["yuansu"] then 			---Ԫ��
		PseudoPassiveAddDef=10
		PseudoPassiveAddRes2=10
		RaceAddSkillID=1250
	elseif race==Race["teshu"] then 			---����
		PseudoPassiveAddDodge=15
		RaceAddSkillID=1251
	else
	end 
	
	if horoscope==Horoscope["riyao"] then				---����
		HoroscopeAddSkillID=1252
		DescriptionID=1359
	elseif horoscope==Horoscope["yueyao"] then	---����
		HoroscopeAddSkillID=1253
		DescriptionID=1360
	elseif horoscope==Horoscope["jinyao"] then	---����
		HoroscopeAddSkillID=1254
		DescriptionID=1361
	elseif horoscope==Horoscope["muyao"] then		---ľ��
		HoroscopeAddSkillID=1255
		DescriptionID=1362
	elseif horoscope==Horoscope["shuiyao"] then	---ˮ��
		HoroscopeAddSkillID=1256
		DescriptionID=1363
	elseif horoscope==Horoscope["huoyao"] then	---����
		HoroscopeAddSkillID=1257
		DescriptionID=1364
	elseif horoscope==Horoscope["tuyao"] then		---����
		HoroscopeAddSkillID=1258
		DescriptionID=1365
	elseif horoscope==Horoscope["luohou"] then	---�޺�
		HoroscopeAddSkillID=1259
		DescriptionID=1366
	elseif horoscope==Horoscope["jidu"] then		---�ƶ�
		HoroscopeAddSkillID=1260
		DescriptionID=1367
	else 
	end 
	--[[	
	---���ɳ�����������Ӱ��(PseudoPassiveSkills)
	---����	���Խ���	�����ĳɹ�������3����								1
	---����	����ֱ��	��˯��������15�㡣									1
	---����	��������	���������ʻ�õĳɳ�����5��					1
	---����	ӥ�۶���	��������15�㡣											1
	---����	����֮��	�Ȼ�������15�㡣									1
	---�콫	����֮��	����������15�㡣									1
	---����	�ɶ��칤	������������ֵ����5�㡣							1
	---ɽ��	��â����	��Ѫ�ظ��ٶȼӱ���									1
	---Ұ��	Ұ������	����һ���˺�����10����							1
	---����	���ݹ�ע	�ܵ��˺�����10�㡣									1
	---ˮ��	����˴�	�������ĸ����½���									1
	---���	����֮��	����ͨĿ���������20���˺���				1
	---����	��ռ�ȡ	�����ظ��ٶȼӱ���									1
	---����	������־	ѣ�ο�������15�㡣									1
	---Ԫ��	��������	������������15�㡣									1
	---����	��������	��������15�㡣											1
	---����/����/����/����/����/�콫/����/ɽ��/
			Ұ��/����/ˮ��/���/����/����/Ԫ��/����
	--]]				

	pet:UpdateData(DataIndex["critrate"], crit+PseudoPassiveAddCrit)
	pet:UpdateData(DataIndex["critdamage"], critdmg+PseudoPassiveAddCritDmg)
	pet:UpdateData(DataIndex["nativecritrate"], crit+PseudoPassiveAddCrit)	 	
 	pet:UpdateData(DataIndex["nativecritdamage"], critdmg+PseudoPassiveAddCritDmg)
	---//nativecrit/nativecritdamageΪ�������ܶȶ�crit/critdmgӰ������õ�������
	
	
	---���ɳ���ս�������Ϣ
	pet:UpdateData(DataIndex["extradamage"], 1+PseudoPassiveAddExtraDamage)
	pet:UpdateData(DataIndex["extradamagereduce"], 1+PseudoPassiveAddExtraDamageReduce)
	pet:UpdateData(DataIndex["star"], StarLevel)
	pet:UpdateData(DataIndex["maintype"], MainType)

	---//��ʼֵΪʵ��ֵ
	pet:UpdateData(DataIndex["default_hp"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["default_hp"]],GradeDirection["default_hp"]))	
	pet:UpdateData(DataIndex["default_mp"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["default_mp"]],GradeDirection["default_mp"]))
	pet:UpdateData(DataIndex["default_minatk"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["default_minatk"]],GradeDirection["default_minatk"]))
	pet:UpdateData(DataIndex["default_maxatk"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["default_maxatk"]],GradeDirection["default_maxatk"]))
	pet:UpdateData(DataIndex["default_def"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["default_def"]],GradeDirection["default_def"])+PseudoPassiveAddDef)
	pet:UpdateData(DataIndex["default_attackrate"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["default_attackrate"]],GradeDirection["default_attackrate"])+PseudoPassiveAddAtkRate)
	pet:UpdateData(DataIndex["default_dodge"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["default_dodge"]],GradeDirection["default_dodge"])+PseudoPassiveAddDodge)
	
	pet:UpdateData(DataIndex["default_resist1"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["default_resist1"]],GradeDirection["default_resist1"])+PseudoPassiveAddRes1)
	pet:UpdateData(DataIndex["default_resist2"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["default_resist2"]],GradeDirection["default_resist2"])+PseudoPassiveAddRes2)
	pet:UpdateData(DataIndex["default_resist3"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["default_resist3"]],GradeDirection["default_resist3"])+PseudoPassiveAddRes3)
	pet:UpdateData(DataIndex["default_resist4"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["default_resist4"]],GradeDirection["default_resist4"])+PseudoPassiveAddRes4)
	pet:UpdateData(DataIndex["default_resist5"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["default_resist5"]],GradeDirection["default_resist5"])+PseudoPassiveAddRes5)
	pet:UpdateData(DataIndex["default_resist6"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["default_resist6"]],GradeDirection["default_resist6"])+PseudoPassiveAddRes6)

	---//��λֵΪ��ôֵ(�ͻ�����ʾֵ)
	pet:UpdateData(DataIndex["potential_hp"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["potential_hp"]],GradeDirection["potential_hp"]))
	pet:UpdateData(DataIndex["potential_mp"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["potential_mp"]],GradeDirection["potential_mp"]))
	pet:UpdateData(DataIndex["potential_minatk"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["potential_minatk"]],GradeDirection["potential_minatk"]))
	pet:UpdateData(DataIndex["potential_maxatk"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["potential_maxatk"]],GradeDirection["potential_maxatk"]))
	pet:UpdateData(DataIndex["potential_def"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["potential_def"]],GradeDirection["potential_def"]))
	pet:UpdateData(DataIndex["potential_attackrate"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["potential_attackrate"]],GradeDirection["potential_attackrate"]))
	pet:UpdateData(DataIndex["potential_dodge"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["potential_dodge"]],GradeDirection["potential_dodge"]))
	pet:UpdateData(DataIndex["potential_resist1"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["potential_resist1"]],GradeDirection["potential_resist1"]))
	pet:UpdateData(DataIndex["potential_resist2"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["potential_resist2"]],GradeDirection["potential_resist2"]))
	pet:UpdateData(DataIndex["potential_resist3"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["potential_resist3"]],GradeDirection["potential_resist3"]))
	pet:UpdateData(DataIndex["potential_resist4"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["potential_resist4"]],GradeDirection["potential_resist4"]))
	pet:UpdateData(DataIndex["potential_resist5"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["potential_resist5"]],GradeDirection["potential_resist5"]))
	pet:UpdateData(DataIndex["potential_resist6"], ZLuaPetBedgeGradeData(GradesList[GradeDirection["potential_resist6"]],GradeDirection["potential_resist6"]))
		
			
	---���ɳ��＼�������Ϣ
	---//1Ϊ�����ǳ�����(��ΪΪ����)
	pet:UpdateData(DataIndex["skillid_0"], HoroscopeAddSkillID or 0)	
	pet:UpdateData(DataIndex["skillid_1"], SkillsList[1] or 0)	
	pet:UpdateData(DataIndex["skillid_2"], SkillsList[2] or 0)	
	pet:UpdateData(DataIndex["skillid_3"], SkillsList[3] or 0)	
	pet:UpdateData(DataIndex["skillid_4"], SkillsList[4] or 0)	
	pet:UpdateData(DataIndex["skillid_5"], SkillsList[5] or 0)	
	pet:UpdateData(DataIndex["skillid_6"], SkillsList[6] or 0)	
	pet:UpdateData(DataIndex["skillid_7"], SkillsList[7] or 0)	
	
	
	---��9��Ԥ��Ϊ�����ֻؼ���ָ��
	pet:UpdateData(DataIndex["skillid_8"], FatalitySkillID or 0)	
	
	---��10��Ԥ��Ϊ�������弼��ָ��
	pet:UpdateData(DataIndex["skillid_9"], RaceAddSkillID or 0)	
	
	---��11��ְҵ��������
	pet:UpdateData(DataIndex["skillid_10"], DescriptionID)	
	
	---��12���հ�(���ڲ���)
	pet:UpdateData(DataIndex["skillid_11"], 0)	
	

	pet:UpdateData(DataIndex["skilllvl_0"], 1)	
	pet:UpdateData(DataIndex["skilllvl_1"], SkillsLevel[1] or 0)	
	pet:UpdateData(DataIndex["skilllvl_2"], SkillsLevel[2] or 0)	
	pet:UpdateData(DataIndex["skilllvl_3"], SkillsLevel[3] or 0)	
	pet:UpdateData(DataIndex["skilllvl_4"], SkillsLevel[4] or 0)	
	pet:UpdateData(DataIndex["skilllvl_5"], SkillsLevel[5] or 0)	
	pet:UpdateData(DataIndex["skilllvl_6"], SkillsLevel[6] or 0)	
	pet:UpdateData(DataIndex["skilllvl_7"], SkillsLevel[7] or 0)	
	pet:UpdateData(DataIndex["skilllvl_8"], 1)	
	pet:UpdateData(DataIndex["skilllvl_9"], 1)	
	pet:UpdateData(DataIndex["skilllvl_10"], 1)	
	pet:UpdateData(DataIndex["skilllvl_11"], 0)	

	---���ɳ����츳�����Ϣ
	pet:UpdateData(DataIndex["talent_1"], TalenetsList[1] or 0)	
	pet:UpdateData(DataIndex["talent_2"], TalenetsList[2] or 0)	
	pet:UpdateData(DataIndex["talent_3"], TalenetsList[3] or 0)	
	pet:UpdateData(DataIndex["talent_4"], TalenetsList[4] or 0)	
	pet:UpdateData(DataIndex["talent_5"], TalenetsList[5] or 0)	
	pet:UpdateData(DataIndex["talent_6"], TalenetsList[6] or 0)	
	pet:UpdateData(DataIndex["talent_7"], TalenetsList[7] or 0)	
	pet:UpdateData(DataIndex["talent_8"], TalenetsList[8] or 0)	
	pet:UpdateData(DataIndex["talent_9"], TalenetsList[9] or 0)	
	pet:UpdateData(DataIndex["talent_10"], TalenetsList[10] or 0)	
	pet:UpdateData(DataIndex["talent_11"], TalenetsList[11] or 0)	
	pet:UpdateData(DataIndex["talent_12"], TalenetsList[12] or 0)	
	pet:UpdateData(DataIndex["talent_13"], TalenetsList[13] or 0)
	pet:UpdateData(DataIndex["isspecial"], 0)
	

	---���ɳ������������Ϣ
	pet:UpdateData(DataIndex["age"], LivesList[1] or 0)	
	pet:UpdateData(DataIndex["life"], LivesList[2] or 0)	
	pet:UpdateData(DataIndex["maxhunger"],LivesList[3] or 0)	
	pet:UpdateData(DataIndex["curhunger"],LivesList[4] or 0)	
	pet:UpdateData(DataIndex["maxhonor"],LivesList[5] or 0)	
	pet:UpdateData(DataIndex["curhonor"],LivesList[6] or 0)
	pet:UpdateData(DataIndex["acuity"], LivesList[7] or 0)	
	pet:UpdateData(DataIndex["stamina"], LivesList[8] or 0)	
	pet:UpdateData(DataIndex["sawy"], LivesList[9] or 0)	
	pet:UpdateData(DataIndex["dowry"], LivesList[10] or 0)	
	pet:UpdateData(DataIndex["wisdom"], LivesList[11] or 0)	
	pet:UpdateData(DataIndex["cnr"], LivesList[12] or 0)	
	
	
	pet:SetAge(LivesList[1] or 0)
	pet:SetLife(LivesList[2] or 0)
	pet:SetMaxHungerPoint(LivesList[3] or 0)
	pet:SetCurHungerPoint(LivesList[4] or 0)
	pet:SetMaxHonorPoint(LivesList[5] or 0)
	pet:SetCurHonorPoint(LivesList[6] or 0)
	
	--[[
	pet:SetAcuity(LivesList[6] or 0)
	pet:SetStamina(LivesList[7] or 0)
	pet:SetSawy(LivesList[8] or 0)
	pet:SetAcuity(LivesList[9] or 0)
	pet:SetDowry(LivesList[10] or 0)
	pet:SetWisdom(LivesList[11] or 0)
	pet:SetCNR(LivesList[12] or 0)
 	--]]
 	
 	---����ֵ
 	pet:UpdateData(DataIndex["face"], 0)	
 	pet:UpdateData(DataIndex["shape"],1)	
 	pet:UpdateData(DataIndex["isgrowup"],0)					---//����������ı�����(����ר��ÿ10����ı�һ��,0Ϊ����)	
 	pet:UpdateData(DataIndex["isaberrant"],0)				---//�����Ƿ�Ϊ�������
	
	pet:SetShape(1)
	pet:SetFace(0)
	
	pet:UpdateData(DataIndex["feedtimes"], 0)	
 	pet:UpdateData(DataIndex["feedaids"], 0)
 	pet:UpdateData(DataIndex["fatalityinchp"], 1)
  pet:UpdateData(DataIndex["fatalityincmp"], 1)
  pet:UpdateData(DataIndex["fatalityincminatk"], 1)
  pet:UpdateData(DataIndex["fatalityincmaxatk"], 1)
  pet:UpdateData(DataIndex["fatalityincdef"], 1)  
  pet:UpdateData(DataIndex["fatalityaddatkrate"], 0)
  pet:UpdateData(DataIndex["fatalityadddodge"], 0)
  pet:UpdateData(DataIndex["fatalityincres1"], 1)
  pet:UpdateData(DataIndex["fatalityincres2"], 1)
  pet:UpdateData(DataIndex["fatalityincres3"], 1)
  pet:UpdateData(DataIndex["fatalityincres4"], 1)
  pet:UpdateData(DataIndex["fatalityincres5"], 1)
  pet:UpdateData(DataIndex["fatalityincres6"], 1)
  pet:UpdateData(DataIndex["fatalityaddcrit"], 1)
  pet:UpdateData(DataIndex["fatalityaddcritdmg"], 0)
  pet:UpdateData(DataIndex["fatalityaddacuity"], 0)
  pet:UpdateData(DataIndex["fatalityaddstamina"], 0)
  pet:UpdateData(DataIndex["fatalityaddsawy"], 0)
  pet:UpdateData(DataIndex["fatalityadddowry"], 0)
  pet:UpdateData(DataIndex["fatalityaddwisdom"], 0)
  pet:UpdateData(DataIndex["fatalityaddcnr"], 0)
  
  ---��������ֵ
  pet:UpdateData(DataIndex["blank"], 0)
  pet:UpdateData(DataIndex["smallgrow"], 0)
  pet:UpdateData(DataIndex["reserve1"], 0)	---20090303�������Ƴ����������ܸ����
  pet:UpdateData(DataIndex["reserve2"], 0)
  pet:UpdateData(DataIndex["reserve3"], 0)
  pet:UpdateData(DataIndex["reserve4"], 0)
  pet:UpdateData(DataIndex["reserve5"], 0)
  pet:UpdateData(DataIndex["reserve6"], 0)
  pet:UpdateData(DataIndex["reserve7"], 0)
  pet:UpdateData(DataIndex["reserve8"], 0)
  pet:UpdateData(DataIndex["reserve9"], 0)

 	---//������� ����ϵ�кͿ���ϵ�еȼ�Ԥ�����ѱ��Ԥ����
 	local templevel=1
 	for i,v in pairs(availablePets) do
		if v.pet_tid==pet_tid and v.born_special ~= 0 and type(v.born_special)=="number" then 
 			if type(master_level)=="number" and master_level>=1 and master_level<=150 then 
 				templevel=math.min(master_level+v.born_special,150)
			end
		pet:SetLevel(templevel)
 		PetBedgeAdopt(pet_tid,pet,origin) 
		end
	end

		ZLuaPetBedgeRebuild(pet_tid,pet,origin,master_level,_)
 	---HuangXinҪ���return��(�̶�)
 	return pet_tid
 end
-------------------------------------------------------------------------------------------------------------
---//����ӿ�
function PetBedgeRebuild(pet_tid,pet,origin,master_level,cult)
	ZLuaPetBedgeRebuild(pet_tid,pet,origin,master_level,cult)
	---//cultΪ����컯��1���ɣ�2��ħ��4�������������������������ڷǷ�����Ӱ��
	return pet_tid;
end 
-------------------------------------------------------------------------------------------------------------
--------���������������úͼ���--------------------------------------------------------------------------------
function ZLuaPetBedgeRebuild(pet_tid,pet,origin,master_level,cult)
	
	
	local DataIndex=ZLuaPetBedgeDataIndex()
	local SpecialIndex=ZLuaPetBedgeSpecialIndex()
	local availablePets = ZLuaAvailablePets()
	local Race=ZLuaPetBedgeRaceDesc()
	
	local level=pet:QueryLevel()
	
	---//������� ����ϵ�кͿ���ϵ�еȼ�Ԥ����	
	for i,v in pairs(availablePets) do
		if v.pet_tid==pet_tid and v.born_special ~= 0 and type(v.born_special)=="number" then 
 			if type(master_level)=="number" and master_level>=1 and master_level<=150 then 
 				level=math.max(math.min(master_level+v.born_special,150),1)
			end
			pet:SetLevel(level)
		end
	end

		---����2009��̨����������ǵ��쳣��Bug---��ʼ---------------------------------	
		if pet_tid==29992 and pet:QueryData(DataIndex["id"])==29992 then
			---����Ƿ��쳣����
				pet:UpdateData(DataIndex["id"], 33146)
			---����id�����³�ʼ��	
		 		PetBedgeInit(33146,pet,origin,master_level)
				pet:UpdateData(DataIndex["identify"], 1)
		end
	
		pet:SetStar(pet:QueryData(DataIndex["star"]))
		pet:SetMainType(pet:QueryData(DataIndex["maintype"]))
		
		pet:SetElement(pet:QueryData(DataIndex["element"]))
		pet:SetIdentify(pet:QueryData(DataIndex["identify"]))
		pet:SetRace(pet:QueryData(DataIndex["race"]))
		pet:SetHoroscope(pet:QueryData(DataIndex["horoscope"]))
		
		pet:SetCombatAttrInit(SpecialIndex["hp"],pet:QueryData(DataIndex["default_hp"]))
		pet:SetCombatAttrInit(SpecialIndex["mp"],pet:QueryData(DataIndex["default_mp"]))
		pet:SetCombatAttrInit(SpecialIndex["minatk"],pet:QueryData(DataIndex["default_minatk"]))
		pet:SetCombatAttrInit(SpecialIndex["maxatk"],pet:QueryData(DataIndex["default_maxatk"]))
		pet:SetCombatAttrInit(SpecialIndex["defence"],pet:QueryData(DataIndex["default_def"]))
		pet:SetCombatAttrInit(SpecialIndex["atkrate"],pet:QueryData(DataIndex["default_attackrate"]))
		pet:SetCombatAttrInit(SpecialIndex["dodge"],pet:QueryData(DataIndex["default_dodge"]))
		pet:SetCombatAttrInit(SpecialIndex["res1"],pet:QueryData(DataIndex["default_resist1"]))
		pet:SetCombatAttrInit(SpecialIndex["res2"],pet:QueryData(DataIndex["default_resist2"]))
		pet:SetCombatAttrInit(SpecialIndex["res3"],pet:QueryData(DataIndex["default_resist3"]))
		pet:SetCombatAttrInit(SpecialIndex["res4"],pet:QueryData(DataIndex["default_resist4"]))
		pet:SetCombatAttrInit(SpecialIndex["res5"],pet:QueryData(DataIndex["default_resist5"]))
		pet:SetCombatAttrInit(SpecialIndex["res6"],pet:QueryData(DataIndex["default_resist6"]))
		
		pet:SetCombatAttrPotential(SpecialIndex["hp"],pet:QueryData(DataIndex["potential_hp"]))
		pet:SetCombatAttrPotential(SpecialIndex["mp"],pet:QueryData(DataIndex["potential_mp"]))
		pet:SetCombatAttrPotential(SpecialIndex["minatk"],pet:QueryData(DataIndex["potential_minatk"]))
		pet:SetCombatAttrPotential(SpecialIndex["maxatk"],pet:QueryData(DataIndex["potential_maxatk"]))
		pet:SetCombatAttrPotential(SpecialIndex["defence"],pet:QueryData(DataIndex["potential_def"]))
		pet:SetCombatAttrPotential(SpecialIndex["atkrate"],pet:QueryData(DataIndex["potential_attackrate"]))
		pet:SetCombatAttrPotential(SpecialIndex["dodge"],pet:QueryData(DataIndex["potential_dodge"]))
		pet:SetCombatAttrPotential(SpecialIndex["res1"],pet:QueryData(DataIndex["potential_resist1"]))
		pet:SetCombatAttrPotential(SpecialIndex["res2"],pet:QueryData(DataIndex["potential_resist2"]))
		pet:SetCombatAttrPotential(SpecialIndex["res3"],pet:QueryData(DataIndex["potential_resist3"]))
		pet:SetCombatAttrPotential(SpecialIndex["res4"],pet:QueryData(DataIndex["potential_resist4"]))
		pet:SetCombatAttrPotential(SpecialIndex["res5"],pet:QueryData(DataIndex["potential_resist5"]))
		pet:SetCombatAttrPotential(SpecialIndex["res6"],pet:QueryData(DataIndex["potential_resist6"]))

	
		pet:SetMaxHungerPoint(500+(level-1)*90)
		pet:SetMaxHonorPoint(pet:QueryMaxHonorPoint())
		pet:SetCurHungerPoint(pet:QueryCurHungerPoint())
		pet:SetCurHonorPoint(pet:QueryCurHonorPoint())
		pet:SetAge(pet:QueryAge())
		pet:SetLife(pet:QueryLife())
		
		pet:UpdateData(DataIndex["curhunger"],pet:QueryCurHungerPoint())
		pet:UpdateData(DataIndex["maxhunger"],pet:QueryMaxHungerPoint())
		pet:UpdateData(DataIndex["curhonor"],pet:QueryCurHonorPoint())
		pet:UpdateData(DataIndex["maxhunger"],500+(level-1)*30)
		pet:UpdateData(DataIndex["age"],pet:QueryAge())
		pet:UpdateData(DataIndex["life"],pet:QueryLife())
	
		---//����Ƿ���������
		if cult~=4 and type(cult)=="number" then 
			ZLuaPetBedgeRollBack(pet_tid,pet)
		end  
		
		---//�����������
	  local pea_atk,pea_def,pea_crithurt=0,0,0
	  pea_atk,pea_def,pea_crithurt=ZLuaPetBedgeFatalityEffect(pet_tid,pet,origin)
	  
	 		---//������������弼��
	  local spirit_crit=0
	  spirit_crit=ZLuaPetBedgeSpiritEffect(pet_tid,pet,origin)
		
		pet:SetSkillID(0,pet:QueryData(DataIndex["skillid_0"]))
		pet:SetSkillID(1,pet:QueryData(DataIndex["skillid_1"]))
		pet:SetSkillID(2,pet:QueryData(DataIndex["skillid_2"]))
		pet:SetSkillID(3,pet:QueryData(DataIndex["skillid_3"]))
		pet:SetSkillID(4,pet:QueryData(DataIndex["skillid_4"]))
		pet:SetSkillID(5,pet:QueryData(DataIndex["skillid_5"]))
		pet:SetSkillID(6,pet:QueryData(DataIndex["skillid_6"]))
		pet:SetSkillID(7,pet:QueryData(DataIndex["skillid_7"]))
		pet:SetSkillID(8,pet:QueryData(DataIndex["skillid_8"]))
		pet:SetSkillID(9,pet:QueryData(DataIndex["skillid_9"]))
		pet:SetSkillID(10,pet:QueryData(DataIndex["skillid_10"]))
		pet:SetSkillID(11,pet:QueryData(DataIndex["skillid_11"]))
		
		
		pet:SetTalent(0,pet:QueryData(DataIndex["talent_1"]))
		pet:SetTalent(1,pet:QueryData(DataIndex["talent_2"]))
		pet:SetTalent(2,pet:QueryData(DataIndex["talent_3"]))
		pet:SetTalent(3,pet:QueryData(DataIndex["talent_4"]))
		pet:SetTalent(4,pet:QueryData(DataIndex["talent_5"]))
		pet:SetTalent(5,pet:QueryData(DataIndex["talent_6"]))
		pet:SetTalent(6,pet:QueryData(DataIndex["talent_7"]))
		pet:SetTalent(7,pet:QueryData(DataIndex["talent_8"]))
		pet:SetTalent(8,pet:QueryData(DataIndex["talent_9"]))
		pet:SetTalent(9,pet:QueryData(DataIndex["talent_10"]))
		pet:SetTalent(10,pet:QueryData(DataIndex["talent_11"]))
		pet:SetTalent(11,pet:QueryData(DataIndex["talent_12"]))
		pet:SetTalent(12,pet:QueryData(DataIndex["talent_13"]))

		local talentslist={
		pet:QueryData(DataIndex["talent_1"]),pet:QueryData(DataIndex["talent_2"]),
		pet:QueryData(DataIndex["talent_3"]),pet:QueryData(DataIndex["talent_4"]),
		pet:QueryData(DataIndex["talent_5"]),pet:QueryData(DataIndex["talent_6"]),
		pet:QueryData(DataIndex["talent_7"]),pet:QueryData(DataIndex["talent_8"]),
		pet:QueryData(DataIndex["talent_9"]),pet:QueryData(DataIndex["talent_10"]),
		pet:QueryData(DataIndex["talent_11"]),pet:QueryData(DataIndex["talent_12"]),
		pet:QueryData(DataIndex["talent_13"])}
		
		local skillslistex={
		pet:QueryData(DataIndex["skillid_1"]),pet:QueryData(DataIndex["skillid_2"]),
		pet:QueryData(DataIndex["skillid_3"]),pet:QueryData(DataIndex["skillid_4"]),
		pet:QueryData(DataIndex["skillid_5"]),pet:QueryData(DataIndex["skillid_6"]),
		pet:QueryData(DataIndex["skillid_7"])}
		---//�������ʵļ��ܲ�������1�����ܺ����4������
		
		pet:SetSkillLevel(0,1+math.floor(level/75))
		

		---//���ܵȼ��ܵ�����Ӱ��
		pet:SetSkillLevel(1,ZLuaPetBedgeSkillBenefitByTalenet(skillslistex[1],talentslist,level)+pet:QueryData(DataIndex["skilllvl_1"]))
		pet:SetSkillLevel(2,ZLuaPetBedgeSkillBenefitByTalenet(skillslistex[2],talentslist,level)+pet:QueryData(DataIndex["skilllvl_2"]))
		pet:SetSkillLevel(3,ZLuaPetBedgeSkillBenefitByTalenet(skillslistex[3],talentslist,level)+pet:QueryData(DataIndex["skilllvl_3"]))
		pet:SetSkillLevel(4,ZLuaPetBedgeSkillBenefitByTalenet(skillslistex[4],talentslist,level)+pet:QueryData(DataIndex["skilllvl_4"]))
		pet:SetSkillLevel(5,ZLuaPetBedgeSkillBenefitByTalenet(skillslistex[5],talentslist,level)+pet:QueryData(DataIndex["skilllvl_5"]))
		pet:SetSkillLevel(6,ZLuaPetBedgeSkillBenefitByTalenet(skillslistex[6],talentslist,level)+pet:QueryData(DataIndex["skilllvl_6"]))
		pet:SetSkillLevel(7,ZLuaPetBedgeSkillBenefitByTalenet(skillslistex[7],talentslist,level)+pet:QueryData(DataIndex["skilllvl_7"]))
	
		pet:SetSkillLevel(8,pet:QueryData(DataIndex["skilllvl_8"]))
		pet:SetSkillLevel(9,pet:QueryData(DataIndex["skilllvl_9"]))			
		pet:SetSkillLevel(10,pet:QueryData(DataIndex["skilllvl_10"]))
		pet:SetSkillLevel(11,pet:QueryData(DataIndex["skilllvl_11"]))
			
		local Star=pet:QueryData(DataIndex["star"])
		local IsGrowUp=pet:QueryData(DataIndex["isgrowup"])
		local IsAberrant=pet:QueryData(DataIndex["isaberrant"])
		
		---//�ǵȸı�/���쵼�µ�����仯
		local FaceFromShape={}
		
			FaceFromShape[1]=0
			FaceFromShape[2]=1
			FaceFromShape[3]=2
			FaceFromShape[4]=3
			FaceFromShape[5]=4
			FaceFromShape[6]=5
			
		---//����������ǵȳɳ��ı������ͷ������
		if IsGrowUp==1 then 	
			pet:SetShape(math.max(math.min(math.floor(level/10)+1,6),1))
			pet:SetFace(FaceFromShape[math.max(math.min(math.floor(level/10)+1,6),1)])
		else
			pet:SetShape(math.max(pet:QueryData(DataIndex["shape"]),1))
			pet:SetFace(math.max(FaceFromShape[pet:QueryData(DataIndex["shape"])],0))
		end 
		
		---������ﱻ������
		local Race=ZLuaPetBedgeRaceDesc()
		local race=pet:QueryData(DataIndex["race"])
		
		local PseudoPassiveIncHpGrow=1
	
		if race==Race["renzu"] then 
		elseif race==Race["yaozu"] then 
		elseif race==Race["guizu"] then 
			PseudoPassiveIncHpGrow=1.05
		elseif race==Race["yuzu"] then 
		elseif race==Race["meizu"] then 
		elseif race==Race["tianjiang"] then 
		elseif race==Race["xianling"] then 
		elseif race==Race["dijing"] then 
		elseif race==Race["yeshou"] then 
		elseif race==Race["yishou"] then 
		elseif race==Race["shuizu"] then 
		elseif race==Race["chonggu"] then 
		elseif race==Race["huanling"] then 
		elseif race==Race["siling"] then 
		elseif race==Race["yuansu"] then 
		elseif race==Race["teshu"] then 
		else
		end 
		--[[ ������������
		---���ɳ�����������Ӱ��(PseudoPassiveSkills)
		---����	���Խ���	�����ĳɹ�������3����								1
		---����	����ֱ��	��˯��������15�㡣									1
		---����	��������	���������ʻ�õĳɳ�����5��					1
		---����	ӥ�۶���	��������15�㡣											1
		---����	����֮��	�Ȼ�������15�㡣									1
		---�콫	����֮��	����������15�㡣									1
		---����	�ɶ��칤	������������ֵ����5�㡣							1
		---ɽ��	�������	��Ѫ�ظ��ٶȼӱ���									1
		---Ұ��	Ұ������	����һ���˺�����10����							1
		---����	���ݹ�ע	�ܵ��˺�����10��										1
		---ˮ��	����˴�	�������ĸ����½���									1
		---���	����֮��	����ͨĿ���������20���˺���				1
		---����	��ռ�ȡ	�����ظ��ٶȼӱ���									1
		---����	������־	ѣ�ο�������15�㡣									1
		---Ԫ��	��������	������������15�㡣									1
		---����	��������	��������15�㡣											1
		---����/����/����/����/����/�콫/����/�ؾ�/
			Ұ��/����/ˮ��/���/����/����/Ԫ��/����
		--]]
		
		
		---����2009������ڼ�ץ�����й����岻��ȷ��Bug---��ʼ---------------------------------	
		if pet_tid==30989 and race~=Race["siling"] then
			---��������
				pet:UpdateData(DataIndex["race"], Race["siling"])
			---�����ʼѣ�ο���16��	
				pet:UpdateData(DataIndex["default_resist1"], 16)
			---�������弼��1249
				pet:UpdateData(DataIndex["skillid_9"], 1249)
				pet:UpdateData(DataIndex["skilllvl_9"], 1)
				local LivesList={}
				LivesList=ZLuaPetBedgeLives(pet_tid,serverorigin)
				pet:UpdateData(DataIndex["acuity"], LivesList[7] or 0)	
				pet:UpdateData(DataIndex["stamina"], LivesList[8] or 0)	
				pet:UpdateData(DataIndex["sawy"], LivesList[9] or 0)	
				pet:UpdateData(DataIndex["dowry"], LivesList[10] or 0)	
				pet:UpdateData(DataIndex["wisdom"], LivesList[11] or 0)	
				pet:UpdateData(DataIndex["cnr"], LivesList[12] or 0)
		end
		---����2009������ڼ�ץ�����й����岻��ȷ��Bug---���---------------------------------		
		
					
	
		---//��������
		pet:SetCombatAttrCur(SpecialIndex["hp"],
		math.min(math.floor(pet:QueryData(DataIndex["default_hp"])+(-0.21*(level-1)*(level-1)+102.17*(level-1))
		*PseudoPassiveIncHpGrow
		*pet:QueryData(DataIndex["fatalityinchp"])
		*ZLuaPetTrueGrowthFromGrades(pet:QueryData(DataIndex["potential_hp"]),SpecialIndex["hp"])),64000)
		)
			
		pet:SetCombatAttrCur(SpecialIndex["mp"],
		math.min(math.floor(pet:QueryData(DataIndex["default_mp"])+(-0.168*(level-1)*(level-1)+81.74*(level-1))
		*pet:QueryData(DataIndex["fatalityincmp"])
		*ZLuaPetTrueGrowthFromGrades(pet:QueryData(DataIndex["potential_mp"]),SpecialIndex["mp"])),64000)
		)
		
		pet:SetCombatAttrCur(SpecialIndex["minatk"],
		math.min(math.floor(pet:QueryData(DataIndex["default_minatk"])+(0.1023*(level-1)*(level-1)+1.326*(level-1))
		*pet:QueryData(DataIndex["fatalityincminatk"])
		*ZLuaPetTrueGrowthFromGrades(pet:QueryData(DataIndex["potential_minatk"]),SpecialIndex["minatk"])),64000)
		)
		
		pet:SetCombatAttrCur(SpecialIndex["maxatk"],
		math.min(math.floor(pet:QueryData(DataIndex["default_maxatk"])+(0.1023*(level-1)*(level-1)+1.326*(level-1))
		*pet:QueryData(DataIndex["fatalityincmaxatk"])
		*ZLuaPetTrueGrowthFromGrades(pet:QueryData(DataIndex["potential_maxatk"]),SpecialIndex["maxatk"]))+pea_atk,64000)
		)
		
		pet:SetCombatAttrCur(SpecialIndex["defence"],
		math.min(math.floor(pet:QueryData(DataIndex["default_def"])+(0.04121*(level-1)*(level-1)+0.2*(level-1))
		*pet:QueryData(DataIndex["fatalityincdef"])
		*ZLuaPetTrueGrowthFromGrades(pet:QueryData(DataIndex["potential_def"]),SpecialIndex["defence"]))+pea_def,64000)
		)
		
		pet:SetCombatAttrCur(SpecialIndex["atkrate"],
		math.min(math.floor(pet:QueryData(DataIndex["default_attackrate"])+pet:QueryData(DataIndex["fatalityaddatkrate"])
		+(level-1)*ZLuaPetTrueGrowthFromGrades(pet:QueryData(DataIndex["potential_attackrate"]),SpecialIndex["atkrate"])),64000)
		)
		
		pet:SetCombatAttrCur(SpecialIndex["dodge"],
		math.min(math.floor(pet:QueryData(DataIndex["default_dodge"])+pet:QueryData(DataIndex["fatalityadddodge"])
		+(level-1)*ZLuaPetTrueGrowthFromGrades(pet:QueryData(DataIndex["potential_dodge"]),SpecialIndex["dodge"])),64000)
		)
		
		pet:SetCombatAttrCur(SpecialIndex["res1"],math.floor(pet:QueryData(DataIndex["default_resist1"])+
		(level-1)*pet:QueryData(DataIndex["fatalityincres1"])*
		ZLuaPetTrueGrowthFromGrades(pet:QueryData(DataIndex["potential_resist1"]),SpecialIndex["res1"])))
		
		pet:SetCombatAttrCur(SpecialIndex["res2"],math.floor(pet:QueryData(DataIndex["default_resist2"])+
		(level-1)*pet:QueryData(DataIndex["fatalityincres2"])*
		ZLuaPetTrueGrowthFromGrades(pet:QueryData(DataIndex["potential_resist2"]),SpecialIndex["res2"])))
		
		pet:SetCombatAttrCur(SpecialIndex["res3"],math.floor(pet:QueryData(DataIndex["default_resist3"])+
		(level-1)*pet:QueryData(DataIndex["fatalityincres3"])*
		ZLuaPetTrueGrowthFromGrades(pet:QueryData(DataIndex["potential_resist3"]),SpecialIndex["res3"])))
		
		pet:SetCombatAttrCur(SpecialIndex["res4"],math.floor(pet:QueryData(DataIndex["default_resist4"])+
		(level-1)*pet:QueryData(DataIndex["fatalityincres4"])*
		ZLuaPetTrueGrowthFromGrades(pet:QueryData(DataIndex["potential_resist4"]),SpecialIndex["res4"])))
		
		pet:SetCombatAttrCur(SpecialIndex["res5"],math.floor(pet:QueryData(DataIndex["default_resist5"])+
		(level-1)*pet:QueryData(DataIndex["fatalityincres5"])*
		ZLuaPetTrueGrowthFromGrades(pet:QueryData(DataIndex["potential_resist5"]),SpecialIndex["res5"])))
		
		pet:SetCombatAttrCur(SpecialIndex["res6"],math.floor(pet:QueryData(DataIndex["default_resist6"])+
		(level-1)*pet:QueryData(DataIndex["fatalityincres6"])*
		ZLuaPetTrueGrowthFromGrades(pet:QueryData(DataIndex["potential_resist6"]),SpecialIndex["res6"])))

		local critfromhonor,critdmgfromhonor=0,0
		critfromhonor,critdmgfromhonor=ZLuaPetBedgeCritBenefitByHonor(pet:QueryData(DataIndex["curhonor"]))
		
		pet:SetExtraDamage(pet:QueryData(DataIndex["extradamage"]))
		pet:SetExtraDamageReduce(pet:QueryData(DataIndex["extradamagereduce"]))
		pet:SetCritRate(pet:QueryData(DataIndex["nativecritrate"])+critfromhonor+pet:QueryData(DataIndex["fatalityaddcrit"])+0.01*spirit_crit)
		pet:SetCritDamage(pet:QueryData(DataIndex["nativecritdamage"])+critdmgfromhonor+pet:QueryData(DataIndex["fatalityaddcritdmg"])+0.08*pea_crithurt)
		
		pet:SetAcuity(pet:QueryData(DataIndex["acuity"])+pet:QueryData(DataIndex["fatalityaddacuity"]))
		pet:SetStamina(pet:QueryData(DataIndex["stamina"])+pet:QueryData(DataIndex["fatalityaddstamina"]))
		pet:SetSawy(pet:QueryData(DataIndex["sawy"])+pet:QueryData(DataIndex["fatalityaddsawy"]))
		pet:SetDowry(pet:QueryData(DataIndex["dowry"])+pet:QueryData(DataIndex["fatalityadddowry"]))
		pet:SetWisdom(pet:QueryData(DataIndex["wisdom"])+pet:QueryData(DataIndex["fatalityaddwisdom"]))
		pet:SetCNR(pet:QueryData(DataIndex["cnr"])+pet:QueryData(DataIndex["fatalityaddcnr"]))
		
		if level==1 then
			pet:SetCurHP(pet:QueryCombatAttrCur(SpecialIndex["hp"]))
  		pet:SetCurVigor(pet:QueryCombatAttrCur(SpecialIndex["mp"]))
  	end
  	
end 
---��������-------------------------------------------------------------------------------
function PetBedgeLevelUp(pet_tid,pet,origin)
		ZLuaPetBedgeRebuild(pet_tid,pet,origin,_,_)
		local SpecialIndex=ZLuaPetBedgeSpecialIndex()
		pet:SetCurHP(pet:QueryCombatAttrCur(SpecialIndex["hp"]))
  	---pet:SetCurVigor(pet:QueryCombatAttrCur(SpecialIndex["mp"]))
		return pet_tid;
end
---����ѱ��-------------------------------------------------------------------------------
function PetBedgeAdopt(pet_tid,pet,origin)
		local DataIndex=ZLuaPetBedgeDataIndex()
		local availablePets = ZLuaAvailablePets()
			pet:SetLevel(1)
		 	pet:UpdateData(DataIndex["identify"], 1)
		 	pet:SetCurHonorPoint(math.max(pet:QueryCurHonorPoint()/2,1))
	 		pet:SetMaxHonorPoint(math.max(pet:QueryMaxHonorPoint()/2,80))
	 		pet:SetCurHungerPoint(450)
	 		pet:SetMaxHungerPoint(500)
	 		ZLuaPetBedgeRollBack(pet_tid,pet)
	 		pet:UpdateData(DataIndex["feedaids"],0)
	 		ZLuaPetBedgeRebuild(pet_tid,pet,origin,_,_)
			return pet_tid;
end 
---��������-------------------------------------------------------------------------------
function PetBedgeDead(pet_tid,pet,dead_type)
  ---//dead_type  0:����ɱ��	1:���˻��߱��˵ĳ���ɱ��  
  if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then 
  	return 0 
  end
	
	if dead_type==0 then 
		local PetLife=pet:QueryLife()
		local	PetStar=pet:QueryStar()
		local PetCurHonor=pet:QueryCurHonorPoint()
		local PetMaxHonor=pet:QueryMaxHonorPoint()
		
		local NewPetLife,NewPetCurHonor,NewPetMaxHonor
		local DataIndex=ZLuaPetBedgeDataIndex()
		local petlevel=pet:QueryLevel()
		local fatalityskillid=pet:QueryData(DataIndex["skillid_8"])
		
		local lifereduce=1
		if petlevel>=60 then  
			lifereduce=math.floor(petlevel/3)+1
		end 
		
		if petlevel>=60 and fatalityskillid==1398 and PetStar>=8 then 
			lifereduce=math.floor(0.75*petlevel/3)+1
		end 

		if fatalityskillid==1397 and PetStar>=8 then 
			NewPetLife=math.max(PetLife-lifereduce,pet:QueryAge())
			NewPetCurHonor=math.max(math.floor(PetCurHonor*0.925),1)
			NewPetMaxHonor=math.min(math.max(math.ceil(PetMaxHonor*1),NewPetCurHonor,80),57600)				
		else 
			NewPetLife=math.max(PetLife-lifereduce,pet:QueryAge())
			NewPetCurHonor=math.max(math.floor(PetCurHonor*0.9),1)
			NewPetMaxHonor=math.min(math.max(math.ceil(PetMaxHonor*1),NewPetCurHonor,80),57600)
		end 
		
		pet:SetLife(NewPetLife)
		pet:SetCurHonorPoint(NewPetCurHonor)
	  pet:SetMaxHonorPoint(NewPetMaxHonor)

   ---//����������������������rollback������	
	  ZLuaPetBedgeRollBack(pet_tid,pet)

    local origin=pet:QueryData(DataIndex["nativeorigin"])
	  ZLuaPetBedgeRebuild(pet_tid,pet,origin,_,_)
 
 	else 	
		---//���˺��˵ĳ����ɱ����ʧ
	end 
  pet:SetCurHP(2*pet:QueryLevel())
  pet:SetCurVigor(5)
  return pet_tid;
end

---//��������ֻ�/��������/����������Ӱ��
function ZLuaPetBedgeFatalityEffect(pet_tid,pet,origin)
		
		local DataIndex=ZLuaPetBedgeDataIndex()
		local level=pet:QueryLevel()	 	
		local star=pet:QueryStar()
		---//�ֻ�Ӱ��
		local fatalityskill=pet:QueryData(DataIndex["skillid_8"])
	
		---//��������
		local buddhaskillid=pet:QueryData(DataIndex["skillid_10"])
		local buddhaskilllvl=pet:QueryData(DataIndex["skilllvl_10"])
	


		---//��������
		local peaskillid=pet:QueryData(DataIndex["skillid_11"])
		local peaskilllvl=pet:QueryData(DataIndex["skilllvl_11"])
				 	
	 	if level>150 or level<1 or type(level)~="number" then level=1 end 
	 	if star>20 or star<1 or type(star)~="number" then star=1 end 
	 	
	 	pet:UpdateData(DataIndex["fatalityinchp"], 1)
		pet:UpdateData(DataIndex["fatalityincmp"], 1)
		pet:UpdateData(DataIndex["fatalityincminatk"], 1)
		pet:UpdateData(DataIndex["fatalityincmaxatk"], 1)
		pet:UpdateData(DataIndex["fatalityincdef"], 1)  
		pet:UpdateData(DataIndex["fatalityaddatkrate"], 0)
		pet:UpdateData(DataIndex["fatalityadddodge"], 0)
		pet:UpdateData(DataIndex["fatalityincres1"], 1)
		pet:UpdateData(DataIndex["fatalityincres2"], 1)
		pet:UpdateData(DataIndex["fatalityincres3"], 1)
		pet:UpdateData(DataIndex["fatalityincres4"], 1)
		pet:UpdateData(DataIndex["fatalityincres5"], 1)
		pet:UpdateData(DataIndex["fatalityincres6"], 1)
		pet:UpdateData(DataIndex["fatalityaddcrit"], 0)
		pet:UpdateData(DataIndex["fatalityaddcritdmg"], 0)
		pet:UpdateData(DataIndex["fatalityaddacuity"], 0)		---//��ֲ
		pet:UpdateData(DataIndex["fatalityaddstamina"], 0)	---//�ɷ�
		pet:UpdateData(DataIndex["fatalityaddsawy"], 0)			---//����
		pet:UpdateData(DataIndex["fatalityadddowry"], 0)		---//����
		pet:UpdateData(DataIndex["fatalityaddwisdom"], 0)		---//���
		pet:UpdateData(DataIndex["fatalityaddcnr"], 0)			---//����
	 	
 		 		
	 	if fatalityskill==1368 then 	---//������
			pet:UpdateData(DataIndex["fatalityadddowry"], math.floor(level/90)*5)
		elseif fatalityskill==1369 then  ---//������
			pet:UpdateData(DataIndex["fatalityaddstamina"], math.floor(level/90)*5)
		elseif fatalityskill==1370 then 			---//������
			pet:UpdateData(DataIndex["fatalityaddwisdom"], math.floor(level/90)*5)
		elseif fatalityskill==1371 then 			---//��������
			pet:UpdateData(DataIndex["fatalityaddsawy"], math.floor(level/90)*5)
		elseif fatalityskill==1372 then 			---//������
			pet:UpdateData(DataIndex["fatalityaddcnr"], math.floor(level/90)*5)
		elseif fatalityskill==1373 then 			---//�Ƕ���
			pet:UpdateData(DataIndex["fatalityaddacuity"], math.floor(level/90)*2)
			pet:UpdateData(DataIndex["fatalityaddstamina"], math.floor(level/90)*2)
			pet:UpdateData(DataIndex["fatalityaddsawy"], math.floor(level/90)*2)
			pet:UpdateData(DataIndex["fatalityadddowry"], math.floor(level/90)*2)
			pet:UpdateData(DataIndex["fatalityaddwisdom"], math.floor(level/90)*2)
			pet:UpdateData(DataIndex["fatalityaddcnr"], math.floor(level/90)*2)
		elseif fatalityskill==1374 then 			---//��ţսʿ
			pet:UpdateData(DataIndex["fatalityincres1"], 1+0.01*math.floor(level/15))
		elseif fatalityskill==1375 then			---//��ȥ��
			local weakness=0.01*math.floor(pet:QueryData(DataIndex["potential_resist2"])/1500)
			pet:UpdateData(DataIndex["fatalityincres1"], 1+weakness)
			pet:UpdateData(DataIndex["fatalityincres3"], 1+weakness)
		  pet:UpdateData(DataIndex["fatalityincres4"], 1+weakness)
		  pet:UpdateData(DataIndex["fatalityincres5"], 1+weakness)
		  pet:UpdateData(DataIndex["fatalityincres6"], 1)
		elseif fatalityskill==1376 then 		---//��Ԫ��
			pet:UpdateData(DataIndex["fatalityincres3"], 1+0.01*star)
		elseif fatalityskill==1377 then 		---//���ɲ���
			local charm=0.01*math.floor(pet:QueryData(DataIndex["potential_resist4"])/666)
			pet:UpdateData(DataIndex["fatalityincres4"], 1+charm)
		elseif fatalityskill==1378 then 		---//�������
			if pet:QueryData(DataIndex["potential_resist5"])>=3000 then 
				pet:UpdateData(DataIndex["fatalityincmp"], 1.02)
				pet:UpdateData(DataIndex["fatalityincdef"], 1.01)
			end 		
		elseif fatalityskill==1379 then 		---//����
			if pet:QueryData(DataIndex["potential_hp"])>=2000 and pet:QueryData(DataIndex["potential_mp"])>=2000
			and pet:QueryData(DataIndex["potential_minatk"])>=2000 and pet:QueryData(DataIndex["potential_maxatk"])>=2000
			and pet:QueryData(DataIndex["potential_def"])>=2000 and pet:QueryData(DataIndex["potential_attackrate"])>=2000
			and pet:QueryData(DataIndex["potential_dodge"])>=2000 and pet:QueryData(DataIndex["potential_resist1"])>=2000
			and pet:QueryData(DataIndex["potential_resist2"])>=2000 and pet:QueryData(DataIndex["potential_resist3"])>=2000
			and pet:QueryData(DataIndex["potential_resist4"])>=2000 and pet:QueryData(DataIndex["potential_resist5"])>=2000
			then 
				pet:UpdateData(DataIndex["fatalityincmaxatk"], 1.02)		
			end 		
		elseif fatalityskill==1380 then 		---//�˲�
			if star>=(level/10) then 
			pet:UpdateData(DataIndex["fatalityaddcrit"], 0.01)
			pet:UpdateData(DataIndex["fatalityadddodge"], 5)
			end 		
		elseif fatalityskill==1381 then 		---//��߸
			if pet:QueryData(DataIndex["age"])*10<=pet:QueryData(DataIndex["life"]) then 
			pet:UpdateData(DataIndex["fatalityaddcritdmg"], 0.15)	
			end 
		elseif fatalityskill==1382 then 		---//����
			if pet:QueryMaxHonorPoint()>=20000 then 
				pet:UpdateData(DataIndex["fatalityincminatk"], 1.01)	
				pet:UpdateData(DataIndex["fatalityincmaxatk"], 1.01)	
			end 	
		elseif fatalityskill==1383 then 		---//�Ƕ�ʿ
			if pet:QueryData(DataIndex["potential_maxatk"])>=3500 then 
				pet:UpdateData(DataIndex["fatalityincmaxatk"], 1.01)
				pet:UpdateData(DataIndex["fatalityaddcritdmg"], 0.05)		
			end 
		elseif fatalityskill==1384 then			---//�ѻ���
			if pet:QueryData(DataIndex["potential_attackrate"])>=3500 then 
				pet:UpdateData(DataIndex["fatalityinchp"], 1.02)
			end  
		elseif fatalityskill==1385 then 		---//ħ��ʦ
			if pet:QueryData(DataIndex["potential_mp"])>=3500 then 
				pet:UpdateData(DataIndex["fatalityincmaxatk"], 1.02)
			end 
		elseif fatalityskill==1386 then 		---//��Ѫ��
			if pet:QueryData(DataIndex["potential_hp"])>=3500 then 
				pet:UpdateData(DataIndex["fatalityincdef"], 1.01)
			end 		
		elseif fatalityskill==1387 then			---//ʮ�־�
			if pet:QueryData(DataIndex["potential_def"])>=3500 then 
				pet:UpdateData(DataIndex["fatalityincres1"], 1.02)
				pet:UpdateData(DataIndex["fatalityincres2"], 1.02)
				pet:UpdateData(DataIndex["fatalityincres3"], 1.02)
				pet:UpdateData(DataIndex["fatalityincres4"], 1.02)
				pet:UpdateData(DataIndex["fatalityincres5"], 1.02)
			end  
		elseif fatalityskill==1388 then 		---//����
			if star>=12 then 
				pet:UpdateData(DataIndex["fatalityincmaxatk"], 1.01)
				pet:UpdateData(DataIndex["fatalityinchp"], 1.01)
			end 
		elseif fatalityskill==1389 then 		---//����ʦ
			if math.ceil(star/2)-math.floor(star/2)<1 then 
				pet:UpdateData(DataIndex["fatalityincmaxatk"], 1.02)
			else 
				pet:UpdateData(DataIndex["fatalityinchp"], 1.02)
			end 
		elseif fatalityskill==1390 then			---//͸����
			if pet:QueryData(DataIndex["potential_attackrate"])>=3500 and pet:QueryData(DataIndex["potential_dodge"])>=3500 then 
				pet:UpdateData(DataIndex["fatalityincmaxatk"], 1.01)
				pet:UpdateData(DataIndex["fatalityincmp"], 1.02)
			end 
		elseif fatalityskill==1391 then 		---//̫����ʦ
			if star<10 then 
				pet:UpdateData(DataIndex["fatalityinchp"], 0.97)
				pet:UpdateData(DataIndex["fatalityincmp"], 0.97)												
			else 
				pet:UpdateData(DataIndex["fatalityinchp"], 1)
				pet:UpdateData(DataIndex["fatalityincmp"], 1)
				pet:UpdateData(DataIndex["fatalityaddcrit"], 0.01)	
				pet:UpdateData(DataIndex["fatalityaddcritdmg"], 0.05)
			end 
	 	elseif fatalityskill==1392 then			---//֩����
	 		if pet:QueryData(DataIndex["potential_dodge"])>=3500 and pet:QueryData(DataIndex["potential_resist3"])>=3500 then 
	 			pet:UpdateData(DataIndex["fatalityinchp"], 1.01)
				pet:UpdateData(DataIndex["fatalityincmp"], 1.01)	
	 		end 
	 	elseif fatalityskill==1393 then			---//����
	 		local res1=pet:QueryData(DataIndex["potential_resist1"])
	 		local res2=pet:QueryData(DataIndex["potential_resist2"])
	 		local res3=pet:QueryData(DataIndex["potential_resist3"])
	 		local res4=pet:QueryData(DataIndex["potential_resist4"])
	 		local res5=pet:QueryData(DataIndex["potential_resist5"])
	 		if res1+res2+res3+res4+res5>=15000 then 
	 			pet:UpdateData(DataIndex["fatalityincres1"], 1.02)
		  	pet:UpdateData(DataIndex["fatalityincres2"], 1.02)
		  	pet:UpdateData(DataIndex["fatalityincres3"], 1.02)
		  	pet:UpdateData(DataIndex["fatalityincres4"], 1.02)
		  	pet:UpdateData(DataIndex["fatalityincres5"], 1.02)	
	 		end 	 		
	 	elseif fatalityskill==1394 then 			---//��ũ����
	 		pet:UpdateData(DataIndex["fatalityaddacuity"], math.floor(level/90)*5)
	 		
	 	else
		 	---//������1397
		 	---//������1398
		 	---//others
		 	pet:UpdateData(DataIndex["fatalityinchp"], 1)
		  pet:UpdateData(DataIndex["fatalityincmp"], 1)
		  pet:UpdateData(DataIndex["fatalityincminatk"], 1)
		  pet:UpdateData(DataIndex["fatalityincmaxatk"], 1)
		  pet:UpdateData(DataIndex["fatalityincdef"], 1)  
		  pet:UpdateData(DataIndex["fatalityaddatkrate"], 0)
		  pet:UpdateData(DataIndex["fatalityadddodge"], 0)
		  pet:UpdateData(DataIndex["fatalityincres1"], 1)
		  pet:UpdateData(DataIndex["fatalityincres2"], 1)
		  pet:UpdateData(DataIndex["fatalityincres3"], 1)
		  pet:UpdateData(DataIndex["fatalityincres4"], 1)
		  pet:UpdateData(DataIndex["fatalityincres5"], 1)
		  pet:UpdateData(DataIndex["fatalityincres6"], 1)
		  pet:UpdateData(DataIndex["fatalityaddcrit"], 0)
		  pet:UpdateData(DataIndex["fatalityaddcritdmg"], 0)
		  pet:UpdateData(DataIndex["fatalityaddacuity"], 0)
		  pet:UpdateData(DataIndex["fatalityaddstamina"], 0)
		  pet:UpdateData(DataIndex["fatalityaddsawy"], 0)
		  pet:UpdateData(DataIndex["fatalityadddowry"], 0)
		  pet:UpdateData(DataIndex["fatalityaddwisdom"], 0)
		  pet:UpdateData(DataIndex["fatalityaddcnr"], 0)
	 	end   
		---//���������������-------
		if buddhaskilllvl<0 or buddhaskilllvl>20 then buddhaskilllvl=0 end 
		if  buddhaskillid==1356 then 
			pet:UpdateData(DataIndex["fatalityincminatk"], pet:QueryData(DataIndex["fatalityincminatk"])+0.01*buddhaskilllvl+0.0025*star*buddhaskilllvl)
		  pet:UpdateData(DataIndex["fatalityincmaxatk"], pet:QueryData(DataIndex["fatalityincmaxatk"])+0.01*buddhaskilllvl+0.0025*star*buddhaskilllvl)
		elseif  buddhaskillid==1357 then
		  pet:UpdateData(DataIndex["fatalityincdef"], pet:QueryData(DataIndex["fatalityincdef"])+0.01*buddhaskilllvl+0.0015*star*buddhaskilllvl) 
		elseif  buddhaskillid==1358 then
			pet:UpdateData(DataIndex["fatalityincminatk"], pet:QueryData(DataIndex["fatalityincminatk"])+0.01*buddhaskilllvl+0.0025*star*buddhaskilllvl)
		  pet:UpdateData(DataIndex["fatalityincmaxatk"], pet:QueryData(DataIndex["fatalityincmaxatk"])+0.01*buddhaskilllvl+0.0025*star*buddhaskilllvl)
		  pet:UpdateData(DataIndex["fatalityincdef"], pet:QueryData(DataIndex["fatalityincdef"])+0.01*buddhaskilllvl+0.0015*star*buddhaskilllvl) 
		else
		
		end 
		
		---//�������������-------
		if peaskillid>=1262 and  peaskillid<=1270 and peaskilllvl>=0 and peaskilllvl<=99 then 
		
			local para1=math.max(peaskillid-1262,0)
			local para2=peaskilllvl
			local sumpara=para1*99+para2
			if peaskilllvl==99 then 
				return 2*sumpara,sumpara,para1+1
			else
				return 2*sumpara,sumpara,para1
			end 
		else 
			return 0,0,0
		end 

end 
---//ר�����������������Ҫrollback�����-----------------------------------------------------------
function ZLuaPetBedgeRollBack(pet_tid,pet)
		
		if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return 0 end
		if pet == nil then return 0 end
		local DataIndex=ZLuaPetBedgeDataIndex()
		local ServerOrigins=ZLuaPetBedgeOrigins()
		local availablePets = ZLuaAvailablePets()
		
		local PetHoroscope=pet:QueryHoroscope()
		local Horoscope= ZLuaPetBedgeHoroscopeDesc()	
	
	  local DescriptionID=1359
	  if PetHoroscope==Horoscope["riyao"] then				---����
			DescriptionID=1359
		elseif PetHoroscope==Horoscope["yueyao"] then		---����
			DescriptionID=1360
		elseif PetHoroscope==Horoscope["jinyao"] then		---����
			DescriptionID=1361
		elseif PetHoroscope==Horoscope["muyao"] then		---ľ��
			DescriptionID=1362
		elseif PetHoroscope==Horoscope["shuiyao"] then	---ˮ��
			DescriptionID=1363
		elseif PetHoroscope==Horoscope["huoyao"] then		---����
			DescriptionID=1364
		elseif PetHoroscope==Horoscope["tuyao"] then		---����
			DescriptionID=1365
		elseif PetHoroscope==Horoscope["luohou"] then		---�޺�
			DescriptionID=1366
		elseif PetHoroscope==Horoscope["jidu"] then			---�ƶ�
			DescriptionID=1367
		else
		 	DescriptionID=1359
		end 
	  pet:UpdateData(DataIndex["skillid_10"], DescriptionID or 0)
		pet:UpdateData(DataIndex["skilllvl_10"],1)

end 		

---//������������弼��
function ZLuaPetBedgeSpiritEffect(pet_tid,pet,origin)
	local DataIndex=ZLuaPetBedgeDataIndex()
	local SpecialIndex=ZLuaPetBedgeSpecialIndex()
	local availablePets = ZLuaAvailablePets()
	
	local raceskillid=pet:QueryData(DataIndex["skillid_9"])	
	local raceskilllvl=0
	
	if raceskillid==1355 then
	 raceskilllvl=pet:QueryData(DataIndex["skilllvl_9"])	
	else
	 raceskilllvl=0
	end  

	return raceskilllvl
end 