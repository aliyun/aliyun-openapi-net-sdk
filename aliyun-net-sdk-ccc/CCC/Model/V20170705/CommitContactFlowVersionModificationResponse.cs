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

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class CommitContactFlowVersionModificationResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private CommitContactFlowVersionModification_ContactFlowVersion contactFlowVersion;

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

		public CommitContactFlowVersionModification_ContactFlowVersion ContactFlowVersion
		{
			get
			{
				return contactFlowVersion;
			}
			set	
			{
				contactFlowVersion = value;
			}
		}

		public class CommitContactFlowVersionModification_ContactFlowVersion
		{

			private string contactFlowVersionId;

			private string version;

			private string contactFlowVersionDescription;

			private string canvas;

			private string content;

			private string lastModified;

			private string lastModifiedBy;

			private string lockedBy;

			private string status;

			public string ContactFlowVersionId
			{
				get
				{
					return contactFlowVersionId;
				}
				set	
				{
					contactFlowVersionId = value;
				}
			}

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public string ContactFlowVersionDescription
			{
				get
				{
					return contactFlowVersionDescription;
				}
				set	
				{
					contactFlowVersionDescription = value;
				}
			}

			public string Canvas
			{
				get
				{
					return canvas;
				}
				set	
				{
					canvas = value;
				}
			}

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public string LastModified
			{
				get
				{
					return lastModified;
				}
				set	
				{
					lastModified = value;
				}
			}

			public string LastModifiedBy
			{
				get
				{
					return lastModifiedBy;
				}
				set	
				{
					lastModifiedBy = value;
				}
			}

			public string LockedBy
			{
				get
				{
					return lockedBy;
				}
				set	
				{
					lockedBy = value;
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
		}
	}
}
