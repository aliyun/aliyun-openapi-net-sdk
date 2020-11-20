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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class ListDictInformationResponse : AcsResponse
	{

		private string requestId;

		private ListDictInformation_Result result;

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

		public ListDictInformation_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ListDictInformation_Result
		{

			private long? fileSize;

			private string type;

			private ListDictInformation_OssObject ossObject;

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

			public ListDictInformation_OssObject OssObject
			{
				get
				{
					return ossObject;
				}
				set	
				{
					ossObject = value;
				}
			}

			public class ListDictInformation_OssObject
			{

				private string bucketName;

				private string key;

				private string etag;

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

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string Etag
				{
					get
					{
						return etag;
					}
					set	
					{
						etag = value;
					}
				}
			}
		}
	}
}
