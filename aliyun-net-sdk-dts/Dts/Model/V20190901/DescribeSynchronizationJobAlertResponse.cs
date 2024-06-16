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

namespace Aliyun.Acs.Dts.Model.V20190901
{
	public class DescribeSynchronizationJobAlertResponse : AcsResponse
	{

		private string synchronizationJobName;

		private string errorAlertStatus;

		private string errCode;

		private string success;

		private string errorAlertPhone;

		private string errMessage;

		private string delayAlertStatus;

		private string delayAlertPhone;

		private string delayOverSeconds;

		private string requestId;

		private string synchronizationJobId;

		private string synchronizationDirection;

		public string SynchronizationJobName
		{
			get
			{
				return synchronizationJobName;
			}
			set	
			{
				synchronizationJobName = value;
			}
		}

		public string ErrorAlertStatus
		{
			get
			{
				return errorAlertStatus;
			}
			set	
			{
				errorAlertStatus = value;
			}
		}

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

		public string Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string ErrorAlertPhone
		{
			get
			{
				return errorAlertPhone;
			}
			set	
			{
				errorAlertPhone = value;
			}
		}

		public string ErrMessage
		{
			get
			{
				return errMessage;
			}
			set	
			{
				errMessage = value;
			}
		}

		public string DelayAlertStatus
		{
			get
			{
				return delayAlertStatus;
			}
			set	
			{
				delayAlertStatus = value;
			}
		}

		public string DelayAlertPhone
		{
			get
			{
				return delayAlertPhone;
			}
			set	
			{
				delayAlertPhone = value;
			}
		}

		public string DelayOverSeconds
		{
			get
			{
				return delayOverSeconds;
			}
			set	
			{
				delayOverSeconds = value;
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

		public string SynchronizationJobId
		{
			get
			{
				return synchronizationJobId;
			}
			set	
			{
				synchronizationJobId = value;
			}
		}

		public string SynchronizationDirection
		{
			get
			{
				return synchronizationDirection;
			}
			set	
			{
				synchronizationDirection = value;
			}
		}
	}
}
