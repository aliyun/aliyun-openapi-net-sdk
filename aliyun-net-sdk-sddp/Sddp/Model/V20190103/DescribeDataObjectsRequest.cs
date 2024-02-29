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
using Aliyun.Acs.Sddp.Transform;
using Aliyun.Acs.Sddp.Transform.V20190103;

namespace Aliyun.Acs.Sddp.Model.V20190103
{
    public class DescribeDataObjectsRequest : RpcAcsRequest<DescribeDataObjectsResponse>
    {
        public DescribeDataObjectsRequest()
            : base("Sddp", "2019-01-03", "DescribeDataObjects", "sddp", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sddp.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sddp.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? fileType;

		private string riskLevels;

		private string queryName;

		private long? domainId;

		private string parentCategoryIds;

		private string productIds;

		private int? pageSize;

		private string lang;

		private string serviceRegionId;

		private string modelTagIds;

		private long? fileCategoryCode;

		private int? currentPage;

		private long? templateId;

		private string instanceId;

		private string modelIds;

		public long? FileType
		{
			get
			{
				return fileType;
			}
			set	
			{
				fileType = value;
				DictionaryUtil.Add(QueryParameters, "FileType", value.ToString());
			}
		}

		public string RiskLevels
		{
			get
			{
				return riskLevels;
			}
			set	
			{
				riskLevels = value;
				DictionaryUtil.Add(QueryParameters, "RiskLevels", value);
			}
		}

		public string QueryName
		{
			get
			{
				return queryName;
			}
			set	
			{
				queryName = value;
				DictionaryUtil.Add(QueryParameters, "QueryName", value);
			}
		}

		public long? DomainId
		{
			get
			{
				return domainId;
			}
			set	
			{
				domainId = value;
				DictionaryUtil.Add(QueryParameters, "DomainId", value.ToString());
			}
		}

		public string ParentCategoryIds
		{
			get
			{
				return parentCategoryIds;
			}
			set	
			{
				parentCategoryIds = value;
				DictionaryUtil.Add(QueryParameters, "ParentCategoryIds", value);
			}
		}

		public string ProductIds
		{
			get
			{
				return productIds;
			}
			set	
			{
				productIds = value;
				DictionaryUtil.Add(QueryParameters, "ProductIds", value);
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

		public string ServiceRegionId
		{
			get
			{
				return serviceRegionId;
			}
			set	
			{
				serviceRegionId = value;
				DictionaryUtil.Add(QueryParameters, "ServiceRegionId", value);
			}
		}

		public string ModelTagIds
		{
			get
			{
				return modelTagIds;
			}
			set	
			{
				modelTagIds = value;
				DictionaryUtil.Add(QueryParameters, "ModelTagIds", value);
			}
		}

		public long? FileCategoryCode
		{
			get
			{
				return fileCategoryCode;
			}
			set	
			{
				fileCategoryCode = value;
				DictionaryUtil.Add(QueryParameters, "FileCategoryCode", value.ToString());
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

		public long? TemplateId
		{
			get
			{
				return templateId;
			}
			set	
			{
				templateId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateId", value.ToString());
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

		public string ModelIds
		{
			get
			{
				return modelIds;
			}
			set	
			{
				modelIds = value;
				DictionaryUtil.Add(QueryParameters, "ModelIds", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeDataObjectsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDataObjectsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
