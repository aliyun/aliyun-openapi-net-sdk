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
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaMaxCompute.Model.V20180104
{
	public class QueryCustomerSaleInfoResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private QueryCustomerSaleInfo_Data data;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public QueryCustomerSaleInfo_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QueryCustomerSaleInfo_Data
		{

			private string lastUpdate;

			private List<QueryCustomerSaleInfo_Cluster> clusters;

			public string LastUpdate
			{
				get
				{
					return lastUpdate;
				}
				set	
				{
					lastUpdate = value;
				}
			}

			public List<QueryCustomerSaleInfo_Cluster> Clusters
			{
				get
				{
					return clusters;
				}
				set	
				{
					clusters = value;
				}
			}

			public class QueryCustomerSaleInfo_Cluster
			{

				private string cluster;

				private string region;

				private string machineRoom;

				private List<QueryCustomerSaleInfo_SaleInfo> saleInfos;

				public string Cluster
				{
					get
					{
						return cluster;
					}
					set	
					{
						cluster = value;
					}
				}

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public string MachineRoom
				{
					get
					{
						return machineRoom;
					}
					set	
					{
						machineRoom = value;
					}
				}

				public List<QueryCustomerSaleInfo_SaleInfo> SaleInfos
				{
					get
					{
						return saleInfos;
					}
					set	
					{
						saleInfos = value;
					}
				}

				public class QueryCustomerSaleInfo_SaleInfo
				{

					private string saleMode;

					private string uid;

					private long? mem;

					private long? cpu;

					private string bizCategory;

					private string owner;

					private string queryDate;

					public string SaleMode
					{
						get
						{
							return saleMode;
						}
						set	
						{
							saleMode = value;
						}
					}

					public string Uid
					{
						get
						{
							return uid;
						}
						set	
						{
							uid = value;
						}
					}

					public long? Mem
					{
						get
						{
							return mem;
						}
						set	
						{
							mem = value;
						}
					}

					public long? Cpu
					{
						get
						{
							return cpu;
						}
						set	
						{
							cpu = value;
						}
					}

					public string BizCategory
					{
						get
						{
							return bizCategory;
						}
						set	
						{
							bizCategory = value;
						}
					}

					public string Owner
					{
						get
						{
							return owner;
						}
						set	
						{
							owner = value;
						}
					}

					public string QueryDate
					{
						get
						{
							return queryDate;
						}
						set	
						{
							queryDate = value;
						}
					}
				}
			}
		}
	}
}