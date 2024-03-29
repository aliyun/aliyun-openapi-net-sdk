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

namespace Aliyun.Acs.Actiontrail.Model.V20200706
{
	public class GetTrailStatusResponse : AcsResponse
	{

		private string requestId;

		private string startLoggingTime;

		private string latestDeliveryError;

		private string stopLoggingTime;

		private bool? isLogging;

		private string latestDeliveryTime;

		private string latestDeliveryLogServiceError;

		private string latestDeliveryLogServiceTime;

		private bool? ossBucketStatus;

		private bool? slsLogStoreStatus;

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

		public string StartLoggingTime
		{
			get
			{
				return startLoggingTime;
			}
			set	
			{
				startLoggingTime = value;
			}
		}

		public string LatestDeliveryError
		{
			get
			{
				return latestDeliveryError;
			}
			set	
			{
				latestDeliveryError = value;
			}
		}

		public string StopLoggingTime
		{
			get
			{
				return stopLoggingTime;
			}
			set	
			{
				stopLoggingTime = value;
			}
		}

		public bool? IsLogging
		{
			get
			{
				return isLogging;
			}
			set	
			{
				isLogging = value;
			}
		}

		public string LatestDeliveryTime
		{
			get
			{
				return latestDeliveryTime;
			}
			set	
			{
				latestDeliveryTime = value;
			}
		}

		public string LatestDeliveryLogServiceError
		{
			get
			{
				return latestDeliveryLogServiceError;
			}
			set	
			{
				latestDeliveryLogServiceError = value;
			}
		}

		public string LatestDeliveryLogServiceTime
		{
			get
			{
				return latestDeliveryLogServiceTime;
			}
			set	
			{
				latestDeliveryLogServiceTime = value;
			}
		}

		public bool? OssBucketStatus
		{
			get
			{
				return ossBucketStatus;
			}
			set	
			{
				ossBucketStatus = value;
			}
		}

		public bool? SlsLogStoreStatus
		{
			get
			{
				return slsLogStoreStatus;
			}
			set	
			{
				slsLogStoreStatus = value;
			}
		}
	}
}
