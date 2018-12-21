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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.ARMS.Transform;
using Aliyun.Acs.ARMS.Transform.V20181219;
using System.Collections.Generic;

namespace Aliyun.Acs.ARMS.Model.V20181219
{
    public class MetricQueryRequest : RpcAcsRequest<MetricQueryResponse>
    {
        public MetricQueryRequest()
            : base("ARMS", "2018-12-19", "MetricQuery", "arms", "openAPI")
        {
        }

		private long? endTime;

		private string orderBy;

		private List<Filters> filterss;

		private long? startTime;

		private string accessKeyId;

		private int? iintervalInSec;

		private List<string> measuress;

		private string metric;

		private string securityToken;

		private int? limit;

		private List<string> dimensionss;

		private string order;

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value.ToString());
			}
		}

		public string OrderBy
		{
			get
			{
				return orderBy;
			}
			set	
			{
				orderBy = value;
				DictionaryUtil.Add(QueryParameters, "OrderBy", value);
			}
		}

		public List<Filters> Filterss
		{
			get
			{
				return filterss;
			}

			set
			{
				filterss = value;
				for (int i = 0; i < filterss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Filters." + (i + 1) + ".Value", filterss[i].Value);
					DictionaryUtil.Add(QueryParameters,"Filters." + (i + 1) + ".Key", filterss[i].Key);
				}
			}
		}

		public long? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value.ToString());
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public int? IintervalInSec
		{
			get
			{
				return iintervalInSec;
			}
			set	
			{
				iintervalInSec = value;
				DictionaryUtil.Add(QueryParameters, "IintervalInSec", value.ToString());
			}
		}

		public List<string> Measuress
		{
			get
			{
				return measuress;
			}

			set
			{
				measuress = value;
				for (int i = 0; i < measuress.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Measures." + (i + 1) , measuress[i]);
				}
			}
		}

		public string Metric
		{
			get
			{
				return metric;
			}
			set	
			{
				metric = value;
				DictionaryUtil.Add(QueryParameters, "Metric", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public int? Limit
		{
			get
			{
				return limit;
			}
			set	
			{
				limit = value;
				DictionaryUtil.Add(QueryParameters, "Limit", value.ToString());
			}
		}

		public List<string> Dimensionss
		{
			get
			{
				return dimensionss;
			}

			set
			{
				dimensionss = value;
				for (int i = 0; i < dimensionss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Dimensions." + (i + 1) , dimensionss[i]);
				}
			}
		}

		public string Order
		{
			get
			{
				return order;
			}
			set	
			{
				order = value;
				DictionaryUtil.Add(QueryParameters, "Order", value);
			}
		}

		public class Filters
		{

			private string value_;

			private string key;

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

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

        public override MetricQueryResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return MetricQueryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}