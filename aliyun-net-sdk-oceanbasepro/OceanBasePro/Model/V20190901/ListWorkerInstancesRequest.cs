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
    public class ListWorkerInstancesRequest : RpcAcsRequest<ListWorkerInstancesResponse>
    {
        public ListWorkerInstancesRequest()
            : base("OceanBasePro", "2019-09-01", "ListWorkerInstances", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? onlyBindable;

		private int? pageNumber;

		private List<string> specs = new List<string>(){ };

		private string instanceName;

		private int? pageSize;

		private string sourceType;

		private string destType;

		[JsonProperty(PropertyName = "OnlyBindable")]
		public bool? OnlyBindable
		{
			get
			{
				return onlyBindable;
			}
			set	
			{
				onlyBindable = value;
				DictionaryUtil.Add(BodyParameters, "OnlyBindable", value.ToString());
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

		[JsonProperty(PropertyName = "Specs")]
		public List<string> Specs
		{
			get
			{
				return specs;
			}

			set
			{
				specs = value;
				if(specs != null)
				{
					for (int depth1 = 0; depth1 < specs.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"Specs." + (depth1 + 1), specs[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "InstanceName")]
		public string InstanceName
		{
			get
			{
				return instanceName;
			}
			set	
			{
				instanceName = value;
				DictionaryUtil.Add(BodyParameters, "InstanceName", value);
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

		[JsonProperty(PropertyName = "SourceType")]
		public string SourceType
		{
			get
			{
				return sourceType;
			}
			set	
			{
				sourceType = value;
				DictionaryUtil.Add(BodyParameters, "SourceType", value);
			}
		}

		[JsonProperty(PropertyName = "DestType")]
		public string DestType
		{
			get
			{
				return destType;
			}
			set	
			{
				destType = value;
				DictionaryUtil.Add(BodyParameters, "DestType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListWorkerInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListWorkerInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
