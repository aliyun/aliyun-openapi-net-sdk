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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class ListClusterHostComponentRequest : RpcAcsRequest<ListClusterHostComponentResponse>
    {
        public ListClusterHostComponentRequest()
            : base("Emr", "2016-04-08", "ListClusterHostComponent", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string hostName;

		private string hostInstanceId;

		private string regionId;

		private int? pageSize;

		private string componentName;

		private string serviceName;

		private string clusterId;

		private string hostRole;

		private int? pageNumber;

		private string accessKeyId;

		private string componentStatus;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string HostName
		{
			get
			{
				return hostName;
			}
			set	
			{
				hostName = value;
				DictionaryUtil.Add(QueryParameters, "HostName", value);
			}
		}

		public string HostInstanceId
		{
			get
			{
				return hostInstanceId;
			}
			set	
			{
				hostInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "HostInstanceId", value);
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
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

		public string ComponentName
		{
			get
			{
				return componentName;
			}
			set	
			{
				componentName = value;
				DictionaryUtil.Add(QueryParameters, "ComponentName", value);
			}
		}

		public string ServiceName
		{
			get
			{
				return serviceName;
			}
			set	
			{
				serviceName = value;
				DictionaryUtil.Add(QueryParameters, "ServiceName", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string HostRole
		{
			get
			{
				return hostRole;
			}
			set	
			{
				hostRole = value;
				DictionaryUtil.Add(QueryParameters, "HostRole", value);
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

		public string ComponentStatus
		{
			get
			{
				return componentStatus;
			}
			set	
			{
				componentStatus = value;
				DictionaryUtil.Add(QueryParameters, "ComponentStatus", value);
			}
		}

        public override ListClusterHostComponentResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListClusterHostComponentResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
