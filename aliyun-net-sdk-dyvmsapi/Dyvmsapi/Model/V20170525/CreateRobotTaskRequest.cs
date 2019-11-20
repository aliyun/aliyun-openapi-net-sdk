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
using Aliyun.Acs.Dyvmsapi.Transform;
using Aliyun.Acs.Dyvmsapi.Transform.V20170525;

namespace Aliyun.Acs.Dyvmsapi.Model.V20170525
{
    public class CreateRobotTaskRequest : RpcAcsRequest<CreateRobotTaskResponse>
    {
        public CreateRobotTaskRequest()
            : base("Dyvmsapi", "2017-05-25", "CreateRobotTask", "dyvms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string recallStateCodes;

		private string taskName;

		private int? recallTimes;

		private bool? isSelfLine;

		private string resourceOwnerAccount;

		private int? retryType;

		private long? ownerId;

		private long? dialogId;

		private string caller;

		private bool? numberStatusIdent;

		private string corpName;

		private int? recallInterval;

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

		public string RecallStateCodes
		{
			get
			{
				return recallStateCodes;
			}
			set	
			{
				recallStateCodes = value;
				DictionaryUtil.Add(QueryParameters, "RecallStateCodes", value);
			}
		}

		public string TaskName
		{
			get
			{
				return taskName;
			}
			set	
			{
				taskName = value;
				DictionaryUtil.Add(QueryParameters, "TaskName", value);
			}
		}

		public int? RecallTimes
		{
			get
			{
				return recallTimes;
			}
			set	
			{
				recallTimes = value;
				DictionaryUtil.Add(QueryParameters, "RecallTimes", value.ToString());
			}
		}

		public bool? IsSelfLine
		{
			get
			{
				return isSelfLine;
			}
			set	
			{
				isSelfLine = value;
				DictionaryUtil.Add(QueryParameters, "IsSelfLine", value.ToString());
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

		public int? RetryType
		{
			get
			{
				return retryType;
			}
			set	
			{
				retryType = value;
				DictionaryUtil.Add(QueryParameters, "RetryType", value.ToString());
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

		public long? DialogId
		{
			get
			{
				return dialogId;
			}
			set	
			{
				dialogId = value;
				DictionaryUtil.Add(QueryParameters, "DialogId", value.ToString());
			}
		}

		public string Caller
		{
			get
			{
				return caller;
			}
			set	
			{
				caller = value;
				DictionaryUtil.Add(QueryParameters, "Caller", value);
			}
		}

		public bool? NumberStatusIdent
		{
			get
			{
				return numberStatusIdent;
			}
			set	
			{
				numberStatusIdent = value;
				DictionaryUtil.Add(QueryParameters, "NumberStatusIdent", value.ToString());
			}
		}

		public string CorpName
		{
			get
			{
				return corpName;
			}
			set	
			{
				corpName = value;
				DictionaryUtil.Add(QueryParameters, "CorpName", value);
			}
		}

		public int? RecallInterval
		{
			get
			{
				return recallInterval;
			}
			set	
			{
				recallInterval = value;
				DictionaryUtil.Add(QueryParameters, "RecallInterval", value.ToString());
			}
		}

        public override CreateRobotTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateRobotTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
