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
	    public DomainConfigs_ DomainConfigs { get; set; }

	    public class DomainConfigs_{
	        public List<CacheExpiredConfig> CacheExpiredConfigs { get; set; }

	        public List<HttpHeaderConfig> HttpHeaderConfigs { get; set; }

	        public CcConfig_ CcConfig { get; set; }

	        public ErrorPageConfig_ ErrorPageConfig { get; set; }

	        public OptimizeConfig_ OptimizeConfig { get; set; }

	        public PageCompressConfig_ PageCompressConfig { get; set; }

	        public IgnoreQueryStringConfig_ IgnoreQueryStringConfig { get; set; }

	        public RangeConfig_ RangeConfig { get; set; }

	        public RefererConfig_ RefererConfig { get; set; }

	        public ReqAuthConfig_ ReqAuthConfig { get; set; }

	        public SrcHostConfig_ SrcHostConfig { get; set; }

	        public VideoSeekConfig_ VideoSeekConfig { get; set; }

	        public WafConfig_ WafConfig { get; set; }

	        public NotifyUrlConfig_ NotifyUrlConfig { get; set; }

	        public RedirectTypeConfig_ RedirectTypeConfig { get; set; }

	        public ForwardSchemeConfig_ ForwardSchemeConfig { get; set; }

	        public class CacheExpiredConfig{
	            public string ConfigId { get; set; }

	            public string CacheType { get; set; }

	            public string CacheContent { get; set; }

	            public string TTL { get; set; }

	            public string Weight { get; set; }

	            public string Status { get; set; }
	        }

			public class HttpHeaderConfig{
			    public string ConfigId { get; set; }

			    public string HeaderKey { get; set; }

			    public string HeaderValue { get; set; }

			    public string Status { get; set; }
			}

			public class CcConfig_{
			    public string Enable { get; set; }

			    public string AllowIps { get; set; }

			    public string BlockIps { get; set; }
			}

			public class ErrorPageConfig_{
			    public string ErrorCode { get; set; }

			    public string PageType { get; set; }

			    public string CustomPageUrl { get; set; }
			}

			public class OptimizeConfig_{
			    public string Enable { get; set; }
			}

			public class PageCompressConfig_{
			    public string Enable { get; set; }
			}

			public class IgnoreQueryStringConfig_{
			    public string HashKeyArgs { get; set; }

			    public string Enable { get; set; }
			}

			public class RangeConfig_{
			    public string Enable { get; set; }
			}

			public class RefererConfig_{
			    public string ReferType { get; set; }

			    public string ReferList { get; set; }

			    public string AllowEmpty { get; set; }
			}

			public class ReqAuthConfig_{
			    public string AuthType { get; set; }

			    public string Key1 { get; set; }

			    public string Key2 { get; set; }
			}

			public class SrcHostConfig_{
			    public string DomainName { get; set; }
			}

			public class VideoSeekConfig_{
			    public string Enable { get; set; }
			}

			public class WafConfig_{
			    public string Enable { get; set; }
			}

			public class NotifyUrlConfig_{
			    public string Enable { get; set; }

			    public string NotifyUrl { get; set; }
			}

			public class RedirectTypeConfig_{
			    public string RedirectType { get; set; }
			}

			public class ForwardSchemeConfig_{
			    public string Enable { get; set; }

			    public string SchemeOrigin { get; set; }

			    public string SchemeOriginPort { get; set; }
			}
		}
	}
}