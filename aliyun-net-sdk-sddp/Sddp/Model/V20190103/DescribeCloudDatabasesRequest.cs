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
using Aliyun.Acs.Sddp.Transform;
using Aliyun.Acs.Sddp.Transform.V20190103;

namespace Aliyun.Acs.Sddp.Model.V20190103
{
    public class DescribeCloudDatabasesRequest : RpcAcsRequest<DescribeCloudDatabasesResponse>
    {
        public DescribeCloudDatabasesRequest()
            : base("Sddp", "2019-01-03", "DescribeCloudDatabases", "sddp", "openAPI")
        {
        }

		private string instanceId;

		private string lang;

		private long? resourceType;

		private string serviceRegionId;

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
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

		public long? ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value.ToString());
			}
		}

		public string ServiceRegionId
		{
			get
			{
				return serviceRegionId;
			}
			set	
			{
				serviceRegionId = value;
				DictionaryUtil.Add(QueryParameters, "ServiceRegionId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeCloudDatabasesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeCloudDatabasesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
