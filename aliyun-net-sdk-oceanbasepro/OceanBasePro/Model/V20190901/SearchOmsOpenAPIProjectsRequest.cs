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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.OceanBasePro.Transform;
using Aliyun.Acs.OceanBasePro.Transform.V20190901;

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
    public class SearchOmsOpenAPIProjectsRequest : RpcAcsRequest<SearchOmsOpenAPIProjectsResponse>
    {
        public SearchOmsOpenAPIProjectsRequest()
            : base("OceanBasePro", "2019-09-01", "SearchOmsOpenAPIProjects", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> destDbTypes = new List<string>(){ };

		private List<string> statusList = new List<string>(){ };

		private string searchKey;

		private int? pageNumber;

		private List<string> sourceDbTypes = new List<string>(){ };

		private int? pageSize;

		private string workerGradeId;

		private List<string> labelIds = new List<string>(){ };

		[JsonProperty(PropertyName = "DestDbTypes")]
		public List<string> DestDbTypes
		{
			get
			{
				return destDbTypes;
			}

			set
			{
				destDbTypes = value;
				if(destDbTypes != null)
				{
					for (int depth1 = 0; depth1 < destDbTypes.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"DestDbTypes." + (depth1 + 1), destDbTypes[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "StatusList")]
		public List<string> StatusList
		{
			get
			{
				return statusList;
			}

			set
			{
				statusList = value;
				if(statusList != null)
				{
					for (int depth1 = 0; depth1 < statusList.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"StatusList." + (depth1 + 1), statusList[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "SearchKey")]
		public string SearchKey
		{
			get
			{
				return searchKey;
			}
			set	
			{
				searchKey = value;
				DictionaryUtil.Add(BodyParameters, "SearchKey", value);
			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "SourceDbTypes")]
		public List<string> SourceDbTypes
		{
			get
			{
				return sourceDbTypes;
			}

			set
			{
				sourceDbTypes = value;
				if(sourceDbTypes != null)
				{
					for (int depth1 = 0; depth1 < sourceDbTypes.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"SourceDbTypes." + (depth1 + 1), sourceDbTypes[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "WorkerGradeId")]
		public string WorkerGradeId
		{
			get
			{
				return workerGradeId;
			}
			set	
			{
				workerGradeId = value;
				DictionaryUtil.Add(BodyParameters, "WorkerGradeId", value);
			}
		}

		[JsonProperty(PropertyName = "LabelIds")]
		public List<string> LabelIds
		{
			get
			{
				return labelIds;
			}

			set
			{
				labelIds = value;
				if(labelIds != null)
				{
					for (int depth1 = 0; depth1 < labelIds.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"LabelIds." + (depth1 + 1), labelIds[depth1]);
					}
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SearchOmsOpenAPIProjectsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SearchOmsOpenAPIProjectsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
