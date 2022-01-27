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

namespace Aliyun.Acs.Actiontrail.Model.V20200706
{
	public class UpdateTrailResponse : AcsResponse
	{

		private string slsProjectArn;

		private string eventRW;

		private string requestId;

		private string homeRegion;

		private string ossKeyPrefix;

		private string ossBucketName;

		private string slsWriteRoleArn;

		private string ossWriteRoleArn;

		private string trailRegion;

		private string name;

		public string SlsProjectArn
		{
			get
			{
				return slsProjectArn;
			}
			set	
			{
				slsProjectArn = value;
			}
		}

		public string EventRW
		{
			get
			{
				return eventRW;
			}
			set	
			{
				eventRW = value;
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

		public string HomeRegion
		{
			get
			{
				return homeRegion;
			}
			set	
			{
				homeRegion = value;
			}
		}

		public string OssKeyPrefix
		{
			get
			{
				return ossKeyPrefix;
			}
			set	
			{
				ossKeyPrefix = value;
			}
		}

		public string OssBucketName
		{
			get
			{
				return ossBucketName;
			}
			set	
			{
				ossBucketName = value;
			}
		}

		public string SlsWriteRoleArn
		{
			get
			{
				return slsWriteRoleArn;
			}
			set	
			{
				slsWriteRoleArn = value;
			}
		}

		public string OssWriteRoleArn
		{
			get
			{
				return ossWriteRoleArn;
			}
			set	
			{
				ossWriteRoleArn = value;
			}
		}

		public string TrailRegion
		{
			get
			{
				return trailRegion;
			}
			set	
			{
				trailRegion = value;
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
	}
}
