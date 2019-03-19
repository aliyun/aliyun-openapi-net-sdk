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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.cloudwf.Transform;
using Aliyun.Acs.cloudwf.Transform.V20170328;

namespace Aliyun.Acs.cloudwf.Model.V20170328
{
    public class SaveApPortalConfigRequest : RpcAcsRequest<SaveApPortalConfigResponse>
    {
        public SaveApPortalConfigRequest()
            : base("cloudwf", "2017-03-28", "SaveApPortalConfig", "cloudwf", "openAPI")
        {
        }

		private string authKey;

		private string portalUrl;

		private bool? portalStatus;

		private string whitelist;

		private string checkUrl;

		private long? apConfigId;

		private string authSecret;

		private string webAuthUrl;

		private string accessKeyId;

		private int? network;

		public string AuthKey
		{
			get
			{
				return authKey;
			}
			set	
			{
				authKey = value;
				DictionaryUtil.Add(QueryParameters, "AuthKey", value);
			}
		}

		public string PortalUrl
		{
			get
			{
				return portalUrl;
			}
			set	
			{
				portalUrl = value;
				DictionaryUtil.Add(QueryParameters, "PortalUrl", value);
			}
		}

		public bool? PortalStatus
		{
			get
			{
				return portalStatus;
			}
			set	
			{
				portalStatus = value;
				DictionaryUtil.Add(QueryParameters, "PortalStatus", value.ToString());
			}
		}

		public string Whitelist
		{
			get
			{
				return whitelist;
			}
			set	
			{
				whitelist = value;
				DictionaryUtil.Add(QueryParameters, "Whitelist", value);
			}
		}

		public string CheckUrl
		{
			get
			{
				return checkUrl;
			}
			set	
			{
				checkUrl = value;
				DictionaryUtil.Add(QueryParameters, "CheckUrl", value);
			}
		}

		public long? ApConfigId
		{
			get
			{
				return apConfigId;
			}
			set	
			{
				apConfigId = value;
				DictionaryUtil.Add(QueryParameters, "ApConfigId", value.ToString());
			}
		}

		public string AuthSecret
		{
			get
			{
				return authSecret;
			}
			set	
			{
				authSecret = value;
				DictionaryUtil.Add(QueryParameters, "AuthSecret", value);
			}
		}

		public string WebAuthUrl
		{
			get
			{
				return webAuthUrl;
			}
			set	
			{
				webAuthUrl = value;
				DictionaryUtil.Add(QueryParameters, "WebAuthUrl", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public int? Network
		{
			get
			{
				return network;
			}
			set	
			{
				network = value;
				DictionaryUtil.Add(QueryParameters, "Network", value.ToString());
			}
		}

        public override SaveApPortalConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveApPortalConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
