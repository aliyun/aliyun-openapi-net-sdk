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
using Aliyun.Acs.CCC;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class AddBulkPhoneNumbersRequest : RpcAcsRequest<AddBulkPhoneNumbersResponse>
    {
        public AddBulkPhoneNumbersRequest()
            : base("CCC", "2017-07-05", "AddBulkPhoneNumbers")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string contactFlowId;

		private string usage;

		private List<string> phoneNumbers = new List<string>(){ };

		private string instanceId;

		private List<string> skillGroupIds = new List<string>(){ };

		public string ContactFlowId
		{
			get
			{
				return contactFlowId;
			}
			set	
			{
				contactFlowId = value;
				DictionaryUtil.Add(QueryParameters, "ContactFlowId", value);
			}
		}

		public string Usage
		{
			get
			{
				return usage;
			}
			set	
			{
				usage = value;
				DictionaryUtil.Add(QueryParameters, "Usage", value);
			}
		}

		public List<string> PhoneNumbers
		{
			get
			{
				return phoneNumbers;
			}

			set
			{
				phoneNumbers = value;
				for (int i = 0; i < phoneNumbers.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"PhoneNumber." + (i + 1) , phoneNumbers[i]);
				}
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

		public List<string> SkillGroupIds
		{
			get
			{
				return skillGroupIds;
			}

			set
			{
				skillGroupIds = value;
				for (int i = 0; i < skillGroupIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SkillGroupId." + (i + 1) , skillGroupIds[i]);
				}
			}
		}

        public override AddBulkPhoneNumbersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddBulkPhoneNumbersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
