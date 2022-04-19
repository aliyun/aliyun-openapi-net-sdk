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
using Aliyun.Acs.Sas;
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class DescribeImageGroupedVulListRequest : RpcAcsRequest<DescribeImageGroupedVulListResponse>
    {
        public DescribeImageGroupedVulListRequest()
            : base("Sas", "2018-12-03", "DescribeImageGroupedVulList")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string type;

		private int? isLatest;

		private string imageTag;

		private string groupId;

		private string aliasName;

		private long? patchId;

		private string name;

		private string necessity;

		private string uuids;

		private string repoId;

		private string cveId;

		private string repoNamespace;

		private string imageDigest;

		private int? pageSize;

		private string lang;

		private int? currentPage;

		private string clusterId;

		private string repoName;

		private string repoInstanceId;

		private string imageLayer;

		private string repoRegionId;

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public int? IsLatest
		{
			get
			{
				return isLatest;
			}
			set	
			{
				isLatest = value;
				DictionaryUtil.Add(QueryParameters, "IsLatest", value.ToString());
			}
		}

		public string ImageTag
		{
			get
			{
				return imageTag;
			}
			set	
			{
				imageTag = value;
				DictionaryUtil.Add(QueryParameters, "ImageTag", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string AliasName
		{
			get
			{
				return aliasName;
			}
			set	
			{
				aliasName = value;
				DictionaryUtil.Add(QueryParameters, "AliasName", value);
			}
		}

		public long? PatchId
		{
			get
			{
				return patchId;
			}
			set	
			{
				patchId = value;
				DictionaryUtil.Add(QueryParameters, "PatchId", value.ToString());
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

		public string Necessity
		{
			get
			{
				return necessity;
			}
			set	
			{
				necessity = value;
				DictionaryUtil.Add(QueryParameters, "Necessity", value);
			}
		}

		public string Uuids
		{
			get
			{
				return uuids;
			}
			set	
			{
				uuids = value;
				DictionaryUtil.Add(QueryParameters, "Uuids", value);
			}
		}

		public string RepoId
		{
			get
			{
				return repoId;
			}
			set	
			{
				repoId = value;
				DictionaryUtil.Add(QueryParameters, "RepoId", value);
			}
		}

		public string CveId
		{
			get
			{
				return cveId;
			}
			set	
			{
				cveId = value;
				DictionaryUtil.Add(QueryParameters, "CveId", value);
			}
		}

		public string RepoNamespace
		{
			get
			{
				return repoNamespace;
			}
			set	
			{
				repoNamespace = value;
				DictionaryUtil.Add(QueryParameters, "RepoNamespace", value);
			}
		}

		public string ImageDigest
		{
			get
			{
				return imageDigest;
			}
			set	
			{
				imageDigest = value;
				DictionaryUtil.Add(QueryParameters, "ImageDigest", value);
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

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
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

		public string RepoName
		{
			get
			{
				return repoName;
			}
			set	
			{
				repoName = value;
				DictionaryUtil.Add(QueryParameters, "RepoName", value);
			}
		}

		public string RepoInstanceId
		{
			get
			{
				return repoInstanceId;
			}
			set	
			{
				repoInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "RepoInstanceId", value);
			}
		}

		public string ImageLayer
		{
			get
			{
				return imageLayer;
			}
			set	
			{
				imageLayer = value;
				DictionaryUtil.Add(QueryParameters, "ImageLayer", value);
			}
		}

		public string RepoRegionId
		{
			get
			{
				return repoRegionId;
			}
			set	
			{
				repoRegionId = value;
				DictionaryUtil.Add(QueryParameters, "RepoRegionId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeImageGroupedVulListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeImageGroupedVulListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
