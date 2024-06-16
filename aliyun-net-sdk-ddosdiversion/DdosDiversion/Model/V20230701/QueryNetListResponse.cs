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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.DdosDiversion.Model.V20230701
{
	public class QueryNetListResponse : AcsResponse
	{

		private long? code;

		private string requestId;

		private string message;

		private List<QueryNetList_DataItem> data;

		public long? Code
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

		public List<QueryNetList_DataItem> Data
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

		public class QueryNetList_DataItem
		{

			private long? total;

			private long? page;

			private long? num;

			private List<QueryNetList_Data> nets;

			public long? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public long? Page
			{
				get
				{
					return page;
				}
				set	
				{
					page = value;
				}
			}

			public long? Num
			{
				get
				{
					return num;
				}
				set	
				{
					num = value;
				}
			}

			public List<QueryNetList_Data> Nets
			{
				get
				{
					return nets;
				}
				set	
				{
					nets = value;
				}
			}

			public class QueryNetList_Data
			{

				private string userId;

				private string saleId;

				private string upstreamType;

				private string net;

				private string netType;

				private string mode;

				private int? declaredState;

				private string gmtCreate;

				private string gmtModify;

				private long? netExtend;

				private long? fwdEffect;

				private string netMain;

				private List<QueryNetList_DeclaredItem> declared;

				private QueryNetList_DDoSDefense dDoSDefense;

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public string SaleId
				{
					get
					{
						return saleId;
					}
					set	
					{
						saleId = value;
					}
				}

				public string UpstreamType
				{
					get
					{
						return upstreamType;
					}
					set	
					{
						upstreamType = value;
					}
				}

				public string Net
				{
					get
					{
						return net;
					}
					set	
					{
						net = value;
					}
				}

				public string NetType
				{
					get
					{
						return netType;
					}
					set	
					{
						netType = value;
					}
				}

				public string Mode
				{
					get
					{
						return mode;
					}
					set	
					{
						mode = value;
					}
				}

				public int? DeclaredState
				{
					get
					{
						return declaredState;
					}
					set	
					{
						declaredState = value;
					}
				}

				public string GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public string GmtModify
				{
					get
					{
						return gmtModify;
					}
					set	
					{
						gmtModify = value;
					}
				}

				public long? NetExtend
				{
					get
					{
						return netExtend;
					}
					set	
					{
						netExtend = value;
					}
				}

				public long? FwdEffect
				{
					get
					{
						return fwdEffect;
					}
					set	
					{
						fwdEffect = value;
					}
				}

				public string NetMain
				{
					get
					{
						return netMain;
					}
					set	
					{
						netMain = value;
					}
				}

				public List<QueryNetList_DeclaredItem> Declared
				{
					get
					{
						return declared;
					}
					set	
					{
						declared = value;
					}
				}

				public QueryNetList_DDoSDefense DDoSDefense
				{
					get
					{
						return dDoSDefense;
					}
					set	
					{
						dDoSDefense = value;
					}
				}

				public class QueryNetList_DeclaredItem
				{

					private string region;

					private string declared;

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

					public string Declared
					{
						get
						{
							return declared;
						}
						set	
						{
							declared = value;
						}
					}
				}

				public class QueryNetList_DDoSDefense
				{

					private QueryNetList_DjPolicy djPolicy;

					private QueryNetList_CleanTh cleanTh;

					private QueryNetList_HoleTh holeTh;

					public QueryNetList_DjPolicy DjPolicy
					{
						get
						{
							return djPolicy;
						}
						set	
						{
							djPolicy = value;
						}
					}

					public QueryNetList_CleanTh CleanTh
					{
						get
						{
							return cleanTh;
						}
						set	
						{
							cleanTh = value;
						}
					}

					public QueryNetList_HoleTh HoleTh
					{
						get
						{
							return holeTh;
						}
						set	
						{
							holeTh = value;
						}
					}

					public class QueryNetList_DjPolicy
					{

						private string policyName;

						public string PolicyName
						{
							get
							{
								return policyName;
							}
							set	
							{
								policyName = value;
							}
						}
					}

					public class QueryNetList_CleanTh
					{

						private int? mbps;

						private int? pps;

						public int? Mbps
						{
							get
							{
								return mbps;
							}
							set	
							{
								mbps = value;
							}
						}

						public int? Pps
						{
							get
							{
								return pps;
							}
							set	
							{
								pps = value;
							}
						}
					}

					public class QueryNetList_HoleTh
					{

						private int? threshMbps;

						public int? ThreshMbps
						{
							get
							{
								return threshMbps;
							}
							set	
							{
								threshMbps = value;
							}
						}
					}
				}
			}
		}
	}
}
