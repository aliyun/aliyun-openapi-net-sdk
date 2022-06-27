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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DeleteSnapshotFilesResponse : AcsResponse
	{

		private string requestId;

		private int? successCount;

		private int? failureCount;

		private List<DeleteSnapshotFiles_SnapshotDeleteInfo> snapshotDeleteInfoList;

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

		public int? SuccessCount
		{
			get
			{
				return successCount;
			}
			set	
			{
				successCount = value;
			}
		}

		public int? FailureCount
		{
			get
			{
				return failureCount;
			}
			set	
			{
				failureCount = value;
			}
		}

		public List<DeleteSnapshotFiles_SnapshotDeleteInfo> SnapshotDeleteInfoList
		{
			get
			{
				return snapshotDeleteInfoList;
			}
			set	
			{
				snapshotDeleteInfoList = value;
			}
		}

		public class DeleteSnapshotFiles_SnapshotDeleteInfo
		{

			private long? createTimestamp;

			private string message;

			public long? CreateTimestamp
			{
				get
				{
					return createTimestamp;
				}
				set	
				{
					createTimestamp = value;
				}
			}

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
		}
	}
}
