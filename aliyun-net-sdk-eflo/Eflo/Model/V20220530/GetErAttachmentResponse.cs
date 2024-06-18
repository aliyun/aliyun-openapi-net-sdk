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

namespace Aliyun.Acs.eflo.Model.V20220530
{
	public class GetErAttachmentResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private GetErAttachment_Content content;

		public int? Code
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

		public GetErAttachment_Content Content
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

		public class GetErAttachment_Content
		{

			private string createTime;

			private string gmtModified;

			private string message;

			private string status;

			private string regionId;

			private string tenantId;

			private string erAttachmentName;

			private string erAttachmentId;

			private string erId;

			private string instanceType;

			private string instanceId;

			private string instanceName;

			private bool? autoReceiveAllRoute;

			private bool? across;

			private string resourceTenantId;

			private string resourceGroupId;

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
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

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
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

			public string ErAttachmentName
			{
				get
				{
					return erAttachmentName;
				}
				set	
				{
					erAttachmentName = value;
				}
			}

			public string ErAttachmentId
			{
				get
				{
					return erAttachmentId;
				}
				set	
				{
					erAttachmentId = value;
				}
			}

			public string ErId
			{
				get
				{
					return erId;
				}
				set	
				{
					erId = value;
				}
			}

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
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

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public bool? AutoReceiveAllRoute
			{
				get
				{
					return autoReceiveAllRoute;
				}
				set	
				{
					autoReceiveAllRoute = value;
				}
			}

			public bool? Across
			{
				get
				{
					return across;
				}
				set	
				{
					across = value;
				}
			}

			public string ResourceTenantId
			{
				get
				{
					return resourceTenantId;
				}
				set	
				{
					resourceTenantId = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}
		}
	}
}
