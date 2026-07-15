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

namespace Aliyun.Acs.schedulerx2.Model.V20190430
{
	public class ReadSchedulerxNotificationPolicyResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private int? code;

		private bool? success;

		private ReadSchedulerxNotificationPolicy_AccessDeniedDetail accessDeniedDetail;

		private ReadSchedulerxNotificationPolicy_Data data;

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

		public ReadSchedulerxNotificationPolicy_AccessDeniedDetail AccessDeniedDetail
		{
			get
			{
				return accessDeniedDetail;
			}
			set	
			{
				accessDeniedDetail = value;
			}
		}

		public ReadSchedulerxNotificationPolicy_Data Data
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

		public class ReadSchedulerxNotificationPolicy_AccessDeniedDetail
		{

			private string policyType;

			private string authPrincipalOwnerId;

			private string encodedDiagnosticMessage;

			private string authPrincipalType;

			private string authPrincipalDisplayName;

			private string noPermissionType;

			private string authAction;

			public string PolicyType
			{
				get
				{
					return policyType;
				}
				set	
				{
					policyType = value;
				}
			}

			public string AuthPrincipalOwnerId
			{
				get
				{
					return authPrincipalOwnerId;
				}
				set	
				{
					authPrincipalOwnerId = value;
				}
			}

			public string EncodedDiagnosticMessage
			{
				get
				{
					return encodedDiagnosticMessage;
				}
				set	
				{
					encodedDiagnosticMessage = value;
				}
			}

			public string AuthPrincipalType
			{
				get
				{
					return authPrincipalType;
				}
				set	
				{
					authPrincipalType = value;
				}
			}

			public string AuthPrincipalDisplayName
			{
				get
				{
					return authPrincipalDisplayName;
				}
				set	
				{
					authPrincipalDisplayName = value;
				}
			}

			public string NoPermissionType
			{
				get
				{
					return noPermissionType;
				}
				set	
				{
					noPermissionType = value;
				}
			}

			public string AuthAction
			{
				get
				{
					return authAction;
				}
				set	
				{
					authAction = value;
				}
			}
		}

		public class ReadSchedulerxNotificationPolicy_Data
		{

			private string nextToken;

			private long? total;

			private int? maxResults;

			private List<ReadSchedulerxNotificationPolicy_Record> records;

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

			public long? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public int? MaxResults
			{
				get
				{
					return maxResults;
				}
				set	
				{
					maxResults = value;
				}
			}

			public List<ReadSchedulerxNotificationPolicy_Record> Records
			{
				get
				{
					return records;
				}
				set	
				{
					records = value;
				}
			}

			public class ReadSchedulerxNotificationPolicy_Record
			{

				private string description;

				private string updater;

				private string policyName;

				private string createTime;

				private string updateTime;

				private string creator;

				private string channelTimeRange;

				private List<ReadSchedulerxNotificationPolicy_ReferencedApp> referenceApps;

				public string Description
				{
					get
					{
						return description;
					}
					set	
					{
						description = value;
					}
				}

				public string Updater
				{
					get
					{
						return updater;
					}
					set	
					{
						updater = value;
					}
				}

				public string PolicyName
				{
					get
					{
						return policyName;
					}
					set	
					{
						policyName = value;
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

				public string Creator
				{
					get
					{
						return creator;
					}
					set	
					{
						creator = value;
					}
				}

				public string ChannelTimeRange
				{
					get
					{
						return channelTimeRange;
					}
					set	
					{
						channelTimeRange = value;
					}
				}

				public List<ReadSchedulerxNotificationPolicy_ReferencedApp> ReferenceApps
				{
					get
					{
						return referenceApps;
					}
					set	
					{
						referenceApps = value;
					}
				}

				public class ReadSchedulerxNotificationPolicy_ReferencedApp
				{

					private string namespaceName;

					private string namespaceUid;

					private long? appGroupId;

					private string groupId;

					public string NamespaceName
					{
						get
						{
							return namespaceName;
						}
						set	
						{
							namespaceName = value;
						}
					}

					public string NamespaceUid
					{
						get
						{
							return namespaceUid;
						}
						set	
						{
							namespaceUid = value;
						}
					}

					public long? AppGroupId
					{
						get
						{
							return appGroupId;
						}
						set	
						{
							appGroupId = value;
						}
					}

					public string GroupId
					{
						get
						{
							return groupId;
						}
						set	
						{
							groupId = value;
						}
					}
				}
			}
		}
	}
}
