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
    public class DescribeGroupedMaliciousFilesRequest : RpcAcsRequest<DescribeGroupedMaliciousFilesResponse>
    {
        public DescribeGroupedMaliciousFilesRequest()
            : base("Sas", "2018-12-03", "DescribeGroupedMaliciousFiles", "sas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string repoId;

		private string fuzzyMaliciousName;

		private string repoNamespace;

		private string imageDigest;

		private string pageSize;

		private string lang;

		private string imageTag;

		private int? currentPage;

		private string repoName;

		private string repoInstanceId;

		private string imageLayer;

		private string levels;

		private string repoRegionId;

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

		public string FuzzyMaliciousName
		{
			get
			{
				return fuzzyMaliciousName;
			}
			set	
			{
				fuzzyMaliciousName = value;
				DictionaryUtil.Add(QueryParameters, "FuzzyMaliciousName", value);
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

		public string PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value);
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

		public string Levels
		{
			get
			{
				return levels;
			}
			set	
			{
				levels = value;
				DictionaryUtil.Add(QueryParameters, "Levels", value);
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

        public override DescribeGroupedMaliciousFilesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeGroupedMaliciousFilesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
