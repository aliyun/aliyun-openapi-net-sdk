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
	public class GetDataCorrectOrderDetailResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private GetDataCorrectOrderDetail_DataCorrectOrderDetail dataCorrectOrderDetail;

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

		[JsonProperty(PropertyName = "DataCorrectOrderDetail")]
		public GetDataCorrectOrderDetail_DataCorrectOrderDetail DataCorrectOrderDetail
		{
			get
			{
				return dataCorrectOrderDetail;
			}
			set	
			{
				dataCorrectOrderDetail = value;
			}
		}

		public class GetDataCorrectOrderDetail_DataCorrectOrderDetail
		{

			private string status;

			private List<GetDataCorrectOrderDetail_TaskCheckDO> preCheckDetail;

			private List<GetDataCorrectOrderDetail_Database> databaseList;

			private GetDataCorrectOrderDetail_OrderDetail orderDetail;

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "PreCheckDetail")]
			public List<GetDataCorrectOrderDetail_TaskCheckDO> PreCheckDetail
			{
				get
				{
					return preCheckDetail;
				}
				set	
				{
					preCheckDetail = value;
				}
			}

			[JsonProperty(PropertyName = "DatabaseList")]
			public List<GetDataCorrectOrderDetail_Database> DatabaseList
			{
				get
				{
					return databaseList;
				}
				set	
				{
					databaseList = value;
				}
			}

			[JsonProperty(PropertyName = "OrderDetail")]
			public GetDataCorrectOrderDetail_OrderDetail OrderDetail
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

			public class GetDataCorrectOrderDetail_TaskCheckDO
			{

				private string userTip;

				private string checkStatus;

				private string checkStep;

				[JsonProperty(PropertyName = "UserTip")]
				public string UserTip
				{
					get
					{
						return userTip;
					}
					set	
					{
						userTip = value;
					}
				}

				[JsonProperty(PropertyName = "CheckStatus")]
				public string CheckStatus
				{
					get
					{
						return checkStatus;
					}
					set	
					{
						checkStatus = value;
					}
				}

				[JsonProperty(PropertyName = "CheckStep")]
				public string CheckStep
				{
					get
					{
						return checkStep;
					}
					set	
					{
						checkStep = value;
					}
				}
			}

			public class GetDataCorrectOrderDetail_Database
			{

				private int? dbId;

				private string dbType;

				private bool? logic;

				private string searchName;

				private string envType;

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

				[JsonProperty(PropertyName = "DbType")]
				public string DbType
				{
					get
					{
						return dbType;
					}
					set	
					{
						dbType = value;
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

				[JsonProperty(PropertyName = "SearchName")]
				public string SearchName
				{
					get
					{
						return searchName;
					}
					set	
					{
						searchName = value;
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

			public class GetDataCorrectOrderDetail_OrderDetail
			{

				private string rbSQL;

				private string rbAttachmentName;

				private string classify;

				private string exeSQL;

				private long? estimateAffectRows;

				private string rbSQLType;

				private long? actualAffectRows;

				private bool? ignoreAffectRows;

				private string attachmentName;

				private string sqlType;

				private string ignoreAffectRowsReason;

				[JsonProperty(PropertyName = "RbSQL")]
				public string RbSQL
				{
					get
					{
						return rbSQL;
					}
					set	
					{
						rbSQL = value;
					}
				}

				[JsonProperty(PropertyName = "RbAttachmentName")]
				public string RbAttachmentName
				{
					get
					{
						return rbAttachmentName;
					}
					set	
					{
						rbAttachmentName = value;
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

				[JsonProperty(PropertyName = "EstimateAffectRows")]
				public long? EstimateAffectRows
				{
					get
					{
						return estimateAffectRows;
					}
					set	
					{
						estimateAffectRows = value;
					}
				}

				[JsonProperty(PropertyName = "RbSQLType")]
				public string RbSQLType
				{
					get
					{
						return rbSQLType;
					}
					set	
					{
						rbSQLType = value;
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

				[JsonProperty(PropertyName = "AttachmentName")]
				public string AttachmentName
				{
					get
					{
						return attachmentName;
					}
					set	
					{
						attachmentName = value;
					}
				}

				[JsonProperty(PropertyName = "SqlType")]
				public string SqlType
				{
					get
					{
						return sqlType;
					}
					set	
					{
						sqlType = value;
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
			}
		}
	}
}
