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

namespace Aliyun.Acs.quotas.Model.V20200510
{
	public class GetQuotaUtilizationOverviewResponse : AcsResponse
	{

		private string status;

		private string message;

		private string requestId;

		private string generatedAt;

		private string errorMsg;

		private string errorCode;

		private bool? success;

		private GetQuotaUtilizationOverview_QuotaOverview quotaOverview;

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
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

		public string GeneratedAt
		{
			get
			{
				return generatedAt;
			}
			set	
			{
				generatedAt = value;
			}
		}

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public GetQuotaUtilizationOverview_QuotaOverview QuotaOverview
		{
			get
			{
				return quotaOverview;
			}
			set	
			{
				quotaOverview = value;
			}
		}

		public class GetQuotaUtilizationOverview_QuotaOverview
		{

			private GetQuotaUtilizationOverview_Over80Percent over80Percent;

			private GetQuotaUtilizationOverview_Over95Percent over95Percent;

			private GetQuotaUtilizationOverview_InUse inUse;

			public GetQuotaUtilizationOverview_Over80Percent Over80Percent
			{
				get
				{
					return over80Percent;
				}
				set	
				{
					over80Percent = value;
				}
			}

			public GetQuotaUtilizationOverview_Over95Percent Over95Percent
			{
				get
				{
					return over95Percent;
				}
				set	
				{
					over95Percent = value;
				}
			}

			public GetQuotaUtilizationOverview_InUse InUse
			{
				get
				{
					return inUse;
				}
				set	
				{
					inUse = value;
				}
			}

			public class GetQuotaUtilizationOverview_Over80Percent
			{

				private long? total;

				private double? adjustableRatio;

				private long? adjustable;

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

				public double? AdjustableRatio
				{
					get
					{
						return adjustableRatio;
					}
					set	
					{
						adjustableRatio = value;
					}
				}

				public long? Adjustable
				{
					get
					{
						return adjustable;
					}
					set	
					{
						adjustable = value;
					}
				}
			}

			public class GetQuotaUtilizationOverview_Over95Percent
			{

				private long? total;

				private double? adjustableRatio;

				private long? adjustable;

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

				public double? AdjustableRatio
				{
					get
					{
						return adjustableRatio;
					}
					set	
					{
						adjustableRatio = value;
					}
				}

				public long? Adjustable
				{
					get
					{
						return adjustable;
					}
					set	
					{
						adjustable = value;
					}
				}
			}

			public class GetQuotaUtilizationOverview_InUse
			{

				private long? total;

				private double? adjustableRatio;

				private long? adjustable;

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

				public double? AdjustableRatio
				{
					get
					{
						return adjustableRatio;
					}
					set	
					{
						adjustableRatio = value;
					}
				}

				public long? Adjustable
				{
					get
					{
						return adjustable;
					}
					set	
					{
						adjustable = value;
					}
				}
			}
		}
	}
}
