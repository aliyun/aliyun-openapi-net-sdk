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

namespace Aliyun.Acs.vs.Model.V20181212
{
	public class ListObjectsResponse : AcsResponse
	{

		private string requestId;

		private string bucketName;

		private string prefix;

		private int? maxKeys;

		private int? keyCount;

		private string delimiter;

		private string encodingType;

		private bool? isTruncated;

		private string continuationToken;

		private string nextContinuationToken;

		private string marker;

		private string nextMarker;

		private List<ListObjects_Content> contents;

		private List<string> commonPrefixes;

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

		public string Prefix
		{
			get
			{
				return prefix;
			}
			set	
			{
				prefix = value;
			}
		}

		public int? MaxKeys
		{
			get
			{
				return maxKeys;
			}
			set	
			{
				maxKeys = value;
			}
		}

		public int? KeyCount
		{
			get
			{
				return keyCount;
			}
			set	
			{
				keyCount = value;
			}
		}

		public string Delimiter
		{
			get
			{
				return delimiter;
			}
			set	
			{
				delimiter = value;
			}
		}

		public string EncodingType
		{
			get
			{
				return encodingType;
			}
			set	
			{
				encodingType = value;
			}
		}

		public bool? IsTruncated
		{
			get
			{
				return isTruncated;
			}
			set	
			{
				isTruncated = value;
			}
		}

		public string ContinuationToken
		{
			get
			{
				return continuationToken;
			}
			set	
			{
				continuationToken = value;
			}
		}

		public string NextContinuationToken
		{
			get
			{
				return nextContinuationToken;
			}
			set	
			{
				nextContinuationToken = value;
			}
		}

		public string Marker
		{
			get
			{
				return marker;
			}
			set	
			{
				marker = value;
			}
		}

		public string NextMarker
		{
			get
			{
				return nextMarker;
			}
			set	
			{
				nextMarker = value;
			}
		}

		public List<ListObjects_Content> Contents
		{
			get
			{
				return contents;
			}
			set	
			{
				contents = value;
			}
		}

		public List<string> CommonPrefixes
		{
			get
			{
				return commonPrefixes;
			}
			set	
			{
				commonPrefixes = value;
			}
		}

		public class ListObjects_Content
		{

			private string key;

			private string lastModified;

			private string eTag;

			private long? size;

			private string storageClass;

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

			public string LastModified
			{
				get
				{
					return lastModified;
				}
				set	
				{
					lastModified = value;
				}
			}

			public string ETag
			{
				get
				{
					return eTag;
				}
				set	
				{
					eTag = value;
				}
			}

			public long? Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
				}
			}

			public string StorageClass
			{
				get
				{
					return storageClass;
				}
				set	
				{
					storageClass = value;
				}
			}
		}
	}
}
