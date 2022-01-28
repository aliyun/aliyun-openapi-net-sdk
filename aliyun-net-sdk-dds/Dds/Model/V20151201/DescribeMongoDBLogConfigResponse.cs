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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeMongoDBLogConfigResponse : AcsResponse
	{

		private string userProjectName;

		private string requestId;

		private int? isUserProjectLogstoreExist;

		private int? isEtlMetaExist;

		private string serviceType;

		private bool? enableAudit;

		private long? ttlForTrail;

		private long? usedStorageForTrail;

		private long? preserveStorageForTrail;

		private long? ttlForStandard;

		private long? usedStorageForStandard;

		private long? preserveStorageForStandard;

		public string UserProjectName
		{
			get
			{
				return userProjectName;
			}
			set	
			{
				userProjectName = value;
			}
		}

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

		public int? IsUserProjectLogstoreExist
		{
			get
			{
				return isUserProjectLogstoreExist;
			}
			set	
			{
				isUserProjectLogstoreExist = value;
			}
		}

		public int? IsEtlMetaExist
		{
			get
			{
				return isEtlMetaExist;
			}
			set	
			{
				isEtlMetaExist = value;
			}
		}

		public string ServiceType
		{
			get
			{
				return serviceType;
			}
			set	
			{
				serviceType = value;
			}
		}

		public bool? EnableAudit
		{
			get
			{
				return enableAudit;
			}
			set	
			{
				enableAudit = value;
			}
		}

		public long? TtlForTrail
		{
			get
			{
				return ttlForTrail;
			}
			set	
			{
				ttlForTrail = value;
			}
		}

		public long? UsedStorageForTrail
		{
			get
			{
				return usedStorageForTrail;
			}
			set	
			{
				usedStorageForTrail = value;
			}
		}

		public long? PreserveStorageForTrail
		{
			get
			{
				return preserveStorageForTrail;
			}
			set	
			{
				preserveStorageForTrail = value;
			}
		}

		public long? TtlForStandard
		{
			get
			{
				return ttlForStandard;
			}
			set	
			{
				ttlForStandard = value;
			}
		}

		public long? UsedStorageForStandard
		{
			get
			{
				return usedStorageForStandard;
			}
			set	
			{
				usedStorageForStandard = value;
			}
		}

		public long? PreserveStorageForStandard
		{
			get
			{
				return preserveStorageForStandard;
			}
			set	
			{
				preserveStorageForStandard = value;
			}
		}
	}
}
