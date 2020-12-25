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
    public class ListClustersRequest : RpcAcsRequest<ListClustersResponse>
    {
        public ListClustersRequest()
            : base("Emr", "2016-04-08", "ListClusters", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private List<string> statusLists = new List<string>(){ };

		private bool? isDesc;

		private string depositType;

		private int? pageNumber;

		private string machineType;

		private string resourceGroupId;

		private int? pageSize;

		private List<Tag> tags = new List<Tag>(){ };

		private string createType;

		private List<string> expiredTagLists = new List<string>(){ };

		private bool? defaultStatus;

		private string name;

		private List<string> clusterTypeLists = new List<string>(){ };

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

		public List<string> StatusLists
		{
			get
			{
				return statusLists;
			}

			set
			{
				statusLists = value;
				for (int i = 0; i < statusLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"StatusList." + (i + 1) , statusLists[i]);
				}
			}
		}

		public bool? IsDesc
		{
			get
			{
				return isDesc;
			}
			set	
			{
				isDesc = value;
				DictionaryUtil.Add(QueryParameters, "IsDesc", value.ToString());
			}
		}

		public string DepositType
		{
			get
			{
				return depositType;
			}
			set	
			{
				depositType = value;
				DictionaryUtil.Add(QueryParameters, "DepositType", value);
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

		public string MachineType
		{
			get
			{
				return machineType;
			}
			set	
			{
				machineType = value;
				DictionaryUtil.Add(QueryParameters, "MachineType", value);
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
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

		public List<Tag> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				for (int i = 0; i < tags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Value", tags[i].Value);
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Key", tags[i].Key);
				}
			}
		}

		public string CreateType
		{
			get
			{
				return createType;
			}
			set	
			{
				createType = value;
				DictionaryUtil.Add(QueryParameters, "CreateType", value);
			}
		}

		public List<string> ExpiredTagLists
		{
			get
			{
				return expiredTagLists;
			}

			set
			{
				expiredTagLists = value;
				for (int i = 0; i < expiredTagLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ExpiredTagList." + (i + 1) , expiredTagLists[i]);
				}
			}
		}

		public bool? DefaultStatus
		{
			get
			{
				return defaultStatus;
			}
			set	
			{
				defaultStatus = value;
				DictionaryUtil.Add(QueryParameters, "DefaultStatus", value.ToString());
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public List<string> ClusterTypeLists
		{
			get
			{
				return clusterTypeLists;
			}

			set
			{
				clusterTypeLists = value;
				for (int i = 0; i < clusterTypeLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ClusterTypeList." + (i + 1) , clusterTypeLists[i]);
				}
			}
		}

		public class Tag
		{

			private string value_;

			private string key;

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

        public override ListClustersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListClustersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
