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
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class CreateDataAPIServiceRequest : RpcAcsRequest<CreateDataAPIServiceResponse>
    {
        public CreateDataAPIServiceRequest()
            : base("Iot", "2018-01-20", "CreateDataAPIService", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<RequestParam> requestParams = new List<RequestParam>(){ };

		private string iotInstanceId;

		private string apiPath;

		private string templateSql;

		private List<ResponseParam> responseParams = new List<ResponseParam>(){ };

		private string originSql;

		private string displayName;

		private string desc;

		public List<RequestParam> RequestParams
		{
			get
			{
				return requestParams;
			}

			set
			{
				requestParams = value;
				for (int i = 0; i < requestParams.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"RequestParam." + (i + 1) + ".Name", requestParams[i].Name);
					DictionaryUtil.Add(BodyParameters,"RequestParam." + (i + 1) + ".Type", requestParams[i].Type);
					DictionaryUtil.Add(BodyParameters,"RequestParam." + (i + 1) + ".Desc", requestParams[i].Desc);
					DictionaryUtil.Add(BodyParameters,"RequestParam." + (i + 1) + ".Example", requestParams[i].Example);
					DictionaryUtil.Add(BodyParameters,"RequestParam." + (i + 1) + ".Required", requestParams[i].Required);
				}
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(BodyParameters, "IotInstanceId", value);
			}
		}

		public string ApiPath
		{
			get
			{
				return apiPath;
			}
			set	
			{
				apiPath = value;
				DictionaryUtil.Add(BodyParameters, "ApiPath", value);
			}
		}

		public string TemplateSql
		{
			get
			{
				return templateSql;
			}
			set	
			{
				templateSql = value;
				DictionaryUtil.Add(BodyParameters, "TemplateSql", value);
			}
		}

		public List<ResponseParam> ResponseParams
		{
			get
			{
				return responseParams;
			}

			set
			{
				responseParams = value;
				for (int i = 0; i < responseParams.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"ResponseParam." + (i + 1) + ".Name", responseParams[i].Name);
					DictionaryUtil.Add(BodyParameters,"ResponseParam." + (i + 1) + ".Type", responseParams[i].Type);
					DictionaryUtil.Add(BodyParameters,"ResponseParam." + (i + 1) + ".Desc", responseParams[i].Desc);
					DictionaryUtil.Add(BodyParameters,"ResponseParam." + (i + 1) + ".Example", responseParams[i].Example);
					DictionaryUtil.Add(BodyParameters,"ResponseParam." + (i + 1) + ".Required", responseParams[i].Required);
				}
			}
		}

		public string OriginSql
		{
			get
			{
				return originSql;
			}
			set	
			{
				originSql = value;
				DictionaryUtil.Add(BodyParameters, "OriginSql", value);
			}
		}

		public string DisplayName
		{
			get
			{
				return displayName;
			}
			set	
			{
				displayName = value;
				DictionaryUtil.Add(BodyParameters, "DisplayName", value);
			}
		}

		public string Desc
		{
			get
			{
				return desc;
			}
			set	
			{
				desc = value;
				DictionaryUtil.Add(BodyParameters, "Desc", value);
			}
		}

		public class RequestParam
		{

			private string name;

			private string type;

			private string desc;

			private string example;

			private bool? required;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string Desc
			{
				get
				{
					return desc;
				}
				set	
				{
					desc = value;
				}
			}

			public string Example
			{
				get
				{
					return example;
				}
				set	
				{
					example = value;
				}
			}

			public bool? Required
			{
				get
				{
					return required;
				}
				set	
				{
					required = value;
				}
			}
		}

		public class ResponseParam
		{

			private string name;

			private string type;

			private string desc;

			private string example;

			private bool? required;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string Desc
			{
				get
				{
					return desc;
				}
				set	
				{
					desc = value;
				}
			}

			public string Example
			{
				get
				{
					return example;
				}
				set	
				{
					example = value;
				}
			}

			public bool? Required
			{
				get
				{
					return required;
				}
				set	
				{
					required = value;
				}
			}
		}

        public override CreateDataAPIServiceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDataAPIServiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
