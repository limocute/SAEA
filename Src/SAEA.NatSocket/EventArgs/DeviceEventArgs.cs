﻿/****************************************************************************
*Copyright (c) 2018 Microsoft All Rights Reserved.
*CLR版本： 2.1.4
*机器名称：WENLI-PC
*公司名称：wenli
*命名空间：SAEA.NatSocket
*文件名： Class1
*版本号： V3.0.0.1
*唯一标识：ef84e44b-6fa2-432e-90a2-003ebd059303
*当前的用户域：WENLI-PC
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2018/3/1 15:54:21
*描述：
*
*=====================================================================
*修改标记
*修改时间：2018/3/1 15:54:21
*修改人： yswenli
*版本号： V3.0.0.1
*描述：
*
*****************************************************************************/
using SAEA.NatSocket.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAEA.NatSocket.EventArgs
{
    internal class DeviceEventArgs : System.EventArgs
    {
        public DeviceEventArgs(NatDevice device)
        {
            Device = device;
        }

        public NatDevice Device { get; private set; }
    }
}
