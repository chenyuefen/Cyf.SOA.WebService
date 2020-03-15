using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.SOA.Project
{
    /// <summary>
    /// 1 SOA的思想，分布式服务
    /// 2 WebService声明调用授权，Remoting比较
    /// 3 单元测试服务调用
    /// 
    /// 能听见我说话的，能看到我桌面的，刷个1
    /// 平时vip课程不等人的，20:00准时开始，希望大家尽量能提前5分钟
    /// 我今天是忙到6点了，不敢回家，路上堵，怕耽搁，19:35左右开始分享，今天在公司给大家上课(不拖堂太久)
    /// 高级班的传统，准备好学习的小伙伴儿，给Eleven老师刷一个专属字母E，然后课程就正式开始了！！！
    /// 
    /// SOA:面向服务架构，是构造分布式系统的方法论，也会提供一些标准、工具。
    /// 
    /// WebService:寄宿在IIS，也就是必须在网站项目
    /// Http协议  SOAP协议
    /// 1 Http传输信道，A服务器到B服务器，数据是什么格式传递的
    /// 2 XML的数据格式---Http传输解析得到的有用数据
    /// 3 SOAP协议---封装格式：在分布式的环境中，描述了如何做数据交换的一个轻量级协议
    /// 4 WSDL：属于webservice的标配，标准化描述服务，方便调用
    /// 5 UDDI：根据描述查找服务的机制
    /// 
    /// 服务端调用WebService添加服务引用，基于svcUtil.exe生成的
    /// 基于wsdl生成的一个代理：屏蔽服务调用的复杂性
    /// 
    /// 单元测试：测试方法---回归测试
    /// 
    /// WebService安全认证：
    /// Form认证  windows认证
    /// 服务方法里面添加账号密码参数
    /// SoapHeader验证
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.Net高级班VIP课程，今晚是Eleven老师为你带来的SOA系列课程");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
