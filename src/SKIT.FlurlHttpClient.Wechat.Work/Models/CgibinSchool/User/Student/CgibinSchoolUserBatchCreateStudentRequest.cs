﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/user/batch_create_student 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolUserBatchCreateStudentRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Student
            {
                /// <summary>
                /// 获取或设置学生账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("student_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("student_userid")]
                public string StudentUserId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置学生姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置学生所在的部门 ID（即班级）列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department")]
                [System.Text.Json.Serialization.JsonPropertyName("department")]
                public IList<int> DepartmentIdList { get; set; } = new List<int>();
            }
        }

        /// <summary>
        /// 获取或设置学生列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("students")]
        [System.Text.Json.Serialization.JsonPropertyName("students")]
        public IList<Types.Student> StudentList { get; set; } = new List<Types.Student>();
    }
}
