﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinAgentExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/agent/get 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90227 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90363 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90845 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAgentGetResponse> ExecuteCgibinAgentGetAsync(this WechatWorkClient client, Models.CgibinAgentGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AgentId == null)
                request.AgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "agent", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("agentid", request.AgentId);

            return await client.SendRequestWithJsonAsync<Models.CgibinAgentGetResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/agent/list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90227 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90363 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90845 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAgentListResponse> ExecuteCgibinAgentListAsync(this WechatWorkClient client, Models.CgibinAgentListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "agent", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinAgentListResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/agent/set 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90228 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAgentSetResponse> ExecuteCgibinAgentSetAsync(this WechatWorkClient client, Models.CgibinAgentSetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AgentId == null)
                request.AgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "agent", "set")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinAgentSetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/agent/set_scope 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90583 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90807 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAgentSetScopeResponse> ExecuteCgibinAgentSetScopeAsync(this WechatWorkClient client, Models.CgibinAgentSetScopeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AgentId == null)
                request.AgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "agent", "set_scope")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinAgentSetScopeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Workbench
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/agent/set_workbench_template 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92535 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94620 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAgentSetWorkbenchTemplateResponse> ExecuteCgibinAgentSetWorkbenchTemplateAsync(this WechatWorkClient client, Models.CgibinAgentSetWorkbenchTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AgentId == null)
                request.AgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "agent", "set_workbench_template")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinAgentSetWorkbenchTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/agent/get_workbench_template 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92535 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94620 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAgentGetWorkbenchTemplateResponse> ExecuteCgibinAgentGetWorkbenchTemplateAsync(this WechatWorkClient client, Models.CgibinAgentGetWorkbenchTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AgentId == null)
                request.AgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "agent", "get_workbench_template")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinAgentGetWorkbenchTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/agent/set_workbench_data 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92535 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94620 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAgentSetWorkbenchDataResponse> ExecuteCgibinAgentSetWorkbenchDataAsync(this WechatWorkClient client, Models.CgibinAgentSetWorkbenchDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AgentId == null)
                request.AgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "agent", "set_workbench_data")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinAgentSetWorkbenchDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
