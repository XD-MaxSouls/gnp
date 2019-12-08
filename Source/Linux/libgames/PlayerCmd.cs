using System;
using System.Text;
using System.Collections.Generic;

namespace GAME
{
    /// <summary>
    /// 角色游戏命令类
    /// </summary>
    public class GPlayerCmd
    {
        private delegate void CmdHandler(string sCmd, string sParam0, string sParam1, string sParam2, string sParam3, string sParam4, string sParam5, string sParam6);
        private GPlayerImp _imp = null;
        private Dictionary<string,CmdHandler> _cmdhandler = new Dictionary<string,CmdHandler>();
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="imp">角色对象</param>
        public GPlayerCmd(GPlayerImp imp)
        {
            _imp = imp;
            _cmdhandler.Add("test", OnCmdTest);
        }
        /// <summary>
        /// 游戏命令处理函数
        /// </summary>
        /// <param name="sCmd">命令名称</param>
        /// <param name="sParam0">参数0</param>
        /// <param name="sParam1">参数1</param>
        /// <param name="sParam2">参数2</param>
        /// <param name="sParam3">参数3</param>
        /// <param name="sParam4">参数4</param>
        /// <param name="sParam5">参数5</param>
        /// <param name="sParam6">参数6</param>
        /// <returns>是否处理命令</returns>
        public bool OnCmdHandler(string sCmd, string sParam0, string sParam1, string sParam2, string sParam3, string sParam4, string sParam5, string sParam6)
        {
            bool boResult = false;

            if (_cmdhandler.ContainsKey(sCmd) != false)
            {
                _cmdhandler[sCmd](sCmd, sParam0, sParam1, sParam2, sParam3, sParam4, sParam5, sParam6);
                boResult = true;
            }
            return boResult;
        }
        public void OnCmdTest(string sCmd, string sParam0, string sParam1, string sParam2, string sParam3, string sParam4, string sParam5, string sParam6)
        {
            GMatrix matrix = GMatrix.GetMatrix();
            string sText = string.Format("GPlayerCmd::OnTest {0},{1},{2},{3},{4},{5},{6}", sParam0, sParam1, sParam2, sParam3, sParam4, sParam5, sParam6);

            matrix.BroadcastMsg(sText, 9);
        }
    }
}
