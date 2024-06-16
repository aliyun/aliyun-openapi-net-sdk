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
    public class ListProjectFullVerifyResultRequest : RpcAcsRequest<ListProjectFullVerifyResultResponse>
    {
        public ListProjectFullVerifyResultRequest()
            : base("OceanBasePro", "2019-09-01", "ListProjectFullVerifyResult", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> destSchemas = new List<string>(){ };

		private int? pageNumber;

		private int? pageSize;

		private List<string> sourceSchemas = new List<string>(){ };

		private string projectId;

		private string status;

		[JsonProperty(PropertyName = "DestSchemas")]
		public List<string> DestSchemas
		{
			get
			{
				return destSchemas;
			}

			set
			{
				destSchemas = value;
				if(destSchemas != null)
				{
					for (int depth1 = 0; depth1 < destSchemas.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"DestSchemas." + (depth1 + 1), destSchemas[depth1]);
					}
				}
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

		[JsonProperty(PropertyName = "SourceSchemas")]
		public List<string> SourceSchemas
		{
			get
			{
				return sourceSchemas;
			}

			set
			{
				sourceSchemas = value;
				if(sourceSchemas != null)
				{
					for (int depth1 = 0; depth1 < sourceSchemas.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"SourceSchemas." + (depth1 + 1), sourceSchemas[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "ProjectId")]
		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(BodyParameters, "ProjectId", value);
			}
		}

		[JsonProperty(PropertyName = "Status")]
		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(BodyParameters, "Status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListProjectFullVerifyResultResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListProjectFullVerifyResultResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
