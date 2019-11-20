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
    public class ClickToDialRequest : RpcAcsRequest<ClickToDialResponse>
    {
        public ClickToDialRequest()
            : base("Dyvmsapi", "2017-05-25", "ClickToDial", "dyvms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string callerShowNumber;

		private int? sessionTimeout;

		private string calledNumber;

		private string calledShowNumber;

		private bool? asrFlag;

		private string resourceOwnerAccount;

		private bool? recordFlag;

		private long? ownerId;

		private string outId;

		private string asrModelId;

		private string callerNumber;

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

		public string CallerShowNumber
		{
			get
			{
				return callerShowNumber;
			}
			set	
			{
				callerShowNumber = value;
				DictionaryUtil.Add(QueryParameters, "CallerShowNumber", value);
			}
		}

		public int? SessionTimeout
		{
			get
			{
				return sessionTimeout;
			}
			set	
			{
				sessionTimeout = value;
				DictionaryUtil.Add(QueryParameters, "SessionTimeout", value.ToString());
			}
		}

		public string CalledNumber
		{
			get
			{
				return calledNumber;
			}
			set	
			{
				calledNumber = value;
				DictionaryUtil.Add(QueryParameters, "CalledNumber", value);
			}
		}

		public string CalledShowNumber
		{
			get
			{
				return calledShowNumber;
			}
			set	
			{
				calledShowNumber = value;
				DictionaryUtil.Add(QueryParameters, "CalledShowNumber", value);
			}
		}

		public bool? AsrFlag
		{
			get
			{
				return asrFlag;
			}
			set	
			{
				asrFlag = value;
				DictionaryUtil.Add(QueryParameters, "AsrFlag", value.ToString());
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

		public bool? RecordFlag
		{
			get
			{
				return recordFlag;
			}
			set	
			{
				recordFlag = value;
				DictionaryUtil.Add(QueryParameters, "RecordFlag", value.ToString());
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

		public string OutId
		{
			get
			{
				return outId;
			}
			set	
			{
				outId = value;
				DictionaryUtil.Add(QueryParameters, "OutId", value);
			}
		}

		public string AsrModelId
		{
			get
			{
				return asrModelId;
			}
			set	
			{
				asrModelId = value;
				DictionaryUtil.Add(QueryParameters, "AsrModelId", value);
			}
		}

		public string CallerNumber
		{
			get
			{
				return callerNumber;
			}
			set	
			{
				callerNumber = value;
				DictionaryUtil.Add(QueryParameters, "CallerNumber", value);
			}
		}

        public override ClickToDialResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ClickToDialResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
