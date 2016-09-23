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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cdn.Transform;
using Aliyun.Acs.Cdn.Transform.V20141111;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
    public class StartMixStreamsServiceRequest : RpcAcsRequest<StartMixStreamsServiceResponse>
    {
        public StartMixStreamsServiceRequest()
            : base("Cdn", "2014-11-11", "StartMixStreamsService")
        {
        }

		private long? ownerId;

		private string securityToken;

		private string mainDomainName;

		private string mainAppName;

		private string mainStreamName;

		private string mixDomainName;

		private string mixAppName;

		private string mixStreamName;

		private string mixTemplate;

		private string mixType;

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string MainDomainName
		{
			get
			{
				return mainDomainName;
			}
			set	
			{
				mainDomainName = value;
				DictionaryUtil.Add(QueryParameters, "MainDomainName", value);
			}
		}

		public string MainAppName
		{
			get
			{
				return mainAppName;
			}
			set	
			{
				mainAppName = value;
				DictionaryUtil.Add(QueryParameters, "MainAppName", value);
			}
		}

		public string MainStreamName
		{
			get
			{
				return mainStreamName;
			}
			set	
			{
				mainStreamName = value;
				DictionaryUtil.Add(QueryParameters, "MainStreamName", value);
			}
		}

		public string MixDomainName
		{
			get
			{
				return mixDomainName;
			}
			set	
			{
				mixDomainName = value;
				DictionaryUtil.Add(QueryParameters, "MixDomainName", value);
			}
		}

		public string MixAppName
		{
			get
			{
				return mixAppName;
			}
			set	
			{
				mixAppName = value;
				DictionaryUtil.Add(QueryParameters, "MixAppName", value);
			}
		}

		public string MixStreamName
		{
			get
			{
				return mixStreamName;
			}
			set	
			{
				mixStreamName = value;
				DictionaryUtil.Add(QueryParameters, "MixStreamName", value);
			}
		}

		public string MixTemplate
		{
			get
			{
				return mixTemplate;
			}
			set	
			{
				mixTemplate = value;
				DictionaryUtil.Add(QueryParameters, "MixTemplate", value);
			}
		}

		public string MixType
		{
			get
			{
				return mixType;
			}
			set	
			{
				mixType = value;
				DictionaryUtil.Add(QueryParameters, "MixType", value);
			}
		}

        public override StartMixStreamsServiceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return StartMixStreamsServiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}