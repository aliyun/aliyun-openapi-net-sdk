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
    public class InvokeDataAPIServiceRequest : RpcAcsRequest<InvokeDataAPIServiceResponse>
    {
        public InvokeDataAPIServiceRequest()
            : base("Iot", "2018-01-20", "InvokeDataAPIService", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<Param> params_ = new List<Param>(){ };

		private string iotInstanceId;

		private string apiSrn;

		public List<Param> Params
		{
			get
			{
				return params_;
			}

			set
			{
				params_ = value;
				for (int i = 0; i < params_.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Param." + (i + 1) + ".ParamType", params_[i].ParamType);
					for (int j = 0; j < params_[i].ListParamValues.Count; j++)
					{
						DictionaryUtil.Add(BodyParameters,"Param." + (i + 1) + ".ListParamValue." +(j + 1), params_[i].ListParamValues[j]);
					}
					DictionaryUtil.Add(BodyParameters,"Param." + (i + 1) + ".ListParamType", params_[i].ListParamType);
					DictionaryUtil.Add(BodyParameters,"Param." + (i + 1) + ".ParamName", params_[i].ParamName);
					DictionaryUtil.Add(BodyParameters,"Param." + (i + 1) + ".ParamValue", params_[i].ParamValue);
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

		public string ApiSrn
		{
			get
			{
				return apiSrn;
			}
			set	
			{
				apiSrn = value;
				DictionaryUtil.Add(BodyParameters, "ApiSrn", value);
			}
		}

		public class Param
		{

			private string paramType;

			private List<string> listParamValues = new List<string>(){ };

			private string listParamType;

			private string paramName;

			private string paramValue;

			public string ParamType
			{
				get
				{
					return paramType;
				}
				set	
				{
					paramType = value;
				}
			}

			public List<string> ListParamValues
			{
				get
				{
					return listParamValues;
				}
				set	
				{
					listParamValues = value;
				}
			}

			public string ListParamType
			{
				get
				{
					return listParamType;
				}
				set	
				{
					listParamType = value;
				}
			}

			public string ParamName
			{
				get
				{
					return paramName;
				}
				set	
				{
					paramName = value;
				}
			}

			public string ParamValue
			{
				get
				{
					return paramValue;
				}
				set	
				{
					paramValue = value;
				}
			}
		}

        public override InvokeDataAPIServiceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InvokeDataAPIServiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
