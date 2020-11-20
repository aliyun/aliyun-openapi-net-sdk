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
using Aliyun.Acs.Ess.Transform;
using Aliyun.Acs.Ess.Transform.V20140828;

namespace Aliyun.Acs.Ess.Model.V20140828
{
    public class ModifyScheduledTaskRequest : RpcAcsRequest<ModifyScheduledTaskResponse>
    {
        public ModifyScheduledTaskRequest()
            : base("Ess", "2014-08-28", "ModifyScheduledTask", "ess", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string scheduledAction;

		private int? maxValue;

		private string scalingGroupId;

		private string description;

		private string recurrenceEndTime;

		private string launchTime;

		private int? desiredCapacity;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string recurrenceValue;

		private int? launchExpirationTime;

		private int? minValue;

		private string scheduledTaskName;

		private bool? taskEnabled;

		private string scheduledTaskId;

		private string recurrenceType;

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

		public string ScheduledAction
		{
			get
			{
				return scheduledAction;
			}
			set	
			{
				scheduledAction = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction", value);
			}
		}

		public int? MaxValue
		{
			get
			{
				return maxValue;
			}
			set	
			{
				maxValue = value;
				DictionaryUtil.Add(QueryParameters, "MaxValue", value.ToString());
			}
		}

		public string ScalingGroupId
		{
			get
			{
				return scalingGroupId;
			}
			set	
			{
				scalingGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string RecurrenceEndTime
		{
			get
			{
				return recurrenceEndTime;
			}
			set	
			{
				recurrenceEndTime = value;
				DictionaryUtil.Add(QueryParameters, "RecurrenceEndTime", value);
			}
		}

		public string LaunchTime
		{
			get
			{
				return launchTime;
			}
			set	
			{
				launchTime = value;
				DictionaryUtil.Add(QueryParameters, "LaunchTime", value);
			}
		}

		public int? DesiredCapacity
		{
			get
			{
				return desiredCapacity;
			}
			set	
			{
				desiredCapacity = value;
				DictionaryUtil.Add(QueryParameters, "DesiredCapacity", value.ToString());
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

		public string RecurrenceValue
		{
			get
			{
				return recurrenceValue;
			}
			set	
			{
				recurrenceValue = value;
				DictionaryUtil.Add(QueryParameters, "RecurrenceValue", value);
			}
		}

		public int? LaunchExpirationTime
		{
			get
			{
				return launchExpirationTime;
			}
			set	
			{
				launchExpirationTime = value;
				DictionaryUtil.Add(QueryParameters, "LaunchExpirationTime", value.ToString());
			}
		}

		public int? MinValue
		{
			get
			{
				return minValue;
			}
			set	
			{
				minValue = value;
				DictionaryUtil.Add(QueryParameters, "MinValue", value.ToString());
			}
		}

		public string ScheduledTaskName
		{
			get
			{
				return scheduledTaskName;
			}
			set	
			{
				scheduledTaskName = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName", value);
			}
		}

		public bool? TaskEnabled
		{
			get
			{
				return taskEnabled;
			}
			set	
			{
				taskEnabled = value;
				DictionaryUtil.Add(QueryParameters, "TaskEnabled", value.ToString());
			}
		}

		public string ScheduledTaskId
		{
			get
			{
				return scheduledTaskId;
			}
			set	
			{
				scheduledTaskId = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId", value);
			}
		}

		public string RecurrenceType
		{
			get
			{
				return recurrenceType;
			}
			set	
			{
				recurrenceType = value;
				DictionaryUtil.Add(QueryParameters, "RecurrenceType", value);
			}
		}

        public override ModifyScheduledTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyScheduledTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
