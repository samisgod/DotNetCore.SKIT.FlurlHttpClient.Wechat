﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /customservice/msgrecord/getmsglist 接口的请求。</para>
    /// </summary>
    public class CustomServiceMessageRecordGetMessageListRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("starttime")]
        [System.Text.Json.Serialization.JsonPropertyName("starttime")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endtime")]
        [System.Text.Json.Serialization.JsonPropertyName("endtime")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgid")]
        [System.Text.Json.Serialization.JsonPropertyName("msgid")]
        public long MessageId { get; set; } = 1;

        /// <summary>
        /// 获取或设置每次获取条数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("number")]
        [System.Text.Json.Serialization.JsonPropertyName("number")]
        public int Limit { get; set; } = 10;
    }
}
