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
using Aliyun.Acs.ROS.Transform;
using Aliyun.Acs.ROS.Transform.V20190910;

namespace Aliyun.Acs.ROS.Model.V20190910
{
    public class DeleteStackInstancesRequest : RpcAcsRequest<DeleteStackInstancesResponse>
    {
        public DeleteStackInstancesRequest()
            : base("ROS", "2019-09-10", "DeleteStackInstances", "ros", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ROS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ROS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private bool? retainStacks;

		private string stackGroupName;

		private string operationDescription;

		private Dictionary<object,object> operationPreferences;

		private List<object> regionIds;

		private List<object> accountIds;

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

		public bool? RetainStacks
		{
			get
			{
				return retainStacks;
			}
			set	
			{
				retainStacks = value;
				DictionaryUtil.Add(QueryParameters, "RetainStacks", value.ToString());
			}
		}

		public string StackGroupName
		{
			get
			{
				return stackGroupName;
			}
			set	
			{
				stackGroupName = value;
				DictionaryUtil.Add(QueryParameters, "StackGroupName", value);
			}
		}

		public string OperationDescription
		{
			get
			{
				return operationDescription;
			}
			set	
			{
				operationDescription = value;
				DictionaryUtil.Add(QueryParameters, "OperationDescription", value);
			}
		}

		public Dictionary<object,object> OperationPreferences
		{
			get
			{
				return operationPreferences;
			}
			set	
			{
				operationPreferences = value;
				DictionaryUtil.Add(QueryParameters, "OperationPreferences", JsonConvert.SerializeObject(value));
			}
		}

		public List<object> RegionIds
		{
			get
			{
				return regionIds;
			}
			set	
			{
				regionIds = value;
				DictionaryUtil.Add(QueryParameters, "RegionIds", JsonConvert.SerializeObject(value));
			}
		}

		public List<object> AccountIds
		{
			get
			{
				return accountIds;
			}
			set	
			{
				accountIds = value;
				DictionaryUtil.Add(QueryParameters, "AccountIds", JsonConvert.SerializeObject(value));
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteStackInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteStackInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
