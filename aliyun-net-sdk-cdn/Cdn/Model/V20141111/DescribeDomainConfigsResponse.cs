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

		private DomainConfigs_ domainConfigs;

		public DomainConfigs_ DomainConfigs
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

		public class DomainConfigs_{

			private List<CacheExpiredConfig> cacheExpiredConfigs;

			private List<HttpHeaderConfig> httpHeaderConfigs;

			private CcConfig_ ccConfig;

			private ErrorPageConfig_ errorPageConfig;

			private OptimizeConfig_ optimizeConfig;

			private PageCompressConfig_ pageCompressConfig;

			private IgnoreQueryStringConfig_ ignoreQueryStringConfig;

			private RangeConfig_ rangeConfig;

			private RefererConfig_ refererConfig;

			private ReqAuthConfig_ reqAuthConfig;

			private SrcHostConfig_ srcHostConfig;

			private VideoSeekConfig_ videoSeekConfig;

			private WafConfig_ wafConfig;

			private NotifyUrlConfig_ notifyUrlConfig;

			private RedirectTypeConfig_ redirectTypeConfig;

			private ForwardSchemeConfig_ forwardSchemeConfig;

			public List<CacheExpiredConfig> CacheExpiredConfigs
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

			public List<HttpHeaderConfig> HttpHeaderConfigs
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

			public CcConfig_ CcConfig
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

			public ErrorPageConfig_ ErrorPageConfig
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

			public OptimizeConfig_ OptimizeConfig
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

			public PageCompressConfig_ PageCompressConfig
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

			public IgnoreQueryStringConfig_ IgnoreQueryStringConfig
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

			public RangeConfig_ RangeConfig
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

			public RefererConfig_ RefererConfig
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

			public ReqAuthConfig_ ReqAuthConfig
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

			public SrcHostConfig_ SrcHostConfig
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

			public VideoSeekConfig_ VideoSeekConfig
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

			public WafConfig_ WafConfig
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

			public NotifyUrlConfig_ NotifyUrlConfig
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

			public RedirectTypeConfig_ RedirectTypeConfig
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

			public ForwardSchemeConfig_ ForwardSchemeConfig
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

			public class CacheExpiredConfig{

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

			public class HttpHeaderConfig{

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

			public class CcConfig_{

				private string enable;

				private string allowIps;

				private string blockIps;

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
			}

			public class ErrorPageConfig_{

				private string errorCode;

				private string pageType;

				private string customPageUrl;

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
			}

			public class OptimizeConfig_{

				private string enable;

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
			}

			public class PageCompressConfig_{

				private string enable;

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
			}

			public class IgnoreQueryStringConfig_{

				private string hashKeyArgs;

				private string enable;

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
			}

			public class RangeConfig_{

				private string enable;

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
			}

			public class RefererConfig_{

				private string referType;

				private string referList;

				private string allowEmpty;

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
			}

			public class ReqAuthConfig_{

				private string authType;

				private string key1;

				private string key2;

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
			}

			public class SrcHostConfig_{

				private string domainName;

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
			}

			public class VideoSeekConfig_{

				private string enable;

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
			}

			public class WafConfig_{

				private string enable;

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
			}

			public class NotifyUrlConfig_{

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

			public class RedirectTypeConfig_{

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

			public class ForwardSchemeConfig_{

				private string enable;

				private string schemeOrigin;

				private string schemeOriginPort;

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
			}
		}
	}
}