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

namespace Aliyun.Acs.DBFS.Model.V20200418
{
	public class GetSnapshotLinkResponse : AcsResponse
	{

		private string requestId;

		private GetSnapshotLink_Data data;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Data")]
		public GetSnapshotLink_Data Data
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

		public class GetSnapshotLink_Data
		{

			private string status;

			private long? totalSize;

			private int? sourceSize;

			private string fsId;

			private int? snapshotCount;

			private string fsName;

			private string linkId;

			private string category;

			private List<GetSnapshotLink_EcsListItem> ecsList;

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "TotalSize")]
			public long? TotalSize
			{
				get
				{
					return totalSize;
				}
				set	
				{
					totalSize = value;
				}
			}

			[JsonProperty(PropertyName = "SourceSize")]
			public int? SourceSize
			{
				get
				{
					return sourceSize;
				}
				set	
				{
					sourceSize = value;
				}
			}

			[JsonProperty(PropertyName = "FsId")]
			public string FsId
			{
				get
				{
					return fsId;
				}
				set	
				{
					fsId = value;
				}
			}

			[JsonProperty(PropertyName = "SnapshotCount")]
			public int? SnapshotCount
			{
				get
				{
					return snapshotCount;
				}
				set	
				{
					snapshotCount = value;
				}
			}

			[JsonProperty(PropertyName = "FsName")]
			public string FsName
			{
				get
				{
					return fsName;
				}
				set	
				{
					fsName = value;
				}
			}

			[JsonProperty(PropertyName = "LinkId")]
			public string LinkId
			{
				get
				{
					return linkId;
				}
				set	
				{
					linkId = value;
				}
			}

			[JsonProperty(PropertyName = "Category")]
			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			[JsonProperty(PropertyName = "EcsList")]
			public List<GetSnapshotLink_EcsListItem> EcsList
			{
				get
				{
					return ecsList;
				}
				set	
				{
					ecsList = value;
				}
			}

			public class GetSnapshotLink_EcsListItem
			{

				private string ecsId;

				[JsonProperty(PropertyName = "EcsId")]
				public string EcsId
				{
					get
					{
						return ecsId;
					}
					set	
					{
						ecsId = value;
					}
				}
			}
		}
	}
}
