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
	public class ListResourceShareAssociationsResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private List<ListResourceShareAssociations_ResourceShareAssociation> resourceShareAssociations;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
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

		public List<ListResourceShareAssociations_ResourceShareAssociation> ResourceShareAssociations
		{
			get
			{
				return resourceShareAssociations;
			}
			set	
			{
				resourceShareAssociations = value;
			}
		}

		public class ListResourceShareAssociations_ResourceShareAssociation
		{

			private string updateTime;

			private string entityId;

			private string resourceShareName;

			private string createTime;

			private string entityType;

			private string resourceShareId;

			private string associationStatusMessage;

			private string associationType;

			private string associationStatus;

			private bool? external;

			private string targetProperty;

			private List<ListResourceShareAssociations_AssociationFailedDetail> associationFailedDetails;

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public string EntityId
			{
				get
				{
					return entityId;
				}
				set	
				{
					entityId = value;
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

			public string EntityType
			{
				get
				{
					return entityType;
				}
				set	
				{
					entityType = value;
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

			public string AssociationStatusMessage
			{
				get
				{
					return associationStatusMessage;
				}
				set	
				{
					associationStatusMessage = value;
				}
			}

			public string AssociationType
			{
				get
				{
					return associationType;
				}
				set	
				{
					associationType = value;
				}
			}

			public string AssociationStatus
			{
				get
				{
					return associationStatus;
				}
				set	
				{
					associationStatus = value;
				}
			}

			public bool? External
			{
				get
				{
					return external;
				}
				set	
				{
					external = value;
				}
			}

			public string TargetProperty
			{
				get
				{
					return targetProperty;
				}
				set	
				{
					targetProperty = value;
				}
			}

			public List<ListResourceShareAssociations_AssociationFailedDetail> AssociationFailedDetails
			{
				get
				{
					return associationFailedDetails;
				}
				set	
				{
					associationFailedDetails = value;
				}
			}

			public class ListResourceShareAssociations_AssociationFailedDetail
			{

				private string status;

				private string statusMessage;

				private string associateType;

				private string entityId;

				private string entityType;

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

				public string EntityId
				{
					get
					{
						return entityId;
					}
					set	
					{
						entityId = value;
					}
				}

				public string EntityType
				{
					get
					{
						return entityType;
					}
					set	
					{
						entityType = value;
					}
				}
			}
		}
	}
}
