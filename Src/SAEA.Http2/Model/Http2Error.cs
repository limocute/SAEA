﻿/****************************************************************************
*项目名称：SAEA.Http2.Model
*CLR 版本：4.0.30319.42000
*机器名称：WENLI-PC
*命名空间：SAEA.Http2.Model
*类 名 称：Http2Error
*版 本 号：V1.0.0.0
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2019/6/27 16:05:14
*描述：
*=====================================================================
*修改时间：2019/6/27 16:05:14
*修 改 人： yswenli
*版 本 号： V1.0.0.0
*描    述：
*****************************************************************************/

namespace SAEA.Http2.Model
{
    /// <summary>
    /// 携带发生错误的信息
    /// </summary>
    public struct Http2Error
    {
        public ErrorCode Code;

        public uint StreamId;

        public string Message;

        public override string ToString()
        {
            return $"Http2Error{{streamId={StreamId}, code={Code}, message=\"{Message}\"}}";
        }
    }
}