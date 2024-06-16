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
	public class AssociateResourceShareResponse : AcsResponse
	{

		private string requestId;

		private List<AssociateResourceShare_ResourceShareAssociation> resourceShareAssociations;

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

		public List<AssociateResourceShare_ResourceShareAssociation> ResourceShareAssociations
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

		public class AssociateResourceShare_ResourceShareAssociation
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

			private string targetProperty;

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
		}
	}
}
