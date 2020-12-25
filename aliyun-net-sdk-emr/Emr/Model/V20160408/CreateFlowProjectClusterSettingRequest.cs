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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class CreateFlowProjectClusterSettingRequest : RpcAcsRequest<CreateFlowProjectClusterSettingResponse>
    {
        public CreateFlowProjectClusterSettingRequest()
            : base("Emr", "2016-04-08", "CreateFlowProjectClusterSetting", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> userLists = new List<string>(){ };

		private List<string> hostLists = new List<string>(){ };

		private string clusterId;

		private string defaultQueue;

		private string defaultUser;

		private List<string> queueLists = new List<string>(){ };

		private string projectId;

		public List<string> UserLists
		{
			get
			{
				return userLists;
			}

			set
			{
				userLists = value;
				for (int i = 0; i < userLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"UserList." + (i + 1) , userLists[i]);
				}
			}
		}

		public List<string> HostLists
		{
			get
			{
				return hostLists;
			}

			set
			{
				hostLists = value;
				for (int i = 0; i < hostLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"HostList." + (i + 1) , hostLists[i]);
				}
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string DefaultQueue
		{
			get
			{
				return defaultQueue;
			}
			set	
			{
				defaultQueue = value;
				DictionaryUtil.Add(QueryParameters, "DefaultQueue", value);
			}
		}

		public string DefaultUser
		{
			get
			{
				return defaultUser;
			}
			set	
			{
				defaultUser = value;
				DictionaryUtil.Add(QueryParameters, "DefaultUser", value);
			}
		}

		public List<string> QueueLists
		{
			get
			{
				return queueLists;
			}

			set
			{
				queueLists = value;
				for (int i = 0; i < queueLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"QueueList." + (i + 1) , queueLists[i]);
				}
			}
		}

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(QueryParameters, "ProjectId", value);
			}
		}

        public override CreateFlowProjectClusterSettingResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateFlowProjectClusterSettingResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
