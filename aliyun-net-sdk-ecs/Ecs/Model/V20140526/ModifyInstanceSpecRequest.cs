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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ModifyInstanceSpecRequest : RpcAcsRequest<ModifyInstanceSpecResponse>
    {
        public ModifyInstanceSpecRequest()
            : base("Ecs", "2014-05-26", "ModifyInstanceSpec", "ecs", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string clientToken;

		private bool? allowMigrateAcrossZone;

		private string ownerAccount;

		private int? internetMaxBandwidthOut;

		private long? ownerId;

		private int? temporaryInternetMaxBandwidthOut;

		private string systemDiskCategory;

		private string temporaryStartTime;

		private bool? async;

		private string instanceId;

		private string action;

		private string instanceType;

		private string temporaryEndTime;

		private int? internetMaxBandwidthIn;

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

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public bool? AllowMigrateAcrossZone
		{
			get
			{
				return allowMigrateAcrossZone;
			}
			set	
			{
				allowMigrateAcrossZone = value;
				DictionaryUtil.Add(QueryParameters, "AllowMigrateAcrossZone", value.ToString());
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

		public int? InternetMaxBandwidthOut
		{
			get
			{
				return internetMaxBandwidthOut;
			}
			set	
			{
				internetMaxBandwidthOut = value;
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandwidthOut", value.ToString());
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

		public int? TemporaryInternetMaxBandwidthOut
		{
			get
			{
				return temporaryInternetMaxBandwidthOut;
			}
			set	
			{
				temporaryInternetMaxBandwidthOut = value;
				DictionaryUtil.Add(QueryParameters, "Temporary.InternetMaxBandwidthOut", value.ToString());
			}
		}

		public string SystemDiskCategory
		{
			get
			{
				return systemDiskCategory;
			}
			set	
			{
				systemDiskCategory = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Category", value);
			}
		}

		public string TemporaryStartTime
		{
			get
			{
				return temporaryStartTime;
			}
			set	
			{
				temporaryStartTime = value;
				DictionaryUtil.Add(QueryParameters, "Temporary.StartTime", value);
			}
		}

		public bool? Async
		{
			get
			{
				return async;
			}
			set	
			{
				async = value;
				DictionaryUtil.Add(QueryParameters, "Async", value.ToString());
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

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public string TemporaryEndTime
		{
			get
			{
				return temporaryEndTime;
			}
			set	
			{
				temporaryEndTime = value;
				DictionaryUtil.Add(QueryParameters, "Temporary.EndTime", value);
			}
		}

		public int? InternetMaxBandwidthIn
		{
			get
			{
				return internetMaxBandwidthIn;
			}
			set	
			{
				internetMaxBandwidthIn = value;
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandwidthIn", value.ToString());
			}
		}

        public override ModifyInstanceSpecResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyInstanceSpecResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}