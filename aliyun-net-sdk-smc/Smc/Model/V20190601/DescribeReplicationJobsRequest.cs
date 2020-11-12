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
using Aliyun.Acs.smc.Transform;
using Aliyun.Acs.smc.Transform.V20190601;

namespace Aliyun.Acs.smc.Model.V20190601
{
    public class DescribeReplicationJobsRequest : RpcAcsRequest<DescribeReplicationJobsResponse>
    {
        public DescribeReplicationJobsRequest()
            : base("smc", "2019-06-01", "DescribeReplicationJobs", "smc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.smc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.smc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? pageNumber;

		private List<string> jobIds = new List<string>(){ };

		private int? pageSize;

		private List<string> sourceIds = new List<string>(){ };

		private string businessStatus;

		private string resourceOwnerAccount;

		private long? ownerId;

		private string name;

		private string status;

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

		public List<string> JobIds
		{
			get
			{
				return jobIds;
			}

			set
			{
				jobIds = value;
				for (int i = 0; i < jobIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"JobId." + (i + 1) , jobIds[i]);
				}
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

		public List<string> SourceIds
		{
			get
			{
				return sourceIds;
			}

			set
			{
				sourceIds = value;
				for (int i = 0; i < sourceIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SourceId." + (i + 1) , sourceIds[i]);
				}
			}
		}

		public string BusinessStatus
		{
			get
			{
				return businessStatus;
			}
			set	
			{
				businessStatus = value;
				DictionaryUtil.Add(QueryParameters, "BusinessStatus", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
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

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
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
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

        public override DescribeReplicationJobsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeReplicationJobsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
