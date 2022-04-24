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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryDPUtilizationDetailResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryDPUtilizationDetail_Data data;

		public string Code
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public QueryDPUtilizationDetail_Data Data
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

		public class QueryDPUtilizationDetail_Data
		{

			private string nextToken;

			private List<QueryDPUtilizationDetail_DetailListItem> detailList;

			public string NextToken
			{
				get
				{
					return nextToken;
				}
				set	
				{
					nextToken = value;
				}
			}

			public List<QueryDPUtilizationDetail_DetailListItem> DetailList
			{
				get
				{
					return detailList;
				}
				set	
				{
					detailList = value;
				}
			}

			public class QueryDPUtilizationDetail_DetailListItem
			{

				private string deductedInstanceId;

				private string instanceId;

				private float? deductHours;

				private long? shareUid;

				private string deductDate;

				private string instanceSpec;

				private string deductedCommodityCode;

				private string deductedProductDetail;

				private float? deductMeasure;

				private string region;

				private float? deductQuantity;

				private float? deductFactorTotal;

				private string resCode;

				private long? uid;

				public string DeductedInstanceId
				{
					get
					{
						return deductedInstanceId;
					}
					set	
					{
						deductedInstanceId = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public float? DeductHours
				{
					get
					{
						return deductHours;
					}
					set	
					{
						deductHours = value;
					}
				}

				public long? ShareUid
				{
					get
					{
						return shareUid;
					}
					set	
					{
						shareUid = value;
					}
				}

				public string DeductDate
				{
					get
					{
						return deductDate;
					}
					set	
					{
						deductDate = value;
					}
				}

				public string InstanceSpec
				{
					get
					{
						return instanceSpec;
					}
					set	
					{
						instanceSpec = value;
					}
				}

				public string DeductedCommodityCode
				{
					get
					{
						return deductedCommodityCode;
					}
					set	
					{
						deductedCommodityCode = value;
					}
				}

				public string DeductedProductDetail
				{
					get
					{
						return deductedProductDetail;
					}
					set	
					{
						deductedProductDetail = value;
					}
				}

				public float? DeductMeasure
				{
					get
					{
						return deductMeasure;
					}
					set	
					{
						deductMeasure = value;
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

				public float? DeductQuantity
				{
					get
					{
						return deductQuantity;
					}
					set	
					{
						deductQuantity = value;
					}
				}

				public float? DeductFactorTotal
				{
					get
					{
						return deductFactorTotal;
					}
					set	
					{
						deductFactorTotal = value;
					}
				}

				public string ResCode
				{
					get
					{
						return resCode;
					}
					set	
					{
						resCode = value;
					}
				}

				public long? Uid
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
			}
		}
	}
}
