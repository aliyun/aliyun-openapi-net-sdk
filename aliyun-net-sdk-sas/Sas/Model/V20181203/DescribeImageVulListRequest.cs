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
    public class DescribeImageVulListRequest : RpcAcsRequest<DescribeImageVulListResponse>
    {
        public DescribeImageVulListRequest()
            : base("Sas", "2018-12-03", "DescribeImageVulList", "sas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string type;

		private string containerFieldName;

		private string tag;

		private string aliasName;

		private string instanceId;

		private string name;

		private string necessity;

		private string uuids;

		private string repoId;

		private string statusList;

		private string targetType;

		private string repoNamespace;

		private string containerFieldValue;

		private int? pageSize;

		private string digest;

		private string lang;

		private string dealed;

		private int? currentPage;

		private string repoName;

		private string repoInstanceId;

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

		public string ContainerFieldName
		{
			get
			{
				return containerFieldName;
			}
			set	
			{
				containerFieldName = value;
				DictionaryUtil.Add(QueryParameters, "ContainerFieldName", value);
			}
		}

		public string Tag
		{
			get
			{
				return tag;
			}
			set	
			{
				tag = value;
				DictionaryUtil.Add(QueryParameters, "Tag", value);
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

		public string TargetType
		{
			get
			{
				return targetType;
			}
			set	
			{
				targetType = value;
				DictionaryUtil.Add(QueryParameters, "TargetType", value);
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

		public string ContainerFieldValue
		{
			get
			{
				return containerFieldValue;
			}
			set	
			{
				containerFieldValue = value;
				DictionaryUtil.Add(QueryParameters, "ContainerFieldValue", value);
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

		public string Digest
		{
			get
			{
				return digest;
			}
			set	
			{
				digest = value;
				DictionaryUtil.Add(QueryParameters, "Digest", value);
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

        public override DescribeImageVulListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeImageVulListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
