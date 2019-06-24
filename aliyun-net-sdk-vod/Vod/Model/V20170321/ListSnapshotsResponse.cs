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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class ListSnapshotsResponse : AcsResponse
	{

		private string requestId;

		private ListSnapshots_MediaSnapshot mediaSnapshot;

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

		public ListSnapshots_MediaSnapshot MediaSnapshot
		{
			get
			{
				return mediaSnapshot;
			}
			set	
			{
				mediaSnapshot = value;
			}
		}

		public class ListSnapshots_MediaSnapshot
		{

			private long? total;

			private string regular;

			private string creationTime;

			private string jobId;

			private List<ListSnapshots_Snapshot> snapshots;

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

			public string Regular
			{
				get
				{
					return regular;
				}
				set	
				{
					regular = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public List<ListSnapshots_Snapshot> Snapshots
			{
				get
				{
					return snapshots;
				}
				set	
				{
					snapshots = value;
				}
			}

			public class ListSnapshots_Snapshot
			{

				private long? index;

				private string url;

				public long? Index
				{
					get
					{
						return index;
					}
					set	
					{
						index = value;
					}
				}

				public string Url
				{
					get
					{
						return url;
					}
					set	
					{
						url = value;
					}
				}
			}
		}
	}
}
