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
using Aliyun.Acs.ARMS.Transform.V20161125;
using System.Collections.Generic;

namespace Aliyun.Acs.ARMS.Model.V20161125
{
    public class WhereInDimQueryRequest : RpcAcsRequest<WhereInDimQueryResponse>
    {
        public WhereInDimQueryRequest()
            : base("ARMS", "2016-11-25", "WhereInDimQuery")
        {
        }

		private string dateStr;

		private long? minTime;

		private bool? reduceTail;

		private long? maxTime;

		private string whereInKey;

		private List<string> measuress;

		private int? intervalInSec;

		private bool? isDrillDown;

		private string orderByKey;

		private int? limit;

		private long? datasetId;

		private List<string> whereInValuess;

		private List<Dimensions> dimensionss;

		public string DateStr
		{
			get
			{
				return dateStr;
			}
			set	
			{
				dateStr = value;
				DictionaryUtil.Add(QueryParameters, "DateStr", value);
			}
		}

		public long? MinTime
		{
			get
			{
				return minTime;
			}
			set	
			{
				minTime = value;
				DictionaryUtil.Add(QueryParameters, "MinTime", value.ToString());
			}
		}

		public bool? ReduceTail
		{
			get
			{
				return reduceTail;
			}
			set	
			{
				reduceTail = value;
				DictionaryUtil.Add(QueryParameters, "ReduceTail", value.ToString());
			}
		}

		public long? MaxTime
		{
			get
			{
				return maxTime;
			}
			set	
			{
				maxTime = value;
				DictionaryUtil.Add(QueryParameters, "MaxTime", value.ToString());
			}
		}

		public string WhereInKey
		{
			get
			{
				return whereInKey;
			}
			set	
			{
				whereInKey = value;
				DictionaryUtil.Add(QueryParameters, "WhereInKey", value);
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

		public bool? IsDrillDown
		{
			get
			{
				return isDrillDown;
			}
			set	
			{
				isDrillDown = value;
				DictionaryUtil.Add(QueryParameters, "IsDrillDown", value.ToString());
			}
		}

		public string OrderByKey
		{
			get
			{
				return orderByKey;
			}
			set	
			{
				orderByKey = value;
				DictionaryUtil.Add(QueryParameters, "OrderByKey", value);
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

		public long? DatasetId
		{
			get
			{
				return datasetId;
			}
			set	
			{
				datasetId = value;
				DictionaryUtil.Add(QueryParameters, "DatasetId", value.ToString());
			}
		}

		public List<string> WhereInValuess
		{
			get
			{
				return whereInValuess;
			}

			set
			{
				whereInValuess = value;
				for (int i = 0; i < whereInValuess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"WhereInValues." + (i + 1) , whereInValuess[i]);
				}
			}
		}

		public List<Dimensions> Dimensionss
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
					DictionaryUtil.Add(QueryParameters,"Dimensions." + (i + 1) + ".Key", dimensionss[i].Key);
					DictionaryUtil.Add(QueryParameters,"Dimensions." + (i + 1) + ".Value", dimensionss[i].Value);
					DictionaryUtil.Add(QueryParameters,"Dimensions." + (i + 1) + ".Type", dimensionss[i].Type);
				}
			}
		}

		public class Dimensions
		{

			private string key;

			private string value_;

			private string type;

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
		}

        public override WhereInDimQueryResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return WhereInDimQueryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}