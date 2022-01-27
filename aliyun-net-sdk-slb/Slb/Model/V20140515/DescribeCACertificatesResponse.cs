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

namespace Aliyun.Acs.Slb.Model.V20140515
{
	public class DescribeCACertificatesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeCACertificates_CACertificate> cACertificates;

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

		public List<DescribeCACertificates_CACertificate> CACertificates
		{
			get
			{
				return cACertificates;
			}
			set	
			{
				cACertificates = value;
			}
		}

		public class DescribeCACertificates_CACertificate
		{

			private string regionId;

			private string cACertificateId;

			private string cACertificateName;

			private string fingerprint;

			private string resourceGroupId;

			private string createTime;

			private long? createTimeStamp;

			private string expireTime;

			private long? expireTimeStamp;

			private string commonName;

			private string encryptionAlgorithm;

			private int? encryptionKeyLength;

			private string standardType;

			private List<DescribeCACertificates_Tag> tags;

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

			public string CACertificateId
			{
				get
				{
					return cACertificateId;
				}
				set	
				{
					cACertificateId = value;
				}
			}

			public string CACertificateName
			{
				get
				{
					return cACertificateName;
				}
				set	
				{
					cACertificateName = value;
				}
			}

			public string Fingerprint
			{
				get
				{
					return fingerprint;
				}
				set	
				{
					fingerprint = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
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

			public long? CreateTimeStamp
			{
				get
				{
					return createTimeStamp;
				}
				set	
				{
					createTimeStamp = value;
				}
			}

			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			public long? ExpireTimeStamp
			{
				get
				{
					return expireTimeStamp;
				}
				set	
				{
					expireTimeStamp = value;
				}
			}

			public string CommonName
			{
				get
				{
					return commonName;
				}
				set	
				{
					commonName = value;
				}
			}

			public string EncryptionAlgorithm
			{
				get
				{
					return encryptionAlgorithm;
				}
				set	
				{
					encryptionAlgorithm = value;
				}
			}

			public int? EncryptionKeyLength
			{
				get
				{
					return encryptionKeyLength;
				}
				set	
				{
					encryptionKeyLength = value;
				}
			}

			public string StandardType
			{
				get
				{
					return standardType;
				}
				set	
				{
					standardType = value;
				}
			}

			public List<DescribeCACertificates_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public class DescribeCACertificates_Tag
			{

				private string tagKey;

				private string tagValue;

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}
			}
		}
	}
}
