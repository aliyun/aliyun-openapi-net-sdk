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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ModifyInstanceMaintenanceAttributesRequest : RpcAcsRequest<ModifyInstanceMaintenanceAttributesResponse>
    {
        public ModifyInstanceMaintenanceAttributesRequest()
            : base("Ecs", "2014-05-26", "ModifyInstanceMaintenanceAttributes", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private List<string> maintenanceWindows = new List<string>(){ };

		private string actionOnMaintenance;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private bool? notifyOnMaintenance;

		private List<string> instanceIds = new List<string>(){ };

		[JsonProperty(PropertyName = "ResourceOwnerId")]
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

		[JsonProperty(PropertyName = "MaintenanceWindow")]
		public List<string> MaintenanceWindows
		{
			get
			{
				return maintenanceWindows;
			}

			set
			{
				maintenanceWindows = value;
				if(maintenanceWindows != null)
				{
					for (int depth1 = 0; depth1 < maintenanceWindows.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"MaintenanceWindow." + (depth1 + 1), maintenanceWindows[depth1]);
						DictionaryUtil.Add(QueryParameters,"MaintenanceWindow." + (depth1 + 1), maintenanceWindows[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "ActionOnMaintenance")]
		public string ActionOnMaintenance
		{
			get
			{
				return actionOnMaintenance;
			}
			set	
			{
				actionOnMaintenance = value;
				DictionaryUtil.Add(QueryParameters, "ActionOnMaintenance", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
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

		[JsonProperty(PropertyName = "OwnerAccount")]
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

		[JsonProperty(PropertyName = "OwnerId")]
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

		[JsonProperty(PropertyName = "NotifyOnMaintenance")]
		public bool? NotifyOnMaintenance
		{
			get
			{
				return notifyOnMaintenance;
			}
			set	
			{
				notifyOnMaintenance = value;
				DictionaryUtil.Add(QueryParameters, "NotifyOnMaintenance", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "InstanceId")]
		public List<string> InstanceIds
		{
			get
			{
				return instanceIds;
			}

			set
			{
				instanceIds = value;
			}
		}

		public class MaintenanceWindow
		{

			private string endTime;

			private string startTime;

			[JsonProperty(PropertyName = "EndTime")]
			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			[JsonProperty(PropertyName = "StartTime")]
			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}
		}

        public override ModifyInstanceMaintenanceAttributesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyInstanceMaintenanceAttributesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
