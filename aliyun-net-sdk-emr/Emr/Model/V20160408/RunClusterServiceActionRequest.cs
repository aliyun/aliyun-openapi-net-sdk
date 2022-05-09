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
    public class RunClusterServiceActionRequest : RpcAcsRequest<RunClusterServiceActionResponse>
    {
        public RunClusterServiceActionRequest()
            : base("Emr", "2016-04-08", "RunClusterServiceAction", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> hostGroupIdLists = new List<string>(){ };

		private long? resourceOwnerId;

		private string serviceActionName;

		private bool? isRolling;

		private int? totlerateFailCount;

		private string serviceName;

		private string executeStrategy;

		private bool? onlyRestartStaleConfigNodes;

		private int? nodeCountPerBatch;

		private string clusterId;

		private string customCommand;

		private string componentNameList;

		private string comment;

		private string customParams;

		private long? interval;

		private string hostIdList;

		private bool? turnOnMaintenanceMode;

		public List<string> HostGroupIdLists
		{
			get
			{
				return hostGroupIdLists;
			}

			set
			{
				hostGroupIdLists = value;
				for (int i = 0; i < hostGroupIdLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"HostGroupIdList." + (i + 1) , hostGroupIdLists[i]);
				}
			}
		}

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

		public string ServiceActionName
		{
			get
			{
				return serviceActionName;
			}
			set	
			{
				serviceActionName = value;
				DictionaryUtil.Add(QueryParameters, "ServiceActionName", value);
			}
		}

		public bool? IsRolling
		{
			get
			{
				return isRolling;
			}
			set	
			{
				isRolling = value;
				DictionaryUtil.Add(QueryParameters, "IsRolling", value.ToString());
			}
		}

		public int? TotlerateFailCount
		{
			get
			{
				return totlerateFailCount;
			}
			set	
			{
				totlerateFailCount = value;
				DictionaryUtil.Add(QueryParameters, "TotlerateFailCount", value.ToString());
			}
		}

		public string ServiceName
		{
			get
			{
				return serviceName;
			}
			set	
			{
				serviceName = value;
				DictionaryUtil.Add(QueryParameters, "ServiceName", value);
			}
		}

		public string ExecuteStrategy
		{
			get
			{
				return executeStrategy;
			}
			set	
			{
				executeStrategy = value;
				DictionaryUtil.Add(QueryParameters, "ExecuteStrategy", value);
			}
		}

		public bool? OnlyRestartStaleConfigNodes
		{
			get
			{
				return onlyRestartStaleConfigNodes;
			}
			set	
			{
				onlyRestartStaleConfigNodes = value;
				DictionaryUtil.Add(QueryParameters, "OnlyRestartStaleConfigNodes", value.ToString());
			}
		}

		public int? NodeCountPerBatch
		{
			get
			{
				return nodeCountPerBatch;
			}
			set	
			{
				nodeCountPerBatch = value;
				DictionaryUtil.Add(QueryParameters, "NodeCountPerBatch", value.ToString());
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

		public string CustomCommand
		{
			get
			{
				return customCommand;
			}
			set	
			{
				customCommand = value;
				DictionaryUtil.Add(QueryParameters, "CustomCommand", value);
			}
		}

		public string ComponentNameList
		{
			get
			{
				return componentNameList;
			}
			set	
			{
				componentNameList = value;
				DictionaryUtil.Add(QueryParameters, "ComponentNameList", value);
			}
		}

		public string Comment
		{
			get
			{
				return comment;
			}
			set	
			{
				comment = value;
				DictionaryUtil.Add(QueryParameters, "Comment", value);
			}
		}

		public string CustomParams
		{
			get
			{
				return customParams;
			}
			set	
			{
				customParams = value;
				DictionaryUtil.Add(QueryParameters, "CustomParams", value);
			}
		}

		public long? Interval
		{
			get
			{
				return interval;
			}
			set	
			{
				interval = value;
				DictionaryUtil.Add(QueryParameters, "Interval", value.ToString());
			}
		}

		public string HostIdList
		{
			get
			{
				return hostIdList;
			}
			set	
			{
				hostIdList = value;
				DictionaryUtil.Add(QueryParameters, "HostIdList", value);
			}
		}

		public bool? TurnOnMaintenanceMode
		{
			get
			{
				return turnOnMaintenanceMode;
			}
			set	
			{
				turnOnMaintenanceMode = value;
				DictionaryUtil.Add(QueryParameters, "TurnOnMaintenanceMode", value.ToString());
			}
		}

        public override RunClusterServiceActionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RunClusterServiceActionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
