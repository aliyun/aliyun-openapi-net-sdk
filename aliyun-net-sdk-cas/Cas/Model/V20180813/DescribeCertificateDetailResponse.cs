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

namespace Aliyun.Acs.cas.Model.V20180813
{
	public class DescribeCertificateDetailResponse : AcsResponse
	{

		private string requestId;

		private long? id;

		private string sourceType;

		private string instanceId;

		private string name;

		private long? orderId;

		private int? year;

		private long? beforeDate;

		private long? afterDate;

		private string fingerPrint;

		private string domains;

		private string statusCode;

		private string brandName;

		private string certType;

		private int? remainingDays;

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

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
			}
		}

		public string SourceType
		{
			get
			{
				return sourceType;
			}
			set	
			{
				sourceType = value;
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}

		public long? OrderId
		{
			get
			{
				return orderId;
			}
			set	
			{
				orderId = value;
			}
		}

		public int? Year
		{
			get
			{
				return year;
			}
			set	
			{
				year = value;
			}
		}

		public long? BeforeDate
		{
			get
			{
				return beforeDate;
			}
			set	
			{
				beforeDate = value;
			}
		}

		public long? AfterDate
		{
			get
			{
				return afterDate;
			}
			set	
			{
				afterDate = value;
			}
		}

		public string FingerPrint
		{
			get
			{
				return fingerPrint;
			}
			set	
			{
				fingerPrint = value;
			}
		}

		public string Domains
		{
			get
			{
				return domains;
			}
			set	
			{
				domains = value;
			}
		}

		public string StatusCode
		{
			get
			{
				return statusCode;
			}
			set	
			{
				statusCode = value;
			}
		}

		public string BrandName
		{
			get
			{
				return brandName;
			}
			set	
			{
				brandName = value;
			}
		}

		public string CertType
		{
			get
			{
				return certType;
			}
			set	
			{
				certType = value;
			}
		}

		public int? RemainingDays
		{
			get
			{
				return remainingDays;
			}
			set	
			{
				remainingDays = value;
			}
		}
	}
}
