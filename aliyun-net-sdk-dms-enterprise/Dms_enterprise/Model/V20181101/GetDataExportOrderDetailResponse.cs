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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class GetDataExportOrderDetailResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private GetDataExportOrderDetail_DataExportOrderDetail dataExportOrderDetail;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "ErrorCode")]
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

		[JsonProperty(PropertyName = "ErrorMessage")]
		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "DataExportOrderDetail")]
		public GetDataExportOrderDetail_DataExportOrderDetail DataExportOrderDetail
		{
			get
			{
				return dataExportOrderDetail;
			}
			set	
			{
				dataExportOrderDetail = value;
			}
		}

		public class GetDataExportOrderDetail_DataExportOrderDetail
		{

			private GetDataExportOrderDetail_OrderDetail orderDetail;

			private GetDataExportOrderDetail_KeyInfo keyInfo;

			[JsonProperty(PropertyName = "OrderDetail")]
			public GetDataExportOrderDetail_OrderDetail OrderDetail
			{
				get
				{
					return orderDetail;
				}
				set	
				{
					orderDetail = value;
				}
			}

			[JsonProperty(PropertyName = "KeyInfo")]
			public GetDataExportOrderDetail_KeyInfo KeyInfo
			{
				get
				{
					return keyInfo;
				}
				set	
				{
					keyInfo = value;
				}
			}

			public class GetDataExportOrderDetail_OrderDetail
			{

				private bool? ignoreAffectRows;

				private string exeSQL;

				private string classify;

				private string ignoreAffectRowsReason;

				private string database;

				private int? dbId;

				private long? actualAffectRows;

				private bool? logic;

				private string envType;

				[JsonProperty(PropertyName = "IgnoreAffectRows")]
				public bool? IgnoreAffectRows
				{
					get
					{
						return ignoreAffectRows;
					}
					set	
					{
						ignoreAffectRows = value;
					}
				}

				[JsonProperty(PropertyName = "ExeSQL")]
				public string ExeSQL
				{
					get
					{
						return exeSQL;
					}
					set	
					{
						exeSQL = value;
					}
				}

				[JsonProperty(PropertyName = "Classify")]
				public string Classify
				{
					get
					{
						return classify;
					}
					set	
					{
						classify = value;
					}
				}

				[JsonProperty(PropertyName = "IgnoreAffectRowsReason")]
				public string IgnoreAffectRowsReason
				{
					get
					{
						return ignoreAffectRowsReason;
					}
					set	
					{
						ignoreAffectRowsReason = value;
					}
				}

				[JsonProperty(PropertyName = "Database")]
				public string Database
				{
					get
					{
						return database;
					}
					set	
					{
						database = value;
					}
				}

				[JsonProperty(PropertyName = "DbId")]
				public int? DbId
				{
					get
					{
						return dbId;
					}
					set	
					{
						dbId = value;
					}
				}

				[JsonProperty(PropertyName = "ActualAffectRows")]
				public long? ActualAffectRows
				{
					get
					{
						return actualAffectRows;
					}
					set	
					{
						actualAffectRows = value;
					}
				}

				[JsonProperty(PropertyName = "Logic")]
				public bool? Logic
				{
					get
					{
						return logic;
					}
					set	
					{
						logic = value;
					}
				}

				[JsonProperty(PropertyName = "EnvType")]
				public string EnvType
				{
					get
					{
						return envType;
					}
					set	
					{
						envType = value;
					}
				}
			}

			public class GetDataExportOrderDetail_KeyInfo
			{

				private string jobStatus;

				private long? preCheckId;

				[JsonProperty(PropertyName = "JobStatus")]
				public string JobStatus
				{
					get
					{
						return jobStatus;
					}
					set	
					{
						jobStatus = value;
					}
				}

				[JsonProperty(PropertyName = "PreCheckId")]
				public long? PreCheckId
				{
					get
					{
						return preCheckId;
					}
					set	
					{
						preCheckId = value;
					}
				}
			}
		}
	}
}
