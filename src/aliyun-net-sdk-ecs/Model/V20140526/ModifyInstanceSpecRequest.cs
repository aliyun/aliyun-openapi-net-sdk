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
    public class ModifyInstanceSpecRequest : RpcAcsRequest<ModifyInstanceSpecResponse>
    {
        public ModifyInstanceSpecRequest()
            : base("Ecs", "2014-05-26", "ModifyInstanceSpec")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _instanceId;

		private string _instanceType;

		private int? _internetMaxBandwidthOut;

		private int? _internetMaxBandwidthIn;

		private string _ownerAccount;

		private string _temporaryStartTime;

		private string _temporaryEndTime;

		private int? _temporaryInternetMaxBandwidthOut;

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

		public string InstanceId
		{
			get
			{
				return _instanceId;
			}
			set	
			{
				_instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string InstanceType
		{
			get
			{
				return _instanceType;
			}
			set	
			{
				_instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public int? InternetMaxBandwidthOut
		{
			get
			{
				return _internetMaxBandwidthOut;
			}
			set	
			{
				_internetMaxBandwidthOut = value;
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandwidthOut", value.ToString());
			}
		}

		public int? InternetMaxBandwidthIn
		{
			get
			{
				return _internetMaxBandwidthIn;
			}
			set	
			{
				_internetMaxBandwidthIn = value;
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandwidthIn", value.ToString());
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

		public string TemporaryStartTime
		{
			get
			{
				return _temporaryStartTime;
			}
			set	
			{
				_temporaryStartTime = value;
				DictionaryUtil.Add(QueryParameters, "Temporary.StartTime", value);
			}
		}

		public string TemporaryEndTime
		{
			get
			{
				return _temporaryEndTime;
			}
			set	
			{
				_temporaryEndTime = value;
				DictionaryUtil.Add(QueryParameters, "Temporary.EndTime", value);
			}
		}

		public int? TemporaryInternetMaxBandwidthOut
		{
			get
			{
				return _temporaryInternetMaxBandwidthOut;
			}
			set	
			{
				_temporaryInternetMaxBandwidthOut = value;
				DictionaryUtil.Add(QueryParameters, "Temporary.InternetMaxBandwidthOut", value.ToString());
			}
		}

        public override ModifyInstanceSpecResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyInstanceSpecResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}