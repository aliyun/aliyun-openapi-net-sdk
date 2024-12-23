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
	public class DescribeDirQuotasResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeDirQuotas_DirQuotaInfo> dirQuotaInfos;

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
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

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public List<DescribeDirQuotas_DirQuotaInfo> DirQuotaInfos
		{
			get
			{
				return dirQuotaInfos;
			}
			set	
			{
				dirQuotaInfos = value;
			}
		}

		public class DescribeDirQuotas_DirQuotaInfo
		{

			private string status;

			private string path;

			private string dirInode;

			private List<DescribeDirQuotas_UserQuotaInfo> userQuotaInfos;

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

			public string Path
			{
				get
				{
					return path;
				}
				set	
				{
					path = value;
				}
			}

			public string DirInode
			{
				get
				{
					return dirInode;
				}
				set	
				{
					dirInode = value;
				}
			}

			public List<DescribeDirQuotas_UserQuotaInfo> UserQuotaInfos
			{
				get
				{
					return userQuotaInfos;
				}
				set	
				{
					userQuotaInfos = value;
				}
			}

			public class DescribeDirQuotas_UserQuotaInfo
			{

				private long? fileCountReal;

				private string userType;

				private long? fileCountLimit;

				private string userId;

				private long? sizeLimit;

				private string quotaType;

				private long? sizeReal;

				private long? sizeRealInByte;

				public long? FileCountReal
				{
					get
					{
						return fileCountReal;
					}
					set	
					{
						fileCountReal = value;
					}
				}

				public string UserType
				{
					get
					{
						return userType;
					}
					set	
					{
						userType = value;
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

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

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

				public string QuotaType
				{
					get
					{
						return quotaType;
					}
					set	
					{
						quotaType = value;
					}
				}

				public long? SizeReal
				{
					get
					{
						return sizeReal;
					}
					set	
					{
						sizeReal = value;
					}
				}

				public long? SizeRealInByte
				{
					get
					{
						return sizeRealInByte;
					}
					set	
					{
						sizeRealInByte = value;
					}
				}
			}
		}
	}
}
