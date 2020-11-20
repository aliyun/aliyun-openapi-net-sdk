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
    public class DescribeScheduledTasksRequest : RpcAcsRequest<DescribeScheduledTasksResponse>
    {
        public DescribeScheduledTasksRequest()
            : base("Ess", "2014-08-28", "DescribeScheduledTasks", "ess", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string scheduledAction2;

		private string scheduledAction1;

		private string scheduledAction6;

		private string scheduledAction5;

		private string scheduledAction4;

		private string scheduledAction3;

		private string scheduledAction9;

		private string scheduledAction8;

		private string scheduledAction7;

		private long? ownerId;

		private string scheduledTaskName20;

		private string scheduledTaskName19;

		private string scheduledTaskName18;

		private string scheduledTaskId20;

		private string scalingGroupId;

		private string scheduledTaskName13;

		private string scheduledTaskName12;

		private string scheduledTaskName11;

		private string scheduledTaskName10;

		private string scheduledTaskName17;

		private string scheduledTaskName16;

		private int? pageNumber;

		private string scheduledTaskName15;

		private string scheduledTaskName14;

		private string scheduledTaskId2;

		private string scheduledTaskId1;

		private string scheduledTaskId4;

		private string scheduledTaskId18;

		private string scheduledTaskId3;

		private string scheduledTaskId19;

		private string scheduledTaskId6;

		private string scheduledTaskId5;

		private string scheduledTaskId8;

		private string scheduledTaskName9;

		private string scheduledAction20;

		private string scheduledTaskId7;

		private int? pageSize;

		private string scheduledTaskId12;

		private string scheduledTaskName7;

		private string scheduledTaskId9;

		private string scheduledTaskId13;

		private string scheduledTaskName8;

		private string scheduledTaskId10;

		private string scheduledTaskName5;

		private string scheduledTaskId11;

		private string scheduledTaskName6;

		private string scheduledTaskId16;

		private string scheduledTaskName3;

		private string scheduledTaskId17;

		private string scheduledTaskName4;

		private string scheduledTaskId14;

		private string scheduledTaskName1;

		private string scheduledTaskId15;

		private string scheduledTaskName2;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string scheduledAction18;

		private string scheduledAction19;

		private string scheduledAction16;

		private string scheduledAction17;

		private string scheduledAction14;

		private string scheduledAction15;

		private string scheduledAction12;

		private string scheduledAction13;

		private string scheduledAction10;

		private string scheduledAction11;

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

		public string ScheduledAction2
		{
			get
			{
				return scheduledAction2;
			}
			set	
			{
				scheduledAction2 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.2", value);
			}
		}

		public string ScheduledAction1
		{
			get
			{
				return scheduledAction1;
			}
			set	
			{
				scheduledAction1 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.1", value);
			}
		}

		public string ScheduledAction6
		{
			get
			{
				return scheduledAction6;
			}
			set	
			{
				scheduledAction6 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.6", value);
			}
		}

		public string ScheduledAction5
		{
			get
			{
				return scheduledAction5;
			}
			set	
			{
				scheduledAction5 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.5", value);
			}
		}

		public string ScheduledAction4
		{
			get
			{
				return scheduledAction4;
			}
			set	
			{
				scheduledAction4 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.4", value);
			}
		}

		public string ScheduledAction3
		{
			get
			{
				return scheduledAction3;
			}
			set	
			{
				scheduledAction3 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.3", value);
			}
		}

		public string ScheduledAction9
		{
			get
			{
				return scheduledAction9;
			}
			set	
			{
				scheduledAction9 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.9", value);
			}
		}

		public string ScheduledAction8
		{
			get
			{
				return scheduledAction8;
			}
			set	
			{
				scheduledAction8 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.8", value);
			}
		}

		public string ScheduledAction7
		{
			get
			{
				return scheduledAction7;
			}
			set	
			{
				scheduledAction7 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.7", value);
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

		public string ScheduledTaskName20
		{
			get
			{
				return scheduledTaskName20;
			}
			set	
			{
				scheduledTaskName20 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.20", value);
			}
		}

		public string ScheduledTaskName19
		{
			get
			{
				return scheduledTaskName19;
			}
			set	
			{
				scheduledTaskName19 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.19", value);
			}
		}

		public string ScheduledTaskName18
		{
			get
			{
				return scheduledTaskName18;
			}
			set	
			{
				scheduledTaskName18 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.18", value);
			}
		}

		public string ScheduledTaskId20
		{
			get
			{
				return scheduledTaskId20;
			}
			set	
			{
				scheduledTaskId20 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.20", value);
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

		public string ScheduledTaskName13
		{
			get
			{
				return scheduledTaskName13;
			}
			set	
			{
				scheduledTaskName13 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.13", value);
			}
		}

		public string ScheduledTaskName12
		{
			get
			{
				return scheduledTaskName12;
			}
			set	
			{
				scheduledTaskName12 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.12", value);
			}
		}

		public string ScheduledTaskName11
		{
			get
			{
				return scheduledTaskName11;
			}
			set	
			{
				scheduledTaskName11 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.11", value);
			}
		}

		public string ScheduledTaskName10
		{
			get
			{
				return scheduledTaskName10;
			}
			set	
			{
				scheduledTaskName10 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.10", value);
			}
		}

		public string ScheduledTaskName17
		{
			get
			{
				return scheduledTaskName17;
			}
			set	
			{
				scheduledTaskName17 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.17", value);
			}
		}

		public string ScheduledTaskName16
		{
			get
			{
				return scheduledTaskName16;
			}
			set	
			{
				scheduledTaskName16 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.16", value);
			}
		}

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

		public string ScheduledTaskName15
		{
			get
			{
				return scheduledTaskName15;
			}
			set	
			{
				scheduledTaskName15 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.15", value);
			}
		}

		public string ScheduledTaskName14
		{
			get
			{
				return scheduledTaskName14;
			}
			set	
			{
				scheduledTaskName14 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.14", value);
			}
		}

		public string ScheduledTaskId2
		{
			get
			{
				return scheduledTaskId2;
			}
			set	
			{
				scheduledTaskId2 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.2", value);
			}
		}

		public string ScheduledTaskId1
		{
			get
			{
				return scheduledTaskId1;
			}
			set	
			{
				scheduledTaskId1 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.1", value);
			}
		}

		public string ScheduledTaskId4
		{
			get
			{
				return scheduledTaskId4;
			}
			set	
			{
				scheduledTaskId4 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.4", value);
			}
		}

		public string ScheduledTaskId18
		{
			get
			{
				return scheduledTaskId18;
			}
			set	
			{
				scheduledTaskId18 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.18", value);
			}
		}

		public string ScheduledTaskId3
		{
			get
			{
				return scheduledTaskId3;
			}
			set	
			{
				scheduledTaskId3 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.3", value);
			}
		}

		public string ScheduledTaskId19
		{
			get
			{
				return scheduledTaskId19;
			}
			set	
			{
				scheduledTaskId19 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.19", value);
			}
		}

		public string ScheduledTaskId6
		{
			get
			{
				return scheduledTaskId6;
			}
			set	
			{
				scheduledTaskId6 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.6", value);
			}
		}

		public string ScheduledTaskId5
		{
			get
			{
				return scheduledTaskId5;
			}
			set	
			{
				scheduledTaskId5 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.5", value);
			}
		}

		public string ScheduledTaskId8
		{
			get
			{
				return scheduledTaskId8;
			}
			set	
			{
				scheduledTaskId8 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.8", value);
			}
		}

		public string ScheduledTaskName9
		{
			get
			{
				return scheduledTaskName9;
			}
			set	
			{
				scheduledTaskName9 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.9", value);
			}
		}

		public string ScheduledAction20
		{
			get
			{
				return scheduledAction20;
			}
			set	
			{
				scheduledAction20 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.20", value);
			}
		}

		public string ScheduledTaskId7
		{
			get
			{
				return scheduledTaskId7;
			}
			set	
			{
				scheduledTaskId7 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.7", value);
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

		public string ScheduledTaskId12
		{
			get
			{
				return scheduledTaskId12;
			}
			set	
			{
				scheduledTaskId12 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.12", value);
			}
		}

		public string ScheduledTaskName7
		{
			get
			{
				return scheduledTaskName7;
			}
			set	
			{
				scheduledTaskName7 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.7", value);
			}
		}

		public string ScheduledTaskId9
		{
			get
			{
				return scheduledTaskId9;
			}
			set	
			{
				scheduledTaskId9 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.9", value);
			}
		}

		public string ScheduledTaskId13
		{
			get
			{
				return scheduledTaskId13;
			}
			set	
			{
				scheduledTaskId13 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.13", value);
			}
		}

		public string ScheduledTaskName8
		{
			get
			{
				return scheduledTaskName8;
			}
			set	
			{
				scheduledTaskName8 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.8", value);
			}
		}

		public string ScheduledTaskId10
		{
			get
			{
				return scheduledTaskId10;
			}
			set	
			{
				scheduledTaskId10 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.10", value);
			}
		}

		public string ScheduledTaskName5
		{
			get
			{
				return scheduledTaskName5;
			}
			set	
			{
				scheduledTaskName5 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.5", value);
			}
		}

		public string ScheduledTaskId11
		{
			get
			{
				return scheduledTaskId11;
			}
			set	
			{
				scheduledTaskId11 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.11", value);
			}
		}

		public string ScheduledTaskName6
		{
			get
			{
				return scheduledTaskName6;
			}
			set	
			{
				scheduledTaskName6 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.6", value);
			}
		}

		public string ScheduledTaskId16
		{
			get
			{
				return scheduledTaskId16;
			}
			set	
			{
				scheduledTaskId16 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.16", value);
			}
		}

		public string ScheduledTaskName3
		{
			get
			{
				return scheduledTaskName3;
			}
			set	
			{
				scheduledTaskName3 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.3", value);
			}
		}

		public string ScheduledTaskId17
		{
			get
			{
				return scheduledTaskId17;
			}
			set	
			{
				scheduledTaskId17 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.17", value);
			}
		}

		public string ScheduledTaskName4
		{
			get
			{
				return scheduledTaskName4;
			}
			set	
			{
				scheduledTaskName4 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.4", value);
			}
		}

		public string ScheduledTaskId14
		{
			get
			{
				return scheduledTaskId14;
			}
			set	
			{
				scheduledTaskId14 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.14", value);
			}
		}

		public string ScheduledTaskName1
		{
			get
			{
				return scheduledTaskName1;
			}
			set	
			{
				scheduledTaskName1 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.1", value);
			}
		}

		public string ScheduledTaskId15
		{
			get
			{
				return scheduledTaskId15;
			}
			set	
			{
				scheduledTaskId15 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskId.15", value);
			}
		}

		public string ScheduledTaskName2
		{
			get
			{
				return scheduledTaskName2;
			}
			set	
			{
				scheduledTaskName2 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTaskName.2", value);
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

		public string ScheduledAction18
		{
			get
			{
				return scheduledAction18;
			}
			set	
			{
				scheduledAction18 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.18", value);
			}
		}

		public string ScheduledAction19
		{
			get
			{
				return scheduledAction19;
			}
			set	
			{
				scheduledAction19 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.19", value);
			}
		}

		public string ScheduledAction16
		{
			get
			{
				return scheduledAction16;
			}
			set	
			{
				scheduledAction16 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.16", value);
			}
		}

		public string ScheduledAction17
		{
			get
			{
				return scheduledAction17;
			}
			set	
			{
				scheduledAction17 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.17", value);
			}
		}

		public string ScheduledAction14
		{
			get
			{
				return scheduledAction14;
			}
			set	
			{
				scheduledAction14 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.14", value);
			}
		}

		public string ScheduledAction15
		{
			get
			{
				return scheduledAction15;
			}
			set	
			{
				scheduledAction15 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.15", value);
			}
		}

		public string ScheduledAction12
		{
			get
			{
				return scheduledAction12;
			}
			set	
			{
				scheduledAction12 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.12", value);
			}
		}

		public string ScheduledAction13
		{
			get
			{
				return scheduledAction13;
			}
			set	
			{
				scheduledAction13 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.13", value);
			}
		}

		public string ScheduledAction10
		{
			get
			{
				return scheduledAction10;
			}
			set	
			{
				scheduledAction10 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.10", value);
			}
		}

		public string ScheduledAction11
		{
			get
			{
				return scheduledAction11;
			}
			set	
			{
				scheduledAction11 = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledAction.11", value);
			}
		}

        public override DescribeScheduledTasksResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeScheduledTasksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
