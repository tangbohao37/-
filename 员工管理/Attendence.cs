using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 员工管理
{
    static class Attendence
    {
        /// <summary>
        /// 根据 计划时间 现在时间  打卡提前时间（int） 打开后延续时间（int） 计算是否迟到
        ///  返回值   1：成功  2：迟到； 3：未到；
        ///  调用前 需要 先判断是否为当天
        /// </summary>
        /// <param name="ptime"> 计划时间</param>
        /// <param name="ntime">现在</param>
        /// <param name="befotime">提前时间</param>
        /// <param name="aftertime">延续时间</param>
        /// <returns></returns>
        public static int Att(DateTime ptime, DateTime ntime, int befotime, int aftertime)
        {
            int state;    //返回状态    1：为成功打卡； 2：迟到； 3：未到；
            DateTime ptEnd = ptime.AddMinutes(aftertime);//结束打卡时间
            DateTime ptStart = ptime.AddMinutes(0 - befotime);//开始打卡时间
            TimeSpan tsPlanS = ptime.Subtract(ptStart); //计划打卡时间与计划开始时间的差，
            TimeSpan tsPlanE = ptEnd.Subtract(ntime);//计划结束打卡时间与现在时间的查
            TimeSpan tsNow = ntime.Subtract(ptStart);//现在时间开始打卡时间的差

            //判断里不考虑 天数。 在程序初始化的时候判断 是否为当天。
            //int daySpan=Convert.ToInt32( tsPlan.Days);
            //int hoursSpan=Convert.ToInt32(tsPlan.Hours);
            int minSpan = Convert.ToInt32(tsPlanS.Minutes);

            if (Convert.ToInt32(tsNow) > 0 && tsNow < tsPlanS)
            {
                return state = 1;
            }
            if (tsPlanE >= tsNow)
            {
                return state = 2;
            }
            else
            {
                return 3;
            }
        }

    }
}
