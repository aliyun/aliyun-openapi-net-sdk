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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DescribeEipMonitorDataRequest : RpcAcsRequest<DescribeEipMonitorDataResponse>
    {
        public DescribeEipMonitorDataRequest()
            : base("Ecs", "2014-05-26", "DescribeEipMonitorData")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _allocationId;

		private string _startTime;

		private string _endTime;

		private int? _period;

		private string _ownerAccount;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string AllocationId
		{
			get
			{
				return _allocationId;
			}
			set	
			{
				_allocationId = value;
				DictionaryUtil.Add(QueryParameters, "AllocationId", value);
			}
		}

		public string StartTime
		{
			get
			{
				return _startTime;
			}
			set	
			{
				_startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public string EndTime
		{
			get
			{
				return _endTime;
			}
			set	
			{
				_endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public int? Period
		{
			get
			{
				return _period;
			}
			set	
			{
				_period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		public string OwnerAccount
		{
			get
			{
				return _ownerAccount;
			}
			set	
			{
				_ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

        public override DescribeEipMonitorDataResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeEipMonitorDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}