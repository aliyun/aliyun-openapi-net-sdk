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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeDiskReplicaPairsResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<DescribeDiskReplicaPairs_DiskReplicaPair> diskReplicaPairs;

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

		public List<DescribeDiskReplicaPairs_DiskReplicaPair> DiskReplicaPairs
		{
			get
			{
				return diskReplicaPairs;
			}
			set	
			{
				diskReplicaPairs = value;
			}
		}

		public class DescribeDiskReplicaPairs_DiskReplicaPair
		{

			private string replicaPairId;

			private string sourceRegion;

			private string sourceDiskId;

			private string destinationRegion;

			private string destinationDiskId;

			private string pairName;

			private string description;

			private string status;

			public string ReplicaPairId
			{
				get
				{
					return replicaPairId;
				}
				set	
				{
					replicaPairId = value;
				}
			}

			public string SourceRegion
			{
				get
				{
					return sourceRegion;
				}
				set	
				{
					sourceRegion = value;
				}
			}

			public string SourceDiskId
			{
				get
				{
					return sourceDiskId;
				}
				set	
				{
					sourceDiskId = value;
				}
			}

			public string DestinationRegion
			{
				get
				{
					return destinationRegion;
				}
				set	
				{
					destinationRegion = value;
				}
			}

			public string DestinationDiskId
			{
				get
				{
					return destinationDiskId;
				}
				set	
				{
					destinationDiskId = value;
				}
			}

			public string PairName
			{
				get
				{
					return pairName;
				}
				set	
				{
					pairName = value;
				}
			}

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
		}
	}
}
