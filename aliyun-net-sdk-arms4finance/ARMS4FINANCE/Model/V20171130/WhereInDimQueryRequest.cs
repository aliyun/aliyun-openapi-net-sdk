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
using Aliyun.Acs.ARMS4FINANCE.Transform;
using Aliyun.Acs.ARMS4FINANCE.Transform.V20171130;

namespace Aliyun.Acs.ARMS4FINANCE.Model.V20171130
{
    public class WhereInDimQueryRequest : RpcAcsRequest<WhereInDimQueryResponse>
    {
        public WhereInDimQueryRequest()
            : base("ARMS4FINANCE", "2017-11-30", "WhereInDimQuery", "arms4finance", "openAPI")
        {
        }

		private string whereInKey;

		private List<string> measuress;

		private int? intervalInSec;

		private string dateStr;

		private bool? isDrillDown;

		private long? minTime;

		private long? datasetId;

		private List<string> whereInValuess;

		private long? maxTime;

		private List<Dimensions> dimensionss;

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
					DictionaryUtil.Add(QueryParameters,"Dimensions." + (i + 1) + ".Value", dimensionss[i].Value);
					DictionaryUtil.Add(QueryParameters,"Dimensions." + (i + 1) + ".Key", dimensionss[i].Key);
				}
			}
		}

		public class Dimensions
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

        public override WhereInDimQueryResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return WhereInDimQueryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
