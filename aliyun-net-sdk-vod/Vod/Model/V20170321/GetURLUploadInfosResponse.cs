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
	public class GetURLUploadInfosResponse : AcsResponse
	{

		private string requestId;

		private List<GetURLUploadInfos_UrlUploadJobInfoDTO> uRLUploadInfoList;

		private List<string> nonExists;

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

		public List<GetURLUploadInfos_UrlUploadJobInfoDTO> URLUploadInfoList
		{
			get
			{
				return uRLUploadInfoList;
			}
			set	
			{
				uRLUploadInfoList = value;
			}
		}

		public List<string> NonExists
		{
			get
			{
				return nonExists;
			}
			set	
			{
				nonExists = value;
			}
		}

		public class GetURLUploadInfos_UrlUploadJobInfoDTO
		{

			private string jobId;

			private string uploadURL;

			private string mediaId;

			private string fileSize;

			private string status;

			private string userData;

			private string errorCode;

			private string errorMessage;

			private string creationTime;

			private string completeTime;

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

			public string UploadURL
			{
				get
				{
					return uploadURL;
				}
				set	
				{
					uploadURL = value;
				}
			}

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

			public string FileSize
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

			public string UserData
			{
				get
				{
					return userData;
				}
				set	
				{
					userData = value;
				}
			}

			public string ErrorCode
			{
				get
				{
					return errorCode;
				}
				set	
				{
					errorCode = value;
				}
			}

			public string ErrorMessage
			{
				get
				{
					return errorMessage;
				}
				set	
				{
					errorMessage = value;
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

			public string CompleteTime
			{
				get
				{
					return completeTime;
				}
				set	
				{
					completeTime = value;
				}
			}
		}
	}
}
