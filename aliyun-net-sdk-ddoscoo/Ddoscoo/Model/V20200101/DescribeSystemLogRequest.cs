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
using Aliyun.Acs.ddoscoo;
using Aliyun.Acs.ddoscoo.Transform;
using Aliyun.Acs.ddoscoo.Transform.V20200101;

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
    public class DescribeSystemLogRequest : RpcAcsRequest<DescribeSystemLogResponse>
    {
        public DescribeSystemLogRequest()
            : base("ddoscoo", "2020-01-01", "DescribeSystemLog")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? startTime;

		private int? pageNumber;

		private int? pageSize;

		private long? endTime;

		private string entityObject;

		private int? entityType;

		public long? StartTime
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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
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

		public long? EndTime
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

		public string EntityObject
		{
			get
			{
				return entityObject;
			}
			set	
			{
				entityObject = value;
				DictionaryUtil.Add(QueryParameters, "EntityObject", value);
			}
		}

		public int? EntityType
		{
			get
			{
				return entityType;
			}
			set	
			{
				entityType = value;
				DictionaryUtil.Add(QueryParameters, "EntityType", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeSystemLogResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeSystemLogResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
