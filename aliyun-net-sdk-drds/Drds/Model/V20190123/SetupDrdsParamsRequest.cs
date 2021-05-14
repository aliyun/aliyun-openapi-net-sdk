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
using Aliyun.Acs.Drds.Transform;
using Aliyun.Acs.Drds.Transform.V20190123;

namespace Aliyun.Acs.Drds.Model.V20190123
{
    public class SetupDrdsParamsRequest : RpcAcsRequest<SetupDrdsParamsResponse>
    {
        public SetupDrdsParamsRequest()
            : base("Drds", "2019-01-23", "SetupDrdsParams", "drds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string paramLevel;

		private List<Data> datas = new List<Data>(){ };

		private string drdsInstanceId;

		public string ParamLevel
		{
			get
			{
				return paramLevel;
			}
			set	
			{
				paramLevel = value;
				DictionaryUtil.Add(QueryParameters, "ParamLevel", value);
			}
		}

		public List<Data> Datas
		{
			get
			{
				return datas;
			}

			set
			{
				datas = value;
				for (int i = 0; i < datas.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Data." + (i + 1) + ".ParamType", datas[i].ParamType);
					DictionaryUtil.Add(QueryParameters,"Data." + (i + 1) + ".DbName", datas[i].DbName);
					DictionaryUtil.Add(QueryParameters,"Data." + (i + 1) + ".ParamRanges", datas[i].ParamRanges);
					DictionaryUtil.Add(QueryParameters,"Data." + (i + 1) + ".ParamVariableName", datas[i].ParamVariableName);
					DictionaryUtil.Add(QueryParameters,"Data." + (i + 1) + ".ParamValue", datas[i].ParamValue);
				}
			}
		}

		public string DrdsInstanceId
		{
			get
			{
				return drdsInstanceId;
			}
			set	
			{
				drdsInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DrdsInstanceId", value);
			}
		}

		public class Data
		{

			private string paramType;

			private string dbName;

			private string paramRanges;

			private string paramVariableName;

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

			public string DbName
			{
				get
				{
					return dbName;
				}
				set	
				{
					dbName = value;
				}
			}

			public string ParamRanges
			{
				get
				{
					return paramRanges;
				}
				set	
				{
					paramRanges = value;
				}
			}

			public string ParamVariableName
			{
				get
				{
					return paramVariableName;
				}
				set	
				{
					paramVariableName = value;
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SetupDrdsParamsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetupDrdsParamsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
