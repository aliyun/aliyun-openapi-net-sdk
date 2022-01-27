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
using Aliyun.Acs.EHPC;
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class DescribePriceRequest : RpcAcsRequest<DescribePriceResponse>
    {
        public DescribePriceRequest()
            : base("EHPC", "2018-04-12", "DescribePrice")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointRegionalType, null);
            }
        }

		private List<Commodities> commoditiess = new List<Commodities>(){ };

		private string priceUnit;

		private string chargeType;

		private string orderType;

		public List<Commodities> Commoditiess
		{
			get
			{
				return commoditiess;
			}

			set
			{
				commoditiess = value;
				for (int i = 0; i < commoditiess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Commodities." + (i + 1) + ".Amount", commoditiess[i].Amount);
					DictionaryUtil.Add(QueryParameters,"Commodities." + (i + 1) + ".Period", commoditiess[i].Period);
					DictionaryUtil.Add(QueryParameters,"Commodities." + (i + 1) + ".NodeType", commoditiess[i].NodeType);
					DictionaryUtil.Add(QueryParameters,"Commodities." + (i + 1) + ".SystemDiskCategory", commoditiess[i].SystemDiskCategory);
					DictionaryUtil.Add(QueryParameters,"Commodities." + (i + 1) + ".InternetChargeType", commoditiess[i].InternetChargeType);
					DictionaryUtil.Add(QueryParameters,"Commodities." + (i + 1) + ".SystemDiskPerformanceLevel", commoditiess[i].SystemDiskPerformanceLevel);
					DictionaryUtil.Add(QueryParameters,"Commodities." + (i + 1) + ".SystemDiskSize", commoditiess[i].SystemDiskSize);
					DictionaryUtil.Add(QueryParameters,"Commodities." + (i + 1) + ".InternetMaxBandWidthOut", commoditiess[i].InternetMaxBandWidthOut);
					DictionaryUtil.Add(QueryParameters,"Commodities." + (i + 1) + ".InstanceType", commoditiess[i].InstanceType);
					DictionaryUtil.Add(QueryParameters,"Commodities." + (i + 1) + ".NetworkType", commoditiess[i].NetworkType);
				}
			}
		}

		public string PriceUnit
		{
			get
			{
				return priceUnit;
			}
			set	
			{
				priceUnit = value;
				DictionaryUtil.Add(QueryParameters, "PriceUnit", value);
			}
		}

		public string ChargeType
		{
			get
			{
				return chargeType;
			}
			set	
			{
				chargeType = value;
				DictionaryUtil.Add(QueryParameters, "ChargeType", value);
			}
		}

		public string OrderType
		{
			get
			{
				return orderType;
			}
			set	
			{
				orderType = value;
				DictionaryUtil.Add(QueryParameters, "OrderType", value);
			}
		}

		public class Commodities
		{

			private int? amount;

			private int? period;

			private string nodeType;

			private string systemDiskCategory;

			private string internetChargeType;

			private string systemDiskPerformanceLevel;

			private int? systemDiskSize;

			private int? internetMaxBandWidthOut;

			private string instanceType;

			private string networkType;

			public int? Amount
			{
				get
				{
					return amount;
				}
				set	
				{
					amount = value;
				}
			}

			public int? Period
			{
				get
				{
					return period;
				}
				set	
				{
					period = value;
				}
			}

			public string NodeType
			{
				get
				{
					return nodeType;
				}
				set	
				{
					nodeType = value;
				}
			}

			public string SystemDiskCategory
			{
				get
				{
					return systemDiskCategory;
				}
				set	
				{
					systemDiskCategory = value;
				}
			}

			public string InternetChargeType
			{
				get
				{
					return internetChargeType;
				}
				set	
				{
					internetChargeType = value;
				}
			}

			public string SystemDiskPerformanceLevel
			{
				get
				{
					return systemDiskPerformanceLevel;
				}
				set	
				{
					systemDiskPerformanceLevel = value;
				}
			}

			public int? SystemDiskSize
			{
				get
				{
					return systemDiskSize;
				}
				set	
				{
					systemDiskSize = value;
				}
			}

			public int? InternetMaxBandWidthOut
			{
				get
				{
					return internetMaxBandWidthOut;
				}
				set	
				{
					internetMaxBandWidthOut = value;
				}
			}

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
				}
			}
		}

        public override DescribePriceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribePriceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
