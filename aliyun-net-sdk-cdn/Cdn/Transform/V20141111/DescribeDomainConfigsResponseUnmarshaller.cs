/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainConfigsResponseUnmarshaller
    {
        public static DescribeDomainConfigsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainConfigsResponse describeDomainConfigsResponse = new DescribeDomainConfigsResponse();

			describeDomainConfigsResponse.HttpResponse = context.HttpResponse;
			describeDomainConfigsResponse.RequestId = context.StringValue("DescribeDomainConfigs.RequestId");

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs domainConfigs = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs();

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_CcConfig ccConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_CcConfig();
			ccConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.CcConfig.ConfigId");
			ccConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.CcConfig.Enable");
			ccConfig.AllowIps = context.StringValue("DescribeDomainConfigs.DomainConfigs.CcConfig.AllowIps");
			ccConfig.BlockIps = context.StringValue("DescribeDomainConfigs.DomainConfigs.CcConfig.BlockIps");
			ccConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.CcConfig.Status");
			domainConfigs.CcConfig = ccConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_ErrorPageConfig errorPageConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_ErrorPageConfig();
			errorPageConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.ErrorPageConfig.ConfigId");
			errorPageConfig.ErrorCode = context.StringValue("DescribeDomainConfigs.DomainConfigs.ErrorPageConfig.ErrorCode");
			errorPageConfig.PageType = context.StringValue("DescribeDomainConfigs.DomainConfigs.ErrorPageConfig.PageType");
			errorPageConfig.CustomPageUrl = context.StringValue("DescribeDomainConfigs.DomainConfigs.ErrorPageConfig.CustomPageUrl");
			errorPageConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.ErrorPageConfig.Status");
			domainConfigs.ErrorPageConfig = errorPageConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_OptimizeConfig optimizeConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_OptimizeConfig();
			optimizeConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.OptimizeConfig.ConfigId");
			optimizeConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.OptimizeConfig.Enable");
			optimizeConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.OptimizeConfig.Status");
			domainConfigs.OptimizeConfig = optimizeConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_PageCompressConfig pageCompressConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_PageCompressConfig();
			pageCompressConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.PageCompressConfig.ConfigId");
			pageCompressConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.PageCompressConfig.Enable");
			pageCompressConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.PageCompressConfig.Status");
			domainConfigs.PageCompressConfig = pageCompressConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_IgnoreQueryStringConfig ignoreQueryStringConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_IgnoreQueryStringConfig();
			ignoreQueryStringConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.IgnoreQueryStringConfig.ConfigId");
			ignoreQueryStringConfig.HashKeyArgs = context.StringValue("DescribeDomainConfigs.DomainConfigs.IgnoreQueryStringConfig.HashKeyArgs");
			ignoreQueryStringConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.IgnoreQueryStringConfig.Enable");
			ignoreQueryStringConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.IgnoreQueryStringConfig.Status");
			domainConfigs.IgnoreQueryStringConfig = ignoreQueryStringConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_RangeConfig rangeConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_RangeConfig();
			rangeConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.RangeConfig.ConfigId");
			rangeConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.RangeConfig.Enable");
			rangeConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.RangeConfig.Status");
			domainConfigs.RangeConfig = rangeConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_RefererConfig refererConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_RefererConfig();
			refererConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.RefererConfig.ConfigId");
			refererConfig.ReferType = context.StringValue("DescribeDomainConfigs.DomainConfigs.RefererConfig.ReferType");
			refererConfig.ReferList = context.StringValue("DescribeDomainConfigs.DomainConfigs.RefererConfig.ReferList");
			refererConfig.AllowEmpty = context.StringValue("DescribeDomainConfigs.DomainConfigs.RefererConfig.AllowEmpty");
			refererConfig.DisableAst = context.StringValue("DescribeDomainConfigs.DomainConfigs.RefererConfig.DisableAst");
			refererConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.RefererConfig.Status");
			domainConfigs.RefererConfig = refererConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_ReqAuthConfig reqAuthConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_ReqAuthConfig();
			reqAuthConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqAuthConfig.ConfigId");
			reqAuthConfig.AuthType = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqAuthConfig.AuthType");
			reqAuthConfig.Key1 = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqAuthConfig.Key1");
			reqAuthConfig.Key2 = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqAuthConfig.Key2");
			reqAuthConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqAuthConfig.Status");
			reqAuthConfig.AliAuthWhiteList = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqAuthConfig.AliAuthWhiteList");
			reqAuthConfig.AuthM3u8 = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqAuthConfig.AuthM3u8");
			reqAuthConfig.AuthAddr = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqAuthConfig.AuthAddr");
			reqAuthConfig.AuthRemoteDesc = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqAuthConfig.AuthRemoteDesc");
			reqAuthConfig.TimeOut = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqAuthConfig.TimeOut");
			domainConfigs.ReqAuthConfig = reqAuthConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_SrcHostConfig srcHostConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_SrcHostConfig();
			srcHostConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.SrcHostConfig.ConfigId");
			srcHostConfig.DomainName = context.StringValue("DescribeDomainConfigs.DomainConfigs.SrcHostConfig.DomainName");
			srcHostConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.SrcHostConfig.Status");
			domainConfigs.SrcHostConfig = srcHostConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_VideoSeekConfig videoSeekConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_VideoSeekConfig();
			videoSeekConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.VideoSeekConfig.ConfigId");
			videoSeekConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.VideoSeekConfig.Enable");
			videoSeekConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.VideoSeekConfig.Status");
			domainConfigs.VideoSeekConfig = videoSeekConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_WafConfig wafConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_WafConfig();
			wafConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.WafConfig.ConfigId");
			wafConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.WafConfig.Enable");
			wafConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.WafConfig.Status");
			domainConfigs.WafConfig = wafConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_NotifyUrlConfig notifyUrlConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_NotifyUrlConfig();
			notifyUrlConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.NotifyUrlConfig.Enable");
			notifyUrlConfig.NotifyUrl = context.StringValue("DescribeDomainConfigs.DomainConfigs.NotifyUrlConfig.NotifyUrl");
			domainConfigs.NotifyUrlConfig = notifyUrlConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_RedirectTypeConfig redirectTypeConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_RedirectTypeConfig();
			redirectTypeConfig.RedirectType = context.StringValue("DescribeDomainConfigs.DomainConfigs.RedirectTypeConfig.RedirectType");
			domainConfigs.RedirectTypeConfig = redirectTypeConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_ForwardSchemeConfig forwardSchemeConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_ForwardSchemeConfig();
			forwardSchemeConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.ForwardSchemeConfig.ConfigId");
			forwardSchemeConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.ForwardSchemeConfig.Enable");
			forwardSchemeConfig.SchemeOrigin = context.StringValue("DescribeDomainConfigs.DomainConfigs.ForwardSchemeConfig.SchemeOrigin");
			forwardSchemeConfig.SchemeOriginPort = context.StringValue("DescribeDomainConfigs.DomainConfigs.ForwardSchemeConfig.SchemeOriginPort");
			forwardSchemeConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.ForwardSchemeConfig.Status");
			domainConfigs.ForwardSchemeConfig = forwardSchemeConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_RemoveQueryStringConfig removeQueryStringConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_RemoveQueryStringConfig();
			removeQueryStringConfig.AliRemoveArgs = context.StringValue("DescribeDomainConfigs.DomainConfigs.RemoveQueryStringConfig.AliRemoveArgs");
			removeQueryStringConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.RemoveQueryStringConfig.ConfigId");
			removeQueryStringConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.RemoveQueryStringConfig.Status");
			domainConfigs.RemoveQueryStringConfig = removeQueryStringConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_L2OssKeyConfig l2OssKeyConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_L2OssKeyConfig();
			l2OssKeyConfig.PrivateOssAuth = context.StringValue("DescribeDomainConfigs.DomainConfigs.L2OssKeyConfig.PrivateOssAuth");
			l2OssKeyConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.L2OssKeyConfig.ConfigId");
			l2OssKeyConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.L2OssKeyConfig.Status");
			domainConfigs.L2OssKeyConfig = l2OssKeyConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_MacServiceConfig macServiceConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_MacServiceConfig();
			macServiceConfig.AppList = context.StringValue("DescribeDomainConfigs.DomainConfigs.MacServiceConfig.AppList");
			macServiceConfig.Enabled = context.StringValue("DescribeDomainConfigs.DomainConfigs.MacServiceConfig.Enabled");
			macServiceConfig.ProcessResult = context.StringValue("DescribeDomainConfigs.DomainConfigs.MacServiceConfig.ProcessResult");
			macServiceConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.MacServiceConfig.ConfigId");
			macServiceConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.MacServiceConfig.Status");
			domainConfigs.MacServiceConfig = macServiceConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_GreenManagerConfig greenManagerConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_GreenManagerConfig();
			greenManagerConfig.Enabled = context.StringValue("DescribeDomainConfigs.DomainConfigs.GreenManagerConfig.Enabled");
			greenManagerConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.GreenManagerConfig.ConfigId");
			greenManagerConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.GreenManagerConfig.Status");
			domainConfigs.GreenManagerConfig = greenManagerConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_HttpsOptionConfig httpsOptionConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_HttpsOptionConfig();
			httpsOptionConfig.Http2 = context.StringValue("DescribeDomainConfigs.DomainConfigs.HttpsOptionConfig.Http2");
			httpsOptionConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.HttpsOptionConfig.ConfigId");
			httpsOptionConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.HttpsOptionConfig.Status");
			domainConfigs.HttpsOptionConfig = httpsOptionConfig;

			DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_AliBusinessConfig aliBusinessConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_AliBusinessConfig();
			aliBusinessConfig.AliBusinessTable = context.StringValue("DescribeDomainConfigs.DomainConfigs.AliBusinessConfig.AliBusinessTable");
			aliBusinessConfig.AliBusinessType = context.StringValue("DescribeDomainConfigs.DomainConfigs.AliBusinessConfig.AliBusinessType");
			aliBusinessConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.AliBusinessConfig.ConfigId");
			aliBusinessConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.AliBusinessConfig.Status");
			domainConfigs.AliBusinessConfig = aliBusinessConfig;

			List<DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_CacheExpiredConfig> domainConfigs_cacheExpiredConfigs = new List<DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_CacheExpiredConfig>();
			for (int i = 0; i < context.Length("DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs.Length"); i++) {
				DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_CacheExpiredConfig cacheExpiredConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_CacheExpiredConfig();
				cacheExpiredConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs["+ i +"].ConfigId");
				cacheExpiredConfig.CacheType = context.StringValue("DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs["+ i +"].CacheType");
				cacheExpiredConfig.CacheContent = context.StringValue("DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs["+ i +"].CacheContent");
				cacheExpiredConfig.TTL = context.StringValue("DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs["+ i +"].TTL");
				cacheExpiredConfig.Weight = context.StringValue("DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs["+ i +"].Weight");
				cacheExpiredConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs["+ i +"].Status");

				domainConfigs_cacheExpiredConfigs.Add(cacheExpiredConfig);
			}
			domainConfigs.CacheExpiredConfigs = domainConfigs_cacheExpiredConfigs;

			List<DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_HttpErrorPageConfig> domainConfigs_httpErrorPageConfigs = new List<DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_HttpErrorPageConfig>();
			for (int i = 0; i < context.Length("DescribeDomainConfigs.DomainConfigs.HttpErrorPageConfigs.Length"); i++) {
				DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_HttpErrorPageConfig httpErrorPageConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_HttpErrorPageConfig();
				httpErrorPageConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.HttpErrorPageConfigs["+ i +"].ConfigId");
				httpErrorPageConfig.ErrorCode = context.StringValue("DescribeDomainConfigs.DomainConfigs.HttpErrorPageConfigs["+ i +"].ErrorCode");
				httpErrorPageConfig.PageUrl = context.StringValue("DescribeDomainConfigs.DomainConfigs.HttpErrorPageConfigs["+ i +"].PageUrl");
				httpErrorPageConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.HttpErrorPageConfigs["+ i +"].Status");

				domainConfigs_httpErrorPageConfigs.Add(httpErrorPageConfig);
			}
			domainConfigs.HttpErrorPageConfigs = domainConfigs_httpErrorPageConfigs;

			List<DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_HttpHeaderConfig> domainConfigs_httpHeaderConfigs = new List<DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_HttpHeaderConfig>();
			for (int i = 0; i < context.Length("DescribeDomainConfigs.DomainConfigs.HttpHeaderConfigs.Length"); i++) {
				DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_HttpHeaderConfig httpHeaderConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_HttpHeaderConfig();
				httpHeaderConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.HttpHeaderConfigs["+ i +"].ConfigId");
				httpHeaderConfig.HeaderKey = context.StringValue("DescribeDomainConfigs.DomainConfigs.HttpHeaderConfigs["+ i +"].HeaderKey");
				httpHeaderConfig.HeaderValue = context.StringValue("DescribeDomainConfigs.DomainConfigs.HttpHeaderConfigs["+ i +"].HeaderValue");
				httpHeaderConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.HttpHeaderConfigs["+ i +"].Status");

				domainConfigs_httpHeaderConfigs.Add(httpHeaderConfig);
			}
			domainConfigs.HttpHeaderConfigs = domainConfigs_httpHeaderConfigs;

			List<DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_DynamicConfig> domainConfigs_dynamicConfigs = new List<DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_DynamicConfig>();
			for (int i = 0; i < context.Length("DescribeDomainConfigs.DomainConfigs.DynamicConfigs.Length"); i++) {
				DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_DynamicConfig dynamicConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_DynamicConfig();
				dynamicConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.DynamicConfigs["+ i +"].ConfigId");
				dynamicConfig.DynamicOrigin = context.StringValue("DescribeDomainConfigs.DomainConfigs.DynamicConfigs["+ i +"].DynamicOrigin");
				dynamicConfig.StaticType = context.StringValue("DescribeDomainConfigs.DomainConfigs.DynamicConfigs["+ i +"].StaticType");
				dynamicConfig.StaticUri = context.StringValue("DescribeDomainConfigs.DomainConfigs.DynamicConfigs["+ i +"].StaticUri");
				dynamicConfig.StaticPath = context.StringValue("DescribeDomainConfigs.DomainConfigs.DynamicConfigs["+ i +"].StaticPath");
				dynamicConfig.DynamicCacheControl = context.StringValue("DescribeDomainConfigs.DomainConfigs.DynamicConfigs["+ i +"].DynamicCacheControl");
				dynamicConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.DynamicConfigs["+ i +"].Status");

				domainConfigs_dynamicConfigs.Add(dynamicConfig);
			}
			domainConfigs.DynamicConfigs = domainConfigs_dynamicConfigs;

			List<DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_ReqHeaderConfig> domainConfigs_reqHeaderConfigs = new List<DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_ReqHeaderConfig>();
			for (int i = 0; i < context.Length("DescribeDomainConfigs.DomainConfigs.ReqHeaderConfigs.Length"); i++) {
				DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_ReqHeaderConfig reqHeaderConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_ReqHeaderConfig();
				reqHeaderConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqHeaderConfigs["+ i +"].ConfigId");
				reqHeaderConfig.Key = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqHeaderConfigs["+ i +"].Key");
				reqHeaderConfig._Value = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqHeaderConfigs["+ i +"].Value");
				reqHeaderConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqHeaderConfigs["+ i +"].Status");

				domainConfigs_reqHeaderConfigs.Add(reqHeaderConfig);
			}
			domainConfigs.ReqHeaderConfigs = domainConfigs_reqHeaderConfigs;

			List<DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_SetVarsConfig> domainConfigs_setVarsConfigs = new List<DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_SetVarsConfig>();
			for (int i = 0; i < context.Length("DescribeDomainConfigs.DomainConfigs.SetVarsConfigs.Length"); i++) {
				DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_SetVarsConfig setVarsConfig = new DescribeDomainConfigsResponse.DescribeDomainConfigs_DomainConfigs.DescribeDomainConfigs_SetVarsConfig();
				setVarsConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.SetVarsConfigs["+ i +"].ConfigId");
				setVarsConfig.VarName = context.StringValue("DescribeDomainConfigs.DomainConfigs.SetVarsConfigs["+ i +"].VarName");
				setVarsConfig.VarValue = context.StringValue("DescribeDomainConfigs.DomainConfigs.SetVarsConfigs["+ i +"].VarValue");
				setVarsConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.SetVarsConfigs["+ i +"].Status");

				domainConfigs_setVarsConfigs.Add(setVarsConfig);
			}
			domainConfigs.SetVarsConfigs = domainConfigs_setVarsConfigs;
			describeDomainConfigsResponse.DomainConfigs = domainConfigs;
        
			return describeDomainConfigsResponse;
        }
    }
}