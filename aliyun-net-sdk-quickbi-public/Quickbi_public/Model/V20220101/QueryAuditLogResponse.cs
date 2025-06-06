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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class QueryAuditLogResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<QueryAuditLog_LogApiResultModel> result;

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

		public List<QueryAuditLog_LogApiResultModel> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class QueryAuditLog_LogApiResultModel
		{

			private string gmtCreate;

			private string operatorAccountName;

			private string operatorName;

			private string operatorType;

			private string targetName;

			private string targetType;

			private string workspaceId;

			private string targetId;

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

			public string OperatorAccountName
			{
				get
				{
					return operatorAccountName;
				}
				set	
				{
					operatorAccountName = value;
				}
			}

			public string OperatorName
			{
				get
				{
					return operatorName;
				}
				set	
				{
					operatorName = value;
				}
			}

			public string OperatorType
			{
				get
				{
					return operatorType;
				}
				set	
				{
					operatorType = value;
				}
			}

			public string TargetName
			{
				get
				{
					return targetName;
				}
				set	
				{
					targetName = value;
				}
			}

			public string TargetType
			{
				get
				{
					return targetType;
				}
				set	
				{
					targetType = value;
				}
			}

			public string WorkspaceId
			{
				get
				{
					return workspaceId;
				}
				set	
				{
					workspaceId = value;
				}
			}

			public string TargetId
			{
				get
				{
					return targetId;
				}
				set	
				{
					targetId = value;
				}
			}
		}
	}
}
