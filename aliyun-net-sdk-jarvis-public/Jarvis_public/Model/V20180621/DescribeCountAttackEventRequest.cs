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
using Aliyun.Acs.jarvis_public.Transform;
using Aliyun.Acs.jarvis_public.Transform.V20180621;

namespace Aliyun.Acs.jarvis_public.Model.V20180621
{
    public class DescribeCountAttackEventRequest : RpcAcsRequest<DescribeCountAttackEventResponse>
    {
        public DescribeCountAttackEventRequest()
            : base("jarvis-public", "2018-06-21", "DescribeCountAttackEvent", "jarvis-public", "openAPI")
        {
        }

		private string sourceIp;

		private string serverIpList;

		private int? pageSize;

		private int? endTime;

		private int? currentPage;

		private int? startTime;

		private string lang;

		private string region;

		private string productType;

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string ServerIpList
		{
			get
			{
				return serverIpList;
			}
			set	
			{
				serverIpList = value;
				DictionaryUtil.Add(QueryParameters, "ServerIpList", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public int? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value.ToString());
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
			}
		}

		public int? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value.ToString());
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		public string ProductType
		{
			get
			{
				return productType;
			}
			set	
			{
				productType = value;
				DictionaryUtil.Add(QueryParameters, "ProductType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeCountAttackEventResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeCountAttackEventResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
