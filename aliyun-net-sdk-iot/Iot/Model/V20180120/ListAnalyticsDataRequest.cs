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
    public class ListAnalyticsDataRequest : RpcAcsRequest<ListAnalyticsDataResponse>
    {
        public ListAnalyticsDataRequest()
            : base("Iot", "2018-01-20", "ListAnalyticsData", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? pageNum;

		private string iotInstanceId;

		private int? pageSize;

		private string isoId;

		private string apiPath;

		private List<Condition> conditions = new List<Condition>(){ };

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
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

		public string IsoId
		{
			get
			{
				return isoId;
			}
			set	
			{
				isoId = value;
				DictionaryUtil.Add(QueryParameters, "IsoId", value);
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
				DictionaryUtil.Add(QueryParameters, "ApiPath", value);
			}
		}

		public List<Condition> Conditions
		{
			get
			{
				return conditions;
			}

			set
			{
				conditions = value;
				for (int i = 0; i < conditions.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Condition." + (i + 1) + ".FieldName", conditions[i].FieldName);
					DictionaryUtil.Add(QueryParameters,"Condition." + (i + 1) + ".Operate", conditions[i].Operate);
					DictionaryUtil.Add(QueryParameters,"Condition." + (i + 1) + ".BetweenStart", conditions[i].BetweenStart);
					DictionaryUtil.Add(QueryParameters,"Condition." + (i + 1) + ".BetweenEnd", conditions[i].BetweenEnd);
					DictionaryUtil.Add(QueryParameters,"Condition." + (i + 1) + ".Value", conditions[i].Value);
				}
			}
		}

		public class Condition
		{

			private string fieldName;

			private string operate;

			private string betweenStart;

			private string betweenEnd;

			private string value_;

			public string FieldName
			{
				get
				{
					return fieldName;
				}
				set	
				{
					fieldName = value;
				}
			}

			public string Operate
			{
				get
				{
					return operate;
				}
				set	
				{
					operate = value;
				}
			}

			public string BetweenStart
			{
				get
				{
					return betweenStart;
				}
				set	
				{
					betweenStart = value;
				}
			}

			public string BetweenEnd
			{
				get
				{
					return betweenEnd;
				}
				set	
				{
					betweenEnd = value;
				}
			}

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListAnalyticsDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListAnalyticsDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
