-- �ٻ��ű�
-- �������нű�ֻ�����ٻ������ʼ����ʱ����ܵ���
--
--
--

function Summon_Init_Entrance(id, skill_level, player_imp, summon_imp, index)
	local player = {}
	Object_InnerInit(player_imp, player, 1)

	local monster = {}
	Object_InnerInit(summon_imp, monster, 2)

	return InitSummonData(id, skill_level, player, monster, index)
end

xdofile("object_script.lua")
xdofile("script/summon_interface.lua")

