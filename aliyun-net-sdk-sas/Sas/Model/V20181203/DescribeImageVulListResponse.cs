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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeImageVulListResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeImageVulList_VulRecord> vulRecords;

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

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
			}
		}

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

		public List<DescribeImageVulList_VulRecord> VulRecords
		{
			get
			{
				return vulRecords;
			}
			set	
			{
				vulRecords = value;
			}
		}

		public class DescribeImageVulList_VulRecord
		{

			private long? primaryId;

			private string uuid;

			private string name;

			private string tag;

			private string aliasName;

			private string type;

			private string level;

			private long? firstTs;

			private long? lastTs;

			private int? status;

			private int? progress;

			private string necessity;

			private string related;

			private long? modifyTs;

			private string imageDigest;

			private bool? canUpdate;

			private List<string> layers;

			private DescribeImageVulList_ExtendContentJson extendContentJson;

			public long? PrimaryId
			{
				get
				{
					return primaryId;
				}
				set	
				{
					primaryId = value;
				}
			}

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}

			public string AliasName
			{
				get
				{
					return aliasName;
				}
				set	
				{
					aliasName = value;
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

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

			public long? FirstTs
			{
				get
				{
					return firstTs;
				}
				set	
				{
					firstTs = value;
				}
			}

			public long? LastTs
			{
				get
				{
					return lastTs;
				}
				set	
				{
					lastTs = value;
				}
			}

			public int? Status
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

			public int? Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}

			public string Necessity
			{
				get
				{
					return necessity;
				}
				set	
				{
					necessity = value;
				}
			}

			public string Related
			{
				get
				{
					return related;
				}
				set	
				{
					related = value;
				}
			}

			public long? ModifyTs
			{
				get
				{
					return modifyTs;
				}
				set	
				{
					modifyTs = value;
				}
			}

			public string ImageDigest
			{
				get
				{
					return imageDigest;
				}
				set	
				{
					imageDigest = value;
				}
			}

			public bool? CanUpdate
			{
				get
				{
					return canUpdate;
				}
				set	
				{
					canUpdate = value;
				}
			}

			public List<string> Layers
			{
				get
				{
					return layers;
				}
				set	
				{
					layers = value;
				}
			}

			public DescribeImageVulList_ExtendContentJson ExtendContentJson
			{
				get
				{
					return extendContentJson;
				}
				set	
				{
					extendContentJson = value;
				}
			}

			public class DescribeImageVulList_ExtendContentJson
			{

				private string os;

				private string osRelease;

				private List<DescribeImageVulList_RpmEntity> rpmEntityList;

				public string Os
				{
					get
					{
						return os;
					}
					set	
					{
						os = value;
					}
				}

				public string OsRelease
				{
					get
					{
						return osRelease;
					}
					set	
					{
						osRelease = value;
					}
				}

				public List<DescribeImageVulList_RpmEntity> RpmEntityList
				{
					get
					{
						return rpmEntityList;
					}
					set	
					{
						rpmEntityList = value;
					}
				}

				public class DescribeImageVulList_RpmEntity
				{

					private string fullVersion;

					private string matchDetail;

					private string name;

					private string path;

					private string updateCmd;

					private string version;

					private string layer;

					private string matchList;

					public string FullVersion
					{
						get
						{
							return fullVersion;
						}
						set	
						{
							fullVersion = value;
						}
					}

					public string MatchDetail
					{
						get
						{
							return matchDetail;
						}
						set	
						{
							matchDetail = value;
						}
					}

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
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

					public string UpdateCmd
					{
						get
						{
							return updateCmd;
						}
						set	
						{
							updateCmd = value;
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

					public string Layer
					{
						get
						{
							return layer;
						}
						set	
						{
							layer = value;
						}
					}

					public string MatchList
					{
						get
						{
							return matchList;
						}
						set	
						{
							matchList = value;
						}
					}
				}
			}
		}
	}
}
