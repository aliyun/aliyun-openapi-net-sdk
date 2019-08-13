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
using Aliyun.Acs.ARMS.Transform;
using Aliyun.Acs.ARMS.Transform.V20190808;

namespace Aliyun.Acs.ARMS.Model.V20190808
{
    public class QueryMetricRequest : RpcAcsRequest<QueryMetricResponse>
    {
        public QueryMetricRequest()
            : base("ARMS", "2019-08-08", "QueryMetric", "arms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private List<string> measuress;

		private int? intervalInSec;

		private string metric;

		private int? limit;

		private long? endTime;

		private string orderBy;

		private long? startTime;

		private List<Filters> filterss;

		private List<string> dimensionss;

		private string order;

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

		public int? IntervalInSec
		{
			get
			{
				return intervalInSec;
			}
			set	
			{
				intervalInSec = value;
				DictionaryUtil.Add(QueryParameters, "IntervalInSec", value.ToString());
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

        public override QueryMetricResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryMetricResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
