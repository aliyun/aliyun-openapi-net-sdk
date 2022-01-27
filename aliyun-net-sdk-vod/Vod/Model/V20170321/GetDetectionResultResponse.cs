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
	public class GetDetectionResultResponse : AcsResponse
	{

		private string requestId;

		private List<GetDetectionResult_DetectionResult> detectionResultList;

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

		public List<GetDetectionResult_DetectionResult> DetectionResultList
		{
			get
			{
				return detectionResultList;
			}
			set	
			{
				detectionResultList = value;
			}
		}

		public class GetDetectionResult_DetectionResult
		{

			private string status;

			private string platform;

			private string contentType;

			private string collectionTitle;

			private string collectionUrl;

			private string createTime;

			private string uploader;

			private string modifyTime;

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

			public string Platform
			{
				get
				{
					return platform;
				}
				set	
				{
					platform = value;
				}
			}

			public string ContentType
			{
				get
				{
					return contentType;
				}
				set	
				{
					contentType = value;
				}
			}

			public string CollectionTitle
			{
				get
				{
					return collectionTitle;
				}
				set	
				{
					collectionTitle = value;
				}
			}

			public string CollectionUrl
			{
				get
				{
					return collectionUrl;
				}
				set	
				{
					collectionUrl = value;
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

			public string Uploader
			{
				get
				{
					return uploader;
				}
				set	
				{
					uploader = value;
				}
			}

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}
		}
	}
}
