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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeDomainConfigsResponse : AcsResponse
	{

		private string requestId;

		private DescribeDomainConfigs_DomainConfigs domainConfigs;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public DescribeDomainConfigs_DomainConfigs DomainConfigs
		{
			get
			{
				return domainConfigs;
			}
			set	
			{
				domainConfigs = value;
			}
		}

		public class DescribeDomainConfigs_DomainConfigs
		{

			private List<DescribeDomainConfigs_CacheExpiredConfig> cacheExpiredConfigs;

			private List<DescribeDomainConfigs_HttpErrorPageConfig> httpErrorPageConfigs;

			private List<DescribeDomainConfigs_HttpHeaderConfig> httpHeaderConfigs;

			private List<DescribeDomainConfigs_DynamicConfig> dynamicConfigs;

			private List<DescribeDomainConfigs_ReqHeaderConfig> reqHeaderConfigs;

			private DescribeDomainConfigs_CcConfig ccConfig;

			private DescribeDomainConfigs_ErrorPageConfig errorPageConfig;

			private DescribeDomainConfigs_OptimizeConfig optimizeConfig;

			private DescribeDomainConfigs_PageCompressConfig pageCompressConfig;

			private DescribeDomainConfigs_IgnoreQueryStringConfig ignoreQueryStringConfig;

			private DescribeDomainConfigs_RangeConfig rangeConfig;

			private DescribeDomainConfigs_RefererConfig refererConfig;

			private DescribeDomainConfigs_ReqAuthConfig reqAuthConfig;

			private DescribeDomainConfigs_SrcHostConfig srcHostConfig;

			private DescribeDomainConfigs_VideoSeekConfig videoSeekConfig;

			private DescribeDomainConfigs_WafConfig wafConfig;

			private DescribeDomainConfigs_NotifyUrlConfig notifyUrlConfig;

			private DescribeDomainConfigs_RedirectTypeConfig redirectTypeConfig;

			private DescribeDomainConfigs_ForwardSchemeConfig forwardSchemeConfig;

			private DescribeDomainConfigs_RemoveQueryStringConfig removeQueryStringConfig;

			private DescribeDomainConfigs_L2OssKeyConfig l2OssKeyConfig;

			private DescribeDomainConfigs_MacServiceConfig macServiceConfig;

			public List<DescribeDomainConfigs_CacheExpiredConfig> CacheExpiredConfigs
			{
				get
				{
					return cacheExpiredConfigs;
				}
				set	
				{
					cacheExpiredConfigs = value;
				}
			}

			public List<DescribeDomainConfigs_HttpErrorPageConfig> HttpErrorPageConfigs
			{
				get
				{
					return httpErrorPageConfigs;
				}
				set	
				{
					httpErrorPageConfigs = value;
				}
			}

			public List<DescribeDomainConfigs_HttpHeaderConfig> HttpHeaderConfigs
			{
				get
				{
					return httpHeaderConfigs;
				}
				set	
				{
					httpHeaderConfigs = value;
				}
			}

			public List<DescribeDomainConfigs_DynamicConfig> DynamicConfigs
			{
				get
				{
					return dynamicConfigs;
				}
				set	
				{
					dynamicConfigs = value;
				}
			}

			public List<DescribeDomainConfigs_ReqHeaderConfig> ReqHeaderConfigs
			{
				get
				{
					return reqHeaderConfigs;
				}
				set	
				{
					reqHeaderConfigs = value;
				}
			}

			public DescribeDomainConfigs_CcConfig CcConfig
			{
				get
				{
					return ccConfig;
				}
				set	
				{
					ccConfig = value;
				}
			}

			public DescribeDomainConfigs_ErrorPageConfig ErrorPageConfig
			{
				get
				{
					return errorPageConfig;
				}
				set	
				{
					errorPageConfig = value;
				}
			}

			public DescribeDomainConfigs_OptimizeConfig OptimizeConfig
			{
				get
				{
					return optimizeConfig;
				}
				set	
				{
					optimizeConfig = value;
				}
			}

			public DescribeDomainConfigs_PageCompressConfig PageCompressConfig
			{
				get
				{
					return pageCompressConfig;
				}
				set	
				{
					pageCompressConfig = value;
				}
			}

			public DescribeDomainConfigs_IgnoreQueryStringConfig IgnoreQueryStringConfig
			{
				get
				{
					return ignoreQueryStringConfig;
				}
				set	
				{
					ignoreQueryStringConfig = value;
				}
			}

			public DescribeDomainConfigs_RangeConfig RangeConfig
			{
				get
				{
					return rangeConfig;
				}
				set	
				{
					rangeConfig = value;
				}
			}

			public DescribeDomainConfigs_RefererConfig RefererConfig
			{
				get
				{
					return refererConfig;
				}
				set	
				{
					refererConfig = value;
				}
			}

			public DescribeDomainConfigs_ReqAuthConfig ReqAuthConfig
			{
				get
				{
					return reqAuthConfig;
				}
				set	
				{
					reqAuthConfig = value;
				}
			}

			public DescribeDomainConfigs_SrcHostConfig SrcHostConfig
			{
				get
				{
					return srcHostConfig;
				}
				set	
				{
					srcHostConfig = value;
				}
			}

			public DescribeDomainConfigs_VideoSeekConfig VideoSeekConfig
			{
				get
				{
					return videoSeekConfig;
				}
				set	
				{
					videoSeekConfig = value;
				}
			}

			public DescribeDomainConfigs_WafConfig WafConfig
			{
				get
				{
					return wafConfig;
				}
				set	
				{
					wafConfig = value;
				}
			}

			public DescribeDomainConfigs_NotifyUrlConfig NotifyUrlConfig
			{
				get
				{
					return notifyUrlConfig;
				}
				set	
				{
					notifyUrlConfig = value;
				}
			}

			public DescribeDomainConfigs_RedirectTypeConfig RedirectTypeConfig
			{
				get
				{
					return redirectTypeConfig;
				}
				set	
				{
					redirectTypeConfig = value;
				}
			}

			public DescribeDomainConfigs_ForwardSchemeConfig ForwardSchemeConfig
			{
				get
				{
					return forwardSchemeConfig;
				}
				set	
				{
					forwardSchemeConfig = value;
				}
			}

			public DescribeDomainConfigs_RemoveQueryStringConfig RemoveQueryStringConfig
			{
				get
				{
					return removeQueryStringConfig;
				}
				set	
				{
					removeQueryStringConfig = value;
				}
			}

			public DescribeDomainConfigs_L2OssKeyConfig L2OssKeyConfig
			{
				get
				{
					return l2OssKeyConfig;
				}
				set	
				{
					l2OssKeyConfig = value;
				}
			}

			public DescribeDomainConfigs_MacServiceConfig MacServiceConfig
			{
				get
				{
					return macServiceConfig;
				}
				set	
				{
					macServiceConfig = value;
				}
			}

			public class DescribeDomainConfigs_CacheExpiredConfig
			{

				private string configId;

				private string cacheType;

				private string cacheContent;

				private string tTL;

				private string weight;

				private string status;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string CacheType
				{
					get
					{
						return cacheType;
					}
					set	
					{
						cacheType = value;
					}
				}

				public string CacheContent
				{
					get
					{
						return cacheContent;
					}
					set	
					{
						cacheContent = value;
					}
				}

				public string TTL
				{
					get
					{
						return tTL;
					}
					set	
					{
						tTL = value;
					}
				}

				public string Weight
				{
					get
					{
						return weight;
					}
					set	
					{
						weight = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_HttpErrorPageConfig
			{

				private string configId;

				private string errorCode;

				private string pageUrl;

				private string status;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string ErrorCode
				{
					get
					{
						return errorCode;
					}
					set	
					{
						errorCode = value;
					}
				}

				public string PageUrl
				{
					get
					{
						return pageUrl;
					}
					set	
					{
						pageUrl = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_HttpHeaderConfig
			{

				private string configId;

				private string headerKey;

				private string headerValue;

				private string status;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string HeaderKey
				{
					get
					{
						return headerKey;
					}
					set	
					{
						headerKey = value;
					}
				}

				public string HeaderValue
				{
					get
					{
						return headerValue;
					}
					set	
					{
						headerValue = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_DynamicConfig
			{

				private string configId;

				private string dynamicOrigin;

				private string staticType;

				private string staticUri;

				private string staticPath;

				private string dynamicCacheControl;

				private string status;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string DynamicOrigin
				{
					get
					{
						return dynamicOrigin;
					}
					set	
					{
						dynamicOrigin = value;
					}
				}

				public string StaticType
				{
					get
					{
						return staticType;
					}
					set	
					{
						staticType = value;
					}
				}

				public string StaticUri
				{
					get
					{
						return staticUri;
					}
					set	
					{
						staticUri = value;
					}
				}

				public string StaticPath
				{
					get
					{
						return staticPath;
					}
					set	
					{
						staticPath = value;
					}
				}

				public string DynamicCacheControl
				{
					get
					{
						return dynamicCacheControl;
					}
					set	
					{
						dynamicCacheControl = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_ReqHeaderConfig
			{

				private string configId;

				private string key;

				private string _value;

				private string status;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_CcConfig
			{

				private string configId;

				private string enable;

				private string allowIps;

				private string blockIps;

				private string status;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
					}
				}

				public string AllowIps
				{
					get
					{
						return allowIps;
					}
					set	
					{
						allowIps = value;
					}
				}

				public string BlockIps
				{
					get
					{
						return blockIps;
					}
					set	
					{
						blockIps = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_ErrorPageConfig
			{

				private string configId;

				private string errorCode;

				private string pageType;

				private string customPageUrl;

				private string status;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string ErrorCode
				{
					get
					{
						return errorCode;
					}
					set	
					{
						errorCode = value;
					}
				}

				public string PageType
				{
					get
					{
						return pageType;
					}
					set	
					{
						pageType = value;
					}
				}

				public string CustomPageUrl
				{
					get
					{
						return customPageUrl;
					}
					set	
					{
						customPageUrl = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_OptimizeConfig
			{

				private string configId;

				private string enable;

				private string status;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_PageCompressConfig
			{

				private string configId;

				private string enable;

				private string status;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_IgnoreQueryStringConfig
			{

				private string configId;

				private string hashKeyArgs;

				private string enable;

				private string status;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string HashKeyArgs
				{
					get
					{
						return hashKeyArgs;
					}
					set	
					{
						hashKeyArgs = value;
					}
				}

				public string Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_RangeConfig
			{

				private string configId;

				private string enable;

				private string status;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_RefererConfig
			{

				private string configId;

				private string referType;

				private string referList;

				private string allowEmpty;

				private string disableAst;

				private string status;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string ReferType
				{
					get
					{
						return referType;
					}
					set	
					{
						referType = value;
					}
				}

				public string ReferList
				{
					get
					{
						return referList;
					}
					set	
					{
						referList = value;
					}
				}

				public string AllowEmpty
				{
					get
					{
						return allowEmpty;
					}
					set	
					{
						allowEmpty = value;
					}
				}

				public string DisableAst
				{
					get
					{
						return disableAst;
					}
					set	
					{
						disableAst = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_ReqAuthConfig
			{

				private string configId;

				private string authType;

				private string key1;

				private string key2;

				private string status;

				private string aliAuthWhiteList;

				private string authM3u8;

				private string authAddr;

				private string authRemoteDesc;

				private string timeOut;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string AuthType
				{
					get
					{
						return authType;
					}
					set	
					{
						authType = value;
					}
				}

				public string Key1
				{
					get
					{
						return key1;
					}
					set	
					{
						key1 = value;
					}
				}

				public string Key2
				{
					get
					{
						return key2;
					}
					set	
					{
						key2 = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public string AliAuthWhiteList
				{
					get
					{
						return aliAuthWhiteList;
					}
					set	
					{
						aliAuthWhiteList = value;
					}
				}

				public string AuthM3u8
				{
					get
					{
						return authM3u8;
					}
					set	
					{
						authM3u8 = value;
					}
				}

				public string AuthAddr
				{
					get
					{
						return authAddr;
					}
					set	
					{
						authAddr = value;
					}
				}

				public string AuthRemoteDesc
				{
					get
					{
						return authRemoteDesc;
					}
					set	
					{
						authRemoteDesc = value;
					}
				}

				public string TimeOut
				{
					get
					{
						return timeOut;
					}
					set	
					{
						timeOut = value;
					}
				}
			}

			public class DescribeDomainConfigs_SrcHostConfig
			{

				private string configId;

				private string domainName;

				private string status;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string DomainName
				{
					get
					{
						return domainName;
					}
					set	
					{
						domainName = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_VideoSeekConfig
			{

				private string configId;

				private string enable;

				private string status;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_WafConfig
			{

				private string configId;

				private string enable;

				private string status;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_NotifyUrlConfig
			{

				private string enable;

				private string notifyUrl;

				public string Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
					}
				}

				public string NotifyUrl
				{
					get
					{
						return notifyUrl;
					}
					set	
					{
						notifyUrl = value;
					}
				}
			}

			public class DescribeDomainConfigs_RedirectTypeConfig
			{

				private string redirectType;

				public string RedirectType
				{
					get
					{
						return redirectType;
					}
					set	
					{
						redirectType = value;
					}
				}
			}

			public class DescribeDomainConfigs_ForwardSchemeConfig
			{

				private string configId;

				private string enable;

				private string schemeOrigin;

				private string schemeOriginPort;

				private string status;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
					}
				}

				public string SchemeOrigin
				{
					get
					{
						return schemeOrigin;
					}
					set	
					{
						schemeOrigin = value;
					}
				}

				public string SchemeOriginPort
				{
					get
					{
						return schemeOriginPort;
					}
					set	
					{
						schemeOriginPort = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_RemoveQueryStringConfig
			{

				private string aliRemoveArgs;

				private string configId;

				private string status;

				public string AliRemoveArgs
				{
					get
					{
						return aliRemoveArgs;
					}
					set	
					{
						aliRemoveArgs = value;
					}
				}

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_L2OssKeyConfig
			{

				private string privateOssAuth;

				private string configId;

				private string status;

				public string PrivateOssAuth
				{
					get
					{
						return privateOssAuth;
					}
					set	
					{
						privateOssAuth = value;
					}
				}

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDomainConfigs_MacServiceConfig
			{

				private string appList;

				private string enabled;

				private string processResult;

				private string configId;

				private string status;

				public string AppList
				{
					get
					{
						return appList;
					}
					set	
					{
						appList = value;
					}
				}

				public string Enabled
				{
					get
					{
						return enabled;
					}
					set	
					{
						enabled = value;
					}
				}

				public string ProcessResult
				{
					get
					{
						return processResult;
					}
					set	
					{
						processResult = value;
					}
				}

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}
		}
	}
}