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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DescribeInvocationsRequest : RpcAcsRequest<DescribeInvocationsResponse>
    {
        public DescribeInvocationsRequest()
            : base("Ecs", "2014-05-26", "DescribeInvocations", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string invokeStatus;

		private bool? includeOutput;

		private string commandId;

		private long? pageNumber;

		private string contentEncoding;

		private long? pageSize;

		private string invokeId;

		private bool? timed;

		private string commandName;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string commandType;

		private string instanceId;

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

		public string InvokeStatus
		{
			get
			{
				return invokeStatus;
			}
			set	
			{
				invokeStatus = value;
				DictionaryUtil.Add(QueryParameters, "InvokeStatus", value);
			}
		}

		public bool? IncludeOutput
		{
			get
			{
				return includeOutput;
			}
			set	
			{
				includeOutput = value;
				DictionaryUtil.Add(QueryParameters, "IncludeOutput", value.ToString());
			}
		}

		public string CommandId
		{
			get
			{
				return commandId;
			}
			set	
			{
				commandId = value;
				DictionaryUtil.Add(QueryParameters, "CommandId", value);
			}
		}

		public long? PageNumber
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

		public string ContentEncoding
		{
			get
			{
				return contentEncoding;
			}
			set	
			{
				contentEncoding = value;
				DictionaryUtil.Add(QueryParameters, "ContentEncoding", value);
			}
		}

		public long? PageSize
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

		public string InvokeId
		{
			get
			{
				return invokeId;
			}
			set	
			{
				invokeId = value;
				DictionaryUtil.Add(QueryParameters, "InvokeId", value);
			}
		}

		public bool? Timed
		{
			get
			{
				return timed;
			}
			set	
			{
				timed = value;
				DictionaryUtil.Add(QueryParameters, "Timed", value.ToString());
			}
		}

		public string CommandName
		{
			get
			{
				return commandName;
			}
			set	
			{
				commandName = value;
				DictionaryUtil.Add(QueryParameters, "CommandName", value);
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

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
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

		public string CommandType
		{
			get
			{
				return commandType;
			}
			set	
			{
				commandType = value;
				DictionaryUtil.Add(QueryParameters, "CommandType", value);
			}
		}

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

        public override DescribeInvocationsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeInvocationsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
