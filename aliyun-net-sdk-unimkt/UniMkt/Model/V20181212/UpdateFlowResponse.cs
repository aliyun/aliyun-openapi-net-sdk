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

namespace Aliyun.Acs.UniMkt.Model.V20181212
{
	public class UpdateFlowResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private string requestId;

		private UpdateFlow_Model model;

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

		public UpdateFlow_Model Model
		{
			get
			{
				return model;
			}
			set	
			{
				model = value;
			}
		}

		public class UpdateFlow_Model
		{

			private string flowId;

			private long? gmtCreateTime;

			private long? gmtModifiedTime;

			private string tenantId;

			private string extInfo;

			private string type;

			private string businessKey;

			private string reasonType;

			private string oldData;

			private string newData;

			private string status;

			private string childStatus;

			private string applyUserId;

			private string approveUserId;

			private long? approveTime;

			public string FlowId
			{
				get
				{
					return flowId;
				}
				set	
				{
					flowId = value;
				}
			}

			public long? GmtCreateTime
			{
				get
				{
					return gmtCreateTime;
				}
				set	
				{
					gmtCreateTime = value;
				}
			}

			public long? GmtModifiedTime
			{
				get
				{
					return gmtModifiedTime;
				}
				set	
				{
					gmtModifiedTime = value;
				}
			}

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public string ExtInfo
			{
				get
				{
					return extInfo;
				}
				set	
				{
					extInfo = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string BusinessKey
			{
				get
				{
					return businessKey;
				}
				set	
				{
					businessKey = value;
				}
			}

			public string ReasonType
			{
				get
				{
					return reasonType;
				}
				set	
				{
					reasonType = value;
				}
			}

			public string OldData
			{
				get
				{
					return oldData;
				}
				set	
				{
					oldData = value;
				}
			}

			public string NewData
			{
				get
				{
					return newData;
				}
				set	
				{
					newData = value;
				}
			}

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

			public string ChildStatus
			{
				get
				{
					return childStatus;
				}
				set	
				{
					childStatus = value;
				}
			}

			public string ApplyUserId
			{
				get
				{
					return applyUserId;
				}
				set	
				{
					applyUserId = value;
				}
			}

			public string ApproveUserId
			{
				get
				{
					return approveUserId;
				}
				set	
				{
					approveUserId = value;
				}
			}

			public long? ApproveTime
			{
				get
				{
					return approveTime;
				}
				set	
				{
					approveTime = value;
				}
			}
		}
	}
}
