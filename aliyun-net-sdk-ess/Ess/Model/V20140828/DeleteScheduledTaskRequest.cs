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
    public class DeleteScheduledTaskRequest : RpcAcsRequest<DeleteScheduledTaskResponse>
    {
        public DeleteScheduledTaskRequest()
            : base("Ess", "2014-08-28", "DeleteScheduledTask", "ess", "openAPI")
        {
        }

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string action;

		private long? ownerId;

		private string scheduledTaskId;

		private string accessKeyId;

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

        public override DeleteScheduledTaskResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DeleteScheduledTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}