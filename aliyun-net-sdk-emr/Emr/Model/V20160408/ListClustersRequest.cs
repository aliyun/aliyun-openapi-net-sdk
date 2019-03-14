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
        }

		private long? resourceOwnerId;

		private List<string> statusLists;

		private string regionId;

		private int? pageSize;

		private List<string> clusterTypeLists;

		private bool? isDesc;

		private string createType;

		private string depositType;

		private bool? defaultStatus;

		private int? pageNumber;

		private string accessKeyId;

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

        public override ListClustersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListClustersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
