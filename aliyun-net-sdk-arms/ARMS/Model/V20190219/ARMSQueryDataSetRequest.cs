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
using Aliyun.Acs.ARMS.Transform.V20190219;

namespace Aliyun.Acs.ARMS.Model.V20190219
{
    public class ARMSQueryDataSetRequest : RpcAcsRequest<ARMSQueryDataSetResponse>
    {
        public ARMSQueryDataSetRequest()
            : base("ARMS", "2019-02-19", "ARMSQueryDataSet")
        {
        }

		private string dateStr;

		private long? minTime;

		private bool? reduceTail;

		private long? maxTime;

		private List<OptionalDims> optionalDimss;

		private List<string> measuress;

		private int? intervalInSec;

		private bool? isDrillDown;

		private bool? hungryMode;

		private string securityToken;

		private string orderByKey;

		private int? limit;

		private List<RequiredDims> requiredDimss;

		private long? datasetId;

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

		public List<OptionalDims> OptionalDimss
		{
			get
			{
				return optionalDimss;
			}

			set
			{
				optionalDimss = value;
				for (int i = 0; i < optionalDimss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"OptionalDims." + (i + 1) + ".Type", optionalDimss[i].Type);
					DictionaryUtil.Add(QueryParameters,"OptionalDims." + (i + 1) + ".Value", optionalDimss[i].Value);
					DictionaryUtil.Add(QueryParameters,"OptionalDims." + (i + 1) + ".Key", optionalDimss[i].Key);
				}
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

		public bool? HungryMode
		{
			get
			{
				return hungryMode;
			}
			set	
			{
				hungryMode = value;
				DictionaryUtil.Add(QueryParameters, "HungryMode", value.ToString());
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

		public List<RequiredDims> RequiredDimss
		{
			get
			{
				return requiredDimss;
			}

			set
			{
				requiredDimss = value;
				for (int i = 0; i < requiredDimss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RequiredDims." + (i + 1) + ".Type", requiredDimss[i].Type);
					DictionaryUtil.Add(QueryParameters,"RequiredDims." + (i + 1) + ".Value", requiredDimss[i].Value);
					DictionaryUtil.Add(QueryParameters,"RequiredDims." + (i + 1) + ".Key", requiredDimss[i].Key);
				}
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
					DictionaryUtil.Add(QueryParameters,"Dimensions." + (i + 1) + ".Type", dimensionss[i].Type);
					DictionaryUtil.Add(QueryParameters,"Dimensions." + (i + 1) + ".Value", dimensionss[i].Value);
					DictionaryUtil.Add(QueryParameters,"Dimensions." + (i + 1) + ".Key", dimensionss[i].Key);
				}
			}
		}

		public class OptionalDims
		{

			private string type;

			private string value_;

			private string key;

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

		public class RequiredDims
		{

			private string type;

			private string value_;

			private string key;

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

		public class Dimensions
		{

			private string type;

			private string value_;

			private string key;

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

        public override ARMSQueryDataSetResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ARMSQueryDataSetResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
