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
    public class ListProjectsRequest : RpcAcsRequest<ListProjectsResponse>
    {
        public ListProjectsRequest()
            : base("OceanBasePro", "2019-09-01", "ListProjects", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string searchKey;

		private string type;

		private bool? visibleSubProject;

		private int? pageNumber;

		private List<string> sinkEndpointTypes = new List<string>(){ };

		private int? pageSize;

		private string order;

		private List<string> sourceEndpointTypes = new List<string>(){ };

		private string sortField;

		private List<string> labelIds = new List<string>(){ };

		private List<string> status = new List<string>(){ };

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

		[JsonProperty(PropertyName = "Type")]
		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(BodyParameters, "Type", value);
			}
		}

		[JsonProperty(PropertyName = "VisibleSubProject")]
		public bool? VisibleSubProject
		{
			get
			{
				return visibleSubProject;
			}
			set	
			{
				visibleSubProject = value;
				DictionaryUtil.Add(BodyParameters, "VisibleSubProject", value.ToString());
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

		[JsonProperty(PropertyName = "SinkEndpointTypes")]
		public List<string> SinkEndpointTypes
		{
			get
			{
				return sinkEndpointTypes;
			}

			set
			{
				sinkEndpointTypes = value;
				if(sinkEndpointTypes != null)
				{
					for (int depth1 = 0; depth1 < sinkEndpointTypes.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"SinkEndpointTypes." + (depth1 + 1), sinkEndpointTypes[depth1]);
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

		[JsonProperty(PropertyName = "Order")]
		public string Order
		{
			get
			{
				return order;
			}
			set	
			{
				order = value;
				DictionaryUtil.Add(BodyParameters, "Order", value);
			}
		}

		[JsonProperty(PropertyName = "SourceEndpointTypes")]
		public List<string> SourceEndpointTypes
		{
			get
			{
				return sourceEndpointTypes;
			}

			set
			{
				sourceEndpointTypes = value;
				if(sourceEndpointTypes != null)
				{
					for (int depth1 = 0; depth1 < sourceEndpointTypes.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"SourceEndpointTypes." + (depth1 + 1), sourceEndpointTypes[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "SortField")]
		public string SortField
		{
			get
			{
				return sortField;
			}
			set	
			{
				sortField = value;
				DictionaryUtil.Add(BodyParameters, "SortField", value);
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

		[JsonProperty(PropertyName = "Status")]
		public List<string> Status
		{
			get
			{
				return status;
			}

			set
			{
				status = value;
				if(status != null)
				{
					for (int depth1 = 0; depth1 < status.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"Status." + (depth1 + 1), status[depth1]);
					}
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListProjectsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListProjectsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
