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
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainConfigsResponseUnmarshaller
    {
        public static DescribeDomainConfigsResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainConfigsResponse describeDomainConfigsResponse = new DescribeDomainConfigsResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDomainConfigs.RequestId")
            };
            DescribeDomainConfigsResponse.DomainConfigs_ domainConfigs = new DescribeDomainConfigsResponse.DomainConfigs_();

            DescribeDomainConfigsResponse.DomainConfigs_.CcConfig_ ccConfig = new DescribeDomainConfigsResponse.DomainConfigs_.CcConfig_()
            {
                Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.CcConfig.Enable"),
                AllowIps = context.StringValue("DescribeDomainConfigs.DomainConfigs.CcConfig.AllowIps"),
                BlockIps = context.StringValue("DescribeDomainConfigs.DomainConfigs.CcConfig.BlockIps")
            };
            domainConfigs.CcConfig = ccConfig;

            DescribeDomainConfigsResponse.DomainConfigs_.ErrorPageConfig_ errorPageConfig = new DescribeDomainConfigsResponse.DomainConfigs_.ErrorPageConfig_()
            {
                ErrorCode = context.StringValue("DescribeDomainConfigs.DomainConfigs.ErrorPageConfig.ErrorCode"),
                PageType = context.StringValue("DescribeDomainConfigs.DomainConfigs.ErrorPageConfig.PageType"),
                CustomPageUrl = context.StringValue("DescribeDomainConfigs.DomainConfigs.ErrorPageConfig.CustomPageUrl")
            };
            domainConfigs.ErrorPageConfig = errorPageConfig;

            DescribeDomainConfigsResponse.DomainConfigs_.OptimizeConfig_ optimizeConfig = new DescribeDomainConfigsResponse.DomainConfigs_.OptimizeConfig_()
            {
                Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.OptimizeConfig.Enable")
            };
            domainConfigs.OptimizeConfig = optimizeConfig;

            DescribeDomainConfigsResponse.DomainConfigs_.PageCompressConfig_ pageCompressConfig = new DescribeDomainConfigsResponse.DomainConfigs_.PageCompressConfig_()
            {
                Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.PageCompressConfig.Enable")
            };
            domainConfigs.PageCompressConfig = pageCompressConfig;

            DescribeDomainConfigsResponse.DomainConfigs_.IgnoreQueryStringConfig_ ignoreQueryStringConfig = new DescribeDomainConfigsResponse.DomainConfigs_.IgnoreQueryStringConfig_()
            {
                HashKeyArgs = context.StringValue("DescribeDomainConfigs.DomainConfigs.IgnoreQueryStringConfig.HashKeyArgs"),
                Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.IgnoreQueryStringConfig.Enable")
            };
            domainConfigs.IgnoreQueryStringConfig = ignoreQueryStringConfig;

            DescribeDomainConfigsResponse.DomainConfigs_.RangeConfig_ rangeConfig = new DescribeDomainConfigsResponse.DomainConfigs_.RangeConfig_()
            {
                Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.RangeConfig.Enable")
            };
            domainConfigs.RangeConfig = rangeConfig;

            DescribeDomainConfigsResponse.DomainConfigs_.RefererConfig_ refererConfig = new DescribeDomainConfigsResponse.DomainConfigs_.RefererConfig_()
            {
                ReferType = context.StringValue("DescribeDomainConfigs.DomainConfigs.RefererConfig.ReferType"),
                ReferList = context.StringValue("DescribeDomainConfigs.DomainConfigs.RefererConfig.ReferList"),
                AllowEmpty = context.StringValue("DescribeDomainConfigs.DomainConfigs.RefererConfig.AllowEmpty")
            };
            domainConfigs.RefererConfig = refererConfig;

            DescribeDomainConfigsResponse.DomainConfigs_.ReqAuthConfig_ reqAuthConfig = new DescribeDomainConfigsResponse.DomainConfigs_.ReqAuthConfig_()
            {
                AuthType = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqAuthConfig.AuthType"),
                Key1 = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqAuthConfig.Key1"),
                Key2 = context.StringValue("DescribeDomainConfigs.DomainConfigs.ReqAuthConfig.Key2")
            };
            domainConfigs.ReqAuthConfig = reqAuthConfig;

            DescribeDomainConfigsResponse.DomainConfigs_.SrcHostConfig_ srcHostConfig = new DescribeDomainConfigsResponse.DomainConfigs_.SrcHostConfig_()
            {
                DomainName = context.StringValue("DescribeDomainConfigs.DomainConfigs.SrcHostConfig.DomainName")
            };
            domainConfigs.SrcHostConfig = srcHostConfig;

            DescribeDomainConfigsResponse.DomainConfigs_.VideoSeekConfig_ videoSeekConfig = new DescribeDomainConfigsResponse.DomainConfigs_.VideoSeekConfig_()
            {
                Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.VideoSeekConfig.Enable")
            };
            domainConfigs.VideoSeekConfig = videoSeekConfig;

            DescribeDomainConfigsResponse.DomainConfigs_.WafConfig_ wafConfig = new DescribeDomainConfigsResponse.DomainConfigs_.WafConfig_()
            {
                Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.WafConfig.Enable")
            };
            domainConfigs.WafConfig = wafConfig;

            DescribeDomainConfigsResponse.DomainConfigs_.NotifyUrlConfig_ notifyUrlConfig = new DescribeDomainConfigsResponse.DomainConfigs_.NotifyUrlConfig_()
            {
                Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.NotifyUrlConfig.Enable"),
                NotifyUrl = context.StringValue("DescribeDomainConfigs.DomainConfigs.NotifyUrlConfig.NotifyUrl")
            };
            domainConfigs.NotifyUrlConfig = notifyUrlConfig;

            DescribeDomainConfigsResponse.DomainConfigs_.RedirectTypeConfig_ redirectTypeConfig = new DescribeDomainConfigsResponse.DomainConfigs_.RedirectTypeConfig_()
            {
                RedirectType = context.StringValue("DescribeDomainConfigs.DomainConfigs.RedirectTypeConfig.RedirectType")
            };
            domainConfigs.RedirectTypeConfig = redirectTypeConfig;

            DescribeDomainConfigsResponse.DomainConfigs_.ForwardSchemeConfig_ forwardSchemeConfig = new DescribeDomainConfigsResponse.DomainConfigs_.ForwardSchemeConfig_()
            {
                Enable = context.StringValue("DescribeDomainConfigs.DomainConfigs.ForwardSchemeConfig.Enable"),
                SchemeOrigin = context.StringValue("DescribeDomainConfigs.DomainConfigs.ForwardSchemeConfig.SchemeOrigin"),
                SchemeOriginPort = context.StringValue("DescribeDomainConfigs.DomainConfigs.ForwardSchemeConfig.SchemeOriginPort")
            };
            domainConfigs.ForwardSchemeConfig = forwardSchemeConfig;

			List<DescribeDomainConfigsResponse.DomainConfigs_.CacheExpiredConfig> cacheExpiredConfigs = new List<DescribeDomainConfigsResponse.DomainConfigs_.CacheExpiredConfig>();
			for (int i = 0; i < context.Length("DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs.Length"); i++) {
                DescribeDomainConfigsResponse.DomainConfigs_.CacheExpiredConfig cacheExpiredConfig = new DescribeDomainConfigsResponse.DomainConfigs_.CacheExpiredConfig()
                {
                    ConfigId = context.StringValue($"DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs[{i}].ConfigId"),
                    CacheType = context.StringValue($"DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs[{i}].CacheType"),
                    CacheContent = context.StringValue($"DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs[{i}].CacheContent"),
                    TTL = context.StringValue($"DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs[{i}].TTL"),
                    Weight = context.StringValue($"DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs[{i}].Weight"),
                    Status = context.StringValue($"DescribeDomainConfigs.DomainConfigs.CacheExpiredConfigs[{i}].Status")
                };
                cacheExpiredConfigs.Add(cacheExpiredConfig);
			}
			domainConfigs.CacheExpiredConfigs = cacheExpiredConfigs;

			List<DescribeDomainConfigsResponse.DomainConfigs_.HttpHeaderConfig> httpHeaderConfigs = new List<DescribeDomainConfigsResponse.DomainConfigs_.HttpHeaderConfig>();
			for (int i = 0; i < context.Length("DescribeDomainConfigs.DomainConfigs.HttpHeaderConfigs.Length"); i++) {
                DescribeDomainConfigsResponse.DomainConfigs_.HttpHeaderConfig httpHeaderConfig = new DescribeDomainConfigsResponse.DomainConfigs_.HttpHeaderConfig()
                {
                    ConfigId = context.StringValue($"DescribeDomainConfigs.DomainConfigs.HttpHeaderConfigs[{i}].ConfigId"),
                    HeaderKey = context.StringValue($"DescribeDomainConfigs.DomainConfigs.HttpHeaderConfigs[{i}].HeaderKey"),
                    HeaderValue = context.StringValue($"DescribeDomainConfigs.DomainConfigs.HttpHeaderConfigs[{i}].HeaderValue"),
                    Status = context.StringValue($"DescribeDomainConfigs.DomainConfigs.HttpHeaderConfigs[{i}].Status")
                };
                httpHeaderConfigs.Add(httpHeaderConfig);
			}
			domainConfigs.HttpHeaderConfigs = httpHeaderConfigs;
			describeDomainConfigsResponse.DomainConfigs = domainConfigs;
        
			return describeDomainConfigsResponse;
        }
    }
}