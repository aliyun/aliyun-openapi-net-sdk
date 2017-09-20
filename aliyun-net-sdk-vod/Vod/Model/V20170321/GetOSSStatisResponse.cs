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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetOSSStatisResponse : AcsResponse
	{

		private string requestId;

		private long? maxStorageUtilization;

		private List<GetOSSStatis_OSSMetric> ossStatisList;

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

		public long? MaxStorageUtilization
		{
			get
			{
				return maxStorageUtilization;
			}
			set	
			{
				maxStorageUtilization = value;
			}
		}

		public List<GetOSSStatis_OSSMetric> OssStatisList
		{
			get
			{
				return ossStatisList;
			}
			set	
			{
				ossStatisList = value;
			}
		}

		public class GetOSSStatis_OSSMetric
		{

			private string statTime;

			private long? storageUtilization;

			public string StatTime
			{
				get
				{
					return statTime;
				}
				set	
				{
					statTime = value;
				}
			}

			public long? StorageUtilization
			{
				get
				{
					return storageUtilization;
				}
				set	
				{
					storageUtilization = value;
				}
			}
		}
	}
}