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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeFilesetsResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private string fileSystemId;

		private List<DescribeFilesets_Entrie> entries;

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

		public string FileSystemId
		{
			get
			{
				return fileSystemId;
			}
			set	
			{
				fileSystemId = value;
			}
		}

		public List<DescribeFilesets_Entrie> Entries
		{
			get
			{
				return entries;
			}
			set	
			{
				entries = value;
			}
		}

		public class DescribeFilesets_Entrie
		{

			private string description;

			private string fileSystemPath;

			private string fsetId;

			private string status;

			private string createTime;

			private string updateTime;

			private bool? deletionProtection;

			private long? fileCountUsage;

			private long? spaceUsage;

			private string fileSystemId;

			private DescribeFilesets_Quota quota;

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

			public string FileSystemPath
			{
				get
				{
					return fileSystemPath;
				}
				set	
				{
					fileSystemPath = value;
				}
			}

			public string FsetId
			{
				get
				{
					return fsetId;
				}
				set	
				{
					fsetId = value;
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

			public bool? DeletionProtection
			{
				get
				{
					return deletionProtection;
				}
				set	
				{
					deletionProtection = value;
				}
			}

			public long? FileCountUsage
			{
				get
				{
					return fileCountUsage;
				}
				set	
				{
					fileCountUsage = value;
				}
			}

			public long? SpaceUsage
			{
				get
				{
					return spaceUsage;
				}
				set	
				{
					spaceUsage = value;
				}
			}

			public string FileSystemId
			{
				get
				{
					return fileSystemId;
				}
				set	
				{
					fileSystemId = value;
				}
			}

			public DescribeFilesets_Quota Quota
			{
				get
				{
					return quota;
				}
				set	
				{
					quota = value;
				}
			}

			public class DescribeFilesets_Quota
			{

				private long? sizeLimit;

				private long? fileCountLimit;

				public long? SizeLimit
				{
					get
					{
						return sizeLimit;
					}
					set	
					{
						sizeLimit = value;
					}
				}

				public long? FileCountLimit
				{
					get
					{
						return fileCountLimit;
					}
					set	
					{
						fileCountLimit = value;
					}
				}
			}
		}
	}
}
