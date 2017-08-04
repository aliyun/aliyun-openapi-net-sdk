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
    public class DescribeDomainHttpsDataRequest : RpcAcsRequest<DescribeDomainHttpsDataResponse>
    {
        public DescribeDomainHttpsDataRequest()
            : base("Cdn", "2014-11-11", "DescribeDomainHttpsData")
        {
        }

		private string domainType;

		private string securityToken;

		private string timeMerge;

		private string domainNames;

		private string action;

		private string endTime;

		private string interval;

		private string startTime;

		private string cls;

		private long? ownerId;

		private string accessKeyId;

		public string DomainType
		{
			get
			{
				return domainType;
			}
			set	
			{
				domainType = value;
				DictionaryUtil.Add(QueryParameters, "DomainType", value);
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

		public string TimeMerge
		{
			get
			{
				return timeMerge;
			}
			set	
			{
				timeMerge = value;
				DictionaryUtil.Add(QueryParameters, "TimeMerge", value);
			}
		}

		public string DomainNames
		{
			get
			{
				return domainNames;
			}
			set	
			{
				domainNames = value;
				DictionaryUtil.Add(QueryParameters, "DomainNames", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string Interval
		{
			get
			{
				return interval;
			}
			set	
			{
				interval = value;
				DictionaryUtil.Add(QueryParameters, "Interval", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public string Cls
		{
			get
			{
				return cls;
			}
			set	
			{
				cls = value;
				DictionaryUtil.Add(QueryParameters, "Cls", value);
			}
		}

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

        public override DescribeDomainHttpsDataResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeDomainHttpsDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}