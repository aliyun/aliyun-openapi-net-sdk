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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class GetUserUploadFileJobResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private GetUserUploadFileJob_UploadFileJobDetail uploadFileJobDetail;

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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "ErrorMessage")]
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

		[JsonProperty(PropertyName = "ErrorCode")]
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

		[JsonProperty(PropertyName = "UploadFileJobDetail")]
		public GetUserUploadFileJob_UploadFileJobDetail UploadFileJobDetail
		{
			get
			{
				return uploadFileJobDetail;
			}
			set	
			{
				uploadFileJobDetail = value;
			}
		}

		public class GetUserUploadFileJob_UploadFileJobDetail
		{

			private string jobKey;

			private string fileName;

			private long? fileSize;

			private string fileSource;

			private string uploadType;

			private string uploadURL;

			private long? uploadedSize;

			private string jobStatus;

			private string jobStatusDesc;

			private string attachmentKey;

			private GetUserUploadFileJob_UploadOSSParam uploadOSSParam;

			[JsonProperty(PropertyName = "JobKey")]
			public string JobKey
			{
				get
				{
					return jobKey;
				}
				set	
				{
					jobKey = value;
				}
			}

			[JsonProperty(PropertyName = "FileName")]
			public string FileName
			{
				get
				{
					return fileName;
				}
				set	
				{
					fileName = value;
				}
			}

			[JsonProperty(PropertyName = "FileSize")]
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

			[JsonProperty(PropertyName = "FileSource")]
			public string FileSource
			{
				get
				{
					return fileSource;
				}
				set	
				{
					fileSource = value;
				}
			}

			[JsonProperty(PropertyName = "UploadType")]
			public string UploadType
			{
				get
				{
					return uploadType;
				}
				set	
				{
					uploadType = value;
				}
			}

			[JsonProperty(PropertyName = "UploadURL")]
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

			[JsonProperty(PropertyName = "UploadedSize")]
			public long? UploadedSize
			{
				get
				{
					return uploadedSize;
				}
				set	
				{
					uploadedSize = value;
				}
			}

			[JsonProperty(PropertyName = "JobStatus")]
			public string JobStatus
			{
				get
				{
					return jobStatus;
				}
				set	
				{
					jobStatus = value;
				}
			}

			[JsonProperty(PropertyName = "JobStatusDesc")]
			public string JobStatusDesc
			{
				get
				{
					return jobStatusDesc;
				}
				set	
				{
					jobStatusDesc = value;
				}
			}

			[JsonProperty(PropertyName = "AttachmentKey")]
			public string AttachmentKey
			{
				get
				{
					return attachmentKey;
				}
				set	
				{
					attachmentKey = value;
				}
			}

			[JsonProperty(PropertyName = "UploadOSSParam")]
			public GetUserUploadFileJob_UploadOSSParam UploadOSSParam
			{
				get
				{
					return uploadOSSParam;
				}
				set	
				{
					uploadOSSParam = value;
				}
			}

			public class GetUserUploadFileJob_UploadOSSParam
			{

				private string endpoint;

				private string bucketName;

				private string objectName;

				[JsonProperty(PropertyName = "Endpoint")]
				public string Endpoint
				{
					get
					{
						return endpoint;
					}
					set	
					{
						endpoint = value;
					}
				}

				[JsonProperty(PropertyName = "BucketName")]
				public string BucketName
				{
					get
					{
						return bucketName;
					}
					set	
					{
						bucketName = value;
					}
				}

				[JsonProperty(PropertyName = "ObjectName")]
				public string ObjectName
				{
					get
					{
						return objectName;
					}
					set	
					{
						objectName = value;
					}
				}
			}
		}
	}
}
