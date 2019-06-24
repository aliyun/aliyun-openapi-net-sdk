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
	public class GetUploadDetailsResponse : AcsResponse
	{

		private string requestId;

		private List<GetUploadDetails_UploadDetail> uploadDetails;

		private List<string> nonExistMediaIds;

		private List<string> forbiddenMediaIds;

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

		public List<GetUploadDetails_UploadDetail> UploadDetails
		{
			get
			{
				return uploadDetails;
			}
			set	
			{
				uploadDetails = value;
			}
		}

		public List<string> NonExistMediaIds
		{
			get
			{
				return nonExistMediaIds;
			}
			set	
			{
				nonExistMediaIds = value;
			}
		}

		public List<string> ForbiddenMediaIds
		{
			get
			{
				return forbiddenMediaIds;
			}
			set	
			{
				forbiddenMediaIds = value;
			}
		}

		public class GetUploadDetails_UploadDetail
		{

			private string mediaId;

			private string title;

			private long? fileSize;

			private string status;

			private string uploadStatus;

			private string creationTime;

			private string modificationTime;

			private string completionTime;

			private long? uploadSize;

			private float? uploadRatio;

			private string uploadIP;

			private string uploadSource;

			private string deviceModel;

			public string MediaId
			{
				get
				{
					return mediaId;
				}
				set	
				{
					mediaId = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public long? FileSize
			{
				get
				{
					return fileSize;
				}
				set	
				{
					fileSize = value;
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

			public string UploadStatus
			{
				get
				{
					return uploadStatus;
				}
				set	
				{
					uploadStatus = value;
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

			public string ModificationTime
			{
				get
				{
					return modificationTime;
				}
				set	
				{
					modificationTime = value;
				}
			}

			public string CompletionTime
			{
				get
				{
					return completionTime;
				}
				set	
				{
					completionTime = value;
				}
			}

			public long? UploadSize
			{
				get
				{
					return uploadSize;
				}
				set	
				{
					uploadSize = value;
				}
			}

			public float? UploadRatio
			{
				get
				{
					return uploadRatio;
				}
				set	
				{
					uploadRatio = value;
				}
			}

			public string UploadIP
			{
				get
				{
					return uploadIP;
				}
				set	
				{
					uploadIP = value;
				}
			}

			public string UploadSource
			{
				get
				{
					return uploadSource;
				}
				set	
				{
					uploadSource = value;
				}
			}

			public string DeviceModel
			{
				get
				{
					return deviceModel;
				}
				set	
				{
					deviceModel = value;
				}
			}
		}
	}
}
