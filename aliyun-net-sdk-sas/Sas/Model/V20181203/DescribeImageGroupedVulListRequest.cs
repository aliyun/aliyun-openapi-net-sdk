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
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class DescribeImageGroupedVulListRequest : RpcAcsRequest<DescribeImageGroupedVulListResponse>
    {
        public DescribeImageGroupedVulListRequest()
            : base("Sas", "2018-12-03", "DescribeImageGroupedVulList", "sas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string type;

		private long? lastTsEnd;

		private long? createTsStart;

		private string imageTag;

		private string level;

		private string groupId;

		private string orderBy;

		private string aliasName;

		private long? patchId;

		private string name;

		private long? createTsEnd;

		private string necessity;

		private string uuids;

		private string repoId;

		private string statusList;

		private string cveId;

		private string remark;

		private string repoNamespace;

		private string imageDigest;

		private int? pageSize;

		private string lang;

		private long? lastTsStart;

		private string direction;

		private string dealed;

		private int? currentPage;

		private string searchTags;

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

		public long? LastTsEnd
		{
			get
			{
				return lastTsEnd;
			}
			set	
			{
				lastTsEnd = value;
				DictionaryUtil.Add(QueryParameters, "LastTsEnd", value.ToString());
			}
		}

		public long? CreateTsStart
		{
			get
			{
				return createTsStart;
			}
			set	
			{
				createTsStart = value;
				DictionaryUtil.Add(QueryParameters, "CreateTsStart", value.ToString());
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

		public string Level
		{
			get
			{
				return level;
			}
			set	
			{
				level = value;
				DictionaryUtil.Add(QueryParameters, "Level", value);
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

		public string OrderBy
		{
			get
			{
				return orderBy;
			}
			set	
			{
				orderBy = value;
				DictionaryUtil.Add(QueryParameters, "OrderBy", value);
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

		public long? CreateTsEnd
		{
			get
			{
				return createTsEnd;
			}
			set	
			{
				createTsEnd = value;
				DictionaryUtil.Add(QueryParameters, "CreateTsEnd", value.ToString());
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

		public string StatusList
		{
			get
			{
				return statusList;
			}
			set	
			{
				statusList = value;
				DictionaryUtil.Add(QueryParameters, "StatusList", value);
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

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
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

		public long? LastTsStart
		{
			get
			{
				return lastTsStart;
			}
			set	
			{
				lastTsStart = value;
				DictionaryUtil.Add(QueryParameters, "LastTsStart", value.ToString());
			}
		}

		public string Direction
		{
			get
			{
				return direction;
			}
			set	
			{
				direction = value;
				DictionaryUtil.Add(QueryParameters, "Direction", value);
			}
		}

		public string Dealed
		{
			get
			{
				return dealed;
			}
			set	
			{
				dealed = value;
				DictionaryUtil.Add(QueryParameters, "Dealed", value);
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

		public string SearchTags
		{
			get
			{
				return searchTags;
			}
			set	
			{
				searchTags = value;
				DictionaryUtil.Add(QueryParameters, "SearchTags", value);
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
