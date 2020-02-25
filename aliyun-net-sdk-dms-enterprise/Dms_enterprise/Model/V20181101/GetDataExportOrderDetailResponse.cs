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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class GetDataExportOrderDetailResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private GetDataExportOrderDetail_DataExportOrderDetail dataExportOrderDetail;

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

				private long? actualAffectRows;

				private string classify;

				private string database;

				private int? dbId;

				private string envType;

				private string exeSQL;

				private bool? ignoreAffectRows;

				private string ignoreAffectRowsReason;

				private bool? logic;

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
			}

			public class GetDataExportOrderDetail_KeyInfo
			{

				private string jobStatus;

				private long? preCheckId;

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
