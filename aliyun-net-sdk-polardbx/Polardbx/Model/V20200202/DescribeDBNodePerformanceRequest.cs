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
using Aliyun.Acs.polardbx.Transform;
using Aliyun.Acs.polardbx.Transform.V20200202;

namespace Aliyun.Acs.polardbx.Model.V20200202
{
    public class DescribeDBNodePerformanceRequest : RpcAcsRequest<DescribeDBNodePerformanceResponse>
    {
        public DescribeDBNodePerformanceRequest()
            : base("polardbx", "2020-02-02", "DescribeDBNodePerformance", "polardbx", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string startTime;

		private string dBNodeRole;

		private string characterType;

		private string dBInstanceName;

		private string dBNodeIds;

		private string key;

		private string endTime;

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

		public string DBNodeRole
		{
			get
			{
				return dBNodeRole;
			}
			set	
			{
				dBNodeRole = value;
				DictionaryUtil.Add(QueryParameters, "DBNodeRole", value);
			}
		}

		public string CharacterType
		{
			get
			{
				return characterType;
			}
			set	
			{
				characterType = value;
				DictionaryUtil.Add(QueryParameters, "CharacterType", value);
			}
		}

		public string DBInstanceName
		{
			get
			{
				return dBInstanceName;
			}
			set	
			{
				dBInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceName", value);
			}
		}

		public string DBNodeIds
		{
			get
			{
				return dBNodeIds;
			}
			set	
			{
				dBNodeIds = value;
				DictionaryUtil.Add(QueryParameters, "DBNodeIds", value);
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
				DictionaryUtil.Add(QueryParameters, "Key", value);
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

        public override DescribeDBNodePerformanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDBNodePerformanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
