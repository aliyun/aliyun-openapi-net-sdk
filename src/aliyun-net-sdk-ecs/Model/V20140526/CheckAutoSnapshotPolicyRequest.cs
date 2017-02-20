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
    public class CheckAutoSnapshotPolicyRequest : RpcAcsRequest<CheckAutoSnapshotPolicyResponse>
    {
        public CheckAutoSnapshotPolicyRequest()
            : base("Ecs", "2014-05-26", "CheckAutoSnapshotPolicy")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _ownerAccount;

		private bool? _systemDiskPolicyEnabled;

		private int? _systemDiskPolicyTimePeriod;

		private int? _systemDiskPolicyRetentionDays;

		private bool? _systemDiskPolicyRetentionLastWeek;

		private bool? _dataDiskPolicyEnabled;

		private int? _dataDiskPolicyTimePeriod;

		private int? _dataDiskPolicyRetentionDays;

		private bool? _dataDiskPolicyRetentionLastWeek;

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

		public bool? SystemDiskPolicyEnabled
		{
			get
			{
				return _systemDiskPolicyEnabled;
			}
			set	
			{
				_systemDiskPolicyEnabled = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskPolicyEnabled", value.ToString());
			}
		}

		public int? SystemDiskPolicyTimePeriod
		{
			get
			{
				return _systemDiskPolicyTimePeriod;
			}
			set	
			{
				_systemDiskPolicyTimePeriod = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskPolicyTimePeriod", value.ToString());
			}
		}

		public int? SystemDiskPolicyRetentionDays
		{
			get
			{
				return _systemDiskPolicyRetentionDays;
			}
			set	
			{
				_systemDiskPolicyRetentionDays = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskPolicyRetentionDays", value.ToString());
			}
		}

		public bool? SystemDiskPolicyRetentionLastWeek
		{
			get
			{
				return _systemDiskPolicyRetentionLastWeek;
			}
			set	
			{
				_systemDiskPolicyRetentionLastWeek = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskPolicyRetentionLastWeek", value.ToString());
			}
		}

		public bool? DataDiskPolicyEnabled
		{
			get
			{
				return _dataDiskPolicyEnabled;
			}
			set	
			{
				_dataDiskPolicyEnabled = value;
				DictionaryUtil.Add(QueryParameters, "DataDiskPolicyEnabled", value.ToString());
			}
		}

		public int? DataDiskPolicyTimePeriod
		{
			get
			{
				return _dataDiskPolicyTimePeriod;
			}
			set	
			{
				_dataDiskPolicyTimePeriod = value;
				DictionaryUtil.Add(QueryParameters, "DataDiskPolicyTimePeriod", value.ToString());
			}
		}

		public int? DataDiskPolicyRetentionDays
		{
			get
			{
				return _dataDiskPolicyRetentionDays;
			}
			set	
			{
				_dataDiskPolicyRetentionDays = value;
				DictionaryUtil.Add(QueryParameters, "DataDiskPolicyRetentionDays", value.ToString());
			}
		}

		public bool? DataDiskPolicyRetentionLastWeek
		{
			get
			{
				return _dataDiskPolicyRetentionLastWeek;
			}
			set	
			{
				_dataDiskPolicyRetentionLastWeek = value;
				DictionaryUtil.Add(QueryParameters, "DataDiskPolicyRetentionLastWeek", value.ToString());
			}
		}

        public override CheckAutoSnapshotPolicyResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CheckAutoSnapshotPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}