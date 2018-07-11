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
using Aliyun.Acs.Ess.Transform;
using Aliyun.Acs.Ess.Transform.V20140828;
using System.Collections.Generic;

namespace Aliyun.Acs.Ess.Model.V20140828
{
    public class CreateScheduledTaskRequest : RpcAcsRequest<CreateScheduledTaskResponse>
    {
        public CreateScheduledTaskRequest()
            : base("Ess", "2014-08-28", "CreateScheduledTask", "ess", "openAPI")
        {
        }

		private string launchTime;

		private string scheduledAction;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string description;

		private long? ownerId;

		private string recurrenceValue;

		private int? launchExpirationTime;

		private string recurrenceEndTime;

		private string accessKeyId;

		private string regionId;

		private string action;

		private string scheduledTaskName;

		private bool? taskEnabled;

		private string recurrenceType;

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

        public override CreateScheduledTaskResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateScheduledTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}