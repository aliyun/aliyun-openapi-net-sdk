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
    public class DescribeImageListWithBaselineNameRequest : RpcAcsRequest<DescribeImageListWithBaselineNameResponse>
    {
        public DescribeImageListWithBaselineNameRequest()
            : base("Sas", "2018-12-03", "DescribeImageListWithBaselineName")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string criteria;

		private string repoNamespace;

		private string imageDigest;

		private int? pageSize;

		private string criteriaType;

		private string lang;

		private int? currentPage;

		private string clusterId;

		private string repoName;

		private string baselineNameKey;

		private string repoInstanceId;

		public string Criteria
		{
			get
			{
				return criteria;
			}
			set	
			{
				criteria = value;
				DictionaryUtil.Add(QueryParameters, "Criteria", value);
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

		public string CriteriaType
		{
			get
			{
				return criteriaType;
			}
			set	
			{
				criteriaType = value;
				DictionaryUtil.Add(QueryParameters, "CriteriaType", value);
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

		public string BaselineNameKey
		{
			get
			{
				return baselineNameKey;
			}
			set	
			{
				baselineNameKey = value;
				DictionaryUtil.Add(QueryParameters, "BaselineNameKey", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeImageListWithBaselineNameResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeImageListWithBaselineNameResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
