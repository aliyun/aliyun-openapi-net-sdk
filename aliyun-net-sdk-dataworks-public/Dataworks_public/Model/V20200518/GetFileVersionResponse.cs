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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class GetFileVersionResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorCode;

		private string errorMessage;

		private int? httpStatusCode;

		private GetFileVersion_Data data;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public GetFileVersion_Data Data
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

		public class GetFileVersion_Data
		{

			private int? fileVersion;

			private string fileContent;

			private string filePropertyContent;

			private string nodeContent;

			private string comment;

			private long? nodeId;

			private bool? isCurrentProd;

			private string changeType;

			private string status;

			private string fileName;

			private string commitUser;

			private long? commitTime;

			private string useType;

			public int? FileVersion
			{
				get
				{
					return fileVersion;
				}
				set	
				{
					fileVersion = value;
				}
			}

			public string FileContent
			{
				get
				{
					return fileContent;
				}
				set	
				{
					fileContent = value;
				}
			}

			public string FilePropertyContent
			{
				get
				{
					return filePropertyContent;
				}
				set	
				{
					filePropertyContent = value;
				}
			}

			public string NodeContent
			{
				get
				{
					return nodeContent;
				}
				set	
				{
					nodeContent = value;
				}
			}

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}

			public long? NodeId
			{
				get
				{
					return nodeId;
				}
				set	
				{
					nodeId = value;
				}
			}

			public bool? IsCurrentProd
			{
				get
				{
					return isCurrentProd;
				}
				set	
				{
					isCurrentProd = value;
				}
			}

			public string ChangeType
			{
				get
				{
					return changeType;
				}
				set	
				{
					changeType = value;
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

			public string FileName
			{
				get
				{
					return fileName;
				}
				set	
				{
					fileName = value;
				}
			}

			public string CommitUser
			{
				get
				{
					return commitUser;
				}
				set	
				{
					commitUser = value;
				}
			}

			public long? CommitTime
			{
				get
				{
					return commitTime;
				}
				set	
				{
					commitTime = value;
				}
			}

			public string UseType
			{
				get
				{
					return useType;
				}
				set	
				{
					useType = value;
				}
			}
		}
	}
}
