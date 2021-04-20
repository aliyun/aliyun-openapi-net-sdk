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
	public class CreateContactFlowResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private CreateContactFlow_ContactFlow contactFlow;

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

		public CreateContactFlow_ContactFlow ContactFlow
		{
			get
			{
				return contactFlow;
			}
			set	
			{
				contactFlow = value;
			}
		}

		public class CreateContactFlow_ContactFlow
		{

			private string contactFlowId;

			private string instanceId;

			private string contactFlowName;

			private string contactFlowDescription;

			private string type;

			private string appliedVersion;

			private List<CreateContactFlow_ContactFlowVersion> versions;

			private List<CreateContactFlow_PhoneNumber> phoneNumbers;

			public string ContactFlowId
			{
				get
				{
					return contactFlowId;
				}
				set	
				{
					contactFlowId = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string ContactFlowName
			{
				get
				{
					return contactFlowName;
				}
				set	
				{
					contactFlowName = value;
				}
			}

			public string ContactFlowDescription
			{
				get
				{
					return contactFlowDescription;
				}
				set	
				{
					contactFlowDescription = value;
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

			public string AppliedVersion
			{
				get
				{
					return appliedVersion;
				}
				set	
				{
					appliedVersion = value;
				}
			}

			public List<CreateContactFlow_ContactFlowVersion> Versions
			{
				get
				{
					return versions;
				}
				set	
				{
					versions = value;
				}
			}

			public List<CreateContactFlow_PhoneNumber> PhoneNumbers
			{
				get
				{
					return phoneNumbers;
				}
				set	
				{
					phoneNumbers = value;
				}
			}

			public class CreateContactFlow_ContactFlowVersion
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

			public class CreateContactFlow_PhoneNumber
			{

				private string phoneNumberId;

				private string instanceId;

				private string number;

				private string phoneNumberDescription;

				private bool? testOnly;

				private int? remainingTime;

				private bool? allowOutbound;

				private string usage;

				private int? trunks;

				public string PhoneNumberId
				{
					get
					{
						return phoneNumberId;
					}
					set	
					{
						phoneNumberId = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public string Number
				{
					get
					{
						return number;
					}
					set	
					{
						number = value;
					}
				}

				public string PhoneNumberDescription
				{
					get
					{
						return phoneNumberDescription;
					}
					set	
					{
						phoneNumberDescription = value;
					}
				}

				public bool? TestOnly
				{
					get
					{
						return testOnly;
					}
					set	
					{
						testOnly = value;
					}
				}

				public int? RemainingTime
				{
					get
					{
						return remainingTime;
					}
					set	
					{
						remainingTime = value;
					}
				}

				public bool? AllowOutbound
				{
					get
					{
						return allowOutbound;
					}
					set	
					{
						allowOutbound = value;
					}
				}

				public string Usage
				{
					get
					{
						return usage;
					}
					set	
					{
						usage = value;
					}
				}

				public int? Trunks
				{
					get
					{
						return trunks;
					}
					set	
					{
						trunks = value;
					}
				}
			}
		}
	}
}
