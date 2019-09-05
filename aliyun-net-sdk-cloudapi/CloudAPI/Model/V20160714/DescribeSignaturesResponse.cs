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

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeSignaturesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeSignatures_SignatureInfo> signatureInfos;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public List<DescribeSignatures_SignatureInfo> SignatureInfos
		{
			get
			{
				return signatureInfos;
			}
			set	
			{
				signatureInfos = value;
			}
		}

		public class DescribeSignatures_SignatureInfo
		{

			private string regionId;

			private string signatureId;

			private string signatureName;

			private string signatureKey;

			private string signatureSecret;

			private string createdTime;

			private string modifiedTime;

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string SignatureId
			{
				get
				{
					return signatureId;
				}
				set	
				{
					signatureId = value;
				}
			}

			public string SignatureName
			{
				get
				{
					return signatureName;
				}
				set	
				{
					signatureName = value;
				}
			}

			public string SignatureKey
			{
				get
				{
					return signatureKey;
				}
				set	
				{
					signatureKey = value;
				}
			}

			public string SignatureSecret
			{
				get
				{
					return signatureSecret;
				}
				set	
				{
					signatureSecret = value;
				}
			}

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
				}
			}
		}
	}
}
