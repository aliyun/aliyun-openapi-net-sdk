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

			DescribeDomainConfigsResponse.DomainConfigs_ domainConfigs = new DescribeDomainConfigsResponse.DomainConfigs_();

			DescribeDomainConfigsResponse.DomainConfigs_.CcConfig_ ccConfig = new DescribeDomainConfigsResponse.DomainConfigs_.CcConfig_();
			ccConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.CcConfig.Enable");
			ccConfig.AllowIps = context.StringValue("DescribeDomainConfigs.DomainConfigs.CcConfig.AllowIps");
			ccConfig.BlockIps = context.StringValue("DescribeDomainConfigs.DomainConfigs.CcConfig.BlockIps");
			domainConfigs.CcConfig = ccConfig;

			DescribeDomainConfigsResponse.DomainConfigs_.ErrorPageConfig_ errorPageConfig = new DescribeDomainConfigsResponse.DomainConfigs_.ErrorPageConfig_();
			errorPageConfig.ErrorCode = context.StringValue("DescribeDomainConfigs.DomainConfigs.ErrorPageConfig.ErrorCode");
			errorPageConfig.PageType = context.StringValue("DescribeDomainConfigs.DomainConfigs.ErrorPageConfig.PageType");
			errorPageConfig.CustomPageUrl = context.StringValue("DescribeDomainConfigs.DomainConfigs.ErrorPageConfig.CustomPageUrl");
			domainConfigs.ErrorPageConfig = errorPageConfig;

			DescribeDomainConfigsResponse.DomainConfigs_.OptimizeConfig_ optimizeConfig = new DescribeDomainConfigsResponse.DomainConfigs_.OptimizeConfig_();
			optimizeConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.OptimizeConfig.Enable");
			domainConfigs.OptimizeConfig = optimizeConfig;

			DescribeDomainConfigsResponse.DomainConfigs_.PageCompressConfig_ pageCompressConfig = new DescribeDomainConfigsResponse.DomainConfigs_.PageCompressConfig_();
			pageCompressConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.PageCompressConfig.Enable");
			domainConfigs.PageCompressConfig = pageCompressConfig;

			DescribeDomainConfigsResponse.DomainConfigs_.IgnoreQueryStringConfig_ ignoreQueryStringConfig = new DescribeDomainConfigsResponse.DomainConfigs_.IgnoreQueryStringConfig_();
			ignoreQueryStringConfig.HashKeyArgs = context.StringValue("DescribeDomainConfigs.DomainConfigs.IgnoreQueryStringConfig.HashKeyArgs");
			ignoreQueryStringConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.IgnoreQueryStringConfig.Enable");
			domainConfigs.IgnoreQueryStringConfig = ignoreQueryStringConfig;

			DescribeDomainConfigsResponse.DomainConfigs_.RangeConfig_ rangeConfig = new DescribeDomainConfigsResponse.DomainConfigs_.RangeConfig_();
			rangeConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.RangeConfig.Enable");
			domainConfigs.RangeConfig = rangeConfig;

			DescribeDomainConfigsResponse.DomainConfigs_.RefererConfig_ refererConfig = new DescribeDomainConfigsResponse.DomainConfigs_.RefererConfig_();
			refererConfig.ReferType = context.StringValue("DescribeDomainConfigs.DomainConfigs.RefererConfig.ReferType");
			refererConfig.ReferList = context.StringValue("DescribeDomainConfigs.DomainConfigs.RefererConfig.ReferList");
			refererConfig.AllowEmpty = context.StringValue("DescribeDomainConfigs.DomainConfigs.RefererConfig.AllowEmpty");
			domainConfigs.RefererConfig = refererConfig;

			DescribeDomainConfigsResponse.DomainConfigs_.ReqAuthConfig_ reqAuthConfig = new DescribeDomainConfigsResponse.DomainConfigs_.ReqAuthConfig_();
			reqAuthConfig.AuthType = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqAuthConfig.AuthType");
			reqAuthConfig.Key1 = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqAuthConfig.Key1");
			reqAuthConfig.Key2 = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqAuthConfig.Key2");
			domainConfigs.ReqAuthConfig = reqAuthConfig;

			DescribeDomainConfigsResponse.DomainConfigs_.SrcHostConfig_ srcHostConfig = new DescribeDomainConfigsResponse.DomainConfigs_.SrcHostConfig_();
			srcHostConfig.DomainName = context.StringValue("DescribeDomainConfigs.DomainConfigs.SrcHostConfig.DomainName");
			domainConfigs.SrcHostConfig = srcHostConfig;

			DescribeDomainConfigsResponse.DomainConfigs_.VideoSeekConfig_ videoSeekConfig = new DescribeDomainConfigsResponse.DomainConfigs_.VideoSeekConfig_();
			videoSeekConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.VideoSeekConfig.Enable");
			domainConfigs.VideoSeekConfig = videoSeekConfig;

			DescribeDomainConfigsResponse.DomainConfigs_.WafConfig_ wafConfig = new DescribeDomainConfigsResponse.DomainConfigs_.WafConfig_();
			wafConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.WafConfig.Enable");
			domainConfigs.WafConfig = wafConfig;

			DescribeDomainConfigsResponse.DomainConfigs_.NotifyUrlConfig_ notifyUrlConfig = new DescribeDomainConfigsResponse.DomainConfigs_.NotifyUrlConfig_();
			notifyUrlConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.NotifyUrlConfig.Enable");
			notifyUrlConfig.NotifyUrl = context.StringValue("DescribeDomainConfigs.DomainConfigs.NotifyUrlConfig.NotifyUrl");
			domainConfigs.NotifyUrlConfig = notifyUrlConfig;

			DescribeDomainConfigsResponse.DomainConfigs_.RedirectTypeConfig_ redirectTypeConfig = new DescribeDomainConfigsResponse.DomainConfigs_.RedirectTypeConfig_();
			redirectTypeConfig.RedirectType = context.StringValue("DescribeDomainConfigs.DomainConfigs.RedirectTypeConfig.RedirectType");
			domainConfigs.RedirectTypeConfig = redirectTypeConfig;

			DescribeDomainConfigsResponse.DomainConfigs_.ForwardSchemeConfig_ forwardSchemeConfig = new DescribeDomainConfigsResponse.DomainConfigs_.ForwardSchemeConfig_();
			forwardSchemeConfig.Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.ForwardSchemeConfig.Enable");
			forwardSchemeConfig.SchemeOrigin = context.StringValue("DescribeDomainConfigs.DomainConfigs.ForwardSchemeConfig.SchemeOrigin");
			forwardSchemeConfig.SchemeOriginPort = context.StringValue("DescribeDomainConfigs.DomainConfigs.ForwardSchemeConfig.SchemeOriginPort");
			domainConfigs.ForwardSchemeConfig = forwardSchemeConfig;

			List<DescribeDomainConfigsResponse.DomainConfigs_.CacheExpiredConfig> cacheExpiredConfigs = new List<DescribeDomainConfigsResponse.DomainConfigs_.CacheExpiredConfig>();
			for (int i = 0; i < context.Length("DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs.Length"); i++) {
				DescribeDomainConfigsResponse.DomainConfigs_.CacheExpiredConfig cacheExpiredConfig = new DescribeDomainConfigsResponse.DomainConfigs_.CacheExpiredConfig();
				cacheExpiredConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs["+ i +"].ConfigId");
				cacheExpiredConfig.CacheType = context.StringValue("DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs["+ i +"].CacheType");
				cacheExpiredConfig.CacheContent = context.StringValue("DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs["+ i +"].CacheContent");
				cacheExpiredConfig.TTL = context.StringValue("DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs["+ i +"].TTL");
				cacheExpiredConfig.Weight = context.StringValue("DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs["+ i +"].Weight");
				cacheExpiredConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs["+ i +"].Status");

				cacheExpiredConfigs.Add(cacheExpiredConfig);
			}
			domainConfigs.CacheExpiredConfigs = cacheExpiredConfigs;

			List<DescribeDomainConfigsResponse.DomainConfigs_.HttpHeaderConfig> httpHeaderConfigs = new List<DescribeDomainConfigsResponse.DomainConfigs_.HttpHeaderConfig>();
			for (int i = 0; i < context.Length("DescribeDomainConfigs.DomainConfigs.HttpHeaderConfigs.Length"); i++) {
				DescribeDomainConfigsResponse.DomainConfigs_.HttpHeaderConfig httpHeaderConfig = new DescribeDomainConfigsResponse.DomainConfigs_.HttpHeaderConfig();
				httpHeaderConfig.ConfigId = context.StringValue("DescribeDomainConfigs.DomainConfigs.HttpHeaderConfigs["+ i +"].ConfigId");
				httpHeaderConfig.HeaderKey = context.StringValue("DescribeDomainConfigs.DomainConfigs.HttpHeaderConfigs["+ i +"].HeaderKey");
				httpHeaderConfig.HeaderValue = context.StringValue("DescribeDomainConfigs.DomainConfigs.HttpHeaderConfigs["+ i +"].HeaderValue");
				httpHeaderConfig.Status = context.StringValue("DescribeDomainConfigs.DomainConfigs.HttpHeaderConfigs["+ i +"].Status");

				httpHeaderConfigs.Add(httpHeaderConfig);
			}
			domainConfigs.HttpHeaderConfigs = httpHeaderConfigs;
			describeDomainConfigsResponse.DomainConfigs = domainConfigs;
        
			return describeDomainConfigsResponse;
        }
    }
}