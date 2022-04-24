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
	public class QueryRIUtilizationDetailResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryRIUtilizationDetail_Data data;

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

		public QueryRIUtilizationDetail_Data Data
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

		public class QueryRIUtilizationDetail_Data
		{

			private long? pageNum;

			private long? pageSize;

			private long? totalCount;

			private List<QueryRIUtilizationDetail_DetailListItem> detailList;

			public long? PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
				}
			}

			public long? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public long? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public List<QueryRIUtilizationDetail_DetailListItem> DetailList
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

			public class QueryRIUtilizationDetail_DetailListItem
			{

				private string deductedCommodityCode;

				private string deductedProductDetail;

				private string deductedInstanceId;

				private float? deductFactorTotal;

				private float? deductQuantity;

				private string deductHours;

				private string deductDate;

				private string rIInstanceId;

				private string instanceSpec;

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

				public string DeductHours
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

				public string RIInstanceId
				{
					get
					{
						return rIInstanceId;
					}
					set	
					{
						rIInstanceId = value;
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
			}
		}
	}
}
