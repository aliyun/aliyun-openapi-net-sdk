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
	public class GetDataCorrectOrderDetailResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private GetDataCorrectOrderDetail_DataCorrectOrderDetail dataCorrectOrderDetail;

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

			private List<GetDataCorrectOrderDetail_TaskCheckDO> preCheckDetail;

			private List<GetDataCorrectOrderDetail_Database> databaseList;

			private GetDataCorrectOrderDetail_OrderDetail orderDetail;

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

				private string checkStatus;

				private string checkStep;

				private string userTip;

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
			}

			public class GetDataCorrectOrderDetail_Database
			{

				private string searchName;

				private string envType;

				private string dbType;

				private int? dbId;

				private bool? logic;

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

			public class GetDataCorrectOrderDetail_OrderDetail
			{

				private string classify;

				private long? estimateAffectRows;

				private long? actualAffectRows;

				private bool? ignoreAffectRows;

				private string ignoreAffectRowsReason;

				private string sqlType;

				private string exeSQL;

				private string attachmentName;

				private string rbSQLType;

				private string rbSQL;

				private string rbAttachmentName;

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
			}
		}
	}
}
