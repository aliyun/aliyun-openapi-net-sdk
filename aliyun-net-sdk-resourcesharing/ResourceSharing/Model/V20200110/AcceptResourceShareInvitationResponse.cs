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

namespace Aliyun.Acs.ResourceSharing.Model.V20200110
{
	public class AcceptResourceShareInvitationResponse : AcsResponse
	{

		private string requestId;

		private AcceptResourceShareInvitation_ResourceShareInvitation resourceShareInvitation;

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

		public AcceptResourceShareInvitation_ResourceShareInvitation ResourceShareInvitation
		{
			get
			{
				return resourceShareInvitation;
			}
			set	
			{
				resourceShareInvitation = value;
			}
		}

		public class AcceptResourceShareInvitation_ResourceShareInvitation
		{

			private string resourceShareInvitationId;

			private string resourceShareId;

			private string resourceShareName;

			private string senderAccountId;

			private string receiverAccountId;

			private string createTime;

			private string status;

			private List<AcceptResourceShareInvitation_AcceptInvitationFailedDetail> acceptInvitationFailedDetails;

			public string ResourceShareInvitationId
			{
				get
				{
					return resourceShareInvitationId;
				}
				set	
				{
					resourceShareInvitationId = value;
				}
			}

			public string ResourceShareId
			{
				get
				{
					return resourceShareId;
				}
				set	
				{
					resourceShareId = value;
				}
			}

			public string ResourceShareName
			{
				get
				{
					return resourceShareName;
				}
				set	
				{
					resourceShareName = value;
				}
			}

			public string SenderAccountId
			{
				get
				{
					return senderAccountId;
				}
				set	
				{
					senderAccountId = value;
				}
			}

			public string ReceiverAccountId
			{
				get
				{
					return receiverAccountId;
				}
				set	
				{
					receiverAccountId = value;
				}
			}

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

			public List<AcceptResourceShareInvitation_AcceptInvitationFailedDetail> AcceptInvitationFailedDetails
			{
				get
				{
					return acceptInvitationFailedDetails;
				}
				set	
				{
					acceptInvitationFailedDetails = value;
				}
			}

			public class AcceptResourceShareInvitation_AcceptInvitationFailedDetail
			{

				private string status;

				private string statusMessage;

				private string associateType;

				private string resourceId;

				private string resourceType;

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

				public string StatusMessage
				{
					get
					{
						return statusMessage;
					}
					set	
					{
						statusMessage = value;
					}
				}

				public string AssociateType
				{
					get
					{
						return associateType;
					}
					set	
					{
						associateType = value;
					}
				}

				public string ResourceId
				{
					get
					{
						return resourceId;
					}
					set	
					{
						resourceId = value;
					}
				}

				public string ResourceType
				{
					get
					{
						return resourceType;
					}
					set	
					{
						resourceType = value;
					}
				}
			}
		}
	}
}
